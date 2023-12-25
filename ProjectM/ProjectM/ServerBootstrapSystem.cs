// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerBootstrapSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.Auth;
using ProjectM.CastleBuilding;
using ProjectM.EOS;
using ProjectM.Network;
using ProjectM.Shared;
using ProjectM.Terrain;
using Stunlock.Network;
using Stunlock.Network.Lidgren;
using StunMetrics;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Scenes;

#nullable disable
namespace ProjectM
{
  public class ServerBootstrapSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SetupWorldState;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetServer;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultNetworkData;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeApprovedUserIndexes;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeApprovedAdminIndexes;
    private static readonly System.IntPtr NativeFieldInfoPtr__ApprovedUsersLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetEndPointToApprovedUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformIdToApprovedUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserIndexToApprovedUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__HailDataBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_PLATFORM_USER_UPDATE_INTERVAL;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerHostData;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameBootstrap;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__EOSSession;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneLoadSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SteamPlatformSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__KickBanSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdminAuthSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PacketBookkeeperSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDiscoveryData;
    private static readonly System.IntPtr NativeFieldInfoPtr__EditorSpawnChunkAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__InactiveEntitiesToEnable;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllowDebugCommands;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsGameDataInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadingSuccessful;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerWasInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__AuthSessionResponses;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadingDataBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadingData;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionGuidAsString;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAdmins;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinFreeSlotsNeededForNewUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr_HailMessage_Server;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextReloadSettingsCheckTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastUpdatedMetricsSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_EXPENSIVE_METRICS_DELAY_SECONDS;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastUpdatedActivitySecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_ACTIVITY_DELAY_SECONDS;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformIdRemappings;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllConnectedUsersList;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameTags;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedGameTags;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameTagsModified;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitServerData;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextPlatformUserUpdate;
    private static readonly System.IntPtr NativeFieldInfoPtr_HIGH_ACTIVITY_CONSTANT;
    private static readonly System.IntPtr NativeFieldInfoPtr_MID_ACTIVITY_CONSTANT;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveNewUsersScore;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnlineUsersInStartCave;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeTerritoriesPerRegion;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsedTerritoriesPerRegion;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveUsersPerRegion;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsersPerRegion;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUsersTaken_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUsersTaken_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateAFKKick_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateAFKKick_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdatePlatformData_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdatePlatformData_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___NetworkEventLogging_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___NetworkEventLogging_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnGameDataInitialized_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnGameDataInitialized_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateLatency_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateLatency_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUserConnected_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUserConnected_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUserDisconnected_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUserDisconnected_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUserDisconnected_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUserDisconnected_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindClanMembers_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryAuthenticate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryAuthenticate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryAuthenticate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryAuthenticate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateAllConnectedUsersData_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateAllConnectedUsersData_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_6;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_7;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_8;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_9;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_10;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerHostData_Public_get_ServerHostData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerIsInitialized_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GameBootstrap_Public_get_GameBootstrap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StartingItemSets_Public_get_List_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SimulatedLatency_Public_get_SimulationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SimulatedLatency_Public_set_Void_SimulationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkStats_Public_byref_ServerTransportStats_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlatformIdRemappings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUsersTaken_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ServerLoadingCompleted_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAFKKick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLoadingData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetServerGameTag_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveServerGameTag_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlatformData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReloadSettings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMetrics_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMetricsData_Private_Void_NativeHashMap_2_Int32_Int32_Dictionary_2_WorldRegionType_GaugeAPI_WorldRegionType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProfilerData_Private_Void_byref_ProfilerData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAuthSessionResponse_Private_Void_UInt64_AuthSessionResponseEnum_UserContentFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleAuthSessionResponses_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInGameDay_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateActivityLevel_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IncrementActivityPerRegion_Private_Static_Void_NativeHashMap_2_Int32_Int32_WorldRegionType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NetworkEventLogging_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleCreateCharacterEventInternal_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCryptSpawn_Private_Boolean_NetworkId_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWaypointSpawn_Private_Boolean_NetworkId_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfResetServer_Public_Static_Void_byref_ServerRuntimeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSessionGuid_Private_Void_ServerRuntimeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeServer_Public_Void_ServerRuntimeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginSetupServer_Public_Void_GameBootstrap_ServerRuntimeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeSetupServer_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadToTargetWorldConfig_Private_LoadToTargetWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnGameDataInitialized_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateServerFPS_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLatency_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnConnectionApproval_Private_Void_byref_NetBufferIn_NetConnectionId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAuthenticate_Private_Void_NetConnectionId_Int32_UInt64_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApproveClient_Private_Boolean_NetConnectionId_Int32_UInt64_String_Boolean_Boolean_byref_User_Entity_ConnectAddress_ConnectAddress_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectOldUser_Private_Boolean_NetConnectionId_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResetDateTime_Public_Static_DateTime_DateTime_Int32_ResetDayEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUserConnected_Private_Void_NetConnectionId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesToEnableForInactiveCharacter_Private_Static_Void_EntityManager_NativeList_1_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDisableFromEntities_Private_Static_Void_EntityManager_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInactiveEntitiesToEnable_Private_Static_Void_NativeList_1_Entity_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUserDisconnected_Private_Void_NetConnectionId_ConnectionStatusChangeReason_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateUserConnectedEvent_Private_Void_Entity_ConnectedUser_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateUserDisconnectedEvent_Private_Void_Entity_ConnectedUser_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendClanStatusUpdate_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDataReceivedServer_Private_Void_byref_NetBufferIn_NetConnectionId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeReliableEventsPacketServer_Private_Void_Int32_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeUserStateSyncServer_Private_Void_NetBufferIn_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendPacketToUser_Public_Virtual_Final_New_StunNetSendResult_NativeArray_1_Byte_Int32_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAuthenticate_Private_Boolean_UInt64_UserContentFlags_Boolean_byref_Boolean_byref_Boolean_byref_ConnectionStatusChangeReason_byref_User_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRemappedPlatformId_Private_UInt64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearUserNetworkState_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomSpawnPosition_Public_Nullable_Unboxed_1_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomSpawnPosition_Public_Static_Nullable_Unboxed_1_float3_SingletonAccessor_1_EditorSpawnChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnCharacter_Public_Static_Entity_EntityCommandBuffer_Entity_Entity_Nullable_Unboxed_1_float3_Entity_Entity_Int32_CustomizationFeatures_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RespawnCharacter_Public_Entity_EntityCommandBuffer_Entity_Nullable_Unboxed_1_float3_Entity_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RespawnCharacter_Public_Entity_EntityManager_EntityCommandBuffer_Entity_PrefabGUID_PrefabLookupMap_Nullable_Unboxed_1_float3_Entity_Entity_Int32_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnFadeToBlackEntity_Public_Entity_EntityCommandBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Kick_Public_Boolean_UInt64_ConnectionStatusChangeReason_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendRevealedMapData_Private_Void_Entity_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendDiscoveredMapZones_Private_Void_Entity_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendClaimedAchievements_Private_Void_Entity_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendInitialUnlockedProgressionEvent_Private_Void_Entity_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendScrambleGamemodeSettings_Private_Void_Entity_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendAllUsers_Private_Void_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAllConnectedUsersData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateUsersTaken_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateAFKKick_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdatePlatformData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateActivityLevel_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateActivityLevel_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForNetworkEventLogging_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnGameDataInitialized_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateLatency_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUserConnected_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUserDisconnected_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUserDisconnected_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTryAuthenticate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTryAuthenticate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateAllConnectedUsersData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_7;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_8;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_9;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_10;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_11;

    public unsafe ServerHostData ServerHostData
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 148323, RefRangeEnd = 148324, XrefRangeStart = 148323, XrefRangeEnd = 148324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_get_ServerHostData_Public_get_ServerHostData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerHostData) null : new ServerHostData(pointer);
      }
    }

    public unsafe bool ServerIsInitialized
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 981774, RefRangeEnd = 981780, XrefRangeStart = 981769, XrefRangeEnd = 981774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_get_ServerIsInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe GameBootstrap GameBootstrap
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_get_GameBootstrap_Public_get_GameBootstrap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GameBootstrap) null : new GameBootstrap(pointer);
      }
    }

    public unsafe List<PrefabGUID> StartingItemSets
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 981780, RefRangeEnd = 981782, XrefRangeStart = 981780, XrefRangeEnd = 981780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_get_StartingItemSets_Public_get_List_1_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<PrefabGUID>) null : new List<PrefabGUID>(pointer);
      }
    }

    public unsafe SimulationData SimulatedLatency
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981782, XrefRangeEnd = 981785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_get_SimulatedLatency_Public_get_SimulationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SimulationData*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981785, XrefRangeEnd = 981788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_set_SimulatedLatency_Public_set_Void_SimulationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 981792, RefRangeEnd = 981793, XrefRangeStart = 981788, XrefRangeEnd = 981792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref ServerTransportStats GetNetworkStats()
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981793, XrefRangeEnd = 981945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerBootstrapSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982073, RefRangeEnd = 982074, XrefRangeStart = 981945, XrefRangeEnd = 982073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadPlatformIdRemappings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_LoadPlatformIdRemappings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982074, XrefRangeEnd = 982130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerBootstrapSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982130, XrefRangeEnd = 982171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerBootstrapSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982185, RefRangeEnd = 982186, XrefRangeStart = 982171, XrefRangeEnd = 982185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateUsersTaken()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateUsersTaken_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982186, XrefRangeEnd = 982193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ServerLoadingCompleted()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_ServerLoadingCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982251, RefRangeEnd = 982252, XrefRangeStart = 982193, XrefRangeEnd = 982251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAFKKick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateAFKKick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982265, RefRangeEnd = 982266, XrefRangeStart = 982252, XrefRangeEnd = 982265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateLoadingData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateLoadingData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 982273, RefRangeEnd = 982282, XrefRangeStart = 982266, XrefRangeEnd = 982273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetServerGameTag(string tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SetServerGameTag_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 982289, RefRangeEnd = 982292, XrefRangeStart = 982282, XrefRangeEnd = 982289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveServerGameTag(string tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_RemoveServerGameTag_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982428, RefRangeEnd = 982429, XrefRangeStart = 982292, XrefRangeEnd = 982428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePlatformData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdatePlatformData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982449, RefRangeEnd = 982450, XrefRangeStart = 982429, XrefRangeEnd = 982449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReloadSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_ReloadSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982655, RefRangeEnd = 982656, XrefRangeStart = 982450, XrefRangeEnd = 982655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateMetrics()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateMetrics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982656, XrefRangeEnd = 982663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMetricsData(
      NativeHashMap<int, int> territoryActivity,
      Dictionary<WorldRegionType, GaugeAPI> gauges,
      WorldRegionType enumValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &territoryActivity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gauges);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &enumValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SetMetricsData_Private_Void_NativeHashMap_2_Int32_Int32_Dictionary_2_WorldRegionType_GaugeAPI_WorldRegionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982663, XrefRangeEnd = 982669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetProfilerData(
      ref ServerBootstrapSystem.ProfilerData profilerDataCached)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref profilerDataCached;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_GetProfilerData_Private_Void_byref_ProfilerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982669, XrefRangeEnd = 982672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAuthSessionResponse(
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
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_OnAuthSessionResponse_Private_Void_UInt64_AuthSessionResponseEnum_UserContentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982736, RefRangeEnd = 982737, XrefRangeStart = 982672, XrefRangeEnd = 982736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleAuthSessionResponses()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_HandleAuthSessionResponses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982737, XrefRangeEnd = 982748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateInGameDay()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateInGameDay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982812, RefRangeEnd = 982813, XrefRangeStart = 982748, XrefRangeEnd = 982812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateActivityLevel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateActivityLevel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 982819, RefRangeEnd = 982823, XrefRangeStart = 982813, XrefRangeEnd = 982819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void IncrementActivityPerRegion(
      NativeHashMap<int, int> activeUsersPerRegion,
      WorldRegionType region)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &activeUsersPerRegion;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &region;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_IncrementActivityPerRegion_Private_Static_Void_NativeHashMap_2_Int32_Int32_WorldRegionType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982840, RefRangeEnd = 982841, XrefRangeStart = 982823, XrefRangeEnd = 982840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void NetworkEventLogging()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_NetworkEventLogging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982884, RefRangeEnd = 982885, XrefRangeStart = 982841, XrefRangeEnd = 982884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleCreateCharacterEventInternal()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_HandleCreateCharacterEventInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982943, RefRangeEnd = 982944, XrefRangeStart = 982885, XrefRangeEnd = 982943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCryptSpawn(NetworkId networkId, out Entity coffinEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref coffinEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_TryGetCryptSpawn_Private_Boolean_NetworkId_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 982965, RefRangeEnd = 982966, XrefRangeStart = 982944, XrefRangeEnd = 982965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetWaypointSpawn(
      NetworkId networkId,
      Entity user,
      out Entity coffinEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coffinEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_TryGetWaypointSpawn_Private_Boolean_NetworkId_Entity_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 983057, RefRangeEnd = 983058, XrefRangeStart = 982966, XrefRangeEnd = 983057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckIfResetServer(ref ServerRuntimeSettings runtimeSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref runtimeSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_CheckIfResetServer_Public_Static_Void_byref_ServerRuntimeSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983058, XrefRangeEnd = 983076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeSessionGuid(ServerRuntimeSettings runtimeSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &runtimeSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_InitializeSessionGuid_Private_Void_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 983126, RefRangeEnd = 983127, XrefRangeStart = 983076, XrefRangeEnd = 983126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeServer(ServerRuntimeSettings runtimeSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &runtimeSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_InitializeServer_Public_Void_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 983236, RefRangeEnd = 983237, XrefRangeStart = 983127, XrefRangeEnd = 983236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginSetupServer(
      GameBootstrap gameBootstrap,
      ServerRuntimeSettings runtimeSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameBootstrap);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &runtimeSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_BeginSetupServer_Public_Void_GameBootstrap_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 983244, RefRangeEnd = 983245, XrefRangeStart = 983237, XrefRangeEnd = 983244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Shutdown()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Shutdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 983393, RefRangeEnd = 983394, XrefRangeStart = 983245, XrefRangeEnd = 983393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinalizeSetupServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_FinalizeSetupServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 983410, RefRangeEnd = 983412, XrefRangeStart = 983394, XrefRangeEnd = 983410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LoadToTargetWorld GetLoadToTargetWorldConfig()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_GetLoadToTargetWorldConfig_Private_LoadToTargetWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LoadToTargetWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 983507, RefRangeEnd = 983508, XrefRangeStart = 983412, XrefRangeEnd = 983507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnGameDataInitialized()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_OnGameDataInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 983516, RefRangeEnd = 983520, XrefRangeStart = 983508, XrefRangeEnd = 983516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateServerFPS()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateServerFPS_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 983540, RefRangeEnd = 983541, XrefRangeStart = 983520, XrefRangeEnd = 983540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateLatency()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateLatency_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983541, XrefRangeEnd = 983699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnConnectionApproval(
      ref NetBufferIn netBufferIn,
      NetConnectionId netConnectionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBufferIn;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) netConnectionId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_OnConnectionApproval_Private_Void_byref_NetBufferIn_NetConnectionId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 983732, RefRangeEnd = 983734, XrefRangeStart = 983699, XrefRangeEnd = 983732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryAuthenticate(
      NetConnectionId netConnectionId,
      int version,
      ulong platformId,
      string eosId,
      bool isBot)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) netConnectionId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &version;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &platformId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(eosId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isBot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_TryAuthenticate_Private_Void_NetConnectionId_Int32_UInt64_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983734, XrefRangeEnd = 983760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ApproveClient(
      NetConnectionId netConnection,
      int version,
      ulong platformId,
      string eosIdString,
      bool isReconnect,
      bool connectedAsAdmin,
      [In] ref User user,
      Entity userEntity,
      ConnectAddress primaryAddress,
      ConnectAddress secondaryAddress)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) netConnection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &version;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &platformId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(eosIdString);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isReconnect;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &connectedAsAdmin;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &primaryAddress;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryAddress;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_ApproveClient_Private_Boolean_NetConnectionId_Int32_UInt64_String_Boolean_Boolean_byref_User_Entity_ConnectAddress_ConnectAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 983780, RefRangeEnd = 983782, XrefRangeStart = 983760, XrefRangeEnd = 983780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DisconnectOldUser(NetConnectionId netConnection, ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) netConnection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &platformId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_DisconnectOldUser_Private_Boolean_NetConnectionId_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 983790, RefRangeEnd = 983793, XrefRangeStart = 983782, XrefRangeEnd = 983790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.DateTime GetResetDateTime(
      Il2CppSystem.DateTime startTime,
      int daysToAdd,
      ResetDayEnum resetDay)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &startTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &daysToAdd;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resetDay;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_GetResetDateTime_Public_Static_DateTime_DateTime_Int32_ResetDayEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983793, XrefRangeEnd = 984164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnUserConnected(NetConnectionId netConnectionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) netConnectionId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_OnUserConnected_Private_Void_NetConnectionId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984174, RefRangeEnd = 984175, XrefRangeStart = 984164, XrefRangeEnd = 984174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetEntitiesToEnableForInactiveCharacter(
      EntityManager entityManager,
      NativeList<Entity> inactiveEntitiesToEnable,
      Entity controlled)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inactiveEntitiesToEnable;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controlled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_GetEntitiesToEnableForInactiveCharacter_Private_Static_Void_EntityManager_NativeList_1_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 984192, RefRangeEnd = 984194, XrefRangeStart = 984175, XrefRangeEnd = 984192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveDisableFromEntities(
      EntityManager entityManager,
      NativeList<Entity> inactiveEntitiesToEnable)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inactiveEntitiesToEnable;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_RemoveDisableFromEntities_Private_Static_Void_EntityManager_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 984230, RefRangeEnd = 984232, XrefRangeStart = 984194, XrefRangeEnd = 984230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetInactiveEntitiesToEnable(
      NativeList<Entity> entities,
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_GetInactiveEntitiesToEnable_Private_Static_Void_NativeList_1_Entity_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984461, RefRangeEnd = 984462, XrefRangeStart = 984232, XrefRangeEnd = 984461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnUserDisconnected(
      NetConnectionId netConnectionId,
      ConnectionStatusChangeReason connectionStatusReason,
      string extraData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) netConnectionId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &connectionStatusReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(extraData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_OnUserDisconnected_Private_Void_NetConnectionId_ConnectionStatusChangeReason_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984462, XrefRangeEnd = 984482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateUserConnectedEvent(Entity userEntity, ConnectedUser connectedUser)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &connectedUser;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_CreateUserConnectedEvent_Private_Void_Entity_ConnectedUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984482, XrefRangeEnd = 984502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateUserDisconnectedEvent(Entity userEntity, ConnectedUser connectedUser)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &connectedUser;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_CreateUserDisconnectedEvent_Private_Void_Entity_ConnectedUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984502, XrefRangeEnd = 984541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendClanStatusUpdate(Entity userEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SendClanStatusUpdate_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984541, XrefRangeEnd = 984572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDataReceivedServer(
      ref NetBufferIn netBufferIn,
      NetConnectionId netConnectionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBufferIn;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) netConnectionId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_OnDataReceivedServer_Private_Void_byref_NetBufferIn_NetConnectionId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984633, RefRangeEnd = 984634, XrefRangeStart = 984572, XrefRangeEnd = 984633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeReliableEventsPacketServer(
      int approvedUserIndex,
      ref NetBufferIn netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &approvedUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_DeserializeReliableEventsPacketServer_Private_Void_Int32_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984675, RefRangeEnd = 984676, XrefRangeStart = 984634, XrefRangeEnd = 984675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeUserStateSyncServer(
      NetBufferIn netBufferIn,
      int approvedUserIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &netBufferIn;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &approvedUserIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_DeserializeUserStateSyncServer_Private_Void_NetBufferIn_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984697, RefRangeEnd = 984698, XrefRangeStart = 984676, XrefRangeEnd = 984697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe StunNetSendResult SendPacketToUser(
      NativeArray<byte> data,
      int lengthBits,
      int userIndex,
      bool reliable)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lengthBits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &reliable;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SendPacketToUser_Public_Virtual_Final_New_StunNetSendResult_NativeArray_1_Byte_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(StunNetSendResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984828, RefRangeEnd = 984829, XrefRangeStart = 984698, XrefRangeEnd = 984828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryAuthenticate(
      ulong platformId,
      UserContentFlags defaultUserContent,
      bool isBot,
      out bool isReconnect,
      out bool connectedAsAdmin,
      out ConnectionStatusChangeReason error,
      out User user,
      out Entity userEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &platformId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultUserContent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isBot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref isReconnect;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedAsAdmin;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref error;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref userEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_TryAuthenticate_Private_Boolean_UInt64_UserContentFlags_Boolean_byref_Boolean_byref_Boolean_byref_ConnectionStatusChangeReason_byref_User_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984829, XrefRangeEnd = 984835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong GetRemappedPlatformId(ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &platformId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_GetRemappedPlatformId_Private_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984847, RefRangeEnd = 984848, XrefRangeStart = 984835, XrefRangeEnd = 984847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearUserNetworkState(EntityManager entityManager, Entity userEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_ClearUserNetworkState_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984849, RefRangeEnd = 984850, XrefRangeStart = 984848, XrefRangeEnd = 984849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Nullable_Unboxed<float3> GetCustomSpawnPosition()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_GetCustomSpawnPosition_Public_Nullable_Unboxed_1_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<float3>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 984862, RefRangeEnd = 984865, XrefRangeStart = 984850, XrefRangeEnd = 984862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Nullable_Unboxed<float3> GetCustomSpawnPosition(
      SingletonAccessor<EditorSpawnChunk> editorSpawnChunkAccessor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &editorSpawnChunkAccessor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_GetCustomSpawnPosition_Public_Static_Nullable_Unboxed_1_float3_SingletonAccessor_1_EditorSpawnChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<float3>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 984880, RefRangeEnd = 984883, XrefRangeStart = 984865, XrefRangeEnd = 984880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity SpawnCharacter(
      EntityCommandBuffer commandBuffer,
      Entity prefab,
      Entity user,
      Nullable_Unboxed<float3> customSpawnPosition,
      Entity previousCharacter = default (Entity),
      Entity fadeOutEntity = default (Entity),
      int spawnLocationIndex = -1,
      CustomizationFeatures customization = default (CustomizationFeatures),
      Entity coffinEntity = default (Entity),
      PrefabGUID pvpProtectionBuff = default (PrefabGUID))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &customSpawnPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &previousCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &fadeOutEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnLocationIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &customization;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &coffinEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &pvpProtectionBuff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SpawnCharacter_Public_Static_Entity_EntityCommandBuffer_Entity_Entity_Nullable_Unboxed_1_float3_Entity_Entity_Int32_CustomizationFeatures_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984887, RefRangeEnd = 984888, XrefRangeStart = 984883, XrefRangeEnd = 984887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity RespawnCharacter(
      EntityCommandBuffer commandBuffer,
      Entity user,
      Nullable_Unboxed<float3> customSpawnLocation = default (Nullable_Unboxed<float3>),
      Entity previousCharacter = default (Entity),
      Entity fadeOutEntity = default (Entity),
      int spawnLocationIndex = -1)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &customSpawnLocation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &previousCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fadeOutEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnLocationIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_RespawnCharacter_Public_Entity_EntityCommandBuffer_Entity_Nullable_Unboxed_1_float3_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984888, XrefRangeEnd = 984892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity RespawnCharacter(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      Entity user,
      PrefabGUID characterPrefabGuid,
      PrefabLookupMap prefabLookupMap,
      Nullable_Unboxed<float3> customSpawnLocation,
      Entity previousCharacter = default (Entity),
      Entity fadeOutEntity = default (Entity),
      int spawnLocationIndex = -1,
      NetworkId spawnLocationIcon = default (NetworkId))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &characterPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &customSpawnLocation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &previousCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &fadeOutEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnLocationIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnLocationIcon;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_RespawnCharacter_Public_Entity_EntityManager_EntityCommandBuffer_Entity_PrefabGUID_PrefabLookupMap_Nullable_Unboxed_1_float3_Entity_Entity_Int32_NetworkId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984892, XrefRangeEnd = 984908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity SpawnFadeToBlackEntity(
      EntityCommandBuffer commandBuffer,
      Entity playerEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &playerEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SpawnFadeToBlackEntity_Public_Entity_EntityCommandBuffer_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984922, RefRangeEnd = 984923, XrefRangeStart = 984908, XrefRangeEnd = 984922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Kick(
      ulong platformId,
      ConnectionStatusChangeReason disconnectReason,
      bool logIfNotFound)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &platformId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &disconnectReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &logIfNotFound;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Kick_Public_Boolean_UInt64_ConnectionStatusChangeReason_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 984956, RefRangeEnd = 984957, XrefRangeStart = 984923, XrefRangeEnd = 984956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendRevealedMapData(Entity userEntity, User user)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SendRevealedMapData_Private_Void_Entity_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984957, XrefRangeEnd = 984970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendDiscoveredMapZones(Entity userEntity, User user)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SendDiscoveredMapZones_Private_Void_Entity_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984970, XrefRangeEnd = 984983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendClaimedAchievements(Entity userEntity, User user)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SendClaimedAchievements_Private_Void_Entity_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984983, XrefRangeEnd = 984999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendInitialUnlockedProgressionEvent(Entity userEntity, User user)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SendInitialUnlockedProgressionEvent_Private_Void_Entity_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984999, XrefRangeEnd = 985010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendScrambleGamemodeSettings(Entity userEntity, User user)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SendScrambleGamemodeSettings_Private_Void_Entity_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985010, XrefRangeEnd = 985017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendAllUsers(User toUser)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &toUser;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_SendAllUsers_Private_Void_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985035, RefRangeEnd = 985036, XrefRangeStart = 985017, XrefRangeEnd = 985035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAllConnectedUsersData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_UpdateAllConnectedUsersData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe string PersistentIdentifier
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985036, XrefRangeEnd = 985038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985038, XrefRangeEnd = 985059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985059, XrefRangeEnd = 985090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985090, XrefRangeEnd = 985098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerBootstrapSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985098, XrefRangeEnd = 985539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerBootstrapSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985539, XrefRangeEnd = 985558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateUsersTaken_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUsersTaken_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985580, RefRangeEnd = 985581, XrefRangeStart = 985558, XrefRangeEnd = 985580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateAFKKick_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateAFKKick_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985603, RefRangeEnd = 985604, XrefRangeStart = 985581, XrefRangeEnd = 985603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdatePlatformData_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdatePlatformData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985604, XrefRangeEnd = 985623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateActivityLevel_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateActivityLevel_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985623, XrefRangeEnd = 985642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateActivityLevel_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateActivityLevel_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985642, XrefRangeEnd = 985661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForNetworkEventLogging_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForNetworkEventLogging_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985661, XrefRangeEnd = 985677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnGameDataInitialized_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnGameDataInitialized_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985677, XrefRangeEnd = 985693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateLatency_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateLatency_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985693, XrefRangeEnd = 985712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUserConnected_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUserConnected_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985712, XrefRangeEnd = 985728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUserDisconnected_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUserDisconnected_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985728, XrefRangeEnd = 985744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUserDisconnected_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUserDisconnected_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985744, XrefRangeEnd = 985760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTryAuthenticate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryAuthenticate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985760, XrefRangeEnd = 985776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTryAuthenticate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryAuthenticate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985798, RefRangeEnd = 985799, XrefRangeStart = 985776, XrefRangeEnd = 985798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateAllConnectedUsersData_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateAllConnectedUsersData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985803, RefRangeEnd = 985804, XrefRangeStart = 985799, XrefRangeEnd = 985803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985808, RefRangeEnd = 985809, XrefRangeStart = 985804, XrefRangeEnd = 985808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985813, RefRangeEnd = 985814, XrefRangeStart = 985809, XrefRangeEnd = 985813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985818, RefRangeEnd = 985819, XrefRangeStart = 985814, XrefRangeEnd = 985818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985823, RefRangeEnd = 985824, XrefRangeStart = 985819, XrefRangeEnd = 985823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985828, RefRangeEnd = 985829, XrefRangeStart = 985824, XrefRangeEnd = 985828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985833, RefRangeEnd = 985834, XrefRangeStart = 985829, XrefRangeEnd = 985833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985838, RefRangeEnd = 985839, XrefRangeStart = 985834, XrefRangeEnd = 985838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_7()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985843, RefRangeEnd = 985844, XrefRangeStart = 985839, XrefRangeEnd = 985843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_8()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985848, RefRangeEnd = 985849, XrefRangeStart = 985844, XrefRangeEnd = 985848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_9()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_9, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985853, RefRangeEnd = 985854, XrefRangeStart = 985849, XrefRangeEnd = 985853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_10()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_10, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 985858, RefRangeEnd = 985859, XrefRangeStart = 985854, XrefRangeEnd = 985858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_11()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_11, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerBootstrapSystem()
    {
      Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerBootstrapSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr);
      ServerBootstrapSystem.NativeFieldInfoPtr__SetupWorldState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SetupWorldState));
      ServerBootstrapSystem.NativeFieldInfoPtr__NetServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_NetServer));
      ServerBootstrapSystem.NativeFieldInfoPtr__DefaultNetworkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_DefaultNetworkData));
      ServerBootstrapSystem.NativeFieldInfoPtr__FreeApprovedUserIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_FreeApprovedUserIndexes));
      ServerBootstrapSystem.NativeFieldInfoPtr__FreeApprovedAdminIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_FreeApprovedAdminIndexes));
      ServerBootstrapSystem.NativeFieldInfoPtr__ApprovedUsersLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_ApprovedUsersLookup));
      ServerBootstrapSystem.NativeFieldInfoPtr__NetEndPointToApprovedUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_NetEndPointToApprovedUserIndex));
      ServerBootstrapSystem.NativeFieldInfoPtr__PlatformIdToApprovedUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_PlatformIdToApprovedUserIndex));
      ServerBootstrapSystem.NativeFieldInfoPtr__UserIndexToApprovedUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_UserIndexToApprovedUserIndex));
      ServerBootstrapSystem.NativeFieldInfoPtr__HailDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_HailDataBuffer));
      ServerBootstrapSystem.NativeFieldInfoPtr_PLATFORM_USER_UPDATE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (PLATFORM_USER_UPDATE_INTERVAL));
      ServerBootstrapSystem.NativeFieldInfoPtr__ServerHostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_ServerHostData));
      ServerBootstrapSystem.NativeFieldInfoPtr__GameBootstrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_GameBootstrap));
      ServerBootstrapSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_TerrainManager));
      ServerBootstrapSystem.NativeFieldInfoPtr__GameDataManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_GameDataManager));
      ServerBootstrapSystem.NativeFieldInfoPtr__EOSSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_EOSSession));
      ServerBootstrapSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ServerBootstrapSystem.NativeFieldInfoPtr__SceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SceneSystem));
      ServerBootstrapSystem.NativeFieldInfoPtr__SceneLoadSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SceneLoadSystem));
      ServerBootstrapSystem.NativeFieldInfoPtr__SteamPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SteamPlatformSystem));
      ServerBootstrapSystem.NativeFieldInfoPtr__KickBanSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_KickBanSystem));
      ServerBootstrapSystem.NativeFieldInfoPtr__AdminAuthSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_AdminAuthSystem));
      ServerBootstrapSystem.NativeFieldInfoPtr__PacketBookkeeperSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_PacketBookkeeperSystem));
      ServerBootstrapSystem.NativeFieldInfoPtr__ServerDiscoveryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_ServerDiscoveryData));
      ServerBootstrapSystem.NativeFieldInfoPtr__EditorSpawnChunkAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_EditorSpawnChunkAccessor));
      ServerBootstrapSystem.NativeFieldInfoPtr__BalanceSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_BalanceSettingsAccessor));
      ServerBootstrapSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_WorldFrame));
      ServerBootstrapSystem.NativeFieldInfoPtr__InactiveEntitiesToEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_InactiveEntitiesToEnable));
      ServerBootstrapSystem.NativeFieldInfoPtr__AllowDebugCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_AllowDebugCommands));
      ServerBootstrapSystem.NativeFieldInfoPtr__IsGameDataInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_IsGameDataInitialized));
      ServerBootstrapSystem.NativeFieldInfoPtr__LoadingSuccessful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_LoadingSuccessful));
      ServerBootstrapSystem.NativeFieldInfoPtr__ServerWasInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_ServerWasInitialized));
      ServerBootstrapSystem.NativeFieldInfoPtr__AuthSessionResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_AuthSessionResponses));
      ServerBootstrapSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      ServerBootstrapSystem.NativeFieldInfoPtr__LoadingDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_LoadingDataBuffer));
      ServerBootstrapSystem.NativeFieldInfoPtr__LoadingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_LoadingData));
      ServerBootstrapSystem.NativeFieldInfoPtr_SessionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (SessionGuid));
      ServerBootstrapSystem.NativeFieldInfoPtr_SessionGuidAsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (SessionGuidAsString));
      ServerBootstrapSystem.NativeFieldInfoPtr_MaxUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (MaxUsers));
      ServerBootstrapSystem.NativeFieldInfoPtr_MaxAdmins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (MaxAdmins));
      ServerBootstrapSystem.NativeFieldInfoPtr_MinFreeSlotsNeededForNewUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (MinFreeSlotsNeededForNewUsers));
      ServerBootstrapSystem.NativeFieldInfoPtr_HailMessage_Server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (HailMessage_Server));
      ServerBootstrapSystem.NativeFieldInfoPtr__NextReloadSettingsCheckTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_NextReloadSettingsCheckTime));
      ServerBootstrapSystem.NativeFieldInfoPtr__LastUpdatedMetricsSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_LastUpdatedMetricsSecond));
      ServerBootstrapSystem.NativeFieldInfoPtr_EXPENSIVE_METRICS_DELAY_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (EXPENSIVE_METRICS_DELAY_SECONDS));
      ServerBootstrapSystem.NativeFieldInfoPtr__LastUpdatedActivitySecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_LastUpdatedActivitySecond));
      ServerBootstrapSystem.NativeFieldInfoPtr_UPDATE_ACTIVITY_DELAY_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (UPDATE_ACTIVITY_DELAY_SECONDS));
      ServerBootstrapSystem.NativeFieldInfoPtr__PlatformIdRemappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_PlatformIdRemappings));
      ServerBootstrapSystem.NativeFieldInfoPtr_AllConnectedUsersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (AllConnectedUsersList));
      ServerBootstrapSystem.NativeFieldInfoPtr__GameTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_GameTags));
      ServerBootstrapSystem.NativeFieldInfoPtr__CachedGameTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_CachedGameTags));
      ServerBootstrapSystem.NativeFieldInfoPtr__GameTagsModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_GameTagsModified));
      ServerBootstrapSystem.NativeFieldInfoPtr__InitServerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_InitServerData));
      ServerBootstrapSystem.NativeFieldInfoPtr__NextPlatformUserUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_NextPlatformUserUpdate));
      ServerBootstrapSystem.NativeFieldInfoPtr_HIGH_ACTIVITY_CONSTANT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (HIGH_ACTIVITY_CONSTANT));
      ServerBootstrapSystem.NativeFieldInfoPtr_MID_ACTIVITY_CONSTANT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (MID_ACTIVITY_CONSTANT));
      ServerBootstrapSystem.NativeFieldInfoPtr__ActiveNewUsersScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_ActiveNewUsersScore));
      ServerBootstrapSystem.NativeFieldInfoPtr__OnlineUsersInStartCave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_OnlineUsersInStartCave));
      ServerBootstrapSystem.NativeFieldInfoPtr__FreeTerritoriesPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_FreeTerritoriesPerRegion));
      ServerBootstrapSystem.NativeFieldInfoPtr__UsedTerritoriesPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_UsedTerritoriesPerRegion));
      ServerBootstrapSystem.NativeFieldInfoPtr__ActiveUsersPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_ActiveUsersPerRegion));
      ServerBootstrapSystem.NativeFieldInfoPtr__UsersPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_UsersPerRegion));
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateUsersTaken_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateUsersTaken_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateUsersTaken_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateUsersTaken_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAFKKick_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateAFKKick_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAFKKick_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateAFKKick_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdatePlatformData_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdatePlatformData_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdatePlatformData_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdatePlatformData_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateActivityLevel_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateActivityLevel_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateActivityLevel_LambdaJob1_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateActivityLevel_LambdaJob1_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___NetworkEventLogging_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>NetworkEventLogging_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___NetworkEventLogging_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>NetworkEventLogging_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___OnGameDataInitialized_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>OnGameDataInitialized_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___OnGameDataInitialized_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>OnGameDataInitialized_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateLatency_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateLatency_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateLatency_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateLatency_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___OnUserConnected_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>OnUserConnected_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___OnUserConnected_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>OnUserConnected_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>OnUserDisconnected_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>OnUserDisconnected_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>OnUserDisconnected_LambdaJob1_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>OnUserDisconnected_LambdaJob1_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___FindClanMembers_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>FindClanMembers_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>TryAuthenticate_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>TryAuthenticate_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>TryAuthenticate_LambdaJob1_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>TryAuthenticate_LambdaJob1_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAllConnectedUsersData_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateAllConnectedUsersData_LambdaJob0_entityQuery");
      ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAllConnectedUsersData_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>UpdateAllConnectedUsersData_LambdaJob0_profilerMarker");
      ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_6));
      ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DayNightCycle_7));
      ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerGameBalanceSettings_8));
      ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_9));
      ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_RelicDropped_10));
      ServerBootstrapSystem.NativeMethodInfoPtr_get_ServerHostData_Public_get_ServerHostData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675664);
      ServerBootstrapSystem.NativeMethodInfoPtr_get_ServerIsInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675665);
      ServerBootstrapSystem.NativeMethodInfoPtr_get_GameBootstrap_Public_get_GameBootstrap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675666);
      ServerBootstrapSystem.NativeMethodInfoPtr_get_StartingItemSets_Public_get_List_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675667);
      ServerBootstrapSystem.NativeMethodInfoPtr_get_SimulatedLatency_Public_get_SimulationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675668);
      ServerBootstrapSystem.NativeMethodInfoPtr_set_SimulatedLatency_Public_set_Void_SimulationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675669);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetNetworkStats_Public_byref_ServerTransportStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675670);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675671);
      ServerBootstrapSystem.NativeMethodInfoPtr_LoadPlatformIdRemappings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675672);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675673);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675674);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateUsersTaken_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675675);
      ServerBootstrapSystem.NativeMethodInfoPtr_ServerLoadingCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675676);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateAFKKick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675677);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateLoadingData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675678);
      ServerBootstrapSystem.NativeMethodInfoPtr_SetServerGameTag_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675679);
      ServerBootstrapSystem.NativeMethodInfoPtr_RemoveServerGameTag_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675680);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdatePlatformData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675681);
      ServerBootstrapSystem.NativeMethodInfoPtr_ReloadSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675682);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateMetrics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675683);
      ServerBootstrapSystem.NativeMethodInfoPtr_SetMetricsData_Private_Void_NativeHashMap_2_Int32_Int32_Dictionary_2_WorldRegionType_GaugeAPI_WorldRegionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675684);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetProfilerData_Private_Void_byref_ProfilerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675685);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnAuthSessionResponse_Private_Void_UInt64_AuthSessionResponseEnum_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675686);
      ServerBootstrapSystem.NativeMethodInfoPtr_HandleAuthSessionResponses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675687);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateInGameDay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675688);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateActivityLevel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675689);
      ServerBootstrapSystem.NativeMethodInfoPtr_IncrementActivityPerRegion_Private_Static_Void_NativeHashMap_2_Int32_Int32_WorldRegionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675690);
      ServerBootstrapSystem.NativeMethodInfoPtr_NetworkEventLogging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675691);
      ServerBootstrapSystem.NativeMethodInfoPtr_HandleCreateCharacterEventInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675692);
      ServerBootstrapSystem.NativeMethodInfoPtr_TryGetCryptSpawn_Private_Boolean_NetworkId_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675693);
      ServerBootstrapSystem.NativeMethodInfoPtr_TryGetWaypointSpawn_Private_Boolean_NetworkId_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675694);
      ServerBootstrapSystem.NativeMethodInfoPtr_CheckIfResetServer_Public_Static_Void_byref_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675695);
      ServerBootstrapSystem.NativeMethodInfoPtr_InitializeSessionGuid_Private_Void_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675696);
      ServerBootstrapSystem.NativeMethodInfoPtr_InitializeServer_Public_Void_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675697);
      ServerBootstrapSystem.NativeMethodInfoPtr_BeginSetupServer_Public_Void_GameBootstrap_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675698);
      ServerBootstrapSystem.NativeMethodInfoPtr_Shutdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675699);
      ServerBootstrapSystem.NativeMethodInfoPtr_FinalizeSetupServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675700);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetLoadToTargetWorldConfig_Private_LoadToTargetWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675701);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnGameDataInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675702);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateServerFPS_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675703);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateLatency_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675704);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnConnectionApproval_Private_Void_byref_NetBufferIn_NetConnectionId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675705);
      ServerBootstrapSystem.NativeMethodInfoPtr_TryAuthenticate_Private_Void_NetConnectionId_Int32_UInt64_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675706);
      ServerBootstrapSystem.NativeMethodInfoPtr_ApproveClient_Private_Boolean_NetConnectionId_Int32_UInt64_String_Boolean_Boolean_byref_User_Entity_ConnectAddress_ConnectAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675707);
      ServerBootstrapSystem.NativeMethodInfoPtr_DisconnectOldUser_Private_Boolean_NetConnectionId_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675708);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetResetDateTime_Public_Static_DateTime_DateTime_Int32_ResetDayEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675709);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnUserConnected_Private_Void_NetConnectionId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675710);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetEntitiesToEnableForInactiveCharacter_Private_Static_Void_EntityManager_NativeList_1_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675711);
      ServerBootstrapSystem.NativeMethodInfoPtr_RemoveDisableFromEntities_Private_Static_Void_EntityManager_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675712);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetInactiveEntitiesToEnable_Private_Static_Void_NativeList_1_Entity_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675713);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnUserDisconnected_Private_Void_NetConnectionId_ConnectionStatusChangeReason_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675714);
      ServerBootstrapSystem.NativeMethodInfoPtr_CreateUserConnectedEvent_Private_Void_Entity_ConnectedUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675715);
      ServerBootstrapSystem.NativeMethodInfoPtr_CreateUserDisconnectedEvent_Private_Void_Entity_ConnectedUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675716);
      ServerBootstrapSystem.NativeMethodInfoPtr_SendClanStatusUpdate_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675717);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnDataReceivedServer_Private_Void_byref_NetBufferIn_NetConnectionId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675718);
      ServerBootstrapSystem.NativeMethodInfoPtr_DeserializeReliableEventsPacketServer_Private_Void_Int32_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675719);
      ServerBootstrapSystem.NativeMethodInfoPtr_DeserializeUserStateSyncServer_Private_Void_NetBufferIn_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675720);
      ServerBootstrapSystem.NativeMethodInfoPtr_SendPacketToUser_Public_Virtual_Final_New_StunNetSendResult_NativeArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675721);
      ServerBootstrapSystem.NativeMethodInfoPtr_TryAuthenticate_Private_Boolean_UInt64_UserContentFlags_Boolean_byref_Boolean_byref_Boolean_byref_ConnectionStatusChangeReason_byref_User_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675722);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetRemappedPlatformId_Private_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675723);
      ServerBootstrapSystem.NativeMethodInfoPtr_ClearUserNetworkState_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675724);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetCustomSpawnPosition_Public_Nullable_Unboxed_1_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675725);
      ServerBootstrapSystem.NativeMethodInfoPtr_GetCustomSpawnPosition_Public_Static_Nullable_Unboxed_1_float3_SingletonAccessor_1_EditorSpawnChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675726);
      ServerBootstrapSystem.NativeMethodInfoPtr_SpawnCharacter_Public_Static_Entity_EntityCommandBuffer_Entity_Entity_Nullable_Unboxed_1_float3_Entity_Entity_Int32_CustomizationFeatures_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675727);
      ServerBootstrapSystem.NativeMethodInfoPtr_RespawnCharacter_Public_Entity_EntityCommandBuffer_Entity_Nullable_Unboxed_1_float3_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675728);
      ServerBootstrapSystem.NativeMethodInfoPtr_RespawnCharacter_Public_Entity_EntityManager_EntityCommandBuffer_Entity_PrefabGUID_PrefabLookupMap_Nullable_Unboxed_1_float3_Entity_Entity_Int32_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675729);
      ServerBootstrapSystem.NativeMethodInfoPtr_SpawnFadeToBlackEntity_Public_Entity_EntityCommandBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675730);
      ServerBootstrapSystem.NativeMethodInfoPtr_Kick_Public_Boolean_UInt64_ConnectionStatusChangeReason_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675731);
      ServerBootstrapSystem.NativeMethodInfoPtr_SendRevealedMapData_Private_Void_Entity_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675732);
      ServerBootstrapSystem.NativeMethodInfoPtr_SendDiscoveredMapZones_Private_Void_Entity_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675733);
      ServerBootstrapSystem.NativeMethodInfoPtr_SendClaimedAchievements_Private_Void_Entity_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675734);
      ServerBootstrapSystem.NativeMethodInfoPtr_SendInitialUnlockedProgressionEvent_Private_Void_Entity_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675735);
      ServerBootstrapSystem.NativeMethodInfoPtr_SendScrambleGamemodeSettings_Private_Void_Entity_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675736);
      ServerBootstrapSystem.NativeMethodInfoPtr_SendAllUsers_Private_Void_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675737);
      ServerBootstrapSystem.NativeMethodInfoPtr_UpdateAllConnectedUsersData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675738);
      ServerBootstrapSystem.NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675739);
      ServerBootstrapSystem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675740);
      ServerBootstrapSystem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675741);
      ServerBootstrapSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675742);
      ServerBootstrapSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675743);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUsersTaken_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675744);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateAFKKick_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675745);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdatePlatformData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675746);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateActivityLevel_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675747);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateActivityLevel_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675748);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForNetworkEventLogging_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675749);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnGameDataInitialized_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675750);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateLatency_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675751);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUserConnected_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675752);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUserDisconnected_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675753);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUserDisconnected_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675754);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryAuthenticate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675755);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryAuthenticate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675756);
      ServerBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateAllConnectedUsersData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675757);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675758);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675759);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675760);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675761);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675762);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675763);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675764);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675765);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675766);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_9 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675767);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_10 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675768);
      ServerBootstrapSystem.NativeMethodInfoPtr_Method_Public_Static_Void_11 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, 100675769);
    }

    public ServerBootstrapSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SetupWorldState _SetupWorldState
    {
      get
      {
        return *(SetupWorldState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SetupWorldState));
      }
      [param: In] set
      {
        *(SetupWorldState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SetupWorldState)) = value;
      }
    }

    public unsafe IServerNetworkLayer _NetServer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__NetServer));
        return pointer == System.IntPtr.Zero ? (IServerNetworkLayer) null : new IServerNetworkLayer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__NetServer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerNetworkData _DefaultNetworkData
    {
      get
      {
        return *(ServerNetworkData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__DefaultNetworkData));
      }
      [param: In] set
      {
        *(ServerNetworkData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__DefaultNetworkData)) = value;
      }
    }

    public unsafe Stack<byte> _FreeApprovedUserIndexes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__FreeApprovedUserIndexes));
        return pointer == System.IntPtr.Zero ? (Stack<byte>) null : new Stack<byte>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__FreeApprovedUserIndexes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Stack<byte> _FreeApprovedAdminIndexes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__FreeApprovedAdminIndexes));
        return pointer == System.IntPtr.Zero ? (Stack<byte>) null : new Stack<byte>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__FreeApprovedAdminIndexes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ServerBootstrapSystem.ServerClient> _ApprovedUsersLookup
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ApprovedUsersLookup));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ServerBootstrapSystem.ServerClient>) null : new Il2CppReferenceArray<ServerBootstrapSystem.ServerClient>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ApprovedUsersLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<NetConnectionId, int> _NetEndPointToApprovedUserIndex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__NetEndPointToApprovedUserIndex));
        return pointer == System.IntPtr.Zero ? (Dictionary<NetConnectionId, int>) null : new Dictionary<NetConnectionId, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__NetEndPointToApprovedUserIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<ulong, int> _PlatformIdToApprovedUserIndex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__PlatformIdToApprovedUserIndex));
        return pointer == System.IntPtr.Zero ? (Dictionary<ulong, int>) null : new Dictionary<ulong, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__PlatformIdToApprovedUserIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, int> _UserIndexToApprovedUserIndex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__UserIndexToApprovedUserIndex));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, int>) null : new Dictionary<int, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__UserIndexToApprovedUserIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<byte> _HailDataBuffer
    {
      get
      {
        return *(NativeList<byte>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__HailDataBuffer));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__HailDataBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe double PLATFORM_USER_UPDATE_INTERVAL
    {
      get
      {
        double userUpdateInterval;
        IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.NativeFieldInfoPtr_PLATFORM_USER_UPDATE_INTERVAL, (void*) &userUpdateInterval);
        return userUpdateInterval;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.NativeFieldInfoPtr_PLATFORM_USER_UPDATE_INTERVAL, (void*) &value);
      }
    }

    public unsafe ServerHostData _ServerHostData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ServerHostData));
        return pointer == System.IntPtr.Zero ? (ServerHostData) null : new ServerHostData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ServerHostData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameBootstrap _GameBootstrap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__GameBootstrap));
        return pointer == System.IntPtr.Zero ? (GameBootstrap) null : new GameBootstrap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__GameBootstrap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataManager _GameDataManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__GameDataManager));
        return pointer == System.IntPtr.Zero ? (GameDataManager) null : new GameDataManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__GameDataManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Session _EOSSession
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__EOSSession));
        return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__EOSSession), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SceneSystem _SceneSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SceneSystem));
        return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SceneLoadSystem _SceneLoadSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SceneLoadSystem));
        return pointer == System.IntPtr.Zero ? (SceneLoadSystem) null : new SceneLoadSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SceneLoadSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SteamPlatformSystem _SteamPlatformSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SteamPlatformSystem));
        return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SteamPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe KickBanSystem_Server _KickBanSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__KickBanSystem));
        return pointer == System.IntPtr.Zero ? (KickBanSystem_Server) null : new KickBanSystem_Server(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__KickBanSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AdminAuthSystem _AdminAuthSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__AdminAuthSystem));
        return pointer == System.IntPtr.Zero ? (AdminAuthSystem) null : new AdminAuthSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__AdminAuthSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PacketBookkeeperSystem _PacketBookkeeperSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__PacketBookkeeperSystem));
        return pointer == System.IntPtr.Zero ? (PacketBookkeeperSystem) null : new PacketBookkeeperSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__PacketBookkeeperSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ServerDiscoveryData _ServerDiscoveryData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ServerDiscoveryData);
        return new ServerDiscoveryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ServerDiscoveryData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<EditorSpawnChunk> _EditorSpawnChunkAccessor
    {
      get
      {
        return *(SingletonAccessor<EditorSpawnChunk>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__EditorSpawnChunkAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__EditorSpawnChunkAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<EditorSpawnChunk>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _BalanceSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__BalanceSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__BalanceSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _InactiveEntitiesToEnable
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__InactiveEntitiesToEnable));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__InactiveEntitiesToEnable), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _AllowDebugCommands
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__AllowDebugCommands));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__AllowDebugCommands)) = value;
      }
    }

    public unsafe bool _IsGameDataInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__IsGameDataInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__IsGameDataInitialized)) = value;
      }
    }

    public unsafe bool _LoadingSuccessful
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LoadingSuccessful));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LoadingSuccessful)) = value;
      }
    }

    public unsafe bool _ServerWasInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ServerWasInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ServerWasInitialized)) = value;
      }
    }

    public unsafe StructList<ServerBootstrapSystem.AuthSessionResponse> _AuthSessionResponses
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__AuthSessionResponses));
        return pointer == System.IntPtr.Zero ? (StructList<ServerBootstrapSystem.AuthSessionResponse>) null : new StructList<ServerBootstrapSystem.AuthSessionResponse>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__AuthSessionResponses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerDebugSettings _ServerDebugSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ServerDebugSettings));
        return pointer == System.IntPtr.Zero ? (ServerDebugSettings) null : new ServerDebugSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeArray<byte> _LoadingDataBuffer
    {
      get
      {
        return *(NativeArray<byte>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LoadingDataBuffer));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LoadingDataBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NetBufferOut _LoadingData
    {
      get
      {
        return *(NetBufferOut*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LoadingData));
      }
      [param: In] set
      {
        *(NetBufferOut*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LoadingData)) = value;
      }
    }

    public unsafe Il2CppSystem.Guid SessionGuid
    {
      get
      {
        return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_SessionGuid));
      }
      [param: In] set
      {
        *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_SessionGuid)) = value;
      }
    }

    public unsafe string SessionGuidAsString
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_SessionGuidAsString)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_SessionGuidAsString), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int MaxUsers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_MaxUsers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_MaxUsers)) = value;
      }
    }

    public unsafe int MaxAdmins
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_MaxAdmins));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_MaxAdmins)) = value;
      }
    }

    public unsafe int MinFreeSlotsNeededForNewUsers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_MinFreeSlotsNeededForNewUsers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_MinFreeSlotsNeededForNewUsers)) = value;
      }
    }

    public unsafe HailMessageStruct_Server HailMessage_Server
    {
      get
      {
        return *(HailMessageStruct_Server*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_HailMessage_Server));
      }
      [param: In] set
      {
        *(HailMessageStruct_Server*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_HailMessage_Server)) = value;
      }
    }

    public unsafe double _NextReloadSettingsCheckTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__NextReloadSettingsCheckTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__NextReloadSettingsCheckTime)) = value;
      }
    }

    public unsafe int _LastUpdatedMetricsSecond
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LastUpdatedMetricsSecond));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LastUpdatedMetricsSecond)) = value;
      }
    }

    public static unsafe int EXPENSIVE_METRICS_DELAY_SECONDS
    {
      get
      {
        int metricsDelaySeconds;
        IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.NativeFieldInfoPtr_EXPENSIVE_METRICS_DELAY_SECONDS, (void*) &metricsDelaySeconds);
        return metricsDelaySeconds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.NativeFieldInfoPtr_EXPENSIVE_METRICS_DELAY_SECONDS, (void*) &value);
      }
    }

    public unsafe double _LastUpdatedActivitySecond
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LastUpdatedActivitySecond));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__LastUpdatedActivitySecond)) = value;
      }
    }

    public static unsafe int UPDATE_ACTIVITY_DELAY_SECONDS
    {
      get
      {
        int activityDelaySeconds;
        IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.NativeFieldInfoPtr_UPDATE_ACTIVITY_DELAY_SECONDS, (void*) &activityDelaySeconds);
        return activityDelaySeconds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.NativeFieldInfoPtr_UPDATE_ACTIVITY_DELAY_SECONDS, (void*) &value);
      }
    }

    public unsafe Dictionary<ulong, ulong> _PlatformIdRemappings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__PlatformIdRemappings));
        return pointer == System.IntPtr.Zero ? (Dictionary<ulong, ulong>) null : new Dictionary<ulong, ulong>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__PlatformIdRemappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnsafeList<ServerBootstrapSystem.UserData> AllConnectedUsersList
    {
      get
      {
        return *(UnsafeList<ServerBootstrapSystem.UserData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_AllConnectedUsersList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr_AllConnectedUsersList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnsafeList<ServerBootstrapSystem.UserData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<string> _GameTags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__GameTags));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__GameTags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _CachedGameTags
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__CachedGameTags)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__CachedGameTags), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _GameTagsModified
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__GameTagsModified));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__GameTagsModified)) = value;
      }
    }

    public unsafe bool _InitServerData
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__InitServerData));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__InitServerData)) = value;
      }
    }

    public unsafe double _NextPlatformUserUpdate
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__NextPlatformUserUpdate));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__NextPlatformUserUpdate)) = value;
      }
    }

    public static unsafe int HIGH_ACTIVITY_CONSTANT
    {
      get
      {
        int activityConstant;
        IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.NativeFieldInfoPtr_HIGH_ACTIVITY_CONSTANT, (void*) &activityConstant);
        return activityConstant;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.NativeFieldInfoPtr_HIGH_ACTIVITY_CONSTANT, (void*) &value);
      }
    }

    public static unsafe int MID_ACTIVITY_CONSTANT
    {
      get
      {
        int activityConstant;
        IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.NativeFieldInfoPtr_MID_ACTIVITY_CONSTANT, (void*) &activityConstant);
        return activityConstant;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.NativeFieldInfoPtr_MID_ACTIVITY_CONSTANT, (void*) &value);
      }
    }

    public unsafe float _ActiveNewUsersScore
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ActiveNewUsersScore));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ActiveNewUsersScore)) = value;
      }
    }

    public unsafe int _OnlineUsersInStartCave
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__OnlineUsersInStartCave));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__OnlineUsersInStartCave)) = value;
      }
    }

    public unsafe NativeHashMap<int, int> _FreeTerritoriesPerRegion
    {
      get
      {
        return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__FreeTerritoriesPerRegion));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__FreeTerritoriesPerRegion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<int, int> _UsedTerritoriesPerRegion
    {
      get
      {
        return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__UsedTerritoriesPerRegion));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__UsedTerritoriesPerRegion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<int, int> _ActiveUsersPerRegion
    {
      get
      {
        return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ActiveUsersPerRegion));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__ActiveUsersPerRegion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<int, int> _UsersPerRegion
    {
      get
      {
        return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__UsersPerRegion));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__UsersPerRegion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __UpdateUsersTaken_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateUsersTaken_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateUsersTaken_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateUsersTaken_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateUsersTaken_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateUsersTaken_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateAFKKick_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAFKKick_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAFKKick_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateAFKKick_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAFKKick_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAFKKick_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdatePlatformData_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdatePlatformData_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdatePlatformData_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdatePlatformData_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdatePlatformData_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdatePlatformData_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateActivityLevel_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateActivityLevel_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateActivityLevel_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateActivityLevel_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateActivityLevel_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __NetworkEventLogging_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___NetworkEventLogging_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___NetworkEventLogging_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __NetworkEventLogging_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___NetworkEventLogging_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___NetworkEventLogging_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnGameDataInitialized_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnGameDataInitialized_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnGameDataInitialized_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnGameDataInitialized_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnGameDataInitialized_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnGameDataInitialized_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateLatency_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateLatency_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateLatency_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateLatency_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateLatency_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateLatency_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUserConnected_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserConnected_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserConnected_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUserConnected_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserConnected_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserConnected_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUserDisconnected_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUserDisconnected_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUserDisconnected_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUserDisconnected_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___OnUserDisconnected_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __FindClanMembers_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___FindClanMembers_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___FindClanMembers_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TryAuthenticate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TryAuthenticate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TryAuthenticate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TryAuthenticate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___TryAuthenticate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateAllConnectedUsersData_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAllConnectedUsersData_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAllConnectedUsersData_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateAllConnectedUsersData_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAllConnectedUsersData_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr___UpdateAllConnectedUsersData_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_6
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_6));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_6)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DayNightCycle_7
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_7));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_7)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerGameBalanceSettings_8
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_8));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_8)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_9
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_9));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_9)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_RelicDropped_10
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_10));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_10)) = value;
      }
    }

    public sealed class ServerClient : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetConnectionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
      private static readonly System.IntPtr NativeFieldInfoPtr_EOSId;
      private static readonly System.IntPtr NativeFieldInfoPtr_ApprovedUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Exists;
      private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedAsAdmin;

      static ServerClient()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (ServerClient));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr);
        ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_UserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, nameof (UserEntity));
        ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_NetConnectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, nameof (NetConnectionId));
        ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, nameof (PlatformId));
        ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_EOSId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, nameof (EOSId));
        ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_ApprovedUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, nameof (ApprovedUserIndex));
        ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_Exists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, nameof (Exists));
        ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_ConnectedAsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, nameof (ConnectedAsAdmin));
      }

      public ServerClient(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ServerClient()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.ServerClient>.NativeClassPtr, data));
      }

      public unsafe Entity UserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_UserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_UserEntity)) = value;
        }
      }

      public unsafe NetConnectionId NetConnectionId
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_NetConnectionId));
          return pointer == System.IntPtr.Zero ? (NetConnectionId) null : new NetConnectionId(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_NetConnectionId), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ulong PlatformId
      {
        get
        {
          return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_PlatformId));
        }
        [param: In] set
        {
          *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_PlatformId)) = value;
        }
      }

      public unsafe ProductUserId EOSId
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_EOSId));
          return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_EOSId), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe byte ApprovedUserIndex
      {
        get
        {
          return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_ApprovedUserIndex));
        }
        [param: In] set
        {
          *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_ApprovedUserIndex)) = value;
        }
      }

      public unsafe bool Exists
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_Exists));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_Exists)) = value;
        }
      }

      public unsafe bool ConnectedAsAdmin
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_ConnectedAsAdmin));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.ServerClient.NativeFieldInfoPtr_ConnectedAsAdmin)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ProfilerData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TempAllocatorSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_MonoHeapSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_MonoUsedSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalAllocatedMemory;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalReservedMemory;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalUnusedReservedMemory;
      [FieldOffset(0)]
      public uint TempAllocatorSize;
      [FieldOffset(8)]
      public long MonoHeapSize;
      [FieldOffset(16)]
      public long MonoUsedSize;
      [FieldOffset(24)]
      public long TotalAllocatedMemory;
      [FieldOffset(32)]
      public long TotalReservedMemory;
      [FieldOffset(40)]
      public long TotalUnusedReservedMemory;

      static ProfilerData()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (ProfilerData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr);
        ServerBootstrapSystem.ProfilerData.NativeFieldInfoPtr_TempAllocatorSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr, nameof (TempAllocatorSize));
        ServerBootstrapSystem.ProfilerData.NativeFieldInfoPtr_MonoHeapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr, nameof (MonoHeapSize));
        ServerBootstrapSystem.ProfilerData.NativeFieldInfoPtr_MonoUsedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr, nameof (MonoUsedSize));
        ServerBootstrapSystem.ProfilerData.NativeFieldInfoPtr_TotalAllocatedMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr, nameof (TotalAllocatedMemory));
        ServerBootstrapSystem.ProfilerData.NativeFieldInfoPtr_TotalReservedMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr, nameof (TotalReservedMemory));
        ServerBootstrapSystem.ProfilerData.NativeFieldInfoPtr_TotalUnusedReservedMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr, nameof (TotalUnusedReservedMemory));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.ProfilerData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UserData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterName;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsAdmin;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsConnected;
      [FieldOffset(0)]
      public FixedString64 CharacterName;
      [FieldOffset(64)]
      public ulong PlatformId;
      [FieldOffset(72)]
      public NetworkId NetworkId;
      [FieldOffset(80)]
      public bool IsAdmin;
      [FieldOffset(81)]
      public bool IsConnected;

      static UserData()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.UserData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (UserData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.UserData>.NativeClassPtr);
        ServerBootstrapSystem.UserData.NativeFieldInfoPtr_CharacterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.UserData>.NativeClassPtr, nameof (CharacterName));
        ServerBootstrapSystem.UserData.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.UserData>.NativeClassPtr, nameof (PlatformId));
        ServerBootstrapSystem.UserData.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.UserData>.NativeClassPtr, nameof (NetworkId));
        ServerBootstrapSystem.UserData.NativeFieldInfoPtr_IsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.UserData>.NativeClassPtr, nameof (IsAdmin));
        ServerBootstrapSystem.UserData.NativeFieldInfoPtr_IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.UserData>.NativeClassPtr, nameof (IsConnected));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.UserData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class MatchmakingServerData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SessionGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_Tags;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasPassword;
      private static readonly System.IntPtr NativeFieldInfoPtr_ListOnSteam;
      private static readonly System.IntPtr NativeFieldInfoPtr_ListOnEOS;
      private static readonly System.IntPtr NativeFieldInfoPtr_Branch;
      private static readonly System.IntPtr NativeFieldInfoPtr_DaysRunning;
      private static readonly System.IntPtr NativeFieldInfoPtr_DaysUntilReset;

      static MatchmakingServerData()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (MatchmakingServerData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr);
        ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_SessionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, nameof (SessionGuid));
        ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, nameof (Tags));
        ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_HasPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, nameof (HasPassword));
        ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_ListOnSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, nameof (ListOnSteam));
        ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_ListOnEOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, nameof (ListOnEOS));
        ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_Branch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, nameof (Branch));
        ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_DaysRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, nameof (DaysRunning));
        ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_DaysUntilReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, nameof (DaysUntilReset));
      }

      public MatchmakingServerData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public MatchmakingServerData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.MatchmakingServerData>.NativeClassPtr, data));
      }

      public unsafe string SessionGuid
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_SessionGuid)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_SessionGuid), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Tags
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_Tags)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_Tags), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe bool HasPassword
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_HasPassword));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_HasPassword)) = value;
        }
      }

      public unsafe bool ListOnSteam
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_ListOnSteam));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_ListOnSteam)) = value;
        }
      }

      public unsafe bool ListOnEOS
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_ListOnEOS));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_ListOnEOS)) = value;
        }
      }

      public unsafe string Branch
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_Branch)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_Branch), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int DaysRunning
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_DaysRunning));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_DaysRunning)) = value;
        }
      }

      public unsafe Nullable_Unboxed<int> DaysUntilReset
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_DaysUntilReset));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.MatchmakingServerData.NativeFieldInfoPtr_DaysUntilReset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AuthSessionResponse
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
      private static readonly System.IntPtr NativeFieldInfoPtr_Response;
      private static readonly System.IntPtr NativeFieldInfoPtr_UserContent;
      [FieldOffset(0)]
      public ulong PlatformId;
      [FieldOffset(8)]
      public AuthSessionResponseEnum Response;
      [FieldOffset(12)]
      public UserContentFlags UserContent;

      static AuthSessionResponse()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.AuthSessionResponse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (AuthSessionResponse));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.AuthSessionResponse>.NativeClassPtr);
        ServerBootstrapSystem.AuthSessionResponse.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.AuthSessionResponse>.NativeClassPtr, nameof (PlatformId));
        ServerBootstrapSystem.AuthSessionResponse.NativeFieldInfoPtr_Response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.AuthSessionResponse>.NativeClassPtr, nameof (Response));
        ServerBootstrapSystem.AuthSessionResponse.NativeFieldInfoPtr_UserContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.AuthSessionResponse>.NativeClassPtr, nameof (UserContent));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.AuthSessionResponse>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class SessionId : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Id;
      private static readonly System.IntPtr NativeFieldInfoPtr__id;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979741, XrefRangeEnd = 979744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.SessionId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static SessionId()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.SessionId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, nameof (SessionId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.SessionId>.NativeClassPtr);
        ServerBootstrapSystem.SessionId.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.SessionId>.NativeClassPtr, nameof (Id));
        ServerBootstrapSystem.SessionId.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.SessionId>.NativeClassPtr, nameof (_id));
        ServerBootstrapSystem.SessionId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.SessionId>.NativeClassPtr, 100675770);
      }

      public SessionId(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SessionId()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.SessionId>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.SessionId>.NativeClassPtr, data));
      }

      public unsafe Il2CppSystem.Guid Id
      {
        get
        {
          return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.SessionId.NativeFieldInfoPtr_Id));
        }
        [param: In] set
        {
          *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.SessionId.NativeFieldInfoPtr_Id)) = value;
        }
      }

      public unsafe string _id
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.SessionId.NativeFieldInfoPtr__id)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.SessionId.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass68_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass68_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_numOfUsers;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateUsersTaken_b__0_Internal_Void_byref_User_byref_NetworkId_0;
      [FieldOffset(0)]
      public int numOfUsers;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass68_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateUsersTaken_b__0([In] ref User user, [In] ref NetworkId networkId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass68_0.NativeMethodInfoPtr__UpdateUsersTaken_b__0_Internal_Void_byref_User_byref_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass68_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass68_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass68_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass68_0.NativeFieldInfoPtr_numOfUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass68_0>.NativeClassPtr, nameof (numOfUsers));
        ServerBootstrapSystem.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass68_0>.NativeClassPtr, 100675771);
        ServerBootstrapSystem.__c__DisplayClass68_0.NativeMethodInfoPtr__UpdateUsersTaken_b__0_Internal_Void_byref_User_byref_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass68_0>.NativeClassPtr, 100675772);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass68_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass70_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass70_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTicks;
      private static readonly System.IntPtr NativeFieldInfoPtr_durationForWarning;
      private static readonly System.IntPtr NativeFieldInfoPtr_usersToAFKWarn;
      private static readonly System.IntPtr NativeFieldInfoPtr_durationForKick;
      private static readonly System.IntPtr NativeFieldInfoPtr_userIndicesToKick;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateAFKKick_b__0_Internal_Void_Entity_byref_User_byref_EntityInput_byref_ConnectedUser_0;
      [FieldOffset(0)]
      public long currentTicks;
      [FieldOffset(8)]
      public int durationForWarning;
      [FieldOffset(16)]
      public NativeList<User> usersToAFKWarn;
      [FieldOffset(32)]
      public int durationForKick;
      [FieldOffset(40)]
      public NativeList<byte> userIndicesToKick;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass70_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateAFKKick_b__0(
        Entity entity,
        ref User user,
        [In] ref EntityInput entityInput,
        [In] ref ConnectedUser connectedUser)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass70_0.NativeMethodInfoPtr__UpdateAFKKick_b__0_Internal_Void_Entity_byref_User_byref_EntityInput_byref_ConnectedUser_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass70_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass70_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass70_0.NativeFieldInfoPtr_currentTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr, nameof (currentTicks));
        ServerBootstrapSystem.__c__DisplayClass70_0.NativeFieldInfoPtr_durationForWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr, nameof (durationForWarning));
        ServerBootstrapSystem.__c__DisplayClass70_0.NativeFieldInfoPtr_usersToAFKWarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr, nameof (usersToAFKWarn));
        ServerBootstrapSystem.__c__DisplayClass70_0.NativeFieldInfoPtr_durationForKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr, nameof (durationForKick));
        ServerBootstrapSystem.__c__DisplayClass70_0.NativeFieldInfoPtr_userIndicesToKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr, nameof (userIndicesToKick));
        ServerBootstrapSystem.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr, 100675773);
        ServerBootstrapSystem.__c__DisplayClass70_0.NativeMethodInfoPtr__UpdateAFKKick_b__0_Internal_Void_Entity_byref_User_byref_EntityInput_byref_ConnectedUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr, 100675774);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass70_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass79_0")]
    public sealed class __c__DisplayClass79_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_steamPlatform;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdatePlatformData_b__2_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass79_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass79_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdatePlatformData_b__2(
        Entity entity,
        [In] ref User userData,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref userData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass79_0.NativeMethodInfoPtr__UpdatePlatformData_b__2_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass79_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass79_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass79_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
        ServerBootstrapSystem.__c__DisplayClass79_0.NativeFieldInfoPtr_steamPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass79_0>.NativeClassPtr, nameof (steamPlatform));
        ServerBootstrapSystem.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass79_0>.NativeClassPtr, 100675775);
        ServerBootstrapSystem.__c__DisplayClass79_0.NativeMethodInfoPtr__UpdatePlatformData_b__2_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass79_0>.NativeClassPtr, 100675776);
      }

      public __c__DisplayClass79_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ServerBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SteamPlatformSystem steamPlatform
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass79_0.NativeFieldInfoPtr_steamPlatform));
          return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass79_0.NativeFieldInfoPtr_steamPlatform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__79_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__79_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__114_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__122_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdatePlatformData_b__79_0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdatePlatformData_b__79_1_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApproveClient_b__114_0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUserDisconnected_b__122_0_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979744, XrefRangeEnd = 979750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdatePlatformData_b__79_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c.NativeMethodInfoPtr__UpdatePlatformData_b__79_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979750, XrefRangeEnd = 979756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdatePlatformData_b__79_1(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c.NativeMethodInfoPtr__UpdatePlatformData_b__79_1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979756, XrefRangeEnd = 979766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApproveClient_b__114_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c.NativeMethodInfoPtr__ApproveClient_b__114_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979766, XrefRangeEnd = 979776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUserDisconnected_b__122_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c.NativeMethodInfoPtr__OnUserDisconnected_b__122_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr);
        ServerBootstrapSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, "<>9");
        ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__79_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, "<>9__79_0");
        ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__79_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, "<>9__79_1");
        ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__114_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, "<>9__114_0");
        ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__122_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, "<>9__122_0");
        ServerBootstrapSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, 100675778);
        ServerBootstrapSystem.__c.NativeMethodInfoPtr__UpdatePlatformData_b__79_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, 100675779);
        ServerBootstrapSystem.__c.NativeMethodInfoPtr__UpdatePlatformData_b__79_1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, 100675780);
        ServerBootstrapSystem.__c.NativeMethodInfoPtr__ApproveClient_b__114_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, 100675781);
        ServerBootstrapSystem.__c.NativeMethodInfoPtr__OnUserDisconnected_b__122_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c>.NativeClassPtr, 100675782);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ServerBootstrapSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem.__c) null : new ServerBootstrapSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe EOSOperationCompleteHandler __9__79_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__79_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__79_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe EOSOperationCompleteHandler __9__79_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__79_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__79_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe EOSOperationCompleteHandler __9__114_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__114_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__114_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe EOSOperationCompleteHandler __9__122_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__122_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c.NativeFieldInfoPtr___9__122_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass95_0")]
    public sealed class __c__DisplayClass95_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_usersInStartCave;
      private static readonly System.IntPtr NativeFieldInfoPtr_usersPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeUsersPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeUsersScore;
      private static readonly System.IntPtr NativeFieldInfoPtr_minTicks;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeNewUsersScore;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_usedTerritoriesPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_freeTerritoriesPerRegion;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateActivityLevel_b__0_Internal_Void_Entity_byref_CurrentWorldRegion_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateActivityLevel_b__1_Internal_Void_byref_CastleTerritory_byref_TerritoryWorldRegion_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass95_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass95_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateActivityLevel_b__0(
        Entity entity,
        [In] ref CurrentWorldRegion currentWorldRegion,
        [In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentWorldRegion;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass95_0.NativeMethodInfoPtr__UpdateActivityLevel_b__0_Internal_Void_Entity_byref_CurrentWorldRegion_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateActivityLevel_b__1(
        [In] ref CastleTerritory castleTerritory,
        [In] ref TerritoryWorldRegion territoryWorldRegion)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref territoryWorldRegion;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass95_0.NativeMethodInfoPtr__UpdateActivityLevel_b__1_Internal_Void_byref_CastleTerritory_byref_TerritoryWorldRegion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass95_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass95_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usersInStartCave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (usersInStartCave));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usersPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (usersPerRegion));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeUsersPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (activeUsersPerRegion));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeUsersScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (activeUsersScore));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_minTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (minTicks));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (entityManager));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeNewUsersScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (activeNewUsersScore));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, "<>4__this");
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usedTerritoriesPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (usedTerritoriesPerRegion));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_freeTerritoriesPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, nameof (freeTerritoriesPerRegion));
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, 100675783);
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeMethodInfoPtr__UpdateActivityLevel_b__0_Internal_Void_Entity_byref_CurrentWorldRegion_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, 100675784);
        ServerBootstrapSystem.__c__DisplayClass95_0.NativeMethodInfoPtr__UpdateActivityLevel_b__1_Internal_Void_byref_CastleTerritory_byref_TerritoryWorldRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, 100675785);
      }

      public __c__DisplayClass95_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass95_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass95_0>.NativeClassPtr, data));
      }

      public unsafe int usersInStartCave
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usersInStartCave));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usersInStartCave)) = value;
        }
      }

      public unsafe NativeHashMap<int, int> usersPerRegion
      {
        get
        {
          return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usersPerRegion));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usersPerRegion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<int, int> activeUsersPerRegion
      {
        get
        {
          return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeUsersPerRegion));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeUsersPerRegion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe float activeUsersScore
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeUsersScore));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeUsersScore)) = value;
        }
      }

      public unsafe long minTicks
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_minTicks));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_minTicks)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe float activeNewUsersScore
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeNewUsersScore));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_activeNewUsersScore)) = value;
        }
      }

      public unsafe ServerBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<int, int> usedTerritoriesPerRegion
      {
        get
        {
          return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usedTerritoriesPerRegion));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_usedTerritoriesPerRegion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<int, int> freeTerritoriesPerRegion
      {
        get
        {
          return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_freeTerritoriesPerRegion));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass95_0.NativeFieldInfoPtr_freeTerritoriesPerRegion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass97_0")]
    public sealed class __c__DisplayClass97_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_logAllNetworkEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_logAdminEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_logDebugEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__NetworkEventLogging_b__0_Internal_Void_Entity_byref_NetworkEventType_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass97_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _NetworkEventLogging_b__0(
        Entity entity,
        [In] ref NetworkEventType networkEventType,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkEventType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass97_0.NativeMethodInfoPtr__NetworkEventLogging_b__0_Internal_Void_Entity_byref_NetworkEventType_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass97_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass97_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logAllNetworkEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr, nameof (logAllNetworkEvents));
        ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logAdminEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr, nameof (logAdminEvents));
        ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr, nameof (logDebugEvents));
        ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr, "<>4__this");
        ServerBootstrapSystem.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr, 100675786);
        ServerBootstrapSystem.__c__DisplayClass97_0.NativeMethodInfoPtr__NetworkEventLogging_b__0_Internal_Void_Entity_byref_NetworkEventType_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr, 100675787);
      }

      public __c__DisplayClass97_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass97_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass97_0>.NativeClassPtr, data));
      }

      public unsafe bool logAllNetworkEvents
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logAllNetworkEvents));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logAllNetworkEvents)) = value;
        }
      }

      public unsafe bool logAdminEvents
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logAdminEvents));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logAdminEvents)) = value;
        }
      }

      public unsafe bool logDebugEvents
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logDebugEvents));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr_logDebugEvents)) = value;
        }
      }

      public unsafe ServerBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass109_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass109_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactiveEntitiesToEnable;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnGameDataInitialized_b__0_Internal_Void_Entity_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<Entity> inactiveEntitiesToEnable;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass109_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass109_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnGameDataInitialized_b__0(Entity userEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &userEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass109_0.NativeMethodInfoPtr__OnGameDataInitialized_b__0_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass109_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass109_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass109_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass109_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass109_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass109_0>.NativeClassPtr, nameof (entityManager));
        ServerBootstrapSystem.__c__DisplayClass109_0.NativeFieldInfoPtr_inactiveEntitiesToEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass109_0>.NativeClassPtr, nameof (inactiveEntitiesToEnable));
        ServerBootstrapSystem.__c__DisplayClass109_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass109_0>.NativeClassPtr, 100675788);
        ServerBootstrapSystem.__c__DisplayClass109_0.NativeMethodInfoPtr__OnGameDataInitialized_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass109_0>.NativeClassPtr, 100675789);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass109_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass111_0")]
    public sealed class __c__DisplayClass111_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLatency;
      private static readonly System.IntPtr NativeFieldInfoPtr_getController;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateLatency_b__0_Internal_Void_Entity_byref_ConnectedUser_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass111_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass111_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateLatency_b__0(Entity entity, [In] ref ConnectedUser connectedUser)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass111_0.NativeMethodInfoPtr__UpdateLatency_b__0_Internal_Void_Entity_byref_ConnectedUser_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass111_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass111_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr, "<>4__this");
        ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr_getLatency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr, nameof (getLatency));
        ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr_getController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr, nameof (getController));
        ServerBootstrapSystem.__c__DisplayClass111_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr, 100675790);
        ServerBootstrapSystem.__c__DisplayClass111_0.NativeMethodInfoPtr__UpdateLatency_b__0_Internal_Void_Entity_byref_ConnectedUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr, 100675791);
      }

      public __c__DisplayClass111_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass111_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass111_0>.NativeClassPtr, data));
      }

      public unsafe ServerBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentDataFromEntity<Latency> getLatency
      {
        get
        {
          return *(ComponentDataFromEntity<Latency>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr_getLatency));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr_getLatency), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Latency>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Controller> getController
      {
        get
        {
          return *(ComponentDataFromEntity<Controller>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr_getController));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass111_0.NativeFieldInfoPtr_getController), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Controller>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass118_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass118_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_userEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_connectedUser;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUserConnected_b__0_Internal_Void_byref_OnlySyncToUserBitMask_byref_DynamicBuffer_1_OnlySyncToUserBuffer_0;
      [FieldOffset(0)]
      public Entity userEntity;
      [FieldOffset(8)]
      public ConnectedUser connectedUser;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass118_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUserConnected_b__0(
        ref OnlySyncToUserBitMask bitMask,
        [In] ref DynamicBuffer<OnlySyncToUserBuffer> buffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref bitMask;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass118_0.NativeMethodInfoPtr__OnUserConnected_b__0_Internal_Void_byref_OnlySyncToUserBitMask_byref_DynamicBuffer_1_OnlySyncToUserBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass118_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass118_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass118_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass118_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass118_0.NativeFieldInfoPtr_userEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass118_0>.NativeClassPtr, nameof (userEntity));
        ServerBootstrapSystem.__c__DisplayClass118_0.NativeFieldInfoPtr_connectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass118_0>.NativeClassPtr, nameof (connectedUser));
        ServerBootstrapSystem.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass118_0>.NativeClassPtr, 100675792);
        ServerBootstrapSystem.__c__DisplayClass118_0.NativeMethodInfoPtr__OnUserConnected_b__0_Internal_Void_byref_OnlySyncToUserBitMask_byref_DynamicBuffer_1_OnlySyncToUserBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass118_0>.NativeClassPtr, 100675793);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass118_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass122_0")]
    public sealed class __c__DisplayClass122_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_approvedUserIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUserDisconnected_b__1_Internal_Void_byref_UpToDateUserBitMask_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUserDisconnected_b__2_Internal_Void_byref_OnlySyncToUserBitMask_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass122_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass122_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass122_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUserDisconnected_b__1(ref UpToDateUserBitMask upToDateMask)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref upToDateMask;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass122_0.NativeMethodInfoPtr__OnUserDisconnected_b__1_Internal_Void_byref_UpToDateUserBitMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUserDisconnected_b__2(ref OnlySyncToUserBitMask onlySyncToUserBitMask)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref onlySyncToUserBitMask;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass122_0.NativeMethodInfoPtr__OnUserDisconnected_b__2_Internal_Void_byref_OnlySyncToUserBitMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass122_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass122_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass122_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass122_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass122_0.NativeFieldInfoPtr_approvedUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass122_0>.NativeClassPtr, nameof (approvedUserIndex));
        ServerBootstrapSystem.__c__DisplayClass122_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass122_0>.NativeClassPtr, 100675794);
        ServerBootstrapSystem.__c__DisplayClass122_0.NativeMethodInfoPtr__OnUserDisconnected_b__1_Internal_Void_byref_UpToDateUserBitMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass122_0>.NativeClassPtr, 100675795);
        ServerBootstrapSystem.__c__DisplayClass122_0.NativeMethodInfoPtr__OnUserDisconnected_b__2_Internal_Void_byref_OnlySyncToUserBitMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass122_0>.NativeClassPtr, 100675796);
      }

      public __c__DisplayClass122_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int approvedUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass122_0.NativeFieldInfoPtr_approvedUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass122_0.NativeFieldInfoPtr_approvedUserIndex)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass125_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass125_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_userTeamReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_clanMembers;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SendClanStatusUpdate_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public TeamReference userTeamReference;
      [FieldOffset(24)]
      public NativeList<Entity> clanMembers;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass125_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass125_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SendClanStatusUpdate_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass125_0.NativeMethodInfoPtr__SendClanStatusUpdate_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass125_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass125_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass125_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass125_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass125_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass125_0>.NativeClassPtr, nameof (entityManager));
        ServerBootstrapSystem.__c__DisplayClass125_0.NativeFieldInfoPtr_userTeamReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass125_0>.NativeClassPtr, nameof (userTeamReference));
        ServerBootstrapSystem.__c__DisplayClass125_0.NativeFieldInfoPtr_clanMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass125_0>.NativeClassPtr, nameof (clanMembers));
        ServerBootstrapSystem.__c__DisplayClass125_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass125_0>.NativeClassPtr, 100675797);
        ServerBootstrapSystem.__c__DisplayClass125_0.NativeMethodInfoPtr__SendClanStatusUpdate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass125_0>.NativeClassPtr, 100675798);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass125_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass130_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass130_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mappedPlatformId;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_userIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_nextId;
      private static readonly System.IntPtr NativeFieldInfoPtr_numOfUsers;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryAuthenticate_b__0_Internal_Void_Entity_byref_User_0;
      [FieldOffset(0)]
      public ulong mappedPlatformId;
      [FieldOffset(8)]
      public Entity jobUserEntity;
      [FieldOffset(16)]
      public int userIndex;
      [FieldOffset(24)]
      public User localUser;
      [FieldOffset(176)]
      public int nextId;
      [FieldOffset(180)]
      public int numOfUsers;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass130_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass130_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TryAuthenticate_b__0(Entity entity, [In] ref User userData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref userData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass130_0.NativeMethodInfoPtr__TryAuthenticate_b__0_Internal_Void_Entity_byref_User_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass130_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass130_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass130_0.NativeFieldInfoPtr_mappedPlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, nameof (mappedPlatformId));
        ServerBootstrapSystem.__c__DisplayClass130_0.NativeFieldInfoPtr_jobUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, nameof (jobUserEntity));
        ServerBootstrapSystem.__c__DisplayClass130_0.NativeFieldInfoPtr_userIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, nameof (userIndex));
        ServerBootstrapSystem.__c__DisplayClass130_0.NativeFieldInfoPtr_localUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, nameof (localUser));
        ServerBootstrapSystem.__c__DisplayClass130_0.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, nameof (nextId));
        ServerBootstrapSystem.__c__DisplayClass130_0.NativeFieldInfoPtr_numOfUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, nameof (numOfUsers));
        ServerBootstrapSystem.__c__DisplayClass130_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, 100675799);
        ServerBootstrapSystem.__c__DisplayClass130_0.NativeMethodInfoPtr__TryAuthenticate_b__0_Internal_Void_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, 100675800);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass130_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass130_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mainWorldZoneMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryAuthenticate_b__1_Internal_Void_byref_WorldZoneId_0;
      [FieldOffset(0)]
      public Nullable_Unboxed<WorldZoneId> mainWorldZoneMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass130_1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass130_1.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TryAuthenticate_b__1([In] ref WorldZoneId worldZoneId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref worldZoneId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass130_1.NativeMethodInfoPtr__TryAuthenticate_b__1_Internal_Void_byref_WorldZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass130_1()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass130_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_1>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass130_1.NativeFieldInfoPtr_mainWorldZoneMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_1>.NativeClassPtr, nameof (mainWorldZoneMap));
        ServerBootstrapSystem.__c__DisplayClass130_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_1>.NativeClassPtr, 100675801);
        ServerBootstrapSystem.__c__DisplayClass130_1.NativeMethodInfoPtr__TryAuthenticate_b__1_Internal_Void_byref_WorldZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_1>.NativeClassPtr, 100675802);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass130_1>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/<>c__DisplayClass146_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass146_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_allConnectedUsersList;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateAllConnectedUsersData_b__0_Internal_Void_byref_User_byref_NetworkId_0;
      [FieldOffset(0)]
      public UnsafeList<ServerBootstrapSystem.UserData> allConnectedUsersList;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass146_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass146_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateAllConnectedUsersData_b__0([In] ref User user, [In] ref NetworkId networkId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass146_0.NativeMethodInfoPtr__UpdateAllConnectedUsersData_b__0_Internal_Void_byref_User_byref_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass146_0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass146_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass146_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass146_0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass146_0.NativeFieldInfoPtr_allConnectedUsersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass146_0>.NativeClassPtr, nameof (allConnectedUsersList));
        ServerBootstrapSystem.__c__DisplayClass146_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass146_0>.NativeClassPtr, 100675803);
        ServerBootstrapSystem.__c__DisplayClass146_0.NativeMethodInfoPtr__UpdateAllConnectedUsersData_b__0_Internal_Void_byref_User_byref_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass146_0>.NativeClassPtr, 100675804);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass146_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateUsersTaken_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateUsersTaken_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_numOfUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_NetworkId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass68_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int numOfUsers;
      [FieldOffset(8)]
      public ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 500919, RefRangeEnd = 500920, XrefRangeStart = 500919, XrefRangeEnd = 500920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref User user, [In] ref NetworkId networkId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 979865, RefRangeEnd = 979889, XrefRangeStart = 979865, XrefRangeEnd = 979865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass68_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(21)]
      [CachedScanResults(RefRangeStart = 979889, RefRangeEnd = 979910, XrefRangeStart = 979889, XrefRangeEnd = 979889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass68_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979910, XrefRangeEnd = 979912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979920, RefRangeEnd = 979921, XrefRangeStart = 979912, XrefRangeEnd = 979920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979923, RefRangeEnd = 979924, XrefRangeStart = 979921, XrefRangeEnd = 979923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass68_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass68_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979924, XrefRangeEnd = 979928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979928, XrefRangeEnd = 979934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateUsersTaken_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateUsersTaken_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr_numOfUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, nameof (numOfUsers));
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, 100675805);
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, 100675806);
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, 100675807);
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, 100675808);
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, 100675809);
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass68_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, 100675810);
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, 100675811);
        ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, 100675812);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkId;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<NetworkId> forParameter_networkId;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 979782, RefRangeEnd = 979783, XrefRangeStart = 979776, XrefRangeEnd = 979782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 979789, RefRangeEnd = 979790, XrefRangeStart = 979783, XrefRangeEnd = 979789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkId));
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675813);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675814);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkId;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<NetworkId>.Runtime runtime_networkId;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkId));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateUsersTaken_LambdaJob0/ProjectM.RunWithoutJobSystem_00003077$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00003077$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675815);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675816);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675817);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675818);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateUsersTaken_LambdaJob0/ProjectM.RunWithoutJobSystem_00003077$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979790, XrefRangeEnd = 979804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979804, XrefRangeEnd = 979822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979822, XrefRangeEnd = 979837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 979864, RefRangeEnd = 979865, XrefRangeStart = 979837, XrefRangeEnd = 979864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00003077$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675819);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675820);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675821);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675822);
          ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675824);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateUsersTaken_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateAFKKick_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateAFKKick_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTicks;
      private static readonly System.IntPtr NativeFieldInfoPtr_durationForWarning;
      private static readonly System.IntPtr NativeFieldInfoPtr_usersToAFKWarn;
      private static readonly System.IntPtr NativeFieldInfoPtr_durationForKick;
      private static readonly System.IntPtr NativeFieldInfoPtr_userIndicesToKick;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_EntityInput_byref_ConnectedUser_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass70_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass70_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass70_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public long currentTicks;
      [FieldOffset(8)]
      public int durationForWarning;
      [FieldOffset(16)]
      public NativeList<User> usersToAFKWarn;
      [FieldOffset(32)]
      public int durationForKick;
      [FieldOffset(40)]
      public NativeList<byte> userIndicesToKick;
      [FieldOffset(56)]
      public ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(160)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980031, XrefRangeEnd = 980039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref User user,
        [In] ref EntityInput entityInput,
        [In] ref ConnectedUser connectedUser)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_EntityInput_byref_ConnectedUser_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980039, RefRangeEnd = 980040, XrefRangeStart = 980039, XrefRangeEnd = 980039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass70_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass70_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980040, RefRangeEnd = 980041, XrefRangeStart = 980040, XrefRangeEnd = 980040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass70_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass70_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980041, XrefRangeEnd = 980043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980055, RefRangeEnd = 980056, XrefRangeStart = 980043, XrefRangeEnd = 980055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980058, RefRangeEnd = 980059, XrefRangeStart = 980056, XrefRangeEnd = 980058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass70_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass70_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980059, XrefRangeEnd = 980063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980063, XrefRangeEnd = 980069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateAFKKick_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateAFKKick_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_currentTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (currentTicks));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_durationForWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (durationForWarning));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_usersToAFKWarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (usersToAFKWarn));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_durationForKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (durationForKick));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_userIndicesToKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (userIndicesToKick));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_EntityInput_byref_ConnectedUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, 100675825);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass70_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, 100675826);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass70_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, 100675827);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, 100675828);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, 100675829);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass70_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, 100675830);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, 100675831);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, 100675832);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityInput;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_connectedUser;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<EntityInput> forParameter_entityInput;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<ConnectedUser> forParameter_connectedUser;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 979944, RefRangeEnd = 979945, XrefRangeStart = 979934, XrefRangeEnd = 979944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 979955, RefRangeEnd = 979956, XrefRangeStart = 979945, XrefRangeEnd = 979955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityInput));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_connectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_connectedUser));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675833);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675834);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityInput;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_connectedUser;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<EntityInput>.Runtime runtime_entityInput;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<ConnectedUser>.Runtime runtime_connectedUser;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityInput));
            ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_connectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_connectedUser));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateAFKKick_LambdaJob0/ProjectM.RunWithoutJobSystem_00003080$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00003080$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675835);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675836);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675837);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675838);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateAFKKick_LambdaJob0/ProjectM.RunWithoutJobSystem_00003080$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979956, XrefRangeEnd = 979970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979970, XrefRangeEnd = 979988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979988, XrefRangeEnd = 980003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980030, RefRangeEnd = 980031, XrefRangeStart = 980003, XrefRangeEnd = 980030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00003080$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675839);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675840);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675841);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675842);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675844);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAFKKick_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdatePlatformData_LambdaJob0")]
    public sealed class __c__DisplayClass_UpdatePlatformData_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_steamPlatform;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass79_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass79_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass79_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980097, RefRangeEnd = 980098, XrefRangeStart = 980085, XrefRangeEnd = 980097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User userData,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref userData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980101, RefRangeEnd = 980102, XrefRangeStart = 980098, XrefRangeEnd = 980101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ServerBootstrapSystem.__c__DisplayClass79_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass79_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980105, RefRangeEnd = 980106, XrefRangeStart = 980102, XrefRangeEnd = 980105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ServerBootstrapSystem.__c__DisplayClass79_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass79_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980106, XrefRangeEnd = 980108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980117, RefRangeEnd = 980118, XrefRangeStart = 980108, XrefRangeEnd = 980117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980120, RefRangeEnd = 980121, XrefRangeStart = 980118, XrefRangeEnd = 980120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ServerBootstrapSystem.__c__DisplayClass79_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass79_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980121, XrefRangeEnd = 980127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdatePlatformData_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_UpdatePlatformData_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, "<>4__this");
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr_steamPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, nameof (steamPlatform));
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, 100675845);
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass79_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, 100675846);
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass79_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, 100675847);
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, 100675848);
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, 100675849);
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass79_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, 100675850);
        ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, 100675851);
      }

      public __c__DisplayClass_UpdatePlatformData_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdatePlatformData_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ServerBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SteamPlatformSystem steamPlatform
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr_steamPlatform));
          return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr_steamPlatform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_userData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_userData;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980076, RefRangeEnd = 980077, XrefRangeStart = 980069, XrefRangeEnd = 980076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980084, RefRangeEnd = 980085, XrefRangeStart = 980077, XrefRangeEnd = 980084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_userData));
          ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675852);
          ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675853);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_userData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_userData;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_userData));
            ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdatePlatformData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateActivityLevel_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateActivityLevel_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_usersInStartCave;
      private static readonly System.IntPtr NativeFieldInfoPtr_usersPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeUsersPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeUsersScore;
      private static readonly System.IntPtr NativeFieldInfoPtr_minTicks;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeNewUsersScore;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CurrentWorldRegion_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass95_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int usersInStartCave;
      [FieldOffset(8)]
      public NativeHashMap<int, int> usersPerRegion;
      [FieldOffset(24)]
      public NativeHashMap<int, int> activeUsersPerRegion;
      [FieldOffset(40)]
      public float activeUsersScore;
      [FieldOffset(48)]
      public long minTicks;
      [FieldOffset(56)]
      public EntityManager entityManager;
      [FieldOffset(64)]
      public float activeNewUsersScore;
      [FieldOffset(72)]
      public ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(144)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980218, XrefRangeEnd = 980243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref CurrentWorldRegion currentWorldRegion,
        [In] ref User user)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentWorldRegion;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CurrentWorldRegion_byref_User_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980243, RefRangeEnd = 980244, XrefRangeStart = 980243, XrefRangeEnd = 980243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass95_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980244, RefRangeEnd = 980245, XrefRangeStart = 980244, XrefRangeEnd = 980244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass95_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980245, XrefRangeEnd = 980247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980256, RefRangeEnd = 980257, XrefRangeStart = 980247, XrefRangeEnd = 980256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980259, RefRangeEnd = 980260, XrefRangeStart = 980257, XrefRangeEnd = 980259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass95_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass95_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980260, XrefRangeEnd = 980264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980264, XrefRangeEnd = 980270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateActivityLevel_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateActivityLevel_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_usersInStartCave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (usersInStartCave));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_usersPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (usersPerRegion));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_activeUsersPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (activeUsersPerRegion));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_activeUsersScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (activeUsersScore));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_minTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (minTicks));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_activeNewUsersScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (activeNewUsersScore));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CurrentWorldRegion_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, 100675854);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, 100675855);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, 100675856);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, 100675857);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, 100675858);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass95_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, 100675859);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, 100675860);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, 100675861);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_currentWorldRegion;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CurrentWorldRegion> forParameter_currentWorldRegion;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980134, RefRangeEnd = 980135, XrefRangeStart = 980127, XrefRangeEnd = 980134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980142, RefRangeEnd = 980143, XrefRangeStart = 980135, XrefRangeEnd = 980142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_currentWorldRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_currentWorldRegion));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675862);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675863);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_currentWorldRegion;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CurrentWorldRegion>.Runtime runtime_currentWorldRegion;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_currentWorldRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_currentWorldRegion));
            ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateActivityLevel_LambdaJob0/ProjectM.RunWithoutJobSystem_00003092$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00003092$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675864);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675865);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675866);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675867);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateActivityLevel_LambdaJob0/ProjectM.RunWithoutJobSystem_00003092$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980143, XrefRangeEnd = 980157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980157, XrefRangeEnd = 980175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980175, XrefRangeEnd = 980190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980217, RefRangeEnd = 980218, XrefRangeStart = 980190, XrefRangeEnd = 980217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00003092$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675868);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675869);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675870);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675871);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675873);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateActivityLevel_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateActivityLevel_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_usedTerritoriesPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_freeTerritoriesPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Pylonstation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_byref_TerritoryWorldRegion_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass95_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<int, int> usedTerritoriesPerRegion;
      [FieldOffset(16)]
      public NativeHashMap<int, int> freeTerritoriesPerRegion;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Pylonstation> _ComponentDataFromEntity_Pylonstation_0;
      [FieldOffset(64)]
      public ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980359, XrefRangeEnd = 980368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref CastleTerritory castleTerritory,
        [In] ref TerritoryWorldRegion territoryWorldRegion)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref territoryWorldRegion;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_byref_TerritoryWorldRegion_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980368, RefRangeEnd = 980369, XrefRangeStart = 980368, XrefRangeEnd = 980368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass95_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980369, RefRangeEnd = 980370, XrefRangeStart = 980369, XrefRangeEnd = 980369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass95_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980370, XrefRangeEnd = 980372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980380, RefRangeEnd = 980381, XrefRangeStart = 980372, XrefRangeEnd = 980380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980386, RefRangeEnd = 980387, XrefRangeStart = 980381, XrefRangeEnd = 980386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass95_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass95_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980387, XrefRangeEnd = 980391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980391, XrefRangeEnd = 980397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateActivityLevel_LambdaJob1()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateActivityLevel_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr_usedTerritoriesPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, nameof (usedTerritoriesPerRegion));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr_freeTerritoriesPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, nameof (freeTerritoriesPerRegion));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_Pylonstation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_Pylonstation_0));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_byref_TerritoryWorldRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, 100675874);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, 100675875);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass95_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, 100675876);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, 100675877);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, 100675878);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass95_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, 100675879);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, 100675880);
        ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, 100675881);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleTerritory;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_territoryWorldRegion;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_castleTerritory;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<TerritoryWorldRegion> forParameter_territoryWorldRegion;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980276, RefRangeEnd = 980277, XrefRangeStart = 980270, XrefRangeEnd = 980276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980283, RefRangeEnd = 980284, XrefRangeStart = 980277, XrefRangeEnd = 980283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleTerritory));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_territoryWorldRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_territoryWorldRegion));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100675882);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100675883);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleTerritory;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_territoryWorldRegion;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_castleTerritory;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<TerritoryWorldRegion>.Runtime runtime_territoryWorldRegion;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleTerritory));
            ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_territoryWorldRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_territoryWorldRegion));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateActivityLevel_LambdaJob1/ProjectM.RunWithoutJobSystem_0000309B$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_0000309B$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675884);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675885);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675886);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675887);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateActivityLevel_LambdaJob1/ProjectM.RunWithoutJobSystem_0000309B$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980284, XrefRangeEnd = 980298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980298, XrefRangeEnd = 980316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980316, XrefRangeEnd = 980331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980358, RefRangeEnd = 980359, XrefRangeStart = 980331, XrefRangeEnd = 980358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_0000309B$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675888);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675889);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675890);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675891);
          ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675893);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateActivityLevel_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_NetworkEventLogging")]
    public sealed class __c__DisplayClass_NetworkEventLogging : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_logAllNetworkEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_logAdminEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_logDebugEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_User_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkEventType_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass97_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass97_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass97_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980467, RefRangeEnd = 980468, XrefRangeStart = 980413, XrefRangeEnd = 980467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref NetworkEventType networkEventType,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkEventType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkEventType_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980469, RefRangeEnd = 980470, XrefRangeStart = 980468, XrefRangeEnd = 980469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass97_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass97_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980471, RefRangeEnd = 980472, XrefRangeStart = 980470, XrefRangeEnd = 980471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass97_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass97_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980472, XrefRangeEnd = 980474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980483, RefRangeEnd = 980484, XrefRangeStart = 980474, XrefRangeEnd = 980483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980489, RefRangeEnd = 980490, XrefRangeStart = 980484, XrefRangeEnd = 980489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass97_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass97_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980490, XrefRangeEnd = 980496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_NetworkEventLogging()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_NetworkEventLogging");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logAllNetworkEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, nameof (logAllNetworkEvents));
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logAdminEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, nameof (logAdminEvents));
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, nameof (logDebugEvents));
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, "<>4__this");
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__ComponentDataFromEntity_User_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, nameof (_ComponentDataFromEntity_User_0));
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkEventType_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, 100675894);
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass97_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, 100675895);
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass97_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, 100675896);
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, 100675897);
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, 100675898);
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass97_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, 100675899);
        ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, 100675900);
      }

      public __c__DisplayClass_NetworkEventLogging(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_NetworkEventLogging()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, data));
      }

      public unsafe bool logAllNetworkEvents
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logAllNetworkEvents));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logAllNetworkEvents)) = value;
        }
      }

      public unsafe bool logAdminEvents
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logAdminEvents));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logAdminEvents)) = value;
        }
      }

      public unsafe bool logDebugEvents
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logDebugEvents));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_logDebugEvents)) = value;
        }
      }

      public unsafe ServerBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentDataFromEntity<User> _ComponentDataFromEntity_User_0
      {
        get
        {
          return *(ComponentDataFromEntity<User>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__ComponentDataFromEntity_User_0));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__ComponentDataFromEntity_User_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<User>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkEventType;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<NetworkEventType> forParameter_networkEventType;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980404, RefRangeEnd = 980405, XrefRangeStart = 980397, XrefRangeEnd = 980404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980412, RefRangeEnd = 980413, XrefRangeStart = 980405, XrefRangeEnd = 980412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkEventType));
          ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders>.NativeClassPtr, 100675901);
          ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders>.NativeClassPtr, 100675902);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkEventType;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<NetworkEventType>.Runtime runtime_networkEventType;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkEventType));
            ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_NetworkEventLogging.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnGameDataInitialized_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnGameDataInitialized_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactiveEntitiesToEnable;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass109_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass109_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass109_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<Entity> inactiveEntitiesToEnable;
      [FieldOffset(24)]
      public ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(32)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980572, RefRangeEnd = 980573, XrefRangeStart = 980571, XrefRangeEnd = 980572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity userEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &userEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 980573, RefRangeEnd = 980586, XrefRangeStart = 980573, XrefRangeEnd = 980573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass109_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass109_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 980586, RefRangeEnd = 980599, XrefRangeStart = 980586, XrefRangeEnd = 980586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass109_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass109_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980599, XrefRangeEnd = 980601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980604, RefRangeEnd = 980605, XrefRangeStart = 980601, XrefRangeEnd = 980604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980607, RefRangeEnd = 980608, XrefRangeStart = 980605, XrefRangeEnd = 980607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass109_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass109_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980608, XrefRangeEnd = 980612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980612, XrefRangeEnd = 980618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnGameDataInitialized_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_OnGameDataInitialized_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr_inactiveEntitiesToEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, nameof (inactiveEntitiesToEnable));
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, 100675903);
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass109_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, 100675904);
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass109_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, 100675905);
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, 100675906);
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, 100675907);
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass109_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, 100675908);
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, 100675909);
        ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, 100675910);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_userEntity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_userEntity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_userEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_userEntity));
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675911);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675912);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_userEntity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_userEntity;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_userEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_userEntity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnGameDataInitialized_LambdaJob0/ProjectM.RunWithoutJobSystem_000030AD$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030AD$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675913);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675914);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675915);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675916);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnGameDataInitialized_LambdaJob0/ProjectM.RunWithoutJobSystem_000030AD$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980496, XrefRangeEnd = 980510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980510, XrefRangeEnd = 980528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980528, XrefRangeEnd = 980543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980570, RefRangeEnd = 980571, XrefRangeStart = 980543, XrefRangeEnd = 980570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030AD$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675917);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675918);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675919);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675920);
          ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675922);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnGameDataInitialized_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateLatency_LambdaJob0")]
    public sealed class __c__DisplayClass_UpdateLatency_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLatency;
      private static readonly System.IntPtr NativeFieldInfoPtr_getController;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ConnectedUser_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass111_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass111_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass111_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980647, RefRangeEnd = 980648, XrefRangeStart = 980628, XrefRangeEnd = 980647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref ConnectedUser connectedUser)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ConnectedUser_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980649, RefRangeEnd = 980650, XrefRangeStart = 980648, XrefRangeEnd = 980649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass111_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass111_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980651, RefRangeEnd = 980652, XrefRangeStart = 980650, XrefRangeEnd = 980651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass111_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass111_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980652, XrefRangeEnd = 980654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980660, RefRangeEnd = 980661, XrefRangeStart = 980654, XrefRangeEnd = 980660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980663, RefRangeEnd = 980664, XrefRangeStart = 980661, XrefRangeEnd = 980663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass111_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass111_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980664, XrefRangeEnd = 980670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateLatency_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateLatency_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, "<>4__this");
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_getLatency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, nameof (getLatency));
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_getController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, nameof (getController));
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ConnectedUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, 100675923);
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass111_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, 100675924);
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass111_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, 100675925);
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, 100675926);
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, 100675927);
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass111_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, 100675928);
        ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, 100675929);
      }

      public __c__DisplayClass_UpdateLatency_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateLatency_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ServerBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentDataFromEntity<Latency> getLatency
      {
        get
        {
          return *(ComponentDataFromEntity<Latency>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_getLatency));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_getLatency), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Latency>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Controller> getController
      {
        get
        {
          return *(ComponentDataFromEntity<Controller>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_getController));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_getController), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Controller>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_connectedUser;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ConnectedUser> forParameter_connectedUser;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980622, RefRangeEnd = 980623, XrefRangeStart = 980618, XrefRangeEnd = 980622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980627, RefRangeEnd = 980628, XrefRangeStart = 980623, XrefRangeEnd = 980627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_connectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_connectedUser));
          ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675930);
          ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675931);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_connectedUser;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ConnectedUser>.Runtime runtime_connectedUser;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_connectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_connectedUser));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateLatency_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserConnected_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUserConnected_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_userEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_connectedUser;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_byref_DynamicBuffer_1_OnlySyncToUserBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass118_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass118_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass118_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Entity userEntity;
      [FieldOffset(8)]
      public ConnectedUser connectedUser;
      [FieldOffset(16)]
      public ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980759, XrefRangeEnd = 980769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref OnlySyncToUserBitMask bitMask,
        [In] ref DynamicBuffer<OnlySyncToUserBuffer> buffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref bitMask;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_byref_DynamicBuffer_1_OnlySyncToUserBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 980769, RefRangeEnd = 980774, XrefRangeStart = 980769, XrefRangeEnd = 980769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass118_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass118_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 980774, RefRangeEnd = 980779, XrefRangeStart = 980774, XrefRangeEnd = 980774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass118_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass118_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980779, XrefRangeEnd = 980781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980789, RefRangeEnd = 980790, XrefRangeStart = 980781, XrefRangeEnd = 980789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980792, RefRangeEnd = 980793, XrefRangeStart = 980790, XrefRangeEnd = 980792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass118_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass118_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980793, XrefRangeEnd = 980797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980797, XrefRangeEnd = 980803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUserConnected_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_OnUserConnected_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr_userEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, nameof (userEntity));
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr_connectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, nameof (connectedUser));
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_byref_DynamicBuffer_1_OnlySyncToUserBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, 100675932);
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass118_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, 100675933);
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass118_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, 100675934);
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, 100675935);
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, 100675936);
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass118_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, 100675937);
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, 100675938);
        ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, 100675939);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_bitMask;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<OnlySyncToUserBitMask> forParameter_bitMask;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<OnlySyncToUserBuffer> forParameter_buffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980676, RefRangeEnd = 980677, XrefRangeStart = 980670, XrefRangeEnd = 980676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980683, RefRangeEnd = 980684, XrefRangeStart = 980677, XrefRangeEnd = 980683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_bitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_bitMask));
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffer));
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675940);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675941);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_bitMask;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<OnlySyncToUserBitMask>.Runtime runtime_bitMask;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<OnlySyncToUserBuffer>.Runtime runtime_buffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_bitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_bitMask));
            ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserConnected_LambdaJob0/ProjectM.RunWithoutJobSystem_000030BF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030BF$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675942);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675943);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675944);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675945);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserConnected_LambdaJob0/ProjectM.RunWithoutJobSystem_000030BF$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980684, XrefRangeEnd = 980698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980698, XrefRangeEnd = 980716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980716, XrefRangeEnd = 980731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980758, RefRangeEnd = 980759, XrefRangeStart = 980731, XrefRangeEnd = 980758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030BF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675946);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675947);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675948);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675949);
          ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675951);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserConnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserDisconnected_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUserDisconnected_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_approvedUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UpToDateUserBitMask_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass122_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int approvedUserIndex;
      [FieldOffset(8)]
      public ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 980916, RefRangeEnd = 980918, XrefRangeStart = 980886, XrefRangeEnd = 980916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref UpToDateUserBitMask upToDateMask)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref upToDateMask;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UpToDateUserBitMask_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 980918, RefRangeEnd = 980920, XrefRangeStart = 980918, XrefRangeEnd = 980918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ServerBootstrapSystem.__c__DisplayClass122_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 980920, RefRangeEnd = 980922, XrefRangeStart = 980920, XrefRangeEnd = 980920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ServerBootstrapSystem.__c__DisplayClass122_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980922, XrefRangeEnd = 980924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980929, RefRangeEnd = 980930, XrefRangeStart = 980924, XrefRangeEnd = 980929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 980932, RefRangeEnd = 980933, XrefRangeStart = 980930, XrefRangeEnd = 980932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ServerBootstrapSystem.__c__DisplayClass122_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass122_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980933, XrefRangeEnd = 980937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980937, XrefRangeEnd = 980943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUserDisconnected_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_OnUserDisconnected_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr_approvedUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, nameof (approvedUserIndex));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UpToDateUserBitMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, 100675952);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, 100675953);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, 100675954);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, 100675955);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, 100675956);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass122_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, 100675957);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, 100675958);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, 100675959);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_upToDateMask;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<UpToDateUserBitMask> forParameter_upToDateMask;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980806, RefRangeEnd = 980807, XrefRangeStart = 980803, XrefRangeEnd = 980806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980810, RefRangeEnd = 980811, XrefRangeStart = 980807, XrefRangeEnd = 980810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_upToDateMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_upToDateMask));
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675960);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675961);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_upToDateMask;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<UpToDateUserBitMask>.Runtime runtime_upToDateMask;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_upToDateMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_upToDateMask));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserDisconnected_LambdaJob0/ProjectM.RunWithoutJobSystem_000030C8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030C8$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675962);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675963);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675964);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675965);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserDisconnected_LambdaJob0/ProjectM.RunWithoutJobSystem_000030C8$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980811, XrefRangeEnd = 980825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980825, XrefRangeEnd = 980843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980843, XrefRangeEnd = 980858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980885, RefRangeEnd = 980886, XrefRangeStart = 980858, XrefRangeEnd = 980885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030C8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675966);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675967);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675968);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675969);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675971);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserDisconnected_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUserDisconnected_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_approvedUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass122_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int approvedUserIndex;
      [FieldOffset(8)]
      public ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 980916, RefRangeEnd = 980918, XrefRangeStart = 980916, XrefRangeEnd = 980918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref OnlySyncToUserBitMask onlySyncToUserBitMask)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref onlySyncToUserBitMask;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 980918, RefRangeEnd = 980920, XrefRangeStart = 980918, XrefRangeEnd = 980920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ServerBootstrapSystem.__c__DisplayClass122_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 980920, RefRangeEnd = 980922, XrefRangeStart = 980920, XrefRangeEnd = 980922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ServerBootstrapSystem.__c__DisplayClass122_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981026, XrefRangeEnd = 981028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981033, RefRangeEnd = 981034, XrefRangeStart = 981028, XrefRangeEnd = 981033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981036, RefRangeEnd = 981037, XrefRangeStart = 981034, XrefRangeEnd = 981036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ServerBootstrapSystem.__c__DisplayClass122_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass122_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981037, XrefRangeEnd = 981041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981041, XrefRangeEnd = 981047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUserDisconnected_LambdaJob1()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_OnUserDisconnected_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr_approvedUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, nameof (approvedUserIndex));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, 100675972);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, 100675973);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass122_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, 100675974);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, 100675975);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, 100675976);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem___c__DisplayClass122_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, 100675977);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, 100675978);
        ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, 100675979);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_onlySyncToUserBitMask;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<OnlySyncToUserBitMask> forParameter_onlySyncToUserBitMask;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980946, RefRangeEnd = 980947, XrefRangeStart = 980943, XrefRangeEnd = 980946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 980950, RefRangeEnd = 980951, XrefRangeStart = 980947, XrefRangeEnd = 980950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_onlySyncToUserBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_onlySyncToUserBitMask));
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100675980);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100675981);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_onlySyncToUserBitMask;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<OnlySyncToUserBitMask>.Runtime runtime_onlySyncToUserBitMask;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_onlySyncToUserBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_onlySyncToUserBitMask));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserDisconnected_LambdaJob1/ProjectM.RunWithoutJobSystem_000030D1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000030D1$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675982);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675983);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675984);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100675985);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_OnUserDisconnected_LambdaJob1/ProjectM.RunWithoutJobSystem_000030D1$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980951, XrefRangeEnd = 980965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980965, XrefRangeEnd = 980983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980983, XrefRangeEnd = 980998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981025, RefRangeEnd = 981026, XrefRangeStart = 980998, XrefRangeEnd = 981025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000030D1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675986);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675987);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675988);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675989);
          ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100675991);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_OnUserDisconnected_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_FindClanMembers")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindClanMembers
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_userTeamReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_clanMembers;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass125_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass125_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass125_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public TeamReference userTeamReference;
      [FieldOffset(24)]
      public NativeList<Entity> clanMembers;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981123, RefRangeEnd = 981124, XrefRangeStart = 981122, XrefRangeEnd = 981123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981124, RefRangeEnd = 981125, XrefRangeStart = 981124, XrefRangeEnd = 981124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass125_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass125_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981125, RefRangeEnd = 981126, XrefRangeStart = 981125, XrefRangeEnd = 981125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass125_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass125_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981127, RefRangeEnd = 981128, XrefRangeStart = 981126, XrefRangeEnd = 981127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981129, RefRangeEnd = 981130, XrefRangeStart = 981128, XrefRangeEnd = 981129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass125_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass125_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981130, XrefRangeEnd = 981134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981429, RefRangeEnd = 981430, XrefRangeStart = 981134, XrefRangeEnd = 981429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindClanMembers()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_FindClanMembers");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, nameof (entityManager));
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_userTeamReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, nameof (userTeamReference));
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_clanMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, nameof (clanMembers));
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, 100675992);
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass125_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, 100675993);
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass125_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, 100675994);
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, 100675995);
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass125_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, 100675996);
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, 100675997);
        ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, 100675998);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_FindClanMembers/ProjectM.RunWithoutJobSystem_000030D9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, "RunWithoutJobSystem_000030D9$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100675999);
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100676000);
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100676001);
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100676002);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_FindClanMembers/ProjectM.RunWithoutJobSystem_000030D9$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981047, XrefRangeEnd = 981061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981061, XrefRangeEnd = 981079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981079, XrefRangeEnd = 981094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981121, RefRangeEnd = 981122, XrefRangeStart = 981094, XrefRangeEnd = 981121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers>.NativeClassPtr, "RunWithoutJobSystem_000030D9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676003);
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676004);
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676005);
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676006);
          ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676008);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_FindClanMembers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_TryAuthenticate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TryAuthenticate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mappedPlatformId;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_userIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_nextId;
      private static readonly System.IntPtr NativeFieldInfoPtr_numOfUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass130_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ulong mappedPlatformId;
      [FieldOffset(8)]
      public Entity jobUserEntity;
      [FieldOffset(16)]
      public int userIndex;
      [FieldOffset(24)]
      public User localUser;
      [FieldOffset(176)]
      public int nextId;
      [FieldOffset(180)]
      public int numOfUsers;
      [FieldOffset(184)]
      public ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(224)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981515, RefRangeEnd = 981516, XrefRangeStart = 981515, XrefRangeEnd = 981515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref User userData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref userData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981516, RefRangeEnd = 981517, XrefRangeStart = 981516, XrefRangeEnd = 981516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass130_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981517, RefRangeEnd = 981518, XrefRangeStart = 981517, XrefRangeEnd = 981517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass130_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981518, XrefRangeEnd = 981520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981526, RefRangeEnd = 981527, XrefRangeStart = 981520, XrefRangeEnd = 981526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981529, RefRangeEnd = 981530, XrefRangeStart = 981527, XrefRangeEnd = 981529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass130_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass130_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981530, XrefRangeEnd = 981534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981534, XrefRangeEnd = 981540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TryAuthenticate_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_TryAuthenticate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_mappedPlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (mappedPlatformId));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_jobUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (jobUserEntity));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_userIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (userIndex));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_localUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (localUser));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (nextId));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_numOfUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (numOfUsers));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, 100676009);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, 100676010);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, 100676011);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, 100676012);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, 100676013);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass130_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, 100676014);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, 100676015);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, 100676016);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_userData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_userData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981434, RefRangeEnd = 981435, XrefRangeStart = 981430, XrefRangeEnd = 981434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981439, RefRangeEnd = 981440, XrefRangeStart = 981435, XrefRangeEnd = 981439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_userData));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100676017);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100676018);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_userData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_userData;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_userData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_TryAuthenticate_LambdaJob0/ProjectM.RunWithoutJobSystem_000030E0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030E0$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676019);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676020);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676021);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676022);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_TryAuthenticate_LambdaJob0/ProjectM.RunWithoutJobSystem_000030E0$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981440, XrefRangeEnd = 981454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981454, XrefRangeEnd = 981472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981472, XrefRangeEnd = 981487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981514, RefRangeEnd = 981515, XrefRangeStart = 981487, XrefRangeEnd = 981514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030E0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676023);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676024);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676025);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676026);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676028);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_TryAuthenticate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TryAuthenticate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mainWorldZoneMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_WorldZoneId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass130_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Nullable_Unboxed<WorldZoneId> mainWorldZoneMap;
      [FieldOffset(24)]
      public ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981623, XrefRangeEnd = 981626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref WorldZoneId worldZoneId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref worldZoneId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_WorldZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981626, RefRangeEnd = 981627, XrefRangeStart = 981626, XrefRangeEnd = 981626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass130_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981627, RefRangeEnd = 981628, XrefRangeStart = 981627, XrefRangeEnd = 981627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass130_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981628, XrefRangeEnd = 981630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981635, RefRangeEnd = 981636, XrefRangeStart = 981630, XrefRangeEnd = 981635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981638, RefRangeEnd = 981639, XrefRangeStart = 981636, XrefRangeEnd = 981638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass130_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass130_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981639, XrefRangeEnd = 981643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981643, XrefRangeEnd = 981649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TryAuthenticate_LambdaJob1()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_TryAuthenticate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr_mainWorldZoneMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, nameof (mainWorldZoneMap));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_WorldZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, 100676029);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, 100676030);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass130_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, 100676031);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, 100676032);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, 100676033);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass130_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, 100676034);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, 100676035);
        ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, 100676036);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_worldZoneId;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<WorldZoneId> forParameter_worldZoneId;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981543, RefRangeEnd = 981544, XrefRangeStart = 981540, XrefRangeEnd = 981543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981547, RefRangeEnd = 981548, XrefRangeStart = 981544, XrefRangeEnd = 981547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_worldZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_worldZoneId));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100676037);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100676038);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_worldZoneId;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<WorldZoneId>.Runtime runtime_worldZoneId;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_worldZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_worldZoneId));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_TryAuthenticate_LambdaJob1/ProjectM.RunWithoutJobSystem_000030E9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000030E9$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676039);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676040);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676041);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676042);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_TryAuthenticate_LambdaJob1/ProjectM.RunWithoutJobSystem_000030E9$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981548, XrefRangeEnd = 981562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981562, XrefRangeEnd = 981580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981580, XrefRangeEnd = 981595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981622, RefRangeEnd = 981623, XrefRangeStart = 981595, XrefRangeEnd = 981622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000030E9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676043);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676044);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676045);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676046);
          ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676048);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_TryAuthenticate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_allConnectedUsersList;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_NetworkId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass146_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass146_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass146_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public UnsafeList<ServerBootstrapSystem.UserData> allConnectedUsersList;
      [FieldOffset(24)]
      public ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981738, XrefRangeEnd = 981741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref User user, [In] ref NetworkId networkId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 743279, RefRangeEnd = 743284, XrefRangeStart = 743279, XrefRangeEnd = 743284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass146_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass146_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 981741, RefRangeEnd = 981745, XrefRangeStart = 981741, XrefRangeEnd = 981741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerBootstrapSystem.__c__DisplayClass146_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass146_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981745, XrefRangeEnd = 981747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981755, RefRangeEnd = 981756, XrefRangeStart = 981747, XrefRangeEnd = 981755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 981758, RefRangeEnd = 981759, XrefRangeStart = 981756, XrefRangeEnd = 981758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerBootstrapSystem componentSystem,
        ref ServerBootstrapSystem.__c__DisplayClass146_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass146_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981759, XrefRangeEnd = 981763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981763, XrefRangeEnd = 981769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr_allConnectedUsersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, nameof (allConnectedUsersList));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, 100676049);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass146_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, 100676050);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass146_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, 100676051);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, 100676052);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, 100676053);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_byref___c__DisplayClass146_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, 100676054);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, 100676055);
        ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, 100676056);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkId;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<NetworkId> forParameter_networkId;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981655, RefRangeEnd = 981656, XrefRangeStart = 981649, XrefRangeEnd = 981655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981662, RefRangeEnd = 981663, XrefRangeStart = 981656, XrefRangeEnd = 981662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkId));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100676057);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100676058);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkId;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<NetworkId>.Runtime runtime_networkId;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkId));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0/ProjectM.RunWithoutJobSystem_000030F2$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030F2$PostfixBurstDelegate");
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676059);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676060);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676061);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676062);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerBootstrapSystem/ProjectM.<>c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0/ProjectM.RunWithoutJobSystem_000030F2$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981663, XrefRangeEnd = 981677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981677, XrefRangeEnd = 981695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981695, XrefRangeEnd = 981710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 981737, RefRangeEnd = 981738, XrefRangeStart = 981710, XrefRangeEnd = 981737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000030F2$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676063);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676064);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676065);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676066);
          ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676068);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerBootstrapSystem.__c__DisplayClass_UpdateAllConnectedUsersData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
