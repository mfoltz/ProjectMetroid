// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffCategoryFlag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum BuffCategoryFlag : long
  {
    None = 0,
    Stun = 1,
    Knockback = 2,
    Interact = 4,
    Travel = 8,
    Slow = 16, // 0x0000000000000010
    Weaken = 32, // 0x0000000000000020
    Amplify = 64, // 0x0000000000000040
    Silence = 128, // 0x0000000000000080
    Fear = 256, // 0x0000000000000100
    BloodHeal = 512, // 0x0000000000000200
    BloodRage = 1024, // 0x0000000000000400
    Damage = 2048, // 0x0000000000000800
    Shapeshift = 4096, // 0x0000000000001000
    RemovableBuff = 8192, // 0x0000000000002000
    VeilDash = 16384, // 0x0000000000004000
    SunResistance = 32768, // 0x0000000000008000
    GarlicResistance = 65536, // 0x0000000000010000
    HolyResistance = 131072, // 0x0000000000020000
    FireResistance = 262144, // 0x0000000000040000
    SilverResistance = 524288, // 0x0000000000080000
    Ignite = 1048576, // 0x0000000000100000
    RemoveOnDisconnect = 2097152, // 0x0000000000200000
    SpellPower = 4194304, // 0x0000000000400000
    PhysicalPower = 8388608, // 0x0000000000800000
    Mount = 16777216, // 0x0000000001000000
    RelicCarry = 33554432, // 0x0000000002000000
    RelicPower = 67108864, // 0x0000000004000000
    PhysicalConsumables = 134217728, // 0x0000000008000000
    SpellConsumables = 268435456, // 0x0000000010000000
    AirThrow = 536870912, // 0x0000000020000000
    ShockwaveRecast = 1073741824, // 0x0000000040000000
    Chill = 2147483648, // 0x0000000080000000
    Corruption = 4294967296, // 0x0000000100000000
    SpellSchool = 8589934592, // 0x0000000200000000
    Grab = 17179869184, // 0x0000000400000000
  }
}
