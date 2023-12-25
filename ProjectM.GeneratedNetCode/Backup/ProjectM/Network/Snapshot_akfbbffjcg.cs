// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_akfbbffjcg
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_akfbbffjcg
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkPortal_ToChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal_ToChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ChunkPortal;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ChunkPortal;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ChunkPortal;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Translation;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public int2 ChunkPortal_ToChunk;
    [FieldOffset(16)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(17)]
    public quaternion Rotation_Value;
    [FieldOffset(33)]
    public int Team_FactionIndex;
    [FieldOffset(37)]
    public int Team_Value;
    [FieldOffset(41)]
    public TileType TileModel_DisabledTileTypes;
    [FieldOffset(42)]
    public float3 Translation_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1553443, XrefRangeEnd = 1553492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_akfbbffjcg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1553522, RefRangeEnd = 1553523, XrefRangeStart = 1553492, XrefRangeEnd = 1553522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_akfbbffjcg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_akfbbffjcg()
    {
      Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_akfbbffjcg));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr);
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ChunkPortal_ToChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ChunkPortal_ToChunk));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (Rotation_Value));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (Team_Value));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (Translation_Value));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_ChunkPortal_Start));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_ChunkPortal_Count));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Start));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Count));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Translation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_Translation_Start));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Translation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedFields_Translation_Count));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_ChunkPortal));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_Rotation));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_Translation));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal_ToChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_ChunkPortal_ToChunk));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_Rotation_Value));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (FrameChangedIndex_Translation_Value));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_ChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataStartOffset_ChunkPortal));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_ChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataSize_ChunkPortal));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataStartOffset_Rotation));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataSize_Rotation));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataStartOffset_Translation));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (ComponentDataSize_Translation));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_ChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (CompBit_ChunkPortal));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (CompBit_Rotation));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, nameof (CompBit_Translation));
      Snapshot_akfbbffjcg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, 100664418);
      Snapshot_akfbbffjcg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, 100664419);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_akfbbffjcg>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ChunkPortal_Start
    {
      get
      {
        int chunkPortalStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Start, (void*) &chunkPortalStart);
        return chunkPortalStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ChunkPortal_Count
    {
      get
      {
        int chunkPortalCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Count, (void*) &chunkPortalCount);
        return chunkPortalCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Start
    {
      get
      {
        int fieldsRotationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &fieldsRotationStart);
        return fieldsRotationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Count
    {
      get
      {
        int fieldsRotationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &fieldsRotationCount);
        return fieldsRotationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ChunkPortal
    {
      get
      {
        int indexChunkPortal;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal, (void*) &indexChunkPortal);
        return indexChunkPortal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation
    {
      get
      {
        int changedIndexRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &changedIndexRotation);
        return changedIndexRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation
    {
      get
      {
        int indexTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &indexTranslation);
        return indexTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ChunkPortal_ToChunk
    {
      get
      {
        int chunkPortalToChunk;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal_ToChunk, (void*) &chunkPortalToChunk);
        return chunkPortalToChunk;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal_ToChunk, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation_Value
    {
      get
      {
        int indexRotationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &indexRotationValue);
        return indexRotationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ChunkPortal
    {
      get
      {
        int offsetChunkPortal;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_ChunkPortal, (void*) &offsetChunkPortal);
        return offsetChunkPortal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_ChunkPortal, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ChunkPortal
    {
      get
      {
        int dataSizeChunkPortal;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_ChunkPortal, (void*) &dataSizeChunkPortal);
        return dataSizeChunkPortal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_ChunkPortal, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Rotation
    {
      get
      {
        int startOffsetRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &startOffsetRotation);
        return startOffsetRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Rotation
    {
      get
      {
        int dataSizeRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &dataSizeRotation);
        return dataSizeRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Translation
    {
      get
      {
        int offsetTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &offsetTranslation);
        return offsetTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Translation
    {
      get
      {
        int dataSizeTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &dataSizeTranslation);
        return dataSizeTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ChunkPortal
    {
      get
      {
        ulong compBitChunkPortal;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_ChunkPortal, (void*) &compBitChunkPortal);
        return compBitChunkPortal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_ChunkPortal, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Rotation
    {
      get
      {
        ulong compBitRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Rotation, (void*) &compBitRotation);
        return compBitRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Rotation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Translation
    {
      get
      {
        ulong compBitTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Translation, (void*) &compBitTranslation);
        return compBitTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akfbbffjcg.NativeFieldInfoPtr_CompBit_Translation, (void*) &value);
      }
    }
  }
}
