﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.LifeLeechSetting
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct LifeLeechSetting
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_Modifier;
    [FieldOffset(0)]
    public EntityCategory EntityCategory;
    [FieldOffset(8)]
    public float Modifier;

    static LifeLeechSetting()
    {
      Il2CppClassPointerStore<LifeLeechSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LifeLeechSetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LifeLeechSetting>.NativeClassPtr);
      LifeLeechSetting.NativeFieldInfoPtr_EntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeechSetting>.NativeClassPtr, nameof (EntityCategory));
      LifeLeechSetting.NativeFieldInfoPtr_Modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeechSetting>.NativeClassPtr, nameof (Modifier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LifeLeechSetting>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}