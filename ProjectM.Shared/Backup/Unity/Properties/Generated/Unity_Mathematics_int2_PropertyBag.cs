// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.Unity_Mathematics_int2_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Mathematics;

#nullable disable
namespace Unity.Properties.Generated
{
  public class Unity_Mathematics_int2_PropertyBag : ContainerPropertyBag<int2>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 806414, RefRangeEnd = 806415, XrefRangeStart = 806395, XrefRangeEnd = 806414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Unity_Mathematics_int2_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Unity_Mathematics_int2_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Unity_Mathematics_int2_PropertyBag()
    {
      Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (Unity_Mathematics_int2_PropertyBag));
      Unity_Mathematics_int2_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag>.NativeClassPtr, 100671533);
    }

    public Unity_Mathematics_int2_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class x_Property : Property<int2, int>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_int2_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_int2_Int32_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806383, XrefRangeEnd = 806385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806388, RefRangeEnd = 806389, XrefRangeStart = 806385, XrefRangeEnd = 806388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe x_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.x_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe int GetValue(ref int2 container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_int2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref int2 container, int value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_int2_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static x_Property()
      {
        Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.x_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag>.NativeClassPtr, nameof (x_Property));
        Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.x_Property>.NativeClassPtr, 100671534);
        Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.x_Property>.NativeClassPtr, 100671535);
        Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.x_Property>.NativeClassPtr, 100671536);
        Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.x_Property>.NativeClassPtr, 100671537);
        Unity_Mathematics_int2_PropertyBag.x_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.x_Property>.NativeClassPtr, 100671538);
      }

      public x_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class y_Property : Property<int2, int>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_int2_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_int2_Int32_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806389, XrefRangeEnd = 806391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 806394, RefRangeEnd = 806395, XrefRangeStart = 806391, XrefRangeEnd = 806394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe y_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.y_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe int GetValue(ref int2 container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_int2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref int2 container, int value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_int2_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static y_Property()
      {
        Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.y_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag>.NativeClassPtr, nameof (y_Property));
        Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.y_Property>.NativeClassPtr, 100671539);
        Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.y_Property>.NativeClassPtr, 100671540);
        Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.y_Property>.NativeClassPtr, 100671541);
        Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.y_Property>.NativeClassPtr, 100671542);
        Unity_Mathematics_int2_PropertyBag.y_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_int2_PropertyBag.y_Property>.NativeClassPtr, 100671543);
      }

      public y_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
