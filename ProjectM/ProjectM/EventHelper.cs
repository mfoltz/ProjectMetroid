// Decompiled with JetBrains decompiler
// Type: ProjectM.EventHelper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Network;
using ProjectM.Terrain;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class EventHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveToInventory_Public_Static_Boolean_EntityManager_NetworkId_Int32_NetworkId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveToInventory_Public_Static_Boolean_EntityManager_Entity_Int32_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDropInventoryItem_Public_Static_Void_EntityManager_NetworkId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDropInventoryItem_Public_Static_Void_EntityManager_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryTakeItem_Public_Static_Void_EntityManager_Int32_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SortSingleInventory_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SortAllInventories_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveAllItems_Public_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveAllItemsV2Filtered_Public_Static_Void_EntityManager_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveAllItemsV2_Public_Static_Void_EntityManager_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySmartMergeItems_Public_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySplitItem_Public_Static_Void_EntityManager_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRepairItem_Public_Static_Void_EntityManager_Int32_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRepairEquippedItem_Public_Static_Void_EntityManager_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDiscoverReserach_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnlockResearch_Public_Static_Void_EntityManager_PrefabGUID_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryShareRefinement_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryShareUnitspawnerRecipes_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInsertOrClaimBlood_Public_Static_Void_EntityManager_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStartCraftJewel_Public_Static_Void_EntityManager_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStopCraftJewel_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCompleteCraftJewel_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCharacterCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStopCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInteractWithPrisoner_Public_Static_Void_EntityManager_Entity_PrisonInteraction_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStopCharacterCraftItem_Public_Static_Void_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryToggleRefining_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInteractWithPrisoner_Public_Static_Void_EntityManager_Entity_PrisonInteraction_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryToggleSalvage_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendOnMission_Public_Static_Void_EntityManager_Entity_Entity_Entity_Entity_MapZoneId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRestoreStation_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryClaimAchievement_Public_Static_Void_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryClaimAchievementDebug_Public_Static_Void_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryClaimVBlood_Public_Static_Void_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryEnterShapeshift_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUseDefaultAction_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUseEmote_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendInsertEvent_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendTerminateEvent_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendFinishConvertEvent_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendReviveEvent_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendWakeUpEvent_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendSummonServantEvent_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendChangeServantNameEvent_Public_Static_Void_EntityManager_Entity_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendUpgradeEvent_Public_Static_Void_EntityManager_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendAbandonEvent_Public_Static_Void_EntityManager_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendExposeEvent_Public_Static_Void_EntityManager_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendClaimEvent_Public_Static_Void_EntityManager_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendDestroyPylonEvent_Public_Static_Void_EntityManager_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendCastleHeartRaidEvent_Public_Static_Void_EntityManager_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendBuildDebugCastleEvent_Public_Static_Void_EntityManager_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryActivateVBloodAbility_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendVivoxConnectEvent_Public_Static_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendVivoxJoinChannelEvent_Public_Static_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUseItem_Public_Static_Boolean_EntityManager_PrefabGUID_Int32_Entity_EntityQuery_Nullable_Unboxed_1_EquipmentType_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUseServantItem_Public_Static_Boolean_EntityManager_PrefabGUID_Int32_Entity_EntityQuery_Nullable_Unboxed_1_EquipmentType_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryTrackVBloodUnit_Public_Static_Void_EntityManager_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryTrackVBloodUnitV2_Public_Static_Void_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStopTrackVBloodUnit_Public_Static_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendStopInteractingWith_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendTraderPurchaseEvent_Public_Static_Boolean_EntityManager_Entity_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendRequestVBloodPositions_Public_Static_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryChargeItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCollectChargedItem_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySendGetTerritoryOwnerName_Public_Static_Void_EntityManager_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateClientSideEventResponse_Public_Static_Void_EntityManager_ResponseEventType_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994459, RefRangeEnd = 994461, XrefRangeStart = 994455, XrefRangeEnd = 994459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryMoveToInventory(
      EntityManager entityManager,
      NetworkId fromInventory,
      int fromIndex,
      NetworkId toInventory,
      int toIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &toIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryMoveToInventory_Public_Static_Boolean_EntityManager_NetworkId_Int32_NetworkId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 994473, RefRangeEnd = 994483, XrefRangeStart = 994461, XrefRangeEnd = 994473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryMoveToInventory(
      EntityManager entityManager,
      Entity fromEntity,
      int fromIndex,
      Entity toEntity,
      int toIndex = -1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &toIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryMoveToInventory_Public_Static_Boolean_EntityManager_Entity_Int32_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994486, RefRangeEnd = 994487, XrefRangeStart = 994483, XrefRangeEnd = 994486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryDropInventoryItem(
      EntityManager entityManager,
      NetworkId inventory,
      int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryDropInventoryItem_Public_Static_Void_EntityManager_NetworkId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994493, RefRangeEnd = 994495, XrefRangeStart = 994487, XrefRangeEnd = 994493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryDropInventoryItem(
      EntityManager entityManager,
      Entity inventory,
      int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryDropInventoryItem_Public_Static_Void_EntityManager_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 994503, RefRangeEnd = 994508, XrefRangeStart = 994495, XrefRangeEnd = 994503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryTakeItem(
      EntityManager entityManager,
      int index,
      Entity fromEntity,
      Entity toEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryTakeItem_Public_Static_Void_EntityManager_Int32_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994514, RefRangeEnd = 994516, XrefRangeStart = 994508, XrefRangeEnd = 994514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SortSingleInventory(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_SortSingleInventory_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994522, RefRangeEnd = 994523, XrefRangeStart = 994516, XrefRangeEnd = 994522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SortAllInventories(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_SortAllInventories_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994531, RefRangeEnd = 994533, XrefRangeStart = 994523, XrefRangeEnd = 994531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryMoveAllItems(
      EntityManager entityManager,
      Entity fromEntity,
      Entity toEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryMoveAllItems_Public_Static_Void_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 994543, RefRangeEnd = 994556, XrefRangeStart = 994533, XrefRangeEnd = 994543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryMoveAllItemsV2Filtered(
      EntityManager entityManager,
      Entity fromEntity,
      Entity toEntity,
      PrefabGUID filteredItem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &filteredItem;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryMoveAllItemsV2Filtered_Public_Static_Void_EntityManager_Entity_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994556, XrefRangeEnd = 994564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryMoveAllItemsV2(
      EntityManager entityManager,
      Entity fromEntity,
      Entity toEntity,
      PrefabGUID filteredItem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &filteredItem;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryMoveAllItemsV2_Public_Static_Void_EntityManager_Entity_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994572, RefRangeEnd = 994573, XrefRangeStart = 994564, XrefRangeEnd = 994572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySmartMergeItems(
      EntityManager entityManager,
      Entity fromEntity,
      Entity toEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySmartMergeItems_Public_Static_Void_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 994579, RefRangeEnd = 994595, XrefRangeStart = 994573, XrefRangeEnd = 994579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySplitItem(
      EntityManager entityManager,
      int index,
      Entity targetInventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetInventory;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySplitItem_Public_Static_Void_EntityManager_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 994603, RefRangeEnd = 994608, XrefRangeStart = 994595, XrefRangeEnd = 994603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryRepairItem(
      EntityManager entityManager,
      int index,
      Entity target,
      Entity inventory,
      PrefabGUID itemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryRepairItem_Public_Static_Void_EntityManager_Int32_Entity_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994611, RefRangeEnd = 994612, XrefRangeStart = 994608, XrefRangeEnd = 994611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryRepairEquippedItem(
      EntityManager entityManager,
      EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryRepairEquippedItem_Public_Static_Void_EntityManager_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994618, RefRangeEnd = 994619, XrefRangeStart = 994612, XrefRangeEnd = 994618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryDiscoverReserach(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryDiscoverReserach_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994625, RefRangeEnd = 994627, XrefRangeStart = 994619, XrefRangeEnd = 994625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryUnlockResearch(
      EntityManager entityManager,
      PrefabGUID researchId,
      Entity target,
      int amount = 1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &researchId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryUnlockResearch_Public_Static_Void_EntityManager_PrefabGUID_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994633, RefRangeEnd = 994635, XrefRangeStart = 994627, XrefRangeEnd = 994633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryShareRefinement(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryShareRefinement_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994641, RefRangeEnd = 994642, XrefRangeStart = 994635, XrefRangeEnd = 994641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryShareUnitspawnerRecipes(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryShareUnitspawnerRecipes_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994642, XrefRangeEnd = 994648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryInsertOrClaimBlood(
      EntityManager entityManager,
      PrefabGUID entryId,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryInsertOrClaimBlood_Public_Static_Void_EntityManager_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994654, RefRangeEnd = 994656, XrefRangeStart = 994648, XrefRangeEnd = 994654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryCraftItem(
      EntityManager entityManager,
      PrefabGUID recipeId,
      Entity target,
      int amount = 1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994662, RefRangeEnd = 994663, XrefRangeStart = 994656, XrefRangeEnd = 994662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryStartCraftJewel(
      EntityManager entityManager,
      Entity target,
      PrefabGUID recipeId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryStartCraftJewel_Public_Static_Void_EntityManager_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994669, RefRangeEnd = 994670, XrefRangeStart = 994663, XrefRangeEnd = 994669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryStopCraftJewel(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryStopCraftJewel_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994676, RefRangeEnd = 994677, XrefRangeStart = 994670, XrefRangeEnd = 994676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryCompleteCraftJewel(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryCompleteCraftJewel_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994680, RefRangeEnd = 994681, XrefRangeStart = 994677, XrefRangeEnd = 994680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryCharacterCraftItem(
      EntityManager entityManager,
      PrefabGUID recipeId,
      int amount = 1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryCharacterCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 994687, RefRangeEnd = 994690, XrefRangeStart = 994681, XrefRangeEnd = 994687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryStopCraftItem(
      EntityManager entityManager,
      PrefabGUID recipeId,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryStopCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994690, XrefRangeEnd = 994695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryInteractWithPrisoner(
      EntityManager entityManager,
      Entity target,
      EventHelper.PrisonInteraction charm,
      Il2CppSystem.Object prefabGUID_PrisonInteractBuff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &charm;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabGUID_PrisonInteractBuff);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryInteractWithPrisoner_Public_Static_Void_EntityManager_Entity_PrisonInteraction_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 994698, RefRangeEnd = 994701, XrefRangeStart = 994695, XrefRangeEnd = 994698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryStopCharacterCraftItem(
      EntityManager entityManager,
      PrefabGUID recipeId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryStopCharacterCraftItem_Public_Static_Void_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 994707, RefRangeEnd = 994711, XrefRangeStart = 994701, XrefRangeEnd = 994707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryToggleRefining(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryToggleRefining_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 994717, RefRangeEnd = 994720, XrefRangeStart = 994711, XrefRangeEnd = 994717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryInteractWithPrisoner(
      EntityManager entityManager,
      Entity target,
      EventHelper.PrisonInteraction interaction,
      PrefabGUID buff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &interaction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryInteractWithPrisoner_Public_Static_Void_EntityManager_Entity_PrisonInteraction_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994726, RefRangeEnd = 994728, XrefRangeStart = 994720, XrefRangeEnd = 994726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryToggleSalvage(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryToggleSalvage_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994760, RefRangeEnd = 994761, XrefRangeStart = 994728, XrefRangeEnd = 994760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendOnMission(
      EntityManager entityManager,
      Entity target,
      Entity servant1,
      Entity servant2,
      Entity servant3,
      MapZoneId mapZoneId,
      int missionDataID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &servant1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &servant2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &servant3;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mapZoneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &missionDataID;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendOnMission_Public_Static_Void_EntityManager_Entity_Entity_Entity_Entity_MapZoneId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994767, RefRangeEnd = 994768, XrefRangeStart = 994761, XrefRangeEnd = 994767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryRestoreStation(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryRestoreStation_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994771, RefRangeEnd = 994773, XrefRangeStart = 994768, XrefRangeEnd = 994771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryClaimAchievement(
      EntityManager entityManager,
      PrefabGUID achievement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &achievement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryClaimAchievement_Public_Static_Void_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994773, XrefRangeEnd = 994776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryClaimAchievementDebug(
      EntityManager entityManager,
      PrefabGUID achievement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &achievement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryClaimAchievementDebug_Public_Static_Void_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994776, XrefRangeEnd = 994779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryClaimVBlood(EntityManager entityManager, PrefabGUID source)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryClaimVBlood_Public_Static_Void_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994782, RefRangeEnd = 994783, XrefRangeStart = 994779, XrefRangeEnd = 994782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryEnterShapeshift(
      EntityManager entityManager,
      PrefabGUID shapeshift,
      bool exitOnSameForm)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shapeshift;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &exitOnSameForm;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryEnterShapeshift_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994786, RefRangeEnd = 994787, XrefRangeStart = 994783, XrefRangeEnd = 994786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryUseDefaultAction(
      EntityManager entityManager,
      PrefabGUID action,
      bool exitOnSameForm)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &action;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &exitOnSameForm;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryUseDefaultAction_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994790, RefRangeEnd = 994791, XrefRangeStart = 994787, XrefRangeEnd = 994790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryUseEmote(
      EntityManager entityManager,
      PrefabGUID action,
      bool exitOnSameForm)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &action;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &exitOnSameForm;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryUseEmote_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994797, RefRangeEnd = 994798, XrefRangeStart = 994791, XrefRangeEnd = 994797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendInsertEvent(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendInsertEvent_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994804, RefRangeEnd = 994806, XrefRangeStart = 994798, XrefRangeEnd = 994804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendTerminateEvent(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendTerminateEvent_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994806, XrefRangeEnd = 994812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendFinishConvertEvent(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendFinishConvertEvent_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994818, RefRangeEnd = 994819, XrefRangeStart = 994812, XrefRangeEnd = 994818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendReviveEvent(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendReviveEvent_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994825, RefRangeEnd = 994826, XrefRangeStart = 994819, XrefRangeEnd = 994825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendWakeUpEvent(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendWakeUpEvent_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994832, RefRangeEnd = 994833, XrefRangeStart = 994826, XrefRangeEnd = 994832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendSummonServantEvent(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendSummonServantEvent_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 994840, RefRangeEnd = 994843, XrefRangeStart = 994833, XrefRangeEnd = 994840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendChangeServantNameEvent(
      EntityManager entityManager,
      Entity target,
      string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendChangeServantNameEvent_Public_Static_Void_EntityManager_Entity_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994849, RefRangeEnd = 994851, XrefRangeStart = 994843, XrefRangeEnd = 994849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendUpgradeEvent(
      EntityManager entityManager,
      Entity target,
      bool isConsoleCommand = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isConsoleCommand;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendUpgradeEvent_Public_Static_Void_EntityManager_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994857, RefRangeEnd = 994859, XrefRangeStart = 994851, XrefRangeEnd = 994857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendAbandonEvent(
      EntityManager entityManager,
      Entity target,
      bool isConsoleCommand = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isConsoleCommand;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendAbandonEvent_Public_Static_Void_EntityManager_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994865, RefRangeEnd = 994867, XrefRangeStart = 994859, XrefRangeEnd = 994865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendExposeEvent(
      EntityManager entityManager,
      Entity target,
      bool isConsoleCommand = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isConsoleCommand;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendExposeEvent_Public_Static_Void_EntityManager_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994873, RefRangeEnd = 994875, XrefRangeStart = 994867, XrefRangeEnd = 994873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendClaimEvent(
      EntityManager entityManager,
      Entity target,
      bool isConsoleCommand = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isConsoleCommand;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendClaimEvent_Public_Static_Void_EntityManager_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994881, RefRangeEnd = 994883, XrefRangeStart = 994875, XrefRangeEnd = 994881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendDestroyPylonEvent(
      EntityManager entityManager,
      Entity target,
      bool isConsoleCommand = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isConsoleCommand;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendDestroyPylonEvent_Public_Static_Void_EntityManager_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994889, RefRangeEnd = 994891, XrefRangeStart = 994883, XrefRangeEnd = 994889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendCastleHeartRaidEvent(
      EntityManager entityManager,
      Entity target,
      bool isConsoleCommand = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isConsoleCommand;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendCastleHeartRaidEvent_Public_Static_Void_EntityManager_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994894, RefRangeEnd = 994895, XrefRangeStart = 994891, XrefRangeEnd = 994894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendBuildDebugCastleEvent(
      EntityManager entityManager,
      int territoryIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &territoryIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendBuildDebugCastleEvent_Public_Static_Void_EntityManager_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994898, RefRangeEnd = 994899, XrefRangeStart = 994895, XrefRangeEnd = 994898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryActivateVBloodAbility(
      EntityManager entityManager,
      PrefabGUID ability,
      bool primary)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ability;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &primary;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryActivateVBloodAbility_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994899, XrefRangeEnd = 994902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendVivoxConnectEvent(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendVivoxConnectEvent_Public_Static_Void_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994902, XrefRangeEnd = 994905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendVivoxJoinChannelEvent(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendVivoxJoinChannelEvent_Public_Static_Void_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994905, XrefRangeEnd = 994974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUseItem(
      EntityManager entityManager,
      PrefabGUID itemId,
      int itemIndex,
      Entity syncedEntity,
      EntityQuery getItemDatasQuery,
      Nullable_Unboxed<EquipmentType> equippedItem,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &syncedEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getItemDatasQuery;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &equippedItem;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryUseItem_Public_Static_Boolean_EntityManager_PrefabGUID_Int32_Entity_EntityQuery_Nullable_Unboxed_1_EquipmentType_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995019, RefRangeEnd = 995020, XrefRangeStart = 994974, XrefRangeEnd = 995019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUseServantItem(
      EntityManager entityManager,
      PrefabGUID itemId,
      int itemIndex,
      Entity syncedEntity,
      EntityQuery getItemDatasQuery,
      Nullable_Unboxed<EquipmentType> equippedItem,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &syncedEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getItemDatasQuery;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &equippedItem;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryUseServantItem_Public_Static_Boolean_EntityManager_PrefabGUID_Int32_Entity_EntityQuery_Nullable_Unboxed_1_EquipmentType_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 995026, RefRangeEnd = 995028, XrefRangeStart = 995020, XrefRangeEnd = 995026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryTrackVBloodUnit(
      EntityManager entityManager,
      PrefabGUID entryId,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryTrackVBloodUnit_Public_Static_Void_EntityManager_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 995031, RefRangeEnd = 995034, XrefRangeStart = 995028, XrefRangeEnd = 995031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryTrackVBloodUnitV2(EntityManager entityManager, PrefabGUID entryId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entryId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryTrackVBloodUnitV2_Public_Static_Void_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 995037, RefRangeEnd = 995039, XrefRangeStart = 995034, XrefRangeEnd = 995037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryStopTrackVBloodUnit(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryStopTrackVBloodUnit_Public_Static_Void_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 995045, RefRangeEnd = 995063, XrefRangeStart = 995039, XrefRangeEnd = 995045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendStopInteractingWith(
      EntityManager entityManager,
      Entity interactBuff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &interactBuff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendStopInteractingWith_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995069, RefRangeEnd = 995070, XrefRangeStart = 995063, XrefRangeEnd = 995069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TrySendTraderPurchaseEvent(
      EntityManager entityManager,
      Entity traderEntity,
      int itemIndex,
      int itemId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &traderEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendTraderPurchaseEvent_Public_Static_Boolean_EntityManager_Entity_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 995073, RefRangeEnd = 995075, XrefRangeStart = 995070, XrefRangeEnd = 995073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendRequestVBloodPositions(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendRequestVBloodPositions_Public_Static_Void_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995081, RefRangeEnd = 995082, XrefRangeStart = 995075, XrefRangeEnd = 995081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryChargeItem(
      EntityManager entityManager,
      PrefabGUID recipeId,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryChargeItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995088, RefRangeEnd = 995089, XrefRangeStart = 995082, XrefRangeEnd = 995088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryCollectChargedItem(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TryCollectChargedItem_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995092, RefRangeEnd = 995093, XrefRangeStart = 995089, XrefRangeEnd = 995092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySendGetTerritoryOwnerName(
      EntityManager entityManager,
      int territoryIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &territoryIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_TrySendGetTerritoryOwnerName_Public_Static_Void_EntityManager_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 995097, RefRangeEnd = 995100, XrefRangeStart = 995093, XrefRangeEnd = 995097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateClientSideEventResponse(
      EntityManager entityManager,
      ResponseEventType responseType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &responseType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelper.NativeMethodInfoPtr_CreateClientSideEventResponse_Public_Static_Void_EntityManager_ResponseEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EventHelper()
    {
      Il2CppClassPointerStore<EventHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EventHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHelper>.NativeClassPtr);
      EventHelper.NativeMethodInfoPtr_TryMoveToInventory_Public_Static_Boolean_EntityManager_NetworkId_Int32_NetworkId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676785);
      EventHelper.NativeMethodInfoPtr_TryMoveToInventory_Public_Static_Boolean_EntityManager_Entity_Int32_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676786);
      EventHelper.NativeMethodInfoPtr_TryDropInventoryItem_Public_Static_Void_EntityManager_NetworkId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676787);
      EventHelper.NativeMethodInfoPtr_TryDropInventoryItem_Public_Static_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676788);
      EventHelper.NativeMethodInfoPtr_TryTakeItem_Public_Static_Void_EntityManager_Int32_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676789);
      EventHelper.NativeMethodInfoPtr_SortSingleInventory_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676790);
      EventHelper.NativeMethodInfoPtr_SortAllInventories_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676791);
      EventHelper.NativeMethodInfoPtr_TryMoveAllItems_Public_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676792);
      EventHelper.NativeMethodInfoPtr_TryMoveAllItemsV2Filtered_Public_Static_Void_EntityManager_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676793);
      EventHelper.NativeMethodInfoPtr_TryMoveAllItemsV2_Public_Static_Void_EntityManager_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676794);
      EventHelper.NativeMethodInfoPtr_TrySmartMergeItems_Public_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676795);
      EventHelper.NativeMethodInfoPtr_TrySplitItem_Public_Static_Void_EntityManager_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676796);
      EventHelper.NativeMethodInfoPtr_TryRepairItem_Public_Static_Void_EntityManager_Int32_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676797);
      EventHelper.NativeMethodInfoPtr_TryRepairEquippedItem_Public_Static_Void_EntityManager_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676798);
      EventHelper.NativeMethodInfoPtr_TryDiscoverReserach_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676799);
      EventHelper.NativeMethodInfoPtr_TryUnlockResearch_Public_Static_Void_EntityManager_PrefabGUID_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676800);
      EventHelper.NativeMethodInfoPtr_TryShareRefinement_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676801);
      EventHelper.NativeMethodInfoPtr_TryShareUnitspawnerRecipes_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676802);
      EventHelper.NativeMethodInfoPtr_TryInsertOrClaimBlood_Public_Static_Void_EntityManager_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676803);
      EventHelper.NativeMethodInfoPtr_TryCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676804);
      EventHelper.NativeMethodInfoPtr_TryStartCraftJewel_Public_Static_Void_EntityManager_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676805);
      EventHelper.NativeMethodInfoPtr_TryStopCraftJewel_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676806);
      EventHelper.NativeMethodInfoPtr_TryCompleteCraftJewel_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676807);
      EventHelper.NativeMethodInfoPtr_TryCharacterCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676808);
      EventHelper.NativeMethodInfoPtr_TryStopCraftItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676809);
      EventHelper.NativeMethodInfoPtr_TryInteractWithPrisoner_Public_Static_Void_EntityManager_Entity_PrisonInteraction_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676810);
      EventHelper.NativeMethodInfoPtr_TryStopCharacterCraftItem_Public_Static_Void_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676811);
      EventHelper.NativeMethodInfoPtr_TryToggleRefining_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676812);
      EventHelper.NativeMethodInfoPtr_TryInteractWithPrisoner_Public_Static_Void_EntityManager_Entity_PrisonInteraction_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676813);
      EventHelper.NativeMethodInfoPtr_TryToggleSalvage_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676814);
      EventHelper.NativeMethodInfoPtr_TrySendOnMission_Public_Static_Void_EntityManager_Entity_Entity_Entity_Entity_MapZoneId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676815);
      EventHelper.NativeMethodInfoPtr_TryRestoreStation_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676816);
      EventHelper.NativeMethodInfoPtr_TryClaimAchievement_Public_Static_Void_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676817);
      EventHelper.NativeMethodInfoPtr_TryClaimAchievementDebug_Public_Static_Void_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676818);
      EventHelper.NativeMethodInfoPtr_TryClaimVBlood_Public_Static_Void_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676819);
      EventHelper.NativeMethodInfoPtr_TryEnterShapeshift_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676820);
      EventHelper.NativeMethodInfoPtr_TryUseDefaultAction_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676821);
      EventHelper.NativeMethodInfoPtr_TryUseEmote_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676822);
      EventHelper.NativeMethodInfoPtr_TrySendInsertEvent_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676823);
      EventHelper.NativeMethodInfoPtr_TrySendTerminateEvent_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676824);
      EventHelper.NativeMethodInfoPtr_TrySendFinishConvertEvent_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676825);
      EventHelper.NativeMethodInfoPtr_TrySendReviveEvent_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676826);
      EventHelper.NativeMethodInfoPtr_TrySendWakeUpEvent_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676827);
      EventHelper.NativeMethodInfoPtr_TrySendSummonServantEvent_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676828);
      EventHelper.NativeMethodInfoPtr_TrySendChangeServantNameEvent_Public_Static_Void_EntityManager_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676829);
      EventHelper.NativeMethodInfoPtr_TrySendUpgradeEvent_Public_Static_Void_EntityManager_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676830);
      EventHelper.NativeMethodInfoPtr_TrySendAbandonEvent_Public_Static_Void_EntityManager_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676831);
      EventHelper.NativeMethodInfoPtr_TrySendExposeEvent_Public_Static_Void_EntityManager_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676832);
      EventHelper.NativeMethodInfoPtr_TrySendClaimEvent_Public_Static_Void_EntityManager_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676833);
      EventHelper.NativeMethodInfoPtr_TrySendDestroyPylonEvent_Public_Static_Void_EntityManager_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676834);
      EventHelper.NativeMethodInfoPtr_TrySendCastleHeartRaidEvent_Public_Static_Void_EntityManager_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676835);
      EventHelper.NativeMethodInfoPtr_TrySendBuildDebugCastleEvent_Public_Static_Void_EntityManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676836);
      EventHelper.NativeMethodInfoPtr_TryActivateVBloodAbility_Public_Static_Void_EntityManager_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676837);
      EventHelper.NativeMethodInfoPtr_TrySendVivoxConnectEvent_Public_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676838);
      EventHelper.NativeMethodInfoPtr_TrySendVivoxJoinChannelEvent_Public_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676839);
      EventHelper.NativeMethodInfoPtr_TryUseItem_Public_Static_Boolean_EntityManager_PrefabGUID_Int32_Entity_EntityQuery_Nullable_Unboxed_1_EquipmentType_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676840);
      EventHelper.NativeMethodInfoPtr_TryUseServantItem_Public_Static_Boolean_EntityManager_PrefabGUID_Int32_Entity_EntityQuery_Nullable_Unboxed_1_EquipmentType_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676841);
      EventHelper.NativeMethodInfoPtr_TryTrackVBloodUnit_Public_Static_Void_EntityManager_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676842);
      EventHelper.NativeMethodInfoPtr_TryTrackVBloodUnitV2_Public_Static_Void_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676843);
      EventHelper.NativeMethodInfoPtr_TryStopTrackVBloodUnit_Public_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676844);
      EventHelper.NativeMethodInfoPtr_TrySendStopInteractingWith_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676845);
      EventHelper.NativeMethodInfoPtr_TrySendTraderPurchaseEvent_Public_Static_Boolean_EntityManager_Entity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676846);
      EventHelper.NativeMethodInfoPtr_TrySendRequestVBloodPositions_Public_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676847);
      EventHelper.NativeMethodInfoPtr_TryChargeItem_Public_Static_Void_EntityManager_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676848);
      EventHelper.NativeMethodInfoPtr_TryCollectChargedItem_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676849);
      EventHelper.NativeMethodInfoPtr_TrySendGetTerritoryOwnerName_Public_Static_Void_EntityManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676850);
      EventHelper.NativeMethodInfoPtr_CreateClientSideEventResponse_Public_Static_Void_EntityManager_ResponseEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100676851);
    }

    public EventHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public enum PrisonInteraction
    {
      Imprison,
      Charm,
      Kill,
    }
  }
}
