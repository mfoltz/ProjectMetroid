// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequenceBlob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Sequencer;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SequenceBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayInFlyMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventMetaData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FlowEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticleEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_WindMotorEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalMaterialEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScreenShakes;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimatorParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_Animations;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_Voices;
    private static readonly System.IntPtr NativeFieldInfoPtr_VolumeProfiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialChanges;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideMaterialEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialProperties;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoomModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_GraphDebugging;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceAssetGuid;
    [FieldOffset(0)]
    public bool PlayInFlyMode;
    [FieldOffset(4)]
    public BlobArray<NodeMetaData> EventMetaData;
    [FieldOffset(12)]
    public BlobArray<FlowEventBlob> FlowEvents;
    [FieldOffset(20)]
    public BlobArray<ParticleEvent> ParticleEvents;
    [FieldOffset(28)]
    public BlobArray<WindMotorEvent> WindMotorEvents;
    [FieldOffset(36)]
    public BlobArray<AdditionalMaterialEvent> AdditionalMaterialEvents;
    [FieldOffset(44)]
    public BlobArray<ScreenShakeEvent> ScreenShakes;
    [FieldOffset(52)]
    public BlobArray<AnimatorParameterEvent> AnimatorParameters;
    [FieldOffset(60)]
    public BlobArray<AnimationEvent> Animations;
    [FieldOffset(68)]
    public BlobArray<SoundEvent> Sounds;
    [FieldOffset(76)]
    public BlobArray<VoiceEvent> Voices;
    [FieldOffset(84)]
    public BlobArray<VolumeProfileEvent> VolumeProfiles;
    [FieldOffset(92)]
    public BlobArray<MaterialChangeEvent> MaterialChanges;
    [FieldOffset(100)]
    public BlobArray<HideMaterialEvent> HideMaterialEvents;
    [FieldOffset(108)]
    public BlobArray<MaterialPropertyEvent> MaterialProperties;
    [FieldOffset(116)]
    public BlobArray<ZoomModifierEvent> ZoomModifiers;
    [FieldOffset(124)]
    public BlobArray<GraphDebugRegisterElement> GraphDebugging;
    [FieldOffset(132)]
    public BlobString SequenceAssetGuid;

    static SequenceBlob()
    {
      Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (SequenceBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr);
      SequenceBlob.NativeFieldInfoPtr_PlayInFlyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (PlayInFlyMode));
      SequenceBlob.NativeFieldInfoPtr_EventMetaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (EventMetaData));
      SequenceBlob.NativeFieldInfoPtr_FlowEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (FlowEvents));
      SequenceBlob.NativeFieldInfoPtr_ParticleEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (ParticleEvents));
      SequenceBlob.NativeFieldInfoPtr_WindMotorEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (WindMotorEvents));
      SequenceBlob.NativeFieldInfoPtr_AdditionalMaterialEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (AdditionalMaterialEvents));
      SequenceBlob.NativeFieldInfoPtr_ScreenShakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (ScreenShakes));
      SequenceBlob.NativeFieldInfoPtr_AnimatorParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (AnimatorParameters));
      SequenceBlob.NativeFieldInfoPtr_Animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (Animations));
      SequenceBlob.NativeFieldInfoPtr_Sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (Sounds));
      SequenceBlob.NativeFieldInfoPtr_Voices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (Voices));
      SequenceBlob.NativeFieldInfoPtr_VolumeProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (VolumeProfiles));
      SequenceBlob.NativeFieldInfoPtr_MaterialChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (MaterialChanges));
      SequenceBlob.NativeFieldInfoPtr_HideMaterialEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (HideMaterialEvents));
      SequenceBlob.NativeFieldInfoPtr_MaterialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (MaterialProperties));
      SequenceBlob.NativeFieldInfoPtr_ZoomModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (ZoomModifiers));
      SequenceBlob.NativeFieldInfoPtr_GraphDebugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (GraphDebugging));
      SequenceBlob.NativeFieldInfoPtr_SequenceAssetGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, nameof (SequenceAssetGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequenceBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
