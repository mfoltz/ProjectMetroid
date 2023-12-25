// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.ReplayHeaders
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Replays
{
  public static class ReplayHeaders : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_V1_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_V1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryReadGuid_Private_Static_Boolean_byref_NetBufferIn_byref_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteGuid_Private_Static_Void_byref_NetBufferOut_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateInitialReplayHeader_Internal_Static_V1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteReplayHeader_Internal_Static_Void_BinaryWriter_V1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryReadHeader_Internal_Static_Boolean_String_byref_V1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryReadHeader_Internal_Static_Boolean_BinaryReader_byref_V1_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483499, XrefRangeEnd = 1483518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(ReplayHeaders.V1 header, ref NetBufferOut netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &header;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.NativeMethodInfoPtr_Serialize_Public_Static_Void_V1_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1483526, RefRangeEnd = 1483528, XrefRangeStart = 1483518, XrefRangeEnd = 1483526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Deserialize(ref NetBufferIn netBuffer, out ReplayHeaders.V1 header)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref header;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_V1_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483528, XrefRangeEnd = 1483535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryReadGuid(ref NetBufferIn netBuffer, out Il2CppSystem.Guid guid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref guid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.NativeMethodInfoPtr_TryReadGuid_Private_Static_Boolean_byref_NetBufferIn_byref_Guid_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483535, XrefRangeEnd = 1483546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteGuid(ref NetBufferOut netBuffer, Il2CppSystem.Guid guid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &guid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.NativeMethodInfoPtr_WriteGuid_Private_Static_Void_byref_NetBufferOut_Guid_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1483546, RefRangeEnd = 1483548, XrefRangeStart = 1483546, XrefRangeEnd = 1483546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ReplayHeaders.V1 CreateInitialReplayHeader()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.NativeMethodInfoPtr_CreateInitialReplayHeader_Internal_Static_V1_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ReplayHeaders.V1*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1483574, RefRangeEnd = 1483577, XrefRangeStart = 1483548, XrefRangeEnd = 1483574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteReplayHeader(
      BinaryWriter replayWriter,
      ReplayHeaders.V1 replayHeader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) replayWriter);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &replayHeader;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.NativeMethodInfoPtr_WriteReplayHeader_Internal_Static_Void_BinaryWriter_V1_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483577, XrefRangeEnd = 1483613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryReadHeader(
      string replayFullPath,
      out ReplayHeaders.V1 replayHeader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(replayFullPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref replayHeader;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.NativeMethodInfoPtr_TryReadHeader_Internal_Static_Boolean_String_byref_V1_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483621, RefRangeEnd = 1483622, XrefRangeStart = 1483613, XrefRangeEnd = 1483621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryReadHeader(
      BinaryReader replayReader,
      out ReplayHeaders.V1 replayHeader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) replayReader);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref replayHeader;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.NativeMethodInfoPtr_TryReadHeader_Internal_Static_Boolean_BinaryReader_byref_V1_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ReplayHeaders()
    {
      Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Replays", nameof (ReplayHeaders));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr);
      ReplayHeaders.NativeMethodInfoPtr_Serialize_Public_Static_Void_V1_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, 100663714);
      ReplayHeaders.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_V1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, 100663715);
      ReplayHeaders.NativeMethodInfoPtr_TryReadGuid_Private_Static_Boolean_byref_NetBufferIn_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, 100663716);
      ReplayHeaders.NativeMethodInfoPtr_WriteGuid_Private_Static_Void_byref_NetBufferOut_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, 100663717);
      ReplayHeaders.NativeMethodInfoPtr_CreateInitialReplayHeader_Internal_Static_V1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, 100663718);
      ReplayHeaders.NativeMethodInfoPtr_WriteReplayHeader_Internal_Static_Void_BinaryWriter_V1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, 100663719);
      ReplayHeaders.NativeMethodInfoPtr_TryReadHeader_Internal_Static_Boolean_String_byref_V1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, 100663720);
      ReplayHeaders.NativeMethodInfoPtr_TryReadHeader_Internal_Static_Boolean_BinaryReader_byref_V1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, 100663721);
    }

    public ReplayHeaders(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct V1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HeaderVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeaderVersionGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameplayVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_AssetsRevision;
      private static readonly System.IntPtr NativeFieldInfoPtr_CompletelyRecorded;
      private static readonly System.IntPtr NativeFieldInfoPtr_HailMessage;
      private static readonly System.IntPtr NativeFieldInfoPtr_HailMessagePositionBits;
      private static readonly System.IntPtr NativeFieldInfoPtr_HailMessageLengthBits;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_byref_NetBufferIn_byref_V1_0;
      [FieldOffset(0)]
      public int GameplayVersion;
      [FieldOffset(4)]
      public int AssetsRevision;
      [FieldOffset(8)]
      public bool CompletelyRecorded;
      [FieldOffset(16)]
      public NativeArray<byte> HailMessage;
      [FieldOffset(32)]
      public int HailMessagePositionBits;
      [FieldOffset(36)]
      public int HailMessageLengthBits;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1483489, RefRangeEnd = 1483491, XrefRangeStart = 1483483, XrefRangeEnd = 1483489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Serialize(ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.V1.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483491, XrefRangeEnd = 1483499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryDeserialize(
        ref NetBufferIn netBuffer,
        out ReplayHeaders.V1 header)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref header;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHeaders.V1.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_byref_NetBufferIn_byref_V1_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static V1()
      {
        Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplayHeaders>.NativeClassPtr, nameof (V1));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr);
        ReplayHeaders.V1.NativeFieldInfoPtr_HeaderVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (HeaderVersion));
        ReplayHeaders.V1.NativeFieldInfoPtr_HeaderVersionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (HeaderVersionGuid));
        ReplayHeaders.V1.NativeFieldInfoPtr_GameplayVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (GameplayVersion));
        ReplayHeaders.V1.NativeFieldInfoPtr_AssetsRevision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (AssetsRevision));
        ReplayHeaders.V1.NativeFieldInfoPtr_CompletelyRecorded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (CompletelyRecorded));
        ReplayHeaders.V1.NativeFieldInfoPtr_HailMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (HailMessage));
        ReplayHeaders.V1.NativeFieldInfoPtr_HailMessagePositionBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (HailMessagePositionBits));
        ReplayHeaders.V1.NativeFieldInfoPtr_HailMessageLengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (HailMessageLengthBits));
        ReplayHeaders.V1.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, 100663722);
        ReplayHeaders.V1.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_byref_NetBufferIn_byref_V1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, 100663723);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe int HeaderVersion
      {
        get
        {
          int headerVersion;
          IL2CPP.il2cpp_field_static_get_value(ReplayHeaders.V1.NativeFieldInfoPtr_HeaderVersion, (void*) &headerVersion);
          return headerVersion;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplayHeaders.V1.NativeFieldInfoPtr_HeaderVersion, (void*) &value);
        }
      }

      public static unsafe Il2CppSystem.Guid HeaderVersionGuid
      {
        get
        {
          Il2CppSystem.Guid headerVersionGuid;
          IL2CPP.il2cpp_field_static_get_value(ReplayHeaders.V1.NativeFieldInfoPtr_HeaderVersionGuid, (void*) &headerVersionGuid);
          return headerVersionGuid;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplayHeaders.V1.NativeFieldInfoPtr_HeaderVersionGuid, (void*) &value);
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Snapshot
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_PositionInFile;
        private static readonly System.IntPtr NativeFieldInfoPtr_EventIndex;
        private static readonly System.IntPtr NativeFieldInfoPtr_InputEventIndex;
        private static readonly System.IntPtr NativeFieldInfoPtr_BaseTime;
        private static readonly System.IntPtr NativeFieldInfoPtr_ScaledTime;
        [FieldOffset(0)]
        public int PositionInFile;
        [FieldOffset(4)]
        public int EventIndex;
        [FieldOffset(8)]
        public int InputEventIndex;
        [FieldOffset(16)]
        public double BaseTime;
        [FieldOffset(24)]
        public double ScaledTime;

        static Snapshot()
        {
          Il2CppClassPointerStore<ReplayHeaders.V1.Snapshot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplayHeaders.V1>.NativeClassPtr, nameof (Snapshot));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayHeaders.V1.Snapshot>.NativeClassPtr);
          ReplayHeaders.V1.Snapshot.NativeFieldInfoPtr_PositionInFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1.Snapshot>.NativeClassPtr, nameof (PositionInFile));
          ReplayHeaders.V1.Snapshot.NativeFieldInfoPtr_EventIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1.Snapshot>.NativeClassPtr, nameof (EventIndex));
          ReplayHeaders.V1.Snapshot.NativeFieldInfoPtr_InputEventIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1.Snapshot>.NativeClassPtr, nameof (InputEventIndex));
          ReplayHeaders.V1.Snapshot.NativeFieldInfoPtr_BaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1.Snapshot>.NativeClassPtr, nameof (BaseTime));
          ReplayHeaders.V1.Snapshot.NativeFieldInfoPtr_ScaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHeaders.V1.Snapshot>.NativeClassPtr, nameof (ScaledTime));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplayHeaders.V1.Snapshot>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }
  }
}
