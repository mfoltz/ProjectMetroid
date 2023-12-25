// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.UpdateParticlesJob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.ParticleSystemJobs;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateParticlesJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_BufferOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_GlobalParticlePositionBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ParticleSystemJobData_0;
    [FieldOffset(0)]
    public int StartIndex;
    [FieldOffset(4)]
    public int BufferOffset;
    [FieldOffset(8)]
    public NativeArray<float4> GlobalParticlePositionBuffer;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101292, RefRangeEnd = 1101293, XrefRangeStart = 1101292, XrefRangeEnd = 1101292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ParticleSystemJobData particles)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &particles;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateParticlesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ParticleSystemJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateParticlesJob()
    {
      Il2CppClassPointerStore<UpdateParticlesJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (UpdateParticlesJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateParticlesJob>.NativeClassPtr);
      UpdateParticlesJob.NativeFieldInfoPtr_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateParticlesJob>.NativeClassPtr, nameof (StartIndex));
      UpdateParticlesJob.NativeFieldInfoPtr_BufferOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateParticlesJob>.NativeClassPtr, nameof (BufferOffset));
      UpdateParticlesJob.NativeFieldInfoPtr_GlobalParticlePositionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateParticlesJob>.NativeClassPtr, nameof (GlobalParticlePositionBuffer));
      UpdateParticlesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ParticleSystemJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateParticlesJob>.NativeClassPtr, 100687390);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateParticlesJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
