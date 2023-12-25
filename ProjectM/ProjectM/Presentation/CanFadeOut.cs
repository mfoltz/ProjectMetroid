// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.CanFadeOut
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CanFadeOut
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinimumFadeValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOut;
    [FieldOffset(0)]
    public float MinimumFadeValue;
    [FieldOffset(4)]
    public bool FadeOut;

    static CanFadeOut()
    {
      Il2CppClassPointerStore<CanFadeOut>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (CanFadeOut));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanFadeOut>.NativeClassPtr);
      CanFadeOut.NativeFieldInfoPtr_MinimumFadeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFadeOut>.NativeClassPtr, nameof (MinimumFadeValue));
      CanFadeOut.NativeFieldInfoPtr_FadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFadeOut>.NativeClassPtr, nameof (FadeOut));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CanFadeOut>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
