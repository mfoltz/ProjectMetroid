// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyVFXParticleSystemBlobAsset
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
  public struct ProxyVFXParticleSystemBlobAsset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Parameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsValid;
    [FieldOffset(0)]
    public BlobArray<ProxyVFXParameter> Parameters;
    [FieldOffset(8)]
    public int NameIndex;
    [FieldOffset(12)]
    public bool IsValid;

    static ProxyVFXParticleSystemBlobAsset()
    {
      Il2CppClassPointerStore<ProxyVFXParticleSystemBlobAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyVFXParticleSystemBlobAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyVFXParticleSystemBlobAsset>.NativeClassPtr);
      ProxyVFXParticleSystemBlobAsset.NativeFieldInfoPtr_Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParticleSystemBlobAsset>.NativeClassPtr, nameof (Parameters));
      ProxyVFXParticleSystemBlobAsset.NativeFieldInfoPtr_NameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParticleSystemBlobAsset>.NativeClassPtr, nameof (NameIndex));
      ProxyVFXParticleSystemBlobAsset.NativeFieldInfoPtr_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParticleSystemBlobAsset>.NativeClassPtr, nameof (IsValid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProxyVFXParticleSystemBlobAsset>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
