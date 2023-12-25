// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.GlobalParticleIndex
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GlobalParticleIndex
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticleIndex;
    [FieldOffset(0)]
    public int PrefabIndex;
    [FieldOffset(4)]
    public int ParticleIndex;

    static GlobalParticleIndex()
    {
      Il2CppClassPointerStore<GlobalParticleIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (GlobalParticleIndex));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleIndex>.NativeClassPtr);
      GlobalParticleIndex.NativeFieldInfoPtr_PrefabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleIndex>.NativeClassPtr, nameof (PrefabIndex));
      GlobalParticleIndex.NativeFieldInfoPtr_ParticleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleIndex>.NativeClassPtr, nameof (ParticleIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleIndex>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
