// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Presentation;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag : 
    ContainerPropertyBag<ProxyPlanarReflectionPrefab>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171684, XrefRangeEnd = 1171697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag));
      ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag>.NativeClassPtr, 100693424);
    }

    public ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class InfluenceVolume_Property : 
      Property<ProxyPlanarReflectionPrefab, ProxyPlanarReflectionPrefab.InfluenceVolumeData>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_InfluenceVolumeData_byref_ProxyPlanarReflectionPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyPlanarReflectionPrefab_InfluenceVolumeData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171677, XrefRangeEnd = 1171679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171682, RefRangeEnd = 1171684, XrefRangeStart = 1171679, XrefRangeEnd = 1171682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InfluenceVolume_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe ProxyPlanarReflectionPrefab.InfluenceVolumeData GetValue(
        ref ProxyPlanarReflectionPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_InfluenceVolumeData_byref_ProxyPlanarReflectionPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyPlanarReflectionPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyPlanarReflectionPrefab reflectionPrefab = pointer == IntPtr.Zero ? (ProxyPlanarReflectionPrefab) null : new ProxyPlanarReflectionPrefab(pointer);
        local = reflectionPrefab;
        return *(ProxyPlanarReflectionPrefab.InfluenceVolumeData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyPlanarReflectionPrefab container,
        ProxyPlanarReflectionPrefab.InfluenceVolumeData value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyPlanarReflectionPrefab_InfluenceVolumeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyPlanarReflectionPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyPlanarReflectionPrefab reflectionPrefab = pointer == IntPtr.Zero ? (ProxyPlanarReflectionPrefab) null : new ProxyPlanarReflectionPrefab(pointer);
        local = reflectionPrefab;
      }

      static InfluenceVolume_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag>.NativeClassPtr, nameof (InfluenceVolume_Property));
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property>.NativeClassPtr, 100693425);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property>.NativeClassPtr, 100693426);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property>.NativeClassPtr, 100693427);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_InfluenceVolumeData_byref_ProxyPlanarReflectionPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property>.NativeClassPtr, 100693428);
        ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyPlanarReflectionPrefab_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyPlanarReflectionPrefab_PropertyBag.InfluenceVolume_Property>.NativeClassPtr, 100693429);
      }

      public InfluenceVolume_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
