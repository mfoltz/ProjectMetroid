// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VoiceInstance
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using FMOD.Studio;
using Il2CppInterop.Runtime;
using ProjectM.Audio;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VoiceInstance
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopModeEnum;
    [FieldOffset(0)]
    public EventInstance EventInstance;
    [FieldOffset(8)]
    public StudioEventStopModeEnum StopModeEnum;

    static VoiceInstance()
    {
      Il2CppClassPointerStore<VoiceInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VoiceInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceInstance>.NativeClassPtr);
      VoiceInstance.NativeFieldInfoPtr_EventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceInstance>.NativeClassPtr, nameof (EventInstance));
      VoiceInstance.NativeFieldInfoPtr_StopModeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceInstance>.NativeClassPtr, nameof (StopModeEnum));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoiceInstance>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
