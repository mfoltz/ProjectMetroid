// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ceffhbdbf
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_ceffhbdbf
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementDestroyData_DestroyReason;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_PlacementDestroyData;
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
    public TileModelDestroyReason PlacementDestroyData_DestroyReason;
    [FieldOffset(12)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(16)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(24)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(25)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(37)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(38)]
    public int Team_FactionIndex;
    [FieldOffset(42)]
    public int Team_Value;
    [FieldOffset(46)]
    public ProjectM.TileType TileModel_DisabledTileTypes;
    [FieldOffset(47)]
    public int UnitLevel_Level;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1563760, XrefRangeEnd = 1563867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ceffhbdbf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1563914, RefRangeEnd = 1563915, XrefRangeStart = 1563867, XrefRangeEnd = 1563914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ceffhbdbf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_ceffhbdbf()
    {
      Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ceffhbdbf));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr);
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_PlacementDestroyData_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (PlacementDestroyData_DestroyReason));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (Team_Value));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_UnitLevel_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (UnitLevel_Level));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_PlacementDestroyData_Start));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_PlacementDestroyData_Count));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_UnitLevel_Start));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedFields_UnitLevel_Count));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_PlacementDestroyData));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_UnitLevel));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_CastleBuildingAttachedChildrenBuffer));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_PlacementDestroyData_DestroyReason));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (FrameChangedIndex_UnitLevel_Level));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataStartOffset_PlacementDestroyData));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataSize_PlacementDestroyData));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataStartOffset_UnitLevel));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (ComponentDataSize_UnitLevel));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (CompBit_PlacementDestroyData));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (CompBit_UnitLevel));
      Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, nameof (CompBit_CastleBuildingAttachedChildrenBuffer));
      Snapshot_ceffhbdbf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, 100664492);
      Snapshot_ceffhbdbf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, 100664493);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ceffhbdbf>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlacementDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlacementDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitLevel_Start
    {
      get
      {
        int fieldsUnitLevelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start, (void*) &fieldsUnitLevelStart);
        return fieldsUnitLevelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitLevel_Count
    {
      get
      {
        int fieldsUnitLevelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count, (void*) &fieldsUnitLevelCount);
        return fieldsUnitLevelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitLevel
    {
      get
      {
        int changedIndexUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel, (void*) &changedIndexUnitLevel);
        return changedIndexUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        int attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlacementDestroyData_DestroyReason
    {
      get
      {
        int dataDestroyReason;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason, (void*) &dataDestroyReason);
        return dataDestroyReason;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitLevel_Level
    {
      get
      {
        int indexUnitLevelLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level, (void*) &indexUnitLevelLevel);
        return indexUnitLevelLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_UnitLevel
    {
      get
      {
        int startOffsetUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel, (void*) &startOffsetUnitLevel);
        return startOffsetUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_UnitLevel
    {
      get
      {
        int dataSizeUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_UnitLevel, (void*) &dataSizeUnitLevel);
        return dataSizeUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_ComponentDataSize_UnitLevel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_PlacementDestroyData
    {
      get
      {
        ulong placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UnitLevel
    {
      get
      {
        ulong compBitUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_UnitLevel, (void*) &compBitUnitLevel);
        return compBitUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_UnitLevel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        ulong attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ceffhbdbf.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }
  }
}
