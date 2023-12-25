// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.AnimatorLastState
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
  public struct AnimatorLastState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Animation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutIfRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullBodyLayerWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpperBodyLayerWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseChestAimIk;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitIfRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasTransitionedOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasTransitionedOutIfMoving;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FinishPlaying;
    [FieldOffset(0)]
    public FixedString128 Animation;
    [FieldOffset(128)]
    public float StartTime;
    [FieldOffset(132)]
    public float BlendIn;
    [FieldOffset(136)]
    public float BlendOut;
    [FieldOffset(140)]
    public float BlendOutIfRunning;
    [FieldOffset(144)]
    public float Duration;
    [FieldOffset(148)]
    public AnimationTypeEnum AnimationType;
    [FieldOffset(152)]
    public int Importance;
    [FieldOffset(156)]
    public float FullBodyLayerWeight;
    [FieldOffset(160)]
    public float UpperBodyLayerWeight;
    [FieldOffset(164)]
    public bool UseChestAimIk;
    [FieldOffset(165)]
    public bool ExitIfRunning;
    [FieldOffset(166)]
    public bool HasTransitionedOut;
    [FieldOffset(167)]
    public bool HasTransitionedOutIfMoving;
    [FieldOffset(168)]
    public bool HasState;
    [FieldOffset(169)]
    public bool FinishPlaying;

    static AnimatorLastState()
    {
      Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (AnimatorLastState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr);
      AnimatorLastState.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (Animation));
      AnimatorLastState.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (StartTime));
      AnimatorLastState.NativeFieldInfoPtr_BlendIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (BlendIn));
      AnimatorLastState.NativeFieldInfoPtr_BlendOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (BlendOut));
      AnimatorLastState.NativeFieldInfoPtr_BlendOutIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (BlendOutIfRunning));
      AnimatorLastState.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (Duration));
      AnimatorLastState.NativeFieldInfoPtr_AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (AnimationType));
      AnimatorLastState.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (Importance));
      AnimatorLastState.NativeFieldInfoPtr_FullBodyLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (FullBodyLayerWeight));
      AnimatorLastState.NativeFieldInfoPtr_UpperBodyLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (UpperBodyLayerWeight));
      AnimatorLastState.NativeFieldInfoPtr_UseChestAimIk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (UseChestAimIk));
      AnimatorLastState.NativeFieldInfoPtr_ExitIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (ExitIfRunning));
      AnimatorLastState.NativeFieldInfoPtr_HasTransitionedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (HasTransitionedOut));
      AnimatorLastState.NativeFieldInfoPtr_HasTransitionedOutIfMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (HasTransitionedOutIfMoving));
      AnimatorLastState.NativeFieldInfoPtr_HasState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (HasState));
      AnimatorLastState.NativeFieldInfoPtr_FinishPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, nameof (FinishPlaying));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorLastState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
