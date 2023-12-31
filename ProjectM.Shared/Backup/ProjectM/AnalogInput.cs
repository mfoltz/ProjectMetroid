// Decompiled with JetBrains decompiler
// Type: ProjectM.AnalogInput
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum AnalogInput
  {
    None = 0,
    All = 2147483647, // 0x7FFFFFFF
    MoveX = 1,
    MoveY = 2,
    AimX = 4,
    AimY = 8,
    ZoomCamera = 16, // 0x00000010
    RotateCameraX = 32, // 0x00000020
    RotateCameraY = 64, // 0x00000040
    MoveCameraX = 128, // 0x00000080
    MoveCameraY = 256, // 0x00000100
  }
}
