﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyDyeData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProxyDyeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DyeOverrideIndex;
    [FieldOffset(0)]
    public int DyeOverrideIndex;

    static ProxyDyeData()
    {
      Il2CppClassPointerStore<ProxyDyeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyDyeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyDyeData>.NativeClassPtr);
      ProxyDyeData.NativeFieldInfoPtr_DyeOverrideIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyDyeData>.NativeClassPtr, nameof (DyeOverrideIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProxyDyeData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
