// Decompiled with JetBrains decompiler
// Type: NetworkEvents
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
public static class NetworkEvents : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_None;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_AbortMissionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_AcceptClanInviteResultResponse;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_AchievementClaimedServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ActivateVBloodAbilityEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_AdminAuthEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_AdminCommandNotifyUsersServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_AdminForceJoinedYourClan;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ApplyBuffDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_BanEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_BecomeObserverEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_BlinkEntityEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_BuildDebugCastleEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_BuildTileModelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_BuildWallpaperEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CancelEditTileModelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CancelRepair;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CastAbilityServerDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CastleAttackedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CastleHeartRaidEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CastleWallBreachedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChangeBloodDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChangeDurabilityDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChangeHealthDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChangeHealthOfClosestToPositionDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChangeRole_Request;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChangeServantNameEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChangeVBloodDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CharacterHasRespawnedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CharacterRespawnEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChatMessageEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ChatMessageServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClaimAchievementEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClaimedAchievementsEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClaimItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClaimPylonEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClaimVBloodEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClanInvitationResponse;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClanInvitationResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClanInviteResponse;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClientActionResponseEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClientEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ClientStateEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CollectChargedItemsEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CompleteAllAchievementsEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CompleteCraftJewelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CompleteCurrentAchievementAdminEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CompleteJournalDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ConsumeBloodDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ControlDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CrashDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CreateCharacterEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CreateCharacterResponseEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CreateClan_Request;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CreateClan_Response;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CreateJewelDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CustomizationDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_CustomizeCharacterEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DeauthAdminEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DebugTeleportToEntityEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DebugTeleportToNetherEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DecayEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DeleteMapMarkerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DestroyDeadDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DestroyDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DestroyPylonEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DiscoveredMapZonesEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DiscoverResearchEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DismantleTileModelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DropEquippedItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DropInventoryItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_DropItemAtSlotEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EditClan;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EnterShapeshiftEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipBagEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipBagFromInventoryEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipItemFromInventoryEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipJewelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipmentToEquipmentTransferEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipSaddleEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipServantItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_EquipServantItemFromInventoryEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ErrorResponse;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ForceClaimAchievement_Debug;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ForfeitCastleHeartEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_FullUserInfoSyncEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GenerateJewelAtUnitLevelDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GenerateJewelDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GenerateLegendaryWeaponDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GetTerritoryOwnerRequestEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GetTerritoryOwnerResponseEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GetVBloodPositionsEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GetVBloodPositionsResponseEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GiveDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_GiveUpReviveEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_HardCoreDeathEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_InitialUnlockedProgressionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_InsertItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_InteractWithPrisonerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_InvitePlayerToClan;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_JewelEquippedResponseEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_JumpToNextBloodMoonEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_Kick_Request;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_KickedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_KickEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_KillEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_LatencyDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_LeaveClan;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_LeaveClanResultResponse;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_MapZoneDiscoveredEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_MemberConnectionChangedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_MoveAllItemsBetweenInventoriesEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_MoveAllItemsBetweenInventoriesEventV2;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_MoveItemBetweenInventoriesEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_MoveTileModelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_NewSiegeWeapon;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_OpenVBloodMenuEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_OverrideVampireAttackPowerDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_PlayerTeleportDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_PvPToggleEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RandomizeCustomization2DebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RandomizeCustomizationDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RecommendedSpawnLocationRequestEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RecommendedSpawnLocationResponseEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RegisterCharacterNameEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RemoveItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RemovePvPProtectionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RenameInteractable;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RenameUserDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RepairEquippedItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RepairItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RepairTileModelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_Reponse;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_Request_ByClosestToPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_Request_ByPlayerName;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_Request0;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ResetBuffAgeServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ResetCooldownsDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ResetScheduleNotificationEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ResetServerLogsEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RespawnAiDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RestorStationEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RevealedMapEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RoleChangedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_RunConsoleCommandDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ScrambleGameModeDataEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SendOnMissionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SerializePersistenceFailedFeedbackEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ServantCoffinActionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ServantMissionFinishedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ServantMissionStartedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ServerChannelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ServerDebugErrorEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ServerIsRestartingServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ServerLoginEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ServerRejectEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetAdminOnlyDebugEventsAdminEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetCloudinessDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetControlMoveSpeedDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetDebugSettingEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetMapMarkerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetMovementSpeedDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetPlayerTeamDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetTileModelVariationEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetTimeOfDayEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetTimeScaleDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetUserAdminLevelAdminEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SetUserContentDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ShareRefinementEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ShareUnitspawnerRecipesEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ShareVBloodEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SmartMergeItemsBetweenInventoriesEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SortAllInventoriesEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SortSingleInventoryEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SpawnCharmeableDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SpawnDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SpawnUnitEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SpellModSetAckEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SplitItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StartCharacterCraftItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StartChargeItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StartCraftItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StartCraftJewelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StartEditTileModelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StartRepair;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StartTrackVBloodUnitEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StartTrackVBloodUnitEventV2;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StopCharacterCraftItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StopCraftItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StopCraftJewelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StopInteractingWithObjectEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_StopTrackVBloodUnitEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_SwapBagSlotsEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_TeleportDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_TeleportPlayerToLocationDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_TeleportToNetherEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_TeleportToPlayerLocationDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_TeleportToWaypointEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ToggleInvulnerableEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ToggleRefiningEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ToggleSalvageEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_ToggleUserPermissionsEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_TrackVBloodDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_TraderPurchaseEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_TryInsertBloodEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnequipBagEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnequipBagIntoInventoryEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnequipItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnequipJewelEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnequipSaddleEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnequipServantItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnlockAllVBloodAbilities;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnlockAllVBloodPassives;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnlockAllVBloodShapeshifts;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnlockProgressionServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnlockRegionDebugEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UnlockResearchEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UpgradePylonEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UseDefaultActionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UseEmoteEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UseItemEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UserConnectedServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UserDisconnectedServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UserDownedServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UserInfoServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_UserKillServerEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventId_WarningForBeingAFKEvent;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_byref_User_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_byref_User_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkEventType_Public_Static_NetworkEventType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEventId_Private_Static_Void_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkEventName_Public_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEventName_Private_Static_Void_Int32_byref_String_0;

  [CallerCount(0)]
  public static unsafe Entity SendEvent<T>(EntityCommandBuffer commandBuffer, T eventData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &commandBuffer;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) eventData;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref eventData;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkEvents.MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Entity*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 916517, RefRangeEnd = 916518, XrefRangeStart = 916491, XrefRangeEnd = 916517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Entity SendEvent<T>(EntityManager entityManager, T eventData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &entityManager;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) eventData;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref eventData;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkEvents.MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityManager_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Entity*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 916518, RefRangeEnd = 916542, XrefRangeStart = 916518, XrefRangeEnd = 916518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Entity SendEvent<T>(
    EntityCommandBuffer commandBuffer,
    T eventData,
    [In] ref User toUser)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &commandBuffer;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) eventData;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref eventData;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref toUser;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkEvents.MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_byref_User_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Entity*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 916566, RefRangeEnd = 916586, XrefRangeStart = 916542, XrefRangeEnd = 916566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Entity SendEvent<T>(
    EntityManager entityManager,
    T eventData,
    [In] ref User toUser)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &entityManager;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) eventData;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref eventData;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref toUser;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkEvents.MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityManager_T_byref_User_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Entity*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916586, XrefRangeEnd = 916597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Entity SendEvent<T>(
    EntityCommandBuffer commandBuffer,
    T eventData,
    int userIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &commandBuffer;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) eventData;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref eventData;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userIndex;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkEvents.MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Entity*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 916621, RefRangeEnd = 916622, XrefRangeStart = 916597, XrefRangeEnd = 916621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Entity SendEvent<T>(EntityManager entityManager, T eventData, int userIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &entityManager;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) eventData;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref eventData;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userIndex;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkEvents.MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityManager_T_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Entity*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916622, XrefRangeEnd = 916628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe NetworkEventType GetNetworkEventType<T>()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkEvents.MethodInfoStoreGeneric_GetNetworkEventType_Public_Static_NetworkEventType_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(NetworkEventType*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916628, XrefRangeEnd = 917764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetEventId<T>(ref int eventId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref eventId;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NetworkEvents.MethodInfoStoreGeneric_GetEventId_Private_Static_Void_byref_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 917765, RefRangeEnd = 917766, XrefRangeStart = 917764, XrefRangeEnd = 917765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetNetworkEventName(int eventId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &eventId;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NetworkEvents.NativeMethodInfoPtr_GetNetworkEventName_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 918674, RefRangeEnd = 918675, XrefRangeStart = 917766, XrefRangeEnd = 918674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetEventName(int eventId, ref string name)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &eventId;
    System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr* numPtr2 = &il2Cpp;
    *(System.IntPtr*) num = (System.IntPtr) numPtr2;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NetworkEvents.NativeMethodInfoPtr_GetEventName_Private_Static_Void_Int32_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    name = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  static NetworkEvents()
  {
    Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (NetworkEvents));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr);
    NetworkEvents.NativeFieldInfoPtr_EventId_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_None));
    NetworkEvents.NativeFieldInfoPtr_EventId_AbortMissionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_AbortMissionEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_AcceptClanInviteResultResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_AcceptClanInviteResultResponse));
    NetworkEvents.NativeFieldInfoPtr_EventId_AchievementClaimedServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_AchievementClaimedServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ActivateVBloodAbilityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ActivateVBloodAbilityEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_AdminAuthEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_AdminAuthEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_AdminCommandNotifyUsersServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_AdminCommandNotifyUsersServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_AdminForceJoinedYourClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_AdminForceJoinedYourClan));
    NetworkEvents.NativeFieldInfoPtr_EventId_ApplyBuffDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ApplyBuffDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_BanEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_BanEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_BecomeObserverEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_BecomeObserverEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_BlinkEntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_BlinkEntityEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_BuildDebugCastleEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_BuildDebugCastleEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_BuildTileModelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_BuildTileModelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_BuildWallpaperEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_BuildWallpaperEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CancelEditTileModelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CancelEditTileModelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CancelRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CancelRepair));
    NetworkEvents.NativeFieldInfoPtr_EventId_CastAbilityServerDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CastAbilityServerDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CastleAttackedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CastleAttackedEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CastleHeartRaidEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CastleHeartRaidEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CastleWallBreachedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CastleWallBreachedEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChangeBloodDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChangeBloodDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChangeDurabilityDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChangeDurabilityDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChangeHealthDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChangeHealthDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChangeHealthOfClosestToPositionDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChangeHealthOfClosestToPositionDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChangeRole_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChangeRole_Request));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChangeServantNameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChangeServantNameEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChangeVBloodDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChangeVBloodDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CharacterHasRespawnedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CharacterHasRespawnedEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CharacterRespawnEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CharacterRespawnEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChatMessageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChatMessageEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ChatMessageServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ChatMessageServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClaimAchievementEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClaimAchievementEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClaimedAchievementsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClaimedAchievementsEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClaimItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClaimItem));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClaimPylonEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClaimPylonEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClaimVBloodEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClaimVBloodEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClanInvitationResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClanInvitationResponse));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClanInvitationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClanInvitationResult));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClanInviteResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClanInviteResponse));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClientActionResponseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClientActionResponseEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClientEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClientEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ClientStateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ClientStateEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CollectChargedItemsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CollectChargedItemsEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CompleteAllAchievementsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CompleteAllAchievementsEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CompleteCraftJewelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CompleteCraftJewelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CompleteCurrentAchievementAdminEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CompleteCurrentAchievementAdminEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CompleteJournalDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CompleteJournalDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ConsumeBloodDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ConsumeBloodDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ControlDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ControlDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CrashDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CrashDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CreateCharacterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CreateCharacterEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CreateCharacterResponseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CreateCharacterResponseEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CreateClan_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CreateClan_Request));
    NetworkEvents.NativeFieldInfoPtr_EventId_CreateClan_Response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CreateClan_Response));
    NetworkEvents.NativeFieldInfoPtr_EventId_CreateJewelDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CreateJewelDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CustomizationDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CustomizationDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_CustomizeCharacterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_CustomizeCharacterEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DeauthAdminEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DeauthAdminEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DebugTeleportToEntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DebugTeleportToEntityEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DebugTeleportToNetherEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DebugTeleportToNetherEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DecayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DecayEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DeleteMapMarkerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DeleteMapMarkerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DestroyDeadDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DestroyDeadDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DestroyDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DestroyDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DestroyPylonEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DestroyPylonEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DiscoveredMapZonesEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DiscoveredMapZonesEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DiscoverResearchEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DiscoverResearchEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DismantleTileModelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DismantleTileModelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DropEquippedItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DropEquippedItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DropInventoryItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DropInventoryItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_DropItemAtSlotEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_DropItemAtSlotEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EditClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EditClan));
    NetworkEvents.NativeFieldInfoPtr_EventId_EnterShapeshiftEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EnterShapeshiftEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipBagEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipBagEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipBagFromInventoryEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipBagFromInventoryEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipItemFromInventoryEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipItemFromInventoryEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipJewelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipJewelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipmentToEquipmentTransferEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipmentToEquipmentTransferEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipSaddleEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipSaddleEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipServantItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipServantItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_EquipServantItemFromInventoryEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_EquipServantItemFromInventoryEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ErrorResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ErrorResponse));
    NetworkEvents.NativeFieldInfoPtr_EventId_ForceClaimAchievement_Debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ForceClaimAchievement_Debug));
    NetworkEvents.NativeFieldInfoPtr_EventId_ForfeitCastleHeartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ForfeitCastleHeartEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_FullUserInfoSyncEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_FullUserInfoSyncEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GenerateJewelAtUnitLevelDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GenerateJewelAtUnitLevelDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GenerateJewelDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GenerateJewelDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GenerateLegendaryWeaponDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GenerateLegendaryWeaponDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GetTerritoryOwnerRequestEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GetTerritoryOwnerRequestEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GetTerritoryOwnerResponseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GetTerritoryOwnerResponseEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GetVBloodPositionsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GetVBloodPositionsEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GetVBloodPositionsResponseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GetVBloodPositionsResponseEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GiveDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GiveDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_GiveUpReviveEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_GiveUpReviveEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_HardCoreDeathEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_HardCoreDeathEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_InitialUnlockedProgressionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_InitialUnlockedProgressionEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_InsertItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_InsertItem));
    NetworkEvents.NativeFieldInfoPtr_EventId_InteractWithPrisonerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_InteractWithPrisonerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_InvitePlayerToClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_InvitePlayerToClan));
    NetworkEvents.NativeFieldInfoPtr_EventId_JewelEquippedResponseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_JewelEquippedResponseEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_JumpToNextBloodMoonEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_JumpToNextBloodMoonEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_Kick_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_Kick_Request));
    NetworkEvents.NativeFieldInfoPtr_EventId_KickedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_KickedEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_KickEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_KickEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_KillEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_KillEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_LatencyDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_LatencyDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_LeaveClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_LeaveClan));
    NetworkEvents.NativeFieldInfoPtr_EventId_LeaveClanResultResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_LeaveClanResultResponse));
    NetworkEvents.NativeFieldInfoPtr_EventId_MapZoneDiscoveredEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_MapZoneDiscoveredEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_MemberConnectionChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_MemberConnectionChangedEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_MoveAllItemsBetweenInventoriesEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_MoveAllItemsBetweenInventoriesEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_MoveAllItemsBetweenInventoriesEventV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_MoveAllItemsBetweenInventoriesEventV2));
    NetworkEvents.NativeFieldInfoPtr_EventId_MoveItemBetweenInventoriesEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_MoveItemBetweenInventoriesEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_MoveTileModelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_MoveTileModelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_NewSiegeWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_NewSiegeWeapon));
    NetworkEvents.NativeFieldInfoPtr_EventId_OpenVBloodMenuEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_OpenVBloodMenuEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_OverrideVampireAttackPowerDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_OverrideVampireAttackPowerDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_PlayerTeleportDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_PlayerTeleportDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_PvPToggleEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_PvPToggleEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RandomizeCustomization2DebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RandomizeCustomization2DebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RandomizeCustomizationDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RandomizeCustomizationDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RecommendedSpawnLocationRequestEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RecommendedSpawnLocationRequestEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RecommendedSpawnLocationResponseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RecommendedSpawnLocationResponseEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RegisterCharacterNameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RegisterCharacterNameEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RemoveItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RemoveItem));
    NetworkEvents.NativeFieldInfoPtr_EventId_RemovePvPProtectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RemovePvPProtectionEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RenameInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RenameInteractable));
    NetworkEvents.NativeFieldInfoPtr_EventId_RenameUserDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RenameUserDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RepairEquippedItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RepairEquippedItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RepairItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RepairItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RepairTileModelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RepairTileModelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_Reponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_Reponse));
    NetworkEvents.NativeFieldInfoPtr_EventId_Request_ByClosestToPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_Request_ByClosestToPosition));
    NetworkEvents.NativeFieldInfoPtr_EventId_Request_ByPlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_Request_ByPlayerName));
    NetworkEvents.NativeFieldInfoPtr_EventId_Request0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_Request0));
    NetworkEvents.NativeFieldInfoPtr_EventId_ResetBuffAgeServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ResetBuffAgeServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ResetCooldownsDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ResetCooldownsDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ResetScheduleNotificationEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ResetScheduleNotificationEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ResetServerLogsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ResetServerLogsEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RespawnAiDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RespawnAiDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RestorStationEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RestorStationEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RevealedMapEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RevealedMapEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RoleChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RoleChangedEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_RunConsoleCommandDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_RunConsoleCommandDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ScrambleGameModeDataEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ScrambleGameModeDataEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SendOnMissionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SendOnMissionEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SerializePersistenceFailedFeedbackEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SerializePersistenceFailedFeedbackEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ServantCoffinActionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ServantCoffinActionEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ServantMissionFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ServantMissionFinishedEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ServantMissionStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ServantMissionStartedEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ServerChannelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ServerChannelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ServerDebugErrorEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ServerDebugErrorEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ServerIsRestartingServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ServerIsRestartingServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ServerLoginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ServerLoginEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ServerRejectEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ServerRejectEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetAdminOnlyDebugEventsAdminEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetAdminOnlyDebugEventsAdminEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetCloudinessDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetCloudinessDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetControlMoveSpeedDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetControlMoveSpeedDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetDebugSettingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetDebugSettingEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetMapMarkerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetMapMarkerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetMovementSpeedDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetMovementSpeedDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetPlayerTeamDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetPlayerTeamDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetTileModelVariationEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetTileModelVariationEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetTimeOfDayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetTimeOfDayEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetTimeScaleDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetTimeScaleDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetUserAdminLevelAdminEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetUserAdminLevelAdminEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SetUserContentDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SetUserContentDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ShareRefinementEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ShareRefinementEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ShareUnitspawnerRecipesEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ShareUnitspawnerRecipesEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ShareVBloodEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ShareVBloodEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SmartMergeItemsBetweenInventoriesEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SmartMergeItemsBetweenInventoriesEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SortAllInventoriesEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SortAllInventoriesEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SortSingleInventoryEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SortSingleInventoryEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SpawnCharmeableDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SpawnCharmeableDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SpawnDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SpawnDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SpawnUnitEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SpawnUnitEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SpellModSetAckEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SpellModSetAckEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SplitItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SplitItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StartCharacterCraftItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StartCharacterCraftItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StartChargeItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StartChargeItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StartCraftItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StartCraftItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StartCraftJewelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StartCraftJewelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StartEditTileModelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StartEditTileModelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StartRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StartRepair));
    NetworkEvents.NativeFieldInfoPtr_EventId_StartTrackVBloodUnitEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StartTrackVBloodUnitEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StartTrackVBloodUnitEventV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StartTrackVBloodUnitEventV2));
    NetworkEvents.NativeFieldInfoPtr_EventId_StopCharacterCraftItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StopCharacterCraftItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StopCraftItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StopCraftItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StopCraftJewelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StopCraftJewelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StopInteractingWithObjectEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StopInteractingWithObjectEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_StopTrackVBloodUnitEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_StopTrackVBloodUnitEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_SwapBagSlotsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_SwapBagSlotsEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_TeleportDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_TeleportDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_TeleportPlayerToLocationDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_TeleportPlayerToLocationDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToNetherEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_TeleportToNetherEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToPlayerLocationDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_TeleportToPlayerLocationDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToWaypointEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_TeleportToWaypointEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ToggleInvulnerableEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ToggleInvulnerableEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ToggleRefiningEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ToggleRefiningEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ToggleSalvageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ToggleSalvageEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_ToggleUserPermissionsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_ToggleUserPermissionsEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_TrackVBloodDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_TrackVBloodDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_TraderPurchaseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_TraderPurchaseEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_TryInsertBloodEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_TryInsertBloodEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnequipBagEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnequipBagEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnequipBagIntoInventoryEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnequipBagIntoInventoryEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnequipItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnequipItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnequipJewelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnequipJewelEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnequipSaddleEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnequipSaddleEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnequipServantItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnequipServantItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnlockAllVBloodAbilities));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodPassives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnlockAllVBloodPassives));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodShapeshifts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnlockAllVBloodShapeshifts));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnlockProgressionServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnlockProgressionServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnlockRegionDebugEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnlockRegionDebugEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UnlockResearchEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UnlockResearchEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UpgradePylonEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UpgradePylonEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UseDefaultActionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UseDefaultActionEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UseEmoteEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UseEmoteEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UseItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UseItemEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UserConnectedServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UserConnectedServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UserDisconnectedServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UserDisconnectedServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UserDownedServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UserDownedServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UserInfoServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UserInfoServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_UserKillServerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_UserKillServerEvent));
    NetworkEvents.NativeFieldInfoPtr_EventId_WarningForBeingAFKEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, nameof (EventId_WarningForBeingAFKEvent));
    NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663654);
    NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663655);
    NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663656);
    NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663657);
    NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663658);
    NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663659);
    NetworkEvents.NativeMethodInfoPtr_GetNetworkEventType_Public_Static_NetworkEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663660);
    NetworkEvents.NativeMethodInfoPtr_GetEventId_Private_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663661);
    NetworkEvents.NativeMethodInfoPtr_GetNetworkEventName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663662);
    NetworkEvents.NativeMethodInfoPtr_GetEventName_Private_Static_Void_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr, 100663663);
  }

  public NetworkEvents(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int EventId_None
  {
    get
    {
      int eventIdNone;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_None, (void*) &eventIdNone);
      return eventIdNone;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_None, (void*) &value);
    }
  }

  public static unsafe int EventId_AbortMissionEvent
  {
    get
    {
      int abortMissionEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_AbortMissionEvent, (void*) &abortMissionEvent);
      return abortMissionEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_AbortMissionEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_AcceptClanInviteResultResponse
  {
    get
    {
      int inviteResultResponse;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_AcceptClanInviteResultResponse, (void*) &inviteResultResponse);
      return inviteResultResponse;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_AcceptClanInviteResultResponse, (void*) &value);
    }
  }

  public static unsafe int EventId_AchievementClaimedServerEvent
  {
    get
    {
      int claimedServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_AchievementClaimedServerEvent, (void*) &claimedServerEvent);
      return claimedServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_AchievementClaimedServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ActivateVBloodAbilityEvent
  {
    get
    {
      int vbloodAbilityEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ActivateVBloodAbilityEvent, (void*) &vbloodAbilityEvent);
      return vbloodAbilityEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ActivateVBloodAbilityEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_AdminAuthEvent
  {
    get
    {
      int idAdminAuthEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_AdminAuthEvent, (void*) &idAdminAuthEvent);
      return idAdminAuthEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_AdminAuthEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_AdminCommandNotifyUsersServerEvent
  {
    get
    {
      int usersServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_AdminCommandNotifyUsersServerEvent, (void*) &usersServerEvent);
      return usersServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_AdminCommandNotifyUsersServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_AdminForceJoinedYourClan
  {
    get
    {
      int forceJoinedYourClan;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_AdminForceJoinedYourClan, (void*) &forceJoinedYourClan);
      return forceJoinedYourClan;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_AdminForceJoinedYourClan, (void*) &value);
    }
  }

  public static unsafe int EventId_ApplyBuffDebugEvent
  {
    get
    {
      int applyBuffDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ApplyBuffDebugEvent, (void*) &applyBuffDebugEvent);
      return applyBuffDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ApplyBuffDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_BanEvent
  {
    get
    {
      int eventIdBanEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_BanEvent, (void*) &eventIdBanEvent);
      return eventIdBanEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_BanEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_BecomeObserverEvent
  {
    get
    {
      int becomeObserverEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_BecomeObserverEvent, (void*) &becomeObserverEvent);
      return becomeObserverEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_BecomeObserverEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_BlinkEntityEvent
  {
    get
    {
      int blinkEntityEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_BlinkEntityEvent, (void*) &blinkEntityEvent);
      return blinkEntityEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_BlinkEntityEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_BuildDebugCastleEvent
  {
    get
    {
      int debugCastleEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_BuildDebugCastleEvent, (void*) &debugCastleEvent);
      return debugCastleEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_BuildDebugCastleEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_BuildTileModelEvent
  {
    get
    {
      int buildTileModelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_BuildTileModelEvent, (void*) &buildTileModelEvent);
      return buildTileModelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_BuildTileModelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_BuildWallpaperEvent
  {
    get
    {
      int buildWallpaperEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_BuildWallpaperEvent, (void*) &buildWallpaperEvent);
      return buildWallpaperEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_BuildWallpaperEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CancelEditTileModelEvent
  {
    get
    {
      int editTileModelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CancelEditTileModelEvent, (void*) &editTileModelEvent);
      return editTileModelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CancelEditTileModelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CancelRepair
  {
    get
    {
      int eventIdCancelRepair;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CancelRepair, (void*) &eventIdCancelRepair);
      return eventIdCancelRepair;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CancelRepair, (void*) &value);
    }
  }

  public static unsafe int EventId_CastAbilityServerDebugEvent
  {
    get
    {
      int serverDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CastAbilityServerDebugEvent, (void*) &serverDebugEvent);
      return serverDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CastAbilityServerDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CastleAttackedEvent
  {
    get
    {
      int castleAttackedEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CastleAttackedEvent, (void*) &castleAttackedEvent);
      return castleAttackedEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CastleAttackedEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CastleHeartRaidEvent
  {
    get
    {
      int castleHeartRaidEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CastleHeartRaidEvent, (void*) &castleHeartRaidEvent);
      return castleHeartRaidEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CastleHeartRaidEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CastleWallBreachedEvent
  {
    get
    {
      int wallBreachedEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CastleWallBreachedEvent, (void*) &wallBreachedEvent);
      return wallBreachedEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CastleWallBreachedEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ChangeBloodDebugEvent
  {
    get
    {
      int changeBloodDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeBloodDebugEvent, (void*) &changeBloodDebugEvent);
      return changeBloodDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeBloodDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ChangeDurabilityDebugEvent
  {
    get
    {
      int durabilityDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeDurabilityDebugEvent, (void*) &durabilityDebugEvent);
      return durabilityDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeDurabilityDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ChangeHealthDebugEvent
  {
    get
    {
      int healthDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeHealthDebugEvent, (void*) &healthDebugEvent);
      return healthDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeHealthDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ChangeHealthOfClosestToPositionDebugEvent
  {
    get
    {
      int positionDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeHealthOfClosestToPositionDebugEvent, (void*) &positionDebugEvent);
      return positionDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeHealthOfClosestToPositionDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ChangeRole_Request
  {
    get
    {
      int changeRoleRequest;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeRole_Request, (void*) &changeRoleRequest);
      return changeRoleRequest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeRole_Request, (void*) &value);
    }
  }

  public static unsafe int EventId_ChangeServantNameEvent
  {
    get
    {
      int servantNameEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeServantNameEvent, (void*) &servantNameEvent);
      return servantNameEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeServantNameEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ChangeVBloodDebugEvent
  {
    get
    {
      int vbloodDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeVBloodDebugEvent, (void*) &vbloodDebugEvent);
      return vbloodDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChangeVBloodDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CharacterHasRespawnedEvent
  {
    get
    {
      int hasRespawnedEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CharacterHasRespawnedEvent, (void*) &hasRespawnedEvent);
      return hasRespawnedEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CharacterHasRespawnedEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CharacterRespawnEvent
  {
    get
    {
      int characterRespawnEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CharacterRespawnEvent, (void*) &characterRespawnEvent);
      return characterRespawnEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CharacterRespawnEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ChatMessageEvent
  {
    get
    {
      int chatMessageEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChatMessageEvent, (void*) &chatMessageEvent);
      return chatMessageEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChatMessageEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ChatMessageServerEvent
  {
    get
    {
      int messageServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChatMessageServerEvent, (void*) &messageServerEvent);
      return messageServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ChatMessageServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ClaimAchievementEvent
  {
    get
    {
      int achievementEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimAchievementEvent, (void*) &achievementEvent);
      return achievementEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimAchievementEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ClaimedAchievementsEvent
  {
    get
    {
      int achievementsEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimedAchievementsEvent, (void*) &achievementsEvent);
      return achievementsEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimedAchievementsEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ClaimItem
  {
    get
    {
      int eventIdClaimItem;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimItem, (void*) &eventIdClaimItem);
      return eventIdClaimItem;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimItem, (void*) &value);
    }
  }

  public static unsafe int EventId_ClaimPylonEvent
  {
    get
    {
      int idClaimPylonEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimPylonEvent, (void*) &idClaimPylonEvent);
      return idClaimPylonEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimPylonEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ClaimVBloodEvent
  {
    get
    {
      int claimVbloodEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimVBloodEvent, (void*) &claimVbloodEvent);
      return claimVbloodEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClaimVBloodEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ClanInvitationResponse
  {
    get
    {
      int invitationResponse;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClanInvitationResponse, (void*) &invitationResponse);
      return invitationResponse;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClanInvitationResponse, (void*) &value);
    }
  }

  public static unsafe int EventId_ClanInvitationResult
  {
    get
    {
      int invitationResult;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClanInvitationResult, (void*) &invitationResult);
      return invitationResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClanInvitationResult, (void*) &value);
    }
  }

  public static unsafe int EventId_ClanInviteResponse
  {
    get
    {
      int clanInviteResponse;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClanInviteResponse, (void*) &clanInviteResponse);
      return clanInviteResponse;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClanInviteResponse, (void*) &value);
    }
  }

  public static unsafe int EventId_ClientActionResponseEvent
  {
    get
    {
      int actionResponseEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClientActionResponseEvent, (void*) &actionResponseEvent);
      return actionResponseEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClientActionResponseEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ClientEvent
  {
    get
    {
      int eventIdClientEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClientEvent, (void*) &eventIdClientEvent);
      return eventIdClientEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClientEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ClientStateEvent
  {
    get
    {
      int clientStateEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClientStateEvent, (void*) &clientStateEvent);
      return clientStateEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ClientStateEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CollectChargedItemsEvent
  {
    get
    {
      int chargedItemsEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CollectChargedItemsEvent, (void*) &chargedItemsEvent);
      return chargedItemsEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CollectChargedItemsEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CompleteAllAchievementsEvent
  {
    get
    {
      int achievementsEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CompleteAllAchievementsEvent, (void*) &achievementsEvent);
      return achievementsEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CompleteAllAchievementsEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CompleteCraftJewelEvent
  {
    get
    {
      int completeCraftJewelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CompleteCraftJewelEvent, (void*) &completeCraftJewelEvent);
      return completeCraftJewelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CompleteCraftJewelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CompleteCurrentAchievementAdminEvent
  {
    get
    {
      int achievementAdminEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CompleteCurrentAchievementAdminEvent, (void*) &achievementAdminEvent);
      return achievementAdminEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CompleteCurrentAchievementAdminEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CompleteJournalDebugEvent
  {
    get
    {
      int journalDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CompleteJournalDebugEvent, (void*) &journalDebugEvent);
      return journalDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CompleteJournalDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ConsumeBloodDebugEvent
  {
    get
    {
      int consumeBloodDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ConsumeBloodDebugEvent, (void*) &consumeBloodDebugEvent);
      return consumeBloodDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ConsumeBloodDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ControlDebugEvent
  {
    get
    {
      int controlDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ControlDebugEvent, (void*) &controlDebugEvent);
      return controlDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ControlDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CrashDebugEvent
  {
    get
    {
      int idCrashDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CrashDebugEvent, (void*) &idCrashDebugEvent);
      return idCrashDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CrashDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CreateCharacterEvent
  {
    get
    {
      int createCharacterEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateCharacterEvent, (void*) &createCharacterEvent);
      return createCharacterEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateCharacterEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CreateCharacterResponseEvent
  {
    get
    {
      int characterResponseEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateCharacterResponseEvent, (void*) &characterResponseEvent);
      return characterResponseEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateCharacterResponseEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CreateClan_Request
  {
    get
    {
      int createClanRequest;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateClan_Request, (void*) &createClanRequest);
      return createClanRequest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateClan_Request, (void*) &value);
    }
  }

  public static unsafe int EventId_CreateClan_Response
  {
    get
    {
      int createClanResponse;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateClan_Response, (void*) &createClanResponse);
      return createClanResponse;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateClan_Response, (void*) &value);
    }
  }

  public static unsafe int EventId_CreateJewelDebugEvent
  {
    get
    {
      int createJewelDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateJewelDebugEvent, (void*) &createJewelDebugEvent);
      return createJewelDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CreateJewelDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CustomizationDebugEvent
  {
    get
    {
      int customizationDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CustomizationDebugEvent, (void*) &customizationDebugEvent);
      return customizationDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CustomizationDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_CustomizeCharacterEvent
  {
    get
    {
      int customizeCharacterEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_CustomizeCharacterEvent, (void*) &customizeCharacterEvent);
      return customizeCharacterEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_CustomizeCharacterEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DeauthAdminEvent
  {
    get
    {
      int deauthAdminEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DeauthAdminEvent, (void*) &deauthAdminEvent);
      return deauthAdminEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DeauthAdminEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DebugTeleportToEntityEvent
  {
    get
    {
      int teleportToEntityEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DebugTeleportToEntityEvent, (void*) &teleportToEntityEvent);
      return teleportToEntityEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DebugTeleportToEntityEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DebugTeleportToNetherEvent
  {
    get
    {
      int teleportToNetherEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DebugTeleportToNetherEvent, (void*) &teleportToNetherEvent);
      return teleportToNetherEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DebugTeleportToNetherEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DecayEvent
  {
    get
    {
      int eventIdDecayEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DecayEvent, (void*) &eventIdDecayEvent);
      return eventIdDecayEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DecayEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DeleteMapMarkerEvent
  {
    get
    {
      int deleteMapMarkerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DeleteMapMarkerEvent, (void*) &deleteMapMarkerEvent);
      return deleteMapMarkerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DeleteMapMarkerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DestroyDeadDebugEvent
  {
    get
    {
      int destroyDeadDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DestroyDeadDebugEvent, (void*) &destroyDeadDebugEvent);
      return destroyDeadDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DestroyDeadDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DestroyDebugEvent
  {
    get
    {
      int destroyDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DestroyDebugEvent, (void*) &destroyDebugEvent);
      return destroyDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DestroyDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DestroyPylonEvent
  {
    get
    {
      int destroyPylonEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DestroyPylonEvent, (void*) &destroyPylonEvent);
      return destroyPylonEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DestroyPylonEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DiscoveredMapZonesEvent
  {
    get
    {
      int discoveredMapZonesEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DiscoveredMapZonesEvent, (void*) &discoveredMapZonesEvent);
      return discoveredMapZonesEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DiscoveredMapZonesEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DiscoverResearchEvent
  {
    get
    {
      int discoverResearchEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DiscoverResearchEvent, (void*) &discoverResearchEvent);
      return discoverResearchEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DiscoverResearchEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DismantleTileModelEvent
  {
    get
    {
      int dismantleTileModelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DismantleTileModelEvent, (void*) &dismantleTileModelEvent);
      return dismantleTileModelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DismantleTileModelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DropEquippedItemEvent
  {
    get
    {
      int equippedItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DropEquippedItemEvent, (void*) &equippedItemEvent);
      return equippedItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DropEquippedItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DropInventoryItemEvent
  {
    get
    {
      int inventoryItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DropInventoryItemEvent, (void*) &inventoryItemEvent);
      return inventoryItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DropInventoryItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_DropItemAtSlotEvent
  {
    get
    {
      int dropItemAtSlotEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_DropItemAtSlotEvent, (void*) &dropItemAtSlotEvent);
      return dropItemAtSlotEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_DropItemAtSlotEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EditClan
  {
    get
    {
      int eventIdEditClan;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EditClan, (void*) &eventIdEditClan);
      return eventIdEditClan;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EditClan, (void*) &value);
    }
  }

  public static unsafe int EventId_EnterShapeshiftEvent
  {
    get
    {
      int enterShapeshiftEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EnterShapeshiftEvent, (void*) &enterShapeshiftEvent);
      return enterShapeshiftEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EnterShapeshiftEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipBagEvent
  {
    get
    {
      int eventIdEquipBagEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipBagEvent, (void*) &eventIdEquipBagEvent);
      return eventIdEquipBagEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipBagEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipBagFromInventoryEvent
  {
    get
    {
      int fromInventoryEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipBagFromInventoryEvent, (void*) &fromInventoryEvent);
      return fromInventoryEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipBagFromInventoryEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipItemEvent
  {
    get
    {
      int idEquipItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipItemEvent, (void*) &idEquipItemEvent);
      return idEquipItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipItemFromInventoryEvent
  {
    get
    {
      int fromInventoryEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipItemFromInventoryEvent, (void*) &fromInventoryEvent);
      return fromInventoryEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipItemFromInventoryEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipJewelEvent
  {
    get
    {
      int idEquipJewelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipJewelEvent, (void*) &idEquipJewelEvent);
      return idEquipJewelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipJewelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipmentToEquipmentTransferEvent
  {
    get
    {
      int equipmentTransferEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipmentToEquipmentTransferEvent, (void*) &equipmentTransferEvent);
      return equipmentTransferEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipmentToEquipmentTransferEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipSaddleEvent
  {
    get
    {
      int equipSaddleEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipSaddleEvent, (void*) &equipSaddleEvent);
      return equipSaddleEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipSaddleEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipServantItemEvent
  {
    get
    {
      int servantItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipServantItemEvent, (void*) &servantItemEvent);
      return servantItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipServantItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_EquipServantItemFromInventoryEvent
  {
    get
    {
      int fromInventoryEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipServantItemFromInventoryEvent, (void*) &fromInventoryEvent);
      return fromInventoryEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_EquipServantItemFromInventoryEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ErrorResponse
  {
    get
    {
      int eventIdErrorResponse;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ErrorResponse, (void*) &eventIdErrorResponse);
      return eventIdErrorResponse;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ErrorResponse, (void*) &value);
    }
  }

  public static unsafe int EventId_ForceClaimAchievement_Debug
  {
    get
    {
      int achievementDebug;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ForceClaimAchievement_Debug, (void*) &achievementDebug);
      return achievementDebug;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ForceClaimAchievement_Debug, (void*) &value);
    }
  }

  public static unsafe int EventId_ForfeitCastleHeartEvent
  {
    get
    {
      int castleHeartEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ForfeitCastleHeartEvent, (void*) &castleHeartEvent);
      return castleHeartEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ForfeitCastleHeartEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_FullUserInfoSyncEvent
  {
    get
    {
      int userInfoSyncEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_FullUserInfoSyncEvent, (void*) &userInfoSyncEvent);
      return userInfoSyncEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_FullUserInfoSyncEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GenerateJewelAtUnitLevelDebugEvent
  {
    get
    {
      int unitLevelDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GenerateJewelAtUnitLevelDebugEvent, (void*) &unitLevelDebugEvent);
      return unitLevelDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GenerateJewelAtUnitLevelDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GenerateJewelDebugEvent
  {
    get
    {
      int generateJewelDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GenerateJewelDebugEvent, (void*) &generateJewelDebugEvent);
      return generateJewelDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GenerateJewelDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GenerateLegendaryWeaponDebugEvent
  {
    get
    {
      int weaponDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GenerateLegendaryWeaponDebugEvent, (void*) &weaponDebugEvent);
      return weaponDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GenerateLegendaryWeaponDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GetTerritoryOwnerRequestEvent
  {
    get
    {
      int ownerRequestEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GetTerritoryOwnerRequestEvent, (void*) &ownerRequestEvent);
      return ownerRequestEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GetTerritoryOwnerRequestEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GetTerritoryOwnerResponseEvent
  {
    get
    {
      int ownerResponseEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GetTerritoryOwnerResponseEvent, (void*) &ownerResponseEvent);
      return ownerResponseEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GetTerritoryOwnerResponseEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GetVBloodPositionsEvent
  {
    get
    {
      int vbloodPositionsEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GetVBloodPositionsEvent, (void*) &vbloodPositionsEvent);
      return vbloodPositionsEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GetVBloodPositionsEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GetVBloodPositionsResponseEvent
  {
    get
    {
      int positionsResponseEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GetVBloodPositionsResponseEvent, (void*) &positionsResponseEvent);
      return positionsResponseEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GetVBloodPositionsResponseEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GiveDebugEvent
  {
    get
    {
      int idGiveDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GiveDebugEvent, (void*) &idGiveDebugEvent);
      return idGiveDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GiveDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_GiveUpReviveEvent
  {
    get
    {
      int giveUpReviveEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_GiveUpReviveEvent, (void*) &giveUpReviveEvent);
      return giveUpReviveEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_GiveUpReviveEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_HardCoreDeathEvent
  {
    get
    {
      int hardCoreDeathEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_HardCoreDeathEvent, (void*) &hardCoreDeathEvent);
      return hardCoreDeathEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_HardCoreDeathEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_InitialUnlockedProgressionEvent
  {
    get
    {
      int progressionEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_InitialUnlockedProgressionEvent, (void*) &progressionEvent);
      return progressionEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_InitialUnlockedProgressionEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_InsertItem
  {
    get
    {
      int eventIdInsertItem;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_InsertItem, (void*) &eventIdInsertItem);
      return eventIdInsertItem;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_InsertItem, (void*) &value);
    }
  }

  public static unsafe int EventId_InteractWithPrisonerEvent
  {
    get
    {
      int withPrisonerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_InteractWithPrisonerEvent, (void*) &withPrisonerEvent);
      return withPrisonerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_InteractWithPrisonerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_InvitePlayerToClan
  {
    get
    {
      int invitePlayerToClan;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_InvitePlayerToClan, (void*) &invitePlayerToClan);
      return invitePlayerToClan;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_InvitePlayerToClan, (void*) &value);
    }
  }

  public static unsafe int EventId_JewelEquippedResponseEvent
  {
    get
    {
      int equippedResponseEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_JewelEquippedResponseEvent, (void*) &equippedResponseEvent);
      return equippedResponseEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_JewelEquippedResponseEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_JumpToNextBloodMoonEvent
  {
    get
    {
      int nextBloodMoonEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_JumpToNextBloodMoonEvent, (void*) &nextBloodMoonEvent);
      return nextBloodMoonEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_JumpToNextBloodMoonEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_Kick_Request
  {
    get
    {
      int eventIdKickRequest;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_Kick_Request, (void*) &eventIdKickRequest);
      return eventIdKickRequest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_Kick_Request, (void*) &value);
    }
  }

  public static unsafe int EventId_KickedEvent
  {
    get
    {
      int eventIdKickedEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_KickedEvent, (void*) &eventIdKickedEvent);
      return eventIdKickedEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_KickedEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_KickEvent
  {
    get
    {
      int eventIdKickEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_KickEvent, (void*) &eventIdKickEvent);
      return eventIdKickEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_KickEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_KillEvent
  {
    get
    {
      int eventIdKillEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_KillEvent, (void*) &eventIdKillEvent);
      return eventIdKillEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_KillEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_LatencyDebugEvent
  {
    get
    {
      int latencyDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_LatencyDebugEvent, (void*) &latencyDebugEvent);
      return latencyDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_LatencyDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_LeaveClan
  {
    get
    {
      int eventIdLeaveClan;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_LeaveClan, (void*) &eventIdLeaveClan);
      return eventIdLeaveClan;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_LeaveClan, (void*) &value);
    }
  }

  public static unsafe int EventId_LeaveClanResultResponse
  {
    get
    {
      int clanResultResponse;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_LeaveClanResultResponse, (void*) &clanResultResponse);
      return clanResultResponse;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_LeaveClanResultResponse, (void*) &value);
    }
  }

  public static unsafe int EventId_MapZoneDiscoveredEvent
  {
    get
    {
      int zoneDiscoveredEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_MapZoneDiscoveredEvent, (void*) &zoneDiscoveredEvent);
      return zoneDiscoveredEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_MapZoneDiscoveredEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_MemberConnectionChangedEvent
  {
    get
    {
      int connectionChangedEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_MemberConnectionChangedEvent, (void*) &connectionChangedEvent);
      return connectionChangedEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_MemberConnectionChangedEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_MoveAllItemsBetweenInventoriesEvent
  {
    get
    {
      int inventoriesEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_MoveAllItemsBetweenInventoriesEvent, (void*) &inventoriesEvent);
      return inventoriesEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_MoveAllItemsBetweenInventoriesEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_MoveAllItemsBetweenInventoriesEventV2
  {
    get
    {
      int inventoriesEventV2;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_MoveAllItemsBetweenInventoriesEventV2, (void*) &inventoriesEventV2);
      return inventoriesEventV2;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_MoveAllItemsBetweenInventoriesEventV2, (void*) &value);
    }
  }

  public static unsafe int EventId_MoveItemBetweenInventoriesEvent
  {
    get
    {
      int inventoriesEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_MoveItemBetweenInventoriesEvent, (void*) &inventoriesEvent);
      return inventoriesEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_MoveItemBetweenInventoriesEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_MoveTileModelEvent
  {
    get
    {
      int moveTileModelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_MoveTileModelEvent, (void*) &moveTileModelEvent);
      return moveTileModelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_MoveTileModelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_NewSiegeWeapon
  {
    get
    {
      int idNewSiegeWeapon;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_NewSiegeWeapon, (void*) &idNewSiegeWeapon);
      return idNewSiegeWeapon;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_NewSiegeWeapon, (void*) &value);
    }
  }

  public static unsafe int EventId_OpenVBloodMenuEvent
  {
    get
    {
      int openVbloodMenuEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_OpenVBloodMenuEvent, (void*) &openVbloodMenuEvent);
      return openVbloodMenuEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_OpenVBloodMenuEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_OverrideVampireAttackPowerDebugEvent
  {
    get
    {
      int attackPowerDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_OverrideVampireAttackPowerDebugEvent, (void*) &attackPowerDebugEvent);
      return attackPowerDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_OverrideVampireAttackPowerDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_PlayerTeleportDebugEvent
  {
    get
    {
      int teleportDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_PlayerTeleportDebugEvent, (void*) &teleportDebugEvent);
      return teleportDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_PlayerTeleportDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_PvPToggleEvent
  {
    get
    {
      int idPvPtoggleEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_PvPToggleEvent, (void*) &idPvPtoggleEvent);
      return idPvPtoggleEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_PvPToggleEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RandomizeCustomization2DebugEvent
  {
    get
    {
      int customization2DebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RandomizeCustomization2DebugEvent, (void*) &customization2DebugEvent);
      return customization2DebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RandomizeCustomization2DebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RandomizeCustomizationDebugEvent
  {
    get
    {
      int customizationDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RandomizeCustomizationDebugEvent, (void*) &customizationDebugEvent);
      return customizationDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RandomizeCustomizationDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RecommendedSpawnLocationRequestEvent
  {
    get
    {
      int locationRequestEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RecommendedSpawnLocationRequestEvent, (void*) &locationRequestEvent);
      return locationRequestEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RecommendedSpawnLocationRequestEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RecommendedSpawnLocationResponseEvent
  {
    get
    {
      int locationResponseEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RecommendedSpawnLocationResponseEvent, (void*) &locationResponseEvent);
      return locationResponseEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RecommendedSpawnLocationResponseEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RegisterCharacterNameEvent
  {
    get
    {
      int characterNameEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RegisterCharacterNameEvent, (void*) &characterNameEvent);
      return characterNameEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RegisterCharacterNameEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RemoveItem
  {
    get
    {
      int eventIdRemoveItem;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RemoveItem, (void*) &eventIdRemoveItem);
      return eventIdRemoveItem;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RemoveItem, (void*) &value);
    }
  }

  public static unsafe int EventId_RemovePvPProtectionEvent
  {
    get
    {
      int pprotectionEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RemovePvPProtectionEvent, (void*) &pprotectionEvent);
      return pprotectionEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RemovePvPProtectionEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RenameInteractable
  {
    get
    {
      int renameInteractable;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RenameInteractable, (void*) &renameInteractable);
      return renameInteractable;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RenameInteractable, (void*) &value);
    }
  }

  public static unsafe int EventId_RenameUserDebugEvent
  {
    get
    {
      int renameUserDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RenameUserDebugEvent, (void*) &renameUserDebugEvent);
      return renameUserDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RenameUserDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RepairEquippedItemEvent
  {
    get
    {
      int equippedItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RepairEquippedItemEvent, (void*) &equippedItemEvent);
      return equippedItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RepairEquippedItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RepairItemEvent
  {
    get
    {
      int idRepairItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RepairItemEvent, (void*) &idRepairItemEvent);
      return idRepairItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RepairItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RepairTileModelEvent
  {
    get
    {
      int repairTileModelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RepairTileModelEvent, (void*) &repairTileModelEvent);
      return repairTileModelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RepairTileModelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_Reponse
  {
    get
    {
      int eventIdReponse;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_Reponse, (void*) &eventIdReponse);
      return eventIdReponse;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_Reponse, (void*) &value);
    }
  }

  public static unsafe int EventId_Request_ByClosestToPosition
  {
    get
    {
      int closestToPosition;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_Request_ByClosestToPosition, (void*) &closestToPosition);
      return closestToPosition;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_Request_ByClosestToPosition, (void*) &value);
    }
  }

  public static unsafe int EventId_Request_ByPlayerName
  {
    get
    {
      int requestByPlayerName;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_Request_ByPlayerName, (void*) &requestByPlayerName);
      return requestByPlayerName;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_Request_ByPlayerName, (void*) &value);
    }
  }

  public static unsafe int EventId_Request0
  {
    get
    {
      int eventIdRequest0;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_Request0, (void*) &eventIdRequest0);
      return eventIdRequest0;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_Request0, (void*) &value);
    }
  }

  public static unsafe int EventId_ResetBuffAgeServerEvent
  {
    get
    {
      int buffAgeServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ResetBuffAgeServerEvent, (void*) &buffAgeServerEvent);
      return buffAgeServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ResetBuffAgeServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ResetCooldownsDebugEvent
  {
    get
    {
      int cooldownsDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ResetCooldownsDebugEvent, (void*) &cooldownsDebugEvent);
      return cooldownsDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ResetCooldownsDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ResetScheduleNotificationEvent
  {
    get
    {
      int notificationEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ResetScheduleNotificationEvent, (void*) &notificationEvent);
      return notificationEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ResetScheduleNotificationEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ResetServerLogsEvent
  {
    get
    {
      int resetServerLogsEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ResetServerLogsEvent, (void*) &resetServerLogsEvent);
      return resetServerLogsEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ResetServerLogsEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RespawnAiDebugEvent
  {
    get
    {
      int respawnAiDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RespawnAiDebugEvent, (void*) &respawnAiDebugEvent);
      return respawnAiDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RespawnAiDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RestorStationEvent
  {
    get
    {
      int restorStationEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RestorStationEvent, (void*) &restorStationEvent);
      return restorStationEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RestorStationEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RevealedMapEvent
  {
    get
    {
      int revealedMapEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RevealedMapEvent, (void*) &revealedMapEvent);
      return revealedMapEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RevealedMapEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RoleChangedEvent
  {
    get
    {
      int roleChangedEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RoleChangedEvent, (void*) &roleChangedEvent);
      return roleChangedEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RoleChangedEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_RunConsoleCommandDebugEvent
  {
    get
    {
      int commandDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_RunConsoleCommandDebugEvent, (void*) &commandDebugEvent);
      return commandDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_RunConsoleCommandDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ScrambleGameModeDataEvent
  {
    get
    {
      int gameModeDataEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ScrambleGameModeDataEvent, (void*) &gameModeDataEvent);
      return gameModeDataEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ScrambleGameModeDataEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SendOnMissionEvent
  {
    get
    {
      int sendOnMissionEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SendOnMissionEvent, (void*) &sendOnMissionEvent);
      return sendOnMissionEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SendOnMissionEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SerializePersistenceFailedFeedbackEvent
  {
    get
    {
      int failedFeedbackEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SerializePersistenceFailedFeedbackEvent, (void*) &failedFeedbackEvent);
      return failedFeedbackEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SerializePersistenceFailedFeedbackEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ServantCoffinActionEvent
  {
    get
    {
      int coffinActionEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServantCoffinActionEvent, (void*) &coffinActionEvent);
      return coffinActionEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServantCoffinActionEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ServantMissionFinishedEvent
  {
    get
    {
      int missionFinishedEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServantMissionFinishedEvent, (void*) &missionFinishedEvent);
      return missionFinishedEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServantMissionFinishedEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ServantMissionStartedEvent
  {
    get
    {
      int missionStartedEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServantMissionStartedEvent, (void*) &missionStartedEvent);
      return missionStartedEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServantMissionStartedEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ServerChannelEvent
  {
    get
    {
      int serverChannelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerChannelEvent, (void*) &serverChannelEvent);
      return serverChannelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerChannelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ServerDebugErrorEvent
  {
    get
    {
      int serverDebugErrorEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerDebugErrorEvent, (void*) &serverDebugErrorEvent);
      return serverDebugErrorEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerDebugErrorEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ServerIsRestartingServerEvent
  {
    get
    {
      int restartingServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerIsRestartingServerEvent, (void*) &restartingServerEvent);
      return restartingServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerIsRestartingServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ServerLoginEvent
  {
    get
    {
      int serverLoginEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerLoginEvent, (void*) &serverLoginEvent);
      return serverLoginEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerLoginEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ServerRejectEvent
  {
    get
    {
      int serverRejectEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerRejectEvent, (void*) &serverRejectEvent);
      return serverRejectEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ServerRejectEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetAdminOnlyDebugEventsAdminEvent
  {
    get
    {
      int eventsAdminEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetAdminOnlyDebugEventsAdminEvent, (void*) &eventsAdminEvent);
      return eventsAdminEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetAdminOnlyDebugEventsAdminEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetCloudinessDebugEvent
  {
    get
    {
      int cloudinessDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetCloudinessDebugEvent, (void*) &cloudinessDebugEvent);
      return cloudinessDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetCloudinessDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetControlMoveSpeedDebugEvent
  {
    get
    {
      int moveSpeedDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetControlMoveSpeedDebugEvent, (void*) &moveSpeedDebugEvent);
      return moveSpeedDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetControlMoveSpeedDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetDebugSettingEvent
  {
    get
    {
      int debugSettingEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetDebugSettingEvent, (void*) &debugSettingEvent);
      return debugSettingEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetDebugSettingEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetMapMarkerEvent
  {
    get
    {
      int setMapMarkerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetMapMarkerEvent, (void*) &setMapMarkerEvent);
      return setMapMarkerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetMapMarkerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetMovementSpeedDebugEvent
  {
    get
    {
      int movementSpeedDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetMovementSpeedDebugEvent, (void*) &movementSpeedDebugEvent);
      return movementSpeedDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetMovementSpeedDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetPlayerTeamDebugEvent
  {
    get
    {
      int playerTeamDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetPlayerTeamDebugEvent, (void*) &playerTeamDebugEvent);
      return playerTeamDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetPlayerTeamDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetTileModelVariationEvent
  {
    get
    {
      int modelVariationEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetTileModelVariationEvent, (void*) &modelVariationEvent);
      return modelVariationEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetTileModelVariationEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetTimeOfDayEvent
  {
    get
    {
      int setTimeOfDayEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetTimeOfDayEvent, (void*) &setTimeOfDayEvent);
      return setTimeOfDayEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetTimeOfDayEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetTimeScaleDebugEvent
  {
    get
    {
      int timeScaleDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetTimeScaleDebugEvent, (void*) &timeScaleDebugEvent);
      return timeScaleDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetTimeScaleDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetUserAdminLevelAdminEvent
  {
    get
    {
      int adminLevelAdminEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetUserAdminLevelAdminEvent, (void*) &adminLevelAdminEvent);
      return adminLevelAdminEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetUserAdminLevelAdminEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SetUserContentDebugEvent
  {
    get
    {
      int contentDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetUserContentDebugEvent, (void*) &contentDebugEvent);
      return contentDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SetUserContentDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ShareRefinementEvent
  {
    get
    {
      int shareRefinementEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ShareRefinementEvent, (void*) &shareRefinementEvent);
      return shareRefinementEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ShareRefinementEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ShareUnitspawnerRecipesEvent
  {
    get
    {
      int unitspawnerRecipesEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ShareUnitspawnerRecipesEvent, (void*) &unitspawnerRecipesEvent);
      return unitspawnerRecipesEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ShareUnitspawnerRecipesEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ShareVBloodEvent
  {
    get
    {
      int shareVbloodEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ShareVBloodEvent, (void*) &shareVbloodEvent);
      return shareVbloodEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ShareVBloodEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SmartMergeItemsBetweenInventoriesEvent
  {
    get
    {
      int inventoriesEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SmartMergeItemsBetweenInventoriesEvent, (void*) &inventoriesEvent);
      return inventoriesEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SmartMergeItemsBetweenInventoriesEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SortAllInventoriesEvent
  {
    get
    {
      int inventoriesEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SortAllInventoriesEvent, (void*) &inventoriesEvent);
      return inventoriesEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SortAllInventoriesEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SortSingleInventoryEvent
  {
    get
    {
      int singleInventoryEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SortSingleInventoryEvent, (void*) &singleInventoryEvent);
      return singleInventoryEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SortSingleInventoryEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SpawnCharmeableDebugEvent
  {
    get
    {
      int charmeableDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SpawnCharmeableDebugEvent, (void*) &charmeableDebugEvent);
      return charmeableDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SpawnCharmeableDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SpawnDebugEvent
  {
    get
    {
      int idSpawnDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SpawnDebugEvent, (void*) &idSpawnDebugEvent);
      return idSpawnDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SpawnDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SpawnUnitEvent
  {
    get
    {
      int idSpawnUnitEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SpawnUnitEvent, (void*) &idSpawnUnitEvent);
      return idSpawnUnitEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SpawnUnitEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SpellModSetAckEvent
  {
    get
    {
      int spellModSetAckEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SpellModSetAckEvent, (void*) &spellModSetAckEvent);
      return spellModSetAckEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SpellModSetAckEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SplitItemEvent
  {
    get
    {
      int idSplitItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SplitItemEvent, (void*) &idSplitItemEvent);
      return idSplitItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SplitItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StartCharacterCraftItemEvent
  {
    get
    {
      int characterCraftItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartCharacterCraftItemEvent, (void*) &characterCraftItemEvent);
      return characterCraftItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartCharacterCraftItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StartChargeItemEvent
  {
    get
    {
      int startChargeItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartChargeItemEvent, (void*) &startChargeItemEvent);
      return startChargeItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartChargeItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StartCraftItemEvent
  {
    get
    {
      int startCraftItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartCraftItemEvent, (void*) &startCraftItemEvent);
      return startCraftItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartCraftItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StartCraftJewelEvent
  {
    get
    {
      int startCraftJewelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartCraftJewelEvent, (void*) &startCraftJewelEvent);
      return startCraftJewelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartCraftJewelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StartEditTileModelEvent
  {
    get
    {
      int editTileModelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartEditTileModelEvent, (void*) &editTileModelEvent);
      return editTileModelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartEditTileModelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StartRepair
  {
    get
    {
      int eventIdStartRepair;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartRepair, (void*) &eventIdStartRepair);
      return eventIdStartRepair;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartRepair, (void*) &value);
    }
  }

  public static unsafe int EventId_StartTrackVBloodUnitEvent
  {
    get
    {
      int trackVbloodUnitEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartTrackVBloodUnitEvent, (void*) &trackVbloodUnitEvent);
      return trackVbloodUnitEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartTrackVBloodUnitEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StartTrackVBloodUnitEventV2
  {
    get
    {
      int vbloodUnitEventV2;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartTrackVBloodUnitEventV2, (void*) &vbloodUnitEventV2);
      return vbloodUnitEventV2;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StartTrackVBloodUnitEventV2, (void*) &value);
    }
  }

  public static unsafe int EventId_StopCharacterCraftItemEvent
  {
    get
    {
      int characterCraftItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopCharacterCraftItemEvent, (void*) &characterCraftItemEvent);
      return characterCraftItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopCharacterCraftItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StopCraftItemEvent
  {
    get
    {
      int stopCraftItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopCraftItemEvent, (void*) &stopCraftItemEvent);
      return stopCraftItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopCraftItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StopCraftJewelEvent
  {
    get
    {
      int stopCraftJewelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopCraftJewelEvent, (void*) &stopCraftJewelEvent);
      return stopCraftJewelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopCraftJewelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StopInteractingWithObjectEvent
  {
    get
    {
      int interactingWithObjectEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopInteractingWithObjectEvent, (void*) &interactingWithObjectEvent);
      return interactingWithObjectEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopInteractingWithObjectEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_StopTrackVBloodUnitEvent
  {
    get
    {
      int trackVbloodUnitEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopTrackVBloodUnitEvent, (void*) &trackVbloodUnitEvent);
      return trackVbloodUnitEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_StopTrackVBloodUnitEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_SwapBagSlotsEvent
  {
    get
    {
      int swapBagSlotsEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_SwapBagSlotsEvent, (void*) &swapBagSlotsEvent);
      return swapBagSlotsEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_SwapBagSlotsEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_TeleportDebugEvent
  {
    get
    {
      int teleportDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportDebugEvent, (void*) &teleportDebugEvent);
      return teleportDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_TeleportPlayerToLocationDebugEvent
  {
    get
    {
      int locationDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportPlayerToLocationDebugEvent, (void*) &locationDebugEvent);
      return locationDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportPlayerToLocationDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_TeleportToNetherEvent
  {
    get
    {
      int teleportToNetherEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToNetherEvent, (void*) &teleportToNetherEvent);
      return teleportToNetherEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToNetherEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_TeleportToPlayerLocationDebugEvent
  {
    get
    {
      int locationDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToPlayerLocationDebugEvent, (void*) &locationDebugEvent);
      return locationDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToPlayerLocationDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_TeleportToWaypointEvent
  {
    get
    {
      int teleportToWaypointEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToWaypointEvent, (void*) &teleportToWaypointEvent);
      return teleportToWaypointEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_TeleportToWaypointEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ToggleInvulnerableEvent
  {
    get
    {
      int invulnerableEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ToggleInvulnerableEvent, (void*) &invulnerableEvent);
      return invulnerableEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ToggleInvulnerableEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ToggleRefiningEvent
  {
    get
    {
      int toggleRefiningEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ToggleRefiningEvent, (void*) &toggleRefiningEvent);
      return toggleRefiningEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ToggleRefiningEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ToggleSalvageEvent
  {
    get
    {
      int toggleSalvageEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ToggleSalvageEvent, (void*) &toggleSalvageEvent);
      return toggleSalvageEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ToggleSalvageEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_ToggleUserPermissionsEvent
  {
    get
    {
      int permissionsEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_ToggleUserPermissionsEvent, (void*) &permissionsEvent);
      return permissionsEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_ToggleUserPermissionsEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_TrackVBloodDebugEvent
  {
    get
    {
      int vbloodDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_TrackVBloodDebugEvent, (void*) &vbloodDebugEvent);
      return vbloodDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_TrackVBloodDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_TraderPurchaseEvent
  {
    get
    {
      int traderPurchaseEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_TraderPurchaseEvent, (void*) &traderPurchaseEvent);
      return traderPurchaseEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_TraderPurchaseEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_TryInsertBloodEvent
  {
    get
    {
      int insertBloodEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_TryInsertBloodEvent, (void*) &insertBloodEvent);
      return insertBloodEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_TryInsertBloodEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnequipBagEvent
  {
    get
    {
      int idUnequipBagEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipBagEvent, (void*) &idUnequipBagEvent);
      return idUnequipBagEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipBagEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnequipBagIntoInventoryEvent
  {
    get
    {
      int intoInventoryEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipBagIntoInventoryEvent, (void*) &intoInventoryEvent);
      return intoInventoryEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipBagIntoInventoryEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnequipItemEvent
  {
    get
    {
      int unequipItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipItemEvent, (void*) &unequipItemEvent);
      return unequipItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnequipJewelEvent
  {
    get
    {
      int unequipJewelEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipJewelEvent, (void*) &unequipJewelEvent);
      return unequipJewelEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipJewelEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnequipSaddleEvent
  {
    get
    {
      int unequipSaddleEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipSaddleEvent, (void*) &unequipSaddleEvent);
      return unequipSaddleEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipSaddleEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnequipServantItemEvent
  {
    get
    {
      int servantItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipServantItemEvent, (void*) &servantItemEvent);
      return servantItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnequipServantItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnlockAllVBloodAbilities
  {
    get
    {
      int allVbloodAbilities;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodAbilities, (void*) &allVbloodAbilities);
      return allVbloodAbilities;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodAbilities, (void*) &value);
    }
  }

  public static unsafe int EventId_UnlockAllVBloodPassives
  {
    get
    {
      int allVbloodPassives;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodPassives, (void*) &allVbloodPassives);
      return allVbloodPassives;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodPassives, (void*) &value);
    }
  }

  public static unsafe int EventId_UnlockAllVBloodShapeshifts
  {
    get
    {
      int vbloodShapeshifts;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodShapeshifts, (void*) &vbloodShapeshifts);
      return vbloodShapeshifts;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockAllVBloodShapeshifts, (void*) &value);
    }
  }

  public static unsafe int EventId_UnlockProgressionServerEvent
  {
    get
    {
      int progressionServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockProgressionServerEvent, (void*) &progressionServerEvent);
      return progressionServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockProgressionServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnlockRegionDebugEvent
  {
    get
    {
      int regionDebugEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockRegionDebugEvent, (void*) &regionDebugEvent);
      return regionDebugEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockRegionDebugEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UnlockResearchEvent
  {
    get
    {
      int unlockResearchEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockResearchEvent, (void*) &unlockResearchEvent);
      return unlockResearchEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UnlockResearchEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UpgradePylonEvent
  {
    get
    {
      int upgradePylonEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UpgradePylonEvent, (void*) &upgradePylonEvent);
      return upgradePylonEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UpgradePylonEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UseDefaultActionEvent
  {
    get
    {
      int defaultActionEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UseDefaultActionEvent, (void*) &defaultActionEvent);
      return defaultActionEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UseDefaultActionEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UseEmoteEvent
  {
    get
    {
      int eventIdUseEmoteEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UseEmoteEvent, (void*) &eventIdUseEmoteEvent);
      return eventIdUseEmoteEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UseEmoteEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UseItemEvent
  {
    get
    {
      int eventIdUseItemEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UseItemEvent, (void*) &eventIdUseItemEvent);
      return eventIdUseItemEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UseItemEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UserConnectedServerEvent
  {
    get
    {
      int connectedServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserConnectedServerEvent, (void*) &connectedServerEvent);
      return connectedServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserConnectedServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UserDisconnectedServerEvent
  {
    get
    {
      int disconnectedServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserDisconnectedServerEvent, (void*) &disconnectedServerEvent);
      return disconnectedServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserDisconnectedServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UserDownedServerEvent
  {
    get
    {
      int downedServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserDownedServerEvent, (void*) &downedServerEvent);
      return downedServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserDownedServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UserInfoServerEvent
  {
    get
    {
      int userInfoServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserInfoServerEvent, (void*) &userInfoServerEvent);
      return userInfoServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserInfoServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_UserKillServerEvent
  {
    get
    {
      int userKillServerEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserKillServerEvent, (void*) &userKillServerEvent);
      return userKillServerEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_UserKillServerEvent, (void*) &value);
    }
  }

  public static unsafe int EventId_WarningForBeingAFKEvent
  {
    get
    {
      int forBeingAfkEvent;
      IL2CPP.il2cpp_field_static_get_value(NetworkEvents.NativeFieldInfoPtr_EventId_WarningForBeingAFKEvent, (void*) &forBeingAfkEvent);
      return forBeingAfkEvent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NetworkEvents.NativeFieldInfoPtr_EventId_WarningForBeingAFKEvent, (void*) &value);
    }
  }

  private sealed class MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_0, Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityManager_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_0, Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_byref_User_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_byref_User_0, Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityManager_T_byref_User_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_byref_User_0, Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityCommandBuffer_T_Int32_0, Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SendEvent_Public_Static_Entity_EntityManager_T_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents.NativeMethodInfoPtr_SendEvent_Public_Static_Entity_EntityManager_T_Int32_0, Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetNetworkEventType_Public_Static_NetworkEventType_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents.NativeMethodInfoPtr_GetNetworkEventType_Public_Static_NetworkEventType_0, Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetEventId_Private_Static_Void_byref_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents.NativeMethodInfoPtr_GetEventId_Private_Static_Void_byref_Int32_0, Il2CppClassPointerStore<NetworkEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
