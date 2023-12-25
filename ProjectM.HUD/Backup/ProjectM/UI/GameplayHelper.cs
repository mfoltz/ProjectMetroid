// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.GameplayHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.CastleBuilding;
using ProjectM.Shared;
using Stunlock.Localization;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class GameplayHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSalvageInfo_Internal_Static_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_ItemGridSelectionEntry_byref_List_1_CostData_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRequirements_Internal_Static_List_1_CostData_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_EntityManager_GameDataSystem_Dictionary_2_PrefabGUID_List_1_CostData_PrefabCollectionSystem_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRepairCost_Internal_Static_Nullable_1_RepairCost_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_DurabilityInfo_Dictionary_2_PrefabGUID_List_1_CostData_EntityManager_GameDataSystem_PrefabGUID_PrefabCollectionSystem_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_RecipeData_Nullable_Unboxed_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RelicAlreadyExist_Internal_Static_Boolean_EntityManager_RelicType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AffordToRepair_Internal_Static_Boolean_Entity_Entity_EntityManager_GameDataSystem_PrefabCollectionSystem_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDurability_Internal_Static_Nullable_Unboxed_1_DurabilityInfo_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_Nullable_Unboxed_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCastleFloorName_Internal_Static_Void_StationBonusRequirement_CastleFloorsLocalizationKeys_CastleFloorTypes_byref_Nullable_Unboxed_1_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBlueprintTypeName_Internal_Static_String_BlueprintType_BlueprintTypeLocalizationKeys_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetExtraItemInfo_Internal_Static_Nullable_1_ExtraItemInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBloodBuffInfo_Internal_Static_Nullable_1_BloodBuffInfo_EntityManager_Nullable_Unboxed_1_Entity_PrefabCollectionSystem_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAsVBloodFromItemName_Public_Static_Nullable_Unboxed_1_LocalizationKey_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetConsumableTooltip_Public_Static_Boolean_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetUnlockInfo_Public_Static_Nullable_1_UnlockInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemName_Internal_Static_AssetGuid_GameDataSystem_EntityManager_PrefabLookupMap_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStatsInfo_Public_Static_Nullable_1_StatsInfo_EntityManager_GameDataSystem_PrefabCollectionSystem_SpellModCollectionSystem_UI_SpellModTierCollectionSystem_CurveCollectionSystem_PrefabGUID_Nullable_Unboxed_1_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddLegendaryItemStats_Internal_Static_Void_EntityManager_GameDataSystem_SpellModCollectionSystem_UI_SpellModTierCollectionSystem_CurveCollectionSystem_Nullable_Unboxed_1_Entity_StatsInfo_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddStat_Private_Static_Void_GameDataSystem_UnitStatType_Single_StatsInfo_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrMergeStatEntry_Private_Static_Void_List_1_KeyValuePair_Unboxed_2_AssetGuid_StatInfo_LocalizationKey_Single_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldMerge_Private_Static_Boolean_List_1_KeyValuePair_Unboxed_2_AssetGuid_StatInfo_AssetGuid_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemSet_Public_Static_Nullable_1_ItemSetInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAvaragePlayerLevel_Internal_Static_Single_Equipment_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPlayer_Internal_Static_Entity_EntityQuery_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Internal_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemLevel_Public_Static_Nullable_Unboxed_1_ItemLevel_EntityManager_PrefabCollectionSystem_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemLevel_Public_Static_Nullable_Unboxed_1_ItemLevel_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipmentType_Public_Static_EquipmentType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetArmorSlotEquipmentType_Public_Static_EquipmentType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWeaponSlotEquipmentType_Public_Static_EquipmentType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCloakSlotEquipmentType_Public_Static_EquipmentType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeadSlotEquipmentType_Public_Static_EquipmentType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGrimoireSlotEquipmentType_Public_Static_EquipmentType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCategoryString_Public_Static_String_ItemCategorySettings_ItemCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1265225, RefRangeEnd = 1265234, XrefRangeStart = 1265159, XrefRangeEnd = 1265225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetSalvageInfo(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      ItemGridSelectionEntry item,
      ref List<CostData> salvageList,
      out bool isSalvageable)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      numPtr1[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) salvageList);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref isSalvageable;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetSalvageInfo_Internal_Static_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_ItemGridSelectionEntry_byref_List_1_CostData_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<CostData> local = ref salvageList;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<CostData>) list;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265319, RefRangeEnd = 1265320, XrefRangeStart = 1265234, XrefRangeEnd = 1265319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<CostData> TryGetRequirements(
      Nullable_Unboxed<Entity> localPlayer,
      Nullable_Unboxed<Entity> localUser,
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Dictionary<PrefabGUID, List<CostData>> cachedRecipeRequirements,
      PrefabCollectionSystem prefabCollectionSystem,
      PrefabGUID entry,
      Entity entryPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cachedRecipeRequirements);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &entry;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &entryPrefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetRequirements_Internal_Static_List_1_CostData_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_EntityManager_GameDataSystem_Dictionary_2_PrefabGUID_List_1_CostData_PrefabCollectionSystem_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265392, RefRangeEnd = 1265393, XrefRangeStart = 1265320, XrefRangeEnd = 1265392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Nullable<RepairCost> TryGetRepairCost(
      Nullable_Unboxed<Entity> localPlayer,
      Nullable_Unboxed<DurabilityInfo> durabilityInfo,
      Dictionary<PrefabGUID, List<CostData>> cachedRepairCosts,
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabGUID entry,
      PrefabCollectionSystem prefabCollectionSystem,
      Nullable_Unboxed<Entity> entity,
      Nullable_Unboxed<RecipeData> recipeData,
      Nullable_Unboxed<Entity> container)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &durabilityInfo;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cachedRepairCosts);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entry;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &container;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetRepairCost_Internal_Static_Nullable_1_RepairCost_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_DurabilityInfo_Dictionary_2_PrefabGUID_List_1_CostData_EntityManager_GameDataSystem_PrefabGUID_PrefabCollectionSystem_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_RecipeData_Nullable_Unboxed_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<RepairCost>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265393, XrefRangeEnd = 1265401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RelicAlreadyExist(EntityManager entityManager, RelicType relicType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relicType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_RelicAlreadyExist_Internal_Static_Boolean_EntityManager_RelicType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1265425, RefRangeEnd = 1265430, XrefRangeStart = 1265401, XrefRangeEnd = 1265425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AffordToRepair(
      Entity entity,
      Entity localPlayer,
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      Entity additionalContainer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalContainer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_AffordToRepair_Internal_Static_Boolean_Entity_Entity_EntityManager_GameDataSystem_PrefabCollectionSystem_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1265447, RefRangeEnd = 1265456, XrefRangeStart = 1265430, XrefRangeEnd = 1265447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Nullable_Unboxed<DurabilityInfo> TryGetDurability(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      PrefabGUID entry,
      Nullable_Unboxed<Entity> entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entry;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetDurability_Internal_Static_Nullable_Unboxed_1_DurabilityInfo_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_Nullable_Unboxed_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<DurabilityInfo>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1265471, RefRangeEnd = 1265473, XrefRangeStart = 1265456, XrefRangeEnd = 1265471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryGetCastleFloorName(
      StationBonusRequirement requirement,
      CastleFloorsLocalizationKeys castleFloorsLocalizationKeys,
      CastleFloorTypes matchingFloorType,
      out Nullable_Unboxed<LocalizationKey> floorType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &requirement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) castleFloorsLocalizationKeys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &matchingFloorType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetCastleFloorName_Internal_Static_Void_StationBonusRequirement_CastleFloorsLocalizationKeys_CastleFloorTypes_byref_Nullable_Unboxed_1_LocalizationKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265473, XrefRangeEnd = 1265474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string TryGetBlueprintTypeName(
      BlueprintType type,
      BlueprintTypeLocalizationKeys blueprintTypeLocalizationKeys)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blueprintTypeLocalizationKeys);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetBlueprintTypeName_Internal_Static_String_BlueprintType_BlueprintTypeLocalizationKeys_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 1265489, RefRangeEnd = 1265504, XrefRangeStart = 1265474, XrefRangeEnd = 1265489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Nullable<ExtraItemInfo> TryGetExtraItemInfo(
      EntityManager entityManager,
      Nullable_Unboxed<Entity> item,
      GameDataSystem gameDataSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &item;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetExtraItemInfo_Internal_Static_Nullable_1_ExtraItemInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<ExtraItemInfo>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265554, RefRangeEnd = 1265555, XrefRangeStart = 1265504, XrefRangeEnd = 1265554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Nullable<BloodBuffInfo> TryGetBloodBuffInfo(
      EntityManager entityManager,
      Nullable_Unboxed<Entity> localPlayer,
      PrefabCollectionSystem prefabCollectionSystem,
      GameDataSystem gameDataSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetBloodBuffInfo_Internal_Static_Nullable_1_BloodBuffInfo_EntityManager_Nullable_Unboxed_1_Entity_PrefabCollectionSystem_GameDataSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<BloodBuffInfo>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265555, XrefRangeEnd = 1265566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Nullable_Unboxed<LocalizationKey> TryGetAsVBloodFromItemName(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      PrefabGUID prefabGUID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetAsVBloodFromItemName_Public_Static_Nullable_Unboxed_1_LocalizationKey_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<LocalizationKey>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265600, RefRangeEnd = 1265601, XrefRangeStart = 1265566, XrefRangeEnd = 1265600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetConsumableTooltip(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      PrefabGUID prefabGUID,
      out string consumableDesc)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetConsumableTooltip_Public_Static_Boolean_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      consumableDesc = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265680, RefRangeEnd = 1265681, XrefRangeStart = 1265601, XrefRangeEnd = 1265680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Nullable<UnlockInfo> TryGetUnlockInfo(
      EntityManager entityManager,
      Nullable_Unboxed<Entity> localPlayer,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      PrefabGUID prefabGUID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetUnlockInfo_Public_Static_Nullable_1_UnlockInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<UnlockInfo>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265699, RefRangeEnd = 1265700, XrefRangeStart = 1265681, XrefRangeEnd = 1265699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AssetGuid TryGetItemName(
      GameDataSystem gameDataSystem,
      EntityManager entityManager,
      PrefabLookupMap prefabLookupMap,
      PrefabGUID id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetItemName_Internal_Static_AssetGuid_GameDataSystem_EntityManager_PrefabLookupMap_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265761, RefRangeEnd = 1265762, XrefRangeStart = 1265700, XrefRangeEnd = 1265761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Nullable<StatsInfo> TryGetStatsInfo(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      SpellModCollectionSystem_UI spellModCollection,
      SpellModTierCollectionSystem spellModTierCollectionSystem,
      CurveCollectionSystem curveCollectionSystem,
      PrefabGUID prefabGUID,
      Nullable_Unboxed<Entity> entity,
      bool showAdvancedData = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellModCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellModTierCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curveCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &showAdvancedData;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetStatsInfo_Public_Static_Nullable_1_StatsInfo_EntityManager_GameDataSystem_PrefabCollectionSystem_SpellModCollectionSystem_UI_SpellModTierCollectionSystem_CurveCollectionSystem_PrefabGUID_Nullable_Unboxed_1_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<StatsInfo>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1265813, RefRangeEnd = 1265815, XrefRangeStart = 1265762, XrefRangeEnd = 1265813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryAddLegendaryItemStats(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      SpellModCollectionSystem_UI spellModCollection,
      SpellModTierCollectionSystem spellModTierCollectionSystem,
      CurveCollectionSystem curveCollectionSystem,
      Nullable_Unboxed<Entity> entity,
      StatsInfo statsInfo,
      bool showAdvancedData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellModCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellModTierCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curveCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) statsInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &showAdvancedData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryAddLegendaryItemStats_Internal_Static_Void_EntityManager_GameDataSystem_SpellModCollectionSystem_UI_SpellModTierCollectionSystem_CurveCollectionSystem_Nullable_Unboxed_1_Entity_StatsInfo_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1265817, RefRangeEnd = 1265819, XrefRangeStart = 1265815, XrefRangeEnd = 1265817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddStat(
      GameDataSystem gameDataSystem,
      UnitStatType statType,
      float value,
      StatsInfo statsInfo,
      Nullable_Unboxed<float> minValue = default (Nullable_Unboxed<float>),
      Nullable_Unboxed<float> maxValue = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) statsInfo));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_AddStat_Private_Static_Void_GameDataSystem_UnitStatType_Single_StatsInfo_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1265849, RefRangeEnd = 1265851, XrefRangeStart = 1265819, XrefRangeEnd = 1265849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddOrMergeStatEntry(
      List<KeyValuePair_Unboxed<AssetGuid, StatInfo>> statsList,
      LocalizationKey key,
      float value,
      float modifier = 1f,
      Nullable_Unboxed<float> minValue = default (Nullable_Unboxed<float>),
      Nullable_Unboxed<float> maxValue = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) statsList);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_AddOrMergeStatEntry_Private_Static_Void_List_1_KeyValuePair_Unboxed_2_AssetGuid_StatInfo_LocalizationKey_Single_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265851, XrefRangeEnd = 1265857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldMerge(
      List<KeyValuePair_Unboxed<AssetGuid, StatInfo>> statsList,
      AssetGuid assetGuid,
      out int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) statsList);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &assetGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_ShouldMerge_Private_Static_Boolean_List_1_KeyValuePair_Unboxed_2_AssetGuid_StatInfo_AssetGuid_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1266047, RefRangeEnd = 1266048, XrefRangeStart = 1265857, XrefRangeEnd = 1266047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Nullable<ItemSetInfo> TryGetItemSet(
      EntityManager entityManager,
      Nullable_Unboxed<Entity> localPlayer,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      PrefabGUID prefabGUID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetItemSet_Public_Static_Nullable_1_ItemSetInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<ItemSetInfo>(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1266053, RefRangeEnd = 1266057, XrefRangeStart = 1266048, XrefRangeEnd = 1266053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetAvaragePlayerLevel(Equipment equipment)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipment;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetAvaragePlayerLevel_Internal_Static_Single_Equipment_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266057, XrefRangeEnd = 1266070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetLocalPlayer(EntityQuery localPlayerQuery)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localPlayerQuery;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetLocalPlayer_Internal_Static_Entity_EntityQuery_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266070, XrefRangeEnd = 1266098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasBuff(
      EntityManager entityManager,
      Entity target,
      PrefabGUID buff,
      out Entity buffEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_HasBuff_Internal_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266098, XrefRangeEnd = 1266114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Nullable_Unboxed<ItemLevel> TryGetItemLevel(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      PrefabGUID prefabGUID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetItemLevel_Public_Static_Nullable_Unboxed_1_ItemLevel_EntityManager_PrefabCollectionSystem_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<ItemLevel>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1266133, RefRangeEnd = 1266145, XrefRangeStart = 1266114, XrefRangeEnd = 1266133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Nullable_Unboxed<ItemLevel> TryGetItemLevel(
      EntityManager entityManager,
      Entity prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_TryGetItemLevel_Public_Static_Nullable_Unboxed_1_ItemLevel_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<ItemLevel>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1266145, RefRangeEnd = 1266147, XrefRangeStart = 1266145, XrefRangeEnd = 1266145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EquipmentType GetEquipmentType(int itemIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetEquipmentType_Public_Static_EquipmentType_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipmentType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe EquipmentType GetArmorSlotEquipmentType(int itemIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetArmorSlotEquipmentType_Public_Static_EquipmentType_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipmentType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe EquipmentType GetWeaponSlotEquipmentType(int itemIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetWeaponSlotEquipmentType_Public_Static_EquipmentType_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipmentType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe EquipmentType GetCloakSlotEquipmentType(int itemIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetCloakSlotEquipmentType_Public_Static_EquipmentType_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipmentType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe EquipmentType GetHeadSlotEquipmentType(int itemIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetHeadSlotEquipmentType_Public_Static_EquipmentType_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipmentType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe EquipmentType GetGrimoireSlotEquipmentType(int itemIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetGrimoireSlotEquipmentType_Public_Static_EquipmentType_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipmentType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1266160, RefRangeEnd = 1266161, XrefRangeStart = 1266147, XrefRangeEnd = 1266160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetItemCategoryString(
      ItemCategorySettings itemCategorySettings,
      ItemCategory itemCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr_GetItemCategoryString_Public_Static_String_ItemCategorySettings_ItemCategory_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayHelper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayHelper()
    {
      Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (GameplayHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr);
      GameplayHelper.NativeMethodInfoPtr_GetSalvageInfo_Internal_Static_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_ItemGridSelectionEntry_byref_List_1_CostData_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667545);
      GameplayHelper.NativeMethodInfoPtr_TryGetRequirements_Internal_Static_List_1_CostData_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_EntityManager_GameDataSystem_Dictionary_2_PrefabGUID_List_1_CostData_PrefabCollectionSystem_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667546);
      GameplayHelper.NativeMethodInfoPtr_TryGetRepairCost_Internal_Static_Nullable_1_RepairCost_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_DurabilityInfo_Dictionary_2_PrefabGUID_List_1_CostData_EntityManager_GameDataSystem_PrefabGUID_PrefabCollectionSystem_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_RecipeData_Nullable_Unboxed_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667547);
      GameplayHelper.NativeMethodInfoPtr_RelicAlreadyExist_Internal_Static_Boolean_EntityManager_RelicType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667548);
      GameplayHelper.NativeMethodInfoPtr_AffordToRepair_Internal_Static_Boolean_Entity_Entity_EntityManager_GameDataSystem_PrefabCollectionSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667549);
      GameplayHelper.NativeMethodInfoPtr_TryGetDurability_Internal_Static_Nullable_Unboxed_1_DurabilityInfo_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_Nullable_Unboxed_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667550);
      GameplayHelper.NativeMethodInfoPtr_TryGetCastleFloorName_Internal_Static_Void_StationBonusRequirement_CastleFloorsLocalizationKeys_CastleFloorTypes_byref_Nullable_Unboxed_1_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667551);
      GameplayHelper.NativeMethodInfoPtr_TryGetBlueprintTypeName_Internal_Static_String_BlueprintType_BlueprintTypeLocalizationKeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667552);
      GameplayHelper.NativeMethodInfoPtr_TryGetExtraItemInfo_Internal_Static_Nullable_1_ExtraItemInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667553);
      GameplayHelper.NativeMethodInfoPtr_TryGetBloodBuffInfo_Internal_Static_Nullable_1_BloodBuffInfo_EntityManager_Nullable_Unboxed_1_Entity_PrefabCollectionSystem_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667554);
      GameplayHelper.NativeMethodInfoPtr_TryGetAsVBloodFromItemName_Public_Static_Nullable_Unboxed_1_LocalizationKey_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667555);
      GameplayHelper.NativeMethodInfoPtr_TryGetConsumableTooltip_Public_Static_Boolean_EntityManager_GameDataSystem_PrefabCollectionSystem_PrefabGUID_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667556);
      GameplayHelper.NativeMethodInfoPtr_TryGetUnlockInfo_Public_Static_Nullable_1_UnlockInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667557);
      GameplayHelper.NativeMethodInfoPtr_TryGetItemName_Internal_Static_AssetGuid_GameDataSystem_EntityManager_PrefabLookupMap_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667558);
      GameplayHelper.NativeMethodInfoPtr_TryGetStatsInfo_Public_Static_Nullable_1_StatsInfo_EntityManager_GameDataSystem_PrefabCollectionSystem_SpellModCollectionSystem_UI_SpellModTierCollectionSystem_CurveCollectionSystem_PrefabGUID_Nullable_Unboxed_1_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667559);
      GameplayHelper.NativeMethodInfoPtr_TryAddLegendaryItemStats_Internal_Static_Void_EntityManager_GameDataSystem_SpellModCollectionSystem_UI_SpellModTierCollectionSystem_CurveCollectionSystem_Nullable_Unboxed_1_Entity_StatsInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667560);
      GameplayHelper.NativeMethodInfoPtr_AddStat_Private_Static_Void_GameDataSystem_UnitStatType_Single_StatsInfo_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667561);
      GameplayHelper.NativeMethodInfoPtr_AddOrMergeStatEntry_Private_Static_Void_List_1_KeyValuePair_Unboxed_2_AssetGuid_StatInfo_LocalizationKey_Single_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667562);
      GameplayHelper.NativeMethodInfoPtr_ShouldMerge_Private_Static_Boolean_List_1_KeyValuePair_Unboxed_2_AssetGuid_StatInfo_AssetGuid_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667563);
      GameplayHelper.NativeMethodInfoPtr_TryGetItemSet_Public_Static_Nullable_1_ItemSetInfo_EntityManager_Nullable_Unboxed_1_Entity_GameDataSystem_PrefabCollectionSystem_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667564);
      GameplayHelper.NativeMethodInfoPtr_GetAvaragePlayerLevel_Internal_Static_Single_Equipment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667565);
      GameplayHelper.NativeMethodInfoPtr_GetLocalPlayer_Internal_Static_Entity_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667566);
      GameplayHelper.NativeMethodInfoPtr_HasBuff_Internal_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667567);
      GameplayHelper.NativeMethodInfoPtr_TryGetItemLevel_Public_Static_Nullable_Unboxed_1_ItemLevel_EntityManager_PrefabCollectionSystem_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667568);
      GameplayHelper.NativeMethodInfoPtr_TryGetItemLevel_Public_Static_Nullable_Unboxed_1_ItemLevel_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667569);
      GameplayHelper.NativeMethodInfoPtr_GetEquipmentType_Public_Static_EquipmentType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667570);
      GameplayHelper.NativeMethodInfoPtr_GetArmorSlotEquipmentType_Public_Static_EquipmentType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667571);
      GameplayHelper.NativeMethodInfoPtr_GetWeaponSlotEquipmentType_Public_Static_EquipmentType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667572);
      GameplayHelper.NativeMethodInfoPtr_GetCloakSlotEquipmentType_Public_Static_EquipmentType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667573);
      GameplayHelper.NativeMethodInfoPtr_GetHeadSlotEquipmentType_Public_Static_EquipmentType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667574);
      GameplayHelper.NativeMethodInfoPtr_GetGrimoireSlotEquipmentType_Public_Static_EquipmentType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667575);
      GameplayHelper.NativeMethodInfoPtr_GetItemCategoryString_Public_Static_String_ItemCategorySettings_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667576);
      GameplayHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayHelper>.NativeClassPtr, 100667577);
    }

    public GameplayHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
