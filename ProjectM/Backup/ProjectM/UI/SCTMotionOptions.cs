// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SCTMotionOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using System;

#nullable disable
namespace ProjectM.UI
{
  [Flags]
  public enum SCTMotionOptions
  {
    UseXPositionMotion = 1,
    UseYPositionMotion = 2,
    UseZPositionMotion = 4,
    UseScaleMotion = 8,
    UseAlphaMotion = 16, // 0x00000010
    UseForceMotion = 32, // 0x00000020
    UseRandomXZ = 64, // 0x00000040
  }
}
