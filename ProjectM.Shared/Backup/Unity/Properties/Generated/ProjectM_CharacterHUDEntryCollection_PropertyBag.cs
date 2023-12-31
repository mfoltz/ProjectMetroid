// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_CharacterHUDEntryCollection_PropertyBag
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
  public class ProjectM_CharacterHUDEntryCollection_PropertyBag : 
    ContainerPropertyBag<CharacterHUDEntryCollection>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 804742, RefRangeEnd = 804743, XrefRangeStart = 804669, XrefRangeEnd = 804742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_CharacterHUDEntryCollection_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_CharacterHUDEntryCollection_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_CharacterHUDEntryCollection_PropertyBag));
      ProjectM_CharacterHUDEntryCollection_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, 100670969);
    }

    public ProjectM_CharacterHUDEntryCollection_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class CharacterEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804585, XrefRangeEnd = 804587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804590, RefRangeEnd = 804591, XrefRangeStart = 804587, XrefRangeEnd = 804590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CharacterEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static CharacterEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (CharacterEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property>.NativeClassPtr, 100670970);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property>.NativeClassPtr, 100670971);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property>.NativeClassPtr, 100670972);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property>.NativeClassPtr, 100670973);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.CharacterEntry_Property>.NativeClassPtr, 100670974);
      }

      public CharacterEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BaseUnitEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804591, XrefRangeEnd = 804593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804596, RefRangeEnd = 804597, XrefRangeStart = 804593, XrefRangeEnd = 804596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BaseUnitEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static BaseUnitEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (BaseUnitEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property>.NativeClassPtr, 100670975);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property>.NativeClassPtr, 100670976);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property>.NativeClassPtr, 100670977);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property>.NativeClassPtr, 100670978);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitEntry_Property>.NativeClassPtr, 100670979);
      }

      public BaseUnitEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BaseUnitNamedEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804597, XrefRangeEnd = 804599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804602, RefRangeEnd = 804603, XrefRangeStart = 804599, XrefRangeEnd = 804602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BaseUnitNamedEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804603, XrefRangeEnd = 804605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static BaseUnitNamedEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (BaseUnitNamedEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property>.NativeClassPtr, 100670980);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property>.NativeClassPtr, 100670981);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property>.NativeClassPtr, 100670982);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property>.NativeClassPtr, 100670983);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitNamedEntry_Property>.NativeClassPtr, 100670984);
      }

      public BaseUnitNamedEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BaseUnitShortEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804605, XrefRangeEnd = 804607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804610, RefRangeEnd = 804611, XrefRangeStart = 804607, XrefRangeEnd = 804610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BaseUnitShortEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804611, XrefRangeEnd = 804613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static BaseUnitShortEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (BaseUnitShortEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property>.NativeClassPtr, 100670985);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property>.NativeClassPtr, 100670986);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property>.NativeClassPtr, 100670987);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property>.NativeClassPtr, 100670988);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitShortEntry_Property>.NativeClassPtr, 100670989);
      }

      public BaseUnitShortEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BloodTypeEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804613, XrefRangeEnd = 804615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804618, RefRangeEnd = 804619, XrefRangeStart = 804615, XrefRangeEnd = 804618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BloodTypeEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804619, XrefRangeEnd = 804621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static BloodTypeEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (BloodTypeEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property>.NativeClassPtr, 100670990);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property>.NativeClassPtr, 100670991);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property>.NativeClassPtr, 100670992);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property>.NativeClassPtr, 100670993);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BloodTypeEntry_Property>.NativeClassPtr, 100670994);
      }

      public BloodTypeEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BossUnitEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804621, XrefRangeEnd = 804623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804626, RefRangeEnd = 804627, XrefRangeStart = 804623, XrefRangeEnd = 804626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BossUnitEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804627, XrefRangeEnd = 804629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static BossUnitEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (BossUnitEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property>.NativeClassPtr, 100670995);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property>.NativeClassPtr, 100670996);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property>.NativeClassPtr, 100670997);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property>.NativeClassPtr, 100670998);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BossUnitEntry_Property>.NativeClassPtr, 100670999);
      }

      public BossUnitEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class EliteUnitEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804629, XrefRangeEnd = 804631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804634, RefRangeEnd = 804635, XrefRangeStart = 804631, XrefRangeEnd = 804634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EliteUnitEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804635, XrefRangeEnd = 804637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static EliteUnitEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (EliteUnitEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property>.NativeClassPtr, 100671000);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property>.NativeClassPtr, 100671001);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property>.NativeClassPtr, 100671002);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property>.NativeClassPtr, 100671003);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitEntry_Property>.NativeClassPtr, 100671004);
      }

      public EliteUnitEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class EliteUnitNamedEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804637, XrefRangeEnd = 804639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804642, RefRangeEnd = 804643, XrefRangeStart = 804639, XrefRangeEnd = 804642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EliteUnitNamedEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804643, XrefRangeEnd = 804645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static EliteUnitNamedEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (EliteUnitNamedEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property>.NativeClassPtr, 100671005);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property>.NativeClassPtr, 100671006);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property>.NativeClassPtr, 100671007);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property>.NativeClassPtr, 100671008);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.EliteUnitNamedEntry_Property>.NativeClassPtr, 100671009);
      }

      public EliteUnitNamedEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class VampireHunterEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804645, XrefRangeEnd = 804647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804650, RefRangeEnd = 804651, XrefRangeStart = 804647, XrefRangeEnd = 804650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VampireHunterEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804651, XrefRangeEnd = 804653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static VampireHunterEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (VampireHunterEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property>.NativeClassPtr, 100671010);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property>.NativeClassPtr, 100671011);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property>.NativeClassPtr, 100671012);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property>.NativeClassPtr, 100671013);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.VampireHunterEntry_Property>.NativeClassPtr, 100671014);
      }

      public VampireHunterEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BaseUnitTraderEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804653, XrefRangeEnd = 804655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804658, RefRangeEnd = 804659, XrefRangeStart = 804655, XrefRangeEnd = 804658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BaseUnitTraderEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804659, XrefRangeEnd = 804661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static BaseUnitTraderEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (BaseUnitTraderEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property>.NativeClassPtr, 100671015);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property>.NativeClassPtr, 100671016);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property>.NativeClassPtr, 100671017);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property>.NativeClassPtr, 100671018);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.BaseUnitTraderEntry_Property>.NativeClassPtr, 100671019);
      }

      public BaseUnitTraderEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SiegeUnitEntry_Property : Property<CharacterHUDEntryCollection, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804661, XrefRangeEnd = 804663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804666, RefRangeEnd = 804667, XrefRangeStart = 804663, XrefRangeEnd = 804666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SiegeUnitEntry_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref CharacterHUDEntryCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer1 = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer1 == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer1);
        local = hudEntryCollection;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804667, XrefRangeEnd = 804669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CharacterHUDEntryCollection container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CharacterHUDEntryCollection local = ref container;
        IntPtr pointer = ptr;
        CharacterHUDEntryCollection hudEntryCollection = pointer == IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
        local = hudEntryCollection;
      }

      static SiegeUnitEntry_Property()
      {
        Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag>.NativeClassPtr, nameof (SiegeUnitEntry_Property));
        ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property>.NativeClassPtr, 100671020);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property>.NativeClassPtr, 100671021);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property>.NativeClassPtr, 100671022);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_CharacterHUDEntryCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property>.NativeClassPtr, 100671023);
        ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CharacterHUDEntryCollection_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CharacterHUDEntryCollection_PropertyBag.SiegeUnitEntry_Property>.NativeClassPtr, 100671024);
      }

      public SiegeUnitEntry_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
