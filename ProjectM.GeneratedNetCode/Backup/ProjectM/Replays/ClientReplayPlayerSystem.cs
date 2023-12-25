// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.ClientReplayPlayerSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.IO;
using ProjectM.Network;
using ProjectM.UI;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Replays
{
  public class ClientReplayPlayerSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__FilePath;
    private static readonly System.IntPtr NativeFieldInfoPtr__Events;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr__Snapshots;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputEventIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__StartBaseTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplayLength;
    private static readonly System.IntPtr NativeFieldInfoPtr__Timer;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsPlayingReplay;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsReplayLoaded;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsGameDataLoaded;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplayHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr__PacketPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__PartialInputCommand;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplayJumpToSnapshotEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasPerformedSnapshotJump;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplayHUDSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_0;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_1;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayReplay_Private_Void_FixedString512_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayReplayFile_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetReplayTime_Private_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializePlayback_Private_Boolean_V1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadEvent_Private_Boolean_BinaryReader_Int32_byref_EventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFullReplayPath_Private_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleJumpToSnapshot_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadEvents_Private_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReachedEndOfReplay_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeReplaySnapshot_Public_Void_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482027, XrefRangeEnd = 1482046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayPlayerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482046, XrefRangeEnd = 1482066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayPlayerSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482066, XrefRangeEnd = 1482076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayPlayerSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1482080, RefRangeEnd = 1482082, XrefRangeStart = 1482076, XrefRangeEnd = 1482080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayReplay(FixedString512 filePath)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &filePath;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_PlayReplay_Private_Void_FixedString512_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482311, RefRangeEnd = 1482312, XrefRangeStart = 1482082, XrefRangeEnd = 1482311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayReplayFile(string replayFullPath)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(replayFullPath);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_PlayReplayFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1482319, RefRangeEnd = 1482324, XrefRangeStart = 1482312, XrefRangeEnd = 1482319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetReplayTime(double newTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_SetReplayTime_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482324, XrefRangeEnd = 1482339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool InitializePlayback(ReplayHeaders.V1 replayHeader)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &replayHeader;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_InitializePlayback_Private_Boolean_V1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482345, RefRangeEnd = 1482346, XrefRangeStart = 1482339, XrefRangeEnd = 1482345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ReadEvent(
      BinaryReader replayReader,
      int length,
      out ClientReplayPlayerSystem.EventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) replayReader);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_ReadEvent_Private_Boolean_BinaryReader_Int32_byref_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ClientReplayPlayerSystem.EventData local = ref eventData;
      System.IntPtr pointer = zero;
      ClientReplayPlayerSystem.EventData eventData1 = pointer == System.IntPtr.Zero ? (ClientReplayPlayerSystem.EventData) null : new ClientReplayPlayerSystem.EventData(pointer);
      local = eventData1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482391, RefRangeEnd = 1482392, XrefRangeStart = 1482346, XrefRangeEnd = 1482391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetFullReplayPath(string replayFolder, string replayFileName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(replayFolder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(replayFileName);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_GetFullReplayPath_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482392, XrefRangeEnd = 1482406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayPlayerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482487, RefRangeEnd = 1482488, XrefRangeStart = 1482406, XrefRangeEnd = 1482487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleJumpToSnapshot()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_HandleJumpToSnapshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482569, RefRangeEnd = 1482570, XrefRangeStart = 1482488, XrefRangeEnd = 1482569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReadEvents(double time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &time;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_ReadEvents_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482570, XrefRangeEnd = 1482576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReachedEndOfReplay()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_ReachedEndOfReplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482726, RefRangeEnd = 1482727, XrefRangeStart = 1482576, XrefRangeEnd = 1482726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeReplaySnapshot(NetBufferIn netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr_DeserializeReplaySnapshot_Public_Void_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientReplayPlayerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482727, XrefRangeEnd = 1482747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientReplayPlayerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientReplayPlayerSystem()
    {
      Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Replays", nameof (ClientReplayPlayerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr);
      ClientReplayPlayerSystem.NativeFieldInfoPtr__FilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_FilePath));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_Events));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__InputEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_InputEvents));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__Snapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_Snapshots));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__EventIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_EventIndex));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__InputEventIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_InputEventIndex));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__StartBaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_StartBaseTime));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_ReplayLength));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_Timer));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__IsPlayingReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_IsPlayingReplay));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__IsReplayLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_IsReplayLoaded));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__IsGameDataLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_IsGameDataLoaded));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_ReplayHeader));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__PacketPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_PacketPrefab));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__LastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_LastTime));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__PartialInputCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_PartialInputCommand));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayJumpToSnapshotEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_ReplayJumpToSnapshotEvent));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__HasPerformedSnapshotJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_HasPerformedSnapshotJump));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayHUDSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_ReplayHUDSystem));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_WorldFrame));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_CurrentFrame));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientReplayPlayerEnabled_0));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientReplayPlayerEnabled_1));
      ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_2));
      ClientReplayPlayerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663630);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663631);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663632);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_PlayReplay_Private_Void_FixedString512_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663633);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_PlayReplayFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663634);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_SetReplayTime_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663635);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_InitializePlayback_Private_Boolean_V1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663636);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_ReadEvent_Private_Boolean_BinaryReader_Int32_byref_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663637);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_GetFullReplayPath_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663638);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663639);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_HandleJumpToSnapshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663640);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_ReadEvents_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663641);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_ReachedEndOfReplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663642);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_DeserializeReplaySnapshot_Public_Void_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663643);
      ClientReplayPlayerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663644);
      ClientReplayPlayerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, 100663645);
    }

    public ClientReplayPlayerSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FixedString512 _FilePath
    {
      get
      {
        return *(FixedString512*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__FilePath));
      }
      [param: In] set
      {
        *(FixedString512*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__FilePath)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<ClientReplayPlayerSystem.EventData> _Events
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__Events));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ClientReplayPlayerSystem.EventData>) null : new Il2CppReferenceArray<ClientReplayPlayerSystem.EventData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__Events), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ClientReplayPlayerSystem.EventData> _InputEvents
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__InputEvents));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ClientReplayPlayerSystem.EventData>) null : new Il2CppReferenceArray<ClientReplayPlayerSystem.EventData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__InputEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<ReplayHeaders.V1.Snapshot> _Snapshots
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__Snapshots));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ReplayHeaders.V1.Snapshot>) null : new Il2CppStructArray<ReplayHeaders.V1.Snapshot>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__Snapshots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _EventIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__EventIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__EventIndex)) = value;
      }
    }

    public unsafe int _InputEventIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__InputEventIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__InputEventIndex)) = value;
      }
    }

    public unsafe double _StartBaseTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__StartBaseTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__StartBaseTime)) = value;
      }
    }

    public unsafe double _ReplayLength
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayLength));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayLength)) = value;
      }
    }

    public unsafe double _Timer
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__Timer));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__Timer)) = value;
      }
    }

    public unsafe bool _IsPlayingReplay
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__IsPlayingReplay));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__IsPlayingReplay)) = value;
      }
    }

    public unsafe bool _IsReplayLoaded
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__IsReplayLoaded));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__IsReplayLoaded)) = value;
      }
    }

    public unsafe bool _IsGameDataLoaded
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__IsGameDataLoaded));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__IsGameDataLoaded)) = value;
      }
    }

    public unsafe ReplayHeaders.V1 _ReplayHeader
    {
      get
      {
        return *(ReplayHeaders.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayHeader));
      }
      [param: In] set
      {
        *(ReplayHeaders.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayHeader)) = value;
      }
    }

    public unsafe Entity _PacketPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__PacketPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__PacketPrefab)) = value;
      }
    }

    public unsafe double _LastTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__LastTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__LastTime)) = value;
      }
    }

    public unsafe InputCommandBufferElement _PartialInputCommand
    {
      get
      {
        return *(InputCommandBufferElement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__PartialInputCommand));
      }
      [param: In] set
      {
        *(InputCommandBufferElement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__PartialInputCommand)) = value;
      }
    }

    public unsafe EntityQuery _ReplayJumpToSnapshotEvent
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayJumpToSnapshotEvent));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayJumpToSnapshotEvent)) = value;
      }
    }

    public unsafe bool _HasPerformedSnapshotJump
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__HasPerformedSnapshotJump));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__HasPerformedSnapshotJump)) = value;
      }
    }

    public unsafe ReplayHUDSystem _ReplayHUDSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayHUDSystem));
        return pointer == System.IntPtr.Zero ? (ReplayHUDSystem) null : new ReplayHUDSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__ReplayHUDSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _CurrentFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__CurrentFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__CurrentFrame)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientReplayPlayerEnabled_0
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_0));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_0)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientReplayPlayerEnabled_1
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_1));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_1)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_2
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_2));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_2)) = value;
      }
    }

    public sealed class EventData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_Delta;
      private static readonly System.IntPtr NativeFieldInfoPtr_Bits;
      private static readonly System.IntPtr NativeFieldInfoPtr_Data;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Double_0;

      public unsafe double EndTime
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 1482023, RefRangeEnd = 1482025, XrefRangeStart = 1482023, XrefRangeEnd = 1482023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.EventData.NativeMethodInfoPtr_get_EndTime_Public_get_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(double*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      static EventData()
      {
        Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, nameof (EventData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr);
        ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr, nameof (Type));
        ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr, nameof (StartTime));
        ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr, nameof (Delta));
        ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr, nameof (Bits));
        ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr, nameof (Data));
        ClientReplayPlayerSystem.EventData.NativeMethodInfoPtr_get_EndTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr, 100663646);
      }

      public EventData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public EventData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayPlayerSystem.EventData>.NativeClassPtr, data));
      }

      public unsafe ClientReplayEventType Type
      {
        get
        {
          return *(ClientReplayEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(ClientReplayEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public unsafe double StartTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_StartTime)) = value;
        }
      }

      public unsafe float Delta
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Delta));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Delta)) = value;
        }
      }

      public unsafe int Bits
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Bits));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Bits)) = value;
        }
      }

      public unsafe Il2CppStructArray<byte> Data
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Data));
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientReplayPlayerSystem.EventData.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Replays.ClientReplayPlayerSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__30_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetFullReplayPath_b__30_0_Internal_DateTime_FileInfo_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientReplayPlayerSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1482025, XrefRangeEnd = 1482027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.DateTime _GetFullReplayPath_b__30_0(FileInfo f)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) f);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientReplayPlayerSystem.__c.NativeMethodInfoPtr__GetFullReplayPath_b__30_0_Internal_DateTime_FileInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ClientReplayPlayerSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientReplayPlayerSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayPlayerSystem.__c>.NativeClassPtr);
        ClientReplayPlayerSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem.__c>.NativeClassPtr, "<>9");
        ClientReplayPlayerSystem.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerSystem.__c>.NativeClassPtr, "<>9__30_0");
        ClientReplayPlayerSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem.__c>.NativeClassPtr, 100663648);
        ClientReplayPlayerSystem.__c.NativeMethodInfoPtr__GetFullReplayPath_b__30_0_Internal_DateTime_FileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientReplayPlayerSystem.__c>.NativeClassPtr, 100663649);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ClientReplayPlayerSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientReplayPlayerSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ClientReplayPlayerSystem.__c) null : new ClientReplayPlayerSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientReplayPlayerSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<FileInfo, Il2CppSystem.DateTime> __9__30_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientReplayPlayerSystem.__c.NativeFieldInfoPtr___9__30_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<FileInfo, Il2CppSystem.DateTime>) null : new Il2CppSystem.Func<FileInfo, Il2CppSystem.DateTime>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientReplayPlayerSystem.__c.NativeFieldInfoPtr___9__30_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
