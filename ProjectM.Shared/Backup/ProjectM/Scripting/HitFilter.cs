// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.HitFilter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Scripting
{
  [Flags]
  public enum HitFilter : byte
  {
    Ally = 1,
    Enemy = 2,
    Alive = 4,
    Dead = 8,
    IncludeContextEntity = 16, // 0x10
    IncludeImmaterial = 32, // 0x20
  }
}
