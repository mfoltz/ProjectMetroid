// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  public sealed class LobbyInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyjoinlobbyacceptedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbyinviteacceptedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbyinvitereceivedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbyinviterejectedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbymemberstatusreceivedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbymemberupdatereceivedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbyupdatereceivedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyrtcroomconnectionchangedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifysendlobbynativeinviterequestedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttributeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttributedataApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopylobbydetailshandleApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopylobbydetailshandlebyinviteidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopylobbydetailshandlebyuieventidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatelobbyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatelobbysearchApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroylobbyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetinvitecountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetinviteidbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetrtcroomnameApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_HardmutememberApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_InviteidMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsrtcroomconnectedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinlobbyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinlobbybyidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_KickmemberApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeavelobbyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalrtcoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxLobbies;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxLobbyMembers;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxLobbyidoverrideLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSearchResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinLobbyidoverrideLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_PromotememberApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryinvitesApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RejectinviteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SearchBucketId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SearchMincurrentmembers;
    private static readonly System.IntPtr NativeFieldInfoPtr_SearchMinslotsavailable;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendinviteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatelobbyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatelobbymodificationApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyJoinLobbyAccepted_Public_UInt64_byref_AddNotifyJoinLobbyAcceptedOptions_Object_OnJoinLobbyAcceptedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyInviteAccepted_Public_UInt64_byref_AddNotifyLobbyInviteAcceptedOptions_Object_OnLobbyInviteAcceptedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyInviteReceived_Public_UInt64_byref_AddNotifyLobbyInviteReceivedOptions_Object_OnLobbyInviteReceivedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyInviteRejected_Public_UInt64_byref_AddNotifyLobbyInviteRejectedOptions_Object_OnLobbyInviteRejectedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyMemberStatusReceived_Public_UInt64_byref_AddNotifyLobbyMemberStatusReceivedOptions_Object_OnLobbyMemberStatusReceivedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyMemberUpdateReceived_Public_UInt64_byref_AddNotifyLobbyMemberUpdateReceivedOptions_Object_OnLobbyMemberUpdateReceivedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyUpdateReceived_Public_UInt64_byref_AddNotifyLobbyUpdateReceivedOptions_Object_OnLobbyUpdateReceivedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyRTCRoomConnectionChanged_Public_UInt64_byref_AddNotifyRTCRoomConnectionChangedOptions_Object_OnRTCRoomConnectionChangedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifySendLobbyNativeInviteRequested_Public_UInt64_byref_AddNotifySendLobbyNativeInviteRequestedOptions_Object_OnSendLobbyNativeInviteRequestedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLobbyDetailsHandle_Public_Result_byref_CopyLobbyDetailsHandleOptions_byref_LobbyDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLobbyDetailsHandleByInviteId_Public_Result_byref_CopyLobbyDetailsHandleByInviteIdOptions_byref_LobbyDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLobbyDetailsHandleByUiEventId_Public_Result_byref_CopyLobbyDetailsHandleByUiEventIdOptions_byref_LobbyDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateLobby_Public_Void_byref_CreateLobbyOptions_Object_OnCreateLobbyCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateLobbySearch_Public_Result_byref_CreateLobbySearchOptions_byref_LobbySearch_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyLobby_Public_Void_byref_DestroyLobbyOptions_Object_OnDestroyLobbyCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInviteCount_Public_UInt32_byref_GetInviteCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_byref_GetInviteIdByIndexOptions_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRTCRoomName_Public_Result_byref_GetRTCRoomNameOptions_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HardMuteMember_Public_Void_byref_HardMuteMemberOptions_Object_OnHardMuteMemberCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRTCRoomConnected_Public_Result_byref_IsRTCRoomConnectedOptions_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinLobby_Public_Void_byref_JoinLobbyOptions_Object_OnJoinLobbyCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinLobbyById_Public_Void_byref_JoinLobbyByIdOptions_Object_OnJoinLobbyByIdCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_KickMember_Public_Void_byref_KickMemberOptions_Object_OnKickMemberCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Void_byref_LeaveLobbyOptions_Object_OnLeaveLobbyCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PromoteMember_Public_Void_byref_PromoteMemberOptions_Object_OnPromoteMemberCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryInvites_Public_Void_byref_QueryInvitesOptions_Object_OnQueryInvitesCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyJoinLobbyAccepted_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyInviteAccepted_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyInviteReceived_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyInviteRejected_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyMemberStatusReceived_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyMemberUpdateReceived_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyUpdateReceived_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyRTCRoomConnectionChanged_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifySendLobbyNativeInviteRequested_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLobby_Public_Void_byref_UpdateLobbyOptions_Object_OnUpdateLobbyCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLobbyModification_Public_Result_byref_UpdateLobbyModificationOptions_byref_LobbyModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateLobbyCallbackInternalImplementation_Internal_Static_Void_byref_CreateLobbyCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroyLobbyCallbackInternalImplementation_Internal_Static_Void_byref_DestroyLobbyCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnHardMuteMemberCallbackInternalImplementation_Internal_Static_Void_byref_HardMuteMemberCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinLobbyAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyAcceptedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinLobbyByIdCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyByIdCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinLobbyCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnKickMemberCallbackInternalImplementation_Internal_Static_Void_byref_KickMemberCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLeaveLobbyCallbackInternalImplementation_Internal_Static_Void_byref_LeaveLobbyCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteAcceptedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteReceivedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyInviteRejectedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteRejectedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyMemberStatusReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyMemberStatusReceivedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyMemberUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyMemberUpdateReceivedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyUpdateReceivedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPromoteMemberCallbackInternalImplementation_Internal_Static_Void_byref_PromoteMemberCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_byref_QueryInvitesCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRTCRoomConnectionChangedCallbackInternalImplementation_Internal_Static_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSendLobbyNativeInviteRequestedCallbackInternalImplementation_Internal_Static_Void_byref_SendLobbyNativeInviteRequestedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateLobbyCallbackInternalImplementation_Internal_Static_Void_byref_UpdateLobbyCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LobbyInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955706, XrefRangeEnd = 955726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyJoinLobbyAccepted(
      ref AddNotifyJoinLobbyAcceptedOptions options,
      Il2CppSystem.Object clientData,
      OnJoinLobbyAcceptedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyJoinLobbyAccepted_Public_UInt64_byref_AddNotifyJoinLobbyAcceptedOptions_Object_OnJoinLobbyAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955726, XrefRangeEnd = 955746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyLobbyInviteAccepted(
      ref AddNotifyLobbyInviteAcceptedOptions options,
      Il2CppSystem.Object clientData,
      OnLobbyInviteAcceptedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteAccepted_Public_UInt64_byref_AddNotifyLobbyInviteAcceptedOptions_Object_OnLobbyInviteAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955746, XrefRangeEnd = 955766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyLobbyInviteReceived(
      ref AddNotifyLobbyInviteReceivedOptions options,
      Il2CppSystem.Object clientData,
      OnLobbyInviteReceivedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteReceived_Public_UInt64_byref_AddNotifyLobbyInviteReceivedOptions_Object_OnLobbyInviteReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955766, XrefRangeEnd = 955786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyLobbyInviteRejected(
      ref AddNotifyLobbyInviteRejectedOptions options,
      Il2CppSystem.Object clientData,
      OnLobbyInviteRejectedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteRejected_Public_UInt64_byref_AddNotifyLobbyInviteRejectedOptions_Object_OnLobbyInviteRejectedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955786, XrefRangeEnd = 955806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyLobbyMemberStatusReceived(
      ref AddNotifyLobbyMemberStatusReceivedOptions options,
      Il2CppSystem.Object clientData,
      OnLobbyMemberStatusReceivedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyMemberStatusReceived_Public_UInt64_byref_AddNotifyLobbyMemberStatusReceivedOptions_Object_OnLobbyMemberStatusReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955806, XrefRangeEnd = 955826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyLobbyMemberUpdateReceived(
      ref AddNotifyLobbyMemberUpdateReceivedOptions options,
      Il2CppSystem.Object clientData,
      OnLobbyMemberUpdateReceivedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyMemberUpdateReceived_Public_UInt64_byref_AddNotifyLobbyMemberUpdateReceivedOptions_Object_OnLobbyMemberUpdateReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955826, XrefRangeEnd = 955846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyLobbyUpdateReceived(
      ref AddNotifyLobbyUpdateReceivedOptions options,
      Il2CppSystem.Object clientData,
      OnLobbyUpdateReceivedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyUpdateReceived_Public_UInt64_byref_AddNotifyLobbyUpdateReceivedOptions_Object_OnLobbyUpdateReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955846, XrefRangeEnd = 955866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyRTCRoomConnectionChanged(
      ref AddNotifyRTCRoomConnectionChangedOptions options,
      Il2CppSystem.Object clientData,
      OnRTCRoomConnectionChangedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyRTCRoomConnectionChanged_Public_UInt64_byref_AddNotifyRTCRoomConnectionChangedOptions_Object_OnRTCRoomConnectionChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955866, XrefRangeEnd = 955886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifySendLobbyNativeInviteRequested(
      ref AddNotifySendLobbyNativeInviteRequestedOptions options,
      Il2CppSystem.Object clientData,
      OnSendLobbyNativeInviteRequestedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifySendLobbyNativeInviteRequested_Public_UInt64_byref_AddNotifySendLobbyNativeInviteRequestedOptions_Object_OnSendLobbyNativeInviteRequestedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955886, XrefRangeEnd = 955898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLobbyDetailsHandle(
      ref CopyLobbyDetailsHandleOptions options,
      out LobbyDetails outLobbyDetailsHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandle_Public_Result_byref_CopyLobbyDetailsHandleOptions_byref_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LobbyDetails local = ref outLobbyDetailsHandle;
      System.IntPtr pointer = zero;
      LobbyDetails lobbyDetails = pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
      local = lobbyDetails;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955898, XrefRangeEnd = 955910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLobbyDetailsHandleByInviteId(
      ref CopyLobbyDetailsHandleByInviteIdOptions options,
      out LobbyDetails outLobbyDetailsHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandleByInviteId_Public_Result_byref_CopyLobbyDetailsHandleByInviteIdOptions_byref_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LobbyDetails local = ref outLobbyDetailsHandle;
      System.IntPtr pointer = zero;
      LobbyDetails lobbyDetails = pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
      local = lobbyDetails;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955910, XrefRangeEnd = 955922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLobbyDetailsHandleByUiEventId(
      ref CopyLobbyDetailsHandleByUiEventIdOptions options,
      out LobbyDetails outLobbyDetailsHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandleByUiEventId_Public_Result_byref_CopyLobbyDetailsHandleByUiEventIdOptions_byref_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LobbyDetails local = ref outLobbyDetailsHandle;
      System.IntPtr pointer = zero;
      LobbyDetails lobbyDetails = pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
      local = lobbyDetails;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955922, XrefRangeEnd = 955941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateLobby(
      ref CreateLobbyOptions options,
      Il2CppSystem.Object clientData,
      OnCreateLobbyCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CreateLobby_Public_Void_byref_CreateLobbyOptions_Object_OnCreateLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955941, XrefRangeEnd = 955953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CreateLobbySearch(
      ref CreateLobbySearchOptions options,
      out LobbySearch outLobbySearchHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CreateLobbySearch_Public_Result_byref_CreateLobbySearchOptions_byref_LobbySearch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LobbySearch local = ref outLobbySearchHandle;
      System.IntPtr pointer = zero;
      LobbySearch lobbySearch = pointer == System.IntPtr.Zero ? (LobbySearch) null : new LobbySearch(pointer);
      local = lobbySearch;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955953, XrefRangeEnd = 955972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyLobby(
      ref DestroyLobbyOptions options,
      Il2CppSystem.Object clientData,
      OnDestroyLobbyCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_DestroyLobby_Public_Void_byref_DestroyLobbyOptions_Object_OnDestroyLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955972, XrefRangeEnd = 955980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetInviteCount(ref GetInviteCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetInviteCount_Public_UInt32_byref_GetInviteCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955980, XrefRangeEnd = 955991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetInviteIdByIndex(
      ref GetInviteIdByIndexOptions options,
      out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_byref_GetInviteIdByIndexOptions_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955991, XrefRangeEnd = 956002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetRTCRoomName(ref GetRTCRoomNameOptions options, out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetRTCRoomName_Public_Result_byref_GetRTCRoomNameOptions_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956002, XrefRangeEnd = 956021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HardMuteMember(
      ref HardMuteMemberOptions options,
      Il2CppSystem.Object clientData,
      OnHardMuteMemberCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_HardMuteMember_Public_Void_byref_HardMuteMemberOptions_Object_OnHardMuteMemberCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956021, XrefRangeEnd = 956030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result IsRTCRoomConnected(
      ref IsRTCRoomConnectedOptions options,
      out bool bOutIsConnected)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bOutIsConnected;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_IsRTCRoomConnected_Public_Result_byref_IsRTCRoomConnectedOptions_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956030, XrefRangeEnd = 956049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JoinLobby(
      ref JoinLobbyOptions options,
      Il2CppSystem.Object clientData,
      OnJoinLobbyCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_JoinLobby_Public_Void_byref_JoinLobbyOptions_Object_OnJoinLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956049, XrefRangeEnd = 956068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JoinLobbyById(
      ref JoinLobbyByIdOptions options,
      Il2CppSystem.Object clientData,
      OnJoinLobbyByIdCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_JoinLobbyById_Public_Void_byref_JoinLobbyByIdOptions_Object_OnJoinLobbyByIdCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956068, XrefRangeEnd = 956087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void KickMember(
      ref KickMemberOptions options,
      Il2CppSystem.Object clientData,
      OnKickMemberCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_KickMember_Public_Void_byref_KickMemberOptions_Object_OnKickMemberCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956087, XrefRangeEnd = 956106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LeaveLobby(
      ref LeaveLobbyOptions options,
      Il2CppSystem.Object clientData,
      OnLeaveLobbyCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LeaveLobby_Public_Void_byref_LeaveLobbyOptions_Object_OnLeaveLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956106, XrefRangeEnd = 956125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PromoteMember(
      ref PromoteMemberOptions options,
      Il2CppSystem.Object clientData,
      OnPromoteMemberCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_PromoteMember_Public_Void_byref_PromoteMemberOptions_Object_OnPromoteMemberCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956125, XrefRangeEnd = 956144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryInvites(
      ref QueryInvitesOptions options,
      Il2CppSystem.Object clientData,
      OnQueryInvitesCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_QueryInvites_Public_Void_byref_QueryInvitesOptions_Object_OnQueryInvitesCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956144, XrefRangeEnd = 956163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RejectInvite(
      ref RejectInviteOptions options,
      Il2CppSystem.Object clientData,
      OnRejectInviteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956163, XrefRangeEnd = 956168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyJoinLobbyAccepted(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyJoinLobbyAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956168, XrefRangeEnd = 956173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyLobbyInviteAccepted(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956173, XrefRangeEnd = 956178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyLobbyInviteReceived(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956178, XrefRangeEnd = 956183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyLobbyInviteRejected(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteRejected_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956183, XrefRangeEnd = 956188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyLobbyMemberStatusReceived(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyMemberStatusReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956188, XrefRangeEnd = 956193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyLobbyMemberUpdateReceived(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyMemberUpdateReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956193, XrefRangeEnd = 956198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyLobbyUpdateReceived(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyUpdateReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956198, XrefRangeEnd = 956203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyRTCRoomConnectionChanged(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyRTCRoomConnectionChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956203, XrefRangeEnd = 956208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifySendLobbyNativeInviteRequested(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifySendLobbyNativeInviteRequested_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956208, XrefRangeEnd = 956227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendInvite(
      ref SendInviteOptions options,
      Il2CppSystem.Object clientData,
      OnSendInviteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956227, XrefRangeEnd = 956246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateLobby(
      ref UpdateLobbyOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateLobbyCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateLobby_Public_Void_byref_UpdateLobbyOptions_Object_OnUpdateLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956246, XrefRangeEnd = 956258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result UpdateLobbyModification(
      ref UpdateLobbyModificationOptions options,
      out LobbyModification outLobbyModificationHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateLobbyModification_Public_Result_byref_UpdateLobbyModificationOptions_byref_LobbyModification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LobbyModification local = ref outLobbyModificationHandle;
      System.IntPtr pointer = zero;
      LobbyModification lobbyModification = pointer == System.IntPtr.Zero ? (LobbyModification) null : new LobbyModification(pointer);
      local = lobbyModification;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956258, XrefRangeEnd = 956265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnCreateLobbyCallbackInternalImplementation(
      ref CreateLobbyCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnCreateLobbyCallbackInternalImplementation_Internal_Static_Void_byref_CreateLobbyCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956265, XrefRangeEnd = 956272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDestroyLobbyCallbackInternalImplementation(
      ref DestroyLobbyCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnDestroyLobbyCallbackInternalImplementation_Internal_Static_Void_byref_DestroyLobbyCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956272, XrefRangeEnd = 956279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnHardMuteMemberCallbackInternalImplementation(
      ref HardMuteMemberCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnHardMuteMemberCallbackInternalImplementation_Internal_Static_Void_byref_HardMuteMemberCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956279, XrefRangeEnd = 956286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnJoinLobbyAcceptedCallbackInternalImplementation(
      ref JoinLobbyAcceptedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyAcceptedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956286, XrefRangeEnd = 956293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnJoinLobbyByIdCallbackInternalImplementation(
      ref JoinLobbyByIdCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyByIdCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyByIdCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956293, XrefRangeEnd = 956300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnJoinLobbyCallbackInternalImplementation(
      ref JoinLobbyCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956300, XrefRangeEnd = 956307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnKickMemberCallbackInternalImplementation(
      ref KickMemberCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnKickMemberCallbackInternalImplementation_Internal_Static_Void_byref_KickMemberCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956307, XrefRangeEnd = 956314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLeaveLobbyCallbackInternalImplementation(
      ref LeaveLobbyCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLeaveLobbyCallbackInternalImplementation_Internal_Static_Void_byref_LeaveLobbyCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956314, XrefRangeEnd = 956321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLobbyInviteAcceptedCallbackInternalImplementation(
      ref LobbyInviteAcceptedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteAcceptedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956321, XrefRangeEnd = 956328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLobbyInviteReceivedCallbackInternalImplementation(
      ref LobbyInviteReceivedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteReceivedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956328, XrefRangeEnd = 956335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLobbyInviteRejectedCallbackInternalImplementation(
      ref LobbyInviteRejectedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteRejectedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteRejectedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956335, XrefRangeEnd = 956342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLobbyMemberStatusReceivedCallbackInternalImplementation(
      ref LobbyMemberStatusReceivedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyMemberStatusReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyMemberStatusReceivedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956342, XrefRangeEnd = 956349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLobbyMemberUpdateReceivedCallbackInternalImplementation(
      ref LobbyMemberUpdateReceivedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyMemberUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyMemberUpdateReceivedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956349, XrefRangeEnd = 956356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLobbyUpdateReceivedCallbackInternalImplementation(
      ref LobbyUpdateReceivedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyUpdateReceivedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956356, XrefRangeEnd = 956363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnPromoteMemberCallbackInternalImplementation(
      ref PromoteMemberCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnPromoteMemberCallbackInternalImplementation_Internal_Static_Void_byref_PromoteMemberCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956363, XrefRangeEnd = 956370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryInvitesCallbackInternalImplementation(
      ref QueryInvitesCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_byref_QueryInvitesCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956370, XrefRangeEnd = 956377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnRTCRoomConnectionChangedCallbackInternalImplementation(
      ref RTCRoomConnectionChangedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnRTCRoomConnectionChangedCallbackInternalImplementation_Internal_Static_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956377, XrefRangeEnd = 956384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnRejectInviteCallbackInternalImplementation(
      ref RejectInviteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956384, XrefRangeEnd = 956391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSendInviteCallbackInternalImplementation(
      ref SendInviteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956391, XrefRangeEnd = 956398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSendLobbyNativeInviteRequestedCallbackInternalImplementation(
      ref SendLobbyNativeInviteRequestedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnSendLobbyNativeInviteRequestedCallbackInternalImplementation_Internal_Static_Void_byref_SendLobbyNativeInviteRequestedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956398, XrefRangeEnd = 956405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateLobbyCallbackInternalImplementation(
      ref UpdateLobbyCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnUpdateLobbyCallbackInternalImplementation_Internal_Static_Void_byref_UpdateLobbyCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LobbyInterface()
    {
      Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LobbyInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr);
      LobbyInterface.NativeFieldInfoPtr_AddnotifyjoinlobbyacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifyjoinlobbyacceptedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviteacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbyinviteacceptedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinvitereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbyinvitereceivedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviterejectedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbyinviterejectedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberstatusreceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbymemberstatusreceivedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberupdatereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbymemberupdatereceivedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyupdatereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbyupdatereceivedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AddnotifyrtcroomconnectionchangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifyrtcroomconnectionchangedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AddnotifysendlobbynativeinviterequestedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifysendlobbynativeinviterequestedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AttributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AttributeApiLatest));
      LobbyInterface.NativeFieldInfoPtr_AttributedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AttributedataApiLatest));
      LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandleApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CopylobbydetailshandleApiLatest));
      LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyinviteidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CopylobbydetailshandlebyinviteidApiLatest));
      LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyuieventidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CopylobbydetailshandlebyuieventidApiLatest));
      LobbyInterface.NativeFieldInfoPtr_CreatelobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CreatelobbyApiLatest));
      LobbyInterface.NativeFieldInfoPtr_CreatelobbysearchApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CreatelobbysearchApiLatest));
      LobbyInterface.NativeFieldInfoPtr_DestroylobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (DestroylobbyApiLatest));
      LobbyInterface.NativeFieldInfoPtr_GetinvitecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (GetinvitecountApiLatest));
      LobbyInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (GetinviteidbyindexApiLatest));
      LobbyInterface.NativeFieldInfoPtr_GetrtcroomnameApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (GetrtcroomnameApiLatest));
      LobbyInterface.NativeFieldInfoPtr_HardmutememberApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (HardmutememberApiLatest));
      LobbyInterface.NativeFieldInfoPtr_InviteidMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (InviteidMaxLength));
      LobbyInterface.NativeFieldInfoPtr_IsrtcroomconnectedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (IsrtcroomconnectedApiLatest));
      LobbyInterface.NativeFieldInfoPtr_JoinlobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (JoinlobbyApiLatest));
      LobbyInterface.NativeFieldInfoPtr_JoinlobbybyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (JoinlobbybyidApiLatest));
      LobbyInterface.NativeFieldInfoPtr_KickmemberApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (KickmemberApiLatest));
      LobbyInterface.NativeFieldInfoPtr_LeavelobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (LeavelobbyApiLatest));
      LobbyInterface.NativeFieldInfoPtr_LocalrtcoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (LocalrtcoptionsApiLatest));
      LobbyInterface.NativeFieldInfoPtr_MaxLobbies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MaxLobbies));
      LobbyInterface.NativeFieldInfoPtr_MaxLobbyMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MaxLobbyMembers));
      LobbyInterface.NativeFieldInfoPtr_MaxLobbyidoverrideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MaxLobbyidoverrideLength));
      LobbyInterface.NativeFieldInfoPtr_MaxSearchResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MaxSearchResults));
      LobbyInterface.NativeFieldInfoPtr_MinLobbyidoverrideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MinLobbyidoverrideLength));
      LobbyInterface.NativeFieldInfoPtr_PromotememberApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (PromotememberApiLatest));
      LobbyInterface.NativeFieldInfoPtr_QueryinvitesApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (QueryinvitesApiLatest));
      LobbyInterface.NativeFieldInfoPtr_RejectinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (RejectinviteApiLatest));
      LobbyInterface.NativeFieldInfoPtr_SearchBucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (SearchBucketId));
      LobbyInterface.NativeFieldInfoPtr_SearchMincurrentmembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (SearchMincurrentmembers));
      LobbyInterface.NativeFieldInfoPtr_SearchMinslotsavailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (SearchMinslotsavailable));
      LobbyInterface.NativeFieldInfoPtr_SendinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (SendinviteApiLatest));
      LobbyInterface.NativeFieldInfoPtr_UpdatelobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (UpdatelobbyApiLatest));
      LobbyInterface.NativeFieldInfoPtr_UpdatelobbymodificationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (UpdatelobbymodificationApiLatest));
      LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670116);
      LobbyInterface.NativeMethodInfoPtr_AddNotifyJoinLobbyAccepted_Public_UInt64_byref_AddNotifyJoinLobbyAcceptedOptions_Object_OnJoinLobbyAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670118);
      LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteAccepted_Public_UInt64_byref_AddNotifyLobbyInviteAcceptedOptions_Object_OnLobbyInviteAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670119);
      LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteReceived_Public_UInt64_byref_AddNotifyLobbyInviteReceivedOptions_Object_OnLobbyInviteReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670120);
      LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteRejected_Public_UInt64_byref_AddNotifyLobbyInviteRejectedOptions_Object_OnLobbyInviteRejectedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670121);
      LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyMemberStatusReceived_Public_UInt64_byref_AddNotifyLobbyMemberStatusReceivedOptions_Object_OnLobbyMemberStatusReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670122);
      LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyMemberUpdateReceived_Public_UInt64_byref_AddNotifyLobbyMemberUpdateReceivedOptions_Object_OnLobbyMemberUpdateReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670123);
      LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyUpdateReceived_Public_UInt64_byref_AddNotifyLobbyUpdateReceivedOptions_Object_OnLobbyUpdateReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670124);
      LobbyInterface.NativeMethodInfoPtr_AddNotifyRTCRoomConnectionChanged_Public_UInt64_byref_AddNotifyRTCRoomConnectionChangedOptions_Object_OnRTCRoomConnectionChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670125);
      LobbyInterface.NativeMethodInfoPtr_AddNotifySendLobbyNativeInviteRequested_Public_UInt64_byref_AddNotifySendLobbyNativeInviteRequestedOptions_Object_OnSendLobbyNativeInviteRequestedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670126);
      LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandle_Public_Result_byref_CopyLobbyDetailsHandleOptions_byref_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670127);
      LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandleByInviteId_Public_Result_byref_CopyLobbyDetailsHandleByInviteIdOptions_byref_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670128);
      LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandleByUiEventId_Public_Result_byref_CopyLobbyDetailsHandleByUiEventIdOptions_byref_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670129);
      LobbyInterface.NativeMethodInfoPtr_CreateLobby_Public_Void_byref_CreateLobbyOptions_Object_OnCreateLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670130);
      LobbyInterface.NativeMethodInfoPtr_CreateLobbySearch_Public_Result_byref_CreateLobbySearchOptions_byref_LobbySearch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670131);
      LobbyInterface.NativeMethodInfoPtr_DestroyLobby_Public_Void_byref_DestroyLobbyOptions_Object_OnDestroyLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670132);
      LobbyInterface.NativeMethodInfoPtr_GetInviteCount_Public_UInt32_byref_GetInviteCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670133);
      LobbyInterface.NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_byref_GetInviteIdByIndexOptions_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670134);
      LobbyInterface.NativeMethodInfoPtr_GetRTCRoomName_Public_Result_byref_GetRTCRoomNameOptions_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670135);
      LobbyInterface.NativeMethodInfoPtr_HardMuteMember_Public_Void_byref_HardMuteMemberOptions_Object_OnHardMuteMemberCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670136);
      LobbyInterface.NativeMethodInfoPtr_IsRTCRoomConnected_Public_Result_byref_IsRTCRoomConnectedOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670137);
      LobbyInterface.NativeMethodInfoPtr_JoinLobby_Public_Void_byref_JoinLobbyOptions_Object_OnJoinLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670138);
      LobbyInterface.NativeMethodInfoPtr_JoinLobbyById_Public_Void_byref_JoinLobbyByIdOptions_Object_OnJoinLobbyByIdCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670139);
      LobbyInterface.NativeMethodInfoPtr_KickMember_Public_Void_byref_KickMemberOptions_Object_OnKickMemberCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670140);
      LobbyInterface.NativeMethodInfoPtr_LeaveLobby_Public_Void_byref_LeaveLobbyOptions_Object_OnLeaveLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670141);
      LobbyInterface.NativeMethodInfoPtr_PromoteMember_Public_Void_byref_PromoteMemberOptions_Object_OnPromoteMemberCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670142);
      LobbyInterface.NativeMethodInfoPtr_QueryInvites_Public_Void_byref_QueryInvitesOptions_Object_OnQueryInvitesCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670143);
      LobbyInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670144);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifyJoinLobbyAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670145);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670146);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670147);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteRejected_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670148);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyMemberStatusReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670149);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyMemberUpdateReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670150);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyUpdateReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670151);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifyRTCRoomConnectionChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670152);
      LobbyInterface.NativeMethodInfoPtr_RemoveNotifySendLobbyNativeInviteRequested_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670153);
      LobbyInterface.NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670154);
      LobbyInterface.NativeMethodInfoPtr_UpdateLobby_Public_Void_byref_UpdateLobbyOptions_Object_OnUpdateLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670155);
      LobbyInterface.NativeMethodInfoPtr_UpdateLobbyModification_Public_Result_byref_UpdateLobbyModificationOptions_byref_LobbyModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670156);
      LobbyInterface.NativeMethodInfoPtr_OnCreateLobbyCallbackInternalImplementation_Internal_Static_Void_byref_CreateLobbyCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670157);
      LobbyInterface.NativeMethodInfoPtr_OnDestroyLobbyCallbackInternalImplementation_Internal_Static_Void_byref_DestroyLobbyCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670158);
      LobbyInterface.NativeMethodInfoPtr_OnHardMuteMemberCallbackInternalImplementation_Internal_Static_Void_byref_HardMuteMemberCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670159);
      LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyAcceptedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670160);
      LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyByIdCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyByIdCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670161);
      LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyCallbackInternalImplementation_Internal_Static_Void_byref_JoinLobbyCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670162);
      LobbyInterface.NativeMethodInfoPtr_OnKickMemberCallbackInternalImplementation_Internal_Static_Void_byref_KickMemberCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670163);
      LobbyInterface.NativeMethodInfoPtr_OnLeaveLobbyCallbackInternalImplementation_Internal_Static_Void_byref_LeaveLobbyCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670164);
      LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteAcceptedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670165);
      LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteReceivedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670166);
      LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteRejectedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyInviteRejectedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670167);
      LobbyInterface.NativeMethodInfoPtr_OnLobbyMemberStatusReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyMemberStatusReceivedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670168);
      LobbyInterface.NativeMethodInfoPtr_OnLobbyMemberUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyMemberUpdateReceivedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670169);
      LobbyInterface.NativeMethodInfoPtr_OnLobbyUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_LobbyUpdateReceivedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670170);
      LobbyInterface.NativeMethodInfoPtr_OnPromoteMemberCallbackInternalImplementation_Internal_Static_Void_byref_PromoteMemberCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670171);
      LobbyInterface.NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_byref_QueryInvitesCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670172);
      LobbyInterface.NativeMethodInfoPtr_OnRTCRoomConnectionChangedCallbackInternalImplementation_Internal_Static_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670173);
      LobbyInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670174);
      LobbyInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670175);
      LobbyInterface.NativeMethodInfoPtr_OnSendLobbyNativeInviteRequestedCallbackInternalImplementation_Internal_Static_Void_byref_SendLobbyNativeInviteRequestedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670176);
      LobbyInterface.NativeMethodInfoPtr_OnUpdateLobbyCallbackInternalImplementation_Internal_Static_Void_byref_UpdateLobbyCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100670177);
    }

    public LobbyInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifyjoinlobbyacceptedApiLatest
    {
      get
      {
        int addnotifyjoinlobbyacceptedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifyjoinlobbyacceptedApiLatest, (void*) &addnotifyjoinlobbyacceptedApiLatest);
        return addnotifyjoinlobbyacceptedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifyjoinlobbyacceptedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifylobbyinviteacceptedApiLatest
    {
      get
      {
        int addnotifylobbyinviteacceptedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviteacceptedApiLatest, (void*) &addnotifylobbyinviteacceptedApiLatest);
        return addnotifylobbyinviteacceptedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviteacceptedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifylobbyinvitereceivedApiLatest
    {
      get
      {
        int addnotifylobbyinvitereceivedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinvitereceivedApiLatest, (void*) &addnotifylobbyinvitereceivedApiLatest);
        return addnotifylobbyinvitereceivedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinvitereceivedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifylobbyinviterejectedApiLatest
    {
      get
      {
        int addnotifylobbyinviterejectedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviterejectedApiLatest, (void*) &addnotifylobbyinviterejectedApiLatest);
        return addnotifylobbyinviterejectedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviterejectedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifylobbymemberstatusreceivedApiLatest
    {
      get
      {
        int addnotifylobbymemberstatusreceivedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberstatusreceivedApiLatest, (void*) &addnotifylobbymemberstatusreceivedApiLatest);
        return addnotifylobbymemberstatusreceivedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberstatusreceivedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifylobbymemberupdatereceivedApiLatest
    {
      get
      {
        int addnotifylobbymemberupdatereceivedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberupdatereceivedApiLatest, (void*) &addnotifylobbymemberupdatereceivedApiLatest);
        return addnotifylobbymemberupdatereceivedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberupdatereceivedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifylobbyupdatereceivedApiLatest
    {
      get
      {
        int addnotifylobbyupdatereceivedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyupdatereceivedApiLatest, (void*) &addnotifylobbyupdatereceivedApiLatest);
        return addnotifylobbyupdatereceivedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyupdatereceivedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyrtcroomconnectionchangedApiLatest
    {
      get
      {
        int addnotifyrtcroomconnectionchangedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifyrtcroomconnectionchangedApiLatest, (void*) &addnotifyrtcroomconnectionchangedApiLatest);
        return addnotifyrtcroomconnectionchangedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifyrtcroomconnectionchangedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifysendlobbynativeinviterequestedApiLatest
    {
      get
      {
        int addnotifysendlobbynativeinviterequestedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifysendlobbynativeinviterequestedApiLatest, (void*) &addnotifysendlobbynativeinviterequestedApiLatest);
        return addnotifysendlobbynativeinviterequestedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifysendlobbynativeinviterequestedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AttributeApiLatest
    {
      get
      {
        int attributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AttributeApiLatest, (void*) &attributeApiLatest);
        return attributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AttributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int AttributedataApiLatest
    {
      get
      {
        int attributedataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AttributedataApiLatest, (void*) &attributedataApiLatest);
        return attributedataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AttributedataApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopylobbydetailshandleApiLatest
    {
      get
      {
        int copylobbydetailshandleApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandleApiLatest, (void*) &copylobbydetailshandleApiLatest);
        return copylobbydetailshandleApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandleApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopylobbydetailshandlebyinviteidApiLatest
    {
      get
      {
        int copylobbydetailshandlebyinviteidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyinviteidApiLatest, (void*) &copylobbydetailshandlebyinviteidApiLatest);
        return copylobbydetailshandlebyinviteidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyinviteidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopylobbydetailshandlebyuieventidApiLatest
    {
      get
      {
        int copylobbydetailshandlebyuieventidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyuieventidApiLatest, (void*) &copylobbydetailshandlebyuieventidApiLatest);
        return copylobbydetailshandlebyuieventidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyuieventidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CreatelobbyApiLatest
    {
      get
      {
        int createlobbyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CreatelobbyApiLatest, (void*) &createlobbyApiLatest);
        return createlobbyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CreatelobbyApiLatest, (void*) &value);
      }
    }

    public static unsafe int CreatelobbysearchApiLatest
    {
      get
      {
        int createlobbysearchApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CreatelobbysearchApiLatest, (void*) &createlobbysearchApiLatest);
        return createlobbysearchApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CreatelobbysearchApiLatest, (void*) &value);
      }
    }

    public static unsafe int DestroylobbyApiLatest
    {
      get
      {
        int destroylobbyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_DestroylobbyApiLatest, (void*) &destroylobbyApiLatest);
        return destroylobbyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_DestroylobbyApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetinvitecountApiLatest
    {
      get
      {
        int getinvitecountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_GetinvitecountApiLatest, (void*) &getinvitecountApiLatest);
        return getinvitecountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_GetinvitecountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetinviteidbyindexApiLatest
    {
      get
      {
        int getinviteidbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest, (void*) &getinviteidbyindexApiLatest);
        return getinviteidbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetrtcroomnameApiLatest
    {
      get
      {
        int getrtcroomnameApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_GetrtcroomnameApiLatest, (void*) &getrtcroomnameApiLatest);
        return getrtcroomnameApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_GetrtcroomnameApiLatest, (void*) &value);
      }
    }

    public static unsafe int HardmutememberApiLatest
    {
      get
      {
        int hardmutememberApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_HardmutememberApiLatest, (void*) &hardmutememberApiLatest);
        return hardmutememberApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_HardmutememberApiLatest, (void*) &value);
      }
    }

    public static unsafe int InviteidMaxLength
    {
      get
      {
        int inviteidMaxLength;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_InviteidMaxLength, (void*) &inviteidMaxLength);
        return inviteidMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_InviteidMaxLength, (void*) &value);
      }
    }

    public static unsafe int IsrtcroomconnectedApiLatest
    {
      get
      {
        int isrtcroomconnectedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_IsrtcroomconnectedApiLatest, (void*) &isrtcroomconnectedApiLatest);
        return isrtcroomconnectedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_IsrtcroomconnectedApiLatest, (void*) &value);
      }
    }

    public static unsafe int JoinlobbyApiLatest
    {
      get
      {
        int joinlobbyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_JoinlobbyApiLatest, (void*) &joinlobbyApiLatest);
        return joinlobbyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_JoinlobbyApiLatest, (void*) &value);
      }
    }

    public static unsafe int JoinlobbybyidApiLatest
    {
      get
      {
        int joinlobbybyidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_JoinlobbybyidApiLatest, (void*) &joinlobbybyidApiLatest);
        return joinlobbybyidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_JoinlobbybyidApiLatest, (void*) &value);
      }
    }

    public static unsafe int KickmemberApiLatest
    {
      get
      {
        int kickmemberApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_KickmemberApiLatest, (void*) &kickmemberApiLatest);
        return kickmemberApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_KickmemberApiLatest, (void*) &value);
      }
    }

    public static unsafe int LeavelobbyApiLatest
    {
      get
      {
        int leavelobbyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_LeavelobbyApiLatest, (void*) &leavelobbyApiLatest);
        return leavelobbyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_LeavelobbyApiLatest, (void*) &value);
      }
    }

    public static unsafe int LocalrtcoptionsApiLatest
    {
      get
      {
        int localrtcoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_LocalrtcoptionsApiLatest, (void*) &localrtcoptionsApiLatest);
        return localrtcoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_LocalrtcoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int MaxLobbies
    {
      get
      {
        int maxLobbies;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbies, (void*) &maxLobbies);
        return maxLobbies;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbies, (void*) &value);
      }
    }

    public static unsafe int MaxLobbyMembers
    {
      get
      {
        int maxLobbyMembers;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbyMembers, (void*) &maxLobbyMembers);
        return maxLobbyMembers;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbyMembers, (void*) &value);
      }
    }

    public static unsafe int MaxLobbyidoverrideLength
    {
      get
      {
        int lobbyidoverrideLength;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbyidoverrideLength, (void*) &lobbyidoverrideLength);
        return lobbyidoverrideLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbyidoverrideLength, (void*) &value);
      }
    }

    public static unsafe int MaxSearchResults
    {
      get
      {
        int maxSearchResults;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MaxSearchResults, (void*) &maxSearchResults);
        return maxSearchResults;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MaxSearchResults, (void*) &value);
      }
    }

    public static unsafe int MinLobbyidoverrideLength
    {
      get
      {
        int lobbyidoverrideLength;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MinLobbyidoverrideLength, (void*) &lobbyidoverrideLength);
        return lobbyidoverrideLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MinLobbyidoverrideLength, (void*) &value);
      }
    }

    public static unsafe int PromotememberApiLatest
    {
      get
      {
        int promotememberApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_PromotememberApiLatest, (void*) &promotememberApiLatest);
        return promotememberApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_PromotememberApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryinvitesApiLatest
    {
      get
      {
        int queryinvitesApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_QueryinvitesApiLatest, (void*) &queryinvitesApiLatest);
        return queryinvitesApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_QueryinvitesApiLatest, (void*) &value);
      }
    }

    public static unsafe int RejectinviteApiLatest
    {
      get
      {
        int rejectinviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &rejectinviteApiLatest);
        return rejectinviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &value);
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String SearchBucketId
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_SearchBucketId, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_SearchBucketId, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String SearchMincurrentmembers
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_SearchMincurrentmembers, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_SearchMincurrentmembers, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String SearchMinslotsavailable
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_SearchMinslotsavailable, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_SearchMinslotsavailable, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int SendinviteApiLatest
    {
      get
      {
        int sendinviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &sendinviteApiLatest);
        return sendinviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatelobbyApiLatest
    {
      get
      {
        int updatelobbyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_UpdatelobbyApiLatest, (void*) &updatelobbyApiLatest);
        return updatelobbyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_UpdatelobbyApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatelobbymodificationApiLatest
    {
      get
      {
        int updatelobbymodificationApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_UpdatelobbymodificationApiLatest, (void*) &updatelobbymodificationApiLatest);
        return updatelobbymodificationApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_UpdatelobbymodificationApiLatest, (void*) &value);
      }
    }
  }
}
