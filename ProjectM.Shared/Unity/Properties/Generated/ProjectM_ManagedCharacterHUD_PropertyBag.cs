// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ManagedCharacterHUD_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using Stunlock.Localization;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_ManagedCharacterHUD_PropertyBag : ContainerPropertyBag<ManagedCharacterHUD>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804532, XrefRangeEnd = 804565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ManagedCharacterHUD_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedCharacterHUD_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ManagedCharacterHUD_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_ManagedCharacterHUD_PropertyBag));
      ProjectM_ManagedCharacterHUD_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag>.NativeClassPtr, 100670942);
    }

    public ProjectM_ManagedCharacterHUD_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class PrefabName_Property : Property<ManagedCharacterHUD, string>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedCharacterHUD_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_String_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804504, XrefRangeEnd = 804506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804509, RefRangeEnd = 804511, XrefRangeStart = 804506, XrefRangeEnd = 804509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefabName_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe string GetValue(ref ManagedCharacterHUD container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedCharacterHUD_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedCharacterHUD local = ref container;
        IntPtr pointer = ptr;
        ManagedCharacterHUD managedCharacterHud = pointer == IntPtr.Zero ? (ManagedCharacterHUD) null : new ManagedCharacterHUD(pointer);
        local = managedCharacterHud;
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedCharacterHUD container, string value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedCharacterHUD local = ref container;
        IntPtr pointer = ptr;
        ManagedCharacterHUD managedCharacterHud = pointer == IntPtr.Zero ? (ManagedCharacterHUD) null : new ManagedCharacterHUD(pointer);
        local = managedCharacterHud;
      }

      static PrefabName_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag>.NativeClassPtr, nameof (PrefabName_Property));
        ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property>.NativeClassPtr, 100670943);
        ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property>.NativeClassPtr, 100670944);
        ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property>.NativeClassPtr, 100670945);
        ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedCharacterHUD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property>.NativeClassPtr, 100670946);
        ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.PrefabName_Property>.NativeClassPtr, 100670947);
      }

      public PrefabName_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Icon_Property : Property<ManagedCharacterHUD, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedCharacterHUD_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804511, XrefRangeEnd = 804513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804516, RefRangeEnd = 804518, XrefRangeStart = 804513, XrefRangeEnd = 804516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Icon_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref ManagedCharacterHUD container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedCharacterHUD_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedCharacterHUD local = ref container;
        IntPtr pointer1 = ptr;
        ManagedCharacterHUD managedCharacterHud = pointer1 == IntPtr.Zero ? (ManagedCharacterHUD) null : new ManagedCharacterHUD(pointer1);
        local = managedCharacterHud;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Sprite) null : new Sprite(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedCharacterHUD container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedCharacterHUD local = ref container;
        IntPtr pointer = ptr;
        ManagedCharacterHUD managedCharacterHud = pointer == IntPtr.Zero ? (ManagedCharacterHUD) null : new ManagedCharacterHUD(pointer);
        local = managedCharacterHud;
      }

      static Icon_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag>.NativeClassPtr, nameof (Icon_Property));
        ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property>.NativeClassPtr, 100670948);
        ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property>.NativeClassPtr, 100670949);
        ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property>.NativeClassPtr, 100670950);
        ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ManagedCharacterHUD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property>.NativeClassPtr, 100670951);
        ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Icon_Property>.NativeClassPtr, 100670952);
      }

      public Icon_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Name_Property : Property<ManagedCharacterHUD, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedCharacterHUD_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804518, XrefRangeEnd = 804520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804523, RefRangeEnd = 804525, XrefRangeStart = 804520, XrefRangeEnd = 804523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Name_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedCharacterHUD container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedCharacterHUD_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedCharacterHUD local = ref container;
        IntPtr pointer = ptr;
        ManagedCharacterHUD managedCharacterHud = pointer == IntPtr.Zero ? (ManagedCharacterHUD) null : new ManagedCharacterHUD(pointer);
        local = managedCharacterHud;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedCharacterHUD container, LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedCharacterHUD local = ref container;
        IntPtr pointer = ptr;
        ManagedCharacterHUD managedCharacterHud = pointer == IntPtr.Zero ? (ManagedCharacterHUD) null : new ManagedCharacterHUD(pointer);
        local = managedCharacterHud;
      }

      static Name_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag>.NativeClassPtr, nameof (Name_Property));
        ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property>.NativeClassPtr, 100670953);
        ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property>.NativeClassPtr, 100670954);
        ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property>.NativeClassPtr, 100670955);
        ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedCharacterHUD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property>.NativeClassPtr, 100670956);
        ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Name_Property>.NativeClassPtr, 100670957);
      }

      public Name_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Description_Property : Property<ManagedCharacterHUD, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedCharacterHUD_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804525, XrefRangeEnd = 804527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804530, RefRangeEnd = 804532, XrefRangeStart = 804527, XrefRangeEnd = 804530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Description_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedCharacterHUD container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedCharacterHUD_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedCharacterHUD local = ref container;
        IntPtr pointer = ptr;
        ManagedCharacterHUD managedCharacterHud = pointer == IntPtr.Zero ? (ManagedCharacterHUD) null : new ManagedCharacterHUD(pointer);
        local = managedCharacterHud;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedCharacterHUD container, LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedCharacterHUD local = ref container;
        IntPtr pointer = ptr;
        ManagedCharacterHUD managedCharacterHud = pointer == IntPtr.Zero ? (ManagedCharacterHUD) null : new ManagedCharacterHUD(pointer);
        local = managedCharacterHud;
      }

      static Description_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag>.NativeClassPtr, nameof (Description_Property));
        ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property>.NativeClassPtr, 100670958);
        ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property>.NativeClassPtr, 100670959);
        ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property>.NativeClassPtr, 100670960);
        ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedCharacterHUD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property>.NativeClassPtr, 100670961);
        ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedCharacterHUD_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedCharacterHUD_PropertyBag.Description_Property>.NativeClassPtr, 100670962);
      }

      public Description_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
