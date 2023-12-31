// Decompiled with JetBrains decompiler
// Type: ProjectM.ConditionSource
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum ConditionSource
  {
    Health = 0,
    HealthFactor = 1,
    Energy = 2,
    EnergyFactor = 3,
    Blood = 4,
    BloodFactor = 5,
    UnitType = 6,
    HasBuff = 7,
    IsAlly = 8,
    IsAlive = 9,
    IsOwner = 10, // 0x0000000A
    BloodConsumeQuality = 11, // 0x0000000B
    DoorCanBeClosed = 12, // 0x0000000C
    HasProgression = 13, // 0x0000000D
    CanBeCharmed = 14, // 0x0000000E
    IsWaypointUnlocked = 15, // 0x0000000F
    IsUserOwner = 16, // 0x00000010
    HasUserOwner = 17, // 0x00000011
    HasRespawnPointOwner = 18, // 0x00000012
    HasItems = 19, // 0x00000013
    IsMounted = 20, // 0x00000014
    HasBuffOwnedByNonOwner = 21, // 0x00000015
    IsPrefab = 22, // 0x00000016
    IsDay = 23, // 0x00000017
    Resistance_Fire = 24, // 0x00000018
    Resistance_Garlic = 25, // 0x00000019
    Resistance_Holy = 26, // 0x0000001A
    Resistance_Silver = 27, // 0x0000001B
    Age = 28, // 0x0000001C
    IsWounded = 29, // 0x0000001D
    TimeSinceAbilityCasted = 30, // 0x0000001E
    LastAbilityCasted = 31, // 0x0000001F
    MinionCount = 32, // 0x00000020
    IsCasting = 33, // 0x00000021
    IsSelf = 34, // 0x00000022
    DayTimeSpanActive = 35, // 0x00000023
    HasEquippedWeaponOfType = 36, // 0x00000024
    DistanceBetweenTargetAndSelf = 37, // 0x00000025
    IsShapeShifted = 39, // 0x00000027
    MaterialCategory = 40, // 0x00000028
    IsEnemy = 41, // 0x00000029
    IsInAggroList = 42, // 0x0000002A
    AbilityCastCount_Total = 43, // 0x0000002B
    IsFeedWounded = 44, // 0x0000002C
    DamageTakenSince = 45, // 0x0000002D
    TimeInCurrentState = 46, // 0x0000002E
    BlockFeed = 47, // 0x0000002F
    IsPlayerCharacter = 50, // 0x00000032
    IsAiResourceNode = 51, // 0x00000033
    MainCategory = 53, // 0x00000035
    AbilityCastCount_InARow = 54, // 0x00000036
    HasPermission = 55, // 0x00000037
    AggroListCount = 56, // 0x00000038
    HasAnyEquippedItem = 57, // 0x00000039
    InventoryItemCount = 58, // 0x0000003A
    HasTeleportBoundItem = 59, // 0x0000003B
    HasBuffWithAge = 60, // 0x0000003C
    WeaponLevel = 61, // 0x0000003D
    HasBuffOwnedByOwner = 62, // 0x0000003E
    FollowersCount = 63, // 0x0000003F
    IsFlying = 64, // 0x00000040
    IsFed = 65, // 0x00000041
    IsInUnitTeam = 66, // 0x00000042
    IsConfuseDummy = 67, // 0x00000043
    IsServant = 68, // 0x00000044
    CanLand = 69, // 0x00000045
    CanRepair = 70, // 0x00000046
    OwnerBoundToTarget = 71, // 0x00000047
    PvEEnabled = 72, // 0x00000048
    PvPEnabled = 73, // 0x00000049
    CanLootEnemyContainersEnabled = 74, // 0x0000004A
    CanInteractWithEnemyCastleHeart = 75, // 0x0000004B
    HasMaxMinions = 76, // 0x0000004C
    RandomValueBetween0And1 = 77, // 0x0000004D
    IsVBlood = 78, // 0x0000004E
    HasBuffResistances = 79, // 0x0000004F
    UnitHealthType = 80, // 0x00000050
    BuffModificationActive = 81, // 0x00000051
    IsAiPointOfInterestOfType = 82, // 0x00000052
    BuffStacks = 83, // 0x00000053
    HasSpellMod = 84, // 0x00000054
    AgeBiggerThanLifetime = 85, // 0x00000055
    IsTeleporterGroupLinked = 86, // 0x00000056
    IsCastleBreached = 87, // 0x00000057
    IsCastleAttacked = 88, // 0x00000058
    IsInNeutralTeam = 89, // 0x00000059
    IsOverloaded = 90, // 0x0000005A
    IsInsideOwnerCombatArea = 91, // 0x0000005B
    IsCastleRaided = 92, // 0x0000005C
  }
}
