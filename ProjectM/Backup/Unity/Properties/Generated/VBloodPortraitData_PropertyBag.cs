// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.VBloodPortraitData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class VBloodPortraitData_PropertyBag : ContainerPropertyBag<VBloodPortraitData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1169666, RefRangeEnd = 1169667, XrefRangeStart = 1169635, XrefRangeEnd = 1169666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodPortraitData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodPortraitData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodPortraitData_PropertyBag()
    {
      Il2CppClassPointerStore<VBloodPortraitData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (VBloodPortraitData_PropertyBag));
      VBloodPortraitData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag>.NativeClassPtr, 100692731);
    }

    public VBloodPortraitData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class LargeStandard_Property : Property<VBloodPortraitData, AssetGuid>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169611, XrefRangeEnd = 1169613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169616, RefRangeEnd = 1169617, XrefRangeStart = 1169613, XrefRangeEnd = 1169616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe LargeStandard_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeStandard_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe AssetGuid GetValue(ref VBloodPortraitData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VBloodPortraitData local = ref container;
        IntPtr pointer = ptr;
        VBloodPortraitData vbloodPortraitData = pointer == IntPtr.Zero ? (VBloodPortraitData) null : new VBloodPortraitData(pointer);
        local = vbloodPortraitData;
        return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref VBloodPortraitData container, AssetGuid value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VBloodPortraitData local = ref container;
        IntPtr pointer = ptr;
        VBloodPortraitData vbloodPortraitData = pointer == IntPtr.Zero ? (VBloodPortraitData) null : new VBloodPortraitData(pointer);
        local = vbloodPortraitData;
      }

      static LargeStandard_Property()
      {
        Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeStandard_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag>.NativeClassPtr, nameof (LargeStandard_Property));
        VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeStandard_Property>.NativeClassPtr, 100692732);
        VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeStandard_Property>.NativeClassPtr, 100692733);
        VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeStandard_Property>.NativeClassPtr, 100692734);
        VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeStandard_Property>.NativeClassPtr, 100692735);
        VBloodPortraitData_PropertyBag.LargeStandard_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeStandard_Property>.NativeClassPtr, 100692736);
      }

      public LargeStandard_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class LargeEffect_Property : Property<VBloodPortraitData, AssetGuid>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169617, XrefRangeEnd = 1169619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169622, RefRangeEnd = 1169623, XrefRangeStart = 1169619, XrefRangeEnd = 1169622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe LargeEffect_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeEffect_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe AssetGuid GetValue(ref VBloodPortraitData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VBloodPortraitData local = ref container;
        IntPtr pointer = ptr;
        VBloodPortraitData vbloodPortraitData = pointer == IntPtr.Zero ? (VBloodPortraitData) null : new VBloodPortraitData(pointer);
        local = vbloodPortraitData;
        return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref VBloodPortraitData container, AssetGuid value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VBloodPortraitData local = ref container;
        IntPtr pointer = ptr;
        VBloodPortraitData vbloodPortraitData = pointer == IntPtr.Zero ? (VBloodPortraitData) null : new VBloodPortraitData(pointer);
        local = vbloodPortraitData;
      }

      static LargeEffect_Property()
      {
        Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeEffect_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag>.NativeClassPtr, nameof (LargeEffect_Property));
        VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeEffect_Property>.NativeClassPtr, 100692737);
        VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeEffect_Property>.NativeClassPtr, 100692738);
        VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeEffect_Property>.NativeClassPtr, 100692739);
        VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeEffect_Property>.NativeClassPtr, 100692740);
        VBloodPortraitData_PropertyBag.LargeEffect_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.LargeEffect_Property>.NativeClassPtr, 100692741);
      }

      public LargeEffect_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SmallStandard_Property : Property<VBloodPortraitData, AssetGuid>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169623, XrefRangeEnd = 1169625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169628, RefRangeEnd = 1169629, XrefRangeStart = 1169625, XrefRangeEnd = 1169628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SmallStandard_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallStandard_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe AssetGuid GetValue(ref VBloodPortraitData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VBloodPortraitData local = ref container;
        IntPtr pointer = ptr;
        VBloodPortraitData vbloodPortraitData = pointer == IntPtr.Zero ? (VBloodPortraitData) null : new VBloodPortraitData(pointer);
        local = vbloodPortraitData;
        return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref VBloodPortraitData container, AssetGuid value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VBloodPortraitData local = ref container;
        IntPtr pointer = ptr;
        VBloodPortraitData vbloodPortraitData = pointer == IntPtr.Zero ? (VBloodPortraitData) null : new VBloodPortraitData(pointer);
        local = vbloodPortraitData;
      }

      static SmallStandard_Property()
      {
        Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallStandard_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag>.NativeClassPtr, nameof (SmallStandard_Property));
        VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallStandard_Property>.NativeClassPtr, 100692742);
        VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallStandard_Property>.NativeClassPtr, 100692743);
        VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallStandard_Property>.NativeClassPtr, 100692744);
        VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallStandard_Property>.NativeClassPtr, 100692745);
        VBloodPortraitData_PropertyBag.SmallStandard_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallStandard_Property>.NativeClassPtr, 100692746);
      }

      public SmallStandard_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SmallEffect_Property : Property<VBloodPortraitData, AssetGuid>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169629, XrefRangeEnd = 1169631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169634, RefRangeEnd = 1169635, XrefRangeStart = 1169631, XrefRangeEnd = 1169634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SmallEffect_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallEffect_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe AssetGuid GetValue(ref VBloodPortraitData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VBloodPortraitData local = ref container;
        IntPtr pointer = ptr;
        VBloodPortraitData vbloodPortraitData = pointer == IntPtr.Zero ? (VBloodPortraitData) null : new VBloodPortraitData(pointer);
        local = vbloodPortraitData;
        return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref VBloodPortraitData container, AssetGuid value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VBloodPortraitData local = ref container;
        IntPtr pointer = ptr;
        VBloodPortraitData vbloodPortraitData = pointer == IntPtr.Zero ? (VBloodPortraitData) null : new VBloodPortraitData(pointer);
        local = vbloodPortraitData;
      }

      static SmallEffect_Property()
      {
        Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallEffect_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag>.NativeClassPtr, nameof (SmallEffect_Property));
        VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallEffect_Property>.NativeClassPtr, 100692747);
        VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallEffect_Property>.NativeClassPtr, 100692748);
        VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallEffect_Property>.NativeClassPtr, 100692749);
        VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_VBloodPortraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallEffect_Property>.NativeClassPtr, 100692750);
        VBloodPortraitData_PropertyBag.SmallEffect_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VBloodPortraitData_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData_PropertyBag.SmallEffect_Property>.NativeClassPtr, 100692751);
      }

      public SmallEffect_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
