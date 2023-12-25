// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.PlatformInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.AntiCheatClient;
using Epic.OnlineServices.AntiCheatServer;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.CustomInvites;
using Epic.OnlineServices.Ecom;
using Epic.OnlineServices.Friends;
using Epic.OnlineServices.KWS;
using Epic.OnlineServices.Leaderboards;
using Epic.OnlineServices.Lobby;
using Epic.OnlineServices.Metrics;
using Epic.OnlineServices.Mods;
using Epic.OnlineServices.P2P;
using Epic.OnlineServices.PlayerDataStorage;
using Epic.OnlineServices.Presence;
using Epic.OnlineServices.ProgressionSnapshot;
using Epic.OnlineServices.Reports;
using Epic.OnlineServices.RTC;
using Epic.OnlineServices.RTCAdmin;
using Epic.OnlineServices.Sanctions;
using Epic.OnlineServices.Sessions;
using Epic.OnlineServices.Stats;
using Epic.OnlineServices.TitleStorage;
using Epic.OnlineServices.UI;
using Epic.OnlineServices.UserInfo;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  public sealed class PlatformInterface : Handle
  {
    private static readonly IntPtr NativeFieldInfoPtr_AndroidInitializeoptionssysteminitializeoptionsApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_CountrycodeMaxBufferLen;
    private static readonly IntPtr NativeFieldInfoPtr_CountrycodeMaxLength;
    private static readonly IntPtr NativeFieldInfoPtr_GetdesktopcrossplaystatusApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_InitializeApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_InitializeThreadaffinityApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_LocalecodeMaxBufferLen;
    private static readonly IntPtr NativeFieldInfoPtr_LocalecodeMaxLength;
    private static readonly IntPtr NativeFieldInfoPtr_OptionsApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_RtcoptionsApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_WindowsRtcoptionsplatformspecificoptionsApiLatest;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Result_byref_AndroidInitializeOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_CheckForLauncherAndRestart_Public_Result_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_byref_Options_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetAchievementsInterface_Public_AchievementsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetActiveCountryCode_Public_Result_EpicAccountId_byref_Utf8String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetActiveLocaleCode_Public_Result_EpicAccountId_byref_Utf8String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetAntiCheatClientInterface_Public_AntiCheatClientInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetAntiCheatServerInterface_Public_AntiCheatServerInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetApplicationStatus_Public_ApplicationStatus_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetAuthInterface_Public_AuthInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetConnectInterface_Public_ConnectInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetCustomInvitesInterface_Public_CustomInvitesInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDesktopCrossplayStatus_Public_Result_byref_GetDesktopCrossplayStatusOptions_byref_GetDesktopCrossplayStatusInfo_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetEcomInterface_Public_EcomInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetFriendsInterface_Public_FriendsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetKWSInterface_Public_KWSInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardsInterface_Public_LeaderboardsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetLobbyInterface_Public_LobbyInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetMetricsInterface_Public_MetricsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetModsInterface_Public_ModsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNetworkStatus_Public_NetworkStatus_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetOverrideCountryCode_Public_Result_byref_Utf8String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetOverrideLocaleCode_Public_Result_byref_Utf8String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetP2PInterface_Public_P2PInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPlayerDataStorageInterface_Public_PlayerDataStorageInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPresenceInterface_Public_PresenceInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetProgressionSnapshotInterface_Public_ProgressionSnapshotInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRTCAdminInterface_Public_RTCAdminInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRTCInterface_Public_RTCInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetReportsInterface_Public_ReportsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetSanctionsInterface_Public_SanctionsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetSessionsInterface_Public_SessionsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetStatsInterface_Public_StatsInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetTitleStorageInterface_Public_TitleStorageInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetUIInterface_Public_UIInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetUserInfoInterface_Public_UserInfoInterface_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Result_byref_InitializeOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetApplicationStatus_Public_Result_ApplicationStatus_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetNetworkStatus_Public_Result_NetworkStatus_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetOverrideCountryCode_Public_Result_Utf8String_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetOverrideLocaleCode_Public_Result_Utf8String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Result_0;
    private static readonly IntPtr NativeMethodInfoPtr_Tick_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_byref_WindowsOptions_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971574, XrefRangeEnd = 971582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Result Initialize(ref AndroidInitializeOptions options)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Initialize_Public_Static_Result_byref_AndroidInitializeOptions_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlatformInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971582, XrefRangeEnd = 971583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CheckForLauncherAndRestart()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_CheckForLauncherAndRestart_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971594, RefRangeEnd = 971595, XrefRangeStart = 971583, XrefRangeEnd = 971594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlatformInterface Create(ref Options options)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_byref_Options_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971595, XrefRangeEnd = 971602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementsInterface GetAchievementsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetAchievementsInterface_Public_AchievementsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AchievementsInterface) null : new AchievementsInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971602, XrefRangeEnd = 971611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetActiveCountryCode(EpicAccountId localUserId, out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr2 = &zero;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetActiveCountryCode_Public_Result_EpicAccountId_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971611, XrefRangeEnd = 971620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetActiveLocaleCode(EpicAccountId localUserId, out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr2 = &zero;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetActiveLocaleCode_Public_Result_EpicAccountId_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971620, XrefRangeEnd = 971627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AntiCheatClientInterface GetAntiCheatClientInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetAntiCheatClientInterface_Public_AntiCheatClientInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AntiCheatClientInterface) null : new AntiCheatClientInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971627, XrefRangeEnd = 971634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AntiCheatServerInterface GetAntiCheatServerInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetAntiCheatServerInterface_Public_AntiCheatServerInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AntiCheatServerInterface) null : new AntiCheatServerInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971634, XrefRangeEnd = 971635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ApplicationStatus GetApplicationStatus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetApplicationStatus_Public_ApplicationStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ApplicationStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971635, XrefRangeEnd = 971642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AuthInterface GetAuthInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetAuthInterface_Public_AuthInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AuthInterface) null : new AuthInterface(pointer);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 971649, RefRangeEnd = 971661, XrefRangeStart = 971642, XrefRangeEnd = 971649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConnectInterface GetConnectInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetConnectInterface_Public_ConnectInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ConnectInterface) null : new ConnectInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971661, XrefRangeEnd = 971668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomInvitesInterface GetCustomInvitesInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetCustomInvitesInterface_Public_CustomInvitesInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (CustomInvitesInterface) null : new CustomInvitesInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971668, XrefRangeEnd = 971682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetDesktopCrossplayStatus(
      ref GetDesktopCrossplayStatusOptions options,
      out GetDesktopCrossplayStatusInfo outDesktopCrossplayStatusInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref options;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref outDesktopCrossplayStatusInfo;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetDesktopCrossplayStatus_Public_Result_byref_GetDesktopCrossplayStatusOptions_byref_GetDesktopCrossplayStatusInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971682, XrefRangeEnd = 971689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EcomInterface GetEcomInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetEcomInterface_Public_EcomInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (EcomInterface) null : new EcomInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971689, XrefRangeEnd = 971696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FriendsInterface GetFriendsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetFriendsInterface_Public_FriendsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (FriendsInterface) null : new FriendsInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971696, XrefRangeEnd = 971703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KWSInterface GetKWSInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetKWSInterface_Public_KWSInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (KWSInterface) null : new KWSInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971703, XrefRangeEnd = 971710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LeaderboardsInterface GetLeaderboardsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetLeaderboardsInterface_Public_LeaderboardsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (LeaderboardsInterface) null : new LeaderboardsInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971710, XrefRangeEnd = 971717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LobbyInterface GetLobbyInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetLobbyInterface_Public_LobbyInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (LobbyInterface) null : new LobbyInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971717, XrefRangeEnd = 971724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MetricsInterface GetMetricsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetMetricsInterface_Public_MetricsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (MetricsInterface) null : new MetricsInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971724, XrefRangeEnd = 971731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModsInterface GetModsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetModsInterface_Public_ModsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ModsInterface) null : new ModsInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971731, XrefRangeEnd = 971732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkStatus GetNetworkStatus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetNetworkStatus_Public_NetworkStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971732, XrefRangeEnd = 971739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetOverrideCountryCode(out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[1];
      IntPtr* numPtr2 = numPtr1;
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr3 = &zero;
      *numPtr2 = (IntPtr) numPtr3;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetOverrideCountryCode_Public_Result_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971739, XrefRangeEnd = 971746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetOverrideLocaleCode(out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[1];
      IntPtr* numPtr2 = numPtr1;
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr3 = &zero;
      *numPtr2 = (IntPtr) numPtr3;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetOverrideLocaleCode_Public_Result_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971746, XrefRangeEnd = 971753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe P2PInterface GetP2PInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetP2PInterface_Public_P2PInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (P2PInterface) null : new P2PInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971753, XrefRangeEnd = 971760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerDataStorageInterface GetPlayerDataStorageInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetPlayerDataStorageInterface_Public_PlayerDataStorageInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (PlayerDataStorageInterface) null : new PlayerDataStorageInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971760, XrefRangeEnd = 971767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PresenceInterface GetPresenceInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetPresenceInterface_Public_PresenceInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (PresenceInterface) null : new PresenceInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971767, XrefRangeEnd = 971774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProgressionSnapshotInterface GetProgressionSnapshotInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetProgressionSnapshotInterface_Public_ProgressionSnapshotInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ProgressionSnapshotInterface) null : new ProgressionSnapshotInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971774, XrefRangeEnd = 971781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RTCAdminInterface GetRTCAdminInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetRTCAdminInterface_Public_RTCAdminInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RTCAdminInterface) null : new RTCAdminInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971781, XrefRangeEnd = 971788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RTCInterface GetRTCInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetRTCInterface_Public_RTCInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RTCInterface) null : new RTCInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971788, XrefRangeEnd = 971795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReportsInterface GetReportsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetReportsInterface_Public_ReportsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ReportsInterface) null : new ReportsInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971795, XrefRangeEnd = 971802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SanctionsInterface GetSanctionsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetSanctionsInterface_Public_SanctionsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SanctionsInterface) null : new SanctionsInterface(pointer);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 971809, RefRangeEnd = 971820, XrefRangeStart = 971802, XrefRangeEnd = 971809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionsInterface GetSessionsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetSessionsInterface_Public_SessionsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SessionsInterface) null : new SessionsInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971820, XrefRangeEnd = 971827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatsInterface GetStatsInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetStatsInterface_Public_StatsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (StatsInterface) null : new StatsInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971827, XrefRangeEnd = 971834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TitleStorageInterface GetTitleStorageInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetTitleStorageInterface_Public_TitleStorageInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (TitleStorageInterface) null : new TitleStorageInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971834, XrefRangeEnd = 971841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIInterface GetUIInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetUIInterface_Public_UIInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (UIInterface) null : new UIInterface(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971841, XrefRangeEnd = 971848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserInfoInterface GetUserInfoInterface()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetUserInfoInterface_Public_UserInfoInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (UserInfoInterface) null : new UserInfoInterface(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971856, RefRangeEnd = 971857, XrefRangeStart = 971848, XrefRangeEnd = 971856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Result Initialize(ref InitializeOptions options)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Initialize_Public_Static_Result_byref_InitializeOptions_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 971858, RefRangeEnd = 971860, XrefRangeStart = 971857, XrefRangeEnd = 971858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971860, XrefRangeEnd = 971861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetApplicationStatus(ApplicationStatus newStatus)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &newStatus;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_SetApplicationStatus_Public_Result_ApplicationStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971861, XrefRangeEnd = 971862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetNetworkStatus(NetworkStatus newStatus)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &newStatus;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_SetNetworkStatus_Public_Result_NetworkStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971862, XrefRangeEnd = 971869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetOverrideCountryCode(Epic.OnlineServices.Utf8String newCountryCode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newCountryCode);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_SetOverrideCountryCode_Public_Result_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971869, XrefRangeEnd = 971876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetOverrideLocaleCode(Epic.OnlineServices.Utf8String newLocaleCode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newLocaleCode);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_SetOverrideLocaleCode_Public_Result_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 971877, RefRangeEnd = 971879, XrefRangeStart = 971876, XrefRangeEnd = 971877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Result Shutdown()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Shutdown_Public_Static_Result_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 971880, RefRangeEnd = 971883, XrefRangeStart = 971879, XrefRangeEnd = 971880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Tick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Tick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971883, XrefRangeEnd = 971894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlatformInterface Create(ref WindowsOptions options)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_byref_WindowsOptions_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
    }

    static PlatformInterface()
    {
      Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (PlatformInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr);
      PlatformInterface.NativeFieldInfoPtr_AndroidInitializeoptionssysteminitializeoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (AndroidInitializeoptionssysteminitializeoptionsApiLatest));
      PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxBufferLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (CountrycodeMaxBufferLen));
      PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (CountrycodeMaxLength));
      PlatformInterface.NativeFieldInfoPtr_GetdesktopcrossplaystatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (GetdesktopcrossplaystatusApiLatest));
      PlatformInterface.NativeFieldInfoPtr_InitializeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (InitializeApiLatest));
      PlatformInterface.NativeFieldInfoPtr_InitializeThreadaffinityApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (InitializeThreadaffinityApiLatest));
      PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxBufferLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (LocalecodeMaxBufferLen));
      PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (LocalecodeMaxLength));
      PlatformInterface.NativeFieldInfoPtr_OptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (OptionsApiLatest));
      PlatformInterface.NativeFieldInfoPtr_RtcoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (RtcoptionsApiLatest));
      PlatformInterface.NativeFieldInfoPtr_WindowsRtcoptionsplatformspecificoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (WindowsRtcoptionsplatformspecificoptionsApiLatest));
      PlatformInterface.NativeMethodInfoPtr_Initialize_Public_Static_Result_byref_AndroidInitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674574);
      PlatformInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674575);
      PlatformInterface.NativeMethodInfoPtr_CheckForLauncherAndRestart_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674577);
      PlatformInterface.NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_byref_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674578);
      PlatformInterface.NativeMethodInfoPtr_GetAchievementsInterface_Public_AchievementsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674579);
      PlatformInterface.NativeMethodInfoPtr_GetActiveCountryCode_Public_Result_EpicAccountId_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674580);
      PlatformInterface.NativeMethodInfoPtr_GetActiveLocaleCode_Public_Result_EpicAccountId_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674581);
      PlatformInterface.NativeMethodInfoPtr_GetAntiCheatClientInterface_Public_AntiCheatClientInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674582);
      PlatformInterface.NativeMethodInfoPtr_GetAntiCheatServerInterface_Public_AntiCheatServerInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674583);
      PlatformInterface.NativeMethodInfoPtr_GetApplicationStatus_Public_ApplicationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674584);
      PlatformInterface.NativeMethodInfoPtr_GetAuthInterface_Public_AuthInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674585);
      PlatformInterface.NativeMethodInfoPtr_GetConnectInterface_Public_ConnectInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674586);
      PlatformInterface.NativeMethodInfoPtr_GetCustomInvitesInterface_Public_CustomInvitesInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674587);
      PlatformInterface.NativeMethodInfoPtr_GetDesktopCrossplayStatus_Public_Result_byref_GetDesktopCrossplayStatusOptions_byref_GetDesktopCrossplayStatusInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674588);
      PlatformInterface.NativeMethodInfoPtr_GetEcomInterface_Public_EcomInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674589);
      PlatformInterface.NativeMethodInfoPtr_GetFriendsInterface_Public_FriendsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674590);
      PlatformInterface.NativeMethodInfoPtr_GetKWSInterface_Public_KWSInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674591);
      PlatformInterface.NativeMethodInfoPtr_GetLeaderboardsInterface_Public_LeaderboardsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674592);
      PlatformInterface.NativeMethodInfoPtr_GetLobbyInterface_Public_LobbyInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674593);
      PlatformInterface.NativeMethodInfoPtr_GetMetricsInterface_Public_MetricsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674594);
      PlatformInterface.NativeMethodInfoPtr_GetModsInterface_Public_ModsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674595);
      PlatformInterface.NativeMethodInfoPtr_GetNetworkStatus_Public_NetworkStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674596);
      PlatformInterface.NativeMethodInfoPtr_GetOverrideCountryCode_Public_Result_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674597);
      PlatformInterface.NativeMethodInfoPtr_GetOverrideLocaleCode_Public_Result_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674598);
      PlatformInterface.NativeMethodInfoPtr_GetP2PInterface_Public_P2PInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674599);
      PlatformInterface.NativeMethodInfoPtr_GetPlayerDataStorageInterface_Public_PlayerDataStorageInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674600);
      PlatformInterface.NativeMethodInfoPtr_GetPresenceInterface_Public_PresenceInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674601);
      PlatformInterface.NativeMethodInfoPtr_GetProgressionSnapshotInterface_Public_ProgressionSnapshotInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674602);
      PlatformInterface.NativeMethodInfoPtr_GetRTCAdminInterface_Public_RTCAdminInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674603);
      PlatformInterface.NativeMethodInfoPtr_GetRTCInterface_Public_RTCInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674604);
      PlatformInterface.NativeMethodInfoPtr_GetReportsInterface_Public_ReportsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674605);
      PlatformInterface.NativeMethodInfoPtr_GetSanctionsInterface_Public_SanctionsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674606);
      PlatformInterface.NativeMethodInfoPtr_GetSessionsInterface_Public_SessionsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674607);
      PlatformInterface.NativeMethodInfoPtr_GetStatsInterface_Public_StatsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674608);
      PlatformInterface.NativeMethodInfoPtr_GetTitleStorageInterface_Public_TitleStorageInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674609);
      PlatformInterface.NativeMethodInfoPtr_GetUIInterface_Public_UIInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674610);
      PlatformInterface.NativeMethodInfoPtr_GetUserInfoInterface_Public_UserInfoInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674611);
      PlatformInterface.NativeMethodInfoPtr_Initialize_Public_Static_Result_byref_InitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674612);
      PlatformInterface.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674613);
      PlatformInterface.NativeMethodInfoPtr_SetApplicationStatus_Public_Result_ApplicationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674614);
      PlatformInterface.NativeMethodInfoPtr_SetNetworkStatus_Public_Result_NetworkStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674615);
      PlatformInterface.NativeMethodInfoPtr_SetOverrideCountryCode_Public_Result_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674616);
      PlatformInterface.NativeMethodInfoPtr_SetOverrideLocaleCode_Public_Result_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674617);
      PlatformInterface.NativeMethodInfoPtr_Shutdown_Public_Static_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674618);
      PlatformInterface.NativeMethodInfoPtr_Tick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674619);
      PlatformInterface.NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_byref_WindowsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100674620);
    }

    public PlatformInterface(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AndroidInitializeoptionssysteminitializeoptionsApiLatest
    {
      get
      {
        int initializeoptionssysteminitializeoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_AndroidInitializeoptionssysteminitializeoptionsApiLatest, (void*) &initializeoptionssysteminitializeoptionsApiLatest);
        return initializeoptionssysteminitializeoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_AndroidInitializeoptionssysteminitializeoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int CountrycodeMaxBufferLen
    {
      get
      {
        int countrycodeMaxBufferLen;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxBufferLen, (void*) &countrycodeMaxBufferLen);
        return countrycodeMaxBufferLen;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxBufferLen, (void*) &value);
      }
    }

    public static unsafe int CountrycodeMaxLength
    {
      get
      {
        int countrycodeMaxLength;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxLength, (void*) &countrycodeMaxLength);
        return countrycodeMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxLength, (void*) &value);
      }
    }

    public static unsafe int GetdesktopcrossplaystatusApiLatest
    {
      get
      {
        int getdesktopcrossplaystatusApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_GetdesktopcrossplaystatusApiLatest, (void*) &getdesktopcrossplaystatusApiLatest);
        return getdesktopcrossplaystatusApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_GetdesktopcrossplaystatusApiLatest, (void*) &value);
      }
    }

    public static unsafe int InitializeApiLatest
    {
      get
      {
        int initializeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_InitializeApiLatest, (void*) &initializeApiLatest);
        return initializeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_InitializeApiLatest, (void*) &value);
      }
    }

    public static unsafe int InitializeThreadaffinityApiLatest
    {
      get
      {
        int threadaffinityApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_InitializeThreadaffinityApiLatest, (void*) &threadaffinityApiLatest);
        return threadaffinityApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_InitializeThreadaffinityApiLatest, (void*) &value);
      }
    }

    public static unsafe int LocalecodeMaxBufferLen
    {
      get
      {
        int localecodeMaxBufferLen;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxBufferLen, (void*) &localecodeMaxBufferLen);
        return localecodeMaxBufferLen;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxBufferLen, (void*) &value);
      }
    }

    public static unsafe int LocalecodeMaxLength
    {
      get
      {
        int localecodeMaxLength;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxLength, (void*) &localecodeMaxLength);
        return localecodeMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxLength, (void*) &value);
      }
    }

    public static unsafe int OptionsApiLatest
    {
      get
      {
        int optionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_OptionsApiLatest, (void*) &optionsApiLatest);
        return optionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_OptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int RtcoptionsApiLatest
    {
      get
      {
        int rtcoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_RtcoptionsApiLatest, (void*) &rtcoptionsApiLatest);
        return rtcoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_RtcoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int WindowsRtcoptionsplatformspecificoptionsApiLatest
    {
      get
      {
        int rtcoptionsplatformspecificoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_WindowsRtcoptionsplatformspecificoptionsApiLatest, (void*) &rtcoptionsplatformspecificoptionsApiLatest);
        return rtcoptionsplatformspecificoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_WindowsRtcoptionsplatformspecificoptionsApiLatest, (void*) &value);
      }
    }
  }
}
