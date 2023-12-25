// Decompiled with JetBrains decompiler
// Type: ProjectM.FadeToBlack_Manual
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FadeToBlack_Manual
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeState;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalizedValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManualFadeDurationIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManualFadeDurationOut;
    [FieldOffset(0)]
    public FadeToBlack_Manual.State FadeState;
    [FieldOffset(4)]
    public float NormalizedValue;
    [FieldOffset(8)]
    public float ManualFadeDurationIn;
    [FieldOffset(12)]
    public float ManualFadeDurationOut;

    static FadeToBlack_Manual()
    {
      Il2CppClassPointerStore<FadeToBlack_Manual>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FadeToBlack_Manual));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeToBlack_Manual>.NativeClassPtr);
      FadeToBlack_Manual.NativeFieldInfoPtr_FadeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlack_Manual>.NativeClassPtr, nameof (FadeState));
      FadeToBlack_Manual.NativeFieldInfoPtr_NormalizedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlack_Manual>.NativeClassPtr, nameof (NormalizedValue));
      FadeToBlack_Manual.NativeFieldInfoPtr_ManualFadeDurationIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlack_Manual>.NativeClassPtr, nameof (ManualFadeDurationIn));
      FadeToBlack_Manual.NativeFieldInfoPtr_ManualFadeDurationOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlack_Manual>.NativeClassPtr, nameof (ManualFadeDurationOut));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FadeToBlack_Manual>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum State
    {
      FadeIn,
      Faded,
      FadeOut,
    }
  }
}
