// Decompiled with JetBrains decompiler
// Type: ProjectM.JewelEquipUtilitiesServer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class JewelEquipUtilitiesServer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryEquipJewelSwap_Public_Static_EquipJewelResult_byref_EntityManager_byref_PrefabLookupMap_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryEquipJewel_Public_Static_EquipJewelResult_byref_EntityManager_byref_PrefabLookupMap_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnequipJewel_Public_Static_Boolean_EntityManager_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryEquipJewel_Internal_Private_Static_EquipJewelResult_EntityManager_byref_PrefabLookupMap_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Boolean_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddAbilityJewelToInventory_Private_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_AbilitySpellModItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAbilityGroupJewel_Private_Static_Void_EntityManager_Entity_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetEquippedJewel_Public_Static_Boolean_EntityManager_Entity_Entity_byref_Entity_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1036448, RefRangeEnd = 1036451, XrefRangeStart = 1036447, XrefRangeEnd = 1036448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EquipJewelResult TryEquipJewelSwap(
      [In] ref EntityManager entityManager,
      [In] ref PrefabLookupMap prefabLookup,
      [In] ref NativeHashMap<PrefabGUID, ItemData> itemLookup,
      Entity inventoryTarget,
      int inventorySlotIndex,
      out PrefabGUID equippedJewel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &inventorySlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref equippedJewel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryEquipJewelSwap_Public_Static_EquipJewelResult_byref_EntityManager_byref_PrefabLookupMap_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipJewelResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036451, XrefRangeEnd = 1036452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EquipJewelResult TryEquipJewel(
      [In] ref EntityManager entityManager,
      [In] ref PrefabLookupMap prefabLookup,
      Entity inventoryTarget,
      int inventorySlotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventorySlotIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryEquipJewel_Public_Static_EquipJewelResult_byref_EntityManager_byref_PrefabLookupMap_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipJewelResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1036458, RefRangeEnd = 1036461, XrefRangeStart = 1036452, XrefRangeEnd = 1036458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryUnequipJewel(
      EntityManager entityManager,
      [In] ref NativeHashMap<PrefabGUID, ItemData> itemLookup,
      Entity inventoryTarget,
      Entity abilityGroup)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroup;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryUnequipJewel_Public_Static_Boolean_EntityManager_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1036485, RefRangeEnd = 1036487, XrefRangeStart = 1036461, XrefRangeEnd = 1036485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EquipJewelResult TryEquipJewel_Internal(
      EntityManager entityManager,
      [In] ref PrefabLookupMap prefabLookup,
      [In] ref NativeHashMap<PrefabGUID, ItemData> itemLookup,
      Entity inventoryTarget,
      int inventorySlotIndex,
      bool swap,
      out PrefabGUID equippedJewel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &inventorySlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &swap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref equippedJewel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryEquipJewel_Internal_Private_Static_EquipJewelResult_EntityManager_byref_PrefabLookupMap_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Boolean_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipJewelResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1036495, RefRangeEnd = 1036496, XrefRangeStart = 1036487, XrefRangeEnd = 1036495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryAddAbilityJewelToInventory(
      [In] ref EntityManager entityManager,
      [In] ref NativeHashMap<PrefabGUID, ItemData> itemLookup,
      Entity inventoryTarget,
      AbilitySpellModItem abilitySpellModItem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilitySpellModItem;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryAddAbilityJewelToInventory_Private_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_AbilitySpellModItem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1036535, RefRangeEnd = 1036536, XrefRangeStart = 1036496, XrefRangeEnd = 1036535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateAbilityGroupJewel(
      EntityManager entityManager,
      Entity abilityGroupEntity,
      Entity newJewel,
      Entity oldJewel = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newJewel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &oldJewel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelEquipUtilitiesServer.NativeMethodInfoPtr_UpdateAbilityGroupJewel_Private_Static_Void_EntityManager_Entity_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1036546, RefRangeEnd = 1036550, XrefRangeStart = 1036536, XrefRangeEnd = 1036546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetEquippedJewel(
      EntityManager entityManager,
      Entity localCharacterEntity,
      Entity jewelEntity,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jewelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryGetEquippedJewel_Public_Static_Boolean_EntityManager_Entity_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static JewelEquipUtilitiesServer()
    {
      Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JewelEquipUtilitiesServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr);
      JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryEquipJewelSwap_Public_Static_EquipJewelResult_byref_EntityManager_byref_PrefabLookupMap_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr, 100681110);
      JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryEquipJewel_Public_Static_EquipJewelResult_byref_EntityManager_byref_PrefabLookupMap_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr, 100681111);
      JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryUnequipJewel_Public_Static_Boolean_EntityManager_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr, 100681112);
      JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryEquipJewel_Internal_Private_Static_EquipJewelResult_EntityManager_byref_PrefabLookupMap_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_Int32_Boolean_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr, 100681113);
      JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryAddAbilityJewelToInventory_Private_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_ItemData_Entity_AbilitySpellModItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr, 100681114);
      JewelEquipUtilitiesServer.NativeMethodInfoPtr_UpdateAbilityGroupJewel_Private_Static_Void_EntityManager_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr, 100681115);
      JewelEquipUtilitiesServer.NativeMethodInfoPtr_TryGetEquippedJewel_Public_Static_Boolean_EntityManager_Entity_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelEquipUtilitiesServer>.NativeClassPtr, 100681116);
    }

    public JewelEquipUtilitiesServer(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
