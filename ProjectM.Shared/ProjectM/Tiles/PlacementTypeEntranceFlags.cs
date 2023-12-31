// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementTypeEntranceFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Tiles
{
  [Flags]
  public enum PlacementTypeEntranceFlags : byte
  {
    None = 0,
    Rubble = 1,
    Wood = 2,
    Stone = 4,
    Iron = 8,
    Obsidian = 16, // 0x10
    OuterWall = 32, // 0x20
  }
}
