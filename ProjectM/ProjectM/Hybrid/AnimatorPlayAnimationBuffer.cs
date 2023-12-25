// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.AnimatorPlayAnimationBuffer
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
  public struct AnimatorPlayAnimationBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Animation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalizedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendInTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationScaleMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationLayerEnum;
    private static readonly System.IntPtr NativeFieldInfoPtr_NullAnimation;
    [FieldOffset(0)]
    public FixedString128 Animation;
    [FieldOffset(128)]
    public float NormalizedTime;
    [FieldOffset(132)]
    public float BlendInTime;
    [FieldOffset(136)]
    public float Duration;
    [FieldOffset(140)]
    public float PlaybackSpeed;
    [FieldOffset(144)]
    public int Layer;
    [FieldOffset(148)]
    public AnimationScaleModeEnum AnimationScaleMode;
    [FieldOffset(152)]
    public AnimationLayerEnum AnimationLayerEnum;
    [FieldOffset(156)]
    public bool NullAnimation;

    static AnimatorPlayAnimationBuffer()
    {
      Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (AnimatorPlayAnimationBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr);
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (Animation));
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (NormalizedTime));
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_BlendInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (BlendInTime));
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (Duration));
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_PlaybackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (PlaybackSpeed));
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (Layer));
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_AnimationScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (AnimationScaleMode));
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_AnimationLayerEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (AnimationLayerEnum));
      AnimatorPlayAnimationBuffer.NativeFieldInfoPtr_NullAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, nameof (NullAnimation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorPlayAnimationBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
