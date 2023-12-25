// Decompiled with JetBrains decompiler
// Type: ProjectM.TechDataAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class TechDataAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_NameKey;
    private static readonly IntPtr NativeFieldInfoPtr_DescriptionKey;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideAbilitySource;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideHUDData;
    private static readonly IntPtr NativeFieldInfoPtr_DisplayAsGenericUnlock;
    private static readonly IntPtr NativeFieldInfoPtr_DoNotDisplaySubRewards;
    private static readonly IntPtr NativeFieldInfoPtr_UnlocksRecipes;
    private static readonly IntPtr NativeFieldInfoPtr_UnlockBlueprints;
    private static readonly IntPtr NativeFieldInfoPtr_UnlockAbilities;
    private static readonly IntPtr NativeFieldInfoPtr_UnlockShapeshift;
    private static readonly IntPtr NativeFieldInfoPtr_Cost;
    private static readonly IntPtr NativeFieldInfoPtr_SharedCost;
    private static readonly IntPtr NativeFieldInfoPtr_TechRequirements;
    private static readonly IntPtr NativeFieldInfoPtr_CraftDurationTimer;
    private static readonly IntPtr NativeFieldInfoPtr_NeverShowQuestionmarkResearch;
    private static readonly IntPtr NativeFieldInfoPtr_HudSortingOrder;
    private static readonly IntPtr NativeFieldInfoPtr_TechCateogry;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 993155, RefRangeEnd = 993157, XrefRangeStart = 993154, XrefRangeEnd = 993155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TechDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 993155, RefRangeEnd = 993157, XrefRangeStart = 993155, XrefRangeEnd = 993157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TechDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993157, XrefRangeEnd = 993305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TechDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TechDataAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TechDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TechDataAsset()
    {
      Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TechDataAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr);
      TechDataAsset.NativeFieldInfoPtr_NameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (NameKey));
      TechDataAsset.NativeFieldInfoPtr_DescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (DescriptionKey));
      TechDataAsset.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (Icon));
      TechDataAsset.NativeFieldInfoPtr_OverrideAbilitySource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (OverrideAbilitySource));
      TechDataAsset.NativeFieldInfoPtr_OverrideHUDData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (OverrideHUDData));
      TechDataAsset.NativeFieldInfoPtr_DisplayAsGenericUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (DisplayAsGenericUnlock));
      TechDataAsset.NativeFieldInfoPtr_DoNotDisplaySubRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (DoNotDisplaySubRewards));
      TechDataAsset.NativeFieldInfoPtr_UnlocksRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (UnlocksRecipes));
      TechDataAsset.NativeFieldInfoPtr_UnlockBlueprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (UnlockBlueprints));
      TechDataAsset.NativeFieldInfoPtr_UnlockAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (UnlockAbilities));
      TechDataAsset.NativeFieldInfoPtr_UnlockShapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (UnlockShapeshift));
      TechDataAsset.NativeFieldInfoPtr_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (Cost));
      TechDataAsset.NativeFieldInfoPtr_SharedCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (SharedCost));
      TechDataAsset.NativeFieldInfoPtr_TechRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (TechRequirements));
      TechDataAsset.NativeFieldInfoPtr_CraftDurationTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (CraftDurationTimer));
      TechDataAsset.NativeFieldInfoPtr_NeverShowQuestionmarkResearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (NeverShowQuestionmarkResearch));
      TechDataAsset.NativeFieldInfoPtr_HudSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (HudSortingOrder));
      TechDataAsset.NativeFieldInfoPtr_TechCateogry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (TechCateogry));
      TechDataAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, nameof (_Guid));
      TechDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, 100676696);
      TechDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, 100676697);
      TechDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, 100676698);
      TechDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechDataAsset>.NativeClassPtr, 100676699);
    }

    public TechDataAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey NameKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_NameKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_NameKey)) = value;
      }
    }

    public unsafe LocalizationKey DescriptionKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_DescriptionKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_DescriptionKey)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityGroupComponent OverrideAbilitySource
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_OverrideAbilitySource));
        return pointer == IntPtr.Zero ? (AbilityGroupComponent) null : new AbilityGroupComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_OverrideAbilitySource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool OverrideHUDData
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_OverrideHUDData));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_OverrideHUDData)) = value;
      }
    }

    public unsafe bool DisplayAsGenericUnlock
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_DisplayAsGenericUnlock));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_DisplayAsGenericUnlock)) = value;
      }
    }

    public unsafe bool DoNotDisplaySubRewards
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_DoNotDisplaySubRewards));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_DoNotDisplaySubRewards)) = value;
      }
    }

    public unsafe List<RecipeDataAsset> UnlocksRecipes
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_UnlocksRecipes));
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_UnlocksRecipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<BlueprintDataComponent>> UnlockBlueprints
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_UnlockBlueprints));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<BlueprintDataComponent>>) null : new List<WeakAssetReference<BlueprintDataComponent>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_UnlockBlueprints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<VBloodAbilityDataAuthoring>> UnlockAbilities
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_UnlockAbilities));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<VBloodAbilityDataAuthoring>>) null : new List<WeakAssetReference<VBloodAbilityDataAuthoring>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_UnlockAbilities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<VBloodShapeshiftDataAuthoring>> UnlockShapeshift
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_UnlockShapeshift));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<VBloodShapeshiftDataAuthoring>>) null : new List<WeakAssetReference<VBloodShapeshiftDataAuthoring>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_UnlockShapeshift), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemCost> Cost
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_Cost));
        return pointer == IntPtr.Zero ? (List<ItemCost>) null : new List<ItemCost>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_Cost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SharedItemRequirementAsset> SharedCost
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_SharedCost));
        return pointer == IntPtr.Zero ? (List<SharedItemRequirementAsset>) null : new List<SharedItemRequirementAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_SharedCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TechDataAsset> TechRequirements
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_TechRequirements));
        return pointer == IntPtr.Zero ? (List<TechDataAsset>) null : new List<TechDataAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_TechRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BasicTimerSettings CraftDurationTimer
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_CraftDurationTimer));
        return pointer == IntPtr.Zero ? (BasicTimerSettings) null : new BasicTimerSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_CraftDurationTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool NeverShowQuestionmarkResearch
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_NeverShowQuestionmarkResearch));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_NeverShowQuestionmarkResearch)) = value;
      }
    }

    public unsafe int HudSortingOrder
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_HudSortingOrder));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_HudSortingOrder)) = value;
      }
    }

    public unsafe TechCateogry TechCateogry
    {
      get
      {
        return *(TechCateogry*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_TechCateogry));
      }
      [param: In] set
      {
        *(TechCateogry*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr_TechCateogry)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TechDataAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
