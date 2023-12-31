// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ManagedItemSet_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_ManagedItemSet_PropertyBag : ContainerPropertyBag<ManagedItemSet>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805010, XrefRangeEnd = 805033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ManagedItemSet_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedItemSet_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ManagedItemSet_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_ManagedItemSet_PropertyBag));
      ProjectM_ManagedItemSet_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag>.NativeClassPtr, 100671110);
    }

    public ProjectM_ManagedItemSet_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class PrefabName_Property : Property<ManagedItemSet, string>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedItemSet_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemSet_String_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804996, XrefRangeEnd = 804998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805001, RefRangeEnd = 805003, XrefRangeStart = 804998, XrefRangeEnd = 805001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefabName_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe string GetValue(ref ManagedItemSet container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedItemSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemSet local = ref container;
        IntPtr pointer = ptr;
        ManagedItemSet managedItemSet = pointer == IntPtr.Zero ? (ManagedItemSet) null : new ManagedItemSet(pointer);
        local = managedItemSet;
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedItemSet container, string value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemSet_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemSet local = ref container;
        IntPtr pointer = ptr;
        ManagedItemSet managedItemSet = pointer == IntPtr.Zero ? (ManagedItemSet) null : new ManagedItemSet(pointer);
        local = managedItemSet;
      }

      static PrefabName_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag>.NativeClassPtr, nameof (PrefabName_Property));
        ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671111);
        ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671112);
        ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671113);
        ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_ManagedItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671114);
        ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.PrefabName_Property>.NativeClassPtr, 100671115);
      }

      public PrefabName_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ItemSetEntries_Property : Property<ManagedItemSet, List<ItemSetEntry>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_ItemSetEntry_byref_ManagedItemSet_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemSet_List_1_ItemSetEntry_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805003, XrefRangeEnd = 805005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805008, RefRangeEnd = 805010, XrefRangeStart = 805005, XrefRangeEnd = 805008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ItemSetEntries_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe List<ItemSetEntry> GetValue(ref ManagedItemSet container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_ItemSetEntry_byref_ManagedItemSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemSet local = ref container;
        IntPtr pointer1 = ptr;
        ManagedItemSet managedItemSet = pointer1 == IntPtr.Zero ? (ManagedItemSet) null : new ManagedItemSet(pointer1);
        local = managedItemSet;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (List<ItemSetEntry>) null : new List<ItemSetEntry>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ManagedItemSet container, List<ItemSetEntry> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemSet_List_1_ItemSetEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedItemSet local = ref container;
        IntPtr pointer = ptr;
        ManagedItemSet managedItemSet = pointer == IntPtr.Zero ? (ManagedItemSet) null : new ManagedItemSet(pointer);
        local = managedItemSet;
      }

      static ItemSetEntries_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag>.NativeClassPtr, nameof (ItemSetEntries_Property));
        ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property>.NativeClassPtr, 100671116);
        ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property>.NativeClassPtr, 100671117);
        ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property>.NativeClassPtr, 100671118);
        ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_ItemSetEntry_byref_ManagedItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property>.NativeClassPtr, 100671119);
        ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedItemSet_List_1_ItemSetEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedItemSet_PropertyBag.ItemSetEntries_Property>.NativeClassPtr, 100671120);
      }

      public ItemSetEntries_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
