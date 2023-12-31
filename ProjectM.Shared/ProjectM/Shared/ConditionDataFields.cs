// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionDataFields
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Shared
{
  [Flags]
  public enum ConditionDataFields
  {
    None = 0,
    Target = 1,
    Invert = 2,
    IncludeInterrupted = 4,
    Compare = 8,
    Float = 16, // 0x00000010
    Int = 32, // 0x00000020
    Prefab = 64, // 0x00000040
    EntityCategory = 128, // 0x00000080
    WeaponType = 256, // 0x00000100
    UnitHealthType = 512, // 0x00000200
    BuffCategory = 1024, // 0x00000400
    BuffModification = 2048, // 0x00000800
    AiPointOfInterestType = 4096, // 0x00001000
    SpellMod = 8192, // 0x00002000
    Ability = 65536, // 0x00010000
    DayTimeSpan = 131072, // 0x00020000
  }
}
