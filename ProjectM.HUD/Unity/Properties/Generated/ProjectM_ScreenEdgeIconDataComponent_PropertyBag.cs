// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ScreenEdgeIconDataComponent_PropertyBag
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_ScreenEdgeIconDataComponent_PropertyBag : 
    ContainerPropertyBag<ScreenEdgeIconDataComponent>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291777, XrefRangeEnd = 1291809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ScreenEdgeIconDataComponent_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ScreenEdgeIconDataComponent_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ScreenEdgeIconDataComponent_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "Unity.Properties.Generated", nameof (ProjectM_ScreenEdgeIconDataComponent_PropertyBag));
      ProjectM_ScreenEdgeIconDataComponent_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag>.NativeClassPtr, 100669936);
    }

    public ProjectM_ScreenEdgeIconDataComponent_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Icon_Property : Property<ScreenEdgeIconDataComponent, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ScreenEdgeIconDataComponent_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291749, XrefRangeEnd = 1291751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1291754, RefRangeEnd = 1291756, XrefRangeStart = 1291751, XrefRangeEnd = 1291754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Icon_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref ScreenEdgeIconDataComponent container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ScreenEdgeIconDataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ScreenEdgeIconDataComponent local = ref container;
        IntPtr pointer1 = ptr;
        ScreenEdgeIconDataComponent iconDataComponent = pointer1 == IntPtr.Zero ? (ScreenEdgeIconDataComponent) null : new ScreenEdgeIconDataComponent(pointer1);
        local = iconDataComponent;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (Sprite) null : new Sprite(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ScreenEdgeIconDataComponent container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ScreenEdgeIconDataComponent local = ref container;
        IntPtr pointer = ptr;
        ScreenEdgeIconDataComponent iconDataComponent = pointer == IntPtr.Zero ? (ScreenEdgeIconDataComponent) null : new ScreenEdgeIconDataComponent(pointer);
        local = iconDataComponent;
      }

      static Icon_Property()
      {
        Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag>.NativeClassPtr, nameof (Icon_Property));
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property>.NativeClassPtr, 100669937);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property>.NativeClassPtr, 100669938);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property>.NativeClassPtr, 100669939);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_ScreenEdgeIconDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property>.NativeClassPtr, 100669940);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.Icon_Property>.NativeClassPtr, 100669941);
      }

      public Icon_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ShowArrow_Property : Property<ScreenEdgeIconDataComponent, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291756, XrefRangeEnd = 1291758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1291761, RefRangeEnd = 1291763, XrefRangeStart = 1291758, XrefRangeEnd = 1291761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ShowArrow_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref ScreenEdgeIconDataComponent container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ScreenEdgeIconDataComponent local = ref container;
        IntPtr pointer = ptr;
        ScreenEdgeIconDataComponent iconDataComponent = pointer == IntPtr.Zero ? (ScreenEdgeIconDataComponent) null : new ScreenEdgeIconDataComponent(pointer);
        local = iconDataComponent;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ScreenEdgeIconDataComponent container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ScreenEdgeIconDataComponent local = ref container;
        IntPtr pointer = ptr;
        ScreenEdgeIconDataComponent iconDataComponent = pointer == IntPtr.Zero ? (ScreenEdgeIconDataComponent) null : new ScreenEdgeIconDataComponent(pointer);
        local = iconDataComponent;
      }

      static ShowArrow_Property()
      {
        Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag>.NativeClassPtr, nameof (ShowArrow_Property));
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property>.NativeClassPtr, 100669942);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property>.NativeClassPtr, 100669943);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property>.NativeClassPtr, 100669944);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property>.NativeClassPtr, 100669945);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowArrow_Property>.NativeClassPtr, 100669946);
      }

      public ShowArrow_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ShowDistance_Property : Property<ScreenEdgeIconDataComponent, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291763, XrefRangeEnd = 1291765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1291768, RefRangeEnd = 1291770, XrefRangeStart = 1291765, XrefRangeEnd = 1291768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ShowDistance_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref ScreenEdgeIconDataComponent container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ScreenEdgeIconDataComponent local = ref container;
        IntPtr pointer = ptr;
        ScreenEdgeIconDataComponent iconDataComponent = pointer == IntPtr.Zero ? (ScreenEdgeIconDataComponent) null : new ScreenEdgeIconDataComponent(pointer);
        local = iconDataComponent;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ScreenEdgeIconDataComponent container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ScreenEdgeIconDataComponent local = ref container;
        IntPtr pointer = ptr;
        ScreenEdgeIconDataComponent iconDataComponent = pointer == IntPtr.Zero ? (ScreenEdgeIconDataComponent) null : new ScreenEdgeIconDataComponent(pointer);
        local = iconDataComponent;
      }

      static ShowDistance_Property()
      {
        Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag>.NativeClassPtr, nameof (ShowDistance_Property));
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property>.NativeClassPtr, 100669947);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property>.NativeClassPtr, 100669948);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property>.NativeClassPtr, 100669949);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property>.NativeClassPtr, 100669950);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.ShowDistance_Property>.NativeClassPtr, 100669951);
      }

      public ShowDistance_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class HideDistanceWhenClose_Property : Property<ScreenEdgeIconDataComponent, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291770, XrefRangeEnd = 1291772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1291775, RefRangeEnd = 1291777, XrefRangeStart = 1291772, XrefRangeEnd = 1291775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HideDistanceWhenClose_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref ScreenEdgeIconDataComponent container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ScreenEdgeIconDataComponent local = ref container;
        IntPtr pointer = ptr;
        ScreenEdgeIconDataComponent iconDataComponent = pointer == IntPtr.Zero ? (ScreenEdgeIconDataComponent) null : new ScreenEdgeIconDataComponent(pointer);
        local = iconDataComponent;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref ScreenEdgeIconDataComponent container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ScreenEdgeIconDataComponent local = ref container;
        IntPtr pointer = ptr;
        ScreenEdgeIconDataComponent iconDataComponent = pointer == IntPtr.Zero ? (ScreenEdgeIconDataComponent) null : new ScreenEdgeIconDataComponent(pointer);
        local = iconDataComponent;
      }

      static HideDistanceWhenClose_Property()
      {
        Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag>.NativeClassPtr, nameof (HideDistanceWhenClose_Property));
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property>.NativeClassPtr, 100669952);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property>.NativeClassPtr, 100669953);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property>.NativeClassPtr, 100669954);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_ScreenEdgeIconDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property>.NativeClassPtr, 100669955);
        ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ScreenEdgeIconDataComponent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ScreenEdgeIconDataComponent_PropertyBag.HideDistanceWhenClose_Property>.NativeClassPtr, 100669956);
      }

      public HideDistanceWhenClose_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
