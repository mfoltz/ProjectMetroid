// Decompiled with JetBrains decompiler
// Type: ProjectM.AnimationState
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AnimationState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationName;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendInTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutTimeIfRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationScaleMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitIfRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanPlayMultipleTimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseChestAimIk;
    private static readonly System.IntPtr NativeFieldInfoPtr_FinishPlaying;
    [FieldOffset(0)]
    public FixedString128 AnimationName;
    [FieldOffset(128)]
    public float StartTime;
    [FieldOffset(132)]
    public float BlendInTime;
    [FieldOffset(136)]
    public float BlendOutTime;
    [FieldOffset(140)]
    public float BlendOutTimeIfRunning;
    [FieldOffset(144)]
    public float Duration;
    [FieldOffset(148)]
    public AnimationTypeEnum AnimationType;
    [FieldOffset(152)]
    public AnimationScaleModeEnum AnimationScaleMode;
    [FieldOffset(156)]
    public float PlaybackSpeed;
    [FieldOffset(160)]
    public int Importance;
    [FieldOffset(164)]
    public bool ExitIfRunning;
    [FieldOffset(165)]
    public bool CanPlayMultipleTimes;
    [FieldOffset(166)]
    public bool UseChestAimIk;
    [FieldOffset(167)]
    public bool FinishPlaying;

    static AnimationState()
    {
      Il2CppClassPointerStore<AnimationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AnimationState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationState>.NativeClassPtr);
      AnimationState.NativeFieldInfoPtr_AnimationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (AnimationName));
      AnimationState.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (StartTime));
      AnimationState.NativeFieldInfoPtr_BlendInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (BlendInTime));
      AnimationState.NativeFieldInfoPtr_BlendOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (BlendOutTime));
      AnimationState.NativeFieldInfoPtr_BlendOutTimeIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (BlendOutTimeIfRunning));
      AnimationState.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (Duration));
      AnimationState.NativeFieldInfoPtr_AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (AnimationType));
      AnimationState.NativeFieldInfoPtr_AnimationScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (AnimationScaleMode));
      AnimationState.NativeFieldInfoPtr_PlaybackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (PlaybackSpeed));
      AnimationState.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (Importance));
      AnimationState.NativeFieldInfoPtr_ExitIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (ExitIfRunning));
      AnimationState.NativeFieldInfoPtr_CanPlayMultipleTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (CanPlayMultipleTimes));
      AnimationState.NativeFieldInfoPtr_UseChestAimIk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (UseChestAimIk));
      AnimationState.NativeFieldInfoPtr_FinishPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, nameof (FinishPlaying));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
