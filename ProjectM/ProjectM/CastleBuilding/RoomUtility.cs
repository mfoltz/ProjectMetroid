// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.RoomUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class RoomUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NeighborDirections;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindAllConnectedRoomsForRoom_Public_Static_Void_Entity_NativeHashSet_1_Entity_NativeHashSet_1_Entity_BufferFromEntity_1_CastleRoomFloorsBuffer_ScanStructureGetters_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindAllConnectedRoomsForFloor_Public_Static_Void_Entity_NativeHashSet_1_Entity_NativeHashSet_1_Entity_ScanStructureGetters_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindAllConnectedRoomsForFloor_Public_Static_Void_NeighbourData_NativeHashSet_1_Entity_NativeHashSet_1_Entity_ScanStructureGetters_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddWallsForFloor_Public_Static_Void_Entity_NativeHashSet_1_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFloorAtTile_Public_Static_Boolean_byref_SpatialLookupParams_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_int2_Nullable_Unboxed_1_Byte_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHighestFloorHeightLevelAtTile_Public_Static_Boolean_byref_SpatialLookupParams_byref_ComponentDataFromEntity_1_CastleFloor_byref_ComponentDataFromEntity_1_TilePosition_byref_ComponentDataFromEntity_1_TileData_int2_byref_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSpeedBonusAtTile_Public_Static_Boolean_byref_SpatialLookupParams_ComponentDataFromEntity_1_TileData_ComponentDataFromEntity_1_PavementBonusSource_int2_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundsForFloorNeighbours_Public_Static_BoundsMinMax_TilePosition_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighbourFloors_Public_Static_NativeList_1_NeighbourFloorsResult_byref_GetNeighbourFloorsJobData_TilePosition_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_SpatialLookupParams_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterNeighbourFloors_Public_Static_NativeList_1_NeighbourFloorsResult_byref_GetNeighbourFloorsJobData_byref_NativeList_1_Entity_byref_TilePosition_byref_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFloorNeighbour_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TilePosition_byref_TilePivotSettings_byref_CastleFloor_byref_CastleStairs_Nullable_Unboxed_1_Entity_Entity_NeighbourFilter_byref_CardinalDirection_byref_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFusedRoot_Public_Static_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_ComponentDataFromEntity_1_CastleBuildingFusedChild_ComponentDataFromEntity_1_CastleBuildingFusedRoot_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFloorNeighbour_Public_Static_Boolean_byref_SourceFloorData_byref_NeighbourFloorData_NeighbourFilter_byref_CardinalDirection_byref_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidStairsConnection_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidStairNeighborHorizontal_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidStairNeighborVertical_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFloorNeighbourDirection_Public_Static_Boolean_byref_SourceFloorData_byref_NeighbourFloorData_byref_CardinalDirection_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1129979, RefRangeEnd = 1129980, XrefRangeStart = 1129956, XrefRangeEnd = 1129979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindAllConnectedRoomsForRoom(
      Entity roomEntity,
      NativeHashSet<Entity> exploredFloors,
      NativeHashSet<Entity> exploredRooms,
      BufferFromEntity<CastleRoomFloorsBuffer> getRoomFloors,
      RoomUtility.ScanStructureGetters getters)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &roomEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &exploredFloors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &exploredRooms;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getRoomFloors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getters;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_FindAllConnectedRoomsForRoom_Public_Static_Void_Entity_NativeHashSet_1_Entity_NativeHashSet_1_Entity_BufferFromEntity_1_CastleRoomFloorsBuffer_ScanStructureGetters_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1129984, RefRangeEnd = 1129985, XrefRangeStart = 1129980, XrefRangeEnd = 1129984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindAllConnectedRoomsForFloor(
      Entity floor,
      NativeHashSet<Entity> exploredFloors,
      NativeHashSet<Entity> exploredRooms,
      RoomUtility.ScanStructureGetters getters)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &floor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &exploredFloors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &exploredRooms;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getters;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_FindAllConnectedRoomsForFloor_Public_Static_Void_Entity_NativeHashSet_1_Entity_NativeHashSet_1_Entity_ScanStructureGetters_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1130049, RefRangeEnd = 1130051, XrefRangeStart = 1129985, XrefRangeEnd = 1130049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindAllConnectedRoomsForFloor(
      NeighbourData floor,
      NativeHashSet<Entity> exploredFloors,
      NativeHashSet<Entity> exploredRooms,
      RoomUtility.ScanStructureGetters getters)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &floor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &exploredFloors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &exploredRooms;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getters;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_FindAllConnectedRoomsForFloor_Public_Static_Void_NeighbourData_NativeHashSet_1_Entity_NativeHashSet_1_Entity_ScanStructureGetters_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130051, XrefRangeEnd = 1130075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddWallsForFloor(
      Entity floor,
      NativeHashSet<Entity> walls,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ComponentDataFromEntity<CastleRoomWall> getCastleWall)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &floor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &walls;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleWall;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_AddWallsForFloor_Public_Static_Void_Entity_NativeHashSet_1_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1130111, RefRangeEnd = 1130121, XrefRangeStart = 1130075, XrefRangeEnd = 1130111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetFloorAtTile(
      ref SpatialLookupParams spatialLookupParams,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ComponentDataFromEntity<TileData> getTileData,
      int2 worldTile,
      Nullable_Unboxed<byte> requiredHeightLevel,
      out Entity floorEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref spatialLookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &requiredHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_TryGetFloorAtTile_Public_Static_Boolean_byref_SpatialLookupParams_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_int2_Nullable_Unboxed_1_Byte_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130121, XrefRangeEnd = 1130152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetHighestFloorHeightLevelAtTile(
      ref SpatialLookupParams spatialLookupParams,
      ref ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ref ComponentDataFromEntity<TilePosition> getTilePosition,
      ref ComponentDataFromEntity<TileData> getTileData,
      int2 worldTile,
      out byte tileHeightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref spatialLookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileHeightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_TryGetHighestFloorHeightLevelAtTile_Public_Static_Boolean_byref_SpatialLookupParams_byref_ComponentDataFromEntity_1_CastleFloor_byref_ComponentDataFromEntity_1_TilePosition_byref_ComponentDataFromEntity_1_TileData_int2_byref_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1130169, RefRangeEnd = 1130170, XrefRangeStart = 1130152, XrefRangeEnd = 1130169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetSpeedBonusAtTile(
      ref SpatialLookupParams spatialLookupParams,
      ComponentDataFromEntity<TileData> getTileData,
      ComponentDataFromEntity<PavementBonusSource> getPavementBonusSource,
      int2 worldTile,
      out Entity bonusEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref spatialLookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getPavementBonusSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref bonusEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_TryGetSpeedBonusAtTile_Public_Static_Boolean_byref_SpatialLookupParams_ComponentDataFromEntity_1_TileData_ComponentDataFromEntity_1_PavementBonusSource_int2_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130170, XrefRangeEnd = 1130172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetBoundsForFloorNeighbours(
      TilePosition tilePosition,
      TilePivotSettings pivotSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_GetBoundsForFloorNeighbours_Public_Static_BoundsMinMax_TilePosition_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1130196, RefRangeEnd = 1130197, XrefRangeStart = 1130172, XrefRangeEnd = 1130196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<RoomUtility.NeighbourFloorsResult> GetNeighbourFloors(
      ref RoomUtility.GetNeighbourFloorsJobData jobData,
      TilePosition tilePosition,
      TilePivotSettings pivotSettings,
      CastleFloor castleFloor,
      CastleStairs castleStairs,
      Nullable_Unboxed<Entity> castleStairsEntity,
      NeighbourFilter requireFilter,
      SpatialLookupParams spatialLookupParams,
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
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialLookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_GetNeighbourFloors_Public_Static_NativeList_1_NeighbourFloorsResult_byref_GetNeighbourFloorsJobData_TilePosition_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_SpatialLookupParams_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<RoomUtility.NeighbourFloorsResult>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1130215, RefRangeEnd = 1130217, XrefRangeStart = 1130197, XrefRangeEnd = 1130215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<RoomUtility.NeighbourFloorsResult> FilterNeighbourFloors(
      ref RoomUtility.GetNeighbourFloorsJobData jobData,
      [In] ref NativeList<Entity> tileModels,
      [In] ref TilePosition tilePosition,
      [In] ref TilePivotSettings pivotSettings,
      CastleFloor castleFloor,
      CastleStairs castleStairs,
      Nullable_Unboxed<Entity> castleStairsEntity,
      NeighbourFilter requireFilter,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileModels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &castleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &castleStairs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &castleStairsEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &requireFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_FilterNeighbourFloors_Public_Static_NativeList_1_NeighbourFloorsResult_byref_GetNeighbourFloorsJobData_byref_NativeList_1_Entity_byref_TilePosition_byref_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<RoomUtility.NeighbourFloorsResult>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1130274, RefRangeEnd = 1130276, XrefRangeStart = 1130217, XrefRangeEnd = 1130274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetFloorNeighbour(
      ref RoomUtility.GetNeighbourFloorsJobData jobData,
      [In] ref TilePosition sourceTilePosition,
      [In] ref TilePivotSettings sourcePivotSettings,
      [In] ref CastleFloor sourceCastleFloor,
      [In] ref CastleStairs sourceCastleStairs,
      Nullable_Unboxed<Entity> sourceEntity,
      Entity potentialFloorNeighbour,
      NeighbourFilter requireFilter,
      out CardinalDirection cardinalDirection,
      out NeighbourFilter matchingFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sourceTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sourcePivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref sourceCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref sourceCastleStairs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &potentialFloorNeighbour;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &requireFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref cardinalDirection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref matchingFilter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_TryGetFloorNeighbour_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TilePosition_byref_TilePivotSettings_byref_CastleFloor_byref_CastleStairs_Nullable_Unboxed_1_Entity_Entity_NeighbourFilter_byref_CardinalDirection_byref_NeighbourFilter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1130294, RefRangeEnd = 1130296, XrefRangeStart = 1130276, XrefRangeEnd = 1130294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Nullable_Unboxed<Entity> GetFusedRoot(
      Nullable_Unboxed<Entity> entity,
      ComponentDataFromEntity<CastleBuildingFusedChild> getCastleBuildingFusedChild,
      ComponentDataFromEntity<CastleBuildingFusedRoot> getCastleBuildingFusedRoot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleBuildingFusedChild;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleBuildingFusedRoot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_GetFusedRoot_Public_Static_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_ComponentDataFromEntity_1_CastleBuildingFusedChild_ComponentDataFromEntity_1_CastleBuildingFusedRoot_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1130310, RefRangeEnd = 1130312, XrefRangeStart = 1130296, XrefRangeEnd = 1130310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetFloorNeighbour(
      [In] ref RoomUtility.SourceFloorData sourceFloor,
      [In] ref RoomUtility.NeighbourFloorData neighbourFloor,
      NeighbourFilter requireFilter,
      out CardinalDirection neighborDirection,
      out NeighbourFilter matchingFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref sourceFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref neighbourFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &requireFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref neighborDirection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref matchingFilter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_TryGetFloorNeighbour_Public_Static_Boolean_byref_SourceFloorData_byref_NeighbourFloorData_NeighbourFilter_byref_CardinalDirection_byref_NeighbourFilter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1130327, RefRangeEnd = 1130328, XrefRangeStart = 1130312, XrefRangeEnd = 1130327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValidStairsConnection(
      RoomUtility.SourceFloorData sourceFloor,
      RoomUtility.NeighbourFloorData neighbourFloor,
      CardinalDirection neighborDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &sourceFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &neighbourFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_IsValidStairsConnection_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130328, XrefRangeEnd = 1130337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValidStairNeighborHorizontal(
      RoomUtility.SourceFloorData sourceFloor,
      RoomUtility.NeighbourFloorData neighbourFloor,
      CardinalDirection neighborDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &sourceFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &neighbourFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &neighborDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_IsValidStairNeighborHorizontal_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsValidStairNeighborVertical(
      RoomUtility.SourceFloorData sourceFloor,
      RoomUtility.NeighbourFloorData neighbourFloor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &sourceFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &neighbourFloor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_IsValidStairNeighborVertical_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130337, XrefRangeEnd = 1130345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetFloorNeighbourDirection(
      [In] ref RoomUtility.SourceFloorData sourceFloor,
      [In] ref RoomUtility.NeighbourFloorData neighbourFloor,
      out CardinalDirection neighborDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref sourceFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref neighbourFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref neighborDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomUtility.NativeMethodInfoPtr_TryGetFloorNeighbourDirection_Public_Static_Boolean_byref_SourceFloorData_byref_NeighbourFloorData_byref_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RoomUtility()
    {
      Il2CppClassPointerStore<RoomUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (RoomUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr);
      RoomUtility.NativeFieldInfoPtr_NeighborDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, nameof (NeighborDirections));
      RoomUtility.NativeMethodInfoPtr_FindAllConnectedRoomsForRoom_Public_Static_Void_Entity_NativeHashSet_1_Entity_NativeHashSet_1_Entity_BufferFromEntity_1_CastleRoomFloorsBuffer_ScanStructureGetters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689786);
      RoomUtility.NativeMethodInfoPtr_FindAllConnectedRoomsForFloor_Public_Static_Void_Entity_NativeHashSet_1_Entity_NativeHashSet_1_Entity_ScanStructureGetters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689787);
      RoomUtility.NativeMethodInfoPtr_FindAllConnectedRoomsForFloor_Public_Static_Void_NeighbourData_NativeHashSet_1_Entity_NativeHashSet_1_Entity_ScanStructureGetters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689788);
      RoomUtility.NativeMethodInfoPtr_AddWallsForFloor_Public_Static_Void_Entity_NativeHashSet_1_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689789);
      RoomUtility.NativeMethodInfoPtr_TryGetFloorAtTile_Public_Static_Boolean_byref_SpatialLookupParams_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_int2_Nullable_Unboxed_1_Byte_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689790);
      RoomUtility.NativeMethodInfoPtr_TryGetHighestFloorHeightLevelAtTile_Public_Static_Boolean_byref_SpatialLookupParams_byref_ComponentDataFromEntity_1_CastleFloor_byref_ComponentDataFromEntity_1_TilePosition_byref_ComponentDataFromEntity_1_TileData_int2_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689791);
      RoomUtility.NativeMethodInfoPtr_TryGetSpeedBonusAtTile_Public_Static_Boolean_byref_SpatialLookupParams_ComponentDataFromEntity_1_TileData_ComponentDataFromEntity_1_PavementBonusSource_int2_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689792);
      RoomUtility.NativeMethodInfoPtr_GetBoundsForFloorNeighbours_Public_Static_BoundsMinMax_TilePosition_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689793);
      RoomUtility.NativeMethodInfoPtr_GetNeighbourFloors_Public_Static_NativeList_1_NeighbourFloorsResult_byref_GetNeighbourFloorsJobData_TilePosition_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_SpatialLookupParams_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689794);
      RoomUtility.NativeMethodInfoPtr_FilterNeighbourFloors_Public_Static_NativeList_1_NeighbourFloorsResult_byref_GetNeighbourFloorsJobData_byref_NativeList_1_Entity_byref_TilePosition_byref_TilePivotSettings_CastleFloor_CastleStairs_Nullable_Unboxed_1_Entity_NeighbourFilter_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689795);
      RoomUtility.NativeMethodInfoPtr_TryGetFloorNeighbour_Private_Static_Boolean_byref_GetNeighbourFloorsJobData_byref_TilePosition_byref_TilePivotSettings_byref_CastleFloor_byref_CastleStairs_Nullable_Unboxed_1_Entity_Entity_NeighbourFilter_byref_CardinalDirection_byref_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689796);
      RoomUtility.NativeMethodInfoPtr_GetFusedRoot_Public_Static_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_ComponentDataFromEntity_1_CastleBuildingFusedChild_ComponentDataFromEntity_1_CastleBuildingFusedRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689797);
      RoomUtility.NativeMethodInfoPtr_TryGetFloorNeighbour_Public_Static_Boolean_byref_SourceFloorData_byref_NeighbourFloorData_NeighbourFilter_byref_CardinalDirection_byref_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689798);
      RoomUtility.NativeMethodInfoPtr_IsValidStairsConnection_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689799);
      RoomUtility.NativeMethodInfoPtr_IsValidStairNeighborHorizontal_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689800);
      RoomUtility.NativeMethodInfoPtr_IsValidStairNeighborVertical_Private_Static_Boolean_SourceFloorData_NeighbourFloorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689801);
      RoomUtility.NativeMethodInfoPtr_TryGetFloorNeighbourDirection_Public_Static_Boolean_byref_SourceFloorData_byref_NeighbourFloorData_byref_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, 100689802);
    }

    public RoomUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppStructArray<CardinalDirection> NeighborDirections
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(RoomUtility.NativeFieldInfoPtr_NeighborDirections, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<CardinalDirection>) null : new Il2CppStructArray<CardinalDirection>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoomUtility.NativeFieldInfoPtr_NeighborDirections, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ScanStructureGetters
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      [FieldOffset(0)]
      public ComponentDataFromEntity<CastleRoomConnection> GetRoomConnection;
      [FieldOffset(32)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;

      static ScanStructureGetters()
      {
        Il2CppClassPointerStore<RoomUtility.ScanStructureGetters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, nameof (ScanStructureGetters));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomUtility.ScanStructureGetters>.NativeClassPtr);
        RoomUtility.ScanStructureGetters.NativeFieldInfoPtr_GetRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.ScanStructureGetters>.NativeClassPtr, nameof (GetRoomConnection));
        RoomUtility.ScanStructureGetters.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.ScanStructureGetters>.NativeClassPtr, nameof (GetCastleFloor));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomUtility.ScanStructureGetters>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NeighbourFloorsResult
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Floor;
      private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
      private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFilter;
      [FieldOffset(0)]
      public Entity Floor;
      [FieldOffset(8)]
      public CardinalDirection Direction;
      [FieldOffset(9)]
      public NeighbourFilter MatchingFilter;

      static NeighbourFloorsResult()
      {
        Il2CppClassPointerStore<RoomUtility.NeighbourFloorsResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, nameof (NeighbourFloorsResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomUtility.NeighbourFloorsResult>.NativeClassPtr);
        RoomUtility.NeighbourFloorsResult.NativeFieldInfoPtr_Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.NeighbourFloorsResult>.NativeClassPtr, nameof (Floor));
        RoomUtility.NeighbourFloorsResult.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.NeighbourFloorsResult>.NativeClassPtr, nameof (Direction));
        RoomUtility.NeighbourFloorsResult.NativeFieldInfoPtr_MatchingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.NeighbourFloorsResult>.NativeClassPtr, nameof (MatchingFilter));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomUtility.NeighbourFloorsResult>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GetNeighbourFloorsJobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleStairs;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedChild;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedRoot;
      [FieldOffset(0)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(32)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(64)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(96)]
      public ComponentDataFromEntity<CastleStairs> GetCastleStairs;
      [FieldOffset(128)]
      public ComponentDataFromEntity<CastleBuildingFusedChild> GetCastleBuildingFusedChild;
      [FieldOffset(160)]
      public ComponentDataFromEntity<CastleBuildingFusedRoot> GetCastleBuildingFusedRoot;

      static GetNeighbourFloorsJobData()
      {
        Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, nameof (GetNeighbourFloorsJobData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr);
        RoomUtility.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetCastleFloor));
        RoomUtility.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetTilePosition));
        RoomUtility.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetTileData));
        RoomUtility.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetCastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetCastleStairs));
        RoomUtility.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetCastleBuildingFusedChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetCastleBuildingFusedChild));
        RoomUtility.GetNeighbourFloorsJobData.NativeFieldInfoPtr_GetCastleBuildingFusedRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr, nameof (GetCastleBuildingFusedRoot));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomUtility.GetNeighbourFloorsJobData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SourceFloorData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_PivotSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleStairs;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleStairsFusedRoot;
      [FieldOffset(0)]
      public TilePosition TilePosition;
      [FieldOffset(12)]
      public TilePivotSettings PivotSettings;
      [FieldOffset(24)]
      public CastleFloor CastleFloor;
      [FieldOffset(132)]
      public CastleStairs CastleStairs;
      [FieldOffset(140)]
      public Nullable_Unboxed<Entity> CastleStairsFusedRoot;

      static SourceFloorData()
      {
        Il2CppClassPointerStore<RoomUtility.SourceFloorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, nameof (SourceFloorData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomUtility.SourceFloorData>.NativeClassPtr);
        RoomUtility.SourceFloorData.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.SourceFloorData>.NativeClassPtr, nameof (TilePosition));
        RoomUtility.SourceFloorData.NativeFieldInfoPtr_PivotSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.SourceFloorData>.NativeClassPtr, nameof (PivotSettings));
        RoomUtility.SourceFloorData.NativeFieldInfoPtr_CastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.SourceFloorData>.NativeClassPtr, nameof (CastleFloor));
        RoomUtility.SourceFloorData.NativeFieldInfoPtr_CastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.SourceFloorData>.NativeClassPtr, nameof (CastleStairs));
        RoomUtility.SourceFloorData.NativeFieldInfoPtr_CastleStairsFusedRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.SourceFloorData>.NativeClassPtr, nameof (CastleStairsFusedRoot));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomUtility.SourceFloorData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NeighbourFloorData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_PivotSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleStairs;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleStairsFusedRoot;
      [FieldOffset(0)]
      public TilePosition TilePosition;
      [FieldOffset(12)]
      public TilePivotSettings PivotSettings;
      [FieldOffset(24)]
      public CastleFloor CastleFloor;
      [FieldOffset(132)]
      public CastleStairs CastleStairs;
      [FieldOffset(140)]
      public Nullable_Unboxed<Entity> CastleStairsFusedRoot;

      static NeighbourFloorData()
      {
        Il2CppClassPointerStore<RoomUtility.NeighbourFloorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomUtility>.NativeClassPtr, nameof (NeighbourFloorData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomUtility.NeighbourFloorData>.NativeClassPtr);
        RoomUtility.NeighbourFloorData.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.NeighbourFloorData>.NativeClassPtr, nameof (TilePosition));
        RoomUtility.NeighbourFloorData.NativeFieldInfoPtr_PivotSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.NeighbourFloorData>.NativeClassPtr, nameof (PivotSettings));
        RoomUtility.NeighbourFloorData.NativeFieldInfoPtr_CastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.NeighbourFloorData>.NativeClassPtr, nameof (CastleFloor));
        RoomUtility.NeighbourFloorData.NativeFieldInfoPtr_CastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.NeighbourFloorData>.NativeClassPtr, nameof (CastleStairs));
        RoomUtility.NeighbourFloorData.NativeFieldInfoPtr_CastleStairsFusedRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomUtility.NeighbourFloorData>.NativeClassPtr, nameof (CastleStairsFusedRoot));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomUtility.NeighbourFloorData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
