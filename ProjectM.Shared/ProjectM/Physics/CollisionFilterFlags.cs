// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.CollisionFilterFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Physics
{
  [Flags]
  public enum CollisionFilterFlags : uint
  {
    None = 0,
    All = 4294967295, // 0xFFFFFFFF
    Terrain = 1,
    Pickables = 2,
    Ragdolls = 4,
    Hittable = 8,
    SunBlocker = 16, // 0x00000010
    IgnorePicking = 32, // 0x00000020
    GameplayHeight = 64, // 0x00000040
    BuildingFoundation = 128, // 0x00000080
    ShatterObject = 256, // 0x00000100
    GameplaySlope = 512, // 0x00000200
    Interactable = 1024, // 0x00000400
    DirectionalShield = 2048, // 0x00000800
    ObstacleFade = 4096, // 0x00001000
    Player = 8192, // 0x00002000
    UnitPicking = 16384, // 0x00004000
    BlockSpellCollision = 32768, // 0x00008000
    VisionCheck = 65536, // 0x00010000
    CastleSummon = 131072, // 0x00020000
    RagdollBones = 262144, // 0x00040000
    BlockInteract = 524288, // 0x00080000
    BuildingSnapPicking = 1048576, // 0x00100000
    Unit = 2097152, // 0x00200000
    AbyssPlane = 4194304, // 0x00400000
    BlockTakeoff = 8388608, // 0x00800000
    FlyHeight = 16777216, // 0x01000000
    ObjectHeight = 33554432, // 0x02000000
  }
}
