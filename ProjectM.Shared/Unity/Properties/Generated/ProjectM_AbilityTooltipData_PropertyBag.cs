// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_AbilityTooltipData_PropertyBag
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
  public class ProjectM_AbilityTooltipData_PropertyBag : ContainerPropertyBag<AbilityTooltipData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804778, XrefRangeEnd = 804819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_AbilityTooltipData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_AbilityTooltipData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_AbilityTooltipData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_AbilityTooltipData_PropertyBag));
      ProjectM_AbilityTooltipData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag>.NativeClassPtr, 100671025);
    }

    public ProjectM_AbilityTooltipData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Name_Property : Property<AbilityTooltipData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_AbilityTooltipData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804743, XrefRangeEnd = 804745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804748, RefRangeEnd = 804750, XrefRangeStart = 804745, XrefRangeEnd = 804748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Name_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Name_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref AbilityTooltipData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_AbilityTooltipData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref AbilityTooltipData container, LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
      }

      static Name_Property()
      {
        Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Name_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag>.NativeClassPtr, nameof (Name_Property));
        ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Name_Property>.NativeClassPtr, 100671026);
        ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Name_Property>.NativeClassPtr, 100671027);
        ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Name_Property>.NativeClassPtr, 100671028);
        ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_AbilityTooltipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Name_Property>.NativeClassPtr, 100671029);
        ProjectM_AbilityTooltipData_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Name_Property>.NativeClassPtr, 100671030);
      }

      public Name_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Description_Property : Property<AbilityTooltipData, LocalizedStringBuilderBase>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizedStringBuilderBase_byref_AbilityTooltipData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_LocalizedStringBuilderBase_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804750, XrefRangeEnd = 804752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804755, RefRangeEnd = 804757, XrefRangeStart = 804752, XrefRangeEnd = 804755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Description_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Description_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizedStringBuilderBase GetValue(ref AbilityTooltipData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizedStringBuilderBase_byref_AbilityTooltipData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
        return *(LocalizedStringBuilderBase*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref AbilityTooltipData container,
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
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_LocalizedStringBuilderBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
      }

      static Description_Property()
      {
        Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Description_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag>.NativeClassPtr, nameof (Description_Property));
        ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Description_Property>.NativeClassPtr, 100671031);
        ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Description_Property>.NativeClassPtr, 100671032);
        ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Description_Property>.NativeClassPtr, 100671033);
        ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizedStringBuilderBase_byref_AbilityTooltipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Description_Property>.NativeClassPtr, 100671034);
        ProjectM_AbilityTooltipData_PropertyBag.Description_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_LocalizedStringBuilderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Description_Property>.NativeClassPtr, 100671035);
      }

      public Description_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Icon_Property : Property<AbilityTooltipData, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_AbilityTooltipData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804757, XrefRangeEnd = 804759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804762, RefRangeEnd = 804764, XrefRangeStart = 804759, XrefRangeEnd = 804762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Icon_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Icon_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref AbilityTooltipData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_AbilityTooltipData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer1 = ptr;
        AbilityTooltipData abilityTooltipData = pointer1 == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer1);
        local = abilityTooltipData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Sprite) null : new Sprite(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref AbilityTooltipData container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
      }

      static Icon_Property()
      {
        Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Icon_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag>.NativeClassPtr, nameof (Icon_Property));
        ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Icon_Property>.NativeClassPtr, 100671036);
        ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Icon_Property>.NativeClassPtr, 100671037);
        ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Icon_Property>.NativeClassPtr, 100671038);
        ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_AbilityTooltipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Icon_Property>.NativeClassPtr, 100671039);
        ProjectM_AbilityTooltipData_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.Icon_Property>.NativeClassPtr, 100671040);
      }

      public Icon_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TooltipType_Property : Property<AbilityTooltipData, AbilityTooltipType>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_AbilityTooltipType_byref_AbilityTooltipData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_AbilityTooltipType_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804764, XrefRangeEnd = 804766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804769, RefRangeEnd = 804771, XrefRangeStart = 804766, XrefRangeEnd = 804769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TooltipType_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe AbilityTooltipType GetValue(ref AbilityTooltipData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AbilityTooltipType_byref_AbilityTooltipData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
        return *(AbilityTooltipType*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref AbilityTooltipData container,
        AbilityTooltipType value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_AbilityTooltipType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
      }

      static TooltipType_Property()
      {
        Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag>.NativeClassPtr, nameof (TooltipType_Property));
        ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property>.NativeClassPtr, 100671041);
        ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property>.NativeClassPtr, 100671042);
        ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property>.NativeClassPtr, 100671043);
        ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AbilityTooltipType_byref_AbilityTooltipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property>.NativeClassPtr, 100671044);
        ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_AbilityTooltipType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.TooltipType_Property>.NativeClassPtr, 100671045);
      }

      public TooltipType_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SpawnPrefabOnCast_Property : Property<AbilityTooltipData, PrefabGUID>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_AbilityTooltipData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804771, XrefRangeEnd = 804773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804776, RefRangeEnd = 804778, XrefRangeStart = 804773, XrefRangeEnd = 804776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnPrefabOnCast_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PrefabGUID GetValue(ref AbilityTooltipData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_AbilityTooltipData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref AbilityTooltipData container, PrefabGUID value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AbilityTooltipData local = ref container;
        IntPtr pointer = ptr;
        AbilityTooltipData abilityTooltipData = pointer == IntPtr.Zero ? (AbilityTooltipData) null : new AbilityTooltipData(pointer);
        local = abilityTooltipData;
      }

      static SpawnPrefabOnCast_Property()
      {
        Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag>.NativeClassPtr, nameof (SpawnPrefabOnCast_Property));
        ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property>.NativeClassPtr, 100671046);
        ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property>.NativeClassPtr, 100671047);
        ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property>.NativeClassPtr, 100671048);
        ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_AbilityTooltipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property>.NativeClassPtr, 100671049);
        ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AbilityTooltipData_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_AbilityTooltipData_PropertyBag.SpawnPrefabOnCast_Property>.NativeClassPtr, 100671050);
      }

      public SpawnPrefabOnCast_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
