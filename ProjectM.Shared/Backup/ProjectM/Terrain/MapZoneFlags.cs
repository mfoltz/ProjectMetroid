// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Terrain
{
  [Flags]
  public enum MapZoneFlags : byte
  {
    None = 0,
    Named = 1,
    VisibleOnMap = 2,
    RevealableOnMap = 4,
    BlockAllBuilding = 8,
    ServantSupport = 16, // 0x10
    CastleTerritory = 32, // 0x20
  }
}
