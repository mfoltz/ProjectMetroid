// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AnimatorParameterEvent
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
  public struct AnimatorParameterEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImportanceParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterFloat;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterInt;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterBool;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetAnimationListeners;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestoreOnFinish;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterName;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(8)]
    public BlackboardParameterRuntime ImportanceParameter;
    [FieldOffset(12)]
    public BlackboardParameterRuntime ParameterFloat;
    [FieldOffset(16)]
    public BlackboardParameterRuntime ParameterInt;
    [FieldOffset(20)]
    public BlackboardParameterRuntime ParameterBool;
    [FieldOffset(24)]
    public BlackboardParameterRuntime SetAnimationListeners;
    [FieldOffset(28)]
    public BlackboardParameterRuntime RestoreOnFinish;
    [FieldOffset(32)]
    public AnimatorParameterTypeEnum ParameterType;
    [FieldOffset(36)]
    public FixedString64 ParameterName;

    static AnimatorParameterEvent()
    {
      Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AnimatorParameterEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr);
      AnimatorParameterEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (NodeIndex));
      AnimatorParameterEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (TargetParameter));
      AnimatorParameterEvent.NativeFieldInfoPtr_ImportanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (ImportanceParameter));
      AnimatorParameterEvent.NativeFieldInfoPtr_ParameterFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (ParameterFloat));
      AnimatorParameterEvent.NativeFieldInfoPtr_ParameterInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (ParameterInt));
      AnimatorParameterEvent.NativeFieldInfoPtr_ParameterBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (ParameterBool));
      AnimatorParameterEvent.NativeFieldInfoPtr_SetAnimationListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (SetAnimationListeners));
      AnimatorParameterEvent.NativeFieldInfoPtr_RestoreOnFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (RestoreOnFinish));
      AnimatorParameterEvent.NativeFieldInfoPtr_ParameterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (ParameterType));
      AnimatorParameterEvent.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, nameof (ParameterName));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorParameterEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
