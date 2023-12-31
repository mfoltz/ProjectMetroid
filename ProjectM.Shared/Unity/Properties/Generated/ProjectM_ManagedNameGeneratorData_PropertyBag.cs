// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ManagedNameGeneratorData_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using Stunlock.Localization;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_ManagedNameGeneratorData_PropertyBag : 
    ContainerPropertyBag<ManagedNameGeneratorData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806013, XrefRangeEnd = 806047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ManagedNameGeneratorData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ManagedNameGeneratorData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_ManagedNameGeneratorData_PropertyBag));
      ProjectM_ManagedNameGeneratorData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag>.NativeClassPtr, 100671404);
    }

    public ProjectM_ManagedNameGeneratorData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class NamePrefixes_Property : Property<ManagedNameGeneratorData, List<LocalizationKey>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_LocalizationKey_byref_ManagedNameGeneratorData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_List_1_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805992, XrefRangeEnd = 805994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805997, RefRangeEnd = 805999, XrefRangeStart = 805994, XrefRangeEnd = 805997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NamePrefixes_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe List<LocalizationKey> GetValue(ref ManagedNameGeneratorData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_LocalizationKey_byref_ManagedNameGeneratorData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedNameGeneratorData local = ref container;
        IntPtr pointer1 = ptr;
        ManagedNameGeneratorData nameGeneratorData = pointer1 == IntPtr.Zero ? (ManagedNameGeneratorData) null : new ManagedNameGeneratorData(pointer1);
        local = nameGeneratorData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (List<LocalizationKey>) null : new List<LocalizationKey>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedNameGeneratorData container,
        List<LocalizationKey> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_List_1_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedNameGeneratorData local = ref container;
        IntPtr pointer = ptr;
        ManagedNameGeneratorData nameGeneratorData = pointer == IntPtr.Zero ? (ManagedNameGeneratorData) null : new ManagedNameGeneratorData(pointer);
        local = nameGeneratorData;
      }

      static NamePrefixes_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag>.NativeClassPtr, nameof (NamePrefixes_Property));
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property>.NativeClassPtr, 100671405);
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property>.NativeClassPtr, 100671406);
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property>.NativeClassPtr, 100671407);
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_LocalizationKey_byref_ManagedNameGeneratorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property>.NativeClassPtr, 100671408);
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_List_1_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePrefixes_Property>.NativeClassPtr, 100671409);
      }

      public NamePrefixes_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class NamePostfixes_Property : Property<ManagedNameGeneratorData, List<LocalizationKey>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_LocalizationKey_byref_ManagedNameGeneratorData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_List_1_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805999, XrefRangeEnd = 806001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806004, RefRangeEnd = 806006, XrefRangeStart = 806001, XrefRangeEnd = 806004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NamePostfixes_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe List<LocalizationKey> GetValue(ref ManagedNameGeneratorData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_LocalizationKey_byref_ManagedNameGeneratorData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedNameGeneratorData local = ref container;
        IntPtr pointer1 = ptr;
        ManagedNameGeneratorData nameGeneratorData = pointer1 == IntPtr.Zero ? (ManagedNameGeneratorData) null : new ManagedNameGeneratorData(pointer1);
        local = nameGeneratorData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (List<LocalizationKey>) null : new List<LocalizationKey>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedNameGeneratorData container,
        List<LocalizationKey> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_List_1_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedNameGeneratorData local = ref container;
        IntPtr pointer = ptr;
        ManagedNameGeneratorData nameGeneratorData = pointer == IntPtr.Zero ? (ManagedNameGeneratorData) null : new ManagedNameGeneratorData(pointer);
        local = nameGeneratorData;
      }

      static NamePostfixes_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag>.NativeClassPtr, nameof (NamePostfixes_Property));
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property>.NativeClassPtr, 100671410);
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property>.NativeClassPtr, 100671411);
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property>.NativeClassPtr, 100671412);
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_LocalizationKey_byref_ManagedNameGeneratorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property>.NativeClassPtr, 100671413);
        ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_List_1_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.NamePostfixes_Property>.NativeClassPtr, 100671414);
      }

      public NamePostfixes_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class PrebuiltStrings_Property : 
      Property<ManagedNameGeneratorData, Dictionary<ManagedNameGeneratorData.NameCombinationKey, string>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_NameCombinationKey_String_byref_ManagedNameGeneratorData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_Dictionary_2_NameCombinationKey_String_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806006, XrefRangeEnd = 806008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806011, RefRangeEnd = 806013, XrefRangeStart = 806008, XrefRangeEnd = 806011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrebuiltStrings_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Dictionary<ManagedNameGeneratorData.NameCombinationKey, string> GetValue(
        ref ManagedNameGeneratorData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_NameCombinationKey_String_byref_ManagedNameGeneratorData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedNameGeneratorData local = ref container;
        IntPtr pointer1 = ptr;
        ManagedNameGeneratorData nameGeneratorData = pointer1 == IntPtr.Zero ? (ManagedNameGeneratorData) null : new ManagedNameGeneratorData(pointer1);
        local = nameGeneratorData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Dictionary<ManagedNameGeneratorData.NameCombinationKey, string>) null : new Dictionary<ManagedNameGeneratorData.NameCombinationKey, string>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedNameGeneratorData container,
        Dictionary<ManagedNameGeneratorData.NameCombinationKey, string> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_Dictionary_2_NameCombinationKey_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedNameGeneratorData local = ref container;
        IntPtr pointer = ptr;
        ManagedNameGeneratorData nameGeneratorData = pointer == IntPtr.Zero ? (ManagedNameGeneratorData) null : new ManagedNameGeneratorData(pointer);
        local = nameGeneratorData;
      }

      static PrebuiltStrings_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag>.NativeClassPtr, nameof (PrebuiltStrings_Property));
        ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property>.NativeClassPtr, 100671415);
        ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property>.NativeClassPtr, 100671416);
        ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property>.NativeClassPtr, 100671417);
        ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_NameCombinationKey_String_byref_ManagedNameGeneratorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property>.NativeClassPtr, 100671418);
        ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedNameGeneratorData_Dictionary_2_NameCombinationKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_PropertyBag.PrebuiltStrings_Property>.NativeClassPtr, 100671419);
      }

      public PrebuiltStrings_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
