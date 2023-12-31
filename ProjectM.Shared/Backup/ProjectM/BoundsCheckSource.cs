// Decompiled with JetBrains decompiler
// Type: ProjectM.BoundsCheckSource
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum BoundsCheckSource
  {
    Unspecified,
    Placement_CheckCastleAreas,
    TileCollisionHistorySystem_Base,
    WriteOtherSizes_TileUpdateJob,
    Pathfinding_IncrementFromNeighbour,
    UpdateDirtyBoundsBasedOnHalfSize,
    UpdateTileCollision,
    UpdatePathfindingTilesJob,
    UpdateLineOfSight,
    DrawTileGridSystem,
    MapData_CollisionCheck,
    CheckForDirtyTileBounds_AddCustomDirtyWorldBounds,
    CheckForDirtyTileBounds_AddNewTileBoundsJob,
    CheckForDirtyTileBounds_AddRemovedTileBoundsJob,
    UpdateTileHeights,
    GetChunkTilesWithinWorldBounds,
    GetHeightTilesWithinWorldBounds,
    CheckMovingCircle,
    CheckStaticCircle,
    JumpFromCliff_IsValidLandingPosition,
    SnapshotMapData_CollisionCheck_1,
    SnapshotMapData_CollisionCheck_2,
    Placement_GetStaticTileDataWithinBounds,
  }
}
