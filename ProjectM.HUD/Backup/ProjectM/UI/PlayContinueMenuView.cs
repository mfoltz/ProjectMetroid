// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PlayContinueMenuView
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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class PlayContinueMenuView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MainStateBackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefreshButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeleteSaveButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeleteHistoryButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoToDirectoryButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToggleCloudSaved;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToggleCloudSaveText;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoRefreshImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerInfoContainer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerSettingsPopup;
    private static readonly System.IntPtr NativeFieldInfoPtr_BasicConfirmPopup;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActivePopup;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryClient;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConnectDiscoveryServer;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedServerListEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedContinueServerListEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerListEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListEntriesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr__SaveListEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveListEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveListEntriesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveListRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedSession;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedSaveIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedServerEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedSaveEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConnectCheckServers;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerHistory;
    private static readonly System.IntPtr NativeFieldInfoPtr__Saves;
    private static readonly System.IntPtr NativeFieldInfoPtr__Password;
    private static readonly System.IntPtr NativeFieldInfoPtr__SetPasswordFocus;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollRectTest;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveToCloudKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveFromCloudKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveSaveWarningKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveHistoryWarningKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddToCloudWarningKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveFromCloudWarningKey;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerRules;
    private static readonly System.IntPtr NativeFieldInfoPtr__DescriptionSB;
    private static readonly System.IntPtr NativeFieldInfoPtr__SettingsSB;
    private static readonly System.IntPtr NativeFieldInfoPtr__BloodBoundEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__DaysRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr__DaysUntilReset;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleHeartDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__HostLan;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DiscoveyTime_Private_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenPopup_Private_Void_SimplePopupBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSaves_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Back_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Join_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Host_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoBack_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateServerInfoView_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServerRules_Private_Void_UInt32_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConnectDiscovery_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_0_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_1_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_2_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_3_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_5_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_6_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_11_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_7_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_12_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_8_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_9_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_10_Private_Void_0;

    public unsafe float DiscoveyTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279999, XrefRangeEnd = 1280000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_get_DiscoveyTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280000, XrefRangeEnd = 1280139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280139, XrefRangeEnd = 1280204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280204, XrefRangeEnd = 1280211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenPopup(SimplePopupBase popup)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) popup);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_OpenPopup_Private_Void_SimplePopupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1280244, RefRangeEnd = 1280247, XrefRangeStart = 1280211, XrefRangeEnd = 1280244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetSaves()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_GetSaves_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280247, XrefRangeEnd = 1280249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Back()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_OnButtonClick_Back_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1280275, RefRangeEnd = 1280277, XrefRangeStart = 1280249, XrefRangeEnd = 1280275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Join()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_OnButtonClick_Join_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1280309, RefRangeEnd = 1280311, XrefRangeStart = 1280277, XrefRangeEnd = 1280309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Host()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_OnButtonClick_Host_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280311, XrefRangeEnd = 1280319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GoBack()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280319, XrefRangeEnd = 1280520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1280569, RefRangeEnd = 1280570, XrefRangeStart = 1280520, XrefRangeEnd = 1280569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateServerInfoView()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_UpdateServerInfoView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1280600, RefRangeEnd = 1280601, XrefRangeStart = 1280570, XrefRangeEnd = 1280600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetServerRules(uint ipAddressInt, ushort queryPort)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &ipAddressInt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &queryPort;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_GetServerRules_Private_Void_UInt32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280601, XrefRangeEnd = 1280617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesResponded(string ruleKey, string ruleValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(ruleKey);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(ruleValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280617, XrefRangeEnd = 1280623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesFailedToRespond()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280623, XrefRangeEnd = 1280728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRulesRefreshComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1280750, RefRangeEnd = 1280751, XrefRangeStart = 1280728, XrefRangeEnd = 1280750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateConnectDiscovery()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr_UpdateConnectDiscovery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280751, XrefRangeEnd = 1280783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayContinueMenuView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280783, XrefRangeEnd = 1280806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_0(string newVal)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(newVal);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280806, XrefRangeEnd = 1280810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_1(string newVal)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(newVal);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280810, XrefRangeEnd = 1280825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_2(string newVal)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(newVal);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_2_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280825, XrefRangeEnd = 1280832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Awake_b__46_5(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280832, XrefRangeEnd = 1280843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280843, XrefRangeEnd = 1280849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_11()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_11_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280849, XrefRangeEnd = 1280860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280860, XrefRangeEnd = 1280874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_12()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_12_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280874, XrefRangeEnd = 1280881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280881, XrefRangeEnd = 1280904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_9()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280904, XrefRangeEnd = 1280922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__46_10()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayContinueMenuView()
    {
      Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PlayContinueMenuView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr);
      PlayContinueMenuView.NativeFieldInfoPtr_MainStateBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (MainStateBackButton));
      PlayContinueMenuView.NativeFieldInfoPtr_HostButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (HostButton));
      PlayContinueMenuView.NativeFieldInfoPtr_JoinButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (JoinButton));
      PlayContinueMenuView.NativeFieldInfoPtr_RefreshButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (RefreshButton));
      PlayContinueMenuView.NativeFieldInfoPtr_DeleteSaveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (DeleteSaveButton));
      PlayContinueMenuView.NativeFieldInfoPtr_DeleteHistoryButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (DeleteHistoryButton));
      PlayContinueMenuView.NativeFieldInfoPtr_GoToDirectoryButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (GoToDirectoryButton));
      PlayContinueMenuView.NativeFieldInfoPtr_ToggleCloudSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (ToggleCloudSaved));
      PlayContinueMenuView.NativeFieldInfoPtr_ToggleCloudSaveText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (ToggleCloudSaveText));
      PlayContinueMenuView.NativeFieldInfoPtr_AutoRefreshImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (AutoRefreshImage));
      PlayContinueMenuView.NativeFieldInfoPtr_ServerInfoContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (ServerInfoContainer));
      PlayContinueMenuView.NativeFieldInfoPtr_ServerSettingsPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (ServerSettingsPopup));
      PlayContinueMenuView.NativeFieldInfoPtr_BasicConfirmPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (BasicConfirmPopup));
      PlayContinueMenuView.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_InputSystem));
      PlayContinueMenuView.NativeFieldInfoPtr__ActivePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_ActivePopup));
      PlayContinueMenuView.NativeFieldInfoPtr__DiscoveryClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_DiscoveryClient));
      PlayContinueMenuView.NativeFieldInfoPtr__DiscoveryStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_DiscoveryStartTime));
      PlayContinueMenuView.NativeFieldInfoPtr__ConnectDiscoveryServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_ConnectDiscoveryServer));
      PlayContinueMenuView.NativeFieldInfoPtr__CachedServerListEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_CachedServerListEntries));
      PlayContinueMenuView.NativeFieldInfoPtr__CachedContinueServerListEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_CachedContinueServerListEntries));
      PlayContinueMenuView.NativeFieldInfoPtr__ServerListEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_ServerListEntries));
      PlayContinueMenuView.NativeFieldInfoPtr_ServerListEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (ServerListEntryPrefab));
      PlayContinueMenuView.NativeFieldInfoPtr_ServerListEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (ServerListEntriesParent));
      PlayContinueMenuView.NativeFieldInfoPtr_ServerListRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (ServerListRoot));
      PlayContinueMenuView.NativeFieldInfoPtr__SaveListEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_SaveListEntries));
      PlayContinueMenuView.NativeFieldInfoPtr_SaveListEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (SaveListEntryPrefab));
      PlayContinueMenuView.NativeFieldInfoPtr_SaveListEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (SaveListEntriesParent));
      PlayContinueMenuView.NativeFieldInfoPtr_SaveListRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (SaveListRoot));
      PlayContinueMenuView.NativeFieldInfoPtr__SelectedSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_SelectedSession));
      PlayContinueMenuView.NativeFieldInfoPtr__SelectedSaveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_SelectedSaveIndex));
      PlayContinueMenuView.NativeFieldInfoPtr__SelectedServerEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_SelectedServerEntry));
      PlayContinueMenuView.NativeFieldInfoPtr__SelectedSaveEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_SelectedSaveEntry));
      PlayContinueMenuView.NativeFieldInfoPtr__ConnectCheckServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_ConnectCheckServers));
      PlayContinueMenuView.NativeFieldInfoPtr__ServerHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_ServerHistory));
      PlayContinueMenuView.NativeFieldInfoPtr__Saves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_Saves));
      PlayContinueMenuView.NativeFieldInfoPtr__Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_Password));
      PlayContinueMenuView.NativeFieldInfoPtr__SetPasswordFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_SetPasswordFocus));
      PlayContinueMenuView.NativeFieldInfoPtr_ScrollRectTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (ScrollRectTest));
      PlayContinueMenuView.NativeFieldInfoPtr_MoveToCloudKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (MoveToCloudKey));
      PlayContinueMenuView.NativeFieldInfoPtr_RemoveFromCloudKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (RemoveFromCloudKey));
      PlayContinueMenuView.NativeFieldInfoPtr_RemoveSaveWarningKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (RemoveSaveWarningKey));
      PlayContinueMenuView.NativeFieldInfoPtr_RemoveHistoryWarningKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (RemoveHistoryWarningKey));
      PlayContinueMenuView.NativeFieldInfoPtr_AddToCloudWarningKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (AddToCloudWarningKey));
      PlayContinueMenuView.NativeFieldInfoPtr_RemoveFromCloudWarningKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (RemoveFromCloudWarningKey));
      PlayContinueMenuView.NativeFieldInfoPtr__ServerRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_ServerRules));
      PlayContinueMenuView.NativeFieldInfoPtr__DescriptionSB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_DescriptionSB));
      PlayContinueMenuView.NativeFieldInfoPtr__SettingsSB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_SettingsSB));
      PlayContinueMenuView.NativeFieldInfoPtr__BloodBoundEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_BloodBoundEnabled));
      PlayContinueMenuView.NativeFieldInfoPtr__DaysRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_DaysRunning));
      PlayContinueMenuView.NativeFieldInfoPtr__DaysUntilReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_DaysUntilReset));
      PlayContinueMenuView.NativeFieldInfoPtr__CastleHeartDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_CastleHeartDamageMode));
      PlayContinueMenuView.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_BalanceSettings));
      PlayContinueMenuView.NativeFieldInfoPtr__HostLan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, nameof (_HostLan));
      PlayContinueMenuView.NativeMethodInfoPtr_get_DiscoveyTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669004);
      PlayContinueMenuView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669005);
      PlayContinueMenuView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669006);
      PlayContinueMenuView.NativeMethodInfoPtr_OpenPopup_Private_Void_SimplePopupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669007);
      PlayContinueMenuView.NativeMethodInfoPtr_GetSaves_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669008);
      PlayContinueMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669009);
      PlayContinueMenuView.NativeMethodInfoPtr_OnButtonClick_Back_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669010);
      PlayContinueMenuView.NativeMethodInfoPtr_OnButtonClick_Join_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669011);
      PlayContinueMenuView.NativeMethodInfoPtr_OnButtonClick_Host_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669012);
      PlayContinueMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669013);
      PlayContinueMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669014);
      PlayContinueMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669015);
      PlayContinueMenuView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669016);
      PlayContinueMenuView.NativeMethodInfoPtr_UpdateServerInfoView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669017);
      PlayContinueMenuView.NativeMethodInfoPtr_GetServerRules_Private_Void_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669018);
      PlayContinueMenuView.NativeMethodInfoPtr_OnRulesResponded_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669019);
      PlayContinueMenuView.NativeMethodInfoPtr_OnRulesFailedToRespond_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669020);
      PlayContinueMenuView.NativeMethodInfoPtr_OnRulesRefreshComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669021);
      PlayContinueMenuView.NativeMethodInfoPtr_UpdateConnectDiscovery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669022);
      PlayContinueMenuView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669023);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669024);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669025);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_2_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669026);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669027);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669028);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669029);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_11_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669030);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669031);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_12_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669032);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669033);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669034);
      PlayContinueMenuView.NativeMethodInfoPtr__Awake_b__46_10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, 100669035);
    }

    public PlayContinueMenuView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton MainStateBackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_MainStateBackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_MainStateBackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_HostButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_HostButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton JoinButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_JoinButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_JoinButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton RefreshButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RefreshButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RefreshButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DeleteSaveButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_DeleteSaveButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_DeleteSaveButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DeleteHistoryButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_DeleteHistoryButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_DeleteHistoryButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton GoToDirectoryButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_GoToDirectoryButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_GoToDirectoryButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ToggleCloudSaved
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ToggleCloudSaved));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ToggleCloudSaved), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ToggleCloudSaveText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ToggleCloudSaveText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ToggleCloudSaveText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image AutoRefreshImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_AutoRefreshImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_AutoRefreshImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerInfoContainer ServerInfoContainer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerInfoContainer));
        return pointer == System.IntPtr.Zero ? (ServerInfoContainer) null : new ServerInfoContainer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerInfoContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Popup_ServerSettingDetails ServerSettingsPopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerSettingsPopup));
        return pointer == System.IntPtr.Zero ? (Popup_ServerSettingDetails) null : new Popup_ServerSettingDetails(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerSettingsPopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Popup_BasicConfirm BasicConfirmPopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_BasicConfirmPopup));
        return pointer == System.IntPtr.Zero ? (Popup_BasicConfirm) null : new Popup_BasicConfirm(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_BasicConfirmPopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimplePopupBase _ActivePopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ActivePopup));
        return pointer == System.IntPtr.Zero ? (SimplePopupBase) null : new SimplePopupBase(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ActivePopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DiscoveryClient _DiscoveryClient
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DiscoveryClient));
        return pointer == System.IntPtr.Zero ? (DiscoveryClient) null : new DiscoveryClient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DiscoveryClient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _DiscoveryStartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DiscoveryStartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DiscoveryStartTime)) = value;
      }
    }

    public Il2CppSystem.Nullable<ServerInfo> _ConnectDiscoveryServer
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ConnectDiscoveryServer);
        return new Il2CppSystem.Nullable<ServerInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerInfo>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ConnectDiscoveryServer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<ServerListEntryUIData> _CachedServerListEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__CachedServerListEntries));
        return pointer == System.IntPtr.Zero ? (List<ServerListEntryUIData>) null : new List<ServerListEntryUIData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__CachedServerListEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ServerListEntryUIData> _CachedContinueServerListEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__CachedContinueServerListEntries));
        return pointer == System.IntPtr.Zero ? (List<ServerListEntryUIData>) null : new List<ServerListEntryUIData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__CachedContinueServerListEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<NewServerListEntryComponent> _ServerListEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ServerListEntries));
        return pointer == System.IntPtr.Zero ? (UI_Cache<NewServerListEntryComponent>) null : new UI_Cache<NewServerListEntryComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ServerListEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NewServerListEntryComponent ServerListEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerListEntryPrefab));
        return pointer == System.IntPtr.Zero ? (NewServerListEntryComponent) null : new NewServerListEntryComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerListEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ServerListEntriesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerListEntriesParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerListEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ServerListRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerListRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ServerListRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<NewSaveListEntryComponent> _SaveListEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SaveListEntries));
        return pointer == System.IntPtr.Zero ? (UI_Cache<NewSaveListEntryComponent>) null : new UI_Cache<NewSaveListEntryComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SaveListEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NewSaveListEntryComponent SaveListEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_SaveListEntryPrefab));
        return pointer == System.IntPtr.Zero ? (NewSaveListEntryComponent) null : new NewSaveListEntryComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_SaveListEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SaveListEntriesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_SaveListEntriesParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_SaveListEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SaveListRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_SaveListRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_SaveListRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _SelectedSession
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SelectedSession)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SelectedSession), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int _SelectedSaveIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SelectedSaveIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SelectedSaveIndex)) = value;
      }
    }

    public Il2CppSystem.Nullable<ServerListEntryUIData> _SelectedServerEntry
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SelectedServerEntry);
        return new Il2CppSystem.Nullable<ServerListEntryUIData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerListEntryUIData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SelectedServerEntry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerListEntryUIData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Il2CppSystem.Nullable<SaveListEntryData> _SelectedSaveEntry
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SelectedSaveEntry);
        return new Il2CppSystem.Nullable<SaveListEntryData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<SaveListEntryData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SelectedSaveEntry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<SaveListEntryData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<ServerInfo> _ConnectCheckServers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ConnectCheckServers));
        return pointer == System.IntPtr.Zero ? (List<ServerInfo>) null : new List<ServerInfo>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ConnectCheckServers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerHistory _ServerHistory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ServerHistory));
        return pointer == System.IntPtr.Zero ? (ServerHistory) null : new ServerHistory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ServerHistory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SaveFileData> _Saves
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__Saves));
        return pointer == System.IntPtr.Zero ? (List<SaveFileData>) null : new List<SaveFileData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__Saves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Password
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__Password)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__Password), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _SetPasswordFocus
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SetPasswordFocus));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SetPasswordFocus)) = value;
      }
    }

    public unsafe StunScrollRect ScrollRectTest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ScrollRectTest));
        return pointer == System.IntPtr.Zero ? (StunScrollRect) null : new StunScrollRect(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_ScrollRectTest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey MoveToCloudKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_MoveToCloudKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_MoveToCloudKey)) = value;
      }
    }

    public unsafe LocalizationKey RemoveFromCloudKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RemoveFromCloudKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RemoveFromCloudKey)) = value;
      }
    }

    public unsafe LocalizationKey RemoveSaveWarningKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RemoveSaveWarningKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RemoveSaveWarningKey)) = value;
      }
    }

    public unsafe LocalizationKey RemoveHistoryWarningKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RemoveHistoryWarningKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RemoveHistoryWarningKey)) = value;
      }
    }

    public unsafe LocalizationKey AddToCloudWarningKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_AddToCloudWarningKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_AddToCloudWarningKey)) = value;
      }
    }

    public unsafe LocalizationKey RemoveFromCloudWarningKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RemoveFromCloudWarningKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr_RemoveFromCloudWarningKey)) = value;
      }
    }

    public unsafe Dictionary<string, string> _ServerRules
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ServerRules));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, string>) null : new Dictionary<string, string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__ServerRules), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StringBuilder _DescriptionSB
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DescriptionSB));
        return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DescriptionSB), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StringBuilder _SettingsSB
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SettingsSB));
        return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__SettingsSB), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<bool> _BloodBoundEnabled
    {
      get
      {
        return *(Nullable_Unboxed<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__BloodBoundEnabled));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__BloodBoundEnabled), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> _DaysRunning
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DaysRunning));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DaysRunning), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> _DaysUntilReset
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DaysUntilReset));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__DaysUntilReset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<CastleHeartDamageMode> _CastleHeartDamageMode
    {
      get
      {
        return *(Nullable_Unboxed<CastleHeartDamageMode>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__CastleHeartDamageMode));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__CastleHeartDamageMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CastleHeartDamageMode>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(Nullable_Unboxed<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _HostLan
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__HostLan));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.NativeFieldInfoPtr__HostLan)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayContinueMenuView/<>c__DisplayClass46_0")]
    public sealed class __c__DisplayClass46_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_saveData;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__13_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass46_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass46_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279943, XrefRangeEnd = 1279958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__13()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass46_0.NativeMethodInfoPtr__Awake_b__13_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass46_0()
      {
        Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, "<>c__DisplayClass46_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass46_0>.NativeClassPtr);
        PlayContinueMenuView.__c__DisplayClass46_0.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass46_0>.NativeClassPtr, nameof (saveData));
        PlayContinueMenuView.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass46_0>.NativeClassPtr, "<>4__this");
        PlayContinueMenuView.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass46_0>.NativeClassPtr, 100669036);
        PlayContinueMenuView.__c__DisplayClass46_0.NativeMethodInfoPtr__Awake_b__13_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass46_0>.NativeClassPtr, 100669037);
      }

      public __c__DisplayClass46_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SaveFileData saveData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass46_0.NativeFieldInfoPtr_saveData));
          return pointer == System.IntPtr.Zero ? (SaveFileData) null : new SaveFileData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass46_0.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayContinueMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayContinueMenuView) null : new PlayContinueMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayContinueMenuView/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__46_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__47_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__49_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__57_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__46_4_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__47_0_Internal_Int32_ServerHistoryEntry_ServerHistoryEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetSaves_b__49_0_Internal_Int32_SaveFileData_SaveFileData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__57_0_Internal_Int32_ServerListEntryUIData_ServerListEntryUIData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279958, XrefRangeEnd = 1279966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__46_4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c.NativeMethodInfoPtr__Awake_b__46_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279966, XrefRangeEnd = 1279968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Start_b__47_0(ServerHistoryEntry x, ServerHistoryEntry y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c.NativeMethodInfoPtr__Start_b__47_0_Internal_Int32_ServerHistoryEntry_ServerHistoryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279968, XrefRangeEnd = 1279970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _GetSaves_b__49_0(SaveFileData x, SaveFileData y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c.NativeMethodInfoPtr__GetSaves_b__49_0_Internal_Int32_SaveFileData_SaveFileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _Update_b__57_0(ServerListEntryUIData x, ServerListEntryUIData y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) y));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c.NativeMethodInfoPtr__Update_b__57_0_Internal_Int32_ServerListEntryUIData_ServerListEntryUIData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr);
        PlayContinueMenuView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, "<>9");
        PlayContinueMenuView.__c.NativeFieldInfoPtr___9__46_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, "<>9__46_4");
        PlayContinueMenuView.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, "<>9__47_0");
        PlayContinueMenuView.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, "<>9__49_0");
        PlayContinueMenuView.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, "<>9__57_0");
        PlayContinueMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, 100669039);
        PlayContinueMenuView.__c.NativeMethodInfoPtr__Awake_b__46_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, 100669040);
        PlayContinueMenuView.__c.NativeMethodInfoPtr__Start_b__47_0_Internal_Int32_ServerHistoryEntry_ServerHistoryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, 100669041);
        PlayContinueMenuView.__c.NativeMethodInfoPtr__GetSaves_b__49_0_Internal_Int32_SaveFileData_SaveFileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, 100669042);
        PlayContinueMenuView.__c.NativeMethodInfoPtr__Update_b__57_0_Internal_Int32_ServerListEntryUIData_ServerListEntryUIData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c>.NativeClassPtr, 100669043);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe PlayContinueMenuView.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (PlayContinueMenuView.__c) null : new PlayContinueMenuView.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__46_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9__46_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9__46_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<ServerHistoryEntry> __9__47_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9__47_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<ServerHistoryEntry>) null : new Il2CppSystem.Comparison<ServerHistoryEntry>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9__47_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<SaveFileData> __9__49_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9__49_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<SaveFileData>) null : new Il2CppSystem.Comparison<SaveFileData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9__49_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<ServerListEntryUIData> __9__57_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9__57_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<ServerListEntryUIData>) null : new Il2CppSystem.Comparison<ServerListEntryUIData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayContinueMenuView.__c.NativeFieldInfoPtr___9__57_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayContinueMenuView/<>c__DisplayClass57_0")]
    public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverListSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__3_Internal_Void_NewServerListEntryComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__5_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass57_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279970, XrefRangeEnd = 1279971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__3(NewServerListEntryComponent entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_0.NativeMethodInfoPtr__Update_b__3_Internal_Void_NewServerListEntryComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279971, XrefRangeEnd = 1279972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__5()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_0.NativeMethodInfoPtr__Update_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass57_0()
      {
        Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, "<>c__DisplayClass57_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr);
        PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr_serverListSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr, nameof (serverListSystem));
        PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr, "<>4__this");
        PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr, "<>9__3");
        PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr, "<>9__5");
        PlayContinueMenuView.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr, 100669044);
        PlayContinueMenuView.__c__DisplayClass57_0.NativeMethodInfoPtr__Update_b__3_Internal_Void_NewServerListEntryComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr, 100669045);
        PlayContinueMenuView.__c__DisplayClass57_0.NativeMethodInfoPtr__Update_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_0>.NativeClassPtr, 100669046);
      }

      public __c__DisplayClass57_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ServerListSystem serverListSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr_serverListSystem));
          return pointer == System.IntPtr.Zero ? (ServerListSystem) null : new ServerListSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr_serverListSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayContinueMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayContinueMenuView) null : new PlayContinueMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action<NewServerListEntryComponent> __9__3
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___9__3));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<NewServerListEntryComponent>) null : new Il2CppSystem.Action<NewServerListEntryComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action __9__5
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___9__5));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayContinueMenuView/<>c__DisplayClass57_1")]
    public sealed class __c__DisplayClass57_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__1_Internal_Boolean_SaveFileData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass57_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279972, XrefRangeEnd = 1279974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _Update_b__1(SaveFileData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_1.NativeMethodInfoPtr__Update_b__1_Internal_Boolean_SaveFileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass57_1()
      {
        Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, "<>c__DisplayClass57_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_1>.NativeClassPtr);
        PlayContinueMenuView.__c__DisplayClass57_1.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_1>.NativeClassPtr, nameof (entry));
        PlayContinueMenuView.__c__DisplayClass57_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_1>.NativeClassPtr, 100669047);
        PlayContinueMenuView.__c__DisplayClass57_1.NativeMethodInfoPtr__Update_b__1_Internal_Boolean_SaveFileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_1>.NativeClassPtr, 100669048);
      }

      public __c__DisplayClass57_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ServerHistoryEntry entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_1.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (ServerHistoryEntry) null : new ServerHistoryEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_1.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayContinueMenuView/<>c__DisplayClass57_2")]
    public sealed class __c__DisplayClass57_2 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_data;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__2_Internal_Void_NewServerListEntryComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass57_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279974, XrefRangeEnd = 1279986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__2(NewServerListEntryComponent entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_2.NativeMethodInfoPtr__Update_b__2_Internal_Void_NewServerListEntryComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass57_2()
      {
        Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, "<>c__DisplayClass57_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_2>.NativeClassPtr);
        PlayContinueMenuView.__c__DisplayClass57_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_2>.NativeClassPtr, nameof (data));
        PlayContinueMenuView.__c__DisplayClass57_2.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_2>.NativeClassPtr, "CS$<>8__locals1");
        PlayContinueMenuView.__c__DisplayClass57_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_2>.NativeClassPtr, 100669049);
        PlayContinueMenuView.__c__DisplayClass57_2.NativeMethodInfoPtr__Update_b__2_Internal_Void_NewServerListEntryComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_2>.NativeClassPtr, 100669050);
      }

      public __c__DisplayClass57_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ServerListEntryUIData data
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_2.NativeFieldInfoPtr_data);
          return new ServerListEntryUIData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_2.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PlayContinueMenuView.__c__DisplayClass57_0 field_Public___c__DisplayClass57_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_2.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0));
          return pointer == System.IntPtr.Zero ? (PlayContinueMenuView.__c__DisplayClass57_0) null : new PlayContinueMenuView.__c__DisplayClass57_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_2.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayContinueMenuView/<>c__DisplayClass57_3")]
    public sealed class __c__DisplayClass57_3 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_saveListEntry;
      private static readonly System.IntPtr NativeFieldInfoPtr_index;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__4_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass57_3()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279986, XrefRangeEnd = 1279999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayContinueMenuView.__c__DisplayClass57_3.NativeMethodInfoPtr__Update_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass57_3()
      {
        Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayContinueMenuView>.NativeClassPtr, "<>c__DisplayClass57_3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_3>.NativeClassPtr);
        PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_saveListEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_3>.NativeClassPtr, nameof (saveListEntry));
        PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_3>.NativeClassPtr, nameof (index));
        PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_3>.NativeClassPtr, "CS$<>8__locals2");
        PlayContinueMenuView.__c__DisplayClass57_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_3>.NativeClassPtr, 100669051);
        PlayContinueMenuView.__c__DisplayClass57_3.NativeMethodInfoPtr__Update_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayContinueMenuView.__c__DisplayClass57_3>.NativeClassPtr, 100669052);
      }

      public __c__DisplayClass57_3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe NewSaveListEntryComponent saveListEntry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_saveListEntry));
          return pointer == System.IntPtr.Zero ? (NewSaveListEntryComponent) null : new NewSaveListEntryComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_saveListEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int index
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_index));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_index)) = value;
        }
      }

      public unsafe PlayContinueMenuView.__c__DisplayClass57_0 field_Public___c__DisplayClass57_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0));
          return pointer == System.IntPtr.Zero ? (PlayContinueMenuView.__c__DisplayClass57_0) null : new PlayContinueMenuView.__c__DisplayClass57_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayContinueMenuView.__c__DisplayClass57_3.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
