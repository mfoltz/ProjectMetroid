// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.UnityEngine_GradientColorKey_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class UnityEngine_GradientColorKey_PropertyBag : ContainerPropertyBag<GradientColorKey>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1172161, RefRangeEnd = 1172162, XrefRangeStart = 1172141, XrefRangeEnd = 1172161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnityEngine_GradientColorKey_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnityEngine_GradientColorKey_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnityEngine_GradientColorKey_PropertyBag()
    {
      Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (UnityEngine_GradientColorKey_PropertyBag));
      UnityEngine_GradientColorKey_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag>.NativeClassPtr, 100693555);
    }

    public UnityEngine_GradientColorKey_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class color_Property : Property<GradientColorKey, Color>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_GradientColorKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientColorKey_Color_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172129, XrefRangeEnd = 1172131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1172134, RefRangeEnd = 1172135, XrefRangeStart = 1172131, XrefRangeEnd = 1172134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe color_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.color_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Color GetValue(ref GradientColorKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_GradientColorKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref GradientColorKey container, Color value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientColorKey_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static color_Property()
      {
        Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.color_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag>.NativeClassPtr, nameof (color_Property));
        UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.color_Property>.NativeClassPtr, 100693556);
        UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.color_Property>.NativeClassPtr, 100693557);
        UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.color_Property>.NativeClassPtr, 100693558);
        UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_GradientColorKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.color_Property>.NativeClassPtr, 100693559);
        UnityEngine_GradientColorKey_PropertyBag.color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientColorKey_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.color_Property>.NativeClassPtr, 100693560);
      }

      public color_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class time_Property : Property<GradientColorKey, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientColorKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientColorKey_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172135, XrefRangeEnd = 1172137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1172140, RefRangeEnd = 1172141, XrefRangeStart = 1172137, XrefRangeEnd = 1172140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe time_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.time_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref GradientColorKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientColorKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref GradientColorKey container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientColorKey_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static time_Property()
      {
        Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.time_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag>.NativeClassPtr, nameof (time_Property));
        UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.time_Property>.NativeClassPtr, 100693561);
        UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.time_Property>.NativeClassPtr, 100693562);
        UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.time_Property>.NativeClassPtr, 100693563);
        UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientColorKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.time_Property>.NativeClassPtr, 100693564);
        UnityEngine_GradientColorKey_PropertyBag.time_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientColorKey_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientColorKey_PropertyBag.time_Property>.NativeClassPtr, 100693565);
      }

      public time_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
