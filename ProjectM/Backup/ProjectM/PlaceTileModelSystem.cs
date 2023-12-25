// Decompiled with JetBrains decompiler
// Type: ProjectM.PlaceTileModelSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Network;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class PlaceTileModelSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogDebug;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildTileQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__StartEditQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CancelEditQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveTileQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DismantleTileQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConnectionChangedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCastFinishedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RepairTileQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildWallpaperQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SetVariationQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsUnitTesting;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastApplyResult;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_23;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDoStuff_Private_Boolean_BuildTileModelData_PrefabLookupMap_CollisionWorld_PrepareJobData_EntityCommandBuffer_EntityCommandBuffer_Double_byref_PlacementResult_byref_PlacementResourcesResult_byref_FullPlacementJobData_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlacementLogLevel_Private_PlacementLogLevel_PrepareJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateTransformableInto_Private_Boolean_PrefabGUID_PrefabLookupMap_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleBuildTileModelEvents_Private_Void_CollisionWorld_NativeHashMap_2_NetworkId_Entity_PrepareJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyToLastApplyResult_Private_Void_ApplyResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandlePlaceTileModelAbilityCastFinishedEvents_Private_Void_CollisionWorld_PrepareJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyPathfinding_Public_Boolean_byref_TileWorld_Entity_Entity_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleStartEditTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleCancelEditTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnectionChangedEvents_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleMoveTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_CollisionWorld_PrepareJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleDismantleTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleRepairTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleBuildWallpaperEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetWallpaperVariation_Private_Void_Entity_WallpaperOrientation_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleSetVariationEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnlockedBlueprint_Private_Boolean_Entity_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyAndGetTarget_Private_Static_Boolean_NativeHashMap_2_NetworkId_Entity_INetworkEventWithTarget_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifySharedCanStartEditOrDismantle_Public_Static_Boolean_ComponentSystemBase_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIfCloseEnough_Private_Static_Boolean_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIfCloseEnough_Private_Static_Boolean_EntityManager_Entity_float3_Nullable_Unboxed_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyTileModelNotBeingDissolved_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyEditableTileModel_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyBuildableWallpaperTargetWithOrientation_Public_Static_Boolean_EntityManager_Entity_WallpaperOrientation_PrefabGUID_Byte_byref_ObjectSplits_byref_WallpaperStyleData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateCorrectWallpaperTypeAndOrientation_Private_Static_Boolean_EntityManager_Entity_WallpaperOrientation_ObjectSplits_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldChargeForWallpaper_Private_Static_Boolean_EntityManager_Entity_WallpaperOrientation_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyCanBuildTileModels_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyCorrectOwnership_Public_Static_Boolean_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyMissingCastleHeartConnection_Private_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyCorrectTeam_Private_Static_Boolean_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIfNoOneIsEditing_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIfNotCurrentlyEditing_Private_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIfNotBeingDismantled_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIfCanMoveOrRotateAfterBuilt_Private_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyCanDismantle_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyNotIsNonEmptyForge_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyNotWorkstationProcessing_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyNotHasNonEmptyInventories_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyNotHasNonEmptyInventoriesInner_Private_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyCanRepair_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIfIsCurrentlyEditing_Public_Static_Boolean_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIfIsCurrentlyEditor_Public_Static_Boolean_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearEditing_Public_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnappedTranslation_Public_Static_Translation_ComponentDataFromEntity_1_TileData_CollisionWorld_Entity_Translation_Single_Byte_ComponentDataFromEntity_1_TilePosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026273, XrefRangeEnd = 1026403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlaceTileModelSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026403, XrefRangeEnd = 1026408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlaceTileModelSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026408, XrefRangeEnd = 1026422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlaceTileModelSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1026479, RefRangeEnd = 1026481, XrefRangeStart = 1026422, XrefRangeEnd = 1026479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryDoStuff(
      PlaceTileModelSystem.BuildTileModelData data,
      PrefabLookupMap prefabMap,
      CollisionWorld collisionWorld,
      GetPlacementResult.SystemData.PrepareJobData prepareJobData,
      EntityCommandBuffer spawnCommandBuffer,
      EntityCommandBuffer destroyCommandBuffer,
      double serverTime,
      out PlacementResult placementResult,
      out PlacementResourcesResult resourcesResult,
      out FullPlacementJobData placementJobParams,
      out PrefabGUID placementAbility)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) prepareJobData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref placementResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref resourcesResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref placementJobParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref placementAbility;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_TryDoStuff_Private_Boolean_BuildTileModelData_PrefabLookupMap_CollisionWorld_PrepareJobData_EntityCommandBuffer_EntityCommandBuffer_Double_byref_PlacementResult_byref_PlacementResourcesResult_byref_FullPlacementJobData_byref_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026487, RefRangeEnd = 1026488, XrefRangeStart = 1026481, XrefRangeEnd = 1026487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlacementLogLevel GetPlacementLogLevel(
      GetPlacementResult.SystemData.PrepareJobData prepareJobData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) prepareJobData));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_GetPlacementLogLevel_Private_PlacementLogLevel_PrepareJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementLogLevel*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026517, RefRangeEnd = 1026518, XrefRangeStart = 1026488, XrefRangeEnd = 1026517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidateTransformableInto(
      PrefabGUID prefabGuid,
      PrefabLookupMap prefabMap,
      Entity transformedTileModel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &transformedTileModel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_ValidateTransformableInto_Private_Boolean_PrefabGUID_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026627, RefRangeEnd = 1026628, XrefRangeStart = 1026518, XrefRangeEnd = 1026627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleBuildTileModelEvents(
      CollisionWorld collisionWorld,
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      GetPlacementResult.SystemData.PrepareJobData prepareJobData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &networkIdToEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) prepareJobData));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleBuildTileModelEvents_Private_Void_CollisionWorld_NativeHashMap_2_NetworkId_Entity_PrepareJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1026643, RefRangeEnd = 1026646, XrefRangeStart = 1026628, XrefRangeEnd = 1026643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyToLastApplyResult(ApplyPlacementResult.ApplyResult applyResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &applyResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_CopyToLastApplyResult_Private_Void_ApplyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026692, RefRangeEnd = 1026693, XrefRangeStart = 1026646, XrefRangeEnd = 1026692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandlePlaceTileModelAbilityCastFinishedEvents(
      CollisionWorld collisionWorld,
      GetPlacementResult.SystemData.PrepareJobData prepareJobData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) prepareJobData));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandlePlaceTileModelAbilityCastFinishedEvents_Private_Void_CollisionWorld_PrepareJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026739, RefRangeEnd = 1026740, XrefRangeStart = 1026693, XrefRangeEnd = 1026739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool VerifyPathfinding(
      ref TileWorld tileWorld,
      Entity tileModelPrefab,
      Entity character,
      float3 targetPosition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyPathfinding_Public_Boolean_byref_TileWorld_Entity_Entity_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026804, RefRangeEnd = 1026805, XrefRangeStart = 1026740, XrefRangeEnd = 1026804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleStartEditTileModelEvents(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleStartEditTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026850, RefRangeEnd = 1026851, XrefRangeStart = 1026805, XrefRangeEnd = 1026850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleCancelEditTileModelEvents(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleCancelEditTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026887, RefRangeEnd = 1026888, XrefRangeStart = 1026851, XrefRangeEnd = 1026887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleConnectionChangedEvents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleConnectionChangedEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027006, RefRangeEnd = 1027007, XrefRangeStart = 1026888, XrefRangeEnd = 1027006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleMoveTileModelEvents(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      CollisionWorld collisionWorld,
      GetPlacementResult.SystemData.PrepareJobData prepareJobData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) prepareJobData));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleMoveTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_CollisionWorld_PrepareJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027122, RefRangeEnd = 1027123, XrefRangeStart = 1027007, XrefRangeEnd = 1027122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleDismantleTileModelEvents(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleDismantleTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027250, RefRangeEnd = 1027251, XrefRangeStart = 1027123, XrefRangeEnd = 1027250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleRepairTileModelEvents(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleRepairTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027357, RefRangeEnd = 1027358, XrefRangeStart = 1027251, XrefRangeEnd = 1027357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleBuildWallpaperEvents(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleBuildWallpaperEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027400, RefRangeEnd = 1027401, XrefRangeStart = 1027358, XrefRangeEnd = 1027400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetWallpaperVariation(
      Entity tileModelEntity,
      WallpaperOrientation orientation,
      byte variationIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &orientation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &variationIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_SetWallpaperVariation_Private_Void_Entity_WallpaperOrientation_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027447, RefRangeEnd = 1027448, XrefRangeStart = 1027401, XrefRangeEnd = 1027447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleSetVariationEvents(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HandleSetVariationEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1027483, RefRangeEnd = 1027486, XrefRangeStart = 1027448, XrefRangeEnd = 1027483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasUnlockedBlueprint(Entity user, PrefabGUID prefabGuid, Entity prefab)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_HasUnlockedBlueprint_Private_Boolean_Entity_PrefabGUID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027486, XrefRangeEnd = 1027492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyAndGetTarget(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      INetworkEventWithTarget eventData,
      out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyAndGetTarget_Private_Static_Boolean_NativeHashMap_2_NetworkId_Entity_INetworkEventWithTarget_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1027547, RefRangeEnd = 1027551, XrefRangeStart = 1027492, XrefRangeEnd = 1027547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifySharedCanStartEditOrDismantle(
      ComponentSystemBase systemBase,
      Entity tileModelEntity,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifySharedCanStartEditOrDismantle_Public_Static_Boolean_ComponentSystemBase_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1027565, RefRangeEnd = 1027569, XrefRangeStart = 1027551, XrefRangeEnd = 1027565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyIfCloseEnough(
      EntityManager entityManager,
      Entity character,
      Entity existingTileModel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &existingTileModel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfCloseEnough_Private_Static_Boolean_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1027597, RefRangeEnd = 1027600, XrefRangeStart = 1027569, XrefRangeEnd = 1027597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyIfCloseEnough(
      EntityManager entityManager,
      Entity character,
      float3 position,
      Nullable_Unboxed<Entity> existingTileModel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &existingTileModel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfCloseEnough_Private_Static_Boolean_EntityManager_Entity_float3_Nullable_Unboxed_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1027604, RefRangeEnd = 1027608, XrefRangeStart = 1027600, XrefRangeEnd = 1027604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyTileModelNotBeingDissolved(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyTileModelNotBeingDissolved_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1027615, RefRangeEnd = 1027623, XrefRangeStart = 1027608, XrefRangeEnd = 1027615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyEditableTileModel(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyEditableTileModel_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027643, RefRangeEnd = 1027644, XrefRangeStart = 1027623, XrefRangeEnd = 1027643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyBuildableWallpaperTargetWithOrientation(
      EntityManager entityManager,
      Entity tileModelEntity,
      WallpaperOrientation targetOrientation,
      PrefabGUID parentBlueprintGUID,
      byte targetColorVariationIndex,
      out ObjectSplits objectSplits,
      out WallpaperStyleData targetStyleData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetOrientation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &parentBlueprintGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &targetColorVariationIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref objectSplits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetStyleData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyBuildableWallpaperTargetWithOrientation_Public_Static_Boolean_EntityManager_Entity_WallpaperOrientation_PrefabGUID_Byte_byref_ObjectSplits_byref_WallpaperStyleData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027644, XrefRangeEnd = 1027657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ValidateCorrectWallpaperTypeAndOrientation(
      EntityManager entityManager,
      Entity tileModelEntity,
      WallpaperOrientation targetOrientation,
      ObjectSplits splitsPerStyle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetOrientation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &splitsPerStyle;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_ValidateCorrectWallpaperTypeAndOrientation_Private_Static_Boolean_EntityManager_Entity_WallpaperOrientation_ObjectSplits_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027661, RefRangeEnd = 1027662, XrefRangeStart = 1027657, XrefRangeEnd = 1027661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldChargeForWallpaper(
      EntityManager entityManager,
      Entity tileModelEntity,
      WallpaperOrientation orientation,
      byte targetColorVariationIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &orientation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &targetColorVariationIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_ShouldChargeForWallpaper_Private_Static_Boolean_EntityManager_Entity_WallpaperOrientation_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1027665, RefRangeEnd = 1027667, XrefRangeStart = 1027662, XrefRangeEnd = 1027665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyCanBuildTileModels(
      EntityManager entityManager,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCanBuildTileModels_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1027684, RefRangeEnd = 1027689, XrefRangeStart = 1027667, XrefRangeEnd = 1027684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyCorrectOwnership(
      EntityManager entityManager,
      Entity tileModelEntity,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCorrectOwnership_Public_Static_Boolean_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027689, XrefRangeEnd = 1027697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyMissingCastleHeartConnection(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyMissingCastleHeartConnection_Private_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1027725, RefRangeEnd = 1027727, XrefRangeStart = 1027697, XrefRangeEnd = 1027725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyCorrectTeam(
      EntityManager entityManager,
      Entity tileModelEntity,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCorrectTeam_Private_Static_Boolean_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027733, RefRangeEnd = 1027734, XrefRangeStart = 1027727, XrefRangeEnd = 1027733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyIfNoOneIsEditing(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfNoOneIsEditing_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027739, RefRangeEnd = 1027740, XrefRangeStart = 1027734, XrefRangeEnd = 1027739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyIfNotCurrentlyEditing(
      EntityManager entityManager,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfNotCurrentlyEditing_Private_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1027743, RefRangeEnd = 1027745, XrefRangeStart = 1027740, XrefRangeEnd = 1027743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyIfNotBeingDismantled(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfNotBeingDismantled_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027748, RefRangeEnd = 1027749, XrefRangeStart = 1027745, XrefRangeEnd = 1027748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyIfCanMoveOrRotateAfterBuilt(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfCanMoveOrRotateAfterBuilt_Private_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1027752, RefRangeEnd = 1027755, XrefRangeStart = 1027749, XrefRangeEnd = 1027752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyCanDismantle(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCanDismantle_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027761, RefRangeEnd = 1027762, XrefRangeStart = 1027755, XrefRangeEnd = 1027761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyNotIsNonEmptyForge(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyNotIsNonEmptyForge_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027768, RefRangeEnd = 1027769, XrefRangeStart = 1027762, XrefRangeEnd = 1027768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyNotWorkstationProcessing(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyNotWorkstationProcessing_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027796, RefRangeEnd = 1027797, XrefRangeStart = 1027769, XrefRangeEnd = 1027796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyNotHasNonEmptyInventories(
      EntityManager entityManager,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyNotHasNonEmptyInventories_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1027816, RefRangeEnd = 1027821, XrefRangeStart = 1027797, XrefRangeEnd = 1027816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyNotHasNonEmptyInventoriesInner(
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyNotHasNonEmptyInventoriesInner_Private_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1027824, RefRangeEnd = 1027825, XrefRangeStart = 1027821, XrefRangeEnd = 1027824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyCanRepair(EntityManager entityManager, Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCanRepair_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1027834, RefRangeEnd = 1027837, XrefRangeStart = 1027825, XrefRangeEnd = 1027834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyIfIsCurrentlyEditing(
      EntityManager entityManager,
      Entity tileModelEntity,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfIsCurrentlyEditing_Public_Static_Boolean_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1027842, RefRangeEnd = 1027844, XrefRangeStart = 1027837, XrefRangeEnd = 1027842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyIfIsCurrentlyEditor(
      EntityManager entityManager,
      Entity tileModelEntity,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfIsCurrentlyEditor_Public_Static_Boolean_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1027865, RefRangeEnd = 1027868, XrefRangeStart = 1027844, XrefRangeEnd = 1027865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearEditing(
      EntityManager entityManager,
      Entity tileModelEntity,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_ClearEditing_Public_Static_Void_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027868, XrefRangeEnd = 1027869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Translation GetSnappedTranslation(
      ComponentDataFromEntity<TileData> getTileData,
      CollisionWorld collisionWorld,
      Entity tileModelPrefab,
      Translation translation,
      float rotation,
      byte heightLevel,
      ComponentDataFromEntity<TilePosition> getTilePosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr_GetSnappedTranslation_Public_Static_Translation_ComponentDataFromEntity_1_TileData_CollisionWorld_Entity_Translation_Single_Byte_ComponentDataFromEntity_1_TilePosition_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Translation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlaceTileModelSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaceTileModelSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027869, XrefRangeEnd = 1027877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlaceTileModelSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlaceTileModelSystem()
    {
      Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlaceTileModelSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr);
      PlaceTileModelSystem.NativeFieldInfoPtr_LogDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (LogDebug));
      PlaceTileModelSystem.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_PlacementSystemData));
      PlaceTileModelSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      PlaceTileModelSystem.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_DestroyBarrier));
      PlaceTileModelSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      PlaceTileModelSystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_CollisionSystem));
      PlaceTileModelSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_GameDataSystem));
      PlaceTileModelSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      PlaceTileModelSystem.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      PlaceTileModelSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      PlaceTileModelSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      PlaceTileModelSystem.NativeFieldInfoPtr__BuildTileQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_BuildTileQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__StartEditQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_StartEditQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__CancelEditQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_CancelEditQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__MoveTileQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_MoveTileQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__DismantleTileQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_DismantleTileQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__ConnectionChangedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_ConnectionChangedQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__AbilityCastFinishedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_AbilityCastFinishedQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__RepairTileQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_RepairTileQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__BuildWallpaperQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_BuildWallpaperQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__SetVariationQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_SetVariationQuery));
      PlaceTileModelSystem.NativeFieldInfoPtr__IsUnitTesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_IsUnitTesting));
      PlaceTileModelSystem.NativeFieldInfoPtr_LastApplyResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (LastApplyResult));
      PlaceTileModelSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_23));
      PlaceTileModelSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680241);
      PlaceTileModelSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680242);
      PlaceTileModelSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680243);
      PlaceTileModelSystem.NativeMethodInfoPtr_TryDoStuff_Private_Boolean_BuildTileModelData_PrefabLookupMap_CollisionWorld_PrepareJobData_EntityCommandBuffer_EntityCommandBuffer_Double_byref_PlacementResult_byref_PlacementResourcesResult_byref_FullPlacementJobData_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680244);
      PlaceTileModelSystem.NativeMethodInfoPtr_GetPlacementLogLevel_Private_PlacementLogLevel_PrepareJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680245);
      PlaceTileModelSystem.NativeMethodInfoPtr_ValidateTransformableInto_Private_Boolean_PrefabGUID_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680246);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleBuildTileModelEvents_Private_Void_CollisionWorld_NativeHashMap_2_NetworkId_Entity_PrepareJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680247);
      PlaceTileModelSystem.NativeMethodInfoPtr_CopyToLastApplyResult_Private_Void_ApplyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680248);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandlePlaceTileModelAbilityCastFinishedEvents_Private_Void_CollisionWorld_PrepareJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680249);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyPathfinding_Public_Boolean_byref_TileWorld_Entity_Entity_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680250);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleStartEditTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680251);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleCancelEditTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680252);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleConnectionChangedEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680253);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleMoveTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_CollisionWorld_PrepareJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680254);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleDismantleTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680255);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleRepairTileModelEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680256);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleBuildWallpaperEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680257);
      PlaceTileModelSystem.NativeMethodInfoPtr_SetWallpaperVariation_Private_Void_Entity_WallpaperOrientation_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680258);
      PlaceTileModelSystem.NativeMethodInfoPtr_HandleSetVariationEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680259);
      PlaceTileModelSystem.NativeMethodInfoPtr_HasUnlockedBlueprint_Private_Boolean_Entity_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680260);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyAndGetTarget_Private_Static_Boolean_NativeHashMap_2_NetworkId_Entity_INetworkEventWithTarget_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680261);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifySharedCanStartEditOrDismantle_Public_Static_Boolean_ComponentSystemBase_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680262);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfCloseEnough_Private_Static_Boolean_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680263);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfCloseEnough_Private_Static_Boolean_EntityManager_Entity_float3_Nullable_Unboxed_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680264);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyTileModelNotBeingDissolved_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680265);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyEditableTileModel_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680266);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyBuildableWallpaperTargetWithOrientation_Public_Static_Boolean_EntityManager_Entity_WallpaperOrientation_PrefabGUID_Byte_byref_ObjectSplits_byref_WallpaperStyleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680267);
      PlaceTileModelSystem.NativeMethodInfoPtr_ValidateCorrectWallpaperTypeAndOrientation_Private_Static_Boolean_EntityManager_Entity_WallpaperOrientation_ObjectSplits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680268);
      PlaceTileModelSystem.NativeMethodInfoPtr_ShouldChargeForWallpaper_Private_Static_Boolean_EntityManager_Entity_WallpaperOrientation_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680269);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCanBuildTileModels_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680270);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCorrectOwnership_Public_Static_Boolean_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680271);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyMissingCastleHeartConnection_Private_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680272);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCorrectTeam_Private_Static_Boolean_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680273);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfNoOneIsEditing_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680274);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfNotCurrentlyEditing_Private_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680275);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfNotBeingDismantled_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680276);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfCanMoveOrRotateAfterBuilt_Private_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680277);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCanDismantle_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680278);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyNotIsNonEmptyForge_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680279);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyNotWorkstationProcessing_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680280);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyNotHasNonEmptyInventories_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680281);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyNotHasNonEmptyInventoriesInner_Private_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680282);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyCanRepair_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680283);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfIsCurrentlyEditing_Public_Static_Boolean_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680284);
      PlaceTileModelSystem.NativeMethodInfoPtr_VerifyIfIsCurrentlyEditor_Public_Static_Boolean_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680285);
      PlaceTileModelSystem.NativeMethodInfoPtr_ClearEditing_Public_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680286);
      PlaceTileModelSystem.NativeMethodInfoPtr_GetSnappedTranslation_Public_Static_Translation_ComponentDataFromEntity_1_TileData_CollisionWorld_Entity_Translation_Single_Byte_ComponentDataFromEntity_1_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680287);
      PlaceTileModelSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680288);
      PlaceTileModelSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, 100680290);
    }

    public PlaceTileModelSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool LogDebug
    {
      get
      {
        bool logDebug;
        IL2CPP.il2cpp_field_static_get_value(PlaceTileModelSystem.NativeFieldInfoPtr_LogDebug, (void*) &logDebug);
        return logDebug;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlaceTileModelSystem.NativeFieldInfoPtr_LogDebug, (void*) &value);
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _BuildTileQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__BuildTileQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__BuildTileQuery)) = value;
      }
    }

    public unsafe EntityQuery _StartEditQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__StartEditQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__StartEditQuery)) = value;
      }
    }

    public unsafe EntityQuery _CancelEditQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__CancelEditQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__CancelEditQuery)) = value;
      }
    }

    public unsafe EntityQuery _MoveTileQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__MoveTileQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__MoveTileQuery)) = value;
      }
    }

    public unsafe EntityQuery _DismantleTileQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__DismantleTileQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__DismantleTileQuery)) = value;
      }
    }

    public unsafe EntityQuery _ConnectionChangedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__ConnectionChangedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__ConnectionChangedQuery)) = value;
      }
    }

    public unsafe EntityQuery _AbilityCastFinishedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__AbilityCastFinishedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__AbilityCastFinishedQuery)) = value;
      }
    }

    public unsafe EntityQuery _RepairTileQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__RepairTileQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__RepairTileQuery)) = value;
      }
    }

    public unsafe EntityQuery _BuildWallpaperQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__BuildWallpaperQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__BuildWallpaperQuery)) = value;
      }
    }

    public unsafe EntityQuery _SetVariationQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__SetVariationQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__SetVariationQuery)) = value;
      }
    }

    public unsafe bool _IsUnitTesting
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__IsUnitTesting));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__IsUnitTesting)) = value;
      }
    }

    public unsafe ApplyPlacementResult.ApplyResult LastApplyResult
    {
      get
      {
        return *(ApplyPlacementResult.ApplyResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr_LastApplyResult));
      }
      [param: In] set
      {
        *(ApplyPlacementResult.ApplyResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr_LastApplyResult)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_23
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_23));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaceTileModelSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_23)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BuildTileModelData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_Translation;
      private static readonly System.IntPtr NativeFieldInfoPtr_TransformedTileModel;
      private static readonly System.IntPtr NativeFieldInfoPtr_Character;
      private static readonly System.IntPtr NativeFieldInfoPtr_User;
      [FieldOffset(0)]
      public PrefabGUID PrefabGuid;
      [FieldOffset(4)]
      public TileRotation TileRotation;
      [FieldOffset(8)]
      public Translation Translation;
      [FieldOffset(20)]
      public Entity TransformedTileModel;
      [FieldOffset(28)]
      public Entity Character;
      [FieldOffset(36)]
      public Entity User;

      static BuildTileModelData()
      {
        Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaceTileModelSystem>.NativeClassPtr, nameof (BuildTileModelData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr);
        PlaceTileModelSystem.BuildTileModelData.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr, nameof (PrefabGuid));
        PlaceTileModelSystem.BuildTileModelData.NativeFieldInfoPtr_TileRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr, nameof (TileRotation));
        PlaceTileModelSystem.BuildTileModelData.NativeFieldInfoPtr_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr, nameof (Translation));
        PlaceTileModelSystem.BuildTileModelData.NativeFieldInfoPtr_TransformedTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr, nameof (TransformedTileModel));
        PlaceTileModelSystem.BuildTileModelData.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr, nameof (Character));
        PlaceTileModelSystem.BuildTileModelData.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr, nameof (User));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaceTileModelSystem.BuildTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
