// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_iddhiekfi
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
  public struct Snapshot_iddhiekfi
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkPortal_ToChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal_ToChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ChunkPortal;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ChunkPortal;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ChunkPortal;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public int2 ChunkPortal_ToChunk;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1588187, XrefRangeEnd = 1588192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_iddhiekfi.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1588201, RefRangeEnd = 1588202, XrefRangeStart = 1588192, XrefRangeEnd = 1588201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_iddhiekfi.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_iddhiekfi()
    {
      Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_iddhiekfi));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr);
      Snapshot_iddhiekfi.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_ChunkPortal_ToChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (ChunkPortal_ToChunk));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (FrameChangedFields_ChunkPortal_Start));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (FrameChangedFields_ChunkPortal_Count));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (FrameChangedIndex_ChunkPortal));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal_ToChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (FrameChangedIndex_ChunkPortal_ToChunk));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_ComponentDataStartOffset_ChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (ComponentDataStartOffset_ChunkPortal));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_ComponentDataSize_ChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (ComponentDataSize_ChunkPortal));
      Snapshot_iddhiekfi.NativeFieldInfoPtr_CompBit_ChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, nameof (CompBit_ChunkPortal));
      Snapshot_iddhiekfi.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, 100664708);
      Snapshot_iddhiekfi.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, 100664709);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_iddhiekfi>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ChunkPortal_Start
    {
      get
      {
        int chunkPortalStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Start, (void*) &chunkPortalStart);
        return chunkPortalStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ChunkPortal_Count
    {
      get
      {
        int chunkPortalCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Count, (void*) &chunkPortalCount);
        return chunkPortalCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedFields_ChunkPortal_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ChunkPortal
    {
      get
      {
        int indexChunkPortal;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal, (void*) &indexChunkPortal);
        return indexChunkPortal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ChunkPortal_ToChunk
    {
      get
      {
        int chunkPortalToChunk;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal_ToChunk, (void*) &chunkPortalToChunk);
        return chunkPortalToChunk;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_FrameChangedIndex_ChunkPortal_ToChunk, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ChunkPortal
    {
      get
      {
        int offsetChunkPortal;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_ComponentDataStartOffset_ChunkPortal, (void*) &offsetChunkPortal);
        return offsetChunkPortal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_ComponentDataStartOffset_ChunkPortal, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ChunkPortal
    {
      get
      {
        int dataSizeChunkPortal;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_ComponentDataSize_ChunkPortal, (void*) &dataSizeChunkPortal);
        return dataSizeChunkPortal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_ComponentDataSize_ChunkPortal, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ChunkPortal
    {
      get
      {
        ulong compBitChunkPortal;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_CompBit_ChunkPortal, (void*) &compBitChunkPortal);
        return compBitChunkPortal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_iddhiekfi.NativeFieldInfoPtr_CompBit_ChunkPortal, (void*) &value);
      }
    }
  }
}
