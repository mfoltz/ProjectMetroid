// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VisualEffectBlob
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
  public struct VisualEffectBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Parameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardValueType;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffectIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterName;
    [FieldOffset(0)]
    public BlackboardParameterRuntime Parameter;
    [FieldOffset(4)]
    public BlackboardRegisterType BlackboardValueType;
    [FieldOffset(8)]
    public int VisualEffectIndex;
    [FieldOffset(12)]
    public FixedString64 ParameterName;

    static VisualEffectBlob()
    {
      Il2CppClassPointerStore<VisualEffectBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VisualEffectBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectBlob>.NativeClassPtr);
      VisualEffectBlob.NativeFieldInfoPtr_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectBlob>.NativeClassPtr, nameof (Parameter));
      VisualEffectBlob.NativeFieldInfoPtr_BlackboardValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectBlob>.NativeClassPtr, nameof (BlackboardValueType));
      VisualEffectBlob.NativeFieldInfoPtr_VisualEffectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectBlob>.NativeClassPtr, nameof (VisualEffectIndex));
      VisualEffectBlob.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectBlob>.NativeClassPtr, nameof (ParameterName));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualEffectBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
