// Decompiled with JetBrains decompiler
// Type: ProjectM.Auth.SteamPlatformSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using ProjectM.Network;
using ProjectM.Shared;
using Steamworks;
using Stunlock.Network;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine.Networking;

#nullable disable
namespace ProjectM.Auth
{
  public class SteamPlatformSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_STEAM_LOG_LEVEL;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitState;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitDone;
    private static readonly System.IntPtr NativeFieldInfoPtr__AppID;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserID;
    private static readonly System.IntPtr NativeFieldInfoPtr__AuthSessionTicket;
    private static readonly System.IntPtr NativeFieldInfoPtr__AppTicketDownloadBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__PcbTicketSize;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsClient;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsServer;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientInitSuccess;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerInitSuccess;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkingInitSuccess;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerPolicyResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__GetAuthSessionTicketResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__ValidateAuthTicketResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnGameRichPresenceJoinRequested;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnGetAuthSessionTicketResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__CallbackSteamServersConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr__CallbackSteamServersDisconnected;
    private static readonly System.IntPtr NativeFieldInfoPtr__CallbackPolicyResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewUrlLaunchParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnEncryptedAppTicketResponseCallResult;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnAuthSessionResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnNewLaunchParamsReceived;
    private static readonly System.IntPtr NativeFieldInfoPtr_APP_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_APP_ID_SERVER;
    private static readonly System.IntPtr NativeFieldInfoPtr__AuthTicketHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__SteamServerConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr__BranchName;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerSettingsSerializationNetBufferData;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerListResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayersResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__RulesResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerLANMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForAuthSessionTicket;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForAuthSessionTicketStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_WAIT_FOR_AUTHTICKET_DURATION;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerInfoListRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr__OfficialServers;
    private static readonly System.IntPtr NativeFieldInfoPtr__TrustedServers;
    private static readonly System.IntPtr NativeFieldInfoPtr__BannedServers;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextServerInfoRequestTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerInfoRequestFailCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnServerResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnRefreshComplete;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnLANRefreshComplete;
    private static readonly System.IntPtr NativeFieldInfoPtr__InternetRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr__LANRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr__QueuedPings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActivePings;
    private static readonly System.IntPtr NativeFieldInfoPtr__PingHandles;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxActivePings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerRulesHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnRulesResponded;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnRulesRefreshedCompleted;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnRulesFailedToRespond;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InitState_Public_get_PlatformInitState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserID_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AuthSessionTicket_Public_get_Il2CppStructArray_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerReady_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_OnAuthSessionResponse_Public_add_Void_OnAuthSessionResponseDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnAuthSessionResponse_Public_rem_Void_OnAuthSessionResponseDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_OnNewLaunchParamsReceived_Public_add_Void_OnNewLaunchParamsReceivedDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnNewLaunchParamsReceived_Public_rem_Void_OnNewLaunchParamsReceivedDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LogHeader_Private_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsServerLANMode_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAuthenticating_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSystem_Public_Static_SteamPlatformSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitSocketNetworking_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsClientLoggedOn_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateServerInfoList_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitServer_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitClient_Private_Boolean_byref_PlatformInitState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnNewURLLaunchParameter_Private_Void_NewUrlLaunchParameters_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNotificationPosition_Private_ENotificationPosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnGetAuthSessionTicketResponse_Private_Void_GetAuthSessionTicketResponse_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnGameRichPresenceJoinRequested_Private_Void_GameRichPresenceJoinRequested_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInitResult_Public_Boolean_byref_PlatformInitState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEncryptedAppTicket_Public_Void_Action_2_Il2CppStructArray_1_Byte_PlatformError_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAuthSessionTicket_Public_Void_Boolean_Action_4_Boolean_EResult_Il2CppStructArray_1_Byte_CSteamID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginAuthSession_Public_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_UInt16_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnValidateAuthTicketResponse_Private_Void_ValidateAuthTicketResponse_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckUserContent_Public_Void_UInt64_byref_UserContentFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAuthSessionResponseEnum_Private_AuthSessionResponseEnum_EAuthSessionResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckLicenseSetFlag_Private_Void_byref_UserContentFlags_CSteamID_UInt32_UserContentFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSteamServersConnected_Private_Void_SteamServersConnected_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSteamServersConnectFailure_Private_Void_SteamServerConnectFailure_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSteamServersDisconnected_Private_Void_SteamServersDisconnected_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPolicyResponse_Private_Void_GSPolicyResponse_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUser_Public_Boolean_UInt64_String_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetServerData_Public_Void_MatchmakingServerData_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetServerGameSettingsHash_Private_Void_ServerGameSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetServerSettings_Public_Void_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetServerDescription_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugStartHeartbeat_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelAuthTicket_Public_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndAuthSession_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPersonaName_Public_Boolean_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPlatformId_Public_Boolean_byref_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RequestInternetServerList_Public_HServerListRequest_RequestServerListOptions_Action_1_ServerListEntryData_Action_1_EMatchMakingServerResponse_InternetServerRequestType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RequestLANServerList_Public_HServerListRequest_Action_1_ServerListEntryData_Action_1_EMatchMakingServerResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelServerListRequest_Public_Void_HServerListRequest_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRefreshing_Public_Boolean_HServerListRequest_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendSessions_Public_Void_byref_List_1_FriendSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendServers_Public_Void_Action_1_Nullable_1_ServerListEntryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPublicIP_Public_IPAddress_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseCommandLine_Public_Static_CommandLineData_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentActivePings_Private_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PingServer_Public_PingHandle_UInt32_UInt16_Action_1_Nullable_1_ServerListEntryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelPing_Public_Void_PingHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelAllPings_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GameServerItemToListEntryData_Private_ServerListEntryData_gameserveritem_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsOfficial_Public_Boolean_String_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsTrusted_Public_Boolean_String_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBanned_Public_Boolean_String_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnServerResponded_Public_Void_HServerListRequest_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GameModeFromTags_Public_Static_GameModeType_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ServerActivityLevelFromTags_Public_Static_ServerActivityLevel_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnServerFailedToRespond_Private_Void_HServerListRequest_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRefreshComplete_Private_Void_HServerListRequest_EMatchMakingServerResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServerRules_Public_Void_UInt32_UInt16_Action_2_String_String_Action_Action_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelServerRules_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnServerResponded_Private_Void_gameserveritem_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnServerFailedToRespond_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAddPlayerToList_Private_Void_String_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayersFailedToRespond_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayersRefreshComplete_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearAuthSessionEvent_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryReadCloudFile_Public_Boolean_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryWriteCloudFile_Public_Boolean_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDeleteCloudFile_Public_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAppPurchaseTimeUTC_Public_DateTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_PingAddress_HServerQuery_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_PingAddress_HServerQuery_gameserveritem_t_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe PlatformInitState InitState
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_get_InitState_Public_get_PlatformInitState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlatformInitState*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ulong UserID
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1137228, RefRangeEnd = 1137230, XrefRangeStart = 1137228, XrefRangeEnd = 1137228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_get_UserID_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Il2CppStructArray<byte> AuthSessionTicket
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_get_AuthSessionTicket_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
    }

    public unsafe bool ServerReady
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1137230, RefRangeEnd = 1137231, XrefRangeStart = 1137230, XrefRangeEnd = 1137230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_get_ServerReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137235, RefRangeEnd = 1137236, XrefRangeStart = 1137231, XrefRangeEnd = 1137235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_OnAuthSessionResponse(
      SteamPlatformSystem.OnAuthSessionResponseDelegate value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_add_OnAuthSessionResponse_Public_add_Void_OnAuthSessionResponseDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137240, RefRangeEnd = 1137241, XrefRangeStart = 1137236, XrefRangeEnd = 1137240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_OnAuthSessionResponse(
      SteamPlatformSystem.OnAuthSessionResponseDelegate value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_remove_OnAuthSessionResponse_Public_rem_Void_OnAuthSessionResponseDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137245, RefRangeEnd = 1137246, XrefRangeStart = 1137241, XrefRangeEnd = 1137245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_OnNewLaunchParamsReceived(
      SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_add_OnNewLaunchParamsReceived_Public_add_Void_OnNewLaunchParamsReceivedDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137250, RefRangeEnd = 1137251, XrefRangeStart = 1137246, XrefRangeEnd = 1137250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_OnNewLaunchParamsReceived(
      SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_remove_OnNewLaunchParamsReceived_Public_rem_Void_OnNewLaunchParamsReceivedDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe string LogHeader
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 1137253, RefRangeEnd = 1137256, XrefRangeStart = 1137251, XrefRangeEnd = 1137253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_get_LogHeader_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe bool IsServerLANMode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_get_IsServerLANMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsAuthenticating
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_get_IsAuthenticating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1137260, RefRangeEnd = 1137272, XrefRangeStart = 1137256, XrefRangeEnd = 1137260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SteamPlatformSystem GetSystem()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetSystem_Public_Static_SteamPlatformSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137272, XrefRangeEnd = 1137312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamPlatformSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137312, XrefRangeEnd = 1137330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInitSocketNetworking()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryInitSocketNetworking_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137330, XrefRangeEnd = 1137346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamPlatformSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1137347, RefRangeEnd = 1137350, XrefRangeStart = 1137346, XrefRangeEnd = 1137347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsClientLoggedOn()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_IsClientLoggedOn_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamPlatformSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137350, XrefRangeEnd = 1137360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamPlatformSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137505, RefRangeEnd = 1137506, XrefRangeStart = 1137360, XrefRangeEnd = 1137505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateServerInfoList()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_UpdateServerInfoList_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137616, RefRangeEnd = 1137617, XrefRangeStart = 1137506, XrefRangeEnd = 1137616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInitServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryInitServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137806, RefRangeEnd = 1137807, XrefRangeStart = 1137617, XrefRangeEnd = 1137806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInitClient(out PlatformInitState initState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref initState;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryInitClient_Private_Boolean_byref_PlatformInitState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137807, XrefRangeEnd = 1137810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnNewURLLaunchParameter(NewUrlLaunchParameters_t param)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &param;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnNewURLLaunchParameter_Private_Void_NewUrlLaunchParameters_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137810, XrefRangeEnd = 1137811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ENotificationPosition GetNotificationPosition()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetNotificationPosition_Private_ENotificationPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ENotificationPosition*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137811, XrefRangeEnd = 1137837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnGetAuthSessionTicketResponse(GetAuthSessionTicketResponse_t param)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &param;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnGetAuthSessionTicketResponse_Private_Void_GetAuthSessionTicketResponse_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137837, XrefRangeEnd = 1137867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnGameRichPresenceJoinRequested(GameRichPresenceJoinRequested_t param)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) param));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnGameRichPresenceJoinRequested_Private_Void_GameRichPresenceJoinRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1137867, RefRangeEnd = 1137878, XrefRangeStart = 1137867, XrefRangeEnd = 1137867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetInitResult(out PlatformInitState initState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref initState;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryGetInitResult_Public_Boolean_byref_PlatformInitState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137897, RefRangeEnd = 1137898, XrefRangeStart = 1137878, XrefRangeEnd = 1137897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetEncryptedAppTicket(
      Il2CppSystem.Action<Il2CppStructArray<byte>, SteamPlatformSystem.PlatformError> callback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetEncryptedAppTicket_Public_Void_Action_2_Il2CppStructArray_1_Byte_PlatformError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137931, RefRangeEnd = 1137932, XrefRangeStart = 1137898, XrefRangeEnd = 1137931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetAuthSessionTicket(
      bool isLAN,
      Il2CppSystem.Action<bool, EResult, Il2CppStructArray<byte>, CSteamID> onGetAuthSessionTicketResponse)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &isLAN;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onGetAuthSessionTicketResponse);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Void_Boolean_Action_4_Boolean_EResult_Il2CppStructArray_1_Byte_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1137962, RefRangeEnd = 1137964, XrefRangeStart = 1137932, XrefRangeEnd = 1137962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EBeginAuthSessionResult BeginAuthSession(
      Il2CppStructArray<byte> pAuthTicket,
      ushort size,
      ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pAuthTicket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &platformId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_BeginAuthSession_Public_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_UInt16_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EBeginAuthSessionResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137964, XrefRangeEnd = 1138042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValidateAuthTicketResponse(ValidateAuthTicketResponse_t param)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &param;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnValidateAuthTicketResponse_Private_Void_ValidateAuthTicketResponse_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138048, RefRangeEnd = 1138049, XrefRangeStart = 1138042, XrefRangeEnd = 1138048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckUserContent(ulong platformId, ref UserContentFlags userContent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &platformId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref userContent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_CheckUserContent_Public_Void_UInt64_byref_UserContentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe AuthSessionResponseEnum GetAuthSessionResponseEnum(
      EAuthSessionResponse eAuthSessionResponse)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &eAuthSessionResponse;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetAuthSessionResponseEnum_Private_AuthSessionResponseEnum_EAuthSessionResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AuthSessionResponseEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138049, XrefRangeEnd = 1138050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckLicenseSetFlag(
      ref UserContentFlags userContent,
      CSteamID userSteamID,
      uint appId,
      UserContentFlags userContentFlag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref userContent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userSteamID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &appId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &userContentFlag;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_CheckLicenseSetFlag_Private_Void_byref_UserContentFlags_CSteamID_UInt32_UserContentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138050, XrefRangeEnd = 1138059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnSteamServersConnected(SteamServersConnected_t param)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &param;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnSteamServersConnected_Private_Void_SteamServersConnected_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138059, XrefRangeEnd = 1138068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnSteamServersConnectFailure(SteamServerConnectFailure_t pConnectFailure)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pConnectFailure;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnSteamServersConnectFailure_Private_Void_SteamServerConnectFailure_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138068, XrefRangeEnd = 1138077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnSteamServersDisconnected(SteamServersDisconnected_t pLoggedOff)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pLoggedOff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnSteamServersDisconnected_Private_Void_SteamServersDisconnected_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138077, XrefRangeEnd = 1138118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnPolicyResponse(GSPolicyResponse_t param)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &param;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnPolicyResponse_Private_Void_GSPolicyResponse_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138119, RefRangeEnd = 1138120, XrefRangeStart = 1138118, XrefRangeEnd = 1138119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool UpdateUser(ulong platformId, string name, uint score)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &platformId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &score;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_UpdateUser_Public_Boolean_UInt64_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138202, RefRangeEnd = 1138203, XrefRangeStart = 1138120, XrefRangeEnd = 1138202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetServerData(
      ServerBootstrapSystem.MatchmakingServerData serverInitializeData,
      bool init,
      bool isDedicated)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) serverInitializeData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &init;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isDedicated;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_SetServerData_Public_Void_MatchmakingServerData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138203, XrefRangeEnd = 1138207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetServerGameSettingsHash(ServerGameSettings settings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_SetServerGameSettingsHash_Private_Void_ServerGameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138234, RefRangeEnd = 1138235, XrefRangeStart = 1138207, XrefRangeEnd = 1138234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetServerSettings(ServerGameBalanceSettings settings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &settings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_SetServerSettings_Public_Void_ServerGameBalanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1138247, RefRangeEnd = 1138249, XrefRangeStart = 1138235, XrefRangeEnd = 1138247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetServerDescription(string description)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(description);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_SetServerDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138249, XrefRangeEnd = 1138326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DebugStartHeartbeat()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_DebugStartHeartbeat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138326, XrefRangeEnd = 1138336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CancelAuthTicket(uint authTicket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &authTicket;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_CancelAuthTicket_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1138351, RefRangeEnd = 1138353, XrefRangeStart = 1138336, XrefRangeEnd = 1138351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndAuthSession(ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &platformId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_EndAuthSession_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138355, RefRangeEnd = 1138356, XrefRangeStart = 1138353, XrefRangeEnd = 1138355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPersonaName(out string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryGetPersonaName_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      name = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1138356, RefRangeEnd = 1138367, XrefRangeStart = 1138356, XrefRangeEnd = 1138356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPlatformId(out ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref platformId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryGetPlatformId_Public_Boolean_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138367, XrefRangeEnd = 1138500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HServerListRequest RequestInternetServerList(
      SteamPlatformSystem.RequestServerListOptions options,
      Il2CppSystem.Action<ServerListEntryData> onServerResponse,
      Il2CppSystem.Action<EMatchMakingServerResponse> onRefreshComplete,
      SteamPlatformSystem.InternetServerRequestType requestType = SteamPlatformSystem.InternetServerRequestType.Default)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onServerResponse);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onRefreshComplete);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &requestType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_RequestInternetServerList_Public_HServerListRequest_RequestServerListOptions_Action_1_ServerListEntryData_Action_1_EMatchMakingServerResponse_InternetServerRequestType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(HServerListRequest*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138500, XrefRangeEnd = 1138517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HServerListRequest RequestLANServerList(
      Il2CppSystem.Action<ServerListEntryData> onServerResponse,
      Il2CppSystem.Action<EMatchMakingServerResponse> onRefreshComplete)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onServerResponse);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onRefreshComplete);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_RequestLANServerList_Public_HServerListRequest_Action_1_ServerListEntryData_Action_1_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(HServerListRequest*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1138523, RefRangeEnd = 1138525, XrefRangeStart = 1138517, XrefRangeEnd = 1138523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CancelServerListRequest(HServerListRequest hServerListRequest)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hServerListRequest;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_CancelServerListRequest_Public_Void_HServerListRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1138531, RefRangeEnd = 1138536, XrefRangeStart = 1138525, XrefRangeEnd = 1138531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsRefreshing(HServerListRequest hServerListRequest)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hServerListRequest;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_IsRefreshing_Public_Boolean_HServerListRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138536, XrefRangeEnd = 1138551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetFriendSessions(ref List<FriendSession> output)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) output);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetFriendSessions_Public_Void_byref_List_1_FriendSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<FriendSession> local = ref output;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<FriendSession>) list;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138573, RefRangeEnd = 1138574, XrefRangeStart = 1138551, XrefRangeEnd = 1138573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetFriendServers(
      Il2CppSystem.Action<Il2CppSystem.Nullable<ServerListEntryData>> onPingComplete)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onPingComplete);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetFriendServers_Public_Void_Action_1_Nullable_1_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1138577, RefRangeEnd = 1138579, XrefRangeStart = 1138574, XrefRangeEnd = 1138577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IPAddress GetPublicIP()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetPublicIP_Public_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IPAddress) null : new IPAddress(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1138641, RefRangeEnd = 1138644, XrefRangeStart = 1138579, XrefRangeEnd = 1138641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SteamPlatformSystem.CommandLineData ParseCommandLine(string commandLine)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(commandLine);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_ParseCommandLine_Public_Static_CommandLineData_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SteamPlatformSystem.CommandLineData*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe int CurrentActivePings
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1138660, RefRangeEnd = 1138661, XrefRangeStart = 1138644, XrefRangeEnd = 1138660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_get_CurrentActivePings_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1138710, RefRangeEnd = 1138712, XrefRangeStart = 1138661, XrefRangeEnd = 1138710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SteamPlatformSystem.PingHandle PingServer(
      uint ip,
      ushort port,
      Il2CppSystem.Action<Il2CppSystem.Nullable<ServerListEntryData>> onPingComplete)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &ip;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onPingComplete);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_PingServer_Public_PingHandle_UInt32_UInt16_Action_1_Nullable_1_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SteamPlatformSystem.PingHandle) null : new SteamPlatformSystem.PingHandle(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138727, RefRangeEnd = 1138728, XrefRangeStart = 1138712, XrefRangeEnd = 1138727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CancelPing(SteamPlatformSystem.PingHandle handle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) handle);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_CancelPing_Public_Void_PingHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138728, XrefRangeEnd = 1138738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CancelAllPings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_CancelAllPings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1138853, RefRangeEnd = 1138855, XrefRangeStart = 1138738, XrefRangeEnd = 1138853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerListEntryData GameServerItemToListEntryData(gameserveritem_t server)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) server);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GameServerItemToListEntryData_Private_ServerListEntryData_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new ServerListEntryData(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138865, RefRangeEnd = 1138866, XrefRangeStart = 1138855, XrefRangeEnd = 1138865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsOfficial(string ip, ushort port)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(ip);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_IsOfficial_Public_Boolean_String_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138876, RefRangeEnd = 1138877, XrefRangeStart = 1138866, XrefRangeEnd = 1138876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsTrusted(string ip, ushort port)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(ip);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_IsTrusted_Public_Boolean_String_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138893, RefRangeEnd = 1138894, XrefRangeStart = 1138877, XrefRangeEnd = 1138893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsBanned(string ip, ushort port)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(ip);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_IsBanned_Public_Boolean_String_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138894, XrefRangeEnd = 1138983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnServerResponded(HServerListRequest hRequest, int iServer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &hRequest;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &iServer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnServerResponded_Public_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1138992, RefRangeEnd = 1138993, XrefRangeStart = 1138983, XrefRangeEnd = 1138992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameModeType GameModeFromTags(List<string> tags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tags);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GameModeFromTags_Public_Static_GameModeType_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameModeType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1139002, RefRangeEnd = 1139003, XrefRangeStart = 1138993, XrefRangeEnd = 1139002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ServerActivityLevel ServerActivityLevelFromTags(List<string> tags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tags);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_ServerActivityLevelFromTags_Public_Static_ServerActivityLevel_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerActivityLevel*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139003, XrefRangeEnd = 1139044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnServerFailedToRespond(HServerListRequest hRequest, int iServer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &hRequest;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &iServer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnServerFailedToRespond_Private_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139044, XrefRangeEnd = 1139091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRefreshComplete(
      HServerListRequest hRequest,
      EMatchMakingServerResponse response)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &hRequest;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &response;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnRefreshComplete_Private_Void_HServerListRequest_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1139096, RefRangeEnd = 1139098, XrefRangeStart = 1139091, XrefRangeEnd = 1139096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetServerRules(
      uint ip,
      ushort port,
      Il2CppSystem.Action<string, string> onRulesResponded,
      Il2CppSystem.Action onRulesFailedToRespond,
      Il2CppSystem.Action onRulesRefreshComplete)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &ip;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onRulesResponded);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onRulesFailedToRespond);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onRulesRefreshComplete);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetServerRules_Public_Void_UInt32_UInt16_Action_2_String_String_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139098, XrefRangeEnd = 1139107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CancelServerRules()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_CancelServerRules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnServerResponded(gameserveritem_t server)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) server);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnServerResponded_Private_Void_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnServerFailedToRespond()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnServerFailedToRespond_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAddPlayerToList(string pchName, int nScore, float flTimePlayed)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pchName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nScore;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flTimePlayed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnAddPlayerToList_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnPlayersFailedToRespond()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnPlayersFailedToRespond_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnPlayersRefreshComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnPlayersRefreshComplete_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139107, XrefRangeEnd = 1139109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesRefreshComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139109, XrefRangeEnd = 1139112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesResponded(string pchRule, string pchValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pchRule);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(pchValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139112, XrefRangeEnd = 1139114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesFailedToRespond()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1139115, RefRangeEnd = 1139116, XrefRangeStart = 1139114, XrefRangeEnd = 1139115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearAuthSessionEvent()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_ClearAuthSessionEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1139126, RefRangeEnd = 1139129, XrefRangeStart = 1139116, XrefRangeEnd = 1139126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryReadCloudFile(string filePath, out string content)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(filePath);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryReadCloudFile_Public_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      content = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1139134, RefRangeEnd = 1139137, XrefRangeStart = 1139129, XrefRangeEnd = 1139134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryWriteCloudFile(string filePath, string content)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(filePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(content);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryWriteCloudFile_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1139141, RefRangeEnd = 1139142, XrefRangeStart = 1139137, XrefRangeEnd = 1139141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryDeleteCloudFile(string filePath)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(filePath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_TryDeleteCloudFile_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1139147, RefRangeEnd = 1139149, XrefRangeStart = 1139142, XrefRangeEnd = 1139147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.DateTime GetAppPurchaseTimeUTC()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_GetAppPurchaseTimeUTC_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139149, XrefRangeEnd = 1139175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SteamPlatformSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1139198, RefRangeEnd = 1139201, XrefRangeStart = 1139175, XrefRangeEnd = 1139198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1139233, RefRangeEnd = 1139234, XrefRangeStart = 1139201, XrefRangeEnd = 1139233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_PingAddress_HServerQuery_0(
      SteamPlatformSystem.PingAddress address,
      HServerQuery query)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &address;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_PingAddress_HServerQuery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1139273, RefRangeEnd = 1139274, XrefRangeStart = 1139234, XrefRangeEnd = 1139273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_PingAddress_HServerQuery_gameserveritem_t_0(
      SteamPlatformSystem.PingAddress address,
      HServerQuery query,
      gameserveritem_t server)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &address;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) server);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_PingAddress_HServerQuery_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamPlatformSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SteamPlatformSystem()
    {
      Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Auth", nameof (SteamPlatformSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr);
      SteamPlatformSystem.NativeFieldInfoPtr_STEAM_LOG_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (STEAM_LOG_LEVEL));
      SteamPlatformSystem.NativeFieldInfoPtr__InitState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_InitState));
      SteamPlatformSystem.NativeFieldInfoPtr__InitDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_InitDone));
      SteamPlatformSystem.NativeFieldInfoPtr__AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_AppID));
      SteamPlatformSystem.NativeFieldInfoPtr__UserID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_UserID));
      SteamPlatformSystem.NativeFieldInfoPtr__AuthSessionTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_AuthSessionTicket));
      SteamPlatformSystem.NativeFieldInfoPtr__AppTicketDownloadBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_AppTicketDownloadBuffer));
      SteamPlatformSystem.NativeFieldInfoPtr__PcbTicketSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_PcbTicketSize));
      SteamPlatformSystem.NativeFieldInfoPtr__IsClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_IsClient));
      SteamPlatformSystem.NativeFieldInfoPtr__IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_IsServer));
      SteamPlatformSystem.NativeFieldInfoPtr__ClientInitSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ClientInitSuccess));
      SteamPlatformSystem.NativeFieldInfoPtr__ServerInitSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ServerInitSuccess));
      SteamPlatformSystem.NativeFieldInfoPtr__NetworkingInitSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_NetworkingInitSuccess));
      SteamPlatformSystem.NativeFieldInfoPtr__ServerPolicyResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ServerPolicyResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__GetAuthSessionTicketResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_GetAuthSessionTicketResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__ValidateAuthTicketResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ValidateAuthTicketResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__OnGameRichPresenceJoinRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnGameRichPresenceJoinRequested));
      SteamPlatformSystem.NativeFieldInfoPtr__OnGetAuthSessionTicketResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnGetAuthSessionTicketResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__CallbackSteamServersConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_CallbackSteamServersConnected));
      SteamPlatformSystem.NativeFieldInfoPtr__CallbackSteamServersDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_CallbackSteamServersDisconnected));
      SteamPlatformSystem.NativeFieldInfoPtr__CallbackPolicyResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_CallbackPolicyResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__NewUrlLaunchParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_NewUrlLaunchParameters));
      SteamPlatformSystem.NativeFieldInfoPtr__OnEncryptedAppTicketResponseCallResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnEncryptedAppTicketResponseCallResult));
      SteamPlatformSystem.NativeFieldInfoPtr_OnAuthSessionResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (OnAuthSessionResponse));
      SteamPlatformSystem.NativeFieldInfoPtr_OnNewLaunchParamsReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (OnNewLaunchParamsReceived));
      SteamPlatformSystem.NativeFieldInfoPtr_APP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (APP_ID));
      SteamPlatformSystem.NativeFieldInfoPtr_APP_ID_SERVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (APP_ID_SERVER));
      SteamPlatformSystem.NativeFieldInfoPtr__AuthTicketHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_AuthTicketHandle));
      SteamPlatformSystem.NativeFieldInfoPtr__SteamServerConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_SteamServerConnected));
      SteamPlatformSystem.NativeFieldInfoPtr__BranchName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_BranchName));
      SteamPlatformSystem.NativeFieldInfoPtr__ServerSettingsSerializationNetBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ServerSettingsSerializationNetBufferData));
      SteamPlatformSystem.NativeFieldInfoPtr__ServerListResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ServerListResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__PlayersResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_PlayersResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__RulesResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_RulesResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__ServerLANMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ServerLANMode));
      SteamPlatformSystem.NativeFieldInfoPtr__WaitingForAuthSessionTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_WaitingForAuthSessionTicket));
      SteamPlatformSystem.NativeFieldInfoPtr__WaitingForAuthSessionTicketStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_WaitingForAuthSessionTicketStartTime));
      SteamPlatformSystem.NativeFieldInfoPtr_WAIT_FOR_AUTHTICKET_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (WAIT_FOR_AUTHTICKET_DURATION));
      SteamPlatformSystem.NativeFieldInfoPtr__ServerInfoListRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ServerInfoListRequest));
      SteamPlatformSystem.NativeFieldInfoPtr__OfficialServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OfficialServers));
      SteamPlatformSystem.NativeFieldInfoPtr__TrustedServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_TrustedServers));
      SteamPlatformSystem.NativeFieldInfoPtr__BannedServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_BannedServers));
      SteamPlatformSystem.NativeFieldInfoPtr__NextServerInfoRequestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_NextServerInfoRequestTime));
      SteamPlatformSystem.NativeFieldInfoPtr__ServerInfoRequestFailCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ServerInfoRequestFailCount));
      SteamPlatformSystem.NativeFieldInfoPtr__OnServerResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnServerResponse));
      SteamPlatformSystem.NativeFieldInfoPtr__OnRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnRefreshComplete));
      SteamPlatformSystem.NativeFieldInfoPtr__OnLANRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnLANRefreshComplete));
      SteamPlatformSystem.NativeFieldInfoPtr__InternetRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_InternetRequest));
      SteamPlatformSystem.NativeFieldInfoPtr__LANRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_LANRequest));
      SteamPlatformSystem.NativeFieldInfoPtr__QueuedPings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_QueuedPings));
      SteamPlatformSystem.NativeFieldInfoPtr__ActivePings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ActivePings));
      SteamPlatformSystem.NativeFieldInfoPtr__PingHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_PingHandles));
      SteamPlatformSystem.NativeFieldInfoPtr_maxActivePings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (maxActivePings));
      SteamPlatformSystem.NativeFieldInfoPtr__ServerRulesHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_ServerRulesHandle));
      SteamPlatformSystem.NativeFieldInfoPtr__OnRulesResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnRulesResponded));
      SteamPlatformSystem.NativeFieldInfoPtr__OnRulesRefreshedCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnRulesRefreshedCompleted));
      SteamPlatformSystem.NativeFieldInfoPtr__OnRulesFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (_OnRulesFailedToRespond));
      SteamPlatformSystem.NativeMethodInfoPtr_get_InitState_Public_get_PlatformInitState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690035);
      SteamPlatformSystem.NativeMethodInfoPtr_get_UserID_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690036);
      SteamPlatformSystem.NativeMethodInfoPtr_get_AuthSessionTicket_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690037);
      SteamPlatformSystem.NativeMethodInfoPtr_get_ServerReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690038);
      SteamPlatformSystem.NativeMethodInfoPtr_add_OnAuthSessionResponse_Public_add_Void_OnAuthSessionResponseDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690039);
      SteamPlatformSystem.NativeMethodInfoPtr_remove_OnAuthSessionResponse_Public_rem_Void_OnAuthSessionResponseDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690040);
      SteamPlatformSystem.NativeMethodInfoPtr_add_OnNewLaunchParamsReceived_Public_add_Void_OnNewLaunchParamsReceivedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690041);
      SteamPlatformSystem.NativeMethodInfoPtr_remove_OnNewLaunchParamsReceived_Public_rem_Void_OnNewLaunchParamsReceivedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690042);
      SteamPlatformSystem.NativeMethodInfoPtr_get_LogHeader_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690043);
      SteamPlatformSystem.NativeMethodInfoPtr_get_IsServerLANMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690044);
      SteamPlatformSystem.NativeMethodInfoPtr_get_IsAuthenticating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690045);
      SteamPlatformSystem.NativeMethodInfoPtr_GetSystem_Public_Static_SteamPlatformSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690046);
      SteamPlatformSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690047);
      SteamPlatformSystem.NativeMethodInfoPtr_TryInitSocketNetworking_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690048);
      SteamPlatformSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690049);
      SteamPlatformSystem.NativeMethodInfoPtr_IsClientLoggedOn_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690050);
      SteamPlatformSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690051);
      SteamPlatformSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690052);
      SteamPlatformSystem.NativeMethodInfoPtr_UpdateServerInfoList_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690053);
      SteamPlatformSystem.NativeMethodInfoPtr_TryInitServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690054);
      SteamPlatformSystem.NativeMethodInfoPtr_TryInitClient_Private_Boolean_byref_PlatformInitState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690055);
      SteamPlatformSystem.NativeMethodInfoPtr_OnNewURLLaunchParameter_Private_Void_NewUrlLaunchParameters_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690056);
      SteamPlatformSystem.NativeMethodInfoPtr_GetNotificationPosition_Private_ENotificationPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690057);
      SteamPlatformSystem.NativeMethodInfoPtr_OnGetAuthSessionTicketResponse_Private_Void_GetAuthSessionTicketResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690058);
      SteamPlatformSystem.NativeMethodInfoPtr_OnGameRichPresenceJoinRequested_Private_Void_GameRichPresenceJoinRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690059);
      SteamPlatformSystem.NativeMethodInfoPtr_TryGetInitResult_Public_Boolean_byref_PlatformInitState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690060);
      SteamPlatformSystem.NativeMethodInfoPtr_GetEncryptedAppTicket_Public_Void_Action_2_Il2CppStructArray_1_Byte_PlatformError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690061);
      SteamPlatformSystem.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Void_Boolean_Action_4_Boolean_EResult_Il2CppStructArray_1_Byte_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690062);
      SteamPlatformSystem.NativeMethodInfoPtr_BeginAuthSession_Public_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_UInt16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690063);
      SteamPlatformSystem.NativeMethodInfoPtr_OnValidateAuthTicketResponse_Private_Void_ValidateAuthTicketResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690064);
      SteamPlatformSystem.NativeMethodInfoPtr_CheckUserContent_Public_Void_UInt64_byref_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690065);
      SteamPlatformSystem.NativeMethodInfoPtr_GetAuthSessionResponseEnum_Private_AuthSessionResponseEnum_EAuthSessionResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690066);
      SteamPlatformSystem.NativeMethodInfoPtr_CheckLicenseSetFlag_Private_Void_byref_UserContentFlags_CSteamID_UInt32_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690067);
      SteamPlatformSystem.NativeMethodInfoPtr_OnSteamServersConnected_Private_Void_SteamServersConnected_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690068);
      SteamPlatformSystem.NativeMethodInfoPtr_OnSteamServersConnectFailure_Private_Void_SteamServerConnectFailure_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690069);
      SteamPlatformSystem.NativeMethodInfoPtr_OnSteamServersDisconnected_Private_Void_SteamServersDisconnected_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690070);
      SteamPlatformSystem.NativeMethodInfoPtr_OnPolicyResponse_Private_Void_GSPolicyResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690071);
      SteamPlatformSystem.NativeMethodInfoPtr_UpdateUser_Public_Boolean_UInt64_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690072);
      SteamPlatformSystem.NativeMethodInfoPtr_SetServerData_Public_Void_MatchmakingServerData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690073);
      SteamPlatformSystem.NativeMethodInfoPtr_SetServerGameSettingsHash_Private_Void_ServerGameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690074);
      SteamPlatformSystem.NativeMethodInfoPtr_SetServerSettings_Public_Void_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690075);
      SteamPlatformSystem.NativeMethodInfoPtr_SetServerDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690076);
      SteamPlatformSystem.NativeMethodInfoPtr_DebugStartHeartbeat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690077);
      SteamPlatformSystem.NativeMethodInfoPtr_CancelAuthTicket_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690078);
      SteamPlatformSystem.NativeMethodInfoPtr_EndAuthSession_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690079);
      SteamPlatformSystem.NativeMethodInfoPtr_TryGetPersonaName_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690080);
      SteamPlatformSystem.NativeMethodInfoPtr_TryGetPlatformId_Public_Boolean_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690081);
      SteamPlatformSystem.NativeMethodInfoPtr_RequestInternetServerList_Public_HServerListRequest_RequestServerListOptions_Action_1_ServerListEntryData_Action_1_EMatchMakingServerResponse_InternetServerRequestType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690082);
      SteamPlatformSystem.NativeMethodInfoPtr_RequestLANServerList_Public_HServerListRequest_Action_1_ServerListEntryData_Action_1_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690083);
      SteamPlatformSystem.NativeMethodInfoPtr_CancelServerListRequest_Public_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690084);
      SteamPlatformSystem.NativeMethodInfoPtr_IsRefreshing_Public_Boolean_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690085);
      SteamPlatformSystem.NativeMethodInfoPtr_GetFriendSessions_Public_Void_byref_List_1_FriendSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690086);
      SteamPlatformSystem.NativeMethodInfoPtr_GetFriendServers_Public_Void_Action_1_Nullable_1_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690087);
      SteamPlatformSystem.NativeMethodInfoPtr_GetPublicIP_Public_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690088);
      SteamPlatformSystem.NativeMethodInfoPtr_ParseCommandLine_Public_Static_CommandLineData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690089);
      SteamPlatformSystem.NativeMethodInfoPtr_get_CurrentActivePings_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690090);
      SteamPlatformSystem.NativeMethodInfoPtr_PingServer_Public_PingHandle_UInt32_UInt16_Action_1_Nullable_1_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690091);
      SteamPlatformSystem.NativeMethodInfoPtr_CancelPing_Public_Void_PingHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690092);
      SteamPlatformSystem.NativeMethodInfoPtr_CancelAllPings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690093);
      SteamPlatformSystem.NativeMethodInfoPtr_GameServerItemToListEntryData_Private_ServerListEntryData_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690094);
      SteamPlatformSystem.NativeMethodInfoPtr_IsOfficial_Public_Boolean_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690095);
      SteamPlatformSystem.NativeMethodInfoPtr_IsTrusted_Public_Boolean_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690096);
      SteamPlatformSystem.NativeMethodInfoPtr_IsBanned_Public_Boolean_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690097);
      SteamPlatformSystem.NativeMethodInfoPtr_OnServerResponded_Public_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690098);
      SteamPlatformSystem.NativeMethodInfoPtr_GameModeFromTags_Public_Static_GameModeType_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690099);
      SteamPlatformSystem.NativeMethodInfoPtr_ServerActivityLevelFromTags_Public_Static_ServerActivityLevel_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690100);
      SteamPlatformSystem.NativeMethodInfoPtr_OnServerFailedToRespond_Private_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690101);
      SteamPlatformSystem.NativeMethodInfoPtr_OnRefreshComplete_Private_Void_HServerListRequest_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690102);
      SteamPlatformSystem.NativeMethodInfoPtr_GetServerRules_Public_Void_UInt32_UInt16_Action_2_String_String_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690103);
      SteamPlatformSystem.NativeMethodInfoPtr_CancelServerRules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690104);
      SteamPlatformSystem.NativeMethodInfoPtr_OnServerResponded_Private_Void_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690105);
      SteamPlatformSystem.NativeMethodInfoPtr_OnServerFailedToRespond_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690106);
      SteamPlatformSystem.NativeMethodInfoPtr_OnAddPlayerToList_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690107);
      SteamPlatformSystem.NativeMethodInfoPtr_OnPlayersFailedToRespond_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690108);
      SteamPlatformSystem.NativeMethodInfoPtr_OnPlayersRefreshComplete_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690109);
      SteamPlatformSystem.NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690110);
      SteamPlatformSystem.NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690111);
      SteamPlatformSystem.NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690112);
      SteamPlatformSystem.NativeMethodInfoPtr_ClearAuthSessionEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690113);
      SteamPlatformSystem.NativeMethodInfoPtr_TryReadCloudFile_Public_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690114);
      SteamPlatformSystem.NativeMethodInfoPtr_TryWriteCloudFile_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690115);
      SteamPlatformSystem.NativeMethodInfoPtr_TryDeleteCloudFile_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690116);
      SteamPlatformSystem.NativeMethodInfoPtr_GetAppPurchaseTimeUTC_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690117);
      SteamPlatformSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690118);
      SteamPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690119);
      SteamPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_PingAddress_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690120);
      SteamPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_PingAddress_HServerQuery_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690121);
      SteamPlatformSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, 100690122);
    }

    public SteamPlatformSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ESteamNetworkingSocketsDebugOutputType STEAM_LOG_LEVEL
    {
      get
      {
        ESteamNetworkingSocketsDebugOutputType steamLogLevel;
        IL2CPP.il2cpp_field_static_get_value(SteamPlatformSystem.NativeFieldInfoPtr_STEAM_LOG_LEVEL, (void*) &steamLogLevel);
        return steamLogLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SteamPlatformSystem.NativeFieldInfoPtr_STEAM_LOG_LEVEL, (void*) &value);
      }
    }

    public unsafe PlatformInitState _InitState
    {
      get
      {
        return *(PlatformInitState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__InitState));
      }
      [param: In] set
      {
        *(PlatformInitState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__InitState)) = value;
      }
    }

    public unsafe bool _InitDone
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__InitDone));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__InitDone)) = value;
      }
    }

    public unsafe AppId_t _AppID
    {
      get
      {
        return *(AppId_t*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__AppID));
      }
      [param: In] set
      {
        *(AppId_t*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__AppID)) = value;
      }
    }

    public unsafe CSteamID _UserID
    {
      get
      {
        return *(CSteamID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__UserID));
      }
      [param: In] set
      {
        *(CSteamID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__UserID)) = value;
      }
    }

    public unsafe Il2CppStructArray<byte> _AuthSessionTicket
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__AuthSessionTicket));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__AuthSessionTicket), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<byte> _AppTicketDownloadBuffer
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__AppTicketDownloadBuffer));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__AppTicketDownloadBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe uint _PcbTicketSize
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__PcbTicketSize));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__PcbTicketSize)) = value;
      }
    }

    public unsafe bool _IsClient
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__IsClient));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__IsClient)) = value;
      }
    }

    public unsafe bool _IsServer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__IsServer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__IsServer)) = value;
      }
    }

    public unsafe bool _ClientInitSuccess
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ClientInitSuccess));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ClientInitSuccess)) = value;
      }
    }

    public unsafe bool _ServerInitSuccess
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerInitSuccess));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerInitSuccess)) = value;
      }
    }

    public unsafe bool _NetworkingInitSuccess
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__NetworkingInitSuccess));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__NetworkingInitSuccess)) = value;
      }
    }

    public unsafe bool _ServerPolicyResponse
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerPolicyResponse));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerPolicyResponse)) = value;
      }
    }

    public unsafe Callback<GetAuthSessionTicketResponse_t> _GetAuthSessionTicketResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__GetAuthSessionTicketResponse));
        return pointer == System.IntPtr.Zero ? (Callback<GetAuthSessionTicketResponse_t>) null : new Callback<GetAuthSessionTicketResponse_t>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__GetAuthSessionTicketResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Callback<ValidateAuthTicketResponse_t> _ValidateAuthTicketResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ValidateAuthTicketResponse));
        return pointer == System.IntPtr.Zero ? (Callback<ValidateAuthTicketResponse_t>) null : new Callback<ValidateAuthTicketResponse_t>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ValidateAuthTicketResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Callback<GameRichPresenceJoinRequested_t> _OnGameRichPresenceJoinRequested
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnGameRichPresenceJoinRequested));
        return pointer == System.IntPtr.Zero ? (Callback<GameRichPresenceJoinRequested_t>) null : new Callback<GameRichPresenceJoinRequested_t>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnGameRichPresenceJoinRequested), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<bool, EResult, Il2CppStructArray<byte>, CSteamID> _OnGetAuthSessionTicketResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnGetAuthSessionTicketResponse));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<bool, EResult, Il2CppStructArray<byte>, CSteamID>) null : new Il2CppSystem.Action<bool, EResult, Il2CppStructArray<byte>, CSteamID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnGetAuthSessionTicketResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Callback<SteamServersConnected_t> _CallbackSteamServersConnected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__CallbackSteamServersConnected));
        return pointer == System.IntPtr.Zero ? (Callback<SteamServersConnected_t>) null : new Callback<SteamServersConnected_t>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__CallbackSteamServersConnected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Callback<SteamServersDisconnected_t> _CallbackSteamServersDisconnected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__CallbackSteamServersDisconnected));
        return pointer == System.IntPtr.Zero ? (Callback<SteamServersDisconnected_t>) null : new Callback<SteamServersDisconnected_t>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__CallbackSteamServersDisconnected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Callback<GSPolicyResponse_t> _CallbackPolicyResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__CallbackPolicyResponse));
        return pointer == System.IntPtr.Zero ? (Callback<GSPolicyResponse_t>) null : new Callback<GSPolicyResponse_t>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__CallbackPolicyResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Callback<NewUrlLaunchParameters_t> _NewUrlLaunchParameters
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__NewUrlLaunchParameters));
        return pointer == System.IntPtr.Zero ? (Callback<NewUrlLaunchParameters_t>) null : new Callback<NewUrlLaunchParameters_t>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__NewUrlLaunchParameters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CallResult<EncryptedAppTicketResponse_t> _OnEncryptedAppTicketResponseCallResult
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnEncryptedAppTicketResponseCallResult));
        return pointer == System.IntPtr.Zero ? (CallResult<EncryptedAppTicketResponse_t>) null : new CallResult<EncryptedAppTicketResponse_t>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnEncryptedAppTicketResponseCallResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SteamPlatformSystem.OnAuthSessionResponseDelegate OnAuthSessionResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr_OnAuthSessionResponse));
        return pointer == System.IntPtr.Zero ? (SteamPlatformSystem.OnAuthSessionResponseDelegate) null : new SteamPlatformSystem.OnAuthSessionResponseDelegate(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr_OnAuthSessionResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate OnNewLaunchParamsReceived
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr_OnNewLaunchParamsReceived));
        return pointer == System.IntPtr.Zero ? (SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate) null : new SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr_OnNewLaunchParamsReceived), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AppId_t APP_ID
    {
      get
      {
        return *(AppId_t*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr_APP_ID));
      }
      [param: In] set
      {
        *(AppId_t*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr_APP_ID)) = value;
      }
    }

    public unsafe AppId_t APP_ID_SERVER
    {
      get
      {
        return *(AppId_t*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr_APP_ID_SERVER));
      }
      [param: In] set
      {
        *(AppId_t*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr_APP_ID_SERVER)) = value;
      }
    }

    public unsafe HAuthTicket _AuthTicketHandle
    {
      get
      {
        return *(HAuthTicket*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__AuthTicketHandle));
      }
      [param: In] set
      {
        *(HAuthTicket*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__AuthTicketHandle)) = value;
      }
    }

    public unsafe bool _SteamServerConnected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__SteamServerConnected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__SteamServerConnected)) = value;
      }
    }

    public unsafe string _BranchName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__BranchName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__BranchName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe NativeList<byte> _ServerSettingsSerializationNetBufferData
    {
      get
      {
        return *(NativeList<byte>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerSettingsSerializationNetBufferData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerSettingsSerializationNetBufferData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ISteamMatchmakingServerListResponse _ServerListResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerListResponse));
        return pointer == System.IntPtr.Zero ? (ISteamMatchmakingServerListResponse) null : new ISteamMatchmakingServerListResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerListResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ISteamMatchmakingPlayersResponse _PlayersResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__PlayersResponse));
        return pointer == System.IntPtr.Zero ? (ISteamMatchmakingPlayersResponse) null : new ISteamMatchmakingPlayersResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__PlayersResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ISteamMatchmakingRulesResponse _RulesResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__RulesResponse));
        return pointer == System.IntPtr.Zero ? (ISteamMatchmakingRulesResponse) null : new ISteamMatchmakingRulesResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__RulesResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _ServerLANMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerLANMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerLANMode)) = value;
      }
    }

    public unsafe bool _WaitingForAuthSessionTicket
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__WaitingForAuthSessionTicket));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__WaitingForAuthSessionTicket)) = value;
      }
    }

    public unsafe double _WaitingForAuthSessionTicketStartTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__WaitingForAuthSessionTicketStartTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__WaitingForAuthSessionTicketStartTime)) = value;
      }
    }

    public static unsafe double WAIT_FOR_AUTHTICKET_DURATION
    {
      get
      {
        double authticketDuration;
        IL2CPP.il2cpp_field_static_get_value(SteamPlatformSystem.NativeFieldInfoPtr_WAIT_FOR_AUTHTICKET_DURATION, (void*) &authticketDuration);
        return authticketDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SteamPlatformSystem.NativeFieldInfoPtr_WAIT_FOR_AUTHTICKET_DURATION, (void*) &value);
      }
    }

    public unsafe UnityWebRequest _ServerInfoListRequest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerInfoListRequest));
        return pointer == System.IntPtr.Zero ? (UnityWebRequest) null : new UnityWebRequest(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerInfoListRequest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _OfficialServers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OfficialServers));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OfficialServers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _TrustedServers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__TrustedServers));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__TrustedServers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _BannedServers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__BannedServers));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__BannedServers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _NextServerInfoRequestTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__NextServerInfoRequestTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__NextServerInfoRequestTime)) = value;
      }
    }

    public unsafe int _ServerInfoRequestFailCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerInfoRequestFailCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerInfoRequestFailCount)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<ServerListEntryData> _OnServerResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnServerResponse));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ServerListEntryData>) null : new Il2CppSystem.Action<ServerListEntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnServerResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<EMatchMakingServerResponse> _OnRefreshComplete
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnRefreshComplete));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<EMatchMakingServerResponse>) null : new Il2CppSystem.Action<EMatchMakingServerResponse>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<EMatchMakingServerResponse> _OnLANRefreshComplete
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnLANRefreshComplete));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<EMatchMakingServerResponse>) null : new Il2CppSystem.Action<EMatchMakingServerResponse>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnLANRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HServerListRequest _InternetRequest
    {
      get
      {
        return *(HServerListRequest*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__InternetRequest));
      }
      [param: In] set
      {
        *(HServerListRequest*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__InternetRequest)) = value;
      }
    }

    public unsafe HServerListRequest _LANRequest
    {
      get
      {
        return *(HServerListRequest*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__LANRequest));
      }
      [param: In] set
      {
        *(HServerListRequest*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__LANRequest)) = value;
      }
    }

    public unsafe Queue<SteamPlatformSystem.PingEntry> _QueuedPings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__QueuedPings));
        return pointer == System.IntPtr.Zero ? (Queue<SteamPlatformSystem.PingEntry>) null : new Queue<SteamPlatformSystem.PingEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__QueuedPings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<SteamPlatformSystem.PingAddress, SteamPlatformSystem.PingEntry> _ActivePings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ActivePings));
        return pointer == System.IntPtr.Zero ? (Dictionary<SteamPlatformSystem.PingAddress, SteamPlatformSystem.PingEntry>) null : new Dictionary<SteamPlatformSystem.PingAddress, SteamPlatformSystem.PingEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ActivePings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<SteamPlatformSystem.PingAddress, List<SteamPlatformSystem.PingHandle>> _PingHandles
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__PingHandles));
        return pointer == System.IntPtr.Zero ? (Dictionary<SteamPlatformSystem.PingAddress, List<SteamPlatformSystem.PingHandle>>) null : new Dictionary<SteamPlatformSystem.PingAddress, List<SteamPlatformSystem.PingHandle>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__PingHandles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int maxActivePings
    {
      get
      {
        int maxActivePings;
        IL2CPP.il2cpp_field_static_get_value(SteamPlatformSystem.NativeFieldInfoPtr_maxActivePings, (void*) &maxActivePings);
        return maxActivePings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SteamPlatformSystem.NativeFieldInfoPtr_maxActivePings, (void*) &value);
      }
    }

    public unsafe HServerQuery _ServerRulesHandle
    {
      get
      {
        return *(HServerQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerRulesHandle));
      }
      [param: In] set
      {
        *(HServerQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__ServerRulesHandle)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<string, string> _OnRulesResponded
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnRulesResponded));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string, string>) null : new Il2CppSystem.Action<string, string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnRulesResponded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action _OnRulesRefreshedCompleted
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnRulesRefreshedCompleted));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnRulesRefreshedCompleted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action _OnRulesFailedToRespond
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnRulesFailedToRespond));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.NativeFieldInfoPtr__OnRulesFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class OnAuthSessionResponseDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt64_AuthSessionResponseEnum_UserContentFlags_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UInt64_AuthSessionResponseEnum_UserContentFlags_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnAuthSessionResponseDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamPlatformSystem.OnAuthSessionResponseDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.OnAuthSessionResponseDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1137093, RefRangeEnd = 1137094, XrefRangeStart = 1137076, XrefRangeEnd = 1137093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ulong platformId,
        AuthSessionResponseEnum response,
        UserContentFlags userContent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &platformId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &response;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userContent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.OnAuthSessionResponseDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt64_AuthSessionResponseEnum_UserContentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137094, XrefRangeEnd = 1137104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ulong platformId,
        AuthSessionResponseEnum response,
        UserContentFlags userContent,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &platformId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &response;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userContent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.OnAuthSessionResponseDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UInt64_AuthSessionResponseEnum_UserContentFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.OnAuthSessionResponseDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnAuthSessionResponseDelegate()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.OnAuthSessionResponseDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (OnAuthSessionResponseDelegate));
        SteamPlatformSystem.OnAuthSessionResponseDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.OnAuthSessionResponseDelegate>.NativeClassPtr, 100690123);
        SteamPlatformSystem.OnAuthSessionResponseDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt64_AuthSessionResponseEnum_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.OnAuthSessionResponseDelegate>.NativeClassPtr, 100690124);
        SteamPlatformSystem.OnAuthSessionResponseDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UInt64_AuthSessionResponseEnum_UserContentFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.OnAuthSessionResponseDelegate>.NativeClassPtr, 100690125);
        SteamPlatformSystem.OnAuthSessionResponseDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.OnAuthSessionResponseDelegate>.NativeClassPtr, 100690126);
      }

      public OnAuthSessionResponseDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator SteamPlatformSystem.OnAuthSessionResponseDelegate(
        [In] System.Action<ulong, AuthSessionResponseEnum, UserContentFlags> obj0)
      {
        return DelegateSupport.ConvertDelegate<SteamPlatformSystem.OnAuthSessionResponseDelegate>((System.Delegate) obj0);
      }

      public static SteamPlatformSystem.OnAuthSessionResponseDelegate operator +(
        [In] SteamPlatformSystem.OnAuthSessionResponseDelegate obj0,
        [In] SteamPlatformSystem.OnAuthSessionResponseDelegate obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<SteamPlatformSystem.OnAuthSessionResponseDelegate>();
      }

      public static SteamPlatformSystem.OnAuthSessionResponseDelegate operator -(
        [In] SteamPlatformSystem.OnAuthSessionResponseDelegate obj0,
        [In] SteamPlatformSystem.OnAuthSessionResponseDelegate obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (SteamPlatformSystem.OnAuthSessionResponseDelegate) @delegate : @delegate.Cast<SteamPlatformSystem.OnAuthSessionResponseDelegate>();
      }
    }

    public sealed class OnNewLaunchParamsReceivedDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CommandLineData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CommandLineData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnNewLaunchParamsReceivedDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1137124, RefRangeEnd = 1137126, XrefRangeStart = 1137104, XrefRangeEnd = 1137124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(SteamPlatformSystem.CommandLineData launchParams)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &launchParams;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CommandLineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137126, XrefRangeEnd = 1137130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        SteamPlatformSystem.CommandLineData launchParams,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &launchParams;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CommandLineData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnNewLaunchParamsReceivedDelegate()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (OnNewLaunchParamsReceivedDelegate));
        SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>.NativeClassPtr, 100690127);
        SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CommandLineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>.NativeClassPtr, 100690128);
        SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CommandLineData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>.NativeClassPtr, 100690129);
        SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>.NativeClassPtr, 100690130);
      }

      public OnNewLaunchParamsReceivedDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate(
        [In] System.Action<SteamPlatformSystem.CommandLineData> obj0)
      {
        return DelegateSupport.ConvertDelegate<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>((System.Delegate) obj0);
      }

      public static SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate operator +(
        [In] SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate obj0,
        [In] SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>();
      }

      public static SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate operator -(
        [In] SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate obj0,
        [In] SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate) @delegate : @delegate.Cast<SteamPlatformSystem.OnNewLaunchParamsReceivedDelegate>();
      }
    }

    public enum PlatformError
    {
      None,
      IOFailure,
      TicketGetFailure,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RequestServerListOptions
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsDedicated;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSecure;
      private static readonly System.IntPtr NativeFieldInfoPtr_NoFull;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasPlayers;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsLinux;
      [FieldOffset(0)]
      public bool IsDedicated;
      [FieldOffset(1)]
      public bool IsSecure;
      [FieldOffset(2)]
      public bool NoFull;
      [FieldOffset(3)]
      public bool HasPlayers;
      [FieldOffset(4)]
      public bool IsLinux;

      static RequestServerListOptions()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.RequestServerListOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (RequestServerListOptions));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem.RequestServerListOptions>.NativeClassPtr);
        SteamPlatformSystem.RequestServerListOptions.NativeFieldInfoPtr_IsDedicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.RequestServerListOptions>.NativeClassPtr, nameof (IsDedicated));
        SteamPlatformSystem.RequestServerListOptions.NativeFieldInfoPtr_IsSecure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.RequestServerListOptions>.NativeClassPtr, nameof (IsSecure));
        SteamPlatformSystem.RequestServerListOptions.NativeFieldInfoPtr_NoFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.RequestServerListOptions>.NativeClassPtr, nameof (NoFull));
        SteamPlatformSystem.RequestServerListOptions.NativeFieldInfoPtr_HasPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.RequestServerListOptions>.NativeClassPtr, nameof (HasPlayers));
        SteamPlatformSystem.RequestServerListOptions.NativeFieldInfoPtr_IsLinux = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.RequestServerListOptions>.NativeClassPtr, nameof (IsLinux));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamPlatformSystem.RequestServerListOptions>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum InternetServerRequestType
    {
      Initial1,
      Initial2,
      Default,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CommandLineData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ConnectData;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public Nullable_Unboxed<SteamPlatformSystem.CommandLineConnectData> ConnectData;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137130, XrefRangeEnd = 1137136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.CommandLineData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static CommandLineData()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.CommandLineData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (CommandLineData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineData>.NativeClassPtr);
        SteamPlatformSystem.CommandLineData.NativeFieldInfoPtr_ConnectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineData>.NativeClassPtr, nameof (ConnectData));
        SteamPlatformSystem.CommandLineData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineData>.NativeClassPtr, 100690131);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CommandLineConnectData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryAddress;
      private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryAddress;
      private static readonly System.IntPtr NativeFieldInfoPtr_QueryPort;
      private static readonly System.IntPtr NativeFieldInfoPtr_Password;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExpectPassword;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetConnectAddressPreferSDR_Public_ConnectAddress_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public ConnectAddress PrimaryAddress;
      [FieldOffset(48)]
      public ConnectAddress SecondaryAddress;
      [FieldOffset(96)]
      public ushort QueryPort;
      [FieldOffset(98)]
      public FixedString128 Password;
      [FieldOffset(226)]
      public bool ExpectPassword;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1137136, RefRangeEnd = 1137137, XrefRangeStart = 1137136, XrefRangeEnd = 1137136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ConnectAddress GetConnectAddressPreferSDR()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.CommandLineConnectData.NativeMethodInfoPtr_GetConnectAddressPreferSDR_Public_ConnectAddress_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ConnectAddress*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1137164, RefRangeEnd = 1137165, XrefRangeStart = 1137137, XrefRangeEnd = 1137164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.CommandLineConnectData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static CommandLineConnectData()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (CommandLineConnectData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr);
        SteamPlatformSystem.CommandLineConnectData.NativeFieldInfoPtr_PrimaryAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr, nameof (PrimaryAddress));
        SteamPlatformSystem.CommandLineConnectData.NativeFieldInfoPtr_SecondaryAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr, nameof (SecondaryAddress));
        SteamPlatformSystem.CommandLineConnectData.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr, nameof (QueryPort));
        SteamPlatformSystem.CommandLineConnectData.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr, nameof (Password));
        SteamPlatformSystem.CommandLineConnectData.NativeFieldInfoPtr_ExpectPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr, nameof (ExpectPassword));
        SteamPlatformSystem.CommandLineConnectData.NativeMethodInfoPtr_GetConnectAddressPreferSDR_Public_ConnectAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr, 100690132);
        SteamPlatformSystem.CommandLineConnectData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr, 100690133);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamPlatformSystem.CommandLineConnectData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PingAddress
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ip;
      private static readonly System.IntPtr NativeFieldInfoPtr_port;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PingAddress_PingAddress_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PingAddress_PingAddress_0;
      [FieldOffset(0)]
      public uint ip;
      [FieldOffset(4)]
      public ushort port;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1137165, RefRangeEnd = 1137166, XrefRangeStart = 1137165, XrefRangeEnd = 1137165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PingAddress(uint ip, ushort port)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &ip;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingAddress.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137166, XrefRangeEnd = 1137169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137169, XrefRangeEnd = 1137171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137171, XrefRangeEnd = 1137177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool operator ==(
        SteamPlatformSystem.PingAddress left,
        SteamPlatformSystem.PingAddress right)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &left;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingAddress.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PingAddress_PingAddress_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137177, XrefRangeEnd = 1137183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool operator !=(
        SteamPlatformSystem.PingAddress left,
        SteamPlatformSystem.PingAddress right)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &left;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingAddress.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PingAddress_PingAddress_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static PingAddress()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (PingAddress));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr);
        SteamPlatformSystem.PingAddress.NativeFieldInfoPtr_ip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr, nameof (ip));
        SteamPlatformSystem.PingAddress.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr, nameof (port));
        SteamPlatformSystem.PingAddress.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr, 100690134);
        SteamPlatformSystem.PingAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr, 100690135);
        SteamPlatformSystem.PingAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr, 100690136);
        SteamPlatformSystem.PingAddress.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PingAddress_PingAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr, 100690137);
        SteamPlatformSystem.PingAddress.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PingAddress_PingAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr, 100690138);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamPlatformSystem.PingAddress>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class PingEntry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_address;
      private static readonly System.IntPtr NativeFieldInfoPtr_startTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_pingResponse;
      private static readonly System.IntPtr NativeFieldInfoPtr_query;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PingAddress_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Ping_Public_Void_ISteamMatchmakingPingResponse_0;

      public unsafe bool IsActive
      {
        [CallerCount(8), CachedScanResults(RefRangeStart = 113040, RefRangeEnd = 113048, XrefRangeStart = 113040, XrefRangeEnd = 113048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingEntry.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1137185, RefRangeEnd = 1137186, XrefRangeStart = 1137183, XrefRangeEnd = 1137185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PingEntry(SteamPlatformSystem.PingAddress address)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &address;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingEntry.NativeMethodInfoPtr__ctor_Public_Void_PingAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137186, XrefRangeEnd = 1137192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Ping(ISteamMatchmakingPingResponse pingResponse)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pingResponse);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingEntry.NativeMethodInfoPtr_Ping_Public_Void_ISteamMatchmakingPingResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PingEntry()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (PingEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr);
        SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr, nameof (address));
        SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr, nameof (startTime));
        SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_pingResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr, nameof (pingResponse));
        SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr, nameof (query));
        SteamPlatformSystem.PingEntry.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr, 100690139);
        SteamPlatformSystem.PingEntry.NativeMethodInfoPtr__ctor_Public_Void_PingAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr, 100690140);
        SteamPlatformSystem.PingEntry.NativeMethodInfoPtr_Ping_Public_Void_ISteamMatchmakingPingResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingEntry>.NativeClassPtr, 100690141);
      }

      public PingEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SteamPlatformSystem.PingAddress address
      {
        get
        {
          return *(SteamPlatformSystem.PingAddress*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_address));
        }
        [param: In] set
        {
          *(SteamPlatformSystem.PingAddress*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_address)) = value;
        }
      }

      public unsafe Il2CppSystem.DateTime startTime
      {
        get
        {
          return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_startTime));
        }
        [param: In] set
        {
          *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_startTime)) = value;
        }
      }

      public unsafe ISteamMatchmakingPingResponse pingResponse
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_pingResponse));
          return pointer == System.IntPtr.Zero ? (ISteamMatchmakingPingResponse) null : new ISteamMatchmakingPingResponse(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_pingResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe HServerQuery query
      {
        get
        {
          return *(HServerQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_query));
        }
        [param: In] set
        {
          *(HServerQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingEntry.NativeFieldInfoPtr_query)) = value;
        }
      }
    }

    public class PingHandle : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_callback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PingEntry_Action_1_Nullable_1_ServerListEntryData_0;

      [CallerCount(79)]
      [CachedScanResults(RefRangeStart = 16528, RefRangeEnd = 16607, XrefRangeStart = 16528, XrefRangeEnd = 16607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PingHandle(
        SteamPlatformSystem.PingEntry entry,
        Il2CppSystem.Action<Il2CppSystem.Nullable<ServerListEntryData>> callback)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamPlatformSystem.PingHandle>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.PingHandle.NativeMethodInfoPtr__ctor_Public_Void_PingEntry_Action_1_Nullable_1_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PingHandle()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.PingHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, nameof (PingHandle));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem.PingHandle>.NativeClassPtr);
        SteamPlatformSystem.PingHandle.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.PingHandle>.NativeClassPtr, nameof (entry));
        SteamPlatformSystem.PingHandle.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.PingHandle>.NativeClassPtr, nameof (callback));
        SteamPlatformSystem.PingHandle.NativeMethodInfoPtr__ctor_Public_Void_PingEntry_Action_1_Nullable_1_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.PingHandle>.NativeClassPtr, 100690142);
      }

      public PingHandle(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SteamPlatformSystem.PingEntry entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingHandle.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (SteamPlatformSystem.PingEntry) null : new SteamPlatformSystem.PingEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingHandle.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action<Il2CppSystem.Nullable<ServerListEntryData>> callback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingHandle.NativeFieldInfoPtr_callback));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Il2CppSystem.Nullable<ServerListEntryData>>) null : new Il2CppSystem.Action<Il2CppSystem.Nullable<ServerListEntryData>>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.PingHandle.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Auth.SteamPlatformSystem/<>c__DisplayClass80_0")]
    public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_callback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetEncryptedAppTicket_b__0_Internal_Void_EncryptedAppTicketResponse_t_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass80_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass80_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137192, XrefRangeEnd = 1137225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GetEncryptedAppTicket_b__0(
        EncryptedAppTicketResponse_t param,
        bool bIOFailure)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &param;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bIOFailure;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.__c__DisplayClass80_0.NativeMethodInfoPtr__GetEncryptedAppTicket_b__0_Internal_Void_EncryptedAppTicketResponse_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass80_0()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, "<>c__DisplayClass80_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass80_0>.NativeClassPtr);
        SteamPlatformSystem.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass80_0>.NativeClassPtr, "<>4__this");
        SteamPlatformSystem.__c__DisplayClass80_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass80_0>.NativeClassPtr, nameof (callback));
        SteamPlatformSystem.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass80_0>.NativeClassPtr, 100690143);
        SteamPlatformSystem.__c__DisplayClass80_0.NativeMethodInfoPtr__GetEncryptedAppTicket_b__0_Internal_Void_EncryptedAppTicketResponse_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass80_0>.NativeClassPtr, 100690144);
      }

      public __c__DisplayClass80_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SteamPlatformSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action<Il2CppStructArray<byte>, SteamPlatformSystem.PlatformError> callback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.__c__DisplayClass80_0.NativeFieldInfoPtr_callback));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Il2CppStructArray<byte>, SteamPlatformSystem.PlatformError>) null : new Il2CppSystem.Action<Il2CppStructArray<byte>, SteamPlatformSystem.PlatformError>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.__c__DisplayClass80_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Auth.SteamPlatformSystem/<>c__DisplayClass127_0")]
    public sealed class __c__DisplayClass127_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_currentPing;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PingServer_b__3_Internal_Void_gameserveritem_t_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PingServer_b__4_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass127_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass127_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.__c__DisplayClass127_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137225, XrefRangeEnd = 1137226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PingServer_b__3(gameserveritem_t server)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) server);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.__c__DisplayClass127_0.NativeMethodInfoPtr__PingServer_b__3_Internal_Void_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137226, XrefRangeEnd = 1137228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PingServer_b__4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamPlatformSystem.__c__DisplayClass127_0.NativeMethodInfoPtr__PingServer_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass127_0()
      {
        Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass127_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamPlatformSystem>.NativeClassPtr, "<>c__DisplayClass127_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass127_0>.NativeClassPtr);
        SteamPlatformSystem.__c__DisplayClass127_0.NativeFieldInfoPtr_currentPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass127_0>.NativeClassPtr, nameof (currentPing));
        SteamPlatformSystem.__c__DisplayClass127_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass127_0>.NativeClassPtr, "<>4__this");
        SteamPlatformSystem.__c__DisplayClass127_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass127_0>.NativeClassPtr, 100690145);
        SteamPlatformSystem.__c__DisplayClass127_0.NativeMethodInfoPtr__PingServer_b__3_Internal_Void_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass127_0>.NativeClassPtr, 100690146);
        SteamPlatformSystem.__c__DisplayClass127_0.NativeMethodInfoPtr__PingServer_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPlatformSystem.__c__DisplayClass127_0>.NativeClassPtr, 100690147);
      }

      public __c__DisplayClass127_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SteamPlatformSystem.PingEntry currentPing
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.__c__DisplayClass127_0.NativeFieldInfoPtr_currentPing));
          return pointer == System.IntPtr.Zero ? (SteamPlatformSystem.PingEntry) null : new SteamPlatformSystem.PingEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.__c__DisplayClass127_0.NativeFieldInfoPtr_currentPing), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SteamPlatformSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.__c__DisplayClass127_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamPlatformSystem.__c__DisplayClass127_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
