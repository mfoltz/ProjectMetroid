// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VolumeProfileEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VolumeProfileEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImportanceParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeightParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeInTimeParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutTimeParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullscreenEffectType;
    private static readonly System.IntPtr NativeFieldInfoPtr_VolumeProfileAssetIndex;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public BlackboardParameterRuntime ImportanceParameter;
    [FieldOffset(8)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(12)]
    public BlackboardParameterRuntime WeightParameter;
    [FieldOffset(16)]
    public BlackboardParameterRuntime FadeInTimeParameter;
    [FieldOffset(20)]
    public BlackboardParameterRuntime FadeOutTimeParameter;
    [FieldOffset(24)]
    public FullscreenEffectTypeEnum FullscreenEffectType;
    [FieldOffset(28)]
    public int VolumeProfileAssetIndex;

    static VolumeProfileEvent()
    {
      Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VolumeProfileEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr);
      VolumeProfileEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, nameof (NodeIndex));
      VolumeProfileEvent.NativeFieldInfoPtr_ImportanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, nameof (ImportanceParameter));
      VolumeProfileEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, nameof (TargetParameter));
      VolumeProfileEvent.NativeFieldInfoPtr_WeightParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, nameof (WeightParameter));
      VolumeProfileEvent.NativeFieldInfoPtr_FadeInTimeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, nameof (FadeInTimeParameter));
      VolumeProfileEvent.NativeFieldInfoPtr_FadeOutTimeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, nameof (FadeOutTimeParameter));
      VolumeProfileEvent.NativeFieldInfoPtr_FullscreenEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, nameof (FullscreenEffectType));
      VolumeProfileEvent.NativeFieldInfoPtr_VolumeProfileAssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, nameof (VolumeProfileAssetIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeProfileEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
