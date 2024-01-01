// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Methods.UserModelMethods
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using ProjectM.CastleBuilding;
using ProjectM.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using VRising.GameData.Models;
using VRising.GameData.Models.Internals;
using VRising.GameData.Utils;

#nullable disable
namespace VRising.GameData.Methods
{
  public static class UserModelMethods
  {
    private static readonly PrefabGUID InCombatBuff = new PrefabGUID(581443919);
    private static readonly PrefabGUID InCombatPvPBuff = new PrefabGUID(697095869);

    public static void SendSystemMessage(this UserModel userModel, string message)
    {
      if (VRising.GameData.GameData.World.IsClientWorld())
        return;
      ServerChatUtils.SendSystemMessageToClient(VRising.GameData.GameData.World.EntityManager, userModel.Internals.User.Value, message);
    }

    public static unsafe bool TryGiveItem(
      this UserModel userModel,
      PrefabGUID itemGuid,
      int amount,
      out Entity itemEntity)
    {
      itemEntity = Entity.Null;
      if (VRising.GameData.GameData.World.IsClientWorld())
        return false;
      byte* numPtr = stackalloc byte[Marshal.SizeOf<FakeNull>()];
      System.IntPtr num = new System.IntPtr((void*) numPtr);
      Marshal.StructureToPtr<FakeNull>(new FakeNull()
      {
        value = 0,
        has_value = true
      }, num, false);
      Il2CppSystem.Nullable<int> nullable = new Il2CppSystem.Nullable<int>(System.IntPtr.Subtract(num, 16));
      AddItemSettings addItemSettings = AddItemSettings.Create(VRising.GameData.GameData.World.EntityManager, VRising.GameData.GameData.Systems.GameDataSystem.ItemHashLookupMap);
      User? user = userModel.Internals.User;
      ref User? local = ref user;
      Entity target = (local.HasValue ? new Entity?(local.GetValueOrDefault().LocalCharacter._Entity) : new Entity?()).Value;
      PrefabGUID itemType = itemGuid;
      int amount1 = amount;
      return (bool) InventoryUtilitiesServer.TryAddItem(addItemSettings, target, itemType, amount1);
    }

    public static void DropItemNearby(this UserModel userModel, PrefabGUID itemGuid, int amount)
    {
      if (VRising.GameData.GameData.World.IsClientWorld())
        return;
      InventoryUtilitiesServer.CreateDropItem(VRising.GameData.GameData.World.EntityManager, userModel.Entity, itemGuid, amount, new Entity());
    }

    public static void TeleportTo(this UserModel userModel, float3 position)
    {
      if (VRising.GameData.GameData.World.IsClientWorld())
        return;
      EntityManager entityManager = VRising.GameData.GameData.World.EntityManager;
      Entity entity = entityManager.CreateEntity(ComponentType.ReadWrite<FromCharacter>(), ComponentType.ReadWrite<PlayerTeleportDebugEvent>());
      entityManager = VRising.GameData.GameData.World.EntityManager;
      entityManager.SetComponentData<FromCharacter>(entity, userModel.FromCharacter);
      entityManager = VRising.GameData.GameData.World.EntityManager;
      entityManager.SetComponentData<PlayerTeleportDebugEvent>(entity, new PlayerTeleportDebugEvent()
      {
        Position = position,
        Target = PlayerTeleportDebugEvent.TeleportTarget.Self
      });
    }

    public static bool IsInCastle(this UserModel userModel)
    {
      EntityManager entityManager = VRising.GameData.GameData.World.EntityManager;
      foreach (BaseEntityModel baseEntityModel in entityManager.CreateEntityQuery(ComponentType.ReadOnly<PrefabGUID>(), ComponentType.ReadOnly<LocalToWorld>(), ComponentType.ReadOnly<UserOwner>(), ComponentType.ReadOnly<CastleFloor>()).ToEnumerable())
      {
        LocalToWorld? localToWorld = baseEntityModel.LocalToWorld;
        if (localToWorld.HasValue)
        {
          localToWorld = baseEntityModel.LocalToWorld;
          float3 position1 = localToWorld.Value.Position;
          float3 position2 = userModel.Position;
          if ((double) Math.Abs(position2.x - position1.x) < 3.0 && (double) Math.Abs(position2.z - position1.z) < 3.0)
            return true;
        }
      }
      return false;
    }

    public static bool IsInCombat(this UserModel userModel)
    {
      return BuffUtility.HasBuff(VRising.GameData.GameData.World.EntityManager, userModel.Character.Entity, UserModelMethods.InCombatBuff) || BuffUtility.HasBuff(VRising.GameData.GameData.World.EntityManager, userModel.Character.Entity, UserModelMethods.InCombatPvPBuff);
    }
  }
}
