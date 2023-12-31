// Decompiled with JetBrains decompiler
// Type: ProjectM.TileType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum TileType : byte
  {
    None = 0,
    Collision = 1,
    Placement = 2,
    SurfaceFluff = 4,
    Pathfinding = 8,
    LineOfSight = 16, // 0x10
    Height = 32, // 0x20
    RestrictionArea = 64, // 0x40
    All = 255, // 0xFF
  }
}
