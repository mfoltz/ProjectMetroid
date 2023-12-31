// Decompiled with JetBrains decompiler
// Type: ProjectM.InventoryUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class InventoryUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_NativeArray_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryGetInventoryFromInventoryEntity_Private_Static_Boolean_BufferFromEntity_1_InventoryBuffer_Entity_byref_NativeArray_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryGetInventoryFromInventoryEntity_Private_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryReadOnlyWithoutCopy_Public_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_ClientGameManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_ServerGameManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_EntityManager_Entity_byref_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_ClientGameManager_Entity_byref_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_ClientGameManager_Entity_byref_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_ServerGameManager_Entity_byref_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_ServerGameManager_Entity_byref_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_EntityManager_Entity_PrefabGUID_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_PrefabGUID_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemAmount_Private_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_EntityManager_NativeList_1_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemAmountInInventories_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemsInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_NativeList_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemsInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_NativeList_1_InventoryBuffer_byref_NativeList_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasFreeStackSpaceOfType_Public_Static_Boolean_EntityManager_Entity_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ItemAllowedInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_ItemCategory_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasFreeStackSpaceForItems_Public_Static_Boolean_EntityManager_Entity_NativeHashMap_2_PrefabGUID_ItemData_NativeArray_1_RecipeOutputBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanCraftRecipe_Public_Static_Boolean_NativeHashMap_2_PrefabGUID_RecipeData_EntityManager_Entity_PrefabGUID_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMatchingRecipe_Public_Static_PrefabGUID_EntityManager_DynamicBuffer_1_RefinementstationRecipesBuffer_NativeHashMap_2_PrefabGUID_RecipeData_Entity_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HasComplexItemInInventory_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemOfCategory_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_ItemCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemOfCategory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_NativeHashMap_2_PrefabGUID_ItemData_ItemCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ItemOfCategoryCount_Public_Static_Int32_PrefabLookupMap_BufferFromEntity_1_InventoryInstanceElement_BufferFromEntity_1_InventoryBuffer_Entity_ItemCategory_ComponentDataFromEntity_1_ItemData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasEmptySlots_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeSlotsCount_Public_Static_Int32_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsedSlotsCount_Public_Static_Int32_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_DynamicBuffer_1_InventoryBuffer_Int32_byref_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_EntityManager_Entity_Int32_byref_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_Int32_byref_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_EntityManager_Entity_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_EntityManager_Entity_Entity_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_Entity_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_InventoryInstanceElement_BufferFromEntity_1_InventoryBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMainInventoryIndex_Public_Static_Boolean_EntityManager_Entity_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMainInventoryEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_NativeArray_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInventoryFull_Public_Static_Boolean_NativeArray_1_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInventoryFull_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemDataFromType_Public_Static_ItemData_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInventorySize_Public_Static_Int32_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInventorySize_Public_Static_Int32_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemSlotsReadOnly_Public_Static_Int32_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToInventoryBufferList_Public_Static_Void_byref_NativeList_1_InventoryBuffer_NativeArray_1_T_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ItemHasComponent_Public_Static_Boolean_EntityManager_PrefabCollectionSystem_PrefabGUID_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 737307, RefRangeEnd = 737310, XrefRangeStart = 737295, XrefRangeEnd = 737307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventory(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      BufferFromEntity<InventoryInstanceElement> getInventoryOwner,
      Entity entity,
      out NativeArray<InventoryBuffer> inventory,
      int inventoryInstanceIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737310, XrefRangeEnd = 737316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventory(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      InventoryInstanceElement inventoryInstanceElement,
      Entity entity,
      out NativeArray<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_NativeArray_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 737325, RefRangeEnd = 737331, XrefRangeStart = 737316, XrefRangeEnd = 737325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool _TryGetInventoryFromInventoryEntity(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      Entity inventoryEntity,
      out NativeArray<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr__TryGetInventoryFromInventoryEntity_Private_Static_Boolean_BufferFromEntity_1_InventoryBuffer_Entity_byref_NativeArray_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 737333, RefRangeEnd = 737351, XrefRangeStart = 737331, XrefRangeEnd = 737333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventory(
      EntityManager entityManager,
      Entity entity,
      out NativeArray<InventoryBuffer> inventory,
      int inventoryIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 737357, RefRangeEnd = 737382, XrefRangeStart = 737351, XrefRangeEnd = 737357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool _TryGetInventoryFromInventoryEntity(
      EntityManager entityManager,
      Entity inventoryEntity,
      out NativeArray<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr__TryGetInventoryFromInventoryEntity_Private_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 737333, RefRangeEnd = 737351, XrefRangeStart = 737333, XrefRangeEnd = 737351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryReadOnlyWithoutCopy(
      EntityManager entityManager,
      Entity entity,
      out NativeArray<InventoryBuffer> inventory,
      int inventoryInstanceIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryReadOnlyWithoutCopy_Public_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737382, XrefRangeEnd = 737384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventory(
      ClientGameManager clientGameManager,
      Entity entity,
      out NativeArray<InventoryBuffer> inventory,
      int inventoryInstanceIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &clientGameManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_ClientGameManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737386, RefRangeEnd = 737387, XrefRangeStart = 737384, XrefRangeEnd = 737386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventory(
      ServerGameManager serverGameManager,
      Entity entity,
      out NativeArray<InventoryBuffer> inventory,
      int inventoryInstanceIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &serverGameManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_ServerGameManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 737414, RefRangeEnd = 737423, XrefRangeStart = 737387, XrefRangeEnd = 737414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntities(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      BufferFromEntity<InventoryInstanceElement> getInventoryInstances,
      Entity entity,
      ref NativeList<Entity> inventoryEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryInstances;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntities;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737423, XrefRangeEnd = 737434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntity(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      BufferFromEntity<InventoryInstanceElement> getInventoryOwner,
      Entity entity,
      out Entity inventoryEntity,
      int inventoryIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737434, XrefRangeEnd = 737441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntity(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      InventoryInstanceElement inventoryInstanceElement,
      Entity entity,
      out Entity inventoryEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(43)]
    [CachedScanResults(RefRangeStart = 737462, RefRangeEnd = 737505, XrefRangeStart = 737441, XrefRangeEnd = 737462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntities(
      EntityManager entityManager,
      Entity entity,
      ref NativeList<Entity> inventoryEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntities;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_EntityManager_Entity_byref_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 737516, RefRangeEnd = 737530, XrefRangeStart = 737505, XrefRangeEnd = 737516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntity(
      EntityManager entityManager,
      Entity entity,
      out Entity inventoryEntity,
      int inventoryInstanceIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737530, XrefRangeEnd = 737531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntities(
      ClientGameManager clientGameManager,
      Entity entity,
      ref NativeList<Entity> inventoryEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &clientGameManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntities;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_ClientGameManager_Entity_byref_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737531, XrefRangeEnd = 737532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntity(
      ClientGameManager clientGameManager,
      Entity entity,
      out Entity inventoryEntity,
      int inventoryInstanceIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &clientGameManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_ClientGameManager_Entity_byref_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737532, XrefRangeEnd = 737533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntities(
      ServerGameManager serverGameManager,
      Entity entity,
      ref NativeList<Entity> inventoryEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &serverGameManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntities;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_ServerGameManager_Entity_byref_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737533, XrefRangeEnd = 737534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInventoryEntity(
      ServerGameManager serverGameManager,
      Entity entity,
      out Entity inventoryEntity,
      int inventoryInstanceIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &serverGameManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_ServerGameManager_Entity_byref_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 737572, RefRangeEnd = 737591, XrefRangeStart = 737534, XrefRangeEnd = 737572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemAmount(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      Nullable_Unboxed<int> inventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_EntityManager_Entity_PrefabGUID_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 737623, RefRangeEnd = 737626, XrefRangeStart = 737591, XrefRangeEnd = 737623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemAmount(
      BufferFromEntity<InventoryBuffer> getInventory,
      BufferFromEntity<InventoryInstanceElement> getInventoryOwner,
      Entity target,
      PrefabGUID type,
      Nullable_Unboxed<int> inventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &getInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_PrefabGUID_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 737627, RefRangeEnd = 737629, XrefRangeStart = 737626, XrefRangeEnd = 737627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemAmount(NativeArray<InventoryBuffer> inventory, PrefabGUID type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemAmount_Private_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737638, RefRangeEnd = 737639, XrefRangeStart = 737629, XrefRangeEnd = 737638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemAmount(
      EntityManager entityManager,
      NativeList<Entity> inventories,
      PrefabGUID type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventories;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_EntityManager_NativeList_1_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737652, RefRangeEnd = 737653, XrefRangeStart = 737639, XrefRangeEnd = 737652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemAmountInInventories(
      EntityManager entityManager,
      Entity targetEntity,
      PrefabGUID itemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemAmountInInventories_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 737682, RefRangeEnd = 737685, XrefRangeStart = 737653, XrefRangeEnd = 737682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemInInventories(
      EntityManager entityManager,
      NativeList<Entity> inventoryEntities,
      PrefabGUID type,
      int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 737708, RefRangeEnd = 737714, XrefRangeStart = 737685, XrefRangeEnd = 737708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemsInInventories(
      EntityManager entityManager,
      NativeList<Entity> inventoryEntities,
      NativeList<InventoryBuffer> items)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &items;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemsInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_NativeList_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 737737, RefRangeEnd = 737745, XrefRangeStart = 737714, XrefRangeEnd = 737737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemsInInventories(
      EntityManager entityManager,
      NativeList<Entity> inventoryEntities,
      NativeList<InventoryBuffer> items,
      out NativeList<int> amounts)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &items;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref amounts;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemsInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_NativeList_1_InventoryBuffer_byref_NativeList_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 737773, RefRangeEnd = 737777, XrefRangeStart = 737745, XrefRangeEnd = 737773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasFreeStackSpaceOfType(
      EntityManager entityManager,
      Entity inventoryOwner,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      PrefabGUID itemType,
      int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasFreeStackSpaceOfType_Public_Static_Boolean_EntityManager_Entity_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737792, RefRangeEnd = 737793, XrefRangeStart = 737777, XrefRangeEnd = 737792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ItemAllowedInInventory(
      EntityManager entityManager,
      Entity inventoryEntity,
      PrefabGUID itemType,
      ItemCategory itemCategory,
      bool onlyRestrictedButAllowed)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyRestrictedButAllowed;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_ItemAllowedInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_ItemCategory_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 737870, RefRangeEnd = 737880, XrefRangeStart = 737793, XrefRangeEnd = 737870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasFreeStackSpaceForItems(
      EntityManager entityManager,
      Entity inventoryOwnerEntity,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      NativeArray<RecipeOutputBuffer> items)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwnerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &items;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasFreeStackSpaceForItems_Public_Static_Boolean_EntityManager_Entity_NativeHashMap_2_PrefabGUID_ItemData_NativeArray_1_RecipeOutputBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 737905, RefRangeEnd = 737908, XrefRangeStart = 737880, XrefRangeEnd = 737905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanCraftRecipe(
      NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap,
      EntityManager entityManager,
      Entity inventoryTarget,
      PrefabGUID recipeGuid,
      float resourceMultiplier = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &recipeHashLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceMultiplier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_CanCraftRecipe_Public_Static_Boolean_NativeHashMap_2_PrefabGUID_RecipeData_EntityManager_Entity_PrefabGUID_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 737930, RefRangeEnd = 737933, XrefRangeStart = 737908, XrefRangeEnd = 737930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PrefabGUID GetMatchingRecipe(
      EntityManager entityManager,
      DynamicBuffer<RefinementstationRecipesBuffer> recipes,
      NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap,
      Entity inventoryTarget,
      float resourceMultiplier = 1f,
      bool skipItemRequirement = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeHashLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceMultiplier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &skipItemRequirement;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetMatchingRecipe_Public_Static_PrefabGUID_EntityManager_DynamicBuffer_1_RefinementstationRecipesBuffer_NativeHashMap_2_PrefabGUID_RecipeData_Entity_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 737934, RefRangeEnd = 737943, XrefRangeStart = 737933, XrefRangeEnd = 737934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemInInventory(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      int amount,
      out int outAmount,
      Nullable_Unboxed<int> inventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref outAmount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 737944, RefRangeEnd = 737950, XrefRangeStart = 737943, XrefRangeEnd = 737944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemInInventory(
      EntityManager entityManager,
      Entity target,
      PrefabGUID type,
      int amount,
      Nullable_Unboxed<int> inventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737951, RefRangeEnd = 737952, XrefRangeStart = 737950, XrefRangeEnd = 737951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemInInventory(
      NativeArray<InventoryBuffer> inventory,
      PrefabGUID type,
      int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 737981, RefRangeEnd = 737983, XrefRangeStart = 737952, XrefRangeEnd = 737981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemInInventory(
      EntityManager entityManager,
      Entity target,
      Entity itemEntity,
      Nullable_Unboxed<int> inventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737985, RefRangeEnd = 737986, XrefRangeStart = 737983, XrefRangeEnd = 737985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool _HasComplexItemInInventory(
      [In] ref NativeArray<InventoryBuffer> inventory,
      Entity itemEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr__HasComplexItemInInventory_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737986, XrefRangeEnd = 737987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemInInventory(
      NativeArray<InventoryBuffer> inventory,
      PrefabGUID type,
      int amount,
      int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 738019, RefRangeEnd = 738022, XrefRangeStart = 737987, XrefRangeEnd = 738019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemOfCategory(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity target,
      ItemCategory itemCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemOfCategory_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_ItemCategory_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738022, XrefRangeEnd = 738025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemOfCategory(
      NativeArray<InventoryBuffer> inventory,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      ItemCategory itemCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasItemOfCategory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_NativeHashMap_2_PrefabGUID_ItemData_ItemCategory_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 738045, RefRangeEnd = 738047, XrefRangeStart = 738025, XrefRangeEnd = 738045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int ItemOfCategoryCount(
      PrefabLookupMap prefabLookupMap,
      BufferFromEntity<InventoryInstanceElement> getInventoryOwner,
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      Entity inventoryTarget,
      ItemCategory itemCategory,
      ComponentDataFromEntity<ItemData> getItemData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getItemData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_ItemOfCategoryCount_Public_Static_Int32_PrefabLookupMap_BufferFromEntity_1_InventoryInstanceElement_BufferFromEntity_1_InventoryBuffer_Entity_ItemCategory_ComponentDataFromEntity_1_ItemData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738079, RefRangeEnd = 738080, XrefRangeStart = 738047, XrefRangeEnd = 738079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasEmptySlots(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      Entity inventoryOwner,
      PrefabGUID itemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_HasEmptySlots_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738109, RefRangeEnd = 738110, XrefRangeStart = 738080, XrefRangeEnd = 738109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetFreeSlotsCount(EntityManager entityManager, Entity inventoryOwner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetFreeSlotsCount_Public_Static_Int32_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 738123, RefRangeEnd = 738125, XrefRangeStart = 738110, XrefRangeEnd = 738123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetUsedSlotsCount(EntityManager entityManager, Entity inventoryOwner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetUsedSlotsCount_Public_Static_Int32_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 738133, RefRangeEnd = 738136, XrefRangeStart = 738125, XrefRangeEnd = 738133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemAtSlot(
      DynamicBuffer<InventoryBuffer> inventory,
      int slotIndex,
      out InventoryBuffer item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref item;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_DynamicBuffer_1_InventoryBuffer_Int32_byref_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 738153, RefRangeEnd = 738168, XrefRangeStart = 738136, XrefRangeEnd = 738153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemAtSlot(
      EntityManager entityManager,
      Entity inventoryOwner,
      int slotIndex,
      out InventoryBuffer item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref item;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_EntityManager_Entity_Int32_byref_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738168, XrefRangeEnd = 738171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemAtSlot(
      NativeArray<InventoryBuffer> inventory,
      int slotIndex,
      out InventoryBuffer item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref item;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_Int32_byref_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738186, RefRangeEnd = 738187, XrefRangeStart = 738171, XrefRangeEnd = 738186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemSlot(
      EntityManager entityManager,
      Entity inventoryOwner,
      PrefabGUID itemType,
      Entity itemEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_EntityManager_Entity_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738187, XrefRangeEnd = 738190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemSlot(
      NativeArray<InventoryBuffer> inventory,
      PrefabGUID itemType,
      Entity itemEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738190, XrefRangeEnd = 738202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemSlot(
      EntityManager entityManager,
      Entity inventoryOwner,
      PrefabGUID itemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738202, XrefRangeEnd = 738203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemSlot(
      NativeArray<InventoryBuffer> inventory,
      PrefabGUID itemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 738217, RefRangeEnd = 738219, XrefRangeStart = 738203, XrefRangeEnd = 738217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemSlot(
      EntityManager entityManager,
      Entity inventoryOwner,
      PrefabGUID itemType,
      out int slotId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738219, XrefRangeEnd = 738220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemSlot(
      NativeArray<InventoryBuffer> inventory,
      PrefabGUID itemType,
      out int slotId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738235, RefRangeEnd = 738236, XrefRangeStart = 738220, XrefRangeEnd = 738235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemSlot(
      EntityManager entityManager,
      Entity inventoryOwner,
      Entity itemEntity,
      out int slotId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_EntityManager_Entity_Entity_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738236, XrefRangeEnd = 738238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemSlot(
      NativeArray<InventoryBuffer> inventory,
      Entity itemEntity,
      out int slotId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_Entity_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738238, XrefRangeEnd = 738246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInventoryEmpty(
      InventoryInstanceElement inventoryInstanceElement,
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      Entity inventoryTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventoryInstanceElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_InventoryInstanceElement_BufferFromEntity_1_InventoryBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 738259, RefRangeEnd = 738261, XrefRangeStart = 738246, XrefRangeEnd = 738259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInventoryEmpty(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      BufferFromEntity<InventoryInstanceElement> inventoryInstanceElement,
      Entity inventoryTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 738273, RefRangeEnd = 738279, XrefRangeStart = 738261, XrefRangeEnd = 738273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInventoryEmpty(EntityManager entityManager, Entity inventoryTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 738294, RefRangeEnd = 738298, XrefRangeStart = 738279, XrefRangeEnd = 738294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetMainInventoryIndex(
      EntityManager entityManager,
      Entity inventoryTarget,
      out int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetMainInventoryIndex_Public_Static_Boolean_EntityManager_Entity_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 738317, RefRangeEnd = 738319, XrefRangeStart = 738298, XrefRangeEnd = 738317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetMainInventoryEntity(
      EntityManager entityManager,
      Entity inventoryOwner,
      out Entity mainInventoryEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mainInventoryEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_TryGetMainInventoryEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 738339, RefRangeEnd = 738345, XrefRangeStart = 738319, XrefRangeEnd = 738339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInventoryEmpty(NativeArray<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_NativeArray_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738365, RefRangeEnd = 738366, XrefRangeStart = 738345, XrefRangeEnd = 738365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInventoryFull(NativeArray<InventoryBuffer> inventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inventory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_IsInventoryFull_Public_Static_Boolean_NativeArray_1_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 738378, RefRangeEnd = 738380, XrefRangeStart = 738366, XrefRangeEnd = 738378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInventoryFull(EntityManager entityManager, Entity inventoryTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_IsInventoryFull_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738380, XrefRangeEnd = 738384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ItemData GetItemDataFromType(
      NativeHashMap<PrefabGUID, ItemData> itemLookup,
      PrefabGUID itemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &itemLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemDataFromType_Public_Static_ItemData_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ItemData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 738395, RefRangeEnd = 738407, XrefRangeStart = 738384, XrefRangeEnd = 738395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetInventorySize(EntityManager entityManager, Entity inventoryTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetInventorySize_Public_Static_Int32_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738419, RefRangeEnd = 738420, XrefRangeStart = 738407, XrefRangeEnd = 738419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetInventorySize(
      BufferFromEntity<InventoryBuffer> getInventoryBuffer,
      BufferFromEntity<InventoryInstanceElement> getInventoryInstances,
      Entity inventoryTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &getInventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getInventoryInstances;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetInventorySize_Public_Static_Int32_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 738395, RefRangeEnd = 738407, XrefRangeStart = 738395, XrefRangeEnd = 738407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetItemSlotsReadOnly(
      EntityManager entityManager,
      Entity inventoryTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.NativeMethodInfoPtr_GetItemSlotsReadOnly_Public_Static_Int32_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738428, RefRangeEnd = 738429, XrefRangeStart = 738420, XrefRangeEnd = 738428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ToInventoryBufferList<T>(
      ref NativeList<InventoryBuffer> output,
      NativeArray<T> requirements,
      float modifier = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref output;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &requirements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.MethodInfoStoreGeneric_ToInventoryBufferList_Public_Static_Void_byref_NativeList_1_InventoryBuffer_NativeArray_1_T_Single_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 738431, RefRangeEnd = 738432, XrefRangeStart = 738429, XrefRangeEnd = 738431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ItemHasComponent<T>(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      PrefabGUID itemId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryUtilities.MethodInfoStoreGeneric_ItemHasComponent_Public_Static_Boolean_EntityManager_PrefabCollectionSystem_PrefabGUID_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InventoryUtilities()
    {
      Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InventoryUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665137);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_NativeArray_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665138);
      InventoryUtilities.NativeMethodInfoPtr__TryGetInventoryFromInventoryEntity_Private_Static_Boolean_BufferFromEntity_1_InventoryBuffer_Entity_byref_NativeArray_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665139);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665140);
      InventoryUtilities.NativeMethodInfoPtr__TryGetInventoryFromInventoryEntity_Private_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665141);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryReadOnlyWithoutCopy_Public_Static_Boolean_EntityManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665142);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_ClientGameManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665143);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventory_Public_Static_Boolean_ServerGameManager_Entity_byref_NativeArray_1_InventoryBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665144);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665145);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_byref_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665146);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_InventoryInstanceElement_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665147);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_EntityManager_Entity_byref_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665148);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665149);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_ClientGameManager_Entity_byref_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665150);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_ClientGameManager_Entity_byref_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665151);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntities_Public_Static_Boolean_ServerGameManager_Entity_byref_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665152);
      InventoryUtilities.NativeMethodInfoPtr_TryGetInventoryEntity_Public_Static_Boolean_ServerGameManager_Entity_byref_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665153);
      InventoryUtilities.NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_EntityManager_Entity_PrefabGUID_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665154);
      InventoryUtilities.NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_PrefabGUID_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665155);
      InventoryUtilities.NativeMethodInfoPtr_GetItemAmount_Private_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665156);
      InventoryUtilities.NativeMethodInfoPtr_GetItemAmount_Public_Static_Int32_EntityManager_NativeList_1_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665157);
      InventoryUtilities.NativeMethodInfoPtr_GetItemAmountInInventories_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665158);
      InventoryUtilities.NativeMethodInfoPtr_HasItemInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665159);
      InventoryUtilities.NativeMethodInfoPtr_HasItemsInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_NativeList_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665160);
      InventoryUtilities.NativeMethodInfoPtr_HasItemsInInventories_Public_Static_Boolean_EntityManager_NativeList_1_Entity_NativeList_1_InventoryBuffer_byref_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665161);
      InventoryUtilities.NativeMethodInfoPtr_HasFreeStackSpaceOfType_Public_Static_Boolean_EntityManager_Entity_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665162);
      InventoryUtilities.NativeMethodInfoPtr_ItemAllowedInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_ItemCategory_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665163);
      InventoryUtilities.NativeMethodInfoPtr_HasFreeStackSpaceForItems_Public_Static_Boolean_EntityManager_Entity_NativeHashMap_2_PrefabGUID_ItemData_NativeArray_1_RecipeOutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665164);
      InventoryUtilities.NativeMethodInfoPtr_CanCraftRecipe_Public_Static_Boolean_NativeHashMap_2_PrefabGUID_RecipeData_EntityManager_Entity_PrefabGUID_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665165);
      InventoryUtilities.NativeMethodInfoPtr_GetMatchingRecipe_Public_Static_PrefabGUID_EntityManager_DynamicBuffer_1_RefinementstationRecipesBuffer_NativeHashMap_2_PrefabGUID_RecipeData_Entity_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665166);
      InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_byref_Int32_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665167);
      InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_Int32_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665168);
      InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665169);
      InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_EntityManager_Entity_Entity_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665170);
      InventoryUtilities.NativeMethodInfoPtr__HasComplexItemInInventory_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665171);
      InventoryUtilities.NativeMethodInfoPtr_HasItemInInventory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665172);
      InventoryUtilities.NativeMethodInfoPtr_HasItemOfCategory_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665173);
      InventoryUtilities.NativeMethodInfoPtr_HasItemOfCategory_Public_Static_Boolean_NativeArray_1_InventoryBuffer_NativeHashMap_2_PrefabGUID_ItemData_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665174);
      InventoryUtilities.NativeMethodInfoPtr_ItemOfCategoryCount_Public_Static_Int32_PrefabLookupMap_BufferFromEntity_1_InventoryInstanceElement_BufferFromEntity_1_InventoryBuffer_Entity_ItemCategory_ComponentDataFromEntity_1_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665175);
      InventoryUtilities.NativeMethodInfoPtr_HasEmptySlots_Public_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665176);
      InventoryUtilities.NativeMethodInfoPtr_GetFreeSlotsCount_Public_Static_Int32_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665177);
      InventoryUtilities.NativeMethodInfoPtr_GetUsedSlotsCount_Public_Static_Int32_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665178);
      InventoryUtilities.NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_DynamicBuffer_1_InventoryBuffer_Int32_byref_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665179);
      InventoryUtilities.NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_EntityManager_Entity_Int32_byref_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665180);
      InventoryUtilities.NativeMethodInfoPtr_TryGetItemAtSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_Int32_byref_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665181);
      InventoryUtilities.NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_EntityManager_Entity_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665182);
      InventoryUtilities.NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665183);
      InventoryUtilities.NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665184);
      InventoryUtilities.NativeMethodInfoPtr_GetItemSlot_Public_Static_Int32_NativeArray_1_InventoryBuffer_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665185);
      InventoryUtilities.NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665186);
      InventoryUtilities.NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_PrefabGUID_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665187);
      InventoryUtilities.NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_EntityManager_Entity_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665188);
      InventoryUtilities.NativeMethodInfoPtr_TryGetItemSlot_Public_Static_Boolean_NativeArray_1_InventoryBuffer_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665189);
      InventoryUtilities.NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_InventoryInstanceElement_BufferFromEntity_1_InventoryBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665190);
      InventoryUtilities.NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665191);
      InventoryUtilities.NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665192);
      InventoryUtilities.NativeMethodInfoPtr_TryGetMainInventoryIndex_Public_Static_Boolean_EntityManager_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665193);
      InventoryUtilities.NativeMethodInfoPtr_TryGetMainInventoryEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665194);
      InventoryUtilities.NativeMethodInfoPtr_IsInventoryEmpty_Public_Static_Boolean_NativeArray_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665195);
      InventoryUtilities.NativeMethodInfoPtr_IsInventoryFull_Public_Static_Boolean_NativeArray_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665196);
      InventoryUtilities.NativeMethodInfoPtr_IsInventoryFull_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665197);
      InventoryUtilities.NativeMethodInfoPtr_GetItemDataFromType_Public_Static_ItemData_NativeHashMap_2_PrefabGUID_ItemData_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665198);
      InventoryUtilities.NativeMethodInfoPtr_GetInventorySize_Public_Static_Int32_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665199);
      InventoryUtilities.NativeMethodInfoPtr_GetInventorySize_Public_Static_Int32_BufferFromEntity_1_InventoryBuffer_BufferFromEntity_1_InventoryInstanceElement_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665200);
      InventoryUtilities.NativeMethodInfoPtr_GetItemSlotsReadOnly_Public_Static_Int32_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665201);
      InventoryUtilities.NativeMethodInfoPtr_ToInventoryBufferList_Public_Static_Void_byref_NativeList_1_InventoryBuffer_NativeArray_1_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665202);
      InventoryUtilities.NativeMethodInfoPtr_ItemHasComponent_Public_Static_Boolean_EntityManager_PrefabCollectionSystem_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, 100665203);
    }

    public InventoryUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SlotEntryThing
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_RestrictedItemCategory;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
      [FieldOffset(0)]
      public PrefabGUID Type;
      [FieldOffset(8)]
      public ItemCategory RestrictedItemCategory;
      [FieldOffset(16)]
      public int MaxAmount;
      [FieldOffset(20)]
      public int Amount;

      static SlotEntryThing()
      {
        Il2CppClassPointerStore<InventoryUtilities.SlotEntryThing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr, nameof (SlotEntryThing));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryUtilities.SlotEntryThing>.NativeClassPtr);
        InventoryUtilities.SlotEntryThing.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilities.SlotEntryThing>.NativeClassPtr, nameof (Type));
        InventoryUtilities.SlotEntryThing.NativeFieldInfoPtr_RestrictedItemCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilities.SlotEntryThing>.NativeClassPtr, nameof (RestrictedItemCategory));
        InventoryUtilities.SlotEntryThing.NativeFieldInfoPtr_MaxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilities.SlotEntryThing>.NativeClassPtr, nameof (MaxAmount));
        InventoryUtilities.SlotEntryThing.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryUtilities.SlotEntryThing>.NativeClassPtr, nameof (Amount));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryUtilities.SlotEntryThing>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    private sealed class MethodInfoStoreGeneric_ToInventoryBufferList_Public_Static_Void_byref_NativeList_1_InventoryBuffer_NativeArray_1_T_Single_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(InventoryUtilities.NativeMethodInfoPtr_ToInventoryBufferList_Public_Static_Void_byref_NativeList_1_InventoryBuffer_NativeArray_1_T_Single_0, Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ItemHasComponent_Public_Static_Boolean_EntityManager_PrefabCollectionSystem_PrefabGUID_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(InventoryUtilities.NativeMethodInfoPtr_ItemHasComponent_Public_Static_Boolean_EntityManager_PrefabCollectionSystem_PrefabGUID_0, Il2CppClassPointerStore<InventoryUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
