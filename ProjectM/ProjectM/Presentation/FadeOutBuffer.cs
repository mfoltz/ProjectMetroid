﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.FadeOutBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FadeOutBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public Entity Entity;

    static FadeOutBuffer()
    {
      Il2CppClassPointerStore<FadeOutBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (FadeOutBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeOutBuffer>.NativeClassPtr);
      FadeOutBuffer.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutBuffer>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FadeOutBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
