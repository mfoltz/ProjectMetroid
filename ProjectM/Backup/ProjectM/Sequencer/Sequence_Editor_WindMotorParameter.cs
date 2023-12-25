// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Sequence_Editor_WindMotorParameter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Wind;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Sequence_Editor_WindMotorParameter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MotorType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    [FieldOffset(0)]
    public WindMotorTypes MotorType;
    [FieldOffset(4)]
    public float3 Position;
    [FieldOffset(16)]
    public float3 Force;
    [FieldOffset(28)]
    public float Range;

    static Sequence_Editor_WindMotorParameter()
    {
      Il2CppClassPointerStore<Sequence_Editor_WindMotorParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Sequence_Editor_WindMotorParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence_Editor_WindMotorParameter>.NativeClassPtr);
      Sequence_Editor_WindMotorParameter.NativeFieldInfoPtr_MotorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_WindMotorParameter>.NativeClassPtr, nameof (MotorType));
      Sequence_Editor_WindMotorParameter.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_WindMotorParameter>.NativeClassPtr, nameof (Position));
      Sequence_Editor_WindMotorParameter.NativeFieldInfoPtr_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_WindMotorParameter>.NativeClassPtr, nameof (Force));
      Sequence_Editor_WindMotorParameter.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_WindMotorParameter>.NativeClassPtr, nameof (Range));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sequence_Editor_WindMotorParameter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
