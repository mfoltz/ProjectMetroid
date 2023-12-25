// Decompiled with JetBrains decompiler
// Type: ProjectM.SunBlocker.SunBlockerRegionAuthoring
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
namespace ProjectM.SunBlocker
{
  public class SunBlockerRegionAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_EditorColor;
    private static readonly IntPtr NativeMethodInfoPtr_GetPolygonDisplayColor_Public_Virtual_Final_New_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ColorPriority_Public_Virtual_Final_New_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Color GetPolygonDisplayColor()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SunBlockerRegionAuthoring.NativeMethodInfoPtr_GetPolygonDisplayColor_Public_Virtual_Final_New_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe int ColorPriority
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SunBlockerRegionAuthoring.NativeMethodInfoPtr_get_ColorPriority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114689, XrefRangeEnd = 1114691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SunBlockerRegionAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SunBlockerRegionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SunBlockerRegionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SunBlockerRegionAuthoring()
    {
      Il2CppClassPointerStore<SunBlockerRegionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.SunBlocker", nameof (SunBlockerRegionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunBlockerRegionAuthoring>.NativeClassPtr);
      SunBlockerRegionAuthoring.NativeFieldInfoPtr_EditorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunBlockerRegionAuthoring>.NativeClassPtr, nameof (EditorColor));
      SunBlockerRegionAuthoring.NativeMethodInfoPtr_GetPolygonDisplayColor_Public_Virtual_Final_New_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlockerRegionAuthoring>.NativeClassPtr, 100688242);
      SunBlockerRegionAuthoring.NativeMethodInfoPtr_get_ColorPriority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlockerRegionAuthoring>.NativeClassPtr, 100688243);
      SunBlockerRegionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlockerRegionAuthoring>.NativeClassPtr, 100688244);
    }

    public SunBlockerRegionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color EditorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SunBlockerRegionAuthoring.NativeFieldInfoPtr_EditorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SunBlockerRegionAuthoring.NativeFieldInfoPtr_EditorColor)) = value;
      }
    }
  }
}
