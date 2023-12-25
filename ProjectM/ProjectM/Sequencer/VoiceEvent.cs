// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VoiceEvent
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
  public struct VoiceEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopWithSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoicePlayMode;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(8)]
    public PrefabGUID VoiceType;
    [FieldOffset(12)]
    public bool StopWithSequence;
    [FieldOffset(16)]
    public SoundPlayModeEnum VoicePlayMode;

    static VoiceEvent()
    {
      Il2CppClassPointerStore<VoiceEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VoiceEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceEvent>.NativeClassPtr);
      VoiceEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEvent>.NativeClassPtr, nameof (NodeIndex));
      VoiceEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEvent>.NativeClassPtr, nameof (TargetParameter));
      VoiceEvent.NativeFieldInfoPtr_VoiceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEvent>.NativeClassPtr, nameof (VoiceType));
      VoiceEvent.NativeFieldInfoPtr_StopWithSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEvent>.NativeClassPtr, nameof (StopWithSequence));
      VoiceEvent.NativeFieldInfoPtr_VoicePlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEvent>.NativeClassPtr, nameof (VoicePlayMode));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoiceEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
