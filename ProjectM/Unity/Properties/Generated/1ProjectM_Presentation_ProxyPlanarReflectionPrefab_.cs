// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag
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
  public class ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag : 
    ContainerPropertyBag<ProxyPlanarReflectionPrefab.InfluenceVolumeData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1171838, RefRangeEnd = 1171839, XrefRangeStart = 1171763, XrefRangeEnd = 1171838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag));
      ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, 100693430);
    }

    public ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag(
      IntPtr pointer)
      : base(pointer)
    {
    }

    public class m_Shape_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, InfluenceShape>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_InfluenceShape_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_InfluenceShape_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171697, XrefRangeEnd = 1171699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171702, RefRangeEnd = 1171703, XrefRangeStart = 1171699, XrefRangeEnd = 1171702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_Shape_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe InfluenceShape GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_InfluenceShape_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(InfluenceShape*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        InfluenceShape value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_InfluenceShape_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_Shape_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_Shape_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property>.NativeClassPtr, 100693431);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property>.NativeClassPtr, 100693432);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property>.NativeClassPtr, 100693433);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_InfluenceShape_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property>.NativeClassPtr, 100693434);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_InfluenceShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_Shape_Property>.NativeClassPtr, 100693435);
      }

      public m_Shape_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_BoxSize_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, Vector3>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171703, XrefRangeEnd = 1171705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171708, RefRangeEnd = 1171709, XrefRangeStart = 1171705, XrefRangeEnd = 1171708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_BoxSize_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector3 GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        Vector3 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_BoxSize_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_BoxSize_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property>.NativeClassPtr, 100693436);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property>.NativeClassPtr, 100693437);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property>.NativeClassPtr, 100693438);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property>.NativeClassPtr, 100693439);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSize_Property>.NativeClassPtr, 100693440);
      }

      public m_BoxSize_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_BoxBlendDistancePositive_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, Vector3>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171709, XrefRangeEnd = 1171711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171714, RefRangeEnd = 1171715, XrefRangeStart = 1171711, XrefRangeEnd = 1171714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_BoxBlendDistancePositive_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector3 GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        Vector3 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_BoxBlendDistancePositive_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_BoxBlendDistancePositive_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property>.NativeClassPtr, 100693441);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property>.NativeClassPtr, 100693442);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property>.NativeClassPtr, 100693443);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property>.NativeClassPtr, 100693444);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistancePositive_Property>.NativeClassPtr, 100693445);
      }

      public m_BoxBlendDistancePositive_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_BoxBlendDistanceNegative_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, Vector3>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171715, XrefRangeEnd = 1171717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171720, RefRangeEnd = 1171721, XrefRangeStart = 1171717, XrefRangeEnd = 1171720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_BoxBlendDistanceNegative_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector3 GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        Vector3 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_BoxBlendDistanceNegative_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_BoxBlendDistanceNegative_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property>.NativeClassPtr, 100693446);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property>.NativeClassPtr, 100693447);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property>.NativeClassPtr, 100693448);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property>.NativeClassPtr, 100693449);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendDistanceNegative_Property>.NativeClassPtr, 100693450);
      }

      public m_BoxBlendDistanceNegative_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_BoxBlendNormalDistancePositive_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, Vector3>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171721, XrefRangeEnd = 1171723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171726, RefRangeEnd = 1171727, XrefRangeStart = 1171723, XrefRangeEnd = 1171726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_BoxBlendNormalDistancePositive_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector3 GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        Vector3 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_BoxBlendNormalDistancePositive_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_BoxBlendNormalDistancePositive_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property>.NativeClassPtr, 100693451);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property>.NativeClassPtr, 100693452);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property>.NativeClassPtr, 100693453);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property>.NativeClassPtr, 100693454);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistancePositive_Property>.NativeClassPtr, 100693455);
      }

      public m_BoxBlendNormalDistancePositive_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_BoxBlendNormalDistanceNegative_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, Vector3>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171727, XrefRangeEnd = 1171729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171732, RefRangeEnd = 1171733, XrefRangeStart = 1171729, XrefRangeEnd = 1171732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_BoxBlendNormalDistanceNegative_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector3 GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        Vector3 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_BoxBlendNormalDistanceNegative_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_BoxBlendNormalDistanceNegative_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property>.NativeClassPtr, 100693456);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property>.NativeClassPtr, 100693457);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property>.NativeClassPtr, 100693458);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property>.NativeClassPtr, 100693459);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxBlendNormalDistanceNegative_Property>.NativeClassPtr, 100693460);
      }

      public m_BoxBlendNormalDistanceNegative_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_BoxSideFadePositive_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, Vector3>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171733, XrefRangeEnd = 1171735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171738, RefRangeEnd = 1171739, XrefRangeStart = 1171735, XrefRangeEnd = 1171738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_BoxSideFadePositive_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector3 GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        Vector3 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_BoxSideFadePositive_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_BoxSideFadePositive_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property>.NativeClassPtr, 100693461);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property>.NativeClassPtr, 100693462);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property>.NativeClassPtr, 100693463);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property>.NativeClassPtr, 100693464);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadePositive_Property>.NativeClassPtr, 100693465);
      }

      public m_BoxSideFadePositive_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_BoxSideFadeNegative_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, Vector3>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171739, XrefRangeEnd = 1171741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171744, RefRangeEnd = 1171745, XrefRangeStart = 1171741, XrefRangeEnd = 1171744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_BoxSideFadeNegative_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector3 GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        Vector3 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_BoxSideFadeNegative_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_BoxSideFadeNegative_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property>.NativeClassPtr, 100693466);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property>.NativeClassPtr, 100693467);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property>.NativeClassPtr, 100693468);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector3_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property>.NativeClassPtr, 100693469);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_BoxSideFadeNegative_Property>.NativeClassPtr, 100693470);
      }

      public m_BoxSideFadeNegative_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_SphereRadius_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171745, XrefRangeEnd = 1171747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171750, RefRangeEnd = 1171751, XrefRangeStart = 1171747, XrefRangeEnd = 1171750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_SphereRadius_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_SphereRadius_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_SphereRadius_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property>.NativeClassPtr, 100693471);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property>.NativeClassPtr, 100693472);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property>.NativeClassPtr, 100693473);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property>.NativeClassPtr, 100693474);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereRadius_Property>.NativeClassPtr, 100693475);
      }

      public m_SphereRadius_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_SphereBlendDistance_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171751, XrefRangeEnd = 1171753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171756, RefRangeEnd = 1171757, XrefRangeStart = 1171753, XrefRangeEnd = 1171756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_SphereBlendDistance_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_SphereBlendDistance_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_SphereBlendDistance_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property>.NativeClassPtr, 100693476);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property>.NativeClassPtr, 100693477);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property>.NativeClassPtr, 100693478);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property>.NativeClassPtr, 100693479);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendDistance_Property>.NativeClassPtr, 100693480);
      }

      public m_SphereBlendDistance_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class m_SphereBlendNormalDistance_Property : 
      Property<ProxyPlanarReflectionPrefab.InfluenceVolumeData, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171757, XrefRangeEnd = 1171759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171762, RefRangeEnd = 1171763, XrefRangeStart = 1171759, XrefRangeEnd = 1171762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe m_SphereBlendNormalDistance_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab.InfluenceVolumeData container,
        float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static m_SphereBlendNormalDistance_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag>.NativeClassPtr, nameof (m_SphereBlendNormalDistance_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property>.NativeClassPtr, 100693481);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property>.NativeClassPtr, 100693482);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property>.NativeClassPtr, 100693483);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property>.NativeClassPtr, 100693484);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InfluenceVolumeData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_InfluenceVolumeData_PropertyBag.m_SphereBlendNormalDistance_Property>.NativeClassPtr, 100693485);
      }

      public m_SphereBlendNormalDistance_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
