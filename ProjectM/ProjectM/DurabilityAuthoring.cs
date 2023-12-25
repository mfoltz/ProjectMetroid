// Decompiled with JetBrains decompiler
// Type: ProjectM.DurabilityAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DurabilityAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityAssetSettings;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideDurabilityFromStatsAsset;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideMaxDurability;
    private static readonly IntPtr NativeFieldInfoPtr_RepairSequence;
    private static readonly IntPtr NativeFieldInfoPtr_LoseDurabilityOnDamageTaken;
    private static readonly IntPtr NativeFieldInfoPtr_TakeDamageDurabilityLossFactor;
    private static readonly IntPtr NativeFieldInfoPtr_LoseDurabilityOnDamageDealt;
    private static readonly IntPtr NativeFieldInfoPtr_DealDamageTypeModifiers;
    private static readonly IntPtr NativeFieldInfoPtr_LoseDurabilityOnSpellUse;
    private static readonly IntPtr NativeFieldInfoPtr_Factor_One_WeaponLevelBelow;
    private static readonly IntPtr NativeFieldInfoPtr_Factor_Two_WeaponLevelsBelow;
    private static readonly IntPtr NativeFieldInfoPtr_Factor_Three_WeaponLevelsBelow;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989374, XrefRangeEnd = 989419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DurabilityAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989419, XrefRangeEnd = 989423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DurabilityAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989423, XrefRangeEnd = 989424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DurabilityAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DurabilityAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DurabilityAuthoring()
    {
      Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DurabilityAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr);
      DurabilityAuthoring.NativeFieldInfoPtr_DurabilityAssetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (DurabilityAssetSettings));
      DurabilityAuthoring.NativeFieldInfoPtr_OverrideDurabilityFromStatsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (OverrideDurabilityFromStatsAsset));
      DurabilityAuthoring.NativeFieldInfoPtr_OverrideMaxDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (OverrideMaxDurability));
      DurabilityAuthoring.NativeFieldInfoPtr_RepairSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (RepairSequence));
      DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnDamageTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (LoseDurabilityOnDamageTaken));
      DurabilityAuthoring.NativeFieldInfoPtr_TakeDamageDurabilityLossFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (TakeDamageDurabilityLossFactor));
      DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnDamageDealt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (LoseDurabilityOnDamageDealt));
      DurabilityAuthoring.NativeFieldInfoPtr_DealDamageTypeModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (DealDamageTypeModifiers));
      DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnSpellUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (LoseDurabilityOnSpellUse));
      DurabilityAuthoring.NativeFieldInfoPtr_Factor_One_WeaponLevelBelow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (Factor_One_WeaponLevelBelow));
      DurabilityAuthoring.NativeFieldInfoPtr_Factor_Two_WeaponLevelsBelow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (Factor_Two_WeaponLevelsBelow));
      DurabilityAuthoring.NativeFieldInfoPtr_Factor_Three_WeaponLevelsBelow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, nameof (Factor_Three_WeaponLevelsBelow));
      DurabilityAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, 100676350);
      DurabilityAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, 100676351);
      DurabilityAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurabilityAuthoring>.NativeClassPtr, 100676352);
    }

    public DurabilityAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Item_DurabilitySettings_Asset DurabilityAssetSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_DurabilityAssetSettings));
        return pointer == IntPtr.Zero ? (Item_DurabilitySettings_Asset) null : new Item_DurabilitySettings_Asset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_DurabilityAssetSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool OverrideDurabilityFromStatsAsset
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_OverrideDurabilityFromStatsAsset));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_OverrideDurabilityFromStatsAsset)) = value;
      }
    }

    public unsafe float OverrideMaxDurability
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_OverrideMaxDurability));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_OverrideMaxDurability)) = value;
      }
    }

    public unsafe SequenceField RepairSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_RepairSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_RepairSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool LoseDurabilityOnDamageTaken
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnDamageTaken));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnDamageTaken)) = value;
      }
    }

    public unsafe float TakeDamageDurabilityLossFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_TakeDamageDurabilityLossFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_TakeDamageDurabilityLossFactor)) = value;
      }
    }

    public unsafe bool LoseDurabilityOnDamageDealt
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnDamageDealt));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnDamageDealt)) = value;
      }
    }

    public unsafe DurabilityDamageModifiers DealDamageTypeModifiers
    {
      get
      {
        return *(DurabilityDamageModifiers*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_DealDamageTypeModifiers));
      }
      [param: In] set
      {
        *(DurabilityDamageModifiers*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_DealDamageTypeModifiers)) = value;
      }
    }

    public unsafe bool LoseDurabilityOnSpellUse
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnSpellUse));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_LoseDurabilityOnSpellUse)) = value;
      }
    }

    public unsafe float Factor_One_WeaponLevelBelow
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_Factor_One_WeaponLevelBelow));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_Factor_One_WeaponLevelBelow)) = value;
      }
    }

    public unsafe float Factor_Two_WeaponLevelsBelow
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_Factor_Two_WeaponLevelsBelow));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_Factor_Two_WeaponLevelsBelow)) = value;
      }
    }

    public unsafe float Factor_Three_WeaponLevelsBelow
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_Factor_Three_WeaponLevelsBelow));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityAuthoring.NativeFieldInfoPtr_Factor_Three_WeaponLevelsBelow)) = value;
      }
    }
  }
}
