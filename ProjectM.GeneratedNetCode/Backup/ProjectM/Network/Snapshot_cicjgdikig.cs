// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cicjgdikig
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cicjgdikig
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StoredConsumeCount_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StoredConsumeCount_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StoredConsumeCount_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StoredConsumeCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StoredConsumeCount_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StoredConsumeCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StoredConsumeCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StoredConsumeCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public int StoredConsumeCount_Count;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1572520, XrefRangeEnd = 1572524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cicjgdikig.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1572532, RefRangeEnd = 1572533, XrefRangeStart = 1572524, XrefRangeEnd = 1572532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cicjgdikig.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cicjgdikig()
    {
      Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cicjgdikig));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr);
      Snapshot_cicjgdikig.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_StoredConsumeCount_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (StoredConsumeCount_Count));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedFields_StoredConsumeCount_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (FrameChangedFields_StoredConsumeCount_Start));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedFields_StoredConsumeCount_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (FrameChangedFields_StoredConsumeCount_Count));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedIndex_StoredConsumeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (FrameChangedIndex_StoredConsumeCount));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedIndex_StoredConsumeCount_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (FrameChangedIndex_StoredConsumeCount_Count));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_ComponentDataStartOffset_StoredConsumeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (ComponentDataStartOffset_StoredConsumeCount));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_ComponentDataSize_StoredConsumeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (ComponentDataSize_StoredConsumeCount));
      Snapshot_cicjgdikig.NativeFieldInfoPtr_CompBit_StoredConsumeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, nameof (CompBit_StoredConsumeCount));
      Snapshot_cicjgdikig.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, 100664556);
      Snapshot_cicjgdikig.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, 100664557);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cicjgdikig>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StoredConsumeCount_Start
    {
      get
      {
        int consumeCountStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedFields_StoredConsumeCount_Start, (void*) &consumeCountStart);
        return consumeCountStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedFields_StoredConsumeCount_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StoredConsumeCount_Count
    {
      get
      {
        int consumeCountCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedFields_StoredConsumeCount_Count, (void*) &consumeCountCount);
        return consumeCountCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedFields_StoredConsumeCount_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StoredConsumeCount
    {
      get
      {
        int storedConsumeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedIndex_StoredConsumeCount, (void*) &storedConsumeCount);
        return storedConsumeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedIndex_StoredConsumeCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StoredConsumeCount_Count
    {
      get
      {
        int consumeCountCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedIndex_StoredConsumeCount_Count, (void*) &consumeCountCount);
        return consumeCountCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_FrameChangedIndex_StoredConsumeCount_Count, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StoredConsumeCount
    {
      get
      {
        int storedConsumeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_ComponentDataStartOffset_StoredConsumeCount, (void*) &storedConsumeCount);
        return storedConsumeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_ComponentDataStartOffset_StoredConsumeCount, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StoredConsumeCount
    {
      get
      {
        int storedConsumeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_ComponentDataSize_StoredConsumeCount, (void*) &storedConsumeCount);
        return storedConsumeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_ComponentDataSize_StoredConsumeCount, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StoredConsumeCount
    {
      get
      {
        ulong storedConsumeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_CompBit_StoredConsumeCount, (void*) &storedConsumeCount);
        return storedConsumeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cicjgdikig.NativeFieldInfoPtr_CompBit_StoredConsumeCount, (void*) &value);
      }
    }
  }
}
