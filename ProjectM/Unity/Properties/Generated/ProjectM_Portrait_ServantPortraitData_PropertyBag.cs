// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Portrait_ServantPortraitData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Portrait;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Portrait_ServantPortraitData_PropertyBag : 
    ContainerPropertyBag<ServantPortraitData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172251, XrefRangeEnd = 1172270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Portrait_ServantPortraitData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Portrait_ServantPortraitData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Portrait_ServantPortraitData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_Portrait_ServantPortraitData_PropertyBag));
      ProjectM_Portrait_ServantPortraitData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag>.NativeClassPtr, 100693589);
    }

    public ProjectM_Portrait_ServantPortraitData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class NormalPortrait_Property : Property<ServantPortraitData, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ServantPortraitData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ServantPortraitData_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172237, XrefRangeEnd = 1172239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172242, RefRangeEnd = 1172244, XrefRangeStart = 1172239, XrefRangeEnd = 1172242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NormalPortrait_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref ServantPortraitData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ServantPortraitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ServantPortraitData local = ref container;
        IntPtr pointer1 = ptr;
        ServantPortraitData servantPortraitData = pointer1 == IntPtr.Zero ? (ServantPortraitData) null : new ServantPortraitData(pointer1);
        local = servantPortraitData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Sprite) null : new Sprite(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ServantPortraitData container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ServantPortraitData_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ServantPortraitData local = ref container;
        IntPtr pointer = ptr;
        ServantPortraitData servantPortraitData = pointer == IntPtr.Zero ? (ServantPortraitData) null : new ServantPortraitData(pointer);
        local = servantPortraitData;
      }

      static NormalPortrait_Property()
      {
        Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag>.NativeClassPtr, nameof (NormalPortrait_Property));
        ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property>.NativeClassPtr, 100693590);
        ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property>.NativeClassPtr, 100693591);
        ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property>.NativeClassPtr, 100693592);
        ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ServantPortraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property>.NativeClassPtr, 100693593);
        ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ServantPortraitData_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.NormalPortrait_Property>.NativeClassPtr, 100693594);
      }

      public NormalPortrait_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class VampirePortrait_Property : Property<ServantPortraitData, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ServantPortraitData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ServantPortraitData_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172244, XrefRangeEnd = 1172246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172249, RefRangeEnd = 1172251, XrefRangeStart = 1172246, XrefRangeEnd = 1172249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VampirePortrait_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref ServantPortraitData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ServantPortraitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ServantPortraitData local = ref container;
        IntPtr pointer1 = ptr;
        ServantPortraitData servantPortraitData = pointer1 == IntPtr.Zero ? (ServantPortraitData) null : new ServantPortraitData(pointer1);
        local = servantPortraitData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Sprite) null : new Sprite(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ServantPortraitData container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ServantPortraitData_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ServantPortraitData local = ref container;
        IntPtr pointer = ptr;
        ServantPortraitData servantPortraitData = pointer == IntPtr.Zero ? (ServantPortraitData) null : new ServantPortraitData(pointer);
        local = servantPortraitData;
      }

      static VampirePortrait_Property()
      {
        Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag>.NativeClassPtr, nameof (VampirePortrait_Property));
        ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property>.NativeClassPtr, 100693595);
        ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property>.NativeClassPtr, 100693596);
        ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property>.NativeClassPtr, 100693597);
        ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ServantPortraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property>.NativeClassPtr, 100693598);
        ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ServantPortraitData_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Portrait_ServantPortraitData_PropertyBag.VampirePortrait_Property>.NativeClassPtr, 100693599);
      }

      public VampirePortrait_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
