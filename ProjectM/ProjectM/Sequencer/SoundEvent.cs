// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SoundEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SoundEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Event;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundPlayMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CueOnStopParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceStopParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_VolumeParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_PitchParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistanceParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parameters;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public FmodEventGuid Event;
    [FieldOffset(20)]
    public SoundPlayModeEnum SoundPlayMode;
    [FieldOffset(24)]
    public BlackboardParameterRuntime PositionParameter;
    [FieldOffset(28)]
    public BlackboardParameterRuntime CueOnStopParameter;
    [FieldOffset(32)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(36)]
    public BlackboardParameterRuntime ForceStopParameter;
    [FieldOffset(40)]
    public BlackboardParameterRuntime VolumeParameter;
    [FieldOffset(44)]
    public BlackboardParameterRuntime PitchParameter;
    [FieldOffset(48)]
    public BlackboardParameterRuntime MinDistanceParameter;
    [FieldOffset(52)]
    public BlackboardParameterRuntime MaxDistanceParameter;
    [FieldOffset(56)]
    public BlobArray<SoundParameterRuntime> Parameters;

    static SoundEvent()
    {
      Il2CppClassPointerStore<SoundEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SoundEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr);
      SoundEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (NodeIndex));
      SoundEvent.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (Event));
      SoundEvent.NativeFieldInfoPtr_SoundPlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (SoundPlayMode));
      SoundEvent.NativeFieldInfoPtr_PositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (PositionParameter));
      SoundEvent.NativeFieldInfoPtr_CueOnStopParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (CueOnStopParameter));
      SoundEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (TargetParameter));
      SoundEvent.NativeFieldInfoPtr_ForceStopParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (ForceStopParameter));
      SoundEvent.NativeFieldInfoPtr_VolumeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (VolumeParameter));
      SoundEvent.NativeFieldInfoPtr_PitchParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (PitchParameter));
      SoundEvent.NativeFieldInfoPtr_MinDistanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (MinDistanceParameter));
      SoundEvent.NativeFieldInfoPtr_MaxDistanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (MaxDistanceParameter));
      SoundEvent.NativeFieldInfoPtr_Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, nameof (Parameters));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SoundEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
