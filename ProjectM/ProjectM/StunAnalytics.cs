// Decompiled with JetBrains decompiler
// Type: ProjectM.StunAnalytics
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class StunAnalytics : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PROGRESSION_UNLOCKED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ACHIEVEMENT_UNLOCKED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_KILLED_VBLOOD_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BUILDING_PLACED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ABILITY_CAST_FINISHED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ABILITY_CAST_INTERRUPTED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_UI_CLICK_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_DOWNED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CONNECTED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_DISCONNECTED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CASTLE_INFO_ON_DISCONNECT_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_STATUS_CHANGED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CHAT_MESSAGE_SENT_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CHUNK_IDENTIFIER_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_POS_X_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_POS_Z_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_GAME_MODE_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_GEAR_LEVEL_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_SIZE_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_SESSION_GUID_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PROGRESSION_NAME_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ACHIEVEMENT_NAME_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BUILDING_NAME_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_UNIT_NAME_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ABILITY_NAME_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ABILITY_GROUP_NAME_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CAST_COUNT_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BUTTON_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_UI_BUTTON_LINK_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_SOURCE_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_REASON_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_UNIQUE_WORKSTATIONS_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_HEALTH_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_TIME_TO_KILL_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_SOURCE_HEALTH_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CASTLE_HEART_LEVEL_ARG_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_TIMES_ENGAGED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBLOOD_COMBAT_TIME_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLAYERS_ENGAGED_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CHANGE_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_BLOOD_TYPE_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_BLOOD_VALUE_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_BLOOD_QUALITY_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_EQUIPMENT_ID;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Enabled_Private_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Environment_Private_Static_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OptOut_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendUnlockProgressionEvent_Public_Static_Void_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendAchievementEvent_Public_Static_Void_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendPlayerKilledVBloodEvent_Public_Static_Void_EntityManager_PrefabGUID_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendPlayerDownedEvent_Public_Static_Void_EntityManager_String_PrefabGUID_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendBuildingPlacedEvent_Public_Static_Void_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendAbilityCastFinishedEvent_Public_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendAbilityCastInterruptedEvent_Public_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendAbilityCastEvent_Private_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendUiClickEvent_Public_Static_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendConnectedEvent_Public_Static_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendDisconnectedEvent_Public_Static_Void_EntityManager_String_ClientBootstrapSystem_TerrainManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendClanStatusChangedEvent_Public_Static_Void_EntityManager_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendChatMessageSentEvent_Public_Static_Void_EntityManager_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendCastleInfoOnDisconnectEvent_Private_Static_Void_EntityManager_Entity_TerrainManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCastleHeart_Private_Static_Boolean_EntityManager_Entity_byref_Entity_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendGameplayEvent_Private_Static_Void_EntityManager_String_Dictionary_2_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendGameplayEvent_Private_Static_Void_EntityManager_String_Dictionary_2_String_Object_ClientBootstrapSystem_TerrainManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Private_Static_Void_String_Dictionary_2_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugLogEvent_Private_Static_Void_String_Dictionary_2_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBloodInfo_Private_Static_Boolean_EntityManager_Entity_byref_Single_byref_Single_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalUser_Private_Static_Boolean_EntityManager_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurrentPosition_Private_Static_Boolean_EntityManager_Entity_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_Entity_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_Entity_TerrainManager_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGameMode_Private_Static_Boolean_EntityManager_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGearLevel_Private_Static_Boolean_EntityManager_Entity_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetEquipmentInfo_Private_Static_Boolean_EntityManager_Entity_PrefabCollectionSystem_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateUniqueWorkstations_Private_Static_Int32_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClanSize_Private_Static_Int32_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkIdentifier_Private_Static_String_EntityManager_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkIdentifier_Private_Static_String_EntityManager_float2_TerrainManager_0;

    public static unsafe bool Enabled
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 975500, RefRangeEnd = 975502, XrefRangeStart = 975499, XrefRangeEnd = 975500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_get_Enabled_Private_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe string Environment
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 975503, RefRangeEnd = 975504, XrefRangeStart = 975502, XrefRangeEnd = 975503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_get_Environment_Private_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975504, XrefRangeEnd = 975509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 975514, RefRangeEnd = 975516, XrefRangeStart = 975509, XrefRangeEnd = 975514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool OptOut()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_OptOut_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975538, RefRangeEnd = 975539, XrefRangeStart = 975516, XrefRangeEnd = 975538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendUnlockProgressionEvent(
      EntityManager entityManager,
      PrefabGUID unlockID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unlockID;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendUnlockProgressionEvent_Public_Static_Void_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975561, RefRangeEnd = 975562, XrefRangeStart = 975539, XrefRangeEnd = 975561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendAchievementEvent(
      EntityManager entityManager,
      PrefabGUID achievement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &achievement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendAchievementEvent_Public_Static_Void_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975632, RefRangeEnd = 975633, XrefRangeStart = 975562, XrefRangeEnd = 975632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendPlayerKilledVBloodEvent(
      EntityManager entityManager,
      PrefabGUID unitPrefabGuid,
      float playerHealth,
      float timeToKill,
      float timesEngaged,
      float playersEngaged)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unitPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerHealth;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &timeToKill;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &timesEngaged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &playersEngaged;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendPlayerKilledVBloodEvent_Public_Static_Void_EntityManager_PrefabGUID_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975701, RefRangeEnd = 975702, XrefRangeStart = 975633, XrefRangeEnd = 975701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendPlayerDownedEvent(
      EntityManager entityManager,
      string reason,
      PrefabGUID sourcePrefabGuid,
      float sourceHealth,
      float vbloodCombatTime,
      float playersEngaged)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(reason);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sourcePrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceHealth;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &vbloodCombatTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &playersEngaged;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendPlayerDownedEvent_Public_Static_Void_EntityManager_String_PrefabGUID_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975702, XrefRangeEnd = 975724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendBuildingPlacedEvent(
      EntityManager entityManager,
      PrefabGUID buildingPrefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buildingPrefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendBuildingPlacedEvent_Public_Static_Void_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975727, RefRangeEnd = 975728, XrefRangeStart = 975724, XrefRangeEnd = 975727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendAbilityCastFinishedEvent(
      EntityManager entityManager,
      NativeHashMap<Entity, int> casts)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &casts;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendAbilityCastFinishedEvent_Public_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975731, RefRangeEnd = 975732, XrefRangeStart = 975728, XrefRangeEnd = 975731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendAbilityCastInterruptedEvent(
      EntityManager entityManager,
      NativeHashMap<Entity, int> casts)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &casts;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendAbilityCastInterruptedEvent_Public_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 975799, RefRangeEnd = 975801, XrefRangeStart = 975732, XrefRangeEnd = 975799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendAbilityCastEvent(
      EntityManager entityManager,
      NativeHashMap<Entity, int> casts,
      string eventId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &casts;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(eventId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendAbilityCastEvent_Private_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 975820, RefRangeEnd = 975822, XrefRangeStart = 975801, XrefRangeEnd = 975820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendUiClickEvent(string buttonId, string link = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(buttonId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(link);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendUiClickEvent_Public_Static_Void_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975831, RefRangeEnd = 975832, XrefRangeStart = 975822, XrefRangeEnd = 975831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendConnectedEvent(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendConnectedEvent_Public_Static_Void_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 975856, RefRangeEnd = 975858, XrefRangeStart = 975832, XrefRangeEnd = 975856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendDisconnectedEvent(
      EntityManager entityManager,
      string reason,
      ClientBootstrapSystem clientBootstrapSystem,
      TerrainManager terrainManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(reason);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientBootstrapSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) terrainManager);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendDisconnectedEvent_Public_Static_Void_EntityManager_String_ClientBootstrapSystem_TerrainManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 975873, RefRangeEnd = 975877, XrefRangeStart = 975858, XrefRangeEnd = 975873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendClanStatusChangedEvent(EntityManager entityManager, string change)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(change);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendClanStatusChangedEvent_Public_Static_Void_EntityManager_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975892, RefRangeEnd = 975893, XrefRangeStart = 975877, XrefRangeEnd = 975892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendChatMessageSentEvent(EntityManager entityManager, string type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendChatMessageSentEvent_Public_Static_Void_EntityManager_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975932, RefRangeEnd = 975933, XrefRangeStart = 975893, XrefRangeEnd = 975932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendCastleInfoOnDisconnectEvent(
      EntityManager entityManager,
      Entity localUser,
      TerrainManager terrainManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) terrainManager);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendCastleInfoOnDisconnectEvent_Private_Static_Void_EntityManager_Entity_TerrainManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975975, RefRangeEnd = 975976, XrefRangeStart = 975933, XrefRangeEnd = 975975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCastleHeart(
      EntityManager entityManager,
      Entity localUser,
      out Entity highestLvlCastle,
      out int highestHeartLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref highestLvlCastle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref highestHeartLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetCastleHeart_Private_Static_Boolean_EntityManager_Entity_byref_Entity_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 975985, RefRangeEnd = 975994, XrefRangeStart = 975976, XrefRangeEnd = 975985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendGameplayEvent(
      EntityManager entityManager,
      string name,
      Dictionary<string, Il2CppSystem.Object> args)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendGameplayEvent_Private_Static_Void_EntityManager_String_Dictionary_2_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 976066, RefRangeEnd = 976068, XrefRangeStart = 975994, XrefRangeEnd = 976066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendGameplayEvent(
      EntityManager entityManager,
      string name,
      Dictionary<string, Il2CppSystem.Object> args,
      ClientBootstrapSystem clientBootstrapSystem,
      TerrainManager terrainManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientBootstrapSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) terrainManager);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendGameplayEvent_Private_Static_Void_EntityManager_String_Dictionary_2_String_Object_ClientBootstrapSystem_TerrainManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 976082, RefRangeEnd = 976085, XrefRangeStart = 976068, XrefRangeEnd = 976082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendEvent(string name, Dictionary<string, Il2CppSystem.Object> args)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_SendEvent_Private_Static_Void_String_Dictionary_2_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976085, XrefRangeEnd = 976122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DebugLogEvent(string eventName, Dictionary<string, Il2CppSystem.Object> args)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_DebugLogEvent_Private_Static_Void_String_Dictionary_2_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 976148, RefRangeEnd = 976150, XrefRangeStart = 976122, XrefRangeEnd = 976148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBloodInfo(
      EntityManager entityManager,
      Entity localUser,
      out float bloodValue,
      out float bloodQuality,
      out string bloodType)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref bloodValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref bloodQuality;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetBloodInfo_Private_Static_Boolean_EntityManager_Entity_byref_Single_byref_Single_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      bloodType = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 976168, RefRangeEnd = 976173, XrefRangeStart = 976150, XrefRangeEnd = 976168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetLocalUser(EntityManager entityManager, out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetLocalUser_Private_Static_Boolean_EntityManager_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976173, XrefRangeEnd = 976176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCurrentPosition(
      EntityManager entityManager,
      Entity localUser,
      out float2 result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetCurrentPosition_Private_Static_Boolean_EntityManager_Entity_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976176, XrefRangeEnd = 976185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCurrentChunkIdentifier(
      EntityManager entityManager,
      Entity localUser,
      out string result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_Entity_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      result = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 976192, RefRangeEnd = 976194, XrefRangeStart = 976185, XrefRangeEnd = 976192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCurrentChunkIdentifier(
      EntityManager entityManager,
      Entity entity,
      TerrainManager terrainManager,
      out string result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) terrainManager);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_Entity_TerrainManager_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      result = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976194, XrefRangeEnd = 976204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCurrentChunkIdentifier(
      EntityManager entityManager,
      out string result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &entityManager;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      result = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976231, RefRangeEnd = 976232, XrefRangeStart = 976204, XrefRangeEnd = 976231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetGameMode(EntityManager entityManager, out string result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &entityManager;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetGameMode_Private_Static_Boolean_EntityManager_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      result = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976232, XrefRangeEnd = 976243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetGearLevel(
      EntityManager entityManager,
      Entity localUser,
      out float result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetGearLevel_Private_Static_Boolean_EntityManager_Entity_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 976294, RefRangeEnd = 976296, XrefRangeStart = 976243, XrefRangeEnd = 976294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetEquipmentInfo(
      EntityManager entityManager,
      Entity localUser,
      PrefabCollectionSystem prefabCollectionSystem,
      out string result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_TryGetEquipmentInfo_Private_Static_Boolean_EntityManager_Entity_PrefabCollectionSystem_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      result = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976356, RefRangeEnd = 976357, XrefRangeStart = 976296, XrefRangeEnd = 976356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int CalculateUniqueWorkstations(
      EntityManager entityManager,
      Entity localUser)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_CalculateUniqueWorkstations_Private_Static_Int32_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976357, XrefRangeEnd = 976370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetClanSize(EntityManager entityManager, Entity localUser)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_GetClanSize_Private_Static_Int32_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976370, XrefRangeEnd = 976375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetChunkIdentifier(EntityManager entityManager, float2 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_GetChunkIdentifier_Private_Static_String_EntityManager_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 976396, RefRangeEnd = 976400, XrefRangeStart = 976375, XrefRangeEnd = 976396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetChunkIdentifier(
      EntityManager entityManager,
      float2 position,
      TerrainManager terrainManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) terrainManager);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StunAnalytics.NativeMethodInfoPtr_GetChunkIdentifier_Private_Static_String_EntityManager_float2_TerrainManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static StunAnalytics()
    {
      Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StunAnalytics));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr);
      StunAnalytics.NativeFieldInfoPtr_PROGRESSION_UNLOCKED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PROGRESSION_UNLOCKED_ID));
      StunAnalytics.NativeFieldInfoPtr_ACHIEVEMENT_UNLOCKED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (ACHIEVEMENT_UNLOCKED_ID));
      StunAnalytics.NativeFieldInfoPtr_PLAYER_KILLED_VBLOOD_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PLAYER_KILLED_VBLOOD_ID));
      StunAnalytics.NativeFieldInfoPtr_BUILDING_PLACED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (BUILDING_PLACED_ID));
      StunAnalytics.NativeFieldInfoPtr_ABILITY_CAST_FINISHED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (ABILITY_CAST_FINISHED_ID));
      StunAnalytics.NativeFieldInfoPtr_ABILITY_CAST_INTERRUPTED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (ABILITY_CAST_INTERRUPTED_ID));
      StunAnalytics.NativeFieldInfoPtr_UI_CLICK_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (UI_CLICK_ID));
      StunAnalytics.NativeFieldInfoPtr_PLAYER_DOWNED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PLAYER_DOWNED_ID));
      StunAnalytics.NativeFieldInfoPtr_CONNECTED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CONNECTED_ID));
      StunAnalytics.NativeFieldInfoPtr_DISCONNECTED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (DISCONNECTED_ID));
      StunAnalytics.NativeFieldInfoPtr_CASTLE_INFO_ON_DISCONNECT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CASTLE_INFO_ON_DISCONNECT_ID));
      StunAnalytics.NativeFieldInfoPtr_CLAN_STATUS_CHANGED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CLAN_STATUS_CHANGED_ID));
      StunAnalytics.NativeFieldInfoPtr_CHAT_MESSAGE_SENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CHAT_MESSAGE_SENT_ID));
      StunAnalytics.NativeFieldInfoPtr_CHUNK_IDENTIFIER_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CHUNK_IDENTIFIER_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_POS_X_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (POS_X_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_POS_Z_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (POS_Z_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_GAME_MODE_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (GAME_MODE_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_GEAR_LEVEL_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (GEAR_LEVEL_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_CLAN_SIZE_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CLAN_SIZE_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_SESSION_GUID_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (SESSION_GUID_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_PROGRESSION_NAME_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PROGRESSION_NAME_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_ACHIEVEMENT_NAME_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (ACHIEVEMENT_NAME_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_BUILDING_NAME_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (BUILDING_NAME_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_UNIT_NAME_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (UNIT_NAME_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_ABILITY_NAME_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (ABILITY_NAME_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_ABILITY_GROUP_NAME_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (ABILITY_GROUP_NAME_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_CAST_COUNT_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CAST_COUNT_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_BUTTON_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (BUTTON_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_UI_BUTTON_LINK_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (UI_BUTTON_LINK_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_SOURCE_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (SOURCE_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_REASON_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (REASON_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_UNIQUE_WORKSTATIONS_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (UNIQUE_WORKSTATIONS_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_PLAYER_HEALTH_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PLAYER_HEALTH_ID));
      StunAnalytics.NativeFieldInfoPtr_TIME_TO_KILL_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (TIME_TO_KILL_ID));
      StunAnalytics.NativeFieldInfoPtr_SOURCE_HEALTH_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (SOURCE_HEALTH_ID));
      StunAnalytics.NativeFieldInfoPtr_CASTLE_HEART_LEVEL_ARG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CASTLE_HEART_LEVEL_ARG_ID));
      StunAnalytics.NativeFieldInfoPtr_TIMES_ENGAGED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (TIMES_ENGAGED_ID));
      StunAnalytics.NativeFieldInfoPtr_VBLOOD_COMBAT_TIME_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (VBLOOD_COMBAT_TIME_ID));
      StunAnalytics.NativeFieldInfoPtr_PLAYERS_ENGAGED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PLAYERS_ENGAGED_ID));
      StunAnalytics.NativeFieldInfoPtr_CHANGE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (CHANGE_ID));
      StunAnalytics.NativeFieldInfoPtr_TYPE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (TYPE_ID));
      StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_TYPE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PLAYER_BLOOD_TYPE_ID));
      StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_VALUE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PLAYER_BLOOD_VALUE_ID));
      StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_QUALITY_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PLAYER_BLOOD_QUALITY_ID));
      StunAnalytics.NativeFieldInfoPtr_PLAYER_EQUIPMENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, nameof (PLAYER_EQUIPMENT_ID));
      StunAnalytics.NativeMethodInfoPtr_get_Enabled_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675420);
      StunAnalytics.NativeMethodInfoPtr_get_Environment_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675421);
      StunAnalytics.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675422);
      StunAnalytics.NativeMethodInfoPtr_OptOut_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675423);
      StunAnalytics.NativeMethodInfoPtr_SendUnlockProgressionEvent_Public_Static_Void_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675424);
      StunAnalytics.NativeMethodInfoPtr_SendAchievementEvent_Public_Static_Void_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675425);
      StunAnalytics.NativeMethodInfoPtr_SendPlayerKilledVBloodEvent_Public_Static_Void_EntityManager_PrefabGUID_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675426);
      StunAnalytics.NativeMethodInfoPtr_SendPlayerDownedEvent_Public_Static_Void_EntityManager_String_PrefabGUID_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675427);
      StunAnalytics.NativeMethodInfoPtr_SendBuildingPlacedEvent_Public_Static_Void_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675428);
      StunAnalytics.NativeMethodInfoPtr_SendAbilityCastFinishedEvent_Public_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675429);
      StunAnalytics.NativeMethodInfoPtr_SendAbilityCastInterruptedEvent_Public_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675430);
      StunAnalytics.NativeMethodInfoPtr_SendAbilityCastEvent_Private_Static_Void_EntityManager_NativeHashMap_2_Entity_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675431);
      StunAnalytics.NativeMethodInfoPtr_SendUiClickEvent_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675432);
      StunAnalytics.NativeMethodInfoPtr_SendConnectedEvent_Public_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675433);
      StunAnalytics.NativeMethodInfoPtr_SendDisconnectedEvent_Public_Static_Void_EntityManager_String_ClientBootstrapSystem_TerrainManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675434);
      StunAnalytics.NativeMethodInfoPtr_SendClanStatusChangedEvent_Public_Static_Void_EntityManager_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675435);
      StunAnalytics.NativeMethodInfoPtr_SendChatMessageSentEvent_Public_Static_Void_EntityManager_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675436);
      StunAnalytics.NativeMethodInfoPtr_SendCastleInfoOnDisconnectEvent_Private_Static_Void_EntityManager_Entity_TerrainManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675437);
      StunAnalytics.NativeMethodInfoPtr_TryGetCastleHeart_Private_Static_Boolean_EntityManager_Entity_byref_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675438);
      StunAnalytics.NativeMethodInfoPtr_SendGameplayEvent_Private_Static_Void_EntityManager_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675439);
      StunAnalytics.NativeMethodInfoPtr_SendGameplayEvent_Private_Static_Void_EntityManager_String_Dictionary_2_String_Object_ClientBootstrapSystem_TerrainManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675440);
      StunAnalytics.NativeMethodInfoPtr_SendEvent_Private_Static_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675441);
      StunAnalytics.NativeMethodInfoPtr_DebugLogEvent_Private_Static_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675442);
      StunAnalytics.NativeMethodInfoPtr_TryGetBloodInfo_Private_Static_Boolean_EntityManager_Entity_byref_Single_byref_Single_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675443);
      StunAnalytics.NativeMethodInfoPtr_TryGetLocalUser_Private_Static_Boolean_EntityManager_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675444);
      StunAnalytics.NativeMethodInfoPtr_TryGetCurrentPosition_Private_Static_Boolean_EntityManager_Entity_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675445);
      StunAnalytics.NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_Entity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675446);
      StunAnalytics.NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_Entity_TerrainManager_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675447);
      StunAnalytics.NativeMethodInfoPtr_TryGetCurrentChunkIdentifier_Private_Static_Boolean_EntityManager_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675448);
      StunAnalytics.NativeMethodInfoPtr_TryGetGameMode_Private_Static_Boolean_EntityManager_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675449);
      StunAnalytics.NativeMethodInfoPtr_TryGetGearLevel_Private_Static_Boolean_EntityManager_Entity_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675450);
      StunAnalytics.NativeMethodInfoPtr_TryGetEquipmentInfo_Private_Static_Boolean_EntityManager_Entity_PrefabCollectionSystem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675451);
      StunAnalytics.NativeMethodInfoPtr_CalculateUniqueWorkstations_Private_Static_Int32_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675452);
      StunAnalytics.NativeMethodInfoPtr_GetClanSize_Private_Static_Int32_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675453);
      StunAnalytics.NativeMethodInfoPtr_GetChunkIdentifier_Private_Static_String_EntityManager_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675454);
      StunAnalytics.NativeMethodInfoPtr_GetChunkIdentifier_Private_Static_String_EntityManager_float2_TerrainManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, 100675455);
    }

    public StunAnalytics(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string PROGRESSION_UNLOCKED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PROGRESSION_UNLOCKED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PROGRESSION_UNLOCKED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ACHIEVEMENT_UNLOCKED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_ACHIEVEMENT_UNLOCKED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_ACHIEVEMENT_UNLOCKED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PLAYER_KILLED_VBLOOD_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_KILLED_VBLOOD_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_KILLED_VBLOOD_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string BUILDING_PLACED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_BUILDING_PLACED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_BUILDING_PLACED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ABILITY_CAST_FINISHED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_ABILITY_CAST_FINISHED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_ABILITY_CAST_FINISHED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ABILITY_CAST_INTERRUPTED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_ABILITY_CAST_INTERRUPTED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_ABILITY_CAST_INTERRUPTED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string UI_CLICK_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_UI_CLICK_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_UI_CLICK_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PLAYER_DOWNED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_DOWNED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_DOWNED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CONNECTED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CONNECTED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CONNECTED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DISCONNECTED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_DISCONNECTED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_DISCONNECTED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CASTLE_INFO_ON_DISCONNECT_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CASTLE_INFO_ON_DISCONNECT_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CASTLE_INFO_ON_DISCONNECT_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CLAN_STATUS_CHANGED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CLAN_STATUS_CHANGED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CLAN_STATUS_CHANGED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CHAT_MESSAGE_SENT_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CHAT_MESSAGE_SENT_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CHAT_MESSAGE_SENT_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CHUNK_IDENTIFIER_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CHUNK_IDENTIFIER_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CHUNK_IDENTIFIER_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string POS_X_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_POS_X_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_POS_X_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string POS_Z_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_POS_Z_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_POS_Z_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GAME_MODE_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_GAME_MODE_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_GAME_MODE_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GEAR_LEVEL_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_GEAR_LEVEL_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_GEAR_LEVEL_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CLAN_SIZE_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CLAN_SIZE_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CLAN_SIZE_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string SESSION_GUID_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_SESSION_GUID_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_SESSION_GUID_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PROGRESSION_NAME_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PROGRESSION_NAME_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PROGRESSION_NAME_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ACHIEVEMENT_NAME_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_ACHIEVEMENT_NAME_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_ACHIEVEMENT_NAME_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string BUILDING_NAME_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_BUILDING_NAME_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_BUILDING_NAME_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string UNIT_NAME_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_UNIT_NAME_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_UNIT_NAME_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ABILITY_NAME_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_ABILITY_NAME_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_ABILITY_NAME_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ABILITY_GROUP_NAME_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_ABILITY_GROUP_NAME_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_ABILITY_GROUP_NAME_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CAST_COUNT_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CAST_COUNT_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CAST_COUNT_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string BUTTON_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_BUTTON_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_BUTTON_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string UI_BUTTON_LINK_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_UI_BUTTON_LINK_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_UI_BUTTON_LINK_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string SOURCE_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_SOURCE_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_SOURCE_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string REASON_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_REASON_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_REASON_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string UNIQUE_WORKSTATIONS_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_UNIQUE_WORKSTATIONS_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_UNIQUE_WORKSTATIONS_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PLAYER_HEALTH_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_HEALTH_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_HEALTH_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string TIME_TO_KILL_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_TIME_TO_KILL_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_TIME_TO_KILL_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string SOURCE_HEALTH_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_SOURCE_HEALTH_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_SOURCE_HEALTH_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CASTLE_HEART_LEVEL_ARG_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CASTLE_HEART_LEVEL_ARG_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CASTLE_HEART_LEVEL_ARG_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string TIMES_ENGAGED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_TIMES_ENGAGED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_TIMES_ENGAGED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string VBLOOD_COMBAT_TIME_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_VBLOOD_COMBAT_TIME_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_VBLOOD_COMBAT_TIME_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PLAYERS_ENGAGED_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PLAYERS_ENGAGED_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PLAYERS_ENGAGED_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CHANGE_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_CHANGE_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_CHANGE_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string TYPE_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_TYPE_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_TYPE_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PLAYER_BLOOD_TYPE_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_TYPE_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_TYPE_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PLAYER_BLOOD_VALUE_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_VALUE_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_VALUE_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PLAYER_BLOOD_QUALITY_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_QUALITY_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_BLOOD_QUALITY_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PLAYER_EQUIPMENT_ID
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_EQUIPMENT_ID, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunAnalytics.NativeFieldInfoPtr_PLAYER_EQUIPMENT_ID, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [ObfuscatedName("ProjectM.StunAnalytics/<Initialize>d__49")]
    public sealed class _Initialize_d__49 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
      private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
      private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975418, XrefRangeEnd = 975499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunAnalytics._Initialize_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunAnalytics._Initialize_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static _Initialize_d__49()
      {
        Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StunAnalytics>.NativeClassPtr, "<Initialize>d__49");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr);
        StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr, "<>1__state");
        StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr, "<>t__builder");
        StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr, "<>u__1");
        StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr, "<>u__2");
        StunAnalytics._Initialize_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr, 100675456);
        StunAnalytics._Initialize_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr, 100675457);
      }

      public _Initialize_d__49(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public _Initialize_d__49()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StunAnalytics._Initialize_d__49>.NativeClassPtr, data));
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public AsyncVoidMethodBuilder __t__builder
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___t__builder);
          return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public TaskAwaiter __u__1
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___u__1);
          return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public TaskAwaiter<List<string>> __u__2
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___u__2);
          return new TaskAwaiter<List<string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<List<string>>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunAnalytics._Initialize_d__49.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<List<string>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
