// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.DyeSwatchCollectionData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class DyeSwatchCollectionData_PropertyBag : ContainerPropertyBag<DyeSwatchCollectionData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1169548, RefRangeEnd = 1169549, XrefRangeStart = 1169525, XrefRangeEnd = 1169548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DyeSwatchCollectionData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeSwatchCollectionData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DyeSwatchCollectionData_PropertyBag()
    {
      Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (DyeSwatchCollectionData_PropertyBag));
      DyeSwatchCollectionData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag>.NativeClassPtr, 100692704);
    }

    public DyeSwatchCollectionData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class ColorSwatchData_Property : 
      Property<DyeSwatchCollectionData, Il2CppReferenceArray<ColorSwatchData>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_ColorSwatchData_byref_DyeSwatchCollectionData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_DyeSwatchCollectionData_Il2CppReferenceArray_1_ColorSwatchData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169500, XrefRangeEnd = 1169502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169518, RefRangeEnd = 1169519, XrefRangeStart = 1169502, XrefRangeEnd = 1169518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ColorSwatchData_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppReferenceArray<ColorSwatchData> GetValue(
        ref DyeSwatchCollectionData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_ColorSwatchData_byref_DyeSwatchCollectionData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref DyeSwatchCollectionData local = ref container;
        IntPtr pointer = ptr;
        DyeSwatchCollectionData swatchCollectionData = pointer == IntPtr.Zero ? (DyeSwatchCollectionData) null : new DyeSwatchCollectionData(pointer);
        local = swatchCollectionData;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ColorSwatchData>) null : new Il2CppReferenceArray<ColorSwatchData>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref DyeSwatchCollectionData container,
        Il2CppReferenceArray<ColorSwatchData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_DyeSwatchCollectionData_Il2CppReferenceArray_1_ColorSwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref DyeSwatchCollectionData local = ref container;
        IntPtr pointer = ptr;
        DyeSwatchCollectionData swatchCollectionData = pointer == IntPtr.Zero ? (DyeSwatchCollectionData) null : new DyeSwatchCollectionData(pointer);
        local = swatchCollectionData;
      }

      static ColorSwatchData_Property()
      {
        Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag>.NativeClassPtr, nameof (ColorSwatchData_Property));
        DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692705);
        DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692706);
        DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692707);
        DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_ColorSwatchData_byref_DyeSwatchCollectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692708);
        DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_DyeSwatchCollectionData_Il2CppReferenceArray_1_ColorSwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692709);
      }

      public ColorSwatchData_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ID_Property : Property<DyeSwatchCollectionData, PrefabGUID>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_DyeSwatchCollectionData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_DyeSwatchCollectionData_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169519, XrefRangeEnd = 1169521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169524, RefRangeEnd = 1169525, XrefRangeStart = 1169521, XrefRangeEnd = 1169524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ID_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ID_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PrefabGUID GetValue(ref DyeSwatchCollectionData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_DyeSwatchCollectionData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref DyeSwatchCollectionData local = ref container;
        IntPtr pointer = ptr;
        DyeSwatchCollectionData swatchCollectionData = pointer == IntPtr.Zero ? (DyeSwatchCollectionData) null : new DyeSwatchCollectionData(pointer);
        local = swatchCollectionData;
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref DyeSwatchCollectionData container, PrefabGUID value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_DyeSwatchCollectionData_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref DyeSwatchCollectionData local = ref container;
        IntPtr pointer = ptr;
        DyeSwatchCollectionData swatchCollectionData = pointer == IntPtr.Zero ? (DyeSwatchCollectionData) null : new DyeSwatchCollectionData(pointer);
        local = swatchCollectionData;
      }

      static ID_Property()
      {
        Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ID_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag>.NativeClassPtr, nameof (ID_Property));
        DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ID_Property>.NativeClassPtr, 100692710);
        DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ID_Property>.NativeClassPtr, 100692711);
        DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ID_Property>.NativeClassPtr, 100692712);
        DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_DyeSwatchCollectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ID_Property>.NativeClassPtr, 100692713);
        DyeSwatchCollectionData_PropertyBag.ID_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_DyeSwatchCollectionData_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData_PropertyBag.ID_Property>.NativeClassPtr, 100692714);
      }

      public ID_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
