// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AnimationEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AnimationEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationName;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationScaleMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImportanceParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendInParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutIfRunningParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitIfRunningParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FinishPlaying;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanPlayMultipleTimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseChestAimIk;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public FixedString64 AnimationName;
    [FieldOffset(68)]
    public AnimationTypeEnum AnimationType;
    [FieldOffset(72)]
    public AnimationScaleModeEnum AnimationScaleMode;
    [FieldOffset(76)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(80)]
    public BlackboardParameterRuntime ImportanceParameter;
    [FieldOffset(84)]
    public BlackboardParameterRuntime BlendInParameter;
    [FieldOffset(88)]
    public BlackboardParameterRuntime BlendOutParameter;
    [FieldOffset(92)]
    public BlackboardParameterRuntime BlendOutIfRunningParameter;
    [FieldOffset(96)]
    public BlackboardParameterRuntime ExitIfRunningParameter;
    [FieldOffset(100)]
    public bool FinishPlaying;
    [FieldOffset(101)]
    public bool CanPlayMultipleTimes;
    [FieldOffset(102)]
    public bool UseChestAimIk;

    static AnimationEvent()
    {
      Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AnimationEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr);
      AnimationEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (NodeIndex));
      AnimationEvent.NativeFieldInfoPtr_AnimationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (AnimationName));
      AnimationEvent.NativeFieldInfoPtr_AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (AnimationType));
      AnimationEvent.NativeFieldInfoPtr_AnimationScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (AnimationScaleMode));
      AnimationEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (TargetParameter));
      AnimationEvent.NativeFieldInfoPtr_ImportanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (ImportanceParameter));
      AnimationEvent.NativeFieldInfoPtr_BlendInParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (BlendInParameter));
      AnimationEvent.NativeFieldInfoPtr_BlendOutParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (BlendOutParameter));
      AnimationEvent.NativeFieldInfoPtr_BlendOutIfRunningParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (BlendOutIfRunningParameter));
      AnimationEvent.NativeFieldInfoPtr_ExitIfRunningParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (ExitIfRunningParameter));
      AnimationEvent.NativeFieldInfoPtr_FinishPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (FinishPlaying));
      AnimationEvent.NativeFieldInfoPtr_CanPlayMultipleTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (CanPlayMultipleTimes));
      AnimationEvent.NativeFieldInfoPtr_UseChestAimIk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, nameof (UseChestAimIk));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
