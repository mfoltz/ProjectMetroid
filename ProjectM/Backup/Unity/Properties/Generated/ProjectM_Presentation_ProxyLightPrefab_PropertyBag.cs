// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Presentation_ProxyLightPrefab_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Presentation;
using System;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Presentation_ProxyLightPrefab_PropertyBag : 
    ContainerPropertyBag<ProxyLightPrefab>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1171620, RefRangeEnd = 1171621, XrefRangeStart = 1171537, XrefRangeEnd = 1171620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Presentation_ProxyLightPrefab_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Presentation_ProxyLightPrefab_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_Presentation_ProxyLightPrefab_PropertyBag));
      ProjectM_Presentation_ProxyLightPrefab_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, 100693342);
    }

    public ProjectM_Presentation_ProxyLightPrefab_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class color_Property : Property<ProxyLightPrefab, Color>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Color_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171465, XrefRangeEnd = 1171467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171470, RefRangeEnd = 1171471, XrefRangeStart = 1171467, XrefRangeEnd = 1171470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe color_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Color GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(Color*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, Color value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static color_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (color_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property>.NativeClassPtr, 100693343);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property>.NativeClassPtr, 100693344);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property>.NativeClassPtr, 100693345);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property>.NativeClassPtr, 100693346);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.color_Property>.NativeClassPtr, 100693347);
      }

      public color_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class range_Property : Property<ProxyLightPrefab, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171471, XrefRangeEnd = 1171473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171476, RefRangeEnd = 1171477, XrefRangeStart = 1171473, XrefRangeEnd = 1171476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe range_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static range_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (range_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property>.NativeClassPtr, 100693348);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property>.NativeClassPtr, 100693349);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property>.NativeClassPtr, 100693350);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property>.NativeClassPtr, 100693351);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.range_Property>.NativeClassPtr, 100693352);
      }

      public range_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class intensity_Property : Property<ProxyLightPrefab, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171477, XrefRangeEnd = 1171479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171482, RefRangeEnd = 1171483, XrefRangeStart = 1171479, XrefRangeEnd = 1171482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe intensity_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static intensity_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (intensity_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property>.NativeClassPtr, 100693353);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property>.NativeClassPtr, 100693354);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property>.NativeClassPtr, 100693355);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property>.NativeClassPtr, 100693356);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.intensity_Property>.NativeClassPtr, 100693357);
      }

      public intensity_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class cookie_Property : Property<ProxyLightPrefab, Texture>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Texture_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Texture_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171483, XrefRangeEnd = 1171485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171488, RefRangeEnd = 1171489, XrefRangeStart = 1171485, XrefRangeEnd = 1171488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe cookie_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Texture GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Texture_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer1 = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer1 == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer1);
        local = proxyLightPrefab;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Texture) null : new Texture(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, Texture value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static cookie_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (cookie_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property>.NativeClassPtr, 100693358);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property>.NativeClassPtr, 100693359);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property>.NativeClassPtr, 100693360);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Texture_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property>.NativeClassPtr, 100693361);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.cookie_Property>.NativeClassPtr, 100693362);
      }

      public cookie_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class spotLightShape_Property : Property<ProxyLightPrefab, SpotLightShape>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_SpotLightShape_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_SpotLightShape_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171489, XrefRangeEnd = 1171491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171494, RefRangeEnd = 1171495, XrefRangeStart = 1171491, XrefRangeEnd = 1171494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe spotLightShape_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe SpotLightShape GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_SpotLightShape_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(SpotLightShape*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, SpotLightShape value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_SpotLightShape_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static spotLightShape_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (spotLightShape_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property>.NativeClassPtr, 100693363);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property>.NativeClassPtr, 100693364);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property>.NativeClassPtr, 100693365);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_SpotLightShape_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property>.NativeClassPtr, 100693366);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_SpotLightShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotLightShape_Property>.NativeClassPtr, 100693367);
      }

      public spotLightShape_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class shapeRadius_Property : Property<ProxyLightPrefab, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171495, XrefRangeEnd = 1171497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171500, RefRangeEnd = 1171501, XrefRangeStart = 1171497, XrefRangeEnd = 1171500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe shapeRadius_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static shapeRadius_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (shapeRadius_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property>.NativeClassPtr, 100693368);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property>.NativeClassPtr, 100693369);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property>.NativeClassPtr, 100693370);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property>.NativeClassPtr, 100693371);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeRadius_Property>.NativeClassPtr, 100693372);
      }

      public shapeRadius_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class spotAngle_Property : Property<ProxyLightPrefab, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171501, XrefRangeEnd = 1171503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171506, RefRangeEnd = 1171507, XrefRangeStart = 1171503, XrefRangeEnd = 1171506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe spotAngle_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static spotAngle_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (spotAngle_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property>.NativeClassPtr, 100693373);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property>.NativeClassPtr, 100693374);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property>.NativeClassPtr, 100693375);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property>.NativeClassPtr, 100693376);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.spotAngle_Property>.NativeClassPtr, 100693377);
      }

      public spotAngle_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class innerSpotPercent_Property : Property<ProxyLightPrefab, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171507, XrefRangeEnd = 1171509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171512, RefRangeEnd = 1171513, XrefRangeStart = 1171509, XrefRangeEnd = 1171512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe innerSpotPercent_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static innerSpotPercent_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (innerSpotPercent_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property>.NativeClassPtr, 100693378);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property>.NativeClassPtr, 100693379);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property>.NativeClassPtr, 100693380);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property>.NativeClassPtr, 100693381);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.innerSpotPercent_Property>.NativeClassPtr, 100693382);
      }

      public innerSpotPercent_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class aspectRatio_Property : Property<ProxyLightPrefab, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171513, XrefRangeEnd = 1171515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171518, RefRangeEnd = 1171519, XrefRangeStart = 1171515, XrefRangeEnd = 1171518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe aspectRatio_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static aspectRatio_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (aspectRatio_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property>.NativeClassPtr, 100693383);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property>.NativeClassPtr, 100693384);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property>.NativeClassPtr, 100693385);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property>.NativeClassPtr, 100693386);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.aspectRatio_Property>.NativeClassPtr, 100693387);
      }

      public aspectRatio_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class shapeWidth_Property : Property<ProxyLightPrefab, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171519, XrefRangeEnd = 1171521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171524, RefRangeEnd = 1171525, XrefRangeStart = 1171521, XrefRangeEnd = 1171524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe shapeWidth_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static shapeWidth_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (shapeWidth_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property>.NativeClassPtr, 100693388);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property>.NativeClassPtr, 100693389);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property>.NativeClassPtr, 100693390);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property>.NativeClassPtr, 100693391);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeWidth_Property>.NativeClassPtr, 100693392);
      }

      public shapeWidth_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class shapeHeight_Property : Property<ProxyLightPrefab, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171525, XrefRangeEnd = 1171527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171530, RefRangeEnd = 1171531, XrefRangeStart = 1171527, XrefRangeEnd = 1171530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe shapeHeight_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static shapeHeight_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (shapeHeight_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property>.NativeClassPtr, 100693393);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property>.NativeClassPtr, 100693394);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property>.NativeClassPtr, 100693395);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property>.NativeClassPtr, 100693396);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.shapeHeight_Property>.NativeClassPtr, 100693397);
      }

      public shapeHeight_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class type_Property : Property<ProxyLightPrefab, HDLightType>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_HDLightType_byref_ProxyLightPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_HDLightType_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171531, XrefRangeEnd = 1171533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171536, RefRangeEnd = 1171537, XrefRangeStart = 1171533, XrefRangeEnd = 1171536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe type_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe HDLightType GetValue(ref ProxyLightPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_HDLightType_byref_ProxyLightPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
        return *(HDLightType*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ProxyLightPrefab container, HDLightType value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_HDLightType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyLightPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyLightPrefab proxyLightPrefab = pointer == IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
        local = proxyLightPrefab;
      }

      static type_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag>.NativeClassPtr, nameof (type_Property));
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property>.NativeClassPtr, 100693398);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property>.NativeClassPtr, 100693399);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property>.NativeClassPtr, 100693400);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_HDLightType_byref_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property>.NativeClassPtr, 100693401);
        ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyLightPrefab_HDLightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyLightPrefab_PropertyBag.type_Property>.NativeClassPtr, 100693402);
      }

      public type_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
