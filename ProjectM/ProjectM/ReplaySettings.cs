// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaySettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ReplaySettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_SETTINGS_PATH;
    private static readonly IntPtr NativeFieldInfoPtr_Path;
    private static readonly IntPtr NativeFieldInfoPtr_Width;
    private static readonly IntPtr NativeFieldInfoPtr_Height;
    private static readonly IntPtr NativeFieldInfoPtr_Framerate;
    private static readonly IntPtr NativeFieldInfoPtr_VideoBitrate;
    private static readonly IntPtr NativeFieldInfoPtr_EncodeAudio;
    private static readonly IntPtr NativeFieldInfoPtr_AudioBitrate;
    private static readonly IntPtr NativeFieldInfoPtr_Uncompressed;
    private static readonly IntPtr NativeFieldInfoPtr_VideoLength;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078021, XrefRangeEnd = 1078026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplaySettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplaySettings()
    {
      Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ReplaySettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr);
      ReplaySettings.NativeFieldInfoPtr_SETTINGS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (SETTINGS_PATH));
      ReplaySettings.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (Path));
      ReplaySettings.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (Width));
      ReplaySettings.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (Height));
      ReplaySettings.NativeFieldInfoPtr_Framerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (Framerate));
      ReplaySettings.NativeFieldInfoPtr_VideoBitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (VideoBitrate));
      ReplaySettings.NativeFieldInfoPtr_EncodeAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (EncodeAudio));
      ReplaySettings.NativeFieldInfoPtr_AudioBitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (AudioBitrate));
      ReplaySettings.NativeFieldInfoPtr_Uncompressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (Uncompressed));
      ReplaySettings.NativeFieldInfoPtr_VideoLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, nameof (VideoLength));
      ReplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaySettings>.NativeClassPtr, 100684906);
    }

    public ReplaySettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string SETTINGS_PATH
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplaySettings.NativeFieldInfoPtr_SETTINGS_PATH, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplaySettings.NativeFieldInfoPtr_SETTINGS_PATH, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Path
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Path)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int Width
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Width));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Width)) = value;
      }
    }

    public unsafe int Height
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Height));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Height)) = value;
      }
    }

    public unsafe int Framerate
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Framerate));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Framerate)) = value;
      }
    }

    public unsafe int VideoBitrate
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_VideoBitrate));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_VideoBitrate)) = value;
      }
    }

    public unsafe bool EncodeAudio
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_EncodeAudio));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_EncodeAudio)) = value;
      }
    }

    public unsafe int AudioBitrate
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_AudioBitrate));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_AudioBitrate)) = value;
      }
    }

    public unsafe bool Uncompressed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Uncompressed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_Uncompressed)) = value;
      }
    }

    public unsafe float VideoLength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_VideoLength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaySettings.NativeFieldInfoPtr_VideoLength)) = value;
      }
    }
  }
}
