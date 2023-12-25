// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequencerParticle
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SequencerParticle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    [FieldOffset(0)]
    public quaternion Rotation;
    [FieldOffset(16)]
    public float3 Position;
    [FieldOffset(28)]
    public float3 LocalScale;
    [FieldOffset(40)]
    public ParticleState State;

    static SequencerParticle()
    {
      Il2CppClassPointerStore<SequencerParticle>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequencerParticle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerParticle>.NativeClassPtr);
      SequencerParticle.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerParticle>.NativeClassPtr, nameof (Rotation));
      SequencerParticle.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerParticle>.NativeClassPtr, nameof (Position));
      SequencerParticle.NativeFieldInfoPtr_LocalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerParticle>.NativeClassPtr, nameof (LocalScale));
      SequencerParticle.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerParticle>.NativeClassPtr, nameof (State));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequencerParticle>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
