// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.MapCollisionFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Tiles
{
  [Flags]
  public enum MapCollisionFlags : byte
  {
    None = 0,
    CollideNormalMovement = 1,
    CollideAirMovement = 2,
    CollideStandardSpells = 4,
    CollideTargetAoE = 8,
    CollideJumpFromCliff = 16, // 0x10
    CollideNormalMovementMounted = 32, // 0x20
    CollideFlyMovement = 64, // 0x40
  }
}
