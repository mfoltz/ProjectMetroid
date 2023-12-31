// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffModificationTypes
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum BuffModificationTypes : long
  {
    None = 0,
    All = -1, // 0xFFFFFFFFFFFFFFFF
    ImmuneToHazards = 1,
    ImmuneToSun = 2,
    Invulnerable = 4,
    Immaterial = 8,
    MovementImpair = 16, // 0x0000000000000010
    BuildMenuImpair = 32, // 0x0000000000000020
    IsFlying = 64, // 0x0000000000000040
    ConsumableImpair = 128, // 0x0000000000000080
    DisableDynamicCollision = 512, // 0x0000000000000200
    DisableMapCollision = 2048, // 0x0000000000000800
    MountImpaired = 4096, // 0x0000000000001000
    FishingImpaired = 8192, // 0x0000000000002000
    SleepInCoffinImpaired = 16384, // 0x0000000000004000
    ContainerInteractionImpaired = 32768, // 0x0000000000008000
    HayStackImpaired = 65536, // 0x0000000000010000
    ThroneImpaired = 131072, // 0x0000000000020000
    RelicImpaired = 262144, // 0x0000000000040000
    FeedImpaired = 524288, // 0x0000000000080000
    PrisonImpaired = 1048576, // 0x0000000000100000
    ReviveImpaired = 2097152, // 0x0000000000200000
    DragPlayerImpaired = 4194304, // 0x0000000000400000
    TargetSpellImpaired = 8388608, // 0x0000000000800000
    AlwaysInSun = 16777216, // 0x0000000001000000
    AbilityCastImpair = 33554432, // 0x0000000002000000
    FlyOnlyMapCollision = 67108864, // 0x0000000004000000
    DisableHeightCorrection = 134217728, // 0x0000000008000000
    KeepMountOnAbilityImpair = 268435456, // 0x0000000010000000
    DisableUnitVisibility = 536870912, // 0x0000000020000000
    RotationImpair = 1073741824, // 0x0000000040000000
    TradeImpair = 2147483648, // 0x0000000080000000
    WaypointImpair = 4294967296, // 0x0000000100000000
    SiegeStructureImpair = 8589934592, // 0x0000000200000000
    CastOptionImpair = 17179869184, // 0x0000000400000000
    RelocateImpair = 34359738368, // 0x0000000800000000
    VeilActive = 68719476736, // 0x0000001000000000
    LegDirectionImpair = 137438953472, // 0x0000002000000000
    BehaviourImpair = 274877906944, // 0x0000004000000000
    IsVbloodGhost = 549755813888, // 0x0000008000000000
    IsWounded = 1099511627776, // 0x0000010000000000
    CannotBeDisconnectDragged = 2199023255552, // 0x0000020000000000
    LocalTeleporterImpaired = 4398046511104, // 0x0000040000000000
    PickupItemImpaired = 8796093022208, // 0x0000080000000000
    PickupRaidItemImpaired = 17592186044416, // 0x0000100000000000
  }
}
