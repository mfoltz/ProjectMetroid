// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum ServantType
  {
    None = 0,
    Blacksmith = 1,
    Lumberjack = 2,
    Tailor = 4,
    Officer = 8,
    Guard = 16, // 0x00000010
  }
}
