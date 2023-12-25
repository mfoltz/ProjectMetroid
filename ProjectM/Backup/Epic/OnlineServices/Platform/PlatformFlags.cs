// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.PlatformFlags
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using System;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [Flags]
  public enum PlatformFlags : ulong
  {
    None = 0,
    LoadingInEditor = 1,
    DisableOverlay = 2,
    DisableSocialOverlay = 4,
    Reserved1 = 8,
    WindowsEnableOverlayD3D9 = 16, // 0x0000000000000010
    WindowsEnableOverlayD3D10 = 32, // 0x0000000000000020
    WindowsEnableOverlayOpengl = 64, // 0x0000000000000040
  }
}
