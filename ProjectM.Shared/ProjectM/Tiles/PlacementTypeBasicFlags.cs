// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementTypeBasicFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Tiles
{
  [Flags]
  public enum PlacementTypeBasicFlags : long
  {
    None = 0,
    Floor = 2,
    Wall = 4,
    Object = 8,
    Entrance = 16, // 0x0000000000000010
    Ceiling = 32, // 0x0000000000000020
    Door = 64, // 0x0000000000000040
    WallDecoration = 128, // 0x0000000000000080
    WallPillar = 256, // 0x0000000000000100
    WallRubble = 512, // 0x0000000000000200
    ResourceProp = 1024, // 0x0000000000000400
    PillarAttach = 2048, // 0x0000000000000800
    PillarAttachImmaterial = 4096, // 0x0000000000001000
    WallPillarBig = 8192, // 0x0000000000002000
    FloorDecoration = 16384, // 0x0000000000004000
    ObjectGrounded = 32768, // 0x0000000000008000
    WorldBreakableNoCollision = 65536, // 0x0000000000010000
    WorldStatic = 131072, // 0x0000000000020000
    LightSource = 262144, // 0x0000000000040000
    PortalWorld = 524288, // 0x0000000000080000
    Framework = 1048576, // 0x0000000000100000
    PortalCastle = 2097152, // 0x0000000000200000
    Pipe = 4194304, // 0x0000000000400000
    PipeStart = 8388608, // 0x0000000000800000
    PipeEnd = 16777216, // 0x0000000001000000
    OuterWall = 33554432, // 0x0000000002000000
    EnemyConstruction = 67108864, // 0x0000000004000000
    DoorHouse = 134217728, // 0x0000000008000000
    WindowFrame = 268435456, // 0x0000000010000000
    Window = 536870912, // 0x0000000020000000
    Blight = 1073741824, // 0x0000000040000000
    BlightEdge = 2147483648, // 0x0000000080000000
    Pylon = 4294967296, // 0x0000000100000000
    WorldBreakableCollision = 8589934592, // 0x0000000200000000
    FlyingObject = 17179869184, // 0x0000000400000000
    Module = 34359738368, // 0x0000000800000000
    StairsPartLower = 68719476736, // 0x0000001000000000
    StairsPartUpper = 137438953472, // 0x0000002000000000
    Railing = 274877906944, // 0x0000004000000000
  }
}
