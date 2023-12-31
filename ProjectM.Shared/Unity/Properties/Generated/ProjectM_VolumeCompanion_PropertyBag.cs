// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_VolumeCompanion_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using UnityEngine.Rendering;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_VolumeCompanion_PropertyBag : ContainerPropertyBag<VolumeCompanion>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806264, XrefRangeEnd = 806303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_VolumeCompanion_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_VolumeCompanion_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_VolumeCompanion_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_VolumeCompanion_PropertyBag));
      ProjectM_VolumeCompanion_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag>.NativeClassPtr, 100671483);
    }

    public ProjectM_VolumeCompanion_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Priority_Property : Property<VolumeCompanion, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806229, XrefRangeEnd = 806231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806234, RefRangeEnd = 806236, XrefRangeStart = 806231, XrefRangeEnd = 806234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Priority_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Priority_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref VolumeCompanion container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref VolumeCompanion container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
      }

      static Priority_Property()
      {
        Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Priority_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag>.NativeClassPtr, nameof (Priority_Property));
        ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Priority_Property>.NativeClassPtr, 100671484);
        ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Priority_Property>.NativeClassPtr, 100671485);
        ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Priority_Property>.NativeClassPtr, 100671486);
        ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Priority_Property>.NativeClassPtr, 100671487);
        ProjectM_VolumeCompanion_PropertyBag.Priority_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Priority_Property>.NativeClassPtr, 100671488);
      }

      public Priority_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BlendDistance_Property : Property<VolumeCompanion, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806236, XrefRangeEnd = 806238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806241, RefRangeEnd = 806243, XrefRangeStart = 806238, XrefRangeEnd = 806241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BlendDistance_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref VolumeCompanion container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref VolumeCompanion container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
      }

      static BlendDistance_Property()
      {
        Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag>.NativeClassPtr, nameof (BlendDistance_Property));
        ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property>.NativeClassPtr, 100671489);
        ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property>.NativeClassPtr, 100671490);
        ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property>.NativeClassPtr, 100671491);
        ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property>.NativeClassPtr, 100671492);
        ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.BlendDistance_Property>.NativeClassPtr, 100671493);
      }

      public BlendDistance_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Weight_Property : Property<VolumeCompanion, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806243, XrefRangeEnd = 806245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806248, RefRangeEnd = 806250, XrefRangeStart = 806245, XrefRangeEnd = 806248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Weight_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Weight_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref VolumeCompanion container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref VolumeCompanion container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
      }

      static Weight_Property()
      {
        Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Weight_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag>.NativeClassPtr, nameof (Weight_Property));
        ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Weight_Property>.NativeClassPtr, 100671494);
        ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Weight_Property>.NativeClassPtr, 100671495);
        ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Weight_Property>.NativeClassPtr, 100671496);
        ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_VolumeCompanion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Weight_Property>.NativeClassPtr, 100671497);
        ProjectM_VolumeCompanion_PropertyBag.Weight_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Weight_Property>.NativeClassPtr, 100671498);
      }

      public Weight_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Profile_Property : Property<VolumeCompanion, VolumeProfile>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_VolumeProfile_byref_VolumeCompanion_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_VolumeProfile_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806250, XrefRangeEnd = 806252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806255, RefRangeEnd = 806257, XrefRangeStart = 806252, XrefRangeEnd = 806255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Profile_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Profile_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe VolumeProfile GetValue(ref VolumeCompanion container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_VolumeProfile_byref_VolumeCompanion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer1 = ptr;
        VolumeCompanion volumeCompanion = pointer1 == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer1);
        local = volumeCompanion;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref VolumeCompanion container, VolumeProfile value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_VolumeProfile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
      }

      static Profile_Property()
      {
        Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Profile_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag>.NativeClassPtr, nameof (Profile_Property));
        ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Profile_Property>.NativeClassPtr, 100671499);
        ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Profile_Property>.NativeClassPtr, 100671500);
        ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Profile_Property>.NativeClassPtr, 100671501);
        ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_VolumeProfile_byref_VolumeCompanion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Profile_Property>.NativeClassPtr, 100671502);
        ProjectM_VolumeCompanion_PropertyBag.Profile_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Profile_Property>.NativeClassPtr, 100671503);
      }

      public Profile_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Name_Property : Property<VolumeCompanion, string>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_VolumeCompanion_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_String_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806257, XrefRangeEnd = 806259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806262, RefRangeEnd = 806264, XrefRangeStart = 806259, XrefRangeEnd = 806262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Name_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Name_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe string GetValue(ref VolumeCompanion container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_VolumeCompanion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref VolumeCompanion container, string value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VolumeCompanion local = ref container;
        IntPtr pointer = ptr;
        VolumeCompanion volumeCompanion = pointer == IntPtr.Zero ? (VolumeCompanion) null : new VolumeCompanion(pointer);
        local = volumeCompanion;
      }

      static Name_Property()
      {
        Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Name_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag>.NativeClassPtr, nameof (Name_Property));
        ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Name_Property>.NativeClassPtr, 100671504);
        ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Name_Property>.NativeClassPtr, 100671505);
        ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Name_Property>.NativeClassPtr, 100671506);
        ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_VolumeCompanion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Name_Property>.NativeClassPtr, 100671507);
        ProjectM_VolumeCompanion_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VolumeCompanion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VolumeCompanion_PropertyBag.Name_Property>.NativeClassPtr, 100671508);
      }

      public Name_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
