﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnRandomLifeTime
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnRandomLifeTime
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDuration;
    [FieldOffset(0)]
    public float MinDuration;
    [FieldOffset(4)]
    public float MaxDuration;

    static SpawnRandomLifeTime()
    {
      Il2CppClassPointerStore<SpawnRandomLifeTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnRandomLifeTime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRandomLifeTime>.NativeClassPtr);
      SpawnRandomLifeTime.NativeFieldInfoPtr_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRandomLifeTime>.NativeClassPtr, nameof (MinDuration));
      SpawnRandomLifeTime.NativeFieldInfoPtr_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRandomLifeTime>.NativeClassPtr, nameof (MaxDuration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRandomLifeTime>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}