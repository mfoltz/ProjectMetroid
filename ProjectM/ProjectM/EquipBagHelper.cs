// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipBagHelper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class EquipBagHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryEquipBag_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_Entity_Entity_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnEquipBag_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_Entity_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindCompatibleBagSlot_Public_Static_Int32_EntityManager_BagHolder_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValidBagSlot_Public_Static_Boolean_EntityManager_BagHolder_Entity_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BagsAreCompatibleForSwap_Private_Static_Boolean_EntityManager_BagHolder_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestrictedSlotsCompatible_Private_Static_Boolean_Restricted_InventoryBuffer_Restricted_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckValidBagSlotIndex_Public_Static_Boolean_EntityManager_BagHolder_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1016426, RefRangeEnd = 1016428, XrefRangeStart = 1016356, XrefRangeEnd = 1016426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryEquipBag(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Entity userEntity,
      Entity ownerEntity,
      Entity fromInventoryEntity,
      int fromInventorySlotIndex,
      int toBagSlotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ownerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventorySlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &toBagSlotIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipBagHelper.NativeMethodInfoPtr_TryEquipBag_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_Entity_Entity_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1016469, RefRangeEnd = 1016471, XrefRangeStart = 1016428, XrefRangeEnd = 1016469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUnEquipBag(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Entity bagOwnerEntity,
      Entity inventoryEntity,
      int fromBagSlotIndex,
      int toInventorySlot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bagOwnerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fromBagSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventorySlot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipBagHelper.NativeMethodInfoPtr_TryUnEquipBag_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_Entity_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1016523, RefRangeEnd = 1016525, XrefRangeStart = 1016471, XrefRangeEnd = 1016523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int FindCompatibleBagSlot(
      EntityManager entityManager,
      BagHolder bagHolder,
      Entity incomingBagEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagHolder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &incomingBagEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipBagHelper.NativeMethodInfoPtr_FindCompatibleBagSlot_Public_Static_Int32_EntityManager_BagHolder_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016525, XrefRangeEnd = 1016528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetValidBagSlot(
      EntityManager entityManager,
      BagHolder bagHolder,
      Entity incomingBagEntity,
      int initialBagSlot,
      out int bagSlot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagHolder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &incomingBagEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &initialBagSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref bagSlot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipBagHelper.NativeMethodInfoPtr_TryGetValidBagSlot_Public_Static_Boolean_EntityManager_BagHolder_Entity_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1016556, RefRangeEnd = 1016558, XrefRangeStart = 1016528, XrefRangeEnd = 1016556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool BagsAreCompatibleForSwap(
      EntityManager entityManager,
      BagHolder bagHolder,
      int bagSlotIndex,
      Entity incomingBagEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagHolder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bagSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &incomingBagEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipBagHelper.NativeMethodInfoPtr_BagsAreCompatibleForSwap_Private_Static_Boolean_EntityManager_BagHolder_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016558, XrefRangeEnd = 1016561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RestrictedSlotsCompatible(
      Restricted_InventoryBuffer b1,
      Restricted_InventoryBuffer b2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &b1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipBagHelper.NativeMethodInfoPtr_RestrictedSlotsCompatible_Private_Static_Boolean_Restricted_InventoryBuffer_Restricted_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1016561, RefRangeEnd = 1016563, XrefRangeStart = 1016561, XrefRangeEnd = 1016561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckValidBagSlotIndex(
      EntityManager entityManager,
      BagHolder bagHolder,
      int bagSlot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagHolder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bagSlot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipBagHelper.NativeMethodInfoPtr_CheckValidBagSlotIndex_Public_Static_Boolean_EntityManager_BagHolder_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EquipBagHelper()
    {
      Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EquipBagHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr);
      EquipBagHelper.NativeMethodInfoPtr_TryEquipBag_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_Entity_Entity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr, 100679278);
      EquipBagHelper.NativeMethodInfoPtr_TryUnEquipBag_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_Entity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr, 100679279);
      EquipBagHelper.NativeMethodInfoPtr_FindCompatibleBagSlot_Public_Static_Int32_EntityManager_BagHolder_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr, 100679280);
      EquipBagHelper.NativeMethodInfoPtr_TryGetValidBagSlot_Public_Static_Boolean_EntityManager_BagHolder_Entity_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr, 100679281);
      EquipBagHelper.NativeMethodInfoPtr_BagsAreCompatibleForSwap_Private_Static_Boolean_EntityManager_BagHolder_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr, 100679282);
      EquipBagHelper.NativeMethodInfoPtr_RestrictedSlotsCompatible_Private_Static_Boolean_Restricted_InventoryBuffer_Restricted_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr, 100679283);
      EquipBagHelper.NativeMethodInfoPtr_CheckValidBagSlotIndex_Public_Static_Boolean_EntityManager_BagHolder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagHelper>.NativeClassPtr, 100679284);
    }

    public EquipBagHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
