// Decompiled with JetBrains decompiler
// Type: ProjectM.FadeToBlack
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FadeToBlack
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveTimeline;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentValue;
    [FieldOffset(0)]
    public MinMaxValue ActiveTimeline;
    [FieldOffset(8)]
    public CurveReference Curve;
    [FieldOffset(16)]
    public float CurrentValue;

    static FadeToBlack()
    {
      Il2CppClassPointerStore<FadeToBlack>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FadeToBlack));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeToBlack>.NativeClassPtr);
      FadeToBlack.NativeFieldInfoPtr_ActiveTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlack>.NativeClassPtr, nameof (ActiveTimeline));
      FadeToBlack.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlack>.NativeClassPtr, nameof (Curve));
      FadeToBlack.NativeFieldInfoPtr_CurrentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlack>.NativeClassPtr, nameof (CurrentValue));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FadeToBlack>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
