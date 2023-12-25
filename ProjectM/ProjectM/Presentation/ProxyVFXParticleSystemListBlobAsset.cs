// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyVFXParticleSystemListBlobAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProxyVFXParticleSystemListBlobAsset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticleSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsValid;
    [FieldOffset(0)]
    public BlobArray<ProxyVFXParticleSystemBlobAsset> ParticleSystems;
    [FieldOffset(8)]
    public bool IsValid;

    static ProxyVFXParticleSystemListBlobAsset()
    {
      Il2CppClassPointerStore<ProxyVFXParticleSystemListBlobAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyVFXParticleSystemListBlobAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyVFXParticleSystemListBlobAsset>.NativeClassPtr);
      ProxyVFXParticleSystemListBlobAsset.NativeFieldInfoPtr_ParticleSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParticleSystemListBlobAsset>.NativeClassPtr, nameof (ParticleSystems));
      ProxyVFXParticleSystemListBlobAsset.NativeFieldInfoPtr_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParticleSystemListBlobAsset>.NativeClassPtr, nameof (IsValid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProxyVFXParticleSystemListBlobAsset>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
