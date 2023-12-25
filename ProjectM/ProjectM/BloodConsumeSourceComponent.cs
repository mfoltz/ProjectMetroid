// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodConsumeSourceComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Sequencer;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class BloodConsumeSourceComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UnitBloodType;
    private static readonly IntPtr NativeFieldInfoPtr_RandomizedBloodType;
    private static readonly IntPtr NativeFieldInfoPtr_BloodQualityUnitBuffs;
    private static readonly IntPtr NativeFieldInfoPtr_BloodQualitySetting;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideBloodCurve;
    private static readonly IntPtr NativeFieldInfoPtr_BloodQualityBuffRequirement;
    private static readonly IntPtr NativeFieldInfoPtr_FeedRadius;
    private static readonly IntPtr NativeFieldInfoPtr_VBloodAbilityRewards;
    private static readonly IntPtr NativeFieldInfoPtr_VBloodPassiveRewards;
    private static readonly IntPtr NativeFieldInfoPtr_VBloodShapeshiftRewards;
    private static readonly IntPtr NativeFieldInfoPtr_VBloodTechRewards;
    private static readonly IntPtr NativeFieldInfoPtr_JournalCategory;
    private static readonly IntPtr NativeFieldInfoPtr_JournalTooltip;
    private static readonly IntPtr NativeFieldInfoPtr_QuestFlavorTextOverride;
    private static readonly IntPtr NativeFieldInfoPtr_UnlockRewardSequence;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsVBlood_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool IsVBlood
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011185, XrefRangeEnd = 1011189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodConsumeSourceComponent.NativeMethodInfoPtr_get_IsVBlood_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(BloodConsumeSourceComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011189, XrefRangeEnd = 1011193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodConsumeSourceComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodConsumeSourceComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodConsumeSourceComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodConsumeSourceComponent()
    {
      Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodConsumeSourceComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr);
      BloodConsumeSourceComponent.NativeFieldInfoPtr_UnitBloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (UnitBloodType));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_RandomizedBloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (RandomizedBloodType));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualityUnitBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (BloodQualityUnitBuffs));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualitySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (BloodQualitySetting));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_OverrideBloodCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (OverrideBloodCurve));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualityBuffRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (BloodQualityBuffRequirement));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_FeedRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (FeedRadius));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodAbilityRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (VBloodAbilityRewards));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodPassiveRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (VBloodPassiveRewards));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodShapeshiftRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (VBloodShapeshiftRewards));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodTechRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (VBloodTechRewards));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_JournalCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (JournalCategory));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_JournalTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (JournalTooltip));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_QuestFlavorTextOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (QuestFlavorTextOverride));
      BloodConsumeSourceComponent.NativeFieldInfoPtr_UnlockRewardSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, nameof (UnlockRewardSequence));
      BloodConsumeSourceComponent.NativeMethodInfoPtr_get_IsVBlood_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, 100678676);
      BloodConsumeSourceComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, 100678677);
      BloodConsumeSourceComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, 100678678);
      BloodConsumeSourceComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodConsumeSourceComponent>.NativeClassPtr, 100678679);
    }

    public BloodConsumeSourceComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitBloodType UnitBloodType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_UnitBloodType));
        return pointer == IntPtr.Zero ? (UnitBloodType) null : new UnitBloodType(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_UnitBloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<UnitBloodType> RandomizedBloodType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_RandomizedBloodType));
        return pointer == IntPtr.Zero ? (List<UnitBloodType>) null : new List<UnitBloodType>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_RandomizedBloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<UnitBloodQualityBuff> BloodQualityUnitBuffs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualityUnitBuffs));
        return pointer == IntPtr.Zero ? (List<UnitBloodQualityBuff>) null : new List<UnitBloodQualityBuff>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualityUnitBuffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<BloodQualityCurveSettingsAsset> BloodQualitySetting
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualitySetting));
        return pointer == IntPtr.Zero ? (WeakAssetReference<BloodQualityCurveSettingsAsset>) null : new WeakAssetReference<BloodQualityCurveSettingsAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualitySetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveReference OverrideBloodCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_OverrideBloodCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_OverrideBloodCurve)) = value;
      }
    }

    public unsafe int BloodQualityBuffRequirement
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualityBuffRequirement));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_BloodQualityBuffRequirement)) = value;
      }
    }

    public unsafe float FeedRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_FeedRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_FeedRadius)) = value;
      }
    }

    public unsafe List<WeakAssetReference<VBloodAbilityDataAuthoring>> VBloodAbilityRewards
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodAbilityRewards));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<VBloodAbilityDataAuthoring>>) null : new List<WeakAssetReference<VBloodAbilityDataAuthoring>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodAbilityRewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<VBloodPassiveDataAuthoring>> VBloodPassiveRewards
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodPassiveRewards));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<VBloodPassiveDataAuthoring>>) null : new List<WeakAssetReference<VBloodPassiveDataAuthoring>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodPassiveRewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<VBloodShapeshiftDataAuthoring>> VBloodShapeshiftRewards
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodShapeshiftRewards));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<VBloodShapeshiftDataAuthoring>>) null : new List<WeakAssetReference<VBloodShapeshiftDataAuthoring>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodShapeshiftRewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<TechDataAsset>> VBloodTechRewards
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodTechRewards));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<TechDataAsset>>) null : new List<WeakAssetReference<TechDataAsset>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_VBloodTechRewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JournalCategoryType JournalCategory
    {
      get
      {
        return *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_JournalCategory));
      }
      [param: In] set
      {
        *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_JournalCategory)) = value;
      }
    }

    public unsafe JournalTooltipAsset JournalTooltip
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_JournalTooltip));
        return pointer == IntPtr.Zero ? (JournalTooltipAsset) null : new JournalTooltipAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_JournalTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey QuestFlavorTextOverride
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_QuestFlavorTextOverride));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_QuestFlavorTextOverride)) = value;
      }
    }

    public unsafe SequenceField UnlockRewardSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_UnlockRewardSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodConsumeSourceComponent.NativeFieldInfoPtr_UnlockRewardSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
