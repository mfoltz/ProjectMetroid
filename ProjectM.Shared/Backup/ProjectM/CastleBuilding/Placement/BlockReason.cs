// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.BlockReason
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public enum BlockReason : byte
  {
    None,
    PlacementRestriction,
    PlacementRequirementsNotMet,
    ReplacementTeamRestriction,
    OnlySpawnChildren,
    AttachedRestriction,
    ReplacedInternally,
    DependencyRestricted,
    RestrictMoveWhenAttached,
    InRestrictionArea,
    CastleAreaNotOwnedByUser,
    MultipleCastleAreaIntersections,
    MovingOutsideOfCastleArea,
    CantPlaceInOwnedCastleArea,
    InEnemyRestrictionArea,
    LocationAlreadyModifiedThisFrame,
    CanOnlyUpgrade,
    InMapZone,
    RequiresConnectedCastleHeart,
    RequiresGrounded,
    RequiresGroundConnection,
    RequiresFloorConnection,
    RequiresNoConnectedFloors,
    RequireNoCastleItems,
    CanNotBeMoved,
    MustMoveWithSameCastle,
    RequiresIntactCastleHeartConnection,
    RequiresIntactGroundConnection,
    BlockedByRoad,
    OutOfRange,
    ReachedCastleLimit,
    ReachedCastleTileLimit,
    ReachedCastleHeightLimit,
    ReachedWorldHeightLimit,
    BlockedByInteraction,
    BlockedByCastleSiege,
    PlacementRestrictionWithReplacement,
    PlacementRestrictionLimitToSet,
    RequiresTerritoryLocation,
    RequiresUnclaimedTerritory,
    TeleporterLimitReached,
    RequireGridAlignment10x10,
    UnitOnElevatedFloor,
    CanNotDismantleDueToAttachment,
  }
}
