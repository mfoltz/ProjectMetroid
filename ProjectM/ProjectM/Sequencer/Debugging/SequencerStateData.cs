// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Debugging.SequencerStateData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SequencerStateData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_StateEnum;
    [FieldOffset(0)]
    public float Time;
    [FieldOffset(4)]
    public int NodeIndex;
    [FieldOffset(8)]
    public float Duration;
    [FieldOffset(12)]
    public float Speed;
    [FieldOffset(16)]
    public EventStateEnum StateEnum;

    static SequencerStateData()
    {
      Il2CppClassPointerStore<SequencerStateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer.Debugging", nameof (SequencerStateData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerStateData>.NativeClassPtr);
      SequencerStateData.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerStateData>.NativeClassPtr, nameof (Time));
      SequencerStateData.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerStateData>.NativeClassPtr, nameof (NodeIndex));
      SequencerStateData.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerStateData>.NativeClassPtr, nameof (Duration));
      SequencerStateData.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerStateData>.NativeClassPtr, nameof (Speed));
      SequencerStateData.NativeFieldInfoPtr_StateEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerStateData>.NativeClassPtr, nameof (StateEnum));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequencerStateData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
