// Decompiled with JetBrains decompiler
// Type: ProjectM.InventoryUtilities_Events
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class InventoryUtilities_Events : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryUseItem_Public_Static_Void_EntityManager_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryEquipItem_Public_Static_Void_EntityManager_PrefabGUID_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryEquipServantItem_Public_Static_Void_EntityManager_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryTransferEquipment_Public_Static_Void_EntityManager_Entity_EquipmentType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryEquipItemFromInventory_Public_Static_Void_EntityManager_NetworkId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryEquipServantItemFromInventory_Public_Static_Void_EntityManager_Entity_NetworkId_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryUnEquipItem_Public_Static_Void_EntityManager_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryUnEquipItem_Public_Static_Void_EntityManager_EquipmentType_Int32_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryUnEquipServantItem_Public_Static_Void_EntityManager_EquipmentType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryUnEquipServantItem_Public_Static_Void_EntityManager_EquipmentType_Int32_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryDropItem_Public_Static_Void_EntityManager_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryDropEquippedItem_Public_Static_Void_EntityManager_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryEquipBag_Public_Static_Void_EntityManager_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryEquipBagFromInventory_Public_Static_Void_EntityManager_NetworkId_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTrySwapBagSlots_Public_Static_Void_EntityManager_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryUnEquipBag_Public_Static_Void_EntityManager_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryUnEquipBagIntoInventory_Public_Static_Void_EntityManager_Int32_NetworkId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryDropEquippedBag_Public_Static_Void_EntityManager_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTryEquipJewel_Public_Static_Void_EntityManager_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1020174, RefRangeEnd = 1020176, XrefRangeStart = 1020168, XrefRangeEnd = 1020174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryUseItem(
      EntityManager entityManager,
      int slotIndex,
      Entity targetItem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetItem;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUseItem_Public_Static_Void_EntityManager_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1020179, RefRangeEnd = 1020181, XrefRangeStart = 1020176, XrefRangeEnd = 1020179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryEquipItem(
      EntityManager entityManager,
      PrefabGUID itemId,
      int slotIndex,
      bool isInventoryEquipped)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isInventoryEquipped;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipItem_Public_Static_Void_EntityManager_PrefabGUID_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1020187, RefRangeEnd = 1020188, XrefRangeStart = 1020181, XrefRangeEnd = 1020187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryEquipServantItem(
      EntityManager entityManager,
      Entity toEntity,
      int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipServantItem_Public_Static_Void_EntityManager_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1020194, RefRangeEnd = 1020196, XrefRangeStart = 1020188, XrefRangeEnd = 1020194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryTransferEquipment(
      EntityManager entityManager,
      Entity toEntity,
      EquipmentType equipmentType,
      bool fromServant)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fromServant;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryTransferEquipment_Public_Static_Void_EntityManager_Entity_EquipmentType_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020196, XrefRangeEnd = 1020199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryEquipItemFromInventory(
      EntityManager entityManager,
      NetworkId fromInventory,
      int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipItemFromInventory_Public_Static_Void_EntityManager_NetworkId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020199, XrefRangeEnd = 1020205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryEquipServantItemFromInventory(
      EntityManager entityManager,
      Entity toEntity,
      NetworkId fromInventory,
      int slotIndex,
      bool isInventoryEquipped)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isInventoryEquipped;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipServantItemFromInventory_Public_Static_Void_EntityManager_Entity_NetworkId_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1020208, RefRangeEnd = 1020211, XrefRangeStart = 1020205, XrefRangeEnd = 1020208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryUnEquipItem(
      EntityManager entityManager,
      EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipItem_Public_Static_Void_EntityManager_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1020214, RefRangeEnd = 1020216, XrefRangeStart = 1020211, XrefRangeEnd = 1020214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryUnEquipItem(
      EntityManager entityManager,
      EquipmentType equipmentType,
      int toSlotIndex,
      NetworkId toInventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventory;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipItem_Public_Static_Void_EntityManager_EquipmentType_Int32_NetworkId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1020222, RefRangeEnd = 1020226, XrefRangeStart = 1020216, XrefRangeEnd = 1020222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryUnEquipServantItem(
      EntityManager entityManager,
      EquipmentType equipmentType,
      Entity fromEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipServantItem_Public_Static_Void_EntityManager_EquipmentType_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020226, XrefRangeEnd = 1020232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryUnEquipServantItem(
      EntityManager entityManager,
      EquipmentType equipmentType,
      int toSlotIndex,
      NetworkId toInventory,
      Entity fromEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fromEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipServantItem_Public_Static_Void_EntityManager_EquipmentType_Int32_NetworkId_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1020235, RefRangeEnd = 1020238, XrefRangeStart = 1020232, XrefRangeEnd = 1020235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryDropItem(EntityManager entityManager, int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryDropItem_Public_Static_Void_EntityManager_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1020241, RefRangeEnd = 1020243, XrefRangeStart = 1020238, XrefRangeEnd = 1020241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryDropEquippedItem(
      EntityManager entityManager,
      EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryDropEquippedItem_Public_Static_Void_EntityManager_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1020246, RefRangeEnd = 1020247, XrefRangeStart = 1020243, XrefRangeEnd = 1020246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryEquipBag(
      EntityManager entityManager,
      int slotIndex,
      int toBagSlotIndex = -1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toBagSlotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipBag_Public_Static_Void_EntityManager_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1020250, RefRangeEnd = 1020251, XrefRangeStart = 1020247, XrefRangeEnd = 1020250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryEquipBagFromInventory(
      EntityManager entityManager,
      NetworkId fromInventory,
      int slotIndex,
      int toBagSlotIndex = -1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toBagSlotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipBagFromInventory_Public_Static_Void_EntityManager_NetworkId_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1020254, RefRangeEnd = 1020256, XrefRangeStart = 1020251, XrefRangeEnd = 1020254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTrySwapBagSlots(
      EntityManager entityManager,
      int fromSlotIndex,
      int toSlotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toSlotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTrySwapBagSlots_Public_Static_Void_EntityManager_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1020259, RefRangeEnd = 1020260, XrefRangeStart = 1020256, XrefRangeEnd = 1020259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryUnEquipBag(
      EntityManager entityManager,
      int fromBagSlotIndex,
      int toInventorySlotIndex = -1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromBagSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventorySlotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipBag_Public_Static_Void_EntityManager_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020260, XrefRangeEnd = 1020263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryUnEquipBagIntoInventory(
      EntityManager entityManager,
      int fromBagSlotIndex,
      NetworkId toInventory,
      int toInventorySlotIndex = -1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromBagSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventorySlotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipBagIntoInventory_Public_Static_Void_EntityManager_Int32_NetworkId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryDropEquippedBag(EntityManager entityManager, int hoveredIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hoveredIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryDropEquippedBag_Public_Static_Void_EntityManager_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1020266, RefRangeEnd = 1020268, XrefRangeStart = 1020263, XrefRangeEnd = 1020266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendTryEquipJewel(EntityManager entityManager, int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipJewel_Public_Static_Void_EntityManager_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventoryUtilities_Events()
    {
      Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InventoryUtilities_Events));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUseItem_Public_Static_Void_EntityManager_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679615);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipItem_Public_Static_Void_EntityManager_PrefabGUID_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679616);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipServantItem_Public_Static_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679617);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryTransferEquipment_Public_Static_Void_EntityManager_Entity_EquipmentType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679618);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipItemFromInventory_Public_Static_Void_EntityManager_NetworkId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679619);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipServantItemFromInventory_Public_Static_Void_EntityManager_Entity_NetworkId_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679620);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipItem_Public_Static_Void_EntityManager_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679621);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipItem_Public_Static_Void_EntityManager_EquipmentType_Int32_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679622);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipServantItem_Public_Static_Void_EntityManager_EquipmentType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679623);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipServantItem_Public_Static_Void_EntityManager_EquipmentType_Int32_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679624);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryDropItem_Public_Static_Void_EntityManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679625);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryDropEquippedItem_Public_Static_Void_EntityManager_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679626);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipBag_Public_Static_Void_EntityManager_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679627);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipBagFromInventory_Public_Static_Void_EntityManager_NetworkId_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679628);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTrySwapBagSlots_Public_Static_Void_EntityManager_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679629);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipBag_Public_Static_Void_EntityManager_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679630);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryUnEquipBagIntoInventory_Public_Static_Void_EntityManager_Int32_NetworkId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679631);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryDropEquippedBag_Public_Static_Void_EntityManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679632);
      InventoryUtilities_Events.NativeMethodInfoPtr_SendTryEquipJewel_Public_Static_Void_EntityManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryUtilities_Events>.NativeClassPtr, 100679633);
    }

    public InventoryUtilities_Events(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
