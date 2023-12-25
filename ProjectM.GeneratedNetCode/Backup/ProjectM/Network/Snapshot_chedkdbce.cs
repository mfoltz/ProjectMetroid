﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_chedkdbce
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_chedkdbce
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(24)]
    public double CreatedTime_CreateTime;
    [FieldOffset(32)]
    public bool DismantleDestroyData_WasDismantled;
    [FieldOffset(33)]
    public bool EditableTileModel_CanRepair;
    [FieldOffset(34)]
    public NetworkId EditableTileModel_CurrentEditor;
    [FieldOffset(42)]
    public bool EditableTileModel_IsDismantling;
    [FieldOffset(43)]
    public bool EditableTileModel_IsEdited;
    [FieldOffset(44)]
    public bool EditableTileModel_IsRepairing;
    [FieldOffset(45)]
    public bool Health_IsDead;
    [FieldOffset(46)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(54)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(58)]
    public double Health_TimeOfDeath;
    [FieldOffset(66)]
    public float Health_Value;
    [FieldOffset(70)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(71)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(75)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(83)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(84)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(96)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(97)]
    public int Team_FactionIndex;
    [FieldOffset(101)]
    public int Team_Value;
    [FieldOffset(105)]
    public ProjectM.TileType TileModel_DisabledTileTypes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1570517, XrefRangeEnd = 1570703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_CastleBuildingAttachedChildrenBuffer> get_buffer_CastleBuildingAttachedChildrenBuffer,
      ref BufferFromEntity<Snapshot_CastleBuildingAttachToParentsBuffer> get_buffer_CastleBuildingAttachToParentsBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleBuildingAttachedChildrenBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleBuildingAttachToParentsBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_chedkdbce.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1570796, RefRangeEnd = 1570797, XrefRangeStart = 1570703, XrefRangeEnd = 1570796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_CastleBuildingAttachedChildrenBuffer> buffer_CastleBuildingAttachedChildrenBuffer,
      DynamicBuffer<Snapshot_CastleBuildingAttachToParentsBuffer> buffer_CastleBuildingAttachToParentsBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleBuildingAttachedChildrenBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleBuildingAttachToParentsBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_chedkdbce.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_chedkdbce()
    {
      Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_chedkdbce));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr);
      Snapshot_chedkdbce.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_chedkdbce.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_chedkdbce.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CreatedTime_CreateTime));
      Snapshot_chedkdbce.NativeFieldInfoPtr_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (DismantleDestroyData_WasDismantled));
      Snapshot_chedkdbce.NativeFieldInfoPtr_EditableTileModel_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (EditableTileModel_CanRepair));
      Snapshot_chedkdbce.NativeFieldInfoPtr_EditableTileModel_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (EditableTileModel_CurrentEditor));
      Snapshot_chedkdbce.NativeFieldInfoPtr_EditableTileModel_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (EditableTileModel_IsDismantling));
      Snapshot_chedkdbce.NativeFieldInfoPtr_EditableTileModel_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (EditableTileModel_IsEdited));
      Snapshot_chedkdbce.NativeFieldInfoPtr_EditableTileModel_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (EditableTileModel_IsRepairing));
      Snapshot_chedkdbce.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_chedkdbce.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_chedkdbce.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_chedkdbce.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_chedkdbce.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (Health_Value));
      Snapshot_chedkdbce.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_chedkdbce.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_chedkdbce.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_chedkdbce.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_chedkdbce.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_chedkdbce.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_chedkdbce.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_chedkdbce.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (Team_Value));
      Snapshot_chedkdbce.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_EditableTileModel_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_EditableTileModel_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_CastleBuildingAttachedChildrenBuffer));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_CastleBuildingAttachToParentsBuffer));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime_CreateTime));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData_WasDismantled));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_CanRepair));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_CurrentEditor));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsDismantling));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsEdited));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsRepairing));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_CreatedTime));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_CreatedTime));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_DismantleDestroyData));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_DismantleDestroyData));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_EditableTileModel));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_EditableTileModel));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_CreatedTime));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_DismantleDestroyData));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_EditableTileModel));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_CastleBuildingAttachedChildrenBuffer));
      Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, nameof (CompBit_CastleBuildingAttachToParentsBuffer));
      Snapshot_chedkdbce.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, 100664540);
      Snapshot_chedkdbce.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, 100664541);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_chedkdbce>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Start
    {
      get
      {
        int createdTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &createdTimeStart);
        return createdTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Count
    {
      get
      {
        int createdTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &createdTimeCount);
        return createdTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EditableTileModel_Start
    {
      get
      {
        int editableTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start, (void*) &editableTileModelStart);
        return editableTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EditableTileModel_Count
    {
      get
      {
        int editableTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count, (void*) &editableTileModelCount);
        return editableTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime
    {
      get
      {
        int indexCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &indexCreatedTime);
        return indexCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        int attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleBuildingAttachToParentsBuffer
    {
      get
      {
        int attachToParentsBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer, (void*) &attachToParentsBuffer);
        return attachToParentsBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime_CreateTime
    {
      get
      {
        int createdTimeCreateTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &createdTimeCreateTime);
        return createdTimeCreateTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData_WasDismantled
    {
      get
      {
        int dataWasDismantled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &dataWasDismantled);
        return dataWasDismantled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_CanRepair
    {
      get
      {
        int tileModelCanRepair;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair, (void*) &tileModelCanRepair);
        return tileModelCanRepair;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_CurrentEditor
    {
      get
      {
        int modelCurrentEditor;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor, (void*) &modelCurrentEditor);
        return modelCurrentEditor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsDismantling
    {
      get
      {
        int modelIsDismantling;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling, (void*) &modelIsDismantling);
        return modelIsDismantling;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsEdited
    {
      get
      {
        int tileModelIsEdited;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited, (void*) &tileModelIsEdited);
        return tileModelIsEdited;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsRepairing
    {
      get
      {
        int modelIsRepairing;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing, (void*) &modelIsRepairing);
        return modelIsRepairing;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CreatedTime
    {
      get
      {
        int offsetCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &offsetCreatedTime);
        return offsetCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CreatedTime
    {
      get
      {
        int dataSizeCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &dataSizeCreatedTime);
        return dataSizeCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CreatedTime
    {
      get
      {
        ulong compBitCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &compBitCreatedTime);
        return compBitCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DismantleDestroyData
    {
      get
      {
        ulong dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EditableTileModel
    {
      get
      {
        ulong editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        ulong attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleBuildingAttachToParentsBuffer
    {
      get
      {
        ulong attachToParentsBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer, (void*) &attachToParentsBuffer);
        return attachToParentsBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chedkdbce.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer, (void*) &value);
      }
    }
  }
}