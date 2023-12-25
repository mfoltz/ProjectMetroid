// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ColorSwatchData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM;
using System;
using Unity.Mathematics;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ColorSwatchData_PropertyBag : ContainerPropertyBag<ColorSwatchData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1169610, RefRangeEnd = 1169611, XrefRangeStart = 1169580, XrefRangeEnd = 1169610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ColorSwatchData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSwatchData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ColorSwatchData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ColorSwatchData_PropertyBag()
    {
      Il2CppClassPointerStore<ColorSwatchData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ColorSwatchData_PropertyBag));
      ColorSwatchData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag>.NativeClassPtr, 100692715);
    }

    public ColorSwatchData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class UiColor_Property : Property<ColorSwatchData, float4>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_ColorSwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_float4_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169549, XrefRangeEnd = 1169551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169554, RefRangeEnd = 1169555, XrefRangeStart = 1169551, XrefRangeEnd = 1169554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UiColor_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.UiColor_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float4 GetValue(ref ColorSwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_ColorSwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ColorSwatchData local = ref container;
        IntPtr pointer = ptr;
        ColorSwatchData colorSwatchData = pointer == IntPtr.Zero ? (ColorSwatchData) null : new ColorSwatchData(pointer);
        local = colorSwatchData;
        return *(float4*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ColorSwatchData container, float4 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_float4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ColorSwatchData local = ref container;
        IntPtr pointer = ptr;
        ColorSwatchData colorSwatchData = pointer == IntPtr.Zero ? (ColorSwatchData) null : new ColorSwatchData(pointer);
        local = colorSwatchData;
      }

      static UiColor_Property()
      {
        Il2CppClassPointerStore<ColorSwatchData_PropertyBag.UiColor_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSwatchData_PropertyBag>.NativeClassPtr, nameof (UiColor_Property));
        ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.UiColor_Property>.NativeClassPtr, 100692716);
        ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.UiColor_Property>.NativeClassPtr, 100692717);
        ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.UiColor_Property>.NativeClassPtr, 100692718);
        ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_ColorSwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.UiColor_Property>.NativeClassPtr, 100692719);
        ColorSwatchData_PropertyBag.UiColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.UiColor_Property>.NativeClassPtr, 100692720);
      }

      public UiColor_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SubSwatchAssetGuids_Property : 
      Property<ColorSwatchData, Il2CppStructArray<PrefabGUID>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_ColorSwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_Il2CppStructArray_1_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169555, XrefRangeEnd = 1169557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169573, RefRangeEnd = 1169574, XrefRangeStart = 1169557, XrefRangeEnd = 1169573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SubSwatchAssetGuids_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppStructArray<PrefabGUID> GetValue(ref ColorSwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_ColorSwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ColorSwatchData local = ref container;
        IntPtr pointer = ptr;
        ColorSwatchData colorSwatchData = pointer == IntPtr.Zero ? (ColorSwatchData) null : new ColorSwatchData(pointer);
        local = colorSwatchData;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<PrefabGUID>) null : new Il2CppStructArray<PrefabGUID>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ColorSwatchData container,
        Il2CppStructArray<PrefabGUID> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_Il2CppStructArray_1_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ColorSwatchData local = ref container;
        IntPtr pointer = ptr;
        ColorSwatchData colorSwatchData = pointer == IntPtr.Zero ? (ColorSwatchData) null : new ColorSwatchData(pointer);
        local = colorSwatchData;
      }

      static SubSwatchAssetGuids_Property()
      {
        Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSwatchData_PropertyBag>.NativeClassPtr, nameof (SubSwatchAssetGuids_Property));
        ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property>.NativeClassPtr, 100692721);
        ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property>.NativeClassPtr, 100692722);
        ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property>.NativeClassPtr, 100692723);
        ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_ColorSwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property>.NativeClassPtr, 100692724);
        ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_Il2CppStructArray_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SubSwatchAssetGuids_Property>.NativeClassPtr, 100692725);
      }

      public SubSwatchAssetGuids_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SwatchNameHash_Property : Property<ColorSwatchData, int>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_ColorSwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_Int32_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169574, XrefRangeEnd = 1169576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169579, RefRangeEnd = 1169580, XrefRangeStart = 1169576, XrefRangeEnd = 1169579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SwatchNameHash_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SwatchNameHash_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe int GetValue(ref ColorSwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_ColorSwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ColorSwatchData local = ref container;
        IntPtr pointer = ptr;
        ColorSwatchData colorSwatchData = pointer == IntPtr.Zero ? (ColorSwatchData) null : new ColorSwatchData(pointer);
        local = colorSwatchData;
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ColorSwatchData container, int value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ColorSwatchData local = ref container;
        IntPtr pointer = ptr;
        ColorSwatchData colorSwatchData = pointer == IntPtr.Zero ? (ColorSwatchData) null : new ColorSwatchData(pointer);
        local = colorSwatchData;
      }

      static SwatchNameHash_Property()
      {
        Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SwatchNameHash_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSwatchData_PropertyBag>.NativeClassPtr, nameof (SwatchNameHash_Property));
        ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SwatchNameHash_Property>.NativeClassPtr, 100692726);
        ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SwatchNameHash_Property>.NativeClassPtr, 100692727);
        ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SwatchNameHash_Property>.NativeClassPtr, 100692728);
        ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_ColorSwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SwatchNameHash_Property>.NativeClassPtr, 100692729);
        ColorSwatchData_PropertyBag.SwatchNameHash_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ColorSwatchData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData_PropertyBag.SwatchNameHash_Property>.NativeClassPtr, 100692730);
      }

      public SwatchNameHash_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
