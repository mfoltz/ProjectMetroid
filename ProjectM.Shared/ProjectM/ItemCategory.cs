// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemCategory
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum ItemCategory : long
  {
    Weapon = 1,
    Armor = 2,
    Gem = 4,
    BloodBound = 8,
    Flower = 16, // 0x0000000000000010
    Lumber = 32, // 0x0000000000000020
    Stone = 64, // 0x0000000000000040
    BloodEssence = 128, // 0x0000000000000080
    SoulBound = 256, // 0x0000000000000100
    TeleportBound = 512, // 0x0000000000000200
    Silver = 1024, // 0x0000000000000400
    LoseDurabilityOnDeath = 2048, // 0x0000000000000800
    Knowledge = 4096, // 0x0000000000001000
    Blood = 8192, // 0x0000000000002000
    Relic = 16384, // 0x0000000000004000
    Coin = 32768, // 0x0000000000008000
    Consumable = 65536, // 0x0000000000010000
    Herb = 131072, // 0x0000000000020000
    Bag = 262144, // 0x0000000000040000
    Saddle = 524288, // 0x0000000000080000
    FishCommon = 1048576, // 0x0000000000100000
    FishUncommon = 2097152, // 0x0000000000200000
    FishRare = 4194304, // 0x0000000000400000
    ALL = -1, // 0xFFFFFFFFFFFFFFFF
    NONE = 0,
  }
}
