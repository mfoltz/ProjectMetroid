// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.SwatchData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class SwatchData_PropertyBag : ContainerPropertyBag<SwatchData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1169423, RefRangeEnd = 1169424, XrefRangeStart = 1169377, XrefRangeEnd = 1169423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SwatchData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SwatchData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SwatchData_PropertyBag()
    {
      Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (SwatchData_PropertyBag));
      SwatchData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr, 100692646);
    }

    public SwatchData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Material_Property : Property<SwatchData, Material>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_Material_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169328, XrefRangeEnd = 1169330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169346, RefRangeEnd = 1169347, XrefRangeStart = 1169330, XrefRangeEnd = 1169346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Material_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchData_PropertyBag.Material_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Material GetValue(ref SwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer1 = ptr;
        SwatchData swatchData = pointer1 == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer1);
        local = swatchData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Material) null : new Material(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref SwatchData container, Material value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
      }

      static Material_Property()
      {
        Il2CppClassPointerStore<SwatchData_PropertyBag.Material_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr, nameof (Material_Property));
        SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Material_Property>.NativeClassPtr, 100692647);
        SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Material_Property>.NativeClassPtr, 100692648);
        SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Material_Property>.NativeClassPtr, 100692649);
        SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Material_Property>.NativeClassPtr, 100692650);
        SwatchData_PropertyBag.Material_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Material_Property>.NativeClassPtr, 100692651);
      }

      public Material_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OriginalMaterialColor_Property : Property<SwatchData, float4>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169347, XrefRangeEnd = 1169349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169352, RefRangeEnd = 1169353, XrefRangeStart = 1169349, XrefRangeEnd = 1169352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OriginalMaterialColor_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchData_PropertyBag.OriginalMaterialColor_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float4 GetValue(ref SwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
        return *(float4*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref SwatchData container, float4 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
      }

      static OriginalMaterialColor_Property()
      {
        Il2CppClassPointerStore<SwatchData_PropertyBag.OriginalMaterialColor_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr, nameof (OriginalMaterialColor_Property));
        SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.OriginalMaterialColor_Property>.NativeClassPtr, 100692652);
        SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.OriginalMaterialColor_Property>.NativeClassPtr, 100692653);
        SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.OriginalMaterialColor_Property>.NativeClassPtr, 100692654);
        SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.OriginalMaterialColor_Property>.NativeClassPtr, 100692655);
        SwatchData_PropertyBag.OriginalMaterialColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.OriginalMaterialColor_Property>.NativeClassPtr, 100692656);
      }

      public OriginalMaterialColor_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Color_Property : Property<SwatchData, float4>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169353, XrefRangeEnd = 1169355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169358, RefRangeEnd = 1169359, XrefRangeStart = 1169355, XrefRangeEnd = 1169358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Color_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchData_PropertyBag.Color_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float4 GetValue(ref SwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
        return *(float4*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref SwatchData container, float4 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
      }

      static Color_Property()
      {
        Il2CppClassPointerStore<SwatchData_PropertyBag.Color_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr, nameof (Color_Property));
        SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Color_Property>.NativeClassPtr, 100692657);
        SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Color_Property>.NativeClassPtr, 100692658);
        SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Color_Property>.NativeClassPtr, 100692659);
        SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Color_Property>.NativeClassPtr, 100692660);
        SwatchData_PropertyBag.Color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Color_Property>.NativeClassPtr, 100692661);
      }

      public Color_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class EndColor_Property : Property<SwatchData, float4>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169359, XrefRangeEnd = 1169361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169364, RefRangeEnd = 1169365, XrefRangeStart = 1169361, XrefRangeEnd = 1169364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EndColor_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchData_PropertyBag.EndColor_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float4 GetValue(ref SwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
        return *(float4*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref SwatchData container, float4 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
      }

      static EndColor_Property()
      {
        Il2CppClassPointerStore<SwatchData_PropertyBag.EndColor_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr, nameof (EndColor_Property));
        SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.EndColor_Property>.NativeClassPtr, 100692662);
        SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.EndColor_Property>.NativeClassPtr, 100692663);
        SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.EndColor_Property>.NativeClassPtr, 100692664);
        SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float4_byref_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.EndColor_Property>.NativeClassPtr, 100692665);
        SwatchData_PropertyBag.EndColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.EndColor_Property>.NativeClassPtr, 100692666);
      }

      public EndColor_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Type_Property : Property<SwatchData, SwatchType>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_SwatchType_byref_SwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_SwatchType_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169365, XrefRangeEnd = 1169367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169370, RefRangeEnd = 1169371, XrefRangeStart = 1169367, XrefRangeEnd = 1169370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Type_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchData_PropertyBag.Type_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe SwatchType GetValue(ref SwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_SwatchType_byref_SwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
        return *(SwatchType*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref SwatchData container, SwatchType value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_SwatchType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
      }

      static Type_Property()
      {
        Il2CppClassPointerStore<SwatchData_PropertyBag.Type_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr, nameof (Type_Property));
        SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Type_Property>.NativeClassPtr, 100692667);
        SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Type_Property>.NativeClassPtr, 100692668);
        SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Type_Property>.NativeClassPtr, 100692669);
        SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_SwatchType_byref_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Type_Property>.NativeClassPtr, 100692670);
        SwatchData_PropertyBag.Type_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_SwatchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.Type_Property>.NativeClassPtr, 100692671);
      }

      public Type_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class VFXSetType_Property : Property<SwatchData, VFXColorSetType>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_VFXColorSetType_byref_SwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_VFXColorSetType_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169371, XrefRangeEnd = 1169373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169376, RefRangeEnd = 1169377, XrefRangeStart = 1169373, XrefRangeEnd = 1169376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VFXSetType_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchData_PropertyBag.VFXSetType_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe VFXColorSetType GetValue(ref SwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_VFXColorSetType_byref_SwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
        return *(VFXColorSetType*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref SwatchData container, VFXColorSetType value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_VFXColorSetType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SwatchData local = ref container;
        IntPtr pointer = ptr;
        SwatchData swatchData = pointer == IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
        local = swatchData;
      }

      static VFXSetType_Property()
      {
        Il2CppClassPointerStore<SwatchData_PropertyBag.VFXSetType_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwatchData_PropertyBag>.NativeClassPtr, nameof (VFXSetType_Property));
        SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.VFXSetType_Property>.NativeClassPtr, 100692672);
        SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.VFXSetType_Property>.NativeClassPtr, 100692673);
        SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.VFXSetType_Property>.NativeClassPtr, 100692674);
        SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_VFXColorSetType_byref_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.VFXSetType_Property>.NativeClassPtr, 100692675);
        SwatchData_PropertyBag.VFXSetType_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwatchData_VFXColorSetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData_PropertyBag.VFXSetType_Property>.NativeClassPtr, 100692676);
      }

      public VFXSetType_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
