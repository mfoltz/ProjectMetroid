// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.WindMotorOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WindMotorOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MotorType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFrameOutputIndex;
    [FieldOffset(0)]
    public Entity SequenceEntity;
    [FieldOffset(8)]
    public int MotorType;
    [FieldOffset(12)]
    public float3 Position;
    [FieldOffset(24)]
    public float3 Force;
    [FieldOffset(36)]
    public float Range;
    [FieldOffset(40)]
    public int LastFrameOutputIndex;

    static WindMotorOutput()
    {
      Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (WindMotorOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr);
      WindMotorOutput.NativeFieldInfoPtr_SequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr, nameof (SequenceEntity));
      WindMotorOutput.NativeFieldInfoPtr_MotorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr, nameof (MotorType));
      WindMotorOutput.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr, nameof (Position));
      WindMotorOutput.NativeFieldInfoPtr_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr, nameof (Force));
      WindMotorOutput.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr, nameof (Range));
      WindMotorOutput.NativeFieldInfoPtr_LastFrameOutputIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr, nameof (LastFrameOutputIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindMotorOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
