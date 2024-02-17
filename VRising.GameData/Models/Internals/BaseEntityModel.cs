// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.Internals.BaseEntityModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using ProjectM.Behaviours;
using ProjectM.CastleBuilding;
using ProjectM.Gameplay.Scripting;
using ProjectM.Network;
using ProjectM.Pathfinding;
using ProjectM.Roofs;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using ProjectM.Shared;
using ProjectM.Terrain;
using ProjectM.Tiles;
using Stunlock.Sequencer;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Physics;
using Unity.Scenes;

#nullable disable
namespace VRising.GameData.Models.Internals
{
  public class BaseEntityModel
  {
    private readonly World _world;
    public readonly Entity _entity;

    internal BaseEntityModel(World world, Entity entity)
    {
      this._world = world;
      this._entity = entity;
    }

    public Unity.Entities.SceneReference? SceneReference
    {
      get
      {
        Unity.Entities.SceneReference sceneReference;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Entities.SceneReference>(this._entity, out sceneReference) ? new Unity.Entities.SceneReference?() : new Unity.Entities.SceneReference?(sceneReference);
      }
    }

    public Unity.Entities.RequestSceneLoaded? RequestSceneLoaded
    {
      get
      {
        Unity.Entities.RequestSceneLoaded requestSceneLoaded;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Entities.RequestSceneLoaded>(this._entity, out requestSceneLoaded) ? new Unity.Entities.RequestSceneLoaded?() : new Unity.Entities.RequestSceneLoaded?(requestSceneLoaded);
      }
    }

    public Unity.Scenes.ResolvedSceneHash? ResolvedSceneHash
    {
      get
      {
        Unity.Scenes.ResolvedSceneHash resolvedSceneHash;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Scenes.ResolvedSceneHash>(this._entity, out resolvedSceneHash) ? new Unity.Scenes.ResolvedSceneHash?() : new Unity.Scenes.ResolvedSceneHash?(resolvedSceneHash);
      }
    }

    public List<LinkedEntityGroup> LinkedEntityGroups
    {
      get => this._world.EntityManager.GetBufferInternal<LinkedEntityGroup>(this._entity);
    }

    public List<ResolvedSectionEntity> ResolvedSectionEntities
    {
      get => this._world.EntityManager.GetBufferInternal<ResolvedSectionEntity>(this._entity);
    }

    public PostLoadCommandBuffer PostLoadCommandBuffer
    {
      get
      {
        PostLoadCommandBuffer loadCommandBuffer;
        return !this._world.EntityManager.TryGetComponentDataInternal<PostLoadCommandBuffer>(this._entity, out loadCommandBuffer) ? (PostLoadCommandBuffer) null : loadCommandBuffer;
      }
    }

    public ServerRuntimeSettings ServerRuntimeSettings
    {
      get
      {
        ServerRuntimeSettings serverRuntimeSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<ServerRuntimeSettings>(this._entity, out serverRuntimeSettings) ? new ServerRuntimeSettings() : serverRuntimeSettings;
      }
    }

    public bool Prefab => this._world.EntityManager.HasComponentInternal<Unity.Entities.Prefab>(this._entity);

    public ProjectM.Network.NetworkedSettings? NetworkedSettings
    {
      get
      {
        ProjectM.Network.NetworkedSettings networkedSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.NetworkedSettings>(this._entity, out networkedSettings) ? new ProjectM.Network.NetworkedSettings?() : new ProjectM.Network.NetworkedSettings?(networkedSettings);
      }
    }

    public ProjectM.Network.FrameChanged? FrameChanged
    {
      get
      {
        ProjectM.Network.FrameChanged frameChanged;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.FrameChanged>(this._entity, out frameChanged) ? new ProjectM.Network.FrameChanged?() : new ProjectM.Network.FrameChanged?(frameChanged);
      }
    }

    public ProjectM.Network.NetworkSnapshot? NetworkSnapshot
    {
      get
      {
        ProjectM.Network.NetworkSnapshot networkSnapshot;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.NetworkSnapshot>(this._entity, out networkSnapshot) ? new ProjectM.Network.NetworkSnapshot?() : new ProjectM.Network.NetworkSnapshot?(networkSnapshot);
      }
    }

    public ProjectM.Network.DestroyedEntity? DestroyedEntity
    {
      get
      {
        ProjectM.Network.DestroyedEntity destroyedEntity;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.DestroyedEntity>(this._entity, out destroyedEntity) ? new ProjectM.Network.DestroyedEntity?() : new ProjectM.Network.DestroyedEntity?(destroyedEntity);
      }
    }

    public List<NetSnapshot> NetSnapshots
    {
      get => this._world.EntityManager.GetBufferInternal<NetSnapshot>(this._entity);
    }

    public List<SnapshotFrameChangedBuffer> SnapshotFrameChangedBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<SnapshotFrameChangedBuffer>(this._entity);
    }

    public List<ProjectM.Network.Snapshot_InventoryBuffer> Snapshot_InventoryBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_InventoryBuffer>(this._entity);
    }

    public List<ProjectM.Network.Snapshot_PerksBuffer> Snapshot_PerksBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_PerksBuffer>(this._entity);
    }

    public bool NewDestroyedEntity
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Network.NewDestroyedEntity>(this._entity);
    }

    public ProjectM.WorldTypeSingleton? WorldTypeSingleton
    {
      get
      {
        ProjectM.WorldTypeSingleton worldTypeSingleton;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WorldTypeSingleton>(this._entity, out worldTypeSingleton) ? new ProjectM.WorldTypeSingleton?() : new ProjectM.WorldTypeSingleton?(worldTypeSingleton);
      }
    }

    public ProjectM.WorldFrame? WorldFrame
    {
      get
      {
        ProjectM.WorldFrame worldFrame;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WorldFrame>(this._entity, out worldFrame) ? new ProjectM.WorldFrame?() : new ProjectM.WorldFrame?(worldFrame);
      }
    }

    public ProjectM.Terrain.TerrainChunkLoadedEvent? TerrainChunkLoadedEvent
    {
      get
      {
        ProjectM.Terrain.TerrainChunkLoadedEvent chunkLoadedEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.TerrainChunkLoadedEvent>(this._entity, out chunkLoadedEvent) ? new ProjectM.Terrain.TerrainChunkLoadedEvent?() : new ProjectM.Terrain.TerrainChunkLoadedEvent?(chunkLoadedEvent);
      }
    }

    public List<PublicEntityRef> PublicEntityRefs
    {
      get => this._world.EntityManager.GetBufferInternal<PublicEntityRef>(this._entity);
    }

    public ProjectM.Terrain.TerrainChunkMetadataLoadedEvent? TerrainChunkMetadataLoadedEvent
    {
      get
      {
        ProjectM.Terrain.TerrainChunkMetadataLoadedEvent metadataLoadedEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.TerrainChunkMetadataLoadedEvent>(this._entity, out metadataLoadedEvent) ? new ProjectM.Terrain.TerrainChunkMetadataLoadedEvent?() : new ProjectM.Terrain.TerrainChunkMetadataLoadedEvent?(metadataLoadedEvent);
      }
    }

    public ProjectM.LoadToTargetWorld? LoadToTargetWorld
    {
      get
      {
        ProjectM.LoadToTargetWorld loadToTargetWorld;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.LoadToTargetWorld>(this._entity, out loadToTargetWorld) ? new ProjectM.LoadToTargetWorld?() : new ProjectM.LoadToTargetWorld?(loadToTargetWorld);
      }
    }

    public ServerGameBalanceSettings ServerGameBalanceSettings
    {
      get
      {
        ServerGameBalanceSettings gameBalanceSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<ServerGameBalanceSettings>(this._entity, out gameBalanceSettings) ? new ServerGameBalanceSettings() : gameBalanceSettings;
      }
    }

    public ProjectM.ToggleDisabledEvent? ToggleDisabledEvent
    {
      get
      {
        ProjectM.ToggleDisabledEvent toggleDisabledEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ToggleDisabledEvent>(this._entity, out toggleDisabledEvent) ? new ProjectM.ToggleDisabledEvent?() : new ProjectM.ToggleDisabledEvent?(toggleDisabledEvent);
      }
    }

    public List<ProjectM.Network.Snapshot_CastleBuildingAttachedChildrenBuffer> Snapshot_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_CastleBuildingAttachedChildrenBuffer>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_CastleBuildingAttachToParentsBuffer> Snapshot_CastleBuildingAttachToParentsBuffer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_CastleBuildingAttachToParentsBuffer>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_RefinementstationRecipesBuffer> Snapshot_RefinementstationRecipesBuffer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_RefinementstationRecipesBuffer>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_ActiveServantMission> Snapshot_ActiveServantMission
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_ActiveServantMission>(this._entity);
      }
    }

    public Unity.Transforms.LocalToWorld? LocalToWorld
    {
      get
      {
        Unity.Transforms.LocalToWorld localToWorld;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Transforms.LocalToWorld>(this._entity, out localToWorld) ? new Unity.Transforms.LocalToWorld?() : new Unity.Transforms.LocalToWorld?(localToWorld);
      }
    }

    public ProjectM.TileBounds? TileBounds
    {
      get
      {
        ProjectM.TileBounds tileBounds;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TileBounds>(this._entity, out tileBounds) ? new ProjectM.TileBounds?() : new ProjectM.TileBounds?(tileBounds);
      }
    }

    public ProjectM.TilePosition? TilePosition
    {
      get
      {
        ProjectM.TilePosition tilePosition;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TilePosition>(this._entity, out tilePosition) ? new ProjectM.TilePosition?() : new ProjectM.TilePosition?(tilePosition);
      }
    }

    public ProjectM.TileModelSpatialData? TileModelSpatialData
    {
      get
      {
        ProjectM.TileModelSpatialData modelSpatialData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TileModelSpatialData>(this._entity, out modelSpatialData) ? new ProjectM.TileModelSpatialData?() : new ProjectM.TileModelSpatialData?(modelSpatialData);
      }
    }

    public TileData TileData
    {
      get
      {
        TileData tileData;
        return !this._world.EntityManager.TryGetComponentDataInternal<TileData>(this._entity, out tileData) ? new TileData() : tileData;
      }
    }

    public ProjectM.Terrain.MapZoneData? MapZoneData
    {
      get
      {
        ProjectM.Terrain.MapZoneData mapZoneData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.MapZoneData>(this._entity, out mapZoneData) ? new ProjectM.Terrain.MapZoneData?() : new ProjectM.Terrain.MapZoneData?(mapZoneData);
      }
    }

    public ProjectM.Tiles.TileModel? TileModel
    {
      get
      {
        ProjectM.Tiles.TileModel tileModel;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Tiles.TileModel>(this._entity, out tileModel) ? new ProjectM.Tiles.TileModel?() : new ProjectM.Tiles.TileModel?(tileModel);
      }
    }

    public List<MapZonePolygonVertexElement> MapZonePolygonVertexElements
    {
      get => this._world.EntityManager.GetBufferInternal<MapZonePolygonVertexElement>(this._entity);
    }

    public List<MapZoneDiscoverableElement> MapZoneDiscoverableElements
    {
      get => this._world.EntityManager.GetBufferInternal<MapZoneDiscoverableElement>(this._entity);
    }

    public bool TileRestrictionAreaTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.TileRestrictionAreaTag>(this._entity);
    }

    public bool TileModelRegistrationState
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.TileModelRegistrationState>(this._entity);
      }
    }

    public RetainBlobAssets RetainBlobAssets
    {
      get
      {
        RetainBlobAssets retainBlobAssets;
        return !this._world.EntityManager.TryGetComponentDataInternal<RetainBlobAssets>(this._entity, out retainBlobAssets) ? new RetainBlobAssets() : retainBlobAssets;
      }
    }

    public Unity.Entities.RetainBlobAssetBatchPtr? RetainBlobAssetBatchPtr
    {
      get
      {
        Unity.Entities.RetainBlobAssetBatchPtr blobAssetBatchPtr;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Entities.RetainBlobAssetBatchPtr>(this._entity, out blobAssetBatchPtr) ? new Unity.Entities.RetainBlobAssetBatchPtr?() : new Unity.Entities.RetainBlobAssetBatchPtr?(blobAssetBatchPtr);
      }
    }

    public bool BlobAssetOwner
    {
      get => this._world.EntityManager.HasComponentInternal<Unity.Entities.BlobAssetOwner>(this._entity);
    }

    public List<ProjectM.Terrain.WorldAssetChunks> WorldAssetChunks
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Terrain.WorldAssetChunks>(this._entity);
    }

    public bool WorldAssetSingleton
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Terrain.WorldAssetSingleton>(this._entity);
    }

    public bool WorldConfigSingleton
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Terrain.WorldConfigSingleton>(this._entity);
    }

    public List<RelicDropped> RelicDroppeds
    {
      get => this._world.EntityManager.GetBufferInternal<RelicDropped>(this._entity);
    }

    public ProjectM.KnockbackAssetsSingleton? KnockbackAssetsSingleton
    {
      get
      {
        ProjectM.KnockbackAssetsSingleton knockbackAssetsSingleton;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.KnockbackAssetsSingleton>(this._entity, out knockbackAssetsSingleton) ? new ProjectM.KnockbackAssetsSingleton?() : new ProjectM.KnockbackAssetsSingleton?(knockbackAssetsSingleton);
      }
    }

    public List<ProjectM.Network.Snapshot_SpawnedUnitsBuffer> Snapshot_SpawnedUnitsBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_SpawnedUnitsBuffer>(this._entity);
    }

    public Unity.Scenes.SceneEntityReference? SceneEntityReference
    {
      get
      {
        Unity.Scenes.SceneEntityReference sceneEntityReference;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Scenes.SceneEntityReference>(this._entity, out sceneEntityReference) ? new Unity.Scenes.SceneEntityReference?() : new Unity.Scenes.SceneEntityReference?(sceneEntityReference);
      }
    }

    public Unity.Entities.SceneSectionData? SceneSectionData
    {
      get
      {
        Unity.Entities.SceneSectionData sceneSectionData;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Entities.SceneSectionData>(this._entity, out sceneSectionData) ? new Unity.Entities.SceneSectionData?() : new Unity.Entities.SceneSectionData?(sceneSectionData);
      }
    }

    public Unity.Scenes.ResolvedSectionPath? ResolvedSectionPath
    {
      get
      {
        Unity.Scenes.ResolvedSectionPath resolvedSectionPath;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Scenes.ResolvedSectionPath>(this._entity, out resolvedSectionPath) ? new Unity.Scenes.ResolvedSectionPath?() : new Unity.Scenes.ResolvedSectionPath?(resolvedSectionPath);
      }
    }

    public Unity.Scenes.SceneBoundingVolume? SceneBoundingVolume
    {
      get
      {
        Unity.Scenes.SceneBoundingVolume sceneBoundingVolume;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Scenes.SceneBoundingVolume>(this._entity, out sceneBoundingVolume) ? new Unity.Scenes.SceneBoundingVolume?() : new Unity.Scenes.SceneBoundingVolume?(sceneBoundingVolume);
      }
    }

    public PhysicsCollider PhysicsCollider
    {
      get
      {
        PhysicsCollider physicsCollider;
        return !this._world.EntityManager.TryGetComponentDataInternal<PhysicsCollider>(this._entity, out physicsCollider) ? new PhysicsCollider() : physicsCollider;
      }
    }

    public Unity.Physics.Systems.StaticPhysicsWorldBodyIndex? StaticPhysicsWorldBodyIndex
    {
      get
      {
        Unity.Physics.Systems.StaticPhysicsWorldBodyIndex physicsWorldBodyIndex;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Physics.Systems.StaticPhysicsWorldBodyIndex>(this._entity, out physicsWorldBodyIndex) ? new Unity.Physics.Systems.StaticPhysicsWorldBodyIndex?() : new Unity.Physics.Systems.StaticPhysicsWorldBodyIndex?(physicsWorldBodyIndex);
      }
    }

    public ProjectM.ModifyMovementDuringCastActive? ModifyMovementDuringCastActive
    {
      get
      {
        ProjectM.ModifyMovementDuringCastActive duringCastActive;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyMovementDuringCastActive>(this._entity, out duringCastActive) ? new ProjectM.ModifyMovementDuringCastActive?() : new ProjectM.ModifyMovementDuringCastActive?(duringCastActive);
      }
    }

    public ProjectM.DestroyData? DestroyData
    {
      get
      {
        ProjectM.DestroyData destroyData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DestroyData>(this._entity, out destroyData) ? new ProjectM.DestroyData?() : new ProjectM.DestroyData?(destroyData);
      }
    }

    public ProjectM.DestroyState? DestroyState
    {
      get
      {
        ProjectM.DestroyState destroyState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DestroyState>(this._entity, out destroyState) ? new ProjectM.DestroyState?() : new ProjectM.DestroyState?(destroyState);
      }
    }

    public ProjectM.MoveDuringCastActive? MoveDuringCastActive
    {
      get
      {
        ProjectM.MoveDuringCastActive duringCastActive;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MoveDuringCastActive>(this._entity, out duringCastActive) ? new ProjectM.MoveDuringCastActive?() : new ProjectM.MoveDuringCastActive?(duringCastActive);
      }
    }

    public List<ProjectM.Network.Snapshot_QueuedWorkstationCraftAction> Snapshot_QueuedWorkstationCraftAction
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_QueuedWorkstationCraftAction>(this._entity);
      }
    }

    public ProjectM.RotateTowardsAimDirectionDuringCastActive? RotateTowardsAimDirectionDuringCastActive
    {
      get
      {
        ProjectM.RotateTowardsAimDirectionDuringCastActive duringCastActive;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RotateTowardsAimDirectionDuringCastActive>(this._entity, out duringCastActive) ? new ProjectM.RotateTowardsAimDirectionDuringCastActive?() : new ProjectM.RotateTowardsAimDirectionDuringCastActive?(duringCastActive);
      }
    }

    public List<ProjectM.Network.Snapshot_ResearchBuffer> Snapshot_ResearchBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_ResearchBuffer>(this._entity);
    }

    public ProjectM.AbilityCastStartedEvent? AbilityCastStartedEvent
    {
      get
      {
        ProjectM.AbilityCastStartedEvent castStartedEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityCastStartedEvent>(this._entity, out castStartedEvent) ? new ProjectM.AbilityCastStartedEvent?() : new ProjectM.AbilityCastStartedEvent?(castStartedEvent);
      }
    }

    public List<ProjectM.Network.Snapshot_AllyPermission> Snapshot_AllyPermission
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_AllyPermission>(this._entity);
    }

    public List<ProjectM.Network.Snapshot_RespawnPointOwnerBuffer> Snapshot_RespawnPointOwnerBuffer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_RespawnPointOwnerBuffer>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_UnlockedWaypointElement> Snapshot_UnlockedWaypointElement
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_UnlockedWaypointElement>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_UserMapZoneElement> Snapshot_UserMapZoneElement
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_UserMapZoneElement>(this._entity);
    }

    public ProjectM.AbilityPostCastFinishedEvent? AbilityPostCastFinishedEvent
    {
      get
      {
        ProjectM.AbilityPostCastFinishedEvent castFinishedEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityPostCastFinishedEvent>(this._entity, out castFinishedEvent) ? new ProjectM.AbilityPostCastFinishedEvent?() : new ProjectM.AbilityPostCastFinishedEvent?(castFinishedEvent);
      }
    }

    public List<ProjectM.Network.Snapshot_FollowerBuffer> Snapshot_FollowerBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_FollowerBuffer>(this._entity);
    }

    public ProjectM.AbilityCastEndedEvent? AbilityCastEndedEvent
    {
      get
      {
        ProjectM.AbilityCastEndedEvent abilityCastEndedEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityCastEndedEvent>(this._entity, out abilityCastEndedEvent) ? new ProjectM.AbilityCastEndedEvent?() : new ProjectM.AbilityCastEndedEvent?(abilityCastEndedEvent);
      }
    }

    public ProjectM.AbilityPostCastEndedEvent? AbilityPostCastEndedEvent
    {
      get
      {
        ProjectM.AbilityPostCastEndedEvent postCastEndedEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityPostCastEndedEvent>(this._entity, out postCastEndedEvent) ? new ProjectM.AbilityPostCastEndedEvent?() : new ProjectM.AbilityPostCastEndedEvent?(postCastEndedEvent);
      }
    }

    public List<ProjectM.Network.Snapshot_AbilityStateBuffer> Snapshot_AbilityStateBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_AbilityStateBuffer>(this._entity);
    }

    public ProjectM.AbilityInterruptedEvent? AbilityInterruptedEvent
    {
      get
      {
        ProjectM.AbilityInterruptedEvent interruptedEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityInterruptedEvent>(this._entity, out interruptedEvent) ? new ProjectM.AbilityInterruptedEvent?() : new ProjectM.AbilityInterruptedEvent?(interruptedEvent);
      }
    }

    public ProjectM.TeleportationRequest? TeleportationRequest
    {
      get
      {
        ProjectM.TeleportationRequest teleportationRequest;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TeleportationRequest>(this._entity, out teleportationRequest) ? new ProjectM.TeleportationRequest?() : new ProjectM.TeleportationRequest?(teleportationRequest);
      }
    }

    public List<ProjectM.Network.Snapshot_Restricted_InventoryBuffer> Snapshot_Restricted_InventoryBuffer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_Restricted_InventoryBuffer>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_AchievementInProgressElement> Snapshot_AchievementInProgressElement
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_AchievementInProgressElement>(this._entity);
      }
    }

    public Unity.Physics.PhysicsStep? PhysicsStep
    {
      get
      {
        Unity.Physics.PhysicsStep physicsStep;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Physics.PhysicsStep>(this._entity, out physicsStep) ? new Unity.Physics.PhysicsStep?() : new Unity.Physics.PhysicsStep?(physicsStep);
      }
    }

    public Unity.Entities.WorldTime? WorldTime
    {
      get
      {
        Unity.Entities.WorldTime worldTime;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Entities.WorldTime>(this._entity, out worldTime) ? new Unity.Entities.WorldTime?() : new Unity.Entities.WorldTime?(worldTime);
      }
    }

    public List<WorldTimeQueue> WorldTimeQueues
    {
      get => this._world.EntityManager.GetBufferInternal<WorldTimeQueue>(this._entity);
    }

    public ProjectM.Sun? Sun
    {
      get
      {
        ProjectM.Sun sun;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Sun>(this._entity, out sun) ? new ProjectM.Sun?() : new ProjectM.Sun?(sun);
      }
    }

    public CloudCookieLight CloudCookieLight
    {
      get
      {
        CloudCookieLight cloudCookieLight;
        return !this._world.EntityManager.TryGetComponentDataInternal<CloudCookieLight>(this._entity, out cloudCookieLight) ? (CloudCookieLight) null : cloudCookieLight;
      }
    }

    public List<ProjectM.Network.Snapshot_ProgressionBookBlueprintElement> Snapshot_ProgressionBookBlueprintElement
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_ProgressionBookBlueprintElement>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_ProgressionBookRecipeElement> Snapshot_ProgressionBookRecipeElement
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_ProgressionBookRecipeElement>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_ProgressionBookShapeshiftElement> Snapshot_ProgressionBookShapeshiftElement
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_ProgressionBookShapeshiftElement>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_ProgressionBookTechElement> Snapshot_ProgressionBookTechElement
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_ProgressionBookTechElement>(this._entity);
      }
    }

    public List<ProjectM.Network.Snapshot_BloodHuntBuffer> Snapshot_BloodHuntBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Network.Snapshot_BloodHuntBuffer>(this._entity);
    }

    public Unity.Transforms.Rotation? Rotation
    {
      get
      {
        Unity.Transforms.Rotation rotation;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Transforms.Rotation>(this._entity, out rotation) ? new Unity.Transforms.Rotation?() : new Unity.Transforms.Rotation?(rotation);
      }
    }

    public Unity.Transforms.Translation? Translation
    {
      get
      {
        Unity.Transforms.Translation translation;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Transforms.Translation>(this._entity, out translation) ? new Unity.Transforms.Translation?() : new Unity.Transforms.Translation?(translation);
      }
    }

    public ProjectM.PrefabGUID? PrefabGUID
    {
      get
      {
        ProjectM.PrefabGUID prefabGuid;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PrefabGUID>(this._entity, out prefabGuid) ? new ProjectM.PrefabGUID?() : new ProjectM.PrefabGUID?(prefabGuid);
      }
    }

    public ProjectM.AiPointOfInterest? AiPointOfInterest
    {
      get
      {
        ProjectM.AiPointOfInterest aiPointOfInterest;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AiPointOfInterest>(this._entity, out aiPointOfInterest) ? new ProjectM.AiPointOfInterest?() : new ProjectM.AiPointOfInterest?(aiPointOfInterest);
      }
    }

    public ProjectM.AutoChainInstanceData? AutoChainInstanceData
    {
      get
      {
        ProjectM.AutoChainInstanceData chainInstanceData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AutoChainInstanceData>(this._entity, out chainInstanceData) ? new ProjectM.AutoChainInstanceData?() : new ProjectM.AutoChainInstanceData?(chainInstanceData);
      }
    }

    public bool SpawnTag => this._world.EntityManager.HasComponentInternal<Unity.Entities.SpawnTag>(this._entity);

    public bool PrefabCollectionPrefabTag
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.PrefabCollectionPrefabTag>(this._entity);
      }
    }

    public bool UsesSpawnTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.UsesSpawnTag>(this._entity);
    }

    public bool DisableWhenNoPlayersInRange
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.DisableWhenNoPlayersInRange>(this._entity);
      }
    }

    public List<EntityNameCollectionBuffer> EntityNameCollectionBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<EntityNameCollectionBuffer>(this._entity);
    }

    public List<PrefabCollectionBuffer> PrefabCollectionBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<PrefabCollectionBuffer>(this._entity);
    }

    public bool PrefabCollectionTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.PrefabCollectionTag>(this._entity);
    }

    public bool GameDataSubSceneTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.GameDataSubSceneTag>(this._entity);
    }

    public ProjectM.RandomizedSpawnChain? RandomizedSpawnChain
    {
      get
      {
        ProjectM.RandomizedSpawnChain randomizedSpawnChain;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RandomizedSpawnChain>(this._entity, out randomizedSpawnChain) ? new ProjectM.RandomizedSpawnChain?() : new ProjectM.RandomizedSpawnChain?(randomizedSpawnChain);
      }
    }

    public ProjectM.StaticTransformIndex? StaticTransformIndex
    {
      get
      {
        ProjectM.StaticTransformIndex staticTransformIndex;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StaticTransformIndex>(this._entity, out staticTransformIndex) ? new ProjectM.StaticTransformIndex?() : new ProjectM.StaticTransformIndex?(staticTransformIndex);
      }
    }

    public ProjectM.BlueprintData? BlueprintData
    {
      get
      {
        ProjectM.BlueprintData blueprintData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BlueprintData>(this._entity, out blueprintData) ? new ProjectM.BlueprintData?() : new ProjectM.BlueprintData?(blueprintData);
      }
    }

    public ProjectM.Team? Team
    {
      get
      {
        ProjectM.Team team;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Team>(this._entity, out team) ? new ProjectM.Team?() : new ProjectM.Team?(team);
      }
    }

    public ProjectM.EditableTileModel? EditableTileModel
    {
      get
      {
        ProjectM.EditableTileModel editableTileModel;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EditableTileModel>(this._entity, out editableTileModel) ? new ProjectM.EditableTileModel?() : new ProjectM.EditableTileModel?(editableTileModel);
      }
    }

    public ProjectM.CastleBuilding.CastleHeartConnection? CastleHeartConnection
    {
      get
      {
        ProjectM.CastleBuilding.CastleHeartConnection castleHeartConnection;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleHeartConnection>(this._entity, out castleHeartConnection) ? new ProjectM.CastleBuilding.CastleHeartConnection?() : new ProjectM.CastleBuilding.CastleHeartConnection?(castleHeartConnection);
      }
    }

    public ProjectM.DismantleDestroyData? DismantleDestroyData
    {
      get
      {
        ProjectM.DismantleDestroyData dismantleDestroyData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DismantleDestroyData>(this._entity, out dismantleDestroyData) ? new ProjectM.DismantleDestroyData?() : new ProjectM.DismantleDestroyData?(dismantleDestroyData);
      }
    }

    public ProjectM.JoinDefaultTeamOnSpawn? JoinDefaultTeamOnSpawn
    {
      get
      {
        ProjectM.JoinDefaultTeamOnSpawn defaultTeamOnSpawn;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.JoinDefaultTeamOnSpawn>(this._entity, out defaultTeamOnSpawn) ? new ProjectM.JoinDefaultTeamOnSpawn?() : new ProjectM.JoinDefaultTeamOnSpawn?(defaultTeamOnSpawn);
      }
    }

    public ProjectM.Network.UpToDateUserBitMask? UpToDateUserBitMask
    {
      get
      {
        ProjectM.Network.UpToDateUserBitMask toDateUserBitMask;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.UpToDateUserBitMask>(this._entity, out toDateUserBitMask) ? new ProjectM.Network.UpToDateUserBitMask?() : new ProjectM.Network.UpToDateUserBitMask?(toDateUserBitMask);
      }
    }

    public ProjectM.Network.NetworkId? NetworkId
    {
      get
      {
        ProjectM.Network.NetworkId networkId;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.NetworkId>(this._entity, out networkId) ? new ProjectM.Network.NetworkId?() : new ProjectM.Network.NetworkId?(networkId);
      }
    }

    public ProjectM.CastleBuilding.CastleBuildingMaxRange? CastleBuildingMaxRange
    {
      get
      {
        ProjectM.CastleBuilding.CastleBuildingMaxRange buildingMaxRange;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleBuildingMaxRange>(this._entity, out buildingMaxRange) ? new ProjectM.CastleBuilding.CastleBuildingMaxRange?() : new ProjectM.CastleBuilding.CastleBuildingMaxRange?(buildingMaxRange);
      }
    }

    public ProjectM.PlacementDestroyData? PlacementDestroyData
    {
      get
      {
        ProjectM.PlacementDestroyData placementDestroyData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PlacementDestroyData>(this._entity, out placementDestroyData) ? new ProjectM.PlacementDestroyData?() : new ProjectM.PlacementDestroyData?(placementDestroyData);
      }
    }

    public ProjectM.CastleAreaRequirement? CastleAreaRequirement
    {
      get
      {
        ProjectM.CastleAreaRequirement castleAreaRequirement;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleAreaRequirement>(this._entity, out castleAreaRequirement) ? new ProjectM.CastleAreaRequirement?() : new ProjectM.CastleAreaRequirement?(castleAreaRequirement);
      }
    }

    public List<NetworkedEntityModificationBuffer> NetworkedEntityModificationBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<NetworkedEntityModificationBuffer>(this._entity);
      }
    }

    public List<CastleBuildingAttachedChildrenBuffer> CastleBuildingAttachedChildrenBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CastleBuildingAttachedChildrenBuffer>(this._entity);
      }
    }

    public List<BlueprintRequirementBuffer> BlueprintRequirementBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<BlueprintRequirementBuffer>(this._entity);
    }

    public bool TilePlacementTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.TilePlacementTag>(this._entity);
    }

    public bool Networked
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Network.Networked>(this._entity);
    }

    public bool RunCastleCleanupOnDeath
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Tiles.RunCastleCleanupOnDeath>(this._entity);
    }

    public bool RestrictPlacementToMapZones
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.CastleBuilding.Placement.RestrictPlacementToMapZones>(this._entity);
      }
    }

    public bool NetworkSnapshotType
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Network.NetworkSnapshotType>(this._entity);
    }

    public bool TileModelLayer
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Tiles.TileModelLayer>(this._entity);
    }

    public ProjectM.BuffResistances? BuffResistances
    {
      get
      {
        ProjectM.BuffResistances buffResistances;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BuffResistances>(this._entity, out buffResistances) ? new ProjectM.BuffResistances?() : new ProjectM.BuffResistances?(buffResistances);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderHealthThreshhold_DataServer? Script_ApplyBuffUnderHealthThreshhold_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderHealthThreshhold_DataServer threshholdDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderHealthThreshhold_DataServer>(this._entity, out threshholdDataServer) ? new ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderHealthThreshhold_DataServer?() : new ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderHealthThreshhold_DataServer?(threshholdDataServer);
      }
    }

    public ProjectM.Buffable? Buffable
    {
      get
      {
        ProjectM.Buffable buffable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Buffable>(this._entity, out buffable) ? new ProjectM.Buffable?() : new ProjectM.Buffable?(buffable);
      }
    }

    public ProjectM.CreatedTime? CreatedTime
    {
      get
      {
        ProjectM.CreatedTime createdTime;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CreatedTime>(this._entity, out createdTime) ? new ProjectM.CreatedTime?() : new ProjectM.CreatedTime?(createdTime);
      }
    }

    public ProjectM.Health? Health
    {
      get
      {
        ProjectM.Health health;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Health>(this._entity, out health) ? new ProjectM.Health?() : new ProjectM.Health?(health);
      }
    }

    public ProjectM.HealthConstants? HealthConstants
    {
      get
      {
        ProjectM.HealthConstants healthConstants;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.HealthConstants>(this._entity, out healthConstants) ? new ProjectM.HealthConstants?() : new ProjectM.HealthConstants?(healthConstants);
      }
    }

    public ProjectM.Immortal? Immortal
    {
      get
      {
        ProjectM.Immortal immortal;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Immortal>(this._entity, out immortal) ? new ProjectM.Immortal?() : new ProjectM.Immortal?(immortal);
      }
    }

    public ProjectM.CollisionRadius? CollisionRadius
    {
      get
      {
        ProjectM.CollisionRadius collisionRadius;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CollisionRadius>(this._entity, out collisionRadius) ? new ProjectM.CollisionRadius?() : new ProjectM.CollisionRadius?(collisionRadius);
      }
    }

    public ProjectM.ArmorLevel? ArmorLevel
    {
      get
      {
        ProjectM.ArmorLevel armorLevel;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ArmorLevel>(this._entity, out armorLevel) ? new ProjectM.ArmorLevel?() : new ProjectM.ArmorLevel?(armorLevel);
      }
    }

    public ProjectM.EntityCategory? EntityCategory
    {
      get
      {
        ProjectM.EntityCategory entityCategory;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EntityCategory>(this._entity, out entityCategory) ? new ProjectM.EntityCategory?() : new ProjectM.EntityCategory?(entityCategory);
      }
    }

    public ProjectM.StaticTransformCompatible? StaticTransformCompatible
    {
      get
      {
        ProjectM.StaticTransformCompatible transformCompatible;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StaticTransformCompatible>(this._entity, out transformCompatible) ? new ProjectM.StaticTransformCompatible?() : new ProjectM.StaticTransformCompatible?(transformCompatible);
      }
    }

    public ProjectM.Sequencer.ImpactMaterial? ImpactMaterial
    {
      get
      {
        ProjectM.Sequencer.ImpactMaterial impactMaterial;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Sequencer.ImpactMaterial>(this._entity, out impactMaterial) ? new ProjectM.Sequencer.ImpactMaterial?() : new ProjectM.Sequencer.ImpactMaterial?(impactMaterial);
      }
    }

    public ProjectM.CastleDecayAndRegen? CastleDecayAndRegen
    {
      get
      {
        ProjectM.CastleDecayAndRegen castleDecayAndRegen;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleDecayAndRegen>(this._entity, out castleDecayAndRegen) ? new ProjectM.CastleDecayAndRegen?() : new ProjectM.CastleDecayAndRegen?(castleDecayAndRegen);
      }
    }

    public StaticHierarchyData StaticHierarchyData
    {
      get
      {
        StaticHierarchyData staticHierarchyData;
        return !this._world.EntityManager.TryGetComponentDataInternal<StaticHierarchyData>(this._entity, out staticHierarchyData) ? new StaticHierarchyData() : staticHierarchyData;
      }
    }

    public List<BoolModificationBuffer> BoolModificationBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<BoolModificationBuffer>(this._entity);
    }

    public List<EntityModificationBuffer> EntityModificationBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<EntityModificationBuffer>(this._entity);
    }

    public List<FloatModificationBuffer> FloatModificationBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<FloatModificationBuffer>(this._entity);
    }

    public List<IntModificationBuffer> IntModificationBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<IntModificationBuffer>(this._entity);
    }

    public List<StaticHierarchyBuffer> StaticHierarchyBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<StaticHierarchyBuffer>(this._entity);
    }

    public List<CastleBuildingAttachToParentsBuffer> CastleBuildingAttachToParentsBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CastleBuildingAttachToParentsBuffer>(this._entity);
      }
    }

    public List<CreateGameplayEventsOnSpawn> CreateGameplayEventsOnSpawns
    {
      get => this._world.EntityManager.GetBufferInternal<CreateGameplayEventsOnSpawn>(this._entity);
    }

    public List<ApplyBuffOnGameplayEvent> ApplyBuffOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<ApplyBuffOnGameplayEvent>(this._entity);
    }

    public List<GameplayEventIdMapping> GameplayEventIdMappings
    {
      get => this._world.EntityManager.GetBufferInternal<GameplayEventIdMapping>(this._entity);
    }

    public bool TileCollisionTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.TileCollisionTag>(this._entity);
    }

    public bool TilePathfindingTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.TilePathfindingTag>(this._entity);
    }

    public bool TileLineOfSightTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.TileLineOfSightTag>(this._entity);
    }

    public bool ScriptSpawn
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Scripting.ScriptSpawn>(this._entity);
    }

    public bool MoveStopTrigger
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.MoveStopTrigger>(this._entity);
    }

    public ProjectM.ProgressionUserContentDependency? ProgressionUserContentDependency
    {
      get
      {
        ProjectM.ProgressionUserContentDependency contentDependency;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ProgressionUserContentDependency>(this._entity, out contentDependency) ? new ProjectM.ProgressionUserContentDependency?() : new ProjectM.ProgressionUserContentDependency?(contentDependency);
      }
    }

    public ProjectM.PavementBonusSource? PavementBonusSource
    {
      get
      {
        ProjectM.PavementBonusSource pavementBonusSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PavementBonusSource>(this._entity, out pavementBonusSource) ? new ProjectM.PavementBonusSource?() : new ProjectM.PavementBonusSource?(pavementBonusSource);
      }
    }

    public Unity.Transforms.Parent? Parent
    {
      get
      {
        Unity.Transforms.Parent parent;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Transforms.Parent>(this._entity, out parent) ? new Unity.Transforms.Parent?() : new Unity.Transforms.Parent?(parent);
      }
    }

    public ProjectM.RotateAroundAxis? RotateAroundAxis
    {
      get
      {
        ProjectM.RotateAroundAxis rotateAroundAxis;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RotateAroundAxis>(this._entity, out rotateAroundAxis) ? new ProjectM.RotateAroundAxis?() : new ProjectM.RotateAroundAxis?(rotateAroundAxis);
      }
    }

    public bool CastleBuildingShowOnlyInPreview
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.CastleBuilding.CastleBuildingShowOnlyInPreview>(this._entity);
      }
    }

    public ProjectM.InventoryOwner? InventoryOwner
    {
      get
      {
        ProjectM.InventoryOwner inventoryOwner;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.InventoryOwner>(this._entity, out inventoryOwner) ? new ProjectM.InventoryOwner?() : new ProjectM.InventoryOwner?(inventoryOwner);
      }
    }

    public ProjectM.Refinementstation? Refinementstation
    {
      get
      {
        ProjectM.Refinementstation refinementstation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Refinementstation>(this._entity, out refinementstation) ? new ProjectM.Refinementstation?() : new ProjectM.Refinementstation?(refinementstation);
      }
    }

    public ProjectM.WorkstationAssignedServant? WorkstationAssignedServant
    {
      get
      {
        ProjectM.WorkstationAssignedServant workstationAssignedServant;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WorkstationAssignedServant>(this._entity, out workstationAssignedServant) ? new ProjectM.WorkstationAssignedServant?() : new ProjectM.WorkstationAssignedServant?(workstationAssignedServant);
      }
    }

    public ProjectM.CastleBuilding.CastleRoomConnection? CastleRoomConnection
    {
      get
      {
        ProjectM.CastleBuilding.CastleRoomConnection castleRoomConnection;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleRoomConnection>(this._entity, out castleRoomConnection) ? new ProjectM.CastleBuilding.CastleRoomConnection?() : new ProjectM.CastleBuilding.CastleRoomConnection?(castleRoomConnection);
      }
    }

    public ProjectM.ServantInteractPointLocalTransform? ServantInteractPointLocalTransform
    {
      get
      {
        ProjectM.ServantInteractPointLocalTransform pointLocalTransform;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantInteractPointLocalTransform>(this._entity, out pointLocalTransform) ? new ProjectM.ServantInteractPointLocalTransform?() : new ProjectM.ServantInteractPointLocalTransform?(pointLocalTransform);
      }
    }

    public ProjectM.StationServants? StationServants
    {
      get
      {
        ProjectM.StationServants stationServants;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StationServants>(this._entity, out stationServants) ? new ProjectM.StationServants?() : new ProjectM.StationServants?(stationServants);
      }
    }

    public ProjectM.CastleWorkstation? CastleWorkstation
    {
      get
      {
        ProjectM.CastleWorkstation castleWorkstation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleWorkstation>(this._entity, out castleWorkstation) ? new ProjectM.CastleWorkstation?() : new ProjectM.CastleWorkstation?(castleWorkstation);
      }
    }

    public ProjectM.CastleBuilding.CastleBuildingAttachSettings? CastleBuildingAttachSettings
    {
      get
      {
        ProjectM.CastleBuilding.CastleBuildingAttachSettings buildingAttachSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleBuildingAttachSettings>(this._entity, out buildingAttachSettings) ? new ProjectM.CastleBuilding.CastleBuildingAttachSettings?() : new ProjectM.CastleBuilding.CastleBuildingAttachSettings?(buildingAttachSettings);
      }
    }

    public ProjectM.Interactable? Interactable
    {
      get
      {
        ProjectM.Interactable interactable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Interactable>(this._entity, out interactable) ? new ProjectM.Interactable?() : new ProjectM.Interactable?(interactable);
      }
    }

    public ProjectM.InteractedUpon? InteractedUpon
    {
      get
      {
        ProjectM.InteractedUpon interactedUpon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.InteractedUpon>(this._entity, out interactedUpon) ? new ProjectM.InteractedUpon?() : new ProjectM.InteractedUpon?(interactedUpon);
      }
    }

    public List<InventoryBuffer> InventoryBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<InventoryBuffer>(this._entity);
    }

    public List<StationBonusBuffer> StationBonusBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<StationBonusBuffer>(this._entity);
    }

    public List<RefinementstationRecipesBuffer> RefinementstationRecipesBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<RefinementstationRecipesBuffer>(this._entity);
      }
    }

    public List<InteractAbilityBuffer> InteractAbilityBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<InteractAbilityBuffer>(this._entity);
    }

    public bool TileHeightTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.TileHeightTag>(this._entity);
    }

    public bool PickParentTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Physics.PickParentTag>(this._entity);
    }

    public bool WallpaperSet
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.WallpaperSet>(this._entity);
    }

    public List<DoorChildren> DoorChildrens
    {
      get => this._world.EntityManager.GetBufferInternal<DoorChildren>(this._entity);
    }

    public bool ChildPrefabTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.ChildPrefabTag>(this._entity);
    }

    public ProjectM.NetherSpawnPosition? NetherSpawnPosition
    {
      get
      {
        ProjectM.NetherSpawnPosition netherSpawnPosition;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.NetherSpawnPosition>(this._entity, out netherSpawnPosition) ? new ProjectM.NetherSpawnPosition?() : new ProjectM.NetherSpawnPosition?(netherSpawnPosition);
      }
    }

    public ProjectM.CastleLimited? CastleLimited
    {
      get
      {
        ProjectM.CastleLimited castleLimited;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleLimited>(this._entity, out castleLimited) ? new ProjectM.CastleLimited?() : new ProjectM.CastleLimited?(castleLimited);
      }
    }

    public ProjectM.Hybrid.HybridModelSeed? HybridModelSeed
    {
      get
      {
        ProjectM.Hybrid.HybridModelSeed hybridModelSeed;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Hybrid.HybridModelSeed>(this._entity, out hybridModelSeed) ? new ProjectM.Hybrid.HybridModelSeed?() : new ProjectM.Hybrid.HybridModelSeed?(hybridModelSeed);
      }
    }

    public ProjectM.NameableInteractable? NameableInteractable
    {
      get
      {
        ProjectM.NameableInteractable nameableInteractable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.NameableInteractable>(this._entity, out nameableInteractable) ? new ProjectM.NameableInteractable?() : new ProjectM.NameableInteractable?(nameableInteractable);
      }
    }

    public ProjectM.PrisonCell? PrisonCell
    {
      get
      {
        ProjectM.PrisonCell prisonCell;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PrisonCell>(this._entity, out prisonCell) ? new ProjectM.PrisonCell?() : new ProjectM.PrisonCell?(prisonCell);
      }
    }

    public ProjectM.EntityOwner? EntityOwner
    {
      get
      {
        ProjectM.EntityOwner entityOwner;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EntityOwner>(this._entity, out entityOwner) ? new ProjectM.EntityOwner?() : new ProjectM.EntityOwner?(entityOwner);
      }
    }

    public ProjectM.EntityCreator? EntityCreator
    {
      get
      {
        ProjectM.EntityCreator entityCreator;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EntityCreator>(this._entity, out entityCreator) ? new ProjectM.EntityCreator?() : new ProjectM.EntityCreator?(entityCreator);
      }
    }

    public ProjectM.Prisonstation? Prisonstation
    {
      get
      {
        ProjectM.Prisonstation prisonstation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Prisonstation>(this._entity, out prisonstation) ? new ProjectM.Prisonstation?() : new ProjectM.Prisonstation?(prisonstation);
      }
    }

    public List<QueuedWorkstationCraftAction> QueuedWorkstationCraftActions
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<QueuedWorkstationCraftAction>(this._entity);
      }
    }

    public List<ProjectM.QueuedWorkstationCraftActionItems> QueuedWorkstationCraftActionItems
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.QueuedWorkstationCraftActionItems>(this._entity);
      }
    }

    public List<WorkstationRecipesBuffer> WorkstationRecipesBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<WorkstationRecipesBuffer>(this._entity);
    }

    public ProjectM.UserOwner? UserOwner
    {
      get
      {
        ProjectM.UserOwner userOwner;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UserOwner>(this._entity, out userOwner) ? new ProjectM.UserOwner?() : new ProjectM.UserOwner?(userOwner);
      }
    }

    public ProjectM.Pylonstation? Pylonstation
    {
      get
      {
        ProjectM.Pylonstation pylonstation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Pylonstation>(this._entity, out pylonstation) ? new ProjectM.Pylonstation?() : new ProjectM.Pylonstation?(pylonstation);
      }
    }

    public ProjectM.CastleBuilding.CastleFloor? CastleFloor
    {
      get
      {
        ProjectM.CastleBuilding.CastleFloor castleFloor;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleFloor>(this._entity, out castleFloor) ? new ProjectM.CastleBuilding.CastleFloor?() : new ProjectM.CastleBuilding.CastleFloor?(castleFloor);
      }
    }

    public ProjectM.CastleBuilding.CastleFloorRoof? CastleFloorRoof
    {
      get
      {
        ProjectM.CastleBuilding.CastleFloorRoof castleFloorRoof;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleFloorRoof>(this._entity, out castleFloorRoof) ? new ProjectM.CastleBuilding.CastleFloorRoof?() : new ProjectM.CastleBuilding.CastleFloorRoof?(castleFloorRoof);
      }
    }

    public ProjectM.MapPylonArea? MapPylonArea
    {
      get
      {
        ProjectM.MapPylonArea mapPylonArea;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MapPylonArea>(this._entity, out mapPylonArea) ? new ProjectM.MapPylonArea?() : new ProjectM.MapPylonArea?(mapPylonArea);
      }
    }

    public ProjectM.CastleBuilding.CastleHeart? CastleHeart
    {
      get
      {
        ProjectM.CastleBuilding.CastleHeart castleHeart;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleHeart>(this._entity, out castleHeart) ? new ProjectM.CastleBuilding.CastleHeart?() : new ProjectM.CastleBuilding.CastleHeart?(castleHeart);
      }
    }

    public ProjectM.DurabilityTarget? DurabilityTarget
    {
      get
      {
        ProjectM.DurabilityTarget durabilityTarget;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DurabilityTarget>(this._entity, out durabilityTarget) ? new ProjectM.DurabilityTarget?() : new ProjectM.DurabilityTarget?(durabilityTarget);
      }
    }

    public List<ProjectM.Restricted_InventoryBuffer> Restricted_InventoryBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Restricted_InventoryBuffer>(this._entity);
    }

    public List<AttachMapIconsToEntity> AttachMapIconsToEntities
    {
      get => this._world.EntityManager.GetBufferInternal<AttachMapIconsToEntity>(this._entity);
    }

    public List<MapIconPerUserData> MapIconPerUserDatas
    {
      get => this._world.EntityManager.GetBufferInternal<MapIconPerUserData>(this._entity);
    }

    public List<PylonstationUpgradesBuffer> PylonstationUpgradesBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<PylonstationUpgradesBuffer>(this._entity);
    }

    public List<PylonstationCastleClaimBuffer> PylonstationCastleClaimBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<PylonstationCastleClaimBuffer>(this._entity);
      }
    }

    public List<PylonstationCastleDestroyBuffer> PylonstationCastleDestroyBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<PylonstationCastleDestroyBuffer>(this._entity);
      }
    }

    public List<ProgressionDependencyElement> ProgressionDependencyElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProgressionDependencyElement>(this._entity);
      }
    }

    public Door Door
    {
      get
      {
        Door door;
        return !this._world.EntityManager.TryGetComponentDataInternal<Door>(this._entity, out door) ? new Door() : door;
      }
    }

    public bool AnnounceCastleBreached
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.AnnounceCastleBreached>(this._entity);
    }

    public ProjectM.BloodAltar? BloodAltar
    {
      get
      {
        ProjectM.BloodAltar bloodAltar;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodAltar>(this._entity, out bloodAltar) ? new ProjectM.BloodAltar?() : new ProjectM.BloodAltar?(bloodAltar);
      }
    }

    public List<BloodHuntBuffer> BloodHuntBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<BloodHuntBuffer>(this._entity);
    }

    public ProjectM.StartGraveyardExitWaypoint? StartGraveyardExitWaypoint
    {
      get
      {
        ProjectM.StartGraveyardExitWaypoint graveyardExitWaypoint;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StartGraveyardExitWaypoint>(this._entity, out graveyardExitWaypoint) ? new ProjectM.StartGraveyardExitWaypoint?() : new ProjectM.StartGraveyardExitWaypoint?(graveyardExitWaypoint);
      }
    }

    public bool AlwaysNetworked
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Network.AlwaysNetworked>(this._entity);
    }

    public ProjectM.CastleBuilding.CastleWall? CastleWall
    {
      get
      {
        ProjectM.CastleBuilding.CastleWall castleWall;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleWall>(this._entity, out castleWall) ? new ProjectM.CastleBuilding.CastleWall?() : new ProjectM.CastleBuilding.CastleWall?(castleWall);
      }
    }

    public ProjectM.AoETargetImportance? AoETargetImportance
    {
      get
      {
        ProjectM.AoETargetImportance etargetImportance;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AoETargetImportance>(this._entity, out etargetImportance) ? new ProjectM.AoETargetImportance?() : new ProjectM.AoETargetImportance?(etargetImportance);
      }
    }

    public NetworkedPrefabChildren NetworkedPrefabChildren
    {
      get
      {
        NetworkedPrefabChildren networkedPrefabChildren;
        return !this._world.EntityManager.TryGetComponentDataInternal<NetworkedPrefabChildren>(this._entity, out networkedPrefabChildren) ? new NetworkedPrefabChildren() : networkedPrefabChildren;
      }
    }

    public ProjectM.RespawnPoint? RespawnPoint
    {
      get
      {
        ProjectM.RespawnPoint respawnPoint;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RespawnPoint>(this._entity, out respawnPoint) ? new ProjectM.RespawnPoint?() : new ProjectM.RespawnPoint?(respawnPoint);
      }
    }

    public ProjectM.ChunkWaypoint? ChunkWaypoint
    {
      get
      {
        ProjectM.ChunkWaypoint chunkWaypoint;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ChunkWaypoint>(this._entity, out chunkWaypoint) ? new ProjectM.ChunkWaypoint?() : new ProjectM.ChunkWaypoint?(chunkWaypoint);
      }
    }

    public bool CastleWaypoint
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.CastleWaypoint>(this._entity);
    }

    public ProjectM.Residency? Residency
    {
      get
      {
        ProjectM.Residency residency;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Residency>(this._entity, out residency) ? new ProjectM.Residency?() : new ProjectM.Residency?(residency);
      }
    }

    public ProjectM.LastTranslation? LastTranslation
    {
      get
      {
        ProjectM.LastTranslation lastTranslation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.LastTranslation>(this._entity, out lastTranslation) ? new ProjectM.LastTranslation?() : new ProjectM.LastTranslation?(lastTranslation);
      }
    }

    public ProjectM.Network.OnlySyncToUserBitMask? OnlySyncToUserBitMask
    {
      get
      {
        ProjectM.Network.OnlySyncToUserBitMask syncToUserBitMask;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.OnlySyncToUserBitMask>(this._entity, out syncToUserBitMask) ? new ProjectM.Network.OnlySyncToUserBitMask?() : new ProjectM.Network.OnlySyncToUserBitMask?(syncToUserBitMask);
      }
    }

    public List<StartItemBuffer> StartItemBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<StartItemBuffer>(this._entity);
    }

    public List<OnlySyncToUserBuffer> OnlySyncToUserBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<OnlySyncToUserBuffer>(this._entity);
    }

    public bool InventoryStartItems
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.InventoryStartItems>(this._entity);
    }

    public bool StaticSceneTag
    {
      get => this._world.EntityManager.HasComponentInternal<Unity.Entities.StaticSceneTag>(this._entity);
    }

    public bool SceneTag => this._world.EntityManager.HasComponentInternal<Unity.Entities.SceneTag>(this._entity);

    public List<Unity.Transforms.Child> Children
    {
      get => this._world.EntityManager.GetBufferInternal<Unity.Transforms.Child>(this._entity);
    }

    public bool SceneSection
    {
      get => this._world.EntityManager.HasComponentInternal<Unity.Entities.SceneSection>(this._entity);
    }

    public ProjectM.Wallpaper_NotSplit? Wallpaper_NotSplit
    {
      get
      {
        ProjectM.Wallpaper_NotSplit wallpaperNotSplit;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Wallpaper_NotSplit>(this._entity, out wallpaperNotSplit) ? new ProjectM.Wallpaper_NotSplit?() : new ProjectM.Wallpaper_NotSplit?(wallpaperNotSplit);
      }
    }

    public WallpaperStyles WallpaperStyles
    {
      get
      {
        WallpaperStyles wallpaperStyles;
        return !this._world.EntityManager.TryGetComponentDataInternal<WallpaperStyles>(this._entity, out wallpaperStyles) ? new WallpaperStyles() : wallpaperStyles;
      }
    }

    public List<CastleBuildingAttachmentActiveBuffsBuffer> CastleBuildingAttachmentActiveBuffsBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CastleBuildingAttachmentActiveBuffsBuffer>(this._entity);
      }
    }

    public List<CastleBuildingAttachmentApplyBuff> CastleBuildingAttachmentApplyBuffs
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CastleBuildingAttachmentApplyBuff>(this._entity);
      }
    }

    public Unity.Transforms.LocalToParent? LocalToParent
    {
      get
      {
        Unity.Transforms.LocalToParent localToParent;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Transforms.LocalToParent>(this._entity, out localToParent) ? new Unity.Transforms.LocalToParent?() : new Unity.Transforms.LocalToParent?(localToParent);
      }
    }

    public ProjectM.Terrain.WorldRegionPolygon? WorldRegionPolygon
    {
      get
      {
        ProjectM.Terrain.WorldRegionPolygon worldRegionPolygon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.WorldRegionPolygon>(this._entity, out worldRegionPolygon) ? new ProjectM.Terrain.WorldRegionPolygon?() : new ProjectM.Terrain.WorldRegionPolygon?(worldRegionPolygon);
      }
    }

    public Unity.Transforms.PreviousParent? PreviousParent
    {
      get
      {
        Unity.Transforms.PreviousParent previousParent;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Transforms.PreviousParent>(this._entity, out previousParent) ? new Unity.Transforms.PreviousParent?() : new Unity.Transforms.PreviousParent?(previousParent);
      }
    }

    public List<WorldRegionPolygonVertex> WorldRegionPolygonVertexes
    {
      get => this._world.EntityManager.GetBufferInternal<WorldRegionPolygonVertex>(this._entity);
    }

    public ProjectM.Wallpaper_TwoSplits? Wallpaper_TwoSplits
    {
      get
      {
        ProjectM.Wallpaper_TwoSplits wallpaperTwoSplits;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Wallpaper_TwoSplits>(this._entity, out wallpaperTwoSplits) ? new ProjectM.Wallpaper_TwoSplits?() : new ProjectM.Wallpaper_TwoSplits?(wallpaperTwoSplits);
      }
    }

    public ProjectM.CastleBuilding.WallRoofOrnament? WallRoofOrnament
    {
      get
      {
        ProjectM.CastleBuilding.WallRoofOrnament wallRoofOrnament;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.WallRoofOrnament>(this._entity, out wallRoofOrnament) ? new ProjectM.CastleBuilding.WallRoofOrnament?() : new ProjectM.CastleBuilding.WallRoofOrnament?(wallRoofOrnament);
      }
    }

    public ProjectM.Terrain.WaypointRegionPolygon? WaypointRegionPolygon
    {
      get
      {
        ProjectM.Terrain.WaypointRegionPolygon waypointRegionPolygon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.WaypointRegionPolygon>(this._entity, out waypointRegionPolygon) ? new ProjectM.Terrain.WaypointRegionPolygon?() : new ProjectM.Terrain.WaypointRegionPolygon?(waypointRegionPolygon);
      }
    }

    public List<BundleElementData> BundleElementDatas
    {
      get => this._world.EntityManager.GetBufferInternal<BundleElementData>(this._entity);
    }

    public bool SceneSectionBundle
    {
      get => this._world.EntityManager.HasComponentInternal<Unity.Scenes.SceneSectionBundle>(this._entity);
    }

    public ProjectM.Terrain.WorldZoneId? WorldZoneId
    {
      get
      {
        ProjectM.Terrain.WorldZoneId worldZoneId;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.WorldZoneId>(this._entity, out worldZoneId) ? new ProjectM.Terrain.WorldZoneId?() : new ProjectM.Terrain.WorldZoneId?(worldZoneId);
      }
    }

    public ProjectM.Terrain.WorldZoneTextureProjectionMatrix? WorldZoneTextureProjectionMatrix
    {
      get
      {
        ProjectM.Terrain.WorldZoneTextureProjectionMatrix projectionMatrix;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.WorldZoneTextureProjectionMatrix>(this._entity, out projectionMatrix) ? new ProjectM.Terrain.WorldZoneTextureProjectionMatrix?() : new ProjectM.Terrain.WorldZoneTextureProjectionMatrix?(projectionMatrix);
      }
    }

    public ProjectM.Terrain.TerrainChunk? TerrainChunk
    {
      get
      {
        ProjectM.Terrain.TerrainChunk terrainChunk;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.TerrainChunk>(this._entity, out terrainChunk) ? new ProjectM.Terrain.TerrainChunk?() : new ProjectM.Terrain.TerrainChunk?(terrainChunk);
      }
    }

    public ProjectM.Terrain.ChunkSceneId? ChunkSceneId
    {
      get
      {
        ProjectM.Terrain.ChunkSceneId chunkSceneId;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.ChunkSceneId>(this._entity, out chunkSceneId) ? new ProjectM.Terrain.ChunkSceneId?() : new ProjectM.Terrain.ChunkSceneId?(chunkSceneId);
      }
    }

    public BakedCollisionTilesBoundsRef BakedCollisionTilesBoundsRef
    {
      get
      {
        BakedCollisionTilesBoundsRef collisionTilesBoundsRef;
        return !this._world.EntityManager.TryGetComponentDataInternal<BakedCollisionTilesBoundsRef>(this._entity, out collisionTilesBoundsRef) ? new BakedCollisionTilesBoundsRef() : collisionTilesBoundsRef;
      }
    }

    public BakedLineOfSightTileDataBoundsRef BakedLineOfSightTileDataBoundsRef
    {
      get
      {
        BakedLineOfSightTileDataBoundsRef tileDataBoundsRef;
        return !this._world.EntityManager.TryGetComponentDataInternal<BakedLineOfSightTileDataBoundsRef>(this._entity, out tileDataBoundsRef) ? new BakedLineOfSightTileDataBoundsRef() : tileDataBoundsRef;
      }
    }

    public BakedPathfindingTileDataBoundsRef BakedPathfindingTileDataBoundsRef
    {
      get
      {
        BakedPathfindingTileDataBoundsRef tileDataBoundsRef;
        return !this._world.EntityManager.TryGetComponentDataInternal<BakedPathfindingTileDataBoundsRef>(this._entity, out tileDataBoundsRef) ? new BakedPathfindingTileDataBoundsRef() : tileDataBoundsRef;
      }
    }

    public List<ReplaceDropTableElement> ReplaceDropTableElements
    {
      get => this._world.EntityManager.GetBufferInternal<ReplaceDropTableElement>(this._entity);
    }

    public List<ReplaceRandomizedSpawnChainElement> ReplaceRandomizedSpawnChainElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ReplaceRandomizedSpawnChainElement>(this._entity);
      }
    }

    public List<StaticTransformElement> StaticTransformElements
    {
      get => this._world.EntityManager.GetBufferInternal<StaticTransformElement>(this._entity);
    }

    public List<ControllableAreaIdBuffer> ControllableAreaIdBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<ControllableAreaIdBuffer>(this._entity);
    }

    public List<ProjectM.Terrain.ChunkBaseGameplayHeights> ChunkBaseGameplayHeights
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Terrain.ChunkBaseGameplayHeights>(this._entity);
    }

    public List<ProjectM.Tiles.BakedCollisionTiles> BakedCollisionTiles
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Tiles.BakedCollisionTiles>(this._entity);
    }

    public List<ProjectM.Tiles.BakedLineOfSightTiles> BakedLineOfSightTiles
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Tiles.BakedLineOfSightTiles>(this._entity);
    }

    public List<ProjectM.Tiles.BakedPlacementTiles> BakedPlacementTiles
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Tiles.BakedPlacementTiles>(this._entity);
    }

    public List<ProjectM.Tiles.BakedPlacementTilesBounds> BakedPlacementTilesBounds
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Tiles.BakedPlacementTilesBounds>(this._entity);
    }

    public List<BakedPathfindingTileData> BakedPathfindingTileDatas
    {
      get => this._world.EntityManager.GetBufferInternal<BakedPathfindingTileData>(this._entity);
    }

    public bool Static => this._world.EntityManager.HasComponentInternal<Unity.Transforms.Static>(this._entity);

    public bool TerrainTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Terrain.TerrainTag>(this._entity);
    }

    public bool MakeStaticOnLoad
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Terrain.MakeStaticOnLoad>(this._entity);
    }

    public bool TerrainChunkShared
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Terrain.TerrainChunkShared>(this._entity);
    }

    public bool StaticTileModel
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Tiles.StaticTileModel>(this._entity);
    }

    public Unity.Transforms.NonUniformScale? NonUniformScale
    {
      get
      {
        Unity.Transforms.NonUniformScale nonUniformScale;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Transforms.NonUniformScale>(this._entity, out nonUniformScale) ? new Unity.Transforms.NonUniformScale?() : new Unity.Transforms.NonUniformScale?(nonUniformScale);
      }
    }

    public ProjectM.Terrain.ProcessChunkTask? ProcessChunkTask
    {
      get
      {
        ProjectM.Terrain.ProcessChunkTask processChunkTask;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.ProcessChunkTask>(this._entity, out processChunkTask) ? new ProjectM.Terrain.ProcessChunkTask?() : new ProjectM.Terrain.ProcessChunkTask?(processChunkTask);
      }
    }

    public ProjectM.Terrain.LoadTerrainChunkRequest? LoadTerrainChunkRequest
    {
      get
      {
        ProjectM.Terrain.LoadTerrainChunkRequest terrainChunkRequest;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.LoadTerrainChunkRequest>(this._entity, out terrainChunkRequest) ? new ProjectM.Terrain.LoadTerrainChunkRequest?() : new ProjectM.Terrain.LoadTerrainChunkRequest?(terrainChunkRequest);
      }
    }

    public ProjectM.Wallpaper_FourSplits? Wallpaper_FourSplits
    {
      get
      {
        ProjectM.Wallpaper_FourSplits wallpaperFourSplits;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Wallpaper_FourSplits>(this._entity, out wallpaperFourSplits) ? new ProjectM.Wallpaper_FourSplits?() : new ProjectM.Wallpaper_FourSplits?(wallpaperFourSplits);
      }
    }

    public ProjectM.Terrain.TerrainChunkMetadata? TerrainChunkMetadata
    {
      get
      {
        ProjectM.Terrain.TerrainChunkMetadata terrainChunkMetadata;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.TerrainChunkMetadata>(this._entity, out terrainChunkMetadata) ? new ProjectM.Terrain.TerrainChunkMetadata?() : new ProjectM.Terrain.TerrainChunkMetadata?(terrainChunkMetadata);
      }
    }

    public ChunkRoadGraph ChunkRoadGraph
    {
      get
      {
        ChunkRoadGraph chunkRoadGraph;
        return !this._world.EntityManager.TryGetComponentDataInternal<ChunkRoadGraph>(this._entity, out chunkRoadGraph) ? new ChunkRoadGraph() : chunkRoadGraph;
      }
    }

    public List<TerrainChunkPortalBuffer> TerrainChunkPortalBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<TerrainChunkPortalBuffer>(this._entity);
    }

    public List<MapZoneNameOverride> MapZoneNameOverrides
    {
      get => this._world.EntityManager.GetBufferInternal<MapZoneNameOverride>(this._entity);
    }

    public List<MapIconNameOverride> MapIconNameOverrides
    {
      get => this._world.EntityManager.GetBufferInternal<MapIconNameOverride>(this._entity);
    }

    public UpgradeableFromTileModel UpgradeableFromTileModel
    {
      get
      {
        UpgradeableFromTileModel upgradeableFromTileModel;
        return !this._world.EntityManager.TryGetComponentDataInternal<UpgradeableFromTileModel>(this._entity, out upgradeableFromTileModel) ? new UpgradeableFromTileModel() : upgradeableFromTileModel;
      }
    }

    public ProjectM.Shared.Relic? Relic
    {
      get
      {
        ProjectM.Shared.Relic relic;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Shared.Relic>(this._entity, out relic) ? new ProjectM.Shared.Relic?() : new ProjectM.Shared.Relic?(relic);
      }
    }

    public List<DropTableBuffer> DropTableBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<DropTableBuffer>(this._entity);
    }

    public bool DropTable
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DropTable>(this._entity);
    }

    public bool DropTableOnDeath
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DropTableOnDeath>(this._entity);
    }

    public bool DropTableOnDestroy
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DropTableOnDestroy>(this._entity);
    }

    public ProjectM.ChunkWaypointMetadata? ChunkWaypointMetadata
    {
      get
      {
        ProjectM.ChunkWaypointMetadata waypointMetadata;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ChunkWaypointMetadata>(this._entity, out waypointMetadata) ? new ProjectM.ChunkWaypointMetadata?() : new ProjectM.ChunkWaypointMetadata?(waypointMetadata);
      }
    }

    public MapZoneDataPacked MapZoneDataPacked
    {
      get
      {
        MapZoneDataPacked mapZoneDataPacked;
        return !this._world.EntityManager.TryGetComponentDataInternal<MapZoneDataPacked>(this._entity, out mapZoneDataPacked) ? new MapZoneDataPacked() : mapZoneDataPacked;
      }
    }

    public ProjectM.ChunkScenePortalMetadata? ChunkScenePortalMetadata
    {
      get
      {
        ProjectM.ChunkScenePortalMetadata scenePortalMetadata;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ChunkScenePortalMetadata>(this._entity, out scenePortalMetadata) ? new ProjectM.ChunkScenePortalMetadata?() : new ProjectM.ChunkScenePortalMetadata?(scenePortalMetadata);
      }
    }

    public ProjectM.NetherSpawnPositionMetadata? NetherSpawnPositionMetadata
    {
      get
      {
        ProjectM.NetherSpawnPositionMetadata positionMetadata;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.NetherSpawnPositionMetadata>(this._entity, out positionMetadata) ? new ProjectM.NetherSpawnPositionMetadata?() : new ProjectM.NetherSpawnPositionMetadata?(positionMetadata);
      }
    }

    public ProjectM.Attach? Attach
    {
      get
      {
        ProjectM.Attach attach;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Attach>(this._entity, out attach) ? new ProjectM.Attach?() : new ProjectM.Attach?(attach);
      }
    }

    public ProjectM.Buff? Buff
    {
      get
      {
        ProjectM.Buff buff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Buff>(this._entity, out buff) ? new ProjectM.Buff?() : new ProjectM.Buff?(buff);
      }
    }

    public ProjectM.ReplaceAbilityOnSlotData? ReplaceAbilityOnSlotData
    {
      get
      {
        ProjectM.ReplaceAbilityOnSlotData abilityOnSlotData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ReplaceAbilityOnSlotData>(this._entity, out abilityOnSlotData) ? new ProjectM.ReplaceAbilityOnSlotData?() : new ProjectM.ReplaceAbilityOnSlotData?(abilityOnSlotData);
      }
    }

    public ProjectM.BuffCategory? BuffCategory
    {
      get
      {
        ProjectM.BuffCategory buffCategory;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BuffCategory>(this._entity, out buffCategory) ? new ProjectM.BuffCategory?() : new ProjectM.BuffCategory?(buffCategory);
      }
    }

    public ProjectM.SpellLevel? SpellLevel
    {
      get
      {
        ProjectM.SpellLevel spellLevel;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpellLevel>(this._entity, out spellLevel) ? new ProjectM.SpellLevel?() : new ProjectM.SpellLevel?(spellLevel);
      }
    }

    public List<ProjectM.ModifyUnitStatBuff_DOTS> ModifyUnitStatBuff_DOTS
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.ModifyUnitStatBuff_DOTS>(this._entity);
    }

    public List<ReplaceAbilityOnSlotBuff> ReplaceAbilityOnSlotBuffs
    {
      get => this._world.EntityManager.GetBufferInternal<ReplaceAbilityOnSlotBuff>(this._entity);
    }

    public bool Buff_Persists_Through_Death
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.Buff_Persists_Through_Death>(this._entity);
      }
    }

    public bool ScriptUpdate
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Scripting.ScriptUpdate>(this._entity);
    }

    public ProjectM.Age? Age
    {
      get
      {
        ProjectM.Age age;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Age>(this._entity, out age) ? new ProjectM.Age?() : new ProjectM.Age?(age);
      }
    }

    public ProjectM.Scripting.ScriptDestroy? ScriptDestroy
    {
      get
      {
        ProjectM.Scripting.ScriptDestroy scriptDestroy;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Scripting.ScriptDestroy>(this._entity, out scriptDestroy) ? new ProjectM.Scripting.ScriptDestroy?() : new ProjectM.Scripting.ScriptDestroy?(scriptDestroy);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_ModifyDynamicCollision_DataServer? Script_Buff_ModifyDynamicCollision_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_ModifyDynamicCollision_DataServer collisionDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_ModifyDynamicCollision_DataServer>(this._entity, out collisionDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_ModifyDynamicCollision_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_ModifyDynamicCollision_DataServer?(collisionDataServer);
      }
    }

    public bool InCombatBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.InCombatBuff>(this._entity);
    }

    public bool UseCombatAnimationState
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.UseCombatAnimationState>(this._entity);
    }

    public ProjectM.DisableAggroBuff? DisableAggroBuff
    {
      get
      {
        ProjectM.DisableAggroBuff disableAggroBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DisableAggroBuff>(this._entity, out disableAggroBuff) ? new ProjectM.DisableAggroBuff?() : new ProjectM.DisableAggroBuff?(disableAggroBuff);
      }
    }

    public ProjectM.SpawnPrefabOnDestroy? SpawnPrefabOnDestroy
    {
      get
      {
        ProjectM.SpawnPrefabOnDestroy spawnPrefabOnDestroy;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnPrefabOnDestroy>(this._entity, out spawnPrefabOnDestroy) ? new ProjectM.SpawnPrefabOnDestroy?() : new ProjectM.SpawnPrefabOnDestroy?(spawnPrefabOnDestroy);
      }
    }

    public bool HideTargetHUD
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.HideTargetHUD>(this._entity);
    }

    public List<HealOnGameplayEvent> HealOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<HealOnGameplayEvent>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_TrueForm_DataServer? Script_Buff_TrueForm_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_TrueForm_DataServer trueFormDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_TrueForm_DataServer>(this._entity, out trueFormDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_TrueForm_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_TrueForm_DataServer?(trueFormDataServer);
      }
    }

    public ProjectM.LifeTime? LifeTime
    {
      get
      {
        ProjectM.LifeTime lifeTime;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.LifeTime>(this._entity, out lifeTime) ? new ProjectM.LifeTime?() : new ProjectM.LifeTime?(lifeTime);
      }
    }

    public ProjectM.ModifyBloodDrainBuff? ModifyBloodDrainBuff
    {
      get
      {
        ProjectM.ModifyBloodDrainBuff modifyBloodDrainBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyBloodDrainBuff>(this._entity, out modifyBloodDrainBuff) ? new ProjectM.ModifyBloodDrainBuff?() : new ProjectM.ModifyBloodDrainBuff?(modifyBloodDrainBuff);
      }
    }

    public ProjectM.SetOwnerRotateTowardsMouse? SetOwnerRotateTowardsMouse
    {
      get
      {
        ProjectM.SetOwnerRotateTowardsMouse rotateTowardsMouse;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SetOwnerRotateTowardsMouse>(this._entity, out rotateTowardsMouse) ? new ProjectM.SetOwnerRotateTowardsMouse?() : new ProjectM.SetOwnerRotateTowardsMouse?(rotateTowardsMouse);
      }
    }

    public ProjectM.Description? Description
    {
      get
      {
        ProjectM.Description description;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Description>(this._entity, out description) ? new ProjectM.Description?() : new ProjectM.Description?(description);
      }
    }

    public bool GetOwnerTeamOnSpawn
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.GetOwnerTeamOnSpawn>(this._entity);
    }

    public List<CreateGameplayEventsOnTick> CreateGameplayEventsOnTicks
    {
      get => this._world.EntityManager.GetBufferInternal<CreateGameplayEventsOnTick>(this._entity);
    }

    public List<RunScriptOnGameplayEvent> RunScriptOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<RunScriptOnGameplayEvent>(this._entity);
    }

    public ProjectM.CloudCookie? CloudCookie
    {
      get
      {
        ProjectM.CloudCookie cloudCookie;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CloudCookie>(this._entity, out cloudCookie) ? new ProjectM.CloudCookie?() : new ProjectM.CloudCookie?(cloudCookie);
      }
    }

    public bool CloudLight
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.CloudLight>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.RadialZone_Environment_Data? RadialZone_Environment_Data
    {
      get
      {
        ProjectM.Gameplay.Scripting.RadialZone_Environment_Data zoneEnvironmentData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.RadialZone_Environment_Data>(this._entity, out zoneEnvironmentData) ? new ProjectM.Gameplay.Scripting.RadialZone_Environment_Data?() : new ProjectM.Gameplay.Scripting.RadialZone_Environment_Data?(zoneEnvironmentData);
      }
    }

    public List<HashedTypesBuffer> HashedTypesBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<HashedTypesBuffer>(this._entity);
    }

    public List<ProjectM.Gameplay.Scripting.RadialZone_Environment_HitSpheres> RadialZone_Environment_HitSpheres
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.RadialZone_Environment_HitSpheres>(this._entity);
      }
    }

    public bool HolyArea => this._world.EntityManager.HasComponentInternal<ProjectM.Gameplay.Scripting.HolyArea>(this._entity);

    public bool Disabled => this._world.EntityManager.HasComponentInternal<Unity.Entities.Disabled>(this._entity);

    public bool DisabledDueToNoPlayersInRange
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.DisabledDueToNoPlayersInRange>(this._entity);
      }
    }

    public bool GarlicArea
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Gameplay.Scripting.GarlicArea>(this._entity);
    }

    public ProjectM.CastleBuilding.CurrentTileModelEditing? CurrentTileModelEditing
    {
      get
      {
        ProjectM.CastleBuilding.CurrentTileModelEditing tileModelEditing;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CurrentTileModelEditing>(this._entity, out tileModelEditing) ? new ProjectM.CastleBuilding.CurrentTileModelEditing?() : new ProjectM.CastleBuilding.CurrentTileModelEditing?(tileModelEditing);
      }
    }

    public bool CanBuildTileModels
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.CastleBuilding.CanBuildTileModels>(this._entity);
    }

    public Unity.Transforms.CompositeScale? CompositeScale
    {
      get
      {
        Unity.Transforms.CompositeScale compositeScale;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Transforms.CompositeScale>(this._entity, out compositeScale) ? new Unity.Transforms.CompositeScale?() : new Unity.Transforms.CompositeScale?(compositeScale);
      }
    }

    public ManagedItemSet ManagedItemSet
    {
      get
      {
        ManagedItemSet managedItemSet;
        return !this._world.EntityManager.TryGetComponentDataInternal<ManagedItemSet>(this._entity, out managedItemSet) ? (ManagedItemSet) null : managedItemSet;
      }
    }

    public FeatureCollectionComponent FeatureCollectionComponent
    {
      get
      {
        FeatureCollectionComponent collectionComponent;
        return !this._world.EntityManager.TryGetComponentDataInternal<FeatureCollectionComponent>(this._entity, out collectionComponent) ? (FeatureCollectionComponent) null : collectionComponent;
      }
    }

    public ManagedItemData ManagedItemData
    {
      get
      {
        ManagedItemData managedItemData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ManagedItemData>(this._entity, out managedItemData) ? (ManagedItemData) null : managedItemData;
      }
    }

    public bool GameDataInitializedSingleton
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.GameDataInitializedSingleton>(this._entity);
      }
    }

    public ProjectM.Sequencer.SpawnSequenceForEntity? SpawnSequenceForEntity
    {
      get
      {
        ProjectM.Sequencer.SpawnSequenceForEntity sequenceForEntity;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Sequencer.SpawnSequenceForEntity>(this._entity, out sequenceForEntity) ? new ProjectM.Sequencer.SpawnSequenceForEntity?() : new ProjectM.Sequencer.SpawnSequenceForEntity?(sequenceForEntity);
      }
    }

    public ProjectM.DestroyWhenNoCharacterNearbyAfterDuration? DestroyWhenNoCharacterNearbyAfterDuration
    {
      get
      {
        ProjectM.DestroyWhenNoCharacterNearbyAfterDuration nearbyAfterDuration;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DestroyWhenNoCharacterNearbyAfterDuration>(this._entity, out nearbyAfterDuration) ? new ProjectM.DestroyWhenNoCharacterNearbyAfterDuration?() : new ProjectM.DestroyWhenNoCharacterNearbyAfterDuration?(nearbyAfterDuration);
      }
    }

    public ProjectM.ItemPickup? ItemPickup
    {
      get
      {
        ProjectM.ItemPickup itemPickup;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ItemPickup>(this._entity, out itemPickup) ? new ProjectM.ItemPickup?() : new ProjectM.ItemPickup?(itemPickup);
      }
    }

    public ProjectM.PlaySequenceOnPickup? PlaySequenceOnPickup
    {
      get
      {
        ProjectM.PlaySequenceOnPickup sequenceOnPickup;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PlaySequenceOnPickup>(this._entity, out sequenceOnPickup) ? new ProjectM.PlaySequenceOnPickup?() : new ProjectM.PlaySequenceOnPickup?(sequenceOnPickup);
      }
    }

    public ProjectM.PlayerDeathContainer? PlayerDeathContainer
    {
      get
      {
        ProjectM.PlayerDeathContainer playerDeathContainer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PlayerDeathContainer>(this._entity, out playerDeathContainer) ? new ProjectM.PlayerDeathContainer?() : new ProjectM.PlayerDeathContainer?(playerDeathContainer);
      }
    }

    public ProjectM.DestroyAfterDuration? DestroyAfterDuration
    {
      get
      {
        ProjectM.DestroyAfterDuration destroyAfterDuration;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DestroyAfterDuration>(this._entity, out destroyAfterDuration) ? new ProjectM.DestroyAfterDuration?() : new ProjectM.DestroyAfterDuration?(destroyAfterDuration);
      }
    }

    public ProjectM.Height? Height
    {
      get
      {
        ProjectM.Height height;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Height>(this._entity, out height) ? new ProjectM.Height?() : new ProjectM.Height?(height);
      }
    }

    public bool DestroyWhenInventoryIsEmpty
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.DestroyWhenInventoryIsEmpty>(this._entity);
      }
    }

    public ProjectM.SiegeWeapon? SiegeWeapon
    {
      get
      {
        ProjectM.SiegeWeapon siegeWeapon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SiegeWeapon>(this._entity, out siegeWeapon) ? new ProjectM.SiegeWeapon?() : new ProjectM.SiegeWeapon?(siegeWeapon);
      }
    }

    public List<CreateGameplayEventsOnDestroy> CreateGameplayEventsOnDestroys
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CreateGameplayEventsOnDestroy>(this._entity);
      }
    }

    public List<CreateGameplayEventsOnTimePassed> CreateGameplayEventsOnTimePasseds
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CreateGameplayEventsOnTimePassed>(this._entity);
      }
    }

    public List<DestroyOnGameplayEvent> DestroyOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<DestroyOnGameplayEvent>(this._entity);
    }

    public bool AnnounceSiegeWeapon
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.AnnounceSiegeWeapon>(this._entity);
    }

    public List<AchievementInProgressElement> AchievementInProgressElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<AchievementInProgressElement>(this._entity);
      }
    }

    public List<AchievementClaimedElement> AchievementClaimedElements
    {
      get => this._world.EntityManager.GetBufferInternal<AchievementClaimedElement>(this._entity);
    }

    public List<ProjectM.TeamAllies> TeamAllies
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.TeamAllies>(this._entity);
    }

    public ProjectM.ProgressionMapper? ProgressionMapper
    {
      get
      {
        ProjectM.ProgressionMapper progressionMapper;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ProgressionMapper>(this._entity, out progressionMapper) ? new ProjectM.ProgressionMapper?() : new ProjectM.ProgressionMapper?(progressionMapper);
      }
    }

    public ProjectM.EntityInput? EntityInput
    {
      get
      {
        ProjectM.EntityInput entityInput;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EntityInput>(this._entity, out entityInput) ? new ProjectM.EntityInput?() : new ProjectM.EntityInput?(entityInput);
      }
    }

    public ProjectM.Controller? Controller
    {
      get
      {
        ProjectM.Controller controller;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Controller>(this._entity, out controller) ? new ProjectM.Controller?() : new ProjectM.Controller?(controller);
      }
    }

    public ProjectM.Network.User? User
    {
      get
      {
        ProjectM.Network.User user;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.User>(this._entity, out user) ? new ProjectM.Network.User?() : new ProjectM.Network.User?(user);
      }
    }

    public ProjectM.Network.InputCommandDataProxy? InputCommandDataProxy
    {
      get
      {
        ProjectM.Network.InputCommandDataProxy commandDataProxy;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.InputCommandDataProxy>(this._entity, out commandDataProxy) ? new ProjectM.Network.InputCommandDataProxy?() : new ProjectM.Network.InputCommandDataProxy?(commandDataProxy);
      }
    }

    public ProjectM.AchievementOwner? AchievementOwner
    {
      get
      {
        ProjectM.AchievementOwner achievementOwner;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AchievementOwner>(this._entity, out achievementOwner) ? new ProjectM.AchievementOwner?() : new ProjectM.AchievementOwner?(achievementOwner);
      }
    }

    public ProjectM.CurrentMapZone? CurrentMapZone
    {
      get
      {
        ProjectM.CurrentMapZone currentMapZone;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CurrentMapZone>(this._entity, out currentMapZone) ? new ProjectM.CurrentMapZone?() : new ProjectM.CurrentMapZone?(currentMapZone);
      }
    }

    public ProjectM.ClanRole? ClanRole
    {
      get
      {
        ProjectM.ClanRole clanRole;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ClanRole>(this._entity, out clanRole) ? new ProjectM.ClanRole?() : new ProjectM.ClanRole?(clanRole);
      }
    }

    public ProjectM.Emoter? Emoter
    {
      get
      {
        ProjectM.Emoter emoter;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Emoter>(this._entity, out emoter) ? new ProjectM.Emoter?() : new ProjectM.Emoter?(emoter);
      }
    }

    public ProjectM.Shapeshift? Shapeshift
    {
      get
      {
        ProjectM.Shapeshift shapeshift;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Shapeshift>(this._entity, out shapeshift) ? new ProjectM.Shapeshift?() : new ProjectM.Shapeshift?(shapeshift);
      }
    }

    public ProjectM.Terrain.CurrentWorldRegion? CurrentWorldRegion
    {
      get
      {
        ProjectM.Terrain.CurrentWorldRegion currentWorldRegion;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Terrain.CurrentWorldRegion>(this._entity, out currentWorldRegion) ? new ProjectM.Terrain.CurrentWorldRegion?() : new ProjectM.Terrain.CurrentWorldRegion?(currentWorldRegion);
      }
    }

    public ProjectM.Network.Latency? Latency
    {
      get
      {
        ProjectM.Network.Latency latency;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.Latency>(this._entity, out latency) ? new ProjectM.Network.Latency?() : new ProjectM.Network.Latency?(latency);
      }
    }

    public ProjectM.Network.ServerNetworkState? ServerNetworkState
    {
      get
      {
        ProjectM.Network.ServerNetworkState serverNetworkState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.ServerNetworkState>(this._entity, out serverNetworkState) ? new ProjectM.Network.ServerNetworkState?() : new ProjectM.Network.ServerNetworkState?(serverNetworkState);
      }
    }

    public ProjectM.Network.DisconnectedTimer? DisconnectedTimer
    {
      get
      {
        ProjectM.Network.DisconnectedTimer disconnectedTimer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.DisconnectedTimer>(this._entity, out disconnectedTimer) ? new ProjectM.Network.DisconnectedTimer?() : new ProjectM.Network.DisconnectedTimer?(disconnectedTimer);
      }
    }

    public ProjectM.Network.UserHeartCount? UserHeartCount
    {
      get
      {
        ProjectM.Network.UserHeartCount userHeartCount;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.UserHeartCount>(this._entity, out userHeartCount) ? new ProjectM.Network.UserHeartCount?() : new ProjectM.Network.UserHeartCount?(userHeartCount);
      }
    }

    public List<AllyPermission> AllyPermissions
    {
      get => this._world.EntityManager.GetBufferInternal<AllyPermission>(this._entity);
    }

    public List<UnlockedWaypointElement> UnlockedWaypointElements
    {
      get => this._world.EntityManager.GetBufferInternal<UnlockedWaypointElement>(this._entity);
    }

    public List<InputCommandBufferElement> InputCommandBufferElements
    {
      get => this._world.EntityManager.GetBufferInternal<InputCommandBufferElement>(this._entity);
    }

    public List<RespawnPointOwnerBuffer> RespawnPointOwnerBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<RespawnPointOwnerBuffer>(this._entity);
    }

    public List<UserMapZoneElement> UserMapZoneElements
    {
      get => this._world.EntityManager.GetBufferInternal<UserMapZoneElement>(this._entity);
    }

    public List<IncomingClientMessage> IncomingClientMessages
    {
      get => this._world.EntityManager.GetBufferInternal<IncomingClientMessage>(this._entity);
    }

    public List<IncomingNetBuffer> IncomingNetBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<IncomingNetBuffer>(this._entity);
    }

    public List<UserNetBuffer> UserNetBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<UserNetBuffer>(this._entity);
    }

    public List<PriorityEntitiesToSerializeBuffer> PriorityEntitiesToSerializeBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<PriorityEntitiesToSerializeBuffer>(this._entity);
      }
    }

    public List<PanicEntitiesToSerializeBuffer> PanicEntitiesToSerializeBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<PanicEntitiesToSerializeBuffer>(this._entity);
      }
    }

    public List<UserEntityNetworkState> UserEntityNetworkStates
    {
      get => this._world.EntityManager.GetBufferInternal<UserEntityNetworkState>(this._entity);
    }

    public List<TileCollisionHistoryElement> TileCollisionHistoryElements
    {
      get => this._world.EntityManager.GetBufferInternal<TileCollisionHistoryElement>(this._entity);
    }

    public List<TileGameplayHeightsHistoryElement> TileGameplayHeightsHistoryElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<TileGameplayHeightsHistoryElement>(this._entity);
      }
    }

    public List<TileCollisionHistoryMetadataElement> TileCollisionHistoryMetadataElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<TileCollisionHistoryMetadataElement>(this._entity);
      }
    }

    public List<TileDisabledCollisionHistoryElement> TileDisabledCollisionHistoryElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<TileDisabledCollisionHistoryElement>(this._entity);
      }
    }

    public List<InputCommandStateHistoryBufferElement> InputCommandStateHistoryBufferElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<InputCommandStateHistoryBufferElement>(this._entity);
      }
    }

    public List<DefaultAction> DefaultActions
    {
      get => this._world.EntityManager.GetBufferInternal<DefaultAction>(this._entity);
    }

    public List<EmoteAbility> EmoteAbilities
    {
      get => this._world.EntityManager.GetBufferInternal<EmoteAbility>(this._entity);
    }

    public List<ShapeshiftAbility> ShapeshiftAbilities
    {
      get => this._world.EntityManager.GetBufferInternal<ShapeshiftAbility>(this._entity);
    }

    public bool NeutralTeam
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.NeutralTeam>(this._entity);
    }

    public ProjectM.ClanTeam? ClanTeam
    {
      get
      {
        ProjectM.ClanTeam clanTeam;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ClanTeam>(this._entity, out clanTeam) ? new ProjectM.ClanTeam?() : new ProjectM.ClanTeam?(clanTeam);
      }
    }

    public bool UnitTeam => this._world.EntityManager.HasComponentInternal<ProjectM.UnitTeam>(this._entity);

    public ProjectM.UserTeam? UserTeam
    {
      get
      {
        ProjectM.UserTeam userTeam;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UserTeam>(this._entity, out userTeam) ? new ProjectM.UserTeam?() : new ProjectM.UserTeam?(userTeam);
      }
    }

    public ProjectM.ItemData? ItemData
    {
      get
      {
        ProjectM.ItemData itemData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ItemData>(this._entity, out itemData) ? new ProjectM.ItemData?() : new ProjectM.ItemData?(itemData);
      }
    }

    public ProjectM.Shared.Salvageable? Salvageable
    {
      get
      {
        ProjectM.Shared.Salvageable salvageable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Shared.Salvageable>(this._entity, out salvageable) ? new ProjectM.Shared.Salvageable?() : new ProjectM.Shared.Salvageable?(salvageable);
      }
    }

    public ProjectM.CastAbilityOnConsume? CastAbilityOnConsume
    {
      get
      {
        ProjectM.CastAbilityOnConsume abilityOnConsume;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastAbilityOnConsume>(this._entity, out abilityOnConsume) ? new ProjectM.CastAbilityOnConsume?() : new ProjectM.CastAbilityOnConsume?(abilityOnConsume);
      }
    }

    public List<RecipeRequirementBuffer> RecipeRequirementBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<RecipeRequirementBuffer>(this._entity);
    }

    public List<ConsumableCondition> ConsumableConditions
    {
      get => this._world.EntityManager.GetBufferInternal<ConsumableCondition>(this._entity);
    }

    public List<RequiredProgressionToConsume> RequiredProgressionToConsumes
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<RequiredProgressionToConsume>(this._entity);
      }
    }

    public List<ProgressionBookRecipeElement> ProgressionBookRecipeElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProgressionBookRecipeElement>(this._entity);
      }
    }

    public List<ProgressionBookTechElement> ProgressionBookTechElements
    {
      get => this._world.EntityManager.GetBufferInternal<ProgressionBookTechElement>(this._entity);
    }

    public List<ProgressionBookBlueprintElement> ProgressionBookBlueprintElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProgressionBookBlueprintElement>(this._entity);
      }
    }

    public List<ProgressionBookShapeshiftElement> ProgressionBookShapeshiftElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProgressionBookShapeshiftElement>(this._entity);
      }
    }

    public bool InventoryItem
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.InventoryItem>(this._entity);
    }

    public ProjectM.NetworkedSpawnChainChild? NetworkedSpawnChainChild
    {
      get
      {
        ProjectM.NetworkedSpawnChainChild networkedSpawnChainChild;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.NetworkedSpawnChainChild>(this._entity, out networkedSpawnChainChild) ? new ProjectM.NetworkedSpawnChainChild?() : new ProjectM.NetworkedSpawnChainChild?(networkedSpawnChainChild);
      }
    }

    public ProjectM.SpellMovement? SpellMovement
    {
      get
      {
        ProjectM.SpellMovement spellMovement;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpellMovement>(this._entity, out spellMovement) ? new ProjectM.SpellMovement?() : new ProjectM.SpellMovement?(spellMovement);
      }
    }

    public ProjectM.ServerDebugViewData? ServerDebugViewData
    {
      get
      {
        ProjectM.ServerDebugViewData serverDebugViewData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServerDebugViewData>(this._entity, out serverDebugViewData) ? new ProjectM.ServerDebugViewData?() : new ProjectM.ServerDebugViewData?(serverDebugViewData);
      }
    }

    public ProjectM.ModifyMovementSpeedBuff? ModifyMovementSpeedBuff
    {
      get
      {
        ProjectM.ModifyMovementSpeedBuff movementSpeedBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyMovementSpeedBuff>(this._entity, out movementSpeedBuff) ? new ProjectM.ModifyMovementSpeedBuff?() : new ProjectM.ModifyMovementSpeedBuff?(movementSpeedBuff);
      }
    }

    public bool ProgressionGain
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.ProgressionGain>(this._entity);
    }

    public ProjectM.Dash? Dash
    {
      get
      {
        ProjectM.Dash dash;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Dash>(this._entity, out dash) ? new ProjectM.Dash?() : new ProjectM.Dash?(dash);
      }
    }

    public ProjectM.DashSpawn? DashSpawn
    {
      get
      {
        ProjectM.DashSpawn dashSpawn;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DashSpawn>(this._entity, out dashSpawn) ? new ProjectM.DashSpawn?() : new ProjectM.DashSpawn?(dashSpawn);
      }
    }

    public ProjectM.GetOwnerRotation? GetOwnerRotation
    {
      get
      {
        ProjectM.GetOwnerRotation getOwnerRotation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GetOwnerRotation>(this._entity, out getOwnerRotation) ? new ProjectM.GetOwnerRotation?() : new ProjectM.GetOwnerRotation?(getOwnerRotation);
      }
    }

    public ProjectM.GetOwnerTranslationOnSpawn? GetOwnerTranslationOnSpawn
    {
      get
      {
        ProjectM.GetOwnerTranslationOnSpawn translationOnSpawn;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GetOwnerTranslationOnSpawn>(this._entity, out translationOnSpawn) ? new ProjectM.GetOwnerTranslationOnSpawn?() : new ProjectM.GetOwnerTranslationOnSpawn?(translationOnSpawn);
      }
    }

    public bool GetOwnerRotationOnlyOnSpawnTag
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.GetOwnerRotationOnlyOnSpawnTag>(this._entity);
      }
    }

    public ProjectM.SyncedServerDebugSettings? SyncedServerDebugSettings
    {
      get
      {
        ProjectM.SyncedServerDebugSettings serverDebugSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SyncedServerDebugSettings>(this._entity, out serverDebugSettings) ? new ProjectM.SyncedServerDebugSettings?() : new ProjectM.SyncedServerDebugSettings?(serverDebugSettings);
      }
    }

    public ProjectM.MapIconData? MapIconData
    {
      get
      {
        ProjectM.MapIconData mapIconData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MapIconData>(this._entity, out mapIconData) ? new ProjectM.MapIconData?() : new ProjectM.MapIconData?(mapIconData);
      }
    }

    public ProjectM.MapIconTargetEntity? MapIconTargetEntity
    {
      get
      {
        ProjectM.MapIconTargetEntity iconTargetEntity;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MapIconTargetEntity>(this._entity, out iconTargetEntity) ? new ProjectM.MapIconTargetEntity?() : new ProjectM.MapIconTargetEntity?(iconTargetEntity);
      }
    }

    public ProjectM.MapIconPosition? MapIconPosition
    {
      get
      {
        ProjectM.MapIconPosition mapIconPosition;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MapIconPosition>(this._entity, out mapIconPosition) ? new ProjectM.MapIconPosition?() : new ProjectM.MapIconPosition?(mapIconPosition);
      }
    }

    public List<PlaySequenceOnGameplayEvent> PlaySequenceOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<PlaySequenceOnGameplayEvent>(this._entity);
    }

    public ProjectM.Equippable? Equippable
    {
      get
      {
        ProjectM.Equippable equippable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Equippable>(this._entity, out equippable) ? new ProjectM.Equippable?() : new ProjectM.Equippable?(equippable);
      }
    }

    public ProjectM.EquippableData? EquippableData
    {
      get
      {
        ProjectM.EquippableData equippableData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EquippableData>(this._entity, out equippableData) ? new ProjectM.EquippableData?() : new ProjectM.EquippableData?(equippableData);
      }
    }

    public ProjectM.HeadgearToggleData? HeadgearToggleData
    {
      get
      {
        ProjectM.HeadgearToggleData headgearToggleData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.HeadgearToggleData>(this._entity, out headgearToggleData) ? new ProjectM.HeadgearToggleData?() : new ProjectM.HeadgearToggleData?(headgearToggleData);
      }
    }

    public ProjectM.SunDamageDebuff? SunDamageDebuff
    {
      get
      {
        ProjectM.SunDamageDebuff sunDamageDebuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SunDamageDebuff>(this._entity, out sunDamageDebuff) ? new ProjectM.SunDamageDebuff?() : new ProjectM.SunDamageDebuff?(sunDamageDebuff);
      }
    }

    public ProjectM.DeathBuff? DeathBuff
    {
      get
      {
        ProjectM.DeathBuff deathBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DeathBuff>(this._entity, out deathBuff) ? new ProjectM.DeathBuff?() : new ProjectM.DeathBuff?(deathBuff);
      }
    }

    public ProjectM.WeaponLevelSource? WeaponLevelSource
    {
      get
      {
        ProjectM.WeaponLevelSource weaponLevelSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WeaponLevelSource>(this._entity, out weaponLevelSource) ? new ProjectM.WeaponLevelSource?() : new ProjectM.WeaponLevelSource?(weaponLevelSource);
      }
    }

    public ProjectM.Shared.Durability? Durability
    {
      get
      {
        ProjectM.Shared.Durability durability;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Shared.Durability>(this._entity, out durability) ? new ProjectM.Shared.Durability?() : new ProjectM.Shared.Durability?(durability);
      }
    }

    public List<ReplaceAbilityOnSlotWhenMountedBuffElement> ReplaceAbilityOnSlotWhenMountedBuffElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ReplaceAbilityOnSlotWhenMountedBuffElement>(this._entity);
      }
    }

    public List<ReplaceAbilityOnSlotWhenMountedBuffModificationElement> ReplaceAbilityOnSlotWhenMountedBuffModificationElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ReplaceAbilityOnSlotWhenMountedBuffModificationElement>(this._entity);
      }
    }

    public ProjectM.AbilityGroupSlot? AbilityGroupSlot
    {
      get
      {
        ProjectM.AbilityGroupSlot abilityGroupSlot;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityGroupSlot>(this._entity, out abilityGroupSlot) ? new ProjectM.AbilityGroupSlot?() : new ProjectM.AbilityGroupSlot?(abilityGroupSlot);
      }
    }

    public bool StaticPhysicsCollider
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Shared.StaticPhysicsCollider>(this._entity);
    }

    public ProjectM.SpawnPhysicsObjectOnDeath? SpawnPhysicsObjectOnDeath
    {
      get
      {
        ProjectM.SpawnPhysicsObjectOnDeath physicsObjectOnDeath;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnPhysicsObjectOnDeath>(this._entity, out physicsObjectOnDeath) ? new ProjectM.SpawnPhysicsObjectOnDeath?() : new ProjectM.SpawnPhysicsObjectOnDeath?(physicsObjectOnDeath);
      }
    }

    public ProjectM.RepairstationData? RepairstationData
    {
      get
      {
        ProjectM.RepairstationData repairstationData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RepairstationData>(this._entity, out repairstationData) ? new ProjectM.RepairstationData?() : new ProjectM.RepairstationData?(repairstationData);
      }
    }

    public ProjectM.Repairstation? Repairstation
    {
      get
      {
        ProjectM.Repairstation repairstation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Repairstation>(this._entity, out repairstation) ? new ProjectM.Repairstation?() : new ProjectM.Repairstation?(repairstation);
      }
    }

    public List<RepairRequirementBuffer> RepairRequirementBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<RepairRequirementBuffer>(this._entity);
    }

    public ProjectM.UnitSpawnerstation? UnitSpawnerstation
    {
      get
      {
        ProjectM.UnitSpawnerstation unitSpawnerstation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UnitSpawnerstation>(this._entity, out unitSpawnerstation) ? new ProjectM.UnitSpawnerstation?() : new ProjectM.UnitSpawnerstation?(unitSpawnerstation);
      }
    }

    public List<SpawnedUnitsBuffer> SpawnedUnitsBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<SpawnedUnitsBuffer>(this._entity);
    }

    public List<UnitSpawnPointBuffer> UnitSpawnPointBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<UnitSpawnPointBuffer>(this._entity);
    }

    public bool RelicRadar
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.RelicRadar>(this._entity);
    }

    public ProjectM.ResearchStation? ResearchStation
    {
      get
      {
        ProjectM.ResearchStation researchStation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ResearchStation>(this._entity, out researchStation) ? new ProjectM.ResearchStation?() : new ProjectM.ResearchStation?(researchStation);
      }
    }

    public List<DiscoverCostBuffer> DiscoverCostBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<DiscoverCostBuffer>(this._entity);
    }

    public List<ResearchBuffer> ResearchBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<ResearchBuffer>(this._entity);
    }

    public ProjectM.ServantCoffinstation? ServantCoffinstation
    {
      get
      {
        ProjectM.ServantCoffinstation servantCoffinstation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantCoffinstation>(this._entity, out servantCoffinstation) ? new ProjectM.ServantCoffinstation?() : new ProjectM.ServantCoffinstation?(servantCoffinstation);
      }
    }

    public ProjectM.ServantCoffinEffects? ServantCoffinEffects
    {
      get
      {
        ProjectM.ServantCoffinEffects servantCoffinEffects;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantCoffinEffects>(this._entity, out servantCoffinEffects) ? new ProjectM.ServantCoffinEffects?() : new ProjectM.ServantCoffinEffects?(servantCoffinEffects);
      }
    }

    public ProjectM.Bonfire? Bonfire
    {
      get
      {
        ProjectM.Bonfire bonfire;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Bonfire>(this._entity, out bonfire) ? new ProjectM.Bonfire?() : new ProjectM.Bonfire?(bonfire);
      }
    }

    public ProjectM.BurnContainer? BurnContainer
    {
      get
      {
        ProjectM.BurnContainer burnContainer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BurnContainer>(this._entity, out burnContainer) ? new ProjectM.BurnContainer?() : new ProjectM.BurnContainer?(burnContainer);
      }
    }

    public ProjectM.Salvagestation? Salvagestation
    {
      get
      {
        ProjectM.Salvagestation salvagestation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Salvagestation>(this._entity, out salvagestation) ? new ProjectM.Salvagestation?() : new ProjectM.Salvagestation?(salvagestation);
      }
    }

    public List<CastOptionBuffer> CastOptionBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<CastOptionBuffer>(this._entity);
    }

    public List<ProjectM.UnitLevelDamageSettings> UnitLevelDamageSettings
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.UnitLevelDamageSettings>(this._entity);
    }

    public List<CastOptionGroupBuffer> CastOptionGroupBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<CastOptionGroupBuffer>(this._entity);
    }

    public List<SpawnPrefabOnGameplayEvent> SpawnPrefabOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<SpawnPrefabOnGameplayEvent>(this._entity);
    }

    public ProjectM.SpellTarget? SpellTarget
    {
      get
      {
        ProjectM.SpellTarget spellTarget;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpellTarget>(this._entity, out spellTarget) ? new ProjectM.SpellTarget?() : new ProjectM.SpellTarget?(spellTarget);
      }
    }

    public bool DestroyOnSpawn
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DestroyOnSpawn>(this._entity);
    }

    public bool BindCoffin
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.BindCoffin>(this._entity);
    }

    public List<RemoveBuffOnGameplayEvent> RemoveBuffOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<RemoveBuffOnGameplayEvent>(this._entity);
    }

    public List<RemoveBuffOnGameplayEventEntry> RemoveBuffOnGameplayEventEntries
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<RemoveBuffOnGameplayEventEntry>(this._entity);
      }
    }

    public List<DealDamageOnGameplayEvent> DealDamageOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<DealDamageOnGameplayEvent>(this._entity);
    }

    public ProjectM.Knockback? Knockback
    {
      get
      {
        ProjectM.Knockback knockback;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Knockback>(this._entity, out knockback) ? new ProjectM.Knockback?() : new ProjectM.Knockback?(knockback);
      }
    }

    public ProjectM.ChangeKnockbackResistanceBuff? ChangeKnockbackResistanceBuff
    {
      get
      {
        ProjectM.ChangeKnockbackResistanceBuff knockbackResistanceBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ChangeKnockbackResistanceBuff>(this._entity, out knockbackResistanceBuff) ? new ProjectM.ChangeKnockbackResistanceBuff?() : new ProjectM.ChangeKnockbackResistanceBuff?(knockbackResistanceBuff);
      }
    }

    public bool BlockEquipmentSwapping
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.BlockEquipmentSwapping>(this._entity);
    }

    public bool AbilityTargetSource
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.AbilityTargetSource>(this._entity);
    }

    public List<CreateGameplayEventsOnHit> CreateGameplayEventsOnHits
    {
      get => this._world.EntityManager.GetBufferInternal<CreateGameplayEventsOnHit>(this._entity);
    }

    public List<ChangeBloodOnGameplayEvent> ChangeBloodOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<ChangeBloodOnGameplayEvent>(this._entity);
    }

    public List<TransformBuffTargetOnGameplayEvent> TransformBuffTargetOnGameplayEvents
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<TransformBuffTargetOnGameplayEvent>(this._entity);
      }
    }

    public bool ServerControlsPositionBuff
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.ServerControlsPositionBuff>(this._entity);
      }
    }

    public bool Buff_Destroy_On_Owner_Death
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.Buff_Destroy_On_Owner_Death>(this._entity);
      }
    }

    public bool DecayOnServerTick
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DecayOnServerTick>(this._entity);
    }

    public List<HitTrigger> HitTriggers
    {
      get => this._world.EntityManager.GetBufferInternal<HitTrigger>(this._entity);
    }

    public List<HitColliderCast> HitColliderCasts
    {
      get => this._world.EntityManager.GetBufferInternal<HitColliderCast>(this._entity);
    }

    public List<SpawnMinionOnGameplayEvent> SpawnMinionOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<SpawnMinionOnGameplayEvent>(this._entity);
    }

    public ProjectM.SetOwnerRotateTowardsMovement? SetOwnerRotateTowardsMovement
    {
      get
      {
        ProjectM.SetOwnerRotateTowardsMovement rotateTowardsMovement;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SetOwnerRotateTowardsMovement>(this._entity, out rotateTowardsMovement) ? new ProjectM.SetOwnerRotateTowardsMovement?() : new ProjectM.SetOwnerRotateTowardsMovement?(rotateTowardsMovement);
      }
    }

    public bool MountInitBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.MountInitBuff>(this._entity);
    }

    public bool RegenOnServerTick
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.RegenOnServerTick>(this._entity);
    }

    public ModifyRotation ModifyRotation
    {
      get
      {
        ModifyRotation modifyRotation;
        return !this._world.EntityManager.TryGetComponentDataInternal<ModifyRotation>(this._entity, out modifyRotation) ? new ModifyRotation() : modifyRotation;
      }
    }

    public List<PlayBlinkSequenceOnGameplayEvent> PlayBlinkSequenceOnGameplayEvents
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<PlayBlinkSequenceOnGameplayEvent>(this._entity);
      }
    }

    public List<PlayImpactOnGameplayEvent> PlayImpactOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<PlayImpactOnGameplayEvent>(this._entity);
    }

    public bool HasResidentBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.HasResidentBuff>(this._entity);
    }

    public bool InsideInitBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.InsideInitBuff>(this._entity);
    }

    public ProjectM.TargetAoE? TargetAoE
    {
      get
      {
        ProjectM.TargetAoE targetAoE;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TargetAoE>(this._entity, out targetAoE) ? new ProjectM.TargetAoE?() : new ProjectM.TargetAoE?(targetAoE);
      }
    }

    public ProjectM.RagdollForceSource? RagdollForceSource
    {
      get
      {
        ProjectM.RagdollForceSource ragdollForceSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RagdollForceSource>(this._entity, out ragdollForceSource) ? new ProjectM.RagdollForceSource?() : new ProjectM.RagdollForceSource?(ragdollForceSource);
      }
    }

    public bool YieldResourceDisable
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.YieldResourceDisable>(this._entity);
    }

    public ProjectM.UsePortal? UsePortal
    {
      get
      {
        ProjectM.UsePortal usePortal;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UsePortal>(this._entity, out usePortal) ? new ProjectM.UsePortal?() : new ProjectM.UsePortal?(usePortal);
      }
    }

    public ProjectM.Velocity? Velocity
    {
      get
      {
        ProjectM.Velocity velocity;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Velocity>(this._entity, out velocity) ? new ProjectM.Velocity?() : new ProjectM.Velocity?(velocity);
      }
    }

    public ProjectM.TargetDirection? TargetDirection
    {
      get
      {
        ProjectM.TargetDirection targetDirection;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TargetDirection>(this._entity, out targetDirection) ? new ProjectM.TargetDirection?() : new ProjectM.TargetDirection?(targetDirection);
      }
    }

    public ProjectM.EntityAimData? EntityAimData
    {
      get
      {
        ProjectM.EntityAimData entityAimData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EntityAimData>(this._entity, out entityAimData) ? new ProjectM.EntityAimData?() : new ProjectM.EntityAimData?(entityAimData);
      }
    }

    public ProjectM.MoveVelocity? MoveVelocity
    {
      get
      {
        ProjectM.MoveVelocity moveVelocity;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MoveVelocity>(this._entity, out moveVelocity) ? new ProjectM.MoveVelocity?() : new ProjectM.MoveVelocity?(moveVelocity);
      }
    }

    public List<ProjectM.Float3ModificationBuffer> Float3ModificationBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Float3ModificationBuffer>(this._entity);
    }

    public ProjectM.InteractPickup? InteractPickup
    {
      get
      {
        ProjectM.InteractPickup interactPickup;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.InteractPickup>(this._entity, out interactPickup) ? new ProjectM.InteractPickup?() : new ProjectM.InteractPickup?(interactPickup);
      }
    }

    public bool OpenDoor => this._world.EntityManager.HasComponentInternal<ProjectM.OpenDoor>(this._entity);

    public List<CastOptionStateBuffer> CastOptionStateBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<CastOptionStateBuffer>(this._entity);
    }

    public ProjectM.ModifyAggroRangesBuff? ModifyAggroRangesBuff
    {
      get
      {
        ProjectM.ModifyAggroRangesBuff modifyAggroRangesBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyAggroRangesBuff>(this._entity, out modifyAggroRangesBuff) ? new ProjectM.ModifyAggroRangesBuff?() : new ProjectM.ModifyAggroRangesBuff?(modifyAggroRangesBuff);
      }
    }

    public ProjectM.AbilityTarget? AbilityTarget
    {
      get
      {
        ProjectM.AbilityTarget abilityTarget;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityTarget>(this._entity, out abilityTarget) ? new ProjectM.AbilityTarget?() : new ProjectM.AbilityTarget?(abilityTarget);
      }
    }

    public List<CreateGameplayEventOnDamageTaken> CreateGameplayEventOnDamageTakens
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CreateGameplayEventOnDamageTaken>(this._entity);
      }
    }

    public ProjectM.Hybrid.DeathRagdollForce? DeathRagdollForce
    {
      get
      {
        ProjectM.Hybrid.DeathRagdollForce deathRagdollForce;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Hybrid.DeathRagdollForce>(this._entity, out deathRagdollForce) ? new ProjectM.Hybrid.DeathRagdollForce?() : new ProjectM.Hybrid.DeathRagdollForce?(deathRagdollForce);
      }
    }

    public ProjectM.HideWeapon? HideWeapon
    {
      get
      {
        ProjectM.HideWeapon hideWeapon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.HideWeapon>(this._entity, out hideWeapon) ? new ProjectM.HideWeapon?() : new ProjectM.HideWeapon?(hideWeapon);
      }
    }

    public bool GrabBuff => this._world.EntityManager.HasComponentInternal<ProjectM.GrabBuff>(this._entity);

    public ProjectM.CastleResistanceBuff? CastleResistanceBuff
    {
      get
      {
        ProjectM.CastleResistanceBuff castleResistanceBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleResistanceBuff>(this._entity, out castleResistanceBuff) ? new ProjectM.CastleResistanceBuff?() : new ProjectM.CastleResistanceBuff?(castleResistanceBuff);
      }
    }

    public ProjectM.AdjustFlyHeightBuff? AdjustFlyHeightBuff
    {
      get
      {
        ProjectM.AdjustFlyHeightBuff adjustFlyHeightBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AdjustFlyHeightBuff>(this._entity, out adjustFlyHeightBuff) ? new ProjectM.AdjustFlyHeightBuff?() : new ProjectM.AdjustFlyHeightBuff?(adjustFlyHeightBuff);
      }
    }

    public bool GetOwnerFactionOnSpawn
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.GetOwnerFactionOnSpawn>(this._entity);
    }

    public ProjectM.WeaponLevel? WeaponLevel
    {
      get
      {
        ProjectM.WeaponLevel weaponLevel;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WeaponLevel>(this._entity, out weaponLevel) ? new ProjectM.WeaponLevel?() : new ProjectM.WeaponLevel?(weaponLevel);
      }
    }

    public ProjectM.Behaviours.BehaviourTreeBlackboardSize? BehaviourTreeBlackboardSize
    {
      get
      {
        ProjectM.Behaviours.BehaviourTreeBlackboardSize treeBlackboardSize;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Behaviours.BehaviourTreeBlackboardSize>(this._entity, out treeBlackboardSize) ? new ProjectM.Behaviours.BehaviourTreeBlackboardSize?() : new ProjectM.Behaviours.BehaviourTreeBlackboardSize?(treeBlackboardSize);
      }
    }

    public BehaviourTree BehaviourTree
    {
      get
      {
        BehaviourTree behaviourTree;
        return !this._world.EntityManager.TryGetComponentDataInternal<BehaviourTree>(this._entity, out behaviourTree) ? new BehaviourTree() : behaviourTree;
      }
    }

    public List<BehaviourTreeBlackboardEntityFieldElement> BehaviourTreeBlackboardEntityFieldElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<BehaviourTreeBlackboardEntityFieldElement>(this._entity);
      }
    }

    public List<BehaviourTreeBlackboardDebugElement> BehaviourTreeBlackboardDebugElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<BehaviourTreeBlackboardDebugElement>(this._entity);
      }
    }

    public List<ApplyKnockbackOnGameplayEvent> ApplyKnockbackOnGameplayEvents
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ApplyKnockbackOnGameplayEvent>(this._entity);
      }
    }

    public List<TriggerCounterOnGameplayEvent> TriggerCounterOnGameplayEvents
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<TriggerCounterOnGameplayEvent>(this._entity);
      }
    }

    public bool YieldResourceSource
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.YieldResourceSource>(this._entity);
    }

    public List<TargetAOESequence> TargetAOESequences
    {
      get => this._world.EntityManager.GetBufferInternal<TargetAOESequence>(this._entity);
    }

    public ProjectM.AbilityState? AbilityState
    {
      get
      {
        ProjectM.AbilityState abilityState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityState>(this._entity, out abilityState) ? new ProjectM.AbilityState?() : new ProjectM.AbilityState?(abilityState);
      }
    }

    public ModifyRotationDuringCast ModifyRotationDuringCast
    {
      get
      {
        ModifyRotationDuringCast rotationDuringCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ModifyRotationDuringCast>(this._entity, out rotationDuringCast) ? new ModifyRotationDuringCast() : rotationDuringCast;
      }
    }

    public ProjectM.AbilityInterruptData? AbilityInterruptData
    {
      get
      {
        ProjectM.AbilityInterruptData abilityInterruptData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityInterruptData>(this._entity, out abilityInterruptData) ? new ProjectM.AbilityInterruptData?() : new ProjectM.AbilityInterruptData?(abilityInterruptData);
      }
    }

    public ProjectM.AbilityCooldownState? AbilityCooldownState
    {
      get
      {
        ProjectM.AbilityCooldownState abilityCooldownState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityCooldownState>(this._entity, out abilityCooldownState) ? new ProjectM.AbilityCooldownState?() : new ProjectM.AbilityCooldownState?(abilityCooldownState);
      }
    }

    public ProjectM.AbilityCooldownData? AbilityCooldownData
    {
      get
      {
        ProjectM.AbilityCooldownData abilityCooldownData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityCooldownData>(this._entity, out abilityCooldownData) ? new ProjectM.AbilityCooldownData?() : new ProjectM.AbilityCooldownData?(abilityCooldownData);
      }
    }

    public ProjectM.GlobalCooldown? GlobalCooldown
    {
      get
      {
        ProjectM.GlobalCooldown globalCooldown;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GlobalCooldown>(this._entity, out globalCooldown) ? new ProjectM.GlobalCooldown?() : new ProjectM.GlobalCooldown?(globalCooldown);
      }
    }

    public ProjectM.AbilityIgnoreSettings? AbilityIgnoreSettings
    {
      get
      {
        ProjectM.AbilityIgnoreSettings abilityIgnoreSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityIgnoreSettings>(this._entity, out abilityIgnoreSettings) ? new ProjectM.AbilityIgnoreSettings?() : new ProjectM.AbilityIgnoreSettings?(abilityIgnoreSettings);
      }
    }

    public ProjectM.AbilityPriority? AbilityPriority
    {
      get
      {
        ProjectM.AbilityPriority abilityPriority;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityPriority>(this._entity, out abilityPriority) ? new ProjectM.AbilityPriority?() : new ProjectM.AbilityPriority?(abilityPriority);
      }
    }

    public ProjectM.AbilityCastTimeData? AbilityCastTimeData
    {
      get
      {
        ProjectM.AbilityCastTimeData abilityCastTimeData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityCastTimeData>(this._entity, out abilityCastTimeData) ? new ProjectM.AbilityCastTimeData?() : new ProjectM.AbilityCastTimeData?(abilityCastTimeData);
      }
    }

    public List<AbilitySpawnPrefabOnCast> AbilitySpawnPrefabOnCasts
    {
      get => this._world.EntityManager.GetBufferInternal<AbilitySpawnPrefabOnCast>(this._entity);
    }

    public List<AbilityCastCondition> AbilityCastConditions
    {
      get => this._world.EntityManager.GetBufferInternal<AbilityCastCondition>(this._entity);
    }

    public ProjectM.WeakenBuff? WeakenBuff
    {
      get
      {
        ProjectM.WeakenBuff weakenBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WeakenBuff>(this._entity, out weakenBuff) ? new ProjectM.WeakenBuff?() : new ProjectM.WeakenBuff?(weakenBuff);
      }
    }

    public ProjectM.AbilityDirectionInaccuracy? AbilityDirectionInaccuracy
    {
      get
      {
        ProjectM.AbilityDirectionInaccuracy directionInaccuracy;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityDirectionInaccuracy>(this._entity, out directionInaccuracy) ? new ProjectM.AbilityDirectionInaccuracy?() : new ProjectM.AbilityDirectionInaccuracy?(directionInaccuracy);
      }
    }

    public ProjectM.ChangeKnockbackResistanceDuringCast? ChangeKnockbackResistanceDuringCast
    {
      get
      {
        ProjectM.ChangeKnockbackResistanceDuringCast resistanceDuringCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ChangeKnockbackResistanceDuringCast>(this._entity, out resistanceDuringCast) ? new ProjectM.ChangeKnockbackResistanceDuringCast?() : new ProjectM.ChangeKnockbackResistanceDuringCast?(resistanceDuringCast);
      }
    }

    public ProjectM.ModifyMovementDuringCastData? ModifyMovementDuringCastData
    {
      get
      {
        ProjectM.ModifyMovementDuringCastData movementDuringCastData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyMovementDuringCastData>(this._entity, out movementDuringCastData) ? new ProjectM.ModifyMovementDuringCastData?() : new ProjectM.ModifyMovementDuringCastData?(movementDuringCastData);
      }
    }

    public ProjectM.MoveDuringCastData? MoveDuringCastData
    {
      get
      {
        ProjectM.MoveDuringCastData moveDuringCastData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MoveDuringCastData>(this._entity, out moveDuringCastData) ? new ProjectM.MoveDuringCastData?() : new ProjectM.MoveDuringCastData?(moveDuringCastData);
      }
    }

    public ProjectM.AdditionalInteractBuff? AdditionalInteractBuff
    {
      get
      {
        ProjectM.AdditionalInteractBuff additionalInteractBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AdditionalInteractBuff>(this._entity, out additionalInteractBuff) ? new ProjectM.AdditionalInteractBuff?() : new ProjectM.AdditionalInteractBuff?(additionalInteractBuff);
      }
    }

    public List<CreateGameplayEventsOnAbilityTrigger> CreateGameplayEventsOnAbilityTriggers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CreateGameplayEventsOnAbilityTrigger>(this._entity);
      }
    }

    public List<ProjectM.CreateGameplayEventsOnAbilityTriggerAbilityPrefabTargets> CreateGameplayEventsOnAbilityTriggerAbilityPrefabTargets
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.CreateGameplayEventsOnAbilityTriggerAbilityPrefabTargets>(this._entity);
      }
    }

    public ProjectM.Behaviours.AbilityRange? AbilityRange
    {
      get
      {
        ProjectM.Behaviours.AbilityRange abilityRange;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Behaviours.AbilityRange>(this._entity, out abilityRange) ? new ProjectM.Behaviours.AbilityRange?() : new ProjectM.Behaviours.AbilityRange?(abilityRange);
      }
    }

    public ProjectM.HideWeaponDuringCast? HideWeaponDuringCast
    {
      get
      {
        ProjectM.HideWeaponDuringCast weaponDuringCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.HideWeaponDuringCast>(this._entity, out weaponDuringCast) ? new ProjectM.HideWeaponDuringCast?() : new ProjectM.HideWeaponDuringCast?(weaponDuringCast);
      }
    }

    public bool AbilityHoldToCastData
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.AbilityHoldToCastData>(this._entity);
    }

    public bool BlockFeedBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.BlockFeedBuff>(this._entity);
    }

    public bool IgnoreInCombatBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.IgnoreInCombatBuff>(this._entity);
    }

    public ProjectM.AbsorbBuff? AbsorbBuff
    {
      get
      {
        ProjectM.AbsorbBuff absorbBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbsorbBuff>(this._entity, out absorbBuff) ? new ProjectM.AbsorbBuff?() : new ProjectM.AbsorbBuff?(absorbBuff);
      }
    }

    public bool MultiplyAbsorbCapBySpellPower
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.MultiplyAbsorbCapBySpellPower>(this._entity);
      }
    }

    public ProjectM.AllowJumpFromCliffsBuff? AllowJumpFromCliffsBuff
    {
      get
      {
        ProjectM.AllowJumpFromCliffsBuff jumpFromCliffsBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AllowJumpFromCliffsBuff>(this._entity, out jumpFromCliffsBuff) ? new ProjectM.AllowJumpFromCliffsBuff?() : new ProjectM.AllowJumpFromCliffsBuff?(jumpFromCliffsBuff);
      }
    }

    public ProjectM.EnergyRequirement? EnergyRequirement
    {
      get
      {
        ProjectM.EnergyRequirement energyRequirement;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EnergyRequirement>(this._entity, out energyRequirement) ? new ProjectM.EnergyRequirement?() : new ProjectM.EnergyRequirement?(energyRequirement);
      }
    }

    public ProjectM.TravelBuff? TravelBuff
    {
      get
      {
        ProjectM.TravelBuff travelBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TravelBuff>(this._entity, out travelBuff) ? new ProjectM.TravelBuff?() : new ProjectM.TravelBuff?(travelBuff);
      }
    }

    public ProjectM.TravelBuffSpawn? TravelBuffSpawn
    {
      get
      {
        ProjectM.TravelBuffSpawn travelBuffSpawn;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TravelBuffSpawn>(this._entity, out travelBuffSpawn) ? new ProjectM.TravelBuffSpawn?() : new ProjectM.TravelBuffSpawn?(travelBuffSpawn);
      }
    }

    public ProjectM.DeathPvPTimer? DeathPvPTimer
    {
      get
      {
        ProjectM.DeathPvPTimer deathPvPtimer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DeathPvPTimer>(this._entity, out deathPvPtimer) ? new ProjectM.DeathPvPTimer?() : new ProjectM.DeathPvPTimer?(deathPvPtimer);
      }
    }

    public ProjectM.Projectile? Projectile
    {
      get
      {
        ProjectM.Projectile projectile;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Projectile>(this._entity, out projectile) ? new ProjectM.Projectile?() : new ProjectM.Projectile?(projectile);
      }
    }

    public ProjectM.ProjectileDestroyData? ProjectileDestroyData
    {
      get
      {
        ProjectM.ProjectileDestroyData projectileDestroyData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ProjectileDestroyData>(this._entity, out projectileDestroyData) ? new ProjectM.ProjectileDestroyData?() : new ProjectM.ProjectileDestroyData?(projectileDestroyData);
      }
    }

    public ProjectM.OffsetTranslationOnSpawn? OffsetTranslationOnSpawn
    {
      get
      {
        ProjectM.OffsetTranslationOnSpawn translationOnSpawn;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.OffsetTranslationOnSpawn>(this._entity, out translationOnSpawn) ? new ProjectM.OffsetTranslationOnSpawn?() : new ProjectM.OffsetTranslationOnSpawn?(translationOnSpawn);
      }
    }

    public ProjectileSnapToHeight ProjectileSnapToHeight
    {
      get
      {
        ProjectileSnapToHeight projectileSnapToHeight;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectileSnapToHeight>(this._entity, out projectileSnapToHeight) ? new ProjectileSnapToHeight() : projectileSnapToHeight;
      }
    }

    public ProjectM.SpawnRandomLifeTime? SpawnRandomLifeTime
    {
      get
      {
        ProjectM.SpawnRandomLifeTime spawnRandomLifeTime;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnRandomLifeTime>(this._entity, out spawnRandomLifeTime) ? new ProjectM.SpawnRandomLifeTime?() : new ProjectM.SpawnRandomLifeTime?(spawnRandomLifeTime);
      }
    }

    public ProjectM.LimitAbilityPriorityBuff? LimitAbilityPriorityBuff
    {
      get
      {
        ProjectM.LimitAbilityPriorityBuff abilityPriorityBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.LimitAbilityPriorityBuff>(this._entity, out abilityPriorityBuff) ? new ProjectM.LimitAbilityPriorityBuff?() : new ProjectM.LimitAbilityPriorityBuff?(abilityPriorityBuff);
      }
    }

    public List<CreateGameplayEventsOnAbilityImpaired> CreateGameplayEventsOnAbilityImpaireds
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CreateGameplayEventsOnAbilityImpaired>(this._entity);
      }
    }

    public List<ChangeEnergyOnGameplayEvent> ChangeEnergyOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<ChangeEnergyOnGameplayEvent>(this._entity);
    }

    public ProjectM.DestroyBuffOnDamageTaken? DestroyBuffOnDamageTaken
    {
      get
      {
        ProjectM.DestroyBuffOnDamageTaken buffOnDamageTaken;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DestroyBuffOnDamageTaken>(this._entity, out buffOnDamageTaken) ? new ProjectM.DestroyBuffOnDamageTaken?() : new ProjectM.DestroyBuffOnDamageTaken?(buffOnDamageTaken);
      }
    }

    public ProjectM.AbilityOwner? AbilityOwner
    {
      get
      {
        ProjectM.AbilityOwner abilityOwner;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityOwner>(this._entity, out abilityOwner) ? new ProjectM.AbilityOwner?() : new ProjectM.AbilityOwner?(abilityOwner);
      }
    }

    public ProjectM.AbilityPositionInaccuracy? AbilityPositionInaccuracy
    {
      get
      {
        ProjectM.AbilityPositionInaccuracy positionInaccuracy;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityPositionInaccuracy>(this._entity, out positionInaccuracy) ? new ProjectM.AbilityPositionInaccuracy?() : new ProjectM.AbilityPositionInaccuracy?(positionInaccuracy);
      }
    }

    public TravelToTarget TravelToTarget
    {
      get
      {
        TravelToTarget travelToTarget;
        return !this._world.EntityManager.TryGetComponentDataInternal<TravelToTarget>(this._entity, out travelToTarget) ? new TravelToTarget() : travelToTarget;
      }
    }

    public List<ChangeAbilityOnGameplayEvent> ChangeAbilityOnGameplayEvents
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ChangeAbilityOnGameplayEvent>(this._entity);
      }
    }

    public List<ForceCastOnGameplayEvent> ForceCastOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<ForceCastOnGameplayEvent>(this._entity);
    }

    public ProjectM.AbilityAimPrediction? AbilityAimPrediction
    {
      get
      {
        ProjectM.AbilityAimPrediction abilityAimPrediction;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityAimPrediction>(this._entity, out abilityAimPrediction) ? new ProjectM.AbilityAimPrediction?() : new ProjectM.AbilityAimPrediction?(abilityAimPrediction);
      }
    }

    public ProjectM.MoveStopAbilityData? MoveStopAbilityData
    {
      get
      {
        ProjectM.MoveStopAbilityData moveStopAbilityData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MoveStopAbilityData>(this._entity, out moveStopAbilityData) ? new ProjectM.MoveStopAbilityData?() : new ProjectM.MoveStopAbilityData?(moveStopAbilityData);
      }
    }

    public ProjectM.SpawnSleepingBuff? SpawnSleepingBuff
    {
      get
      {
        ProjectM.SpawnSleepingBuff spawnSleepingBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnSleepingBuff>(this._entity, out spawnSleepingBuff) ? new ProjectM.SpawnSleepingBuff?() : new ProjectM.SpawnSleepingBuff?(spawnSleepingBuff);
      }
    }

    public bool HolyAreaDebuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.HolyAreaDebuff>(this._entity);
    }

    public ProjectM.UI.GoToHUDMenu? GoToHUDMenu
    {
      get
      {
        ProjectM.UI.GoToHUDMenu goToHudMenu;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UI.GoToHUDMenu>(this._entity, out goToHudMenu) ? new ProjectM.UI.GoToHUDMenu?() : new ProjectM.UI.GoToHUDMenu?(goToHudMenu);
      }
    }

    public List<CreateGameplayEventOnItemEquipped> CreateGameplayEventOnItemEquippeds
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CreateGameplayEventOnItemEquipped>(this._entity);
      }
    }

    public bool MoveTowardsRotationBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.MoveTowardsRotationBuff>(this._entity);
    }

    public bool DestroyOnManualInterrupt
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DestroyOnManualInterrupt>(this._entity);
    }

    public ProjectM.AmplifyBuff? AmplifyBuff
    {
      get
      {
        ProjectM.AmplifyBuff amplifyBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AmplifyBuff>(this._entity, out amplifyBuff) ? new ProjectM.AmplifyBuff?() : new ProjectM.AmplifyBuff?(amplifyBuff);
      }
    }

    public ProjectM.ShapeshiftImpairBuff? ShapeshiftImpairBuff
    {
      get
      {
        ProjectM.ShapeshiftImpairBuff shapeshiftImpairBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ShapeshiftImpairBuff>(this._entity, out shapeshiftImpairBuff) ? new ProjectM.ShapeshiftImpairBuff?() : new ProjectM.ShapeshiftImpairBuff?(shapeshiftImpairBuff);
      }
    }

    public ProjectM.DestroyBuffOnMove? DestroyBuffOnMove
    {
      get
      {
        ProjectM.DestroyBuffOnMove destroyBuffOnMove;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DestroyBuffOnMove>(this._entity, out destroyBuffOnMove) ? new ProjectM.DestroyBuffOnMove?() : new ProjectM.DestroyBuffOnMove?(destroyBuffOnMove);
      }
    }

    public List<CreateGameplayEventOnLeaveCliff> CreateGameplayEventOnLeaveCliffs
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CreateGameplayEventOnLeaveCliff>(this._entity);
      }
    }

    public List<AbilitySpawnPrefabOnStartCast> AbilitySpawnPrefabOnStartCasts
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<AbilitySpawnPrefabOnStartCast>(this._entity);
      }
    }

    public ProjectM.DestroyOnAbilityCast? DestroyOnAbilityCast
    {
      get
      {
        ProjectM.DestroyOnAbilityCast destroyOnAbilityCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DestroyOnAbilityCast>(this._entity, out destroyOnAbilityCast) ? new ProjectM.DestroyOnAbilityCast?() : new ProjectM.DestroyOnAbilityCast?(destroyOnAbilityCast);
      }
    }

    public ProjectM.RadialDamageDebuff? RadialDamageDebuff
    {
      get
      {
        ProjectM.RadialDamageDebuff radialDamageDebuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RadialDamageDebuff>(this._entity, out radialDamageDebuff) ? new ProjectM.RadialDamageDebuff?() : new ProjectM.RadialDamageDebuff?(radialDamageDebuff);
      }
    }

    public ProjectM.TeleportBuff? TeleportBuff
    {
      get
      {
        ProjectM.TeleportBuff teleportBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TeleportBuff>(this._entity, out teleportBuff) ? new ProjectM.TeleportBuff?() : new ProjectM.TeleportBuff?(teleportBuff);
      }
    }

    public ProjectM.FadeToBlack? FadeToBlack
    {
      get
      {
        ProjectM.FadeToBlack fadeToBlack;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.FadeToBlack>(this._entity, out fadeToBlack) ? new ProjectM.FadeToBlack?() : new ProjectM.FadeToBlack?(fadeToBlack);
      }
    }

    public ProjectM.FadeToBlack_Manual? FadeToBlack_Manual
    {
      get
      {
        ProjectM.FadeToBlack_Manual fadeToBlackManual;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.FadeToBlack_Manual>(this._entity, out fadeToBlackManual) ? new ProjectM.FadeToBlack_Manual?() : new ProjectM.FadeToBlack_Manual?(fadeToBlackManual);
      }
    }

    public List<LifeLeechOnGameplayEvent> LifeLeechOnGameplayEvents
    {
      get => this._world.EntityManager.GetBufferInternal<LifeLeechOnGameplayEvent>(this._entity);
    }

    public ProjectM.AllowJumpDuringCast? AllowJumpDuringCast
    {
      get
      {
        ProjectM.AllowJumpDuringCast allowJumpDuringCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AllowJumpDuringCast>(this._entity, out allowJumpDuringCast) ? new ProjectM.AllowJumpDuringCast?() : new ProjectM.AllowJumpDuringCast?(allowJumpDuringCast);
      }
    }

    public ProjectM.AbsorbStackModifier? AbsorbStackModifier
    {
      get
      {
        ProjectM.AbsorbStackModifier absorbStackModifier;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbsorbStackModifier>(this._entity, out absorbStackModifier) ? new ProjectM.AbsorbStackModifier?() : new ProjectM.AbsorbStackModifier?(absorbStackModifier);
      }
    }

    public ProjectM.AbsorbCapStackModifier? AbsorbCapStackModifier
    {
      get
      {
        ProjectM.AbsorbCapStackModifier capStackModifier;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbsorbCapStackModifier>(this._entity, out capStackModifier) ? new ProjectM.AbsorbCapStackModifier?() : new ProjectM.AbsorbCapStackModifier?(capStackModifier);
      }
    }

    public bool GiveAchievementOnHit
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.GiveAchievementOnHit>(this._entity);
    }

    public ProjectM.VBloodAbilityReplaceBuff? VBloodAbilityReplaceBuff
    {
      get
      {
        ProjectM.VBloodAbilityReplaceBuff abilityReplaceBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodAbilityReplaceBuff>(this._entity, out abilityReplaceBuff) ? new ProjectM.VBloodAbilityReplaceBuff?() : new ProjectM.VBloodAbilityReplaceBuff?(abilityReplaceBuff);
      }
    }

    public ProjectM.BlockHealBuff? BlockHealBuff
    {
      get
      {
        ProjectM.BlockHealBuff blockHealBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BlockHealBuff>(this._entity, out blockHealBuff) ? new ProjectM.BlockHealBuff?() : new ProjectM.BlockHealBuff?(blockHealBuff);
      }
    }

    public ProjectM.ModifyTeamBuff? ModifyTeamBuff
    {
      get
      {
        ProjectM.ModifyTeamBuff modifyTeamBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyTeamBuff>(this._entity, out modifyTeamBuff) ? new ProjectM.ModifyTeamBuff?() : new ProjectM.ModifyTeamBuff?(modifyTeamBuff);
      }
    }

    public bool FollowBuffOwner
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.FollowBuffOwner>(this._entity);
    }

    public bool PreventDisableBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.PreventDisableBuff>(this._entity);
    }

    public ProjectM.RespawnDelay? RespawnDelay
    {
      get
      {
        ProjectM.RespawnDelay respawnDelay;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RespawnDelay>(this._entity, out respawnDelay) ? new ProjectM.RespawnDelay?() : new ProjectM.RespawnDelay?(respawnDelay);
      }
    }

    public bool GallopBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.GallopBuff>(this._entity);
    }

    public List<GenerateAggroOnGameplayEvent> GenerateAggroOnGameplayEvents
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<GenerateAggroOnGameplayEvent>(this._entity);
      }
    }

    public List<DropFromTablesOnGameplayEvent> DropFromTablesOnGameplayEvents
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<DropFromTablesOnGameplayEvent>(this._entity);
      }
    }

    public ProjectM.EmpowerBuff? EmpowerBuff
    {
      get
      {
        ProjectM.EmpowerBuff empowerBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.EmpowerBuff>(this._entity, out empowerBuff) ? new ProjectM.EmpowerBuff?() : new ProjectM.EmpowerBuff?(empowerBuff);
      }
    }

    public bool FadeOutFlyMoodBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.FadeOutFlyMoodBuff>(this._entity);
    }

    public ProjectM.ImprisonedBuff? ImprisonedBuff
    {
      get
      {
        ProjectM.ImprisonedBuff imprisonedBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ImprisonedBuff>(this._entity, out imprisonedBuff) ? new ProjectM.ImprisonedBuff?() : new ProjectM.ImprisonedBuff?(imprisonedBuff);
      }
    }

    public bool ModifyObstacleFadeoutBuff
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.ModifyObstacleFadeoutBuff>(this._entity);
      }
    }

    public ProjectM.AbilityRemoveBuffCategoryOnStartCast? AbilityRemoveBuffCategoryOnStartCast
    {
      get
      {
        ProjectM.AbilityRemoveBuffCategoryOnStartCast categoryOnStartCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityRemoveBuffCategoryOnStartCast>(this._entity, out categoryOnStartCast) ? new ProjectM.AbilityRemoveBuffCategoryOnStartCast?() : new ProjectM.AbilityRemoveBuffCategoryOnStartCast?(categoryOnStartCast);
      }
    }

    public ProjectM.RotateTowardsAimDirectionDuringCastData? RotateTowardsAimDirectionDuringCastData
    {
      get
      {
        ProjectM.RotateTowardsAimDirectionDuringCastData directionDuringCastData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RotateTowardsAimDirectionDuringCastData>(this._entity, out directionDuringCastData) ? new ProjectM.RotateTowardsAimDirectionDuringCastData?() : new ProjectM.RotateTowardsAimDirectionDuringCastData?(directionDuringCastData);
      }
    }

    public ProjectM.Minion? Minion
    {
      get
      {
        ProjectM.Minion minion;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Minion>(this._entity, out minion) ? new ProjectM.Minion?() : new ProjectM.Minion?(minion);
      }
    }

    public ProjectM.SpawnTransform? SpawnTransform
    {
      get
      {
        ProjectM.SpawnTransform spawnTransform;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnTransform>(this._entity, out spawnTransform) ? new ProjectM.SpawnTransform?() : new ProjectM.SpawnTransform?(spawnTransform);
      }
    }

    public ProjectM.UnitRespawnTime? UnitRespawnTime
    {
      get
      {
        ProjectM.UnitRespawnTime unitRespawnTime;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UnitRespawnTime>(this._entity, out unitRespawnTime) ? new ProjectM.UnitRespawnTime?() : new ProjectM.UnitRespawnTime?(unitRespawnTime);
      }
    }

    public ProjectM.Network.NetworkedTimeout? NetworkedTimeout
    {
      get
      {
        ProjectM.Network.NetworkedTimeout networkedTimeout;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.NetworkedTimeout>(this._entity, out networkedTimeout) ? new ProjectM.Network.NetworkedTimeout?() : new ProjectM.Network.NetworkedTimeout?(networkedTimeout);
      }
    }

    public ProjectM.IsSpellControlled? IsSpellControlled
    {
      get
      {
        ProjectM.IsSpellControlled isSpellControlled;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.IsSpellControlled>(this._entity, out isSpellControlled) ? new ProjectM.IsSpellControlled?() : new ProjectM.IsSpellControlled?(isSpellControlled);
      }
    }

    public bool DropTableOnSalvageDestroy
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.DropTableOnSalvageDestroy>(this._entity);
      }
    }

    public ProjectM.AggroConsumer? AggroConsumer
    {
      get
      {
        ProjectM.AggroConsumer aggroConsumer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AggroConsumer>(this._entity, out aggroConsumer) ? new ProjectM.AggroConsumer?() : new ProjectM.AggroConsumer?(aggroConsumer);
      }
    }

    public ProjectM.AiMove_Server? AiMove_Server
    {
      get
      {
        ProjectM.AiMove_Server aiMoveServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AiMove_Server>(this._entity, out aiMoveServer) ? new ProjectM.AiMove_Server?() : new ProjectM.AiMove_Server?(aiMoveServer);
      }
    }

    public ProjectM.Pathfinding.LastPathRequest? LastPathRequest
    {
      get
      {
        ProjectM.Pathfinding.LastPathRequest lastPathRequest;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Pathfinding.LastPathRequest>(this._entity, out lastPathRequest) ? new ProjectM.Pathfinding.LastPathRequest?() : new ProjectM.Pathfinding.LastPathRequest?(lastPathRequest);
      }
    }

    public ProjectM.GainAggroByAlert? GainAggroByAlert
    {
      get
      {
        ProjectM.GainAggroByAlert gainAggroByAlert;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GainAggroByAlert>(this._entity, out gainAggroByAlert) ? new ProjectM.GainAggroByAlert?() : new ProjectM.GainAggroByAlert?(gainAggroByAlert);
      }
    }

    public ProjectM.GainAggroByVicinity? GainAggroByVicinity
    {
      get
      {
        ProjectM.GainAggroByVicinity gainAggroByVicinity;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GainAggroByVicinity>(this._entity, out gainAggroByVicinity) ? new ProjectM.GainAggroByVicinity?() : new ProjectM.GainAggroByVicinity?(gainAggroByVicinity);
      }
    }

    public ProjectM.GainAlertByVicinity? GainAlertByVicinity
    {
      get
      {
        ProjectM.GainAlertByVicinity gainAlertByVicinity;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GainAlertByVicinity>(this._entity, out gainAlertByVicinity) ? new ProjectM.GainAlertByVicinity?() : new ProjectM.GainAlertByVicinity?(gainAlertByVicinity);
      }
    }

    public ProjectM.AggroModifiers? AggroModifiers
    {
      get
      {
        ProjectM.AggroModifiers aggroModifiers;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AggroModifiers>(this._entity, out aggroModifiers) ? new ProjectM.AggroModifiers?() : new ProjectM.AggroModifiers?(aggroModifiers);
      }
    }

    public ProjectM.AlertModifiers? AlertModifiers
    {
      get
      {
        ProjectM.AlertModifiers alertModifiers;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AlertModifiers>(this._entity, out alertModifiers) ? new ProjectM.AlertModifiers?() : new ProjectM.AlertModifiers?(alertModifiers);
      }
    }

    public ProjectM.AggroDamageHistoryConfig? AggroDamageHistoryConfig
    {
      get
      {
        ProjectM.AggroDamageHistoryConfig damageHistoryConfig;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AggroDamageHistoryConfig>(this._entity, out damageHistoryConfig) ? new ProjectM.AggroDamageHistoryConfig?() : new ProjectM.AggroDamageHistoryConfig?(damageHistoryConfig);
      }
    }

    public ProjectM.AiPrioritization_Data? AiPrioritization_Data
    {
      get
      {
        ProjectM.AiPrioritization_Data prioritizationData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AiPrioritization_Data>(this._entity, out prioritizationData) ? new ProjectM.AiPrioritization_Data?() : new ProjectM.AiPrioritization_Data?(prioritizationData);
      }
    }

    public ProjectM.AiPrioritization_State? AiPrioritization_State
    {
      get
      {
        ProjectM.AiPrioritization_State prioritizationState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AiPrioritization_State>(this._entity, out prioritizationState) ? new ProjectM.AiPrioritization_State?() : new ProjectM.AiPrioritization_State?(prioritizationState);
      }
    }

    public ProjectM.Aggroable? Aggroable
    {
      get
      {
        ProjectM.Aggroable aggroable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Aggroable>(this._entity, out aggroable) ? new ProjectM.Aggroable?() : new ProjectM.Aggroable?(aggroable);
      }
    }

    public ProjectM.AiMoveSpeeds? AiMoveSpeeds
    {
      get
      {
        ProjectM.AiMoveSpeeds aiMoveSpeeds;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AiMoveSpeeds>(this._entity, out aiMoveSpeeds) ? new ProjectM.AiMoveSpeeds?() : new ProjectM.AiMoveSpeeds?(aiMoveSpeeds);
      }
    }

    public ProjectM.Stealthable? Stealthable
    {
      get
      {
        ProjectM.Stealthable stealthable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Stealthable>(this._entity, out stealthable) ? new ProjectM.Stealthable?() : new ProjectM.Stealthable?(stealthable);
      }
    }

    public Movement Movement
    {
      get
      {
        Movement movement;
        return !this._world.EntityManager.TryGetComponentDataInternal<Movement>(this._entity, out movement) ? new Movement() : movement;
      }
    }

    public ProjectM.MapCollision? MapCollision
    {
      get
      {
        ProjectM.MapCollision mapCollision;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MapCollision>(this._entity, out mapCollision) ? new ProjectM.MapCollision?() : new ProjectM.MapCollision?(mapCollision);
      }
    }

    public ProjectM.UnitLevel? UnitLevel
    {
      get
      {
        ProjectM.UnitLevel unitLevel;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UnitLevel>(this._entity, out unitLevel) ? new ProjectM.UnitLevel?() : new ProjectM.UnitLevel?(unitLevel);
      }
    }

    public ProjectM.Vision? Vision
    {
      get
      {
        ProjectM.Vision vision;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Vision>(this._entity, out vision) ? new ProjectM.Vision?() : new ProjectM.Vision?(vision);
      }
    }

    public ProjectM.ResistanceData? ResistanceData
    {
      get
      {
        ProjectM.ResistanceData resistanceData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ResistanceData>(this._entity, out resistanceData) ? new ProjectM.ResistanceData?() : new ProjectM.ResistanceData?(resistanceData);
      }
    }

    public ProjectM.UnitStats? UnitStats
    {
      get
      {
        ProjectM.UnitStats unitStats;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UnitStats>(this._entity, out unitStats) ? new ProjectM.UnitStats?() : new ProjectM.UnitStats?(unitStats);
      }
    }

    public ProjectM.AiMove_Shared? AiMove_Shared
    {
      get
      {
        ProjectM.AiMove_Shared aiMoveShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AiMove_Shared>(this._entity, out aiMoveShared) ? new ProjectM.AiMove_Shared?() : new ProjectM.AiMove_Shared?(aiMoveShared);
      }
    }

    public ProjectM.GenericCombatMovementData? GenericCombatMovementData
    {
      get
      {
        ProjectM.GenericCombatMovementData combatMovementData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GenericCombatMovementData>(this._entity, out combatMovementData) ? new ProjectM.GenericCombatMovementData?() : new ProjectM.GenericCombatMovementData?(combatMovementData);
      }
    }

    public ProjectM.MiscAiGameplayData? MiscAiGameplayData
    {
      get
      {
        ProjectM.MiscAiGameplayData miscAiGameplayData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MiscAiGameplayData>(this._entity, out miscAiGameplayData) ? new ProjectM.MiscAiGameplayData?() : new ProjectM.MiscAiGameplayData?(miscAiGameplayData);
      }
    }

    public ProjectM.AiDebugDraw? AiDebugDraw
    {
      get
      {
        ProjectM.AiDebugDraw aiDebugDraw;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AiDebugDraw>(this._entity, out aiDebugDraw) ? new ProjectM.AiDebugDraw?() : new ProjectM.AiDebugDraw?(aiDebugDraw);
      }
    }

    public ProjectM.Pathfinding.Pathfinder? Pathfinder
    {
      get
      {
        ProjectM.Pathfinding.Pathfinder pathfinder;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Pathfinding.Pathfinder>(this._entity, out pathfinder) ? new ProjectM.Pathfinding.Pathfinder?() : new ProjectM.Pathfinding.Pathfinder?(pathfinder);
      }
    }

    public ProjectM.DynamicCollision? DynamicCollision
    {
      get
      {
        ProjectM.DynamicCollision dynamicCollision;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DynamicCollision>(this._entity, out dynamicCollision) ? new ProjectM.DynamicCollision?() : new ProjectM.DynamicCollision?(dynamicCollision);
      }
    }

    public ProjectM.Network.NetworkInterpolated_Shared? NetworkInterpolated_Shared
    {
      get
      {
        ProjectM.Network.NetworkInterpolated_Shared interpolatedShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.NetworkInterpolated_Shared>(this._entity, out interpolatedShared) ? new ProjectM.Network.NetworkInterpolated_Shared?() : new ProjectM.Network.NetworkInterpolated_Shared?(interpolatedShared);
      }
    }

    public List<AggroBuffer> AggroBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<AggroBuffer>(this._entity);
    }

    public List<AlertBuffer> AlertBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<AlertBuffer>(this._entity);
    }

    public List<AggroCandidateBufferElement> AggroCandidateBufferElements
    {
      get => this._world.EntityManager.GetBufferInternal<AggroCandidateBufferElement>(this._entity);
    }

    public List<AggroDamageHistoryBufferElement> AggroDamageHistoryBufferElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<AggroDamageHistoryBufferElement>(this._entity);
      }
    }

    public List<ExternalAggroBufferElement> ExternalAggroBufferElements
    {
      get => this._world.EntityManager.GetBufferInternal<ExternalAggroBufferElement>(this._entity);
    }

    public List<ProjectM.EntitiesInView_Server> EntitiesInView_Server
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.EntitiesInView_Server>(this._entity);
    }

    public List<BehaviourTreeStateActiveBuffsBuffer> BehaviourTreeStateActiveBuffsBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<BehaviourTreeStateActiveBuffsBuffer>(this._entity);
      }
    }

    public List<BehaviourTreeStateBuffsBuffer> BehaviourTreeStateBuffsBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<BehaviourTreeStateBuffsBuffer>(this._entity);
      }
    }

    public List<PathBuffer> PathBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<PathBuffer>(this._entity);
    }

    public List<PathRequestFilledSegmentBuffer> PathRequestFilledSegmentBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<PathRequestFilledSegmentBuffer>(this._entity);
      }
    }

    public List<PathRequestSolveDebugBuffer> PathRequestSolveDebugBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<PathRequestSolveDebugBuffer>(this._entity);
    }

    public List<UnsmoothedPathBuffer> UnsmoothedPathBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<UnsmoothedPathBuffer>(this._entity);
    }

    public bool MoveEntity
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.MoveEntity>(this._entity);
    }

    public bool SnapToHeight
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.SnapToHeight>(this._entity);
    }

    public bool HideOutsideVision
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.HideOutsideVision>(this._entity);
    }

    public ProjectM.FactionReference? FactionReference
    {
      get
      {
        ProjectM.FactionReference factionReference;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.FactionReference>(this._entity, out factionReference) ? new ProjectM.FactionReference?() : new ProjectM.FactionReference?(factionReference);
      }
    }

    public List<PrefabGUIDModificationBuffer> PrefabGUIDModificationBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<PrefabGUIDModificationBuffer>(this._entity);
      }
    }

    public List<PlaySequenceOnDeath> PlaySequenceOnDeaths
    {
      get => this._world.EntityManager.GetBufferInternal<PlaySequenceOnDeath>(this._entity);
    }

    public ProjectM.AbilityGroupState? AbilityGroupState
    {
      get
      {
        ProjectM.AbilityGroupState abilityGroupState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityGroupState>(this._entity, out abilityGroupState) ? new ProjectM.AbilityGroupState?() : new ProjectM.AbilityGroupState?(abilityGroupState);
      }
    }

    public ProjectM.PlaceTilemodelAbility? PlaceTilemodelAbility
    {
      get
      {
        ProjectM.PlaceTilemodelAbility tilemodelAbility;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PlaceTilemodelAbility>(this._entity, out tilemodelAbility) ? new ProjectM.PlaceTilemodelAbility?() : new ProjectM.PlaceTilemodelAbility?(tilemodelAbility);
      }
    }

    public List<AbilityStateBuffer> AbilityStateBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<AbilityStateBuffer>(this._entity);
    }

    public List<AbilityGroupStartAbilitiesBuffer> AbilityGroupStartAbilitiesBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<AbilityGroupStartAbilitiesBuffer>(this._entity);
      }
    }

    public ProjectM.AbilityChargesState? AbilityChargesState
    {
      get
      {
        ProjectM.AbilityChargesState abilityChargesState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityChargesState>(this._entity, out abilityChargesState) ? new ProjectM.AbilityChargesState?() : new ProjectM.AbilityChargesState?(abilityChargesState);
      }
    }

    public ProjectM.AbilityChargesData? AbilityChargesData
    {
      get
      {
        ProjectM.AbilityChargesData abilityChargesData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityChargesData>(this._entity, out abilityChargesData) ? new ProjectM.AbilityChargesData?() : new ProjectM.AbilityChargesData?(abilityChargesData);
      }
    }

    public ProjectM.AbilityGroupComboState? AbilityGroupComboState
    {
      get
      {
        ProjectM.AbilityGroupComboState abilityGroupComboState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityGroupComboState>(this._entity, out abilityGroupComboState) ? new ProjectM.AbilityGroupComboState?() : new ProjectM.AbilityGroupComboState?(abilityGroupComboState);
      }
    }

    public ProjectM.AbilityGroupResetComboState? AbilityGroupResetComboState
    {
      get
      {
        ProjectM.AbilityGroupResetComboState groupResetComboState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityGroupResetComboState>(this._entity, out groupResetComboState) ? new ProjectM.AbilityGroupResetComboState?() : new ProjectM.AbilityGroupResetComboState?(groupResetComboState);
      }
    }

    public ProjectM.VBloodAbilityData? VBloodAbilityData
    {
      get
      {
        ProjectM.VBloodAbilityData vbloodAbilityData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodAbilityData>(this._entity, out vbloodAbilityData) ? new ProjectM.VBloodAbilityData?() : new ProjectM.VBloodAbilityData?(vbloodAbilityData);
      }
    }

    public ProjectM.AbilityGroupConsumeItemOnCast? AbilityGroupConsumeItemOnCast
    {
      get
      {
        ProjectM.AbilityGroupConsumeItemOnCast consumeItemOnCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityGroupConsumeItemOnCast>(this._entity, out consumeItemOnCast) ? new ProjectM.AbilityGroupConsumeItemOnCast?() : new ProjectM.AbilityGroupConsumeItemOnCast?(consumeItemOnCast);
      }
    }

    public ProjectM.StoredBloodAbility? StoredBloodAbility
    {
      get
      {
        ProjectM.StoredBloodAbility storedBloodAbility;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StoredBloodAbility>(this._entity, out storedBloodAbility) ? new ProjectM.StoredBloodAbility?() : new ProjectM.StoredBloodAbility?(storedBloodAbility);
      }
    }

    public bool VBloodEmoteData
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.VBloodEmoteData>(this._entity);
    }

    public ProjectM.DismantleAbility? DismantleAbility
    {
      get
      {
        ProjectM.DismantleAbility dismantleAbility;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DismantleAbility>(this._entity, out dismantleAbility) ? new ProjectM.DismantleAbility?() : new ProjectM.DismantleAbility?(dismantleAbility);
      }
    }

    public ProjectM.MagicSourceDurabilityRequirement? MagicSourceDurabilityRequirement
    {
      get
      {
        ProjectM.MagicSourceDurabilityRequirement durabilityRequirement;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MagicSourceDurabilityRequirement>(this._entity, out durabilityRequirement) ? new ProjectM.MagicSourceDurabilityRequirement?() : new ProjectM.MagicSourceDurabilityRequirement?(durabilityRequirement);
      }
    }

    public ProjectM.RepairAbility? RepairAbility
    {
      get
      {
        ProjectM.RepairAbility repairAbility;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RepairAbility>(this._entity, out repairAbility) ? new ProjectM.RepairAbility?() : new ProjectM.RepairAbility?(repairAbility);
      }
    }

    public ProjectM.Shared.IgnoreHitsPerTarget? IgnoreHitsPerTarget
    {
      get
      {
        ProjectM.Shared.IgnoreHitsPerTarget ignoreHitsPerTarget;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Shared.IgnoreHitsPerTarget>(this._entity, out ignoreHitsPerTarget) ? new ProjectM.Shared.IgnoreHitsPerTarget?() : new ProjectM.Shared.IgnoreHitsPerTarget?(ignoreHitsPerTarget);
      }
    }

    public List<IgnoreHitsPerTargetElement> IgnoreHitsPerTargetElements
    {
      get => this._world.EntityManager.GetBufferInternal<IgnoreHitsPerTargetElement>(this._entity);
    }

    public ProjectM.AbilityGroupGiveProgressionOnCast? AbilityGroupGiveProgressionOnCast
    {
      get
      {
        ProjectM.AbilityGroupGiveProgressionOnCast progressionOnCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityGroupGiveProgressionOnCast>(this._entity, out progressionOnCast) ? new ProjectM.AbilityGroupGiveProgressionOnCast?() : new ProjectM.AbilityGroupGiveProgressionOnCast?(progressionOnCast);
      }
    }

    public ProjectM.Shared.DamageReductionPerTarget? DamageReductionPerTarget
    {
      get
      {
        ProjectM.Shared.DamageReductionPerTarget reductionPerTarget;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Shared.DamageReductionPerTarget>(this._entity, out reductionPerTarget) ? new ProjectM.Shared.DamageReductionPerTarget?() : new ProjectM.Shared.DamageReductionPerTarget?(reductionPerTarget);
      }
    }

    public List<DamageReductionPerTargetElement> DamageReductionPerTargetElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<DamageReductionPerTargetElement>(this._entity);
      }
    }

    public ProjectM.AbilityBar_Server? AbilityBar_Server
    {
      get
      {
        ProjectM.AbilityBar_Server abilityBarServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityBar_Server>(this._entity, out abilityBarServer) ? new ProjectM.AbilityBar_Server?() : new ProjectM.AbilityBar_Server?(abilityBarServer);
      }
    }

    public ProjectM.AbilityBar_Shared? AbilityBar_Shared
    {
      get
      {
        ProjectM.AbilityBar_Shared abilityBarShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityBar_Shared>(this._entity, out abilityBarShared) ? new ProjectM.AbilityBar_Shared?() : new ProjectM.AbilityBar_Shared?(abilityBarShared);
      }
    }

    public ProjectM.AbilityBarInitializationState? AbilityBarInitializationState
    {
      get
      {
        ProjectM.AbilityBarInitializationState initializationState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityBarInitializationState>(this._entity, out initializationState) ? new ProjectM.AbilityBarInitializationState?() : new ProjectM.AbilityBarInitializationState?(initializationState);
      }
    }

    public WalkBackAndForth WalkBackAndForth
    {
      get
      {
        WalkBackAndForth walkBackAndForth;
        return !this._world.EntityManager.TryGetComponentDataInternal<WalkBackAndForth>(this._entity, out walkBackAndForth) ? new WalkBackAndForth() : walkBackAndForth;
      }
    }

    public List<AbilityGroupSlotBuffer> AbilityGroupSlotBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<AbilityGroupSlotBuffer>(this._entity);
    }

    public ProjectM.Follower? Follower
    {
      get
      {
        ProjectM.Follower follower;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Follower>(this._entity, out follower) ? new ProjectM.Follower?() : new ProjectM.Follower?(follower);
      }
    }

    public ProjectM.Behaviours.BehaviourTreeInstance? BehaviourTreeInstance
    {
      get
      {
        ProjectM.Behaviours.BehaviourTreeInstance behaviourTreeInstance;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Behaviours.BehaviourTreeInstance>(this._entity, out behaviourTreeInstance) ? new ProjectM.Behaviours.BehaviourTreeInstance?() : new ProjectM.Behaviours.BehaviourTreeInstance?(behaviourTreeInstance);
      }
    }

    public ProjectM.Hideable? Hideable
    {
      get
      {
        ProjectM.Hideable hideable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Hideable>(this._entity, out hideable) ? new ProjectM.Hideable?() : new ProjectM.Hideable?(hideable);
      }
    }

    public ProjectM.WoundedConstants? WoundedConstants
    {
      get
      {
        ProjectM.WoundedConstants woundedConstants;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WoundedConstants>(this._entity, out woundedConstants) ? new ProjectM.WoundedConstants?() : new ProjectM.WoundedConstants?(woundedConstants);
      }
    }

    public ProjectM.CanPreventDisableWhenNoPlayersInRange? CanPreventDisableWhenNoPlayersInRange
    {
      get
      {
        ProjectM.CanPreventDisableWhenNoPlayersInRange noPlayersInRange;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CanPreventDisableWhenNoPlayersInRange>(this._entity, out noPlayersInRange) ? new ProjectM.CanPreventDisableWhenNoPlayersInRange?() : new ProjectM.CanPreventDisableWhenNoPlayersInRange?(noPlayersInRange);
      }
    }

    public ProjectM.Behaviours.BehaviourTreeBinding? BehaviourTreeBinding
    {
      get
      {
        ProjectM.Behaviours.BehaviourTreeBinding behaviourTreeBinding;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Behaviours.BehaviourTreeBinding>(this._entity, out behaviourTreeBinding) ? new ProjectM.Behaviours.BehaviourTreeBinding?() : new ProjectM.Behaviours.BehaviourTreeBinding?(behaviourTreeBinding);
      }
    }

    public ProjectM.Behaviours.BehaviourTreeState? BehaviourTreeState
    {
      get
      {
        ProjectM.Behaviours.BehaviourTreeState behaviourTreeState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Behaviours.BehaviourTreeState>(this._entity, out behaviourTreeState) ? new ProjectM.Behaviours.BehaviourTreeState?() : new ProjectM.Behaviours.BehaviourTreeState?(behaviourTreeState);
      }
    }

    public ProjectM.Behaviours.BehaviourTreeStateMetadata? BehaviourTreeStateMetadata
    {
      get
      {
        ProjectM.Behaviours.BehaviourTreeStateMetadata treeStateMetadata;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Behaviours.BehaviourTreeStateMetadata>(this._entity, out treeStateMetadata) ? new ProjectM.Behaviours.BehaviourTreeStateMetadata?() : new ProjectM.Behaviours.BehaviourTreeStateMetadata?(treeStateMetadata);
      }
    }

    public List<BlackboardElement> BlackboardElements
    {
      get => this._world.EntityManager.GetBufferInternal<BlackboardElement>(this._entity);
    }

    public List<BehaviourTreeNodeInstanceElement> BehaviourTreeNodeInstanceElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<BehaviourTreeNodeInstanceElement>(this._entity);
      }
    }

    public bool CharmSource
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.CharmSource>(this._entity);
    }

    public ProjectM.CastHistoryData? CastHistoryData
    {
      get
      {
        ProjectM.CastHistoryData castHistoryData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastHistoryData>(this._entity, out castHistoryData) ? new ProjectM.CastHistoryData?() : new ProjectM.CastHistoryData?(castHistoryData);
      }
    }

    public List<CastHistoryBufferElement> CastHistoryBufferElements
    {
      get => this._world.EntityManager.GetBufferInternal<CastHistoryBufferElement>(this._entity);
    }

    public ProjectM.BloodConsumeSource? BloodConsumeSource
    {
      get
      {
        ProjectM.BloodConsumeSource bloodConsumeSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodConsumeSource>(this._entity, out bloodConsumeSource) ? new ProjectM.BloodConsumeSource?() : new ProjectM.BloodConsumeSource?(bloodConsumeSource);
      }
    }

    public ProjectM.TravelToTargetRadius? TravelToTargetRadius
    {
      get
      {
        ProjectM.TravelToTargetRadius travelToTargetRadius;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TravelToTargetRadius>(this._entity, out travelToTargetRadius) ? new ProjectM.TravelToTargetRadius?() : new ProjectM.TravelToTargetRadius?(travelToTargetRadius);
      }
    }

    public List<RandomBloodTypeBuffer> RandomBloodTypeBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<RandomBloodTypeBuffer>(this._entity);
    }

    public bool IgnorePvETag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.IgnorePvETag>(this._entity);
    }

    public ProjectM.BloodBuff? BloodBuff
    {
      get
      {
        ProjectM.BloodBuff bloodBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuff>(this._entity, out bloodBuff) ? new ProjectM.BloodBuff?() : new ProjectM.BloodBuff?(bloodBuff);
      }
    }

    public ProjectM.Gameplay.Scripting.AbilityProjectileFanOnGameplayEvent_DataServer? AbilityProjectileFanOnGameplayEvent_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.AbilityProjectileFanOnGameplayEvent_DataServer gameplayEventDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.AbilityProjectileFanOnGameplayEvent_DataServer>(this._entity, out gameplayEventDataServer) ? new ProjectM.Gameplay.Scripting.AbilityProjectileFanOnGameplayEvent_DataServer?() : new ProjectM.Gameplay.Scripting.AbilityProjectileFanOnGameplayEvent_DataServer?(gameplayEventDataServer);
      }
    }

    public ProjectM.BloodBuffScript_Brute_HealthRegenBonus? BloodBuffScript_Brute_HealthRegenBonus
    {
      get
      {
        ProjectM.BloodBuffScript_Brute_HealthRegenBonus healthRegenBonus;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuffScript_Brute_HealthRegenBonus>(this._entity, out healthRegenBonus) ? new ProjectM.BloodBuffScript_Brute_HealthRegenBonus?() : new ProjectM.BloodBuffScript_Brute_HealthRegenBonus?(healthRegenBonus);
      }
    }

    public ProjectM.Gameplay.Scripting.EvenSpreadCluster_Tick_DataServer? EvenSpreadCluster_Tick_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.EvenSpreadCluster_Tick_DataServer clusterTickDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.EvenSpreadCluster_Tick_DataServer>(this._entity, out clusterTickDataServer) ? new ProjectM.Gameplay.Scripting.EvenSpreadCluster_Tick_DataServer?() : new ProjectM.Gameplay.Scripting.EvenSpreadCluster_Tick_DataServer?(clusterTickDataServer);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Throw_Prefabs_To_Spawn> Throw_Prefabs_To_Spawn
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Throw_Prefabs_To_Spawn>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.AbilityThrowTowardsEventHitTarget_DataServer? AbilityThrowTowardsEventHitTarget_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.AbilityThrowTowardsEventHitTarget_DataServer targetDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.AbilityThrowTowardsEventHitTarget_DataServer>(this._entity, out targetDataServer) ? new ProjectM.Gameplay.Scripting.AbilityThrowTowardsEventHitTarget_DataServer?() : new ProjectM.Gameplay.Scripting.AbilityThrowTowardsEventHitTarget_DataServer?(targetDataServer);
      }
    }

    public ProjectM.BloodBuffScript_Brute_NulifyAndEmpower? BloodBuffScript_Brute_NulifyAndEmpower
    {
      get
      {
        ProjectM.BloodBuffScript_Brute_NulifyAndEmpower nulifyAndEmpower;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuffScript_Brute_NulifyAndEmpower>(this._entity, out nulifyAndEmpower) ? new ProjectM.BloodBuffScript_Brute_NulifyAndEmpower?() : new ProjectM.BloodBuffScript_Brute_NulifyAndEmpower?(nulifyAndEmpower);
      }
    }

    public ProjectM.Gameplay.Scripting.AbilityThrowMultipleWithSpreadOnTick_DataServer? AbilityThrowMultipleWithSpreadOnTick_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.AbilityThrowMultipleWithSpreadOnTick_DataServer onTickDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.AbilityThrowMultipleWithSpreadOnTick_DataServer>(this._entity, out onTickDataServer) ? new ProjectM.Gameplay.Scripting.AbilityThrowMultipleWithSpreadOnTick_DataServer?() : new ProjectM.Gameplay.Scripting.AbilityThrowMultipleWithSpreadOnTick_DataServer?(onTickDataServer);
      }
    }

    public ProjectM.BloodBuffScript_Rogue_MountDamageBonus? BloodBuffScript_Rogue_MountDamageBonus
    {
      get
      {
        ProjectM.BloodBuffScript_Rogue_MountDamageBonus mountDamageBonus;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuffScript_Rogue_MountDamageBonus>(this._entity, out mountDamageBonus) ? new ProjectM.BloodBuffScript_Rogue_MountDamageBonus?() : new ProjectM.BloodBuffScript_Rogue_MountDamageBonus?(mountDamageBonus);
      }
    }

    public ProjectM.BloodBuffScript_Innocent_80? BloodBuffScript_Innocent_80
    {
      get
      {
        ProjectM.BloodBuffScript_Innocent_80 scriptInnocent80;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuffScript_Innocent_80>(this._entity, out scriptInnocent80) ? new ProjectM.BloodBuffScript_Innocent_80?() : new ProjectM.BloodBuffScript_Innocent_80?(scriptInnocent80);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_SetAbilityCooldownOnGameplayEvent_DataServer? Script_SetAbilityCooldownOnGameplayEvent_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_SetAbilityCooldownOnGameplayEvent_DataServer gameplayEventDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_SetAbilityCooldownOnGameplayEvent_DataServer>(this._entity, out gameplayEventDataServer) ? new ProjectM.Gameplay.Scripting.Script_SetAbilityCooldownOnGameplayEvent_DataServer?() : new ProjectM.Gameplay.Scripting.Script_SetAbilityCooldownOnGameplayEvent_DataServer?(gameplayEventDataServer);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Script_SCTChatOnSpawn_Buffer> Script_SCTChatOnSpawn_Buffer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_SCTChatOnSpawn_Buffer>(this._entity);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_BouncingProjectile_DataServer? Script_BouncingProjectile_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_BouncingProjectile_DataServer projectileDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_BouncingProjectile_DataServer>(this._entity, out projectileDataServer) ? new ProjectM.Gameplay.Scripting.Script_BouncingProjectile_DataServer?() : new ProjectM.Gameplay.Scripting.Script_BouncingProjectile_DataServer?(projectileDataServer);
      }
    }

    public ProjectM.SetDynamicCollisionHardnessBuff? SetDynamicCollisionHardnessBuff
    {
      get
      {
        ProjectM.SetDynamicCollisionHardnessBuff collisionHardnessBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SetDynamicCollisionHardnessBuff>(this._entity, out collisionHardnessBuff) ? new ProjectM.SetDynamicCollisionHardnessBuff?() : new ProjectM.SetDynamicCollisionHardnessBuff?(collisionHardnessBuff);
      }
    }

    public ProjectM.Ticker? Ticker
    {
      get
      {
        ProjectM.Ticker ticker;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Ticker>(this._entity, out ticker) ? new ProjectM.Ticker?() : new ProjectM.Ticker?(ticker);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Gorgon_Venom_Debuff_DataServer? Script_Gorgon_Venom_Debuff_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Gorgon_Venom_Debuff_DataServer debuffDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Gorgon_Venom_Debuff_DataServer>(this._entity, out debuffDataServer) ? new ProjectM.Gameplay.Scripting.Script_Gorgon_Venom_Debuff_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Gorgon_Venom_Debuff_DataServer?(debuffDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ApplyExclusiveSiegeBuff_DataServer? Script_ApplyExclusiveSiegeBuff_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ApplyExclusiveSiegeBuff_DataServer siegeBuffDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ApplyExclusiveSiegeBuff_DataServer>(this._entity, out siegeBuffDataServer) ? new ProjectM.Gameplay.Scripting.Script_ApplyExclusiveSiegeBuff_DataServer?() : new ProjectM.Gameplay.Scripting.Script_ApplyExclusiveSiegeBuff_DataServer?(siegeBuffDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_Shared? Script_DamageZone_SingleTarget_Shared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_Shared singleTargetShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_Shared>(this._entity, out singleTargetShared) ? new ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_Shared?() : new ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_Shared?(singleTargetShared);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_HitTarget> Script_DamageZone_SingleTarget_HitTarget
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_HitTarget>(this._entity);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_HitConditions> Script_DamageZone_SingleTarget_HitConditions
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_HitConditions>(this._entity);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_SilverDebuff_DataServer? Script_SilverDebuff_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_SilverDebuff_DataServer debuffDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_SilverDebuff_DataServer>(this._entity, out debuffDataServer) ? new ProjectM.Gameplay.Scripting.Script_SilverDebuff_DataServer?() : new ProjectM.Gameplay.Scripting.Script_SilverDebuff_DataServer?(debuffDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.LaunchProjectileTowardsTargetOnGameplayEvent_DataServer? LaunchProjectileTowardsTargetOnGameplayEvent_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.LaunchProjectileTowardsTargetOnGameplayEvent_DataServer gameplayEventDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.LaunchProjectileTowardsTargetOnGameplayEvent_DataServer>(this._entity, out gameplayEventDataServer) ? new ProjectM.Gameplay.Scripting.LaunchProjectileTowardsTargetOnGameplayEvent_DataServer?() : new ProjectM.Gameplay.Scripting.LaunchProjectileTowardsTargetOnGameplayEvent_DataServer?(gameplayEventDataServer);
      }
    }

    public bool AbilityChargeResetOnUse
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Gameplay.Scripting.AbilityChargeResetOnUse>(this._entity);
    }

    public ProjectM.ServantEquipment? ServantEquipment
    {
      get
      {
        ProjectM.ServantEquipment servantEquipment;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantEquipment>(this._entity, out servantEquipment) ? new ProjectM.ServantEquipment?() : new ProjectM.ServantEquipment?(servantEquipment);
      }
    }

    public ProjectM.ServantConnectedCoffin? ServantConnectedCoffin
    {
      get
      {
        ProjectM.ServantConnectedCoffin servantConnectedCoffin;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantConnectedCoffin>(this._entity, out servantConnectedCoffin) ? new ProjectM.ServantConnectedCoffin?() : new ProjectM.ServantConnectedCoffin?(servantConnectedCoffin);
      }
    }

    public ProjectM.ServantData? ServantData
    {
      get
      {
        ProjectM.ServantData servantData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantData>(this._entity, out servantData) ? new ProjectM.ServantData?() : new ProjectM.ServantData?(servantData);
      }
    }

    public ProjectM.ServantPower? ServantPower
    {
      get
      {
        ProjectM.ServantPower servantPower;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantPower>(this._entity, out servantPower) ? new ProjectM.ServantPower?() : new ProjectM.ServantPower?(servantPower);
      }
    }

    public ProjectM.ServantPowerConstants? ServantPowerConstants
    {
      get
      {
        ProjectM.ServantPowerConstants servantPowerConstants;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantPowerConstants>(this._entity, out servantPowerConstants) ? new ProjectM.ServantPowerConstants?() : new ProjectM.ServantPowerConstants?(servantPowerConstants);
      }
    }

    public ProjectM.ServantTypeData? ServantTypeData
    {
      get
      {
        ProjectM.ServantTypeData servantTypeData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantTypeData>(this._entity, out servantTypeData) ? new ProjectM.ServantTypeData?() : new ProjectM.ServantTypeData?(servantTypeData);
      }
    }

    public ProjectM.NPCServantColorIndex? NPCServantColorIndex
    {
      get
      {
        ProjectM.NPCServantColorIndex servantColorIndex;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.NPCServantColorIndex>(this._entity, out servantColorIndex) ? new ProjectM.NPCServantColorIndex?() : new ProjectM.NPCServantColorIndex?(servantColorIndex);
      }
    }

    public ProjectM.Torture? Torture
    {
      get
      {
        ProjectM.Torture torture;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Torture>(this._entity, out torture) ? new ProjectM.Torture?() : new ProjectM.Torture?(torture);
      }
    }

    public ProjectM.YieldEssenceOnDeath? YieldEssenceOnDeath
    {
      get
      {
        ProjectM.YieldEssenceOnDeath yieldEssenceOnDeath;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.YieldEssenceOnDeath>(this._entity, out yieldEssenceOnDeath) ? new ProjectM.YieldEssenceOnDeath?() : new ProjectM.YieldEssenceOnDeath?(yieldEssenceOnDeath);
      }
    }

    public ProjectM.OpenDoors? OpenDoors
    {
      get
      {
        ProjectM.OpenDoors openDoors;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.OpenDoors>(this._entity, out openDoors) ? new ProjectM.OpenDoors?() : new ProjectM.OpenDoors?(openDoors);
      }
    }

    public ProjectM.ServantConvertable? ServantConvertable
    {
      get
      {
        ProjectM.ServantConvertable servantConvertable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantConvertable>(this._entity, out servantConvertable) ? new ProjectM.ServantConvertable?() : new ProjectM.ServantConvertable?(servantConvertable);
      }
    }

    public List<OpenDoorsBuffer> OpenDoorsBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<OpenDoorsBuffer>(this._entity);
    }

    public List<PerksBuffer> PerksBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<PerksBuffer>(this._entity);
    }

    public List<ServantConvertRequirement> ServantConvertRequirements
    {
      get => this._world.EntityManager.GetBufferInternal<ServantConvertRequirement>(this._entity);
    }

    public List<ProjectM.Gameplay.Scripting.Script_SCTChatOnAggro_Buffer> Script_SCTChatOnAggro_Buffer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_SCTChatOnAggro_Buffer>(this._entity);
      }
    }

    public List<YieldResourcesOnDamageTaken> YieldResourcesOnDamageTakens
    {
      get => this._world.EntityManager.GetBufferInternal<YieldResourcesOnDamageTaken>(this._entity);
    }

    public bool YieldResourcesOnPickup
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.YieldResourcesOnPickup>(this._entity);
    }

    public ProjectM.GetOwnerPrimaryAggroTargetOnSpawn? GetOwnerPrimaryAggroTargetOnSpawn
    {
      get
      {
        ProjectM.GetOwnerPrimaryAggroTargetOnSpawn aggroTargetOnSpawn;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GetOwnerPrimaryAggroTargetOnSpawn>(this._entity, out aggroTargetOnSpawn) ? new ProjectM.GetOwnerPrimaryAggroTargetOnSpawn?() : new ProjectM.GetOwnerPrimaryAggroTargetOnSpawn?(aggroTargetOnSpawn);
      }
    }

    public bool CombatMusicSource_Server
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.CombatMusicSource_Server>(this._entity);
    }

    public ProjectM.FeedableInventory? FeedableInventory
    {
      get
      {
        ProjectM.FeedableInventory feedableInventory;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.FeedableInventory>(this._entity, out feedableInventory) ? new ProjectM.FeedableInventory?() : new ProjectM.FeedableInventory?(feedableInventory);
      }
    }

    public ProjectM.Mountable? Mountable
    {
      get
      {
        ProjectM.Mountable mountable;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Mountable>(this._entity, out mountable) ? new ProjectM.Mountable?() : new ProjectM.Mountable?(mountable);
      }
    }

    public List<CreateGameplayEventOnDeath> CreateGameplayEventOnDeaths
    {
      get => this._world.EntityManager.GetBufferInternal<CreateGameplayEventOnDeath>(this._entity);
    }

    public ProjectM.VBloodUnit? VBloodUnit
    {
      get
      {
        ProjectM.VBloodUnit vbloodUnit;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodUnit>(this._entity, out vbloodUnit) ? new ProjectM.VBloodUnit?() : new ProjectM.VBloodUnit?(vbloodUnit);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_GenerateAggro_DataServer? Script_Buff_GenerateAggro_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_GenerateAggro_DataServer generateAggroDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_GenerateAggro_DataServer>(this._entity, out generateAggroDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_GenerateAggro_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_GenerateAggro_DataServer?(generateAggroDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.RotateOverTimeData? RotateOverTimeData
    {
      get
      {
        ProjectM.Gameplay.Scripting.RotateOverTimeData rotateOverTimeData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.RotateOverTimeData>(this._entity, out rotateOverTimeData) ? new ProjectM.Gameplay.Scripting.RotateOverTimeData?() : new ProjectM.Gameplay.Scripting.RotateOverTimeData?(rotateOverTimeData);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Worker_Gallop_DataShared? BloodBuff_Worker_Gallop_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Worker_Gallop_DataShared gallopDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Worker_Gallop_DataShared>(this._entity, out gallopDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Worker_Gallop_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Worker_Gallop_DataShared?(gallopDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Warrior_100_DataShared? BloodBuff_Warrior_100_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Warrior_100_DataShared warrior100DataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Warrior_100_DataShared>(this._entity, out warrior100DataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_100_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_100_DataShared?(warrior100DataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Worker_Pulverize_DataShared? BloodBuff_Worker_Pulverize_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Worker_Pulverize_DataShared pulverizeDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Worker_Pulverize_DataShared>(this._entity, out pulverizeDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Worker_Pulverize_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Worker_Pulverize_DataShared?(pulverizeDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysicalBonus_DataShared? BloodBuff_Warrior_PhysicalBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysicalBonus_DataShared physicalBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysicalBonus_DataShared>(this._entity, out physicalBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysicalBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysicalBonus_DataShared?(physicalBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysDamageBonus_DataShared? BloodBuff_Warrior_PhysDamageBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysDamageBonus_DataShared damageBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysDamageBonus_DataShared>(this._entity, out damageBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysDamageBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysDamageBonus_DataShared?(damageBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_ModifyAggroFactor_DataServer? Script_Buff_ModifyAggroFactor_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_ModifyAggroFactor_DataServer factorDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_ModifyAggroFactor_DataServer>(this._entity, out factorDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_ModifyAggroFactor_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_ModifyAggroFactor_DataServer?(factorDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Rogue_AttackSpeedBonus_DataShared? BloodBuff_Rogue_AttackSpeedBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Rogue_AttackSpeedBonus_DataShared speedBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Rogue_AttackSpeedBonus_DataShared>(this._entity, out speedBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Rogue_AttackSpeedBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Rogue_AttackSpeedBonus_DataShared?(speedBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_PrimaryAttackLifeLeech_DataShared? BloodBuff_PrimaryAttackLifeLeech_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_PrimaryAttackLifeLeech_DataShared lifeLeechDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_PrimaryAttackLifeLeech_DataShared>(this._entity, out lifeLeechDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_PrimaryAttackLifeLeech_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_PrimaryAttackLifeLeech_DataShared?(lifeLeechDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Innocent_0_DataShared? BloodBuff_Innocent_0_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Innocent_0_DataShared innocent0DataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Innocent_0_DataShared>(this._entity, out innocent0DataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Innocent_0_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Innocent_0_DataShared?(innocent0DataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponCooldown_DataShared? BloodBuff_Warrior_WeaponCooldown_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponCooldown_DataShared cooldownDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponCooldown_DataShared>(this._entity, out cooldownDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponCooldown_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponCooldown_DataShared?(cooldownDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Creature_SpeedBonus_DataShared? BloodBuff_Creature_SpeedBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Creature_SpeedBonus_DataShared speedBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Creature_SpeedBonus_DataShared>(this._entity, out speedBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Creature_SpeedBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Creature_SpeedBonus_DataShared?(speedBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Brute_100_DataShared? BloodBuff_Brute_100_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Brute_100_DataShared brute100DataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Brute_100_DataShared>(this._entity, out brute100DataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Brute_100_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Brute_100_DataShared?(brute100DataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCritChanceBonus_DataShared? BloodBuff_Scholar_SpellCritChanceBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCritChanceBonus_DataShared chanceBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCritChanceBonus_DataShared>(this._entity, out chanceBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCritChanceBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCritChanceBonus_DataShared?(chanceBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.EvenSpreadCluster_DataServer? EvenSpreadCluster_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.EvenSpreadCluster_DataServer clusterDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.EvenSpreadCluster_DataServer>(this._entity, out clusterDataServer) ? new ProjectM.Gameplay.Scripting.EvenSpreadCluster_DataServer?() : new ProjectM.Gameplay.Scripting.EvenSpreadCluster_DataServer?(clusterDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_Data? Script_Modify_Combat_Movement_Buff_Data
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_Data movementBuffData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_Data>(this._entity, out movementBuffData) ? new ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_Data?() : new ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_Data?(movementBuffData);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_State? Script_Modify_Combat_Movement_Buff_State
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_State movementBuffState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_State>(this._entity, out movementBuffState) ? new ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_State?() : new ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_State?(movementBuffState);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Satiated_DataShared? BloodBuff_Satiated_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Satiated_DataShared satiatedDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Satiated_DataShared>(this._entity, out satiatedDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Satiated_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Satiated_DataShared?(satiatedDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAggroListTarget_DataServer? Script_ApplyBuffOnAggroListTarget_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAggroListTarget_DataServer targetDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAggroListTarget_DataServer>(this._entity, out targetDataServer) ? new ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAggroListTarget_DataServer?() : new ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAggroListTarget_DataServer?(targetDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Strength_DataShared? BloodBuff_Strength_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Strength_DataShared strengthDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Strength_DataShared>(this._entity, out strengthDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Strength_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Strength_DataShared?(strengthDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_CritAmplifyProc_DataShared? BloodBuff_CritAmplifyProc_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_CritAmplifyProc_DataShared amplifyProcDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_CritAmplifyProc_DataShared>(this._entity, out amplifyProcDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_CritAmplifyProc_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_CritAmplifyProc_DataShared?(amplifyProcDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Innocent_50_DataShared? BloodBuff_Innocent_50_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Innocent_50_DataShared innocent50DataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Innocent_50_DataShared>(this._entity, out innocent50DataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Innocent_50_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Innocent_50_DataShared?(innocent50DataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_HealthRegeneration_DataShared? BloodBuff_HealthRegeneration_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_HealthRegeneration_DataShared regenerationDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_HealthRegeneration_DataShared>(this._entity, out regenerationDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_HealthRegeneration_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_HealthRegeneration_DataShared?(regenerationDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Brute_RecoverOnKill_DataShared? BloodBuff_Brute_RecoverOnKill_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Brute_RecoverOnKill_DataShared onKillDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Brute_RecoverOnKill_DataShared>(this._entity, out onKillDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Brute_RecoverOnKill_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Brute_RecoverOnKill_DataShared?(onKillDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_PrisonInteract_DataServer? Script_PrisonInteract_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_PrisonInteract_DataServer interactDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_PrisonInteract_DataServer>(this._entity, out interactDataServer) ? new ProjectM.Gameplay.Scripting.Script_PrisonInteract_DataServer?() : new ProjectM.Gameplay.Scripting.Script_PrisonInteract_DataServer?(interactDataServer);
      }
    }

    public ProjectM.BloodBuffScript_FirstStrike? BloodBuffScript_FirstStrike
    {
      get
      {
        ProjectM.BloodBuffScript_FirstStrike scriptFirstStrike;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuffScript_FirstStrike>(this._entity, out scriptFirstStrike) ? new ProjectM.BloodBuffScript_FirstStrike?() : new ProjectM.BloodBuffScript_FirstStrike?(scriptFirstStrike);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_DamageReduction_DataShared? BloodBuff_DamageReduction_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_DamageReduction_DataShared reductionDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_DamageReduction_DataShared>(this._entity, out reductionDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_DamageReduction_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_DamageReduction_DataShared?(reductionDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_PowerMod_Stacking_DataServer? Script_Buff_PowerMod_Stacking_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_PowerMod_Stacking_DataServer stackingDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_PowerMod_Stacking_DataServer>(this._entity, out stackingDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_PowerMod_Stacking_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_PowerMod_Stacking_DataServer?(stackingDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_Werewolf_AttackSpeed_DataServer? Script_Buff_Werewolf_AttackSpeed_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_Werewolf_AttackSpeed_DataServer attackSpeedDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_Werewolf_AttackSpeed_DataServer>(this._entity, out attackSpeedDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_Werewolf_AttackSpeed_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_Werewolf_AttackSpeed_DataServer?(attackSpeedDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DataShared? BloodBuff_Warrior_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DataShared warriorDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DataShared>(this._entity, out warriorDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DataShared?(warriorDataShared);
      }
    }

    public ProjectM.BloodBuffScript_ChanceToResetCooldown? BloodBuffScript_ChanceToResetCooldown
    {
      get
      {
        ProjectM.BloodBuffScript_ChanceToResetCooldown chanceToResetCooldown;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuffScript_ChanceToResetCooldown>(this._entity, out chanceToResetCooldown) ? new ProjectM.BloodBuffScript_ChanceToResetCooldown?() : new ProjectM.BloodBuffScript_ChanceToResetCooldown?(chanceToResetCooldown);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysCritDamageBonus_DataShared? BloodBuff_Warrior_PhysCritDamageBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysCritDamageBonus_DataShared damageBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysCritDamageBonus_DataShared>(this._entity, out damageBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysCritDamageBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysCritDamageBonus_DataShared?(damageBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_WeatherResistant_DataShared? BloodBuff_WeatherResistant_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_WeatherResistant_DataShared resistantDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_WeatherResistant_DataShared>(this._entity, out resistantDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_WeatherResistant_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_WeatherResistant_DataShared?(resistantDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_SpellLifeLeech_DataShared? BloodBuff_SpellLifeLeech_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_SpellLifeLeech_DataShared lifeLeechDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_SpellLifeLeech_DataShared>(this._entity, out lifeLeechDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_SpellLifeLeech_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_SpellLifeLeech_DataShared?(lifeLeechDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_DataServer? Script_Convert_Item_OnConsume_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_DataServer consumeDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_DataServer>(this._entity, out consumeDataServer) ? new ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_DataServer?(consumeDataServer);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_Entry> Script_Convert_Item_OnConsume_Entry
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_Entry>(this._entity);
      }
    }

    public ProjectM.BloodBuffScript_Worker_ReducedDurability? BloodBuffScript_Worker_ReducedDurability
    {
      get
      {
        ProjectM.BloodBuffScript_Worker_ReducedDurability reducedDurability;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuffScript_Worker_ReducedDurability>(this._entity, out reducedDurability) ? new ProjectM.BloodBuffScript_Worker_ReducedDurability?() : new ProjectM.BloodBuffScript_Worker_ReducedDurability?(reducedDurability);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Brute_ArmorLevelBonus_DataShared? BloodBuff_Brute_ArmorLevelBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Brute_ArmorLevelBonus_DataShared levelBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Brute_ArmorLevelBonus_DataShared>(this._entity, out levelBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Brute_ArmorLevelBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Brute_ArmorLevelBonus_DataShared?(levelBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_WerewolfChieftain_ToggleGates_DataShared? Script_WerewolfChieftain_ToggleGates_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_WerewolfChieftain_ToggleGates_DataShared toggleGatesDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_WerewolfChieftain_ToggleGates_DataShared>(this._entity, out toggleGatesDataShared) ? new ProjectM.Gameplay.Scripting.Script_WerewolfChieftain_ToggleGates_DataShared?() : new ProjectM.Gameplay.Scripting.Script_WerewolfChieftain_ToggleGates_DataShared?(toggleGatesDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellPowerBonus_DataShared? BloodBuff_Scholar_SpellPowerBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellPowerBonus_DataShared powerBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellPowerBonus_DataShared>(this._entity, out powerBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellPowerBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellPowerBonus_DataShared?(powerBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_SunResistance_DataShared? BloodBuff_SunResistance_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_SunResistance_DataShared resistanceDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_SunResistance_DataShared>(this._entity, out resistanceDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_SunResistance_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_SunResistance_DataShared?(resistanceDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Brute_PhysLifeLeech_DataShared? BloodBuff_Brute_PhysLifeLeech_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Brute_PhysLifeLeech_DataShared lifeLeechDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Brute_PhysLifeLeech_DataShared>(this._entity, out lifeLeechDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Brute_PhysLifeLeech_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Brute_PhysLifeLeech_DataShared?(lifeLeechDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_PhysCritChanceBonus_DataShared? BloodBuff_PhysCritChanceBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_PhysCritChanceBonus_DataShared chanceBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_PhysCritChanceBonus_DataShared>(this._entity, out chanceBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_PhysCritChanceBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_PhysCritChanceBonus_DataShared?(chanceBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Scholar_ManaRegenBonus_DataShared? BloodBuff_Scholar_ManaRegenBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Scholar_ManaRegenBonus_DataShared regenBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Scholar_ManaRegenBonus_DataShared>(this._entity, out regenBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_ManaRegenBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_ManaRegenBonus_DataShared?(regenBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_VBlood_0_DataShared? BloodBuff_VBlood_0_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_VBlood_0_DataShared vblood0DataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_VBlood_0_DataShared>(this._entity, out vblood0DataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_VBlood_0_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_VBlood_0_DataShared?(vblood0DataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Scholar_MaxManaBonus_DataShared? BloodBuff_Scholar_MaxManaBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Scholar_MaxManaBonus_DataShared manaBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Scholar_MaxManaBonus_DataShared>(this._entity, out manaBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_MaxManaBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_MaxManaBonus_DataShared?(manaBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Worker_IncreaseYield_DataShared? BloodBuff_Worker_IncreaseYield_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Worker_IncreaseYield_DataShared increaseYieldDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Worker_IncreaseYield_DataShared>(this._entity, out increaseYieldDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Worker_IncreaseYield_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Worker_IncreaseYield_DataShared?(increaseYieldDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Frail_DataShared? BloodBuff_Frail_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Frail_DataShared buffFrailDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Frail_DataShared>(this._entity, out buffFrailDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Frail_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Frail_DataShared?(buffFrailDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DamageReduction_DataShared? BloodBuff_Warrior_DamageReduction_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DamageReduction_DataShared reductionDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DamageReduction_DataShared>(this._entity, out reductionDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DamageReduction_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DamageReduction_DataShared?(reductionDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_ReducedTravelCooldown_DataShared? BloodBuff_ReducedTravelCooldown_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_ReducedTravelCooldown_DataShared cooldownDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_ReducedTravelCooldown_DataShared>(this._entity, out cooldownDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_ReducedTravelCooldown_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_ReducedTravelCooldown_DataShared?(cooldownDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_HealReceivedProc_DataShared? BloodBuff_HealReceivedProc_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_HealReceivedProc_DataShared receivedProcDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_HealReceivedProc_DataShared>(this._entity, out receivedProcDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_HealReceivedProc_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_HealReceivedProc_DataShared?(receivedProcDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.SpawnStructure_WeakenState_DataShared? SpawnStructure_WeakenState_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.SpawnStructure_WeakenState_DataShared weakenStateDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.SpawnStructure_WeakenState_DataShared>(this._entity, out weakenStateDataShared) ? new ProjectM.Gameplay.Scripting.SpawnStructure_WeakenState_DataShared?() : new ProjectM.Gameplay.Scripting.SpawnStructure_WeakenState_DataShared?(weakenStateDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponLevelBonus_DataShared? BloodBuff_Warrior_WeaponLevelBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponLevelBonus_DataShared levelBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponLevelBonus_DataShared>(this._entity, out levelBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponLevelBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Warrior_WeaponLevelBonus_DataShared?(levelBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Unsteady_DataShared? BloodBuff_Unsteady_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Unsteady_DataShared unsteadyDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Unsteady_DataShared>(this._entity, out unsteadyDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Unsteady_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Unsteady_DataShared?(unsteadyDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Rogue_SpeedBonus_DataShared? BloodBuff_Rogue_SpeedBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Rogue_SpeedBonus_DataShared speedBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Rogue_SpeedBonus_DataShared>(this._entity, out speedBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Rogue_SpeedBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Rogue_SpeedBonus_DataShared?(speedBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Worker_100_DataShared? BloodBuff_Worker_100_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Worker_100_DataShared worker100DataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Worker_100_DataShared>(this._entity, out worker100DataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Worker_100_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Worker_100_DataShared?(worker100DataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Worker_ResourceDamageBonus_DataShared? BloodBuff_Worker_ResourceDamageBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Worker_ResourceDamageBonus_DataShared damageBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Worker_ResourceDamageBonus_DataShared>(this._entity, out damageBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Worker_ResourceDamageBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Worker_ResourceDamageBonus_DataShared?(damageBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCooldown_DataShared? BloodBuff_Scholar_SpellCooldown_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCooldown_DataShared cooldownDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCooldown_DataShared>(this._entity, out cooldownDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCooldown_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCooldown_DataShared?(cooldownDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellLevelBonus_DataShared? BloodBuff_Scholar_SpellLevelBonus_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellLevelBonus_DataShared levelBonusDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellLevelBonus_DataShared>(this._entity, out levelBonusDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellLevelBonus_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellLevelBonus_DataShared?(levelBonusDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Intelligence_DataShared? BloodBuff_Intelligence_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Intelligence_DataShared intelligenceDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Intelligence_DataShared>(this._entity, out intelligenceDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Intelligence_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Intelligence_DataShared?(intelligenceDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_PrimaryProc_FreeCast_DataShared? BloodBuff_PrimaryProc_FreeCast_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_PrimaryProc_FreeCast_DataShared freeCastDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_PrimaryProc_FreeCast_DataShared>(this._entity, out freeCastDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_PrimaryProc_FreeCast_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_PrimaryProc_FreeCast_DataShared?(freeCastDataShared);
      }
    }

    public ProjectM.BloodBuffScript_Scholar_MovementSpeedOnCast? BloodBuffScript_Scholar_MovementSpeedOnCast
    {
      get
      {
        ProjectM.BloodBuffScript_Scholar_MovementSpeedOnCast movementSpeedOnCast;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodBuffScript_Scholar_MovementSpeedOnCast>(this._entity, out movementSpeedOnCast) ? new ProjectM.BloodBuffScript_Scholar_MovementSpeedOnCast?() : new ProjectM.BloodBuffScript_Scholar_MovementSpeedOnCast?(movementSpeedOnCast);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Rogue_100_DataShared? BloodBuff_Rogue_100_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Rogue_100_DataShared rogue100DataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Rogue_100_DataShared>(this._entity, out rogue100DataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Rogue_100_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Rogue_100_DataShared?(rogue100DataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Sorcerrer_DataShared? BloodBuff_Sorcerrer_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Sorcerrer_DataShared sorcerrerDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Sorcerrer_DataShared>(this._entity, out sorcerrerDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Sorcerrer_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Sorcerrer_DataShared?(sorcerrerDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitDetection_DataServer? Script_CreateGameplayEventOnHitDetection_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitDetection_DataServer detectionDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitDetection_DataServer>(this._entity, out detectionDataServer) ? new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitDetection_DataServer?() : new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitDetection_DataServer?(detectionDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickRandomChance_DataServer? Script_CreateGameplayEventOnTickRandomChance_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickRandomChance_DataServer chanceDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickRandomChance_DataServer>(this._entity, out chanceDataServer) ? new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickRandomChance_DataServer?() : new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickRandomChance_DataServer?(chanceDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_Shapeshift_DataShared? Script_Buff_Shapeshift_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_Shapeshift_DataShared shapeshiftDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_Shapeshift_DataShared>(this._entity, out shapeshiftDataShared) ? new ProjectM.Gameplay.Scripting.Script_Buff_Shapeshift_DataShared?() : new ProjectM.Gameplay.Scripting.Script_Buff_Shapeshift_DataShared?(shapeshiftDataShared);
      }
    }

    public bool BloodShareBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.BloodShareBuff>(this._entity);
    }

    public bool BloodShareBuff_ResetVBlood
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.BloodShareBuff_ResetVBlood>(this._entity);
      }
    }

    public bool RunScriptOnCastEnded
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.RunScriptOnCastEnded>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.SpawnThrowFromBuff_DataServer? SpawnThrowFromBuff_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.SpawnThrowFromBuff_DataServer fromBuffDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.SpawnThrowFromBuff_DataServer>(this._entity, out fromBuffDataServer) ? new ProjectM.Gameplay.Scripting.SpawnThrowFromBuff_DataServer?() : new ProjectM.Gameplay.Scripting.SpawnThrowFromBuff_DataServer?(fromBuffDataServer);
      }
    }

    public bool RunScriptOnCastStarted
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.RunScriptOnCastStarted>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.Script_Gorgon_Rush_Consume_DataServer? Script_Gorgon_Rush_Consume_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Gorgon_Rush_Consume_DataServer consumeDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Gorgon_Rush_Consume_DataServer>(this._entity, out consumeDataServer) ? new ProjectM.Gameplay.Scripting.Script_Gorgon_Rush_Consume_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Gorgon_Rush_Consume_DataServer?(consumeDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_VisionRangeModification_DataServer? Script_Buff_VisionRangeModification_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_VisionRangeModification_DataServer modificationDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_VisionRangeModification_DataServer>(this._entity, out modificationDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_VisionRangeModification_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_VisionRangeModification_DataServer?(modificationDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Siphon_Blood_Buff_DataShared? Script_Siphon_Blood_Buff_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Siphon_Blood_Buff_DataShared bloodBuffDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Siphon_Blood_Buff_DataShared>(this._entity, out bloodBuffDataShared) ? new ProjectM.Gameplay.Scripting.Script_Siphon_Blood_Buff_DataShared?() : new ProjectM.Gameplay.Scripting.Script_Siphon_Blood_Buff_DataShared?(bloodBuffDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.RingAoE_DataShared? RingAoE_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.RingAoE_DataShared ringAoEDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.RingAoE_DataShared>(this._entity, out ringAoEDataShared) ? new ProjectM.Gameplay.Scripting.RingAoE_DataShared?() : new ProjectM.Gameplay.Scripting.RingAoE_DataShared?(ringAoEDataShared);
      }
    }

    public List<HitList> HitLists
    {
      get => this._world.EntityManager.GetBufferInternal<HitList>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.Script_Demount_DataServer? Script_Demount_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Demount_DataServer demountDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Demount_DataServer>(this._entity, out demountDataServer) ? new ProjectM.Gameplay.Scripting.Script_Demount_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Demount_DataServer?(demountDataServer);
      }
    }

    public ProjectM.ModifyTargetHUDHeight? ModifyTargetHUDHeight
    {
      get
      {
        ProjectM.ModifyTargetHUDHeight modifyTargetHudHeight;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyTargetHUDHeight>(this._entity, out modifyTargetHudHeight) ? new ProjectM.ModifyTargetHUDHeight?() : new ProjectM.ModifyTargetHUDHeight?(modifyTargetHudHeight);
      }
    }

    public ProjectM.MountBuff? MountBuff
    {
      get
      {
        ProjectM.MountBuff mountBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MountBuff>(this._entity, out mountBuff) ? new ProjectM.MountBuff?() : new ProjectM.MountBuff?(mountBuff);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_AggroRangeFactor_DataShared? Script_Buff_AggroRangeFactor_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_AggroRangeFactor_DataShared factorDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_AggroRangeFactor_DataShared>(this._entity, out factorDataShared) ? new ProjectM.Gameplay.Scripting.Script_Buff_AggroRangeFactor_DataShared?() : new ProjectM.Gameplay.Scripting.Script_Buff_AggroRangeFactor_DataShared?(factorDataShared);
      }
    }

    public bool Hideable_CopyFromAttachParent
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.Hideable_CopyFromAttachParent>(this._entity);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnAreaEnterExit_DataServer? Script_CreateGameplayEventOnAreaEnterExit_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnAreaEnterExit_DataServer enterExitDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnAreaEnterExit_DataServer>(this._entity, out enterExitDataServer) ? new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnAreaEnterExit_DataServer?() : new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnAreaEnterExit_DataServer?(enterExitDataServer);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnAreaEnterExit_Entry> Script_CreateGameplayEventOnAreaEnterExit_Entry
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnAreaEnterExit_Entry>(this._entity);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataServer? Script_Blood_CrimsonBeam_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataServer crimsonBeamDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataServer>(this._entity, out crimsonBeamDataServer) ? new ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataServer?(crimsonBeamDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataShared? Script_Blood_CrimsonBeam_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataShared crimsonBeamDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataShared>(this._entity, out crimsonBeamDataShared) ? new ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataShared?() : new ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataShared?(crimsonBeamDataShared);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_HitElement> Script_Blood_CrimsonBeam_HitElement
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_HitElement>(this._entity);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_RemoveBuffOnAbilityUseData? Script_RemoveBuffOnAbilityUseData
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_RemoveBuffOnAbilityUseData onAbilityUseData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_RemoveBuffOnAbilityUseData>(this._entity, out onAbilityUseData) ? new ProjectM.Gameplay.Scripting.Script_RemoveBuffOnAbilityUseData?() : new ProjectM.Gameplay.Scripting.Script_RemoveBuffOnAbilityUseData?(onAbilityUseData);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_MountSpeed_DataShared? Script_Buff_MountSpeed_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_MountSpeed_DataShared mountSpeedDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_MountSpeed_DataShared>(this._entity, out mountSpeedDataShared) ? new ProjectM.Gameplay.Scripting.Script_Buff_MountSpeed_DataShared?() : new ProjectM.Gameplay.Scripting.Script_Buff_MountSpeed_DataShared?(mountSpeedDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_Assault_DataShared? BloodBuff_Assault_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_Assault_DataShared assaultDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_Assault_DataShared>(this._entity, out assaultDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_Assault_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_Assault_DataShared?(assaultDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_ModifyFaction_DataServer? Script_Buff_ModifyFaction_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_ModifyFaction_DataServer factionDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_ModifyFaction_DataServer>(this._entity, out factionDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_ModifyFaction_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_ModifyFaction_DataServer?(factionDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAllWithBuff_Cast_DataServer? Script_ApplyBuffOnAllWithBuff_Cast_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAllWithBuff_Cast_DataServer buffCastDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAllWithBuff_Cast_DataServer>(this._entity, out buffCastDataServer) ? new ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAllWithBuff_Cast_DataServer?() : new ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAllWithBuff_Cast_DataServer?(buffCastDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_SetFlyingHeightVision_Buff_DataShared? Script_SetFlyingHeightVision_Buff_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_SetFlyingHeightVision_Buff_DataShared visionBuffDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_SetFlyingHeightVision_Buff_DataShared>(this._entity, out visionBuffDataShared) ? new ProjectM.Gameplay.Scripting.Script_SetFlyingHeightVision_Buff_DataShared?() : new ProjectM.Gameplay.Scripting.Script_SetFlyingHeightVision_Buff_DataShared?(visionBuffDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_MultiThrow_Cast_DataServer? Script_MultiThrow_Cast_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_MultiThrow_Cast_DataServer throwCastDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_MultiThrow_Cast_DataServer>(this._entity, out throwCastDataServer) ? new ProjectM.Gameplay.Scripting.Script_MultiThrow_Cast_DataServer?() : new ProjectM.Gameplay.Scripting.Script_MultiThrow_Cast_DataServer?(throwCastDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ProjectileSpread_Channel_Data? Script_ProjectileSpread_Channel_Data
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ProjectileSpread_Channel_Data spreadChannelData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ProjectileSpread_Channel_Data>(this._entity, out spreadChannelData) ? new ProjectM.Gameplay.Scripting.Script_ProjectileSpread_Channel_Data?() : new ProjectM.Gameplay.Scripting.Script_ProjectileSpread_Channel_Data?(spreadChannelData);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_SpawnThrowTowardsNearbyVampires_DataServer? Script_SpawnThrowTowardsNearbyVampires_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_SpawnThrowTowardsNearbyVampires_DataServer vampiresDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_SpawnThrowTowardsNearbyVampires_DataServer>(this._entity, out vampiresDataServer) ? new ProjectM.Gameplay.Scripting.Script_SpawnThrowTowardsNearbyVampires_DataServer?() : new ProjectM.Gameplay.Scripting.Script_SpawnThrowTowardsNearbyVampires_DataServer?(vampiresDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ClusterBomb_Cast_DataServer? Script_ClusterBomb_Cast_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ClusterBomb_Cast_DataServer bombCastDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ClusterBomb_Cast_DataServer>(this._entity, out bombCastDataServer) ? new ProjectM.Gameplay.Scripting.Script_ClusterBomb_Cast_DataServer?() : new ProjectM.Gameplay.Scripting.Script_ClusterBomb_Cast_DataServer?(bombCastDataServer);
      }
    }

    public ProjectM.Script_ConfuseDummy_DataServer? Script_ConfuseDummy_DataServer
    {
      get
      {
        ProjectM.Script_ConfuseDummy_DataServer confuseDummyDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Script_ConfuseDummy_DataServer>(this._entity, out confuseDummyDataServer) ? new ProjectM.Script_ConfuseDummy_DataServer?() : new ProjectM.Script_ConfuseDummy_DataServer?(confuseDummyDataServer);
      }
    }

    public List<ProjectM.Script_ConfuseDummy_BuffedEntitiesBuffer> Script_ConfuseDummy_BuffedEntitiesBuffer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Script_ConfuseDummy_BuffedEntitiesBuffer>(this._entity);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_GrabToOwner_DataServer? Script_Buff_GrabToOwner_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_GrabToOwner_DataServer toOwnerDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_GrabToOwner_DataServer>(this._entity, out toOwnerDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_GrabToOwner_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_GrabToOwner_DataServer?(toOwnerDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_GrowingProjectile_DataServer? Script_GrowingProjectile_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_GrowingProjectile_DataServer projectileDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_GrowingProjectile_DataServer>(this._entity, out projectileDataServer) ? new ProjectM.Gameplay.Scripting.Script_GrowingProjectile_DataServer?() : new ProjectM.Gameplay.Scripting.Script_GrowingProjectile_DataServer?(projectileDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ToggleNearbyArmorRacks_DataShared? Script_ToggleNearbyArmorRacks_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ToggleNearbyArmorRacks_DataShared armorRacksDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ToggleNearbyArmorRacks_DataShared>(this._entity, out armorRacksDataShared) ? new ProjectM.Gameplay.Scripting.Script_ToggleNearbyArmorRacks_DataShared?() : new ProjectM.Gameplay.Scripting.Script_ToggleNearbyArmorRacks_DataShared?(armorRacksDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_ModifyBuffResistances_DataServer? Script_Buff_ModifyBuffResistances_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_ModifyBuffResistances_DataServer resistancesDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_ModifyBuffResistances_DataServer>(this._entity, out resistancesDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_ModifyBuffResistances_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_ModifyBuffResistances_DataServer?(resistancesDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_MultiShot_Cast_DataServer? Script_MultiShot_Cast_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_MultiShot_Cast_DataServer shotCastDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_MultiShot_Cast_DataServer>(this._entity, out shotCastDataServer) ? new ProjectM.Gameplay.Scripting.Script_MultiShot_Cast_DataServer?() : new ProjectM.Gameplay.Scripting.Script_MultiShot_Cast_DataServer?(shotCastDataServer);
      }
    }

    public ProjectM.InsideBuff? InsideBuff
    {
      get
      {
        ProjectM.InsideBuff insideBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.InsideBuff>(this._entity, out insideBuff) ? new ProjectM.InsideBuff?() : new ProjectM.InsideBuff?(insideBuff);
      }
    }

    public ProjectM.Gameplay.Scripting.BloodBuff_CriticalStrikeOnNextAttack_DataShared? BloodBuff_CriticalStrikeOnNextAttack_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.BloodBuff_CriticalStrikeOnNextAttack_DataShared attackDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.BloodBuff_CriticalStrikeOnNextAttack_DataShared>(this._entity, out attackDataShared) ? new ProjectM.Gameplay.Scripting.BloodBuff_CriticalStrikeOnNextAttack_DataShared?() : new ProjectM.Gameplay.Scripting.BloodBuff_CriticalStrikeOnNextAttack_DataShared?(attackDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_IgniteDebuff_DataServer? Script_IgniteDebuff_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_IgniteDebuff_DataServer debuffDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_IgniteDebuff_DataServer>(this._entity, out debuffDataServer) ? new ProjectM.Gameplay.Scripting.Script_IgniteDebuff_DataServer?() : new ProjectM.Gameplay.Scripting.Script_IgniteDebuff_DataServer?(debuffDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Roll_Jump_DataServer? Script_Roll_Jump_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Roll_Jump_DataServer rollJumpDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Roll_Jump_DataServer>(this._entity, out rollJumpDataServer) ? new ProjectM.Gameplay.Scripting.Script_Roll_Jump_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Roll_Jump_DataServer?(rollJumpDataServer);
      }
    }

    public bool RunScriptOnCastUpdate
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.RunScriptOnCastUpdate>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.Script_Knockback_Wall_Buff_DataServer? Script_Knockback_Wall_Buff_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Knockback_Wall_Buff_DataServer wallBuffDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Knockback_Wall_Buff_DataServer>(this._entity, out wallBuffDataServer) ? new ProjectM.Gameplay.Scripting.Script_Knockback_Wall_Buff_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Knockback_Wall_Buff_DataServer?(wallBuffDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_Stealth_DataServer? Script_Buff_Stealth_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_Stealth_DataServer stealthDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_Stealth_DataServer>(this._entity, out stealthDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_Stealth_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_Stealth_DataServer?(stealthDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Fly_CheckLanding_DataServer? Script_Fly_CheckLanding_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Fly_CheckLanding_DataServer landingDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Fly_CheckLanding_DataServer>(this._entity, out landingDataServer) ? new ProjectM.Gameplay.Scripting.Script_Fly_CheckLanding_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Fly_CheckLanding_DataServer?(landingDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_BouncingProjectile_Delay_DataServer? Script_BouncingProjectile_Delay_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_BouncingProjectile_Delay_DataServer projectileDelayDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_BouncingProjectile_Delay_DataServer>(this._entity, out projectileDelayDataServer) ? new ProjectM.Gameplay.Scripting.Script_BouncingProjectile_Delay_DataServer?() : new ProjectM.Gameplay.Scripting.Script_BouncingProjectile_Delay_DataServer?(projectileDelayDataServer);
      }
    }

    public bool UsePylonStation
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.UsePylonStation>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.Script_Wounded_DataShared? Script_Wounded_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Wounded_DataShared woundedDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Wounded_DataShared>(this._entity, out woundedDataShared) ? new ProjectM.Gameplay.Scripting.Script_Wounded_DataShared?() : new ProjectM.Gameplay.Scripting.Script_Wounded_DataShared?(woundedDataShared);
      }
    }

    public ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared? Script_BloodAltar_TrackVBloodUnit_Shared
    {
      get
      {
        ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared vbloodUnitShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared>(this._entity, out vbloodUnitShared) ? new ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared?() : new ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared?(vbloodUnitShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_BloodAltar_TrackVBloodUnit_Server? Script_BloodAltar_TrackVBloodUnit_Server
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_BloodAltar_TrackVBloodUnit_Server vbloodUnitServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_BloodAltar_TrackVBloodUnit_Server>(this._entity, out vbloodUnitServer) ? new ProjectM.Gameplay.Scripting.Script_BloodAltar_TrackVBloodUnit_Server?() : new ProjectM.Gameplay.Scripting.Script_BloodAltar_TrackVBloodUnit_Server?(vbloodUnitServer);
      }
    }

    public ProjectM.FortifyBuff? FortifyBuff
    {
      get
      {
        ProjectM.FortifyBuff fortifyBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.FortifyBuff>(this._entity, out fortifyBuff) ? new ProjectM.FortifyBuff?() : new ProjectM.FortifyBuff?(fortifyBuff);
      }
    }

    public ProjectM.AmplifyStackModifier? AmplifyStackModifier
    {
      get
      {
        ProjectM.AmplifyStackModifier amplifyStackModifier;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AmplifyStackModifier>(this._entity, out amplifyStackModifier) ? new ProjectM.AmplifyStackModifier?() : new ProjectM.AmplifyStackModifier?(amplifyStackModifier);
      }
    }

    public ProjectM.WeakenStackModifier? WeakenStackModifier
    {
      get
      {
        ProjectM.WeakenStackModifier weakenStackModifier;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WeakenStackModifier>(this._entity, out weakenStackModifier) ? new ProjectM.WeakenStackModifier?() : new ProjectM.WeakenStackModifier?(weakenStackModifier);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataServer? Script_GarlicAreaDebuff_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataServer debuffDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataServer>(this._entity, out debuffDataServer) ? new ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataServer?() : new ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataServer?(debuffDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataShared? Script_GarlicAreaDebuff_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataShared debuffDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataShared>(this._entity, out debuffDataShared) ? new ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataShared?() : new ProjectM.Gameplay.Scripting.Script_GarlicAreaDebuff_DataShared?(debuffDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_GarlicFeverDebuff_DataServer? Script_GarlicFeverDebuff_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_GarlicFeverDebuff_DataServer debuffDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_GarlicFeverDebuff_DataServer>(this._entity, out debuffDataServer) ? new ProjectM.Gameplay.Scripting.Script_GarlicFeverDebuff_DataServer?() : new ProjectM.Gameplay.Scripting.Script_GarlicFeverDebuff_DataServer?(debuffDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_Spellblock_DataServer? Script_Buff_Spellblock_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_Spellblock_DataServer spellblockDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_Spellblock_DataServer>(this._entity, out spellblockDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_Spellblock_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_Spellblock_DataServer?(spellblockDataServer);
      }
    }

    public ProjectM.VampireDownedBuff? VampireDownedBuff
    {
      get
      {
        ProjectM.VampireDownedBuff vampireDownedBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VampireDownedBuff>(this._entity, out vampireDownedBuff) ? new ProjectM.VampireDownedBuff?() : new ProjectM.VampireDownedBuff?(vampireDownedBuff);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickAfterDelay_DataServer? Script_CreateGameplayEventOnTickAfterDelay_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickAfterDelay_DataServer afterDelayDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickAfterDelay_DataServer>(this._entity, out afterDelayDataServer) ? new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickAfterDelay_DataServer?() : new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickAfterDelay_DataServer?(afterDelayDataServer);
      }
    }

    public bool DropItemImpairedBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DropItemImpairedBuff>(this._entity);
    }

    public bool EquipmentImpairedBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.EquipmentImpairedBuff>(this._entity);
    }

    public bool ReviveCancelBuff
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.ReviveCancelBuff>(this._entity);
    }

    public bool DamagedEditableTile
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DamagedEditableTile>(this._entity);
    }

    public ProjectM.Gameplay.Scripting.Script_PreCast_TakeFlight_DataServer? Script_PreCast_TakeFlight_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_PreCast_TakeFlight_DataServer flightDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_PreCast_TakeFlight_DataServer>(this._entity, out flightDataServer) ? new ProjectM.Gameplay.Scripting.Script_PreCast_TakeFlight_DataServer?() : new ProjectM.Gameplay.Scripting.Script_PreCast_TakeFlight_DataServer?(flightDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_DestroyBuffOnNoAbilityCharges_Server? Script_DestroyBuffOnNoAbilityCharges_Server
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_DestroyBuffOnNoAbilityCharges_Server abilityChargesServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_DestroyBuffOnNoAbilityCharges_Server>(this._entity, out abilityChargesServer) ? new ProjectM.Gameplay.Scripting.Script_DestroyBuffOnNoAbilityCharges_Server?() : new ProjectM.Gameplay.Scripting.Script_DestroyBuffOnNoAbilityCharges_Server?(abilityChargesServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_SpawnPrefabOnMiss_DataServer? Script_SpawnPrefabOnMiss_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_SpawnPrefabOnMiss_DataServer onMissDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_SpawnPrefabOnMiss_DataServer>(this._entity, out onMissDataServer) ? new ProjectM.Gameplay.Scripting.Script_SpawnPrefabOnMiss_DataServer?() : new ProjectM.Gameplay.Scripting.Script_SpawnPrefabOnMiss_DataServer?(onMissDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Unholy_RaiseDead_DataServer? Script_Unholy_RaiseDead_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Unholy_RaiseDead_DataServer raiseDeadDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Unholy_RaiseDead_DataServer>(this._entity, out raiseDeadDataServer) ? new ProjectM.Gameplay.Scripting.Script_Unholy_RaiseDead_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Unholy_RaiseDead_DataServer?(raiseDeadDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ModifyBuffResistancesDuringCast_DataServer? Script_ModifyBuffResistancesDuringCast_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ModifyBuffResistancesDuringCast_DataServer duringCastDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ModifyBuffResistancesDuringCast_DataServer>(this._entity, out duringCastDataServer) ? new ProjectM.Gameplay.Scripting.Script_ModifyBuffResistancesDuringCast_DataServer?() : new ProjectM.Gameplay.Scripting.Script_ModifyBuffResistancesDuringCast_DataServer?(duringCastDataServer);
      }
    }

    public bool SiegeWeaponAbsorbCapByServerSettings
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.SiegeWeaponAbsorbCapByServerSettings>(this._entity);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_Stealth_Duration_DataServer? Script_Buff_Stealth_Duration_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_Stealth_Duration_DataServer durationDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_Stealth_Duration_DataServer>(this._entity, out durationDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_Stealth_Duration_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_Stealth_Duration_DataServer?(durationDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_BatformSCT_DataServer? Script_BatformSCT_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_BatformSCT_DataServer batformSctDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_BatformSCT_DataServer>(this._entity, out batformSctDataServer) ? new ProjectM.Gameplay.Scripting.Script_BatformSCT_DataServer?() : new ProjectM.Gameplay.Scripting.Script_BatformSCT_DataServer?(batformSctDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_IgnoresPathfindingLineOfSight_DataServer? Script_Buff_IgnoresPathfindingLineOfSight_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_IgnoresPathfindingLineOfSight_DataServer ofSightDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_IgnoresPathfindingLineOfSight_DataServer>(this._entity, out ofSightDataServer) ? new ProjectM.Gameplay.Scripting.Script_Buff_IgnoresPathfindingLineOfSight_DataServer?() : new ProjectM.Gameplay.Scripting.Script_Buff_IgnoresPathfindingLineOfSight_DataServer?(ofSightDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_Buff_PvPProtection_DataShared? Script_Buff_PvPProtection_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_Buff_PvPProtection_DataShared pprotectionDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_Buff_PvPProtection_DataShared>(this._entity, out pprotectionDataShared) ? new ProjectM.Gameplay.Scripting.Script_Buff_PvPProtection_DataShared?() : new ProjectM.Gameplay.Scripting.Script_Buff_PvPProtection_DataShared?(pprotectionDataShared);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_UnitSpawn_DataServer? Script_UnitSpawn_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_UnitSpawn_DataServer unitSpawnDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_UnitSpawn_DataServer>(this._entity, out unitSpawnDataServer) ? new ProjectM.Gameplay.Scripting.Script_UnitSpawn_DataServer?() : new ProjectM.Gameplay.Scripting.Script_UnitSpawn_DataServer?(unitSpawnDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.LaunchProjectileFromKiller_DataServer? LaunchProjectileFromKiller_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.LaunchProjectileFromKiller_DataServer killerDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.LaunchProjectileFromKiller_DataServer>(this._entity, out killerDataServer) ? new ProjectM.Gameplay.Scripting.LaunchProjectileFromKiller_DataServer?() : new ProjectM.Gameplay.Scripting.LaunchProjectileFromKiller_DataServer?(killerDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.SpiderCocoon_DataShared? SpiderCocoon_DataShared
    {
      get
      {
        ProjectM.Gameplay.Scripting.SpiderCocoon_DataShared cocoonDataShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.SpiderCocoon_DataShared>(this._entity, out cocoonDataShared) ? new ProjectM.Gameplay.Scripting.SpiderCocoon_DataShared?() : new ProjectM.Gameplay.Scripting.SpiderCocoon_DataShared?(cocoonDataShared);
      }
    }

    public List<ProjectM.Gameplay.Scripting.SpiderCocoonSpawns_DataServer> SpiderCocoonSpawns_DataServer
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.SpiderCocoonSpawns_DataServer>(this._entity);
      }
    }

    public ProjectM.MinionMaster? MinionMaster
    {
      get
      {
        ProjectM.MinionMaster minionMaster;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MinionMaster>(this._entity, out minionMaster) ? new ProjectM.MinionMaster?() : new ProjectM.MinionMaster?(minionMaster);
      }
    }

    public ProjectM.VBloodConsumeSource? VBloodConsumeSource
    {
      get
      {
        ProjectM.VBloodConsumeSource vbloodConsumeSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodConsumeSource>(this._entity, out vbloodConsumeSource) ? new ProjectM.VBloodConsumeSource?() : new ProjectM.VBloodConsumeSource?(vbloodConsumeSource);
      }
    }

    public ProjectM.VBloodRewardSequence? VBloodRewardSequence
    {
      get
      {
        ProjectM.VBloodRewardSequence vbloodRewardSequence;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodRewardSequence>(this._entity, out vbloodRewardSequence) ? new ProjectM.VBloodRewardSequence?() : new ProjectM.VBloodRewardSequence?(vbloodRewardSequence);
      }
    }

    public List<MaxMinionsPerPlayerElement> MaxMinionsPerPlayerElements
    {
      get => this._world.EntityManager.GetBufferInternal<MaxMinionsPerPlayerElement>(this._entity);
    }

    public List<VBloodUnlockTechBuffer> VBloodUnlockTechBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<VBloodUnlockTechBuffer>(this._entity);
    }

    public bool Script_SetHealthToOwnerPercentage_DataServer
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.Gameplay.Scripting.Script_SetHealthToOwnerPercentage_DataServer>(this._entity);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholds_DataServer? Script_ApplyBuffUnderThreeHealthThreshholds_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholds_DataServer threshholdsDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>(this._entity, out threshholdsDataServer) ? new ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholds_DataServer?() : new ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholds_DataServer?(threshholdsDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholdsDataCarrier_DataServer? Script_ApplyBuffUnderThreeHealthThreshholdsDataCarrier_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholdsDataCarrier_DataServer carrierDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholdsDataCarrier_DataServer>(this._entity, out carrierDataServer) ? new ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholdsDataCarrier_DataServer?() : new ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholdsDataCarrier_DataServer?(carrierDataServer);
      }
    }

    public ProjectM.Gameplay.Scripting.CastAbilityInStateScript_DataServer? CastAbilityInStateScript_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.CastAbilityInStateScript_DataServer scriptDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.CastAbilityInStateScript_DataServer>(this._entity, out scriptDataServer) ? new ProjectM.Gameplay.Scripting.CastAbilityInStateScript_DataServer?() : new ProjectM.Gameplay.Scripting.CastAbilityInStateScript_DataServer?(scriptDataServer);
      }
    }

    public ProjectM.CanFly? CanFly
    {
      get
      {
        ProjectM.CanFly canFly;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CanFly>(this._entity, out canFly) ? new ProjectM.CanFly?() : new ProjectM.CanFly?(canFly);
      }
    }

    public bool VisibleFromFlight
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.VisibleFromFlight>(this._entity);
    }

    public List<TechUnlockPassiveBuffer> TechUnlockPassiveBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<TechUnlockPassiveBuffer>(this._entity);
    }

    public ProjectM.Blood? Blood
    {
      get
      {
        ProjectM.Blood blood;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Blood>(this._entity, out blood) ? new ProjectM.Blood?() : new ProjectM.Blood?(blood);
      }
    }

    public ProjectM.Equipment? Equipment
    {
      get
      {
        ProjectM.Equipment equipment;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Equipment>(this._entity, out equipment) ? new ProjectM.Equipment?() : new ProjectM.Equipment?(equipment);
      }
    }

    public ProjectM.PlayerCharacter? PlayerCharacter
    {
      get
      {
        ProjectM.PlayerCharacter playerCharacter;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PlayerCharacter>(this._entity, out playerCharacter) ? new ProjectM.PlayerCharacter?() : new ProjectM.PlayerCharacter?(playerCharacter);
      }
    }

    public ProjectM.ReturnToNetherWaypoint? ReturnToNetherWaypoint
    {
      get
      {
        ProjectM.ReturnToNetherWaypoint toNetherWaypoint;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ReturnToNetherWaypoint>(this._entity, out toNetherWaypoint) ? new ProjectM.ReturnToNetherWaypoint?() : new ProjectM.ReturnToNetherWaypoint?(toNetherWaypoint);
      }
    }

    public ProjectM.BloodMoonBuffState? BloodMoonBuffState
    {
      get
      {
        ProjectM.BloodMoonBuffState bloodMoonBuffState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodMoonBuffState>(this._entity, out bloodMoonBuffState) ? new ProjectM.BloodMoonBuffState?() : new ProjectM.BloodMoonBuffState?(bloodMoonBuffState);
      }
    }

    public ProjectM.Mounter? Mounter
    {
      get
      {
        ProjectM.Mounter mounter;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Mounter>(this._entity, out mounter) ? new ProjectM.Mounter?() : new ProjectM.Mounter?(mounter);
      }
    }

    public ProjectM.Resident? Resident
    {
      get
      {
        ProjectM.Resident resident;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Resident>(this._entity, out resident) ? new ProjectM.Resident?() : new ProjectM.Resident?(resident);
      }
    }

    public ProjectM.TakeDamageInSun? TakeDamageInSun
    {
      get
      {
        ProjectM.TakeDamageInSun takeDamageInSun;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TakeDamageInSun>(this._entity, out takeDamageInSun) ? new ProjectM.TakeDamageInSun?() : new ProjectM.TakeDamageInSun?(takeDamageInSun);
      }
    }

    public ProjectM.TakeDamageInSunDebuffState? TakeDamageInSunDebuffState
    {
      get
      {
        ProjectM.TakeDamageInSunDebuffState inSunDebuffState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TakeDamageInSunDebuffState>(this._entity, out inSunDebuffState) ? new ProjectM.TakeDamageInSunDebuffState?() : new ProjectM.TakeDamageInSunDebuffState?(inSunDebuffState);
      }
    }

    public ProjectM.Interactor? Interactor
    {
      get
      {
        ProjectM.Interactor interactor;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Interactor>(this._entity, out interactor) ? new ProjectM.Interactor?() : new ProjectM.Interactor?(interactor);
      }
    }

    public ProjectM.RespawnCharacter? RespawnCharacter
    {
      get
      {
        ProjectM.RespawnCharacter respawnCharacter;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RespawnCharacter>(this._entity, out respawnCharacter) ? new ProjectM.RespawnCharacter?() : new ProjectM.RespawnCharacter?(respawnCharacter);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer? Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer categoryDataServer;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>(this._entity, out categoryDataServer) ? new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer?() : new ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer?(categoryDataServer);
      }
    }

    public ProjectM.CustomizationFeatures? CustomizationFeatures
    {
      get
      {
        ProjectM.CustomizationFeatures customizationFeatures;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CustomizationFeatures>(this._entity, out customizationFeatures) ? new ProjectM.CustomizationFeatures?() : new ProjectM.CustomizationFeatures?(customizationFeatures);
      }
    }

    public ProjectM.Energy? Energy
    {
      get
      {
        ProjectM.Energy energy;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Energy>(this._entity, out energy) ? new ProjectM.Energy?() : new ProjectM.Energy?(energy);
      }
    }

    public ProjectM.PavementBonus? PavementBonus
    {
      get
      {
        ProjectM.PavementBonus pavementBonus;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PavementBonus>(this._entity, out pavementBonus) ? new ProjectM.PavementBonus?() : new ProjectM.PavementBonus?(pavementBonus);
      }
    }

    public ProjectM.VBloodAbilityOwnerData? VBloodAbilityOwnerData
    {
      get
      {
        ProjectM.VBloodAbilityOwnerData abilityOwnerData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodAbilityOwnerData>(this._entity, out abilityOwnerData) ? new ProjectM.VBloodAbilityOwnerData?() : new ProjectM.VBloodAbilityOwnerData?(abilityOwnerData);
      }
    }

    public ProjectM.BloodMoonBuff? BloodMoonBuff
    {
      get
      {
        ProjectM.BloodMoonBuff bloodMoonBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.BloodMoonBuff>(this._entity, out bloodMoonBuff) ? new ProjectM.BloodMoonBuff?() : new ProjectM.BloodMoonBuff?(bloodMoonBuff);
      }
    }

    public ProjectM.LifeLeech? LifeLeech
    {
      get
      {
        ProjectM.LifeLeech lifeLeech;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.LifeLeech>(this._entity, out lifeLeech) ? new ProjectM.LifeLeech?() : new ProjectM.LifeLeech?(lifeLeech);
      }
    }

    public ProjectM.CombatMusicListener_Shared? CombatMusicListener_Shared
    {
      get
      {
        ProjectM.CombatMusicListener_Shared musicListenerShared;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CombatMusicListener_Shared>(this._entity, out musicListenerShared) ? new ProjectM.CombatMusicListener_Shared?() : new ProjectM.CombatMusicListener_Shared?(musicListenerShared);
      }
    }

    public ProjectM.JumpFromCliffs? JumpFromCliffs
    {
      get
      {
        ProjectM.JumpFromCliffs jumpFromCliffs;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.JumpFromCliffs>(this._entity, out jumpFromCliffs) ? new ProjectM.JumpFromCliffs?() : new ProjectM.JumpFromCliffs?(jumpFromCliffs);
      }
    }

    public ProjectM.CharacterVoiceActivity? CharacterVoiceActivity
    {
      get
      {
        ProjectM.CharacterVoiceActivity characterVoiceActivity;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CharacterVoiceActivity>(this._entity, out characterVoiceActivity) ? new ProjectM.CharacterVoiceActivity?() : new ProjectM.CharacterVoiceActivity?(characterVoiceActivity);
      }
    }

    public ProjectM.Tiles.RestrictPlacementArea? RestrictPlacementArea
    {
      get
      {
        ProjectM.Tiles.RestrictPlacementArea restrictPlacementArea;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Tiles.RestrictPlacementArea>(this._entity, out restrictPlacementArea) ? new ProjectM.Tiles.RestrictPlacementArea?() : new ProjectM.Tiles.RestrictPlacementArea?(restrictPlacementArea);
      }
    }

    public List<FollowerBuffer> FollowerBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<FollowerBuffer>(this._entity);
    }

    public List<VBloodAbilityBuffEntry> VBloodAbilityBuffEntries
    {
      get => this._world.EntityManager.GetBufferInternal<VBloodAbilityBuffEntry>(this._entity);
    }

    public List<ProjectM.CombatMusicListener_SourceElement> CombatMusicListener_SourceElement
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.CombatMusicListener_SourceElement>(this._entity);
      }
    }

    public List<EquipmentSetBuff> EquipmentSetBuffs
    {
      get => this._world.EntityManager.GetBufferInternal<EquipmentSetBuff>(this._entity);
    }

    public List<BloodQualityBuff> BloodQualityBuffs
    {
      get => this._world.EntityManager.GetBufferInternal<BloodQualityBuff>(this._entity);
    }

    public List<BuffByItemCategoryCount> BuffByItemCategoryCounts
    {
      get => this._world.EntityManager.GetBufferInternal<BuffByItemCategoryCount>(this._entity);
    }

    public List<BuffOnConnectionStatusElement> BuffOnConnectionStatusElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<BuffOnConnectionStatusElement>(this._entity);
      }
    }

    public bool RadialDamageTarget
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.RadialDamageTarget>(this._entity);
    }

    public bool VampireTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.VampireTag>(this._entity);
    }

    public Unity.Physics.PhysicsMass? PhysicsMass
    {
      get
      {
        Unity.Physics.PhysicsMass physicsMass;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Physics.PhysicsMass>(this._entity, out physicsMass) ? new Unity.Physics.PhysicsMass?() : new Unity.Physics.PhysicsMass?(physicsMass);
      }
    }

    public Unity.Physics.PhysicsVelocity? PhysicsVelocity
    {
      get
      {
        Unity.Physics.PhysicsVelocity physicsVelocity;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Physics.PhysicsVelocity>(this._entity, out physicsVelocity) ? new Unity.Physics.PhysicsVelocity?() : new Unity.Physics.PhysicsVelocity?(physicsVelocity);
      }
    }

    public Unity.Physics.PhysicsDamping? PhysicsDamping
    {
      get
      {
        Unity.Physics.PhysicsDamping physicsDamping;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Physics.PhysicsDamping>(this._entity, out physicsDamping) ? new Unity.Physics.PhysicsDamping?() : new Unity.Physics.PhysicsDamping?(physicsDamping);
      }
    }

    public Unity.Physics.PhysicsGravityFactor? PhysicsGravityFactor
    {
      get
      {
        Unity.Physics.PhysicsGravityFactor physicsGravityFactor;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Physics.PhysicsGravityFactor>(this._entity, out physicsGravityFactor) ? new Unity.Physics.PhysicsGravityFactor?() : new Unity.Physics.PhysicsGravityFactor?(physicsGravityFactor);
      }
    }

    public ProjectM.Physics.PhysicsRubble? PhysicsRubble
    {
      get
      {
        ProjectM.Physics.PhysicsRubble physicsRubble;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Physics.PhysicsRubble>(this._entity, out physicsRubble) ? new ProjectM.Physics.PhysicsRubble?() : new ProjectM.Physics.PhysicsRubble?(physicsRubble);
      }
    }

    public ProjectM.DestroyAfterTimeOnInventoryChange? DestroyAfterTimeOnInventoryChange
    {
      get
      {
        ProjectM.DestroyAfterTimeOnInventoryChange onInventoryChange;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DestroyAfterTimeOnInventoryChange>(this._entity, out onInventoryChange) ? new ProjectM.DestroyAfterTimeOnInventoryChange?() : new ProjectM.DestroyAfterTimeOnInventoryChange?(onInventoryChange);
      }
    }

    public ProjectM.DropInInventoryOnSpawn? DropInInventoryOnSpawn
    {
      get
      {
        ProjectM.DropInInventoryOnSpawn inventoryOnSpawn;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DropInInventoryOnSpawn>(this._entity, out inventoryOnSpawn) ? new ProjectM.DropInInventoryOnSpawn?() : new ProjectM.DropInInventoryOnSpawn?(inventoryOnSpawn);
      }
    }

    public ProjectM.TransitionWhenInventoryIsEmpty? TransitionWhenInventoryIsEmpty
    {
      get
      {
        ProjectM.TransitionWhenInventoryIsEmpty inventoryIsEmpty;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TransitionWhenInventoryIsEmpty>(this._entity, out inventoryIsEmpty) ? new ProjectM.TransitionWhenInventoryIsEmpty?() : new ProjectM.TransitionWhenInventoryIsEmpty?(inventoryIsEmpty);
      }
    }

    public UnitUptimeSetting UnitUptimeSetting
    {
      get
      {
        UnitUptimeSetting unitUptimeSetting;
        return !this._world.EntityManager.TryGetComponentDataInternal<UnitUptimeSetting>(this._entity, out unitUptimeSetting) ? new UnitUptimeSetting() : unitUptimeSetting;
      }
    }

    public RandomizedSpawnChainSettings RandomizedSpawnChainSettings
    {
      get
      {
        RandomizedSpawnChainSettings spawnChainSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<RandomizedSpawnChainSettings>(this._entity, out spawnChainSettings) ? new RandomizedSpawnChainSettings() : spawnChainSettings;
      }
    }

    public ProjectM.Roofs.RoofCategory? RoofCategory
    {
      get
      {
        ProjectM.Roofs.RoofCategory roofCategory;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Roofs.RoofCategory>(this._entity, out roofCategory) ? new ProjectM.Roofs.RoofCategory?() : new ProjectM.Roofs.RoofCategory?(roofCategory);
      }
    }

    public List<RoofRootBlobElement> RoofRootBlobElements
    {
      get => this._world.EntityManager.GetBufferInternal<RoofRootBlobElement>(this._entity);
    }

    public List<ProjectM.Roofs.RoofTileVariations> RoofTileVariations
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.Roofs.RoofTileVariations>(this._entity);
    }

    public ProjectM.ChunkPortal? ChunkPortal
    {
      get
      {
        ProjectM.ChunkPortal chunkPortal;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ChunkPortal>(this._entity, out chunkPortal) ? new ProjectM.ChunkPortal?() : new ProjectM.ChunkPortal?(chunkPortal);
      }
    }

    public ProjectM.CastleBuilding.CastleRoof? CastleRoof
    {
      get
      {
        ProjectM.CastleBuilding.CastleRoof castleRoof;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleRoof>(this._entity, out castleRoof) ? new ProjectM.CastleBuilding.CastleRoof?() : new ProjectM.CastleBuilding.CastleRoof?(castleRoof);
      }
    }

    public ProjectM.CastleBuilding.CastleRoofOrnaments? CastleRoofOrnaments
    {
      get
      {
        ProjectM.CastleBuilding.CastleRoofOrnaments castleRoofOrnaments;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleRoofOrnaments>(this._entity, out castleRoofOrnaments) ? new ProjectM.CastleBuilding.CastleRoofOrnaments?() : new ProjectM.CastleBuilding.CastleRoofOrnaments?(castleRoofOrnaments);
      }
    }

    public ProjectM.Roofs.RoofTileData? RoofTileData
    {
      get
      {
        ProjectM.Roofs.RoofTileData roofTileData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Roofs.RoofTileData>(this._entity, out roofTileData) ? new ProjectM.Roofs.RoofTileData?() : new ProjectM.Roofs.RoofTileData?(roofTileData);
      }
    }

    public ProjectM.Roofs.RoofInstanceTypeId? RoofInstanceTypeId
    {
      get
      {
        ProjectM.Roofs.RoofInstanceTypeId roofInstanceTypeId;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Roofs.RoofInstanceTypeId>(this._entity, out roofInstanceTypeId) ? new ProjectM.Roofs.RoofInstanceTypeId?() : new ProjectM.Roofs.RoofInstanceTypeId?(roofInstanceTypeId);
      }
    }

    public ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_Data? Script_StealthBush_Environment_Data
    {
      get
      {
        ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_Data bushEnvironmentData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_Data>(this._entity, out bushEnvironmentData) ? new ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_Data?() : new ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_Data?(bushEnvironmentData);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_ActiveStealths> Script_StealthBush_Environment_ActiveStealths
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_ActiveStealths>(this._entity);
      }
    }

    public List<ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_HitSpheres> Script_StealthBush_Environment_HitSpheres
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_HitSpheres>(this._entity);
      }
    }

    public ProjectM.Gameplay.Script_InspectTarget_Data? Script_InspectTarget_Data
    {
      get
      {
        ProjectM.Gameplay.Script_InspectTarget_Data inspectTargetData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Script_InspectTarget_Data>(this._entity, out inspectTargetData) ? new ProjectM.Gameplay.Script_InspectTarget_Data?() : new ProjectM.Gameplay.Script_InspectTarget_Data?(inspectTargetData);
      }
    }

    public ProjectM.ServantMissionSettingsSingleton? ServantMissionSettingsSingleton
    {
      get
      {
        ProjectM.ServantMissionSettingsSingleton settingsSingleton;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServantMissionSettingsSingleton>(this._entity, out settingsSingleton) ? new ProjectM.ServantMissionSettingsSingleton?() : new ProjectM.ServantMissionSettingsSingleton?(settingsSingleton);
      }
    }

    public List<ServantMissionSetting> ServantMissionSettings
    {
      get => this._world.EntityManager.GetBufferInternal<ServantMissionSetting>(this._entity);
    }

    public List<ServantInjuredChance> ServantInjuredChances
    {
      get => this._world.EntityManager.GetBufferInternal<ServantInjuredChance>(this._entity);
    }

    public List<ServantBloodTypePerkElement> ServantBloodTypePerkElements
    {
      get => this._world.EntityManager.GetBufferInternal<ServantBloodTypePerkElement>(this._entity);
    }

    public List<ServantFactionPerkElement> ServantFactionPerkElements
    {
      get => this._world.EntityManager.GetBufferInternal<ServantFactionPerkElement>(this._entity);
    }

    public bool ServantPerkCollectionSingleton
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.ServantPerkCollectionSingleton>(this._entity);
      }
    }

    public Unity.Physics.PhysicsConstrainedBodyPair? PhysicsConstrainedBodyPair
    {
      get
      {
        Unity.Physics.PhysicsConstrainedBodyPair constrainedBodyPair;
        return !this._world.EntityManager.TryGetComponentDataInternal<Unity.Physics.PhysicsConstrainedBodyPair>(this._entity, out constrainedBodyPair) ? new Unity.Physics.PhysicsConstrainedBodyPair?() : new Unity.Physics.PhysicsConstrainedBodyPair?(constrainedBodyPair);
      }
    }

    public PhysicsJoint PhysicsJoint
    {
      get
      {
        PhysicsJoint physicsJoint;
        return !this._world.EntityManager.TryGetComponentDataInternal<PhysicsJoint>(this._entity, out physicsJoint) ? new PhysicsJoint() : physicsJoint;
      }
    }

    public List<PhysicsJointCompanion> PhysicsJointCompanions
    {
      get => this._world.EntityManager.GetBufferInternal<PhysicsJointCompanion>(this._entity);
    }

    public ProjectM.CastleDestroyData? CastleDestroyData
    {
      get
      {
        ProjectM.CastleDestroyData castleDestroyData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleDestroyData>(this._entity, out castleDestroyData) ? new ProjectM.CastleDestroyData?() : new ProjectM.CastleDestroyData?(castleDestroyData);
      }
    }

    public List<CastleDestroyRequirementBuffer> CastleDestroyRequirementBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CastleDestroyRequirementBuffer>(this._entity);
      }
    }

    public ProjectM.CastleClaimData? CastleClaimData
    {
      get
      {
        ProjectM.CastleClaimData castleClaimData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleClaimData>(this._entity, out castleClaimData) ? new ProjectM.CastleClaimData?() : new ProjectM.CastleClaimData?(castleClaimData);
      }
    }

    public List<CastleClaimRequirementBuffer> CastleClaimRequirementBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CastleClaimRequirementBuffer>(this._entity);
      }
    }

    public ProjectM.CharacterCustomizationSettingsComponent? CharacterCustomizationSettingsComponent
    {
      get
      {
        ProjectM.CharacterCustomizationSettingsComponent settingsComponent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CharacterCustomizationSettingsComponent>(this._entity, out settingsComponent) ? new ProjectM.CharacterCustomizationSettingsComponent?() : new ProjectM.CharacterCustomizationSettingsComponent?(settingsComponent);
      }
    }

    public List<MaleFacesEntry> MaleFacesEntries
    {
      get => this._world.EntityManager.GetBufferInternal<MaleFacesEntry>(this._entity);
    }

    public List<MaleHairsEntry> MaleHairsEntries
    {
      get => this._world.EntityManager.GetBufferInternal<MaleHairsEntry>(this._entity);
    }

    public List<MaleFeaturesEntry> MaleFeaturesEntries
    {
      get => this._world.EntityManager.GetBufferInternal<MaleFeaturesEntry>(this._entity);
    }

    public List<MaleAccessoriesEntry> MaleAccessoriesEntries
    {
      get => this._world.EntityManager.GetBufferInternal<MaleAccessoriesEntry>(this._entity);
    }

    public List<FemaleFacesEntry> FemaleFacesEntries
    {
      get => this._world.EntityManager.GetBufferInternal<FemaleFacesEntry>(this._entity);
    }

    public List<FemaleHairsEntry> FemaleHairsEntries
    {
      get => this._world.EntityManager.GetBufferInternal<FemaleHairsEntry>(this._entity);
    }

    public List<FemaleFeaturesEntry> FemaleFeaturesEntries
    {
      get => this._world.EntityManager.GetBufferInternal<FemaleFeaturesEntry>(this._entity);
    }

    public List<FemaleAccessoriesEntry> FemaleAccessoriesEntries
    {
      get => this._world.EntityManager.GetBufferInternal<FemaleAccessoriesEntry>(this._entity);
    }

    public List<PrefabSetBuffer> PrefabSetBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<PrefabSetBuffer>(this._entity);
    }

    public List<PrefabSetSourceObjectBuffer> PrefabSetSourceObjectBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<PrefabSetSourceObjectBuffer>(this._entity);
    }

    public ProjectM.GeneralGameplayCollection? GeneralGameplayCollection
    {
      get
      {
        ProjectM.GeneralGameplayCollection gameplayCollection;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GeneralGameplayCollection>(this._entity, out gameplayCollection) ? new ProjectM.GeneralGameplayCollection?() : new ProjectM.GeneralGameplayCollection?(gameplayCollection);
      }
    }

    public ProjectM.DropTableData? DropTableData
    {
      get
      {
        ProjectM.DropTableData dropTableData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DropTableData>(this._entity, out dropTableData) ? new ProjectM.DropTableData?() : new ProjectM.DropTableData?(dropTableData);
      }
    }

    public List<DropTableDataBuffer> DropTableDataBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<DropTableDataBuffer>(this._entity);
    }

    public List<ProjectM.UI.UnitBloodTypeBuffs> UnitBloodTypeBuffs
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.UI.UnitBloodTypeBuffs>(this._entity);
    }

    public ProjectM.Gameplay.Clan.ClanSystemSettingsComponent? ClanSystemSettingsComponent
    {
      get
      {
        ProjectM.Gameplay.Clan.ClanSystemSettingsComponent settingsComponent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Gameplay.Clan.ClanSystemSettingsComponent>(this._entity, out settingsComponent) ? new ProjectM.Gameplay.Clan.ClanSystemSettingsComponent?() : new ProjectM.Gameplay.Clan.ClanSystemSettingsComponent?(settingsComponent);
      }
    }

    public ProjectM.PerkData? PerkData
    {
      get
      {
        ProjectM.PerkData perkData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PerkData>(this._entity, out perkData) ? new ProjectM.PerkData?() : new ProjectM.PerkData?(perkData);
      }
    }

    public ProjectM.DayTimeSpan? DayTimeSpan
    {
      get
      {
        ProjectM.DayTimeSpan dayTimeSpan;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DayTimeSpan>(this._entity, out dayTimeSpan) ? new ProjectM.DayTimeSpan?() : new ProjectM.DayTimeSpan?(dayTimeSpan);
      }
    }

    public ProjectM.MissionData? MissionData
    {
      get
      {
        ProjectM.MissionData missionData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MissionData>(this._entity, out missionData) ? new ProjectM.MissionData?() : new ProjectM.MissionData?(missionData);
      }
    }

    public ProjectM.RecipeData? RecipeData
    {
      get
      {
        ProjectM.RecipeData recipeData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RecipeData>(this._entity, out recipeData) ? new ProjectM.RecipeData?() : new ProjectM.RecipeData?(recipeData);
      }
    }

    public List<RecipeOutputBuffer> RecipeOutputBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<RecipeOutputBuffer>(this._entity);
    }

    public List<RecipeOutputUnitBuffer> RecipeOutputUnitBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<RecipeOutputUnitBuffer>(this._entity);
    }

    public List<LifeLeechSetting> LifeLeechSettings
    {
      get => this._world.EntityManager.GetBufferInternal<LifeLeechSetting>(this._entity);
    }

    public List<ImpactMaterialMappingBuffer> ImpactMaterialMappingBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<ImpactMaterialMappingBuffer>(this._entity);
    }

    public List<ProjectM.EquipmentSetElements> EquipmentSetElements
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.EquipmentSetElements>(this._entity);
    }

    public List<EquipmentSet> EquipmentSets
    {
      get => this._world.EntityManager.GetBufferInternal<EquipmentSet>(this._entity);
    }

    public ProjectM.JournalTooltip? JournalTooltip
    {
      get
      {
        ProjectM.JournalTooltip journalTooltip;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.JournalTooltip>(this._entity, out journalTooltip) ? new ProjectM.JournalTooltip?() : new ProjectM.JournalTooltip?(journalTooltip);
      }
    }

    public ProjectM.UpgradeData? UpgradeData
    {
      get
      {
        ProjectM.UpgradeData upgradeData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UpgradeData>(this._entity, out upgradeData) ? new ProjectM.UpgradeData?() : new ProjectM.UpgradeData?(upgradeData);
      }
    }

    public List<UpgradeRequirementBuffer> UpgradeRequirementBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<UpgradeRequirementBuffer>(this._entity);
    }

    public ProjectM.ItemDataDropGroup? ItemDataDropGroup
    {
      get
      {
        ProjectM.ItemDataDropGroup itemDataDropGroup;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ItemDataDropGroup>(this._entity, out itemDataDropGroup) ? new ProjectM.ItemDataDropGroup?() : new ProjectM.ItemDataDropGroup?(itemDataDropGroup);
      }
    }

    public List<ItemDataDropGroupBuffer> ItemDataDropGroupBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<ItemDataDropGroupBuffer>(this._entity);
    }

    public List<ItemRepairBuffer> ItemRepairBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<ItemRepairBuffer>(this._entity);
    }

    public ProjectM.TechData? TechData
    {
      get
      {
        ProjectM.TechData techData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TechData>(this._entity, out techData) ? new ProjectM.TechData?() : new ProjectM.TechData?(techData);
      }
    }

    public List<TechUnlockAbilityBuffer> TechUnlockAbilityBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<TechUnlockAbilityBuffer>(this._entity);
    }

    public List<TechUnlockRecipeBuffer> TechUnlockRecipeBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<TechUnlockRecipeBuffer>(this._entity);
    }

    public List<TechUnlockBlueprintBuffer> TechUnlockBlueprintBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<TechUnlockBlueprintBuffer>(this._entity);
    }

    public List<TechRequirementBuffer> TechRequirementBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<TechRequirementBuffer>(this._entity);
    }

    public List<TechItemRequirementBuffer> TechItemRequirementBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<TechItemRequirementBuffer>(this._entity);
    }

    public ProjectM.SCTTypeCollection? SCTTypeCollection
    {
      get
      {
        ProjectM.SCTTypeCollection sctTypeCollection;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SCTTypeCollection>(this._entity, out sctTypeCollection) ? new ProjectM.SCTTypeCollection?() : new ProjectM.SCTTypeCollection?(sctTypeCollection);
      }
    }

    public ProjectM.RagdollSourceSetting? RagdollSourceSetting
    {
      get
      {
        ProjectM.RagdollSourceSetting ragdollSourceSetting;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RagdollSourceSetting>(this._entity, out ragdollSourceSetting) ? new ProjectM.RagdollSourceSetting?() : new ProjectM.RagdollSourceSetting?(ragdollSourceSetting);
      }
    }

    public List<UnitStatsSettingsElement> UnitStatsSettingsElements
    {
      get => this._world.EntityManager.GetBufferInternal<UnitStatsSettingsElement>(this._entity);
    }

    public List<BuffResistanceElement> BuffResistanceElements
    {
      get => this._world.EntityManager.GetBufferInternal<BuffResistanceElement>(this._entity);
    }

    public Faction Faction
    {
      get
      {
        Faction faction;
        return !this._world.EntityManager.TryGetComponentDataInternal<Faction>(this._entity, out faction) ? new Faction() : faction;
      }
    }

    public ProjectM.HealingBuff? HealingBuff
    {
      get
      {
        ProjectM.HealingBuff healingBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.HealingBuff>(this._entity, out healingBuff) ? new ProjectM.HealingBuff?() : new ProjectM.HealingBuff?(healingBuff);
      }
    }

    public ProjectM.MiscItemLevel? MiscItemLevel
    {
      get
      {
        ProjectM.MiscItemLevel miscItemLevel;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.MiscItemLevel>(this._entity, out miscItemLevel) ? new ProjectM.MiscItemLevel?() : new ProjectM.MiscItemLevel?(miscItemLevel);
      }
    }

    public ProjectM.RepairData? RepairData
    {
      get
      {
        ProjectM.RepairData repairData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RepairData>(this._entity, out repairData) ? new ProjectM.RepairData?() : new ProjectM.RepairData?(repairData);
      }
    }

    public ProjectM.CastleBuffsSettings? CastleBuffsSettings
    {
      get
      {
        ProjectM.CastleBuffsSettings castleBuffsSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuffsSettings>(this._entity, out castleBuffsSettings) ? new ProjectM.CastleBuffsSettings?() : new ProjectM.CastleBuffsSettings?(castleBuffsSettings);
      }
    }

    public List<ProjectM.HybridCameraFrustumPlanes> HybridCameraFrustumPlanes
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.HybridCameraFrustumPlanes>(this._entity);
    }

    public ProjectM.AchievementSubTaskData? AchievementSubTaskData
    {
      get
      {
        ProjectM.AchievementSubTaskData achievementSubTaskData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AchievementSubTaskData>(this._entity, out achievementSubTaskData) ? new ProjectM.AchievementSubTaskData?() : new ProjectM.AchievementSubTaskData?(achievementSubTaskData);
      }
    }

    public ProjectM.AchievementData? AchievementData
    {
      get
      {
        ProjectM.AchievementData achievementData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AchievementData>(this._entity, out achievementData) ? new ProjectM.AchievementData?() : new ProjectM.AchievementData?(achievementData);
      }
    }

    public List<AchievementSubTaskEntry> AchievementSubTaskEntries
    {
      get => this._world.EntityManager.GetBufferInternal<AchievementSubTaskEntry>(this._entity);
    }

    public ProjectM.StationBonusData? StationBonusData
    {
      get
      {
        ProjectM.StationBonusData stationBonusData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StationBonusData>(this._entity, out stationBonusData) ? new ProjectM.StationBonusData?() : new ProjectM.StationBonusData?(stationBonusData);
      }
    }

    public List<UserMapZonePackedRevealElement> UserMapZonePackedRevealElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<UserMapZonePackedRevealElement>(this._entity);
      }
    }

    public ProjectM.StoredBlood? StoredBlood
    {
      get
      {
        ProjectM.StoredBlood storedBlood;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StoredBlood>(this._entity, out storedBlood) ? new ProjectM.StoredBlood?() : new ProjectM.StoredBlood?(storedBlood);
      }
    }

    public ProjectM.ProgressAchievementOnItemGain? ProgressAchievementOnItemGain
    {
      get
      {
        ProjectM.ProgressAchievementOnItemGain achievementOnItemGain;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ProgressAchievementOnItemGain>(this._entity, out achievementOnItemGain) ? new ProjectM.ProgressAchievementOnItemGain?() : new ProjectM.ProgressAchievementOnItemGain?(achievementOnItemGain);
      }
    }

    public ProjectM.SpellLevelSource? SpellLevelSource
    {
      get
      {
        ProjectM.SpellLevelSource spellLevelSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpellLevelSource>(this._entity, out spellLevelSource) ? new ProjectM.SpellLevelSource?() : new ProjectM.SpellLevelSource?(spellLevelSource);
      }
    }

    public ProjectM.GiveAchievementOnItemCraft? GiveAchievementOnItemCraft
    {
      get
      {
        ProjectM.GiveAchievementOnItemCraft achievementOnItemCraft;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GiveAchievementOnItemCraft>(this._entity, out achievementOnItemCraft) ? new ProjectM.GiveAchievementOnItemCraft?() : new ProjectM.GiveAchievementOnItemCraft?(achievementOnItemCraft);
      }
    }

    public ProjectM.WaypointMapIcon? WaypointMapIcon
    {
      get
      {
        ProjectM.WaypointMapIcon waypointMapIcon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.WaypointMapIcon>(this._entity, out waypointMapIcon) ? new ProjectM.WaypointMapIcon?() : new ProjectM.WaypointMapIcon?(waypointMapIcon);
      }
    }

    public ProjectM.CastleBuilding.CastleRoom? CastleRoom
    {
      get
      {
        ProjectM.CastleBuilding.CastleRoom castleRoom;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.CastleBuilding.CastleRoom>(this._entity, out castleRoom) ? new ProjectM.CastleBuilding.CastleRoom?() : new ProjectM.CastleBuilding.CastleRoom?(castleRoom);
      }
    }

    public List<CastleRoomFloorsBuffer> CastleRoomFloorsBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<CastleRoomFloorsBuffer>(this._entity);
    }

    public List<CastleRoomWallsBuffer> CastleRoomWallsBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<CastleRoomWallsBuffer>(this._entity);
    }

    public List<CastleRoomWorkstationsBuffer> CastleRoomWorkstationsBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<CastleRoomWorkstationsBuffer>(this._entity);
      }
    }

    public ProjectM.ServerDebugLogs? ServerDebugLogs
    {
      get
      {
        ProjectM.ServerDebugLogs serverDebugLogs;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServerDebugLogs>(this._entity, out serverDebugLogs) ? new ProjectM.ServerDebugLogs?() : new ProjectM.ServerDebugLogs?(serverDebugLogs);
      }
    }

    public ProjectM.ServerTime? ServerTime
    {
      get
      {
        ProjectM.ServerTime serverTime;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServerTime>(this._entity, out serverTime) ? new ProjectM.ServerTime?() : new ProjectM.ServerTime?(serverTime);
      }
    }

    public ProjectM.VBloodProgressionUnlockData? VBloodProgressionUnlockData
    {
      get
      {
        ProjectM.VBloodProgressionUnlockData progressionUnlockData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodProgressionUnlockData>(this._entity, out progressionUnlockData) ? new ProjectM.VBloodProgressionUnlockData?() : new ProjectM.VBloodProgressionUnlockData?(progressionUnlockData);
      }
    }

    public List<UnlockedProgressionElement> UnlockedProgressionElements
    {
      get => this._world.EntityManager.GetBufferInternal<UnlockedProgressionElement>(this._entity);
    }

    public List<DiscoveredMapZoneElement> DiscoveredMapZoneElements
    {
      get => this._world.EntityManager.GetBufferInternal<DiscoveredMapZoneElement>(this._entity);
    }

    public List<UnlockedShapeshiftElement> UnlockedShapeshiftElements
    {
      get => this._world.EntityManager.GetBufferInternal<UnlockedShapeshiftElement>(this._entity);
    }

    public List<UnlockedRecipeElement> UnlockedRecipeElements
    {
      get => this._world.EntityManager.GetBufferInternal<UnlockedRecipeElement>(this._entity);
    }

    public List<UnlockedBlueprintElement> UnlockedBlueprintElements
    {
      get => this._world.EntityManager.GetBufferInternal<UnlockedBlueprintElement>(this._entity);
    }

    public List<UnlockedPassiveElement> UnlockedPassiveElements
    {
      get => this._world.EntityManager.GetBufferInternal<UnlockedPassiveElement>(this._entity);
    }

    public List<UnlockedAbilityElement> UnlockedAbilityElements
    {
      get => this._world.EntityManager.GetBufferInternal<UnlockedAbilityElement>(this._entity);
    }

    public List<UnlockedVBlood> UnlockedVBloods
    {
      get => this._world.EntityManager.GetBufferInternal<UnlockedVBlood>(this._entity);
    }

    public bool UpdateAgeWhenDisabled
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.UpdateAgeWhenDisabled>(this._entity);
    }

    public bool UpdateLifeTimeWhenDisabled
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.UpdateLifeTimeWhenDisabled>(this._entity);
      }
    }

    public ProjectM.DealDamageToPrisoner? DealDamageToPrisoner
    {
      get
      {
        ProjectM.DealDamageToPrisoner damageToPrisoner;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DealDamageToPrisoner>(this._entity, out damageToPrisoner) ? new ProjectM.DealDamageToPrisoner?() : new ProjectM.DealDamageToPrisoner?(damageToPrisoner);
      }
    }

    public ProjectM.Network.InputCommandData? InputCommandData
    {
      get
      {
        ProjectM.Network.InputCommandData inputCommandData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.InputCommandData>(this._entity, out inputCommandData) ? new ProjectM.Network.InputCommandData?() : new ProjectM.Network.InputCommandData?(inputCommandData);
      }
    }

    public ProjectM.Network.InputCommandState? InputCommandState
    {
      get
      {
        ProjectM.Network.InputCommandState inputCommandState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.InputCommandState>(this._entity, out inputCommandState) ? new ProjectM.Network.InputCommandState?() : new ProjectM.Network.InputCommandState?(inputCommandState);
      }
    }

    public ProjectM.JumpFromCliffsTravelBuff? JumpFromCliffsTravelBuff
    {
      get
      {
        ProjectM.JumpFromCliffsTravelBuff cliffsTravelBuff;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.JumpFromCliffsTravelBuff>(this._entity, out cliffsTravelBuff) ? new ProjectM.JumpFromCliffsTravelBuff?() : new ProjectM.JumpFromCliffsTravelBuff?(cliffsTravelBuff);
      }
    }

    public ProjectM.ArmorLevelSource? ArmorLevelSource
    {
      get
      {
        ProjectM.ArmorLevelSource armorLevelSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ArmorLevelSource>(this._entity, out armorLevelSource) ? new ProjectM.ArmorLevelSource?() : new ProjectM.ArmorLevelSource?(armorLevelSource);
      }
    }

    public ProjectM.RelicSpawnBoundMapIcon? RelicSpawnBoundMapIcon
    {
      get
      {
        ProjectM.RelicSpawnBoundMapIcon spawnBoundMapIcon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RelicSpawnBoundMapIcon>(this._entity, out spawnBoundMapIcon) ? new ProjectM.RelicSpawnBoundMapIcon?() : new ProjectM.RelicSpawnBoundMapIcon?(spawnBoundMapIcon);
      }
    }

    public ProjectM.SpawnLocationSelector? SpawnLocationSelector
    {
      get
      {
        ProjectM.SpawnLocationSelector locationSelector;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnLocationSelector>(this._entity, out locationSelector) ? new ProjectM.SpawnLocationSelector?() : new ProjectM.SpawnLocationSelector?(locationSelector);
      }
    }

    public bool NetworkedSequence
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.NetworkedSequence>(this._entity);
    }

    public ProjectM.StartGraveyardMapIcon? StartGraveyardMapIcon
    {
      get
      {
        ProjectM.StartGraveyardMapIcon graveyardMapIcon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StartGraveyardMapIcon>(this._entity, out graveyardMapIcon) ? new ProjectM.StartGraveyardMapIcon?() : new ProjectM.StartGraveyardMapIcon?(graveyardMapIcon);
      }
    }

    public ProjectM.PlayerMapIcon? PlayerMapIcon
    {
      get
      {
        ProjectM.PlayerMapIcon playerMapIcon;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PlayerMapIcon>(this._entity, out playerMapIcon) ? new ProjectM.PlayerMapIcon?() : new ProjectM.PlayerMapIcon?(playerMapIcon);
      }
    }

    public bool RelicMapIcon
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.RelicMapIcon>(this._entity);
    }

    public ProjectM.VBloodItemSource? VBloodItemSource
    {
      get
      {
        ProjectM.VBloodItemSource vbloodItemSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodItemSource>(this._entity, out vbloodItemSource) ? new ProjectM.VBloodItemSource?() : new ProjectM.VBloodItemSource?(vbloodItemSource);
      }
    }

    public ProjectM.TimeScale? TimeScale
    {
      get
      {
        ProjectM.TimeScale timeScale;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.TimeScale>(this._entity, out timeScale) ? new ProjectM.TimeScale?() : new ProjectM.TimeScale?(timeScale);
      }
    }

    public ProjectM.DayNightCycle? DayNightCycle
    {
      get
      {
        ProjectM.DayNightCycle dayNightCycle;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DayNightCycle>(this._entity, out dayNightCycle) ? new ProjectM.DayNightCycle?() : new ProjectM.DayNightCycle?(dayNightCycle);
      }
    }

    public ProjectM.FeedPrisoner? FeedPrisoner
    {
      get
      {
        ProjectM.FeedPrisoner feedPrisoner;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.FeedPrisoner>(this._entity, out feedPrisoner) ? new ProjectM.FeedPrisoner?() : new ProjectM.FeedPrisoner?(feedPrisoner);
      }
    }

    public ProjectM.ScrollingCombatTextMessage? ScrollingCombatTextMessage
    {
      get
      {
        ProjectM.ScrollingCombatTextMessage combatTextMessage;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ScrollingCombatTextMessage>(this._entity, out combatTextMessage) ? new ProjectM.ScrollingCombatTextMessage?() : new ProjectM.ScrollingCombatTextMessage?(combatTextMessage);
      }
    }

    public bool EntitySpawnedMetadata
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Gameplay.EntitySpawnedMetadata>(this._entity);
    }

    public ProjectM.PatrolState? PatrolState
    {
      get
      {
        ProjectM.PatrolState patrolState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PatrolState>(this._entity, out patrolState) ? new ProjectM.PatrolState?() : new ProjectM.PatrolState?(patrolState);
      }
    }

    public UnitCompositionSpawner UnitCompositionSpawner
    {
      get
      {
        UnitCompositionSpawner compositionSpawner;
        return !this._world.EntityManager.TryGetComponentDataInternal<UnitCompositionSpawner>(this._entity, out compositionSpawner) ? new UnitCompositionSpawner() : compositionSpawner;
      }
    }

    public MovePatrolState MovePatrolState
    {
      get
      {
        MovePatrolState movePatrolState;
        return !this._world.EntityManager.TryGetComponentDataInternal<MovePatrolState>(this._entity, out movePatrolState) ? new MovePatrolState() : movePatrolState;
      }
    }

    public ProjectM.UnitCompositionSpawnerDebugName? UnitCompositionSpawnerDebugName
    {
      get
      {
        ProjectM.UnitCompositionSpawnerDebugName spawnerDebugName;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.UnitCompositionSpawnerDebugName>(this._entity, out spawnerDebugName) ? new ProjectM.UnitCompositionSpawnerDebugName?() : new ProjectM.UnitCompositionSpawnerDebugName?(spawnerDebugName);
      }
    }

    public List<UnitCompositionActiveUnit> UnitCompositionActiveUnits
    {
      get => this._world.EntityManager.GetBufferInternal<UnitCompositionActiveUnit>(this._entity);
    }

    public List<FormationOffsetBuffer> FormationOffsetBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<FormationOffsetBuffer>(this._entity);
    }

    public List<UnitCompositionGroupEntry> UnitCompositionGroupEntries
    {
      get => this._world.EntityManager.GetBufferInternal<UnitCompositionGroupEntry>(this._entity);
    }

    public List<UnitCompositionGroupUnitEntry> UnitCompositionGroupUnitEntries
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<UnitCompositionGroupUnitEntry>(this._entity);
      }
    }

    public ProjectM.PathSettings? PathSettings
    {
      get
      {
        ProjectM.PathSettings pathSettings;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PathSettings>(this._entity, out pathSettings) ? new ProjectM.PathSettings?() : new ProjectM.PathSettings?(pathSettings);
      }
    }

    public List<GlobalPatrolElement> GlobalPatrolElements
    {
      get => this._world.EntityManager.GetBufferInternal<GlobalPatrolElement>(this._entity);
    }

    public ProjectM.Pathfinding.PathRequest? PathRequest
    {
      get
      {
        ProjectM.Pathfinding.PathRequest pathRequest;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Pathfinding.PathRequest>(this._entity, out pathRequest) ? new ProjectM.Pathfinding.PathRequest?() : new ProjectM.Pathfinding.PathRequest?(pathRequest);
      }
    }

    public ProjectM.PathWaypointNode? PathWaypointNode
    {
      get
      {
        ProjectM.PathWaypointNode pathWaypointNode;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.PathWaypointNode>(this._entity, out pathWaypointNode) ? new ProjectM.PathWaypointNode?() : new ProjectM.PathWaypointNode?(pathWaypointNode);
      }
    }

    public List<ProjectM.PathWaypointNeighbours> PathWaypointNeighbours
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.PathWaypointNeighbours>(this._entity);
    }

    public ProjectM.SpawnGroupData? SpawnGroupData
    {
      get
      {
        ProjectM.SpawnGroupData spawnGroupData;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnGroupData>(this._entity, out spawnGroupData) ? new ProjectM.SpawnGroupData?() : new ProjectM.SpawnGroupData?(spawnGroupData);
      }
    }

    public List<ProjectM.SpawnGroup_SpawnTableBuffer> SpawnGroup_SpawnTableBuffer
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.SpawnGroup_SpawnTableBuffer>(this._entity);
    }

    public ProjectM.Network.FromCharacter? FromCharacter
    {
      get
      {
        ProjectM.Network.FromCharacter fromCharacter;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.FromCharacter>(this._entity, out fromCharacter) ? new ProjectM.Network.FromCharacter?() : new ProjectM.Network.FromCharacter?(fromCharacter);
      }
    }

    public ProjectM.Network.GiveDebugEvent? GiveDebugEvent
    {
      get
      {
        ProjectM.Network.GiveDebugEvent giveDebugEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.GiveDebugEvent>(this._entity, out giveDebugEvent) ? new ProjectM.Network.GiveDebugEvent?() : new ProjectM.Network.GiveDebugEvent?(giveDebugEvent);
      }
    }

    public ProjectM.SpawnRegion? SpawnRegion
    {
      get
      {
        ProjectM.SpawnRegion spawnRegion;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnRegion>(this._entity, out spawnRegion) ? new ProjectM.SpawnRegion?() : new ProjectM.SpawnRegion?(spawnRegion);
      }
    }

    public List<SpawnGroupBuffer> SpawnGroupBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<SpawnGroupBuffer>(this._entity);
    }

    public List<ProjectM.SpawnRegion_ActiveEntities> SpawnRegion_ActiveEntities
    {
      get => this._world.EntityManager.GetBufferInternal<ProjectM.SpawnRegion_ActiveEntities>(this._entity);
    }

    public List<SpawnPointBuffer> SpawnPointBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<SpawnPointBuffer>(this._entity);
    }

    public List<SpawnRegionSpawnSlotEntry> SpawnRegionSpawnSlotEntries
    {
      get => this._world.EntityManager.GetBufferInternal<SpawnRegionSpawnSlotEntry>(this._entity);
    }

    public ProjectM.VBloodUnitSpawnSource? VBloodUnitSpawnSource
    {
      get
      {
        ProjectM.VBloodUnitSpawnSource vbloodUnitSpawnSource;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.VBloodUnitSpawnSource>(this._entity, out vbloodUnitSpawnSource) ? new ProjectM.VBloodUnitSpawnSource?() : new ProjectM.VBloodUnitSpawnSource?(vbloodUnitSpawnSource);
      }
    }

    public ProjectM.Network.SpawnDebugEvent? SpawnDebugEvent
    {
      get
      {
        ProjectM.Network.SpawnDebugEvent spawnDebugEvent;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Network.SpawnDebugEvent>(this._entity, out spawnDebugEvent) ? new ProjectM.Network.SpawnDebugEvent?() : new ProjectM.Network.SpawnDebugEvent?(spawnDebugEvent);
      }
    }

    public ProjectM.Behaviours.EvaluateCastOptionsRequest? EvaluateCastOptionsRequest
    {
      get
      {
        ProjectM.Behaviours.EvaluateCastOptionsRequest castOptionsRequest;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Behaviours.EvaluateCastOptionsRequest>(this._entity, out castOptionsRequest) ? new ProjectM.Behaviours.EvaluateCastOptionsRequest?() : new ProjectM.Behaviours.EvaluateCastOptionsRequest?(castOptionsRequest);
      }
    }

    public List<AbilityGroupSlotModificationBuffer> AbilityGroupSlotModificationBuffers
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<AbilityGroupSlotModificationBuffer>(this._entity);
      }
    }

    public bool DisabledTileModel
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Tiles.DisabledTileModel>(this._entity);
    }

    public ProjectM.GlobalPatrolState? GlobalPatrolState
    {
      get
      {
        ProjectM.GlobalPatrolState globalPatrolState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.GlobalPatrolState>(this._entity, out globalPatrolState) ? new ProjectM.GlobalPatrolState?() : new ProjectM.GlobalPatrolState?(globalPatrolState);
      }
    }

    public List<WaypointTargetBufferEntry> WaypointTargetBufferEntries
    {
      get => this._world.EntityManager.GetBufferInternal<WaypointTargetBufferEntry>(this._entity);
    }

    public List<PatrolBusStopNode> PatrolBusStopNodes
    {
      get => this._world.EntityManager.GetBufferInternal<PatrolBusStopNode>(this._entity);
    }

    public List<RoadTypePathfindingWeightsElement> RoadTypePathfindingWeightsElements
    {
      get
      {
        return this._world.EntityManager.GetBufferInternal<RoadTypePathfindingWeightsElement>(this._entity);
      }
    }

    public PathWaypointNodeWait PathWaypointNodeWait
    {
      get
      {
        PathWaypointNodeWait waypointNodeWait;
        return !this._world.EntityManager.TryGetComponentDataInternal<PathWaypointNodeWait>(this._entity, out waypointNodeWait) ? new PathWaypointNodeWait() : waypointNodeWait;
      }
    }

    public ProjectM.OnKillListener? OnKillListener
    {
      get
      {
        ProjectM.OnKillListener onKillListener;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.OnKillListener>(this._entity, out onKillListener) ? new ProjectM.OnKillListener?() : new ProjectM.OnKillListener?(onKillListener);
      }
    }

    public bool ListenerTag
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.Scripting.ListenerTag>(this._entity);
    }

    public ProjectM.StatChangeListener? StatChangeListener
    {
      get
      {
        ProjectM.StatChangeListener statChangeListener;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.StatChangeListener>(this._entity, out statChangeListener) ? new ProjectM.StatChangeListener?() : new ProjectM.StatChangeListener?(statChangeListener);
      }
    }

    public ProjectM.SpawnChainChild? SpawnChainChild
    {
      get
      {
        ProjectM.SpawnChainChild spawnChainChild;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.SpawnChainChild>(this._entity, out spawnChainChild) ? new ProjectM.SpawnChainChild?() : new ProjectM.SpawnChainChild?(spawnChainChild);
      }
    }

    public bool GuaranteedStaticTransform
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.GuaranteedStaticTransform>(this._entity);
      }
    }

    public ProjectM.Dead? Dead
    {
      get
      {
        ProjectM.Dead dead;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.Dead>(this._entity, out dead) ? new ProjectM.Dead?() : new ProjectM.Dead?(dead);
      }
    }

    public ProjectM.RandomizedSpawnChainChild? RandomizedSpawnChainChild
    {
      get
      {
        ProjectM.RandomizedSpawnChainChild randomizedSpawnChainChild;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.RandomizedSpawnChainChild>(this._entity, out randomizedSpawnChainChild) ? new ProjectM.RandomizedSpawnChainChild?() : new ProjectM.RandomizedSpawnChainChild?(randomizedSpawnChainChild);
      }
    }

    public bool WasDisabledBeforeNoPlayersInRange
    {
      get
      {
        return this._world.EntityManager.HasComponentInternal<ProjectM.WasDisabledBeforeNoPlayersInRange>(this._entity);
      }
    }

    public ProjectM.ControlledBy? ControlledBy
    {
      get
      {
        ProjectM.ControlledBy controlledBy;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ControlledBy>(this._entity, out controlledBy) ? new ProjectM.ControlledBy?() : new ProjectM.ControlledBy?(controlledBy);
      }
    }

    public List<MinionBuffer> MinionBuffers
    {
      get => this._world.EntityManager.GetBufferInternal<MinionBuffer>(this._entity);
    }

    public ProjectM.DisableAggroBuffModifications? DisableAggroBuffModifications
    {
      get
      {
        ProjectM.DisableAggroBuffModifications buffModifications;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.DisableAggroBuffModifications>(this._entity, out buffModifications) ? new ProjectM.DisableAggroBuffModifications?() : new ProjectM.DisableAggroBuffModifications?(buffModifications);
      }
    }

    public bool AbilityGroupComboActive
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.AbilityGroupComboActive>(this._entity);
    }

    public ProjectM.ChangeKnockbackResistanceBuffModification? ChangeKnockbackResistanceBuffModification
    {
      get
      {
        ProjectM.ChangeKnockbackResistanceBuffModification buffModification;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ChangeKnockbackResistanceBuffModification>(this._entity, out buffModification) ? new ProjectM.ChangeKnockbackResistanceBuffModification?() : new ProjectM.ChangeKnockbackResistanceBuffModification?(buffModification);
      }
    }

    public ProjectM.ModifyAggroRangesBuffModifications? ModifyAggroRangesBuffModifications
    {
      get
      {
        ProjectM.ModifyAggroRangesBuffModifications buffModifications;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyAggroRangesBuffModifications>(this._entity, out buffModifications) ? new ProjectM.ModifyAggroRangesBuffModifications?() : new ProjectM.ModifyAggroRangesBuffModifications?(buffModifications);
      }
    }

    public ProjectM.AbilityIsCastingState? AbilityIsCastingState
    {
      get
      {
        ProjectM.AbilityIsCastingState abilityIsCastingState;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AbilityIsCastingState>(this._entity, out abilityIsCastingState) ? new ProjectM.AbilityIsCastingState?() : new ProjectM.AbilityIsCastingState?(abilityIsCastingState);
      }
    }

    public ProjectM.ModifyMovementSpeedBuffModification? ModifyMovementSpeedBuffModification
    {
      get
      {
        ProjectM.ModifyMovementSpeedBuffModification buffModification;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ModifyMovementSpeedBuffModification>(this._entity, out buffModification) ? new ProjectM.ModifyMovementSpeedBuffModification?() : new ProjectM.ModifyMovementSpeedBuffModification?(buffModification);
      }
    }

    public ProjectM.AdminUser? AdminUser
    {
      get
      {
        ProjectM.AdminUser adminUser;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.AdminUser>(this._entity, out adminUser) ? new ProjectM.AdminUser?() : new ProjectM.AdminUser?(adminUser);
      }
    }

    public bool DestroyWhenDisabled
    {
      get => this._world.EntityManager.HasComponentInternal<ProjectM.DestroyWhenDisabled>(this._entity);
    }

    public ProjectM.ServerControlsPositionModifications? ServerControlsPositionModifications
    {
      get
      {
        ProjectM.ServerControlsPositionModifications positionModifications;
        return !this._world.EntityManager.TryGetComponentDataInternal<ProjectM.ServerControlsPositionModifications>(this._entity, out positionModifications) ? new ProjectM.ServerControlsPositionModifications?() : new ProjectM.ServerControlsPositionModifications?(positionModifications);
      }
    }
  }
}
