// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ManagedMapIconData_PropertyBag
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

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_ManagedMapIconData_PropertyBag : ContainerPropertyBag<ManagedMapIconData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 805217, RefRangeEnd = 805218, XrefRangeStart = 805161, XrefRangeEnd = 805217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ManagedMapIconData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedMapIconData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ManagedMapIconData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_ManagedMapIconData_PropertyBag));
      ProjectM_ManagedMapIconData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr, 100671148);
    }

    public ProjectM_ManagedMapIconData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class PrefabGUID_Property : Property<ManagedMapIconData, PrefabGUID>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_ManagedMapIconData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805115, XrefRangeEnd = 805117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805120, RefRangeEnd = 805121, XrefRangeStart = 805117, XrefRangeEnd = 805120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefabGUID_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PrefabGUID GetValue(ref ManagedMapIconData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_ManagedMapIconData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedMapIconData container, PrefabGUID value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
      }

      static PrefabGUID_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr, nameof (PrefabGUID_Property));
        ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property>.NativeClassPtr, 100671149);
        ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property>.NativeClassPtr, 100671150);
        ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property>.NativeClassPtr, 100671151);
        ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_ManagedMapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property>.NativeClassPtr, 100671152);
        ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.PrefabGUID_Property>.NativeClassPtr, 100671153);
      }

      public PrefabGUID_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class VisualOverrides_Property : 
      Property<ManagedMapIconData, Il2CppReferenceArray<MapIconStates>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_MapIconStates_byref_ManagedMapIconData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_Il2CppReferenceArray_1_MapIconStates_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805121, XrefRangeEnd = 805123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805126, RefRangeEnd = 805127, XrefRangeStart = 805123, XrefRangeEnd = 805126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VisualOverrides_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppReferenceArray<MapIconStates> GetValue(
        ref ManagedMapIconData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_MapIconStates_byref_ManagedMapIconData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<MapIconStates>) null : new Il2CppReferenceArray<MapIconStates>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedMapIconData container,
        Il2CppReferenceArray<MapIconStates> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_Il2CppReferenceArray_1_MapIconStates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
      }

      static VisualOverrides_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr, nameof (VisualOverrides_Property));
        ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property>.NativeClassPtr, 100671154);
        ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property>.NativeClassPtr, 100671155);
        ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property>.NativeClassPtr, 100671156);
        ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_MapIconStates_byref_ManagedMapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property>.NativeClassPtr, 100671157);
        ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_Il2CppReferenceArray_1_MapIconStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.VisualOverrides_Property>.NativeClassPtr, 100671158);
      }

      public VisualOverrides_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class NormalState_Property : Property<ManagedMapIconData, MapIconState>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconState_byref_ManagedMapIconData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_MapIconState_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805127, XrefRangeEnd = 805129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805132, RefRangeEnd = 805133, XrefRangeStart = 805129, XrefRangeEnd = 805132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NormalState_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe MapIconState GetValue(ref ManagedMapIconData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr pointer1 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconState_byref_ManagedMapIconData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer2 = ptr;
        ManagedMapIconData managedMapIconData = pointer2 == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer2);
        local = managedMapIconData;
        return new MapIconState(pointer1);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805133, XrefRangeEnd = 805135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedMapIconData container, MapIconState value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_MapIconState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
      }

      static NormalState_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr, nameof (NormalState_Property));
        ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property>.NativeClassPtr, 100671159);
        ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property>.NativeClassPtr, 100671160);
        ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property>.NativeClassPtr, 100671161);
        ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconState_byref_ManagedMapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property>.NativeClassPtr, 100671162);
        ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_MapIconState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.NormalState_Property>.NativeClassPtr, 100671163);
      }

      public NormalState_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class HoverState_Property : Property<ManagedMapIconData, MapIconState>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconState_byref_ManagedMapIconData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_MapIconState_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805135, XrefRangeEnd = 805137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805140, RefRangeEnd = 805141, XrefRangeStart = 805137, XrefRangeEnd = 805140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HoverState_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe MapIconState GetValue(ref ManagedMapIconData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr pointer1 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconState_byref_ManagedMapIconData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer2 = ptr;
        ManagedMapIconData managedMapIconData = pointer2 == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer2);
        local = managedMapIconData;
        return new MapIconState(pointer1);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805141, XrefRangeEnd = 805143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedMapIconData container, MapIconState value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_MapIconState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
      }

      static HoverState_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr, nameof (HoverState_Property));
        ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property>.NativeClassPtr, 100671164);
        ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property>.NativeClassPtr, 100671165);
        ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property>.NativeClassPtr, 100671166);
        ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MapIconState_byref_ManagedMapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property>.NativeClassPtr, 100671167);
        ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_MapIconState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HoverState_Property>.NativeClassPtr, 100671168);
      }

      public HoverState_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class HeaderLocalizedKey_Property : Property<ManagedMapIconData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedMapIconData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805143, XrefRangeEnd = 805145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805148, RefRangeEnd = 805149, XrefRangeStart = 805145, XrefRangeEnd = 805148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HeaderLocalizedKey_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedMapIconData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedMapIconData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedMapIconData container, LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
      }

      static HeaderLocalizedKey_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr, nameof (HeaderLocalizedKey_Property));
        ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property>.NativeClassPtr, 100671169);
        ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property>.NativeClassPtr, 100671170);
        ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property>.NativeClassPtr, 100671171);
        ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedMapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property>.NativeClassPtr, 100671172);
        ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.HeaderLocalizedKey_Property>.NativeClassPtr, 100671173);
      }

      public HeaderLocalizedKey_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SubHeaderLocalizedKey_Property : Property<ManagedMapIconData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedMapIconData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805149, XrefRangeEnd = 805151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805154, RefRangeEnd = 805155, XrefRangeStart = 805151, XrefRangeEnd = 805154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SubHeaderLocalizedKey_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref ManagedMapIconData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedMapIconData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedMapIconData container, LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
      }

      static SubHeaderLocalizedKey_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr, nameof (SubHeaderLocalizedKey_Property));
        ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property>.NativeClassPtr, 100671174);
        ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property>.NativeClassPtr, 100671175);
        ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property>.NativeClassPtr, 100671176);
        ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_ManagedMapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property>.NativeClassPtr, 100671177);
        ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.SubHeaderLocalizedKey_Property>.NativeClassPtr, 100671178);
      }

      public SubHeaderLocalizedKey_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ShowObjectRotation_Property : Property<ManagedMapIconData, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ManagedMapIconData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805155, XrefRangeEnd = 805157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805160, RefRangeEnd = 805161, XrefRangeStart = 805157, XrefRangeEnd = 805160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ShowObjectRotation_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref ManagedMapIconData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ManagedMapIconData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ManagedMapIconData container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedMapIconData local = ref container;
        IntPtr pointer = ptr;
        ManagedMapIconData managedMapIconData = pointer == IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
        local = managedMapIconData;
      }

      static ShowObjectRotation_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag>.NativeClassPtr, nameof (ShowObjectRotation_Property));
        ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property>.NativeClassPtr, 100671179);
        ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property>.NativeClassPtr, 100671180);
        ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property>.NativeClassPtr, 100671181);
        ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ManagedMapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property>.NativeClassPtr, 100671182);
        ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedMapIconData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedMapIconData_PropertyBag.ShowObjectRotation_Property>.NativeClassPtr, 100671183);
      }

      public ShowObjectRotation_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
