// Decompiled with JetBrains decompiler
// Type: StunShared.UI.TutorialObjectiveType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace StunShared.UI
{
  [Flags]
  public enum TutorialObjectiveType
  {
    NONE = 0,
    CAMERA = 1,
    MOVE = 2,
    JUMPDOWN = 4,
    JUMPDOWN2 = 8,
    MAP = 16, // 0x00000010
    CRAFTING = 32, // 0x00000020
    BUILDING = 64, // 0x00000040
    SHAPESHIFTS = 128, // 0x00000080
    CAMERA2 = 256, // 0x00000100
    JOURNAL = 512, // 0x00000200
    HEAL = 1024, // 0x00000400
    ABILITY = 2048, // 0x00000800
    RECOVERY = 4096, // 0x00001000
  }
}
