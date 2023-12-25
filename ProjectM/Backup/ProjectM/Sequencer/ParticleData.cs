// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ParticleData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ParticleData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Particles;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffects;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineRenderers;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_ParticleData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<ParticleOutput> Particles;
    [FieldOffset(16)]
    public NativeList<VisualEffectOutput> VisualEffects;
    [FieldOffset(32)]
    public NativeList<LineRendererOutput> LineRenderers;
    [FieldOffset(48)]
    public NativeList<Entity> Entities;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107147, RefRangeEnd = 1107149, XrefRangeStart = 1107135, XrefRangeEnd = 1107147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParticleData(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107161, RefRangeEnd = 1107162, XrefRangeStart = 1107149, XrefRangeEnd = 1107161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleData.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107198, RefRangeEnd = 1107199, XrefRangeStart = 1107162, XrefRangeEnd = 1107198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyFrom(ParticleData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleData.NativeMethodInfoPtr_CopyFrom_Public_Void_ParticleData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107211, RefRangeEnd = 1107213, XrefRangeStart = 1107199, XrefRangeEnd = 1107211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ParticleData()
    {
      Il2CppClassPointerStore<ParticleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ParticleData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleData>.NativeClassPtr);
      ParticleData.NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, nameof (Particles));
      ParticleData.NativeFieldInfoPtr_VisualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, nameof (VisualEffects));
      ParticleData.NativeFieldInfoPtr_LineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, nameof (LineRenderers));
      ParticleData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, nameof (Entities));
      ParticleData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, 100687709);
      ParticleData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, 100687710);
      ParticleData.NativeMethodInfoPtr_CopyFrom_Public_Void_ParticleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, 100687711);
      ParticleData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, 100687712);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
