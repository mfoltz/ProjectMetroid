// Decompiled with JetBrains decompiler
// Type: ProjectM.SoundSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class SoundSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Threaded;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableAllSounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableMusic;
    private static readonly System.IntPtr NativeFieldInfoPtr_MonoSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundInBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsePushToTalk;
    private static readonly System.IntPtr NativeFieldInfoPtr_VOIPAutojoin;
    private static readonly System.IntPtr NativeFieldInfoPtr_Driver;
    private static readonly System.IntPtr NativeFieldInfoPtr_MasterVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_MusicVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundEffectsVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmbienceVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceOverVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerVoiceOverVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_UIVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_VOIPVolume;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748679, RefRangeEnd = 748680, XrefRangeStart = 748675, XrefRangeEnd = 748679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SoundSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SoundSettings()
    {
      Il2CppClassPointerStore<SoundSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SoundSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr);
      SoundSettings.NativeFieldInfoPtr_Threaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (Threaded));
      SoundSettings.NativeFieldInfoPtr_DisableAllSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (DisableAllSounds));
      SoundSettings.NativeFieldInfoPtr_DisableMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (DisableMusic));
      SoundSettings.NativeFieldInfoPtr_MonoSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (MonoSound));
      SoundSettings.NativeFieldInfoPtr_SoundInBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (SoundInBackground));
      SoundSettings.NativeFieldInfoPtr_UsePushToTalk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (UsePushToTalk));
      SoundSettings.NativeFieldInfoPtr_VOIPAutojoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (VOIPAutojoin));
      SoundSettings.NativeFieldInfoPtr_Driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (Driver));
      SoundSettings.NativeFieldInfoPtr_MasterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (MasterVolume));
      SoundSettings.NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (MusicVolume));
      SoundSettings.NativeFieldInfoPtr_SoundEffectsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (SoundEffectsVolume));
      SoundSettings.NativeFieldInfoPtr_AmbienceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (AmbienceVolume));
      SoundSettings.NativeFieldInfoPtr_VoiceOverVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (VoiceOverVolume));
      SoundSettings.NativeFieldInfoPtr_PlayerVoiceOverVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (PlayerVoiceOverVolume));
      SoundSettings.NativeFieldInfoPtr_UIVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (UIVolume));
      SoundSettings.NativeFieldInfoPtr_VOIPVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, nameof (VOIPVolume));
      SoundSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, 100665916);
    }

    public SoundSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Threaded
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_Threaded));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_Threaded)) = value;
      }
    }

    public unsafe bool DisableAllSounds
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_DisableAllSounds));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_DisableAllSounds)) = value;
      }
    }

    public unsafe bool DisableMusic
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_DisableMusic));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_DisableMusic)) = value;
      }
    }

    public unsafe bool MonoSound
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_MonoSound));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_MonoSound)) = value;
      }
    }

    public unsafe bool SoundInBackground
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_SoundInBackground));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_SoundInBackground)) = value;
      }
    }

    public unsafe bool UsePushToTalk
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_UsePushToTalk));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_UsePushToTalk)) = value;
      }
    }

    public unsafe bool VOIPAutojoin
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_VOIPAutojoin));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_VOIPAutojoin)) = value;
      }
    }

    public unsafe string Driver
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_Driver)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_Driver), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float MasterVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_MasterVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_MasterVolume)) = value;
      }
    }

    public unsafe float MusicVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_MusicVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_MusicVolume)) = value;
      }
    }

    public unsafe float SoundEffectsVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_SoundEffectsVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_SoundEffectsVolume)) = value;
      }
    }

    public unsafe float AmbienceVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_AmbienceVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_AmbienceVolume)) = value;
      }
    }

    public unsafe float VoiceOverVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_VoiceOverVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_VoiceOverVolume)) = value;
      }
    }

    public unsafe float PlayerVoiceOverVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_PlayerVoiceOverVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_PlayerVoiceOverVolume)) = value;
      }
    }

    public unsafe float UIVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_UIVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_UIVolume)) = value;
      }
    }

    public unsafe float VOIPVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_VOIPVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundSettings.NativeFieldInfoPtr_VOIPVolume)) = value;
      }
    }
  }
}
