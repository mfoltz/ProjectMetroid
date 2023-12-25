// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FakeTooltip
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class FakeTooltip : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipReforgeCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemUnlocks;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemSetBonuses;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemRepairCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeRequiredItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemSalvageItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityEffects;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelSpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponSpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentlyEquipped;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodPotion;
    private static readonly System.IntPtr NativeFieldInfoPtr_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_Repair;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorText;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdvancedTooltipText;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdvancedTooltipParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearlevelFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCategorySettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlueprintTypeLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevelRaritySettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Mana;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_SoulBound;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CraftingDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Stackable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Consumable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Memory;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Tech;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Placeable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_OrbOfKnowledge;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_VBloodEssence;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Salvageable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Bag;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Jewel;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_JewelTierX;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Dark;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShatteredInformationAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_InformationGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModTierCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIAssetSubSceneLoader;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedRecipeRequirements;
    private static readonly System.IntPtr NativeFieldInfoPtr__ItemCategoriesString;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__RootCanvasTransform;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeTooltip_Internal_Void_ComponentSystemBase_AdditionalTooltipSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPrivateData_Private_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_SpellModTierCollectionSystem_SpellModCollectionSystem_UI_CurveCollectionSystem_UIAssetSubSceneLoader_ClientWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_Sprite_LocalizationKey_String_String_String_Nullable_1_ItemSetInfo_Nullable_1_StatsInfo_Nullable_1_BloodBuffInfo_Boolean_Boolean_Nullable_1_ExtraItemInfo_Boolean_String_List_1_CostData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_PrefabGUID_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_String_String_List_1_CostData_Nullable_Unboxed_1_RecipeData_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Boolean_Nullable_1_ExtraItemInfo_Boolean_Boolean_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLegendaryItemSpellMod_Private_Void_Byte_SpellModSet_PrefabGUID_List_1_SpellModInfo_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTooltip_Internal_Boolean_GameDataSystem_Vector3_ItemCategorySettings_InventoryLocalizationKeys_PrefabGUID_ItemCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemTypeString_Private_String_ItemType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Private_Void_Vector3_List_1_CostData_Sprite_String_String_String_String_String_Nullable_Unboxed_1_ItemLevel_Nullable_1_ItemSetInfo_Nullable_1_StatsInfo_Nullable_1_UnlockInfo_Nullable_Unboxed_1_DurabilityInfo_Nullable_1_RepairCost_Nullable_1_BloodBuffInfo_Boolean_Boolean_Nullable_1_ExtraItemInfo_Boolean_List_1_SpellModInfo_List_1_SpellModInfo_Nullable_1_ShatteredItemRepairCostInfo_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionClampedWithinCanvas_Private_Static_Vector3_RectTransform_RectTransform_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionClampedWithinCanvas_Private_Static_Vector3_RectTransform_Rect_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableTooltip_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(39)]
    [CachedScanResults(RefRangeStart = 1251322, RefRangeEnd = 1251361, XrefRangeStart = 1251256, XrefRangeEnd = 1251322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeTooltip(
      ComponentSystemBase systemBase,
      AdditionalTooltipSetting additionalTooltipSetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalTooltipSetting;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_InitializeTooltip_Internal_Void_ComponentSystemBase_AdditionalTooltipSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1251374, RefRangeEnd = 1251376, XrefRangeStart = 1251361, XrefRangeEnd = 1251374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPrivateData(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      SpellModTierCollectionSystem spellModTierCollectionSystem,
      SpellModCollectionSystem_UI spellModCollectionSystem,
      CurveCollectionSystem curveCollectionSystem,
      UIAssetSubSceneLoader_ClientWorld uiAssetSubSceneLoader)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellModTierCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellModCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curveCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) uiAssetSubSceneLoader);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_SetPrivateData_Private_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_SpellModTierCollectionSystem_SpellModCollectionSystem_UI_CurveCollectionSystem_UIAssetSubSceneLoader_ClientWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAnchor(AnchorPreset anchorPreset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &anchorPreset;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1223182, RefRangeEnd = 1223190, XrefRangeStart = 1223182, XrefRangeEnd = 1223190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPivot(PivotPresets pivotPresets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pivotPresets;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(30)]
    [CachedScanResults(RefRangeStart = 1251380, RefRangeEnd = 1251410, XrefRangeStart = 1251376, XrefRangeEnd = 1251380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetTooltip(
      Vector3 position,
      Sprite icon,
      LocalizationKey text,
      string type,
      string desc = null,
      string subText = null,
      Il2CppSystem.Nullable<ItemSetInfo> itemSetInfo = null,
      Il2CppSystem.Nullable<StatsInfo> statsInfo = null,
      Il2CppSystem.Nullable<BloodBuffInfo> bloodBuffInfo = null,
      bool showAmount = true,
      bool showSalvageListHeader = false,
      Il2CppSystem.Nullable<ExtraItemInfo> extraItemInfo = null,
      bool isRelic = false,
      string errorText = null,
      List<CostData> requirements = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[15];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &text;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(desc);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) itemSetInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) statsInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) bloodBuffInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &showAmount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &showSalvageListHeader;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) extraItemInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &isRelic;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(errorText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requirements);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_Sprite_LocalizationKey_String_String_String_Nullable_1_ItemSetInfo_Nullable_1_StatsInfo_Nullable_1_BloodBuffInfo_Boolean_Boolean_Nullable_1_ExtraItemInfo_Boolean_String_List_1_CostData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(43)]
    [CachedScanResults(RefRangeStart = 1251843, RefRangeEnd = 1251886, XrefRangeStart = 1251410, XrefRangeEnd = 1251843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetTooltip(
      Vector3 position,
      PrefabGUID entry,
      Nullable_Unboxed<Entity> localPlayer = default (Nullable_Unboxed<Entity>),
      Nullable_Unboxed<Entity> entity = default (Nullable_Unboxed<Entity>),
      string subText = null,
      string errorText = null,
      List<CostData> requirements = null,
      Nullable_Unboxed<RecipeData> repairRecipeData = default (Nullable_Unboxed<RecipeData>),
      bool showAmount = true,
      Nullable_Unboxed<Entity> container = default (Nullable_Unboxed<Entity>),
      Nullable_Unboxed<Entity> localUser = default (Nullable_Unboxed<Entity>),
      bool showListHeader = false,
      Il2CppSystem.Nullable<ExtraItemInfo> extraItemInfo = null,
      bool showErrorIcon = false,
      bool skipJewelAbilityData = false,
      bool showCompare = true,
      float shatteredRepairCostsModifier = 1f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[17];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entry;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(errorText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requirements);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &repairRecipeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &showAmount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &container;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &showListHeader;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) extraItemInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &showErrorIcon;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = (System.IntPtr) &skipJewelAbilityData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(15) * sizeof (System.IntPtr))) = (System.IntPtr) &showCompare;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(16) * sizeof (System.IntPtr))) = (System.IntPtr) &shatteredRepairCostsModifier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_PrefabGUID_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_String_String_List_1_CostData_Nullable_Unboxed_1_RecipeData_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Boolean_Nullable_1_ExtraItemInfo_Boolean_Boolean_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1251942, RefRangeEnd = 1251944, XrefRangeStart = 1251886, XrefRangeEnd = 1251942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddLegendaryItemSpellMod(
      byte tierIndex,
      SpellModSet spellModSet,
      PrefabGUID abilityPrefabGuid,
      List<SpellModInfo> spellModInfos,
      bool showAdvancedData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &tierIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spellModSet;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellModInfos);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &showAdvancedData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_AddLegendaryItemSpellMod_Private_Void_Byte_SpellModSet_PrefabGUID_List_1_SpellModInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1251958, RefRangeEnd = 1251960, XrefRangeStart = 1251944, XrefRangeEnd = 1251958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetTooltip(
      GameDataSystem gameDataSystem,
      Vector3 position,
      ItemCategorySettings itemCategorySettings,
      InventoryLocalizationKeys localizationKeys,
      PrefabGUID restrictedType,
      ItemCategory restrictedItemCategory)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localizationKeys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictedType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictedItemCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_SetTooltip_Internal_Boolean_GameDataSystem_Vector3_ItemCategorySettings_InventoryLocalizationKeys_PrefabGUID_ItemCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251960, XrefRangeEnd = 1251970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetItemTypeString(ItemType itemType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemType;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_GetItemTypeString_Private_String_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1252162, RefRangeEnd = 1252165, XrefRangeStart = 1251970, XrefRangeEnd = 1252162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      Vector3 position,
      List<CostData> requirements,
      Sprite icon,
      string name,
      string type,
      string description = null,
      string subText = null,
      string errorText = null,
      Nullable_Unboxed<ItemLevel> itemLevel = default (Nullable_Unboxed<ItemLevel>),
      Il2CppSystem.Nullable<ItemSetInfo> itemSetInfo = null,
      Il2CppSystem.Nullable<StatsInfo> statsInfo = null,
      Il2CppSystem.Nullable<UnlockInfo> unlockInfo = null,
      Nullable_Unboxed<DurabilityInfo> durabilityInfo = default (Nullable_Unboxed<DurabilityInfo>),
      Il2CppSystem.Nullable<RepairCost> repairCost = null,
      Il2CppSystem.Nullable<BloodBuffInfo> bloodInfo = null,
      bool showAmount = true,
      bool showSalvageListHeader = false,
      Il2CppSystem.Nullable<ExtraItemInfo> extraItemInfo = null,
      bool isRelic = false,
      List<SpellModInfo> jewelSpellModInfos = null,
      List<SpellModInfo> weaponSpellModInfos = null,
      Il2CppSystem.Nullable<ShatteredItemRepairCostInfo> shatteredItemRepairCost = null,
      bool showErrorIcon = false,
      bool hasAdvancedData = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[24];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requirements);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(description);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(errorText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &itemLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) itemSetInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) statsInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) unlockInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &durabilityInfo;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) repairCost));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) bloodInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(15) * sizeof (System.IntPtr))) = (System.IntPtr) &showAmount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(16) * sizeof (System.IntPtr))) = (System.IntPtr) &showSalvageListHeader;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(17) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) extraItemInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(18) * sizeof (System.IntPtr))) = (System.IntPtr) &isRelic;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(19) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jewelSpellModInfos);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(20) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) weaponSpellModInfos);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(21) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) shatteredItemRepairCost));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(22) * sizeof (System.IntPtr))) = (System.IntPtr) &showErrorIcon;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(23) * sizeof (System.IntPtr))) = (System.IntPtr) &hasAdvancedData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_SetData_Private_Void_Vector3_List_1_CostData_Sprite_String_String_String_String_String_Nullable_Unboxed_1_ItemLevel_Nullable_1_ItemSetInfo_Nullable_1_StatsInfo_Nullable_1_UnlockInfo_Nullable_Unboxed_1_DurabilityInfo_Nullable_1_RepairCost_Nullable_1_BloodBuffInfo_Boolean_Boolean_Nullable_1_ExtraItemInfo_Boolean_List_1_SpellModInfo_List_1_SpellModInfo_Nullable_1_ShatteredItemRepairCostInfo_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252165, XrefRangeEnd = 1252172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTooltipPosition(Vector3 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1252185, RefRangeEnd = 1252186, XrefRangeStart = 1252172, XrefRangeEnd = 1252185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector3 GetPositionClampedWithinCanvas(
      RectTransform canvas,
      RectTransform rectTransform,
      Vector3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_GetPositionClampedWithinCanvas_Private_Static_Vector3_RectTransform_RectTransform_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252186, XrefRangeEnd = 1252198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector3 GetPositionClampedWithinCanvas(
      RectTransform canvas,
      UnityEngine.Rect rect,
      Vector3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rect;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_GetPositionClampedWithinCanvas_Private_Static_Vector3_RectTransform_Rect_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 1222138, RefRangeEnd = 1222167, XrefRangeStart = 1222138, XrefRangeEnd = 1222167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableTooltip()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr_DisableTooltip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FakeTooltip()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FakeTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FakeTooltip()
    {
      Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (FakeTooltip));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr);
      FakeTooltip.NativeFieldInfoPtr_TooltipPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (TooltipPrefab));
      FakeTooltip.NativeFieldInfoPtr_TooltipHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (TooltipHeader));
      FakeTooltip.NativeFieldInfoPtr_TooltipReforgeCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (TooltipReforgeCost));
      FakeTooltip.NativeFieldInfoPtr_ItemStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ItemStats));
      FakeTooltip.NativeFieldInfoPtr_ItemUnlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ItemUnlocks));
      FakeTooltip.NativeFieldInfoPtr_SetItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (SetItems));
      FakeTooltip.NativeFieldInfoPtr_ItemSetBonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ItemSetBonuses));
      FakeTooltip.NativeFieldInfoPtr_ItemRepairCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ItemRepairCost));
      FakeTooltip.NativeFieldInfoPtr_RecipeRequiredItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (RecipeRequiredItems));
      FakeTooltip.NativeFieldInfoPtr_ItemSalvageItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ItemSalvageItems));
      FakeTooltip.NativeFieldInfoPtr_BloodQualityEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (BloodQualityEffects));
      FakeTooltip.NativeFieldInfoPtr_JewelSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (JewelSpellMods));
      FakeTooltip.NativeFieldInfoPtr_WeaponSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (WeaponSpellMods));
      FakeTooltip.NativeFieldInfoPtr_CurrentlyEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (CurrentlyEquipped));
      FakeTooltip.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (Description));
      FakeTooltip.NativeFieldInfoPtr_DescriptionFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (DescriptionFrame));
      FakeTooltip.NativeFieldInfoPtr_BloodPotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (BloodPotion));
      FakeTooltip.NativeFieldInfoPtr_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (Durability));
      FakeTooltip.NativeFieldInfoPtr_Repair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (Repair));
      FakeTooltip.NativeFieldInfoPtr_SubText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (SubText));
      FakeTooltip.NativeFieldInfoPtr_ErrorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ErrorText));
      FakeTooltip.NativeFieldInfoPtr_AdvancedTooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (AdvancedTooltipText));
      FakeTooltip.NativeFieldInfoPtr_AdvancedTooltipParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (AdvancedTooltipParent));
      FakeTooltip.NativeFieldInfoPtr_GearlevelFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (GearlevelFrame));
      FakeTooltip.NativeFieldInfoPtr_ItemCategorySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ItemCategorySettings));
      FakeTooltip.NativeFieldInfoPtr_BlueprintTypeLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (BlueprintTypeLocalizationKeys));
      FakeTooltip.NativeFieldInfoPtr_ItemLevelRaritySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ItemLevelRaritySettings));
      FakeTooltip.NativeFieldInfoPtr_LKey_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Durability));
      FakeTooltip.NativeFieldInfoPtr_LKey_Mana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Mana));
      FakeTooltip.NativeFieldInfoPtr_LKey_SoulBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_SoulBound));
      FakeTooltip.NativeFieldInfoPtr_LKey_CraftingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_CraftingDuration));
      FakeTooltip.NativeFieldInfoPtr_LKey_Stackable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Stackable));
      FakeTooltip.NativeFieldInfoPtr_LKey_Consumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Consumable));
      FakeTooltip.NativeFieldInfoPtr_LKey_Memory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Memory));
      FakeTooltip.NativeFieldInfoPtr_LKey_Tech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Tech));
      FakeTooltip.NativeFieldInfoPtr_LKey_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Equippable));
      FakeTooltip.NativeFieldInfoPtr_LKey_Placeable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Placeable));
      FakeTooltip.NativeFieldInfoPtr_LKey_OrbOfKnowledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_OrbOfKnowledge));
      FakeTooltip.NativeFieldInfoPtr_LKey_VBloodEssence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_VBloodEssence));
      FakeTooltip.NativeFieldInfoPtr_LKey_Salvageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Salvageable));
      FakeTooltip.NativeFieldInfoPtr_LKey_Bag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Bag));
      FakeTooltip.NativeFieldInfoPtr_LKey_Jewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_Jewel));
      FakeTooltip.NativeFieldInfoPtr_LKey_JewelTierX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (LKey_JewelTierX));
      FakeTooltip.NativeFieldInfoPtr_TextColor_Dark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (TextColor_Dark));
      FakeTooltip.NativeFieldInfoPtr_TextColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (TextColor_Normal));
      FakeTooltip.NativeFieldInfoPtr_TextColor_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (TextColor_Durability));
      FakeTooltip.NativeFieldInfoPtr_ShatteredInformationAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (ShatteredInformationAlpha));
      FakeTooltip.NativeFieldInfoPtr_InformationGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (InformationGroup));
      FakeTooltip.NativeFieldInfoPtr__AdditionalTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_AdditionalTooltip));
      FakeTooltip.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_GameDataSystem));
      FakeTooltip.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      FakeTooltip.NativeFieldInfoPtr__SpellModCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_SpellModCollectionSystem));
      FakeTooltip.NativeFieldInfoPtr__SpellModTierCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_SpellModTierCollectionSystem));
      FakeTooltip.NativeFieldInfoPtr__UIAssetSubSceneLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_UIAssetSubSceneLoader));
      FakeTooltip.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_CurveCollectionSystem));
      FakeTooltip.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_EntityManager));
      FakeTooltip.NativeFieldInfoPtr__CachedRecipeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_CachedRecipeRequirements));
      FakeTooltip.NativeFieldInfoPtr__ItemCategoriesString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_ItemCategoriesString));
      FakeTooltip.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_Initialized));
      FakeTooltip.NativeFieldInfoPtr__RootCanvasTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, nameof (_RootCanvasTransform));
      FakeTooltip.NativeMethodInfoPtr_InitializeTooltip_Internal_Void_ComponentSystemBase_AdditionalTooltipSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666662);
      FakeTooltip.NativeMethodInfoPtr_SetPrivateData_Private_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_SpellModTierCollectionSystem_SpellModCollectionSystem_UI_CurveCollectionSystem_UIAssetSubSceneLoader_ClientWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666663);
      FakeTooltip.NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666664);
      FakeTooltip.NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666665);
      FakeTooltip.NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_Sprite_LocalizationKey_String_String_String_Nullable_1_ItemSetInfo_Nullable_1_StatsInfo_Nullable_1_BloodBuffInfo_Boolean_Boolean_Nullable_1_ExtraItemInfo_Boolean_String_List_1_CostData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666666);
      FakeTooltip.NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_PrefabGUID_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_String_String_List_1_CostData_Nullable_Unboxed_1_RecipeData_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Boolean_Nullable_1_ExtraItemInfo_Boolean_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666667);
      FakeTooltip.NativeMethodInfoPtr_AddLegendaryItemSpellMod_Private_Void_Byte_SpellModSet_PrefabGUID_List_1_SpellModInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666668);
      FakeTooltip.NativeMethodInfoPtr_SetTooltip_Internal_Boolean_GameDataSystem_Vector3_ItemCategorySettings_InventoryLocalizationKeys_PrefabGUID_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666669);
      FakeTooltip.NativeMethodInfoPtr_GetItemTypeString_Private_String_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666670);
      FakeTooltip.NativeMethodInfoPtr_SetData_Private_Void_Vector3_List_1_CostData_Sprite_String_String_String_String_String_Nullable_Unboxed_1_ItemLevel_Nullable_1_ItemSetInfo_Nullable_1_StatsInfo_Nullable_1_UnlockInfo_Nullable_Unboxed_1_DurabilityInfo_Nullable_1_RepairCost_Nullable_1_BloodBuffInfo_Boolean_Boolean_Nullable_1_ExtraItemInfo_Boolean_List_1_SpellModInfo_List_1_SpellModInfo_Nullable_1_ShatteredItemRepairCostInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666671);
      FakeTooltip.NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666672);
      FakeTooltip.NativeMethodInfoPtr_GetPositionClampedWithinCanvas_Private_Static_Vector3_RectTransform_RectTransform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666673);
      FakeTooltip.NativeMethodInfoPtr_GetPositionClampedWithinCanvas_Private_Static_Vector3_RectTransform_Rect_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666674);
      FakeTooltip.NativeMethodInfoPtr_DisableTooltip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666675);
      FakeTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTooltip>.NativeClassPtr, 100666676);
    }

    public FakeTooltip(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FakeTooltip TooltipPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TooltipPrefab));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TooltipPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipHeader TooltipHeader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TooltipHeader));
        return pointer == System.IntPtr.Zero ? (TooltipHeader) null : new TooltipHeader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TooltipHeader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipReforgeCost TooltipReforgeCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TooltipReforgeCost));
        return pointer == System.IntPtr.Zero ? (TooltipReforgeCost) null : new TooltipReforgeCost(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TooltipReforgeCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipItemStats ItemStats
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemStats));
        return pointer == System.IntPtr.Zero ? (TooltipItemStats) null : new TooltipItemStats(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemStats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipItemUnlocks ItemUnlocks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemUnlocks));
        return pointer == System.IntPtr.Zero ? (TooltipItemUnlocks) null : new TooltipItemUnlocks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemUnlocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipSetItems SetItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_SetItems));
        return pointer == System.IntPtr.Zero ? (TooltipSetItems) null : new TooltipSetItems(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_SetItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipItemSetBonuses ItemSetBonuses
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemSetBonuses));
        return pointer == System.IntPtr.Zero ? (TooltipItemSetBonuses) null : new TooltipItemSetBonuses(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemSetBonuses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipItemRepairCost ItemRepairCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemRepairCost));
        return pointer == System.IntPtr.Zero ? (TooltipItemRepairCost) null : new TooltipItemRepairCost(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemRepairCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipRecipeRequiredItems RecipeRequiredItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_RecipeRequiredItems));
        return pointer == System.IntPtr.Zero ? (TooltipRecipeRequiredItems) null : new TooltipRecipeRequiredItems(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_RecipeRequiredItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipItemSalvageItems ItemSalvageItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemSalvageItems));
        return pointer == System.IntPtr.Zero ? (TooltipItemSalvageItems) null : new TooltipItemSalvageItems(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemSalvageItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipBloodQualityEffects BloodQualityEffects
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_BloodQualityEffects));
        return pointer == System.IntPtr.Zero ? (TooltipBloodQualityEffects) null : new TooltipBloodQualityEffects(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_BloodQualityEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TooltipSpellMods> JewelSpellMods
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_JewelSpellMods));
        return pointer == System.IntPtr.Zero ? (List<TooltipSpellMods>) null : new List<TooltipSpellMods>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_JewelSpellMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TooltipSpellMods> WeaponSpellMods
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_WeaponSpellMods));
        return pointer == System.IntPtr.Zero ? (List<TooltipSpellMods>) null : new List<TooltipSpellMods>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_WeaponSpellMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CurrentlyEquipped
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_CurrentlyEquipped));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_CurrentlyEquipped), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Description
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_Description));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject DescriptionFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_DescriptionFrame));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_DescriptionFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText BloodPotion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_BloodPotion));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_BloodPotion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Durability
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_Durability));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_Durability), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Repair
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_Repair));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_Repair), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SubText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_SubText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_SubText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ErrorText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ErrorText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ErrorText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText AdvancedTooltipText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_AdvancedTooltipText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_AdvancedTooltipText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject AdvancedTooltipParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_AdvancedTooltipParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_AdvancedTooltipParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject GearlevelFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_GearlevelFrame));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_GearlevelFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemCategorySettings ItemCategorySettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemCategorySettings));
        return pointer == System.IntPtr.Zero ? (ItemCategorySettings) null : new ItemCategorySettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemCategorySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlueprintTypeLocalizationKeys BlueprintTypeLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_BlueprintTypeLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (BlueprintTypeLocalizationKeys) null : new BlueprintTypeLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_BlueprintTypeLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemLevelRaritySettings ItemLevelRaritySettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemLevelRaritySettings));
        return pointer == System.IntPtr.Zero ? (ItemLevelRaritySettings) null : new ItemLevelRaritySettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ItemLevelRaritySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Durability
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Durability));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Durability)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Mana
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Mana));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Mana)) = value;
      }
    }

    public unsafe LocalizationKey LKey_SoulBound
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_SoulBound));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_SoulBound)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CraftingDuration
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_CraftingDuration));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_CraftingDuration)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Stackable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Stackable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Stackable)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Consumable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Consumable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Consumable)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Memory
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Memory));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Memory)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Tech
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Tech));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Tech)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Equippable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Equippable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Equippable)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Placeable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Placeable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Placeable)) = value;
      }
    }

    public unsafe LocalizationKey LKey_OrbOfKnowledge
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_OrbOfKnowledge));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_OrbOfKnowledge)) = value;
      }
    }

    public unsafe LocalizationKey LKey_VBloodEssence
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_VBloodEssence));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_VBloodEssence)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Salvageable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Salvageable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Salvageable)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Bag
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Bag));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Bag)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Jewel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Jewel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_Jewel)) = value;
      }
    }

    public unsafe LocalizationKey LKey_JewelTierX
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_JewelTierX));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_LKey_JewelTierX)) = value;
      }
    }

    public unsafe Color TextColor_Dark
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TextColor_Dark));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TextColor_Dark)) = value;
      }
    }

    public unsafe Color TextColor_Normal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TextColor_Normal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TextColor_Normal)) = value;
      }
    }

    public unsafe Color TextColor_Durability
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TextColor_Durability));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_TextColor_Durability)) = value;
      }
    }

    public unsafe float ShatteredInformationAlpha
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ShatteredInformationAlpha));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_ShatteredInformationAlpha)) = value;
      }
    }

    public unsafe CanvasGroup InformationGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_InformationGroup));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr_InformationGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip _AdditionalTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__AdditionalTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__AdditionalTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModCollectionSystem_UI _SpellModCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__SpellModCollectionSystem));
        return pointer == System.IntPtr.Zero ? (SpellModCollectionSystem_UI) null : new SpellModCollectionSystem_UI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__SpellModCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModTierCollectionSystem _SpellModTierCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__SpellModTierCollectionSystem));
        return pointer == System.IntPtr.Zero ? (SpellModTierCollectionSystem) null : new SpellModTierCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__SpellModTierCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIAssetSubSceneLoader_ClientWorld _UIAssetSubSceneLoader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__UIAssetSubSceneLoader));
        return pointer == System.IntPtr.Zero ? (UIAssetSubSceneLoader_ClientWorld) null : new UIAssetSubSceneLoader_ClientWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__UIAssetSubSceneLoader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityManager _EntityManager
    {
      get
      {
        return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__EntityManager));
      }
      [param: In] set
      {
        *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__EntityManager)) = value;
      }
    }

    public unsafe Dictionary<PrefabGUID, List<CostData>> _CachedRecipeRequirements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__CachedRecipeRequirements));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, List<CostData>>) null : new Dictionary<PrefabGUID, List<CostData>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__CachedRecipeRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public MemoizedItemCategories _ItemCategoriesString
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__ItemCategoriesString);
        return new MemoizedItemCategories(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__ItemCategoriesString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe RectTransform _RootCanvasTransform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__RootCanvasTransform));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FakeTooltip.NativeFieldInfoPtr__RootCanvasTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
