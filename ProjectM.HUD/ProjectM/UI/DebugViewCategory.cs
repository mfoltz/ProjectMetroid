// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugViewCategory
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using System;

#nullable disable
namespace ProjectM.UI
{
  [Flags]
  public enum DebugViewCategory
  {
    None = 0,
    Fps = 1,
    Entities = 2,
    Network = 4,
    Archetypes = 8,
    Positions = 16, // 0x00000010
    Chunks = 32, // 0x00000020
    Replay = 64, // 0x00000040
    Ai = 128, // 0x00000080
    AssetStreaming = 256, // 0x00000100
    All = -1, // 0xFFFFFFFF
  }
}
