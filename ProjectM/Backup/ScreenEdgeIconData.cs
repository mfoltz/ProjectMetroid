// Decompiled with JetBrains decompiler
// Type: ScreenEdgeIconData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ScreenEdgeIconData : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_Icon;
  private static readonly IntPtr NativeFieldInfoPtr_ShowArrow;
  private static readonly IntPtr NativeFieldInfoPtr_ShowDistance;
  private static readonly IntPtr NativeFieldInfoPtr_HideDistanceWhenClose;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScreenEdgeIconData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenEdgeIconData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScreenEdgeIconData()
  {
    Il2CppClassPointerStore<ScreenEdgeIconData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ScreenEdgeIconData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenEdgeIconData>.NativeClassPtr);
    ScreenEdgeIconData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconData>.NativeClassPtr, nameof (Icon));
    ScreenEdgeIconData.NativeFieldInfoPtr_ShowArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconData>.NativeClassPtr, nameof (ShowArrow));
    ScreenEdgeIconData.NativeFieldInfoPtr_ShowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconData>.NativeClassPtr, nameof (ShowDistance));
    ScreenEdgeIconData.NativeFieldInfoPtr_HideDistanceWhenClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconData>.NativeClassPtr, nameof (HideDistanceWhenClose));
    ScreenEdgeIconData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconData>.NativeClassPtr, 100663331);
  }

  public ScreenEdgeIconData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Sprite Icon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconData.NativeFieldInfoPtr_Icon));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool ShowArrow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconData.NativeFieldInfoPtr_ShowArrow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconData.NativeFieldInfoPtr_ShowArrow)) = value;
    }
  }

  public unsafe bool ShowDistance
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconData.NativeFieldInfoPtr_ShowDistance));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconData.NativeFieldInfoPtr_ShowDistance)) = value;
    }
  }

  public unsafe bool HideDistanceWhenClose
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconData.NativeFieldInfoPtr_HideDistanceWhenClose));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconData.NativeFieldInfoPtr_HideDistanceWhenClose)) = value;
    }
  }
}
