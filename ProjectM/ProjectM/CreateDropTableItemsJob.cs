// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateDropTableItemsJob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateDropTableItemsJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GetItemDropGroupBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDropTableDataBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_Random;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemGroupHashLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableDataHashLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemDataLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelSpawnData;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModTierSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteDropOnGround_Public_Void_byref_DynamicBuffer_1_RelicDropped_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_byref_ServerGameBalanceSettings_EntityManager_DropTriggerType_Int32_PrefabGUID_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoDrop_Private_Void_RelicSpawnType_byref_DynamicBuffer_1_RelicDropped_byref_DynamicBuffer_1_DropTableBuffer_DropTriggerType_byref_NativeList_1_DropItemInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemFromGroup_Private_Boolean_PrefabGUID_byref_PrefabGUID_byref_Int32_byref_DropItemType_0;
    [FieldOffset(0)]
    public BufferFromEntity<ItemDataDropGroupBuffer> GetItemDropGroupBuffer;
    [FieldOffset(40)]
    public BufferFromEntity<DropTableDataBuffer> GetDropTableDataBuffer;
    [FieldOffset(80)]
    public Unity.Mathematics.Random Random;
    [FieldOffset(88)]
    public EntityCommandBuffer CommandBuffer;
    [FieldOffset(104)]
    public NativeHashMap<PrefabGUID, ItemDataDropGroup> ItemGroupHashLookupMap;
    [FieldOffset(120)]
    public NativeHashMap<PrefabGUID, DropTableData> DropTableDataHashLookupMap;
    [FieldOffset(136)]
    public PrefabLookupMap PrefabLookupMap;
    [FieldOffset(184)]
    public NativeHashMap<PrefabGUID, ItemData> ItemDataLookup;
    [FieldOffset(200)]
    public CurveCollection CurveCollection;
    [FieldOffset(216)]
    public JewelSpawnSystemData JewelSpawnData;
    [FieldOffset(288)]
    public NativeHashMap<int, BlobAssetReference<SpellModSetGlobalTierData>> SpellModTierSettings;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1014586, RefRangeEnd = 1014590, XrefRangeStart = 1014521, XrefRangeEnd = 1014586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExecuteDropOnGround(
      ref DynamicBuffer<RelicDropped> relicsDroppedBuffer,
      [In] ref DynamicBuffer<DropTableBuffer> dropTablesBuffer,
      [In] ref Translation translation,
      [In] ref ServerGameBalanceSettings serverGameSettings,
      EntityManager entityManager,
      DropTriggerType dropTrigger,
      int sourceLevel = 0,
      PrefabGUID customDropArc = default (PrefabGUID),
      Nullable_Unboxed<float> minRange = default (Nullable_Unboxed<float>),
      Nullable_Unboxed<float> maxRange = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) ref relicsDroppedBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropTablesBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverGameSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dropTrigger;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &customDropArc;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &minRange;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &maxRange;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateDropTableItemsJob.NativeMethodInfoPtr_ExecuteDropOnGround_Public_Void_byref_DynamicBuffer_1_RelicDropped_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_byref_ServerGameBalanceSettings_EntityManager_DropTriggerType_Int32_PrefabGUID_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014660, RefRangeEnd = 1014661, XrefRangeStart = 1014590, XrefRangeEnd = 1014660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoDrop(
      RelicSpawnType relicSpawnType,
      ref DynamicBuffer<RelicDropped> relicsDroppedBuffer,
      [In] ref DynamicBuffer<DropTableBuffer> dropTablesBuffer,
      DropTriggerType dropTrigger,
      ref NativeList<DropItemInfo> droppedItems)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &relicSpawnType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref relicsDroppedBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropTablesBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dropTrigger;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref droppedItems;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateDropTableItemsJob.NativeMethodInfoPtr_DoDrop_Private_Void_RelicSpawnType_byref_DynamicBuffer_1_RelicDropped_byref_DynamicBuffer_1_DropTableBuffer_DropTriggerType_byref_NativeList_1_DropItemInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014693, RefRangeEnd = 1014694, XrefRangeStart = 1014661, XrefRangeEnd = 1014693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetItemFromGroup(
      PrefabGUID groupGuid,
      out PrefabGUID itemGuid,
      out int quantity,
      out DropItemType type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &groupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref quantity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateDropTableItemsJob.NativeMethodInfoPtr_TryGetItemFromGroup_Private_Boolean_PrefabGUID_byref_PrefabGUID_byref_Int32_byref_DropItemType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CreateDropTableItemsJob()
    {
      Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateDropTableItemsJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr);
      CreateDropTableItemsJob.NativeFieldInfoPtr_GetItemDropGroupBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (GetItemDropGroupBuffer));
      CreateDropTableItemsJob.NativeFieldInfoPtr_GetDropTableDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (GetDropTableDataBuffer));
      CreateDropTableItemsJob.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (Random));
      CreateDropTableItemsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (CommandBuffer));
      CreateDropTableItemsJob.NativeFieldInfoPtr_ItemGroupHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (ItemGroupHashLookupMap));
      CreateDropTableItemsJob.NativeFieldInfoPtr_DropTableDataHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (DropTableDataHashLookupMap));
      CreateDropTableItemsJob.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (PrefabLookupMap));
      CreateDropTableItemsJob.NativeFieldInfoPtr_ItemDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (ItemDataLookup));
      CreateDropTableItemsJob.NativeFieldInfoPtr_CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (CurveCollection));
      CreateDropTableItemsJob.NativeFieldInfoPtr_JewelSpawnData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (JewelSpawnData));
      CreateDropTableItemsJob.NativeFieldInfoPtr_SpellModTierSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (SpellModTierSettings));
      CreateDropTableItemsJob.NativeMethodInfoPtr_ExecuteDropOnGround_Public_Void_byref_DynamicBuffer_1_RelicDropped_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_byref_ServerGameBalanceSettings_EntityManager_DropTriggerType_Int32_PrefabGUID_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, 100679112);
      CreateDropTableItemsJob.NativeMethodInfoPtr_DoDrop_Private_Void_RelicSpawnType_byref_DynamicBuffer_1_RelicDropped_byref_DynamicBuffer_1_DropTableBuffer_DropTriggerType_byref_NativeList_1_DropItemInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, 100679113);
      CreateDropTableItemsJob.NativeMethodInfoPtr_TryGetItemFromGroup_Private_Boolean_PrefabGUID_byref_PrefabGUID_byref_Int32_byref_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, 100679114);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct IncreasedMagicFindChanceKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
      private static readonly System.IntPtr NativeFieldInfoPtr_DropTable;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IncreasedMagicFindChanceKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public Entity Owner;
      [FieldOffset(8)]
      public PrefabGUID DropTable;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(
        CreateDropTableItemsJob.IncreasedMagicFindChanceKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateDropTableItemsJob.IncreasedMagicFindChanceKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IncreasedMagicFindChanceKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014518, XrefRangeEnd = 1014521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateDropTableItemsJob.IncreasedMagicFindChanceKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateDropTableItemsJob.IncreasedMagicFindChanceKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static IncreasedMagicFindChanceKey()
      {
        Il2CppClassPointerStore<CreateDropTableItemsJob.IncreasedMagicFindChanceKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateDropTableItemsJob>.NativeClassPtr, nameof (IncreasedMagicFindChanceKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateDropTableItemsJob.IncreasedMagicFindChanceKey>.NativeClassPtr);
        CreateDropTableItemsJob.IncreasedMagicFindChanceKey.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob.IncreasedMagicFindChanceKey>.NativeClassPtr, nameof (Owner));
        CreateDropTableItemsJob.IncreasedMagicFindChanceKey.NativeFieldInfoPtr_DropTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDropTableItemsJob.IncreasedMagicFindChanceKey>.NativeClassPtr, nameof (DropTable));
        CreateDropTableItemsJob.IncreasedMagicFindChanceKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IncreasedMagicFindChanceKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDropTableItemsJob.IncreasedMagicFindChanceKey>.NativeClassPtr, 100679115);
        CreateDropTableItemsJob.IncreasedMagicFindChanceKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDropTableItemsJob.IncreasedMagicFindChanceKey>.NativeClassPtr, 100679116);
        CreateDropTableItemsJob.IncreasedMagicFindChanceKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDropTableItemsJob.IncreasedMagicFindChanceKey>.NativeClassPtr, 100679117);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateDropTableItemsJob.IncreasedMagicFindChanceKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
