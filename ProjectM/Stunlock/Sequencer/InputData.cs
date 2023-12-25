// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.InputData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InputData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventState;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blackboard;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequencerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hidden;
    private static readonly System.IntPtr NativeFieldInfoPtr_HiddenInFly;
    [FieldOffset(0)]
    public unsafe EventStruct* EventState;
    [FieldOffset(8)]
    public Blackboard Blackboard;
    [FieldOffset(16)]
    public SequenceAsset SequenceAsset;
    [FieldOffset(24)]
    public Entity SequencerEntity;
    [FieldOffset(32)]
    public float CurrentTime;
    [FieldOffset(36)]
    public int CurrentFrame;
    [FieldOffset(40)]
    public bool Hidden;
    [FieldOffset(41)]
    public bool HiddenInFly;

    static InputData()
    {
      Il2CppClassPointerStore<InputData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (InputData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputData>.NativeClassPtr);
      InputData.NativeFieldInfoPtr_EventState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, nameof (EventState));
      InputData.NativeFieldInfoPtr_Blackboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, nameof (Blackboard));
      InputData.NativeFieldInfoPtr_SequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, nameof (SequenceAsset));
      InputData.NativeFieldInfoPtr_SequencerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, nameof (SequencerEntity));
      InputData.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, nameof (CurrentTime));
      InputData.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, nameof (CurrentFrame));
      InputData.NativeFieldInfoPtr_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, nameof (Hidden));
      InputData.NativeFieldInfoPtr_HiddenInFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, nameof (HiddenInFly));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
