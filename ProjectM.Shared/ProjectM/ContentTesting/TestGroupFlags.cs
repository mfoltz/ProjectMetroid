// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.TestGroupFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM.ContentTesting
{
  [Flags]
  public enum TestGroupFlags
  {
    None = 0,
    General = 1,
    Art = 2,
    Design = 4,
    Animators = 8,
    Sequences = 16, // 0x00000010
    Physics = 32, // 0x00000020
    LevelDesign = 64, // 0x00000040
    UI = 128, // 0x00000080
    Networked = 256, // 0x00000100
    AI = 512, // 0x00000200
    AssetPatching = 1024, // 0x00000400
    SubScenes = 2048, // 0x00000800
    Animations = 4096, // 0x00001000
    MapIcons = 8192, // 0x00002000
    Sound = 16384, // 0x00004000
    All = -1, // 0xFFFFFFFF
  }
}
