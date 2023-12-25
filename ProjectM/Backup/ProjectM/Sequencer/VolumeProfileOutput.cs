// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VolumeProfileOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VolumeProfileOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeInTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutTime;
    [FieldOffset(0)]
    public SequenceAssetReference AssetReference;
    [FieldOffset(12)]
    public int Importance;
    [FieldOffset(16)]
    public float StartTime;
    [FieldOffset(20)]
    public float Weight;
    [FieldOffset(24)]
    public float FadeInTime;
    [FieldOffset(28)]
    public float FadeOutTime;

    static VolumeProfileOutput()
    {
      Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VolumeProfileOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr);
      VolumeProfileOutput.NativeFieldInfoPtr_AssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr, nameof (AssetReference));
      VolumeProfileOutput.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr, nameof (Importance));
      VolumeProfileOutput.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr, nameof (StartTime));
      VolumeProfileOutput.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr, nameof (Weight));
      VolumeProfileOutput.NativeFieldInfoPtr_FadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr, nameof (FadeInTime));
      VolumeProfileOutput.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr, nameof (FadeOutTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeProfileOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
