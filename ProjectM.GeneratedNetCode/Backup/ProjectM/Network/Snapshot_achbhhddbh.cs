// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_achbhhddbh
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_achbhhddbh
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartConnection_CastleHeartEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatedTime_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPoint_HasRespawnPointOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPoint_RespawnPointOwner;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_RespawnPoint_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_RespawnPoint_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint_HasRespawnPointOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint_RespawnPointOwner;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_RespawnPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_RespawnPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_RespawnPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(24)]
    public NetworkId CastleHeartConnection_CastleHeartEntity;
    [FieldOffset(32)]
    public double CreatedTime_CreateTime;
    [FieldOffset(40)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(41)]
    public bool RespawnPoint_HasRespawnPointOwner;
    [FieldOffset(42)]
    public NetworkId RespawnPoint_RespawnPointOwner;
    [FieldOffset(50)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(54)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(62)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(63)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(75)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(76)]
    public int Team_FactionIndex;
    [FieldOffset(80)]
    public int Team_Value;
    [FieldOffset(84)]
    public ProjectM.TileType TileModel_DisabledTileTypes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1533188, XrefRangeEnd = 1533256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_achbhhddbh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1533306, RefRangeEnd = 1533307, XrefRangeStart = 1533256, XrefRangeEnd = 1533306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_achbhhddbh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_achbhhddbh()
    {
      Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_achbhhddbh));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr);
      Snapshot_achbhhddbh.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CastleHeartConnection_CastleHeartEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CastleHeartConnection_CastleHeartEntity));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CreatedTime_CreateTime));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_RespawnPoint_HasRespawnPointOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (RespawnPoint_HasRespawnPointOwner));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_RespawnPoint_RespawnPointOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (RespawnPoint_RespawnPointOwner));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (Team_Value));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_CastleHeartConnection_Start));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_CastleHeartConnection_Count));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Start));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Count));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_RespawnPoint_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_RespawnPoint_Start));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_RespawnPoint_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_RespawnPoint_Count));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeartConnection));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_RespawnPoint));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeartConnection_CastleHeartEntity));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime_CreateTime));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint_HasRespawnPointOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_RespawnPoint_HasRespawnPointOwner));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint_RespawnPointOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_RespawnPoint_RespawnPointOwner));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleHeartConnection));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataSize_CastleHeartConnection));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataStartOffset_CreatedTime));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataSize_CreatedTime));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataStartOffset_RespawnPoint));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataSize_RespawnPoint));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CompBit_CastleHeartConnection));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CompBit_CreatedTime));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CompBit_RespawnPoint));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_achbhhddbh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, 100664220);
      Snapshot_achbhhddbh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, 100664221);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_achbhhddbh>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleHeartConnection_Start
    {
      get
      {
        int heartConnectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start, (void*) &heartConnectionStart);
        return heartConnectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleHeartConnection_Count
    {
      get
      {
        int heartConnectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count, (void*) &heartConnectionCount);
        return heartConnectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Start
    {
      get
      {
        int createdTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &createdTimeStart);
        return createdTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Count
    {
      get
      {
        int createdTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &createdTimeCount);
        return createdTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_RespawnPoint_Start
    {
      get
      {
        int respawnPointStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_RespawnPoint_Start, (void*) &respawnPointStart);
        return respawnPointStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_RespawnPoint_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_RespawnPoint_Count
    {
      get
      {
        int respawnPointCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_RespawnPoint_Count, (void*) &respawnPointCount);
        return respawnPointCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_RespawnPoint_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime
    {
      get
      {
        int indexCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &indexCreatedTime);
        return indexCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RespawnPoint
    {
      get
      {
        int indexRespawnPoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint, (void*) &indexRespawnPoint);
        return indexRespawnPoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeartConnection_CastleHeartEntity
    {
      get
      {
        int castleHeartEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity, (void*) &castleHeartEntity);
        return castleHeartEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime_CreateTime
    {
      get
      {
        int createdTimeCreateTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &createdTimeCreateTime);
        return createdTimeCreateTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RespawnPoint_HasRespawnPointOwner
    {
      get
      {
        int respawnPointOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint_HasRespawnPointOwner, (void*) &respawnPointOwner);
        return respawnPointOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint_HasRespawnPointOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RespawnPoint_RespawnPointOwner
    {
      get
      {
        int respawnPointOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint_RespawnPointOwner, (void*) &respawnPointOwner);
        return respawnPointOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_RespawnPoint_RespawnPointOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CreatedTime
    {
      get
      {
        int offsetCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &offsetCreatedTime);
        return offsetCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CreatedTime
    {
      get
      {
        int dataSizeCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &dataSizeCreatedTime);
        return dataSizeCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_RespawnPoint
    {
      get
      {
        int offsetRespawnPoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_RespawnPoint, (void*) &offsetRespawnPoint);
        return offsetRespawnPoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_RespawnPoint, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_RespawnPoint
    {
      get
      {
        int sizeRespawnPoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_RespawnPoint, (void*) &sizeRespawnPoint);
        return sizeRespawnPoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_RespawnPoint, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleHeartConnection
    {
      get
      {
        ulong castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CreatedTime
    {
      get
      {
        ulong compBitCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &compBitCreatedTime);
        return compBitCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_RespawnPoint
    {
      get
      {
        ulong compBitRespawnPoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_RespawnPoint, (void*) &compBitRespawnPoint);
        return compBitRespawnPoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_RespawnPoint, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achbhhddbh.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }
  }
}
