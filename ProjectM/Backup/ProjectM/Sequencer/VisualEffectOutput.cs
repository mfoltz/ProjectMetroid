// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VisualEffectOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VisualEffectOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffectParameterElement;
    [FieldOffset(0)]
    public VisualEffectParameterElement VisualEffectParameterElement;

    static VisualEffectOutput()
    {
      Il2CppClassPointerStore<VisualEffectOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VisualEffectOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectOutput>.NativeClassPtr);
      VisualEffectOutput.NativeFieldInfoPtr_VisualEffectParameterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectOutput>.NativeClassPtr, nameof (VisualEffectParameterElement));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualEffectOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
