// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.MoodManagerComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Presentation
{
  public class MoodManagerComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MainLight;
    private static readonly IntPtr NativeFieldInfoPtr_GlobalVolumeLayer1;
    private static readonly IntPtr NativeFieldInfoPtr_Default;
    private static readonly IntPtr NativeFieldInfoPtr_CastleIndoorMood;
    private static readonly IntPtr NativeFieldInfoPtr_FlyModeMood;
    private static readonly IntPtr NativeFieldInfoPtr_FlyModeMaxWeight;
    private static readonly IntPtr NativeFieldInfoPtr_Instance;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetMoodProfile_Public_Void_VolumeProfile_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112462, XrefRangeEnd = 1112480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodManagerComponent.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112480, XrefRangeEnd = 1112483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodManagerComponent.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112483, XrefRangeEnd = 1112486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodManagerComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112486, XrefRangeEnd = 1112488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMoodProfile(VolumeProfile volumeProfile)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeProfile);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodManagerComponent.NativeMethodInfoPtr_SetMoodProfile_Public_Void_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112488, XrefRangeEnd = 1112489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoodManagerComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodManagerComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoodManagerComponent()
    {
      Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (MoodManagerComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr);
      MoodManagerComponent.NativeFieldInfoPtr_MainLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, nameof (MainLight));
      MoodManagerComponent.NativeFieldInfoPtr_GlobalVolumeLayer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, nameof (GlobalVolumeLayer1));
      MoodManagerComponent.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, nameof (Default));
      MoodManagerComponent.NativeFieldInfoPtr_CastleIndoorMood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, nameof (CastleIndoorMood));
      MoodManagerComponent.NativeFieldInfoPtr_FlyModeMood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, nameof (FlyModeMood));
      MoodManagerComponent.NativeFieldInfoPtr_FlyModeMaxWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, nameof (FlyModeMaxWeight));
      MoodManagerComponent.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, nameof (Instance));
      MoodManagerComponent.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, 100688072);
      MoodManagerComponent.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, 100688073);
      MoodManagerComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, 100688074);
      MoodManagerComponent.NativeMethodInfoPtr_SetMoodProfile_Public_Void_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, 100688075);
      MoodManagerComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodManagerComponent>.NativeClassPtr, 100688076);
    }

    public MoodManagerComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Light MainLight
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_MainLight));
        return pointer == IntPtr.Zero ? (Light) null : new Light(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_MainLight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Volume GlobalVolumeLayer1
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_GlobalVolumeLayer1));
        return pointer == IntPtr.Zero ? (Volume) null : new Volume(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_GlobalVolumeLayer1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MoodSetting Default
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_Default));
        return pointer == IntPtr.Zero ? (MoodSetting) null : new MoodSetting(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_Default), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MoodSetting CastleIndoorMood
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_CastleIndoorMood));
        return pointer == IntPtr.Zero ? (MoodSetting) null : new MoodSetting(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_CastleIndoorMood), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MoodSetting FlyModeMood
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_FlyModeMood));
        return pointer == IntPtr.Zero ? (MoodSetting) null : new MoodSetting(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_FlyModeMood), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float FlyModeMaxWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_FlyModeMaxWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodManagerComponent.NativeFieldInfoPtr_FlyModeMaxWeight)) = value;
      }
    }

    public static unsafe MoodManagerComponent Instance
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MoodManagerComponent.NativeFieldInfoPtr_Instance, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (MoodManagerComponent) null : new MoodManagerComponent(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MoodManagerComponent.NativeFieldInfoPtr_Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
