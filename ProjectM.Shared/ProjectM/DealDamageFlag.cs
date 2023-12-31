// Decompiled with JetBrains decompiler
// Type: ProjectM.DealDamageFlag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum DealDamageFlag
  {
    None = 0,
    ShowSct = 2,
    IsDoT = 16, // 0x00000010
    IgnoreCC = 32, // 0x00000020
    PrimaryAttack = 128, // 0x00000080
    LoseDurability = 2048, // 0x00000800
    TooLowResourceLevel = 8192, // 0x00002000
    IgnoreEmpowerStatChanges = 16384, // 0x00004000
    MassiveResourceDamage = 32768, // 0x00008000
    AnnounceCastleAttack = 65536, // 0x00010000
  }
}
