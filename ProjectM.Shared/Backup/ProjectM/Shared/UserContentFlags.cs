// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.UserContentFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Shared
{
  [Flags]
  public enum UserContentFlags
  {
    None = 0,
    EarlyAccess = 1,
    NonExistent = 2,
    DLC_DraculasRelics_EA = 4,
    DLC_FoundersPack_EA = 8,
    GiveAway_Razer01 = 16, // 0x00000010
    Halloween2022 = 32, // 0x00000020
    DLC_Gloomrot = 64, // 0x00000040
  }
}
