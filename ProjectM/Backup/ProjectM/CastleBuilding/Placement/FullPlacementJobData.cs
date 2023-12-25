// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.FullPlacementJobData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FullPlacementJobData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelBuffs;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerGameBalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetUserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetEntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTeamReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAllyPermissions;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetBuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetControlledBy;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetEntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetLastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetStaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePlacementTag;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetIsPreviewingPlacement;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetRestrictionArea;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkedPrefabChildren;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetLinkedEntityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTilesBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetEditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetUpgradeableFromTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachToParentsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetChunkAreas;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPlacementRulesSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleStairs;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWallPillar;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeart;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetServantCoffinstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleLimited;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDyeableCastleObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetUserHeartCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetInteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTeleporterComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetRequireGroundedTag;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTeleporterElements;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabSetBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToCreate;
    private static readonly System.IntPtr NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToMove;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetBlueprintData;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPylonstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedSequencePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnCommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyCommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfilerMarker_FetchAllPlacementDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfilerMarker_SpatialLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTerritory;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTerritoryTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMapZoneData;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMapZonePolygonVertexElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetRestrictPlacementToMapZones;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingAllowReplaceSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingMaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedChild;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPlacementLimitToSet;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_FullPlacementJobData_ComponentSystemBase_PrefabCollectionSystem_SingletonAccessor_1_SyncedServerDebugSettings_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_ServerTime_ITileModelSpatialLookupMap_MapZoneCollectionSystem_TileWorldSystem_TravelBuffCollectionSystem_TerrainChunkLookup_NativeList_1_CreateTileModelData_NativeList_1_MoveTileModelData_EntityCommandBuffer_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateGetPlacementJobData_Public_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateApplyPlacementJobData_Public_JobData_Boolean_0;
    [FieldOffset(0)]
    public SpatialLookupParams SpatialLookupParams;
    [FieldOffset(80)]
    public MapZoneCollection MapZoneCollection;
    [FieldOffset(176)]
    public TileWorld TileWorld;
    [FieldOffset(200)]
    public TravelBuffCollection TravelBuffs;
    [FieldOffset(216)]
    public SyncedServerDebugSettings ServerDebugSettings;
    [FieldOffset(256)]
    public ServerGameBalanceSettings ServerGameBalanceSettings;
    [FieldOffset(1656)]
    public bool IsServer;
    [FieldOffset(1664)]
    public PrefabLookupMap PrefabMap;
    [FieldOffset(1712)]
    public ComponentDataFromEntity<UserOwner> GetUserOwner;
    [FieldOffset(1744)]
    public ComponentDataFromEntity<EntityOwner> GetEntityOwner;
    [FieldOffset(1776)]
    public ComponentDataFromEntity<Team> GetTeam;
    [FieldOffset(1808)]
    public ComponentDataFromEntity<TeamReference> GetTeamReference;
    [FieldOffset(1840)]
    public ComponentDataFromEntity<Prefab> GetPrefab;
    [FieldOffset(1872)]
    public ComponentDataFromEntity<DestroyTag> GetDestroy;
    [FieldOffset(1904)]
    public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
    [FieldOffset(1936)]
    public ComponentDataFromEntity<TilePosition> GetTilePosition;
    [FieldOffset(1968)]
    public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
    [FieldOffset(2000)]
    public BufferFromEntity<AllyPermission> GetAllyPermissions;
    [FieldOffset(2040)]
    public ComponentDataFromEntity<BuffableFlagState> GetBuffableFlagState;
    [FieldOffset(2072)]
    public ComponentDataFromEntity<ControlledBy> GetControlledBy;
    [FieldOffset(2104)]
    public ComponentDataFromEntity<EntityCategory> GetEntityCategory;
    [FieldOffset(2136)]
    public ComponentDataFromEntity<Translation> GetTranslation;
    [FieldOffset(2168)]
    public ComponentDataFromEntity<LastTranslation> GetLastTranslation;
    [FieldOffset(2200)]
    public ComponentDataFromEntity<Rotation> GetRotation;
    [FieldOffset(2232)]
    public ComponentDataFromEntity<StaticTransformCompatible> GetStaticTransformCompatible;
    [FieldOffset(2264)]
    public ComponentDataFromEntity<DestroyAfterDurationCounter> GetDestroyAfterDuration;
    [FieldOffset(2296)]
    public ComponentDataFromEntity<TileData> GetTileData;
    [FieldOffset(2328)]
    public ComponentDataFromEntity<TilePlacementTag> GetTilePlacementTag;
    [FieldOffset(2360)]
    public ComponentDataFromEntity<IsPreviewingPlacement> GetIsPreviewingPlacement;
    [FieldOffset(2392)]
    public ComponentDataFromEntity<RestrictPlacementArea> GetRestrictionArea;
    [FieldOffset(2424)]
    public ComponentDataFromEntity<Dead> GetDead;
    [FieldOffset(2456)]
    public ComponentDataFromEntity<NetworkedPrefabChildren> GetNetworkedPrefabChildren;
    [FieldOffset(2488)]
    public BufferFromEntity<LinkedEntityGroup> GetLinkedEntityGroup;
    [FieldOffset(2528)]
    public BufferFromEntity<BakedPlacementTiles> GetBakedPlacementTiles;
    [FieldOffset(2568)]
    public BufferFromEntity<BakedPlacementTilesBounds> GetBakedPlacementTilesBounds;
    [FieldOffset(2608)]
    public ComponentDataFromEntity<EditableTileModel> GetEditableTileModel;
    [FieldOffset(2640)]
    public ComponentDataFromEntity<UpgradeableFromTileModel> GetUpgradeableFromTileModel;
    [FieldOffset(2672)]
    public ComponentDataFromEntity<CastleBuildingAttachSettings> GetAttachSettings;
    [FieldOffset(2704)]
    public BufferFromEntity<CastleBuildingAttachToParentsBuffer> GetAttachToParentsBuffer;
    [FieldOffset(2744)]
    public BufferFromEntity<CastleBuildingAttachedChildrenBuffer> GetAttachedChildrenBuffer;
    [FieldOffset(2784)]
    public TerrainChunkLookup TerrainChunks;
    [FieldOffset(2800)]
    public BufferFromEntity<ControllableAreaIdBuffer> GetChunkAreas;
    [FieldOffset(2840)]
    public ComponentDataFromEntity<CastleAreaRequirement> GetPlacementRulesSettings;
    [FieldOffset(2872)]
    public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
    [FieldOffset(2904)]
    public ComponentDataFromEntity<CastleStairs> GetCastleStairs;
    [FieldOffset(2936)]
    public ComponentDataFromEntity<CastleWall> GetCastleWall;
    [FieldOffset(2968)]
    public ComponentDataFromEntity<CastleWallPillar> GetCastleWallPillar;
    [FieldOffset(3000)]
    public ComponentDataFromEntity<CastleHeart> GetCastleHeart;
    [FieldOffset(3032)]
    public ComponentDataFromEntity<ServantCoffinstation> GetServantCoffinstation;
    [FieldOffset(3064)]
    public ComponentDataFromEntity<CastleLimited> GetCastleLimited;
    [FieldOffset(3096)]
    public ComponentDataFromEntity<DyeableCastleObject> GetDyeableCastleObject;
    [FieldOffset(3128)]
    public ComponentDataFromEntity<UserHeartCount> GetUserHeartCount;
    [FieldOffset(3160)]
    public ComponentDataFromEntity<InteractedUpon> GetInteractedUpon;
    [FieldOffset(3192)]
    public ComponentDataFromEntity<PlacementDestroyData> GetPlacementDestroyData;
    [FieldOffset(3224)]
    public ComponentDataFromEntity<CastleHeartConnection> GetCastleHeartConnection;
    [FieldOffset(3256)]
    public ComponentDataFromEntity<CastleTeleporterComponent> GetCastleTeleporterComponent;
    [FieldOffset(3288)]
    public ComponentDataFromEntity<RequireGroundedTag> GetRequireGroundedTag;
    [FieldOffset(3320)]
    public BufferFromEntity<CastleTeleporterElement> GetCastleTeleporterElements;
    [FieldOffset(3360)]
    public BufferFromEntity<PrefabSetBuffer> GetPrefabSetBuffer;
    [FieldOffset(3400)]
    public NativeList<CreateTileModelData> ApplyPlacementHistoryTileModelsToCreate;
    [FieldOffset(3416)]
    public NativeList<MoveTileModelData> ApplyPlacementHistoryTileModelsToMove;
    [FieldOffset(3432)]
    public ComponentDataFromEntity<BlueprintData> GetBlueprintData;
    [FieldOffset(3464)]
    public ComponentDataFromEntity<DismantleDestroyData> GetDismantleDestroyData;
    [FieldOffset(3496)]
    public ComponentDataFromEntity<Pylonstation> GetPylonstation;
    [FieldOffset(3528)]
    public Entity NetworkedSequencePrefab;
    [FieldOffset(3536)]
    public EntityCommandBuffer SpawnCommandBuffer;
    [FieldOffset(3552)]
    public EntityCommandBuffer DestroyCommandBuffer;
    [FieldOffset(3568)]
    public ProfilerMarker ProfilerMarker_FetchAllPlacementDatas;
    [FieldOffset(3576)]
    public ProfilerMarker ProfilerMarker_SpatialLookup;
    [FieldOffset(3584)]
    public double ServerTime;
    [FieldOffset(3592)]
    public ComponentDataFromEntity<CastleTerritory> GetCastleTerritory;
    [FieldOffset(3624)]
    public BufferFromEntity<CastleTerritoryTiles> GetCastleTerritoryTiles;
    [FieldOffset(3664)]
    public ComponentDataFromEntity<MapZoneData> GetMapZoneData;
    [FieldOffset(3696)]
    public BufferFromEntity<MapZonePolygonVertexElement> GetMapZonePolygonVertexElement;
    [FieldOffset(3736)]
    public ComponentDataFromEntity<RestrictPlacementToMapZones> GetRestrictPlacementToMapZones;
    [FieldOffset(3768)]
    public ComponentDataFromEntity<CastleBuildingAllowReplaceSelf> GetCastleBuildingAllowReplaceSelf;
    [FieldOffset(3800)]
    public ComponentDataFromEntity<CastleBuildingMaxRange> GetCastleBuildingMaxRange;
    [FieldOffset(3832)]
    public ComponentDataFromEntity<CastleBuildingFusedRoot> GetCastleBuildingFusedRoot;
    [FieldOffset(3864)]
    public ComponentDataFromEntity<CastleBuildingFusedChild> GetCastleBuildingFusedChild;
    [FieldOffset(3896)]
    public BufferFromEntity<CastleBuildingFusedChildrenBuffer> GetCastleBuildingFusedChildrenBuffer;
    [FieldOffset(3936)]
    public ComponentDataFromEntity<PlacementLimitToSet> GetPlacementLimitToSet;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1131390, RefRangeEnd = 1131391, XrefRangeStart = 1131171, XrefRangeEnd = 1131390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe FullPlacementJobData Create(
      ComponentSystemBase systemBase,
      PrefabCollectionSystem prefabCollectionSystem,
      SingletonAccessor<SyncedServerDebugSettings> serverDebugSettings,
      SingletonAccessor<ServerGameBalanceSettings> serverGameBalanceSettings,
      SingletonAccessor<ProjectM.ServerTime> serverTime,
      ITileModelSpatialLookupMap tileModelSpatialLookup,
      MapZoneCollectionSystem mapZoneCollectionSystem,
      TileWorldSystem tileWorldSystem,
      TravelBuffCollectionSystem travelBuffCollection,
      TerrainChunkLookup terrainChunks,
      NativeList<CreateTileModelData> applyPlacementHistoryTileModelsToCreate,
      NativeList<MoveTileModelData> applyPlacementHistoryTileModelsToMove,
      EntityCommandBuffer spawnCommandBuffer,
      EntityCommandBuffer destroyCommandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[14];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverDebugSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &serverGameBalanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileModelSpatialLookup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapZoneCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileWorldSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) travelBuffCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &applyPlacementHistoryTileModelsToCreate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &applyPlacementHistoryTileModelsToMove;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FullPlacementJobData.NativeMethodInfoPtr_Create_Public_Static_FullPlacementJobData_ComponentSystemBase_PrefabCollectionSystem_SingletonAccessor_1_SyncedServerDebugSettings_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_ServerTime_ITileModelSpatialLookupMap_MapZoneCollectionSystem_TileWorldSystem_TravelBuffCollectionSystem_TerrainChunkLookup_NativeList_1_CreateTileModelData_NativeList_1_MoveTileModelData_EntityCommandBuffer_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(FullPlacementJobData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1131392, RefRangeEnd = 1131398, XrefRangeStart = 1131391, XrefRangeEnd = 1131392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetPlacementResult.JobData CreateGetPlacementJobData()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FullPlacementJobData.NativeMethodInfoPtr_CreateGetPlacementJobData_Public_JobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetPlacementResult.JobData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1131398, RefRangeEnd = 1131406, XrefRangeStart = 1131398, XrefRangeEnd = 1131398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ApplyPlacementResult.JobData CreateApplyPlacementJobData(bool isDismantleOperation = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &isDismantleOperation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FullPlacementJobData.NativeMethodInfoPtr_CreateApplyPlacementJobData_Public_JobData_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ApplyPlacementResult.JobData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FullPlacementJobData()
    {
      Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (FullPlacementJobData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr);
      FullPlacementJobData.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (SpatialLookupParams));
      FullPlacementJobData.NativeFieldInfoPtr_MapZoneCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (MapZoneCollection));
      FullPlacementJobData.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (TileWorld));
      FullPlacementJobData.NativeFieldInfoPtr_TravelBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (TravelBuffs));
      FullPlacementJobData.NativeFieldInfoPtr_ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (ServerDebugSettings));
      FullPlacementJobData.NativeFieldInfoPtr_ServerGameBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (ServerGameBalanceSettings));
      FullPlacementJobData.NativeFieldInfoPtr_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (IsServer));
      FullPlacementJobData.NativeFieldInfoPtr_PrefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (PrefabMap));
      FullPlacementJobData.NativeFieldInfoPtr_GetUserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetUserOwner));
      FullPlacementJobData.NativeFieldInfoPtr_GetEntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetEntityOwner));
      FullPlacementJobData.NativeFieldInfoPtr_GetTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetTeam));
      FullPlacementJobData.NativeFieldInfoPtr_GetTeamReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetTeamReference));
      FullPlacementJobData.NativeFieldInfoPtr_GetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetPrefab));
      FullPlacementJobData.NativeFieldInfoPtr_GetDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetDestroy));
      FullPlacementJobData.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetPrefabGUID));
      FullPlacementJobData.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetTilePosition));
      FullPlacementJobData.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetLocalToWorld));
      FullPlacementJobData.NativeFieldInfoPtr_GetAllyPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetAllyPermissions));
      FullPlacementJobData.NativeFieldInfoPtr_GetBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetBuffableFlagState));
      FullPlacementJobData.NativeFieldInfoPtr_GetControlledBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetControlledBy));
      FullPlacementJobData.NativeFieldInfoPtr_GetEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetEntityCategory));
      FullPlacementJobData.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetTranslation));
      FullPlacementJobData.NativeFieldInfoPtr_GetLastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetLastTranslation));
      FullPlacementJobData.NativeFieldInfoPtr_GetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetRotation));
      FullPlacementJobData.NativeFieldInfoPtr_GetStaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetStaticTransformCompatible));
      FullPlacementJobData.NativeFieldInfoPtr_GetDestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetDestroyAfterDuration));
      FullPlacementJobData.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetTileData));
      FullPlacementJobData.NativeFieldInfoPtr_GetTilePlacementTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetTilePlacementTag));
      FullPlacementJobData.NativeFieldInfoPtr_GetIsPreviewingPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetIsPreviewingPlacement));
      FullPlacementJobData.NativeFieldInfoPtr_GetRestrictionArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetRestrictionArea));
      FullPlacementJobData.NativeFieldInfoPtr_GetDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetDead));
      FullPlacementJobData.NativeFieldInfoPtr_GetNetworkedPrefabChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetNetworkedPrefabChildren));
      FullPlacementJobData.NativeFieldInfoPtr_GetLinkedEntityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetLinkedEntityGroup));
      FullPlacementJobData.NativeFieldInfoPtr_GetBakedPlacementTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetBakedPlacementTiles));
      FullPlacementJobData.NativeFieldInfoPtr_GetBakedPlacementTilesBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetBakedPlacementTilesBounds));
      FullPlacementJobData.NativeFieldInfoPtr_GetEditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetEditableTileModel));
      FullPlacementJobData.NativeFieldInfoPtr_GetUpgradeableFromTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetUpgradeableFromTileModel));
      FullPlacementJobData.NativeFieldInfoPtr_GetAttachSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetAttachSettings));
      FullPlacementJobData.NativeFieldInfoPtr_GetAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetAttachToParentsBuffer));
      FullPlacementJobData.NativeFieldInfoPtr_GetAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetAttachedChildrenBuffer));
      FullPlacementJobData.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (TerrainChunks));
      FullPlacementJobData.NativeFieldInfoPtr_GetChunkAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetChunkAreas));
      FullPlacementJobData.NativeFieldInfoPtr_GetPlacementRulesSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetPlacementRulesSettings));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleFloor));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleStairs));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleWall));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleWallPillar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleWallPillar));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleHeart));
      FullPlacementJobData.NativeFieldInfoPtr_GetServantCoffinstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetServantCoffinstation));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleLimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleLimited));
      FullPlacementJobData.NativeFieldInfoPtr_GetDyeableCastleObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetDyeableCastleObject));
      FullPlacementJobData.NativeFieldInfoPtr_GetUserHeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetUserHeartCount));
      FullPlacementJobData.NativeFieldInfoPtr_GetInteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetInteractedUpon));
      FullPlacementJobData.NativeFieldInfoPtr_GetPlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetPlacementDestroyData));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleHeartConnection));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleTeleporterComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleTeleporterComponent));
      FullPlacementJobData.NativeFieldInfoPtr_GetRequireGroundedTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetRequireGroundedTag));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleTeleporterElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleTeleporterElements));
      FullPlacementJobData.NativeFieldInfoPtr_GetPrefabSetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetPrefabSetBuffer));
      FullPlacementJobData.NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (ApplyPlacementHistoryTileModelsToCreate));
      FullPlacementJobData.NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (ApplyPlacementHistoryTileModelsToMove));
      FullPlacementJobData.NativeFieldInfoPtr_GetBlueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetBlueprintData));
      FullPlacementJobData.NativeFieldInfoPtr_GetDismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetDismantleDestroyData));
      FullPlacementJobData.NativeFieldInfoPtr_GetPylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetPylonstation));
      FullPlacementJobData.NativeFieldInfoPtr_NetworkedSequencePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (NetworkedSequencePrefab));
      FullPlacementJobData.NativeFieldInfoPtr_SpawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (SpawnCommandBuffer));
      FullPlacementJobData.NativeFieldInfoPtr_DestroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (DestroyCommandBuffer));
      FullPlacementJobData.NativeFieldInfoPtr_ProfilerMarker_FetchAllPlacementDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (ProfilerMarker_FetchAllPlacementDatas));
      FullPlacementJobData.NativeFieldInfoPtr_ProfilerMarker_SpatialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (ProfilerMarker_SpatialLookup));
      FullPlacementJobData.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (ServerTime));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleTerritory));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleTerritoryTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleTerritoryTiles));
      FullPlacementJobData.NativeFieldInfoPtr_GetMapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetMapZoneData));
      FullPlacementJobData.NativeFieldInfoPtr_GetMapZonePolygonVertexElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetMapZonePolygonVertexElement));
      FullPlacementJobData.NativeFieldInfoPtr_GetRestrictPlacementToMapZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetRestrictPlacementToMapZones));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleBuildingAllowReplaceSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleBuildingAllowReplaceSelf));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleBuildingMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleBuildingMaxRange));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleBuildingFusedRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleBuildingFusedRoot));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleBuildingFusedChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleBuildingFusedChild));
      FullPlacementJobData.NativeFieldInfoPtr_GetCastleBuildingFusedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetCastleBuildingFusedChildrenBuffer));
      FullPlacementJobData.NativeFieldInfoPtr_GetPlacementLimitToSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, nameof (GetPlacementLimitToSet));
      FullPlacementJobData.NativeMethodInfoPtr_Create_Public_Static_FullPlacementJobData_ComponentSystemBase_PrefabCollectionSystem_SingletonAccessor_1_SyncedServerDebugSettings_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_ServerTime_ITileModelSpatialLookupMap_MapZoneCollectionSystem_TileWorldSystem_TravelBuffCollectionSystem_TerrainChunkLookup_NativeList_1_CreateTileModelData_NativeList_1_MoveTileModelData_EntityCommandBuffer_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, 100689821);
      FullPlacementJobData.NativeMethodInfoPtr_CreateGetPlacementJobData_Public_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, 100689822);
      FullPlacementJobData.NativeMethodInfoPtr_CreateApplyPlacementJobData_Public_JobData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, 100689823);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullPlacementJobData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
