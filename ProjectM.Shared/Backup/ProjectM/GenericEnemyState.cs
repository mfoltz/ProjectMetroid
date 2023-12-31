// Decompiled with JetBrains decompiler
// Type: ProjectM.GenericEnemyState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum GenericEnemyState
  {
    Initialize = 0,
    Idle = 2,
    Alert = 4,
    Combat = 8,
    Return = 64, // 0x00000040
    Flee = 128, // 0x00000080
    Follow = 256, // 0x00000100
    Imprisoned = 2048, // 0x00000800
    Servant_FindWorkstation = 4096, // 0x00001000
    Servant_WalkToWorkstation = 8192, // 0x00002000
    Servant_TeleportToWorkstation = 16384, // 0x00004000
    Villager_Cover = 32768, // 0x00008000
    Combat_Relocate = 262144, // 0x00040000
    Idle_Horse = 524288, // 0x00080000
  }
}
