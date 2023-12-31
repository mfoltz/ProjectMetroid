// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_MapIconOverrideState_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_MapIconOverrideState_PropertyBag : ContainerPropertyBag<MapIconOverrideState>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805381, XrefRangeEnd = 805407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_MapIconOverrideState_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconOverrideState_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_MapIconOverrideState_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_MapIconOverrideState_PropertyBag));
      ProjectM_MapIconOverrideState_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag>.NativeClassPtr, 100671205);
    }

    public ProjectM_MapIconOverrideState_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Icon_Property : Property<MapIconOverrideState, MapIconIconOverrideSettings>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconIconOverrideSettings_byref_MapIconOverrideState_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconIconOverrideSettings_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805320, XrefRangeEnd = 805322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805338, RefRangeEnd = 805340, XrefRangeStart = 805322, XrefRangeEnd = 805338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Icon_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Icon_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe MapIconIconOverrideSettings GetValue(ref MapIconOverrideState container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconIconOverrideSettings_byref_MapIconOverrideState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new MapIconIconOverrideSettings(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805340, XrefRangeEnd = 805341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref MapIconOverrideState container,
        MapIconIconOverrideSettings value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Icon_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Icon_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag>.NativeClassPtr, nameof (Icon_Property));
        ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Icon_Property>.NativeClassPtr, 100671206);
        ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Icon_Property>.NativeClassPtr, 100671207);
        ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Icon_Property>.NativeClassPtr, 100671208);
        ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconIconOverrideSettings_byref_MapIconOverrideState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Icon_Property>.NativeClassPtr, 100671209);
        ProjectM_MapIconOverrideState_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Icon_Property>.NativeClassPtr, 100671210);
      }

      public Icon_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Header_Property : Property<MapIconOverrideState, MapIconLabelOverrideSettings>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconLabelOverrideSettings_byref_MapIconOverrideState_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconLabelOverrideSettings_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805341, XrefRangeEnd = 805343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805359, RefRangeEnd = 805361, XrefRangeStart = 805343, XrefRangeEnd = 805359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Header_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Header_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe MapIconLabelOverrideSettings GetValue(
        ref MapIconOverrideState container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconLabelOverrideSettings_byref_MapIconOverrideState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MapIconLabelOverrideSettings*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref MapIconOverrideState container,
        MapIconLabelOverrideSettings value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Header_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Header_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag>.NativeClassPtr, nameof (Header_Property));
        ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Header_Property>.NativeClassPtr, 100671211);
        ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Header_Property>.NativeClassPtr, 100671212);
        ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Header_Property>.NativeClassPtr, 100671213);
        ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconLabelOverrideSettings_byref_MapIconOverrideState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Header_Property>.NativeClassPtr, 100671214);
        ProjectM_MapIconOverrideState_PropertyBag.Header_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.Header_Property>.NativeClassPtr, 100671215);
      }

      public Header_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SubHeader_Property : Property<MapIconOverrideState, MapIconLabelOverrideSettings>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconLabelOverrideSettings_byref_MapIconOverrideState_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconLabelOverrideSettings_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805361, XrefRangeEnd = 805363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805379, RefRangeEnd = 805381, XrefRangeStart = 805363, XrefRangeEnd = 805379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SubHeader_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe MapIconLabelOverrideSettings GetValue(
        ref MapIconOverrideState container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconLabelOverrideSettings_byref_MapIconOverrideState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MapIconLabelOverrideSettings*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref MapIconOverrideState container,
        MapIconLabelOverrideSettings value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SubHeader_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag>.NativeClassPtr, nameof (SubHeader_Property));
        ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property>.NativeClassPtr, 100671216);
        ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property>.NativeClassPtr, 100671217);
        ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property>.NativeClassPtr, 100671218);
        ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconLabelOverrideSettings_byref_MapIconOverrideState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property>.NativeClassPtr, 100671219);
        ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconOverrideState_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconOverrideState_PropertyBag.SubHeader_Property>.NativeClassPtr, 100671220);
      }

      public SubHeader_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
