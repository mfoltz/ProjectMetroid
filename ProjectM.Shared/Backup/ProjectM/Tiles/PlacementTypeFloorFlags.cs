// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementTypeFloorFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Tiles
{
  [Flags]
  public enum PlacementTypeFloorFlags : long
  {
    None = 0,
    LumberMill = 1,
    BlackSmith = 2,
    Hallway = 4,
    StoneCuttery = 8,
    RatNest = 16, // 0x0000000000000010
    CastleCrypt = 32, // 0x0000000000000020
    Library = 64, // 0x0000000000000040
    Tailor = 128, // 0x0000000000000080
    Prison = 256, // 0x0000000000000100
    Bestiary = 512, // 0x0000000000000200
    Alchemy = 1024, // 0x0000000000000400
    ThroneHall = 2048, // 0x0000000000000800
    Inscription = 4096, // 0x0000000000001000
    Ruins = 8192, // 0x0000000000002000
    House = 16384, // 0x0000000000004000
    Temple = 32768, // 0x0000000000008000
    Treasury = 65536, // 0x0000000000010000
    Pavement = 131072, // 0x0000000000020000
    RaisedCrypt = 262144, // 0x0000000000040000
    Entryway = 524288, // 0x0000000000080000
    EntrywayRuins = 1048576, // 0x0000000000100000
    EntrywayStairs = 2097152, // 0x0000000000200000
    EntrywayStairsRuins = 4194304, // 0x0000000000400000
    EntrywayEdge = 8388608, // 0x0000000000800000
    Outdoor_Border = 16777216, // 0x0000000001000000
    Outdoor_Cobblestone01 = 33554432, // 0x0000000002000000
    FloorSquare = 67108864, // 0x0000000004000000
    FloorTriangle = 134217728, // 0x0000000008000000
    FloorDecoration = 268435456, // 0x0000000010000000
    FloorBlockBuilding = 536870912, // 0x0000000020000000
    FloorRoom = 1073741824, // 0x0000000040000000
    FloorEnd = 2147483648, // 0x0000000080000000
    FloorOutdoor = 4294967296, // 0x0000000100000000
    Outdoor_Cobblestone02 = 8589934592, // 0x0000000200000000
    Outdoor_Grass = 17179869184, // 0x0000000400000000
    FloorEdge = 34359738368, // 0x0000000800000000
    FloorCorner = 68719476736, // 0x0000001000000000
  }
}
