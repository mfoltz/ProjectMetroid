// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.GetPlacementResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Network;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public static class GetPlacementResult : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_Static_PlacementResult_byref_Operation_byref_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanPerformOperation_Private_Static_Boolean_Entity_byref_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOperationFromFusedParent_Private_Static_Operation_byref_Operation_byref_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogDebug_Private_Static_Void_Operation_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_Int32_NativeList_1_DetachTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDismantleResult_Private_Static_PlacementResult_byref_Operation_byref_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogDismantleDebug_Private_Static_Void_Operation_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckSiege_Private_Static_Void_byref_JobData_InternalTileModel_byref_TileModelBlockReasons_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDeadResult_Public_Static_PlacementResult_byref_DeadOperation_byref_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetUserTeam_Private_Static_Nullable_Unboxed_1_Team_byref_JobData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupInternalTileModelsAndDependencies_Private_Static_Void_byref_Operation_byref_JobData_byref_NativeList_1_InternalTileModel_byref_NativeMultiHashMap_2_Int32_InternalTileModelDependency_byref_NativeHashMap_2_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOldTranslationAndRotation_Private_Static_Void_byref_Operation_byref_JobData_byref_Translation_byref_Rotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddInternalTileModel_Private_Static_Boolean_NativeList_1_InternalTileModel_Entity_Entity_Translation_Rotation_Translation_Rotation_InternalTileModelSource_Boolean_InternalOrExternalEntityId_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInternalTileModelNetworkedChildren_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeHashMap_2_NetworkedChildKey_Int32_Entity_Int32_Translation_Rotation_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInternalTileModelAttachedChildren_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_Entity_Int32_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInternalTileModelFusedChildren_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_Entity_Int32_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateInternalTileModelBounds_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_byref_NativeArray_1_InternalTileModelBounds_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedLocalBounds_Private_Static_BoundsMinMax_byref_JobData_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FetchAllPlacementDatas_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeHashMap_2_Entity_Int32_NativeArray_1_InternalTileModelBounds_byref_NativeMultiHashMap_2_int3_TileModelPlacementData_byref_NativeMultiHashMap_2_Int32_Entity_byref_NativeMultiHashMap_2_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterOutFromHeightLayerIncludeStairs_Private_Static_Boolean_ComponentDataFromEntity_1_TilePosition_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStaticPlacementData_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStaticTileDataWithinBounds_Public_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBakedPlacementTiles_Private_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_int2_Byte_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WritePlacement_Private_Static_Void_Entity_TilePosition_byref_TileDatas2dArray_1_PlacementData_BoundsMinMax_int2_NativeMultiHashMap_2_int3_TileModelPlacementData_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBlockedTiles_Private_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_Byte_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRoadsFromChunks_Private_Static_Void_byref_JobData_NativeArray_1_InternalTileModelBounds_byref_NativeHashSet_1_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedPlacementJobData_Private_Static_MergedPlacementJobData_byref_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedPlacementJobData_Public_Static_MergedPlacementJobData_SystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedPlacementDatas_Public_Static_Void_MergedPlacementJobData_NativeHashMap_2_int3_PlacementData_Entity_int2_Single_TileRotation_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalPlacementResultsAndAttachments_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_NativeHashSet_1_int2_NativeMultiHashMap_2_Int32_InternalTileModelDependency_byref_NativeArray_1_InternalTileModelPlacementResults_byref_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_byref_NativeList_1_InternalDestroyTileModelData_byref_NativeList_1_InternalAttachTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddBlockReason_Private_Static_Void_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Int32_InternalTileModelBlockReasonData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckRestrictionAreas_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_int2_byref_TileModelBlockReasons_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckMapZoneRestrictions_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_TileModelBlockReasons_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfInRestrictionArea_Private_Static_BlockReason_Entity_Team_byref_Operation_byref_JobData_NativeList_1_Entity_int2_PlacementTypeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckPlacementHistory_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_TileModelBlockReasons_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckCastleTeleporters_Private_Static_Void_byref_Operation_byref_JobData_Entity_byref_TileModelBlockReasons_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsAttachment_Private_Static_Boolean_NativeList_1_InternalAttachTileModelData_InternalOrExternalEntityId_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AttachNetworkedChildrenToRootParent_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalAttachTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelIfOnlyUpgradeableAndNotUpgrading_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelPlacementsBasedOnDependencyTree_Private_Static_Void_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelReplacements_Private_Static_Void_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalDestroyTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelPlacementsBasedOnInternalReplacements_Private_Static_Void_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelAttachments_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetExistingEntity_Private_Static_Boolean_InternalOrExternalEntityId_NativeList_1_InternalTileModel_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDetachments_Private_Static_NativeList_1_DetachTileModelData_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_Entity_NativeMultiHashMap_2_Int32_Entity_byref_NativeList_1_DetachTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupPlacementResult_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_NativeList_1_DetachTileModelData_byref_PlacementResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupPlacementResultBlockReasons_Private_Static_Void_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_PlacementResult_Int32_InternalTileModel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEmtpyResult_Private_Static_PlacementResult_PlacementOperation_Entity_Nullable_Unboxed_1_Team_Boolean_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSimpleBlockedPlacementResult_Private_Static_PlacementResult_byref_Operation_byref_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDetachmentsBasedOnDestroyDatas_Private_Static_Void_byref_JobData_PlacementResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsReplaceData_Private_Static_Boolean_NativeList_1_InternalDestroyTileModelData_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsDestroyData_Private_Static_Boolean_NativeList_1_DestroyTileModelData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsDetachData_Private_Static_Boolean_NativeList_1_DetachTileModelData_DetachTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDestroyDataRecursive_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeList_1_Entity_NativeList_1_DestroyTileModelData_NativeList_1_DetachTileModelData_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Boolean_Entity_Boolean_TileModelDestroyReason_Nullable_Unboxed_1_PlacementEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyFusedDependencySillNotDestroyed_Private_Static_Boolean_Entity_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeList_1_DestroyTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInternalEntity_Private_Static_Boolean_NativeList_1_InternalTileModel_Entity_byref_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDestroyDataRecursiveInternal_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_Entity_NativeList_1_InternalTileModel_NativeList_1_DestroyTileModelData_NativeList_1_DetachTileModelData_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Boolean_Entity_Boolean_TileModelDestroyReason_Nullable_Unboxed_1_PlacementEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInternalTileModelIndex_Private_Static_Boolean_Entity_NativeList_1_InternalTileModel_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckRoads_Private_Static_Void_byref_JobData_NativeHashSet_1_int2_NativeKeyValueArrays_2_int3_PlacementData_byref_CastleAreaRequirement_byref_TileModelBlockReasons_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckCastleTerritoryZone_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_CastleAreaRequirement_byref_InternalTileModel_byref_TileModelBlockReasons_byref_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTeam_Private_Static_Boolean_Entity_ComponentDataFromEntity_1_Team_byref_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_AttachToOwnedArea_Private_Static_Boolean_byref_Operation_byref_JobData_byref_TileModelBlockReasons_Entity_Entity_Boolean_byref_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInWorldExceptInEnemyArea_Private_Static_Boolean_byref_Operation_byref_JobData_byref_TileModelBlockReasons_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInNeutralArea_Private_Static_Boolean_byref_TileModelBlockReasons_Entity_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInClaimableTerritory_Private_Static_Boolean_byref_Operation_byref_JobData_byref_InternalTileModel_byref_TileModelBlockReasons_Entity_Entity_Boolean_byref_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckFloorTerritory_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_Entity_Entity_byref_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeHashMap_2_InternalOrExternalEntityId_NeighbourFilter_NativeHashSet_1_InternalOrExternalEntityId_byref_TileModelBlockReasons_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RoomUtilityGetNeighbourJobData_Private_Static_GetNeighbourFloorsJobData_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckTerritoryNonFloors_Private_Static_Void_byref_Operation_byref_JobData_Entity_byref_TileModelBlockReasons_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MergeNeighbourFloors_Private_Static_NativeList_1_NeighbourFloorsInternalResult_NativeList_1_NeighbourFloorsResult_NativeList_1_NeighbourFloorsInternalResult_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalNeighbourFloors_Private_Static_NativeList_1_NeighbourFloorsInternalResult_byref_GetNeighbourFloorsJobData_TilePosition_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_NativeList_1_InternalTileModel_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighbourFloorsAndNearbyCastleFloors_Private_Static_NativeList_1_Entity_Byte_Int32_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_CastleFloor_SpatialLookupParams_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindConnectedFloor_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_InternalOrExternalEntityId_NeighbourFilter_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindConnectedFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_InternalOrExternalEntityId_NeighbourFilter_byref_NativeList_1_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasExternalNeighbor_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindNonInternalNeighborNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_byref_NativeHashSet_1_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyNeighborHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllNeighborsHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllNeighborsHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_byref_NativeList_1_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAll_Private_Static_Void_NativeHashSet_1_InternalOrExternalEntityId_NativeHashSet_1_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAll_Private_Static_Void_NativeHashMap_2_InternalOrExternalEntityId_NeighbourFilter_NativeHashSet_1_InternalOrExternalEntityId_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindGroundedFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_NeighbourFilter_byref_NativeHashSet_1_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsStairsGrounded_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_Entity_byref_CastleStairs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyNeighborHasCastleHeartConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_ComponentDataFromEntity_1_CastleHeart_byref_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllNeighborsHasCastleHeartConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_byref_NativeList_1_InternalOrExternalEntityId_ComponentDataFromEntity_1_CastleHeart_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindCastleHeartForFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_ComponentDataFromEntity_1_CastleHeart_byref_NativeHashSet_1_InternalOrExternalEntityId_byref_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyUnitsOnElevatedFloor_Private_Static_Boolean_byref_JobData_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTilePosition_Private_Static_TilePosition_NativeList_1_InternalTileModel_ComponentDataFromEntity_1_TilePosition_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastleStairs_Private_Static_CastleStairs_NativeList_1_InternalTileModel_ComponentDataFromEntity_1_CastleStairs_InternalOrExternalEntityId_byref_Nullable_Unboxed_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabOrEntity_Private_Static_Entity_NativeList_1_InternalTileModel_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighborFilter_Private_Static_NeighbourFilter_byref_GetNeighbourFloorsJobData_byref_InternalOrExternalEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighborFilter_Private_Static_NeighbourFilter_byref_CastleFloor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighbourFloors_Private_Static_InternalNeighbourFloorsEnumerator_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_BoundsMinMax_int2_PDM_0;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1132680, RefRangeEnd = 1132692, XrefRangeStart = 1132578, XrefRangeEnd = 1132680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementResult GetResult(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetResult_Public_Static_PlacementResult_byref_Operation_byref_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132692, XrefRangeEnd = 1132699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanPerformOperation(
      Entity character,
      ref GetPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CanPerformOperation_Private_Static_Boolean_Entity_byref_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1132716, RefRangeEnd = 1132717, XrefRangeStart = 1132699, XrefRangeEnd = 1132716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetPlacementResult.Operation GetOperationFromFusedParent(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetOperationFromFusedParent_Private_Static_Operation_byref_Operation_byref_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetPlacementResult.Operation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1132960, RefRangeEnd = 1132961, XrefRangeStart = 1132717, XrefRangeEnd = 1132960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogDebug(
      GetPlacementResult.Operation operation,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelsBounds,
      NativeMultiHashMap<int3, GetPlacementResult.TileModelPlacementData> placementDatasPerWorldTile,
      NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      NativeList<GetPlacementResult.InternalDestroyTileModelData> finalReplacements,
      NativeList<GetPlacementResult.InternalAttachTileModelData> finalAttachments,
      int dependencyTreeIterations,
      NativeList<DetachTileModelData> detachments)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &placementDatasPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &finalReplacements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &finalAttachments;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTreeIterations;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &detachments;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_LogDebug_Private_Static_Void_Operation_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_Int32_NativeList_1_DetachTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133063, RefRangeEnd = 1133064, XrefRangeStart = 1132961, XrefRangeEnd = 1133063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementResult GetDismantleResult(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetDismantleResult_Private_Static_PlacementResult_byref_Operation_byref_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133095, RefRangeEnd = 1133096, XrefRangeStart = 1133064, XrefRangeEnd = 1133095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogDismantleDebug(
      GetPlacementResult.Operation operation,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_LogDismantleDebug_Private_Static_Void_Operation_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133111, RefRangeEnd = 1133112, XrefRangeStart = 1133096, XrefRangeEnd = 1133111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckSiege(
      ref GetPlacementResult.JobData jobData,
      GetPlacementResult.InternalTileModel internalTileModel,
      ref GetPlacementResult.TileModelBlockReasons blockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckSiege_Private_Static_Void_byref_JobData_InternalTileModel_byref_TileModelBlockReasons_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1133138, RefRangeEnd = 1133140, XrefRangeStart = 1133112, XrefRangeEnd = 1133138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementResult GetDeadResult(
      ref GetPlacementResult.DeadOperation operation,
      ref GetPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetDeadResult_Public_Static_PlacementResult_byref_DeadOperation_byref_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1133162, RefRangeEnd = 1133168, XrefRangeStart = 1133140, XrefRangeEnd = 1133162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Nullable_Unboxed<Team> TryGetUserTeam(
      ref GetPlacementResult.JobData jobData,
      Entity characterEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &characterEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryGetUserTeam_Private_Static_Nullable_Unboxed_1_Team_byref_JobData_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<Team>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1133251, RefRangeEnd = 1133253, XrefRangeStart = 1133168, XrefRangeEnd = 1133251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupInternalTileModelsAndDependencies(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      out NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      out NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      out NativeHashMap<Entity, int> isInternalEntityMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref isInternalEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_SetupInternalTileModelsAndDependencies_Private_Static_Void_byref_Operation_byref_JobData_byref_NativeList_1_InternalTileModel_byref_NativeMultiHashMap_2_Int32_InternalTileModelDependency_byref_NativeHashMap_2_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133253, XrefRangeEnd = 1133266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetOldTranslationAndRotation(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      out Translation oldTranslation,
      out Rotation oldRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref oldTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref oldRotation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetOldTranslationAndRotation_Private_Static_Void_byref_Operation_byref_JobData_byref_Translation_byref_Rotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1133281, RefRangeEnd = 1133285, XrefRangeStart = 1133266, XrefRangeEnd = 1133281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryAddInternalTileModel(
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      Entity tileModelPrefab,
      Entity existingEntity,
      Translation oldTranslation,
      Rotation oldRotation,
      Translation newTranslation,
      Rotation newRotation,
      GetPlacementResult.InternalTileModelSource source,
      bool isFusedRoot,
      GetPlacementResult.InternalOrExternalEntityId fusedRootParent,
      out int internalTileModelIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &existingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &oldTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &oldRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &newTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &isFusedRoot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &fusedRootParent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalTileModelIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryAddInternalTileModel_Private_Static_Boolean_NativeList_1_InternalTileModel_Entity_Entity_Translation_Rotation_Translation_Rotation_InternalTileModelSource_Boolean_InternalOrExternalEntityId_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1133384, RefRangeEnd = 1133386, XrefRangeStart = 1133285, XrefRangeEnd = 1133384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddInternalTileModelNetworkedChildren(
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      NativeHashMap<GetPlacementResult.NetworkedChildKey, int> networkedChildToInternalIndex,
      Entity parentPrefabEntity,
      int parentInternalIndex,
      Translation parentTranslation,
      Rotation parentRotation,
      GetPlacementResult.InternalOrExternalEntityId fusedRoot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &networkedChildToInternalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &parentPrefabEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &parentInternalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &parentTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &parentRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &fusedRoot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddInternalTileModelNetworkedChildren_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeHashMap_2_NetworkedChildKey_Int32_Entity_Int32_Translation_Rotation_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1133459, RefRangeEnd = 1133461, XrefRangeStart = 1133386, XrefRangeEnd = 1133459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddInternalTileModelAttachedChildren(
      PlacementOperation placementOperation,
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      Entity parentEntity,
      int parentInternalIndex,
      Translation oldTranslation,
      Rotation oldRotation,
      Translation newTranslation,
      Rotation newRotation,
      NativeHashSet<Entity> checkedEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &placementOperation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &parentInternalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &oldTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &oldRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &newTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &checkedEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddInternalTileModelAttachedChildren_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_Entity_Int32_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1133528, RefRangeEnd = 1133530, XrefRangeStart = 1133461, XrefRangeEnd = 1133528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddInternalTileModelFusedChildren(
      PlacementOperation placementOperation,
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      Entity parentEntity,
      int parentInternalIndex,
      Translation oldTranslation,
      Rotation oldRotation,
      Translation newTranslation,
      Rotation newRotation,
      NativeHashSet<Entity> checkedEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &placementOperation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &parentInternalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &oldTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &oldRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &newTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &checkedEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddInternalTileModelFusedChildren_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_Entity_Int32_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1133578, RefRangeEnd = 1133580, XrefRangeStart = 1133530, XrefRangeEnd = 1133578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CalculateInternalTileModelBounds(
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      out NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelsBounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalTileModelsBounds;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CalculateInternalTileModelBounds_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_byref_NativeArray_1_InternalTileModelBounds_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133641, RefRangeEnd = 1133642, XrefRangeStart = 1133580, XrefRangeEnd = 1133641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetMergedLocalBounds(
      ref GetPlacementResult.JobData jobData,
      Entity prefabEntity,
      int internalIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetMergedLocalBounds_Private_Static_BoundsMinMax_byref_JobData_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133811, RefRangeEnd = 1133812, XrefRangeStart = 1133642, XrefRangeEnd = 1133811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FetchAllPlacementDatas(
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeHashMap<Entity, int> isInternalEntityMap,
      NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelsBounds,
      out NativeMultiHashMap<int3, GetPlacementResult.TileModelPlacementData> placementDatasPerWorldTile,
      out NativeMultiHashMap<int, Entity> attachedExternalEntitiesInNewBoundsByInternalIndex,
      out NativeMultiHashMap<int, Entity> attachedExternalEntitiesInOldBoundsByInternalIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isInternalEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref placementDatasPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref attachedExternalEntitiesInNewBoundsByInternalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref attachedExternalEntitiesInOldBoundsByInternalIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_FetchAllPlacementDatas_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeHashMap_2_Entity_Int32_NativeArray_1_InternalTileModelBounds_byref_NativeMultiHashMap_2_int3_TileModelPlacementData_byref_NativeMultiHashMap_2_Int32_Entity_byref_NativeMultiHashMap_2_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133820, RefRangeEnd = 1133821, XrefRangeStart = 1133812, XrefRangeEnd = 1133820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FilterOutFromHeightLayerIncludeStairs(
      ComponentDataFromEntity<TilePosition> getTilePosition,
      int requiredHeightLevel,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &requiredHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_FilterOutFromHeightLayerIncludeStairs_Private_Static_Boolean_ComponentDataFromEntity_1_TilePosition_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133835, RefRangeEnd = 1133836, XrefRangeStart = 1133821, XrefRangeEnd = 1133835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryGetStaticPlacementData(
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelsBounds,
      NativeMultiHashMap<int3, GetPlacementResult.TileModelPlacementData> placementDatasPerWorldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &placementDatasPerWorldTile;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryGetStaticPlacementData_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133846, RefRangeEnd = 1133847, XrefRangeStart = 1133836, XrefRangeEnd = 1133846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetStaticTileDataWithinBounds(
      ref GetPlacementResult.GetStaticTileDataRequirements jobData,
      NativeMultiHashMap<int3, GetPlacementResult.TileModelPlacementData> placementDatasPerWorldTile,
      BoundsMinMax worldBounds,
      byte targetHeightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &placementDatasPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &targetHeightLevel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetStaticTileDataWithinBounds_Public_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1133884, RefRangeEnd = 1133886, XrefRangeStart = 1133847, XrefRangeEnd = 1133884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryGetBakedPlacementTiles(
      ref GetPlacementResult.GetStaticTileDataRequirements jobData,
      NativeMultiHashMap<int3, GetPlacementResult.TileModelPlacementData> placementDatasPerWorldTile,
      BoundsMinMax intersectedChunkBounds,
      int2 chunkTileOffset,
      byte targetHeightLevel,
      Entity chunkEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &placementDatasPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &intersectedChunkBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkTileOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &targetHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryGetBakedPlacementTiles_Private_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_int2_Byte_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133901, RefRangeEnd = 1133902, XrefRangeStart = 1133886, XrefRangeEnd = 1133901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WritePlacement(
      Entity chunkEntity,
      TilePosition tilePosition,
      ref TileDatas2dArray<PlacementData> placementTiles,
      BoundsMinMax bounds,
      int2 chunkTileOffset,
      NativeMultiHashMap<int3, GetPlacementResult.TileModelPlacementData> placementDatasPerWorldTile,
      byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &chunkEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref placementTiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkTileOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &placementDatasPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_WritePlacement_Private_Static_Void_Entity_TilePosition_byref_TileDatas2dArray_1_PlacementData_BoundsMinMax_int2_NativeMultiHashMap_2_int3_TileModelPlacementData_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1133921, RefRangeEnd = 1133923, XrefRangeStart = 1133902, XrefRangeEnd = 1133921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryGetBlockedTiles(
      ref GetPlacementResult.GetStaticTileDataRequirements jobData,
      NativeMultiHashMap<int3, GetPlacementResult.TileModelPlacementData> placementDatasPerWorldTile,
      BoundsMinMax intersectedWorldBounds,
      byte heightLevel,
      Entity chunkEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &placementDatasPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &intersectedWorldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryGetBlockedTiles_Private_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_Byte_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133945, RefRangeEnd = 1133946, XrefRangeStart = 1133923, XrefRangeEnd = 1133945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetRoadsFromChunks(
      ref GetPlacementResult.JobData jobData,
      NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelsBounds,
      out NativeHashSet<int2> roadPerWorldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref roadPerWorldTile;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetRoadsFromChunks_Private_Static_Void_byref_JobData_NativeArray_1_InternalTileModelBounds_byref_NativeHashSet_1_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe GetPlacementResult.MergedPlacementJobData GetMergedPlacementJobData(
      ref GetPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetMergedPlacementJobData_Private_Static_MergedPlacementJobData_byref_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetPlacementResult.MergedPlacementJobData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1133962, RefRangeEnd = 1133963, XrefRangeStart = 1133946, XrefRangeEnd = 1133962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetPlacementResult.MergedPlacementJobData GetMergedPlacementJobData(
      SystemBase systemBase)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetMergedPlacementJobData_Public_Static_MergedPlacementJobData_SystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetPlacementResult.MergedPlacementJobData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1134036, RefRangeEnd = 1134043, XrefRangeStart = 1133963, XrefRangeEnd = 1134036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetMergedPlacementDatas(
      GetPlacementResult.MergedPlacementJobData jobData,
      NativeHashMap<int3, PlacementData> mergedPlacementDatas,
      Entity parentEntity,
      int2 parentTilePosition,
      float parentPositionY,
      TileRotation parentTileRotation,
      bool isPrefabEntity,
      bool checkChildren = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mergedPlacementDatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &parentTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &parentPositionY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &parentTileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &isPrefabEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &checkChildren;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetMergedPlacementDatas_Public_Static_Void_MergedPlacementJobData_NativeHashMap_2_int3_PlacementData_Entity_int2_Single_TileRotation_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134445, RefRangeEnd = 1134446, XrefRangeStart = 1134043, XrefRangeEnd = 1134445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetInternalPlacementResultsAndAttachments(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelsBounds,
      NativeMultiHashMap<int3, GetPlacementResult.TileModelPlacementData> placementDatasPerWorldTile,
      NativeHashSet<int2> roadPerWorldTile,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      out NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      out NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      out NativeList<GetPlacementResult.InternalDestroyTileModelData> finalReplacements,
      out NativeList<GetPlacementResult.InternalAttachTileModelData> finalAttachments)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &placementDatasPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &roadPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref finalReplacements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref finalAttachments;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetInternalPlacementResultsAndAttachments_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_NativeHashSet_1_int2_NativeMultiHashMap_2_Int32_InternalTileModelDependency_byref_NativeArray_1_InternalTileModelPlacementResults_byref_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_byref_NativeList_1_InternalDestroyTileModelData_byref_NativeList_1_InternalAttachTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1134460, RefRangeEnd = 1134465, XrefRangeStart = 1134446, XrefRangeEnd = 1134460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddBlockReason(
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      int internalIndex,
      GetPlacementResult.InternalTileModelBlockReasonData blockReasonData,
      bool avoidDuplicates = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &blockReasonData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &avoidDuplicates;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddBlockReason_Private_Static_Void_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Int32_InternalTileModelBlockReasonData_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134481, RefRangeEnd = 1134482, XrefRangeStart = 1134465, XrefRangeEnd = 1134481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckRestrictionAreas(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeKeyValueArrays<int3, PlacementData> mergedPlacementKeyValuePair,
      BoundsMinMax worldBounds,
      int2 tilePosition,
      ref GetPlacementResult.TileModelBlockReasons blockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mergedPlacementKeyValuePair;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckRestrictionAreas_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_int2_byref_TileModelBlockReasons_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134518, RefRangeEnd = 1134519, XrefRangeStart = 1134482, XrefRangeEnd = 1134518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckMapZoneRestrictions(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeKeyValueArrays<int3, PlacementData> mergedPlacementKeyValuePair,
      BoundsMinMax worldBounds,
      ref GetPlacementResult.TileModelBlockReasons blockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mergedPlacementKeyValuePair;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckMapZoneRestrictions_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_TileModelBlockReasons_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1134563, RefRangeEnd = 1134565, XrefRangeStart = 1134519, XrefRangeEnd = 1134563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BlockReason CheckIfInRestrictionArea(
      Entity characterEntity,
      Team characterTeam,
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeList<Entity> restrictionAreas,
      int2 tilePosition,
      PlacementTypeData placementTypes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &characterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &characterTeam;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictionAreas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &placementTypes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckIfInRestrictionArea_Private_Static_BlockReason_Entity_Team_byref_Operation_byref_JobData_NativeList_1_Entity_int2_PlacementTypeData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlockReason*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134632, RefRangeEnd = 1134633, XrefRangeStart = 1134565, XrefRangeEnd = 1134632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckPlacementHistory(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeKeyValueArrays<int3, PlacementData> mergedPlacementKeyValuePair,
      BoundsMinMax worldBounds,
      ref GetPlacementResult.TileModelBlockReasons blockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mergedPlacementKeyValuePair;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckPlacementHistory_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_TileModelBlockReasons_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134647, RefRangeEnd = 1134648, XrefRangeStart = 1134633, XrefRangeEnd = 1134647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckCastleTeleporters(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      Entity castleHeart,
      ref GetPlacementResult.TileModelBlockReasons blockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckCastleTeleporters_Private_Static_Void_byref_Operation_byref_JobData_Entity_byref_TileModelBlockReasons_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134648, XrefRangeEnd = 1134658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ContainsAttachment(
      NativeList<GetPlacementResult.InternalAttachTileModelData> attachments,
      GetPlacementResult.InternalOrExternalEntityId child,
      GetPlacementResult.InternalOrExternalEntityId parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &attachments;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &child;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parent;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_ContainsAttachment_Private_Static_Boolean_NativeList_1_InternalAttachTileModelData_InternalOrExternalEntityId_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AttachNetworkedChildrenToRootParent(
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      NativeList<GetPlacementResult.InternalAttachTileModelData> attachments)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &attachments;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AttachNetworkedChildrenToRootParent_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalAttachTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134678, RefRangeEnd = 1134679, XrefRangeStart = 1134658, XrefRangeEnd = 1134678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CancelIfOnlyUpgradeableAndNotUpgrading(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CancelIfOnlyUpgradeableAndNotUpgrading_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134700, RefRangeEnd = 1134701, XrefRangeStart = 1134679, XrefRangeEnd = 1134700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CancelPlacementsBasedOnDependencyTree(
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      out int dependencyTreeIterations)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref dependencyTreeIterations;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CancelPlacementsBasedOnDependencyTree_Private_Static_Void_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134701, XrefRangeEnd = 1134716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CancelReplacements(
      NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      NativeList<GetPlacementResult.InternalDestroyTileModelData> finalReplacements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &finalReplacements;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CancelReplacements_Private_Static_Void_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalDestroyTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134731, RefRangeEnd = 1134732, XrefRangeStart = 1134716, XrefRangeEnd = 1134731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CancelPlacementsBasedOnInternalReplacements(
      NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      NativeList<GetPlacementResult.InternalDestroyTileModelData> finalReplacements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &finalReplacements;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CancelPlacementsBasedOnInternalReplacements_Private_Static_Void_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134852, RefRangeEnd = 1134853, XrefRangeStart = 1134732, XrefRangeEnd = 1134852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CancelAttachments(
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      NativeList<GetPlacementResult.InternalDestroyTileModelData> finalReplacements,
      NativeList<GetPlacementResult.InternalAttachTileModelData> finalAttachments)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &finalReplacements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &finalAttachments;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CancelAttachments_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134853, XrefRangeEnd = 1134867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetExistingEntity(
      GetPlacementResult.InternalOrExternalEntityId id,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      out Entity resultEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref resultEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryGetExistingEntity_Private_Static_Boolean_InternalOrExternalEntityId_NativeList_1_InternalTileModel_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1134978, RefRangeEnd = 1134979, XrefRangeStart = 1134867, XrefRangeEnd = 1134978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<DetachTileModelData> GetDetachments(
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      NativeList<GetPlacementResult.InternalAttachTileModelData> finalAttachments,
      NativeMultiHashMap<int, Entity> attachedExternalEntitiesInNewBoundsByInternalIndex,
      NativeMultiHashMap<int, Entity> attachedExternalEntitiesInOldBoundsByInternalIndex,
      out NativeList<DetachTileModelData> detachments)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &finalAttachments;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &attachedExternalEntitiesInNewBoundsByInternalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &attachedExternalEntitiesInOldBoundsByInternalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref detachments;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetDetachments_Private_Static_NativeList_1_DetachTileModelData_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_Entity_NativeMultiHashMap_2_Int32_Entity_byref_NativeList_1_DetachTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<DetachTileModelData>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1135161, RefRangeEnd = 1135162, XrefRangeStart = 1134979, XrefRangeEnd = 1135161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupPlacementResult(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelBounds,
      NativeArray<GetPlacementResult.InternalTileModelPlacementResults> internalTileModelsPlacementResults,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      NativeList<GetPlacementResult.InternalDestroyTileModelData> finalReplacements,
      NativeList<GetPlacementResult.InternalAttachTileModelData> finalAttachments,
      NativeList<DetachTileModelData> detachments,
      out PlacementResult result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsPlacementResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &finalReplacements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &finalAttachments;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &detachments;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_SetupPlacementResult_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_NativeList_1_DetachTileModelData_byref_PlacementResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1135180, RefRangeEnd = 1135182, XrefRangeStart = 1135162, XrefRangeEnd = 1135180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupPlacementResultBlockReasons(
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      PlacementResult result,
      int internalIndex,
      GetPlacementResult.InternalTileModel internalTileModel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_SetupPlacementResultBlockReasons_Private_Static_Void_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_PlacementResult_Int32_InternalTileModel_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1135203, RefRangeEnd = 1135208, XrefRangeStart = 1135182, XrefRangeEnd = 1135203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementResult CreateEmtpyResult(
      PlacementOperation placementOperation,
      Entity characterEntity,
      Nullable_Unboxed<Team> userTeam,
      bool keepTeamDuringTransform,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &placementOperation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &characterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userTeam;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &keepTeamDuringTransform;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CreateEmtpyResult_Private_Static_PlacementResult_PlacementOperation_Entity_Nullable_Unboxed_1_Team_Boolean_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135208, XrefRangeEnd = 1135220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementResult GetSimpleBlockedPlacementResult(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetSimpleBlockedPlacementResult_Private_Static_PlacementResult_byref_Operation_byref_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1135296, RefRangeEnd = 1135299, XrefRangeStart = 1135220, XrefRangeEnd = 1135296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddDetachmentsBasedOnDestroyDatas(
      ref GetPlacementResult.JobData jobData,
      PlacementResult result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddDetachmentsBasedOnDestroyDatas_Private_Static_Void_byref_JobData_PlacementResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1135308, RefRangeEnd = 1135310, XrefRangeStart = 1135299, XrefRangeEnd = 1135308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ContainsReplaceData(
      NativeList<GetPlacementResult.InternalDestroyTileModelData> finalReplacements,
      GetPlacementResult.InternalOrExternalEntityId entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &finalReplacements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_ContainsReplaceData_Private_Static_Boolean_NativeList_1_InternalDestroyTileModelData_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1135319, RefRangeEnd = 1135322, XrefRangeStart = 1135310, XrefRangeEnd = 1135319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ContainsDestroyData(
      NativeList<DestroyTileModelData> tileModelsToDestroy,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileModelsToDestroy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_ContainsDestroyData_Private_Static_Boolean_NativeList_1_DestroyTileModelData_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1135334, RefRangeEnd = 1135336, XrefRangeStart = 1135322, XrefRangeEnd = 1135334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ContainsDetachData(
      NativeList<DetachTileModelData> tileModelsToDetach,
      DetachTileModelData detachData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileModelsToDetach;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &detachData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_ContainsDetachData_Private_Static_Boolean_NativeList_1_DetachTileModelData_DetachTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1135363, RefRangeEnd = 1135367, XrefRangeStart = 1135336, XrefRangeEnd = 1135363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddDestroyDataRecursive(
      PlacementOperation placementOperation,
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      NativeList<Entity> checkedEntities,
      NativeList<DestroyTileModelData> tileModelsToDestroy,
      NativeList<DetachTileModelData> tileModelsToDetach,
      NativeList<GetPlacementResult.InternalAttachTileModelData> finalAttachments,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      bool addBlockReasonIfFailedToDestroy,
      Entity currentEntity,
      bool isFromDismantle,
      TileModelDestroyReason destroyReason,
      Nullable_Unboxed<PlacementEntityId> entityCausedDestruction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[14];
      numPtr[0] = (System.IntPtr) &placementOperation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &checkedEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelsToDestroy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelsToDetach;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &finalAttachments;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &addBlockReasonIfFailedToDestroy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &currentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &isFromDismantle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCausedDestruction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddDestroyDataRecursive_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeList_1_Entity_NativeList_1_DestroyTileModelData_NativeList_1_DetachTileModelData_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Boolean_Entity_Boolean_TileModelDestroyReason_Nullable_Unboxed_1_PlacementEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1135383, RefRangeEnd = 1135384, XrefRangeStart = 1135367, XrefRangeEnd = 1135383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAnyFusedDependencySillNotDestroyed(
      Entity entityToDestroy,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelDependency> dependencyTree,
      NativeList<DestroyTileModelData> temporaryTileModelsToDestroy)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityToDestroy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyTree;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &temporaryTileModelsToDestroy;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_IsAnyFusedDependencySillNotDestroyed_Private_Static_Boolean_Entity_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeList_1_DestroyTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135384, XrefRangeEnd = 1135393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInternalEntity(
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      Entity entity,
      out GetPlacementResult.InternalOrExternalEntityId internalEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryGetInternalEntity_Private_Static_Boolean_NativeList_1_InternalTileModel_Entity_byref_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1135581, RefRangeEnd = 1135585, XrefRangeStart = 1135393, XrefRangeEnd = 1135581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddDestroyDataRecursiveInternal(
      PlacementOperation placementOperation,
      ref GetPlacementResult.JobData jobData,
      NativeList<Entity> checkedEntities,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeList<DestroyTileModelData> tileModelsToDestroy,
      NativeList<DetachTileModelData> tileModelsToDetach,
      NativeList<GetPlacementResult.InternalAttachTileModelData> finalAttachments,
      NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> internalTileModelBlockReasons,
      bool addBlockReasonIfFailedToDestroy,
      Entity currentEntity,
      bool isFromDismantle,
      TileModelDestroyReason destroyReason,
      Nullable_Unboxed<PlacementEntityId> entityCausedDestruction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[13];
      numPtr[0] = (System.IntPtr) &placementOperation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &checkedEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelsToDestroy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelsToDetach;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &finalAttachments;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelBlockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &addBlockReasonIfFailedToDestroy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &currentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &isFromDismantle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCausedDestruction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddDestroyDataRecursiveInternal_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_Entity_NativeList_1_InternalTileModel_NativeList_1_DestroyTileModelData_NativeList_1_DetachTileModelData_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Boolean_Entity_Boolean_TileModelDestroyReason_Nullable_Unboxed_1_PlacementEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135585, XrefRangeEnd = 1135594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInternalTileModelIndex(
      Entity currentEntity,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      out int currentInternalTileModelIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &currentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentInternalTileModelIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryGetInternalTileModelIndex_Private_Static_Boolean_Entity_NativeList_1_InternalTileModel_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135594, XrefRangeEnd = 1135599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckRoads(
      ref GetPlacementResult.JobData jobData,
      NativeHashSet<int2> roadPerWorldTile,
      NativeKeyValueArrays<int3, PlacementData> mergedPlacementKeyValuePair,
      [In] ref CastleAreaRequirement castleAreaRequirement,
      ref GetPlacementResult.TileModelBlockReasons blockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &roadPerWorldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mergedPlacementKeyValuePair;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleAreaRequirement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckRoads_Private_Static_Void_byref_JobData_NativeHashSet_1_int2_NativeKeyValueArrays_2_int3_PlacementData_byref_CastleAreaRequirement_byref_TileModelBlockReasons_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1135706, RefRangeEnd = 1135707, XrefRangeStart = 1135599, XrefRangeEnd = 1135706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckCastleTerritoryZone(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeKeyValueArrays<int3, PlacementData> mergedPlacementKeyValuePair,
      BoundsMinMax worldBounds,
      [In] ref CastleAreaRequirement castleAreaRequirement,
      ref GetPlacementResult.InternalTileModel internalTileModel,
      ref GetPlacementResult.TileModelBlockReasons blockReasons,
      out Entity attachToCastleHeart,
      out Entity attachToCastleTerritory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mergedPlacementKeyValuePair;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleAreaRequirement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalTileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref attachToCastleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref attachToCastleTerritory;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckCastleTerritoryZone_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_CastleAreaRequirement_byref_InternalTileModel_byref_TileModelBlockReasons_byref_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135707, XrefRangeEnd = 1135711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetTeam(
      Entity entity,
      ComponentDataFromEntity<Team> teamFromEntity,
      out Team team)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &teamFromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryGetTeam_Private_Static_Boolean_Entity_ComponentDataFromEntity_1_Team_byref_Team_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1135737, RefRangeEnd = 1135738, XrefRangeStart = 1135711, XrefRangeEnd = 1135737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanBuildWithTerritoryRequirement_AttachToOwnedArea(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      ref GetPlacementResult.TileModelBlockReasons blockReasons,
      Entity buildingInCastleTerritory,
      Entity castleHeartForArea,
      bool hasDisallowedTileOutsideOfTerritory,
      out Entity attachToCastleTerritory,
      out Entity attachToCastleHeart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buildingInCastleTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartForArea;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hasDisallowedTileOutsideOfTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref attachToCastleTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref attachToCastleHeart;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_AttachToOwnedArea_Private_Static_Boolean_byref_Operation_byref_JobData_byref_TileModelBlockReasons_Entity_Entity_Boolean_byref_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1135774, RefRangeEnd = 1135775, XrefRangeStart = 1135738, XrefRangeEnd = 1135774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanBuildWithTerritoryRequirement_PlaceableInWorldExceptInEnemyArea(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      ref GetPlacementResult.TileModelBlockReasons blockReasons,
      Entity buildingInCastleTerritory,
      Entity castleHeartForArea)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buildingInCastleTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartForArea;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInWorldExceptInEnemyArea_Private_Static_Boolean_byref_Operation_byref_JobData_byref_TileModelBlockReasons_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135775, XrefRangeEnd = 1135781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanBuildWithTerritoryRequirement_PlaceableInNeutralArea(
      ref GetPlacementResult.TileModelBlockReasons blockReasons,
      Entity buildingInCastleTerritory,
      Entity castleHeartForArea,
      bool territoryIsGlobalDebugTerritory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref blockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buildingInCastleTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartForArea;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &territoryIsGlobalDebugTerritory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInNeutralArea_Private_Static_Boolean_byref_TileModelBlockReasons_Entity_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1135812, RefRangeEnd = 1135813, XrefRangeStart = 1135781, XrefRangeEnd = 1135812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanBuildWithTerritoryRequirement_PlaceableInClaimableTerritory(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      ref GetPlacementResult.InternalTileModel internalTileModel,
      ref GetPlacementResult.TileModelBlockReasons blockReasons,
      Entity buildingInCastleTerritory,
      Entity castleHeartForArea,
      bool hasDisallowedTileOutsideOfTerritory,
      out Entity attachToCastleTerritory,
      out Entity attachToCastleHeart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalTileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &buildingInCastleTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartForArea;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hasDisallowedTileOutsideOfTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref attachToCastleTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref attachToCastleHeart;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInClaimableTerritory_Private_Static_Boolean_byref_Operation_byref_JobData_byref_InternalTileModel_byref_TileModelBlockReasons_Entity_Entity_Boolean_byref_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1136084, RefRangeEnd = 1136086, XrefRangeStart = 1135813, XrefRangeEnd = 1136084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckFloorTerritory(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      Entity castleHeartEntity,
      Entity castleTerritoryEntity,
      ref GetPlacementResult.InternalTileModel internalTileModel,
      NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelsBounds,
      NativeHashMap<GetPlacementResult.InternalOrExternalEntityId, NeighbourFilter> groundConnectedFloors,
      NativeHashSet<GetPlacementResult.InternalOrExternalEntityId> groundDisconnectedFloors,
      ref GetPlacementResult.TileModelBlockReasons blockReasons)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &castleTerritoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref internalTileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &groundConnectedFloors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &groundDisconnectedFloors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckFloorTerritory_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_Entity_Entity_byref_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeHashMap_2_InternalOrExternalEntityId_NeighbourFilter_NativeHashSet_1_InternalOrExternalEntityId_byref_TileModelBlockReasons_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136086, XrefRangeEnd = 1136092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RoomUtility.GetNeighbourFloorsJobData RoomUtilityGetNeighbourJobData(
      GetPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_RoomUtilityGetNeighbourJobData_Private_Static_GetNeighbourFloorsJobData_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RoomUtility.GetNeighbourFloorsJobData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136121, RefRangeEnd = 1136122, XrefRangeStart = 1136092, XrefRangeEnd = 1136121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckTerritoryNonFloors(
      ref GetPlacementResult.Operation operation,
      ref GetPlacementResult.JobData jobData,
      Entity castleHeartEntity,
      ref GetPlacementResult.TileModelBlockReasons blockReasons,
      Entity tileModelEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockReasons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_CheckTerritoryNonFloors_Private_Static_Void_byref_Operation_byref_JobData_Entity_byref_TileModelBlockReasons_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136122, XrefRangeEnd = 1136147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<GetPlacementResult.NeighbourFloorsInternalResult> MergeNeighbourFloors(
      NativeList<RoomUtility.NeighbourFloorsResult> neighbourFloorsExternal,
      NativeList<GetPlacementResult.NeighbourFloorsInternalResult> neighbourFloorsInternal,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &neighbourFloorsExternal;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &neighbourFloorsInternal;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_MergeNeighbourFloors_Private_Static_NativeList_1_NeighbourFloorsInternalResult_NativeList_1_NeighbourFloorsResult_NativeList_1_NeighbourFloorsInternalResult_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<GetPlacementResult.NeighbourFloorsInternalResult>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1136199, RefRangeEnd = 1136201, XrefRangeStart = 1136147, XrefRangeEnd = 1136199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<GetPlacementResult.NeighbourFloorsInternalResult> GetInternalNeighbourFloors(
      ref RoomUtility.GetNeighbourFloorsJobData jobData,
      TilePosition tilePosition,
      TilePivotSettings pivotSettings,
      CastleFloor castleFloor,
      CastleStairs castleStairs,
      Nullable_Unboxed<Entity> castleStairsEntity,
      NeighbourFilter requireFilter,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &castleStairs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &castleStairsEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &requireFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetInternalNeighbourFloors_Private_Static_NativeList_1_NeighbourFloorsInternalResult_byref_GetNeighbourFloorsJobData_TilePosition_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_NativeList_1_InternalTileModel_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<GetPlacementResult.NeighbourFloorsInternalResult>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136238, RefRangeEnd = 1136239, XrefRangeStart = 1136201, XrefRangeEnd = 1136238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<Entity> GetNeighbourFloorsAndNearbyCastleFloors(
      byte requiredHeightLevel,
      int distanceInFloors,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      SpatialLookupParams spatialLookupParams,
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      NativeArray<GetPlacementResult.InternalTileModelBounds> internalTileModelsBounds,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &requiredHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &distanceInFloors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialLookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelsBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetNeighbourFloorsAndNearbyCastleFloors_Private_Static_NativeList_1_Entity_Byte_Int32_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_CastleFloor_SpatialLookupParams_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136239, XrefRangeEnd = 1136248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindConnectedFloor(
      ref GetPlacementResult.GetNeighbourFloorsJobData jobData,
      GetPlacementResult.InternalOrExternalEntityId floorToSearchFrom,
      GetPlacementResult.InternalOrExternalEntityId floorToFind,
      NeighbourFilter neighborFilter,
      GetPlacementResult.InternalOrExternalEntityId floorEntityToExclude)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorToSearchFrom;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorToFind;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntityToExclude;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryFindConnectedFloor_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_InternalOrExternalEntityId_NeighbourFilter_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1136260, RefRangeEnd = 1136263, XrefRangeStart = 1136248, XrefRangeEnd = 1136260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindConnectedFloorNested(
      ref GetPlacementResult.GetNeighbourFloorsJobData jobData,
      GetPlacementResult.InternalOrExternalEntityId floorEntity,
      GetPlacementResult.InternalOrExternalEntityId floorToFind,
      NeighbourFilter neighborFilter,
      ref NativeList<GetPlacementResult.InternalOrExternalEntityId> searchedFloors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorToFind;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref searchedFloors;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryFindConnectedFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_InternalOrExternalEntityId_NeighbourFilter_byref_NativeList_1_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136263, XrefRangeEnd = 1136267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasExternalNeighbor(
      ref GetPlacementResult.GetNeighbourFloorsJobData neighbourFloorsData,
      GetPlacementResult.InternalOrExternalEntityId floorEntity,
      NeighbourFilter neighborFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref neighbourFloorsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborFilter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_HasExternalNeighbor_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1136276, RefRangeEnd = 1136279, XrefRangeStart = 1136267, XrefRangeEnd = 1136276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FindNonInternalNeighborNested(
      ref GetPlacementResult.GetNeighbourFloorsJobData neighbourFloorsData,
      GetPlacementResult.InternalOrExternalEntityId floorEntityId,
      NeighbourFilter neighborFilter,
      ref NativeHashSet<GetPlacementResult.InternalOrExternalEntityId> searchedFloors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref neighbourFloorsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntityId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref searchedFloors;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_FindNonInternalNeighborNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_byref_NativeHashSet_1_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136298, RefRangeEnd = 1136299, XrefRangeStart = 1136279, XrefRangeEnd = 1136298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AnyNeighborHasGroundConnection(
      ref GetPlacementResult.GetNeighbourFloorsJobData neighbourFloorsData,
      [In] ref TileWorld tileWorld,
      GetPlacementResult.InternalOrExternalEntityId floorEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref neighbourFloorsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AnyNeighborHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136299, XrefRangeEnd = 1136303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AllNeighborsHasGroundConnection(
      ref GetPlacementResult.GetNeighbourFloorsJobData neighbourFloorsData,
      [In] ref TileWorld tileWorld,
      GetPlacementResult.InternalOrExternalEntityId floorEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref neighbourFloorsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AllNeighborsHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1136342, RefRangeEnd = 1136345, XrefRangeStart = 1136303, XrefRangeEnd = 1136342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AllNeighborsHasGroundConnection(
      ref GetPlacementResult.GetNeighbourFloorsJobData neighbourFloorsData,
      [In] ref TileWorld tileWorld,
      GetPlacementResult.InternalOrExternalEntityId floorEntity,
      ref NativeList<GetPlacementResult.InternalOrExternalEntityId> floorsToExclude)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref neighbourFloorsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorsToExclude;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AllNeighborsHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_byref_NativeList_1_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136345, XrefRangeEnd = 1136351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddAll(
      this NativeHashSet<GetPlacementResult.InternalOrExternalEntityId> source,
      NativeHashSet<GetPlacementResult.InternalOrExternalEntityId> target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddAll_Private_Static_Void_NativeHashSet_1_InternalOrExternalEntityId_NativeHashSet_1_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136364, RefRangeEnd = 1136365, XrefRangeStart = 1136351, XrefRangeEnd = 1136364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddAll(
      this NativeHashMap<GetPlacementResult.InternalOrExternalEntityId, NeighbourFilter> source,
      NativeHashSet<GetPlacementResult.InternalOrExternalEntityId> target,
      NeighbourFilter targetFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFilter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AddAll_Private_Static_Void_NativeHashMap_2_InternalOrExternalEntityId_NeighbourFilter_NativeHashSet_1_InternalOrExternalEntityId_NeighbourFilter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1136388, RefRangeEnd = 1136391, XrefRangeStart = 1136365, XrefRangeEnd = 1136388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindGroundedFloorNested(
      ref GetPlacementResult.GetNeighbourFloorsJobData jobData,
      [In] ref TileWorld tileWorld,
      GetPlacementResult.InternalOrExternalEntityId floorEntityId,
      NeighbourFilter neighborFilter,
      ref NativeHashSet<GetPlacementResult.InternalOrExternalEntityId> searchedFloors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntityId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref searchedFloors;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryFindGroundedFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_NeighbourFilter_byref_NativeHashSet_1_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136417, RefRangeEnd = 1136418, XrefRangeStart = 1136391, XrefRangeEnd = 1136417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsStairsGrounded(
      ref GetPlacementResult.GetNeighbourFloorsJobData jobData,
      [In] ref TileWorld tileWorld,
      Entity entity,
      [In] ref CastleStairs castleStairs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleStairs;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_IsStairsGrounded_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_Entity_byref_CastleStairs_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136418, XrefRangeEnd = 1136431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AnyNeighborHasCastleHeartConnection(
      ref GetPlacementResult.GetNeighbourFloorsJobData neighbourFloorsData,
      GetPlacementResult.InternalOrExternalEntityId floorEntity,
      ComponentDataFromEntity<CastleHeart> getCastleHeart,
      out GetPlacementResult.InternalOrExternalEntityId castleHeart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref neighbourFloorsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AnyNeighborHasCastleHeartConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_ComponentDataFromEntity_1_CastleHeart_byref_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136458, RefRangeEnd = 1136459, XrefRangeStart = 1136431, XrefRangeEnd = 1136458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AllNeighborsHasCastleHeartConnection(
      ref GetPlacementResult.GetNeighbourFloorsJobData neighbourFloorsData,
      GetPlacementResult.InternalOrExternalEntityId floorEntity,
      ref NativeList<GetPlacementResult.InternalOrExternalEntityId> floorsToExclude,
      ComponentDataFromEntity<CastleHeart> getCastleHeart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref neighbourFloorsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorsToExclude;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleHeart;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AllNeighborsHasCastleHeartConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_byref_NativeList_1_InternalOrExternalEntityId_ComponentDataFromEntity_1_CastleHeart_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1136480, RefRangeEnd = 1136484, XrefRangeStart = 1136459, XrefRangeEnd = 1136480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindCastleHeartForFloorNested(
      ref GetPlacementResult.GetNeighbourFloorsJobData jobData,
      GetPlacementResult.InternalOrExternalEntityId floorEntity,
      NeighbourFilter neighborFilter,
      ComponentDataFromEntity<CastleHeart> getCastleHeart,
      ref NativeHashSet<GetPlacementResult.InternalOrExternalEntityId> searchedFloors,
      out GetPlacementResult.InternalOrExternalEntityId castleHeart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref searchedFloors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_TryFindCastleHeartForFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_ComponentDataFromEntity_1_CastleHeart_byref_NativeHashSet_1_InternalOrExternalEntityId_byref_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1136559, RefRangeEnd = 1136561, XrefRangeStart = 1136484, XrefRangeEnd = 1136559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AnyUnitsOnElevatedFloor(
      ref GetPlacementResult.JobData jobData,
      Entity floorEntity,
      out Entity unitEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_AnyUnitsOnElevatedFloor_Private_Static_Boolean_byref_JobData_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136579, RefRangeEnd = 1136580, XrefRangeStart = 1136561, XrefRangeEnd = 1136579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TilePosition GetTilePosition(
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      GetPlacementResult.InternalOrExternalEntityId entityId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetTilePosition_Private_Static_TilePosition_NativeList_1_InternalTileModel_ComponentDataFromEntity_1_TilePosition_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TilePosition*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136606, RefRangeEnd = 1136607, XrefRangeStart = 1136580, XrefRangeEnd = 1136606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleStairs GetCastleStairs(
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      ComponentDataFromEntity<CastleStairs> getCastleStairs,
      GetPlacementResult.InternalOrExternalEntityId entityId,
      out Nullable_Unboxed<Entity> castleStairsEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleStairs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleStairsEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetCastleStairs_Private_Static_CastleStairs_NativeList_1_InternalTileModel_ComponentDataFromEntity_1_CastleStairs_InternalOrExternalEntityId_byref_Nullable_Unboxed_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleStairs*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136607, XrefRangeEnd = 1136610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetPrefabOrEntity(
      NativeList<GetPlacementResult.InternalTileModel> internalTileModels,
      GetPlacementResult.InternalOrExternalEntityId entityId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &internalTileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetPrefabOrEntity_Private_Static_Entity_NativeList_1_InternalTileModel_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1136614, RefRangeEnd = 1136619, XrefRangeStart = 1136610, XrefRangeEnd = 1136614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NeighbourFilter GetNeighborFilter(
      ref GetPlacementResult.GetNeighbourFloorsJobData jobData,
      [In] ref GetPlacementResult.InternalOrExternalEntityId floorEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetNeighborFilter_Private_Static_NeighbourFilter_byref_GetNeighbourFloorsJobData_byref_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NeighbourFilter*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe NeighbourFilter GetNeighborFilter([In] ref CastleFloor castleFloor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref castleFloor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetNeighborFilter_Private_Static_NeighbourFilter_byref_CastleFloor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NeighbourFilter*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136619, XrefRangeEnd = 1136621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetPlacementResult.InternalNeighbourFloorsEnumerator GetNeighbourFloors(
      ref GetPlacementResult.GetNeighbourFloorsJobData jobData,
      GetPlacementResult.InternalOrExternalEntityId floorEntity,
      NeighbourFilter neighborFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborFilter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_GetNeighbourFloors_Private_Static_InternalNeighbourFloorsEnumerator_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetPlacementResult.InternalNeighbourFloorsEnumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136621, XrefRangeEnd = 1136622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax Method_Internal_Static_BoundsMinMax_int2_PDM_0(int2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NativeMethodInfoPtr_Method_Internal_Static_BoundsMinMax_int2_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GetPlacementResult()
    {
      Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (GetPlacementResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr);
      GetPlacementResult.NativeMethodInfoPtr_GetResult_Public_Static_PlacementResult_byref_Operation_byref_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689833);
      GetPlacementResult.NativeMethodInfoPtr_CanPerformOperation_Private_Static_Boolean_Entity_byref_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689834);
      GetPlacementResult.NativeMethodInfoPtr_GetOperationFromFusedParent_Private_Static_Operation_byref_Operation_byref_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689835);
      GetPlacementResult.NativeMethodInfoPtr_LogDebug_Private_Static_Void_Operation_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_Int32_NativeList_1_DetachTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689836);
      GetPlacementResult.NativeMethodInfoPtr_GetDismantleResult_Private_Static_PlacementResult_byref_Operation_byref_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689837);
      GetPlacementResult.NativeMethodInfoPtr_LogDismantleDebug_Private_Static_Void_Operation_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689838);
      GetPlacementResult.NativeMethodInfoPtr_CheckSiege_Private_Static_Void_byref_JobData_InternalTileModel_byref_TileModelBlockReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689839);
      GetPlacementResult.NativeMethodInfoPtr_GetDeadResult_Public_Static_PlacementResult_byref_DeadOperation_byref_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689840);
      GetPlacementResult.NativeMethodInfoPtr_TryGetUserTeam_Private_Static_Nullable_Unboxed_1_Team_byref_JobData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689841);
      GetPlacementResult.NativeMethodInfoPtr_SetupInternalTileModelsAndDependencies_Private_Static_Void_byref_Operation_byref_JobData_byref_NativeList_1_InternalTileModel_byref_NativeMultiHashMap_2_Int32_InternalTileModelDependency_byref_NativeHashMap_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689842);
      GetPlacementResult.NativeMethodInfoPtr_GetOldTranslationAndRotation_Private_Static_Void_byref_Operation_byref_JobData_byref_Translation_byref_Rotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689843);
      GetPlacementResult.NativeMethodInfoPtr_TryAddInternalTileModel_Private_Static_Boolean_NativeList_1_InternalTileModel_Entity_Entity_Translation_Rotation_Translation_Rotation_InternalTileModelSource_Boolean_InternalOrExternalEntityId_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689844);
      GetPlacementResult.NativeMethodInfoPtr_AddInternalTileModelNetworkedChildren_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeHashMap_2_NetworkedChildKey_Int32_Entity_Int32_Translation_Rotation_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689845);
      GetPlacementResult.NativeMethodInfoPtr_AddInternalTileModelAttachedChildren_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_Entity_Int32_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689846);
      GetPlacementResult.NativeMethodInfoPtr_AddInternalTileModelFusedChildren_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_Entity_Int32_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689847);
      GetPlacementResult.NativeMethodInfoPtr_CalculateInternalTileModelBounds_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_byref_NativeArray_1_InternalTileModelBounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689848);
      GetPlacementResult.NativeMethodInfoPtr_GetMergedLocalBounds_Private_Static_BoundsMinMax_byref_JobData_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689849);
      GetPlacementResult.NativeMethodInfoPtr_FetchAllPlacementDatas_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeHashMap_2_Entity_Int32_NativeArray_1_InternalTileModelBounds_byref_NativeMultiHashMap_2_int3_TileModelPlacementData_byref_NativeMultiHashMap_2_Int32_Entity_byref_NativeMultiHashMap_2_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689850);
      GetPlacementResult.NativeMethodInfoPtr_FilterOutFromHeightLayerIncludeStairs_Private_Static_Boolean_ComponentDataFromEntity_1_TilePosition_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689851);
      GetPlacementResult.NativeMethodInfoPtr_TryGetStaticPlacementData_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689852);
      GetPlacementResult.NativeMethodInfoPtr_GetStaticTileDataWithinBounds_Public_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689853);
      GetPlacementResult.NativeMethodInfoPtr_TryGetBakedPlacementTiles_Private_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_int2_Byte_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689854);
      GetPlacementResult.NativeMethodInfoPtr_WritePlacement_Private_Static_Void_Entity_TilePosition_byref_TileDatas2dArray_1_PlacementData_BoundsMinMax_int2_NativeMultiHashMap_2_int3_TileModelPlacementData_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689855);
      GetPlacementResult.NativeMethodInfoPtr_TryGetBlockedTiles_Private_Static_Void_byref_GetStaticTileDataRequirements_NativeMultiHashMap_2_int3_TileModelPlacementData_BoundsMinMax_Byte_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689856);
      GetPlacementResult.NativeMethodInfoPtr_GetRoadsFromChunks_Private_Static_Void_byref_JobData_NativeArray_1_InternalTileModelBounds_byref_NativeHashSet_1_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689857);
      GetPlacementResult.NativeMethodInfoPtr_GetMergedPlacementJobData_Private_Static_MergedPlacementJobData_byref_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689858);
      GetPlacementResult.NativeMethodInfoPtr_GetMergedPlacementJobData_Public_Static_MergedPlacementJobData_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689859);
      GetPlacementResult.NativeMethodInfoPtr_GetMergedPlacementDatas_Public_Static_Void_MergedPlacementJobData_NativeHashMap_2_int3_PlacementData_Entity_int2_Single_TileRotation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689860);
      GetPlacementResult.NativeMethodInfoPtr_GetInternalPlacementResultsAndAttachments_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeMultiHashMap_2_int3_TileModelPlacementData_NativeHashSet_1_int2_NativeMultiHashMap_2_Int32_InternalTileModelDependency_byref_NativeArray_1_InternalTileModelPlacementResults_byref_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_byref_NativeList_1_InternalDestroyTileModelData_byref_NativeList_1_InternalAttachTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689861);
      GetPlacementResult.NativeMethodInfoPtr_AddBlockReason_Private_Static_Void_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Int32_InternalTileModelBlockReasonData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689862);
      GetPlacementResult.NativeMethodInfoPtr_CheckRestrictionAreas_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_int2_byref_TileModelBlockReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689863);
      GetPlacementResult.NativeMethodInfoPtr_CheckMapZoneRestrictions_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_TileModelBlockReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689864);
      GetPlacementResult.NativeMethodInfoPtr_CheckIfInRestrictionArea_Private_Static_BlockReason_Entity_Team_byref_Operation_byref_JobData_NativeList_1_Entity_int2_PlacementTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689865);
      GetPlacementResult.NativeMethodInfoPtr_CheckPlacementHistory_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_TileModelBlockReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689866);
      GetPlacementResult.NativeMethodInfoPtr_CheckCastleTeleporters_Private_Static_Void_byref_Operation_byref_JobData_Entity_byref_TileModelBlockReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689867);
      GetPlacementResult.NativeMethodInfoPtr_ContainsAttachment_Private_Static_Boolean_NativeList_1_InternalAttachTileModelData_InternalOrExternalEntityId_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689868);
      GetPlacementResult.NativeMethodInfoPtr_AttachNetworkedChildrenToRootParent_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalAttachTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689869);
      GetPlacementResult.NativeMethodInfoPtr_CancelIfOnlyUpgradeableAndNotUpgrading_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689870);
      GetPlacementResult.NativeMethodInfoPtr_CancelPlacementsBasedOnDependencyTree_Private_Static_Void_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689871);
      GetPlacementResult.NativeMethodInfoPtr_CancelReplacements_Private_Static_Void_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalDestroyTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689872);
      GetPlacementResult.NativeMethodInfoPtr_CancelPlacementsBasedOnInternalReplacements_Private_Static_Void_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689873);
      GetPlacementResult.NativeMethodInfoPtr_CancelAttachments_Private_Static_Void_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689874);
      GetPlacementResult.NativeMethodInfoPtr_TryGetExistingEntity_Private_Static_Boolean_InternalOrExternalEntityId_NativeList_1_InternalTileModel_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689875);
      GetPlacementResult.NativeMethodInfoPtr_GetDetachments_Private_Static_NativeList_1_DetachTileModelData_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelPlacementResults_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_Entity_NativeMultiHashMap_2_Int32_Entity_byref_NativeList_1_DetachTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689876);
      GetPlacementResult.NativeMethodInfoPtr_SetupPlacementResult_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeArray_1_InternalTileModelPlacementResults_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_NativeList_1_InternalDestroyTileModelData_NativeList_1_InternalAttachTileModelData_NativeList_1_DetachTileModelData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689877);
      GetPlacementResult.NativeMethodInfoPtr_SetupPlacementResultBlockReasons_Private_Static_Void_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_PlacementResult_Int32_InternalTileModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689878);
      GetPlacementResult.NativeMethodInfoPtr_CreateEmtpyResult_Private_Static_PlacementResult_PlacementOperation_Entity_Nullable_Unboxed_1_Team_Boolean_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689879);
      GetPlacementResult.NativeMethodInfoPtr_GetSimpleBlockedPlacementResult_Private_Static_PlacementResult_byref_Operation_byref_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689880);
      GetPlacementResult.NativeMethodInfoPtr_AddDetachmentsBasedOnDestroyDatas_Private_Static_Void_byref_JobData_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689881);
      GetPlacementResult.NativeMethodInfoPtr_ContainsReplaceData_Private_Static_Boolean_NativeList_1_InternalDestroyTileModelData_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689882);
      GetPlacementResult.NativeMethodInfoPtr_ContainsDestroyData_Private_Static_Boolean_NativeList_1_DestroyTileModelData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689883);
      GetPlacementResult.NativeMethodInfoPtr_ContainsDetachData_Private_Static_Boolean_NativeList_1_DetachTileModelData_DetachTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689884);
      GetPlacementResult.NativeMethodInfoPtr_AddDestroyDataRecursive_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeList_1_Entity_NativeList_1_DestroyTileModelData_NativeList_1_DetachTileModelData_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Boolean_Entity_Boolean_TileModelDestroyReason_Nullable_Unboxed_1_PlacementEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689885);
      GetPlacementResult.NativeMethodInfoPtr_IsAnyFusedDependencySillNotDestroyed_Private_Static_Boolean_Entity_NativeList_1_InternalTileModel_NativeMultiHashMap_2_Int32_InternalTileModelDependency_NativeList_1_DestroyTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689886);
      GetPlacementResult.NativeMethodInfoPtr_TryGetInternalEntity_Private_Static_Boolean_NativeList_1_InternalTileModel_Entity_byref_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689887);
      GetPlacementResult.NativeMethodInfoPtr_AddDestroyDataRecursiveInternal_Private_Static_Void_PlacementOperation_byref_JobData_NativeList_1_Entity_NativeList_1_InternalTileModel_NativeList_1_DestroyTileModelData_NativeList_1_DetachTileModelData_NativeList_1_InternalAttachTileModelData_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Boolean_Entity_Boolean_TileModelDestroyReason_Nullable_Unboxed_1_PlacementEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689888);
      GetPlacementResult.NativeMethodInfoPtr_TryGetInternalTileModelIndex_Private_Static_Boolean_Entity_NativeList_1_InternalTileModel_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689889);
      GetPlacementResult.NativeMethodInfoPtr_CheckRoads_Private_Static_Void_byref_JobData_NativeHashSet_1_int2_NativeKeyValueArrays_2_int3_PlacementData_byref_CastleAreaRequirement_byref_TileModelBlockReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689890);
      GetPlacementResult.NativeMethodInfoPtr_CheckCastleTerritoryZone_Private_Static_Void_byref_Operation_byref_JobData_NativeKeyValueArrays_2_int3_PlacementData_BoundsMinMax_byref_CastleAreaRequirement_byref_InternalTileModel_byref_TileModelBlockReasons_byref_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689891);
      GetPlacementResult.NativeMethodInfoPtr_TryGetTeam_Private_Static_Boolean_Entity_ComponentDataFromEntity_1_Team_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689892);
      GetPlacementResult.NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_AttachToOwnedArea_Private_Static_Boolean_byref_Operation_byref_JobData_byref_TileModelBlockReasons_Entity_Entity_Boolean_byref_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689893);
      GetPlacementResult.NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInWorldExceptInEnemyArea_Private_Static_Boolean_byref_Operation_byref_JobData_byref_TileModelBlockReasons_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689894);
      GetPlacementResult.NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInNeutralArea_Private_Static_Boolean_byref_TileModelBlockReasons_Entity_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689895);
      GetPlacementResult.NativeMethodInfoPtr_CanBuildWithTerritoryRequirement_PlaceableInClaimableTerritory_Private_Static_Boolean_byref_Operation_byref_JobData_byref_InternalTileModel_byref_TileModelBlockReasons_Entity_Entity_Boolean_byref_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689896);
      GetPlacementResult.NativeMethodInfoPtr_CheckFloorTerritory_Private_Static_Void_byref_Operation_byref_JobData_NativeList_1_InternalTileModel_Entity_Entity_byref_InternalTileModel_NativeArray_1_InternalTileModelBounds_NativeHashMap_2_InternalOrExternalEntityId_NeighbourFilter_NativeHashSet_1_InternalOrExternalEntityId_byref_TileModelBlockReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689897);
      GetPlacementResult.NativeMethodInfoPtr_RoomUtilityGetNeighbourJobData_Private_Static_GetNeighbourFloorsJobData_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689898);
      GetPlacementResult.NativeMethodInfoPtr_CheckTerritoryNonFloors_Private_Static_Void_byref_Operation_byref_JobData_Entity_byref_TileModelBlockReasons_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689899);
      GetPlacementResult.NativeMethodInfoPtr_MergeNeighbourFloors_Private_Static_NativeList_1_NeighbourFloorsInternalResult_NativeList_1_NeighbourFloorsResult_NativeList_1_NeighbourFloorsInternalResult_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689900);
      GetPlacementResult.NativeMethodInfoPtr_GetInternalNeighbourFloors_Private_Static_NativeList_1_NeighbourFloorsInternalResult_byref_GetNeighbourFloorsJobData_TilePosition_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_NativeList_1_InternalTileModel_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689901);
      GetPlacementResult.NativeMethodInfoPtr_GetNeighbourFloorsAndNearbyCastleFloors_Private_Static_NativeList_1_Entity_Byte_Int32_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_CastleFloor_SpatialLookupParams_NativeList_1_InternalTileModel_NativeArray_1_InternalTileModelBounds_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689902);
      GetPlacementResult.NativeMethodInfoPtr_TryFindConnectedFloor_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_InternalOrExternalEntityId_NeighbourFilter_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689903);
      GetPlacementResult.NativeMethodInfoPtr_TryFindConnectedFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_InternalOrExternalEntityId_NeighbourFilter_byref_NativeList_1_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689904);
      GetPlacementResult.NativeMethodInfoPtr_HasExternalNeighbor_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689905);
      GetPlacementResult.NativeMethodInfoPtr_FindNonInternalNeighborNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_byref_NativeHashSet_1_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689906);
      GetPlacementResult.NativeMethodInfoPtr_AnyNeighborHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689907);
      GetPlacementResult.NativeMethodInfoPtr_AllNeighborsHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689908);
      GetPlacementResult.NativeMethodInfoPtr_AllNeighborsHasGroundConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_byref_NativeList_1_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689909);
      GetPlacementResult.NativeMethodInfoPtr_AddAll_Private_Static_Void_NativeHashSet_1_InternalOrExternalEntityId_NativeHashSet_1_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689910);
      GetPlacementResult.NativeMethodInfoPtr_AddAll_Private_Static_Void_NativeHashMap_2_InternalOrExternalEntityId_NeighbourFilter_NativeHashSet_1_InternalOrExternalEntityId_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689911);
      GetPlacementResult.NativeMethodInfoPtr_TryFindGroundedFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_InternalOrExternalEntityId_NeighbourFilter_byref_NativeHashSet_1_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689912);
      GetPlacementResult.NativeMethodInfoPtr_IsStairsGrounded_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TileWorld_Entity_byref_CastleStairs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689913);
      GetPlacementResult.NativeMethodInfoPtr_AnyNeighborHasCastleHeartConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_ComponentDataFromEntity_1_CastleHeart_byref_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689914);
      GetPlacementResult.NativeMethodInfoPtr_AllNeighborsHasCastleHeartConnection_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_byref_NativeList_1_InternalOrExternalEntityId_ComponentDataFromEntity_1_CastleHeart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689915);
      GetPlacementResult.NativeMethodInfoPtr_TryFindCastleHeartForFloorNested_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_ComponentDataFromEntity_1_CastleHeart_byref_NativeHashSet_1_InternalOrExternalEntityId_byref_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689916);
      GetPlacementResult.NativeMethodInfoPtr_AnyUnitsOnElevatedFloor_Private_Static_Boolean_byref_JobData_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689917);
      GetPlacementResult.NativeMethodInfoPtr_GetTilePosition_Private_Static_TilePosition_NativeList_1_InternalTileModel_ComponentDataFromEntity_1_TilePosition_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689918);
      GetPlacementResult.NativeMethodInfoPtr_GetCastleStairs_Private_Static_CastleStairs_NativeList_1_InternalTileModel_ComponentDataFromEntity_1_CastleStairs_InternalOrExternalEntityId_byref_Nullable_Unboxed_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689919);
      GetPlacementResult.NativeMethodInfoPtr_GetPrefabOrEntity_Private_Static_Entity_NativeList_1_InternalTileModel_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689920);
      GetPlacementResult.NativeMethodInfoPtr_GetNeighborFilter_Private_Static_NeighbourFilter_byref_GetNeighbourFloorsJobData_byref_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689921);
      GetPlacementResult.NativeMethodInfoPtr_GetNeighborFilter_Private_Static_NeighbourFilter_byref_CastleFloor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689922);
      GetPlacementResult.NativeMethodInfoPtr_GetNeighbourFloors_Private_Static_InternalNeighbourFloorsEnumerator_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689923);
      GetPlacementResult.NativeMethodInfoPtr_Method_Internal_Static_BoundsMinMax_int2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, 100689924);
    }

    public GetPlacementResult(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public sealed class SystemData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__TravelBuffCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__ApplyPlacementHistorySystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameBalanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__EnableLocalBuildingDebugging;
      private static readonly System.IntPtr NativeMethodInfoPtr_HasLocalBuildingDebuggingSingleton_Public_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_SystemData_World_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_PrepareJobData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobData_Public_JobData_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateFullJobData_Public_FullPlacementJobData_ComponentSystemBase_EntityCommandBuffer_EntityCommandBuffer_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1131666, RefRangeEnd = 1131667, XrefRangeStart = 1131663, XrefRangeEnd = 1131666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool HasLocalBuildingDebuggingSingleton()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.NativeMethodInfoPtr_HasLocalBuildingDebuggingSingleton_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1131708, RefRangeEnd = 1131719, XrefRangeStart = 1131667, XrefRangeEnd = 1131708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe GetPlacementResult.SystemData Create(World world)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.NativeMethodInfoPtr_Create_Public_Static_SystemData_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new GetPlacementResult.SystemData(pointer);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1131731, RefRangeEnd = 1131742, XrefRangeStart = 1131719, XrefRangeEnd = 1131731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1131744, RefRangeEnd = 1131748, XrefRangeStart = 1131742, XrefRangeEnd = 1131744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GetPlacementResult.SystemData.PrepareJobData Prepare()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.NativeMethodInfoPtr_Prepare_Public_PrepareJobData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new GetPlacementResult.SystemData.PrepareJobData(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1131751, RefRangeEnd = 1131754, XrefRangeStart = 1131748, XrefRangeEnd = 1131751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GetPlacementResult.JobData CreateJobData(ComponentSystemBase systemBase)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.NativeMethodInfoPtr_CreateJobData_Public_JobData_ComponentSystemBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GetPlacementResult.JobData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1131758, RefRangeEnd = 1131763, XrefRangeStart = 1131754, XrefRangeEnd = 1131758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FullPlacementJobData CreateFullJobData(
        ComponentSystemBase systemBase,
        EntityCommandBuffer spawnCommandBuffer,
        EntityCommandBuffer destroyCommandBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.NativeMethodInfoPtr_CreateFullJobData_Public_FullPlacementJobData_ComponentSystemBase_EntityCommandBuffer_EntityCommandBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(FullPlacementJobData*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SystemData()
      {
        Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (SystemData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr);
        GetPlacementResult.SystemData.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_PrefabCollectionSystem));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__MapZoneCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_MapZoneCollectionSystem));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_TerrainManager));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_TileWorldSystem));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__TravelBuffCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_TravelBuffCollectionSystem));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__ApplyPlacementHistorySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_ApplyPlacementHistorySystem));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_ServerDebugSettings));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerGameBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_ServerGameBalanceSettings));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_ServerTime));
        GetPlacementResult.SystemData.NativeFieldInfoPtr__EnableLocalBuildingDebugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (_EnableLocalBuildingDebugging));
        GetPlacementResult.SystemData.NativeMethodInfoPtr_HasLocalBuildingDebuggingSingleton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, 100689925);
        GetPlacementResult.SystemData.NativeMethodInfoPtr_Create_Public_Static_SystemData_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, 100689926);
        GetPlacementResult.SystemData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, 100689927);
        GetPlacementResult.SystemData.NativeMethodInfoPtr_Prepare_Public_PrepareJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, 100689928);
        GetPlacementResult.SystemData.NativeMethodInfoPtr_CreateJobData_Public_JobData_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, 100689929);
        GetPlacementResult.SystemData.NativeMethodInfoPtr_CreateFullJobData_Public_FullPlacementJobData_ComponentSystemBase_EntityCommandBuffer_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, 100689930);
      }

      public SystemData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SystemData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }

      public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__TileModelSpatialLookupMap));
          return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabCollectionSystem _PrefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__PrefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe MapZoneCollectionSystem _MapZoneCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__MapZoneCollectionSystem));
          return pointer == System.IntPtr.Zero ? (MapZoneCollectionSystem) null : new MapZoneCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__MapZoneCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TerrainManager _TerrainManager
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__TerrainManager));
          return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TileWorldSystem _TileWorldSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__TileWorldSystem));
          return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TravelBuffCollectionSystem _TravelBuffCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__TravelBuffCollectionSystem));
          return pointer == System.IntPtr.Zero ? (TravelBuffCollectionSystem) null : new TravelBuffCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__TravelBuffCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ApplyPlacementHistorySystem _ApplyPlacementHistorySystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__ApplyPlacementHistorySystem));
          return pointer == System.IntPtr.Zero ? (ApplyPlacementHistorySystem) null : new ApplyPlacementHistorySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__ApplyPlacementHistorySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
      {
        get
        {
          return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerDebugSettings));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerGameBalanceSettings
      {
        get
        {
          return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerGameBalanceSettings));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerGameBalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SingletonAccessor<ServerTime> _ServerTime
      {
        get
        {
          return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerTime));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SingletonAccessor<EnableLocalBuildingDebuggingSingleton> _EnableLocalBuildingDebugging
      {
        get
        {
          return *(SingletonAccessor<EnableLocalBuildingDebuggingSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__EnableLocalBuildingDebugging));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.NativeFieldInfoPtr__EnableLocalBuildingDebugging), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<EnableLocalBuildingDebuggingSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public sealed class PrepareJobData : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr__SystemData;
        private static readonly System.IntPtr NativeFieldInfoPtr__TerrainChunks;
        private static readonly System.IntPtr NativeFieldInfoPtr__ApplyPlacementHistoryTileModelsToCreate;
        private static readonly System.IntPtr NativeFieldInfoPtr__ApplyPlacementHistoryTileModelsToMove;
        private static readonly System.IntPtr NativeMethodInfoPtr_HasLocalBuildingDebuggingSingleton_Public_Boolean_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SystemData_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobData_Public_JobData_ComponentSystemBase_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_CreateFullJobData_Public_FullPlacementJobData_ComponentSystemBase_EntityCommandBuffer_EntityCommandBuffer_0;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1131650, RefRangeEnd = 1131651, XrefRangeStart = 1131649, XrefRangeEnd = 1131650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe bool HasLocalBuildingDebuggingSingleton()
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.PrepareJobData.NativeMethodInfoPtr_HasLocalBuildingDebuggingSingleton_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1131653, RefRangeEnd = 1131654, XrefRangeStart = 1131651, XrefRangeEnd = 1131653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PrepareJobData(GetPlacementResult.SystemData systemData)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) systemData));
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.PrepareJobData.NativeMethodInfoPtr__ctor_Public_Void_SystemData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 1131656, RefRangeEnd = 1131658, XrefRangeStart = 1131654, XrefRangeEnd = 1131656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GetPlacementResult.JobData CreateJobData(ComponentSystemBase systemBase)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.PrepareJobData.NativeMethodInfoPtr_CreateJobData_Public_JobData_ComponentSystemBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GetPlacementResult.JobData*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 1131661, RefRangeEnd = 1131663, XrefRangeStart = 1131658, XrefRangeEnd = 1131661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe FullPlacementJobData CreateFullJobData(
          ComponentSystemBase systemBase,
          EntityCommandBuffer spawnCommandBuffer,
          EntityCommandBuffer destroyCommandBuffer)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.SystemData.PrepareJobData.NativeMethodInfoPtr_CreateFullJobData_Public_FullPlacementJobData_ComponentSystemBase_EntityCommandBuffer_EntityCommandBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(FullPlacementJobData*) IL2CPP.il2cpp_object_unbox(num);
        }

        static PrepareJobData()
        {
          Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, nameof (PrepareJobData));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr);
          GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__SystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, nameof (_SystemData));
          GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, nameof (_TerrainChunks));
          GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__ApplyPlacementHistoryTileModelsToCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, nameof (_ApplyPlacementHistoryTileModelsToCreate));
          GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__ApplyPlacementHistoryTileModelsToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, nameof (_ApplyPlacementHistoryTileModelsToMove));
          GetPlacementResult.SystemData.PrepareJobData.NativeMethodInfoPtr_HasLocalBuildingDebuggingSingleton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, 100689931);
          GetPlacementResult.SystemData.PrepareJobData.NativeMethodInfoPtr__ctor_Public_Void_SystemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, 100689932);
          GetPlacementResult.SystemData.PrepareJobData.NativeMethodInfoPtr_CreateJobData_Public_JobData_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, 100689933);
          GetPlacementResult.SystemData.PrepareJobData.NativeMethodInfoPtr_CreateFullJobData_Public_FullPlacementJobData_ComponentSystemBase_EntityCommandBuffer_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, 100689934);
        }

        public PrepareJobData(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public PrepareJobData()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData.PrepareJobData>.NativeClassPtr, data));
        }

        public GetPlacementResult.SystemData _SystemData
        {
          get
          {
            System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__SystemData);
            return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
          }
          [param: In] set
          {
            __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__SystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          }
        }

        public unsafe TerrainChunkLookup _TerrainChunks
        {
          get
          {
            return *(TerrainChunkLookup*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__TerrainChunks));
          }
          [param: In] set
          {
            *(TerrainChunkLookup*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__TerrainChunks)) = value;
          }
        }

        public unsafe NativeList<CreateTileModelData> _ApplyPlacementHistoryTileModelsToCreate
        {
          get
          {
            return *(NativeList<CreateTileModelData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__ApplyPlacementHistoryTileModelsToCreate));
          }
          [param: In] set
          {
            __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__ApplyPlacementHistoryTileModelsToCreate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<CreateTileModelData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          }
        }

        public unsafe NativeList<MoveTileModelData> _ApplyPlacementHistoryTileModelsToMove
        {
          get
          {
            return *(NativeList<MoveTileModelData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__ApplyPlacementHistoryTileModelsToMove));
          }
          [param: In] set
          {
            __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResult.SystemData.PrepareJobData.NativeFieldInfoPtr__ApplyPlacementHistoryTileModelsToMove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MoveTileModelData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          }
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct JobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerGameBalanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_TravelBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePlacementTag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetEntityOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetControlledBy;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetEntityCategory;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDestroy;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTeamReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetIsPreviewingPlacement;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRestrictionArea;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDead;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkedPrefabChildren;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLinkedEntityGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAllyPermissions;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBuffableFlagState;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTiles;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTilesBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetEditableTileModel;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetUpgradeableFromTileModel;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachToParentsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachedChildrenBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetChunkAreas;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleAreaRequirement;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleStairs;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWallPillar;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeart;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeartConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPylonstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetServantCoffinstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleLimited;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetUserHeartCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetInteractedUpon;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPlacementDestroyData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTeleporterComponent;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRequireGroundedTag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTeleporterElements;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabSetBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToCreate;
      private static readonly System.IntPtr NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToMove;
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
      private static readonly System.IntPtr NativeFieldInfoPtr_ProfilerMarker_FetchAllPlacementDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProfilerMarker_SpatialLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_JobData_ComponentSystemBase_PrefabLookupMap_SingletonAccessor_1_SyncedServerDebugSettings_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_ServerTime_ITileModelSpatialLookupMap_MapZoneCollectionSystem_TileWorldSystem_TravelBuffCollectionSystem_TerrainChunkLookup_NativeList_1_CreateTileModelData_NativeList_1_MoveTileModelData_0;
      [FieldOffset(0)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(80)]
      public SyncedServerDebugSettings ServerDebugSettings;
      [FieldOffset(120)]
      public ServerGameBalanceSettings ServerGameBalanceSettings;
      [FieldOffset(1520)]
      public MapZoneCollection MapZoneCollection;
      [FieldOffset(1616)]
      public TileWorld TileWorld;
      [FieldOffset(1640)]
      public TravelBuffCollection TravelBuffs;
      [FieldOffset(1656)]
      public bool IsServer;
      [FieldOffset(1664)]
      public PrefabLookupMap PrefabMap;
      [FieldOffset(1712)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
      [FieldOffset(1744)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(1776)]
      public ComponentDataFromEntity<Rotation> GetRotation;
      [FieldOffset(1808)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(1840)]
      public ComponentDataFromEntity<TilePlacementTag> GetTilePlacementTag;
      [FieldOffset(1872)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(1904)]
      public ComponentDataFromEntity<Prefab> GetPrefab;
      [FieldOffset(1936)]
      public ComponentDataFromEntity<EntityOwner> GetEntityOwner;
      [FieldOffset(1968)]
      public ComponentDataFromEntity<ControlledBy> GetControlledBy;
      [FieldOffset(2000)]
      public ComponentDataFromEntity<EntityCategory> GetEntityCategory;
      [FieldOffset(2032)]
      public ComponentDataFromEntity<DestroyTag> GetDestroy;
      [FieldOffset(2064)]
      public ComponentDataFromEntity<Team> GetTeam;
      [FieldOffset(2096)]
      public ComponentDataFromEntity<TeamReference> GetTeamReference;
      [FieldOffset(2128)]
      public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
      [FieldOffset(2160)]
      public ComponentDataFromEntity<IsPreviewingPlacement> GetIsPreviewingPlacement;
      [FieldOffset(2192)]
      public ComponentDataFromEntity<RestrictPlacementArea> GetRestrictionArea;
      [FieldOffset(2224)]
      public ComponentDataFromEntity<Dead> GetDead;
      [FieldOffset(2256)]
      public ComponentDataFromEntity<NetworkedPrefabChildren> GetNetworkedPrefabChildren;
      [FieldOffset(2288)]
      public BufferFromEntity<LinkedEntityGroup> GetLinkedEntityGroup;
      [FieldOffset(2328)]
      public BufferFromEntity<AllyPermission> GetAllyPermissions;
      [FieldOffset(2368)]
      public ComponentDataFromEntity<BuffableFlagState> GetBuffableFlagState;
      [FieldOffset(2400)]
      public BufferFromEntity<BakedPlacementTiles> GetBakedPlacementTiles;
      [FieldOffset(2440)]
      public BufferFromEntity<BakedPlacementTilesBounds> GetBakedPlacementTilesBounds;
      [FieldOffset(2480)]
      public ComponentDataFromEntity<EditableTileModel> GetEditableTileModel;
      [FieldOffset(2512)]
      public ComponentDataFromEntity<UpgradeableFromTileModel> GetUpgradeableFromTileModel;
      [FieldOffset(2544)]
      public ComponentDataFromEntity<CastleBuildingAttachSettings> GetAttachSettings;
      [FieldOffset(2576)]
      public BufferFromEntity<CastleBuildingAttachToParentsBuffer> GetAttachToParentsBuffer;
      [FieldOffset(2616)]
      public BufferFromEntity<CastleBuildingAttachedChildrenBuffer> GetAttachedChildrenBuffer;
      [FieldOffset(2656)]
      public TerrainChunkLookup TerrainChunks;
      [FieldOffset(2672)]
      public BufferFromEntity<ControllableAreaIdBuffer> GetChunkAreas;
      [FieldOffset(2712)]
      public ComponentDataFromEntity<CastleAreaRequirement> GetCastleAreaRequirement;
      [FieldOffset(2744)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(2776)]
      public ComponentDataFromEntity<CastleStairs> GetCastleStairs;
      [FieldOffset(2808)]
      public ComponentDataFromEntity<CastleWall> GetCastleWall;
      [FieldOffset(2840)]
      public ComponentDataFromEntity<CastleWallPillar> GetCastleWallPillar;
      [FieldOffset(2872)]
      public ComponentDataFromEntity<CastleHeart> GetCastleHeart;
      [FieldOffset(2904)]
      public ComponentDataFromEntity<CastleHeartConnection> GetCastleHeartConnection;
      [FieldOffset(2936)]
      public ComponentDataFromEntity<Pylonstation> GetPylonstation;
      [FieldOffset(2968)]
      public ComponentDataFromEntity<ServantCoffinstation> GetServantCoffinstation;
      [FieldOffset(3000)]
      public ComponentDataFromEntity<CastleLimited> GetCastleLimited;
      [FieldOffset(3032)]
      public ComponentDataFromEntity<UserHeartCount> GetUserHeartCount;
      [FieldOffset(3064)]
      public ComponentDataFromEntity<InteractedUpon> GetInteractedUpon;
      [FieldOffset(3096)]
      public ComponentDataFromEntity<PlacementDestroyData> GetPlacementDestroyData;
      [FieldOffset(3128)]
      public ComponentDataFromEntity<CastleTeleporterComponent> GetCastleTeleporterComponent;
      [FieldOffset(3160)]
      public ComponentDataFromEntity<RequireGroundedTag> GetRequireGroundedTag;
      [FieldOffset(3192)]
      public BufferFromEntity<CastleTeleporterElement> GetCastleTeleporterElements;
      [FieldOffset(3232)]
      public BufferFromEntity<PrefabSetBuffer> GetPrefabSetBuffer;
      [FieldOffset(3272)]
      public NativeList<CreateTileModelData> ApplyPlacementHistoryTileModelsToCreate;
      [FieldOffset(3288)]
      public NativeList<MoveTileModelData> ApplyPlacementHistoryTileModelsToMove;
      [FieldOffset(3304)]
      public ComponentDataFromEntity<CastleTerritory> GetCastleTerritory;
      [FieldOffset(3336)]
      public BufferFromEntity<CastleTerritoryTiles> GetCastleTerritoryTiles;
      [FieldOffset(3376)]
      public ComponentDataFromEntity<MapZoneData> GetMapZoneData;
      [FieldOffset(3408)]
      public BufferFromEntity<MapZonePolygonVertexElement> GetMapZonePolygonVertexElement;
      [FieldOffset(3448)]
      public ComponentDataFromEntity<RestrictPlacementToMapZones> GetRestrictPlacementToMapZones;
      [FieldOffset(3480)]
      public ComponentDataFromEntity<CastleBuildingAllowReplaceSelf> GetCastleBuildingAllowReplaceSelf;
      [FieldOffset(3512)]
      public ComponentDataFromEntity<CastleBuildingMaxRange> GetCastleBuildingMaxRange;
      [FieldOffset(3544)]
      public ComponentDataFromEntity<CastleBuildingFusedRoot> GetCastleBuildingFusedRoot;
      [FieldOffset(3576)]
      public ComponentDataFromEntity<CastleBuildingFusedChild> GetCastleBuildingFusedChild;
      [FieldOffset(3608)]
      public BufferFromEntity<CastleBuildingFusedChildrenBuffer> GetCastleBuildingFusedChildrenBuffer;
      [FieldOffset(3648)]
      public ComponentDataFromEntity<PlacementLimitToSet> GetPlacementLimitToSet;
      [FieldOffset(3680)]
      public ProfilerMarker ProfilerMarker_FetchAllPlacementDatas;
      [FieldOffset(3688)]
      public ProfilerMarker ProfilerMarker_SpatialLookup;
      [FieldOffset(3696)]
      public double ServerTime;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1131960, RefRangeEnd = 1131961, XrefRangeStart = 1131763, XrefRangeEnd = 1131960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe GetPlacementResult.JobData Create(
        ComponentSystemBase systemBase,
        PrefabLookupMap prefabLookupMap,
        SingletonAccessor<SyncedServerDebugSettings> serverDebugSettings,
        SingletonAccessor<ServerGameBalanceSettings> serverGameBalanceSettings,
        SingletonAccessor<ServerTime> serverTime,
        ITileModelSpatialLookupMap tileModelSpatialLookup,
        MapZoneCollectionSystem mapZoneCollectionSystem,
        TileWorldSystem tileWorldSystem,
        TravelBuffCollectionSystem travelBuffCollectionSystem,
        TerrainChunkLookup terrainChunks,
        NativeList<CreateTileModelData> applyPlacementHistoryTileModelsToCreate,
        NativeList<MoveTileModelData> applyPlacementHistoryTileModelsToMove)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[12];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverDebugSettings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &serverGameBalanceSettings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileModelSpatialLookup);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapZoneCollectionSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileWorldSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) travelBuffCollectionSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunks;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &applyPlacementHistoryTileModelsToCreate;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &applyPlacementHistoryTileModelsToMove;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.JobData.NativeMethodInfoPtr_Create_Public_Static_JobData_ComponentSystemBase_PrefabLookupMap_SingletonAccessor_1_SyncedServerDebugSettings_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_ServerTime_ITileModelSpatialLookupMap_MapZoneCollectionSystem_TileWorldSystem_TravelBuffCollectionSystem_TerrainChunkLookup_NativeList_1_CreateTileModelData_NativeList_1_MoveTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GetPlacementResult.JobData*) IL2CPP.il2cpp_object_unbox(num);
      }

      static JobData()
      {
        Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (JobData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr);
        GetPlacementResult.JobData.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (SpatialLookupParams));
        GetPlacementResult.JobData.NativeFieldInfoPtr_ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (ServerDebugSettings));
        GetPlacementResult.JobData.NativeFieldInfoPtr_ServerGameBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (ServerGameBalanceSettings));
        GetPlacementResult.JobData.NativeFieldInfoPtr_MapZoneCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (MapZoneCollection));
        GetPlacementResult.JobData.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (TileWorld));
        GetPlacementResult.JobData.NativeFieldInfoPtr_TravelBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (TravelBuffs));
        GetPlacementResult.JobData.NativeFieldInfoPtr_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (IsServer));
        GetPlacementResult.JobData.NativeFieldInfoPtr_PrefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (PrefabMap));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetLocalToWorld));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetTranslation));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetRotation));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetTilePosition));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetTilePlacementTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetTilePlacementTag));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetTileData));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetPrefab));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetEntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetEntityOwner));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetControlledBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetControlledBy));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetEntityCategory));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetDestroy));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetTeam));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetTeamReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetTeamReference));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetPrefabGUID));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetIsPreviewingPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetIsPreviewingPlacement));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetRestrictionArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetRestrictionArea));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetDead));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetNetworkedPrefabChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetNetworkedPrefabChildren));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetLinkedEntityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetLinkedEntityGroup));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetAllyPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetAllyPermissions));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetBuffableFlagState));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetBakedPlacementTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetBakedPlacementTiles));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetBakedPlacementTilesBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetBakedPlacementTilesBounds));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetEditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetEditableTileModel));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetUpgradeableFromTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetUpgradeableFromTileModel));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetAttachSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetAttachSettings));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetAttachToParentsBuffer));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetAttachedChildrenBuffer));
        GetPlacementResult.JobData.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (TerrainChunks));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetChunkAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetChunkAreas));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleAreaRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleAreaRequirement));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleFloor));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleStairs));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleWall));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleWallPillar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleWallPillar));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleHeart));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleHeartConnection));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetPylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetPylonstation));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetServantCoffinstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetServantCoffinstation));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleLimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleLimited));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetUserHeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetUserHeartCount));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetInteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetInteractedUpon));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetPlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetPlacementDestroyData));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleTeleporterComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleTeleporterComponent));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetRequireGroundedTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetRequireGroundedTag));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleTeleporterElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleTeleporterElements));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetPrefabSetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetPrefabSetBuffer));
        GetPlacementResult.JobData.NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (ApplyPlacementHistoryTileModelsToCreate));
        GetPlacementResult.JobData.NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (ApplyPlacementHistoryTileModelsToMove));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleTerritory));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleTerritoryTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleTerritoryTiles));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetMapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetMapZoneData));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetMapZonePolygonVertexElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetMapZonePolygonVertexElement));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetRestrictPlacementToMapZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetRestrictPlacementToMapZones));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleBuildingAllowReplaceSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleBuildingAllowReplaceSelf));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleBuildingMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleBuildingMaxRange));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleBuildingFusedRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleBuildingFusedRoot));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleBuildingFusedChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleBuildingFusedChild));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetCastleBuildingFusedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleBuildingFusedChildrenBuffer));
        GetPlacementResult.JobData.NativeFieldInfoPtr_GetPlacementLimitToSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (GetPlacementLimitToSet));
        GetPlacementResult.JobData.NativeFieldInfoPtr_ProfilerMarker_FetchAllPlacementDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (ProfilerMarker_FetchAllPlacementDatas));
        GetPlacementResult.JobData.NativeFieldInfoPtr_ProfilerMarker_SpatialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (ProfilerMarker_SpatialLookup));
        GetPlacementResult.JobData.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, nameof (ServerTime));
        GetPlacementResult.JobData.NativeMethodInfoPtr_Create_Public_Static_JobData_ComponentSystemBase_PrefabLookupMap_SingletonAccessor_1_SyncedServerDebugSettings_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_ServerTime_ITileModelSpatialLookupMap_MapZoneCollectionSystem_TileWorldSystem_TravelBuffCollectionSystem_TerrainChunkLookup_NativeList_1_CreateTileModelData_NativeList_1_MoveTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, 100689935);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.JobData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Operation
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NewRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileModelPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExistingEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementOperation;
      private static readonly System.IntPtr NativeFieldInfoPtr_LogLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_SkipNetworkedChildren;
      private static readonly System.IntPtr NativeFieldInfoPtr_KeepTeamDuringTransform;
      private static readonly System.IntPtr NativeFieldInfoPtr_PersistanceAllocation;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_PlacementOperation_Entity_Entity_Translation_Rotation_Entity_Boolean_PlacementLogLevel_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Operation_PlacementOperation_Entity_Entity_Translation_Rotation_Entity_Boolean_PlacementLogLevel_Boolean_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Operation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocator_Public_Allocator_0;
      [FieldOffset(0)]
      public readonly Rotation NewRotation;
      [FieldOffset(16)]
      public readonly Translation NewTranslation;
      [FieldOffset(28)]
      public readonly Entity CharacterEntity;
      [FieldOffset(36)]
      public readonly Entity TileModelPrefab;
      [FieldOffset(44)]
      public readonly Entity ExistingEntity;
      [FieldOffset(52)]
      public readonly PlacementOperation PlacementOperation;
      [FieldOffset(56)]
      public readonly PlacementLogLevel LogLevel;
      [FieldOffset(57)]
      public readonly bool SkipNetworkedChildren;
      [FieldOffset(58)]
      public readonly bool KeepTeamDuringTransform;
      [FieldOffset(59)]
      public readonly bool PersistanceAllocation;

      [CallerCount(0)]
      public unsafe Operation(
        PlacementOperation placementOperation,
        Entity characterEntity,
        Entity tileModelPrefab,
        Translation newTranslation,
        Rotation newRotation,
        Entity existingEntity,
        bool skipNetworkedChildren,
        PlacementLogLevel logLevel,
        bool keepTeamDuringTransform,
        bool persistanceAllocation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[10];
        numPtr[0] = (System.IntPtr) &placementOperation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &characterEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelPrefab;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newTranslation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &existingEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &skipNetworkedChildren;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &logLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &keepTeamDuringTransform;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &persistanceAllocation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.Operation.NativeMethodInfoPtr__ctor_Private_Void_PlacementOperation_Entity_Entity_Translation_Rotation_Entity_Boolean_PlacementLogLevel_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1131961, RefRangeEnd = 1131971, XrefRangeStart = 1131961, XrefRangeEnd = 1131961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe GetPlacementResult.Operation Create(
        PlacementOperation placementOperation,
        Entity characterEntity,
        Entity tileModelPrefab,
        Translation newTranslation,
        Rotation newRotation,
        Entity existingEntity,
        bool skipNetworkedChildren = false,
        PlacementLogLevel logLevel = PlacementLogLevel.None,
        bool keepTeamDuringTransform = true,
        bool ignoreObjectsWithHealth = false,
        bool persistanceAllocation = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[11];
        numPtr[0] = (System.IntPtr) &placementOperation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &characterEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelPrefab;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newTranslation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &existingEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &skipNetworkedChildren;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &logLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &keepTeamDuringTransform;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreObjectsWithHealth;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &persistanceAllocation;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.Operation.NativeMethodInfoPtr_Create_Public_Static_Operation_PlacementOperation_Entity_Entity_Translation_Rotation_Entity_Boolean_PlacementLogLevel_Boolean_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GetPlacementResult.Operation*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131971, XrefRangeEnd = 1131974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(GetPlacementResult.Operation other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.Operation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Operation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1131974, RefRangeEnd = 1131978, XrefRangeStart = 1131974, XrefRangeEnd = 1131974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Allocator GetAllocator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.Operation.NativeMethodInfoPtr_GetAllocator_Public_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Allocator*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Operation()
      {
        Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (Operation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr);
        GetPlacementResult.Operation.NativeFieldInfoPtr_NewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (NewRotation));
        GetPlacementResult.Operation.NativeFieldInfoPtr_NewTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (NewTranslation));
        GetPlacementResult.Operation.NativeFieldInfoPtr_CharacterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (CharacterEntity));
        GetPlacementResult.Operation.NativeFieldInfoPtr_TileModelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (TileModelPrefab));
        GetPlacementResult.Operation.NativeFieldInfoPtr_ExistingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (ExistingEntity));
        GetPlacementResult.Operation.NativeFieldInfoPtr_PlacementOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (PlacementOperation));
        GetPlacementResult.Operation.NativeFieldInfoPtr_LogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (LogLevel));
        GetPlacementResult.Operation.NativeFieldInfoPtr_SkipNetworkedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (SkipNetworkedChildren));
        GetPlacementResult.Operation.NativeFieldInfoPtr_KeepTeamDuringTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (KeepTeamDuringTransform));
        GetPlacementResult.Operation.NativeFieldInfoPtr_PersistanceAllocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, nameof (PersistanceAllocation));
        GetPlacementResult.Operation.NativeMethodInfoPtr__ctor_Private_Void_PlacementOperation_Entity_Entity_Translation_Rotation_Entity_Boolean_PlacementLogLevel_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, 100689936);
        GetPlacementResult.Operation.NativeMethodInfoPtr_Create_Public_Static_Operation_PlacementOperation_Entity_Entity_Translation_Rotation_Entity_Boolean_PlacementLogLevel_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, 100689937);
        GetPlacementResult.Operation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, 100689938);
        GetPlacementResult.Operation.NativeMethodInfoPtr_GetAllocator_Public_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, 100689939);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.Operation>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DeadOperation
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementOperation;
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExistingEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_LogLevel;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_PlacementOperation_Entity_Entity_PlacementLogLevel_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DeadOperation_PlacementOperation_Entity_Entity_PlacementLogLevel_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocator_Public_Allocator_0;
      [FieldOffset(0)]
      public PlacementOperation PlacementOperation;
      [FieldOffset(4)]
      public Entity CharacterEntity;
      [FieldOffset(12)]
      public Entity ExistingEntity;
      [FieldOffset(20)]
      public PlacementLogLevel LogLevel;

      [CallerCount(0)]
      public unsafe DeadOperation(
        PlacementOperation placementOperation,
        Entity characterEntity,
        Entity existingEntity,
        PlacementLogLevel logLevel)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &placementOperation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &characterEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &existingEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &logLevel;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.DeadOperation.NativeMethodInfoPtr__ctor_Private_Void_PlacementOperation_Entity_Entity_PlacementLogLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1131978, RefRangeEnd = 1131979, XrefRangeStart = 1131978, XrefRangeEnd = 1131978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe GetPlacementResult.DeadOperation Create(
        PlacementOperation placementOperation,
        Entity characterEntity,
        Entity existingEntity,
        PlacementLogLevel logLevel = PlacementLogLevel.None)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &placementOperation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &characterEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &existingEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &logLevel;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.DeadOperation.NativeMethodInfoPtr_Create_Public_Static_DeadOperation_PlacementOperation_Entity_Entity_PlacementLogLevel_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GetPlacementResult.DeadOperation*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(21)]
      [CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Allocator GetAllocator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.DeadOperation.NativeMethodInfoPtr_GetAllocator_Public_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Allocator*) IL2CPP.il2cpp_object_unbox(num);
      }

      static DeadOperation()
      {
        Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (DeadOperation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr);
        GetPlacementResult.DeadOperation.NativeFieldInfoPtr_PlacementOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr, nameof (PlacementOperation));
        GetPlacementResult.DeadOperation.NativeFieldInfoPtr_CharacterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr, nameof (CharacterEntity));
        GetPlacementResult.DeadOperation.NativeFieldInfoPtr_ExistingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr, nameof (ExistingEntity));
        GetPlacementResult.DeadOperation.NativeFieldInfoPtr_LogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr, nameof (LogLevel));
        GetPlacementResult.DeadOperation.NativeMethodInfoPtr__ctor_Private_Void_PlacementOperation_Entity_Entity_PlacementLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr, 100689940);
        GetPlacementResult.DeadOperation.NativeMethodInfoPtr_Create_Public_Static_DeadOperation_PlacementOperation_Entity_Entity_PlacementLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr, 100689941);
        GetPlacementResult.DeadOperation.NativeMethodInfoPtr_GetAllocator_Public_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr, 100689942);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.DeadOperation>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NetworkedChildDependency
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedChild;
      private static readonly System.IntPtr NativeFieldInfoPtr_InternalTileModelIndex;
      [FieldOffset(0)]
      public GetPlacementResult.NetworkedChildKey NetworkedChild;
      [FieldOffset(8)]
      public int InternalTileModelIndex;

      static NetworkedChildDependency()
      {
        Il2CppClassPointerStore<GetPlacementResult.NetworkedChildDependency>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (NetworkedChildDependency));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildDependency>.NativeClassPtr);
        GetPlacementResult.NetworkedChildDependency.NativeFieldInfoPtr_NetworkedChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildDependency>.NativeClassPtr, nameof (NetworkedChild));
        GetPlacementResult.NetworkedChildDependency.NativeFieldInfoPtr_InternalTileModelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildDependency>.NativeClassPtr, nameof (InternalTileModelIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildDependency>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NetworkedChildKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ParentInternalIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedChildIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkedChildKey_0;
      [FieldOffset(0)]
      public int ParentInternalIndex;
      [FieldOffset(4)]
      public int NetworkedChildIndex;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131979, XrefRangeEnd = 1131982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NetworkedChildKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NetworkedChildKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 261548, RefRangeEnd = 261550, XrefRangeStart = 261548, XrefRangeEnd = 261550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(GetPlacementResult.NetworkedChildKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.NetworkedChildKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkedChildKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static NetworkedChildKey()
      {
        Il2CppClassPointerStore<GetPlacementResult.NetworkedChildKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (NetworkedChildKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildKey>.NativeClassPtr);
        GetPlacementResult.NetworkedChildKey.NativeFieldInfoPtr_ParentInternalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildKey>.NativeClassPtr, nameof (ParentInternalIndex));
        GetPlacementResult.NetworkedChildKey.NativeFieldInfoPtr_NetworkedChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildKey>.NativeClassPtr, nameof (NetworkedChildIndex));
        GetPlacementResult.NetworkedChildKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildKey>.NativeClassPtr, 100689943);
        GetPlacementResult.NetworkedChildKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildKey>.NativeClassPtr, 100689944);
        GetPlacementResult.NetworkedChildKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkedChildKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildKey>.NativeClassPtr, 100689945);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.NetworkedChildKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GetStaticTileDataRequirements
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTiles;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTilesBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      [FieldOffset(0)]
      public TileWorld TileWorld;
      [FieldOffset(24)]
      public TerrainChunkLookup TerrainChunks;
      [FieldOffset(40)]
      public BufferFromEntity<BakedPlacementTiles> GetBakedPlacementTiles;
      [FieldOffset(80)]
      public BufferFromEntity<BakedPlacementTilesBounds> GetBakedPlacementTilesBounds;
      [FieldOffset(120)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;

      static GetStaticTileDataRequirements()
      {
        Il2CppClassPointerStore<GetPlacementResult.GetStaticTileDataRequirements>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (GetStaticTileDataRequirements));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.GetStaticTileDataRequirements>.NativeClassPtr);
        GetPlacementResult.GetStaticTileDataRequirements.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetStaticTileDataRequirements>.NativeClassPtr, nameof (TileWorld));
        GetPlacementResult.GetStaticTileDataRequirements.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetStaticTileDataRequirements>.NativeClassPtr, nameof (TerrainChunks));
        GetPlacementResult.GetStaticTileDataRequirements.NativeFieldInfoPtr_GetBakedPlacementTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetStaticTileDataRequirements>.NativeClassPtr, nameof (GetBakedPlacementTiles));
        GetPlacementResult.GetStaticTileDataRequirements.NativeFieldInfoPtr_GetBakedPlacementTilesBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetStaticTileDataRequirements>.NativeClassPtr, nameof (GetBakedPlacementTilesBounds));
        GetPlacementResult.GetStaticTileDataRequirements.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetStaticTileDataRequirements>.NativeClassPtr, nameof (GetLocalToWorld));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.GetStaticTileDataRequirements>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MergedPlacementJobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePlacementTag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLinkedEntityGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      [FieldOffset(0)]
      public ComponentDataFromEntity<TilePlacementTag> GetTilePlacementTag;
      [FieldOffset(32)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(64)]
      public BufferFromEntity<LinkedEntityGroup> GetLinkedEntityGroup;
      [FieldOffset(104)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(136)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;

      static MergedPlacementJobData()
      {
        Il2CppClassPointerStore<GetPlacementResult.MergedPlacementJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (MergedPlacementJobData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.MergedPlacementJobData>.NativeClassPtr);
        GetPlacementResult.MergedPlacementJobData.NativeFieldInfoPtr_GetTilePlacementTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.MergedPlacementJobData>.NativeClassPtr, nameof (GetTilePlacementTag));
        GetPlacementResult.MergedPlacementJobData.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.MergedPlacementJobData>.NativeClassPtr, nameof (GetTileData));
        GetPlacementResult.MergedPlacementJobData.NativeFieldInfoPtr_GetLinkedEntityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.MergedPlacementJobData>.NativeClassPtr, nameof (GetLinkedEntityGroup));
        GetPlacementResult.MergedPlacementJobData.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.MergedPlacementJobData>.NativeClassPtr, nameof (GetTilePosition));
        GetPlacementResult.MergedPlacementJobData.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.MergedPlacementJobData>.NativeClassPtr, nameof (GetLocalToWorld));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.MergedPlacementJobData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NeighbourFloorsInternalResult
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Floor;
      private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
      private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFilter;
      [FieldOffset(0)]
      public GetPlacementResult.InternalOrExternalEntityId Floor;
      [FieldOffset(16)]
      public CardinalDirection Direction;
      [FieldOffset(17)]
      public NeighbourFilter MatchingFilter;

      static NeighbourFloorsInternalResult()
      {
        Il2CppClassPointerStore<GetPlacementResult.NeighbourFloorsInternalResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (NeighbourFloorsInternalResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.NeighbourFloorsInternalResult>.NativeClassPtr);
        GetPlacementResult.NeighbourFloorsInternalResult.NativeFieldInfoPtr_Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.NeighbourFloorsInternalResult>.NativeClassPtr, nameof (Floor));
        GetPlacementResult.NeighbourFloorsInternalResult.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.NeighbourFloorsInternalResult>.NativeClassPtr, nameof (Direction));
        GetPlacementResult.NeighbourFloorsInternalResult.NativeFieldInfoPtr_MatchingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.NeighbourFloorsInternalResult>.NativeClassPtr, nameof (MatchingFilter));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.NeighbourFloorsInternalResult>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalNeighbourFloorsEnumerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_JobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__IsFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr__CurrentResult;
      private static readonly System.IntPtr NativeFieldInfoPtr__InternalNeighbourFloors;
      private static readonly System.IntPtr NativeFieldInfoPtr__ExternalNeighbourFloors;
      private static readonly System.IntPtr NativeFieldInfoPtr__IgnoredExternalEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr__CurrentInternalIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr__CurrentExternalIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr__NeighbourEnumerator;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIgnoreExternalEntity_Private_Static_Boolean_GetNeighbourFloorsJobData_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_Result_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalOrExternalEntityId_Private_InternalOrExternalEntityId_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_InternalNeighbourFloorsEnumerator_0;
      [FieldOffset(0)]
      public GetPlacementResult.GetNeighbourFloorsJobData JobData;
      [FieldOffset(320)]
      public GetPlacementResult.InternalOrExternalEntityId FloorEntity;
      [FieldOffset(336)]
      public bool _IsFloor;
      [FieldOffset(340)]
      public GetPlacementResult.InternalNeighbourFloorsEnumerator.Result _CurrentResult;
      [FieldOffset(360)]
      public NativeList<GetPlacementResult.NeighbourFloorsInternalResult> _InternalNeighbourFloors;
      [FieldOffset(376)]
      public NativeList<RoomUtility.NeighbourFloorsResult> _ExternalNeighbourFloors;
      [FieldOffset(392)]
      public NativeHashSet<Entity> _IgnoredExternalEntities;
      [FieldOffset(408)]
      public int _CurrentInternalIndex;
      [FieldOffset(412)]
      public int _CurrentExternalIndex;
      [FieldOffset(416)]
      public CastleFloorNeighbourEnumerator _NeighbourEnumerator;

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 1132034, RefRangeEnd = 1132046, XrefRangeStart = 1131982, XrefRangeEnd = 1132034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InternalNeighbourFloorsEnumerator(
        ref GetPlacementResult.GetNeighbourFloorsJobData jobData,
        GetPlacementResult.InternalOrExternalEntityId floorEntity,
        NeighbourFilter neighborFilter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref jobData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborFilter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1132076, RefRangeEnd = 1132078, XrefRangeStart = 1132046, XrefRangeEnd = 1132076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool ShouldIgnoreExternalEntity(
        GetPlacementResult.GetNeighbourFloorsJobData jobData,
        Entity externalEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &jobData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &externalEntity;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_ShouldIgnoreExternalEntity_Private_Static_Boolean_GetNeighbourFloorsJobData_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      public unsafe GetPlacementResult.InternalNeighbourFloorsEnumerator.Result Current
      {
        [CallerCount(0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_get_Current_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GetPlacementResult.InternalNeighbourFloorsEnumerator.Result*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 1132112, RefRangeEnd = 1132125, XrefRangeStart = 1132078, XrefRangeEnd = 1132112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool MoveNext()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1132149, RefRangeEnd = 1132151, XrefRangeStart = 1132125, XrefRangeEnd = 1132149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GetPlacementResult.InternalOrExternalEntityId GetInternalOrExternalEntityId(
        Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_GetInternalOrExternalEntityId_Private_InternalOrExternalEntityId_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GetPlacementResult.InternalOrExternalEntityId*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132151, XrefRangeEnd = 1132152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Reset()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1132152, RefRangeEnd = 1132163, XrefRangeStart = 1132152, XrefRangeEnd = 1132152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GetPlacementResult.InternalNeighbourFloorsEnumerator GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_InternalNeighbourFloorsEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GetPlacementResult.InternalNeighbourFloorsEnumerator*) IL2CPP.il2cpp_object_unbox(num);
      }

      static InternalNeighbourFloorsEnumerator()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalNeighbourFloorsEnumerator));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr);
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr_JobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (JobData));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr_FloorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (FloorEntity));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr__IsFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (_IsFloor));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr__CurrentResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (_CurrentResult));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr__InternalNeighbourFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (_InternalNeighbourFloors));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr__ExternalNeighbourFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (_ExternalNeighbourFloors));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr__IgnoredExternalEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (_IgnoredExternalEntities));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr__CurrentInternalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (_CurrentInternalIndex));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr__CurrentExternalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (_CurrentExternalIndex));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeFieldInfoPtr__NeighbourEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (_NeighbourEnumerator));
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_GetNeighbourFloorsJobData_InternalOrExternalEntityId_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, 100689946);
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_ShouldIgnoreExternalEntity_Private_Static_Boolean_GetNeighbourFloorsJobData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, 100689947);
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_get_Current_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, 100689948);
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, 100689949);
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_GetInternalOrExternalEntityId_Private_InternalOrExternalEntityId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, 100689950);
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, 100689951);
        GetPlacementResult.InternalNeighbourFloorsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_InternalNeighbourFloorsEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, 100689952);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Result
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
        private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFilter;
        private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_InternalOrExternalEntityId_Result_0;
        [FieldOffset(0)]
        public GetPlacementResult.InternalOrExternalEntityId Entity;
        [FieldOffset(16)]
        public CardinalDirection Direction;
        [FieldOffset(17)]
        public NeighbourFilter MatchingFilter;

        [CallerCount(0)]
        public static unsafe implicit operator GetPlacementResult.InternalOrExternalEntityId(
          GetPlacementResult.InternalNeighbourFloorsEnumerator.Result result)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &result;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalNeighbourFloorsEnumerator.Result.NativeMethodInfoPtr_op_Implicit_Public_Static_InternalOrExternalEntityId_Result_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GetPlacementResult.InternalOrExternalEntityId*) IL2CPP.il2cpp_object_unbox(num);
        }

        static Result()
        {
          Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator.Result>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator>.NativeClassPtr, nameof (Result));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator.Result>.NativeClassPtr);
          GetPlacementResult.InternalNeighbourFloorsEnumerator.Result.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator.Result>.NativeClassPtr, nameof (Entity));
          GetPlacementResult.InternalNeighbourFloorsEnumerator.Result.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator.Result>.NativeClassPtr, nameof (Direction));
          GetPlacementResult.InternalNeighbourFloorsEnumerator.Result.NativeFieldInfoPtr_MatchingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator.Result>.NativeClassPtr, nameof (MatchingFilter));
          GetPlacementResult.InternalNeighbourFloorsEnumerator.Result.NativeMethodInfoPtr_op_Implicit_Public_Static_InternalOrExternalEntityId_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator.Result>.NativeClassPtr, 100689953);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalNeighbourFloorsEnumerator.Result>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GetNeighbourFloorsJobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InternalTileModels;
      private static readonly System.IntPtr NativeFieldInfoPtr_AllNearbyExistingFloors;
      private static readonly System.IntPtr NativeFieldInfoPtr_GroundConnectedFloors;
      private static readonly System.IntPtr NativeFieldInfoPtr_GroundDisconnectedFloors;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleStairs;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPlacementDestroyData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedChild;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedRoot;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomUtilsJobData_Public_get_GetNeighbourFloorsJobData_0;
      [FieldOffset(0)]
      public NativeList<GetPlacementResult.InternalTileModel> InternalTileModels;
      [FieldOffset(16)]
      public NativeList<Entity> AllNearbyExistingFloors;
      [FieldOffset(32)]
      public NativeHashMap<GetPlacementResult.InternalOrExternalEntityId, NeighbourFilter> GroundConnectedFloors;
      [FieldOffset(48)]
      public NativeHashSet<GetPlacementResult.InternalOrExternalEntityId> GroundDisconnectedFloors;
      [FieldOffset(64)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(96)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(128)]
      public ComponentDataFromEntity<CastleStairs> GetCastleStairs;
      [FieldOffset(160)]
      public ComponentDataFromEntity<PlacementDestroyData> GetPlacementDestroyData;
      [FieldOffset(192)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(224)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(256)]
      public ComponentDataFromEntity<CastleBuildingFusedChild> GetCastleBuildingFusedChild;
      [FieldOffset(288)]
      public ComponentDataFromEntity<CastleBuildingFusedRoot> GetCastleBuildingFusedRoot;

      public unsafe RoomUtility.GetNeighbourFloorsJobData RoomUtilsJobData
      {
        [CallerCount(0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.GetNeighbourFloorsJobData.NativeMethodInfoPtr_get_RoomUtilsJobData_Public_get_GetNeighbourFloorsJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RoomUtility.GetNeighbourFloorsJobData*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      static GetNeighbourFloorsJobData()
      {
        Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (GetNeighbourFloorsJobData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr);
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_InternalTileModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (InternalTileModels));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_AllNearbyExistingFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (AllNearbyExistingFloors));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GroundConnectedFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GroundConnectedFloors));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GroundDisconnectedFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GroundDisconnectedFloors));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetTileData));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetCastleFloor));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetCastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetCastleStairs));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetPlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetPlacementDestroyData));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetTilePosition));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetTranslation));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetCastleBuildingFusedChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetCastleBuildingFusedChild));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetCastleBuildingFusedRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetCastleBuildingFusedRoot));
        GetPlacementResult.GetNeighbourFloorsJobData.NativeMethodInfoPtr_get_RoomUtilsJobData_Public_get_GetNeighbourFloorsJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, 100689954);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.GetNeighbourFloorsJobData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum InternalTileModelSource
    {
      Root,
      NetworkChild,
      AttachedChild,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalTileModel
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExistingEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_OldTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_OldRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_Index;
      private static readonly System.IntPtr NativeFieldInfoPtr_Source;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsFusedRoot;
      private static readonly System.IntPtr NativeFieldInfoPtr_FusedRootParent;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public Entity PrefabEntity;
      [FieldOffset(8)]
      public Entity ExistingEntity;
      [FieldOffset(16)]
      public Translation OldTranslation;
      [FieldOffset(28)]
      public Rotation OldRotation;
      [FieldOffset(44)]
      public Translation NewTranslation;
      [FieldOffset(56)]
      public Rotation NewRotation;
      [FieldOffset(72)]
      public int Index;
      [FieldOffset(76)]
      public GetPlacementResult.InternalTileModelSource Source;
      [FieldOffset(80)]
      public bool IsFusedRoot;
      [FieldOffset(84)]
      public GetPlacementResult.InternalOrExternalEntityId FusedRootParent;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132163, XrefRangeEnd = 1132215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalTileModel.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static InternalTileModel()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalTileModel));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr);
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_PrefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (PrefabEntity));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_ExistingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (ExistingEntity));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_OldTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (OldTranslation));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_OldRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (OldRotation));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_NewTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (NewTranslation));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_NewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (NewRotation));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (Index));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (Source));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_IsFusedRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (IsFusedRoot));
        GetPlacementResult.InternalTileModel.NativeFieldInfoPtr_FusedRootParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, nameof (FusedRootParent));
        GetPlacementResult.InternalTileModel.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, 100689955);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalTileModel>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalTileModelBounds
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public int2 TilePosition;
      [FieldOffset(8)]
      public TileRotation TileRotation;
      [FieldOffset(12)]
      public BoundsMinMax LocalBounds;
      [FieldOffset(28)]
      public BoundsMinMax WorldBounds;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132215, XrefRangeEnd = 1132240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalTileModelBounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static InternalTileModelBounds()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalTileModelBounds));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBounds>.NativeClassPtr);
        GetPlacementResult.InternalTileModelBounds.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBounds>.NativeClassPtr, nameof (TilePosition));
        GetPlacementResult.InternalTileModelBounds.NativeFieldInfoPtr_TileRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBounds>.NativeClassPtr, nameof (TileRotation));
        GetPlacementResult.InternalTileModelBounds.NativeFieldInfoPtr_LocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBounds>.NativeClassPtr, nameof (LocalBounds));
        GetPlacementResult.InternalTileModelBounds.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBounds>.NativeClassPtr, nameof (WorldBounds));
        GetPlacementResult.InternalTileModelBounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBounds>.NativeClassPtr, 100689956);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBounds>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalTileModelBlockReasonData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockReason;
      private static readonly System.IntPtr NativeFieldInfoPtr_DependencyBlockerIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockReasonEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockRequirements;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockRestrictions;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalOverlappingAll;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneId;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldTile;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlockReason_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_MapZoneId_Nullable_Unboxed_1_int3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InternalTileModelBlockReasonData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public BlockReason BlockReason;
      [FieldOffset(4)]
      public Nullable_Unboxed<int> DependencyBlockerIndex;
      [FieldOffset(12)]
      public Nullable_Unboxed<Entity> BlockReasonEntity;
      [FieldOffset(24)]
      public Nullable_Unboxed<PlacementTypeData> BlockRequirements;
      [FieldOffset(72)]
      public Nullable_Unboxed<PlacementTypeData> BlockRestrictions;
      [FieldOffset(120)]
      public Nullable_Unboxed<PlacementTypeData> TotalOverlappingAll;
      [FieldOffset(168)]
      public Nullable_Unboxed<MapZoneId> MapZoneId;
      [FieldOffset(184)]
      public Nullable_Unboxed<int3> WorldTile;

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 1132240, RefRangeEnd = 1132257, XrefRangeStart = 1132240, XrefRangeEnd = 1132240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InternalTileModelBlockReasonData(
        BlockReason blockReason,
        Nullable_Unboxed<int> dependencyBlockerIndex = default (Nullable_Unboxed<int>),
        Nullable_Unboxed<Entity> blockReasonEntity = default (Nullable_Unboxed<Entity>),
        Nullable_Unboxed<PlacementTypeData> blockRequirements = default (Nullable_Unboxed<PlacementTypeData>),
        Nullable_Unboxed<PlacementTypeData> blockRestrictions = default (Nullable_Unboxed<PlacementTypeData>),
        Nullable_Unboxed<PlacementTypeData> totalOverlappingAll = default (Nullable_Unboxed<PlacementTypeData>),
        Nullable_Unboxed<MapZoneId> mapZoneId = default (Nullable_Unboxed<MapZoneId>),
        Nullable_Unboxed<int3> worldTile = default (Nullable_Unboxed<int3>))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &blockReason;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dependencyBlockerIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &blockReasonEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &blockRequirements;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &blockRestrictions;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &totalOverlappingAll;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &mapZoneId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &worldTile;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalTileModelBlockReasonData.NativeMethodInfoPtr__ctor_Public_Void_BlockReason_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_MapZoneId_Nullable_Unboxed_1_int3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1132262, RefRangeEnd = 1132264, XrefRangeStart = 1132257, XrefRangeEnd = 1132262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(
        GetPlacementResult.InternalTileModelBlockReasonData other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalTileModelBlockReasonData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InternalTileModelBlockReasonData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132264, XrefRangeEnd = 1132308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalTileModelBlockReasonData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static InternalTileModelBlockReasonData()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalTileModelBlockReasonData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr);
        GetPlacementResult.InternalTileModelBlockReasonData.NativeFieldInfoPtr_BlockReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, nameof (BlockReason));
        GetPlacementResult.InternalTileModelBlockReasonData.NativeFieldInfoPtr_DependencyBlockerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, nameof (DependencyBlockerIndex));
        GetPlacementResult.InternalTileModelBlockReasonData.NativeFieldInfoPtr_BlockReasonEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, nameof (BlockReasonEntity));
        GetPlacementResult.InternalTileModelBlockReasonData.NativeFieldInfoPtr_BlockRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, nameof (BlockRequirements));
        GetPlacementResult.InternalTileModelBlockReasonData.NativeFieldInfoPtr_BlockRestrictions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, nameof (BlockRestrictions));
        GetPlacementResult.InternalTileModelBlockReasonData.NativeFieldInfoPtr_TotalOverlappingAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, nameof (TotalOverlappingAll));
        GetPlacementResult.InternalTileModelBlockReasonData.NativeFieldInfoPtr_MapZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, nameof (MapZoneId));
        GetPlacementResult.InternalTileModelBlockReasonData.NativeFieldInfoPtr_WorldTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, nameof (WorldTile));
        GetPlacementResult.InternalTileModelBlockReasonData.NativeMethodInfoPtr__ctor_Public_Void_BlockReason_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_PlacementTypeData_Nullable_Unboxed_1_MapZoneId_Nullable_Unboxed_1_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, 100689957);
        GetPlacementResult.InternalTileModelBlockReasonData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InternalTileModelBlockReasonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, 100689958);
        GetPlacementResult.InternalTileModelBlockReasonData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, 100689959);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelBlockReasonData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TileModelBlockReasons
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__BlockReasons;
      private static readonly System.IntPtr NativeFieldInfoPtr__InternalTileModelIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Any_Public_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_BlockReason_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_InternalTileModelBlockReasonData_Boolean_0;
      [FieldOffset(0)]
      public NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> _BlockReasons;
      [FieldOffset(16)]
      public readonly int _InternalTileModelIndex;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 650309, RefRangeEnd = 650313, XrefRangeStart = 650309, XrefRangeEnd = 650313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileModelBlockReasons(
        ref NativeMultiHashMap<int, GetPlacementResult.InternalTileModelBlockReasonData> blockReasons,
        int internalTileModelIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref blockReasons;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &internalTileModelIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.TileModelBlockReasons.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1132311, RefRangeEnd = 1132312, XrefRangeStart = 1132308, XrefRangeEnd = 1132311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool Any()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.TileModelBlockReasons.NativeMethodInfoPtr_Any_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(35)]
      [CachedScanResults(RefRangeStart = 1132313, RefRangeEnd = 1132348, XrefRangeStart = 1132312, XrefRangeEnd = 1132313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Add(BlockReason blockReason, bool avoidDuplicates = true)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &blockReason;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &avoidDuplicates;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.TileModelBlockReasons.NativeMethodInfoPtr_Add_Public_Void_BlockReason_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 1132361, RefRangeEnd = 1132373, XrefRangeStart = 1132348, XrefRangeEnd = 1132361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Add(
        GetPlacementResult.InternalTileModelBlockReasonData blockReasonData,
        bool avoidDuplicates = true)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &blockReasonData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &avoidDuplicates;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.TileModelBlockReasons.NativeMethodInfoPtr_Add_Public_Void_InternalTileModelBlockReasonData_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileModelBlockReasons()
      {
        Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (TileModelBlockReasons));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr);
        GetPlacementResult.TileModelBlockReasons.NativeFieldInfoPtr__BlockReasons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr, nameof (_BlockReasons));
        GetPlacementResult.TileModelBlockReasons.NativeFieldInfoPtr__InternalTileModelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr, nameof (_InternalTileModelIndex));
        GetPlacementResult.TileModelBlockReasons.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeMultiHashMap_2_Int32_InternalTileModelBlockReasonData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr, 100689960);
        GetPlacementResult.TileModelBlockReasons.NativeMethodInfoPtr_Any_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr, 100689961);
        GetPlacementResult.TileModelBlockReasons.NativeMethodInfoPtr_Add_Public_Void_BlockReason_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr, 100689962);
        GetPlacementResult.TileModelBlockReasons.NativeMethodInfoPtr_Add_Public_Void_InternalTileModelBlockReasonData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr, 100689963);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.TileModelBlockReasons>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalTileModelPlacementResults
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CanPlace;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachToCastleHeart;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachToCastleTerritory;
      private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_AllExistingFlags;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public bool CanPlace;
      [FieldOffset(4)]
      public Entity AttachToCastleHeart;
      [FieldOffset(12)]
      public Entity AttachToCastleTerritory;
      [FieldOffset(24)]
      public PlacementTypeData MatchingFlags;
      [FieldOffset(64)]
      public PlacementTypeData AllExistingFlags;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132373, XrefRangeEnd = 1132379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalTileModelPlacementResults.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static InternalTileModelPlacementResults()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalTileModelPlacementResults));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr);
        GetPlacementResult.InternalTileModelPlacementResults.NativeFieldInfoPtr_CanPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr, nameof (CanPlace));
        GetPlacementResult.InternalTileModelPlacementResults.NativeFieldInfoPtr_AttachToCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr, nameof (AttachToCastleHeart));
        GetPlacementResult.InternalTileModelPlacementResults.NativeFieldInfoPtr_AttachToCastleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr, nameof (AttachToCastleTerritory));
        GetPlacementResult.InternalTileModelPlacementResults.NativeFieldInfoPtr_MatchingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr, nameof (MatchingFlags));
        GetPlacementResult.InternalTileModelPlacementResults.NativeFieldInfoPtr_AllExistingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr, nameof (AllExistingFlags));
        GetPlacementResult.InternalTileModelPlacementResults.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr, 100689964);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelPlacementResults>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum DependencyReason
    {
      NetworkedChild,
      AttachedChild,
      FusedChild,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalTileModelDependency
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Index;
      private static readonly System.IntPtr NativeFieldInfoPtr_DependentOnIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_DependencyReason;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockSpawnFromDependency;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public int Index;
      [FieldOffset(4)]
      public int DependentOnIndex;
      [FieldOffset(8)]
      public GetPlacementResult.DependencyReason DependencyReason;
      [FieldOffset(12)]
      public bool BlockSpawnFromDependency;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132379, XrefRangeEnd = 1132404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalTileModelDependency.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static InternalTileModelDependency()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalTileModelDependency>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalTileModelDependency));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelDependency>.NativeClassPtr);
        GetPlacementResult.InternalTileModelDependency.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelDependency>.NativeClassPtr, nameof (Index));
        GetPlacementResult.InternalTileModelDependency.NativeFieldInfoPtr_DependentOnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelDependency>.NativeClassPtr, nameof (DependentOnIndex));
        GetPlacementResult.InternalTileModelDependency.NativeFieldInfoPtr_DependencyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelDependency>.NativeClassPtr, nameof (DependencyReason));
        GetPlacementResult.InternalTileModelDependency.NativeFieldInfoPtr_BlockSpawnFromDependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelDependency>.NativeClassPtr, nameof (BlockSpawnFromDependency));
        GetPlacementResult.InternalTileModelDependency.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelDependency>.NativeClassPtr, 100689965);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalTileModelDependency>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TileModelPlacementData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityId;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementData;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsStatic;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public GetPlacementResult.InternalOrExternalEntityId EntityId;
      [FieldOffset(16)]
      public PlacementData PlacementData;
      [FieldOffset(216)]
      public bool IsStatic;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132404, XrefRangeEnd = 1132413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.TileModelPlacementData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static TileModelPlacementData()
      {
        Il2CppClassPointerStore<GetPlacementResult.TileModelPlacementData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (TileModelPlacementData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.TileModelPlacementData>.NativeClassPtr);
        GetPlacementResult.TileModelPlacementData.NativeFieldInfoPtr_EntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.TileModelPlacementData>.NativeClassPtr, nameof (EntityId));
        GetPlacementResult.TileModelPlacementData.NativeFieldInfoPtr_PlacementData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.TileModelPlacementData>.NativeClassPtr, nameof (PlacementData));
        GetPlacementResult.TileModelPlacementData.NativeFieldInfoPtr_IsStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.TileModelPlacementData>.NativeClassPtr, nameof (IsStatic));
        GetPlacementResult.TileModelPlacementData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.TileModelPlacementData>.NativeClassPtr, 100689966);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.TileModelPlacementData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalOrExternalEntityId
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InternalEntityIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExternalEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_InternalOrExternalEntityId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInternalEntity_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExternalEntity_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FromExternalEntity_Public_Static_InternalOrExternalEntityId_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FromInternalEntity_Public_Static_InternalOrExternalEntityId_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InternalOrExternalEntityId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InternalOrExternalEntityId_InternalOrExternalEntityId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InternalOrExternalEntityId_InternalOrExternalEntityId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Entity_InternalOrExternalEntityId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Entity_InternalOrExternalEntityId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityOrPrefab_Internal_Entity_NativeList_1_InternalTileModel_0;
      [FieldOffset(0)]
      public Nullable_Unboxed<int> InternalEntityIndex;
      [FieldOffset(8)]
      public Entity ExternalEntity;

      public static unsafe GetPlacementResult.InternalOrExternalEntityId Null
      {
        [CallerCount(54), CachedScanResults(RefRangeStart = 533439, RefRangeEnd = 533493, XrefRangeStart = 533439, XrefRangeEnd = 533493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_get_Null_Public_Static_get_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GetPlacementResult.InternalOrExternalEntityId*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool IsInternalEntity
      {
        [CallerCount(3), CachedScanResults(RefRangeStart = 1132414, RefRangeEnd = 1132417, XrefRangeStart = 1132413, XrefRangeEnd = 1132414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_get_IsInternalEntity_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool IsExternalEntity
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 1132418, RefRangeEnd = 1132419, XrefRangeStart = 1132417, XrefRangeEnd = 1132418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_get_IsExternalEntity_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1132419, RefRangeEnd = 1132426, XrefRangeStart = 1132419, XrefRangeEnd = 1132419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe GetPlacementResult.InternalOrExternalEntityId FromExternalEntity(
        Entity externalEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &externalEntity;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_FromExternalEntity_Public_Static_InternalOrExternalEntityId_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GetPlacementResult.InternalOrExternalEntityId*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 1132430, RefRangeEnd = 1132439, XrefRangeStart = 1132426, XrefRangeEnd = 1132430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe GetPlacementResult.InternalOrExternalEntityId FromInternalEntity(
        int internalEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &internalEntityIndex;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_FromInternalEntity_Public_Static_InternalOrExternalEntityId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GetPlacementResult.InternalOrExternalEntityId*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132439, XrefRangeEnd = 1132442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(
        GetPlacementResult.InternalOrExternalEntityId other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InternalOrExternalEntityId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132442, XrefRangeEnd = 1132445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132445, XrefRangeEnd = 1132448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 1132451, RefRangeEnd = 1132464, XrefRangeStart = 1132448, XrefRangeEnd = 1132451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool operator ==(
        GetPlacementResult.InternalOrExternalEntityId x,
        GetPlacementResult.InternalOrExternalEntityId y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InternalOrExternalEntityId_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1132467, RefRangeEnd = 1132470, XrefRangeStart = 1132464, XrefRangeEnd = 1132467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool operator !=(
        GetPlacementResult.InternalOrExternalEntityId x,
        GetPlacementResult.InternalOrExternalEntityId y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InternalOrExternalEntityId_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132470, XrefRangeEnd = 1132472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool operator ==(
        Entity x,
        GetPlacementResult.InternalOrExternalEntityId y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Entity_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132472, XrefRangeEnd = 1132474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool operator !=(
        Entity x,
        GetPlacementResult.InternalOrExternalEntityId y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Entity_InternalOrExternalEntityId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132474, XrefRangeEnd = 1132483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 1132497, RefRangeEnd = 1132506, XrefRangeStart = 1132483, XrefRangeEnd = 1132497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Entity GetEntityOrPrefab(
        NativeList<GetPlacementResult.InternalTileModel> internalTileModels)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &internalTileModels;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_GetEntityOrPrefab_Internal_Entity_NativeList_1_InternalTileModel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }

      static InternalOrExternalEntityId()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalOrExternalEntityId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr);
        GetPlacementResult.InternalOrExternalEntityId.NativeFieldInfoPtr_InternalEntityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, nameof (InternalEntityIndex));
        GetPlacementResult.InternalOrExternalEntityId.NativeFieldInfoPtr_ExternalEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, nameof (ExternalEntity));
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_get_Null_Public_Static_get_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689967);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_get_IsInternalEntity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689968);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_get_IsExternalEntity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689969);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_FromExternalEntity_Public_Static_InternalOrExternalEntityId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689970);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_FromInternalEntity_Public_Static_InternalOrExternalEntityId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689971);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689972);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689973);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689974);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InternalOrExternalEntityId_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689975);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InternalOrExternalEntityId_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689976);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Entity_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689977);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Entity_InternalOrExternalEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689978);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689979);
        GetPlacementResult.InternalOrExternalEntityId.NativeMethodInfoPtr_GetEntityOrPrefab_Internal_Entity_NativeList_1_InternalTileModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, 100689980);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalOrExternalEntityId>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalDestroyTileModelData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityToDestroy;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityCausedDestruction;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_Replaces;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsDismantlable;
      private static readonly System.IntPtr NativeFieldInfoPtr_Canceled;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public GetPlacementResult.InternalOrExternalEntityId EntityToDestroy;
      [FieldOffset(16)]
      public GetPlacementResult.InternalOrExternalEntityId EntityCausedDestruction;
      [FieldOffset(32)]
      public PlacementTypeData PlacementTypes;
      [FieldOffset(72)]
      public PlacementTypeData Replaces;
      [FieldOffset(112)]
      public bool IsDismantlable;
      [FieldOffset(113)]
      public bool Canceled;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132506, XrefRangeEnd = 1132539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalDestroyTileModelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static InternalDestroyTileModelData()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalDestroyTileModelData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr);
        GetPlacementResult.InternalDestroyTileModelData.NativeFieldInfoPtr_EntityToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr, nameof (EntityToDestroy));
        GetPlacementResult.InternalDestroyTileModelData.NativeFieldInfoPtr_EntityCausedDestruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr, nameof (EntityCausedDestruction));
        GetPlacementResult.InternalDestroyTileModelData.NativeFieldInfoPtr_PlacementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr, nameof (PlacementTypes));
        GetPlacementResult.InternalDestroyTileModelData.NativeFieldInfoPtr_Replaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr, nameof (Replaces));
        GetPlacementResult.InternalDestroyTileModelData.NativeFieldInfoPtr_IsDismantlable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr, nameof (IsDismantlable));
        GetPlacementResult.InternalDestroyTileModelData.NativeFieldInfoPtr_Canceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr, nameof (Canceled));
        GetPlacementResult.InternalDestroyTileModelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr, 100689981);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalDestroyTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum AttachCancelReason
    {
      None,
      InternalParentNotSpawned,
      InternalChildNotSpawned,
      AlreadyAttached,
      ChildReplaced,
      ParentReplaced,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InternalAttachTileModelData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ChildEntityToAttach;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParentEntityAttachingTo;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachTo;
      private static readonly System.IntPtr NativeFieldInfoPtr_Canceled;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachCancelReason;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public GetPlacementResult.InternalOrExternalEntityId ChildEntityToAttach;
      [FieldOffset(16)]
      public GetPlacementResult.InternalOrExternalEntityId ParentEntityAttachingTo;
      [FieldOffset(32)]
      public CastleBuildingAttachSettings AttachSettings;
      [FieldOffset(40)]
      public PlacementTypeData PlacementTypes;
      [FieldOffset(80)]
      public PlacementTypeData AttachTo;
      [FieldOffset(120)]
      public bool Canceled;
      [FieldOffset(124)]
      public GetPlacementResult.AttachCancelReason AttachCancelReason;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132539, XrefRangeEnd = 1132578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GetPlacementResult.InternalAttachTileModelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static InternalAttachTileModelData()
      {
        Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResult>.NativeClassPtr, nameof (InternalAttachTileModelData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr);
        GetPlacementResult.InternalAttachTileModelData.NativeFieldInfoPtr_ChildEntityToAttach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, nameof (ChildEntityToAttach));
        GetPlacementResult.InternalAttachTileModelData.NativeFieldInfoPtr_ParentEntityAttachingTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, nameof (ParentEntityAttachingTo));
        GetPlacementResult.InternalAttachTileModelData.NativeFieldInfoPtr_AttachSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, nameof (AttachSettings));
        GetPlacementResult.InternalAttachTileModelData.NativeFieldInfoPtr_PlacementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, nameof (PlacementTypes));
        GetPlacementResult.InternalAttachTileModelData.NativeFieldInfoPtr_AttachTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, nameof (AttachTo));
        GetPlacementResult.InternalAttachTileModelData.NativeFieldInfoPtr_Canceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, nameof (Canceled));
        GetPlacementResult.InternalAttachTileModelData.NativeFieldInfoPtr_AttachCancelReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, nameof (AttachCancelReason));
        GetPlacementResult.InternalAttachTileModelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, 100689982);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.InternalAttachTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
