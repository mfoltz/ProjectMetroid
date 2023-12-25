// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.ClientReplayRecorderSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;
using Il2CppSystem.Text.RegularExpressions;
using ProjectM.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Replays
{
  public class ClientReplayRecorderSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentReplayFileName;
    private static readonly System.IntPtr NativeFieldInfoPtr__StreamWriter;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplayWriter;
    private static readonly System.IntPtr NativeFieldInfoPtr__RecordingStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__Time;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__NumOfSnapshots;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplaySnapshotEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr__HailMessageQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__State;
    private static readonly System.IntPtr NativeFieldInfoPtr_SNAPSHOT_INTERVAL_SECONDS;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextSnapshotTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReplayHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleHailMessage_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleHailMessage_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RecordSnapshot_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RecordSnapshot_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RecordInputCommand_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RecordInputCommand_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RecordDataReceived_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RecordDataReceived_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_3;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartRecording_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StopRecording_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RewriteReplayHeader_Private_Void_V1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateReplayFile_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteInitialReplayHeader_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOldReplays_Private_Static_Void_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CloseStreams_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleHailMessage_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RecordSnapshot_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RecordInputCommand_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RecordDataReceived_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteEvent_Private_Void_ClientReplayEventType_NativeArray_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteEvent_Private_Void_ClientReplayEventType_Int32_NativeArray_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RecordSnapshot_b__27_0_Private_Void_byref_DynamicBuffer_1_ReplayStoreSnapshotEventBuffer_byref_DynamicBuffer_1_ReplayScreenshotBuffer_byref_ReplayStoreSnapshotEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RecordInputCommand_b__28_0_Private_Void_Entity_byref_LocalUser_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RecordDataReceived_b__29_0_Private_Void_DynamicBuffer_1_ReceivedPacketBuffer_byref_ReceivedPacket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleHailMessage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRecordSnapshot_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRecordInputCommand_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRecordDataReceived_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482936, XrefRangeEnd = 1482939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayRecorderSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482939, XrefRangeEnd = 1482943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayRecorderSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartRecording()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_StartRecording_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482943, XrefRangeEnd = 1482944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayRecorderSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482968, RefRangeEnd = 1482969, XrefRangeStart = 1482944, XrefRangeEnd = 1482968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StopRecording()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_StopRecording_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1482978, RefRangeEnd = 1482980, XrefRangeStart = 1482969, XrefRangeEnd = 1482978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RewriteReplayHeader(ReplayHeaders.V1 replayHeader)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &replayHeader;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_RewriteReplayHeader_Private_Void_V1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1483048, RefRangeEnd = 1483050, XrefRangeStart = 1482980, XrefRangeEnd = 1483048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateReplayFile(string replayFolderFullPath)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(replayFolderFullPath);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_CreateReplayFile_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483050, XrefRangeEnd = 1483052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WriteInitialReplayHeader()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_WriteInitialReplayHeader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1483137, RefRangeEnd = 1483139, XrefRangeStart = 1483052, XrefRangeEnd = 1483137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveOldReplays(string replayFolderFullPath, int maxNumOfReplays)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(replayFolderFullPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxNumOfReplays;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_RemoveOldReplays_Private_Static_Void_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483139, XrefRangeEnd = 1483142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CloseStreams()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_CloseStreams_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483142, XrefRangeEnd = 1483148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTime(double baseTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &baseTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_SetTime_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483148, XrefRangeEnd = 1483176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayRecorderSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483191, RefRangeEnd = 1483192, XrefRangeStart = 1483176, XrefRangeEnd = 1483191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleHailMessage()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_HandleHailMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483207, RefRangeEnd = 1483208, XrefRangeStart = 1483192, XrefRangeEnd = 1483207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RecordSnapshot()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_RecordSnapshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483220, RefRangeEnd = 1483221, XrefRangeStart = 1483208, XrefRangeEnd = 1483220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RecordInputCommand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_RecordInputCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483233, RefRangeEnd = 1483234, XrefRangeStart = 1483221, XrefRangeEnd = 1483233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RecordDataReceived()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_RecordDataReceived_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483234, XrefRangeEnd = 1483235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WriteEvent(ClientReplayEventType eventType, NativeArray<byte> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &eventType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_WriteEvent_Private_Void_ClientReplayEventType_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1483244, RefRangeEnd = 1483249, XrefRangeStart = 1483235, XrefRangeEnd = 1483244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WriteEvent(
      ClientReplayEventType eventType,
      int lengthBits,
      NativeArray<byte> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &eventType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lengthBits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr_WriteEvent_Private_Void_ClientReplayEventType_Int32_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientReplayRecorderSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483262, RefRangeEnd = 1483263, XrefRangeStart = 1483249, XrefRangeEnd = 1483262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RecordSnapshot_b__27_0(
      ref DynamicBuffer<ReplayStoreSnapshotEventBuffer> replaySnapshotEventBuffer,
      ref DynamicBuffer<ReplayScreenshotBuffer> replayScreenshotBuffer,
      [In] ref ReplayStoreSnapshotEvent replaySnapshotEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref replaySnapshotEventBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref replayScreenshotBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref replaySnapshotEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr__RecordSnapshot_b__27_0_Private_Void_byref_DynamicBuffer_1_ReplayStoreSnapshotEventBuffer_byref_DynamicBuffer_1_ReplayScreenshotBuffer_byref_ReplayStoreSnapshotEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483283, RefRangeEnd = 1483284, XrefRangeStart = 1483263, XrefRangeEnd = 1483283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RecordInputCommand_b__28_0(Entity localUserEntity, [In] ref LocalUser localUser)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &localUserEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUser;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr__RecordInputCommand_b__28_0_Private_Void_Entity_byref_LocalUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483291, RefRangeEnd = 1483292, XrefRangeStart = 1483284, XrefRangeEnd = 1483291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RecordDataReceived_b__29_0(
      DynamicBuffer<ReceivedPacketBuffer> packetBuffer,
      [In] ref ReceivedPacket receivedPacket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &packetBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref receivedPacket;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr__RecordDataReceived_b__29_0_Private_Void_DynamicBuffer_1_ReceivedPacketBuffer_byref_ReceivedPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483292, XrefRangeEnd = 1483406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayRecorderSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483406, XrefRangeEnd = 1483425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleHailMessage_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleHailMessage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483447, RefRangeEnd = 1483448, XrefRangeStart = 1483425, XrefRangeEnd = 1483447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRecordSnapshot_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr___GetEntityQuery_ForRecordSnapshot_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483448, XrefRangeEnd = 1483464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRecordInputCommand_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr___GetEntityQuery_ForRecordInputCommand_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483464, XrefRangeEnd = 1483483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRecordDataReceived_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.NativeMethodInfoPtr___GetEntityQuery_ForRecordDataReceived_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ClientReplayRecorderSystem()
    {
      Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Replays", nameof (ClientReplayRecorderSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr);
      ClientReplayRecorderSystem.NativeFieldInfoPtr__CurrentReplayFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_CurrentReplayFileName));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__StreamWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_StreamWriter));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__ReplayWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_ReplayWriter));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__RecordingStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_RecordingStartTime));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_Time));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__LastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_LastTime));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__NumOfSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_NumOfSnapshots));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__ReplaySnapshotEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_ReplaySnapshotEvent));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__HailMessageQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_HailMessageQuery));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_State));
      ClientReplayRecorderSystem.NativeFieldInfoPtr_SNAPSHOT_INTERVAL_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (SNAPSHOT_INTERVAL_SECONDS));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__NextSnapshotTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_NextSnapshotTime));
      ClientReplayRecorderSystem.NativeFieldInfoPtr_ReplayHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (ReplayHeader));
      ClientReplayRecorderSystem.NativeFieldInfoPtr___HandleHailMessage_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>HandleHailMessage_LambdaJob0_entityQuery");
      ClientReplayRecorderSystem.NativeFieldInfoPtr___HandleHailMessage_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>HandleHailMessage_LambdaJob0_profilerMarker");
      ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordSnapshot_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>RecordSnapshot_LambdaJob0_entityQuery");
      ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordSnapshot_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>RecordSnapshot_LambdaJob0_profilerMarker");
      ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordInputCommand_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>RecordInputCommand_LambdaJob0_entityQuery");
      ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordInputCommand_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>RecordInputCommand_LambdaJob0_profilerMarker");
      ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordDataReceived_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>RecordDataReceived_LambdaJob0_entityQuery");
      ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordDataReceived_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>RecordDataReceived_LambdaJob0_profilerMarker");
      ClientReplayRecorderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientReplayRecorderEnabled_3));
      ClientReplayRecorderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientReplayRecorderEnabled_4));
      ClientReplayRecorderSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663650);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663651);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_StartRecording_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663652);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663653);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_StopRecording_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663654);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_RewriteReplayHeader_Private_Void_V1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663655);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_CreateReplayFile_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663656);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_WriteInitialReplayHeader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663657);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_RemoveOldReplays_Private_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663658);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_CloseStreams_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663659);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_SetTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663660);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663661);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_HandleHailMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663662);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_RecordSnapshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663663);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_RecordInputCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663664);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_RecordDataReceived_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663665);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_WriteEvent_Private_Void_ClientReplayEventType_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663666);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_WriteEvent_Private_Void_ClientReplayEventType_Int32_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663667);
      ClientReplayRecorderSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663668);
      ClientReplayRecorderSystem.NativeMethodInfoPtr__RecordSnapshot_b__27_0_Private_Void_byref_DynamicBuffer_1_ReplayStoreSnapshotEventBuffer_byref_DynamicBuffer_1_ReplayScreenshotBuffer_byref_ReplayStoreSnapshotEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663669);
      ClientReplayRecorderSystem.NativeMethodInfoPtr__RecordInputCommand_b__28_0_Private_Void_Entity_byref_LocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663670);
      ClientReplayRecorderSystem.NativeMethodInfoPtr__RecordDataReceived_b__29_0_Private_Void_DynamicBuffer_1_ReceivedPacketBuffer_byref_ReceivedPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663671);
      ClientReplayRecorderSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663672);
      ClientReplayRecorderSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleHailMessage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663673);
      ClientReplayRecorderSystem.NativeMethodInfoPtr___GetEntityQuery_ForRecordSnapshot_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663674);
      ClientReplayRecorderSystem.NativeMethodInfoPtr___GetEntityQuery_ForRecordInputCommand_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663675);
      ClientReplayRecorderSystem.NativeMethodInfoPtr___GetEntityQuery_ForRecordDataReceived_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, 100663676);
    }

    public ClientReplayRecorderSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _CurrentReplayFileName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__CurrentReplayFileName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__CurrentReplayFileName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe StreamWriter _StreamWriter
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__StreamWriter));
        return pointer == System.IntPtr.Zero ? (StreamWriter) null : new StreamWriter(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__StreamWriter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BinaryWriter _ReplayWriter
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__ReplayWriter));
        return pointer == System.IntPtr.Zero ? (BinaryWriter) null : new BinaryWriter(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__ReplayWriter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double _RecordingStartTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__RecordingStartTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__RecordingStartTime)) = value;
      }
    }

    public unsafe double _Time
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__Time));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__Time)) = value;
      }
    }

    public unsafe double _LastTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__LastTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__LastTime)) = value;
      }
    }

    public unsafe int _NumOfSnapshots
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__NumOfSnapshots));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__NumOfSnapshots)) = value;
      }
    }

    public unsafe EntityQuery _ReplaySnapshotEvent
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__ReplaySnapshotEvent));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__ReplaySnapshotEvent)) = value;
      }
    }

    public unsafe EntityQuery _HailMessageQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__HailMessageQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__HailMessageQuery)) = value;
      }
    }

    public unsafe ClientReplayRecorderSystem.RecordingState _State
    {
      get
      {
        return *(ClientReplayRecorderSystem.RecordingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__State));
      }
      [param: In] set
      {
        *(ClientReplayRecorderSystem.RecordingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__State)) = value;
      }
    }

    public static unsafe float SNAPSHOT_INTERVAL_SECONDS
    {
      get
      {
        float snapshotIntervalSeconds;
        IL2CPP.il2cpp_field_static_get_value(ClientReplayRecorderSystem.NativeFieldInfoPtr_SNAPSHOT_INTERVAL_SECONDS, (void*) &snapshotIntervalSeconds);
        return snapshotIntervalSeconds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientReplayRecorderSystem.NativeFieldInfoPtr_SNAPSHOT_INTERVAL_SECONDS, (void*) &value);
      }
    }

    public unsafe double _NextSnapshotTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__NextSnapshotTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__NextSnapshotTime)) = value;
      }
    }

    public unsafe ReplayHeaders.V1 ReplayHeader
    {
      get
      {
        return *(ReplayHeaders.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr_ReplayHeader));
      }
      [param: In] set
      {
        *(ReplayHeaders.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr_ReplayHeader)) = value;
      }
    }

    public unsafe EntityQuery __HandleHailMessage_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___HandleHailMessage_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___HandleHailMessage_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleHailMessage_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___HandleHailMessage_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___HandleHailMessage_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RecordSnapshot_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordSnapshot_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordSnapshot_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RecordSnapshot_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordSnapshot_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordSnapshot_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RecordInputCommand_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordInputCommand_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordInputCommand_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RecordInputCommand_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordInputCommand_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordInputCommand_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RecordDataReceived_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordDataReceived_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordDataReceived_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RecordDataReceived_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordDataReceived_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr___RecordDataReceived_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientReplayRecorderEnabled_3
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_3));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_3)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientReplayRecorderEnabled_4
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_4));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_4)) = value;
      }
    }

    public enum RecordingState
    {
      Idle,
      WaitingForHailMessage,
      WaitingForInitialSnapshot,
      Recording,
    }

    [ObfuscatedName("ProjectM.Replays.ClientReplayRecorderSystem/<>c__DisplayClass22_0")]
    public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_regex;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RemoveOldReplays_b__0_Internal_Boolean_FileInfo_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass22_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass22_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482747, XrefRangeEnd = 1482750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _RemoveOldReplays_b__0(FileInfo a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__RemoveOldReplays_b__0_Internal_Boolean_FileInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass22_0()
      {
        Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>c__DisplayClass22_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass22_0>.NativeClassPtr);
        ClientReplayRecorderSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (regex));
        ClientReplayRecorderSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass22_0>.NativeClassPtr, 100663677);
        ClientReplayRecorderSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__RemoveOldReplays_b__0_Internal_Boolean_FileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass22_0>.NativeClassPtr, 100663678);
      }

      public __c__DisplayClass22_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Regex regex
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_regex));
          return pointer == System.IntPtr.Zero ? (Regex) null : new Regex(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_regex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Replays.ClientReplayRecorderSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__22_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RemoveOldReplays_b__22_1_Internal_DateTime_FileInfo_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.DateTime _RemoveOldReplays_b__22_1(FileInfo f)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) f);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c.NativeMethodInfoPtr__RemoveOldReplays_b__22_1_Internal_DateTime_FileInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ClientReplayRecorderSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c>.NativeClassPtr);
        ClientReplayRecorderSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c>.NativeClassPtr, "<>9");
        ClientReplayRecorderSystem.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c>.NativeClassPtr, "<>9__22_1");
        ClientReplayRecorderSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c>.NativeClassPtr, 100663680);
        ClientReplayRecorderSystem.__c.NativeMethodInfoPtr__RemoveOldReplays_b__22_1_Internal_DateTime_FileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c>.NativeClassPtr, 100663681);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ClientReplayRecorderSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientReplayRecorderSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ClientReplayRecorderSystem.__c) null : new ClientReplayRecorderSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientReplayRecorderSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<FileInfo, Il2CppSystem.DateTime> __9__22_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientReplayRecorderSystem.__c.NativeFieldInfoPtr___9__22_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<FileInfo, Il2CppSystem.DateTime>) null : new Il2CppSystem.Func<FileInfo, Il2CppSystem.DateTime>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientReplayRecorderSystem.__c.NativeFieldInfoPtr___9__22_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Replays.ClientReplayRecorderSystem/<>c__DisplayClass26_0")]
    public sealed class __c__DisplayClass26_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_replayHeader;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleHailMessage_b__0_Internal_Void_byref_HailMessage_byref_DynamicBuffer_1_HailMessageBuffer_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass26_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleHailMessage_b__0(
        [In] ref HailMessage hailMessage,
        [In] ref DynamicBuffer<HailMessageBuffer> hailMessageBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref hailMessage;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hailMessageBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeMethodInfoPtr__HandleHailMessage_b__0_Internal_Void_byref_HailMessage_byref_DynamicBuffer_1_HailMessageBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass26_0()
      {
        Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>c__DisplayClass26_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr);
        ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
        ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeFieldInfoPtr_replayHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr, nameof (replayHeader));
        ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr, 100663682);
        ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeMethodInfoPtr__HandleHailMessage_b__0_Internal_Void_byref_HailMessage_byref_DynamicBuffer_1_HailMessageBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr, 100663683);
      }

      public __c__DisplayClass26_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass26_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass26_0>.NativeClassPtr, data));
      }

      public unsafe ClientReplayRecorderSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientReplayRecorderSystem) null : new ClientReplayRecorderSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ReplayHeaders.V1 replayHeader
      {
        get
        {
          return *(ReplayHeaders.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeFieldInfoPtr_replayHeader));
        }
        [param: In] set
        {
          *(ReplayHeaders.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass26_0.NativeFieldInfoPtr_replayHeader)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Replays.ClientReplayRecorderSystem/ProjectM.Replays.<>c__DisplayClass_HandleHailMessage_LambdaJob0")]
    public sealed class __c__DisplayClass_HandleHailMessage_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_replayHeader;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_HailMessage_byref_DynamicBuffer_1_HailMessageBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass26_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass26_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_byref___c__DisplayClass26_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482786, RefRangeEnd = 1482787, XrefRangeStart = 1482764, XrefRangeEnd = 1482786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref HailMessage hailMessage,
        [In] ref DynamicBuffer<HailMessageBuffer> hailMessageBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref hailMessage;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hailMessageBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_HailMessage_byref_DynamicBuffer_1_HailMessageBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482788, RefRangeEnd = 1482789, XrefRangeStart = 1482787, XrefRangeEnd = 1482788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientReplayRecorderSystem.__c__DisplayClass26_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass26_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482790, RefRangeEnd = 1482791, XrefRangeStart = 1482789, XrefRangeEnd = 1482790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientReplayRecorderSystem.__c__DisplayClass26_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass26_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482791, XrefRangeEnd = 1482793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482801, RefRangeEnd = 1482802, XrefRangeStart = 1482793, XrefRangeEnd = 1482801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482804, RefRangeEnd = 1482805, XrefRangeStart = 1482802, XrefRangeEnd = 1482804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientReplayRecorderSystem componentSystem,
        ref ClientReplayRecorderSystem.__c__DisplayClass26_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_byref___c__DisplayClass26_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482805, XrefRangeEnd = 1482811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleHailMessage_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>c__DisplayClass_HandleHailMessage_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr);
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr_replayHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, nameof (replayHeader));
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, "<>4__this");
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_HailMessage_byref_DynamicBuffer_1_HailMessageBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, 100663684);
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass26_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, 100663685);
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass26_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, 100663686);
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, 100663687);
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, 100663688);
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_byref___c__DisplayClass26_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, 100663689);
        ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, 100663690);
      }

      public __c__DisplayClass_HandleHailMessage_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_HandleHailMessage_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ReplayHeaders.V1 replayHeader
      {
        get
        {
          return *(ReplayHeaders.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr_replayHeader));
        }
        [param: In] set
        {
          *(ReplayHeaders.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr_replayHeader)) = value;
        }
      }

      public unsafe ClientReplayRecorderSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientReplayRecorderSystem) null : new ClientReplayRecorderSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hailMessage;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hailMessageBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<HailMessage> forParameter_hailMessage;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<HailMessageBuffer> forParameter_hailMessageBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1482756, RefRangeEnd = 1482757, XrefRangeStart = 1482750, XrefRangeEnd = 1482756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientReplayRecorderSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1482763, RefRangeEnd = 1482764, XrefRangeStart = 1482757, XrefRangeEnd = 1482763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hailMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hailMessage));
          ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hailMessageBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hailMessageBuffer));
          ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663691);
          ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663692);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hailMessage;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hailMessageBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<HailMessage>.Runtime runtime_hailMessage;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<HailMessageBuffer>.Runtime runtime_hailMessageBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hailMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hailMessage));
            ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hailMessageBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hailMessageBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_HandleHailMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Replays.ClientReplayRecorderSystem/ProjectM.Replays.<>c__DisplayClass_RecordSnapshot_LambdaJob0")]
    public sealed class __c__DisplayClass_RecordSnapshot_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_DynamicBuffer_1_ReplayStoreSnapshotEventBuffer_byref_DynamicBuffer_1_ReplayScreenshotBuffer_byref_ReplayStoreSnapshotEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482833, RefRangeEnd = 1482834, XrefRangeStart = 1482831, XrefRangeEnd = 1482833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<ReplayStoreSnapshotEventBuffer> replaySnapshotEventBuffer,
        ref DynamicBuffer<ReplayScreenshotBuffer> replayScreenshotBuffer,
        [In] ref ReplayStoreSnapshotEvent replaySnapshotEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref replaySnapshotEventBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref replayScreenshotBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref replaySnapshotEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_DynamicBuffer_1_ReplayStoreSnapshotEventBuffer_byref_DynamicBuffer_1_ReplayScreenshotBuffer_byref_ReplayStoreSnapshotEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482834, XrefRangeEnd = 1482836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482847, RefRangeEnd = 1482848, XrefRangeStart = 1482836, XrefRangeEnd = 1482847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482862, RefRangeEnd = 1482863, XrefRangeStart = 1482848, XrefRangeEnd = 1482862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ClientReplayRecorderSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482863, XrefRangeEnd = 1482869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RecordSnapshot_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>c__DisplayClass_RecordSnapshot_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_DynamicBuffer_1_ReplayStoreSnapshotEventBuffer_byref_DynamicBuffer_1_ReplayScreenshotBuffer_byref_ReplayStoreSnapshotEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, 100663693);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, 100663694);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, 100663695);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, 100663696);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, 100663697);
      }

      public __c__DisplayClass_RecordSnapshot_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RecordSnapshot_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ClientReplayRecorderSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (ClientReplayRecorderSystem) null : new ClientReplayRecorderSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_replaySnapshotEventBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_replayScreenshotBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_replaySnapshotEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<ReplayStoreSnapshotEventBuffer> forParameter_replaySnapshotEventBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<ReplayScreenshotBuffer> forParameter_replayScreenshotBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<ReplayStoreSnapshotEvent> forParameter_replaySnapshotEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1482820, RefRangeEnd = 1482821, XrefRangeStart = 1482811, XrefRangeEnd = 1482820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientReplayRecorderSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1482830, RefRangeEnd = 1482831, XrefRangeStart = 1482821, XrefRangeEnd = 1482830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_replaySnapshotEventBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_replaySnapshotEventBuffer));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_replayScreenshotBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_replayScreenshotBuffer));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_replaySnapshotEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_replaySnapshotEvent));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663698);
          ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663699);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_replaySnapshotEventBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_replayScreenshotBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_replaySnapshotEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<ReplayStoreSnapshotEventBuffer>.Runtime runtime_replaySnapshotEventBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_DynamicBuffer<ReplayScreenshotBuffer>.Runtime runtime_replayScreenshotBuffer;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<ReplayStoreSnapshotEvent>.Runtime runtime_replaySnapshotEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_replaySnapshotEventBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_replaySnapshotEventBuffer));
            ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_replayScreenshotBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_replayScreenshotBuffer));
            ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_replaySnapshotEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_replaySnapshotEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordSnapshot_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Replays.ClientReplayRecorderSystem/ProjectM.Replays.<>c__DisplayClass_RecordInputCommand_LambdaJob0")]
    public sealed class __c__DisplayClass_RecordInputCommand_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_LocalUser_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482881, RefRangeEnd = 1482882, XrefRangeStart = 1482879, XrefRangeEnd = 1482881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity localUserEntity, [In] ref LocalUser localUser)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &localUserEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_LocalUser_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482882, XrefRangeEnd = 1482884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482890, RefRangeEnd = 1482891, XrefRangeStart = 1482884, XrefRangeEnd = 1482890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482893, RefRangeEnd = 1482894, XrefRangeStart = 1482891, XrefRangeEnd = 1482893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ClientReplayRecorderSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482894, XrefRangeEnd = 1482900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RecordInputCommand_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>c__DisplayClass_RecordInputCommand_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_LocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, 100663700);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, 100663701);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, 100663702);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, 100663703);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, 100663704);
      }

      public __c__DisplayClass_RecordInputCommand_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RecordInputCommand_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ClientReplayRecorderSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (ClientReplayRecorderSystem) null : new ClientReplayRecorderSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localUserEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localUser;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_localUserEntity;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_IComponentData_Tag<LocalUser> forParameter_localUser;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1482873, RefRangeEnd = 1482874, XrefRangeStart = 1482869, XrefRangeEnd = 1482873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientReplayRecorderSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1482878, RefRangeEnd = 1482879, XrefRangeStart = 1482874, XrefRangeEnd = 1482878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localUserEntity));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localUser));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663705);
          ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663706);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localUserEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localUser;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_localUserEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData_Tag<LocalUser>.Runtime runtime_localUser;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localUserEntity));
            ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localUser));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordInputCommand_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Replays.ClientReplayRecorderSystem/ProjectM.Replays.<>c__DisplayClass_RecordDataReceived_LambdaJob0")]
    public sealed class __c__DisplayClass_RecordDataReceived_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_DynamicBuffer_1_ReceivedPacketBuffer_byref_ReceivedPacket_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482915, RefRangeEnd = 1482916, XrefRangeStart = 1482914, XrefRangeEnd = 1482915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<ReceivedPacketBuffer> packetBuffer,
        [In] ref ReceivedPacket receivedPacket)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &packetBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref receivedPacket;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_DynamicBuffer_1_ReceivedPacketBuffer_byref_ReceivedPacket_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482916, XrefRangeEnd = 1482918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482926, RefRangeEnd = 1482927, XrefRangeStart = 1482918, XrefRangeEnd = 1482926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1482929, RefRangeEnd = 1482930, XrefRangeStart = 1482927, XrefRangeEnd = 1482929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ClientReplayRecorderSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482930, XrefRangeEnd = 1482936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RecordDataReceived_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem>.NativeClassPtr, "<>c__DisplayClass_RecordDataReceived_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_DynamicBuffer_1_ReceivedPacketBuffer_byref_ReceivedPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, 100663707);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, 100663708);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, 100663709);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, 100663710);
        ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, 100663711);
      }

      public __c__DisplayClass_RecordDataReceived_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RecordDataReceived_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ClientReplayRecorderSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (ClientReplayRecorderSystem) null : new ClientReplayRecorderSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_packetBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_receivedPacket;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<ReceivedPacketBuffer> forParameter_packetBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<ReceivedPacket> forParameter_receivedPacket;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1482906, RefRangeEnd = 1482907, XrefRangeStart = 1482900, XrefRangeEnd = 1482906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientReplayRecorderSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1482913, RefRangeEnd = 1482914, XrefRangeStart = 1482907, XrefRangeEnd = 1482913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_packetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_packetBuffer));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_receivedPacket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_receivedPacket));
          ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientReplayRecorderSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663712);
          ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663713);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_packetBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_receivedPacket;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<ReceivedPacketBuffer>.Runtime runtime_packetBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<ReceivedPacket>.Runtime runtime_receivedPacket;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_packetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_packetBuffer));
            ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_receivedPacket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_receivedPacket));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderSystem.__c__DisplayClass_RecordDataReceived_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
