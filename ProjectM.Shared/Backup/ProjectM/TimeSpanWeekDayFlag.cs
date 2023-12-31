// Decompiled with JetBrains decompiler
// Type: ProjectM.TimeSpanWeekDayFlag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum TimeSpanWeekDayFlag
  {
    All = 127, // 0x0000007F
    Monday = 1,
    Tuesday = 2,
    Wednesday = 4,
    Thursday = 8,
    Friday = 16, // 0x00000010
    Saturday = 32, // 0x00000020
    Sunday = 64, // 0x00000040
  }
}
