// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.UnityEngine_GradientAlphaKey_PropertyBag
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
  public class UnityEngine_GradientAlphaKey_PropertyBag : ContainerPropertyBag<GradientAlphaKey>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1172193, RefRangeEnd = 1172194, XrefRangeStart = 1172174, XrefRangeEnd = 1172193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnityEngine_GradientAlphaKey_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnityEngine_GradientAlphaKey_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnityEngine_GradientAlphaKey_PropertyBag()
    {
      Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (UnityEngine_GradientAlphaKey_PropertyBag));
      UnityEngine_GradientAlphaKey_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag>.NativeClassPtr, 100693566);
    }

    public UnityEngine_GradientAlphaKey_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class alpha_Property : Property<GradientAlphaKey, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientAlphaKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientAlphaKey_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172162, XrefRangeEnd = 1172164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1172167, RefRangeEnd = 1172168, XrefRangeStart = 1172164, XrefRangeEnd = 1172167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe alpha_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref GradientAlphaKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientAlphaKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref GradientAlphaKey container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientAlphaKey_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static alpha_Property()
      {
        Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag>.NativeClassPtr, nameof (alpha_Property));
        UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property>.NativeClassPtr, 100693567);
        UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property>.NativeClassPtr, 100693568);
        UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property>.NativeClassPtr, 100693569);
        UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property>.NativeClassPtr, 100693570);
        UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientAlphaKey_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.alpha_Property>.NativeClassPtr, 100693571);
      }

      public alpha_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class time_Property : Property<GradientAlphaKey, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientAlphaKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientAlphaKey_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172168, XrefRangeEnd = 1172170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1172173, RefRangeEnd = 1172174, XrefRangeStart = 1172170, XrefRangeEnd = 1172173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe time_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.time_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref GradientAlphaKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientAlphaKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref GradientAlphaKey container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientAlphaKey_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static time_Property()
      {
        Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.time_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag>.NativeClassPtr, nameof (time_Property));
        UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.time_Property>.NativeClassPtr, 100693572);
        UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.time_Property>.NativeClassPtr, 100693573);
        UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.time_Property>.NativeClassPtr, 100693574);
        UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.time_Property>.NativeClassPtr, 100693575);
        UnityEngine_GradientAlphaKey_PropertyBag.time_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_GradientAlphaKey_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine_GradientAlphaKey_PropertyBag.time_Property>.NativeClassPtr, 100693576);
      }

      public time_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
