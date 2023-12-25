// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InventoryDragHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public static class InventoryDragHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_1_NetworkId_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBagInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_NetworkId_Int32_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupServantInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Entity_NetworkId_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_1_NetworkId_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBagInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_NetworkId_Int32_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupServantInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Entity_NetworkId_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupUnequipItemSlot_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupEquipmentSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupServantEquipmentSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupEquipmentSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_EquipmentType_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBagSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBagSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_Entity_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupServantEquipmentSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Int32_EquipmentType_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupStandardInventorySubMenu_Public_Static_Void_EntityManager_PrefabCollectionSystem_InventorySubMenu_Entity_Func_1_NetworkId_Func_2_Int32_NetworkId_UISoundMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupServantInventorySubMenu_Public_Static_Void_EntityManager_PrefabCollectionSystem_ServantInventorySubMenu_Entity_Func_2_Entity_Entity_Func_2_Entity_NetworkId_UISoundMapping_0;

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 1236688, RefRangeEnd = 1236702, XrefRangeStart = 1236671, XrefRangeEnd = 1236688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupInventoryBeginDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup,
      Il2CppSystem.Func<NetworkId> getFromInventory,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getFromInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_1_NetworkId_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236702, XrefRangeEnd = 1236718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupBagInventoryBeginDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup,
      Il2CppSystem.Func<int, NetworkId> getBagFromInventory,
      int bagIndex,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getBagFromInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bagIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupBagInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_NetworkId_Int32_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236718, XrefRangeEnd = 1236735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupServantInventoryBeginDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup,
      Entity menuEntity,
      Il2CppSystem.Func<Entity, NetworkId> getFromInventory,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &menuEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getFromInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupServantInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Entity_NetworkId_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 1236751, RefRangeEnd = 1236765, XrefRangeStart = 1236735, XrefRangeEnd = 1236751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupInventoryEndDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup,
      Il2CppSystem.Func<NetworkId> getToInventory,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getToInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_1_NetworkId_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236765, XrefRangeEnd = 1236781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupBagInventoryEndDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup,
      Il2CppSystem.Func<int, NetworkId> getBagToInventory,
      int bagIndex,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getBagToInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bagIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupBagInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_NetworkId_Int32_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236781, XrefRangeEnd = 1236797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupServantInventoryEndDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup,
      Entity menuEntity,
      Il2CppSystem.Func<Entity, NetworkId> getToInventory,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &menuEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getToInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupServantInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Entity_NetworkId_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236797, XrefRangeEnd = 1236811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupUnequipItemSlot(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup,
      Il2CppSystem.Func<int, EquipmentType> getSlotEquipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getSlotEquipmentType);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupUnequipItemSlot_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1236827, RefRangeEnd = 1236831, XrefRangeStart = 1236811, XrefRangeEnd = 1236827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupEquipmentSlotEndDrag(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupEquipmentSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1236847, RefRangeEnd = 1236850, XrefRangeStart = 1236831, XrefRangeEnd = 1236847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupServantEquipmentSlotEndDrag(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup,
      Entity servantEntity,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &servantEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupServantEquipmentSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1236866, RefRangeEnd = 1236870, XrefRangeStart = 1236850, XrefRangeEnd = 1236866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupEquipmentSlotBeginDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup,
      Il2CppSystem.Func<int, EquipmentType> getSlotEquipmentType,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getSlotEquipmentType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupEquipmentSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_EquipmentType_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236870, XrefRangeEnd = 1236885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupBagSlotBeginDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupBagSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236885, XrefRangeEnd = 1236900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupBagSlotEndDrag(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      Entity localCharacterEntity,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupBagSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_Entity_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1236916, RefRangeEnd = 1236919, XrefRangeStart = 1236900, XrefRangeEnd = 1236916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupServantEquipmentSlotBeginDrag(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup,
      Entity servantEntity,
      Il2CppSystem.Func<int, EquipmentType> getSlotEquipmentType,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &servantEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getSlotEquipmentType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupServantEquipmentSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Int32_EquipmentType_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1237050, RefRangeEnd = 1237051, XrefRangeStart = 1236919, XrefRangeEnd = 1237050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupStandardInventorySubMenu(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      InventorySubMenu inventorySubMenu,
      Entity localCharacterEntity,
      Il2CppSystem.Func<NetworkId> getFromInventory,
      Il2CppSystem.Func<int, NetworkId> getBagFromInventory,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySubMenu);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getFromInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getBagFromInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupStandardInventorySubMenu_Public_Static_Void_EntityManager_PrefabCollectionSystem_InventorySubMenu_Entity_Func_1_NetworkId_Func_2_Int32_NetworkId_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1237112, RefRangeEnd = 1237113, XrefRangeStart = 1237051, XrefRangeEnd = 1237112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupServantInventorySubMenu(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      ServantInventorySubMenu inventorySubMenu,
      Entity menuEntity,
      Il2CppSystem.Func<Entity, Entity> getServantTarget,
      Il2CppSystem.Func<Entity, NetworkId> getFromInventory,
      UISoundMapping soundMapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySubMenu);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &menuEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getServantTarget);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getFromInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.NativeMethodInfoPtr_SetupServantInventorySubMenu_Public_Static_Void_EntityManager_PrefabCollectionSystem_ServantInventorySubMenu_Entity_Func_2_Entity_Entity_Func_2_Entity_NetworkId_UISoundMapping_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventoryDragHelper()
    {
      Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InventoryDragHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr);
      InventoryDragHelper.NativeMethodInfoPtr_SetupInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_1_NetworkId_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665809);
      InventoryDragHelper.NativeMethodInfoPtr_SetupBagInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_NetworkId_Int32_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665810);
      InventoryDragHelper.NativeMethodInfoPtr_SetupServantInventoryBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Entity_NetworkId_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665811);
      InventoryDragHelper.NativeMethodInfoPtr_SetupInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_1_NetworkId_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665812);
      InventoryDragHelper.NativeMethodInfoPtr_SetupBagInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_NetworkId_Int32_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665813);
      InventoryDragHelper.NativeMethodInfoPtr_SetupServantInventoryEndDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Entity_NetworkId_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665814);
      InventoryDragHelper.NativeMethodInfoPtr_SetupUnequipItemSlot_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665815);
      InventoryDragHelper.NativeMethodInfoPtr_SetupEquipmentSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665816);
      InventoryDragHelper.NativeMethodInfoPtr_SetupServantEquipmentSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665817);
      InventoryDragHelper.NativeMethodInfoPtr_SetupEquipmentSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Func_2_Int32_EquipmentType_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665818);
      InventoryDragHelper.NativeMethodInfoPtr_SetupBagSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665819);
      InventoryDragHelper.NativeMethodInfoPtr_SetupBagSlotEndDrag_Public_Static_Void_EntityManager_PrefabCollectionSystem_Entity_GridSelectionGroup_2_ItemGridSelectionEntry_Data_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665820);
      InventoryDragHelper.NativeMethodInfoPtr_SetupServantEquipmentSlotBeginDrag_Public_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Entity_Func_2_Int32_EquipmentType_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665821);
      InventoryDragHelper.NativeMethodInfoPtr_SetupStandardInventorySubMenu_Public_Static_Void_EntityManager_PrefabCollectionSystem_InventorySubMenu_Entity_Func_1_NetworkId_Func_2_Int32_NetworkId_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665822);
      InventoryDragHelper.NativeMethodInfoPtr_SetupServantInventorySubMenu_Public_Static_Void_EntityManager_PrefabCollectionSystem_ServantInventorySubMenu_Entity_Func_2_Entity_Entity_Func_2_Entity_NetworkId_UISoundMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, 100665823);
    }

    public InventoryDragHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_inventorySelectionGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFromInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236420, XrefRangeEnd = 1236435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupInventoryBeginDrag_b__0(int itemIndex, PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &itemIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__SetupInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_inventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr, nameof (inventorySelectionGroup));
        InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_getFromInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr, nameof (getFromInventory));
        InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr, nameof (soundMapping));
        InventoryDragHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr, 100665824);
        InventoryDragHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__SetupInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass0_0>.NativeClassPtr, 100665825);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_inventorySelectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_inventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe Il2CppSystem.Func<NetworkId> getFromInventory
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_getFromInventory));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<NetworkId>) null : new Il2CppSystem.Func<NetworkId>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_getFromInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UISoundMapping soundMapping
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_soundMapping));
          return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass1_0")]
    public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_inventorySelectionGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBagFromInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_bagIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupBagInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass1_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236435, XrefRangeEnd = 1236479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupBagInventoryBeginDrag_b__0(int itemIndex, PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &itemIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass1_0.NativeMethodInfoPtr__SetupBagInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass1_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass1_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_inventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr, nameof (inventorySelectionGroup));
        InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_getBagFromInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr, nameof (getBagFromInventory));
        InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_bagIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr, nameof (bagIndex));
        InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr, nameof (soundMapping));
        InventoryDragHelper.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr, 100665826);
        InventoryDragHelper.__c__DisplayClass1_0.NativeMethodInfoPtr__SetupBagInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass1_0>.NativeClassPtr, 100665827);
      }

      public __c__DisplayClass1_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_inventorySelectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_inventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe Il2CppSystem.Func<int, NetworkId> getBagFromInventory
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_getBagFromInventory));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, NetworkId>) null : new Il2CppSystem.Func<int, NetworkId>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_getBagFromInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int bagIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_bagIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_bagIndex)) = value;
        }
      }

      public unsafe UISoundMapping soundMapping
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_soundMapping));
          return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_inventorySelectionGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFromInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_menuEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupServantInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236479, XrefRangeEnd = 1236494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupServantInventoryBeginDrag_b__0(
        int itemIndex,
        PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &itemIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass2_0.NativeMethodInfoPtr__SetupServantInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_inventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr, nameof (inventorySelectionGroup));
        InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_getFromInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr, nameof (getFromInventory));
        InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_menuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr, nameof (menuEntity));
        InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr, nameof (soundMapping));
        InventoryDragHelper.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr, 100665828);
        InventoryDragHelper.__c__DisplayClass2_0.NativeMethodInfoPtr__SetupServantInventoryBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass2_0>.NativeClassPtr, 100665829);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_inventorySelectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_inventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe Il2CppSystem.Func<Entity, NetworkId> getFromInventory
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_getFromInventory));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, NetworkId>) null : new Il2CppSystem.Func<Entity, NetworkId>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_getFromInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity menuEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_menuEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_menuEntity)) = value;
        }
      }

      public unsafe UISoundMapping soundMapping
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_soundMapping));
          return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getToInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_inventorySelectionGroup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupInventoryEndDrag_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236494, XrefRangeEnd = 1236511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupInventoryEndDrag_b__0(int itemIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &itemIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass3_0.NativeMethodInfoPtr__SetupInventoryEndDrag_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass3_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_getToInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass3_0>.NativeClassPtr, nameof (getToInventory));
        InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass3_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_inventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass3_0>.NativeClassPtr, nameof (inventorySelectionGroup));
        InventoryDragHelper.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass3_0>.NativeClassPtr, 100665830);
        InventoryDragHelper.__c__DisplayClass3_0.NativeMethodInfoPtr__SetupInventoryEndDrag_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass3_0>.NativeClassPtr, 100665831);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Func<NetworkId> getToInventory
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_getToInventory));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<NetworkId>) null : new Il2CppSystem.Func<NetworkId>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_getToInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_inventorySelectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass3_0.NativeFieldInfoPtr_inventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getBagToInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_bagIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_inventorySelectionGroup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupBagInventoryEndDrag_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236511, XrefRangeEnd = 1236532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupBagInventoryEndDrag_b__0(int itemIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &itemIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__SetupBagInventoryEndDrag_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_getBagToInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr, nameof (getBagToInventory));
        InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_bagIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr, nameof (bagIndex));
        InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_inventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr, nameof (inventorySelectionGroup));
        InventoryDragHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr, 100665832);
        InventoryDragHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__SetupBagInventoryEndDrag_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass4_0>.NativeClassPtr, 100665833);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Func<int, NetworkId> getBagToInventory
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_getBagToInventory));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, NetworkId>) null : new Il2CppSystem.Func<int, NetworkId>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_getBagToInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int bagIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_bagIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_bagIndex)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_inventorySelectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_inventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getToInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_menuEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_inventorySelectionGroup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupServantInventoryEndDrag_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236532, XrefRangeEnd = 1236547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupServantInventoryEndDrag_b__0(int itemIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &itemIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__SetupServantInventoryEndDrag_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_getToInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr, nameof (getToInventory));
        InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_menuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr, nameof (menuEntity));
        InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_inventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr, nameof (inventorySelectionGroup));
        InventoryDragHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr, 100665834);
        InventoryDragHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__SetupServantInventoryEndDrag_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass5_0>.NativeClassPtr, 100665835);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Func<Entity, NetworkId> getToInventory
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_getToInventory));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, NetworkId>) null : new Il2CppSystem.Func<Entity, NetworkId>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_getToInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity menuEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_menuEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_menuEntity)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_inventorySelectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_inventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSlotEquipmentType;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupUnequipItemSlot_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236547, XrefRangeEnd = 1236552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupUnequipItemSlot_b__0(int itemIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &itemIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass6_0.NativeMethodInfoPtr__SetupUnequipItemSlot_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass6_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass6_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_getSlotEquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass6_0>.NativeClassPtr, nameof (getSlotEquipmentType));
        InventoryDragHelper.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass6_0>.NativeClassPtr, 100665836);
        InventoryDragHelper.__c__DisplayClass6_0.NativeMethodInfoPtr__SetupUnequipItemSlot_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass6_0>.NativeClassPtr, 100665837);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe Il2CppSystem.Func<int, EquipmentType> getSlotEquipmentType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_getSlotEquipmentType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, EquipmentType>) null : new Il2CppSystem.Func<int, EquipmentType>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass6_0.NativeFieldInfoPtr_getSlotEquipmentType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
      private static readonly System.IntPtr NativeFieldInfoPtr_selectionGroup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupEquipmentSlotEndDrag_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236552, XrefRangeEnd = 1236567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupEquipmentSlotEndDrag_b__0(int itemIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &itemIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass7_0.NativeMethodInfoPtr__SetupEquipmentSlotEndDrag_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr, nameof (soundMapping));
        InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_selectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr, nameof (selectionGroup));
        InventoryDragHelper.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr, 100665838);
        InventoryDragHelper.__c__DisplayClass7_0.NativeMethodInfoPtr__SetupEquipmentSlotEndDrag_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass7_0>.NativeClassPtr, 100665839);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe UISoundMapping soundMapping
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_soundMapping));
          return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_selectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass7_0.NativeFieldInfoPtr_selectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
      private static readonly System.IntPtr NativeFieldInfoPtr_selectionGroup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupServantEquipmentSlotEndDrag_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236567, XrefRangeEnd = 1236582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupServantEquipmentSlotEndDrag_b__0(int itemIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &itemIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass8_0.NativeMethodInfoPtr__SetupServantEquipmentSlotEndDrag_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_servantEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr, nameof (servantEntity));
        InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr, nameof (soundMapping));
        InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_selectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr, nameof (selectionGroup));
        InventoryDragHelper.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr, 100665840);
        InventoryDragHelper.__c__DisplayClass8_0.NativeMethodInfoPtr__SetupServantEquipmentSlotEndDrag_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass8_0>.NativeClassPtr, 100665841);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe Entity servantEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_servantEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_servantEntity)) = value;
        }
      }

      public unsafe UISoundMapping soundMapping
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_soundMapping));
          return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_selectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_selectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_selectionGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSlotEquipmentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupEquipmentSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236582, XrefRangeEnd = 1236603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupEquipmentSlotBeginDrag_b__0(
        int itemIndex,
        PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &itemIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass9_0.NativeMethodInfoPtr__SetupEquipmentSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_selectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr, nameof (selectionGroup));
        InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_getSlotEquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr, nameof (getSlotEquipmentType));
        InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr, nameof (soundMapping));
        InventoryDragHelper.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr, 100665842);
        InventoryDragHelper.__c__DisplayClass9_0.NativeMethodInfoPtr__SetupEquipmentSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass9_0>.NativeClassPtr, 100665843);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_selectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_selectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<int, EquipmentType> getSlotEquipmentType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_getSlotEquipmentType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, EquipmentType>) null : new Il2CppSystem.Func<int, EquipmentType>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_getSlotEquipmentType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe UISoundMapping soundMapping
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_soundMapping));
          return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass9_0.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass10_0")]
    public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_selectionGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupBagSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass10_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236603, XrefRangeEnd = 1236623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupBagSlotBeginDrag_b__0(int itemIndex, PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &itemIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass10_0.NativeMethodInfoPtr__SetupBagSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass10_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_selectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass10_0>.NativeClassPtr, nameof (selectionGroup));
        InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass10_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass10_0>.NativeClassPtr, nameof (soundMapping));
        InventoryDragHelper.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass10_0>.NativeClassPtr, 100665844);
        InventoryDragHelper.__c__DisplayClass10_0.NativeMethodInfoPtr__SetupBagSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass10_0>.NativeClassPtr, 100665845);
      }

      public __c__DisplayClass10_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_selectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_selectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe UISoundMapping soundMapping
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_soundMapping));
          return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass10_0.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_localCharacterEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupBagSlotEndDrag_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236623, XrefRangeEnd = 1236651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupBagSlotEndDrag_b__0(int itemIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &itemIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__SetupBagSlotEndDrag_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass11_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass11_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass11_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_localCharacterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass11_0>.NativeClassPtr, nameof (localCharacterEntity));
        InventoryDragHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass11_0>.NativeClassPtr, 100665846);
        InventoryDragHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__SetupBagSlotEndDrag_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass11_0>.NativeClassPtr, 100665847);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localCharacterEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_localCharacterEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_localCharacterEntity)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryDragHelper/<>c__DisplayClass12_0")]
    public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_selectionGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSlotEquipmentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupServantEquipmentSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236651, XrefRangeEnd = 1236671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupServantEquipmentSlotBeginDrag_b__0(
        int itemIndex,
        PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &itemIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryDragHelper.__c__DisplayClass12_0.NativeMethodInfoPtr__SetupServantEquipmentSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDragHelper>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr);
        InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_selectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr, nameof (selectionGroup));
        InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_getSlotEquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr, nameof (getSlotEquipmentType));
        InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_servantEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr, nameof (servantEntity));
        InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr, nameof (entityManager));
        InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr, nameof (soundMapping));
        InventoryDragHelper.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr, 100665848);
        InventoryDragHelper.__c__DisplayClass12_0.NativeMethodInfoPtr__SetupServantEquipmentSlotBeginDrag_b__0_Internal_Void_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDragHelper.__c__DisplayClass12_0>.NativeClassPtr, 100665849);
      }

      public __c__DisplayClass12_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_selectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_selectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<int, EquipmentType> getSlotEquipmentType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_getSlotEquipmentType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, EquipmentType>) null : new Il2CppSystem.Func<int, EquipmentType>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_getSlotEquipmentType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity servantEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_servantEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_servantEntity)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe UISoundMapping soundMapping
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_soundMapping));
          return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryDragHelper.__c__DisplayClass12_0.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
