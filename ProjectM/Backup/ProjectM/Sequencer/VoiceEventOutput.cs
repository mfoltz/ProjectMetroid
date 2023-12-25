// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VoiceEventOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VoiceEventOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopWithSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFrameOutputIndex;
    [FieldOffset(0)]
    public Entity TargetEntity;
    [FieldOffset(8)]
    public PrefabGUID VoiceType;
    [FieldOffset(12)]
    public bool StopWithSequence;
    [FieldOffset(16)]
    public int LastFrameOutputIndex;

    static VoiceEventOutput()
    {
      Il2CppClassPointerStore<VoiceEventOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VoiceEventOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceEventOutput>.NativeClassPtr);
      VoiceEventOutput.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEventOutput>.NativeClassPtr, nameof (TargetEntity));
      VoiceEventOutput.NativeFieldInfoPtr_VoiceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEventOutput>.NativeClassPtr, nameof (VoiceType));
      VoiceEventOutput.NativeFieldInfoPtr_StopWithSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEventOutput>.NativeClassPtr, nameof (StopWithSequence));
      VoiceEventOutput.NativeFieldInfoPtr_LastFrameOutputIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEventOutput>.NativeClassPtr, nameof (LastFrameOutputIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoiceEventOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
