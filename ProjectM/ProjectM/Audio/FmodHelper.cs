// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.FmodHelper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  public static class FmodHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MasterBusGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_MusicBusGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmbienceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_MusicGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundEffectsGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerVoiceOverGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceOverGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UIEffectsGuid;

    static FmodHelper()
    {
      Il2CppClassPointerStore<FmodHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (FmodHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr);
      FmodHelper.NativeFieldInfoPtr_MasterBusGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr, nameof (MasterBusGuid));
      FmodHelper.NativeFieldInfoPtr_MusicBusGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr, nameof (MusicBusGuid));
      FmodHelper.NativeFieldInfoPtr_AmbienceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr, nameof (AmbienceGuid));
      FmodHelper.NativeFieldInfoPtr_MusicGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr, nameof (MusicGuid));
      FmodHelper.NativeFieldInfoPtr_SoundEffectsGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr, nameof (SoundEffectsGuid));
      FmodHelper.NativeFieldInfoPtr_PlayerVoiceOverGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr, nameof (PlayerVoiceOverGuid));
      FmodHelper.NativeFieldInfoPtr_VoiceOverGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr, nameof (VoiceOverGuid));
      FmodHelper.NativeFieldInfoPtr_UIEffectsGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FmodHelper>.NativeClassPtr, nameof (UIEffectsGuid));
    }

    public FmodHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Guid MasterBusGuid
    {
      get
      {
        Il2CppSystem.Guid masterBusGuid;
        IL2CPP.il2cpp_field_static_get_value(FmodHelper.NativeFieldInfoPtr_MasterBusGuid, (void*) &masterBusGuid);
        return masterBusGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FmodHelper.NativeFieldInfoPtr_MasterBusGuid, (void*) &value);
      }
    }

    public static unsafe Il2CppSystem.Guid MusicBusGuid
    {
      get
      {
        Il2CppSystem.Guid musicBusGuid;
        IL2CPP.il2cpp_field_static_get_value(FmodHelper.NativeFieldInfoPtr_MusicBusGuid, (void*) &musicBusGuid);
        return musicBusGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FmodHelper.NativeFieldInfoPtr_MusicBusGuid, (void*) &value);
      }
    }

    public static unsafe Il2CppSystem.Guid AmbienceGuid
    {
      get
      {
        Il2CppSystem.Guid ambienceGuid;
        IL2CPP.il2cpp_field_static_get_value(FmodHelper.NativeFieldInfoPtr_AmbienceGuid, (void*) &ambienceGuid);
        return ambienceGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FmodHelper.NativeFieldInfoPtr_AmbienceGuid, (void*) &value);
      }
    }

    public static unsafe Il2CppSystem.Guid MusicGuid
    {
      get
      {
        Il2CppSystem.Guid musicGuid;
        IL2CPP.il2cpp_field_static_get_value(FmodHelper.NativeFieldInfoPtr_MusicGuid, (void*) &musicGuid);
        return musicGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FmodHelper.NativeFieldInfoPtr_MusicGuid, (void*) &value);
      }
    }

    public static unsafe Il2CppSystem.Guid SoundEffectsGuid
    {
      get
      {
        Il2CppSystem.Guid soundEffectsGuid;
        IL2CPP.il2cpp_field_static_get_value(FmodHelper.NativeFieldInfoPtr_SoundEffectsGuid, (void*) &soundEffectsGuid);
        return soundEffectsGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FmodHelper.NativeFieldInfoPtr_SoundEffectsGuid, (void*) &value);
      }
    }

    public static unsafe Il2CppSystem.Guid PlayerVoiceOverGuid
    {
      get
      {
        Il2CppSystem.Guid playerVoiceOverGuid;
        IL2CPP.il2cpp_field_static_get_value(FmodHelper.NativeFieldInfoPtr_PlayerVoiceOverGuid, (void*) &playerVoiceOverGuid);
        return playerVoiceOverGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FmodHelper.NativeFieldInfoPtr_PlayerVoiceOverGuid, (void*) &value);
      }
    }

    public static unsafe Il2CppSystem.Guid VoiceOverGuid
    {
      get
      {
        Il2CppSystem.Guid voiceOverGuid;
        IL2CPP.il2cpp_field_static_get_value(FmodHelper.NativeFieldInfoPtr_VoiceOverGuid, (void*) &voiceOverGuid);
        return voiceOverGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FmodHelper.NativeFieldInfoPtr_VoiceOverGuid, (void*) &value);
      }
    }

    public static unsafe Il2CppSystem.Guid UIEffectsGuid
    {
      get
      {
        Il2CppSystem.Guid uiEffectsGuid;
        IL2CPP.il2cpp_field_static_get_value(FmodHelper.NativeFieldInfoPtr_UIEffectsGuid, (void*) &uiEffectsGuid);
        return uiEffectsGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FmodHelper.NativeFieldInfoPtr_UIEffectsGuid, (void*) &value);
      }
    }
  }
}
