// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cjbcjhhgke
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
  public struct Snapshot_cjbcjhhgke
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime_ModifiedTimeOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime_TimeOnServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ServerTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ServerTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerTime_ModifiedTimeOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerTime_TimeOnServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ServerTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public double ServerTime_ModifiedTimeOffset;
    [FieldOffset(16)]
    public double ServerTime_TimeOnServer;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1573535, XrefRangeEnd = 1573541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cjbcjhhgke.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1573551, RefRangeEnd = 1573552, XrefRangeStart = 1573541, XrefRangeEnd = 1573551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cjbcjhhgke.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cjbcjhhgke()
    {
      Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cjbcjhhgke));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr);
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_ServerTime_ModifiedTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (ServerTime_ModifiedTimeOffset));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_ServerTime_TimeOnServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (ServerTime_TimeOnServer));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedFields_ServerTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (FrameChangedFields_ServerTime_Start));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedFields_ServerTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (FrameChangedFields_ServerTime_Count));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (FrameChangedIndex_ServerTime));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime_ModifiedTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (FrameChangedIndex_ServerTime_ModifiedTimeOffset));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime_TimeOnServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (FrameChangedIndex_ServerTime_TimeOnServer));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_ComponentDataStartOffset_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (ComponentDataStartOffset_ServerTime));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_ComponentDataSize_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (ComponentDataSize_ServerTime));
      Snapshot_cjbcjhhgke.NativeFieldInfoPtr_CompBit_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, nameof (CompBit_ServerTime));
      Snapshot_cjbcjhhgke.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, 100664566);
      Snapshot_cjbcjhhgke.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, 100664567);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cjbcjhhgke>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ServerTime_Start
    {
      get
      {
        int fieldsServerTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedFields_ServerTime_Start, (void*) &fieldsServerTimeStart);
        return fieldsServerTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedFields_ServerTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ServerTime_Count
    {
      get
      {
        int fieldsServerTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedFields_ServerTime_Count, (void*) &fieldsServerTimeCount);
        return fieldsServerTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedFields_ServerTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerTime
    {
      get
      {
        int changedIndexServerTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime, (void*) &changedIndexServerTime);
        return changedIndexServerTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerTime_ModifiedTimeOffset
    {
      get
      {
        int modifiedTimeOffset;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime_ModifiedTimeOffset, (void*) &modifiedTimeOffset);
        return modifiedTimeOffset;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime_ModifiedTimeOffset, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerTime_TimeOnServer
    {
      get
      {
        int timeTimeOnServer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime_TimeOnServer, (void*) &timeTimeOnServer);
        return timeTimeOnServer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_FrameChangedIndex_ServerTime_TimeOnServer, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ServerTime
    {
      get
      {
        int offsetServerTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_ComponentDataStartOffset_ServerTime, (void*) &offsetServerTime);
        return offsetServerTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_ComponentDataStartOffset_ServerTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ServerTime
    {
      get
      {
        int dataSizeServerTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_ComponentDataSize_ServerTime, (void*) &dataSizeServerTime);
        return dataSizeServerTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_ComponentDataSize_ServerTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ServerTime
    {
      get
      {
        ulong compBitServerTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_CompBit_ServerTime, (void*) &compBitServerTime);
        return compBitServerTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbcjhhgke.NativeFieldInfoPtr_CompBit_ServerTime, (void*) &value);
      }
    }
  }
}
