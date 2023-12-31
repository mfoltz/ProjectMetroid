// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofCategoryOrnamentCustomization
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.Roofs
{
  [Flags]
  public enum RoofCategoryOrnamentCustomization : byte
  {
    None = 0,
    CountAsOpen_West = 1,
    CountAsOpen_East = 2,
    CountAsOpen_North = 4,
    CountAsOpen_South = 8,
  }
}
