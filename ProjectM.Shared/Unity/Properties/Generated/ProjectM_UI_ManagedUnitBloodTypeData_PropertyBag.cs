// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag : 
    ContainerPropertyBag<ManagedUnitBloodTypeData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806509, XrefRangeEnd = 806535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag));
      ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag>.NativeClassPtr, 100671567);
    }

    public ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Name_Property : Property<ManagedUnitBloodTypeData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedUnitBloodTypeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806488, XrefRangeEnd = 806490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806493, RefRangeEnd = 806495, XrefRangeStart = 806490, XrefRangeEnd = 806493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Name_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedUnitBloodTypeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedUnitBloodTypeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedUnitBloodTypeData local = ref container;
        IntPtr pointer = ptr;
        ManagedUnitBloodTypeData unitBloodTypeData = pointer == IntPtr.Zero ? (ManagedUnitBloodTypeData) null : new ManagedUnitBloodTypeData(pointer);
        local = unitBloodTypeData;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedUnitBloodTypeData container,
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
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedUnitBloodTypeData local = ref container;
        IntPtr pointer = ptr;
        ManagedUnitBloodTypeData unitBloodTypeData = pointer == IntPtr.Zero ? (ManagedUnitBloodTypeData) null : new ManagedUnitBloodTypeData(pointer);
        local = unitBloodTypeData;
      }

      static Name_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag>.NativeClassPtr, nameof (Name_Property));
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property>.NativeClassPtr, 100671568);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property>.NativeClassPtr, 100671569);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property>.NativeClassPtr, 100671570);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedUnitBloodTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property>.NativeClassPtr, 100671571);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Name_Property>.NativeClassPtr, 100671572);
      }

      public Name_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Icon_Property : Property<ManagedUnitBloodTypeData, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedUnitBloodTypeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806495, XrefRangeEnd = 806497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806500, RefRangeEnd = 806502, XrefRangeStart = 806497, XrefRangeEnd = 806500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Icon_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref ManagedUnitBloodTypeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedUnitBloodTypeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedUnitBloodTypeData local = ref container;
        IntPtr pointer1 = ptr;
        ManagedUnitBloodTypeData unitBloodTypeData = pointer1 == IntPtr.Zero ? (ManagedUnitBloodTypeData) null : new ManagedUnitBloodTypeData(pointer1);
        local = unitBloodTypeData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Sprite) null : new Sprite(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedUnitBloodTypeData container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedUnitBloodTypeData local = ref container;
        IntPtr pointer = ptr;
        ManagedUnitBloodTypeData unitBloodTypeData = pointer == IntPtr.Zero ? (ManagedUnitBloodTypeData) null : new ManagedUnitBloodTypeData(pointer);
        local = unitBloodTypeData;
      }

      static Icon_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag>.NativeClassPtr, nameof (Icon_Property));
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property>.NativeClassPtr, 100671573);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property>.NativeClassPtr, 100671574);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property>.NativeClassPtr, 100671575);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedUnitBloodTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property>.NativeClassPtr, 100671576);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon_Property>.NativeClassPtr, 100671577);
      }

      public Icon_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Icon2_Property : Property<ManagedUnitBloodTypeData, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedUnitBloodTypeData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806502, XrefRangeEnd = 806504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806507, RefRangeEnd = 806509, XrefRangeStart = 806504, XrefRangeEnd = 806507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Icon2_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref ManagedUnitBloodTypeData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedUnitBloodTypeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedUnitBloodTypeData local = ref container;
        IntPtr pointer1 = ptr;
        ManagedUnitBloodTypeData unitBloodTypeData = pointer1 == IntPtr.Zero ? (ManagedUnitBloodTypeData) null : new ManagedUnitBloodTypeData(pointer1);
        local = unitBloodTypeData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Sprite) null : new Sprite(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedUnitBloodTypeData container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedUnitBloodTypeData local = ref container;
        IntPtr pointer = ptr;
        ManagedUnitBloodTypeData unitBloodTypeData = pointer == IntPtr.Zero ? (ManagedUnitBloodTypeData) null : new ManagedUnitBloodTypeData(pointer);
        local = unitBloodTypeData;
      }

      static Icon2_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag>.NativeClassPtr, nameof (Icon2_Property));
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property>.NativeClassPtr, 100671578);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property>.NativeClassPtr, 100671579);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property>.NativeClassPtr, 100671580);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedUnitBloodTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property>.NativeClassPtr, 100671581);
        ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedUnitBloodTypeData_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_ManagedUnitBloodTypeData_PropertyBag.Icon2_Property>.NativeClassPtr, 100671582);
      }

      public Icon2_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
