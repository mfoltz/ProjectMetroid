// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ScreenShakeOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ScreenShakeOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForwardForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_SideForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShakeSpace;
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    [FieldOffset(0)]
    public float3 Direction;
    [FieldOffset(12)]
    public float Duration;
    [FieldOffset(16)]
    public float ForwardForce;
    [FieldOffset(20)]
    public float SideForce;
    [FieldOffset(24)]
    public ScreenShakeSpaceEnum ShakeSpace;
    [FieldOffset(28)]
    public ScreenShakeSettings Settings;

    static ScreenShakeOutput()
    {
      Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ScreenShakeOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr);
      ScreenShakeOutput.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr, nameof (Direction));
      ScreenShakeOutput.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr, nameof (Duration));
      ScreenShakeOutput.NativeFieldInfoPtr_ForwardForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr, nameof (ForwardForce));
      ScreenShakeOutput.NativeFieldInfoPtr_SideForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr, nameof (SideForce));
      ScreenShakeOutput.NativeFieldInfoPtr_ShakeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr, nameof (ShakeSpace));
      ScreenShakeOutput.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr, nameof (Settings));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenShakeOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
