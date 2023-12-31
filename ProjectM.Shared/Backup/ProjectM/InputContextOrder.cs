// Decompiled with JetBrains decompiler
// Type: ProjectM.InputContextOrder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum InputContextOrder
  {
    Default = 0,
    ChatInput = 99, // 0x00000063
    HUDLinks = 100, // 0x00000064
    PushToTalk = 400, // 0x00000190
    HUDElement = 495, // 0x000001EF
    DebugMenu = 500, // 0x000001F4
    HUDSubMenu = 501, // 0x000001F5
    HUDMenu = 502, // 0x000001F6
    MenuInput = 600, // 0x00000258
    ActionBar = 900, // 0x00000384
    Gameplay = 1000, // 0x000003E8
  }
}
