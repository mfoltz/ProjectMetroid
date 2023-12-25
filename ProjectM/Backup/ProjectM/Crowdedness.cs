// Decompiled with JetBrains decompiler
// Type: ProjectM.Crowdedness
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Crowdedness
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_FastTransitionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlowTransitionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public float Range;
    [FieldOffset(4)]
    public float FastTransitionTime;
    [FieldOffset(8)]
    public float SlowTransitionTime;
    [FieldOffset(12)]
    public float Value;

    static Crowdedness()
    {
      Il2CppClassPointerStore<Crowdedness>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Crowdedness));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Crowdedness>.NativeClassPtr);
      Crowdedness.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crowdedness>.NativeClassPtr, nameof (Range));
      Crowdedness.NativeFieldInfoPtr_FastTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crowdedness>.NativeClassPtr, nameof (FastTransitionTime));
      Crowdedness.NativeFieldInfoPtr_SlowTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crowdedness>.NativeClassPtr, nameof (SlowTransitionTime));
      Crowdedness.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crowdedness>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Crowdedness>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
