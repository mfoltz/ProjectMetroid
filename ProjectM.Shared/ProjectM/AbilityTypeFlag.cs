// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityTypeFlag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum AbilityTypeFlag : uint
  {
    All = 4294967295, // 0xFFFFFFFF
    None = 0,
    AbilityKit = 1,
    Interact = 2,
    Interact_BreakMount = 4,
    Dismantle = 8,
    AbilityKit_IgnoreInCombat = 16, // 0x00000010
    AbilityKit_BreakStealth = 32, // 0x00000020
    IgnoreSpellBlock = 64, // 0x00000040
    Demount = 128, // 0x00000080
    Primary = 256, // 0x00000100
    Repair = 512, // 0x00000200
    Travel = 1024, // 0x00000400
  }
}
