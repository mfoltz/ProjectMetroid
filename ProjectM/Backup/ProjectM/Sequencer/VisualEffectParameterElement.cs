// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VisualEffectParameterElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VisualEffectParameterElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardValueType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffectIndex;
    [FieldOffset(0)]
    public FixedString64 ParameterName;
    [FieldOffset(64)]
    public BlackboardRegisterType BlackboardValueType;
    [FieldOffset(68)]
    public SocketDefaultValue Value;
    [FieldOffset(84)]
    public int VisualEffectIndex;

    static VisualEffectParameterElement()
    {
      Il2CppClassPointerStore<VisualEffectParameterElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VisualEffectParameterElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectParameterElement>.NativeClassPtr);
      VisualEffectParameterElement.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectParameterElement>.NativeClassPtr, nameof (ParameterName));
      VisualEffectParameterElement.NativeFieldInfoPtr_BlackboardValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectParameterElement>.NativeClassPtr, nameof (BlackboardValueType));
      VisualEffectParameterElement.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectParameterElement>.NativeClassPtr, nameof (Value));
      VisualEffectParameterElement.NativeFieldInfoPtr_VisualEffectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectParameterElement>.NativeClassPtr, nameof (VisualEffectIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualEffectParameterElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
