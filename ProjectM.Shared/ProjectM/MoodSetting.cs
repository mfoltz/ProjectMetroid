// Decompiled with JetBrains decompiler
// Type: ProjectM.MoodSetting
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM
{
  public class MoodSetting : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_MoodFeatures;
    private static readonly IntPtr NativeFieldInfoPtr_UseAdditionalOverrides;
    private static readonly IntPtr NativeFieldInfoPtr_Importance;
    private static readonly IntPtr NativeFieldInfoPtr_MorningProfile;
    private static readonly IntPtr NativeFieldInfoPtr_MorningProfileOverride;
    private static readonly IntPtr NativeFieldInfoPtr_DayProfile;
    private static readonly IntPtr NativeFieldInfoPtr_DayProfileOverride;
    private static readonly IntPtr NativeFieldInfoPtr_EveningProfile;
    private static readonly IntPtr NativeFieldInfoPtr_EveningProfileOverride;
    private static readonly IntPtr NativeFieldInfoPtr_NightProfile;
    private static readonly IntPtr NativeFieldInfoPtr_NightProfileOverride;
    private static readonly IntPtr NativeFieldInfoPtr_PreviewColor;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746943, XrefRangeEnd = 746945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoodSetting()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoodSetting()
    {
      Il2CppClassPointerStore<MoodSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MoodSetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr);
      MoodSetting.NativeFieldInfoPtr_MoodFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (MoodFeatures));
      MoodSetting.NativeFieldInfoPtr_UseAdditionalOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (UseAdditionalOverrides));
      MoodSetting.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (Importance));
      MoodSetting.NativeFieldInfoPtr_MorningProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (MorningProfile));
      MoodSetting.NativeFieldInfoPtr_MorningProfileOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (MorningProfileOverride));
      MoodSetting.NativeFieldInfoPtr_DayProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (DayProfile));
      MoodSetting.NativeFieldInfoPtr_DayProfileOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (DayProfileOverride));
      MoodSetting.NativeFieldInfoPtr_EveningProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (EveningProfile));
      MoodSetting.NativeFieldInfoPtr_EveningProfileOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (EveningProfileOverride));
      MoodSetting.NativeFieldInfoPtr_NightProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (NightProfile));
      MoodSetting.NativeFieldInfoPtr_NightProfileOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (NightProfileOverride));
      MoodSetting.NativeFieldInfoPtr_PreviewColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, nameof (PreviewColor));
      MoodSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodSetting>.NativeClassPtr, 100665759);
    }

    public MoodSetting(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MoodSetting.MoodFeaturesEnum MoodFeatures
    {
      get
      {
        return *(MoodSetting.MoodFeaturesEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_MoodFeatures));
      }
      [param: In] set
      {
        *(MoodSetting.MoodFeaturesEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_MoodFeatures)) = value;
      }
    }

    public unsafe bool UseAdditionalOverrides
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_UseAdditionalOverrides));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_UseAdditionalOverrides)) = value;
      }
    }

    public unsafe int Importance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_Importance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_Importance)) = value;
      }
    }

    public unsafe VolumeProfile MorningProfile
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_MorningProfile));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_MorningProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VolumeProfile MorningProfileOverride
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_MorningProfileOverride));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_MorningProfileOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VolumeProfile DayProfile
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_DayProfile));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_DayProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VolumeProfile DayProfileOverride
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_DayProfileOverride));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_DayProfileOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VolumeProfile EveningProfile
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_EveningProfile));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_EveningProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VolumeProfile EveningProfileOverride
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_EveningProfileOverride));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_EveningProfileOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VolumeProfile NightProfile
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_NightProfile));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_NightProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VolumeProfile NightProfileOverride
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_NightProfileOverride));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_NightProfileOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color PreviewColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_PreviewColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodSetting.NativeFieldInfoPtr_PreviewColor)) = value;
      }
    }

    public enum MoodFeaturesEnum
    {
      DayOnly,
      All,
      DayAndNight,
    }
  }
}
