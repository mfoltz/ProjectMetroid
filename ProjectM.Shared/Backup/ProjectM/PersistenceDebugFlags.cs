﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.PersistenceDebugFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum PersistenceDebugFlags : byte
  {
    None = 0,
    StoreExtraDebugData = 1,
    TestOnSave = 2,
  }
}
