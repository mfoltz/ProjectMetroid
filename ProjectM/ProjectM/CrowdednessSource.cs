// Decompiled with JetBrains decompiler
// Type: ProjectM.CrowdednessSource
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum CrowdednessSource : byte
  {
    None = 0,
    Vicinity = 1,
    Buff = 2,
  }
}
