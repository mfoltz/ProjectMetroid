// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_MapIconIconSettings_PropertyBag
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
  public class ProjectM_MapIconIconSettings_PropertyBag : ContainerPropertyBag<MapIconIconSettings>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805870, XrefRangeEnd = 805911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_MapIconIconSettings_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconSettings_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_MapIconIconSettings_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_MapIconIconSettings_PropertyBag));
      ProjectM_MapIconIconSettings_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag>.NativeClassPtr, 100671351);
    }

    public ProjectM_MapIconIconSettings_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Sprite_Property : Property<MapIconIconSettings, Sprite>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_MapIconIconSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Sprite_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805809, XrefRangeEnd = 805811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805827, RefRangeEnd = 805829, XrefRangeStart = 805811, XrefRangeEnd = 805827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Sprite_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Sprite GetValue(ref MapIconIconSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_MapIconIconSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref MapIconIconSettings container, Sprite value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Sprite_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag>.NativeClassPtr, nameof (Sprite_Property));
        ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671352);
        ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671353);
        ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671354);
        ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Sprite_byref_MapIconIconSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671355);
        ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Sprite_Property>.NativeClassPtr, 100671356);
      }

      public Sprite_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Color_Property : Property<MapIconIconSettings, Color>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconIconSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Color_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805829, XrefRangeEnd = 805831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805834, RefRangeEnd = 805836, XrefRangeStart = 805831, XrefRangeEnd = 805834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Color_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Color_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Color GetValue(ref MapIconIconSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconIconSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconSettings container, Color value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Color_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Color_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag>.NativeClassPtr, nameof (Color_Property));
        ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671357);
        ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671358);
        ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671359);
        ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconIconSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671360);
        ProjectM_MapIconIconSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671361);
      }

      public Color_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TransitionTime_Property : Property<MapIconIconSettings, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconIconSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805836, XrefRangeEnd = 805838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805841, RefRangeEnd = 805843, XrefRangeStart = 805838, XrefRangeEnd = 805841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TransitionTime_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref MapIconIconSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconIconSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconSettings container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TransitionTime_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag>.NativeClassPtr, nameof (TransitionTime_Property));
        ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671362);
        ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671363);
        ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671364);
        ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconIconSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671365);
        ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671366);
      }

      public TransitionTime_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OverrideSize_Property : Property<MapIconIconSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805843, XrefRangeEnd = 805845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805848, RefRangeEnd = 805850, XrefRangeStart = 805845, XrefRangeEnd = 805848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideSize_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconIconSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideSize_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag>.NativeClassPtr, nameof (OverrideSize_Property));
        ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671367);
        ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671368);
        ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671369);
        ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconIconSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671370);
        ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.OverrideSize_Property>.NativeClassPtr, 100671371);
      }

      public OverrideSize_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SizeOverride_Property : Property<MapIconIconSettings, Vector2>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Vector2_byref_MapIconIconSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Vector2_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805850, XrefRangeEnd = 805852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 805868, RefRangeEnd = 805870, XrefRangeStart = 805852, XrefRangeEnd = 805868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SizeOverride_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Vector2 GetValue(ref MapIconIconSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector2_byref_MapIconIconSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconIconSettings container, Vector2 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SizeOverride_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag>.NativeClassPtr, nameof (SizeOverride_Property));
        ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671372);
        ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671373);
        ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671374);
        ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Vector2_byref_MapIconIconSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671375);
        ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconIconSettings_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconIconSettings_PropertyBag.SizeOverride_Property>.NativeClassPtr, 100671376);
      }

      public SizeOverride_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
