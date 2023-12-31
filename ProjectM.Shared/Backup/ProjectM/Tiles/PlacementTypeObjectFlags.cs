// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementTypeObjectFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Tiles
{
  [Flags]
  public enum PlacementTypeObjectFlags : long
  {
    None = 0,
    Grounded = 1,
    Castle = 2,
    House = 4,
    Terrain = 8,
    Pavement = 16, // 0x0000000000000010
    BlockPhysicalFloor = 32, // 0x0000000000000020
    BlockIndoorFloor = 64, // 0x0000000000000040
    BlockOutdoorFloor = 128, // 0x0000000000000080
    SeedPlanter = 256, // 0x0000000000000100
    Seed = 512, // 0x0000000000000200
    ModuleParent = 1024, // 0x0000000000000400
    ModuleChild = 2048, // 0x0000000000000800
    BlockStairsPartLower = 4096, // 0x0000000000001000
    BlockStairsPartUpper = 8192, // 0x0000000000002000
    Sapling = 16384, // 0x0000000000004000
    SaplingPlanter = 32768, // 0x0000000000008000
  }
}
