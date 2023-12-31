// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_MapIconIconOverrideSettings_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_MapIconIconOverrideSettings_PropertyBag : 
    ContainerPropertyBag<MapIconIconOverrideSettings>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 805527, RefRangeEnd = 805528, XrefRangeStart = 805468, XrefRangeEnd = 805527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_MapIconIconOverrideSettings_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_MapIconIconOverrideSettings_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_MapIconIconOverrideSettings_PropertyBag));
      ProjectM_MapIconIconOverrideSettings_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, 100671221);
    }

    public ProjectM_MapIconIconOverrideSettings_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class OverrideSprite_Property : Property<MapIconIconOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805407, XrefRangeEnd = 805409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805412, RefRangeEnd = 805413, XrefRangeStart = 805409, XrefRangeEnd = 805412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideSprite_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconIconOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideSprite_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, nameof (OverrideSprite_Property));
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property>.NativeClassPtr, 100671222);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property>.NativeClassPtr, 100671223);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property>.NativeClassPtr, 100671224);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property>.NativeClassPtr, 100671225);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSprite_Property>.NativeClassPtr, 100671226);
      }

      public OverrideSprite_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Sprite_Property : Property<MapIconIconOverrideSettings, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_MapIconIconOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805413, XrefRangeEnd = 805415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805431, RefRangeEnd = 805432, XrefRangeStart = 805415, XrefRangeEnd = 805431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Sprite_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref MapIconIconOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref MapIconIconOverrideSettings container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Sprite_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, nameof (Sprite_Property));
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671227);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671228);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671229);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671230);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671231);
      }

      public Sprite_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OverrideColor_Property : Property<MapIconIconOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805432, XrefRangeEnd = 805434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805437, RefRangeEnd = 805438, XrefRangeStart = 805434, XrefRangeEnd = 805437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideColor_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconIconOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideColor_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, nameof (OverrideColor_Property));
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671232);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671233);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671234);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671235);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671236);
      }

      public OverrideColor_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Color_Property : Property<MapIconIconOverrideSettings, Color>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconIconOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Color_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805438, XrefRangeEnd = 805440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805443, RefRangeEnd = 805444, XrefRangeStart = 805440, XrefRangeEnd = 805443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Color_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Color GetValue(ref MapIconIconOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconOverrideSettings container, Color value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Color_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, nameof (Color_Property));
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671237);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671238);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671239);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671240);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671241);
      }

      public Color_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OverrideTransitionTime_Property : Property<MapIconIconOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805444, XrefRangeEnd = 805446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805449, RefRangeEnd = 805450, XrefRangeStart = 805446, XrefRangeEnd = 805449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideTransitionTime_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconIconOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideTransitionTime_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, nameof (OverrideTransitionTime_Property));
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671242);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671243);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671244);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671245);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671246);
      }

      public OverrideTransitionTime_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TransitionTime_Property : Property<MapIconIconOverrideSettings, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconIconOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805450, XrefRangeEnd = 805452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805455, RefRangeEnd = 805456, XrefRangeStart = 805452, XrefRangeEnd = 805455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TransitionTime_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref MapIconIconOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconOverrideSettings container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TransitionTime_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, nameof (TransitionTime_Property));
        ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671247);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671248);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671249);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671250);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671251);
      }

      public TransitionTime_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OverrideSize_Property : Property<MapIconIconOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805456, XrefRangeEnd = 805458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805461, RefRangeEnd = 805462, XrefRangeStart = 805458, XrefRangeEnd = 805461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideSize_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconIconOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideSize_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, nameof (OverrideSize_Property));
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671252);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671253);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671254);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671255);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671256);
      }

      public OverrideSize_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SizeOverride_Property : Property<MapIconIconOverrideSettings, Vector2>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector2_byref_MapIconIconOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Vector2_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805462, XrefRangeEnd = 805464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805467, RefRangeEnd = 805468, XrefRangeStart = 805464, XrefRangeEnd = 805467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SizeOverride_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector2 GetValue(ref MapIconIconOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector2_byref_MapIconIconOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconOverrideSettings container, Vector2 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SizeOverride_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag>.NativeClassPtr, nameof (SizeOverride_Property));
        ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671257);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671258);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671259);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector2_byref_MapIconIconOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671260);
        ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconOverrideSettings_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconOverrideSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671261);
      }

      public SizeOverride_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
