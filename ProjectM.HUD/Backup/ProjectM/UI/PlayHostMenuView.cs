// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PlayHostMenuView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class PlayHostMenuView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MenuCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ViewHeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostSelectNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostSavedNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostNewNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdvancedSettingsNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectHostInGameServerButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectHostDedicatedServerButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectRentServerButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostSelectBackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveListNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveListGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoSavedServersMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackToMainMenuButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartNewServerButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostSavedButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostNewBackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostNewButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerNameInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDescriptionInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxUsersInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_PasswordInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_TogglePasswordButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeSelector;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeSelectButton_PvE;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeSelectButton_PvP;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostNewOpenLoadPresetPopupButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_LanServerCheckbox;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxUsersSlider;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyLocalPlayCheckbox;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSizeSlider;
    private static readonly System.IntPtr NativeFieldInfoPtr_MatchingGameModeText;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackToHostNewButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenSavePresetPopupButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenLoadPresetPopupButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveSettingsButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenAdvancedOptionsButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseAdvancedOptionsButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdvancedSettingsPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SavePresetPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadPresetPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnsavedChangesPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PresetNameInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_PresetDescriptionInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_CancelSavePresetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SavePresetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_CancelLoadPresetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadPresetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadPresetsScrollRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadPresetListNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PresetEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PresetName;
    private static readonly System.IntPtr NativeFieldInfoPtr_PresetDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoPresetSelectedText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletePresetSubPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletePresetName;
    private static readonly System.IntPtr NativeFieldInfoPtr_CancelDeletePresetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletePresetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnsavedChanges_NoButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnsavedChanges_YesButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label1Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label2Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label3Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckboxPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SliderPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectorPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromToTimePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomSettingsNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_TitleSoloCoop;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_TitleHost;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_MaxPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_MaxPlayers_Tooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSize_Tooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Custom;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Show;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsLocalizationMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__FromView;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentViewState;
    private static readonly System.IntPtr NativeFieldInfoPtr__HostMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedGameMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerSaves;
    private static readonly System.IntPtr NativeFieldInfoPtr__SaveEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerHostSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameSettings_Edit;
    private static readonly System.IntPtr NativeFieldInfoPtr__PresetEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr_PRESET_FOLDER;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PLAYERS_INIT_KEY;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_PVE_PRESET_FILENAME;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_PVP_PRESET_FILENAME;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PLAYERS_MIN;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PLAYERS_MAX;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PLAYERS_DEFAULT;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PLAYERS_INIT;
    private static readonly System.IntPtr NativeFieldInfoPtr__DayLengths;
    private static readonly System.IntPtr NativeFieldInfoPtr__SaveNameRegex;
    private static readonly System.IntPtr NativeFieldInfoPtr__PresetEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedPresetEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastlePvPWeekdayFromToTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastlePvPWeekendFromToTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPvPWeekdayFromToTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPvPWeekendFromToTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPvPDamageModeSelector;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleHeartDamageModeSelector;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleUnderAttackTimerSlider;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleSiegeTimerSlider;
    private static readonly System.IntPtr NativeFieldInfoPtr__SiegeWeaponHealthSelector;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeCastleRaidCheckbox;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleRaidTimerSlider;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleRaidProtectionTimeSlider;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeCastleClaimCheckbox;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeCastleDestroyCheckbox;
    private static readonly System.IntPtr NativeFieldInfoPtr__AnnounceSiegeWeaponSpawnCheckbox;
    private static readonly System.IntPtr NativeFieldInfoPtr__ShowSiegeWeaponMapIconCheckbox;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodUnitFields;
    private static readonly System.IntPtr NativeFieldInfoPtr_JournalFields;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserPresetsPath_Private_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenURL_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitInitData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_HostSelectHosting_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_HostSavedServer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_HostNewServer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetGameMode_Private_Void_GameModeType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnGameModeChanged_Private_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitGameSettings_Private_Void_GameModeSelectionFlow_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPresetFileNameByHostMode_Private_Boolean_HostMode_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPresetFileNameByGameMode_Private_Boolean_GameModeType_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPresetIndexByGameMode_Private_Boolean_GameModeSelectionFlow_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckGameSettingsPresetMatch_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindMatchingPreset_Private_Boolean_String_ServerSettingsPresetType_byref_ServerGameSettingsTemplate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_CustomSettings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetVBloodUnitSetting_Private_Boolean_ServerGameSettings_Int32_byref_VBloodUnitSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrSetVBloodUnitSetting_Private_Void_ServerGameSettings_VBloodUnitSetting_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateShowPlayerInteractionConditionals_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IndexToDayLength_Private_Void_GameTimeModifiers_Int32_Il2CppReferenceArray_1_GameTimeModifiers_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DayLengthToIndex_Private_Int32_GameTimeModifiers_Il2CppReferenceArray_1_GameTimeModifiers_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SecondsToDayLength_Private_DayLength_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DayLengthToSeconds_Private_Single_DayLength_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearCustomSettings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SwitchView_Private_Void_ViewState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader1_Private_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader2_Private_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader3_Private_CustomGameSettings_Label_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCheckbox_Private_CustomGameSettings_Checkbox_String_Boolean_Boolean_Action_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddFromToTime_Private_CustomGameSettings_FromToTime_String_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Private_CustomGameSettings_Slider_String_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Private_Void_String_Int32_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSelector_Private_CustomGameSettings_Selector_String_Int32_Int32_List_1_LocalizationKey_Boolean_Boolean_Action_2_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSelector_Private_CustomGameSettings_Selector_String_Int32_Int32_List_1_String_Boolean_Boolean_Action_2_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckForSettingsChanges_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ServerNameInputField_OnValueChanged_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PasswordInputField_OnValueChanged_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ServerDescriptionInputField_OnValueChanged_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MaxUsersInputField_OnValueChanged_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckStartNewButton_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckSaveNameOK_Private_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckServerNameOK_Private_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Join_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_HostNewServer_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_HostSavedServer_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_OpenAdvancedOptions_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_CloseAdvancedOptions_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_StartNewServer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_TogglePassword_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_BackToMainMenu_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoBack_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HostSelectBackButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HostNewBackButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_OpenSavePresetPopup_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSavePresetPopup_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckSavePresetButton_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnValueChange_PresetNameInputField_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_OpenLoadPresetPopup_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_SaveSettings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitLoadPresetPopup_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshPresetList_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadPresetsFromPath_Private_Void_String_ServerSettingsPresetType_Nullable_Unboxed_1_GameModeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadPresetbyFileName_Private_Boolean_String_ServerSettingsPresetType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPresetEntrySelected_Private_Void_SavedServerSettingsPresetEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPresetEntryDeleteClicked_Private_Void_SavedServerSettingsPresetEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitDeletePrefabSubPopup_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedPresetEntry_Private_Void_SavedServerSettingsPresetEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckLoadButton_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdvancedSettingsBackButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BackFromAdvancedSettings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenUnsavedChangesPopup_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SettingsHasChanges_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_CancelSavePreset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_SavePreset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_CancelLoadPreset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_LoadPreset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_CancelDeletePreset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CloseDeletePresetSubPopup_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_DeletePreset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDeletePreset_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_UnsavedChanges_No_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_UnsavedChanges_Yes_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCloseActivePopup_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PopupHandleBack_LoadPreset_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidFilename_Private_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__104_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__104_1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__104_2_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__104_3_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__104_4_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Init_HostNewServer_b__111_0_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Init_HostNewServer_b__111_1_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Init_HostNewServer_b__111_2_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__211_0_Private_Void_Boolean_Int32_0;

    public unsafe string UserPresetsPath
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 1281054, RefRangeEnd = 1281060, XrefRangeStart = 1281047, XrefRangeEnd = 1281054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_get_UserPresetsPath_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281060, XrefRangeEnd = 1281294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1281306, RefRangeEnd = 1281308, XrefRangeStart = 1281294, XrefRangeEnd = 1281306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenURL(string url)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(url);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OpenURL_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281308, XrefRangeEnd = 1281316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1281347, RefRangeEnd = 1281348, XrefRangeStart = 1281316, XrefRangeEnd = 1281347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitInitData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_InitInitData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281348, XrefRangeEnd = 1281350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init_HostSelectHosting()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_Init_HostSelectHosting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281350, XrefRangeEnd = 1281371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init_HostSavedServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_Init_HostSavedServer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281371, XrefRangeEnd = 1281442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init_HostNewServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_Init_HostNewServer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1281451, RefRangeEnd = 1281452, XrefRangeStart = 1281442, XrefRangeEnd = 1281451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetGameMode(GameModeType gameMode, bool initializeSettings = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &gameMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initializeSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_SetGameMode_Private_Void_GameModeType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281452, XrefRangeEnd = 1281456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnGameModeChanged(int oldIndex, int newIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &oldIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnGameModeChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1281465, RefRangeEnd = 1281470, XrefRangeStart = 1281456, XrefRangeEnd = 1281465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitGameSettings(GameModeSelectionFlow gameMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &gameMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_InitGameSettings_Private_Void_GameModeSelectionFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281470, XrefRangeEnd = 1281475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPresetFileNameByHostMode(
      PlayHostMenuView.HostMode hostMode,
      out string fileName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &hostMode;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_TryGetPresetFileNameByHostMode_Private_Boolean_HostMode_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      fileName = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281475, XrefRangeEnd = 1281480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPresetFileNameByGameMode(GameModeType gameMode, out string fileName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &gameMode;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_TryGetPresetFileNameByGameMode_Private_Boolean_GameModeType_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      fileName = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool TryGetPresetIndexByGameMode(GameModeSelectionFlow gameMode, out int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &gameMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_TryGetPresetIndexByGameMode_Private_Boolean_GameModeSelectionFlow_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1281484, RefRangeEnd = 1281490, XrefRangeStart = 1281480, XrefRangeEnd = 1281484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckGameSettingsPresetMatch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_CheckGameSettingsPresetMatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1281539, RefRangeEnd = 1281541, XrefRangeStart = 1281490, XrefRangeEnd = 1281539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindMatchingPreset(
      string presetHash,
      ServerSettingsPresetType presetType,
      out ServerGameSettingsTemplate template)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(presetHash);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &presetType;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_TryFindMatchingPreset_Private_Boolean_String_ServerSettingsPresetType_byref_ServerGameSettingsTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerGameSettingsTemplate local = ref template;
      System.IntPtr pointer = zero;
      ServerGameSettingsTemplate settingsTemplate = pointer == System.IntPtr.Zero ? (ServerGameSettingsTemplate) null : new ServerGameSettingsTemplate(pointer);
      local = settingsTemplate;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1282843, RefRangeEnd = 1282845, XrefRangeStart = 1281541, XrefRangeEnd = 1282843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init_CustomSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_Init_CustomSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1282852, RefRangeEnd = 1282854, XrefRangeStart = 1282845, XrefRangeEnd = 1282852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetVBloodUnitSetting(
      ServerGameSettings gameSetting,
      int vBloodId,
      out VBloodUnitSetting setting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameSetting);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vBloodId;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_TryGetVBloodUnitSetting_Private_Boolean_ServerGameSettings_Int32_byref_VBloodUnitSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref VBloodUnitSetting local = ref setting;
      System.IntPtr pointer = zero;
      VBloodUnitSetting vbloodUnitSetting = pointer == System.IntPtr.Zero ? (VBloodUnitSetting) null : new VBloodUnitSetting(pointer);
      local = vbloodUnitSetting;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1282863, RefRangeEnd = 1282865, XrefRangeStart = 1282854, XrefRangeEnd = 1282863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrSetVBloodUnitSetting(
      ServerGameSettings gameSetting,
      VBloodUnitSetting setting,
      int defaultLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameSetting);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) setting);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultLevel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddOrSetVBloodUnitSetting_Private_Void_ServerGameSettings_VBloodUnitSetting_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1282888, RefRangeEnd = 1282891, XrefRangeStart = 1282865, XrefRangeEnd = 1282888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateShowPlayerInteractionConditionals()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_UpdateShowPlayerInteractionConditionals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1282891, RefRangeEnd = 1282892, XrefRangeStart = 1282891, XrefRangeEnd = 1282891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IndexToDayLength(
      GameTimeModifiers sgsGTM,
      int index,
      Il2CppReferenceArray<GameTimeModifiers> dayTimes,
      int defaultIndex = 2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sgsGTM);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dayTimes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_IndexToDayLength_Private_Void_GameTimeModifiers_Int32_Il2CppReferenceArray_1_GameTimeModifiers_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282892, XrefRangeEnd = 1282893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int DayLengthToIndex(
      GameTimeModifiers gtm,
      Il2CppReferenceArray<GameTimeModifiers> a,
      int defaultIndex = 2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gtm);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_DayLengthToIndex_Private_Int32_GameTimeModifiers_Il2CppReferenceArray_1_GameTimeModifiers_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1282894, RefRangeEnd = 1282896, XrefRangeStart = 1282893, XrefRangeEnd = 1282894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayHostMenuView.DayLength SecondsToDayLength(float duration)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &duration;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_SecondsToDayLength_Private_DayLength_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlayHostMenuView.DayLength*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1282896, RefRangeEnd = 1282897, XrefRangeStart = 1282896, XrefRangeEnd = 1282896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float DayLengthToSeconds(PlayHostMenuView.DayLength dayLength)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &dayLength;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_DayLengthToSeconds_Private_Single_DayLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1282921, RefRangeEnd = 1282922, XrefRangeStart = 1282897, XrefRangeEnd = 1282921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearCustomSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_ClearCustomSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1282927, RefRangeEnd = 1282936, XrefRangeStart = 1282922, XrefRangeEnd = 1282927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SwitchView(PlayHostMenuView.ViewState state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_SwitchView_Private_Void_ViewState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1282940, RefRangeEnd = 1282947, XrefRangeStart = 1282936, XrefRangeEnd = 1282940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHeader1(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddHeader1_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1282951, RefRangeEnd = 1282952, XrefRangeStart = 1282947, XrefRangeEnd = 1282951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHeader2(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddHeader2_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282952, XrefRangeEnd = 1282956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Label AddHeader3(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddHeader3_Private_CustomGameSettings_Label_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomGameSettings_Label) null : new CustomGameSettings_Label(pointer);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1282979, RefRangeEnd = 1282988, XrefRangeStart = 1282956, XrefRangeEnd = 1282979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Checkbox AddCheckbox(
      string identifier,
      bool defValue,
      bool initValue,
      Il2CppSystem.Action<bool> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddCheckbox_Private_CustomGameSettings_Checkbox_String_Boolean_Boolean_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1283010, RefRangeEnd = 1283014, XrefRangeStart = 1282988, XrefRangeEnd = 1283010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_FromToTime AddFromToTime(
      string identifier,
      StartEndTimeData defValue,
      StartEndTimeData initValue,
      Il2CppSystem.Action<StartEndTimeData> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defValue);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initValue);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddFromToTime_Private_CustomGameSettings_FromToTime_String_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomGameSettings_FromToTime) null : new CustomGameSettings_FromToTime(pointer);
    }

    [CallerCount(43)]
    [CachedScanResults(RefRangeStart = 1283037, RefRangeEnd = 1283080, XrefRangeStart = 1283014, XrefRangeEnd = 1283037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Slider AddSlider(
      string identifier,
      float sliderMinValue,
      float sliderMaxValue,
      float defValue,
      float initValue,
      int decimals,
      bool wholeNumbers,
      Il2CppSystem.Action<float> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sliderMinValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sliderMaxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &wholeNumbers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddSlider_Private_CustomGameSettings_Slider_String_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 1283107, RefRangeEnd = 1283121, XrefRangeStart = 1283080, XrefRangeEnd = 1283107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSlider(
      string identifier,
      int value,
      float sliderMinValue,
      float sliderMaxValue,
      float defValue,
      float initValue,
      int decimals,
      bool wholeNumbers,
      Il2CppSystem.Action<float> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sliderMinValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sliderMaxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &wholeNumbers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddSlider_Private_Void_String_Int32_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1283144, RefRangeEnd = 1283156, XrefRangeStart = 1283121, XrefRangeEnd = 1283144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Selector AddSelector(
      string identifier,
      int defValue,
      int initValue,
      List<LocalizationKey> keys,
      bool loopAround,
      bool useIndexIndicator,
      Il2CppSystem.Action<int, int> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &loopAround;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &useIndexIndicator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddSelector_Private_CustomGameSettings_Selector_String_Int32_Int32_List_1_LocalizationKey_Boolean_Boolean_Action_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1283179, RefRangeEnd = 1283181, XrefRangeStart = 1283156, XrefRangeEnd = 1283179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Selector AddSelector(
      string identifier,
      int defValue,
      int initValue,
      List<string> keys,
      bool loopAround,
      bool useIndexIndicator,
      Il2CppSystem.Action<int, int> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &loopAround;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &useIndexIndicator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AddSelector_Private_CustomGameSettings_Selector_String_Int32_Int32_List_1_String_Boolean_Boolean_Action_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1283186, RefRangeEnd = 1283195, XrefRangeStart = 1283181, XrefRangeEnd = 1283186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckForSettingsChanges()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_CheckForSettingsChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283195, XrefRangeEnd = 1283203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ServerNameInputField_OnValueChanged(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_ServerNameInputField_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283203, XrefRangeEnd = 1283210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PasswordInputField_OnValueChanged(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_PasswordInputField_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ServerDescriptionInputField_OnValueChanged(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_ServerDescriptionInputField_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283210, XrefRangeEnd = 1283211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MaxUsersInputField_OnValueChanged(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_MaxUsersInputField_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1283227, RefRangeEnd = 1283231, XrefRangeStart = 1283211, XrefRangeEnd = 1283227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckStartNewButton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_CheckStartNewButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283231, XrefRangeEnd = 1283249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckSaveNameOK(string saveName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_CheckSaveNameOK_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283249, XrefRangeEnd = 1283250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckServerNameOK(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_CheckServerNameOK_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Join()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_Join_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283250, XrefRangeEnd = 1283298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_HostNewServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_HostNewServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283298, XrefRangeEnd = 1283317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_HostSavedServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_HostSavedServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283317, XrefRangeEnd = 1283318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_OpenAdvancedOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_OpenAdvancedOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283318, XrefRangeEnd = 1283319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_CloseAdvancedOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_CloseAdvancedOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_StartNewServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_StartNewServer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283319, XrefRangeEnd = 1283327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_TogglePassword()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_TogglePassword_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_BackToMainMenu()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_BackToMainMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GoBack()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HostSelectBackButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_HostSelectBackButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283327, XrefRangeEnd = 1283329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HostNewBackButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_HostNewBackButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283329, XrefRangeEnd = 1283342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_OpenSavePresetPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_OpenSavePresetPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283342, XrefRangeEnd = 1283354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSavePresetPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_InitSavePresetPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283354, XrefRangeEnd = 1283359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckSavePresetButton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_CheckSavePresetButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValueChange_PresetNameInputField(string newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(newValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnValueChange_PresetNameInputField_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283359, XrefRangeEnd = 1283364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_OpenLoadPresetPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_OpenLoadPresetPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283364, XrefRangeEnd = 1283372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_SaveSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_SaveSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283372, XrefRangeEnd = 1283376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitLoadPresetPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_InitLoadPresetPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1283427, RefRangeEnd = 1283430, XrefRangeStart = 1283376, XrefRangeEnd = 1283427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshPresetList()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_RefreshPresetList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1283512, RefRangeEnd = 1283514, XrefRangeStart = 1283430, XrefRangeEnd = 1283512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadPresetsFromPath(
      string path,
      ServerSettingsPresetType presetType,
      Nullable_Unboxed<GameModeType> gameMode = default (Nullable_Unboxed<GameModeType>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &presetType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gameMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_LoadPresetsFromPath_Private_Void_String_ServerSettingsPresetType_Nullable_Unboxed_1_GameModeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283514, XrefRangeEnd = 1283552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryLoadPresetbyFileName(string fileName, ServerSettingsPresetType presetType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &presetType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_TryLoadPresetbyFileName_Private_Boolean_String_ServerSettingsPresetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283552, XrefRangeEnd = 1283572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnPresetEntrySelected(SavedServerSettingsPresetEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnPresetEntrySelected_Private_Void_SavedServerSettingsPresetEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283572, XrefRangeEnd = 1283574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnPresetEntryDeleteClicked(SavedServerSettingsPresetEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnPresetEntryDeleteClicked_Private_Void_SavedServerSettingsPresetEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitDeletePrefabSubPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_InitDeletePrefabSubPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1283595, RefRangeEnd = 1283597, XrefRangeStart = 1283574, XrefRangeEnd = 1283595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSelectedPresetEntry(SavedServerSettingsPresetEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_SetSelectedPresetEntry_Private_Void_SavedServerSettingsPresetEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283597, XrefRangeEnd = 1283605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckLoadButton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_CheckLoadButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283605, XrefRangeEnd = 1283606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AdvancedSettingsBackButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_AdvancedSettingsBackButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1283612, RefRangeEnd = 1283614, XrefRangeStart = 1283606, XrefRangeEnd = 1283612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BackFromAdvancedSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_BackFromAdvancedSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283614, XrefRangeEnd = 1283615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenUnsavedChangesPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OpenUnsavedChangesPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1283618, RefRangeEnd = 1283619, XrefRangeStart = 1283615, XrefRangeEnd = 1283618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SettingsHasChanges()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_SettingsHasChanges_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283619, XrefRangeEnd = 1283620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_CancelSavePreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_CancelSavePreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283620, XrefRangeEnd = 1283637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_SavePreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_SavePreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_CancelLoadPreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_CancelLoadPreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283637, XrefRangeEnd = 1283644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_LoadPreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_LoadPreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283644, XrefRangeEnd = 1283645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_CancelDeletePreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_CancelDeletePreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CloseDeletePresetSubPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_CloseDeletePresetSubPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283645, XrefRangeEnd = 1283648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_DeletePreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_DeletePreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1283657, RefRangeEnd = 1283658, XrefRangeStart = 1283648, XrefRangeEnd = 1283657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryDeletePreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_TryDeletePreset_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_UnsavedChanges_No()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_UnsavedChanges_No_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283658, XrefRangeEnd = 1283660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_UnsavedChanges_Yes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_UnsavedChanges_Yes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283660, XrefRangeEnd = 1283707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283707, XrefRangeEnd = 1283710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1283722, RefRangeEnd = 1283732, XrefRangeStart = 1283710, XrefRangeEnd = 1283722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryCloseActivePopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_TryCloseActivePopup_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283732, XrefRangeEnd = 1283735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool PopupHandleBack_LoadPreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_PopupHandleBack_LoadPreset_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283735, XrefRangeEnd = 1283736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidFilename(string fileName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr_IsValidFilename_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283736, XrefRangeEnd = 1283770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayHostMenuView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__104_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283770, XrefRangeEnd = 1283773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__104_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283773, XrefRangeEnd = 1283776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__104_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283776, XrefRangeEnd = 1283784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__104_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283784, XrefRangeEnd = 1283792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__104_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Init_HostNewServer_b__111_0(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Init_HostNewServer_b__111_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283792, XrefRangeEnd = 1283797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Init_HostNewServer_b__111_1(bool x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Init_HostNewServer_b__111_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283797, XrefRangeEnd = 1283799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Init_HostNewServer_b__111_2(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Init_HostNewServer_b__111_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Update_b__211_0(bool selected, int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &selected;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.NativeMethodInfoPtr__Update_b__211_0_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayHostMenuView()
    {
      Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PlayHostMenuView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr);
      PlayHostMenuView.NativeFieldInfoPtr_MenuCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MenuCollection));
      PlayHostMenuView.NativeFieldInfoPtr_ViewHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (ViewHeaderText));
      PlayHostMenuView.NativeFieldInfoPtr_HostSelectNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (HostSelectNode));
      PlayHostMenuView.NativeFieldInfoPtr_HostSavedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (HostSavedNode));
      PlayHostMenuView.NativeFieldInfoPtr_HostNewNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (HostNewNode));
      PlayHostMenuView.NativeFieldInfoPtr_AdvancedSettingsNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (AdvancedSettingsNode));
      PlayHostMenuView.NativeFieldInfoPtr_SelectHostInGameServerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SelectHostInGameServerButton));
      PlayHostMenuView.NativeFieldInfoPtr_SelectHostDedicatedServerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SelectHostDedicatedServerButton));
      PlayHostMenuView.NativeFieldInfoPtr_SelectRentServerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SelectRentServerButton));
      PlayHostMenuView.NativeFieldInfoPtr_HostSelectBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (HostSelectBackButton));
      PlayHostMenuView.NativeFieldInfoPtr_SaveListNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SaveListNode));
      PlayHostMenuView.NativeFieldInfoPtr_SaveEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SaveEntryPrefab));
      PlayHostMenuView.NativeFieldInfoPtr_SaveListGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SaveListGroup));
      PlayHostMenuView.NativeFieldInfoPtr_NoSavedServersMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (NoSavedServersMessage));
      PlayHostMenuView.NativeFieldInfoPtr_BackToMainMenuButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (BackToMainMenuButton));
      PlayHostMenuView.NativeFieldInfoPtr_StartNewServerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (StartNewServerButton));
      PlayHostMenuView.NativeFieldInfoPtr_HostSavedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (HostSavedButton));
      PlayHostMenuView.NativeFieldInfoPtr_HostNewBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (HostNewBackButton));
      PlayHostMenuView.NativeFieldInfoPtr_HostNewButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (HostNewButton));
      PlayHostMenuView.NativeFieldInfoPtr_ServerNameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (ServerNameInputField));
      PlayHostMenuView.NativeFieldInfoPtr_ServerDescriptionInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (ServerDescriptionInputField));
      PlayHostMenuView.NativeFieldInfoPtr_MaxUsersInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MaxUsersInputField));
      PlayHostMenuView.NativeFieldInfoPtr_PasswordInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (PasswordInputField));
      PlayHostMenuView.NativeFieldInfoPtr_TogglePasswordButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (TogglePasswordButton));
      PlayHostMenuView.NativeFieldInfoPtr_GameModeSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (GameModeSelector));
      PlayHostMenuView.NativeFieldInfoPtr_GameModeSelectButton_PvE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (GameModeSelectButton_PvE));
      PlayHostMenuView.NativeFieldInfoPtr_GameModeSelectButton_PvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (GameModeSelectButton_PvP));
      PlayHostMenuView.NativeFieldInfoPtr_HostNewOpenLoadPresetPopupButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (HostNewOpenLoadPresetPopupButton));
      PlayHostMenuView.NativeFieldInfoPtr_LanServerCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LanServerCheckbox));
      PlayHostMenuView.NativeFieldInfoPtr_MaxUsersSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MaxUsersSlider));
      PlayHostMenuView.NativeFieldInfoPtr_OnlyLocalPlayCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (OnlyLocalPlayCheckbox));
      PlayHostMenuView.NativeFieldInfoPtr_ClanSizeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (ClanSizeSlider));
      PlayHostMenuView.NativeFieldInfoPtr_MatchingGameModeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MatchingGameModeText));
      PlayHostMenuView.NativeFieldInfoPtr_BackToHostNewButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (BackToHostNewButton));
      PlayHostMenuView.NativeFieldInfoPtr_OpenSavePresetPopupButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (OpenSavePresetPopupButton));
      PlayHostMenuView.NativeFieldInfoPtr_OpenLoadPresetPopupButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (OpenLoadPresetPopupButton));
      PlayHostMenuView.NativeFieldInfoPtr_SaveSettingsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SaveSettingsButton));
      PlayHostMenuView.NativeFieldInfoPtr_OpenAdvancedOptionsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (OpenAdvancedOptionsButton));
      PlayHostMenuView.NativeFieldInfoPtr_CloseAdvancedOptionsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (CloseAdvancedOptionsButton));
      PlayHostMenuView.NativeFieldInfoPtr_AdvancedSettingsPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (AdvancedSettingsPopupNode));
      PlayHostMenuView.NativeFieldInfoPtr_SavePresetPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SavePresetPopupNode));
      PlayHostMenuView.NativeFieldInfoPtr_LoadPresetPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LoadPresetPopupNode));
      PlayHostMenuView.NativeFieldInfoPtr_UnsavedChangesPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (UnsavedChangesPopupNode));
      PlayHostMenuView.NativeFieldInfoPtr_PresetNameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (PresetNameInputField));
      PlayHostMenuView.NativeFieldInfoPtr_PresetDescriptionInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (PresetDescriptionInputField));
      PlayHostMenuView.NativeFieldInfoPtr_CancelSavePresetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (CancelSavePresetButton));
      PlayHostMenuView.NativeFieldInfoPtr_SavePresetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SavePresetButton));
      PlayHostMenuView.NativeFieldInfoPtr_CancelLoadPresetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (CancelLoadPresetButton));
      PlayHostMenuView.NativeFieldInfoPtr_LoadPresetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LoadPresetButton));
      PlayHostMenuView.NativeFieldInfoPtr_LoadPresetsScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LoadPresetsScrollRect));
      PlayHostMenuView.NativeFieldInfoPtr_LoadPresetListNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LoadPresetListNode));
      PlayHostMenuView.NativeFieldInfoPtr_PresetEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (PresetEntryPrefab));
      PlayHostMenuView.NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (PresetName));
      PlayHostMenuView.NativeFieldInfoPtr_PresetDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (PresetDescription));
      PlayHostMenuView.NativeFieldInfoPtr_NoPresetSelectedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (NoPresetSelectedText));
      PlayHostMenuView.NativeFieldInfoPtr_DeletePresetSubPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (DeletePresetSubPopupNode));
      PlayHostMenuView.NativeFieldInfoPtr_DeletePresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (DeletePresetName));
      PlayHostMenuView.NativeFieldInfoPtr_CancelDeletePresetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (CancelDeletePresetButton));
      PlayHostMenuView.NativeFieldInfoPtr_DeletePresetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (DeletePresetButton));
      PlayHostMenuView.NativeFieldInfoPtr_UnsavedChanges_NoButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (UnsavedChanges_NoButton));
      PlayHostMenuView.NativeFieldInfoPtr_UnsavedChanges_YesButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (UnsavedChanges_YesButton));
      PlayHostMenuView.NativeFieldInfoPtr_Label1Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (Label1Prefab));
      PlayHostMenuView.NativeFieldInfoPtr_Label2Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (Label2Prefab));
      PlayHostMenuView.NativeFieldInfoPtr_Label3Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (Label3Prefab));
      PlayHostMenuView.NativeFieldInfoPtr_CheckboxPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (CheckboxPrefab));
      PlayHostMenuView.NativeFieldInfoPtr_SliderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SliderPrefab));
      PlayHostMenuView.NativeFieldInfoPtr_SelectorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SelectorPrefab));
      PlayHostMenuView.NativeFieldInfoPtr_FromToTimePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (FromToTimePrefab));
      PlayHostMenuView.NativeFieldInfoPtr_CustomSettingsNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (CustomSettingsNode));
      PlayHostMenuView.NativeFieldInfoPtr_LK_TitleSoloCoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_TitleSoloCoop));
      PlayHostMenuView.NativeFieldInfoPtr_LK_TitleHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_TitleHost));
      PlayHostMenuView.NativeFieldInfoPtr_LK_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_MaxPlayers));
      PlayHostMenuView.NativeFieldInfoPtr_LK_MaxPlayers_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_MaxPlayers_Tooltip));
      PlayHostMenuView.NativeFieldInfoPtr_LK_ClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_ClanSize));
      PlayHostMenuView.NativeFieldInfoPtr_LK_ClanSize_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_ClanSize_Tooltip));
      PlayHostMenuView.NativeFieldInfoPtr_LK_Custom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_Custom));
      PlayHostMenuView.NativeFieldInfoPtr_LK_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_Show));
      PlayHostMenuView.NativeFieldInfoPtr_SettingsLocalizationMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (SettingsLocalizationMapping));
      PlayHostMenuView.NativeFieldInfoPtr_LK_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (LK_GameMode));
      PlayHostMenuView.NativeFieldInfoPtr__FromView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_FromView));
      PlayHostMenuView.NativeFieldInfoPtr__CurrentViewState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_CurrentViewState));
      PlayHostMenuView.NativeFieldInfoPtr__HostMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_HostMode));
      PlayHostMenuView.NativeFieldInfoPtr__SelectedGameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_SelectedGameMode));
      PlayHostMenuView.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_InputSystem));
      PlayHostMenuView.NativeFieldInfoPtr__ServerSaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_ServerSaves));
      PlayHostMenuView.NativeFieldInfoPtr__SaveEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_SaveEntries));
      PlayHostMenuView.NativeFieldInfoPtr__Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_Selected));
      PlayHostMenuView.NativeFieldInfoPtr__ServerHostSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_ServerHostSettings));
      PlayHostMenuView.NativeFieldInfoPtr__ServerGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_ServerGameSettings));
      PlayHostMenuView.NativeFieldInfoPtr__ServerGameSettings_Edit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_ServerGameSettings_Edit));
      PlayHostMenuView.NativeFieldInfoPtr__PresetEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_PresetEntriesCache));
      PlayHostMenuView.NativeFieldInfoPtr_PRESET_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (PRESET_FOLDER));
      PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_INIT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MAX_PLAYERS_INIT_KEY));
      PlayHostMenuView.NativeFieldInfoPtr_DEFAULT_PVE_PRESET_FILENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (DEFAULT_PVE_PRESET_FILENAME));
      PlayHostMenuView.NativeFieldInfoPtr_DEFAULT_PVP_PRESET_FILENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (DEFAULT_PVP_PRESET_FILENAME));
      PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MAX_PLAYERS_MIN));
      PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MAX_PLAYERS_MAX));
      PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MAX_PLAYERS_DEFAULT));
      PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_INIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (MAX_PLAYERS_INIT));
      PlayHostMenuView.NativeFieldInfoPtr__DayLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_DayLengths));
      PlayHostMenuView.NativeFieldInfoPtr__SaveNameRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_SaveNameRegex));
      PlayHostMenuView.NativeFieldInfoPtr__PresetEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_PresetEntries));
      PlayHostMenuView.NativeFieldInfoPtr__SelectedPresetEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_SelectedPresetEntry));
      PlayHostMenuView.NativeFieldInfoPtr__CastlePvPWeekdayFromToTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_CastlePvPWeekdayFromToTime));
      PlayHostMenuView.NativeFieldInfoPtr__CastlePvPWeekendFromToTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_CastlePvPWeekendFromToTime));
      PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPWeekdayFromToTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_PlayerPvPWeekdayFromToTime));
      PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPWeekendFromToTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_PlayerPvPWeekendFromToTime));
      PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPDamageModeSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_PlayerPvPDamageModeSelector));
      PlayHostMenuView.NativeFieldInfoPtr__CastleHeartDamageModeSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_CastleHeartDamageModeSelector));
      PlayHostMenuView.NativeFieldInfoPtr__CastleUnderAttackTimerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_CastleUnderAttackTimerSlider));
      PlayHostMenuView.NativeFieldInfoPtr__CastleSiegeTimerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_CastleSiegeTimerSlider));
      PlayHostMenuView.NativeFieldInfoPtr__SiegeWeaponHealthSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_SiegeWeaponHealthSelector));
      PlayHostMenuView.NativeFieldInfoPtr__FreeCastleRaidCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_FreeCastleRaidCheckbox));
      PlayHostMenuView.NativeFieldInfoPtr__CastleRaidTimerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_CastleRaidTimerSlider));
      PlayHostMenuView.NativeFieldInfoPtr__CastleRaidProtectionTimeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_CastleRaidProtectionTimeSlider));
      PlayHostMenuView.NativeFieldInfoPtr__FreeCastleClaimCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_FreeCastleClaimCheckbox));
      PlayHostMenuView.NativeFieldInfoPtr__FreeCastleDestroyCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_FreeCastleDestroyCheckbox));
      PlayHostMenuView.NativeFieldInfoPtr__AnnounceSiegeWeaponSpawnCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_AnnounceSiegeWeaponSpawnCheckbox));
      PlayHostMenuView.NativeFieldInfoPtr__ShowSiegeWeaponMapIconCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (_ShowSiegeWeaponMapIconCheckbox));
      PlayHostMenuView.NativeFieldInfoPtr_VBloodUnitFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (VBloodUnitFields));
      PlayHostMenuView.NativeFieldInfoPtr_JournalFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (JournalFields));
      PlayHostMenuView.NativeMethodInfoPtr_get_UserPresetsPath_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669053);
      PlayHostMenuView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669054);
      PlayHostMenuView.NativeMethodInfoPtr_OpenURL_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669055);
      PlayHostMenuView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669056);
      PlayHostMenuView.NativeMethodInfoPtr_InitInitData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669057);
      PlayHostMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669058);
      PlayHostMenuView.NativeMethodInfoPtr_Init_HostSelectHosting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669059);
      PlayHostMenuView.NativeMethodInfoPtr_Init_HostSavedServer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669060);
      PlayHostMenuView.NativeMethodInfoPtr_Init_HostNewServer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669061);
      PlayHostMenuView.NativeMethodInfoPtr_SetGameMode_Private_Void_GameModeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669062);
      PlayHostMenuView.NativeMethodInfoPtr_OnGameModeChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669063);
      PlayHostMenuView.NativeMethodInfoPtr_InitGameSettings_Private_Void_GameModeSelectionFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669064);
      PlayHostMenuView.NativeMethodInfoPtr_TryGetPresetFileNameByHostMode_Private_Boolean_HostMode_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669065);
      PlayHostMenuView.NativeMethodInfoPtr_TryGetPresetFileNameByGameMode_Private_Boolean_GameModeType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669066);
      PlayHostMenuView.NativeMethodInfoPtr_TryGetPresetIndexByGameMode_Private_Boolean_GameModeSelectionFlow_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669067);
      PlayHostMenuView.NativeMethodInfoPtr_CheckGameSettingsPresetMatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669068);
      PlayHostMenuView.NativeMethodInfoPtr_TryFindMatchingPreset_Private_Boolean_String_ServerSettingsPresetType_byref_ServerGameSettingsTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669069);
      PlayHostMenuView.NativeMethodInfoPtr_Init_CustomSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669070);
      PlayHostMenuView.NativeMethodInfoPtr_TryGetVBloodUnitSetting_Private_Boolean_ServerGameSettings_Int32_byref_VBloodUnitSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669071);
      PlayHostMenuView.NativeMethodInfoPtr_AddOrSetVBloodUnitSetting_Private_Void_ServerGameSettings_VBloodUnitSetting_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669072);
      PlayHostMenuView.NativeMethodInfoPtr_UpdateShowPlayerInteractionConditionals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669073);
      PlayHostMenuView.NativeMethodInfoPtr_IndexToDayLength_Private_Void_GameTimeModifiers_Int32_Il2CppReferenceArray_1_GameTimeModifiers_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669074);
      PlayHostMenuView.NativeMethodInfoPtr_DayLengthToIndex_Private_Int32_GameTimeModifiers_Il2CppReferenceArray_1_GameTimeModifiers_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669075);
      PlayHostMenuView.NativeMethodInfoPtr_SecondsToDayLength_Private_DayLength_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669076);
      PlayHostMenuView.NativeMethodInfoPtr_DayLengthToSeconds_Private_Single_DayLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669077);
      PlayHostMenuView.NativeMethodInfoPtr_ClearCustomSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669078);
      PlayHostMenuView.NativeMethodInfoPtr_SwitchView_Private_Void_ViewState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669079);
      PlayHostMenuView.NativeMethodInfoPtr_AddHeader1_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669080);
      PlayHostMenuView.NativeMethodInfoPtr_AddHeader2_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669081);
      PlayHostMenuView.NativeMethodInfoPtr_AddHeader3_Private_CustomGameSettings_Label_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669082);
      PlayHostMenuView.NativeMethodInfoPtr_AddCheckbox_Private_CustomGameSettings_Checkbox_String_Boolean_Boolean_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669083);
      PlayHostMenuView.NativeMethodInfoPtr_AddFromToTime_Private_CustomGameSettings_FromToTime_String_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669084);
      PlayHostMenuView.NativeMethodInfoPtr_AddSlider_Private_CustomGameSettings_Slider_String_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669085);
      PlayHostMenuView.NativeMethodInfoPtr_AddSlider_Private_Void_String_Int32_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669086);
      PlayHostMenuView.NativeMethodInfoPtr_AddSelector_Private_CustomGameSettings_Selector_String_Int32_Int32_List_1_LocalizationKey_Boolean_Boolean_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669087);
      PlayHostMenuView.NativeMethodInfoPtr_AddSelector_Private_CustomGameSettings_Selector_String_Int32_Int32_List_1_String_Boolean_Boolean_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669088);
      PlayHostMenuView.NativeMethodInfoPtr_CheckForSettingsChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669089);
      PlayHostMenuView.NativeMethodInfoPtr_ServerNameInputField_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669090);
      PlayHostMenuView.NativeMethodInfoPtr_PasswordInputField_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669091);
      PlayHostMenuView.NativeMethodInfoPtr_ServerDescriptionInputField_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669092);
      PlayHostMenuView.NativeMethodInfoPtr_MaxUsersInputField_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669093);
      PlayHostMenuView.NativeMethodInfoPtr_CheckStartNewButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669094);
      PlayHostMenuView.NativeMethodInfoPtr_CheckSaveNameOK_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669095);
      PlayHostMenuView.NativeMethodInfoPtr_CheckServerNameOK_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669096);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_Join_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669097);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_HostNewServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669098);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_HostSavedServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669099);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_OpenAdvancedOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669100);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_CloseAdvancedOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669101);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_StartNewServer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669102);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_TogglePassword_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669103);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_BackToMainMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669104);
      PlayHostMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669105);
      PlayHostMenuView.NativeMethodInfoPtr_HostSelectBackButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669106);
      PlayHostMenuView.NativeMethodInfoPtr_HostNewBackButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669107);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_OpenSavePresetPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669108);
      PlayHostMenuView.NativeMethodInfoPtr_InitSavePresetPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669109);
      PlayHostMenuView.NativeMethodInfoPtr_CheckSavePresetButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669110);
      PlayHostMenuView.NativeMethodInfoPtr_OnValueChange_PresetNameInputField_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669111);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_OpenLoadPresetPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669112);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_SaveSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669113);
      PlayHostMenuView.NativeMethodInfoPtr_InitLoadPresetPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669114);
      PlayHostMenuView.NativeMethodInfoPtr_RefreshPresetList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669115);
      PlayHostMenuView.NativeMethodInfoPtr_LoadPresetsFromPath_Private_Void_String_ServerSettingsPresetType_Nullable_Unboxed_1_GameModeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669116);
      PlayHostMenuView.NativeMethodInfoPtr_TryLoadPresetbyFileName_Private_Boolean_String_ServerSettingsPresetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669117);
      PlayHostMenuView.NativeMethodInfoPtr_OnPresetEntrySelected_Private_Void_SavedServerSettingsPresetEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669118);
      PlayHostMenuView.NativeMethodInfoPtr_OnPresetEntryDeleteClicked_Private_Void_SavedServerSettingsPresetEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669119);
      PlayHostMenuView.NativeMethodInfoPtr_InitDeletePrefabSubPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669120);
      PlayHostMenuView.NativeMethodInfoPtr_SetSelectedPresetEntry_Private_Void_SavedServerSettingsPresetEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669121);
      PlayHostMenuView.NativeMethodInfoPtr_CheckLoadButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669122);
      PlayHostMenuView.NativeMethodInfoPtr_AdvancedSettingsBackButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669123);
      PlayHostMenuView.NativeMethodInfoPtr_BackFromAdvancedSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669124);
      PlayHostMenuView.NativeMethodInfoPtr_OpenUnsavedChangesPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669125);
      PlayHostMenuView.NativeMethodInfoPtr_SettingsHasChanges_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669126);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_CancelSavePreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669127);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_SavePreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669128);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_CancelLoadPreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669129);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_LoadPreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669130);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_CancelDeletePreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669131);
      PlayHostMenuView.NativeMethodInfoPtr_CloseDeletePresetSubPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669132);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_DeletePreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669133);
      PlayHostMenuView.NativeMethodInfoPtr_TryDeletePreset_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669134);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_UnsavedChanges_No_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669135);
      PlayHostMenuView.NativeMethodInfoPtr_OnButtonClick_UnsavedChanges_Yes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669136);
      PlayHostMenuView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669137);
      PlayHostMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669138);
      PlayHostMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669139);
      PlayHostMenuView.NativeMethodInfoPtr_TryCloseActivePopup_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669140);
      PlayHostMenuView.NativeMethodInfoPtr_PopupHandleBack_LoadPreset_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669141);
      PlayHostMenuView.NativeMethodInfoPtr_IsValidFilename_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669142);
      PlayHostMenuView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669143);
      PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669144);
      PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669145);
      PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669146);
      PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669147);
      PlayHostMenuView.NativeMethodInfoPtr__Awake_b__104_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669148);
      PlayHostMenuView.NativeMethodInfoPtr__Init_HostNewServer_b__111_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669149);
      PlayHostMenuView.NativeMethodInfoPtr__Init_HostNewServer_b__111_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669150);
      PlayHostMenuView.NativeMethodInfoPtr__Init_HostNewServer_b__111_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669151);
      PlayHostMenuView.NativeMethodInfoPtr__Update_b__211_0_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, 100669152);
    }

    public PlayHostMenuView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MenuCollection MenuCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_MenuCollection));
        return pointer == System.IntPtr.Zero ? (MenuCollection) null : new MenuCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_MenuCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ViewHeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_ViewHeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_ViewHeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HostSelectNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostSelectNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostSelectNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HostSavedNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostSavedNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostSavedNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HostNewNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostNewNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostNewNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform AdvancedSettingsNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_AdvancedSettingsNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_AdvancedSettingsNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectHostInGameServerButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SelectHostInGameServerButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SelectHostInGameServerButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectHostDedicatedServerButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SelectHostDedicatedServerButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SelectHostDedicatedServerButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectRentServerButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SelectRentServerButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SelectRentServerButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostSelectBackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostSelectBackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostSelectBackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SaveListNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SaveListNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SaveListNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SaveListEntryComponent SaveEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SaveEntryPrefab));
        return pointer == System.IntPtr.Zero ? (SaveListEntryComponent) null : new SaveListEntryComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SaveEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VerticalLayoutGroup SaveListGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SaveListGroup));
        return pointer == System.IntPtr.Zero ? (VerticalLayoutGroup) null : new VerticalLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SaveListGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NoSavedServersMessage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_NoSavedServersMessage));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_NoSavedServersMessage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton BackToMainMenuButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_BackToMainMenuButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_BackToMainMenuButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton StartNewServerButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_StartNewServerButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_StartNewServerButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostSavedButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostSavedButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostSavedButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostNewBackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostNewBackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostNewBackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostNewButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostNewButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostNewButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField ServerNameInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_ServerNameInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_ServerNameInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField ServerDescriptionInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_ServerDescriptionInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_ServerDescriptionInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField MaxUsersInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_MaxUsersInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_MaxUsersInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField PasswordInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PasswordInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PasswordInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TogglePasswordButton TogglePasswordButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_TogglePasswordButton));
        return pointer == System.IntPtr.Zero ? (TogglePasswordButton) null : new TogglePasswordButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_TogglePasswordButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Selector GameModeSelector
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_GameModeSelector));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_GameModeSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton GameModeSelectButton_PvE
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_GameModeSelectButton_PvE));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_GameModeSelectButton_PvE), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton GameModeSelectButton_PvP
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_GameModeSelectButton_PvP));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_GameModeSelectButton_PvP), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostNewOpenLoadPresetPopupButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostNewOpenLoadPresetPopupButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_HostNewOpenLoadPresetPopupButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Checkbox LanServerCheckbox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LanServerCheckbox));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LanServerCheckbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Slider MaxUsersSlider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_MaxUsersSlider));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_MaxUsersSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Checkbox OnlyLocalPlayCheckbox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_OnlyLocalPlayCheckbox));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_OnlyLocalPlayCheckbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Slider ClanSizeSlider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_ClanSizeSlider));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_ClanSizeSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText MatchingGameModeText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_MatchingGameModeText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_MatchingGameModeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton BackToHostNewButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_BackToHostNewButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_BackToHostNewButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton OpenSavePresetPopupButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_OpenSavePresetPopupButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_OpenSavePresetPopupButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton OpenLoadPresetPopupButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_OpenLoadPresetPopupButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_OpenLoadPresetPopupButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SaveSettingsButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SaveSettingsButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SaveSettingsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton OpenAdvancedOptionsButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_OpenAdvancedOptionsButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_OpenAdvancedOptionsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CloseAdvancedOptionsButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CloseAdvancedOptionsButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CloseAdvancedOptionsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform AdvancedSettingsPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_AdvancedSettingsPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_AdvancedSettingsPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SavePresetPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SavePresetPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SavePresetPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform LoadPresetPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LoadPresetPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LoadPresetPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnsavedChangesPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_UnsavedChangesPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_UnsavedChangesPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField PresetNameInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetNameInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetNameInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField PresetDescriptionInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetDescriptionInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetDescriptionInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CancelSavePresetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CancelSavePresetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CancelSavePresetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SavePresetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SavePresetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SavePresetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CancelLoadPresetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CancelLoadPresetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CancelLoadPresetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton LoadPresetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LoadPresetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LoadPresetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ScrollRect LoadPresetsScrollRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LoadPresetsScrollRect));
        return pointer == System.IntPtr.Zero ? (ScrollRect) null : new ScrollRect(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LoadPresetsScrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform LoadPresetListNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LoadPresetListNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LoadPresetListNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SavedServerSettingsPresetEntry PresetEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetEntryPrefab));
        return pointer == System.IntPtr.Zero ? (SavedServerSettingsPresetEntry) null : new SavedServerSettingsPresetEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text PresetName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetName));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text PresetDescription
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetDescription));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_PresetDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text NoPresetSelectedText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_NoPresetSelectedText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_NoPresetSelectedText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform DeletePresetSubPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_DeletePresetSubPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_DeletePresetSubPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text DeletePresetName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_DeletePresetName));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_DeletePresetName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CancelDeletePresetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CancelDeletePresetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CancelDeletePresetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DeletePresetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_DeletePresetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_DeletePresetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton UnsavedChanges_NoButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_UnsavedChanges_NoButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_UnsavedChanges_NoButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton UnsavedChanges_YesButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_UnsavedChanges_YesButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_UnsavedChanges_YesButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Label Label1Prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_Label1Prefab));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Label) null : new CustomGameSettings_Label(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_Label1Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Label Label2Prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_Label2Prefab));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Label) null : new CustomGameSettings_Label(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_Label2Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Label Label3Prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_Label3Prefab));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Label) null : new CustomGameSettings_Label(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_Label3Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Checkbox CheckboxPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CheckboxPrefab));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CheckboxPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Slider SliderPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SliderPrefab));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SliderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Selector SelectorPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SelectorPrefab));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SelectorPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_FromToTime FromToTimePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_FromToTimePrefab));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_FromToTime) null : new CustomGameSettings_FromToTime(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_FromToTimePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform CustomSettingsNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CustomSettingsNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_CustomSettingsNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_TitleSoloCoop
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_TitleSoloCoop));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_TitleSoloCoop)) = value;
      }
    }

    public unsafe LocalizationKey LK_TitleHost
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_TitleHost));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_TitleHost)) = value;
      }
    }

    public unsafe LocalizationKey LK_MaxPlayers
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_MaxPlayers));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_MaxPlayers)) = value;
      }
    }

    public unsafe LocalizationKey LK_MaxPlayers_Tooltip
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_MaxPlayers_Tooltip));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_MaxPlayers_Tooltip)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSize
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_ClanSize));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_ClanSize)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSize_Tooltip
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_ClanSize_Tooltip));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_ClanSize_Tooltip)) = value;
      }
    }

    public unsafe LocalizationKey LK_Custom
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_Custom));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_Custom)) = value;
      }
    }

    public unsafe LocalizationKey LK_Show
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_Show));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_Show)) = value;
      }
    }

    public unsafe GameBalanceSettingsMapping SettingsLocalizationMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SettingsLocalizationMapping));
        return pointer == System.IntPtr.Zero ? (GameBalanceSettingsMapping) null : new GameBalanceSettingsMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_SettingsLocalizationMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_GameMode
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_GameMode));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_LK_GameMode)) = value;
      }
    }

    public unsafe ViewLocation _FromView
    {
      get
      {
        return *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__FromView));
      }
      [param: In] set
      {
        *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__FromView)) = value;
      }
    }

    public unsafe PlayHostMenuView.ViewState _CurrentViewState
    {
      get
      {
        return *(PlayHostMenuView.ViewState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CurrentViewState));
      }
      [param: In] set
      {
        *(PlayHostMenuView.ViewState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CurrentViewState)) = value;
      }
    }

    public unsafe PlayHostMenuView.HostMode _HostMode
    {
      get
      {
        return *(PlayHostMenuView.HostMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__HostMode));
      }
      [param: In] set
      {
        *(PlayHostMenuView.HostMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__HostMode)) = value;
      }
    }

    public unsafe GameModeSelectionFlow _SelectedGameMode
    {
      get
      {
        return *(GameModeSelectionFlow*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SelectedGameMode));
      }
      [param: In] set
      {
        *(GameModeSelectionFlow*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SelectedGameMode)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SaveFileData> _ServerSaves
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ServerSaves));
        return pointer == System.IntPtr.Zero ? (List<SaveFileData>) null : new List<SaveFileData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ServerSaves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<SaveListEntryComponent> _SaveEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SaveEntries));
        return pointer == System.IntPtr.Zero ? (UI_Cache<SaveListEntryComponent>) null : new UI_Cache<SaveListEntryComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SaveEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _Selected
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__Selected));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__Selected)) = value;
      }
    }

    public unsafe ServerHostSettings _ServerHostSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ServerHostSettings));
        return pointer == System.IntPtr.Zero ? (ServerHostSettings) null : new ServerHostSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ServerHostSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerGameSettings _ServerGameSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ServerGameSettings));
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ServerGameSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerGameSettings _ServerGameSettings_Edit
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ServerGameSettings_Edit));
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ServerGameSettings_Edit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<SavedServerSettingsPresetEntry> _PresetEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PresetEntriesCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<SavedServerSettingsPresetEntry>) null : new UI_Cache<SavedServerSettingsPresetEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PresetEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe string PRESET_FOLDER
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.NativeFieldInfoPtr_PRESET_FOLDER, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.NativeFieldInfoPtr_PRESET_FOLDER, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string MAX_PLAYERS_INIT_KEY
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_INIT_KEY, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_INIT_KEY, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DEFAULT_PVE_PRESET_FILENAME
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.NativeFieldInfoPtr_DEFAULT_PVE_PRESET_FILENAME, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.NativeFieldInfoPtr_DEFAULT_PVE_PRESET_FILENAME, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DEFAULT_PVP_PRESET_FILENAME
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.NativeFieldInfoPtr_DEFAULT_PVP_PRESET_FILENAME, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.NativeFieldInfoPtr_DEFAULT_PVP_PRESET_FILENAME, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int MAX_PLAYERS_MIN
    {
      get
      {
        int maxPlayersMin;
        IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_MIN, (void*) &maxPlayersMin);
        return maxPlayersMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_MIN, (void*) &value);
      }
    }

    public static unsafe int MAX_PLAYERS_MAX
    {
      get
      {
        int maxPlayersMax;
        IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_MAX, (void*) &maxPlayersMax);
        return maxPlayersMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_MAX, (void*) &value);
      }
    }

    public static unsafe int MAX_PLAYERS_DEFAULT
    {
      get
      {
        int maxPlayersDefault;
        IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_DEFAULT, (void*) &maxPlayersDefault);
        return maxPlayersDefault;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_DEFAULT, (void*) &value);
      }
    }

    public static unsafe int MAX_PLAYERS_INIT
    {
      get
      {
        int maxPlayersInit;
        IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_INIT, (void*) &maxPlayersInit);
        return maxPlayersInit;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.NativeFieldInfoPtr_MAX_PLAYERS_INIT, (void*) &value);
      }
    }

    public unsafe Il2CppStructArray<float> _DayLengths
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__DayLengths));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__DayLengths), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Regex _SaveNameRegex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SaveNameRegex));
        return pointer == System.IntPtr.Zero ? (Regex) null : new Regex(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SaveNameRegex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SavedServerSettingsPresetEntry> _PresetEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PresetEntries));
        return pointer == System.IntPtr.Zero ? (List<SavedServerSettingsPresetEntry>) null : new List<SavedServerSettingsPresetEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PresetEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SavedServerSettingsPresetEntry _SelectedPresetEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SelectedPresetEntry));
        return pointer == System.IntPtr.Zero ? (SavedServerSettingsPresetEntry) null : new SavedServerSettingsPresetEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SelectedPresetEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_FromToTime _CastlePvPWeekdayFromToTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastlePvPWeekdayFromToTime));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_FromToTime) null : new CustomGameSettings_FromToTime(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastlePvPWeekdayFromToTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_FromToTime _CastlePvPWeekendFromToTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastlePvPWeekendFromToTime));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_FromToTime) null : new CustomGameSettings_FromToTime(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastlePvPWeekendFromToTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_FromToTime _PlayerPvPWeekdayFromToTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPWeekdayFromToTime));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_FromToTime) null : new CustomGameSettings_FromToTime(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPWeekdayFromToTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_FromToTime _PlayerPvPWeekendFromToTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPWeekendFromToTime));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_FromToTime) null : new CustomGameSettings_FromToTime(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPWeekendFromToTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Selector _PlayerPvPDamageModeSelector
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPDamageModeSelector));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__PlayerPvPDamageModeSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Selector _CastleHeartDamageModeSelector
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleHeartDamageModeSelector));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleHeartDamageModeSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Slider _CastleUnderAttackTimerSlider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleUnderAttackTimerSlider));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleUnderAttackTimerSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Slider _CastleSiegeTimerSlider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleSiegeTimerSlider));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleSiegeTimerSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Selector _SiegeWeaponHealthSelector
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SiegeWeaponHealthSelector));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__SiegeWeaponHealthSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Checkbox _FreeCastleRaidCheckbox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__FreeCastleRaidCheckbox));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__FreeCastleRaidCheckbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Slider _CastleRaidTimerSlider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleRaidTimerSlider));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleRaidTimerSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Slider _CastleRaidProtectionTimeSlider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleRaidProtectionTimeSlider));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__CastleRaidProtectionTimeSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Checkbox _FreeCastleClaimCheckbox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__FreeCastleClaimCheckbox));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__FreeCastleClaimCheckbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Checkbox _FreeCastleDestroyCheckbox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__FreeCastleDestroyCheckbox));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__FreeCastleDestroyCheckbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Checkbox _AnnounceSiegeWeaponSpawnCheckbox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__AnnounceSiegeWeaponSpawnCheckbox));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__AnnounceSiegeWeaponSpawnCheckbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomGameSettings_Checkbox _ShowSiegeWeaponMapIconCheckbox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ShowSiegeWeaponMapIconCheckbox));
        return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr__ShowSiegeWeaponMapIconCheckbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MonoBehaviour> VBloodUnitFields
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_VBloodUnitFields));
        return pointer == System.IntPtr.Zero ? (List<MonoBehaviour>) null : new List<MonoBehaviour>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_VBloodUnitFields), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MonoBehaviour> JournalFields
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_JournalFields));
        return pointer == System.IntPtr.Zero ? (List<MonoBehaviour>) null : new List<MonoBehaviour>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.NativeFieldInfoPtr_JournalFields), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InitMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;
      [FieldOffset(0)]
      public PlayHostMenuView.HostMode InitMode;
      [FieldOffset(4)]
      public GameModeSelectionFlow GameMode;

      static InitData()
      {
        Il2CppClassPointerStore<PlayHostMenuView.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.InitData>.NativeClassPtr);
        PlayHostMenuView.InitData.NativeFieldInfoPtr_InitMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.InitData>.NativeClassPtr, nameof (InitMode));
        PlayHostMenuView.InitData.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.InitData>.NativeClassPtr, nameof (GameMode));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayHostMenuView.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum ViewState
    {
      None,
      HostSelect,
      HostSaved,
      HostNew,
      HostNew_Settings,
    }

    public enum HostMode
    {
      SoloCoop,
      Host,
    }

    public enum SunUpDown
    {
      SwedishWinter,
      Short,
      Medium,
      Long,
      SwedishSummer,
    }

    public enum DayLength
    {
      Short,
      Medium,
      Long,
      VeryLong,
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__110_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_5;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_13;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_15;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_20;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_30;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_89;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_92;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__120_95;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__140_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_HostSavedServer_b__110_0_Internal_Int32_SaveFileData_SaveFileData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_1_Internal_LocalizationKey_TimeZoneNameMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_3_Internal_LocalizationKey_DeathContainerNameMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_5_Internal_LocalizationKey_PvPProtectionModeMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_9_Internal_LocalizationKey_PlayerDamageModeMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_13_Internal_LocalizationKey_CastleDestroyModeMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_15_Internal_LocalizationKey_BloodFountainDestroyModeMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_20_Internal_LocalizationKey_SiegeWeaponHealthMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_30_Internal_LocalizationKey_RelicTypeMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_89_Internal_Int32_VBloodData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_92_Internal_LocalizationKey_ItemSetMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__120_95_Internal_LocalizationKey_ItemSetMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSelector_b__140_0_Internal_String_LocalizationKey_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280922, XrefRangeEnd = 1280924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Init_HostSavedServer_b__110_0(SaveFileData a, SaveFileData b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_HostSavedServer_b__110_0_Internal_Int32_SaveFileData_SaveFileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_1(
        GameBalanceSettingsMapping.TimeZoneNameMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_1_Internal_LocalizationKey_TimeZoneNameMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_3(
        GameBalanceSettingsMapping.DeathContainerNameMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_3_Internal_LocalizationKey_DeathContainerNameMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_5(
        GameBalanceSettingsMapping.PvPProtectionModeMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_5_Internal_LocalizationKey_PvPProtectionModeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_9(
        GameBalanceSettingsMapping.PlayerDamageModeMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_9_Internal_LocalizationKey_PlayerDamageModeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_13(
        GameBalanceSettingsMapping.CastleDestroyModeMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_13_Internal_LocalizationKey_CastleDestroyModeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_15(
        GameBalanceSettingsMapping.BloodFountainDestroyModeMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_15_Internal_LocalizationKey_BloodFountainDestroyModeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_20(
        GameBalanceSettingsMapping.SiegeWeaponHealthMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_20_Internal_LocalizationKey_SiegeWeaponHealthMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_30(
        GameBalanceSettingsMapping.RelicTypeMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_30_Internal_LocalizationKey_RelicTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _Init_CustomSettings_b__120_89(VBloodData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_89_Internal_Int32_VBloodData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_92(
        GameBalanceSettingsMapping.ItemSetMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_92_Internal_LocalizationKey_ItemSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe LocalizationKey _Init_CustomSettings_b__120_95(
        GameBalanceSettingsMapping.ItemSetMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_95_Internal_LocalizationKey_ItemSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280924, XrefRangeEnd = 1280925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _AddSelector_b__140_0(LocalizationKey x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c.NativeMethodInfoPtr__AddSelector_b__140_0_Internal_String_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr);
        PlayHostMenuView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__110_0");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_1");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_3");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_5");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_9");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_13");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_15");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_20");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_30");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_89 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_89");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_92 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_92");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_95 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__120_95");
        PlayHostMenuView.__c.NativeFieldInfoPtr___9__140_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, "<>9__140_0");
        PlayHostMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669154);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_HostSavedServer_b__110_0_Internal_Int32_SaveFileData_SaveFileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669155);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_1_Internal_LocalizationKey_TimeZoneNameMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669156);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_3_Internal_LocalizationKey_DeathContainerNameMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669157);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_5_Internal_LocalizationKey_PvPProtectionModeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669158);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_9_Internal_LocalizationKey_PlayerDamageModeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669159);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_13_Internal_LocalizationKey_CastleDestroyModeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669160);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_15_Internal_LocalizationKey_BloodFountainDestroyModeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669161);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_20_Internal_LocalizationKey_SiegeWeaponHealthMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669162);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_30_Internal_LocalizationKey_RelicTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669163);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_89_Internal_Int32_VBloodData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669164);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_92_Internal_LocalizationKey_ItemSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669165);
        PlayHostMenuView.__c.NativeMethodInfoPtr__Init_CustomSettings_b__120_95_Internal_LocalizationKey_ItemSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669166);
        PlayHostMenuView.__c.NativeMethodInfoPtr__AddSelector_b__140_0_Internal_String_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c>.NativeClassPtr, 100669167);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe PlayHostMenuView.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView.__c) null : new PlayHostMenuView.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<SaveFileData> __9__110_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__110_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<SaveFileData>) null : new Il2CppSystem.Comparison<SaveFileData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__110_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.TimeZoneNameMapping, LocalizationKey> __9__120_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.TimeZoneNameMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.TimeZoneNameMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.DeathContainerNameMapping, LocalizationKey> __9__120_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.DeathContainerNameMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.DeathContainerNameMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.PvPProtectionModeMapping, LocalizationKey> __9__120_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.PvPProtectionModeMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.PvPProtectionModeMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.PlayerDamageModeMapping, LocalizationKey> __9__120_9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.PlayerDamageModeMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.PlayerDamageModeMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.CastleDestroyModeMapping, LocalizationKey> __9__120_13
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_13, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.CastleDestroyModeMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.CastleDestroyModeMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_13, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping, LocalizationKey> __9__120_15
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_15, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_15, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.SiegeWeaponHealthMapping, LocalizationKey> __9__120_20
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_20, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.SiegeWeaponHealthMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.SiegeWeaponHealthMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_20, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.RelicTypeMapping, LocalizationKey> __9__120_30
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_30, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.RelicTypeMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.RelicTypeMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_30, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<VBloodData, int> __9__120_89
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_89, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<VBloodData, int>) null : new Il2CppSystem.Func<VBloodData, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_89, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.ItemSetMapping, LocalizationKey> __9__120_92
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_92, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.ItemSetMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.ItemSetMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_92, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameBalanceSettingsMapping.ItemSetMapping, LocalizationKey> __9__120_95
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_95, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameBalanceSettingsMapping.ItemSetMapping, LocalizationKey>) null : new Il2CppSystem.Func<GameBalanceSettingsMapping.ItemSetMapping, LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__120_95, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<LocalizationKey, string> __9__140_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__140_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<LocalizationKey, string>) null : new Il2CppSystem.Func<LocalizationKey, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayHostMenuView.__c.NativeFieldInfoPtr___9__140_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass120_0")]
    public sealed class __c__DisplayClass120_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sgs;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_csm;
      private static readonly System.IntPtr NativeFieldInfoPtr_sgsGTM;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayTimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_sgsVSM;
      private static readonly System.IntPtr NativeFieldInfoPtr_sgsTM;
      private static readonly System.IntPtr NativeFieldInfoPtr_sgsESMG;
      private static readonly System.IntPtr NativeFieldInfoPtr_sgsUSMG;
      private static readonly System.IntPtr NativeFieldInfoPtr_sgsUSMV;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__2_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__4_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__6_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__7_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__8_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__10_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__11_Internal_Void_StartEndTimeData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__12_Internal_Void_StartEndTimeData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__14_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__16_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__17_Internal_Void_StartEndTimeData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__18_Internal_Void_StartEndTimeData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__19_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__21_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__22_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__23_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__24_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__25_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__26_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__27_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__28_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__29_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__31_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__32_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__33_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__34_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__35_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__36_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__37_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__38_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__39_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__40_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__41_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__42_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__43_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__44_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__45_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__46_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__47_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__48_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__49_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__50_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__51_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__52_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__53_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__54_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__55_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__56_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__57_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__58_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__59_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__60_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__61_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__62_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__63_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__64_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__65_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__66_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__67_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__68_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__69_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__70_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__71_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__72_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__73_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__74_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__75_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__76_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__77_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__78_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__79_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__80_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__81_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__82_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__83_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__84_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__85_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__86_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__87_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__88_Internal_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__90_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__91_Internal_Boolean_ItemSetMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__93_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__94_Internal_Boolean_ItemSetMapping_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__96_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__97_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass120_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__0(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__2(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__2_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__4(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__4_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__6(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__6_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__7(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__7_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__8(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__8_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280925, XrefRangeEnd = 1280927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__10(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__10_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280927, XrefRangeEnd = 1280929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__11(StartEndTimeData a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__11_Internal_Void_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280929, XrefRangeEnd = 1280931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__12(StartEndTimeData a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__12_Internal_Void_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280931, XrefRangeEnd = 1280933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__14(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__14_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__16(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__16_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280933, XrefRangeEnd = 1280935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__17(StartEndTimeData a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__17_Internal_Void_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280935, XrefRangeEnd = 1280937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__18(StartEndTimeData a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__18_Internal_Void_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__19(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__19_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__21(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__21_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__22(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__22_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__23(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__23_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__24(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__24_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__25(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__25_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__26(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__26_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__27(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__27_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__28(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__28_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__29(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__29_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__31(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__31_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__32(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__32_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__33(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__33_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__34(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__34_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__35(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__35_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__36(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__36_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__37(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__37_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__38(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__38_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__39(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__39_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__40(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__40_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__41(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__41_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__42(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__42_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__43(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__43_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__44(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__44_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__45(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__45_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__46(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__46_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__47(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__47_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__48(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__48_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__49(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__49_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__50(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__50_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__51(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__51_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__52(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__52_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__53(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__53_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__54(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__54_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__55(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__55_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__56(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__56_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__57(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__57_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__58(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__58_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__59(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__59_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__60(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__60_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__61(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__61_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__62(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__62_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__63(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__63_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__64(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__64_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__65(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__65_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__66(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__66_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__67(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__67_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280937, XrefRangeEnd = 1280938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__68(int a, int b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__68_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280938, XrefRangeEnd = 1280939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__69(int oldIndex, int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &oldIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__69_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__70(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__70_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__71(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__71_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__72(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__72_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__73(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__73_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__74(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__74_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__75(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__75_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__76(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__76_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__77(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__77_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__78(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__78_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__79(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__79_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__80(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__80_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__81(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__81_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__82(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__82_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__83(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__83_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280939, XrefRangeEnd = 1280946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__84(int oldIndex, int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &oldIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__84_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__85(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__85_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__86(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__86_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__87(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__87_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Init_CustomSettings_b__88(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__88_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280946, XrefRangeEnd = 1280951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__90(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__90_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _Init_CustomSettings_b__91(GameBalanceSettingsMapping.ItemSetMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__91_Internal_Boolean_ItemSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280951, XrefRangeEnd = 1280955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__93(int oldIndex, int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &oldIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__93_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _Init_CustomSettings_b__94(GameBalanceSettingsMapping.ItemSetMapping x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__94_Internal_Boolean_ItemSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280955, XrefRangeEnd = 1280959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__96(int oldIndex, int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &oldIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__96_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280959, XrefRangeEnd = 1280964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__97(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__97_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass120_0()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass120_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (sgs));
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, "<>4__this");
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_csm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (csm));
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsGTM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (sgsGTM));
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_dayTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (dayTimes));
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsVSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (sgsVSM));
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsTM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (sgsTM));
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsESMG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (sgsESMG));
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsUSMG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (sgsUSMG));
        PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsUSMV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, nameof (sgsUSMV));
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669168);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669169);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__2_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669170);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__4_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669171);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__6_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669172);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__7_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669173);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__8_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669174);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__10_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669175);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__11_Internal_Void_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669176);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__12_Internal_Void_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669177);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__14_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669178);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__16_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669179);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__17_Internal_Void_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669180);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__18_Internal_Void_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669181);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__19_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669182);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__21_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669183);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__22_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669184);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__23_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669185);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__24_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669186);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__25_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669187);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__26_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669188);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__27_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669189);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__28_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669190);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__29_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669191);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__31_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669192);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__32_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669193);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__33_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669194);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__34_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669195);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__35_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669196);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__36_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669197);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__37_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669198);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__38_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669199);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__39_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669200);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__40_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669201);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__41_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669202);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__42_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669203);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__43_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669204);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__44_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669205);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__45_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669206);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__46_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669207);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__47_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669208);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__48_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669209);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__49_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669210);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__50_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669211);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__51_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669212);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__52_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669213);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__53_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669214);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__54_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669215);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__55_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669216);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__56_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669217);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__57_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669218);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__58_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669219);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__59_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669220);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__60_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669221);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__61_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669222);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__62_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669223);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__63_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669224);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__64_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669225);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__65_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669226);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__66_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669227);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__67_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669228);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__68_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669229);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__69_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669230);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__70_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669231);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__71_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669232);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__72_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669233);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__73_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669234);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__74_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669235);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__75_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669236);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__76_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669237);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__77_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669238);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__78_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669239);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__79_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669240);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__80_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669241);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__81_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669242);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__82_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669243);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__83_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669244);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__84_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669245);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__85_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669246);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__86_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669247);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__87_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669248);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__88_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669249);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__90_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669250);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__91_Internal_Boolean_ItemSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669251);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__93_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669252);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__94_Internal_Boolean_ItemSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669253);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__96_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669254);
        PlayHostMenuView.__c__DisplayClass120_0.NativeMethodInfoPtr__Init_CustomSettings_b__97_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_0>.NativeClassPtr, 100669255);
      }

      public __c__DisplayClass120_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ServerGameSettings sgs
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgs));
          return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayHostMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView) null : new PlayHostMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CastleStatModifiersEditor csm
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_csm));
          return pointer == System.IntPtr.Zero ? (CastleStatModifiersEditor) null : new CastleStatModifiersEditor(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_csm), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameTimeModifiers sgsGTM
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsGTM));
          return pointer == System.IntPtr.Zero ? (GameTimeModifiers) null : new GameTimeModifiers(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsGTM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<GameTimeModifiers> dayTimes
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_dayTimes));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameTimeModifiers>) null : new Il2CppReferenceArray<GameTimeModifiers>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_dayTimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VampireStatModifiers sgsVSM
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsVSM));
          return pointer == System.IntPtr.Zero ? (VampireStatModifiers) null : new VampireStatModifiers(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsVSM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TraderModifiers sgsTM
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsTM));
          return pointer == System.IntPtr.Zero ? (TraderModifiers) null : new TraderModifiers(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsTM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EquipmentStatModifiers sgsESMG
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsESMG));
          return pointer == System.IntPtr.Zero ? (EquipmentStatModifiers) null : new EquipmentStatModifiers(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsESMG), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnitStatModifiers sgsUSMG
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsUSMG));
          return pointer == System.IntPtr.Zero ? (UnitStatModifiers) null : new UnitStatModifiers(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsUSMG), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnitStatModifiers sgsUSMV
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsUSMV));
          return pointer == System.IntPtr.Zero ? (UnitStatModifiers) null : new UnitStatModifiers(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_0.NativeFieldInfoPtr_sgsUSMV), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass120_1")]
    public sealed class __c__DisplayClass120_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_bloodHunt;
      private static readonly System.IntPtr NativeFieldInfoPtr_unlockedByDefaultEntry;
      private static readonly System.IntPtr NativeFieldInfoPtr_initSetting;
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__98_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__99_Internal_Void_Single_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass120_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280964, XrefRangeEnd = 1280973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__98(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_1.NativeMethodInfoPtr__Init_CustomSettings_b__98_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280973, XrefRangeEnd = 1280984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__99(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_1.NativeMethodInfoPtr__Init_CustomSettings_b__99_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass120_1()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass120_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_bloodHunt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr, nameof (bloodHunt));
        PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_unlockedByDefaultEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr, nameof (unlockedByDefaultEntry));
        PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_initSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr, nameof (initSetting));
        PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr, nameof (entry));
        PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr, "CS$<>8__locals1");
        PlayHostMenuView.__c__DisplayClass120_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr, 100669256);
        PlayHostMenuView.__c__DisplayClass120_1.NativeMethodInfoPtr__Init_CustomSettings_b__98_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr, 100669257);
        PlayHostMenuView.__c__DisplayClass120_1.NativeMethodInfoPtr__Init_CustomSettings_b__99_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_1>.NativeClassPtr, 100669258);
      }

      public __c__DisplayClass120_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe VBloodData bloodHunt
      {
        get
        {
          return *(VBloodData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_bloodHunt));
        }
        [param: In] set
        {
          *(VBloodData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_bloodHunt)) = value;
        }
      }

      public unsafe CustomGameSettings_Checkbox unlockedByDefaultEntry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_unlockedByDefaultEntry));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_unlockedByDefaultEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VBloodUnitSetting initSetting
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_initSetting));
          return pointer == System.IntPtr.Zero ? (VBloodUnitSetting) null : new VBloodUnitSetting(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_initSetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CustomGameSettings_Slider entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayHostMenuView.__c__DisplayClass120_0 field_Public___c__DisplayClass120_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView.__c__DisplayClass120_0) null : new PlayHostMenuView.__c__DisplayClass120_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_1.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass120_2")]
    public sealed class __c__DisplayClass120_2 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_achievementHash;
      private static readonly System.IntPtr NativeFieldInfoPtr_unlockedByDefaultEntry;
      private static readonly System.IntPtr NativeFieldInfoPtr_initialSetting;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__100_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass120_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280984, XrefRangeEnd = 1280999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__100(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_2.NativeMethodInfoPtr__Init_CustomSettings_b__100_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass120_2()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass120_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_achievementHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr, nameof (achievementHash));
        PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_unlockedByDefaultEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr, nameof (unlockedByDefaultEntry));
        PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_initialSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr, nameof (initialSetting));
        PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr, "CS$<>8__locals2");
        PlayHostMenuView.__c__DisplayClass120_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr, 100669259);
        PlayHostMenuView.__c__DisplayClass120_2.NativeMethodInfoPtr__Init_CustomSettings_b__100_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_2>.NativeClassPtr, 100669260);
      }

      public __c__DisplayClass120_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int achievementHash
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_achievementHash));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_achievementHash)) = value;
        }
      }

      public unsafe CustomGameSettings_Checkbox unlockedByDefaultEntry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_unlockedByDefaultEntry));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_unlockedByDefaultEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool initialSetting
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_initialSetting));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_initialSetting)) = value;
        }
      }

      public unsafe PlayHostMenuView.__c__DisplayClass120_0 field_Public___c__DisplayClass120_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView.__c__DisplayClass120_0) null : new PlayHostMenuView.__c__DisplayClass120_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_2.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass120_3")]
    public sealed class __c__DisplayClass120_3 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_guidHash;
      private static readonly System.IntPtr NativeFieldInfoPtr_unlockedByDefaultEntry;
      private static readonly System.IntPtr NativeFieldInfoPtr_initialSetting;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Init_CustomSettings_b__101_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass120_3()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280999, XrefRangeEnd = 1281014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Init_CustomSettings_b__101(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass120_3.NativeMethodInfoPtr__Init_CustomSettings_b__101_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass120_3()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass120_3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_guidHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr, nameof (guidHash));
        PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_unlockedByDefaultEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr, nameof (unlockedByDefaultEntry));
        PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_initialSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr, nameof (initialSetting));
        PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr, "CS$<>8__locals3");
        PlayHostMenuView.__c__DisplayClass120_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr, 100669261);
        PlayHostMenuView.__c__DisplayClass120_3.NativeMethodInfoPtr__Init_CustomSettings_b__101_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass120_3>.NativeClassPtr, 100669262);
      }

      public __c__DisplayClass120_3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int guidHash
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_guidHash));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_guidHash)) = value;
        }
      }

      public unsafe CustomGameSettings_Checkbox unlockedByDefaultEntry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_unlockedByDefaultEntry));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_unlockedByDefaultEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool initialSetting
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_initialSetting));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_initialSetting)) = value;
        }
      }

      public unsafe PlayHostMenuView.__c__DisplayClass120_0 field_Public___c__DisplayClass120_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView.__c__DisplayClass120_0) null : new PlayHostMenuView.__c__DisplayClass120_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass120_3.NativeFieldInfoPtr_field_Public___c__DisplayClass120_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass136_0")]
    public sealed class __c__DisplayClass136_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_defValue;
      private static readonly System.IntPtr NativeFieldInfoPtr_initValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddCheckbox_b__0_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass136_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass136_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281014, XrefRangeEnd = 1281020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddCheckbox_b__0(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass136_0.NativeMethodInfoPtr__AddCheckbox_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass136_0()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass136_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr, nameof (onValueChange));
        PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr, "<>4__this");
        PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr, nameof (entry));
        PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_defValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr, nameof (defValue));
        PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_initValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr, nameof (initValue));
        PlayHostMenuView.__c__DisplayClass136_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr, 100669263);
        PlayHostMenuView.__c__DisplayClass136_0.NativeMethodInfoPtr__AddCheckbox_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass136_0>.NativeClassPtr, 100669264);
      }

      public __c__DisplayClass136_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Action<bool> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : new Il2CppSystem.Action<bool>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayHostMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView) null : new PlayHostMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CustomGameSettings_Checkbox entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool defValue
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_defValue));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_defValue)) = value;
        }
      }

      public unsafe bool initValue
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_initValue));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass136_0.NativeFieldInfoPtr_initValue)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass137_0")]
    public sealed class __c__DisplayClass137_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddFromToTime_b__0_Internal_Void_StartEndTimeData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass137_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass137_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281020, XrefRangeEnd = 1281025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddFromToTime_b__0(StartEndTimeData v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) v);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass137_0.NativeMethodInfoPtr__AddFromToTime_b__0_Internal_Void_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass137_0()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass137_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass137_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass137_0>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass137_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass137_0>.NativeClassPtr, nameof (onValueChange));
        PlayHostMenuView.__c__DisplayClass137_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass137_0>.NativeClassPtr, "<>4__this");
        PlayHostMenuView.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass137_0>.NativeClassPtr, 100669265);
        PlayHostMenuView.__c__DisplayClass137_0.NativeMethodInfoPtr__AddFromToTime_b__0_Internal_Void_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass137_0>.NativeClassPtr, 100669266);
      }

      public __c__DisplayClass137_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Action<StartEndTimeData> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass137_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<StartEndTimeData>) null : new Il2CppSystem.Action<StartEndTimeData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass137_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayHostMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass137_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView) null : new PlayHostMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass137_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass138_0")]
    public sealed class __c__DisplayClass138_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_defValue;
      private static readonly System.IntPtr NativeFieldInfoPtr_initValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSlider_b__0_Internal_Void_Single_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass138_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass138_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281025, XrefRangeEnd = 1281033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddSlider_b__0(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass138_0.NativeMethodInfoPtr__AddSlider_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass138_0()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass138_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr, nameof (onValueChange));
        PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr, "<>4__this");
        PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr, nameof (entry));
        PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_defValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr, nameof (defValue));
        PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_initValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr, nameof (initValue));
        PlayHostMenuView.__c__DisplayClass138_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr, 100669267);
        PlayHostMenuView.__c__DisplayClass138_0.NativeMethodInfoPtr__AddSlider_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass138_0>.NativeClassPtr, 100669268);
      }

      public __c__DisplayClass138_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Action<float> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : new Il2CppSystem.Action<float>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayHostMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView) null : new PlayHostMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CustomGameSettings_Slider entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float defValue
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_defValue));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_defValue)) = value;
        }
      }

      public unsafe float initValue
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_initValue));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass138_0.NativeFieldInfoPtr_initValue)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass139_0")]
    public sealed class __c__DisplayClass139_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_defValue;
      private static readonly System.IntPtr NativeFieldInfoPtr_initValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSlider_b__0_Internal_Void_Single_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass139_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281033, XrefRangeEnd = 1281041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddSlider_b__0(float v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass139_0.NativeMethodInfoPtr__AddSlider_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass139_0()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass139_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr, nameof (onValueChange));
        PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr, "<>4__this");
        PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr, nameof (entry));
        PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_defValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr, nameof (defValue));
        PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_initValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr, nameof (initValue));
        PlayHostMenuView.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr, 100669269);
        PlayHostMenuView.__c__DisplayClass139_0.NativeMethodInfoPtr__AddSlider_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass139_0>.NativeClassPtr, 100669270);
      }

      public __c__DisplayClass139_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Action<float> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : new Il2CppSystem.Action<float>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayHostMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView) null : new PlayHostMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CustomGameSettings_Slider entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float defValue
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_defValue));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_defValue)) = value;
        }
      }

      public unsafe float initValue
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_initValue));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass139_0.NativeFieldInfoPtr_initValue)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PlayHostMenuView/<>c__DisplayClass141_0")]
    public sealed class __c__DisplayClass141_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_defValue;
      private static readonly System.IntPtr NativeFieldInfoPtr_initValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSelector_b__0_Internal_Void_Int32_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass141_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281041, XrefRangeEnd = 1281047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddSelector_b__0(int v0, int v1)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &v0;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayHostMenuView.__c__DisplayClass141_0.NativeMethodInfoPtr__AddSelector_b__0_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass141_0()
      {
        Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayHostMenuView>.NativeClassPtr, "<>c__DisplayClass141_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr);
        PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr, nameof (onValueChange));
        PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr, "<>4__this");
        PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr, nameof (entry));
        PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_defValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr, nameof (defValue));
        PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_initValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr, nameof (initValue));
        PlayHostMenuView.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr, 100669271);
        PlayHostMenuView.__c__DisplayClass141_0.NativeMethodInfoPtr__AddSelector_b__0_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayHostMenuView.__c__DisplayClass141_0>.NativeClassPtr, 100669272);
      }

      public __c__DisplayClass141_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Action<int, int> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int, int>) null : new Il2CppSystem.Action<int, int>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlayHostMenuView __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayHostMenuView) null : new PlayHostMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CustomGameSettings_Selector entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int defValue
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_defValue));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_defValue)) = value;
        }
      }

      public unsafe int initValue
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_initValue));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayHostMenuView.__c__DisplayClass141_0.NativeFieldInfoPtr_initValue)) = value;
        }
      }
    }
  }
}
