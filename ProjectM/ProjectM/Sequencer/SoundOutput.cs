// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SoundOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Audio;
using Stunlock.Fmod;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SoundOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Volume;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pitch;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundParameterStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFrameOutputIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Event;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundParameterCount;
    [FieldOffset(0)]
    public Entity SequenceEntity;
    [FieldOffset(8)]
    public float3 Position;
    [FieldOffset(20)]
    public float Volume;
    [FieldOffset(24)]
    public float Pitch;
    [FieldOffset(28)]
    public float MinDistance;
    [FieldOffset(32)]
    public float MaxDistance;
    [FieldOffset(36)]
    public int SoundParameterStartIndex;
    [FieldOffset(40)]
    public int LastFrameOutputIndex;
    [FieldOffset(44)]
    public FmodEventGuid Event;
    [FieldOffset(60)]
    public StudioEventStopModeEnum StopMode;
    [FieldOffset(64)]
    public int SoundParameterCount;

    static SoundOutput()
    {
      Il2CppClassPointerStore<SoundOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SoundOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr);
      SoundOutput.NativeFieldInfoPtr_SequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (SequenceEntity));
      SoundOutput.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (Position));
      SoundOutput.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (Volume));
      SoundOutput.NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (Pitch));
      SoundOutput.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (MinDistance));
      SoundOutput.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (MaxDistance));
      SoundOutput.NativeFieldInfoPtr_SoundParameterStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (SoundParameterStartIndex));
      SoundOutput.NativeFieldInfoPtr_LastFrameOutputIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (LastFrameOutputIndex));
      SoundOutput.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (Event));
      SoundOutput.NativeFieldInfoPtr_StopMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (StopMode));
      SoundOutput.NativeFieldInfoPtr_SoundParameterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, nameof (SoundParameterCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SoundOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
