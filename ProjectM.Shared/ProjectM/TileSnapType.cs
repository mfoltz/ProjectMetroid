// Decompiled with JetBrains decompiler
// Type: ProjectM.TileSnapType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum TileSnapType : byte
  {
    Standard,
    Floor10x10,
    Floor10x10Offset,
    Edge10x10,
    Edge10x10Inverted,
    Corner10x10,
    Floor5x5,
    Floor5x5Offset,
    Edge5x5,
    Edge5x5Inverted,
    Corner5x5,
    Free,
  }
}
