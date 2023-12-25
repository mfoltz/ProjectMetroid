// Decompiled with JetBrains decompiler
// Type: ProjectM.Script_BloodBuff_Rogue_MountDamageBonus
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class Script_BloodBuff_Rogue_MountDamageBonus : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MinMountDamageIncrease;
    private static readonly IntPtr NativeFieldInfoPtr_MaxMountDamageIncrease;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174463, XrefRangeEnd = 1174466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Rogue_MountDamageBonus.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174466, XrefRangeEnd = 1174470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_BloodBuff_Rogue_MountDamageBonus.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_BloodBuff_Rogue_MountDamageBonus()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Rogue_MountDamageBonus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_BloodBuff_Rogue_MountDamageBonus()
    {
      Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM", nameof (Script_BloodBuff_Rogue_MountDamageBonus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr);
      Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_MinMountDamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr, nameof (MinMountDamageIncrease));
      Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_MaxMountDamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr, nameof (MaxMountDamageIncrease));
      Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr, nameof (RequiredBloodPercentage));
      Script_BloodBuff_Rogue_MountDamageBonus.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr, 100663325);
      Script_BloodBuff_Rogue_MountDamageBonus.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr, 100663326);
      Script_BloodBuff_Rogue_MountDamageBonus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Rogue_MountDamageBonus>.NativeClassPtr, 100663327);
    }

    public Script_BloodBuff_Rogue_MountDamageBonus(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinMountDamageIncrease
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_MinMountDamageIncrease));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_MinMountDamageIncrease)) = value;
      }
    }

    public unsafe float MaxMountDamageIncrease
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_MaxMountDamageIncrease));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_MaxMountDamageIncrease)) = value;
      }
    }

    public unsafe float RequiredBloodPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_RequiredBloodPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Rogue_MountDamageBonus.NativeFieldInfoPtr_RequiredBloodPercentage)) = value;
      }
    }
  }
}
