// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.Unity_Mathematics_float3_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Mathematics;

#nullable disable
namespace Unity.Properties.Generated
{
  public class Unity_Mathematics_float3_PropertyBag : ContainerPropertyBag<float3>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1170772, RefRangeEnd = 1170773, XrefRangeStart = 1170747, XrefRangeEnd = 1170772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Unity_Mathematics_float3_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Unity_Mathematics_float3_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Unity_Mathematics_float3_PropertyBag()
    {
      Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (Unity_Mathematics_float3_PropertyBag));
      Unity_Mathematics_float3_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag>.NativeClassPtr, 100693101);
    }

    public Unity_Mathematics_float3_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class x_Property : Property<float3, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170729, XrefRangeEnd = 1170731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170734, RefRangeEnd = 1170735, XrefRangeStart = 1170731, XrefRangeEnd = 1170734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe x_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.x_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref float3 container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref float3 container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static x_Property()
      {
        Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.x_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag>.NativeClassPtr, nameof (x_Property));
        Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.x_Property>.NativeClassPtr, 100693102);
        Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.x_Property>.NativeClassPtr, 100693103);
        Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.x_Property>.NativeClassPtr, 100693104);
        Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.x_Property>.NativeClassPtr, 100693105);
        Unity_Mathematics_float3_PropertyBag.x_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.x_Property>.NativeClassPtr, 100693106);
      }

      public x_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class y_Property : Property<float3, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170735, XrefRangeEnd = 1170737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170740, RefRangeEnd = 1170741, XrefRangeStart = 1170737, XrefRangeEnd = 1170740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe y_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.y_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref float3 container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref float3 container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static y_Property()
      {
        Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.y_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag>.NativeClassPtr, nameof (y_Property));
        Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.y_Property>.NativeClassPtr, 100693107);
        Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.y_Property>.NativeClassPtr, 100693108);
        Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.y_Property>.NativeClassPtr, 100693109);
        Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.y_Property>.NativeClassPtr, 100693110);
        Unity_Mathematics_float3_PropertyBag.y_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.y_Property>.NativeClassPtr, 100693111);
      }

      public y_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class z_Property : Property<float3, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170741, XrefRangeEnd = 1170743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170746, RefRangeEnd = 1170747, XrefRangeStart = 1170743, XrefRangeEnd = 1170746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe z_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.z_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref float3 container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref float3 container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static z_Property()
      {
        Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.z_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag>.NativeClassPtr, nameof (z_Property));
        Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.z_Property>.NativeClassPtr, 100693112);
        Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.z_Property>.NativeClassPtr, 100693113);
        Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.z_Property>.NativeClassPtr, 100693114);
        Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.z_Property>.NativeClassPtr, 100693115);
        Unity_Mathematics_float3_PropertyBag.z_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Mathematics_float3_PropertyBag.z_Property>.NativeClassPtr, 100693116);
      }

      public z_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
