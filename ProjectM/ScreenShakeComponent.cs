﻿// Decompiled with JetBrains decompiler
// Type: ScreenShakeComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ScreenShakeComponent : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_Settings;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScreenShakeComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenShakeComponent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenShakeComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScreenShakeComponent()
  {
    Il2CppClassPointerStore<ScreenShakeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ScreenShakeComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenShakeComponent>.NativeClassPtr);
    ScreenShakeComponent.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeComponent>.NativeClassPtr, nameof (Settings));
    ScreenShakeComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeComponent>.NativeClassPtr, 100663647);
  }

  public ScreenShakeComponent(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ScreenShakeSettings Settings
  {
    get
    {
      return *(ScreenShakeSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeComponent.NativeFieldInfoPtr_Settings));
    }
    [param: In] set
    {
      *(ScreenShakeSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeComponent.NativeFieldInfoPtr_Settings)) = value;
    }
  }
}
