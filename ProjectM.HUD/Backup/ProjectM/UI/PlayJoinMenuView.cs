// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PlayJoinMenuView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using ProjectM.Network;
using ProjectM.Shared;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class PlayJoinMenuView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MainStateBackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectStateBackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectConnectButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowMoreServersButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdvancedFiltersButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefreshButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefreshButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Refresh;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_StopRefresh;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefreshImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostSoloOrCoopButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostServerButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdvancedServerListButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerInfoContainer;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectPvEButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectPvPButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectPvPlusButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOnlyWithCharacterToggle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowPasswordProtectedToggle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowEmptyToggle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowFullToggle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowDedicated;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowStandardSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowScheduledWipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainContentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectContentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PopupParentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_BasicConfirmPopup;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecommendedOnlyContentRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardContentRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdvancedFiltersRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_Any;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_PvE;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_PvP;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectConnectPopup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerSettingDetailsPopup;
    private static readonly System.IntPtr NativeFieldInfoPtr_SearchInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeDropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_HardcoreSettingDropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_OrderByDropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSizeDropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_LatencyDropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_HardcoreOn;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_HardcoreOff;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_HardcoreAny;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_OrderByPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_OrderByName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_OrderByPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSizeAny;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSizeSolo;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSizeDuo;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSizeSquad;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_TerritoryWarningHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_TerritoryWarningDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActivePopup;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryClient;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConnectDiscoveryServer;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedServerListEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__FilteredServerListEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerListEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListScrollRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListEntriesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServersCountText;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoServerAvailableText;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoRecommendedServersAvailable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListHeaders;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedSession;
    private static readonly System.IntPtr NativeFieldInfoPtr__ShowOnlyRecommended;
    private static readonly System.IntPtr NativeFieldInfoPtr__ShowAdvancedFilters;
    private static readonly System.IntPtr NativeFieldInfoPtr__ViewState;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_GameMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_HardCore;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_ClanSize;
    private static readonly System.IntPtr NativeFieldInfoPtr__JoinModeAdvanced;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerListSorting;
    private static readonly System.IntPtr NativeFieldInfoPtr__LatencyIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__Password;
    private static readonly System.IntPtr NativeFieldInfoPtr__SetPasswordFocus;
    private static readonly System.IntPtr NativeFieldInfoPtr__LatencySettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_ShowOnlyWithCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_ShowPasswordProtected;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_ShowEmpty;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_ShowFull;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_ShowDedicated;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_ShowScheduledWipes;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filter_ShowStandardSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_SHOW_ONLY_WITH_CHARACTER;
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_SHOW_ONLY_DEDICATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_SHOW_ONLY_STANDARD_SETTINGS;
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_SHOW_SCHEDULED_WIPES;
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_SHOW_PASSWORD_PROTECTED;
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_SHOW_EMPTY;
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_SHOW_FULL;
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_MAX_LATENCY;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrioritySettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConnectCheckServers;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviousIsRefreshing;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerRules;
    private static readonly System.IntPtr NativeFieldInfoPtr__DescriptionSB;
    private static readonly System.IntPtr NativeFieldInfoPtr__SettingsSB;
    private static readonly System.IntPtr NativeFieldInfoPtr__BloodBoundEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleHeartDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerHistory;
    private static readonly System.IntPtr NativeFieldInfoPtr__DaysRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr__DaysUntilReset;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DiscoveyTime_Private_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitFilters_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Private_Void_byref_Boolean_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFilter_GameMode_Private_Void_GameModeTypeFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFilter_HardCore_Private_Void_FilterSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetServerListSorting_Private_Void_ServerListSorting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetClanSizeFilter_Private_Void_ClanSizeFilterSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFilter_Latency_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Private_Void_JoinMenuState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitInitData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Back_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_DirectConnect_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Join_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LaunchGameHelper_Private_Static_Void_String_UInt16_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenPopup_Private_Void_SimplePopupBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoBack_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentServerListFilter_Private_ServerListFilterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentSortingOrder_Private_ServerListSorting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateServerInfoView_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServerRules_Private_Void_UInt32_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConnectDiscovery_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateState_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_2_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_3_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_5_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_6_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_7_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_8_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_9_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_10_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_11_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitFilters_b__106_0_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitFilters_b__106_1_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitFilters_b__106_2_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitFilters_b__106_3_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitFilters_b__106_4_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitFilters_b__106_5_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitFilters_b__106_6_Private_Void_Boolean_0;

    public unsafe float DiscoveyTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283844, XrefRangeEnd = 1283845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_get_DiscoveyTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283845, XrefRangeEnd = 1284171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1284259, RefRangeEnd = 1284260, XrefRangeStart = 1284171, XrefRangeEnd = 1284259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitFilters()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_InitFilters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284260, XrefRangeEnd = 1284261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBool(ref bool filter, bool v, string prefsKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefsKey);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_SetBool_Private_Void_byref_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284261, XrefRangeEnd = 1284263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFilter_GameMode(GameModeTypeFilter gameMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &gameMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_SetFilter_GameMode_Private_Void_GameModeTypeFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284263, XrefRangeEnd = 1284265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFilter_HardCore(FilterSetting setting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &setting;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_SetFilter_HardCore_Private_Void_FilterSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284265, XrefRangeEnd = 1284267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetServerListSorting(ServerListSorting setting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &setting;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_SetServerListSorting_Private_Void_ServerListSorting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284267, XrefRangeEnd = 1284269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetClanSizeFilter(ClanSizeFilterSetting setting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &setting;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_SetClanSizeFilter_Private_Void_ClanSizeFilterSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284269, XrefRangeEnd = 1284274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFilter_Latency(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_SetFilter_Latency_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetState(JoinMenuState newState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_SetState_Private_Void_JoinMenuState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284274, XrefRangeEnd = 1284287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1284320, RefRangeEnd = 1284321, XrefRangeStart = 1284287, XrefRangeEnd = 1284320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitInitData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_InitInitData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284321, XrefRangeEnd = 1284323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284323, XrefRangeEnd = 1284324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Back()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_OnButtonClick_Back_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284324, XrefRangeEnd = 1284325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_DirectConnect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_OnButtonClick_DirectConnect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1284365, RefRangeEnd = 1284367, XrefRangeStart = 1284325, XrefRangeEnd = 1284365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Join()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_OnButtonClick_Join_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1284371, RefRangeEnd = 1284372, XrefRangeStart = 1284367, XrefRangeEnd = 1284371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LaunchGameHelper(string ipAddress, ushort port, string password)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(ipAddress);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(password);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_LaunchGameHelper_Private_Static_Void_String_UInt16_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1284379, RefRangeEnd = 1284382, XrefRangeStart = 1284372, XrefRangeEnd = 1284379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenPopup(SimplePopupBase popup)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) popup);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_OpenPopup_Private_Void_SimplePopupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284382, XrefRangeEnd = 1284390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GoBack()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284390, XrefRangeEnd = 1284515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284515, XrefRangeEnd = 1284519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerListFilterOptions GetCurrentServerListFilter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_GetCurrentServerListFilter_Private_ServerListFilterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new ServerListFilterOptions(pointer);
    }

    [CallerCount(0)]
    public unsafe ServerListSorting GetCurrentSortingOrder()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_GetCurrentSortingOrder_Private_ServerListSorting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerListSorting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1284543, RefRangeEnd = 1284544, XrefRangeStart = 1284519, XrefRangeEnd = 1284543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateServerInfoView()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_UpdateServerInfoView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1284574, RefRangeEnd = 1284575, XrefRangeStart = 1284544, XrefRangeEnd = 1284574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetServerRules(uint ipAddressInt, ushort queryPort)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &ipAddressInt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &queryPort;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_GetServerRules_Private_Void_UInt32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284575, XrefRangeEnd = 1284591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesResponded(string ruleKey, string ruleValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(ruleKey);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(ruleValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284591, XrefRangeEnd = 1284597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesFailedToRespond()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284597, XrefRangeEnd = 1284702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesRefreshComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1284720, RefRangeEnd = 1284721, XrefRangeStart = 1284702, XrefRangeEnd = 1284720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateConnectDiscovery()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_UpdateConnectDiscovery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284721, XrefRangeEnd = 1284723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr_UpdateState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284723, XrefRangeEnd = 1284798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayJoinMenuView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284798, XrefRangeEnd = 1284801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284801, XrefRangeEnd = 1284802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284802, XrefRangeEnd = 1284805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284805, XrefRangeEnd = 1284808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284808, XrefRangeEnd = 1284809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284809, XrefRangeEnd = 1284811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_6(string newVal)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(newVal);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_6_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284811, XrefRangeEnd = 1284813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_7(string newVal)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(newVal);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_7_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_8(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_8_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_9(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_9_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_10(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_10_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__105_11(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_11_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284813, XrefRangeEnd = 1284816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitFilters_b__106_0(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284816, XrefRangeEnd = 1284819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitFilters_b__106_1(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284819, XrefRangeEnd = 1284822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitFilters_b__106_2(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_2_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284822, XrefRangeEnd = 1284825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitFilters_b__106_3(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_3_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284825, XrefRangeEnd = 1284828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitFilters_b__106_4(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_4_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284828, XrefRangeEnd = 1284831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitFilters_b__106_5(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284831, XrefRangeEnd = 1284834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitFilters_b__106_6(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_6_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayJoinMenuView()
    {
      Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PlayJoinMenuView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr);
      PlayJoinMenuView.NativeFieldInfoPtr_MainStateBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (MainStateBackButton));
      PlayJoinMenuView.NativeFieldInfoPtr_SelectStateBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (SelectStateBackButton));
      PlayJoinMenuView.NativeFieldInfoPtr_DirectConnectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (DirectConnectButton));
      PlayJoinMenuView.NativeFieldInfoPtr_JoinButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (JoinButton));
      PlayJoinMenuView.NativeFieldInfoPtr_ShowMoreServersButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ShowMoreServersButton));
      PlayJoinMenuView.NativeFieldInfoPtr_AdvancedFiltersButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (AdvancedFiltersButton));
      PlayJoinMenuView.NativeFieldInfoPtr_RefreshButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (RefreshButton));
      PlayJoinMenuView.NativeFieldInfoPtr_RefreshButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (RefreshButtonText));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_Refresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_Refresh));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_StopRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_StopRefresh));
      PlayJoinMenuView.NativeFieldInfoPtr_RefreshImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (RefreshImage));
      PlayJoinMenuView.NativeFieldInfoPtr_HostSoloOrCoopButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (HostSoloOrCoopButton));
      PlayJoinMenuView.NativeFieldInfoPtr_HostServerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (HostServerButton));
      PlayJoinMenuView.NativeFieldInfoPtr_AdvancedServerListButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (AdvancedServerListButton));
      PlayJoinMenuView.NativeFieldInfoPtr_ServerInfoContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ServerInfoContainer));
      PlayJoinMenuView.NativeFieldInfoPtr_SelectPvEButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (SelectPvEButton));
      PlayJoinMenuView.NativeFieldInfoPtr_SelectPvPButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (SelectPvPButton));
      PlayJoinMenuView.NativeFieldInfoPtr_SelectPvPlusButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (SelectPvPlusButton));
      PlayJoinMenuView.NativeFieldInfoPtr_ShowOnlyWithCharacterToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ShowOnlyWithCharacterToggle));
      PlayJoinMenuView.NativeFieldInfoPtr_ShowPasswordProtectedToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ShowPasswordProtectedToggle));
      PlayJoinMenuView.NativeFieldInfoPtr_ShowEmptyToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ShowEmptyToggle));
      PlayJoinMenuView.NativeFieldInfoPtr_ShowFullToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ShowFullToggle));
      PlayJoinMenuView.NativeFieldInfoPtr_ShowDedicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ShowDedicated));
      PlayJoinMenuView.NativeFieldInfoPtr_ShowStandardSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ShowStandardSettings));
      PlayJoinMenuView.NativeFieldInfoPtr_ShowScheduledWipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ShowScheduledWipes));
      PlayJoinMenuView.NativeFieldInfoPtr_MainContentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (MainContentNode));
      PlayJoinMenuView.NativeFieldInfoPtr_SelectContentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (SelectContentNode));
      PlayJoinMenuView.NativeFieldInfoPtr_PopupParentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PopupParentNode));
      PlayJoinMenuView.NativeFieldInfoPtr_BasicConfirmPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (BasicConfirmPopup));
      PlayJoinMenuView.NativeFieldInfoPtr_RecommendedOnlyContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (RecommendedOnlyContentRect));
      PlayJoinMenuView.NativeFieldInfoPtr_StandardContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (StandardContentRect));
      PlayJoinMenuView.NativeFieldInfoPtr_AdvancedFiltersRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (AdvancedFiltersRect));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_GameMode_Any));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_PvE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_GameMode_PvE));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_PvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_GameMode_PvP));
      PlayJoinMenuView.NativeFieldInfoPtr_DirectConnectPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (DirectConnectPopup));
      PlayJoinMenuView.NativeFieldInfoPtr_ServerSettingDetailsPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ServerSettingDetailsPopup));
      PlayJoinMenuView.NativeFieldInfoPtr_SearchInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (SearchInput));
      PlayJoinMenuView.NativeFieldInfoPtr_GameModeDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (GameModeDropdown));
      PlayJoinMenuView.NativeFieldInfoPtr_HardcoreSettingDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (HardcoreSettingDropdown));
      PlayJoinMenuView.NativeFieldInfoPtr_OrderByDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (OrderByDropdown));
      PlayJoinMenuView.NativeFieldInfoPtr_ClanSizeDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ClanSizeDropdown));
      PlayJoinMenuView.NativeFieldInfoPtr_LatencyDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LatencyDropdown));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_HardcoreOn));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_HardcoreOff));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_HardcoreAny));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_OrderByPriority));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_OrderByName));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_OrderByPlayers));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_ClanSizeAny));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeSolo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_ClanSizeSolo));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeDuo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_ClanSizeDuo));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeSquad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_ClanSizeSquad));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_TerritoryWarningHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_TerritoryWarningHeader));
      PlayJoinMenuView.NativeFieldInfoPtr_LK_TerritoryWarningDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LK_TerritoryWarningDescription));
      PlayJoinMenuView.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_InputSystem));
      PlayJoinMenuView.NativeFieldInfoPtr__ActivePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ActivePopup));
      PlayJoinMenuView.NativeFieldInfoPtr__DiscoveryClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_DiscoveryClient));
      PlayJoinMenuView.NativeFieldInfoPtr__DiscoveryStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_DiscoveryStartTime));
      PlayJoinMenuView.NativeFieldInfoPtr__ConnectDiscoveryServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ConnectDiscoveryServer));
      PlayJoinMenuView.NativeFieldInfoPtr__CachedServerListEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_CachedServerListEntries));
      PlayJoinMenuView.NativeFieldInfoPtr__FilteredServerListEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_FilteredServerListEntries));
      PlayJoinMenuView.NativeFieldInfoPtr__ServerListEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ServerListEntries));
      PlayJoinMenuView.NativeFieldInfoPtr_ServerListScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ServerListScrollRect));
      PlayJoinMenuView.NativeFieldInfoPtr_ServerListEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ServerListEntryPrefab));
      PlayJoinMenuView.NativeFieldInfoPtr_ServerListEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ServerListEntriesParent));
      PlayJoinMenuView.NativeFieldInfoPtr_ServersCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ServersCountText));
      PlayJoinMenuView.NativeFieldInfoPtr_NoServerAvailableText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (NoServerAvailableText));
      PlayJoinMenuView.NativeFieldInfoPtr_NoRecommendedServersAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (NoRecommendedServersAvailable));
      PlayJoinMenuView.NativeFieldInfoPtr_ServerListHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (ServerListHeaders));
      PlayJoinMenuView.NativeFieldInfoPtr__SelectedSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_SelectedSession));
      PlayJoinMenuView.NativeFieldInfoPtr__ShowOnlyRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ShowOnlyRecommended));
      PlayJoinMenuView.NativeFieldInfoPtr__ShowAdvancedFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ShowAdvancedFilters));
      PlayJoinMenuView.NativeFieldInfoPtr__ViewState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ViewState));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_GameMode));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_HardCore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_HardCore));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_ClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_ClanSize));
      PlayJoinMenuView.NativeFieldInfoPtr__JoinModeAdvanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_JoinModeAdvanced));
      PlayJoinMenuView.NativeFieldInfoPtr__ServerListSorting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ServerListSorting));
      PlayJoinMenuView.NativeFieldInfoPtr__LatencyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_LatencyIndex));
      PlayJoinMenuView.NativeFieldInfoPtr__Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Password));
      PlayJoinMenuView.NativeFieldInfoPtr__SetPasswordFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_SetPasswordFocus));
      PlayJoinMenuView.NativeFieldInfoPtr__LatencySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_LatencySettings));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowOnlyWithCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_ShowOnlyWithCharacter));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowPasswordProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_ShowPasswordProtected));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_ShowEmpty));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_ShowFull));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowDedicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_ShowDedicated));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowScheduledWipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_ShowScheduledWipes));
      PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowStandardSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_Filter_ShowStandardSettings));
      PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_WITH_CHARACTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PREFS_SHOW_ONLY_WITH_CHARACTER));
      PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_DEDICATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PREFS_SHOW_ONLY_DEDICATED));
      PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_STANDARD_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PREFS_SHOW_ONLY_STANDARD_SETTINGS));
      PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_SCHEDULED_WIPES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PREFS_SHOW_SCHEDULED_WIPES));
      PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_PASSWORD_PROTECTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PREFS_SHOW_PASSWORD_PROTECTED));
      PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_EMPTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PREFS_SHOW_EMPTY));
      PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_FULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PREFS_SHOW_FULL));
      PlayJoinMenuView.NativeFieldInfoPtr_PREFS_MAX_LATENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PREFS_MAX_LATENCY));
      PlayJoinMenuView.NativeFieldInfoPtr_PrioritySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (PrioritySettings));
      PlayJoinMenuView.NativeFieldInfoPtr__SelectedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_SelectedEntry));
      PlayJoinMenuView.NativeFieldInfoPtr__ConnectCheckServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ConnectCheckServers));
      PlayJoinMenuView.NativeFieldInfoPtr__PreviousIsRefreshing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_PreviousIsRefreshing));
      PlayJoinMenuView.NativeFieldInfoPtr__ServerRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ServerRules));
      PlayJoinMenuView.NativeFieldInfoPtr__DescriptionSB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_DescriptionSB));
      PlayJoinMenuView.NativeFieldInfoPtr__SettingsSB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_SettingsSB));
      PlayJoinMenuView.NativeFieldInfoPtr__BloodBoundEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_BloodBoundEnabled));
      PlayJoinMenuView.NativeFieldInfoPtr__CastleHeartDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_CastleHeartDamageMode));
      PlayJoinMenuView.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_BalanceSettings));
      PlayJoinMenuView.NativeFieldInfoPtr__ServerHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_ServerHistory));
      PlayJoinMenuView.NativeFieldInfoPtr__DaysRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_DaysRunning));
      PlayJoinMenuView.NativeFieldInfoPtr__DaysUntilReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (_DaysUntilReset));
      PlayJoinMenuView.NativeMethodInfoPtr_get_DiscoveyTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669273);
      PlayJoinMenuView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669274);
      PlayJoinMenuView.NativeMethodInfoPtr_InitFilters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669275);
      PlayJoinMenuView.NativeMethodInfoPtr_SetBool_Private_Void_byref_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669276);
      PlayJoinMenuView.NativeMethodInfoPtr_SetFilter_GameMode_Private_Void_GameModeTypeFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669277);
      PlayJoinMenuView.NativeMethodInfoPtr_SetFilter_HardCore_Private_Void_FilterSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669278);
      PlayJoinMenuView.NativeMethodInfoPtr_SetServerListSorting_Private_Void_ServerListSorting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669279);
      PlayJoinMenuView.NativeMethodInfoPtr_SetClanSizeFilter_Private_Void_ClanSizeFilterSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669280);
      PlayJoinMenuView.NativeMethodInfoPtr_SetFilter_Latency_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669281);
      PlayJoinMenuView.NativeMethodInfoPtr_SetState_Private_Void_JoinMenuState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669282);
      PlayJoinMenuView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669283);
      PlayJoinMenuView.NativeMethodInfoPtr_InitInitData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669284);
      PlayJoinMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669285);
      PlayJoinMenuView.NativeMethodInfoPtr_OnButtonClick_Back_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669286);
      PlayJoinMenuView.NativeMethodInfoPtr_OnButtonClick_DirectConnect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669287);
      PlayJoinMenuView.NativeMethodInfoPtr_OnButtonClick_Join_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669288);
      PlayJoinMenuView.NativeMethodInfoPtr_LaunchGameHelper_Private_Static_Void_String_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669289);
      PlayJoinMenuView.NativeMethodInfoPtr_OpenPopup_Private_Void_SimplePopupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669290);
      PlayJoinMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669291);
      PlayJoinMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669292);
      PlayJoinMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669293);
      PlayJoinMenuView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669294);
      PlayJoinMenuView.NativeMethodInfoPtr_GetCurrentServerListFilter_Private_ServerListFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669295);
      PlayJoinMenuView.NativeMethodInfoPtr_GetCurrentSortingOrder_Private_ServerListSorting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669296);
      PlayJoinMenuView.NativeMethodInfoPtr_UpdateServerInfoView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669297);
      PlayJoinMenuView.NativeMethodInfoPtr_GetServerRules_Private_Void_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669298);
      PlayJoinMenuView.NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669299);
      PlayJoinMenuView.NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669300);
      PlayJoinMenuView.NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669301);
      PlayJoinMenuView.NativeMethodInfoPtr_UpdateConnectDiscovery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669302);
      PlayJoinMenuView.NativeMethodInfoPtr_UpdateState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669303);
      PlayJoinMenuView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669304);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669305);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669306);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669307);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669308);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669309);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_6_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669310);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_7_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669311);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_8_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669312);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_9_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669313);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_10_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669314);
      PlayJoinMenuView.NativeMethodInfoPtr__Awake_b__105_11_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669315);
      PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669316);
      PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669317);
      PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_2_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669318);
      PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_3_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669319);
      PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_4_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669320);
      PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669321);
      PlayJoinMenuView.NativeMethodInfoPtr__InitFilters_b__106_6_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, 100669322);
    }

    public PlayJoinMenuView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton MainStateBackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_MainStateBackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_MainStateBackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectStateBackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectStateBackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectStateBackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DirectConnectButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_DirectConnectButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_DirectConnectButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton JoinButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_JoinButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_JoinButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ShowMoreServersButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowMoreServersButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowMoreServersButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AdvancedFiltersButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_AdvancedFiltersButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_AdvancedFiltersButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton RefreshButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_RefreshButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_RefreshButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText RefreshButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_RefreshButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_RefreshButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_Refresh
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_Refresh));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_Refresh)) = value;
      }
    }

    public unsafe LocalizationKey LK_StopRefresh
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_StopRefresh));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_StopRefresh)) = value;
      }
    }

    public unsafe Image RefreshImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_RefreshImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_RefreshImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostSoloOrCoopButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_HostSoloOrCoopButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_HostSoloOrCoopButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostServerButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_HostServerButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_HostServerButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AdvancedServerListButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_AdvancedServerListButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_AdvancedServerListButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerInfoContainer ServerInfoContainer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerInfoContainer));
        return pointer == System.IntPtr.Zero ? (ServerInfoContainer) null : new ServerInfoContainer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerInfoContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectPvEButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectPvEButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectPvEButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectPvPButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectPvPButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectPvPButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectPvPlusButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectPvPlusButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectPvPlusButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle ShowOnlyWithCharacterToggle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowOnlyWithCharacterToggle));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowOnlyWithCharacterToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle ShowPasswordProtectedToggle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowPasswordProtectedToggle));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowPasswordProtectedToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle ShowEmptyToggle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowEmptyToggle));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowEmptyToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle ShowFullToggle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowFullToggle));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowFullToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle ShowDedicated
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowDedicated));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowDedicated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle ShowStandardSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowStandardSettings));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowStandardSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle ShowScheduledWipes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowScheduledWipes));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ShowScheduledWipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform MainContentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_MainContentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_MainContentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SelectContentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectContentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SelectContentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PopupParentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_PopupParentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_PopupParentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Popup_BasicConfirm BasicConfirmPopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_BasicConfirmPopup));
        return pointer == System.IntPtr.Zero ? (Popup_BasicConfirm) null : new Popup_BasicConfirm(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_BasicConfirmPopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RecommendedOnlyContentRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_RecommendedOnlyContentRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_RecommendedOnlyContentRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform StandardContentRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_StandardContentRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_StandardContentRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform AdvancedFiltersRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_AdvancedFiltersRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_AdvancedFiltersRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_GameMode_Any
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_Any));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_Any)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_PvE
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_PvE));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_PvE)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_PvP
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_PvP));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_GameMode_PvP)) = value;
      }
    }

    public unsafe Popup_DirectConnect DirectConnectPopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_DirectConnectPopup));
        return pointer == System.IntPtr.Zero ? (Popup_DirectConnect) null : new Popup_DirectConnect(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_DirectConnectPopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Popup_ServerSettingDetails ServerSettingDetailsPopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerSettingDetailsPopup));
        return pointer == System.IntPtr.Zero ? (Popup_ServerSettingDetails) null : new Popup_ServerSettingDetails(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerSettingDetailsPopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField SearchInput
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SearchInput));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_SearchInput), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown GameModeDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_GameModeDropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_GameModeDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown HardcoreSettingDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_HardcoreSettingDropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_HardcoreSettingDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown OrderByDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_OrderByDropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_OrderByDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown ClanSizeDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ClanSizeDropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ClanSizeDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown LatencyDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LatencyDropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LatencyDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_HardcoreOn
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreOn));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreOn)) = value;
      }
    }

    public unsafe LocalizationKey LK_HardcoreOff
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreOff));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreOff)) = value;
      }
    }

    public unsafe LocalizationKey LK_HardcoreAny
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreAny));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_HardcoreAny)) = value;
      }
    }

    public unsafe LocalizationKey LK_OrderByPriority
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByPriority));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByPriority)) = value;
      }
    }

    public unsafe LocalizationKey LK_OrderByName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByName)) = value;
      }
    }

    public unsafe LocalizationKey LK_OrderByPlayers
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByPlayers));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_OrderByPlayers)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSizeAny
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeAny));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeAny)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSizeSolo
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeSolo));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeSolo)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSizeDuo
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeDuo));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeDuo)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSizeSquad
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeSquad));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_ClanSizeSquad)) = value;
      }
    }

    public unsafe LocalizationKey LK_TerritoryWarningHeader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_TerritoryWarningHeader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_TerritoryWarningHeader)) = value;
      }
    }

    public unsafe LocalizationKey LK_TerritoryWarningDescription
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_TerritoryWarningDescription));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_LK_TerritoryWarningDescription)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimplePopupBase _ActivePopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ActivePopup));
        return pointer == System.IntPtr.Zero ? (SimplePopupBase) null : new SimplePopupBase(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ActivePopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DiscoveryClient _DiscoveryClient
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DiscoveryClient));
        return pointer == System.IntPtr.Zero ? (DiscoveryClient) null : new DiscoveryClient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DiscoveryClient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _DiscoveryStartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DiscoveryStartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DiscoveryStartTime)) = value;
      }
    }

    public Il2CppSystem.Nullable<ServerInfo> _ConnectDiscoveryServer
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ConnectDiscoveryServer);
        return new Il2CppSystem.Nullable<ServerInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerInfo>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ConnectDiscoveryServer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<ServerListEntryUIData> _CachedServerListEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__CachedServerListEntries));
        return pointer == System.IntPtr.Zero ? (List<ServerListEntryUIData>) null : new List<ServerListEntryUIData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__CachedServerListEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ServerListEntryUIData> _FilteredServerListEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__FilteredServerListEntries));
        return pointer == System.IntPtr.Zero ? (List<ServerListEntryUIData>) null : new List<ServerListEntryUIData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__FilteredServerListEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<NewServerListEntryComponent> _ServerListEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ServerListEntries));
        return pointer == System.IntPtr.Zero ? (UI_Cache<NewServerListEntryComponent>) null : new UI_Cache<NewServerListEntryComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ServerListEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StunScrollRect ServerListScrollRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerListScrollRect));
        return pointer == System.IntPtr.Zero ? (StunScrollRect) null : new StunScrollRect(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerListScrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NewServerListEntryComponent ServerListEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerListEntryPrefab));
        return pointer == System.IntPtr.Zero ? (NewServerListEntryComponent) null : new NewServerListEntryComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerListEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ServerListEntriesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerListEntriesParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerListEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ServersCountText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServersCountText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServersCountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NoServerAvailableText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_NoServerAvailableText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_NoServerAvailableText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform NoRecommendedServersAvailable
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_NoRecommendedServersAvailable));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_NoRecommendedServersAvailable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ServerListHeaders
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerListHeaders));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_ServerListHeaders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _SelectedSession
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__SelectedSession)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__SelectedSession), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _ShowOnlyRecommended
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ShowOnlyRecommended));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ShowOnlyRecommended)) = value;
      }
    }

    public unsafe bool _ShowAdvancedFilters
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ShowAdvancedFilters));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ShowAdvancedFilters)) = value;
      }
    }

    public unsafe JoinMenuState _ViewState
    {
      get
      {
        return *(JoinMenuState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ViewState));
      }
      [param: In] set
      {
        *(JoinMenuState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ViewState)) = value;
      }
    }

    public unsafe GameModeTypeFilter _Filter_GameMode
    {
      get
      {
        return *(GameModeTypeFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_GameMode));
      }
      [param: In] set
      {
        *(GameModeTypeFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_GameMode)) = value;
      }
    }

    public unsafe FilterSetting _Filter_HardCore
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_HardCore));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_HardCore)) = value;
      }
    }

    public unsafe ClanSizeFilterSetting _Filter_ClanSize
    {
      get
      {
        return *(ClanSizeFilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ClanSize));
      }
      [param: In] set
      {
        *(ClanSizeFilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ClanSize)) = value;
      }
    }

    public unsafe bool _JoinModeAdvanced
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__JoinModeAdvanced));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__JoinModeAdvanced)) = value;
      }
    }

    public unsafe ServerListSorting _ServerListSorting
    {
      get
      {
        return *(ServerListSorting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ServerListSorting));
      }
      [param: In] set
      {
        *(ServerListSorting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ServerListSorting)) = value;
      }
    }

    public unsafe int _LatencyIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__LatencyIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__LatencyIndex)) = value;
      }
    }

    public unsafe string _Password
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Password)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Password), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _SetPasswordFocus
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__SetPasswordFocus));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__SetPasswordFocus)) = value;
      }
    }

    public unsafe List<PlayJoinMenuView.LatencySetting> _LatencySettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__LatencySettings));
        return pointer == System.IntPtr.Zero ? (List<PlayJoinMenuView.LatencySetting>) null : new List<PlayJoinMenuView.LatencySetting>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__LatencySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Filter_ShowOnlyWithCharacter
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowOnlyWithCharacter));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowOnlyWithCharacter)) = value;
      }
    }

    public unsafe bool _Filter_ShowPasswordProtected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowPasswordProtected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowPasswordProtected)) = value;
      }
    }

    public unsafe bool _Filter_ShowEmpty
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowEmpty));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowEmpty)) = value;
      }
    }

    public unsafe bool _Filter_ShowFull
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowFull));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowFull)) = value;
      }
    }

    public unsafe bool _Filter_ShowDedicated
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowDedicated));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowDedicated)) = value;
      }
    }

    public unsafe bool _Filter_ShowScheduledWipes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowScheduledWipes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowScheduledWipes)) = value;
      }
    }

    public unsafe bool _Filter_ShowStandardSettings
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowStandardSettings));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__Filter_ShowStandardSettings)) = value;
      }
    }

    public static unsafe string PREFS_SHOW_ONLY_WITH_CHARACTER
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_WITH_CHARACTER, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_WITH_CHARACTER, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PREFS_SHOW_ONLY_DEDICATED
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_DEDICATED, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_DEDICATED, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PREFS_SHOW_ONLY_STANDARD_SETTINGS
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_STANDARD_SETTINGS, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_ONLY_STANDARD_SETTINGS, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PREFS_SHOW_SCHEDULED_WIPES
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_SCHEDULED_WIPES, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_SCHEDULED_WIPES, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PREFS_SHOW_PASSWORD_PROTECTED
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_PASSWORD_PROTECTED, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_PASSWORD_PROTECTED, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PREFS_SHOW_EMPTY
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_EMPTY, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_EMPTY, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PREFS_SHOW_FULL
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_FULL, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_SHOW_FULL, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PREFS_MAX_LATENCY
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_MAX_LATENCY, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.NativeFieldInfoPtr_PREFS_MAX_LATENCY, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ServerListPrioritySettings PrioritySettings
    {
      get
      {
        return *(ServerListPrioritySettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_PrioritySettings));
      }
      [param: In] set
      {
        *(ServerListPrioritySettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr_PrioritySettings)) = value;
      }
    }

    public Il2CppSystem.Nullable<ServerListEntryUIData> _SelectedEntry
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__SelectedEntry);
        return new Il2CppSystem.Nullable<ServerListEntryUIData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerListEntryUIData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__SelectedEntry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerListEntryUIData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<ServerInfo> _ConnectCheckServers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ConnectCheckServers));
        return pointer == System.IntPtr.Zero ? (List<ServerInfo>) null : new List<ServerInfo>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ConnectCheckServers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _PreviousIsRefreshing
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__PreviousIsRefreshing));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__PreviousIsRefreshing)) = value;
      }
    }

    public unsafe Dictionary<string, string> _ServerRules
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ServerRules));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, string>) null : new Dictionary<string, string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ServerRules), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StringBuilder _DescriptionSB
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DescriptionSB));
        return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DescriptionSB), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StringBuilder _SettingsSB
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__SettingsSB));
        return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__SettingsSB), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<bool> _BloodBoundEnabled
    {
      get
      {
        return *(Nullable_Unboxed<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__BloodBoundEnabled));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__BloodBoundEnabled), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<CastleHeartDamageMode> _CastleHeartDamageMode
    {
      get
      {
        return *(Nullable_Unboxed<CastleHeartDamageMode>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__CastleHeartDamageMode));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__CastleHeartDamageMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CastleHeartDamageMode>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(Nullable_Unboxed<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ServerHistory _ServerHistory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ServerHistory));
        return pointer == System.IntPtr.Zero ? (ServerHistory) null : new ServerHistory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__ServerHistory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<int> _DaysRunning
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DaysRunning));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DaysRunning), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> _DaysUntilReset
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DaysUntilReset));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.NativeFieldInfoPtr__DaysUntilReset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Advanced;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_HardCore;
      [FieldOffset(0)]
      public bool Advanced;
      [FieldOffset(1)]
      public GameModeSelectionFlow GameMode;
      [FieldOffset(4)]
      public ClanSizeFilterSetting ClanSize;
      [FieldOffset(8)]
      public FilterSetting HardCore;

      static InitData()
      {
        Il2CppClassPointerStore<PlayJoinMenuView.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayJoinMenuView.InitData>.NativeClassPtr);
        PlayJoinMenuView.InitData.NativeFieldInfoPtr_Advanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.InitData>.NativeClassPtr, nameof (Advanced));
        PlayJoinMenuView.InitData.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.InitData>.NativeClassPtr, nameof (GameMode));
        PlayJoinMenuView.InitData.NativeFieldInfoPtr_ClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.InitData>.NativeClassPtr, nameof (ClanSize));
        PlayJoinMenuView.InitData.NativeFieldInfoPtr_HardCore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.InitData>.NativeClassPtr, nameof (HardCore));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayJoinMenuView.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class LatencySetting : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Latency;

      static LatencySetting()
      {
        Il2CppClassPointerStore<PlayJoinMenuView.LatencySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, nameof (LatencySetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayJoinMenuView.LatencySetting>.NativeClassPtr);
        PlayJoinMenuView.LatencySetting.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.LatencySetting>.NativeClassPtr, nameof (Name));
        PlayJoinMenuView.LatencySetting.NativeFieldInfoPtr_Latency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.LatencySetting>.NativeClassPtr, nameof (Latency));
      }

      public LatencySetting(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public LatencySetting()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayJoinMenuView.LatencySetting>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayJoinMenuView.LatencySetting>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.LatencySetting.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.LatencySetting.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int Latency
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.LatencySetting.NativeFieldInfoPtr_Latency));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.LatencySetting.NativeFieldInfoPtr_Latency)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayJoinMenuView/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__105_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__105_12;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__105_13;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__105_14;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__105_15;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__105_16;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_4_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_12_Internal_String_LatencySetting_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_13_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_14_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_15_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__105_16_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283799, XrefRangeEnd = 1283807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__105_4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe string _Awake_b__105_12(PlayJoinMenuView.LatencySetting x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_12_Internal_String_LatencySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283807, XrefRangeEnd = 1283814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__105_13()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_13_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283814, XrefRangeEnd = 1283820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__105_14()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_14_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283820, XrefRangeEnd = 1283826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__105_15()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_15_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283826, XrefRangeEnd = 1283832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__105_16()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_16_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr);
        PlayJoinMenuView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, "<>9");
        PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, "<>9__105_4");
        PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, "<>9__105_12");
        PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, "<>9__105_13");
        PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, "<>9__105_14");
        PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, "<>9__105_15");
        PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, "<>9__105_16");
        PlayJoinMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, 100669324);
        PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, 100669325);
        PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_12_Internal_String_LatencySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, 100669326);
        PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_13_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, 100669327);
        PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_14_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, 100669328);
        PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_15_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, 100669329);
        PlayJoinMenuView.__c.NativeMethodInfoPtr__Awake_b__105_16_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c>.NativeClassPtr, 100669330);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe PlayJoinMenuView.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (PlayJoinMenuView.__c) null : new PlayJoinMenuView.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__105_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<PlayJoinMenuView.LatencySetting, string> __9__105_12
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_12, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<PlayJoinMenuView.LatencySetting, string>) null : new Il2CppSystem.Func<PlayJoinMenuView.LatencySetting, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_12, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__105_13
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_13, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_13, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__105_14
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_14, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_14, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__105_15
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_15, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_15, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__105_16
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_16, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayJoinMenuView.__c.NativeFieldInfoPtr___9__105_16, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayJoinMenuView/<>c__DisplayClass119_0")]
    public sealed class __c__DisplayClass119_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ipAddress;
      private static readonly System.IntPtr NativeFieldInfoPtr_port;
      private static readonly System.IntPtr NativeFieldInfoPtr_password;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnButtonClick_Join_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass119_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c__DisplayClass119_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283832, XrefRangeEnd = 1283834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnButtonClick_Join_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c__DisplayClass119_0.NativeMethodInfoPtr__OnButtonClick_Join_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass119_0()
      {
        Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, "<>c__DisplayClass119_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr);
        PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_ipAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr, nameof (ipAddress));
        PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr, nameof (port));
        PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr, nameof (password));
        PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr, "<>4__this");
        PlayJoinMenuView.__c__DisplayClass119_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr, 100669331);
        PlayJoinMenuView.__c__DisplayClass119_0.NativeMethodInfoPtr__OnButtonClick_Join_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass119_0>.NativeClassPtr, 100669332);
      }

      public __c__DisplayClass119_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string ipAddress
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_ipAddress)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_ipAddress), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe ushort port
      {
        get
        {
          return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_port));
        }
        [param: In] set
        {
          *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_port)) = value;
        }
      }

      public unsafe string password
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_password)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr_password), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe PlayJoinMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayJoinMenuView) null : new PlayJoinMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass119_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayJoinMenuView/<>c__DisplayClass126_0")]
    public sealed class __c__DisplayClass126_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverListSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__1_Internal_Void_NewServerListEntryComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass126_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283834, XrefRangeEnd = 1283835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__1(NewServerListEntryComponent entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c__DisplayClass126_0.NativeMethodInfoPtr__Update_b__1_Internal_Void_NewServerListEntryComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass126_0()
      {
        Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, "<>c__DisplayClass126_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_0>.NativeClassPtr);
        PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_0>.NativeClassPtr, "<>4__this");
        PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr_serverListSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_0>.NativeClassPtr, nameof (serverListSystem));
        PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_0>.NativeClassPtr, "<>9__1");
        PlayJoinMenuView.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_0>.NativeClassPtr, 100669333);
        PlayJoinMenuView.__c__DisplayClass126_0.NativeMethodInfoPtr__Update_b__1_Internal_Void_NewServerListEntryComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_0>.NativeClassPtr, 100669334);
      }

      public __c__DisplayClass126_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PlayJoinMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayJoinMenuView) null : new PlayJoinMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerListSystem serverListSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr_serverListSystem));
          return pointer == System.IntPtr.Zero ? (ServerListSystem) null : new ServerListSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr_serverListSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action<NewServerListEntryComponent> __9__1
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr___9__1));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<NewServerListEntryComponent>) null : new Il2CppSystem.Action<NewServerListEntryComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayJoinMenuView/<>c__DisplayClass126_1")]
    public sealed class __c__DisplayClass126_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_data;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass126_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__0_Internal_Void_NewServerListEntryComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass126_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c__DisplayClass126_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283835, XrefRangeEnd = 1283844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__0(NewServerListEntryComponent entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayJoinMenuView.__c__DisplayClass126_1.NativeMethodInfoPtr__Update_b__0_Internal_Void_NewServerListEntryComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass126_1()
      {
        Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayJoinMenuView>.NativeClassPtr, "<>c__DisplayClass126_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_1>.NativeClassPtr);
        PlayJoinMenuView.__c__DisplayClass126_1.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_1>.NativeClassPtr, nameof (data));
        PlayJoinMenuView.__c__DisplayClass126_1.NativeFieldInfoPtr_field_Public___c__DisplayClass126_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_1>.NativeClassPtr, "CS$<>8__locals1");
        PlayJoinMenuView.__c__DisplayClass126_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_1>.NativeClassPtr, 100669335);
        PlayJoinMenuView.__c__DisplayClass126_1.NativeMethodInfoPtr__Update_b__0_Internal_Void_NewServerListEntryComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayJoinMenuView.__c__DisplayClass126_1>.NativeClassPtr, 100669336);
      }

      public __c__DisplayClass126_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ServerListEntryUIData data
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_1.NativeFieldInfoPtr_data);
          return new ServerListEntryUIData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_1.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PlayJoinMenuView.__c__DisplayClass126_0 field_Public___c__DisplayClass126_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_1.NativeFieldInfoPtr_field_Public___c__DisplayClass126_0_0));
          return pointer == System.IntPtr.Zero ? (PlayJoinMenuView.__c__DisplayClass126_0) null : new PlayJoinMenuView.__c__DisplayClass126_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayJoinMenuView.__c__DisplayClass126_1.NativeFieldInfoPtr_field_Public___c__DisplayClass126_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
