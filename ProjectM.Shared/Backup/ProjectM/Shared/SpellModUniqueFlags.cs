// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModUniqueFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Shared
{
  [Flags]
  public enum SpellModUniqueFlags : byte
  {
    None = 0,
    Flag1 = 1,
    Flag2 = 2,
    Flag3 = 4,
    Flag4 = 8,
    Flag5 = 16, // 0x10
    Flag6 = 32, // 0x20
    Flag7 = 64, // 0x40
    Flag8 = 128, // 0x80
  }
}
