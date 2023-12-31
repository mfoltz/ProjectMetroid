// Decompiled with JetBrains decompiler
// Type: ProjectM.StatChangeFlag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum StatChangeFlag
  {
    None = 0,
    IsCritical = 1,
    ShowSct = 2,
    IgnoreWeakens = 4,
    IgnoreInvulnerable = 8,
    IsDoT = 16, // 0x00000010
    IgnoreCC = 32, // 0x00000020
    DisableYield = 64, // 0x00000040
    PrimaryAttack = 128, // 0x00000080
    TrueHealing = 256, // 0x00000100
    IgnoreAmplify = 512, // 0x00000200
    IsLeech = 1024, // 0x00000400
    TooLowResourceLevel = 8192, // 0x00002000
    MassiveResourceDamage = 32768, // 0x00008000
    AnnounceCastleAttack = 65536, // 0x00010000
  }
}
