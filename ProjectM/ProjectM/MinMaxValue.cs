// Decompiled with JetBrains decompiler
// Type: ProjectM.MinMaxValue
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
  public struct MinMaxValue
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPadding;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPadding;
    [FieldOffset(0)]
    public float MinPadding;
    [FieldOffset(4)]
    public float MaxPadding;

    static MinMaxValue()
    {
      Il2CppClassPointerStore<MinMaxValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MinMaxValue));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxValue>.NativeClassPtr);
      MinMaxValue.NativeFieldInfoPtr_MinPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxValue>.NativeClassPtr, nameof (MinPadding));
      MinMaxValue.NativeFieldInfoPtr_MaxPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxValue>.NativeClassPtr, nameof (MaxPadding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinMaxValue>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
