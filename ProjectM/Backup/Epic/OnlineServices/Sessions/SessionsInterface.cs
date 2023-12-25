// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  public sealed class SessionsInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyjoinsessionacceptedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifysessioninviteacceptedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifysessioninvitereceivedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttributedataApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyactivesessionhandleApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopysessionhandlebyinviteidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopysessionhandlebyuieventidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopysessionhandleforpresenceApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatesessionmodificationApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatesessionsearchApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroysessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DumpsessionstateApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndsessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetinvitecountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetinviteidbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_InviteidMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsuserinsessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinsessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSearchResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_Maxregisteredplayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryinvitesApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterplayersApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RejectinviteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SearchBucketId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SearchEmptyServersOnly;
    private static readonly System.IntPtr NativeFieldInfoPtr_SearchMinslotsavailable;
    private static readonly System.IntPtr NativeFieldInfoPtr_SearchNonemptyServersOnly;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendinviteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionattributeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionattributedataApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartsessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnregisterplayersApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatesessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatesessionmodificationApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyJoinSessionAccepted_Public_UInt64_byref_AddNotifyJoinSessionAcceptedOptions_Object_OnJoinSessionAcceptedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifySessionInviteAccepted_Public_UInt64_byref_AddNotifySessionInviteAcceptedOptions_Object_OnSessionInviteAcceptedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifySessionInviteReceived_Public_UInt64_byref_AddNotifySessionInviteReceivedOptions_Object_OnSessionInviteReceivedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyActiveSessionHandle_Public_Result_byref_CopyActiveSessionHandleOptions_byref_ActiveSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopySessionHandleByInviteId_Public_Result_byref_CopySessionHandleByInviteIdOptions_byref_SessionDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopySessionHandleByUiEventId_Public_Result_byref_CopySessionHandleByUiEventIdOptions_byref_SessionDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopySessionHandleForPresence_Public_Result_byref_CopySessionHandleForPresenceOptions_byref_SessionDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSessionModification_Public_Result_byref_CreateSessionModificationOptions_byref_SessionModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSessionSearch_Public_Result_byref_CreateSessionSearchOptions_byref_SessionSearch_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroySession_Public_Void_byref_DestroySessionOptions_Object_OnDestroySessionCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpSessionState_Public_Result_byref_DumpSessionStateOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndSession_Public_Void_byref_EndSessionOptions_Object_OnEndSessionCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInviteCount_Public_UInt32_byref_GetInviteCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_byref_GetInviteIdByIndexOptions_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUserInSession_Public_Result_byref_IsUserInSessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinSession_Public_Void_byref_JoinSessionOptions_Object_OnJoinSessionCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryInvites_Public_Void_byref_QueryInvitesOptions_Object_OnQueryInvitesCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPlayers_Public_Void_byref_RegisterPlayersOptions_Object_OnRegisterPlayersCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyJoinSessionAccepted_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifySessionInviteAccepted_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifySessionInviteReceived_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartSession_Public_Void_byref_StartSessionOptions_Object_OnStartSessionCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterPlayers_Public_Void_byref_UnregisterPlayersOptions_Object_OnUnregisterPlayersCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSession_Public_Void_byref_UpdateSessionOptions_Object_OnUpdateSessionCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSessionModification_Public_Result_byref_UpdateSessionModificationOptions_byref_SessionModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroySessionCallbackInternalImplementation_Internal_Static_Void_byref_DestroySessionCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEndSessionCallbackInternalImplementation_Internal_Static_Void_byref_EndSessionCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinSessionAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinSessionAcceptedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinSessionCallbackInternalImplementation_Internal_Static_Void_byref_JoinSessionCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_byref_QueryInvitesCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRegisterPlayersCallbackInternalImplementation_Internal_Static_Void_byref_RegisterPlayersCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSessionInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_SessionInviteAcceptedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSessionInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_SessionInviteReceivedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartSessionCallbackInternalImplementation_Internal_Static_Void_byref_StartSessionCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUnregisterPlayersCallbackInternalImplementation_Internal_Static_Void_byref_UnregisterPlayersCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateSessionCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSessionCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942500, XrefRangeEnd = 942520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyJoinSessionAccepted(
      ref AddNotifyJoinSessionAcceptedOptions options,
      Il2CppSystem.Object clientData,
      OnJoinSessionAcceptedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_AddNotifyJoinSessionAccepted_Public_UInt64_byref_AddNotifyJoinSessionAcceptedOptions_Object_OnJoinSessionAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942520, XrefRangeEnd = 942540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifySessionInviteAccepted(
      ref AddNotifySessionInviteAcceptedOptions options,
      Il2CppSystem.Object clientData,
      OnSessionInviteAcceptedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_AddNotifySessionInviteAccepted_Public_UInt64_byref_AddNotifySessionInviteAcceptedOptions_Object_OnSessionInviteAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942540, XrefRangeEnd = 942560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifySessionInviteReceived(
      ref AddNotifySessionInviteReceivedOptions options,
      Il2CppSystem.Object clientData,
      OnSessionInviteReceivedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_AddNotifySessionInviteReceived_Public_UInt64_byref_AddNotifySessionInviteReceivedOptions_Object_OnSessionInviteReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942560, XrefRangeEnd = 942572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyActiveSessionHandle(
      ref CopyActiveSessionHandleOptions options,
      out ActiveSession outSessionHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CopyActiveSessionHandle_Public_Result_byref_CopyActiveSessionHandleOptions_byref_ActiveSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ActiveSession local = ref outSessionHandle;
      System.IntPtr pointer = zero;
      ActiveSession activeSession = pointer == System.IntPtr.Zero ? (ActiveSession) null : new ActiveSession(pointer);
      local = activeSession;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942572, XrefRangeEnd = 942584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopySessionHandleByInviteId(
      ref CopySessionHandleByInviteIdOptions options,
      out SessionDetails outSessionHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CopySessionHandleByInviteId_Public_Result_byref_CopySessionHandleByInviteIdOptions_byref_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionDetails local = ref outSessionHandle;
      System.IntPtr pointer = zero;
      SessionDetails sessionDetails = pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
      local = sessionDetails;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942584, XrefRangeEnd = 942596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopySessionHandleByUiEventId(
      ref CopySessionHandleByUiEventIdOptions options,
      out SessionDetails outSessionHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CopySessionHandleByUiEventId_Public_Result_byref_CopySessionHandleByUiEventIdOptions_byref_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionDetails local = ref outSessionHandle;
      System.IntPtr pointer = zero;
      SessionDetails sessionDetails = pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
      local = sessionDetails;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942596, XrefRangeEnd = 942608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopySessionHandleForPresence(
      ref CopySessionHandleForPresenceOptions options,
      out SessionDetails outSessionHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CopySessionHandleForPresence_Public_Result_byref_CopySessionHandleForPresenceOptions_byref_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionDetails local = ref outSessionHandle;
      System.IntPtr pointer = zero;
      SessionDetails sessionDetails = pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
      local = sessionDetails;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942608, XrefRangeEnd = 942620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CreateSessionModification(
      ref CreateSessionModificationOptions options,
      out SessionModification outSessionModificationHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CreateSessionModification_Public_Result_byref_CreateSessionModificationOptions_byref_SessionModification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionModification local = ref outSessionModificationHandle;
      System.IntPtr pointer = zero;
      SessionModification sessionModification = pointer == System.IntPtr.Zero ? (SessionModification) null : new SessionModification(pointer);
      local = sessionModification;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942620, XrefRangeEnd = 942632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CreateSessionSearch(
      ref CreateSessionSearchOptions options,
      out SessionSearch outSessionSearchHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CreateSessionSearch_Public_Result_byref_CreateSessionSearchOptions_byref_SessionSearch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionSearch local = ref outSessionSearchHandle;
      System.IntPtr pointer = zero;
      SessionSearch sessionSearch = pointer == System.IntPtr.Zero ? (SessionSearch) null : new SessionSearch(pointer);
      local = sessionSearch;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942632, XrefRangeEnd = 942651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroySession(
      ref DestroySessionOptions options,
      Il2CppSystem.Object clientData,
      OnDestroySessionCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_DestroySession_Public_Void_byref_DestroySessionOptions_Object_OnDestroySessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942651, XrefRangeEnd = 942659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result DumpSessionState(ref DumpSessionStateOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_DumpSessionState_Public_Result_byref_DumpSessionStateOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942659, XrefRangeEnd = 942678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndSession(
      ref EndSessionOptions options,
      Il2CppSystem.Object clientData,
      OnEndSessionCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_EndSession_Public_Void_byref_EndSessionOptions_Object_OnEndSessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942678, XrefRangeEnd = 942686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetInviteCount(ref GetInviteCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_GetInviteCount_Public_UInt32_byref_GetInviteCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942686, XrefRangeEnd = 942697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_byref_GetInviteIdByIndexOptions_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942697, XrefRangeEnd = 942705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result IsUserInSession(ref IsUserInSessionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_IsUserInSession_Public_Result_byref_IsUserInSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942705, XrefRangeEnd = 942724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JoinSession(
      ref JoinSessionOptions options,
      Il2CppSystem.Object clientData,
      OnJoinSessionCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_JoinSession_Public_Void_byref_JoinSessionOptions_Object_OnJoinSessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942724, XrefRangeEnd = 942743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_QueryInvites_Public_Void_byref_QueryInvitesOptions_Object_OnQueryInvitesCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942743, XrefRangeEnd = 942762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterPlayers(
      ref RegisterPlayersOptions options,
      Il2CppSystem.Object clientData,
      OnRegisterPlayersCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RegisterPlayers_Public_Void_byref_RegisterPlayersOptions_Object_OnRegisterPlayersCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942762, XrefRangeEnd = 942781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942781, XrefRangeEnd = 942786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyJoinSessionAccepted(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RemoveNotifyJoinSessionAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942786, XrefRangeEnd = 942791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifySessionInviteAccepted(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RemoveNotifySessionInviteAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942791, XrefRangeEnd = 942796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifySessionInviteReceived(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RemoveNotifySessionInviteReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942796, XrefRangeEnd = 942815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942815, XrefRangeEnd = 942834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartSession(
      ref StartSessionOptions options,
      Il2CppSystem.Object clientData,
      OnStartSessionCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_StartSession_Public_Void_byref_StartSessionOptions_Object_OnStartSessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942834, XrefRangeEnd = 942853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnregisterPlayers(
      ref UnregisterPlayersOptions options,
      Il2CppSystem.Object clientData,
      OnUnregisterPlayersCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_UnregisterPlayers_Public_Void_byref_UnregisterPlayersOptions_Object_OnUnregisterPlayersCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942872, RefRangeEnd = 942873, XrefRangeStart = 942853, XrefRangeEnd = 942872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSession(
      ref UpdateSessionOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateSessionCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_UpdateSession_Public_Void_byref_UpdateSessionOptions_Object_OnUpdateSessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942873, XrefRangeEnd = 942885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result UpdateSessionModification(
      ref UpdateSessionModificationOptions options,
      out SessionModification outSessionModificationHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_UpdateSessionModification_Public_Result_byref_UpdateSessionModificationOptions_byref_SessionModification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionModification local = ref outSessionModificationHandle;
      System.IntPtr pointer = zero;
      SessionModification sessionModification = pointer == System.IntPtr.Zero ? (SessionModification) null : new SessionModification(pointer);
      local = sessionModification;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942885, XrefRangeEnd = 942892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDestroySessionCallbackInternalImplementation(
      ref DestroySessionCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnDestroySessionCallbackInternalImplementation_Internal_Static_Void_byref_DestroySessionCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942892, XrefRangeEnd = 942899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnEndSessionCallbackInternalImplementation(
      ref EndSessionCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnEndSessionCallbackInternalImplementation_Internal_Static_Void_byref_EndSessionCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942899, XrefRangeEnd = 942906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnJoinSessionAcceptedCallbackInternalImplementation(
      ref JoinSessionAcceptedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnJoinSessionAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinSessionAcceptedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942906, XrefRangeEnd = 942913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnJoinSessionCallbackInternalImplementation(
      ref JoinSessionCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnJoinSessionCallbackInternalImplementation_Internal_Static_Void_byref_JoinSessionCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942913, XrefRangeEnd = 942920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryInvitesCallbackInternalImplementation(
      ref QueryInvitesCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_byref_QueryInvitesCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942920, XrefRangeEnd = 942927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnRegisterPlayersCallbackInternalImplementation(
      ref RegisterPlayersCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnRegisterPlayersCallbackInternalImplementation_Internal_Static_Void_byref_RegisterPlayersCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942927, XrefRangeEnd = 942934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnRejectInviteCallbackInternalImplementation(
      ref RejectInviteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942934, XrefRangeEnd = 942941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSendInviteCallbackInternalImplementation(
      ref SendInviteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942941, XrefRangeEnd = 942948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSessionInviteAcceptedCallbackInternalImplementation(
      ref SessionInviteAcceptedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnSessionInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_SessionInviteAcceptedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942948, XrefRangeEnd = 942955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSessionInviteReceivedCallbackInternalImplementation(
      ref SessionInviteReceivedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnSessionInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_SessionInviteReceivedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942955, XrefRangeEnd = 942962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnStartSessionCallbackInternalImplementation(
      ref StartSessionCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnStartSessionCallbackInternalImplementation_Internal_Static_Void_byref_StartSessionCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942962, XrefRangeEnd = 942969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUnregisterPlayersCallbackInternalImplementation(
      ref UnregisterPlayersCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnUnregisterPlayersCallbackInternalImplementation_Internal_Static_Void_byref_UnregisterPlayersCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942969, XrefRangeEnd = 942976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateSessionCallbackInternalImplementation(
      ref UpdateSessionCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnUpdateSessionCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSessionCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SessionsInterface()
    {
      Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr);
      SessionsInterface.NativeFieldInfoPtr_AddnotifyjoinsessionacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (AddnotifyjoinsessionacceptedApiLatest));
      SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninviteacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (AddnotifysessioninviteacceptedApiLatest));
      SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninvitereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (AddnotifysessioninvitereceivedApiLatest));
      SessionsInterface.NativeFieldInfoPtr_AttributedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (AttributedataApiLatest));
      SessionsInterface.NativeFieldInfoPtr_CopyactivesessionhandleApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CopyactivesessionhandleApiLatest));
      SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyinviteidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CopysessionhandlebyinviteidApiLatest));
      SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyuieventidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CopysessionhandlebyuieventidApiLatest));
      SessionsInterface.NativeFieldInfoPtr_CopysessionhandleforpresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CopysessionhandleforpresenceApiLatest));
      SessionsInterface.NativeFieldInfoPtr_CreatesessionmodificationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CreatesessionmodificationApiLatest));
      SessionsInterface.NativeFieldInfoPtr_CreatesessionsearchApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CreatesessionsearchApiLatest));
      SessionsInterface.NativeFieldInfoPtr_DestroysessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (DestroysessionApiLatest));
      SessionsInterface.NativeFieldInfoPtr_DumpsessionstateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (DumpsessionstateApiLatest));
      SessionsInterface.NativeFieldInfoPtr_EndsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (EndsessionApiLatest));
      SessionsInterface.NativeFieldInfoPtr_GetinvitecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (GetinvitecountApiLatest));
      SessionsInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (GetinviteidbyindexApiLatest));
      SessionsInterface.NativeFieldInfoPtr_InviteidMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (InviteidMaxLength));
      SessionsInterface.NativeFieldInfoPtr_IsuserinsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (IsuserinsessionApiLatest));
      SessionsInterface.NativeFieldInfoPtr_JoinsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (JoinsessionApiLatest));
      SessionsInterface.NativeFieldInfoPtr_MaxSearchResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (MaxSearchResults));
      SessionsInterface.NativeFieldInfoPtr_Maxregisteredplayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (Maxregisteredplayers));
      SessionsInterface.NativeFieldInfoPtr_QueryinvitesApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (QueryinvitesApiLatest));
      SessionsInterface.NativeFieldInfoPtr_RegisterplayersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (RegisterplayersApiLatest));
      SessionsInterface.NativeFieldInfoPtr_RejectinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (RejectinviteApiLatest));
      SessionsInterface.NativeFieldInfoPtr_SearchBucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SearchBucketId));
      SessionsInterface.NativeFieldInfoPtr_SearchEmptyServersOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SearchEmptyServersOnly));
      SessionsInterface.NativeFieldInfoPtr_SearchMinslotsavailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SearchMinslotsavailable));
      SessionsInterface.NativeFieldInfoPtr_SearchNonemptyServersOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SearchNonemptyServersOnly));
      SessionsInterface.NativeFieldInfoPtr_SendinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SendinviteApiLatest));
      SessionsInterface.NativeFieldInfoPtr_SessionattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SessionattributeApiLatest));
      SessionsInterface.NativeFieldInfoPtr_SessionattributedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SessionattributedataApiLatest));
      SessionsInterface.NativeFieldInfoPtr_StartsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (StartsessionApiLatest));
      SessionsInterface.NativeFieldInfoPtr_UnregisterplayersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (UnregisterplayersApiLatest));
      SessionsInterface.NativeFieldInfoPtr_UpdatesessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (UpdatesessionApiLatest));
      SessionsInterface.NativeFieldInfoPtr_UpdatesessionmodificationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (UpdatesessionmodificationApiLatest));
      SessionsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666611);
      SessionsInterface.NativeMethodInfoPtr_AddNotifyJoinSessionAccepted_Public_UInt64_byref_AddNotifyJoinSessionAcceptedOptions_Object_OnJoinSessionAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666613);
      SessionsInterface.NativeMethodInfoPtr_AddNotifySessionInviteAccepted_Public_UInt64_byref_AddNotifySessionInviteAcceptedOptions_Object_OnSessionInviteAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666614);
      SessionsInterface.NativeMethodInfoPtr_AddNotifySessionInviteReceived_Public_UInt64_byref_AddNotifySessionInviteReceivedOptions_Object_OnSessionInviteReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666615);
      SessionsInterface.NativeMethodInfoPtr_CopyActiveSessionHandle_Public_Result_byref_CopyActiveSessionHandleOptions_byref_ActiveSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666616);
      SessionsInterface.NativeMethodInfoPtr_CopySessionHandleByInviteId_Public_Result_byref_CopySessionHandleByInviteIdOptions_byref_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666617);
      SessionsInterface.NativeMethodInfoPtr_CopySessionHandleByUiEventId_Public_Result_byref_CopySessionHandleByUiEventIdOptions_byref_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666618);
      SessionsInterface.NativeMethodInfoPtr_CopySessionHandleForPresence_Public_Result_byref_CopySessionHandleForPresenceOptions_byref_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666619);
      SessionsInterface.NativeMethodInfoPtr_CreateSessionModification_Public_Result_byref_CreateSessionModificationOptions_byref_SessionModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666620);
      SessionsInterface.NativeMethodInfoPtr_CreateSessionSearch_Public_Result_byref_CreateSessionSearchOptions_byref_SessionSearch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666621);
      SessionsInterface.NativeMethodInfoPtr_DestroySession_Public_Void_byref_DestroySessionOptions_Object_OnDestroySessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666622);
      SessionsInterface.NativeMethodInfoPtr_DumpSessionState_Public_Result_byref_DumpSessionStateOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666623);
      SessionsInterface.NativeMethodInfoPtr_EndSession_Public_Void_byref_EndSessionOptions_Object_OnEndSessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666624);
      SessionsInterface.NativeMethodInfoPtr_GetInviteCount_Public_UInt32_byref_GetInviteCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666625);
      SessionsInterface.NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_byref_GetInviteIdByIndexOptions_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666626);
      SessionsInterface.NativeMethodInfoPtr_IsUserInSession_Public_Result_byref_IsUserInSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666627);
      SessionsInterface.NativeMethodInfoPtr_JoinSession_Public_Void_byref_JoinSessionOptions_Object_OnJoinSessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666628);
      SessionsInterface.NativeMethodInfoPtr_QueryInvites_Public_Void_byref_QueryInvitesOptions_Object_OnQueryInvitesCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666629);
      SessionsInterface.NativeMethodInfoPtr_RegisterPlayers_Public_Void_byref_RegisterPlayersOptions_Object_OnRegisterPlayersCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666630);
      SessionsInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666631);
      SessionsInterface.NativeMethodInfoPtr_RemoveNotifyJoinSessionAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666632);
      SessionsInterface.NativeMethodInfoPtr_RemoveNotifySessionInviteAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666633);
      SessionsInterface.NativeMethodInfoPtr_RemoveNotifySessionInviteReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666634);
      SessionsInterface.NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666635);
      SessionsInterface.NativeMethodInfoPtr_StartSession_Public_Void_byref_StartSessionOptions_Object_OnStartSessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666636);
      SessionsInterface.NativeMethodInfoPtr_UnregisterPlayers_Public_Void_byref_UnregisterPlayersOptions_Object_OnUnregisterPlayersCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666637);
      SessionsInterface.NativeMethodInfoPtr_UpdateSession_Public_Void_byref_UpdateSessionOptions_Object_OnUpdateSessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666638);
      SessionsInterface.NativeMethodInfoPtr_UpdateSessionModification_Public_Result_byref_UpdateSessionModificationOptions_byref_SessionModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666639);
      SessionsInterface.NativeMethodInfoPtr_OnDestroySessionCallbackInternalImplementation_Internal_Static_Void_byref_DestroySessionCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666640);
      SessionsInterface.NativeMethodInfoPtr_OnEndSessionCallbackInternalImplementation_Internal_Static_Void_byref_EndSessionCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666641);
      SessionsInterface.NativeMethodInfoPtr_OnJoinSessionAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinSessionAcceptedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666642);
      SessionsInterface.NativeMethodInfoPtr_OnJoinSessionCallbackInternalImplementation_Internal_Static_Void_byref_JoinSessionCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666643);
      SessionsInterface.NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_byref_QueryInvitesCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666644);
      SessionsInterface.NativeMethodInfoPtr_OnRegisterPlayersCallbackInternalImplementation_Internal_Static_Void_byref_RegisterPlayersCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666645);
      SessionsInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666646);
      SessionsInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666647);
      SessionsInterface.NativeMethodInfoPtr_OnSessionInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_SessionInviteAcceptedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666648);
      SessionsInterface.NativeMethodInfoPtr_OnSessionInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_SessionInviteReceivedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666649);
      SessionsInterface.NativeMethodInfoPtr_OnStartSessionCallbackInternalImplementation_Internal_Static_Void_byref_StartSessionCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666650);
      SessionsInterface.NativeMethodInfoPtr_OnUnregisterPlayersCallbackInternalImplementation_Internal_Static_Void_byref_UnregisterPlayersCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666651);
      SessionsInterface.NativeMethodInfoPtr_OnUpdateSessionCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSessionCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666652);
    }

    public SessionsInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifyjoinsessionacceptedApiLatest
    {
      get
      {
        int addnotifyjoinsessionacceptedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_AddnotifyjoinsessionacceptedApiLatest, (void*) &addnotifyjoinsessionacceptedApiLatest);
        return addnotifyjoinsessionacceptedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_AddnotifyjoinsessionacceptedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifysessioninviteacceptedApiLatest
    {
      get
      {
        int addnotifysessioninviteacceptedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninviteacceptedApiLatest, (void*) &addnotifysessioninviteacceptedApiLatest);
        return addnotifysessioninviteacceptedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninviteacceptedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifysessioninvitereceivedApiLatest
    {
      get
      {
        int addnotifysessioninvitereceivedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninvitereceivedApiLatest, (void*) &addnotifysessioninvitereceivedApiLatest);
        return addnotifysessioninvitereceivedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninvitereceivedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AttributedataApiLatest
    {
      get
      {
        int attributedataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_AttributedataApiLatest, (void*) &attributedataApiLatest);
        return attributedataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_AttributedataApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyactivesessionhandleApiLatest
    {
      get
      {
        int copyactivesessionhandleApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CopyactivesessionhandleApiLatest, (void*) &copyactivesessionhandleApiLatest);
        return copyactivesessionhandleApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CopyactivesessionhandleApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopysessionhandlebyinviteidApiLatest
    {
      get
      {
        int copysessionhandlebyinviteidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyinviteidApiLatest, (void*) &copysessionhandlebyinviteidApiLatest);
        return copysessionhandlebyinviteidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyinviteidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopysessionhandlebyuieventidApiLatest
    {
      get
      {
        int copysessionhandlebyuieventidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyuieventidApiLatest, (void*) &copysessionhandlebyuieventidApiLatest);
        return copysessionhandlebyuieventidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyuieventidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopysessionhandleforpresenceApiLatest
    {
      get
      {
        int copysessionhandleforpresenceApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandleforpresenceApiLatest, (void*) &copysessionhandleforpresenceApiLatest);
        return copysessionhandleforpresenceApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandleforpresenceApiLatest, (void*) &value);
      }
    }

    public static unsafe int CreatesessionmodificationApiLatest
    {
      get
      {
        int createsessionmodificationApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CreatesessionmodificationApiLatest, (void*) &createsessionmodificationApiLatest);
        return createsessionmodificationApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CreatesessionmodificationApiLatest, (void*) &value);
      }
    }

    public static unsafe int CreatesessionsearchApiLatest
    {
      get
      {
        int createsessionsearchApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CreatesessionsearchApiLatest, (void*) &createsessionsearchApiLatest);
        return createsessionsearchApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CreatesessionsearchApiLatest, (void*) &value);
      }
    }

    public static unsafe int DestroysessionApiLatest
    {
      get
      {
        int destroysessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_DestroysessionApiLatest, (void*) &destroysessionApiLatest);
        return destroysessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_DestroysessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int DumpsessionstateApiLatest
    {
      get
      {
        int dumpsessionstateApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_DumpsessionstateApiLatest, (void*) &dumpsessionstateApiLatest);
        return dumpsessionstateApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_DumpsessionstateApiLatest, (void*) &value);
      }
    }

    public static unsafe int EndsessionApiLatest
    {
      get
      {
        int endsessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &endsessionApiLatest);
        return endsessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetinvitecountApiLatest
    {
      get
      {
        int getinvitecountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_GetinvitecountApiLatest, (void*) &getinvitecountApiLatest);
        return getinvitecountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_GetinvitecountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetinviteidbyindexApiLatest
    {
      get
      {
        int getinviteidbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest, (void*) &getinviteidbyindexApiLatest);
        return getinviteidbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int InviteidMaxLength
    {
      get
      {
        int inviteidMaxLength;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_InviteidMaxLength, (void*) &inviteidMaxLength);
        return inviteidMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_InviteidMaxLength, (void*) &value);
      }
    }

    public static unsafe int IsuserinsessionApiLatest
    {
      get
      {
        int isuserinsessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_IsuserinsessionApiLatest, (void*) &isuserinsessionApiLatest);
        return isuserinsessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_IsuserinsessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int JoinsessionApiLatest
    {
      get
      {
        int joinsessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_JoinsessionApiLatest, (void*) &joinsessionApiLatest);
        return joinsessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_JoinsessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int MaxSearchResults
    {
      get
      {
        int maxSearchResults;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_MaxSearchResults, (void*) &maxSearchResults);
        return maxSearchResults;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_MaxSearchResults, (void*) &value);
      }
    }

    public static unsafe int Maxregisteredplayers
    {
      get
      {
        int maxregisteredplayers;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_Maxregisteredplayers, (void*) &maxregisteredplayers);
        return maxregisteredplayers;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_Maxregisteredplayers, (void*) &value);
      }
    }

    public static unsafe int QueryinvitesApiLatest
    {
      get
      {
        int queryinvitesApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_QueryinvitesApiLatest, (void*) &queryinvitesApiLatest);
        return queryinvitesApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_QueryinvitesApiLatest, (void*) &value);
      }
    }

    public static unsafe int RegisterplayersApiLatest
    {
      get
      {
        int registerplayersApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_RegisterplayersApiLatest, (void*) &registerplayersApiLatest);
        return registerplayersApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_RegisterplayersApiLatest, (void*) &value);
      }
    }

    public static unsafe int RejectinviteApiLatest
    {
      get
      {
        int rejectinviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &rejectinviteApiLatest);
        return rejectinviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &value);
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String SearchBucketId
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SearchBucketId, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SearchBucketId, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String SearchEmptyServersOnly
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SearchEmptyServersOnly, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SearchEmptyServersOnly, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String SearchMinslotsavailable
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SearchMinslotsavailable, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SearchMinslotsavailable, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String SearchNonemptyServersOnly
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SearchNonemptyServersOnly, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SearchNonemptyServersOnly, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int SendinviteApiLatest
    {
      get
      {
        int sendinviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &sendinviteApiLatest);
        return sendinviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionattributeApiLatest
    {
      get
      {
        int sessionattributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SessionattributeApiLatest, (void*) &sessionattributeApiLatest);
        return sessionattributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SessionattributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionattributedataApiLatest
    {
      get
      {
        int sessionattributedataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SessionattributedataApiLatest, (void*) &sessionattributedataApiLatest);
        return sessionattributedataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SessionattributedataApiLatest, (void*) &value);
      }
    }

    public static unsafe int StartsessionApiLatest
    {
      get
      {
        int startsessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_StartsessionApiLatest, (void*) &startsessionApiLatest);
        return startsessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_StartsessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int UnregisterplayersApiLatest
    {
      get
      {
        int unregisterplayersApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_UnregisterplayersApiLatest, (void*) &unregisterplayersApiLatest);
        return unregisterplayersApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_UnregisterplayersApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatesessionApiLatest
    {
      get
      {
        int updatesessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_UpdatesessionApiLatest, (void*) &updatesessionApiLatest);
        return updatesessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_UpdatesessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatesessionmodificationApiLatest
    {
      get
      {
        int updatesessionmodificationApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_UpdatesessionmodificationApiLatest, (void*) &updatesessionmodificationApiLatest);
        return updatesessionmodificationApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_UpdatesessionmodificationApiLatest, (void*) &value);
      }
    }
  }
}
