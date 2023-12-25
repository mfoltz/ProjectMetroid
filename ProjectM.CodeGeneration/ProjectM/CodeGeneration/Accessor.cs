// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.Accessor
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using System;

#nullable disable
namespace ProjectM.CodeGeneration
{
  [Flags]
  public enum Accessor
  {
    None = 0,
    Public = 1,
    Private = 2,
    Internal = 4,
    Partial = 8,
    Protected = 16, // 0x00000010
    Static = 32, // 0x00000020
  }
}
