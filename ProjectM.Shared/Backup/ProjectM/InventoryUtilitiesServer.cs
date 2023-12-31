// Decompiled with JetBrains decompiler
// Type: ProjectM.InventoryUtilitiesServer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class InventoryUtilitiesServer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryBuffer_Private_Static_GetInventoryResponse_EntityManager_Entity_byref_DynamicBuffer_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryBufferReadOnly_Private_Static_GetInventoryResponse_EntityManager_Entity_byref_DynamicBuffer_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryBuffer_Public_Static_GetInventoryResponse_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_DynamicBuffer_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryBuffer_Public_Static_GetInventoryResponse_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_DynamicBuffer_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateInventory_Public_Static_Void_EntityManager_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddItem_Public_Static_AddItemResponse_AddItemSettings_Entity_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddItem_Public_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryAddItem_Private_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryAddItemInInventory_Private_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryAddItemAtSlot_Private_Static_Void_byref_DynamicBuffer_1_InventoryBuffer_byref_DynamicBuffer_1_Restricted_InventoryBuffer_Int32_ItemData_byref_Int32_byref_Int32_Boolean_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveItemFromInventories_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItemGetRemainder_Public_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_Boolean_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItemGetRemainder_Public_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_byref_Entity_Nullable_Unboxed_1_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RemoveItemGetRemainder_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_byref_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_NetworkedEntity_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_Entity_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveItemAtIndex_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateInventoryChangedEvent_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_InventoryChangedEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateInventoryChangedEvent_Private_Static_Void_EntityCommandBuffer_Entity_PrefabGUID_Int32_InventoryChangedEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDropItem_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySmartMergeInventoriesInternal_Private_Static_SmartMergeInventoriesResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySmartMergeInventories_Public_Static_SmartMergeInventoriesResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMergeInventories_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMergeInventories_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_PrefabGUID_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySortInventory_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveItem_Public_Static_MoveItemResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Entity_Int32_Boolean_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryMoveItem_Public_Static_MoveItemResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Entity_Int32_Nullable_Unboxed_1_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateInventoryItemEntity_Public_Static_Entity_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateInventoryItemEntity_Public_Static_Entity_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnEquipAndAddItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_Int32_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnEquipAndAddServantItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_Int32_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnEquipItem_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnEquipServantItem_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnEquipItem_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Nullable_Unboxed_1_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnEquipItem_Private_Static_Boolean_EntityManager_Entity_Nullable_Unboxed_1_EntityCommandBuffer_Equipment_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnEquipServantItem_Private_Static_Boolean_EntityManager_Entity_Nullable_Unboxed_1_EntityCommandBuffer_ServantEquipment_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDropItem_Public_Static_Boolean_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDropRandomItem_Public_Static_Boolean_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Random_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_float3_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryPrepareDropItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_byref_DropItemPreparationResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryPrepareDropRandomItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Random_byref_DropItemPreparationResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDroppedItemEntity_Private_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_DropItemPreparationResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDroppedItemEntity_Private_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_float3_PrefabGUID_DropItemPreparationResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SplitItemStacks_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearSlot_Public_Static_Void_EntityManager_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearSlot_Public_Static_Void_EntityCommandBuffer_DynamicBuffer_1_InventoryBuffer_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearSlot_Public_Static_InventoryBuffer_EntityManager_Entity_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearSlot_Public_Static_InventoryBuffer_EntityCommandBuffer_Entity_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyInventory_Public_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearInventory_Public_Static_Void_EntityManager_Entity_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 738520, RefRangeEnd = 738543, XrefRangeStart = 738507, XrefRangeEnd = 738520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetInventoryResponse TryGetInventoryBuffer(
      EntityManager entityManager,
      Entity target,
      out DynamicBuffer<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryGetInventoryBuffer_Private_Static_GetInventoryResponse_EntityManager_Entity_byref_DynamicBuffer_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetInventoryResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738543, XrefRangeEnd = 738556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetInventoryResponse TryGetInventoryBufferReadOnly(
      EntityManager entityManager,
      Entity target,
      out DynamicBuffer<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryGetInventoryBufferReadOnly_Private_Static_GetInventoryResponse_EntityManager_Entity_byref_DynamicBuffer_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetInventoryResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 738573, RefRangeEnd = 738578, XrefRangeStart = 738556, XrefRangeEnd = 738573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetInventoryResponse TryGetInventoryBuffer(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      BufferFromEntity<InventoryInstanceElement> getInventoryOwner,
      Entity target,
      out DynamicBuffer<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryGetInventoryBuffer_Public_Static_GetInventoryResponse_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_DynamicBuffer_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetInventoryResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738591, RefRangeEnd = 738592, XrefRangeStart = 738578, XrefRangeEnd = 738591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetInventoryResponse TryGetInventoryBuffer(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      InventoryInstanceElement inventoryInstanceElement,
      Entity target,
      out DynamicBuffer<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryGetInventoryBuffer_Public_Static_GetInventoryResponse_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_DynamicBuffer_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetInventoryResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 738601, RefRangeEnd = 738603, XrefRangeStart = 738592, XrefRangeEnd = 738601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InstantiateInventory(
      EntityManager entityManager,
      Entity target,
      int slots)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slots;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_InstantiateInventory_Public_Static_Void_EntityManager_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738604, RefRangeEnd = 738605, XrefRangeStart = 738603, XrefRangeEnd = 738604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AddItemResponse TryAddItem(
      AddItemSettings addItemSettings,
      Entity target,
      InventoryBuffer inventoryItem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &addItemSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryItem;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryAddItem_Public_Static_AddItemResponse_AddItemSettings_Entity_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AddItemResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(43)]
    [CachedScanResults(RefRangeStart = 738643, RefRangeEnd = 738686, XrefRangeStart = 738605, XrefRangeEnd = 738643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AddItemResponse TryAddItem(
      AddItemSettings addItemSettings,
      Entity target,
      PrefabGUID itemType,
      int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &addItemSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryAddItem_Public_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AddItemResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738710, RefRangeEnd = 738711, XrefRangeStart = 738686, XrefRangeEnd = 738710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AddItemResponse Internal_TryAddItem(
      AddItemSettings addItemSettings,
      Entity target,
      PrefabGUID itemType,
      int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &addItemSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_TryAddItem_Private_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AddItemResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 738789, RefRangeEnd = 738791, XrefRangeStart = 738711, XrefRangeEnd = 738789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AddItemResponse Internal_TryAddItemInInventory(
      AddItemSettings addItemSettings,
      Entity inventoryEntity,
      PrefabGUID itemType,
      int itemAmount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &addItemSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemAmount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_TryAddItemInInventory_Private_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AddItemResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738808, RefRangeEnd = 738809, XrefRangeStart = 738791, XrefRangeEnd = 738808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Internal_TryAddItemAtSlot(
      ref DynamicBuffer<InventoryBuffer> inventory,
      ref DynamicBuffer<Restricted_InventoryBuffer> restrictedInventory,
      int index,
      ItemData itemData,
      ref int emptyIndex,
      ref int maxAmount,
      bool onlyFillEmptySlots,
      ref int amountToAdd)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref restrictedInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref emptyIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref maxAmount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyFillEmptySlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref amountToAdd;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_TryAddItemAtSlot_Private_Static_Void_byref_DynamicBuffer_1_InventoryBuffer_byref_DynamicBuffer_1_Restricted_InventoryBuffer_Int32_ItemData_byref_Int32_byref_Int32_Boolean_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 738832, RefRangeEnd = 738840, XrefRangeStart = 738809, XrefRangeEnd = 738832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryRemoveItem(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738853, RefRangeEnd = 738854, XrefRangeStart = 738840, XrefRangeEnd = 738853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryRemoveItemFromInventories(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItemFromInventories_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 738855, RefRangeEnd = 738866, XrefRangeStart = 738854, XrefRangeEnd = 738855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveItemGetRemainder(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      int amount,
      out int remainder,
      bool destroyItem = true,
      Nullable_Unboxed<int> inventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref remainder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyItem;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_RemoveItemGetRemainder_Public_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_Boolean_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 738887, RefRangeEnd = 738896, XrefRangeStart = 738866, XrefRangeEnd = 738887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveItemGetRemainder(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      int amount,
      out int remainder,
      out Entity itemEntity,
      Nullable_Unboxed<int> inventoryInstanceIndex = default (Nullable_Unboxed<int>),
      bool destroyItem = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref remainder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyItem;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_RemoveItemGetRemainder_Public_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_byref_Entity_Nullable_Unboxed_1_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738968, RefRangeEnd = 738969, XrefRangeStart = 738896, XrefRangeEnd = 738968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Internal_RemoveItemGetRemainder(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      int amount,
      out int remainder,
      out Entity itemEntity,
      bool destroyItem = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref remainder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyItem;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_RemoveItemGetRemainder_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_byref_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738969, XrefRangeEnd = 738979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryRemoveItem(
      EntityManager entityManager,
      Entity target,
      NetworkedEntity itemEntity,
      int amount,
      bool deleteIfNoneRemaining = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &deleteIfNoneRemaining;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_NetworkedEntity_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 738989, RefRangeEnd = 738996, XrefRangeStart = 738979, XrefRangeEnd = 738989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryRemoveItem(
      EntityManager entityManager,
      Entity target,
      Entity itemEntity,
      int amount,
      bool deleteIfNoneRemaining = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &deleteIfNoneRemaining;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_Entity_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 739019, RefRangeEnd = 739025, XrefRangeStart = 738996, XrefRangeEnd = 739019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryRemoveItemAtIndex(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      int amount,
      int slotIndex,
      bool deleteIfNoneRemaining = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deleteIfNoneRemaining;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItemAtIndex_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 739041, RefRangeEnd = 739049, XrefRangeStart = 739025, XrefRangeEnd = 739041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateInventoryChangedEvent(
      EntityManager entityManager,
      Entity target,
      PrefabGUID itemType,
      int amountDiff,
      InventoryChangedEventType changeType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amountDiff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &changeType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateInventoryChangedEvent_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_InventoryChangedEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739049, XrefRangeEnd = 739053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateInventoryChangedEvent(
      EntityCommandBuffer commandBuffer,
      Entity target,
      PrefabGUID itemType,
      int amountDiff,
      InventoryChangedEventType changeType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amountDiff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &changeType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateInventoryChangedEvent_Private_Static_Void_EntityCommandBuffer_Entity_PrefabGUID_Int32_InventoryChangedEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739060, RefRangeEnd = 739061, XrefRangeStart = 739053, XrefRangeEnd = 739060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateDropItem(
      EntityManager entityManager,
      Entity target,
      PrefabGUID itemType,
      int amount,
      Entity previousItemEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &previousItemEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDropItem_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739087, RefRangeEnd = 739088, XrefRangeStart = 739061, XrefRangeEnd = 739087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SmartMergeInventoriesResponse TrySmartMergeInventoriesInternal(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity fromInventoryEntity,
      Entity toInventoryEntity,
      out bool movedAny)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movedAny;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TrySmartMergeInventoriesInternal_Private_Static_SmartMergeInventoriesResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SmartMergeInventoriesResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739117, RefRangeEnd = 739119, XrefRangeStart = 739088, XrefRangeEnd = 739117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SmartMergeInventoriesResponse TrySmartMergeInventories(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity fromInventoryOwnerEntity,
      Entity toInventoryEntity,
      out bool movedAny,
      Nullable_Unboxed<int> fromInventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventoryOwnerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movedAny;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TrySmartMergeInventories_Public_Static_SmartMergeInventoriesResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SmartMergeInventoriesResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739121, RefRangeEnd = 739123, XrefRangeStart = 739119, XrefRangeEnd = 739121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryMergeInventories(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity fromInventoryEntity,
      Entity toInventoryEntity,
      out bool movedItems)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movedItems;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryMergeInventories_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739148, RefRangeEnd = 739150, XrefRangeStart = 739123, XrefRangeEnd = 739148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryMergeInventories(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity fromInventoryEntity,
      Entity toInventoryEntity,
      PrefabGUID filteredItem,
      out bool movedItems)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &filteredItem;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref movedItems;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryMergeInventories_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_PrefabGUID_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739192, RefRangeEnd = 739194, XrefRangeStart = 739150, XrefRangeEnd = 739192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TrySortInventory(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TrySortInventory_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 739220, RefRangeEnd = 739224, XrefRangeStart = 739194, XrefRangeEnd = 739220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MoveItemResponse TryMoveItem(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity fromInventoryEntity,
      int fromSlotIndex,
      Entity toInventoryEntity,
      int toSlotIndex = -1,
      bool allowRelic = true,
      Nullable_Unboxed<int> toInventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fromSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &toSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &allowRelic;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryMoveItem_Public_Static_MoveItemResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Entity_Int32_Boolean_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MoveItemResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739275, RefRangeEnd = 739277, XrefRangeStart = 739224, XrefRangeEnd = 739275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MoveItemResponse Internal_TryMoveItem(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity fromInventoryEntity,
      int fromSlotIndex,
      Entity toInventoryEntity,
      int toSlotIndex = -1,
      Nullable_Unboxed<int> toInventoryInstanceIndex = default (Nullable_Unboxed<int>),
      bool allowRelic = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fromSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &toSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventoryInstanceIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &allowRelic;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_TryMoveItem_Public_Static_MoveItemResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Entity_Int32_Nullable_Unboxed_1_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MoveItemResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 739289, RefRangeEnd = 739297, XrefRangeStart = 739277, XrefRangeEnd = 739289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateInventoryItemEntity(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      PrefabGUID type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateInventoryItemEntity_Public_Static_Entity_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739306, RefRangeEnd = 739307, XrefRangeStart = 739297, XrefRangeEnd = 739306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateInventoryItemEntity(
      EntityCommandBuffer commandBuffer,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      PrefabGUID type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateInventoryItemEntity_Public_Static_Entity_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739331, RefRangeEnd = 739332, XrefRangeStart = 739307, XrefRangeEnd = 739331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUnEquipAndAddItem(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity target,
      Entity inventoryTarget,
      int toSlotIndex,
      Entity item,
      Nullable_Unboxed<EntityCommandBuffer> commandBuffer = default (Nullable_Unboxed<EntityCommandBuffer>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &toSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &item;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipAndAddItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_Int32_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739366, RefRangeEnd = 739367, XrefRangeStart = 739332, XrefRangeEnd = 739366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUnEquipAndAddServantItem(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity target,
      Entity inventoryTarget,
      int toSlotIndex,
      Entity item,
      Nullable_Unboxed<EntityCommandBuffer> commandBuffer = default (Nullable_Unboxed<EntityCommandBuffer>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &toSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &item;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipAndAddServantItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_Int32_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 739379, RefRangeEnd = 739384, XrefRangeStart = 739367, XrefRangeEnd = 739379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUnEquipItem(
      EntityManager entityManager,
      Entity target,
      Entity item,
      Nullable_Unboxed<EntityCommandBuffer> commandBuffer = default (Nullable_Unboxed<EntityCommandBuffer>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &item;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipItem_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739384, XrefRangeEnd = 739393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUnEquipServantItem(
      EntityManager entityManager,
      Entity target,
      Entity item,
      Nullable_Unboxed<EntityCommandBuffer> commandBuffer = default (Nullable_Unboxed<EntityCommandBuffer>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &item;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipServantItem_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 739405, RefRangeEnd = 739408, XrefRangeStart = 739393, XrefRangeEnd = 739405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUnEquipItem(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      Nullable_Unboxed<EntityCommandBuffer> commandBuffer = default (Nullable_Unboxed<EntityCommandBuffer>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipItem_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Nullable_Unboxed_1_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739451, RefRangeEnd = 739453, XrefRangeStart = 739408, XrefRangeEnd = 739451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool UnEquipItem(
      EntityManager entityManager,
      Entity target,
      Nullable_Unboxed<EntityCommandBuffer> commandBuffer,
      Equipment equipment,
      EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &equipment;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_UnEquipItem_Private_Static_Boolean_EntityManager_Entity_Nullable_Unboxed_1_EntityCommandBuffer_Equipment_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739496, RefRangeEnd = 739498, XrefRangeStart = 739453, XrefRangeEnd = 739496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool UnEquipServantItem(
      EntityManager entityManager,
      Entity target,
      Nullable_Unboxed<EntityCommandBuffer> commandBuffer,
      ServantEquipment equipment,
      EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &equipment;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_UnEquipServantItem_Private_Static_Boolean_EntityManager_Entity_Nullable_Unboxed_1_EntityCommandBuffer_ServantEquipment_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739501, RefRangeEnd = 739502, XrefRangeStart = 739498, XrefRangeEnd = 739501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryDropItem(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      NativeHashMap<PrefabGUID, ItemData> itemDataLookup,
      Entity target,
      PrefabGUID itemType,
      int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryDropItem_Public_Static_Boolean_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739505, RefRangeEnd = 739506, XrefRangeStart = 739502, XrefRangeEnd = 739505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryDropRandomItem(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      NativeHashMap<PrefabGUID, ItemData> itemDataLookup,
      Entity target,
      PrefabGUID itemType,
      Unity.Mathematics.Random random,
      int amount = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryDropRandomItem_Public_Static_Boolean_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Random_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739507, RefRangeEnd = 739508, XrefRangeStart = 739506, XrefRangeEnd = 739507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateDroppedItemEntity(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      NativeHashMap<PrefabGUID, ItemData> itemDataLookup,
      Entity target,
      PrefabGUID itemType,
      int amount = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739517, RefRangeEnd = 739518, XrefRangeStart = 739508, XrefRangeEnd = 739517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateDroppedItemEntity(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      NativeHashMap<PrefabGUID, ItemData> itemDataLookup,
      float3 position,
      PrefabGUID itemType,
      int amount = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_float3_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739534, RefRangeEnd = 739535, XrefRangeStart = 739518, XrefRangeEnd = 739534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryPrepareDropItem(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataLookup,
      Entity target,
      PrefabGUID itemType,
      int amount,
      out InventoryUtilitiesServer.DropItemPreparationResult result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryPrepareDropItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_byref_DropItemPreparationResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739575, RefRangeEnd = 739576, XrefRangeStart = 739535, XrefRangeEnd = 739575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryPrepareDropRandomItem(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataLookup,
      Entity target,
      int amount,
      Unity.Mathematics.Random random,
      out InventoryUtilitiesServer.DropItemPreparationResult result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_TryPrepareDropRandomItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Random_byref_DropItemPreparationResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 739588, RefRangeEnd = 739591, XrefRangeStart = 739576, XrefRangeEnd = 739588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateDroppedItemEntity(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      NativeHashMap<PrefabGUID, ItemData> itemDataLookup,
      Entity target,
      PrefabGUID itemType,
      InventoryUtilitiesServer.DropItemPreparationResult preparationResult)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &preparationResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDroppedItemEntity_Private_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_DropItemPreparationResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739591, XrefRangeEnd = 739600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateDroppedItemEntity(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      NativeHashMap<PrefabGUID, ItemData> itemDataLookup,
      float3 position,
      PrefabGUID itemType,
      InventoryUtilitiesServer.DropItemPreparationResult preparationResult)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &preparationResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDroppedItemEntity_Private_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_float3_PrefabGUID_DropItemPreparationResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739630, RefRangeEnd = 739631, XrefRangeStart = 739600, XrefRangeEnd = 739630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SplitItemStacks(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity inventoryOwner,
      int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_SplitItemStacks_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 739641, RefRangeEnd = 739645, XrefRangeStart = 739631, XrefRangeEnd = 739641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearSlot(EntityManager entityManager, Entity target, int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_ClearSlot_Public_Static_Void_EntityManager_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 739656, RefRangeEnd = 739660, XrefRangeStart = 739645, XrefRangeEnd = 739656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearSlot(
      EntityCommandBuffer commandBuffer,
      DynamicBuffer<InventoryBuffer> inventory,
      Entity target,
      int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_ClearSlot_Public_Static_Void_EntityCommandBuffer_DynamicBuffer_1_InventoryBuffer_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739662, RefRangeEnd = 739663, XrefRangeStart = 739660, XrefRangeEnd = 739662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe InventoryBuffer ClearSlot(
      EntityManager entityManager,
      Entity target,
      InventoryBuffer item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &item;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_ClearSlot_Public_Static_InventoryBuffer_EntityManager_Entity_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InventoryBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739663, XrefRangeEnd = 739668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe InventoryBuffer ClearSlot(
      EntityCommandBuffer commandBuffer,
      Entity target,
      InventoryBuffer item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &item;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_ClearSlot_Public_Static_InventoryBuffer_EntityCommandBuffer_Entity_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InventoryBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739684, RefRangeEnd = 739685, XrefRangeStart = 739668, XrefRangeEnd = 739684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyInventory(
      EntityManager entityManager,
      Entity source,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_CopyInventory_Public_Static_Void_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739692, RefRangeEnd = 739694, XrefRangeStart = 739685, XrefRangeEnd = 739692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearInventory(EntityManager entityManager, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.NativeMethodInfoPtr_ClearInventory_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventoryUtilitiesServer()
    {
      Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InventoryUtilitiesServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryGetInventoryBuffer_Private_Static_GetInventoryResponse_EntityManager_Entity_byref_DynamicBuffer_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665212);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryGetInventoryBufferReadOnly_Private_Static_GetInventoryResponse_EntityManager_Entity_byref_DynamicBuffer_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665213);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryGetInventoryBuffer_Public_Static_GetInventoryResponse_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_DynamicBuffer_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665214);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryGetInventoryBuffer_Public_Static_GetInventoryResponse_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_DynamicBuffer_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665215);
      InventoryUtilitiesServer.NativeMethodInfoPtr_InstantiateInventory_Public_Static_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665216);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryAddItem_Public_Static_AddItemResponse_AddItemSettings_Entity_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665217);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryAddItem_Public_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665218);
      InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_TryAddItem_Private_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665219);
      InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_TryAddItemInInventory_Private_Static_AddItemResponse_AddItemSettings_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665220);
      InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_TryAddItemAtSlot_Private_Static_Void_byref_DynamicBuffer_1_InventoryBuffer_byref_DynamicBuffer_1_Restricted_InventoryBuffer_Int32_ItemData_byref_Int32_byref_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665221);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665222);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItemFromInventories_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665223);
      InventoryUtilitiesServer.NativeMethodInfoPtr_RemoveItemGetRemainder_Public_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_Boolean_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665224);
      InventoryUtilitiesServer.NativeMethodInfoPtr_RemoveItemGetRemainder_Public_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_byref_Entity_Nullable_Unboxed_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665225);
      InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_RemoveItemGetRemainder_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_byref_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665226);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_NetworkedEntity_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665227);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItem_Public_Static_Boolean_EntityManager_Entity_Entity_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665228);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryRemoveItemAtIndex_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665229);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateInventoryChangedEvent_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_InventoryChangedEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665230);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateInventoryChangedEvent_Private_Static_Void_EntityCommandBuffer_Entity_PrefabGUID_Int32_InventoryChangedEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665231);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDropItem_Private_Static_Void_EntityManager_Entity_PrefabGUID_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665232);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TrySmartMergeInventoriesInternal_Private_Static_SmartMergeInventoriesResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665233);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TrySmartMergeInventories_Public_Static_SmartMergeInventoriesResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665234);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryMergeInventories_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665235);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryMergeInventories_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_PrefabGUID_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665236);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TrySortInventory_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665237);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryMoveItem_Public_Static_MoveItemResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Entity_Int32_Boolean_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665238);
      InventoryUtilitiesServer.NativeMethodInfoPtr_Internal_TryMoveItem_Public_Static_MoveItemResponse_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Entity_Int32_Nullable_Unboxed_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665239);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateInventoryItemEntity_Public_Static_Entity_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665240);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateInventoryItemEntity_Public_Static_Entity_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665241);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipAndAddItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_Int32_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665242);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipAndAddServantItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_Int32_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665243);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipItem_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665244);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipServantItem_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665245);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryUnEquipItem_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Nullable_Unboxed_1_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665246);
      InventoryUtilitiesServer.NativeMethodInfoPtr_UnEquipItem_Private_Static_Boolean_EntityManager_Entity_Nullable_Unboxed_1_EntityCommandBuffer_Equipment_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665247);
      InventoryUtilitiesServer.NativeMethodInfoPtr_UnEquipServantItem_Private_Static_Boolean_EntityManager_Entity_Nullable_Unboxed_1_EntityCommandBuffer_ServantEquipment_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665248);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryDropItem_Public_Static_Boolean_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665249);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryDropRandomItem_Public_Static_Boolean_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Random_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665250);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665251);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_float3_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665252);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryPrepareDropItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_Int32_byref_DropItemPreparationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665253);
      InventoryUtilitiesServer.NativeMethodInfoPtr_TryPrepareDropRandomItem_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Random_byref_DropItemPreparationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665254);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDroppedItemEntity_Private_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_DropItemPreparationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665255);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CreateDroppedItemEntity_Private_Static_Void_EntityManager_EntityCommandBuffer_NativeHashMap_2_PrefabGUID_ItemData_float3_PrefabGUID_DropItemPreparationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665256);
      InventoryUtilitiesServer.NativeMethodInfoPtr_SplitItemStacks_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665257);
      InventoryUtilitiesServer.NativeMethodInfoPtr_ClearSlot_Public_Static_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665258);
      InventoryUtilitiesServer.NativeMethodInfoPtr_ClearSlot_Public_Static_Void_EntityCommandBuffer_DynamicBuffer_1_InventoryBuffer_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665259);
      InventoryUtilitiesServer.NativeMethodInfoPtr_ClearSlot_Public_Static_InventoryBuffer_EntityManager_Entity_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665260);
      InventoryUtilitiesServer.NativeMethodInfoPtr_ClearSlot_Public_Static_InventoryBuffer_EntityCommandBuffer_Entity_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665261);
      InventoryUtilitiesServer.NativeMethodInfoPtr_CopyInventory_Public_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665262);
      InventoryUtilitiesServer.NativeMethodInfoPtr_ClearInventory_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, 100665263);
    }

    public InventoryUtilitiesServer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InventoryBufferComparer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemDataMap;
      private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InventoryBuffer_InventoryBuffer_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, ItemData> ItemDataMap;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738493, XrefRangeEnd = 738506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int Compare(InventoryBuffer x, InventoryBuffer y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.InventoryBufferComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InventoryBuffer_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static InventoryBufferComparer()
      {
        Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryBufferComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, nameof (InventoryBufferComparer));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryBufferComparer>.NativeClassPtr);
        InventoryUtilitiesServer.InventoryBufferComparer.NativeFieldInfoPtr_ItemDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryBufferComparer>.NativeClassPtr, nameof (ItemDataMap));
        InventoryUtilitiesServer.InventoryBufferComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InventoryBuffer_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryBufferComparer>.NativeClassPtr, 100665264);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryBufferComparer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DropItemPreparationResult
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemToDrop;
      private static readonly System.IntPtr NativeFieldInfoPtr_AmountToDrop;
      private static readonly System.IntPtr NativeFieldInfoPtr_CreateNewItemEntity;
      [FieldOffset(0)]
      public InventoryBuffer ItemToDrop;
      [FieldOffset(24)]
      public int AmountToDrop;
      [FieldOffset(28)]
      public bool CreateNewItemEntity;

      static DropItemPreparationResult()
      {
        Il2CppClassPointerStore<InventoryUtilitiesServer.DropItemPreparationResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, nameof (DropItemPreparationResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryUtilitiesServer.DropItemPreparationResult>.NativeClassPtr);
        InventoryUtilitiesServer.DropItemPreparationResult.NativeFieldInfoPtr_ItemToDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilitiesServer.DropItemPreparationResult>.NativeClassPtr, nameof (ItemToDrop));
        InventoryUtilitiesServer.DropItemPreparationResult.NativeFieldInfoPtr_AmountToDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilitiesServer.DropItemPreparationResult>.NativeClassPtr, nameof (AmountToDrop));
        InventoryUtilitiesServer.DropItemPreparationResult.NativeFieldInfoPtr_CreateNewItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilitiesServer.DropItemPreparationResult>.NativeClassPtr, nameof (CreateNewItemEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryUtilitiesServer.DropItemPreparationResult>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InventoryIndexByAmount
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Index;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
      [FieldOffset(0)]
      public int Index;
      [FieldOffset(4)]
      public int Amount;

      static InventoryIndexByAmount()
      {
        Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, nameof (InventoryIndexByAmount));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmount>.NativeClassPtr);
        InventoryUtilitiesServer.InventoryIndexByAmount.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmount>.NativeClassPtr, nameof (Index));
        InventoryUtilitiesServer.InventoryIndexByAmount.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmount>.NativeClassPtr, nameof (Amount));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmount>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InventoryIndexByAmountSorter
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InventoryIndexByAmount_InventoryIndexByAmount_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738506, XrefRangeEnd = 738507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int Compare(
        InventoryUtilitiesServer.InventoryIndexByAmount x,
        InventoryUtilitiesServer.InventoryIndexByAmount y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilitiesServer.InventoryIndexByAmountSorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InventoryIndexByAmount_InventoryIndexByAmount_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static InventoryIndexByAmountSorter()
      {
        Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmountSorter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryUtilitiesServer>.NativeClassPtr, nameof (InventoryIndexByAmountSorter));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmountSorter>.NativeClassPtr);
        InventoryUtilitiesServer.InventoryIndexByAmountSorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InventoryIndexByAmount_InventoryIndexByAmount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmountSorter>.NativeClassPtr, 100665265);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryUtilitiesServer.InventoryIndexByAmountSorter>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
