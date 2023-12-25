// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_jjjcegjeg
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
  public struct Snapshot_jjjcegjeg
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_AiEnabledCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_AiHighPriorityCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_BytesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_BytesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_EntitiesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_EntitiesEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_Fps;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_FrameCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_FrameTimeMs;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_MessagesMaxBytesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_MessagesMaxBytesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_MessagesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_MessagesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_NetworkedEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_NetworkStatsTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_PacketsReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData_PacketsSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ServerDebugViewData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ServerDebugViewData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_AiEnabledCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_AiHighPriorityCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_BytesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_BytesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_EntitiesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_EntitiesEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_Fps;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_FrameCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_FrameTimeMs;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_NetworkedEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_NetworkStatsTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_PacketsReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_PacketsSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ServerDebugViewData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ServerDebugViewData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ServerDebugViewData;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public int ServerDebugViewData_AiEnabledCount;
    [FieldOffset(12)]
    public int ServerDebugViewData_AiHighPriorityCount;
    [FieldOffset(16)]
    public int ServerDebugViewData_BytesReceivedPerSecond;
    [FieldOffset(20)]
    public int ServerDebugViewData_BytesSentPerSecond;
    [FieldOffset(24)]
    public int ServerDebugViewData_EntitiesDisabled;
    [FieldOffset(28)]
    public int ServerDebugViewData_EntitiesEnabled;
    [FieldOffset(32)]
    public int ServerDebugViewData_Fps;
    [FieldOffset(36)]
    public int ServerDebugViewData_FrameCounter;
    [FieldOffset(40)]
    public float ServerDebugViewData_FrameTimeMs;
    [FieldOffset(44)]
    public int ServerDebugViewData_MessagesMaxBytesReceivedPerSecond;
    [FieldOffset(48)]
    public int ServerDebugViewData_MessagesMaxBytesSentPerSecond;
    [FieldOffset(52)]
    public int ServerDebugViewData_MessagesReceivedPerSecond;
    [FieldOffset(56)]
    public int ServerDebugViewData_MessagesSentPerSecond;
    [FieldOffset(60)]
    public int ServerDebugViewData_NetworkedEntities;
    [FieldOffset(64)]
    public double ServerDebugViewData_NetworkStatsTime;
    [FieldOffset(72)]
    public int ServerDebugViewData_PacketsReceivedPerSecond;
    [FieldOffset(76)]
    public int ServerDebugViewData_PacketsSentPerSecond;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1589438, XrefRangeEnd = 1589474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_jjjcegjeg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1589514, RefRangeEnd = 1589515, XrefRangeStart = 1589474, XrefRangeEnd = 1589514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_jjjcegjeg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_jjjcegjeg()
    {
      Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_jjjcegjeg));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr);
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_AiEnabledCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_AiEnabledCount));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_AiHighPriorityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_AiHighPriorityCount));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_BytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_BytesReceivedPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_BytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_BytesSentPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_EntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_EntitiesDisabled));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_EntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_EntitiesEnabled));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_Fps));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_FrameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_FrameCounter));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_FrameTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_FrameTimeMs));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_MessagesMaxBytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_MessagesMaxBytesReceivedPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_MessagesMaxBytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_MessagesMaxBytesSentPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_MessagesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_MessagesReceivedPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_MessagesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_MessagesSentPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_NetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_NetworkedEntities));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_NetworkStatsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_NetworkStatsTime));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_PacketsReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_PacketsReceivedPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ServerDebugViewData_PacketsSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ServerDebugViewData_PacketsSentPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedFields_ServerDebugViewData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedFields_ServerDebugViewData_Start));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedFields_ServerDebugViewData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedFields_ServerDebugViewData_Count));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_AiEnabledCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_AiEnabledCount));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_AiHighPriorityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_AiHighPriorityCount));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_BytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_BytesReceivedPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_BytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_BytesSentPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_EntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_EntitiesDisabled));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_EntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_EntitiesEnabled));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_Fps));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_FrameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_FrameCounter));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_FrameTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_FrameTimeMs));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesReceivedPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesSentPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_MessagesReceivedPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_MessagesSentPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_NetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_NetworkedEntities));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_NetworkStatsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_NetworkStatsTime));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_PacketsReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_PacketsReceivedPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_PacketsSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (FrameChangedIndex_ServerDebugViewData_PacketsSentPerSecond));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ComponentDataStartOffset_ServerDebugViewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ComponentDataStartOffset_ServerDebugViewData));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_ComponentDataSize_ServerDebugViewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (ComponentDataSize_ServerDebugViewData));
      Snapshot_jjjcegjeg.NativeFieldInfoPtr_CompBit_ServerDebugViewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, nameof (CompBit_ServerDebugViewData));
      Snapshot_jjjcegjeg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, 100664730);
      Snapshot_jjjcegjeg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, 100664731);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_jjjcegjeg>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ServerDebugViewData_Start
    {
      get
      {
        int debugViewDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedFields_ServerDebugViewData_Start, (void*) &debugViewDataStart);
        return debugViewDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedFields_ServerDebugViewData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ServerDebugViewData_Count
    {
      get
      {
        int debugViewDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedFields_ServerDebugViewData_Count, (void*) &debugViewDataCount);
        return debugViewDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedFields_ServerDebugViewData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData
    {
      get
      {
        int serverDebugViewData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData, (void*) &serverDebugViewData);
        return serverDebugViewData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_AiEnabledCount
    {
      get
      {
        int dataAiEnabledCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_AiEnabledCount, (void*) &dataAiEnabledCount);
        return dataAiEnabledCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_AiEnabledCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_AiHighPriorityCount
    {
      get
      {
        int highPriorityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_AiHighPriorityCount, (void*) &highPriorityCount);
        return highPriorityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_AiHighPriorityCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_BytesReceivedPerSecond
    {
      get
      {
        int receivedPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_BytesReceivedPerSecond, (void*) &receivedPerSecond);
        return receivedPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_BytesReceivedPerSecond, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_BytesSentPerSecond
    {
      get
      {
        int bytesSentPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_BytesSentPerSecond, (void*) &bytesSentPerSecond);
        return bytesSentPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_BytesSentPerSecond, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_EntitiesDisabled
    {
      get
      {
        int entitiesDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_EntitiesDisabled, (void*) &entitiesDisabled);
        return entitiesDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_EntitiesDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_EntitiesEnabled
    {
      get
      {
        int dataEntitiesEnabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_EntitiesEnabled, (void*) &dataEntitiesEnabled);
        return dataEntitiesEnabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_EntitiesEnabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_Fps
    {
      get
      {
        int debugViewDataFps;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_Fps, (void*) &debugViewDataFps);
        return debugViewDataFps;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_Fps, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_FrameCounter
    {
      get
      {
        int dataFrameCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_FrameCounter, (void*) &dataFrameCounter);
        return dataFrameCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_FrameCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_FrameTimeMs
    {
      get
      {
        int viewDataFrameTimeMs;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_FrameTimeMs, (void*) &viewDataFrameTimeMs);
        return viewDataFrameTimeMs;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_FrameTimeMs, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesReceivedPerSecond
    {
      get
      {
        int receivedPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesReceivedPerSecond, (void*) &receivedPerSecond);
        return receivedPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesReceivedPerSecond, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesSentPerSecond
    {
      get
      {
        int bytesSentPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesSentPerSecond, (void*) &bytesSentPerSecond);
        return bytesSentPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesMaxBytesSentPerSecond, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_MessagesReceivedPerSecond
    {
      get
      {
        int receivedPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesReceivedPerSecond, (void*) &receivedPerSecond);
        return receivedPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesReceivedPerSecond, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_MessagesSentPerSecond
    {
      get
      {
        int messagesSentPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesSentPerSecond, (void*) &messagesSentPerSecond);
        return messagesSentPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_MessagesSentPerSecond, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_NetworkedEntities
    {
      get
      {
        int networkedEntities;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_NetworkedEntities, (void*) &networkedEntities);
        return networkedEntities;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_NetworkedEntities, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_NetworkStatsTime
    {
      get
      {
        int networkStatsTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_NetworkStatsTime, (void*) &networkStatsTime);
        return networkStatsTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_NetworkStatsTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_PacketsReceivedPerSecond
    {
      get
      {
        int receivedPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_PacketsReceivedPerSecond, (void*) &receivedPerSecond);
        return receivedPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_PacketsReceivedPerSecond, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ServerDebugViewData_PacketsSentPerSecond
    {
      get
      {
        int packetsSentPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_PacketsSentPerSecond, (void*) &packetsSentPerSecond);
        return packetsSentPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_FrameChangedIndex_ServerDebugViewData_PacketsSentPerSecond, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ServerDebugViewData
    {
      get
      {
        int serverDebugViewData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_ComponentDataStartOffset_ServerDebugViewData, (void*) &serverDebugViewData);
        return serverDebugViewData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_ComponentDataStartOffset_ServerDebugViewData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ServerDebugViewData
    {
      get
      {
        int serverDebugViewData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_ComponentDataSize_ServerDebugViewData, (void*) &serverDebugViewData);
        return serverDebugViewData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_ComponentDataSize_ServerDebugViewData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ServerDebugViewData
    {
      get
      {
        ulong serverDebugViewData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_CompBit_ServerDebugViewData, (void*) &serverDebugViewData);
        return serverDebugViewData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jjjcegjeg.NativeFieldInfoPtr_CompBit_ServerDebugViewData, (void*) &value);
      }
    }
  }
}
