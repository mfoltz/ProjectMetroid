﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.ProgressAchievementEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProgressAchievementEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Achievement;
    private static readonly System.IntPtr NativeFieldInfoPtr_User;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompleteAmount;
    [FieldOffset(0)]
    public PrefabGUID Achievement;
    [FieldOffset(4)]
    public Entity User;
    [FieldOffset(12)]
    public int CompleteAmount;

    static ProgressAchievementEvent()
    {
      Il2CppClassPointerStore<ProgressAchievementEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProgressAchievementEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressAchievementEvent>.NativeClassPtr);
      ProgressAchievementEvent.NativeFieldInfoPtr_Achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEvent>.NativeClassPtr, nameof (Achievement));
      ProgressAchievementEvent.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEvent>.NativeClassPtr, nameof (User));
      ProgressAchievementEvent.NativeFieldInfoPtr_CompleteAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEvent>.NativeClassPtr, nameof (CompleteAmount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProgressAchievementEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
