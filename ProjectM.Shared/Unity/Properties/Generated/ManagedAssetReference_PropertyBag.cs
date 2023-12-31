// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ManagedAssetReference_PropertyBag
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
  public class ManagedAssetReference_PropertyBag : ContainerPropertyBag<ManagedAssetReference>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 804469, RefRangeEnd = 804470, XrefRangeStart = 804453, XrefRangeEnd = 804469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedAssetReference_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedAssetReference_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedAssetReference_PropertyBag()
    {
      Il2CppClassPointerStore<ManagedAssetReference_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ManagedAssetReference_PropertyBag));
      ManagedAssetReference_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag>.NativeClassPtr, 100670925);
    }

    public ManagedAssetReference_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class AssetLookup_Property : 
      Property<ManagedAssetReference, Dictionary<AssetGuid, UnityEngine.Object>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_Object_byref_ManagedAssetReference_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetReference_Dictionary_2_AssetGuid_Object_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804447, XrefRangeEnd = 804449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 804452, RefRangeEnd = 804453, XrefRangeStart = 804449, XrefRangeEnd = 804452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AssetLookup_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag.AssetLookup_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Dictionary<AssetGuid, UnityEngine.Object> GetValue(
        ref ManagedAssetReference container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_Object_byref_ManagedAssetReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedAssetReference local = ref container;
        IntPtr pointer1 = ptr;
        ManagedAssetReference managedAssetReference = pointer1 == IntPtr.Zero ? (ManagedAssetReference) null : new ManagedAssetReference(pointer1);
        local = managedAssetReference;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Dictionary<AssetGuid, UnityEngine.Object>) null : new Dictionary<AssetGuid, UnityEngine.Object>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ManagedAssetReference container,
        Dictionary<AssetGuid, UnityEngine.Object> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetReference_Dictionary_2_AssetGuid_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ManagedAssetReference local = ref container;
        IntPtr pointer = ptr;
        ManagedAssetReference managedAssetReference = pointer == IntPtr.Zero ? (ManagedAssetReference) null : new ManagedAssetReference(pointer);
        local = managedAssetReference;
      }

      static AssetLookup_Property()
      {
        Il2CppClassPointerStore<ManagedAssetReference_PropertyBag.AssetLookup_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag>.NativeClassPtr, nameof (AssetLookup_Property));
        ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag.AssetLookup_Property>.NativeClassPtr, 100670926);
        ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag.AssetLookup_Property>.NativeClassPtr, 100670927);
        ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag.AssetLookup_Property>.NativeClassPtr, 100670928);
        ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_AssetGuid_Object_byref_ManagedAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag.AssetLookup_Property>.NativeClassPtr, 100670929);
        ManagedAssetReference_PropertyBag.AssetLookup_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ManagedAssetReference_Dictionary_2_AssetGuid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAssetReference_PropertyBag.AssetLookup_Property>.NativeClassPtr, 100670930);
      }

      public AssetLookup_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
