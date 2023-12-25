// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDElementType
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using System;

#nullable disable
namespace ProjectM.UI
{
  [Flags]
  public enum HUDElementType
  {
    None = 0,
    BottomBar = 1,
    Clock = 2,
    Minimap = 4,
    Links = 8,
    Achievements = 16, // 0x00000010
    BloodOrb = 32, // 0x00000020
    Clan = 64, // 0x00000040
    Progression = 128, // 0x00000080
    CharacterCraftingProgress = 256, // 0x00000100
    Replay = 512, // 0x00000200
    Chat = 1024, // 0x00000400
    Interact = 2048, // 0x00000800
    CharacterHUDs = 4096, // 0x00001000
    ItemTracking = 8192, // 0x00002000
  }
}
