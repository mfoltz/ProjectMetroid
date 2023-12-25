﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.AssetSwapping.AssetSwapFlags
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using System;

#nullable disable
namespace ProjectM.CastleBuilding.AssetSwapping
{
  [Flags]
  public enum AssetSwapFlags : byte
  {
    None = 0,
    HasGround = 1,
    HasFloor = 2,
    HasCeiling = 4,
    HasStructureBelow = 8,
    HasStructureAbove = 16, // 0x10
    HasLedgeAbove = 32, // 0x20
    HasFloorLedge = 64, // 0x40
  }
}
