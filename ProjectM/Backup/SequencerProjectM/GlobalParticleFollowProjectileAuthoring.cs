// Decompiled with JetBrains decompiler
// Type: SequencerProjectM.GlobalParticleFollowProjectileAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;

#nullable disable
namespace SequencerProjectM
{
  public class GlobalParticleFollowProjectileAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GlobalParticleFollowProjectileAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalParticleFollowProjectileAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalParticleFollowProjectileAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GlobalParticleFollowProjectileAuthoring()
    {
      Il2CppClassPointerStore<GlobalParticleFollowProjectileAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "SequencerProjectM", nameof (GlobalParticleFollowProjectileAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleFollowProjectileAuthoring>.NativeClassPtr);
      GlobalParticleFollowProjectileAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleFollowProjectileAuthoring>.NativeClassPtr, 100663974);
    }

    public GlobalParticleFollowProjectileAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
