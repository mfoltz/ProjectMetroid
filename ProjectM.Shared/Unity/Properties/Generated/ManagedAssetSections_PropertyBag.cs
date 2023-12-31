// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ManagedAssetSections_PropertyBag
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
  public class ManagedAssetSections_PropertyBag : ContainerPropertyBag<ManagedAssetSections>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 804387, RefRangeEnd = 804388, XrefRangeStart = 804361, XrefRangeEnd = 804387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedAssetSections_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedAssetSections_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedAssetSections_PropertyBag()
    {
      Il2CppClassPointerStore<ManagedAssetSections_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ManagedAssetSections_PropertyBag));
      ManagedAssetSections_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag>.NativeClassPtr, 100670893);
    }

    public ManagedAssetSections_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class GuidToSectionIndex_Property : 
      Property<ManagedAssetSections, Dictionary<AssetGuid, int>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_Int32_byref_ManagedAssetSections_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetSections_Dictionary_2_AssetGuid_Int32_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804347, XrefRangeEnd = 804349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804352, RefRangeEnd = 804353, XrefRangeStart = 804349, XrefRangeEnd = 804352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GuidToSectionIndex_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Dictionary<AssetGuid, int> GetValue(ref ManagedAssetSections container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_Int32_byref_ManagedAssetSections_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedAssetSections local = ref container;
        IntPtr pointer1 = ptr;
        ManagedAssetSections managedAssetSections = pointer1 == IntPtr.Zero ? (ManagedAssetSections) null : new ManagedAssetSections(pointer1);
        local = managedAssetSections;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Dictionary<AssetGuid, int>) null : new Dictionary<AssetGuid, int>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedAssetSections container,
        Dictionary<AssetGuid, int> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetSections_Dictionary_2_AssetGuid_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedAssetSections local = ref container;
        IntPtr pointer = ptr;
        ManagedAssetSections managedAssetSections = pointer == IntPtr.Zero ? (ManagedAssetSections) null : new ManagedAssetSections(pointer);
        local = managedAssetSections;
      }

      static GuidToSectionIndex_Property()
      {
        Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag>.NativeClassPtr, nameof (GuidToSectionIndex_Property));
        ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property>.NativeClassPtr, 100670894);
        ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property>.NativeClassPtr, 100670895);
        ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property>.NativeClassPtr, 100670896);
        ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_Int32_byref_ManagedAssetSections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property>.NativeClassPtr, 100670897);
        ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetSections_Dictionary_2_AssetGuid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToSectionIndex_Property>.NativeClassPtr, 100670898);
      }

      public GuidToSectionIndex_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class GuidToAssetName_Property : 
      Property<ManagedAssetSections, Dictionary<AssetGuid, string>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_String_byref_ManagedAssetSections_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetSections_Dictionary_2_AssetGuid_String_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804353, XrefRangeEnd = 804355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804358, RefRangeEnd = 804359, XrefRangeStart = 804355, XrefRangeEnd = 804358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GuidToAssetName_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToAssetName_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Dictionary<AssetGuid, string> GetValue(
        ref ManagedAssetSections container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_String_byref_ManagedAssetSections_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedAssetSections local = ref container;
        IntPtr pointer1 = ptr;
        ManagedAssetSections managedAssetSections = pointer1 == IntPtr.Zero ? (ManagedAssetSections) null : new ManagedAssetSections(pointer1);
        local = managedAssetSections;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Dictionary<AssetGuid, string>) null : new Dictionary<AssetGuid, string>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804359, XrefRangeEnd = 804361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedAssetSections container,
        Dictionary<AssetGuid, string> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetSections_Dictionary_2_AssetGuid_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedAssetSections local = ref container;
        IntPtr pointer = ptr;
        ManagedAssetSections managedAssetSections = pointer == IntPtr.Zero ? (ManagedAssetSections) null : new ManagedAssetSections(pointer);
        local = managedAssetSections;
      }

      static GuidToAssetName_Property()
      {
        Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToAssetName_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag>.NativeClassPtr, nameof (GuidToAssetName_Property));
        ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToAssetName_Property>.NativeClassPtr, 100670899);
        ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToAssetName_Property>.NativeClassPtr, 100670900);
        ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToAssetName_Property>.NativeClassPtr, 100670901);
        ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_String_byref_ManagedAssetSections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToAssetName_Property>.NativeClassPtr, 100670902);
        ManagedAssetSections_PropertyBag.GuidToAssetName_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetSections_Dictionary_2_AssetGuid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetSections_PropertyBag.GuidToAssetName_Property>.NativeClassPtr, 100670903);
      }

      public GuidToAssetName_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
