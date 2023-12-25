// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.RTCInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.RTCAudio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTC
{
  public sealed class RTCInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifydisconnectedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyparticipantstatuschangedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockparticipantApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinroomApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeaveroomApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticipantmetadataApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticipantmetadataKeyMaxcharcount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticipantmetadataValueMaxcharcount;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetroomsettingApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetsettingApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyDisconnected_Public_UInt64_byref_AddNotifyDisconnectedOptions_Object_OnDisconnectedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyParticipantStatusChanged_Public_UInt64_byref_AddNotifyParticipantStatusChangedOptions_Object_OnParticipantStatusChangedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockParticipant_Public_Void_byref_BlockParticipantOptions_Object_OnBlockParticipantCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioInterface_Public_RTCAudioInterface_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinRoom_Public_Void_byref_JoinRoomOptions_Object_OnJoinRoomCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LeaveRoom_Public_Void_byref_LeaveRoomOptions_Object_OnLeaveRoomCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyDisconnected_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyParticipantStatusChanged_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetRoomSetting_Public_Result_byref_SetRoomSettingOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSetting_Public_Result_byref_SetSettingOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBlockParticipantCallbackInternalImplementation_Internal_Static_Void_byref_BlockParticipantCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisconnectedCallbackInternalImplementation_Internal_Static_Void_byref_DisconnectedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinRoomCallbackInternalImplementation_Internal_Static_Void_byref_JoinRoomCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLeaveRoomCallbackInternalImplementation_Internal_Static_Void_byref_LeaveRoomCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnParticipantStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_ParticipantStatusChangedCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RTCInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947482, XrefRangeEnd = 947502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyDisconnected(
      ref AddNotifyDisconnectedOptions options,
      Il2CppSystem.Object clientData,
      OnDisconnectedCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_AddNotifyDisconnected_Public_UInt64_byref_AddNotifyDisconnectedOptions_Object_OnDisconnectedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947502, XrefRangeEnd = 947522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyParticipantStatusChanged(
      ref AddNotifyParticipantStatusChangedOptions options,
      Il2CppSystem.Object clientData,
      OnParticipantStatusChangedCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_AddNotifyParticipantStatusChanged_Public_UInt64_byref_AddNotifyParticipantStatusChangedOptions_Object_OnParticipantStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947522, XrefRangeEnd = 947541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BlockParticipant(
      ref BlockParticipantOptions options,
      Il2CppSystem.Object clientData,
      OnBlockParticipantCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_BlockParticipant_Public_Void_byref_BlockParticipantOptions_Object_OnBlockParticipantCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947541, XrefRangeEnd = 947548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RTCAudioInterface GetAudioInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_GetAudioInterface_Public_RTCAudioInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RTCAudioInterface) null : new RTCAudioInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947548, XrefRangeEnd = 947567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JoinRoom(
      ref JoinRoomOptions options,
      Il2CppSystem.Object clientData,
      OnJoinRoomCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_JoinRoom_Public_Void_byref_JoinRoomOptions_Object_OnJoinRoomCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947567, XrefRangeEnd = 947586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LeaveRoom(
      ref LeaveRoomOptions options,
      Il2CppSystem.Object clientData,
      OnLeaveRoomCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_LeaveRoom_Public_Void_byref_LeaveRoomOptions_Object_OnLeaveRoomCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947586, XrefRangeEnd = 947591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyDisconnected(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_RemoveNotifyDisconnected_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947591, XrefRangeEnd = 947596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyParticipantStatusChanged(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_RemoveNotifyParticipantStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947596, XrefRangeEnd = 947604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetRoomSetting(ref SetRoomSettingOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_SetRoomSetting_Public_Result_byref_SetRoomSettingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947604, XrefRangeEnd = 947612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetSetting(ref SetSettingOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_SetSetting_Public_Result_byref_SetSettingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947612, XrefRangeEnd = 947619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnBlockParticipantCallbackInternalImplementation(
      ref BlockParticipantCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnBlockParticipantCallbackInternalImplementation_Internal_Static_Void_byref_BlockParticipantCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947619, XrefRangeEnd = 947626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDisconnectedCallbackInternalImplementation(
      ref DisconnectedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnDisconnectedCallbackInternalImplementation_Internal_Static_Void_byref_DisconnectedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947626, XrefRangeEnd = 947633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnJoinRoomCallbackInternalImplementation(
      ref JoinRoomCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnJoinRoomCallbackInternalImplementation_Internal_Static_Void_byref_JoinRoomCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947633, XrefRangeEnd = 947640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLeaveRoomCallbackInternalImplementation(
      ref LeaveRoomCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnLeaveRoomCallbackInternalImplementation_Internal_Static_Void_byref_LeaveRoomCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947640, XrefRangeEnd = 947647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnParticipantStatusChangedCallbackInternalImplementation(
      ref ParticipantStatusChangedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnParticipantStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_ParticipantStatusChangedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RTCInterface()
    {
      Il2CppClassPointerStore<RTCInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTC", nameof (RTCInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr);
      RTCInterface.NativeFieldInfoPtr_AddnotifydisconnectedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (AddnotifydisconnectedApiLatest));
      RTCInterface.NativeFieldInfoPtr_AddnotifyparticipantstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (AddnotifyparticipantstatuschangedApiLatest));
      RTCInterface.NativeFieldInfoPtr_BlockparticipantApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (BlockparticipantApiLatest));
      RTCInterface.NativeFieldInfoPtr_JoinroomApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (JoinroomApiLatest));
      RTCInterface.NativeFieldInfoPtr_LeaveroomApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (LeaveroomApiLatest));
      RTCInterface.NativeFieldInfoPtr_ParticipantmetadataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (ParticipantmetadataApiLatest));
      RTCInterface.NativeFieldInfoPtr_ParticipantmetadataKeyMaxcharcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (ParticipantmetadataKeyMaxcharcount));
      RTCInterface.NativeFieldInfoPtr_ParticipantmetadataValueMaxcharcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (ParticipantmetadataValueMaxcharcount));
      RTCInterface.NativeFieldInfoPtr_SetroomsettingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (SetroomsettingApiLatest));
      RTCInterface.NativeFieldInfoPtr_SetsettingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (SetsettingApiLatest));
      RTCInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667929);
      RTCInterface.NativeMethodInfoPtr_AddNotifyDisconnected_Public_UInt64_byref_AddNotifyDisconnectedOptions_Object_OnDisconnectedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667931);
      RTCInterface.NativeMethodInfoPtr_AddNotifyParticipantStatusChanged_Public_UInt64_byref_AddNotifyParticipantStatusChangedOptions_Object_OnParticipantStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667932);
      RTCInterface.NativeMethodInfoPtr_BlockParticipant_Public_Void_byref_BlockParticipantOptions_Object_OnBlockParticipantCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667933);
      RTCInterface.NativeMethodInfoPtr_GetAudioInterface_Public_RTCAudioInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667934);
      RTCInterface.NativeMethodInfoPtr_JoinRoom_Public_Void_byref_JoinRoomOptions_Object_OnJoinRoomCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667935);
      RTCInterface.NativeMethodInfoPtr_LeaveRoom_Public_Void_byref_LeaveRoomOptions_Object_OnLeaveRoomCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667936);
      RTCInterface.NativeMethodInfoPtr_RemoveNotifyDisconnected_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667937);
      RTCInterface.NativeMethodInfoPtr_RemoveNotifyParticipantStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667938);
      RTCInterface.NativeMethodInfoPtr_SetRoomSetting_Public_Result_byref_SetRoomSettingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667939);
      RTCInterface.NativeMethodInfoPtr_SetSetting_Public_Result_byref_SetSettingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667940);
      RTCInterface.NativeMethodInfoPtr_OnBlockParticipantCallbackInternalImplementation_Internal_Static_Void_byref_BlockParticipantCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667941);
      RTCInterface.NativeMethodInfoPtr_OnDisconnectedCallbackInternalImplementation_Internal_Static_Void_byref_DisconnectedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667942);
      RTCInterface.NativeMethodInfoPtr_OnJoinRoomCallbackInternalImplementation_Internal_Static_Void_byref_JoinRoomCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667943);
      RTCInterface.NativeMethodInfoPtr_OnLeaveRoomCallbackInternalImplementation_Internal_Static_Void_byref_LeaveRoomCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667944);
      RTCInterface.NativeMethodInfoPtr_OnParticipantStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_ParticipantStatusChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667945);
    }

    public RTCInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifydisconnectedApiLatest
    {
      get
      {
        int addnotifydisconnectedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_AddnotifydisconnectedApiLatest, (void*) &addnotifydisconnectedApiLatest);
        return addnotifydisconnectedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_AddnotifydisconnectedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyparticipantstatuschangedApiLatest
    {
      get
      {
        int addnotifyparticipantstatuschangedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_AddnotifyparticipantstatuschangedApiLatest, (void*) &addnotifyparticipantstatuschangedApiLatest);
        return addnotifyparticipantstatuschangedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_AddnotifyparticipantstatuschangedApiLatest, (void*) &value);
      }
    }

    public static unsafe int BlockparticipantApiLatest
    {
      get
      {
        int blockparticipantApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_BlockparticipantApiLatest, (void*) &blockparticipantApiLatest);
        return blockparticipantApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_BlockparticipantApiLatest, (void*) &value);
      }
    }

    public static unsafe int JoinroomApiLatest
    {
      get
      {
        int joinroomApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_JoinroomApiLatest, (void*) &joinroomApiLatest);
        return joinroomApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_JoinroomApiLatest, (void*) &value);
      }
    }

    public static unsafe int LeaveroomApiLatest
    {
      get
      {
        int leaveroomApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_LeaveroomApiLatest, (void*) &leaveroomApiLatest);
        return leaveroomApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_LeaveroomApiLatest, (void*) &value);
      }
    }

    public static unsafe int ParticipantmetadataApiLatest
    {
      get
      {
        int participantmetadataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataApiLatest, (void*) &participantmetadataApiLatest);
        return participantmetadataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataApiLatest, (void*) &value);
      }
    }

    public static unsafe int ParticipantmetadataKeyMaxcharcount
    {
      get
      {
        int participantmetadataKeyMaxcharcount;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataKeyMaxcharcount, (void*) &participantmetadataKeyMaxcharcount);
        return participantmetadataKeyMaxcharcount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataKeyMaxcharcount, (void*) &value);
      }
    }

    public static unsafe int ParticipantmetadataValueMaxcharcount
    {
      get
      {
        int valueMaxcharcount;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataValueMaxcharcount, (void*) &valueMaxcharcount);
        return valueMaxcharcount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataValueMaxcharcount, (void*) &value);
      }
    }

    public static unsafe int SetroomsettingApiLatest
    {
      get
      {
        int setroomsettingApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_SetroomsettingApiLatest, (void*) &setroomsettingApiLatest);
        return setroomsettingApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_SetroomsettingApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetsettingApiLatest
    {
      get
      {
        int setsettingApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_SetsettingApiLatest, (void*) &setsettingApiLatest);
        return setsettingApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_SetsettingApiLatest, (void*) &value);
      }
    }
  }
}
