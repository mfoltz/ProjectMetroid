// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ParticleOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ParticleOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputEntityBlackboardIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffectParameterStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineRendererParameterStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFrameOutputIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_DyeVariationIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffectParameterCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineRendererParameterCount;
    [FieldOffset(0)]
    public Entity SequenceEntity;
    [FieldOffset(8)]
    public int OutputEntityBlackboardIndex;
    [FieldOffset(12)]
    public float3 Position;
    [FieldOffset(24)]
    public quaternion Rotation;
    [FieldOffset(40)]
    public float3 Scale;
    [FieldOffset(52)]
    public ushort VisualEffectParameterStartIndex;
    [FieldOffset(54)]
    public ushort LineRendererParameterStartIndex;
    [FieldOffset(56)]
    public int LastFrameOutputIndex;
    [FieldOffset(60)]
    public int AssetIndex;
    [FieldOffset(64)]
    public int DyeVariationIndex;
    [FieldOffset(68)]
    public float PlaybackSpeed;
    [FieldOffset(72)]
    public byte VisualEffectParameterCount;
    [FieldOffset(73)]
    public byte LineRendererParameterCount;

    static ParticleOutput()
    {
      Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ParticleOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr);
      ParticleOutput.NativeFieldInfoPtr_SequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (SequenceEntity));
      ParticleOutput.NativeFieldInfoPtr_OutputEntityBlackboardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (OutputEntityBlackboardIndex));
      ParticleOutput.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (Position));
      ParticleOutput.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (Rotation));
      ParticleOutput.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (Scale));
      ParticleOutput.NativeFieldInfoPtr_VisualEffectParameterStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (VisualEffectParameterStartIndex));
      ParticleOutput.NativeFieldInfoPtr_LineRendererParameterStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (LineRendererParameterStartIndex));
      ParticleOutput.NativeFieldInfoPtr_LastFrameOutputIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (LastFrameOutputIndex));
      ParticleOutput.NativeFieldInfoPtr_AssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (AssetIndex));
      ParticleOutput.NativeFieldInfoPtr_DyeVariationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (DyeVariationIndex));
      ParticleOutput.NativeFieldInfoPtr_PlaybackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (PlaybackSpeed));
      ParticleOutput.NativeFieldInfoPtr_VisualEffectParameterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (VisualEffectParameterCount));
      ParticleOutput.NativeFieldInfoPtr_LineRendererParameterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, nameof (LineRendererParameterCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
