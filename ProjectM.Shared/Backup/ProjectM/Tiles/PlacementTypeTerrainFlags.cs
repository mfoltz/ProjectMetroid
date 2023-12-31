// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementTypeTerrainFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Tiles
{
  [Flags]
  public enum PlacementTypeTerrainFlags : byte
  {
    None = 0,
    Ground = 1,
    Water = 2,
    Abyss = 4,
    Cliff = 8,
    Ramp = 16, // 0x10
    RampPatternMatching = 32, // 0x20
  }
}
