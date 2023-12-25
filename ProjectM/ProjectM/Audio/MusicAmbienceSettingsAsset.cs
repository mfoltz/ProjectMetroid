// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.MusicAmbienceSettingsAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Audio
{
  public class MusicAmbienceSettingsAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_MusicEvent;
    private static readonly IntPtr NativeFieldInfoPtr_AmbienceEvent;
    private static readonly IntPtr NativeFieldInfoPtr_MusicParameterName;
    private static readonly IntPtr NativeFieldInfoPtr_AmbienceParameterName;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MusicAmbienceSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicAmbienceSettingsAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicAmbienceSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MusicAmbienceSettingsAsset()
    {
      Il2CppClassPointerStore<MusicAmbienceSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (MusicAmbienceSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicAmbienceSettingsAsset>.NativeClassPtr);
      MusicAmbienceSettingsAsset.NativeFieldInfoPtr_MusicEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceSettingsAsset>.NativeClassPtr, nameof (MusicEvent));
      MusicAmbienceSettingsAsset.NativeFieldInfoPtr_AmbienceEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceSettingsAsset>.NativeClassPtr, nameof (AmbienceEvent));
      MusicAmbienceSettingsAsset.NativeFieldInfoPtr_MusicParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceSettingsAsset>.NativeClassPtr, nameof (MusicParameterName));
      MusicAmbienceSettingsAsset.NativeFieldInfoPtr_AmbienceParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceSettingsAsset>.NativeClassPtr, nameof (AmbienceParameterName));
      MusicAmbienceSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceSettingsAsset>.NativeClassPtr, 100690387);
    }

    public MusicAmbienceSettingsAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public FmodEvent MusicEvent
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSettingsAsset.NativeFieldInfoPtr_MusicEvent);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSettingsAsset.NativeFieldInfoPtr_MusicEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent AmbienceEvent
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSettingsAsset.NativeFieldInfoPtr_AmbienceEvent);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSettingsAsset.NativeFieldInfoPtr_AmbienceEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe string MusicParameterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSettingsAsset.NativeFieldInfoPtr_MusicParameterName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSettingsAsset.NativeFieldInfoPtr_MusicParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string AmbienceParameterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSettingsAsset.NativeFieldInfoPtr_AmbienceParameterName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSettingsAsset.NativeFieldInfoPtr_AmbienceParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
