// Decompiled with JetBrains decompiler
// Type: ProjectM.TargetAOESequence
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
  public struct TargetAOESequence
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImpactSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_Instance;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeEvaluateCurve;
    [FieldOffset(0)]
    public SequenceGUID Sequence;
    [FieldOffset(4)]
    public SequenceGUID ImpactSequence;
    [FieldOffset(8)]
    public SequenceState Instance;
    [FieldOffset(16)]
    public CurveReference TimeEvaluateCurve;

    static TargetAOESequence()
    {
      Il2CppClassPointerStore<TargetAOESequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TargetAOESequence));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetAOESequence>.NativeClassPtr);
      TargetAOESequence.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAOESequence>.NativeClassPtr, nameof (Sequence));
      TargetAOESequence.NativeFieldInfoPtr_ImpactSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAOESequence>.NativeClassPtr, nameof (ImpactSequence));
      TargetAOESequence.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAOESequence>.NativeClassPtr, nameof (Instance));
      TargetAOESequence.NativeFieldInfoPtr_TimeEvaluateCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAOESequence>.NativeClassPtr, nameof (TimeEvaluateCurve));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetAOESequence>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
