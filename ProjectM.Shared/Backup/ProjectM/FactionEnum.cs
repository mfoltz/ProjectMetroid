// Decompiled with JetBrains decompiler
// Type: ProjectM.FactionEnum
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum FactionEnum
  {
    None = 0,
    Players = 1,
    Wolves = 2,
    Undead = 4,
    Militia = 8,
    ChurchOfLum = 16, // 0x00000010
    Prisoners = 32, // 0x00000020
    Bandits = 64, // 0x00000040
    Bear = 128, // 0x00000080
    Plants = 256, // 0x00000100
    Harpy = 512, // 0x00000200
    Critters = 1024, // 0x00000400
    Werewolves = 2048, // 0x00000800
    NatureSpirit = 4096, // 0x00001000
    Spiders = 8192, // 0x00002000
    VampireHunters = 16384, // 0x00004000
    Cursed = 32768, // 0x00008000
    Gloomrot = 65536, // 0x00010000
    Ignored = 131072, // 0x00020000
    Elementals = 262144, // 0x00040000
    Players_ShapeshiftHuman = 524288, // 0x00080000
    Spot_ShapeshiftHuman = 1048576, // 0x00100000
    PlayerCastlePrisoner = 2097152, // 0x00200000
    ChurchOfLum_Slaves = 4194304, // 0x00400000
    ChurchOfLum_Slaves_Rioters = 8388608, // 0x00800000
    WerewolvesHuman = 16777216, // 0x01000000
    Mutants = 33554432, // 0x02000000
    PlayerMutant = 67108864, // 0x04000000
  }
}
