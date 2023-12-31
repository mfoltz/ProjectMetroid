// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ManagedItemData_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_ManagedItemData_PropertyBag : ContainerPropertyBag<ManagedItemData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804962, XrefRangeEnd = 804996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ManagedItemData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedItemData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ManagedItemData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_ManagedItemData_PropertyBag));
      ProjectM_ManagedItemData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag>.NativeClassPtr, 100671089);
    }

    public ProjectM_ManagedItemData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class PrefabName_Property : Property<ManagedItemData, string>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedItemData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_String_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804934, XrefRangeEnd = 804936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804939, RefRangeEnd = 804941, XrefRangeStart = 804936, XrefRangeEnd = 804939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefabName_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.PrefabName_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe string GetValue(ref ManagedItemData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemData local = ref container;
        IntPtr pointer = ptr;
        ManagedItemData managedItemData = pointer == IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        local = managedItemData;
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedItemData container, string value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemData local = ref container;
        IntPtr pointer = ptr;
        ManagedItemData managedItemData = pointer == IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        local = managedItemData;
      }

      static PrefabName_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.PrefabName_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag>.NativeClassPtr, nameof (PrefabName_Property));
        ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671090);
        ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671091);
        ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671092);
        ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671093);
        ProjectM_ManagedItemData_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671094);
      }

      public PrefabName_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Icon_Property : Property<ManagedItemData, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedItemData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804941, XrefRangeEnd = 804943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804946, RefRangeEnd = 804948, XrefRangeStart = 804943, XrefRangeEnd = 804946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Icon_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Icon_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref ManagedItemData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemData local = ref container;
        IntPtr pointer1 = ptr;
        ManagedItemData managedItemData = pointer1 == IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer1);
        local = managedItemData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Sprite) null : new Sprite(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedItemData container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemData local = ref container;
        IntPtr pointer = ptr;
        ManagedItemData managedItemData = pointer == IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        local = managedItemData;
      }

      static Icon_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Icon_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag>.NativeClassPtr, nameof (Icon_Property));
        ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Icon_Property>.NativeClassPtr, 100671095);
        ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Icon_Property>.NativeClassPtr, 100671096);
        ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Icon_Property>.NativeClassPtr, 100671097);
        ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Icon_Property>.NativeClassPtr, 100671098);
        ProjectM_ManagedItemData_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Icon_Property>.NativeClassPtr, 100671099);
      }

      public Icon_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Name_Property : Property<ManagedItemData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedItemData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804948, XrefRangeEnd = 804950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804953, RefRangeEnd = 804955, XrefRangeStart = 804950, XrefRangeEnd = 804953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Name_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Name_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedItemData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemData local = ref container;
        IntPtr pointer = ptr;
        ManagedItemData managedItemData = pointer == IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        local = managedItemData;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedItemData container, LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemData local = ref container;
        IntPtr pointer = ptr;
        ManagedItemData managedItemData = pointer == IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        local = managedItemData;
      }

      static Name_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Name_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag>.NativeClassPtr, nameof (Name_Property));
        ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Name_Property>.NativeClassPtr, 100671100);
        ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Name_Property>.NativeClassPtr, 100671101);
        ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Name_Property>.NativeClassPtr, 100671102);
        ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Name_Property>.NativeClassPtr, 100671103);
        ProjectM_ManagedItemData_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Name_Property>.NativeClassPtr, 100671104);
      }

      public Name_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Description_Property : Property<ManagedItemData, LocalizedStringBuilderBase>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizedStringBuilderBase_byref_ManagedItemData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_LocalizedStringBuilderBase_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804955, XrefRangeEnd = 804957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804960, RefRangeEnd = 804962, XrefRangeStart = 804957, XrefRangeEnd = 804960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Description_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Description_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizedStringBuilderBase GetValue(ref ManagedItemData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizedStringBuilderBase_byref_ManagedItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemData local = ref container;
        IntPtr pointer = ptr;
        ManagedItemData managedItemData = pointer == IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        local = managedItemData;
        return *(LocalizedStringBuilderBase*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedItemData container,
        LocalizedStringBuilderBase value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_LocalizedStringBuilderBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemData local = ref container;
        IntPtr pointer = ptr;
        ManagedItemData managedItemData = pointer == IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        local = managedItemData;
      }

      static Description_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Description_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag>.NativeClassPtr, nameof (Description_Property));
        ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Description_Property>.NativeClassPtr, 100671105);
        ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Description_Property>.NativeClassPtr, 100671106);
        ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Description_Property>.NativeClassPtr, 100671107);
        ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizedStringBuilderBase_byref_ManagedItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Description_Property>.NativeClassPtr, 100671108);
        ProjectM_ManagedItemData_PropertyBag.Description_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemData_LocalizedStringBuilderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemData_PropertyBag.Description_Property>.NativeClassPtr, 100671109);
      }

      public Description_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
