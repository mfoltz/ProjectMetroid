// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_aceegbjekgb
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_aceegbjekgb
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartConnection_CastleHeartEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleWorkstation_WorkstationLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatedTime_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleDestroyData_WasDismantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_CanRepair;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_CurrentEditor;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsDismantling;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsEdited;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsRepairing;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelSeed_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelCraftingStation_ActiveRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelCraftingStation_CraftedItem;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelCraftingStation_CraftProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelCraftingStation_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameableInteractable_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationServants_Servants;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_JewelCraftingStation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_JewelCraftingStation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_NameableInteractable_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_NameableInteractable_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StationServants_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StationServants_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NameableInteractable;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_ActiveRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_CraftedItem;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_CraftProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NameableInteractable_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_JewelCraftingStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_JewelCraftingStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_NameableInteractable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_NameableInteractable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_JewelCraftingStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_NameableInteractable;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InventoryBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_DynamicBuffer_1_Snapshot_InventoryBuffer_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(24)]
    public NetworkId CastleHeartConnection_CastleHeartEntity;
    [FieldOffset(32)]
    public WorkstationLevel CastleWorkstation_WorkstationLevel;
    [FieldOffset(33)]
    public double CreatedTime_CreateTime;
    [FieldOffset(41)]
    public bool DismantleDestroyData_WasDismantled;
    [FieldOffset(42)]
    public bool EditableTileModel_CanRepair;
    [FieldOffset(43)]
    public NetworkId EditableTileModel_CurrentEditor;
    [FieldOffset(51)]
    public bool EditableTileModel_IsDismantling;
    [FieldOffset(52)]
    public bool EditableTileModel_IsEdited;
    [FieldOffset(53)]
    public bool EditableTileModel_IsRepairing;
    [FieldOffset(54)]
    public bool Health_IsDead;
    [FieldOffset(55)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(63)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(67)]
    public double Health_TimeOfDeath;
    [FieldOffset(75)]
    public float Health_Value;
    [FieldOffset(79)]
    public ushort HybridModelSeed_Seed;
    [FieldOffset(81)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(82)]
    public PrefabGUID JewelCraftingStation_ActiveRecipeGuid;
    [FieldOffset(86)]
    public NetworkId JewelCraftingStation_CraftedItem;
    [FieldOffset(94)]
    public float JewelCraftingStation_CraftProgress;
    [FieldOffset(98)]
    public CraftingStatus JewelCraftingStation_Status;
    [FieldOffset(102)]
    public FixedString64 NameableInteractable_Name;
    [FieldOffset(166)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(170)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(178)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(179)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(191)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(192)]
    public ServantType StationServants_Servants;
    [FieldOffset(196)]
    public ProjectM.TileType TileModel_DisabledTileTypes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1528161, XrefRangeEnd = 1528420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_CastleBuildingAttachedChildrenBuffer> get_buffer_CastleBuildingAttachedChildrenBuffer,
      ref BufferFromEntity<Snapshot_CastleBuildingAttachToParentsBuffer> get_buffer_CastleBuildingAttachToParentsBuffer,
      ref BufferFromEntity<Snapshot_InventoryBuffer> get_buffer_InventoryBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleBuildingAttachedChildrenBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleBuildingAttachToParentsBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_InventoryBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_aceegbjekgb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1528558, RefRangeEnd = 1528559, XrefRangeStart = 1528420, XrefRangeEnd = 1528558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_CastleBuildingAttachedChildrenBuffer> buffer_CastleBuildingAttachedChildrenBuffer,
      DynamicBuffer<Snapshot_CastleBuildingAttachToParentsBuffer> buffer_CastleBuildingAttachToParentsBuffer,
      DynamicBuffer<Snapshot_InventoryBuffer> buffer_InventoryBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleBuildingAttachedChildrenBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleBuildingAttachToParentsBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_InventoryBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_aceegbjekgb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_DynamicBuffer_1_Snapshot_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_aceegbjekgb()
    {
      Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_aceegbjekgb));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr);
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CastleHeartConnection_CastleHeartEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CastleHeartConnection_CastleHeartEntity));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CastleWorkstation_WorkstationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CastleWorkstation_WorkstationLevel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CreatedTime_CreateTime));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (DismantleDestroyData_WasDismantled));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_EditableTileModel_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (EditableTileModel_CanRepair));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_EditableTileModel_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (EditableTileModel_CurrentEditor));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_EditableTileModel_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (EditableTileModel_IsDismantling));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_EditableTileModel_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (EditableTileModel_IsEdited));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_EditableTileModel_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (EditableTileModel_IsRepairing));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (Health_Value));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (HybridModelSeed_Seed));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_JewelCraftingStation_ActiveRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (JewelCraftingStation_ActiveRecipeGuid));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_JewelCraftingStation_CraftedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (JewelCraftingStation_CraftedItem));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_JewelCraftingStation_CraftProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (JewelCraftingStation_CraftProgress));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_JewelCraftingStation_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (JewelCraftingStation_Status));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_NameableInteractable_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (NameableInteractable_Name));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_StationServants_Servants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (StationServants_Servants));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_CastleHeartConnection_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_CastleHeartConnection_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_CastleWorkstation_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_CastleWorkstation_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_EditableTileModel_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_EditableTileModel_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_JewelCraftingStation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_JewelCraftingStation_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_JewelCraftingStation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_JewelCraftingStation_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_NameableInteractable_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_NameableInteractable_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_NameableInteractable_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_NameableInteractable_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_StationServants_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_StationServants_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeartConnection));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_CastleWorkstation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_JewelCraftingStation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_NameableInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_NameableInteractable));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_StationServants));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_CastleBuildingAttachedChildrenBuffer));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_CastleBuildingAttachToParentsBuffer));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_InventoryBuffer));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeartConnection_CastleHeartEntity));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_CastleWorkstation_WorkstationLevel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime_CreateTime));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData_WasDismantled));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_CanRepair));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_CurrentEditor));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsDismantling));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsEdited));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsRepairing));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed_Seed));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_ActiveRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_JewelCraftingStation_ActiveRecipeGuid));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_CraftedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_JewelCraftingStation_CraftedItem));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_CraftProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_JewelCraftingStation_CraftProgress));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_JewelCraftingStation_Status));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_NameableInteractable_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_NameableInteractable_Name));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_StationServants_Servants));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleHeartConnection));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_CastleHeartConnection));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleWorkstation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_CastleWorkstation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_CreatedTime));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_CreatedTime));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_DismantleDestroyData));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_DismantleDestroyData));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_EditableTileModel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_EditableTileModel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_HybridModelSeed));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_HybridModelSeed));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_JewelCraftingStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_JewelCraftingStation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_JewelCraftingStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_JewelCraftingStation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_NameableInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_NameableInteractable));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_NameableInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_NameableInteractable));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_StationServants));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_StationServants));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_CastleHeartConnection));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_CastleWorkstation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_CreatedTime));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_DismantleDestroyData));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_EditableTileModel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_HybridModelSeed));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_JewelCraftingStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_JewelCraftingStation));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_NameableInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_NameableInteractable));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_StationServants));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_CastleBuildingAttachedChildrenBuffer));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_CastleBuildingAttachToParentsBuffer));
      Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, nameof (CompBit_InventoryBuffer));
      Snapshot_aceegbjekgb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, 100664176);
      Snapshot_aceegbjekgb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_DynamicBuffer_1_Snapshot_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, 100664177);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_aceegbjekgb>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleHeartConnection_Start
    {
      get
      {
        int heartConnectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start, (void*) &heartConnectionStart);
        return heartConnectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleHeartConnection_Count
    {
      get
      {
        int heartConnectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count, (void*) &heartConnectionCount);
        return heartConnectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleWorkstation_Start
    {
      get
      {
        int workstationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start, (void*) &workstationStart);
        return workstationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleWorkstation_Count
    {
      get
      {
        int workstationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count, (void*) &workstationCount);
        return workstationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Start
    {
      get
      {
        int createdTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &createdTimeStart);
        return createdTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Count
    {
      get
      {
        int createdTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &createdTimeCount);
        return createdTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EditableTileModel_Start
    {
      get
      {
        int editableTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start, (void*) &editableTileModelStart);
        return editableTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EditableTileModel_Count
    {
      get
      {
        int editableTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count, (void*) &editableTileModelCount);
        return editableTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Start
    {
      get
      {
        int hybridModelSeedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &hybridModelSeedStart);
        return hybridModelSeedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Count
    {
      get
      {
        int hybridModelSeedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &hybridModelSeedCount);
        return hybridModelSeedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_JewelCraftingStation_Start
    {
      get
      {
        int craftingStationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_JewelCraftingStation_Start, (void*) &craftingStationStart);
        return craftingStationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_JewelCraftingStation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_JewelCraftingStation_Count
    {
      get
      {
        int craftingStationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_JewelCraftingStation_Count, (void*) &craftingStationCount);
        return craftingStationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_JewelCraftingStation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NameableInteractable_Start
    {
      get
      {
        int interactableStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_NameableInteractable_Start, (void*) &interactableStart);
        return interactableStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_NameableInteractable_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NameableInteractable_Count
    {
      get
      {
        int interactableCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_NameableInteractable_Count, (void*) &interactableCount);
        return interactableCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_NameableInteractable_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StationServants_Start
    {
      get
      {
        int stationServantsStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start, (void*) &stationServantsStart);
        return stationServantsStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StationServants_Count
    {
      get
      {
        int stationServantsCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count, (void*) &stationServantsCount);
        return stationServantsCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime
    {
      get
      {
        int indexCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &indexCreatedTime);
        return indexCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed
    {
      get
      {
        int indexHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &indexHybridModelSeed);
        return indexHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_JewelCraftingStation
    {
      get
      {
        int jewelCraftingStation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation, (void*) &jewelCraftingStation);
        return jewelCraftingStation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NameableInteractable
    {
      get
      {
        int nameableInteractable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_NameableInteractable, (void*) &nameableInteractable);
        return nameableInteractable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_NameableInteractable, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StationServants
    {
      get
      {
        int indexStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StationServants, (void*) &indexStationServants);
        return indexStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StationServants, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        int attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleBuildingAttachToParentsBuffer
    {
      get
      {
        int attachToParentsBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer, (void*) &attachToParentsBuffer);
        return attachToParentsBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InventoryBuffer
    {
      get
      {
        int indexInventoryBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer, (void*) &indexInventoryBuffer);
        return indexInventoryBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeartConnection_CastleHeartEntity
    {
      get
      {
        int castleHeartEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity, (void*) &castleHeartEntity);
        return castleHeartEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleWorkstation_WorkstationLevel
    {
      get
      {
        int workstationLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel, (void*) &workstationLevel);
        return workstationLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime_CreateTime
    {
      get
      {
        int createdTimeCreateTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &createdTimeCreateTime);
        return createdTimeCreateTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData_WasDismantled
    {
      get
      {
        int dataWasDismantled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &dataWasDismantled);
        return dataWasDismantled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_CanRepair
    {
      get
      {
        int tileModelCanRepair;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair, (void*) &tileModelCanRepair);
        return tileModelCanRepair;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_CurrentEditor
    {
      get
      {
        int modelCurrentEditor;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor, (void*) &modelCurrentEditor);
        return modelCurrentEditor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsDismantling
    {
      get
      {
        int modelIsDismantling;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling, (void*) &modelIsDismantling);
        return modelIsDismantling;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsEdited
    {
      get
      {
        int tileModelIsEdited;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited, (void*) &tileModelIsEdited);
        return tileModelIsEdited;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsRepairing
    {
      get
      {
        int modelIsRepairing;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing, (void*) &modelIsRepairing);
        return modelIsRepairing;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed_Seed
    {
      get
      {
        int hybridModelSeedSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &hybridModelSeedSeed);
        return hybridModelSeedSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_JewelCraftingStation_ActiveRecipeGuid
    {
      get
      {
        int activeRecipeGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_ActiveRecipeGuid, (void*) &activeRecipeGuid);
        return activeRecipeGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_ActiveRecipeGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_JewelCraftingStation_CraftedItem
    {
      get
      {
        int stationCraftedItem;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_CraftedItem, (void*) &stationCraftedItem);
        return stationCraftedItem;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_CraftedItem, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_JewelCraftingStation_CraftProgress
    {
      get
      {
        int stationCraftProgress;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_CraftProgress, (void*) &stationCraftProgress);
        return stationCraftProgress;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_CraftProgress, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_JewelCraftingStation_Status
    {
      get
      {
        int craftingStationStatus;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_Status, (void*) &craftingStationStatus);
        return craftingStationStatus;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_JewelCraftingStation_Status, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NameableInteractable_Name
    {
      get
      {
        int interactableName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_NameableInteractable_Name, (void*) &interactableName);
        return interactableName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_NameableInteractable_Name, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StationServants_Servants
    {
      get
      {
        int servantsServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants, (void*) &servantsServants);
        return servantsServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CreatedTime
    {
      get
      {
        int offsetCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &offsetCreatedTime);
        return offsetCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CreatedTime
    {
      get
      {
        int dataSizeCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &dataSizeCreatedTime);
        return dataSizeCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_HybridModelSeed
    {
      get
      {
        int offsetHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &offsetHybridModelSeed);
        return offsetHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_HybridModelSeed
    {
      get
      {
        int sizeHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &sizeHybridModelSeed);
        return sizeHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_JewelCraftingStation
    {
      get
      {
        int jewelCraftingStation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_JewelCraftingStation, (void*) &jewelCraftingStation);
        return jewelCraftingStation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_JewelCraftingStation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_JewelCraftingStation
    {
      get
      {
        int jewelCraftingStation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_JewelCraftingStation, (void*) &jewelCraftingStation);
        return jewelCraftingStation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_JewelCraftingStation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_NameableInteractable
    {
      get
      {
        int nameableInteractable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_NameableInteractable, (void*) &nameableInteractable);
        return nameableInteractable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_NameableInteractable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_NameableInteractable
    {
      get
      {
        int nameableInteractable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_NameableInteractable, (void*) &nameableInteractable);
        return nameableInteractable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_NameableInteractable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StationServants
    {
      get
      {
        int offsetStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants, (void*) &offsetStationServants);
        return offsetStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StationServants
    {
      get
      {
        int sizeStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_StationServants, (void*) &sizeStationServants);
        return sizeStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_StationServants, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleHeartConnection
    {
      get
      {
        ulong castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleWorkstation
    {
      get
      {
        ulong castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CreatedTime
    {
      get
      {
        ulong compBitCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &compBitCreatedTime);
        return compBitCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DismantleDestroyData
    {
      get
      {
        ulong dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EditableTileModel
    {
      get
      {
        ulong editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_HybridModelSeed
    {
      get
      {
        ulong bitHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &bitHybridModelSeed);
        return bitHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_JewelCraftingStation
    {
      get
      {
        ulong jewelCraftingStation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_JewelCraftingStation, (void*) &jewelCraftingStation);
        return jewelCraftingStation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_JewelCraftingStation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_NameableInteractable
    {
      get
      {
        ulong nameableInteractable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_NameableInteractable, (void*) &nameableInteractable);
        return nameableInteractable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_NameableInteractable, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StationServants
    {
      get
      {
        ulong bitStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_StationServants, (void*) &bitStationServants);
        return bitStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_StationServants, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        ulong attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleBuildingAttachToParentsBuffer
    {
      get
      {
        ulong attachToParentsBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer, (void*) &attachToParentsBuffer);
        return attachToParentsBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InventoryBuffer
    {
      get
      {
        ulong bitInventoryBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_InventoryBuffer, (void*) &bitInventoryBuffer);
        return bitInventoryBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aceegbjekgb.NativeFieldInfoPtr_CompBit_InventoryBuffer, (void*) &value);
      }
    }
  }
}
