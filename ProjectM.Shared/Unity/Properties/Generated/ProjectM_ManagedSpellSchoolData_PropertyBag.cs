// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ManagedSpellSchoolData_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM;
using Stunlock.Localization;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_ManagedSpellSchoolData_PropertyBag : 
    ContainerPropertyBag<ManagedSpellSchoolData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 806208, RefRangeEnd = 806209, XrefRangeStart = 806149, XrefRangeEnd = 806208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ManagedSpellSchoolData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedSpellSchoolData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ManagedSpellSchoolData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_ManagedSpellSchoolData_PropertyBag));
      ProjectM_ManagedSpellSchoolData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr, 100671441);
    }

    public ProjectM_ManagedSpellSchoolData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class ShortName_Property : Property<ManagedSpellSchoolData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806107, XrefRangeEnd = 806109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806112, RefRangeEnd = 806113, XrefRangeStart = 806109, XrefRangeEnd = 806112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ShortName_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedSpellSchoolData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedSpellSchoolData container,
        LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
      }

      static ShortName_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr, nameof (ShortName_Property));
        ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property>.NativeClassPtr, 100671442);
        ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property>.NativeClassPtr, 100671443);
        ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property>.NativeClassPtr, 100671444);
        ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property>.NativeClassPtr, 100671445);
        ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.ShortName_Property>.NativeClassPtr, 100671446);
      }

      public ShortName_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class LongName_Property : Property<ManagedSpellSchoolData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806113, XrefRangeEnd = 806115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806118, RefRangeEnd = 806119, XrefRangeStart = 806115, XrefRangeEnd = 806118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe LongName_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedSpellSchoolData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedSpellSchoolData container,
        LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
      }

      static LongName_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr, nameof (LongName_Property));
        ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property>.NativeClassPtr, 100671447);
        ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property>.NativeClassPtr, 100671448);
        ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property>.NativeClassPtr, 100671449);
        ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property>.NativeClassPtr, 100671450);
        ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.LongName_Property>.NativeClassPtr, 100671451);
      }

      public LongName_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Description_Property : Property<ManagedSpellSchoolData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806119, XrefRangeEnd = 806121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806124, RefRangeEnd = 806125, XrefRangeStart = 806121, XrefRangeEnd = 806124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Description_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedSpellSchoolData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedSpellSchoolData container,
        LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
      }

      static Description_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr, nameof (Description_Property));
        ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property>.NativeClassPtr, 100671452);
        ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property>.NativeClassPtr, 100671453);
        ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property>.NativeClassPtr, 100671454);
        ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedSpellSchoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property>.NativeClassPtr, 100671455);
        ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.Description_Property>.NativeClassPtr, 100671456);
      }

      public Description_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BackgroundImage_Property : Property<ManagedSpellSchoolData, AssetGuid>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_ManagedSpellSchoolData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_AssetGuid_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806125, XrefRangeEnd = 806127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806130, RefRangeEnd = 806131, XrefRangeStart = 806127, XrefRangeEnd = 806130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BackgroundImage_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe AssetGuid GetValue(ref ManagedSpellSchoolData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_ManagedSpellSchoolData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
        return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedSpellSchoolData container, AssetGuid value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_AssetGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
      }

      static BackgroundImage_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr, nameof (BackgroundImage_Property));
        ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property>.NativeClassPtr, 100671457);
        ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property>.NativeClassPtr, 100671458);
        ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property>.NativeClassPtr, 100671459);
        ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_ManagedSpellSchoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property>.NativeClassPtr, 100671460);
        ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BackgroundImage_Property>.NativeClassPtr, 100671461);
      }

      public BackgroundImage_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class RelevantBuffs_Property : 
      Property<ManagedSpellSchoolData, Il2CppStructArray<PrefabGUID>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_ManagedSpellSchoolData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Il2CppStructArray_1_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806131, XrefRangeEnd = 806133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806136, RefRangeEnd = 806137, XrefRangeStart = 806133, XrefRangeEnd = 806136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RelevantBuffs_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppStructArray<PrefabGUID> GetValue(
        ref ManagedSpellSchoolData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_ManagedSpellSchoolData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<PrefabGUID>) null : new Il2CppStructArray<PrefabGUID>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedSpellSchoolData container,
        Il2CppStructArray<PrefabGUID> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Il2CppStructArray_1_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
      }

      static RelevantBuffs_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr, nameof (RelevantBuffs_Property));
        ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property>.NativeClassPtr, 100671462);
        ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property>.NativeClassPtr, 100671463);
        ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property>.NativeClassPtr, 100671464);
        ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_ManagedSpellSchoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property>.NativeClassPtr, 100671465);
        ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Il2CppStructArray_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.RelevantBuffs_Property>.NativeClassPtr, 100671466);
      }

      public RelevantBuffs_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TierIcons_Property : Property<ManagedSpellSchoolData, Il2CppReferenceArray<Sprite>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_Sprite_byref_ManagedSpellSchoolData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Il2CppReferenceArray_1_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806137, XrefRangeEnd = 806139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806142, RefRangeEnd = 806143, XrefRangeStart = 806139, XrefRangeEnd = 806142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TierIcons_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppReferenceArray<Sprite> GetValue(
        ref ManagedSpellSchoolData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_Sprite_byref_ManagedSpellSchoolData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedSpellSchoolData container,
        Il2CppReferenceArray<Sprite> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Il2CppReferenceArray_1_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
      }

      static TierIcons_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr, nameof (TierIcons_Property));
        ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property>.NativeClassPtr, 100671467);
        ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property>.NativeClassPtr, 100671468);
        ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property>.NativeClassPtr, 100671469);
        ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_Sprite_byref_ManagedSpellSchoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property>.NativeClassPtr, 100671470);
        ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.TierIcons_Property>.NativeClassPtr, 100671471);
      }

      public TierIcons_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BuffsHeaderColor_Property : Property<ManagedSpellSchoolData, Color>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_ManagedSpellSchoolData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Color_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806143, XrefRangeEnd = 806145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806148, RefRangeEnd = 806149, XrefRangeStart = 806145, XrefRangeEnd = 806148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BuffsHeaderColor_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Color GetValue(ref ManagedSpellSchoolData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_ManagedSpellSchoolData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
        return *(Color*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedSpellSchoolData container, Color value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedSpellSchoolData local = ref container;
        IntPtr pointer = ptr;
        ManagedSpellSchoolData managedSpellSchoolData = pointer == IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        local = managedSpellSchoolData;
      }

      static BuffsHeaderColor_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag>.NativeClassPtr, nameof (BuffsHeaderColor_Property));
        ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property>.NativeClassPtr, 100671472);
        ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property>.NativeClassPtr, 100671473);
        ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property>.NativeClassPtr, 100671474);
        ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_ManagedSpellSchoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property>.NativeClassPtr, 100671475);
        ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedSpellSchoolData_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedSpellSchoolData_PropertyBag.BuffsHeaderColor_Property>.NativeClassPtr, 100671476);
      }

      public BuffsHeaderColor_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
