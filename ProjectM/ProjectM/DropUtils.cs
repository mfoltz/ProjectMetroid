// Decompiled with JetBrains decompiler
// Type: ProjectM.DropUtils
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class DropUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Random;
    private static readonly System.IntPtr NativeMethodInfoPtr_DropInInventory_Public_Static_Void_DropUtilsData_Entity_DropInInventoryOnSpawn_DynamicBuffer_1_DropTableBuffer_byref_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoDrops_Public_Static_Void_DropUtilsData_byref_DynamicBuffer_1_DropTableBuffer_DropTriggerType_byref_NativeList_1_DropItemInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoDrop_Public_Static_Void_DropUtilsData_byref_NativeList_1_DropItemInfo_DropTableData_DynamicBuffer_1_DropTableDataBuffer_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemFromGroup_Private_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_PrefabGUID_byref_PrefabGUID_byref_Int32_byref_DropItemType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014769, RefRangeEnd = 1014770, XrefRangeStart = 1014726, XrefRangeEnd = 1014769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DropInInventory(
      DropUtils.DropUtilsData dropUtilsData,
      Entity inventoryEntity,
      DropInInventoryOnSpawn dropInInventoryData,
      DynamicBuffer<DropTableBuffer> dropTables,
      [In] ref ServerGameBalanceSettings serverGameSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &dropUtilsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dropInInventoryData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dropTables;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverGameSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropUtils.NativeMethodInfoPtr_DropInInventory_Public_Static_Void_DropUtilsData_Entity_DropInInventoryOnSpawn_DynamicBuffer_1_DropTableBuffer_byref_ServerGameBalanceSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014794, RefRangeEnd = 1014795, XrefRangeStart = 1014770, XrefRangeEnd = 1014794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoDrops(
      DropUtils.DropUtilsData dropUtilsData,
      [In] ref DynamicBuffer<DropTableBuffer> dropTablesBuffer,
      DropTriggerType dropTrigger,
      ref NativeList<DropItemInfo> droppedItems)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &dropUtilsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropTablesBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dropTrigger;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref droppedItems;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropUtils.NativeMethodInfoPtr_DoDrops_Public_Static_Void_DropUtilsData_byref_DynamicBuffer_1_DropTableBuffer_DropTriggerType_byref_NativeList_1_DropItemInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1014848, RefRangeEnd = 1014852, XrefRangeStart = 1014795, XrefRangeEnd = 1014848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoDrop(
      DropUtils.DropUtilsData dropUtilsData,
      ref NativeList<DropItemInfo> droppedItems,
      DropTableData dropTableData,
      DynamicBuffer<DropTableDataBuffer> tableDataBuffer,
      float dropVarianceMin = 1f,
      float dropVarianceMax = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &dropUtilsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref droppedItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dropTableData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tableDataBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dropVarianceMin;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dropVarianceMax;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropUtils.NativeMethodInfoPtr_DoDrop_Public_Static_Void_DropUtilsData_byref_NativeList_1_DropItemInfo_DropTableData_DynamicBuffer_1_DropTableDataBuffer_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014888, RefRangeEnd = 1014889, XrefRangeStart = 1014852, XrefRangeEnd = 1014888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemFromGroup(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemDataDropGroup> itemGroupHashLookupMap,
      PrefabGUID groupGuid,
      out PrefabGUID itemGuid,
      out int quantity,
      out DropItemType type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemGroupHashLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &groupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref quantity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropUtils.NativeMethodInfoPtr_TryGetItemFromGroup_Private_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_PrefabGUID_byref_PrefabGUID_byref_Int32_byref_DropItemType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DropUtils()
    {
      Il2CppClassPointerStore<DropUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropUtils));
      DropUtils.NativeFieldInfoPtr__Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils>.NativeClassPtr, nameof (_Random));
      DropUtils.NativeMethodInfoPtr_DropInInventory_Public_Static_Void_DropUtilsData_Entity_DropInInventoryOnSpawn_DynamicBuffer_1_DropTableBuffer_byref_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropUtils>.NativeClassPtr, 100679119);
      DropUtils.NativeMethodInfoPtr_DoDrops_Public_Static_Void_DropUtilsData_byref_DynamicBuffer_1_DropTableBuffer_DropTriggerType_byref_NativeList_1_DropItemInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropUtils>.NativeClassPtr, 100679120);
      DropUtils.NativeMethodInfoPtr_DoDrop_Public_Static_Void_DropUtilsData_byref_NativeList_1_DropItemInfo_DropTableData_DynamicBuffer_1_DropTableDataBuffer_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropUtils>.NativeClassPtr, 100679121);
      DropUtils.NativeMethodInfoPtr_TryGetItemFromGroup_Private_Static_Boolean_EntityManager_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_PrefabGUID_byref_PrefabGUID_byref_Int32_byref_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropUtils>.NativeClassPtr, 100679122);
    }

    public DropUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Unity.Mathematics.Random _Random
    {
      get
      {
        Unity.Mathematics.Random random;
        IL2CPP.il2cpp_field_static_get_value(DropUtils.NativeFieldInfoPtr__Random, (void*) &random);
        return random;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DropUtils.NativeFieldInfoPtr__Random, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DropUtilsData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemDataLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemGroupHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_DropTableDataHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_JewelSpawnData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellModTierSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_Random;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DropUtilsData_SystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DropUtilsData_EntityManager_GameDataSystem_CurveCollectionSystem_JewelSpawnSystem_SpellModTierCollectionSystem_0;
      [FieldOffset(0)]
      public EntityManager EntityManager;
      [FieldOffset(8)]
      public NativeHashMap<PrefabGUID, ItemData> ItemDataLookup;
      [FieldOffset(24)]
      public NativeHashMap<PrefabGUID, ItemDataDropGroup> ItemGroupHashLookupMap;
      [FieldOffset(40)]
      public NativeHashMap<PrefabGUID, DropTableData> DropTableDataHashLookupMap;
      [FieldOffset(56)]
      public CurveCollection CurveCollection;
      [FieldOffset(72)]
      public JewelSpawnSystemData JewelSpawnData;
      [FieldOffset(144)]
      public NativeHashMap<int, BlobAssetReference<SpellModSetGlobalTierData>> SpellModTierSettings;
      [FieldOffset(160)]
      public Unity.Mathematics.Random Random;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014694, XrefRangeEnd = 1014716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe DropUtils.DropUtilsData Create(SystemBase systemBase)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropUtils.DropUtilsData.NativeMethodInfoPtr_Create_Public_Static_DropUtilsData_SystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DropUtils.DropUtilsData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1014722, RefRangeEnd = 1014726, XrefRangeStart = 1014716, XrefRangeEnd = 1014722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe DropUtils.DropUtilsData Create(
        EntityManager entityManager,
        GameDataSystem gameDataSystem,
        CurveCollectionSystem curveCollectionSystem,
        JewelSpawnSystem jewelSpawnSystem,
        SpellModTierCollectionSystem spellModTierSettings)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curveCollectionSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jewelSpawnSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellModTierSettings);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropUtils.DropUtilsData.NativeMethodInfoPtr_Create_Public_Static_DropUtilsData_EntityManager_GameDataSystem_CurveCollectionSystem_JewelSpawnSystem_SpellModTierCollectionSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DropUtils.DropUtilsData*) IL2CPP.il2cpp_object_unbox(num);
      }

      static DropUtilsData()
      {
        Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropUtils>.NativeClassPtr, nameof (DropUtilsData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr);
        DropUtils.DropUtilsData.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, nameof (EntityManager));
        DropUtils.DropUtilsData.NativeFieldInfoPtr_ItemDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, nameof (ItemDataLookup));
        DropUtils.DropUtilsData.NativeFieldInfoPtr_ItemGroupHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, nameof (ItemGroupHashLookupMap));
        DropUtils.DropUtilsData.NativeFieldInfoPtr_DropTableDataHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, nameof (DropTableDataHashLookupMap));
        DropUtils.DropUtilsData.NativeFieldInfoPtr_CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, nameof (CurveCollection));
        DropUtils.DropUtilsData.NativeFieldInfoPtr_JewelSpawnData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, nameof (JewelSpawnData));
        DropUtils.DropUtilsData.NativeFieldInfoPtr_SpellModTierSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, nameof (SpellModTierSettings));
        DropUtils.DropUtilsData.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, nameof (Random));
        DropUtils.DropUtilsData.NativeMethodInfoPtr_Create_Public_Static_DropUtilsData_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, 100679123);
        DropUtils.DropUtilsData.NativeMethodInfoPtr_Create_Public_Static_DropUtilsData_EntityManager_GameDataSystem_CurveCollectionSystem_JewelSpawnSystem_SpellModTierCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, 100679124);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropUtils.DropUtilsData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
