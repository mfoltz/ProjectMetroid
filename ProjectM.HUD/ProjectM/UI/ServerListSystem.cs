// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServerListSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.Auth;
using ProjectM.EOS;
using ProjectM.Shared;
using Steamworks;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class ServerListSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RECOMMENDED_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_REFRESH_TIMEOUT;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerListEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerListEntriesLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__SessionsWithFriends;
    private static readonly System.IntPtr NativeFieldInfoPtr__RefreshTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__RefreshInProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequestHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__LANRequestHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__EOSPlatformSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_HIGH_PING_VALUE;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedResult;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextGetInternalResultsTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFilterOptions;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastServerListSorting;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextPingRequestTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_PingRequestDelays;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForcedPingRequestDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviousEosSearch;
    private static readonly System.IntPtr NativeFieldInfoPtr__ContinueTypingDeadline;
    private static readonly System.IntPtr NativeFieldInfoPtr__EosSearchScheduled;
    private static readonly System.IntPtr NativeFieldInfoPtr__EosServerSearchRateLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitUntilSearchWhenTyping;
    private static readonly System.IntPtr NativeFieldInfoPtr__EosRefreshInProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr__SearchHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSearchCriteria;
    private static readonly System.IntPtr NativeFieldInfoPtr__ToPingLowPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr__ToPing;
    private static readonly System.IntPtr NativeFieldInfoPtr__PingStarted;
    private static readonly System.IntPtr NativeFieldInfoPtr__PingUnavailable;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSystem_Public_Static_ServerListSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFilteredServerListEntries_Public_Void_byref_List_1_ServerListEntryUIData_byref_Single_ServerHistory_ServerListSorting_Nullable_1_ServerListFilterOptions_Nullable_Unboxed_1_ServerListPrioritySettings_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetListEntryPriority_Private_Void_byref_ServerListEntryData_ServerListPrioritySettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterModeCheck_Private_Boolean_GameModeType_GameModeTypeFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterCheck_Private_Boolean_Boolean_FilterSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PingServer_Public_Void_UInt32_UInt16_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSearchUsingEOS_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshFriendServers_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRefreshing_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRefreshingSteam_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrRefreshEntry_Private_Void_ServerListEntryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StopSteamRefresh_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StopRefresh_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRefreshingEOS_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRunningEosSearch_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleEOSSearchAfterFilterChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleEOSSearch_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AbortAllEOSSearches_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TickEOSSearch_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PerformEOSSearch_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForceFilterRefreshNextUpdate_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetEOSSearchCriteria_Public_Void_Nullable_1_ServerListFilterOptions_ServerListSorting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AbortAllEOSPings_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasActiveEOSPings_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeprioritizeOldEOSPings_Private_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToEOSPingQueue_Private_Void_ServerListEntryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RefreshFriendServers_b__28_0_Private_Void_Nullable_1_ServerListEntryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_Boolean_UInt32_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_ServerListEntryData_Nullable_1_ServerListEntryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1284902, RefRangeEnd = 1284906, XrefRangeStart = 1284897, XrefRangeEnd = 1284902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ServerListSystem GetSystem()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_GetSystem_Public_Static_ServerListSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ServerListSystem) null : new ServerListSystem(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1284969, RefRangeEnd = 1284971, XrefRangeStart = 1284906, XrefRangeEnd = 1284969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetFilteredServerListEntries(
      ref List<ServerListEntryUIData> output,
      out float normalizedTimeUntilNextRefresh,
      ServerHistory serverHistory,
      ServerListSorting sortType,
      Il2CppSystem.Nullable<ServerListFilterOptions> filterOptions = null,
      Nullable_Unboxed<ServerListPrioritySettings> prioritySettings = default (Nullable_Unboxed<ServerListPrioritySettings>),
      float timeBetweenInternalFetches = 2f,
      bool forceRefresh = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) output);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref normalizedTimeUntilNextRefresh;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverHistory);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sortType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) filterOptions));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &prioritySettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &timeBetweenInternalFetches;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &forceRefresh;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_GetFilteredServerListEntries_Public_Void_byref_List_1_ServerListEntryUIData_byref_Single_ServerHistory_ServerListSorting_Nullable_1_ServerListFilterOptions_Nullable_Unboxed_1_ServerListPrioritySettings_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<ServerListEntryUIData> local = ref output;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<ServerListEntryUIData>) list;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284971, XrefRangeEnd = 1284987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetListEntryPriority(
      ref ServerListEntryData entry,
      ServerListPrioritySettings prioritySettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prioritySettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_SetListEntryPriority_Private_Void_byref_ServerListEntryData_ServerListPrioritySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool FilterModeCheck(GameModeType gameMode, GameModeTypeFilter gameModeFilter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &gameMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameModeFilter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_FilterModeCheck_Private_Boolean_GameModeType_GameModeTypeFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool FilterCheck(bool boolean, FilterSetting filterSetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &boolean;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &filterSetting;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_FilterCheck_Private_Boolean_Boolean_FilterSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerListSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1285011, RefRangeEnd = 1285016, XrefRangeStart = 1284987, XrefRangeEnd = 1285011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PingServer(uint ip, ushort port, string sessionGUID, bool force = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &ip;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionGUID);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &force;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_PingServer_Public_Void_UInt32_UInt16_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1285041, RefRangeEnd = 1285044, XrefRangeStart = 1285016, XrefRangeEnd = 1285041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Refresh(bool force = false, bool initialRefresh = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &force;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initialRefresh;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_Refresh_Public_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe bool ShouldSearchUsingEOS
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285044, XrefRangeEnd = 1285045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_get_ShouldSearchUsingEOS_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285045, XrefRangeEnd = 1285059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshFriendServers()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_RefreshFriendServers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1285066, RefRangeEnd = 1285069, XrefRangeStart = 1285059, XrefRangeEnd = 1285066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsRefreshing()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_IsRefreshing_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285069, XrefRangeEnd = 1285075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsRefreshingSteam()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_IsRefreshingSteam_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1285086, RefRangeEnd = 1285094, XrefRangeStart = 1285075, XrefRangeEnd = 1285086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrRefreshEntry(ServerListEntryData newEntry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newEntry));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_AddOrRefreshEntry_Private_Void_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1285103, RefRangeEnd = 1285104, XrefRangeStart = 1285094, XrefRangeEnd = 1285103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StopSteamRefresh()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_StopSteamRefresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1285107, RefRangeEnd = 1285108, XrefRangeStart = 1285104, XrefRangeEnd = 1285107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StopRefresh()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_StopRefresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285108, XrefRangeEnd = 1285114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerListSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285114, XrefRangeEnd = 1285118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsRefreshingEOS()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_IsRefreshingEOS_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool IsRunningEosSearch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_IsRunningEosSearch_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285118, XrefRangeEnd = 1285121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleEOSSearchAfterFilterChanged(bool onlyTextChanged)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &onlyTextChanged;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_ScheduleEOSSearchAfterFilterChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285121, XrefRangeEnd = 1285123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleEOSSearch(bool abortCurrent = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &abortCurrent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_ScheduleEOSSearch_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1285125, RefRangeEnd = 1285126, XrefRangeStart = 1285123, XrefRangeEnd = 1285125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AbortAllEOSSearches()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_AbortAllEOSSearches_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1285132, RefRangeEnd = 1285136, XrefRangeStart = 1285126, XrefRangeEnd = 1285132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TickEOSSearch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_TickEOSSearch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285136, XrefRangeEnd = 1285154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PerformEOSSearch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_PerformEOSSearch_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285154, XrefRangeEnd = 1285155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ForceFilterRefreshNextUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_ForceFilterRefreshNextUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1285297, RefRangeEnd = 1285298, XrefRangeStart = 1285155, XrefRangeEnd = 1285297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetEOSSearchCriteria(
      Il2CppSystem.Nullable<ServerListFilterOptions> filterOptionsNullable,
      ServerListSorting sortingOrder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) filterOptionsNullable));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingOrder;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_SetEOSSearchCriteria_Public_Void_Nullable_1_ServerListFilterOptions_ServerListSorting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1285329, RefRangeEnd = 1285331, XrefRangeStart = 1285298, XrefRangeEnd = 1285329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AbortAllEOSPings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_AbortAllEOSPings_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285331, XrefRangeEnd = 1285334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasActiveEOSPings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_HasActiveEOSPings_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285334, XrefRangeEnd = 1285342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeprioritizeOldEOSPings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_DeprioritizeOldEOSPings_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1285358, RefRangeEnd = 1285359, XrefRangeStart = 1285342, XrefRangeEnd = 1285358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddToEOSPingQueue(ServerListEntryData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_AddToEOSPingQueue_Private_Void_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285359, XrefRangeEnd = 1285421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerListSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285421, XrefRangeEnd = 1285426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RefreshFriendServers_b__28_0(Il2CppSystem.Nullable<ServerListEntryData> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr__RefreshFriendServers_b__28_0_Private_Void_Nullable_1_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285426, XrefRangeEnd = 1285447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_Boolean_Boolean_UInt32_PDM_0(
      bool success,
      bool finished,
      uint newResultsCount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &success;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &finished;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newResultsCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_Method_Private_Void_Boolean_Boolean_UInt32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1285477, RefRangeEnd = 1285479, XrefRangeStart = 1285447, XrefRangeEnd = 1285477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1285498, RefRangeEnd = 1285499, XrefRangeStart = 1285479, XrefRangeEnd = 1285498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_ServerListEntryData_Nullable_1_ServerListEntryData_0(
      ServerListEntryData oldData,
      Il2CppSystem.Nullable<ServerListEntryData> updatedData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) oldData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) updatedData));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListSystem.NativeMethodInfoPtr_Method_Private_Void_ServerListEntryData_Nullable_1_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerListSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerListSystem()
    {
      Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServerListSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr);
      ServerListSystem.NativeFieldInfoPtr_RECOMMENDED_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (RECOMMENDED_COUNT));
      ServerListSystem.NativeFieldInfoPtr_REFRESH_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (REFRESH_TIMEOUT));
      ServerListSystem.NativeFieldInfoPtr__ServerListEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_ServerListEntries));
      ServerListSystem.NativeFieldInfoPtr__ServerListEntriesLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_ServerListEntriesLookup));
      ServerListSystem.NativeFieldInfoPtr__SessionsWithFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_SessionsWithFriends));
      ServerListSystem.NativeFieldInfoPtr__RefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_RefreshTime));
      ServerListSystem.NativeFieldInfoPtr__RefreshInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_RefreshInProgress));
      ServerListSystem.NativeFieldInfoPtr__RequestHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_RequestHandle));
      ServerListSystem.NativeFieldInfoPtr__LANRequestHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_LANRequestHandle));
      ServerListSystem.NativeFieldInfoPtr__EOSPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_EOSPlatformSystem));
      ServerListSystem.NativeFieldInfoPtr_HIGH_PING_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (HIGH_PING_VALUE));
      ServerListSystem.NativeFieldInfoPtr__CachedResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_CachedResult));
      ServerListSystem.NativeFieldInfoPtr__NextGetInternalResultsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_NextGetInternalResultsTime));
      ServerListSystem.NativeFieldInfoPtr__LastFilterOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_LastFilterOptions));
      ServerListSystem.NativeFieldInfoPtr__LastServerListSorting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_LastServerListSorting));
      ServerListSystem.NativeFieldInfoPtr__NextPingRequestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_NextPingRequestTime));
      ServerListSystem.NativeFieldInfoPtr_PingRequestDelays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (PingRequestDelays));
      ServerListSystem.NativeFieldInfoPtr_ForcedPingRequestDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (ForcedPingRequestDelay));
      ServerListSystem.NativeFieldInfoPtr__PreviousEosSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_PreviousEosSearch));
      ServerListSystem.NativeFieldInfoPtr__ContinueTypingDeadline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_ContinueTypingDeadline));
      ServerListSystem.NativeFieldInfoPtr__EosSearchScheduled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_EosSearchScheduled));
      ServerListSystem.NativeFieldInfoPtr__EosServerSearchRateLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_EosServerSearchRateLimit));
      ServerListSystem.NativeFieldInfoPtr__WaitUntilSearchWhenTyping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_WaitUntilSearchWhenTyping));
      ServerListSystem.NativeFieldInfoPtr__EosRefreshInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_EosRefreshInProgress));
      ServerListSystem.NativeFieldInfoPtr__SearchHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_SearchHandle));
      ServerListSystem.NativeFieldInfoPtr__CurrentSearchCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_CurrentSearchCriteria));
      ServerListSystem.NativeFieldInfoPtr__ToPingLowPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_ToPingLowPriority));
      ServerListSystem.NativeFieldInfoPtr__ToPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_ToPing));
      ServerListSystem.NativeFieldInfoPtr__PingStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_PingStarted));
      ServerListSystem.NativeFieldInfoPtr__PingUnavailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, nameof (_PingUnavailable));
      ServerListSystem.NativeMethodInfoPtr_GetSystem_Public_Static_ServerListSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669341);
      ServerListSystem.NativeMethodInfoPtr_GetFilteredServerListEntries_Public_Void_byref_List_1_ServerListEntryUIData_byref_Single_ServerHistory_ServerListSorting_Nullable_1_ServerListFilterOptions_Nullable_Unboxed_1_ServerListPrioritySettings_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669342);
      ServerListSystem.NativeMethodInfoPtr_SetListEntryPriority_Private_Void_byref_ServerListEntryData_ServerListPrioritySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669343);
      ServerListSystem.NativeMethodInfoPtr_FilterModeCheck_Private_Boolean_GameModeType_GameModeTypeFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669344);
      ServerListSystem.NativeMethodInfoPtr_FilterCheck_Private_Boolean_Boolean_FilterSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669345);
      ServerListSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669346);
      ServerListSystem.NativeMethodInfoPtr_PingServer_Public_Void_UInt32_UInt16_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669347);
      ServerListSystem.NativeMethodInfoPtr_Refresh_Public_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669348);
      ServerListSystem.NativeMethodInfoPtr_get_ShouldSearchUsingEOS_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669349);
      ServerListSystem.NativeMethodInfoPtr_RefreshFriendServers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669350);
      ServerListSystem.NativeMethodInfoPtr_IsRefreshing_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669351);
      ServerListSystem.NativeMethodInfoPtr_IsRefreshingSteam_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669352);
      ServerListSystem.NativeMethodInfoPtr_AddOrRefreshEntry_Private_Void_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669353);
      ServerListSystem.NativeMethodInfoPtr_StopSteamRefresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669354);
      ServerListSystem.NativeMethodInfoPtr_StopRefresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669355);
      ServerListSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669356);
      ServerListSystem.NativeMethodInfoPtr_IsRefreshingEOS_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669357);
      ServerListSystem.NativeMethodInfoPtr_IsRunningEosSearch_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669358);
      ServerListSystem.NativeMethodInfoPtr_ScheduleEOSSearchAfterFilterChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669359);
      ServerListSystem.NativeMethodInfoPtr_ScheduleEOSSearch_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669360);
      ServerListSystem.NativeMethodInfoPtr_AbortAllEOSSearches_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669361);
      ServerListSystem.NativeMethodInfoPtr_TickEOSSearch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669362);
      ServerListSystem.NativeMethodInfoPtr_PerformEOSSearch_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669363);
      ServerListSystem.NativeMethodInfoPtr_ForceFilterRefreshNextUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669364);
      ServerListSystem.NativeMethodInfoPtr_SetEOSSearchCriteria_Public_Void_Nullable_1_ServerListFilterOptions_ServerListSorting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669365);
      ServerListSystem.NativeMethodInfoPtr_AbortAllEOSPings_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669366);
      ServerListSystem.NativeMethodInfoPtr_HasActiveEOSPings_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669367);
      ServerListSystem.NativeMethodInfoPtr_DeprioritizeOldEOSPings_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669368);
      ServerListSystem.NativeMethodInfoPtr_AddToEOSPingQueue_Private_Void_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669369);
      ServerListSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669370);
      ServerListSystem.NativeMethodInfoPtr__RefreshFriendServers_b__28_0_Private_Void_Nullable_1_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669371);
      ServerListSystem.NativeMethodInfoPtr_Method_Private_Void_Boolean_Boolean_UInt32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669372);
      ServerListSystem.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669373);
      ServerListSystem.NativeMethodInfoPtr_Method_Private_Void_ServerListEntryData_Nullable_1_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669374);
      ServerListSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, 100669375);
    }

    public ServerListSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int RECOMMENDED_COUNT
    {
      get
      {
        int recommendedCount;
        IL2CPP.il2cpp_field_static_get_value(ServerListSystem.NativeFieldInfoPtr_RECOMMENDED_COUNT, (void*) &recommendedCount);
        return recommendedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerListSystem.NativeFieldInfoPtr_RECOMMENDED_COUNT, (void*) &value);
      }
    }

    public static unsafe double REFRESH_TIMEOUT
    {
      get
      {
        double refreshTimeout;
        IL2CPP.il2cpp_field_static_get_value(ServerListSystem.NativeFieldInfoPtr_REFRESH_TIMEOUT, (void*) &refreshTimeout);
        return refreshTimeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerListSystem.NativeFieldInfoPtr_REFRESH_TIMEOUT, (void*) &value);
      }
    }

    public unsafe List<ServerListEntryData> _ServerListEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ServerListEntries));
        return pointer == System.IntPtr.Zero ? (List<ServerListEntryData>) null : new List<ServerListEntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ServerListEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<string, int> _ServerListEntriesLookup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ServerListEntriesLookup));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, int>) null : new Dictionary<string, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ServerListEntriesLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<FriendSession> _SessionsWithFriends
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__SessionsWithFriends));
        return pointer == System.IntPtr.Zero ? (List<FriendSession>) null : new List<FriendSession>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__SessionsWithFriends), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double _RefreshTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__RefreshTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__RefreshTime)) = value;
      }
    }

    public unsafe bool _RefreshInProgress
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__RefreshInProgress));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__RefreshInProgress)) = value;
      }
    }

    public unsafe HServerListRequest _RequestHandle
    {
      get
      {
        return *(HServerListRequest*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__RequestHandle));
      }
      [param: In] set
      {
        *(HServerListRequest*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__RequestHandle)) = value;
      }
    }

    public unsafe HServerListRequest _LANRequestHandle
    {
      get
      {
        return *(HServerListRequest*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__LANRequestHandle));
      }
      [param: In] set
      {
        *(HServerListRequest*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__LANRequestHandle)) = value;
      }
    }

    public unsafe EOSPlatformSystem _EOSPlatformSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__EOSPlatformSystem));
        return pointer == System.IntPtr.Zero ? (EOSPlatformSystem) null : new EOSPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__EOSPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int HIGH_PING_VALUE
    {
      get
      {
        int highPingValue;
        IL2CPP.il2cpp_field_static_get_value(ServerListSystem.NativeFieldInfoPtr_HIGH_PING_VALUE, (void*) &highPingValue);
        return highPingValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerListSystem.NativeFieldInfoPtr_HIGH_PING_VALUE, (void*) &value);
      }
    }

    public unsafe List<ServerListEntryUIData> _CachedResult
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__CachedResult));
        return pointer == System.IntPtr.Zero ? (List<ServerListEntryUIData>) null : new List<ServerListEntryUIData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__CachedResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double _NextGetInternalResultsTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__NextGetInternalResultsTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__NextGetInternalResultsTime)) = value;
      }
    }

    public Il2CppSystem.Nullable<ServerListFilterOptions> _LastFilterOptions
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__LastFilterOptions);
        return new Il2CppSystem.Nullable<ServerListFilterOptions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerListFilterOptions>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__LastFilterOptions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerListFilterOptions>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ServerListSorting _LastServerListSorting
    {
      get
      {
        return *(ServerListSorting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__LastServerListSorting));
      }
      [param: In] set
      {
        *(ServerListSorting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__LastServerListSorting)) = value;
      }
    }

    public unsafe Dictionary<string, double> _NextPingRequestTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__NextPingRequestTime));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, double>) null : new Dictionary<string, double>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__NextPingRequestTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe float PingRequestDelays
    {
      get
      {
        float pingRequestDelays;
        IL2CPP.il2cpp_field_static_get_value(ServerListSystem.NativeFieldInfoPtr_PingRequestDelays, (void*) &pingRequestDelays);
        return pingRequestDelays;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerListSystem.NativeFieldInfoPtr_PingRequestDelays, (void*) &value);
      }
    }

    public static unsafe float ForcedPingRequestDelay
    {
      get
      {
        float pingRequestDelay;
        IL2CPP.il2cpp_field_static_get_value(ServerListSystem.NativeFieldInfoPtr_ForcedPingRequestDelay, (void*) &pingRequestDelay);
        return pingRequestDelay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerListSystem.NativeFieldInfoPtr_ForcedPingRequestDelay, (void*) &value);
      }
    }

    public unsafe double _PreviousEosSearch
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__PreviousEosSearch));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__PreviousEosSearch)) = value;
      }
    }

    public unsafe double _ContinueTypingDeadline
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ContinueTypingDeadline));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ContinueTypingDeadline)) = value;
      }
    }

    public unsafe bool _EosSearchScheduled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__EosSearchScheduled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__EosSearchScheduled)) = value;
      }
    }

    public static unsafe double _EosServerSearchRateLimit
    {
      get
      {
        double serverSearchRateLimit;
        IL2CPP.il2cpp_field_static_get_value(ServerListSystem.NativeFieldInfoPtr__EosServerSearchRateLimit, (void*) &serverSearchRateLimit);
        return serverSearchRateLimit;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerListSystem.NativeFieldInfoPtr__EosServerSearchRateLimit, (void*) &value);
      }
    }

    public static unsafe double _WaitUntilSearchWhenTyping
    {
      get
      {
        double searchWhenTyping;
        IL2CPP.il2cpp_field_static_get_value(ServerListSystem.NativeFieldInfoPtr__WaitUntilSearchWhenTyping, (void*) &searchWhenTyping);
        return searchWhenTyping;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerListSystem.NativeFieldInfoPtr__WaitUntilSearchWhenTyping, (void*) &value);
      }
    }

    public unsafe bool _EosRefreshInProgress
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__EosRefreshInProgress));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__EosRefreshInProgress)) = value;
      }
    }

    public unsafe SessionSearchPaginated _SearchHandle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__SearchHandle));
        return pointer == System.IntPtr.Zero ? (SessionSearchPaginated) null : new SessionSearchPaginated(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__SearchHandle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<SearchCriteron> _CurrentSearchCriteria
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__CurrentSearchCriteria));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SearchCriteron>) null : new Il2CppReferenceArray<SearchCriteron>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__CurrentSearchCriteria), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Queue<ServerListEntryData> _ToPingLowPriority
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ToPingLowPriority));
        return pointer == System.IntPtr.Zero ? (Queue<ServerListEntryData>) null : new Queue<ServerListEntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ToPingLowPriority), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Queue<ServerListEntryData> _ToPing
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ToPing));
        return pointer == System.IntPtr.Zero ? (Queue<ServerListEntryData>) null : new Queue<ServerListEntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__ToPing), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<string, SteamPlatformSystem.PingHandle> _PingStarted
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__PingStarted));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, SteamPlatformSystem.PingHandle>) null : new Dictionary<string, SteamPlatformSystem.PingHandle>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__PingStarted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<string> _PingUnavailable
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__PingUnavailable));
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.NativeFieldInfoPtr__PingUnavailable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.ServerListSystem/<>c__DisplayClass16_0")]
    public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetFilteredServerListEntries_b__3_Internal_Boolean_FriendSession_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass16_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284844, XrefRangeEnd = 1284845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _GetFilteredServerListEntries_b__3(FriendSession x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__GetFilteredServerListEntries_b__3_Internal_Boolean_FriendSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass16_0()
      {
        Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, "<>c__DisplayClass16_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_0>.NativeClassPtr);
        ServerListSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (entry));
        ServerListSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_0>.NativeClassPtr, 100669376);
        ServerListSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__GetFilteredServerListEntries_b__3_Internal_Boolean_FriendSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_0>.NativeClassPtr, 100669377);
      }

      public __c__DisplayClass16_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ServerListEntryData entry
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_entry);
          return new ServerListEntryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_entry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServerListSystem/<>c__DisplayClass16_1")]
    public sealed class __c__DisplayClass16_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionId;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetFilteredServerListEntries_b__4_Internal_Boolean_FriendSession_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass16_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _GetFilteredServerListEntries_b__4(FriendSession x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass16_1.NativeMethodInfoPtr__GetFilteredServerListEntries_b__4_Internal_Boolean_FriendSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass16_1()
      {
        Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, "<>c__DisplayClass16_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_1>.NativeClassPtr);
        ServerListSystem.__c__DisplayClass16_1.NativeFieldInfoPtr_sessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_1>.NativeClassPtr, nameof (sessionId));
        ServerListSystem.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_1>.NativeClassPtr, 100669378);
        ServerListSystem.__c__DisplayClass16_1.NativeMethodInfoPtr__GetFilteredServerListEntries_b__4_Internal_Boolean_FriendSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass16_1>.NativeClassPtr, 100669379);
      }

      public __c__DisplayClass16_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string sessionId
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass16_1.NativeFieldInfoPtr_sessionId)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass16_1.NativeFieldInfoPtr_sessionId), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServerListSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_5;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__25_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_5_Internal_String_FriendSession_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_0_Internal_Single_ServerListEntryUIData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_1_Internal_String_ServerListEntryUIData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_2_Internal_Int32_ServerListEntryUIData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__25_1_Internal_Void_EMatchMakingServerResponse_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe string _GetFilteredServerListEntries_b__16_5(FriendSession x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c.NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_5_Internal_String_FriendSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      public unsafe float _GetFilteredServerListEntries_b__16_0(ServerListEntryUIData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c.NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_0_Internal_Single_ServerListEntryUIData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe string _GetFilteredServerListEntries_b__16_1(ServerListEntryUIData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c.NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_1_Internal_String_ServerListEntryUIData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      public unsafe int _GetFilteredServerListEntries_b__16_2(ServerListEntryUIData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c.NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_2_Internal_Int32_ServerListEntryUIData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284845, XrefRangeEnd = 1284855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Refresh_b__25_1(EMatchMakingServerResponse response)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &response;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c.NativeMethodInfoPtr__Refresh_b__25_1_Internal_Void_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr);
        ServerListSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, "<>9");
        ServerListSystem.__c.NativeFieldInfoPtr___9__16_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, "<>9__16_5");
        ServerListSystem.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, "<>9__16_0");
        ServerListSystem.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, "<>9__16_1");
        ServerListSystem.__c.NativeFieldInfoPtr___9__16_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, "<>9__16_2");
        ServerListSystem.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, "<>9__25_1");
        ServerListSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, 100669381);
        ServerListSystem.__c.NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_5_Internal_String_FriendSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, 100669382);
        ServerListSystem.__c.NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_0_Internal_Single_ServerListEntryUIData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, 100669383);
        ServerListSystem.__c.NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_1_Internal_String_ServerListEntryUIData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, 100669384);
        ServerListSystem.__c.NativeMethodInfoPtr__GetFilteredServerListEntries_b__16_2_Internal_Int32_ServerListEntryUIData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, 100669385);
        ServerListSystem.__c.NativeMethodInfoPtr__Refresh_b__25_1_Internal_Void_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c>.NativeClassPtr, 100669386);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ServerListSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerListSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ServerListSystem.__c) null : new ServerListSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerListSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<FriendSession, string> __9__16_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerListSystem.__c.NativeFieldInfoPtr___9__16_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<FriendSession, string>) null : new Il2CppSystem.Func<FriendSession, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerListSystem.__c.NativeFieldInfoPtr___9__16_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ServerListEntryUIData, float> __9__16_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerListSystem.__c.NativeFieldInfoPtr___9__16_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ServerListEntryUIData, float>) null : new Il2CppSystem.Func<ServerListEntryUIData, float>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerListSystem.__c.NativeFieldInfoPtr___9__16_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ServerListEntryUIData, string> __9__16_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerListSystem.__c.NativeFieldInfoPtr___9__16_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ServerListEntryUIData, string>) null : new Il2CppSystem.Func<ServerListEntryUIData, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerListSystem.__c.NativeFieldInfoPtr___9__16_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ServerListEntryUIData, int> __9__16_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerListSystem.__c.NativeFieldInfoPtr___9__16_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ServerListEntryUIData, int>) null : new Il2CppSystem.Func<ServerListEntryUIData, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerListSystem.__c.NativeFieldInfoPtr___9__16_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<EMatchMakingServerResponse> __9__25_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerListSystem.__c.NativeFieldInfoPtr___9__25_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<EMatchMakingServerResponse>) null : new Il2CppSystem.Action<EMatchMakingServerResponse>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerListSystem.__c.NativeFieldInfoPtr___9__25_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServerListSystem/<>c__DisplayClass24_0")]
    public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PingServer_b__0_Internal_Void_Nullable_1_ServerListEntryData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass24_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass24_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284855, XrefRangeEnd = 1284863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PingServer_b__0(Il2CppSystem.Nullable<ServerListEntryData> data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__PingServer_b__0_Internal_Void_Nullable_1_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass24_0()
      {
        Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, "<>c__DisplayClass24_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass24_0>.NativeClassPtr);
        ServerListSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_sessionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (sessionGUID));
        ServerListSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
        ServerListSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass24_0>.NativeClassPtr, 100669387);
        ServerListSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__PingServer_b__0_Internal_Void_Nullable_1_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass24_0>.NativeClassPtr, 100669388);
      }

      public __c__DisplayClass24_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string sessionGUID
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_sessionGUID)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_sessionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe ServerListSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerListSystem) null : new ServerListSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServerListSystem/<>c__DisplayClass25_0")]
    public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_initialRefresh;
      private static readonly System.IntPtr NativeFieldInfoPtr_steamPlatformSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__6;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__3_Internal_Void_ServerListEntryData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__5_Internal_Void_ServerListEntryData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__6_Internal_Void_EMatchMakingServerResponse_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__0_Internal_Void_ServerListEntryData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__2_Internal_Void_Nullable_1_ServerListEntryData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass25_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284863, XrefRangeEnd = 1284864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Refresh_b__3(ServerListEntryData newEntry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newEntry));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__3_Internal_Void_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Refresh_b__5(ServerListEntryData newEntry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newEntry));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__5_Internal_Void_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284864, XrefRangeEnd = 1284874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Refresh_b__6(EMatchMakingServerResponse response2)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &response2;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__6_Internal_Void_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Refresh_b__0(ServerListEntryData newEntry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newEntry));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__0_Internal_Void_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284874, XrefRangeEnd = 1284879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Refresh_b__2(Il2CppSystem.Nullable<ServerListEntryData> data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__2_Internal_Void_Nullable_1_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass25_0()
      {
        Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, "<>c__DisplayClass25_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr);
        ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
        ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_initialRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, nameof (initialRefresh));
        ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_steamPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, nameof (steamPlatformSystem));
        ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, "<>9__5");
        ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, "<>9__6");
        ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, 100669389);
        ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__3_Internal_Void_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, 100669390);
        ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__5_Internal_Void_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, 100669391);
        ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__6_Internal_Void_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, 100669392);
        ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__0_Internal_Void_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, 100669393);
        ServerListSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__Refresh_b__2_Internal_Void_Nullable_1_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_0>.NativeClassPtr, 100669394);
      }

      public __c__DisplayClass25_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ServerListSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerListSystem) null : new ServerListSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool initialRefresh
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_initialRefresh));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_initialRefresh)) = value;
        }
      }

      public unsafe SteamPlatformSystem steamPlatformSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_steamPlatformSystem));
          return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_steamPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action<ServerListEntryData> __9__5
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___9__5));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ServerListEntryData>) null : new Il2CppSystem.Action<ServerListEntryData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action<EMatchMakingServerResponse> __9__6
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___9__6));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<EMatchMakingServerResponse>) null : new Il2CppSystem.Action<EMatchMakingServerResponse>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServerListSystem/<>c__DisplayClass25_1")]
    public sealed class __c__DisplayClass25_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_options;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__4_Internal_Void_EMatchMakingServerResponse_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass25_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284879, XrefRangeEnd = 1284896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Refresh_b__4(EMatchMakingServerResponse response2)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &response2;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass25_1.NativeMethodInfoPtr__Refresh_b__4_Internal_Void_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass25_1()
      {
        Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, "<>c__DisplayClass25_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_1>.NativeClassPtr);
        ServerListSystem.__c__DisplayClass25_1.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_1>.NativeClassPtr, nameof (options));
        ServerListSystem.__c__DisplayClass25_1.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_1>.NativeClassPtr, "CS$<>8__locals1");
        ServerListSystem.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_1>.NativeClassPtr, 100669395);
        ServerListSystem.__c__DisplayClass25_1.NativeMethodInfoPtr__Refresh_b__4_Internal_Void_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass25_1>.NativeClassPtr, 100669396);
      }

      public __c__DisplayClass25_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SteamPlatformSystem.RequestServerListOptions options
      {
        get
        {
          return *(SteamPlatformSystem.RequestServerListOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_1.NativeFieldInfoPtr_options));
        }
        [param: In] set
        {
          *(SteamPlatformSystem.RequestServerListOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_1.NativeFieldInfoPtr_options)) = value;
        }
      }

      public unsafe ServerListSystem.__c__DisplayClass25_0 field_Public___c__DisplayClass25_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_1.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0));
          return pointer == System.IntPtr.Zero ? (ServerListSystem.__c__DisplayClass25_0) null : new ServerListSystem.__c__DisplayClass25_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass25_1.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServerListSystem/<>c__DisplayClass59_0")]
    public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_data2;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddToEOSPingQueue_b__2_Internal_Void_Nullable_1_ServerListEntryData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass59_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass59_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284896, XrefRangeEnd = 1284897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddToEOSPingQueue_b__2(Il2CppSystem.Nullable<ServerListEntryData> newData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newData));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListSystem.__c__DisplayClass59_0.NativeMethodInfoPtr__AddToEOSPingQueue_b__2_Internal_Void_Nullable_1_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass59_0()
      {
        Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListSystem>.NativeClassPtr, "<>c__DisplayClass59_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass59_0>.NativeClassPtr);
        ServerListSystem.__c__DisplayClass59_0.NativeFieldInfoPtr_data2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass59_0>.NativeClassPtr, nameof (data2));
        ServerListSystem.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass59_0>.NativeClassPtr, "<>4__this");
        ServerListSystem.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass59_0>.NativeClassPtr, 100669397);
        ServerListSystem.__c__DisplayClass59_0.NativeMethodInfoPtr__AddToEOSPingQueue_b__2_Internal_Void_Nullable_1_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListSystem.__c__DisplayClass59_0>.NativeClassPtr, 100669398);
      }

      public __c__DisplayClass59_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ServerListEntryData data2
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass59_0.NativeFieldInfoPtr_data2);
          return new ServerListEntryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass59_0.NativeFieldInfoPtr_data2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServerListSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerListSystem) null : new ServerListSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListSystem.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
