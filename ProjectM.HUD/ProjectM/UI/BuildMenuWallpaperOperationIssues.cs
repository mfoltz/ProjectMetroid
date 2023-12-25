// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenuWallpaperOperationIssues
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using System;

#nullable disable
namespace ProjectM.UI
{
  [Flags]
  public enum BuildMenuWallpaperOperationIssues
  {
    None = 0,
    MissingResources = 1,
    SameBlueprint = 2,
    MissingOwnership = 4,
  }
}
