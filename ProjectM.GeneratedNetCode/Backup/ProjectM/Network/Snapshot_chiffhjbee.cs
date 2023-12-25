// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_chiffhjbee
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
  public struct Snapshot_chiffhjbee
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugLogs_ErrorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugLogs_ExceptionCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugLogs_LogCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugLogs_WarningCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ServerDebugLogs_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ServerDebugLogs_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_ErrorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_ExceptionCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_LogCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_WarningCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ServerDebugLogs;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ServerDebugLogs;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ServerDebugLogs;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public int ServerDebugLogs_ErrorCount;
    [FieldOffset(12)]
    public int ServerDebugLogs_ExceptionCount;
    [FieldOffset(16)]
    public int ServerDebugLogs_LogCount;
    [FieldOffset(20)]
    public int ServerDebugLogs_WarningCount;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1572149, XrefRangeEnd = 1572159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_chiffhjbee.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1572173, RefRangeEnd = 1572174, XrefRangeStart = 1572159, XrefRangeEnd = 1572173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_chiffhjbee.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_chiffhjbee()
    {
      Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_chiffhjbee));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr);
      Snapshot_chiffhjbee.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_ServerDebugLogs_ErrorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (ServerDebugLogs_ErrorCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_ServerDebugLogs_ExceptionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (ServerDebugLogs_ExceptionCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_ServerDebugLogs_LogCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (ServerDebugLogs_LogCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_ServerDebugLogs_WarningCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (ServerDebugLogs_WarningCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedFields_ServerDebugLogs_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChangedFields_ServerDebugLogs_Start));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedFields_ServerDebugLogs_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChangedFields_ServerDebugLogs_Count));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugLogs));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_ErrorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugLogs_ErrorCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_ExceptionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugLogs_ExceptionCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_LogCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugLogs_LogCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_WarningCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugLogs_WarningCount));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_ComponentDataStartOffset_ServerDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (ComponentDataStartOffset_ServerDebugLogs));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_ComponentDataSize_ServerDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (ComponentDataSize_ServerDebugLogs));
      Snapshot_chiffhjbee.NativeFieldInfoPtr_CompBit_ServerDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, nameof (CompBit_ServerDebugLogs));
      Snapshot_chiffhjbee.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, 100664550);
      Snapshot_chiffhjbee.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, 100664551);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_chiffhjbee>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ServerDebugLogs_Start
    {
      get
      {
        int serverDebugLogsStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedFields_ServerDebugLogs_Start, (void*) &serverDebugLogsStart);
        return serverDebugLogsStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedFields_ServerDebugLogs_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ServerDebugLogs_Count
    {
      get
      {
        int serverDebugLogsCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedFields_ServerDebugLogs_Count, (void*) &serverDebugLogsCount);
        return serverDebugLogsCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedFields_ServerDebugLogs_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugLogs
    {
      get
      {
        int indexServerDebugLogs;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs, (void*) &indexServerDebugLogs);
        return indexServerDebugLogs;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugLogs_ErrorCount
    {
      get
      {
        int debugLogsErrorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_ErrorCount, (void*) &debugLogsErrorCount);
        return debugLogsErrorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_ErrorCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugLogs_ExceptionCount
    {
      get
      {
        int logsExceptionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_ExceptionCount, (void*) &logsExceptionCount);
        return logsExceptionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_ExceptionCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugLogs_LogCount
    {
      get
      {
        int debugLogsLogCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_LogCount, (void*) &debugLogsLogCount);
        return debugLogsLogCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_LogCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugLogs_WarningCount
    {
      get
      {
        int logsWarningCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_WarningCount, (void*) &logsWarningCount);
        return logsWarningCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugLogs_WarningCount, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ServerDebugLogs
    {
      get
      {
        int offsetServerDebugLogs;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_ComponentDataStartOffset_ServerDebugLogs, (void*) &offsetServerDebugLogs);
        return offsetServerDebugLogs;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_ComponentDataStartOffset_ServerDebugLogs, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ServerDebugLogs
    {
      get
      {
        int sizeServerDebugLogs;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_ComponentDataSize_ServerDebugLogs, (void*) &sizeServerDebugLogs);
        return sizeServerDebugLogs;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_ComponentDataSize_ServerDebugLogs, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ServerDebugLogs
    {
      get
      {
        ulong bitServerDebugLogs;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_CompBit_ServerDebugLogs, (void*) &bitServerDebugLogs);
        return bitServerDebugLogs;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chiffhjbee.NativeFieldInfoPtr_CompBit_ServerDebugLogs, (void*) &value);
      }
    }
  }
}
