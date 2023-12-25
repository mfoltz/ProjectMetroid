﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_jkekeckbf
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
  public struct Snapshot_jkekeckbf
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleDestroyData_WasDismantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_CanRepair;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_CurrentEditor;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsDismantling;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsEdited;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsRepairing;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevel_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(24)]
    public bool DismantleDestroyData_WasDismantled;
    [FieldOffset(25)]
    public bool EditableTileModel_CanRepair;
    [FieldOffset(26)]
    public NetworkId EditableTileModel_CurrentEditor;
    [FieldOffset(34)]
    public bool EditableTileModel_IsDismantling;
    [FieldOffset(35)]
    public bool EditableTileModel_IsEdited;
    [FieldOffset(36)]
    public bool EditableTileModel_IsRepairing;
    [FieldOffset(37)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(41)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(49)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(50)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(62)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(63)]
    public int Team_FactionIndex;
    [FieldOffset(67)]
    public int Team_Value;
    [FieldOffset(71)]
    public ProjectM.TileType TileModel_DisabledTileTypes;
    [FieldOffset(72)]
    public int UnitLevel_Level;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1589515, XrefRangeEnd = 1589633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_CastleBuildingAttachedChildrenBuffer> get_buffer_CastleBuildingAttachedChildrenBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleBuildingAttachedChildrenBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_jkekeckbf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1589694, RefRangeEnd = 1589695, XrefRangeStart = 1589633, XrefRangeEnd = 1589694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_CastleBuildingAttachedChildrenBuffer> buffer_CastleBuildingAttachedChildrenBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleBuildingAttachedChildrenBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_jkekeckbf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_jkekeckbf()
    {
      Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_jkekeckbf));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr);
      Snapshot_jkekeckbf.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (DismantleDestroyData_WasDismantled));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_EditableTileModel_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (EditableTileModel_CanRepair));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_EditableTileModel_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (EditableTileModel_CurrentEditor));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_EditableTileModel_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (EditableTileModel_IsDismantling));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_EditableTileModel_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (EditableTileModel_IsEdited));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_EditableTileModel_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (EditableTileModel_IsRepairing));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (Team_Value));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_UnitLevel_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (UnitLevel_Level));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Start));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Count));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_EditableTileModel_Start));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_EditableTileModel_Count));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_UnitLevel_Start));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedFields_UnitLevel_Count));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_UnitLevel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_CastleBuildingAttachedChildrenBuffer));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData_WasDismantled));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_CanRepair));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_CurrentEditor));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsDismantling));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsEdited));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsRepairing));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (FrameChangedIndex_UnitLevel_Level));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataStartOffset_DismantleDestroyData));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataSize_DismantleDestroyData));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataStartOffset_EditableTileModel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataSize_EditableTileModel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataStartOffset_UnitLevel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (ComponentDataSize_UnitLevel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CompBit_DismantleDestroyData));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CompBit_EditableTileModel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CompBit_UnitLevel));
      Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, nameof (CompBit_CastleBuildingAttachedChildrenBuffer));
      Snapshot_jkekeckbf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, 100664732);
      Snapshot_jkekeckbf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, 100664733);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_jkekeckbf>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EditableTileModel_Start
    {
      get
      {
        int editableTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start, (void*) &editableTileModelStart);
        return editableTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EditableTileModel_Count
    {
      get
      {
        int editableTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count, (void*) &editableTileModelCount);
        return editableTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitLevel_Start
    {
      get
      {
        int fieldsUnitLevelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start, (void*) &fieldsUnitLevelStart);
        return fieldsUnitLevelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitLevel_Count
    {
      get
      {
        int fieldsUnitLevelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count, (void*) &fieldsUnitLevelCount);
        return fieldsUnitLevelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitLevel
    {
      get
      {
        int changedIndexUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel, (void*) &changedIndexUnitLevel);
        return changedIndexUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        int attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData_WasDismantled
    {
      get
      {
        int dataWasDismantled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &dataWasDismantled);
        return dataWasDismantled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_CanRepair
    {
      get
      {
        int tileModelCanRepair;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair, (void*) &tileModelCanRepair);
        return tileModelCanRepair;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_CurrentEditor
    {
      get
      {
        int modelCurrentEditor;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor, (void*) &modelCurrentEditor);
        return modelCurrentEditor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsDismantling
    {
      get
      {
        int modelIsDismantling;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling, (void*) &modelIsDismantling);
        return modelIsDismantling;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsEdited
    {
      get
      {
        int tileModelIsEdited;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited, (void*) &tileModelIsEdited);
        return tileModelIsEdited;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsRepairing
    {
      get
      {
        int modelIsRepairing;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing, (void*) &modelIsRepairing);
        return modelIsRepairing;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitLevel_Level
    {
      get
      {
        int indexUnitLevelLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level, (void*) &indexUnitLevelLevel);
        return indexUnitLevelLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_UnitLevel
    {
      get
      {
        int startOffsetUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel, (void*) &startOffsetUnitLevel);
        return startOffsetUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_UnitLevel
    {
      get
      {
        int dataSizeUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_UnitLevel, (void*) &dataSizeUnitLevel);
        return dataSizeUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_ComponentDataSize_UnitLevel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DismantleDestroyData
    {
      get
      {
        ulong dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EditableTileModel
    {
      get
      {
        ulong editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UnitLevel
    {
      get
      {
        ulong compBitUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_UnitLevel, (void*) &compBitUnitLevel);
        return compBitUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_UnitLevel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        ulong attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jkekeckbf.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }
  }
}