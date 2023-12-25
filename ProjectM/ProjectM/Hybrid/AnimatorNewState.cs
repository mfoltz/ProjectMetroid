// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.AnimatorNewState
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AnimatorNewState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Animation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalizedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutIfRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationScaleMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitIfRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanPlayMultipleTimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasState;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseChestAimIk;
    private static readonly System.IntPtr NativeFieldInfoPtr_FinishPlaying;
    [FieldOffset(0)]
    public FixedString128 Animation;
    [FieldOffset(128)]
    public float StartTime;
    [FieldOffset(132)]
    public float NormalizedTime;
    [FieldOffset(136)]
    public float BlendIn;
    [FieldOffset(140)]
    public float BlendOut;
    [FieldOffset(144)]
    public float BlendOutIfRunning;
    [FieldOffset(148)]
    public float Duration;
    [FieldOffset(152)]
    public float PlaybackSpeed;
    [FieldOffset(156)]
    public AnimationScaleModeEnum AnimationScaleMode;
    [FieldOffset(160)]
    public AnimationTypeEnum AnimationType;
    [FieldOffset(164)]
    public int Importance;
    [FieldOffset(168)]
    public bool ExitIfRunning;
    [FieldOffset(169)]
    public bool CanPlayMultipleTimes;
    [FieldOffset(170)]
    public bool HasState;
    [FieldOffset(171)]
    public bool UseChestAimIk;
    [FieldOffset(172)]
    public bool FinishPlaying;

    static AnimatorNewState()
    {
      Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (AnimatorNewState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr);
      AnimatorNewState.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (Animation));
      AnimatorNewState.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (StartTime));
      AnimatorNewState.NativeFieldInfoPtr_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (NormalizedTime));
      AnimatorNewState.NativeFieldInfoPtr_BlendIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (BlendIn));
      AnimatorNewState.NativeFieldInfoPtr_BlendOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (BlendOut));
      AnimatorNewState.NativeFieldInfoPtr_BlendOutIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (BlendOutIfRunning));
      AnimatorNewState.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (Duration));
      AnimatorNewState.NativeFieldInfoPtr_PlaybackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (PlaybackSpeed));
      AnimatorNewState.NativeFieldInfoPtr_AnimationScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (AnimationScaleMode));
      AnimatorNewState.NativeFieldInfoPtr_AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (AnimationType));
      AnimatorNewState.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (Importance));
      AnimatorNewState.NativeFieldInfoPtr_ExitIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (ExitIfRunning));
      AnimatorNewState.NativeFieldInfoPtr_CanPlayMultipleTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (CanPlayMultipleTimes));
      AnimatorNewState.NativeFieldInfoPtr_HasState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (HasState));
      AnimatorNewState.NativeFieldInfoPtr_UseChestAimIk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (UseChestAimIk));
      AnimatorNewState.NativeFieldInfoPtr_FinishPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, nameof (FinishPlaying));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorNewState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
