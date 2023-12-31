// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_HybridCamera_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_HybridCamera_PropertyBag : ContainerPropertyBag<HybridCamera>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804484, XrefRangeEnd = 804504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_HybridCamera_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_HybridCamera_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_HybridCamera_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_HybridCamera_PropertyBag));
      ProjectM_HybridCamera_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag>.NativeClassPtr, 100670931);
    }

    public ProjectM_HybridCamera_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Camera_Property : Property<HybridCamera, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_HybridCamera_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridCamera_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804470, XrefRangeEnd = 804472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804475, RefRangeEnd = 804477, XrefRangeStart = 804472, XrefRangeEnd = 804475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Camera_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.Camera_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref HybridCamera container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_HybridCamera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref HybridCamera container, GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridCamera_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Camera_Property()
      {
        Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.Camera_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag>.NativeClassPtr, nameof (Camera_Property));
        ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.Camera_Property>.NativeClassPtr, 100670932);
        ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.Camera_Property>.NativeClassPtr, 100670933);
        ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.Camera_Property>.NativeClassPtr, 100670934);
        ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_HybridCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.Camera_Property>.NativeClassPtr, 100670935);
        ProjectM_HybridCamera_PropertyBag.Camera_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridCamera_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.Camera_Property>.NativeClassPtr, 100670936);
      }

      public Camera_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class VolumeAnchor_Property : Property<HybridCamera, Transform>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Transform_byref_HybridCamera_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridCamera_Transform_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804477, XrefRangeEnd = 804479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804482, RefRangeEnd = 804484, XrefRangeStart = 804479, XrefRangeEnd = 804482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VolumeAnchor_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Transform GetValue(ref HybridCamera container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Transform_byref_HybridCamera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref HybridCamera container, Transform value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridCamera_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static VolumeAnchor_Property()
      {
        Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag>.NativeClassPtr, nameof (VolumeAnchor_Property));
        ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property>.NativeClassPtr, 100670937);
        ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property>.NativeClassPtr, 100670938);
        ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property>.NativeClassPtr, 100670939);
        ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Transform_byref_HybridCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property>.NativeClassPtr, 100670940);
        ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridCamera_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_HybridCamera_PropertyBag.VolumeAnchor_Property>.NativeClassPtr, 100670941);
      }

      public VolumeAnchor_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
