﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ShaderProperty_OverlappingAnimationTime
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShaderProperty_OverlappingAnimationTime
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public float Value;

    static ShaderProperty_OverlappingAnimationTime()
    {
      Il2CppClassPointerStore<ShaderProperty_OverlappingAnimationTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ShaderProperty_OverlappingAnimationTime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperty_OverlappingAnimationTime>.NativeClassPtr);
      ShaderProperty_OverlappingAnimationTime.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_OverlappingAnimationTime>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderProperty_OverlappingAnimationTime>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
