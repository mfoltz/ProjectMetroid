// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_BloodBuff_Warrior_PhysCritDamageBonus
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_BloodBuff_Warrior_PhysCritDamageBonus : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MinWeaponCriticalStrikeDamageIncrease;
    private static readonly IntPtr NativeFieldInfoPtr_MaxWeaponCriticalStrikeDamageIncrease;
    private static readonly IntPtr NativeFieldInfoPtr_WeaponCriticalStrikeDamageIncreaseModificationId;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181889, XrefRangeEnd = 1181892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_BloodBuff_Warrior_PhysCritDamageBonus()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_BloodBuff_Warrior_PhysCritDamageBonus()
    {
      Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_BloodBuff_Warrior_PhysCritDamageBonus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr);
      Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_MinWeaponCriticalStrikeDamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr, nameof (MinWeaponCriticalStrikeDamageIncrease));
      Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_MaxWeaponCriticalStrikeDamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr, nameof (MaxWeaponCriticalStrikeDamageIncrease));
      Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_WeaponCriticalStrikeDamageIncreaseModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr, nameof (WeaponCriticalStrikeDamageIncreaseModificationId));
      Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr, nameof (RequiredBloodPercentage));
      Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr, 100664072);
      Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr, 100664073);
    }

    public Script_BloodBuff_Warrior_PhysCritDamageBonus(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinWeaponCriticalStrikeDamageIncrease
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_MinWeaponCriticalStrikeDamageIncrease));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_MinWeaponCriticalStrikeDamageIncrease)) = value;
      }
    }

    public unsafe float MaxWeaponCriticalStrikeDamageIncrease
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_MaxWeaponCriticalStrikeDamageIncrease));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_MaxWeaponCriticalStrikeDamageIncrease)) = value;
      }
    }

    public unsafe ModificationId WeaponCriticalStrikeDamageIncreaseModificationId
    {
      get
      {
        return *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_WeaponCriticalStrikeDamageIncreaseModificationId));
      }
      [param: In] set
      {
        *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_WeaponCriticalStrikeDamageIncreaseModificationId)) = value;
      }
    }

    public unsafe float RequiredBloodPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_RequiredBloodPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Warrior_PhysCritDamageBonus.NativeFieldInfoPtr_RequiredBloodPercentage)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181834, XrefRangeEnd = 1181855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Warrior_PhysCritDamageBonus.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181855, XrefRangeEnd = 1181873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Warrior_PhysCritDamageBonus.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181873, XrefRangeEnd = 1181889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Warrior_PhysCritDamageBonus.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Warrior_PhysCritDamageBonus.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus.Server>.NativeClassPtr);
        Script_BloodBuff_Warrior_PhysCritDamageBonus.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus.Server>.NativeClassPtr, 100664074);
        Script_BloodBuff_Warrior_PhysCritDamageBonus.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus.Server>.NativeClassPtr, 100664075);
        Script_BloodBuff_Warrior_PhysCritDamageBonus.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus.Server>.NativeClassPtr, 100664076);
        Script_BloodBuff_Warrior_PhysCritDamageBonus.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Warrior_PhysCritDamageBonus.Server>.NativeClassPtr, 100664077);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
