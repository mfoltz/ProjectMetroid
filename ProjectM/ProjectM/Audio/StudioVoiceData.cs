// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StudioVoiceData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StudioVoiceData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VoicePriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_FmodEventGuid;
    [FieldOffset(0)]
    public int VoicePriority;
    [FieldOffset(4)]
    public FmodEventGuid FmodEventGuid;

    static StudioVoiceData()
    {
      Il2CppClassPointerStore<StudioVoiceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StudioVoiceData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioVoiceData>.NativeClassPtr);
      StudioVoiceData.NativeFieldInfoPtr_VoicePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioVoiceData>.NativeClassPtr, nameof (VoicePriority));
      StudioVoiceData.NativeFieldInfoPtr_FmodEventGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioVoiceData>.NativeClassPtr, nameof (FmodEventGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioVoiceData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
