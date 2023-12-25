// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Presentation_ProxyVFXGradient_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Presentation;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Presentation_ProxyVFXGradient_PropertyBag : 
    ContainerPropertyBag<ProxyVFXGradient>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172096, XrefRangeEnd = 1172129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Presentation_ProxyVFXGradient_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXGradient_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Presentation_ProxyVFXGradient_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_Presentation_ProxyVFXGradient_PropertyBag));
      ProjectM_Presentation_ProxyVFXGradient_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag>.NativeClassPtr, 100693539);
    }

    public ProjectM_Presentation_ProxyVFXGradient_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class colorKeys_Property : Property<ProxyVFXGradient, Il2CppStructArray<GradientColorKey>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_GradientColorKey_byref_ProxyVFXGradient_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_Il2CppStructArray_1_GradientColorKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172075, XrefRangeEnd = 1172077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172080, RefRangeEnd = 1172082, XrefRangeStart = 1172077, XrefRangeEnd = 1172080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe colorKeys_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppStructArray<GradientColorKey> GetValue(
        ref ProxyVFXGradient container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_GradientColorKey_byref_ProxyVFXGradient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<GradientColorKey>) null : new Il2CppStructArray<GradientColorKey>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ProxyVFXGradient container,
        Il2CppStructArray<GradientColorKey> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_Il2CppStructArray_1_GradientColorKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static colorKeys_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag>.NativeClassPtr, nameof (colorKeys_Property));
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property>.NativeClassPtr, 100693540);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property>.NativeClassPtr, 100693541);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property>.NativeClassPtr, 100693542);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_GradientColorKey_byref_ProxyVFXGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property>.NativeClassPtr, 100693543);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_Il2CppStructArray_1_GradientColorKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.colorKeys_Property>.NativeClassPtr, 100693544);
      }

      public colorKeys_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class alphaKeys_Property : Property<ProxyVFXGradient, Il2CppStructArray<GradientAlphaKey>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_GradientAlphaKey_byref_ProxyVFXGradient_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_Il2CppStructArray_1_GradientAlphaKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172082, XrefRangeEnd = 1172084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172087, RefRangeEnd = 1172089, XrefRangeStart = 1172084, XrefRangeEnd = 1172087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe alphaKeys_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppStructArray<GradientAlphaKey> GetValue(
        ref ProxyVFXGradient container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_GradientAlphaKey_byref_ProxyVFXGradient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<GradientAlphaKey>) null : new Il2CppStructArray<GradientAlphaKey>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ProxyVFXGradient container,
        Il2CppStructArray<GradientAlphaKey> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_Il2CppStructArray_1_GradientAlphaKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static alphaKeys_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag>.NativeClassPtr, nameof (alphaKeys_Property));
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property>.NativeClassPtr, 100693545);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property>.NativeClassPtr, 100693546);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property>.NativeClassPtr, 100693547);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_GradientAlphaKey_byref_ProxyVFXGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property>.NativeClassPtr, 100693548);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_Il2CppStructArray_1_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.alphaKeys_Property>.NativeClassPtr, 100693549);
      }

      public alphaKeys_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class mode_Property : Property<ProxyVFXGradient, GradientMode>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GradientMode_byref_ProxyVFXGradient_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_GradientMode_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172089, XrefRangeEnd = 1172091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172094, RefRangeEnd = 1172096, XrefRangeStart = 1172091, XrefRangeEnd = 1172094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe mode_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GradientMode GetValue(ref ProxyVFXGradient container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GradientMode_byref_ProxyVFXGradient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GradientMode*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyVFXGradient container, GradientMode value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_GradientMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static mode_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag>.NativeClassPtr, nameof (mode_Property));
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property>.NativeClassPtr, 100693550);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property>.NativeClassPtr, 100693551);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property>.NativeClassPtr, 100693552);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GradientMode_byref_ProxyVFXGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property>.NativeClassPtr, 100693553);
        ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXGradient_GradientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXGradient_PropertyBag.mode_Property>.NativeClassPtr, 100693554);
      }

      public mode_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
