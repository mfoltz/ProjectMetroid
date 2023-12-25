// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ParticleEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ParticleEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabAssetIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoundingSphereRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_CullingDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_DyeVariationIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScaleParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputEntityParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineRenderers;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffects;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public int PrefabAssetIndex;
    [FieldOffset(8)]
    public float BoundingSphereRadius;
    [FieldOffset(12)]
    public float CullingDuration;
    [FieldOffset(16)]
    public BlackboardParameterRuntime DyeVariationIndex;
    [FieldOffset(20)]
    public BlackboardParameterRuntime PositionParameter;
    [FieldOffset(24)]
    public BlackboardParameterRuntime RotationParameter;
    [FieldOffset(28)]
    public BlackboardParameterRuntime ScaleParameter;
    [FieldOffset(32)]
    public BlackboardParameterRuntime OutputEntityParameter;
    [FieldOffset(36)]
    public BlobArray<LineRendererBlob> LineRenderers;
    [FieldOffset(44)]
    public BlobArray<VisualEffectBlob> VisualEffects;

    static ParticleEvent()
    {
      Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ParticleEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr);
      ParticleEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (NodeIndex));
      ParticleEvent.NativeFieldInfoPtr_PrefabAssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (PrefabAssetIndex));
      ParticleEvent.NativeFieldInfoPtr_BoundingSphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (BoundingSphereRadius));
      ParticleEvent.NativeFieldInfoPtr_CullingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (CullingDuration));
      ParticleEvent.NativeFieldInfoPtr_DyeVariationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (DyeVariationIndex));
      ParticleEvent.NativeFieldInfoPtr_PositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (PositionParameter));
      ParticleEvent.NativeFieldInfoPtr_RotationParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (RotationParameter));
      ParticleEvent.NativeFieldInfoPtr_ScaleParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (ScaleParameter));
      ParticleEvent.NativeFieldInfoPtr_OutputEntityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (OutputEntityParameter));
      ParticleEvent.NativeFieldInfoPtr_LineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (LineRenderers));
      ParticleEvent.NativeFieldInfoPtr_VisualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, nameof (VisualEffects));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
