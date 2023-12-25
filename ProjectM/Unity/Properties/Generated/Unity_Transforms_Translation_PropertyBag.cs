// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.Unity_Transforms_Translation_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace Unity.Properties.Generated
{
  public class Unity_Transforms_Translation_PropertyBag : ContainerPropertyBag<Translation>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1170728, RefRangeEnd = 1170729, XrefRangeStart = 1170715, XrefRangeEnd = 1170728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Unity_Transforms_Translation_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Unity_Transforms_Translation_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Unity_Transforms_Translation_PropertyBag()
    {
      Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (Unity_Transforms_Translation_PropertyBag));
      Unity_Transforms_Translation_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag>.NativeClassPtr, 100693095);
    }

    public Unity_Transforms_Translation_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Value_Property : Property<Translation, float3>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_float3_byref_Translation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Translation_float3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170709, XrefRangeEnd = 1170711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170714, RefRangeEnd = 1170715, XrefRangeStart = 1170711, XrefRangeEnd = 1170714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Value_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag.Value_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float3 GetValue(ref Translation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float3_byref_Translation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 872170, RefRangeEnd = 872173, XrefRangeStart = 872170, XrefRangeEnd = 872173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref Translation container, float3 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Translation_float3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Value_Property()
      {
        Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag.Value_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag>.NativeClassPtr, nameof (Value_Property));
        Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag.Value_Property>.NativeClassPtr, 100693096);
        Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag.Value_Property>.NativeClassPtr, 100693097);
        Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag.Value_Property>.NativeClassPtr, 100693098);
        Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float3_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag.Value_Property>.NativeClassPtr, 100693099);
        Unity_Transforms_Translation_PropertyBag.Value_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Translation_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Transforms_Translation_PropertyBag.Value_Property>.NativeClassPtr, 100693100);
      }

      public Value_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
