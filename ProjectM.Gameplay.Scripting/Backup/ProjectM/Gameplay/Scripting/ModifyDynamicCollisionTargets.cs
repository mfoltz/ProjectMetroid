// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.ModifyDynamicCollisionTargets
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using System;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [Flags]
  public enum ModifyDynamicCollisionTargets
  {
    None = 0,
    Players = 1,
    Units = 2,
  }
}
