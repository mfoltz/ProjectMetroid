// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.WindMotorEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Wind;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WindMotorEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_MotorTypeParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_RangeParameter;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public WindMotorTypes MotorTypeParameter;
    [FieldOffset(8)]
    public BlackboardParameterRuntime PositionParameter;
    [FieldOffset(12)]
    public BlackboardParameterRuntime ForceParameter;
    [FieldOffset(16)]
    public BlackboardParameterRuntime RangeParameter;

    static WindMotorEvent()
    {
      Il2CppClassPointerStore<WindMotorEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (WindMotorEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindMotorEvent>.NativeClassPtr);
      WindMotorEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEvent>.NativeClassPtr, nameof (NodeIndex));
      WindMotorEvent.NativeFieldInfoPtr_MotorTypeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEvent>.NativeClassPtr, nameof (MotorTypeParameter));
      WindMotorEvent.NativeFieldInfoPtr_PositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEvent>.NativeClassPtr, nameof (PositionParameter));
      WindMotorEvent.NativeFieldInfoPtr_ForceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEvent>.NativeClassPtr, nameof (ForceParameter));
      WindMotorEvent.NativeFieldInfoPtr_RangeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEvent>.NativeClassPtr, nameof (RangeParameter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindMotorEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
