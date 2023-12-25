// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DMask
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using System;

#nullable disable
namespace StunShared.UI
{
  [Flags]
  public enum Motion2DMask
  {
    PosX = 1,
    PosY = 2,
    Rotation = 4,
    Color = 8,
    ScaleX = 16, // 0x00000010
    ScaleY = 32, // 0x00000020
    Alpha = 64, // 0x00000040
    FillAmount = 128, // 0x00000080
    LayoutElementWidth = 256, // 0x00000100
    LayoutElementHeight = 512, // 0x00000200
    None = 0,
    All = LayoutElementHeight | LayoutElementWidth | FillAmount | Alpha | ScaleY | ScaleX | Color | Rotation | PosY | PosX, // 0x000003FF
  }
}
