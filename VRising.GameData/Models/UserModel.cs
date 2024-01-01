// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.UserModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM.Network;
using ProjectM.Shared;
using System.Diagnostics;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using VRising.GameData.Models.Base;

#nullable disable
namespace VRising.GameData.Models
{
  public class UserModel : EntityModel
  {
    internal UserModel(Entity entity)
      : base(entity)
    {
      User? user = this.Internals.User;
      ref User? local = ref user;
      this.Character = new CharacterModel((local.HasValue ? new Entity?(local.GetValueOrDefault().LocalCharacter._Entity) : new Entity?()).Value);
      this.Inventory = new InventoryModel(this.Character);
    }

    [field: DebuggerBrowsable]
    public InventoryModel Inventory { get; }

    [field: DebuggerBrowsable]
    public CharacterModel Character { get; }

    public string CharacterName
    {
      get
      {
        User? user = this.Internals.User;
        ref User? local = ref user;
        return !local.HasValue ? (string) null : local.GetValueOrDefault().CharacterName.ToString();
      }
    }

    public EquipmentModel Equipment => this.Character.Equipment;

    public FromCharacter FromCharacter
    {
      get
      {
        return new FromCharacter()
        {
          User = this.Entity,
          Character = this.Character.Entity
        };
      }
    }

    public bool IsAdmin
    {
      get
      {
        User? user = this.Internals.User;
        ref User? local = ref user;
        return local.HasValue && local.GetValueOrDefault().IsAdmin;
      }
    }

    public bool IsConnected
    {
      get
      {
        User? user = this.Internals.User;
        ref User? local = ref user;
        return local.HasValue && local.GetValueOrDefault().IsConnected;
      }
    }

    public ulong PlatformId
    {
      get
      {
        User? user = this.Internals.User;
        ref User? local = ref user;
        return !local.HasValue ? 0UL : local.GetValueOrDefault().PlatformId;
      }
    }

    public float3 Position
    {
      get
      {
        LocalToWorld? localToWorld = this.Internals.LocalToWorld;
        ref LocalToWorld? local = ref localToWorld;
        return !local.HasValue ? new float3() : local.GetValueOrDefault().Position;
      }
    }

    public UserContentFlags UserContent
    {
      get
      {
        User? user = this.Internals.User;
        ref User? local = ref user;
        return !local.HasValue ? UserContentFlags.None : local.GetValueOrDefault().UserContent;
      }
    }
  }
}
