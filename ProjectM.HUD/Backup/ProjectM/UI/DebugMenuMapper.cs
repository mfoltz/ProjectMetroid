// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Entities;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class DebugMenuMapper : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentTab;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__ButtonCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__MenuItemCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__AmbienceVca;
    private static readonly System.IntPtr NativeFieldInfoPtr__MusicVca;
    private static readonly System.IntPtr NativeFieldInfoPtr__SoundEffectsVca;
    private static readonly System.IntPtr NativeFieldInfoPtr__VoiceOverVca;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawCurrentTab_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartTab_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndTab_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitMenuItems_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTabButtons_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeTabButton_Private_Void_String_UnityAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentTab_Private_Void_DebugTab_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_General_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_Graphics_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_GraphicsII_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_Audio_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_AI_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_HUD_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_Progression_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_BugReporting_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_Build_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitTab_Other_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSpacing_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader_Private_Void_String_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputField_Private_Void_String_UnityAction_1_String_Func_1_String_ContentType_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddButton_Private_Void_String_UnityAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddButton_Private_Void_String_String_UnityAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Private_Void_String_Single_Single_Single_UnityAction_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCheckBox_Private_Void_String_String_UnityAction_1_Boolean_Func_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCheckBox_Private_Void_String_UnityAction_1_Boolean_Func_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugMenu_Private_DebugMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalUser_Private_Boolean_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTabElement_Private_Boolean_byref_DebugMenuItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TeamId_OnInputSubmitted_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowCollision_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowPlacement_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowLineOfSight_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowCollisionState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowPlacementState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TakeControl_OnButtonClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowPhysicsColliders_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPhysicsCollidersState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RoofGenerationEnabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LinnCastleRoofsEnabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowFluffData_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowFluffDataState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnableBuildGridData_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowTerrainHeightDataState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowTerrainBaseHeightData_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowTerrainBaseHeightDataState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowGameplayBaseHeightData_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowGameplayBaseHeightDataState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowBaseHeightLevelData_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowBaseHeightLevelDataState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowControllableAreas_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowControllableAreasState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLineOfSightState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLineOfSight_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnableFluffState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnableFluff_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnloadClientChunks_OnButtonClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFadeOutEnabledState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FadeOutEnabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HitEffectsEnabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetForceRainEnabledState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForceRainEnabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAimPreviewsEnabledState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AimPreviewsEnabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialChangesEnabledState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MaterialChangesEnabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllProgressionUnlocked_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllVBloodAbilitiesUnlockedOnLaunch_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RevealMap_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowTerrainHeightData_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invulnerable_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugView_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildCosts_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableTutorial_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableCooldowns_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SunDamageDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableLightningStrikes_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DurabilityDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrainBloodDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GlobalCastleTerritoryEnabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildingPlacementRestrictionsDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleHeartConnectionRequirementDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleHeartBloodEssenceDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleBuildingLimitsDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildingEnableDebugging_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DropsDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAllWaypoints_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugViewEnabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowBuildGridDataState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildCostsDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTutorialPopupDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllProgressionUnlocked_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllVBloodAbilitiesUnlockedOnLaunch_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRevealedMap_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDisableCooldowns_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayersInvulnerabilityEnabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSunDamageDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDisableLightningStrikes_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDurabilityDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDrainBloodDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GlobalCastleTerritoryEnabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlacementRestrictionsDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastleHeartConnectionRequirementDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastleHeartBloodEssenceDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastleBuildingLimitsDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildingEnableDebugging_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDropsDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllWaypointsUnlocked_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHitEffectsEnabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRoofGenerationEnabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLinnCastleRoofsEnabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDayButton_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNightButton_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDayNightCycleDisabled_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DayNightCycleDisabled_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUseDeathSequencesInsteadOfRagdolls_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDisableDynamicClouds_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UseDeathSequencesInsteadOfRagdolls_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableDynamicClouds_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDisableNpcsState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableNpcs_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDisableAiCastsState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableAiCasts_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDisableVbloodGhostsState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableVbloodGhosts_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDisableAggroState_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableAggro_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowAiPaths_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowAiPaths_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowWorldPaths_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowWorldPaths_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowAiDistances_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowAiDistances_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowAiStateInfo_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowAiStateInfo_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowAggro_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowAggro_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShowAlert_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowAlert_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetServerShowAi_Private_Boolean_byref_ShowAi_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockVBloodPassives_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockVBloodAbilities_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockVBloodShapeshifts_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearTutorialProgression_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPositionDump_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyDebugDump_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDebugDump_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePerformanceDump_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenCrashDumpFolder_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenLogsFolder_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenEditorLogsFolder_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DummySpawnThing_OnButtonClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DummyDoOther_OnButtonClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DummySliderTest_OnValueChanged_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugGrid_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_HUD_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_CharacterHUDs_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_Minimap_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_EdgeIcons_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_Achievements_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_Clan_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_Replay_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_SCT_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_Logs_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_HudMenus_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_MenuLinks_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_SpecialWakeupText_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHudState_VersionData_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_HUD_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_CharacterHUDs_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_Minimap_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_EdgeIcons_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_Achievements_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_Clan_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_Replay_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_SCT_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_Logs_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_MenuLinks_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_SpecialWakeupMenu_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_VersionData_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableHudElement_HudMenus_OnValueChanged_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_2_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_3_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_4_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_5_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_6_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_7_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_8_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitTabButtons_b__21_9_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256878, XrefRangeEnd = 1256880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256880, XrefRangeEnd = 1256899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256899, XrefRangeEnd = 1256942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256942, XrefRangeEnd = 1256946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1256967, RefRangeEnd = 1256970, XrefRangeStart = 1256946, XrefRangeEnd = 1256967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawCurrentTab()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DrawCurrentTab_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256970, XrefRangeEnd = 1256974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartTab()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_StartTab_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256974, XrefRangeEnd = 1256978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndTab()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_EndTab_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256978, XrefRangeEnd = 1256980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitMenuItems()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitMenuItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1257068, RefRangeEnd = 1257070, XrefRangeStart = 1256980, XrefRangeEnd = 1257068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTabButtons()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTabButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1257074, RefRangeEnd = 1257084, XrefRangeStart = 1257070, XrefRangeEnd = 1257074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeTabButton(string buttonText, UnityAction onButtonClick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(buttonText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onButtonClick);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitializeTabButton_Private_Void_String_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1257104, RefRangeEnd = 1257115, XrefRangeStart = 1257084, XrefRangeEnd = 1257104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetCurrentTab(DebugTab tabValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tabValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_SetCurrentTab_Private_Void_DebugTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1257344, RefRangeEnd = 1257345, XrefRangeStart = 1257115, XrefRangeEnd = 1257344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_General()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_General_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1257478, RefRangeEnd = 1257479, XrefRangeStart = 1257345, XrefRangeEnd = 1257478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_Graphics()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_Graphics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257479, XrefRangeEnd = 1257486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_GraphicsII()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_GraphicsII_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257486, XrefRangeEnd = 1257496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_Audio()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_Audio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1257663, RefRangeEnd = 1257664, XrefRangeStart = 1257496, XrefRangeEnd = 1257663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_AI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_AI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1257906, RefRangeEnd = 1257907, XrefRangeStart = 1257664, XrefRangeEnd = 1257906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_HUD()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_HUD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1258005, RefRangeEnd = 1258006, XrefRangeStart = 1257907, XrefRangeEnd = 1258005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_Progression()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_Progression_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1258068, RefRangeEnd = 1258069, XrefRangeStart = 1258006, XrefRangeEnd = 1258068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_BugReporting()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_BugReporting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1258212, RefRangeEnd = 1258213, XrefRangeStart = 1258069, XrefRangeEnd = 1258212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_Build()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_Build_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1258395, RefRangeEnd = 1258396, XrefRangeStart = 1258213, XrefRangeEnd = 1258395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitTab_Other()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_InitTab_Other_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1258409, RefRangeEnd = 1258412, XrefRangeStart = 1258396, XrefRangeEnd = 1258409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSpacing(float height)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &height;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AddSpacing_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 1258427, RefRangeEnd = 1258447, XrefRangeStart = 1258412, XrefRangeEnd = 1258427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHeader(string text, float fontSize, float marginBottom = 15f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &marginBottom;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AddHeader_Private_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258447, XrefRangeEnd = 1258451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddInputField(
      string headerText,
      UnityAction<string> onInputSubmitted,
      Il2CppSystem.Func<string> getInitialValueFunc = null,
      TMP_InputField.ContentType contentType = TMP_InputField.ContentType.Standard,
      string placeholderText = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(headerText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onInputSubmitted);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getInitialValueFunc);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &contentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(placeholderText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AddInputField_Private_Void_String_UnityAction_1_String_Func_1_String_ContentType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 1258467, RefRangeEnd = 1258483, XrefRangeStart = 1258451, XrefRangeEnd = 1258467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddButton(string buttonText, UnityAction onButtonClick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(buttonText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onButtonClick);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AddButton_Private_Void_String_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258483, XrefRangeEnd = 1258500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddButton(string headerText, string buttonText, UnityAction onButtonClick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(headerText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(buttonText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onButtonClick);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AddButton_Private_Void_String_String_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258500, XrefRangeEnd = 1258504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSlider(
      string headerText,
      float minValue,
      float maxValue,
      float initialValue,
      UnityAction<float> onValueChanged)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(headerText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &initialValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AddSlider_Private_Void_String_Single_Single_Single_UnityAction_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258504, XrefRangeEnd = 1258508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddCheckBox(
      string headerText,
      string checkBoxText,
      UnityAction<bool> onValueChanged,
      Il2CppSystem.Func<bool> getInitialValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(headerText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(checkBoxText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getInitialValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AddCheckBox_Private_Void_String_String_UnityAction_1_Boolean_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(65)]
    [CachedScanResults(RefRangeStart = 1258512, RefRangeEnd = 1258577, XrefRangeStart = 1258508, XrefRangeEnd = 1258512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddCheckBox(
      string checkBoxText,
      UnityAction<bool> onValueChanged,
      Il2CppSystem.Func<bool> getInitialValueFunc = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(checkBoxText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getInitialValueFunc);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AddCheckBox_Private_Void_String_UnityAction_1_Boolean_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258577, XrefRangeEnd = 1258591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugMenu GetDebugMenu()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDebugMenu_Private_DebugMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (DebugMenu) null : new DebugMenu(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258591, XrefRangeEnd = 1258593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetLocalUser(out Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_TryGetLocalUser_Private_Boolean_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258593, XrefRangeEnd = 1258597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetTabElement(out DebugMenuItem element)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetTabElement_Private_Boolean_byref_DebugMenuItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref DebugMenuItem local = ref element;
      System.IntPtr pointer = zero;
      DebugMenuItem debugMenuItem = pointer == System.IntPtr.Zero ? (DebugMenuItem) null : new DebugMenuItem(pointer);
      local = debugMenuItem;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258597, XrefRangeEnd = 1258611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeamId_OnInputSubmitted(string input)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_TeamId_OnInputSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258611, XrefRangeEnd = 1258626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowCollision_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowCollision_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258626, XrefRangeEnd = 1258641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowPlacement_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowPlacement_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258641, XrefRangeEnd = 1258665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowLineOfSight_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowLineOfSight_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258665, XrefRangeEnd = 1258678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowCollisionState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowCollisionState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258678, XrefRangeEnd = 1258680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowPlacementState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowPlacementState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258680, XrefRangeEnd = 1258692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TakeControl_OnButtonClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_TakeControl_OnButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258692, XrefRangeEnd = 1258713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowPhysicsColliders_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowPhysicsColliders_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258713, XrefRangeEnd = 1258726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetPhysicsCollidersState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetPhysicsCollidersState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258726, XrefRangeEnd = 1258739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RoofGenerationEnabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_RoofGenerationEnabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258739, XrefRangeEnd = 1258752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LinnCastleRoofsEnabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_LinnCastleRoofsEnabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258752, XrefRangeEnd = 1258765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowFluffData_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowFluffData_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258765, XrefRangeEnd = 1258767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowFluffDataState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowFluffDataState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258767, XrefRangeEnd = 1258780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EnableBuildGridData_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_EnableBuildGridData_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258780, XrefRangeEnd = 1258786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowTerrainHeightDataState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowTerrainHeightDataState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258786, XrefRangeEnd = 1258799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowTerrainBaseHeightData_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowTerrainBaseHeightData_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258799, XrefRangeEnd = 1258805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowTerrainBaseHeightDataState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowTerrainBaseHeightDataState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258805, XrefRangeEnd = 1258818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowGameplayBaseHeightData_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowGameplayBaseHeightData_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258818, XrefRangeEnd = 1258824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowGameplayBaseHeightDataState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowGameplayBaseHeightDataState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258824, XrefRangeEnd = 1258837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowBaseHeightLevelData_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowBaseHeightLevelData_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258837, XrefRangeEnd = 1258843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowBaseHeightLevelDataState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowBaseHeightLevelDataState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258843, XrefRangeEnd = 1258856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowControllableAreas_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowControllableAreas_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258856, XrefRangeEnd = 1258858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowControllableAreasState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowControllableAreasState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258858, XrefRangeEnd = 1258859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetLineOfSightState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetLineOfSightState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258859, XrefRangeEnd = 1258872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetLineOfSight_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_SetLineOfSight_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258872, XrefRangeEnd = 1258878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetEnableFluffState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetEnableFluffState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258878, XrefRangeEnd = 1258899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EnableFluff_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_EnableFluff_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258899, XrefRangeEnd = 1258911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnloadClientChunks_OnButtonClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_UnloadClientChunks_OnButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258911, XrefRangeEnd = 1258914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetFadeOutEnabledState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetFadeOutEnabledState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258914, XrefRangeEnd = 1258935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FadeOutEnabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_FadeOutEnabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258935, XrefRangeEnd = 1258948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HitEffectsEnabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_HitEffectsEnabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258948, XrefRangeEnd = 1258951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetForceRainEnabledState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetForceRainEnabledState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258951, XrefRangeEnd = 1258964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ForceRainEnabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ForceRainEnabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258964, XrefRangeEnd = 1258968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetAimPreviewsEnabledState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetAimPreviewsEnabledState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258968, XrefRangeEnd = 1258981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AimPreviewsEnabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AimPreviewsEnabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258981, XrefRangeEnd = 1258985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetMaterialChangesEnabledState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetMaterialChangesEnabledState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258985, XrefRangeEnd = 1258998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MaterialChangesEnabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_MaterialChangesEnabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258998, XrefRangeEnd = 1259011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AllProgressionUnlocked_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AllProgressionUnlocked_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259011, XrefRangeEnd = 1259024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AllVBloodAbilitiesUnlockedOnLaunch(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_AllVBloodAbilitiesUnlockedOnLaunch_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259024, XrefRangeEnd = 1259039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RevealMap_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_RevealMap_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259039, XrefRangeEnd = 1259052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowTerrainHeightData_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowTerrainHeightData_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259052, XrefRangeEnd = 1259065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Invulnerable_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_Invulnerable_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259065, XrefRangeEnd = 1259078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DebugView_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DebugView_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259078, XrefRangeEnd = 1259091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildCosts_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_BuildCosts_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259091, XrefRangeEnd = 1259104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableTutorial_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableTutorial_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259104, XrefRangeEnd = 1259117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableCooldowns_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableCooldowns_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259117, XrefRangeEnd = 1259130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SunDamageDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_SunDamageDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259130, XrefRangeEnd = 1259143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableLightningStrikes_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableLightningStrikes_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259143, XrefRangeEnd = 1259156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DurabilityDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DurabilityDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259156, XrefRangeEnd = 1259169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrainBloodDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DrainBloodDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259169, XrefRangeEnd = 1259182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GlobalCastleTerritoryEnabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GlobalCastleTerritoryEnabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259182, XrefRangeEnd = 1259195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildingPlacementRestrictionsDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_BuildingPlacementRestrictionsDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259195, XrefRangeEnd = 1259208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleHeartConnectionRequirementDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_CastleHeartConnectionRequirementDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259208, XrefRangeEnd = 1259221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleHeartBloodEssenceDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_CastleHeartBloodEssenceDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259221, XrefRangeEnd = 1259234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleBuildingLimitsDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_CastleBuildingLimitsDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259234, XrefRangeEnd = 1259250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildingEnableDebugging_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_BuildingEnableDebugging_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259250, XrefRangeEnd = 1259263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DropsDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DropsDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259263, XrefRangeEnd = 1259276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockAllWaypoints_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_UnlockAllWaypoints_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259276, XrefRangeEnd = 1259280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDebugViewEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDebugViewEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259280, XrefRangeEnd = 1259284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowBuildGridDataState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowBuildGridDataState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259284, XrefRangeEnd = 1259285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetBuildCostsDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetBuildCostsDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259285, XrefRangeEnd = 1259286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetTutorialPopupDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetTutorialPopupDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259286, XrefRangeEnd = 1259287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetAllProgressionUnlocked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetAllProgressionUnlocked_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259287, XrefRangeEnd = 1259288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetAllVBloodAbilitiesUnlockedOnLaunch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetAllVBloodAbilitiesUnlockedOnLaunch_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259288, XrefRangeEnd = 1259289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetRevealedMap()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetRevealedMap_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259289, XrefRangeEnd = 1259290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDisableCooldowns()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDisableCooldowns_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259290, XrefRangeEnd = 1259291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetPlayersInvulnerabilityEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetPlayersInvulnerabilityEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259291, XrefRangeEnd = 1259292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetSunDamageDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetSunDamageDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259292, XrefRangeEnd = 1259293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDisableLightningStrikes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDisableLightningStrikes_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259293, XrefRangeEnd = 1259294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDurabilityDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDurabilityDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259294, XrefRangeEnd = 1259295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDrainBloodDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDrainBloodDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259295, XrefRangeEnd = 1259296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GlobalCastleTerritoryEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GlobalCastleTerritoryEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259296, XrefRangeEnd = 1259297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetPlacementRestrictionsDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetPlacementRestrictionsDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259297, XrefRangeEnd = 1259298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetCastleHeartConnectionRequirementDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetCastleHeartConnectionRequirementDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259298, XrefRangeEnd = 1259299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetCastleHeartBloodEssenceDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetCastleHeartBloodEssenceDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259299, XrefRangeEnd = 1259300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetCastleBuildingLimitsDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetCastleBuildingLimitsDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259300, XrefRangeEnd = 1259301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetBuildingEnableDebugging()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetBuildingEnableDebugging_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259301, XrefRangeEnd = 1259302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDropsDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDropsDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259302, XrefRangeEnd = 1259303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetAllWaypointsUnlocked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetAllWaypointsUnlocked_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259303, XrefRangeEnd = 1259304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHitEffectsEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHitEffectsEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259304, XrefRangeEnd = 1259305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetRoofGenerationEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetRoofGenerationEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259305, XrefRangeEnd = 1259306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetLinnCastleRoofsEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetLinnCastleRoofsEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259306, XrefRangeEnd = 1259323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDayButton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_SetDayButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259323, XrefRangeEnd = 1259340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetNightButton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_SetNightButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259340, XrefRangeEnd = 1259341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDayNightCycleDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDayNightCycleDisabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259341, XrefRangeEnd = 1259358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DayNightCycleDisabled_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DayNightCycleDisabled_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259358, XrefRangeEnd = 1259359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetUseDeathSequencesInsteadOfRagdolls()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetUseDeathSequencesInsteadOfRagdolls_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259359, XrefRangeEnd = 1259360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDisableDynamicClouds()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDisableDynamicClouds_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259360, XrefRangeEnd = 1259377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UseDeathSequencesInsteadOfRagdolls_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_UseDeathSequencesInsteadOfRagdolls_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259377, XrefRangeEnd = 1259394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableDynamicClouds_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableDynamicClouds_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259394, XrefRangeEnd = 1259395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDisableNpcsState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDisableNpcsState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259395, XrefRangeEnd = 1259412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableNpcs_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableNpcs_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259412, XrefRangeEnd = 1259413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDisableAiCastsState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDisableAiCastsState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259413, XrefRangeEnd = 1259430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableAiCasts_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableAiCasts_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259430, XrefRangeEnd = 1259431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDisableVbloodGhostsState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDisableVbloodGhostsState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259431, XrefRangeEnd = 1259448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableVbloodGhosts_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableVbloodGhosts_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259448, XrefRangeEnd = 1259449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDisableAggroState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetDisableAggroState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259449, XrefRangeEnd = 1259466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableAggro_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableAggro_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259466, XrefRangeEnd = 1259467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowAiPaths()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowAiPaths_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259467, XrefRangeEnd = 1259482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowAiPaths_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowAiPaths_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259482, XrefRangeEnd = 1259496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowWorldPaths()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowWorldPaths_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259496, XrefRangeEnd = 1259509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowWorldPaths_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowWorldPaths_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259509, XrefRangeEnd = 1259510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowAiDistances()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowAiDistances_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259510, XrefRangeEnd = 1259523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowAiDistances_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowAiDistances_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259523, XrefRangeEnd = 1259524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowAiStateInfo()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowAiStateInfo_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259524, XrefRangeEnd = 1259537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowAiStateInfo_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowAiStateInfo_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259537, XrefRangeEnd = 1259538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowAggro()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowAggro_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259538, XrefRangeEnd = 1259559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowAggro_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowAggro_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259559, XrefRangeEnd = 1259560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetShowAlert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetShowAlert_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259560, XrefRangeEnd = 1259581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowAlert_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ShowAlert_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1259593, RefRangeEnd = 1259598, XrefRangeStart = 1259581, XrefRangeEnd = 1259593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetServerShowAi(out ShowAi showAi)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref showAi;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_TryGetServerShowAi_Private_Boolean_byref_ShowAi_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259598, XrefRangeEnd = 1259610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockVBloodPassives_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_UnlockVBloodPassives_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259610, XrefRangeEnd = 1259622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockVBloodAbilities_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_UnlockVBloodAbilities_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259622, XrefRangeEnd = 1259634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockVBloodShapeshifts_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_UnlockVBloodShapeshifts_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259634, XrefRangeEnd = 1259646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearTutorialProgression_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_ClearTutorialProgression_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259646, XrefRangeEnd = 1259658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyPositionDump_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_CopyPositionDump_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259658, XrefRangeEnd = 1259670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyDebugDump_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_CopyDebugDump_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259670, XrefRangeEnd = 1259682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDebugDump_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_CreateDebugDump_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259682, XrefRangeEnd = 1259694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreatePerformanceDump_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_CreatePerformanceDump_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259694, XrefRangeEnd = 1259706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenCrashDumpFolder_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_OpenCrashDumpFolder_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259706, XrefRangeEnd = 1259718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenLogsFolder_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_OpenLogsFolder_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259718, XrefRangeEnd = 1259730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenEditorLogsFolder_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_OpenEditorLogsFolder_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259730, XrefRangeEnd = 1259736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DummySpawnThing_OnButtonClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DummySpawnThing_OnButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259736, XrefRangeEnd = 1259742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DummyDoOther_OnButtonClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DummyDoOther_OnButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259742, XrefRangeEnd = 1259750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DummySliderTest_OnValueChanged(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DummySliderTest_OnValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259750, XrefRangeEnd = 1259758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DebugGrid_OnValueChanged(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DebugGrid_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259758, XrefRangeEnd = 1259759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_HUD()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_HUD_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259759, XrefRangeEnd = 1259760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_CharacterHUDs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_CharacterHUDs_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259760, XrefRangeEnd = 1259761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_Minimap()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Minimap_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259761, XrefRangeEnd = 1259762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_EdgeIcons()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_EdgeIcons_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259762, XrefRangeEnd = 1259763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_Achievements()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Achievements_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259763, XrefRangeEnd = 1259764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_Clan()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Clan_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259764, XrefRangeEnd = 1259765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_Replay()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Replay_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259765, XrefRangeEnd = 1259766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_SCT()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_SCT_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259766, XrefRangeEnd = 1259767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_Logs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Logs_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259767, XrefRangeEnd = 1259768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_HudMenus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_HudMenus_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259768, XrefRangeEnd = 1259769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_MenuLinks()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_MenuLinks_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259769, XrefRangeEnd = 1259770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_SpecialWakeupText()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_SpecialWakeupText_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259770, XrefRangeEnd = 1259771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetHudState_VersionData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_GetHudState_VersionData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259771, XrefRangeEnd = 1259773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_HUD_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_HUD_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259773, XrefRangeEnd = 1259775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_CharacterHUDs_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_CharacterHUDs_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259775, XrefRangeEnd = 1259777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_Minimap_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Minimap_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259777, XrefRangeEnd = 1259779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_EdgeIcons_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_EdgeIcons_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259779, XrefRangeEnd = 1259781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_Achievements_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Achievements_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259781, XrefRangeEnd = 1259783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_Clan_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Clan_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259783, XrefRangeEnd = 1259785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_Replay_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Replay_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259785, XrefRangeEnd = 1259787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_SCT_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_SCT_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259787, XrefRangeEnd = 1259789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_Logs_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Logs_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259789, XrefRangeEnd = 1259791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_MenuLinks_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_MenuLinks_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259791, XrefRangeEnd = 1259793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_SpecialWakeupMenu_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_SpecialWakeupMenu_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259793, XrefRangeEnd = 1259795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_VersionData_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_VersionData_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259795, XrefRangeEnd = 1259797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableHudElement_HudMenus_OnValueChanged(bool show)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &show;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_HudMenus_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259797, XrefRangeEnd = 1259798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259798, XrefRangeEnd = 1259799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259799, XrefRangeEnd = 1259800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259800, XrefRangeEnd = 1259801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259801, XrefRangeEnd = 1259802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259802, XrefRangeEnd = 1259803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259803, XrefRangeEnd = 1259804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259804, XrefRangeEnd = 1259805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259805, XrefRangeEnd = 1259806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259806, XrefRangeEnd = 1259807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitTabButtons_b__21_9()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugMenuMapper()
    {
      Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DebugMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr);
      DebugMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_Query));
      DebugMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      DebugMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      DebugMenuMapper.NativeFieldInfoPtr__CurrentTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_CurrentTab));
      DebugMenuMapper.NativeFieldInfoPtr__DebugMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_DebugMenu));
      DebugMenuMapper.NativeFieldInfoPtr__ButtonCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_ButtonCache));
      DebugMenuMapper.NativeFieldInfoPtr__MenuItemCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_MenuItemCache));
      DebugMenuMapper.NativeFieldInfoPtr__AmbienceVca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_AmbienceVca));
      DebugMenuMapper.NativeFieldInfoPtr__MusicVca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_MusicVca));
      DebugMenuMapper.NativeFieldInfoPtr__SoundEffectsVca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_SoundEffectsVca));
      DebugMenuMapper.NativeFieldInfoPtr__VoiceOverVca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, nameof (_VoiceOverVca));
      DebugMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666968);
      DebugMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666969);
      DebugMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666970);
      DebugMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666971);
      DebugMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666972);
      DebugMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666973);
      DebugMenuMapper.NativeMethodInfoPtr_DrawCurrentTab_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666974);
      DebugMenuMapper.NativeMethodInfoPtr_StartTab_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666975);
      DebugMenuMapper.NativeMethodInfoPtr_EndTab_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666976);
      DebugMenuMapper.NativeMethodInfoPtr_InitMenuItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666977);
      DebugMenuMapper.NativeMethodInfoPtr_InitTabButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666978);
      DebugMenuMapper.NativeMethodInfoPtr_InitializeTabButton_Private_Void_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666979);
      DebugMenuMapper.NativeMethodInfoPtr_SetCurrentTab_Private_Void_DebugTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666980);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_General_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666981);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_Graphics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666982);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_GraphicsII_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666983);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_Audio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666984);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_AI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666985);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_HUD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666986);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_Progression_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666987);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_BugReporting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666988);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_Build_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666989);
      DebugMenuMapper.NativeMethodInfoPtr_InitTab_Other_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666990);
      DebugMenuMapper.NativeMethodInfoPtr_AddSpacing_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666991);
      DebugMenuMapper.NativeMethodInfoPtr_AddHeader_Private_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666992);
      DebugMenuMapper.NativeMethodInfoPtr_AddInputField_Private_Void_String_UnityAction_1_String_Func_1_String_ContentType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666993);
      DebugMenuMapper.NativeMethodInfoPtr_AddButton_Private_Void_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666994);
      DebugMenuMapper.NativeMethodInfoPtr_AddButton_Private_Void_String_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666995);
      DebugMenuMapper.NativeMethodInfoPtr_AddSlider_Private_Void_String_Single_Single_Single_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666996);
      DebugMenuMapper.NativeMethodInfoPtr_AddCheckBox_Private_Void_String_String_UnityAction_1_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666997);
      DebugMenuMapper.NativeMethodInfoPtr_AddCheckBox_Private_Void_String_UnityAction_1_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666998);
      DebugMenuMapper.NativeMethodInfoPtr_GetDebugMenu_Private_DebugMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100666999);
      DebugMenuMapper.NativeMethodInfoPtr_TryGetLocalUser_Private_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667000);
      DebugMenuMapper.NativeMethodInfoPtr_GetTabElement_Private_Boolean_byref_DebugMenuItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667001);
      DebugMenuMapper.NativeMethodInfoPtr_TeamId_OnInputSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667002);
      DebugMenuMapper.NativeMethodInfoPtr_ShowCollision_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667003);
      DebugMenuMapper.NativeMethodInfoPtr_ShowPlacement_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667004);
      DebugMenuMapper.NativeMethodInfoPtr_ShowLineOfSight_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667005);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowCollisionState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667006);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowPlacementState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667007);
      DebugMenuMapper.NativeMethodInfoPtr_TakeControl_OnButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667008);
      DebugMenuMapper.NativeMethodInfoPtr_ShowPhysicsColliders_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667009);
      DebugMenuMapper.NativeMethodInfoPtr_GetPhysicsCollidersState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667010);
      DebugMenuMapper.NativeMethodInfoPtr_RoofGenerationEnabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667011);
      DebugMenuMapper.NativeMethodInfoPtr_LinnCastleRoofsEnabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667012);
      DebugMenuMapper.NativeMethodInfoPtr_ShowFluffData_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667013);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowFluffDataState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667014);
      DebugMenuMapper.NativeMethodInfoPtr_EnableBuildGridData_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667015);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowTerrainHeightDataState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667016);
      DebugMenuMapper.NativeMethodInfoPtr_ShowTerrainBaseHeightData_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667017);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowTerrainBaseHeightDataState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667018);
      DebugMenuMapper.NativeMethodInfoPtr_ShowGameplayBaseHeightData_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667019);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowGameplayBaseHeightDataState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667020);
      DebugMenuMapper.NativeMethodInfoPtr_ShowBaseHeightLevelData_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667021);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowBaseHeightLevelDataState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667022);
      DebugMenuMapper.NativeMethodInfoPtr_ShowControllableAreas_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667023);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowControllableAreasState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667024);
      DebugMenuMapper.NativeMethodInfoPtr_GetLineOfSightState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667025);
      DebugMenuMapper.NativeMethodInfoPtr_SetLineOfSight_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667026);
      DebugMenuMapper.NativeMethodInfoPtr_GetEnableFluffState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667027);
      DebugMenuMapper.NativeMethodInfoPtr_EnableFluff_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667028);
      DebugMenuMapper.NativeMethodInfoPtr_UnloadClientChunks_OnButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667029);
      DebugMenuMapper.NativeMethodInfoPtr_GetFadeOutEnabledState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667030);
      DebugMenuMapper.NativeMethodInfoPtr_FadeOutEnabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667031);
      DebugMenuMapper.NativeMethodInfoPtr_HitEffectsEnabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667032);
      DebugMenuMapper.NativeMethodInfoPtr_GetForceRainEnabledState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667033);
      DebugMenuMapper.NativeMethodInfoPtr_ForceRainEnabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667034);
      DebugMenuMapper.NativeMethodInfoPtr_GetAimPreviewsEnabledState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667035);
      DebugMenuMapper.NativeMethodInfoPtr_AimPreviewsEnabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667036);
      DebugMenuMapper.NativeMethodInfoPtr_GetMaterialChangesEnabledState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667037);
      DebugMenuMapper.NativeMethodInfoPtr_MaterialChangesEnabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667038);
      DebugMenuMapper.NativeMethodInfoPtr_AllProgressionUnlocked_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667039);
      DebugMenuMapper.NativeMethodInfoPtr_AllVBloodAbilitiesUnlockedOnLaunch_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667040);
      DebugMenuMapper.NativeMethodInfoPtr_RevealMap_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667041);
      DebugMenuMapper.NativeMethodInfoPtr_ShowTerrainHeightData_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667042);
      DebugMenuMapper.NativeMethodInfoPtr_Invulnerable_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667043);
      DebugMenuMapper.NativeMethodInfoPtr_DebugView_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667044);
      DebugMenuMapper.NativeMethodInfoPtr_BuildCosts_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667045);
      DebugMenuMapper.NativeMethodInfoPtr_DisableTutorial_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667046);
      DebugMenuMapper.NativeMethodInfoPtr_DisableCooldowns_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667047);
      DebugMenuMapper.NativeMethodInfoPtr_SunDamageDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667048);
      DebugMenuMapper.NativeMethodInfoPtr_DisableLightningStrikes_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667049);
      DebugMenuMapper.NativeMethodInfoPtr_DurabilityDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667050);
      DebugMenuMapper.NativeMethodInfoPtr_DrainBloodDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667051);
      DebugMenuMapper.NativeMethodInfoPtr_GlobalCastleTerritoryEnabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667052);
      DebugMenuMapper.NativeMethodInfoPtr_BuildingPlacementRestrictionsDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667053);
      DebugMenuMapper.NativeMethodInfoPtr_CastleHeartConnectionRequirementDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667054);
      DebugMenuMapper.NativeMethodInfoPtr_CastleHeartBloodEssenceDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667055);
      DebugMenuMapper.NativeMethodInfoPtr_CastleBuildingLimitsDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667056);
      DebugMenuMapper.NativeMethodInfoPtr_BuildingEnableDebugging_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667057);
      DebugMenuMapper.NativeMethodInfoPtr_DropsDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667058);
      DebugMenuMapper.NativeMethodInfoPtr_UnlockAllWaypoints_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667059);
      DebugMenuMapper.NativeMethodInfoPtr_GetDebugViewEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667060);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowBuildGridDataState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667061);
      DebugMenuMapper.NativeMethodInfoPtr_GetBuildCostsDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667062);
      DebugMenuMapper.NativeMethodInfoPtr_GetTutorialPopupDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667063);
      DebugMenuMapper.NativeMethodInfoPtr_GetAllProgressionUnlocked_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667064);
      DebugMenuMapper.NativeMethodInfoPtr_GetAllVBloodAbilitiesUnlockedOnLaunch_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667065);
      DebugMenuMapper.NativeMethodInfoPtr_GetRevealedMap_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667066);
      DebugMenuMapper.NativeMethodInfoPtr_GetDisableCooldowns_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667067);
      DebugMenuMapper.NativeMethodInfoPtr_GetPlayersInvulnerabilityEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667068);
      DebugMenuMapper.NativeMethodInfoPtr_GetSunDamageDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667069);
      DebugMenuMapper.NativeMethodInfoPtr_GetDisableLightningStrikes_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667070);
      DebugMenuMapper.NativeMethodInfoPtr_GetDurabilityDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667071);
      DebugMenuMapper.NativeMethodInfoPtr_GetDrainBloodDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667072);
      DebugMenuMapper.NativeMethodInfoPtr_GlobalCastleTerritoryEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667073);
      DebugMenuMapper.NativeMethodInfoPtr_GetPlacementRestrictionsDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667074);
      DebugMenuMapper.NativeMethodInfoPtr_GetCastleHeartConnectionRequirementDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667075);
      DebugMenuMapper.NativeMethodInfoPtr_GetCastleHeartBloodEssenceDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667076);
      DebugMenuMapper.NativeMethodInfoPtr_GetCastleBuildingLimitsDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667077);
      DebugMenuMapper.NativeMethodInfoPtr_GetBuildingEnableDebugging_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667078);
      DebugMenuMapper.NativeMethodInfoPtr_GetDropsDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667079);
      DebugMenuMapper.NativeMethodInfoPtr_GetAllWaypointsUnlocked_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667080);
      DebugMenuMapper.NativeMethodInfoPtr_GetHitEffectsEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667081);
      DebugMenuMapper.NativeMethodInfoPtr_GetRoofGenerationEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667082);
      DebugMenuMapper.NativeMethodInfoPtr_GetLinnCastleRoofsEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667083);
      DebugMenuMapper.NativeMethodInfoPtr_SetDayButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667084);
      DebugMenuMapper.NativeMethodInfoPtr_SetNightButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667085);
      DebugMenuMapper.NativeMethodInfoPtr_GetDayNightCycleDisabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667086);
      DebugMenuMapper.NativeMethodInfoPtr_DayNightCycleDisabled_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667087);
      DebugMenuMapper.NativeMethodInfoPtr_GetUseDeathSequencesInsteadOfRagdolls_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667088);
      DebugMenuMapper.NativeMethodInfoPtr_GetDisableDynamicClouds_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667089);
      DebugMenuMapper.NativeMethodInfoPtr_UseDeathSequencesInsteadOfRagdolls_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667090);
      DebugMenuMapper.NativeMethodInfoPtr_DisableDynamicClouds_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667091);
      DebugMenuMapper.NativeMethodInfoPtr_GetDisableNpcsState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667092);
      DebugMenuMapper.NativeMethodInfoPtr_DisableNpcs_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667093);
      DebugMenuMapper.NativeMethodInfoPtr_GetDisableAiCastsState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667094);
      DebugMenuMapper.NativeMethodInfoPtr_DisableAiCasts_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667095);
      DebugMenuMapper.NativeMethodInfoPtr_GetDisableVbloodGhostsState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667096);
      DebugMenuMapper.NativeMethodInfoPtr_DisableVbloodGhosts_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667097);
      DebugMenuMapper.NativeMethodInfoPtr_GetDisableAggroState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667098);
      DebugMenuMapper.NativeMethodInfoPtr_DisableAggro_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667099);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowAiPaths_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667100);
      DebugMenuMapper.NativeMethodInfoPtr_ShowAiPaths_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667101);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowWorldPaths_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667102);
      DebugMenuMapper.NativeMethodInfoPtr_ShowWorldPaths_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667103);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowAiDistances_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667104);
      DebugMenuMapper.NativeMethodInfoPtr_ShowAiDistances_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667105);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowAiStateInfo_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667106);
      DebugMenuMapper.NativeMethodInfoPtr_ShowAiStateInfo_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667107);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowAggro_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667108);
      DebugMenuMapper.NativeMethodInfoPtr_ShowAggro_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667109);
      DebugMenuMapper.NativeMethodInfoPtr_GetShowAlert_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667110);
      DebugMenuMapper.NativeMethodInfoPtr_ShowAlert_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667111);
      DebugMenuMapper.NativeMethodInfoPtr_TryGetServerShowAi_Private_Boolean_byref_ShowAi_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667112);
      DebugMenuMapper.NativeMethodInfoPtr_UnlockVBloodPassives_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667113);
      DebugMenuMapper.NativeMethodInfoPtr_UnlockVBloodAbilities_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667114);
      DebugMenuMapper.NativeMethodInfoPtr_UnlockVBloodShapeshifts_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667115);
      DebugMenuMapper.NativeMethodInfoPtr_ClearTutorialProgression_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667116);
      DebugMenuMapper.NativeMethodInfoPtr_CopyPositionDump_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667117);
      DebugMenuMapper.NativeMethodInfoPtr_CopyDebugDump_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667118);
      DebugMenuMapper.NativeMethodInfoPtr_CreateDebugDump_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667119);
      DebugMenuMapper.NativeMethodInfoPtr_CreatePerformanceDump_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667120);
      DebugMenuMapper.NativeMethodInfoPtr_OpenCrashDumpFolder_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667121);
      DebugMenuMapper.NativeMethodInfoPtr_OpenLogsFolder_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667122);
      DebugMenuMapper.NativeMethodInfoPtr_OpenEditorLogsFolder_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667123);
      DebugMenuMapper.NativeMethodInfoPtr_DummySpawnThing_OnButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667124);
      DebugMenuMapper.NativeMethodInfoPtr_DummyDoOther_OnButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667125);
      DebugMenuMapper.NativeMethodInfoPtr_DummySliderTest_OnValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667126);
      DebugMenuMapper.NativeMethodInfoPtr_DebugGrid_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667127);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_HUD_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667128);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_CharacterHUDs_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667129);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Minimap_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667130);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_EdgeIcons_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667131);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Achievements_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667132);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Clan_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667133);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Replay_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667134);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_SCT_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667135);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_Logs_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667136);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_HudMenus_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667137);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_MenuLinks_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667138);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_SpecialWakeupText_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667139);
      DebugMenuMapper.NativeMethodInfoPtr_GetHudState_VersionData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667140);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_HUD_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667141);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_CharacterHUDs_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667142);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Minimap_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667143);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_EdgeIcons_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667144);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Achievements_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667145);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Clan_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667146);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Replay_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667147);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_SCT_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667148);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_Logs_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667149);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_MenuLinks_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667150);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_SpecialWakeupMenu_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667151);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_VersionData_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667152);
      DebugMenuMapper.NativeMethodInfoPtr_DisableHudElement_HudMenus_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667153);
      DebugMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667154);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667155);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667156);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667157);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667158);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667159);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667160);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667161);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667162);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667163);
      DebugMenuMapper.NativeMethodInfoPtr__InitTabButtons_b__21_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667164);
      DebugMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, 100667165);
    }

    public DebugMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DebugTab _CurrentTab
    {
      get
      {
        return *(DebugTab*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__CurrentTab));
      }
      [param: In] set
      {
        *(DebugTab*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__CurrentTab)) = value;
      }
    }

    public unsafe DebugMenu _DebugMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__DebugMenu));
        return pointer == System.IntPtr.Zero ? (DebugMenu) null : new DebugMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__DebugMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<DebugMenuTabButton> _ButtonCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__ButtonCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<DebugMenuTabButton>) null : new UI_Cache<DebugMenuTabButton>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__ButtonCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<DebugMenuItem> _MenuItemCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__MenuItemCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<DebugMenuItem>) null : new UI_Cache<DebugMenuItem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__MenuItemCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VCA _AmbienceVca
    {
      get
      {
        return *(VCA*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__AmbienceVca));
      }
      [param: In] set
      {
        *(VCA*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__AmbienceVca)) = value;
      }
    }

    public unsafe VCA _MusicVca
    {
      get
      {
        return *(VCA*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__MusicVca));
      }
      [param: In] set
      {
        *(VCA*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__MusicVca)) = value;
      }
    }

    public unsafe VCA _SoundEffectsVca
    {
      get
      {
        return *(VCA*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__SoundEffectsVca));
      }
      [param: In] set
      {
        *(VCA*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__SoundEffectsVca)) = value;
      }
    }

    public unsafe VCA _VoiceOverVca
    {
      get
      {
        return *(VCA*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__VoiceOverVca));
      }
      [param: In] set
      {
        *(VCA*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.NativeFieldInfoPtr__VoiceOverVca)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.DebugMenuMapper/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__InitTab_General_b__24_0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugMenuMapper.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256876, XrefRangeEnd = 1256877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _InitTab_General_b__24_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.__c.NativeMethodInfoPtr__InitTab_General_b__24_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<DebugMenuMapper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugMenuMapper.__c>.NativeClassPtr);
        DebugMenuMapper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper.__c>.NativeClassPtr, "<>9");
        DebugMenuMapper.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper.__c>.NativeClassPtr, "<>9__24_0");
        DebugMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper.__c>.NativeClassPtr, 100667167);
        DebugMenuMapper.__c.NativeMethodInfoPtr__InitTab_General_b__24_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper.__c>.NativeClassPtr, 100667168);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe DebugMenuMapper.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugMenuMapper.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DebugMenuMapper.__c) null : new DebugMenuMapper.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugMenuMapper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__24_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugMenuMapper.__c.NativeFieldInfoPtr___9__24_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugMenuMapper.__c.NativeFieldInfoPtr___9__24_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.DebugMenuMapper/<>c__DisplayClass42_0")]
    public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_returnValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetDebugMenu_b__0_Internal_Void_Entity_DebugMenu_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass42_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugMenuMapper.__c__DisplayClass42_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256877, XrefRangeEnd = 1256878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GetDebugMenu_b__0(Entity entity, DebugMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugMenuMapper.__c__DisplayClass42_0.NativeMethodInfoPtr__GetDebugMenu_b__0_Internal_Void_Entity_DebugMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass42_0()
      {
        Il2CppClassPointerStore<DebugMenuMapper.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugMenuMapper>.NativeClassPtr, "<>c__DisplayClass42_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugMenuMapper.__c__DisplayClass42_0>.NativeClassPtr);
        DebugMenuMapper.__c__DisplayClass42_0.NativeFieldInfoPtr_returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuMapper.__c__DisplayClass42_0>.NativeClassPtr, nameof (returnValue));
        DebugMenuMapper.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper.__c__DisplayClass42_0>.NativeClassPtr, 100667169);
        DebugMenuMapper.__c__DisplayClass42_0.NativeMethodInfoPtr__GetDebugMenu_b__0_Internal_Void_Entity_DebugMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuMapper.__c__DisplayClass42_0>.NativeClassPtr, 100667170);
      }

      public __c__DisplayClass42_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe DebugMenu returnValue
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.__c__DisplayClass42_0.NativeFieldInfoPtr_returnValue));
          return pointer == System.IntPtr.Zero ? (DebugMenu) null : new DebugMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuMapper.__c__DisplayClass42_0.NativeFieldInfoPtr_returnValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
