// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_PrefabPreviewSource_PropertyBag
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
  public class ProjectM_PrefabPreviewSource_PropertyBag : ContainerPropertyBag<PrefabPreviewSource>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805979, XrefRangeEnd = 805992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_PrefabPreviewSource_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_PrefabPreviewSource_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_PrefabPreviewSource_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_PrefabPreviewSource_PropertyBag));
      ProjectM_PrefabPreviewSource_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag>.NativeClassPtr, 100671398);
    }

    public ProjectM_PrefabPreviewSource_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class SourceObject_Property : Property<PrefabPreviewSource, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_PrefabPreviewSource_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PrefabPreviewSource_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805972, XrefRangeEnd = 805974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805977, RefRangeEnd = 805979, XrefRangeStart = 805974, XrefRangeEnd = 805977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SourceObject_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref PrefabPreviewSource container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_PrefabPreviewSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref PrefabPreviewSource local = ref container;
        IntPtr pointer1 = ptr;
        PrefabPreviewSource prefabPreviewSource = pointer1 == IntPtr.Zero ? (PrefabPreviewSource) null : new PrefabPreviewSource(pointer1);
        local = prefabPreviewSource;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref PrefabPreviewSource container, GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PrefabPreviewSource_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref PrefabPreviewSource local = ref container;
        IntPtr pointer = ptr;
        PrefabPreviewSource prefabPreviewSource = pointer == IntPtr.Zero ? (PrefabPreviewSource) null : new PrefabPreviewSource(pointer);
        local = prefabPreviewSource;
      }

      static SourceObject_Property()
      {
        Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag>.NativeClassPtr, nameof (SourceObject_Property));
        ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property>.NativeClassPtr, 100671399);
        ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property>.NativeClassPtr, 100671400);
        ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property>.NativeClassPtr, 100671401);
        ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_PrefabPreviewSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property>.NativeClassPtr, 100671402);
        ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PrefabPreviewSource_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_PrefabPreviewSource_PropertyBag.SourceObject_Property>.NativeClassPtr, 100671403);
      }

      public SourceObject_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
