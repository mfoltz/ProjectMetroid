// Decompiled with JetBrains decompiler
// Type: ProjectM.Pathfinding.PathfindingTile
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Pathfinding
{
  [Flags]
  public enum PathfindingTile : byte
  {
    None = 0,
    Road = 1,
    Grass = 2,
    Door = 4,
    Impassable = 8,
    Fire = 16, // 0x10
    PortalUp = 32, // 0x20
    PortalDown = 64, // 0x40
  }
}
