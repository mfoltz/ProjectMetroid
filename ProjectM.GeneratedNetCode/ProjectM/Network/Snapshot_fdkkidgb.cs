// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_fdkkidgb
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_fdkkidgb
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UnitLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float LifeTime_Duration;
    [FieldOffset(12)]
    public TileModelDestroyReason PlacementDestroyData_DestroyReason;
    [FieldOffset(16)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(20)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(28)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(29)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(41)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(42)]
    public int Team_FactionIndex;
    [FieldOffset(46)]
    public int Team_Value;
    [FieldOffset(50)]
    public ProjectM.TileType TileModel_DisabledTileTypes;
    [FieldOffset(51)]
    public int UnitLevel_Level;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1581994, XrefRangeEnd = 1582102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_fdkkidgb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1582139, RefRangeEnd = 1582140, XrefRangeStart = 1582102, XrefRangeEnd = 1582139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_fdkkidgb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_fdkkidgb()
    {
      Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_fdkkidgb));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr);
      Snapshot_fdkkidgb.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_PlacementDestroyData_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (PlacementDestroyData_DestroyReason));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (Team_Value));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_UnitLevel_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (UnitLevel_Level));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_PlacementDestroyData_Start));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_PlacementDestroyData_Count));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_UnitLevel_Start));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedFields_UnitLevel_Count));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_PlacementDestroyData));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_UnitLevel));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_PlacementDestroyData_DestroyReason));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (FrameChangedIndex_UnitLevel_Level));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataStartOffset_PlacementDestroyData));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataSize_PlacementDestroyData));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataStartOffset_UnitLevel));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (ComponentDataSize_UnitLevel));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (CompBit_PlacementDestroyData));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, nameof (CompBit_UnitLevel));
      Snapshot_fdkkidgb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, 100664650);
      Snapshot_fdkkidgb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, 100664651);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_fdkkidgb>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlacementDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlacementDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitLevel_Start
    {
      get
      {
        int fieldsUnitLevelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start, (void*) &fieldsUnitLevelStart);
        return fieldsUnitLevelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitLevel_Count
    {
      get
      {
        int fieldsUnitLevelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count, (void*) &fieldsUnitLevelCount);
        return fieldsUnitLevelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitLevel
    {
      get
      {
        int changedIndexUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel, (void*) &changedIndexUnitLevel);
        return changedIndexUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlacementDestroyData_DestroyReason
    {
      get
      {
        int dataDestroyReason;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason, (void*) &dataDestroyReason);
        return dataDestroyReason;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitLevel_Level
    {
      get
      {
        int indexUnitLevelLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level, (void*) &indexUnitLevelLevel);
        return indexUnitLevelLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_UnitLevel
    {
      get
      {
        int startOffsetUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel, (void*) &startOffsetUnitLevel);
        return startOffsetUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_UnitLevel
    {
      get
      {
        int dataSizeUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_UnitLevel, (void*) &dataSizeUnitLevel);
        return dataSizeUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_ComponentDataSize_UnitLevel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_PlacementDestroyData
    {
      get
      {
        ulong placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UnitLevel
    {
      get
      {
        ulong compBitUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_UnitLevel, (void*) &compBitUnitLevel);
        return compBitUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdkkidgb.NativeFieldInfoPtr_CompBit_UnitLevel, (void*) &value);
      }
    }
  }
}
