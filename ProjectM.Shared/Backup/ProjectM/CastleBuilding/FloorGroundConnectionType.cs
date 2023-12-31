// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.FloorGroundConnectionType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [Flags]
  public enum FloorGroundConnectionType : byte
  {
    FullyGrounded = 0,
    WestFlying = 1,
    EastFlying = 2,
    NorthFlying = 4,
    SouthFlying = 8,
    FullyFlying = SouthFlying | NorthFlying | EastFlying | WestFlying, // 0x0F
  }
}
