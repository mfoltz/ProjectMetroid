// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.SubSwatchData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class SubSwatchData_PropertyBag : ContainerPropertyBag<SubSwatchData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1169327, RefRangeEnd = 1169328, XrefRangeStart = 1169304, XrefRangeEnd = 1169327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SubSwatchData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSwatchData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubSwatchData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SubSwatchData_PropertyBag()
    {
      Il2CppClassPointerStore<SubSwatchData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (SubSwatchData_PropertyBag));
      SubSwatchData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag>.NativeClassPtr, 100692635);
    }

    public SubSwatchData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class ColorSwatchData_Property : Property<SubSwatchData, Dictionary<int, SwatchData>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_Int32_SwatchData_byref_SubSwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SubSwatchData_Dictionary_2_Int32_SwatchData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169279, XrefRangeEnd = 1169281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169297, RefRangeEnd = 1169298, XrefRangeStart = 1169281, XrefRangeEnd = 1169297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ColorSwatchData_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Dictionary<int, SwatchData> GetValue(ref SubSwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_Int32_SwatchData_byref_SubSwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SubSwatchData local = ref container;
        IntPtr pointer1 = ptr;
        SubSwatchData subSwatchData = pointer1 == IntPtr.Zero ? (SubSwatchData) null : new SubSwatchData(pointer1);
        local = subSwatchData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Dictionary<int, SwatchData>) null : new Dictionary<int, SwatchData>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref SubSwatchData container,
        Dictionary<int, SwatchData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SubSwatchData_Dictionary_2_Int32_SwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SubSwatchData local = ref container;
        IntPtr pointer = ptr;
        SubSwatchData subSwatchData = pointer == IntPtr.Zero ? (SubSwatchData) null : new SubSwatchData(pointer);
        local = subSwatchData;
      }

      static ColorSwatchData_Property()
      {
        Il2CppClassPointerStore<SubSwatchData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubSwatchData_PropertyBag>.NativeClassPtr, nameof (ColorSwatchData_Property));
        SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692636);
        SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692637);
        SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692638);
        SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Dictionary_2_Int32_SwatchData_byref_SubSwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692639);
        SubSwatchData_PropertyBag.ColorSwatchData_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SubSwatchData_Dictionary_2_Int32_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ColorSwatchData_Property>.NativeClassPtr, 100692640);
      }

      public ColorSwatchData_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ID_Property : Property<SubSwatchData, PrefabGUID>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_SubSwatchData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SubSwatchData_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169298, XrefRangeEnd = 1169300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169303, RefRangeEnd = 1169304, XrefRangeStart = 1169300, XrefRangeEnd = 1169303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ID_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ID_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PrefabGUID GetValue(ref SubSwatchData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_SubSwatchData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SubSwatchData local = ref container;
        IntPtr pointer = ptr;
        SubSwatchData subSwatchData = pointer == IntPtr.Zero ? (SubSwatchData) null : new SubSwatchData(pointer);
        local = subSwatchData;
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref SubSwatchData container, PrefabGUID value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SubSwatchData_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SubSwatchData local = ref container;
        IntPtr pointer = ptr;
        SubSwatchData subSwatchData = pointer == IntPtr.Zero ? (SubSwatchData) null : new SubSwatchData(pointer);
        local = subSwatchData;
      }

      static ID_Property()
      {
        Il2CppClassPointerStore<SubSwatchData_PropertyBag.ID_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubSwatchData_PropertyBag>.NativeClassPtr, nameof (ID_Property));
        SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ID_Property>.NativeClassPtr, 100692641);
        SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ID_Property>.NativeClassPtr, 100692642);
        SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ID_Property>.NativeClassPtr, 100692643);
        SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_SubSwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ID_Property>.NativeClassPtr, 100692644);
        SubSwatchData_PropertyBag.ID_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SubSwatchData_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData_PropertyBag.ID_Property>.NativeClassPtr, 100692645);
      }

      public ID_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
