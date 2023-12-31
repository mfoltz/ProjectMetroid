// Decompiled with JetBrains decompiler
// Type: ProjectM.SyncedInputFlag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum SyncedInputFlag
  {
    None = 0,
    Interact = 1,
    Primary = 2,
    WeaponSkill1 = 4,
    TravelSkill = 8,
    CliffJump = 16, // 0x00000010
    WeaponSkill2 = 32, // 0x00000020
    OffensiveSpell = 64, // 0x00000040
    DefensiveSpell = 128, // 0x00000080
    UltimateSpell = 256, // 0x00000100
    Ability4 = 512, // 0x00000200
    Respawn = 65536, // 0x00010000
    AutoMove = 131072, // 0x00020000
    Interrupt = 262144, // 0x00040000
  }
}
