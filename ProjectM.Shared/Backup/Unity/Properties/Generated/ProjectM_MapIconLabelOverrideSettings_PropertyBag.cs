// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_MapIconLabelOverrideSettings_PropertyBag
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
  public class ProjectM_MapIconLabelOverrideSettings_PropertyBag : 
    ContainerPropertyBag<MapIconLabelOverrideSettings>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 805721, RefRangeEnd = 805722, XrefRangeStart = 805664, XrefRangeEnd = 805721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_MapIconLabelOverrideSettings_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_MapIconLabelOverrideSettings_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_MapIconLabelOverrideSettings_PropertyBag));
      ProjectM_MapIconLabelOverrideSettings_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, 100671294);
    }

    public ProjectM_MapIconLabelOverrideSettings_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class OverrideShowOnBigMap_Property : Property<MapIconLabelOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805616, XrefRangeEnd = 805618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805621, RefRangeEnd = 805622, XrefRangeStart = 805618, XrefRangeEnd = 805621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideShowOnBigMap_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconLabelOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconLabelOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideShowOnBigMap_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, nameof (OverrideShowOnBigMap_Property));
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property>.NativeClassPtr, 100671295);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property>.NativeClassPtr, 100671296);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property>.NativeClassPtr, 100671297);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property>.NativeClassPtr, 100671298);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnBigMap_Property>.NativeClassPtr, 100671299);
      }

      public OverrideShowOnBigMap_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ShowOnBigMap_Property : Property<MapIconLabelOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805622, XrefRangeEnd = 805624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805627, RefRangeEnd = 805628, XrefRangeStart = 805624, XrefRangeEnd = 805627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ShowOnBigMap_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconLabelOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconLabelOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ShowOnBigMap_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, nameof (ShowOnBigMap_Property));
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property>.NativeClassPtr, 100671300);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property>.NativeClassPtr, 100671301);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property>.NativeClassPtr, 100671302);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property>.NativeClassPtr, 100671303);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnBigMap_Property>.NativeClassPtr, 100671304);
      }

      public ShowOnBigMap_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OverrideShowOnMiniMap_Property : Property<MapIconLabelOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805628, XrefRangeEnd = 805630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805633, RefRangeEnd = 805634, XrefRangeStart = 805630, XrefRangeEnd = 805633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideShowOnMiniMap_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconLabelOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconLabelOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideShowOnMiniMap_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, nameof (OverrideShowOnMiniMap_Property));
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property>.NativeClassPtr, 100671305);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property>.NativeClassPtr, 100671306);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property>.NativeClassPtr, 100671307);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property>.NativeClassPtr, 100671308);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideShowOnMiniMap_Property>.NativeClassPtr, 100671309);
      }

      public OverrideShowOnMiniMap_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ShowOnMiniMap_Property : Property<MapIconLabelOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805634, XrefRangeEnd = 805636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805639, RefRangeEnd = 805640, XrefRangeStart = 805636, XrefRangeEnd = 805639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ShowOnMiniMap_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconLabelOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconLabelOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ShowOnMiniMap_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, nameof (ShowOnMiniMap_Property));
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property>.NativeClassPtr, 100671310);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property>.NativeClassPtr, 100671311);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property>.NativeClassPtr, 100671312);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property>.NativeClassPtr, 100671313);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.ShowOnMiniMap_Property>.NativeClassPtr, 100671314);
      }

      public ShowOnMiniMap_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OverrideColor_Property : Property<MapIconLabelOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805640, XrefRangeEnd = 805642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805645, RefRangeEnd = 805646, XrefRangeStart = 805642, XrefRangeEnd = 805645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideColor_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconLabelOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconLabelOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideColor_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, nameof (OverrideColor_Property));
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671315);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671316);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671317);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671318);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideColor_Property>.NativeClassPtr, 100671319);
      }

      public OverrideColor_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Color_Property : Property<MapIconLabelOverrideSettings, Color>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconLabelOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Color_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805646, XrefRangeEnd = 805648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805651, RefRangeEnd = 805652, XrefRangeStart = 805648, XrefRangeEnd = 805651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Color_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Color GetValue(ref MapIconLabelOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconLabelOverrideSettings container, Color value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Color_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, nameof (Color_Property));
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671320);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671321);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671322);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Color_byref_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671323);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.Color_Property>.NativeClassPtr, 100671324);
      }

      public Color_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OverrideTransitionTime_Property : Property<MapIconLabelOverrideSettings, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805652, XrefRangeEnd = 805654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805657, RefRangeEnd = 805658, XrefRangeStart = 805654, XrefRangeEnd = 805657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideTransitionTime_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref MapIconLabelOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconLabelOverrideSettings container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideTransitionTime_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, nameof (OverrideTransitionTime_Property));
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671325);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671326);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671327);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671328);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.OverrideTransitionTime_Property>.NativeClassPtr, 100671329);
      }

      public OverrideTransitionTime_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TransitionTime_Property : Property<MapIconLabelOverrideSettings, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconLabelOverrideSettings_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805658, XrefRangeEnd = 805660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 805663, RefRangeEnd = 805664, XrefRangeStart = 805660, XrefRangeEnd = 805663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TransitionTime_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref MapIconLabelOverrideSettings container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconLabelOverrideSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref MapIconLabelOverrideSettings container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TransitionTime_Property()
      {
        Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag>.NativeClassPtr, nameof (TransitionTime_Property));
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671330);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671331);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671332);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_MapIconLabelOverrideSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671333);
        ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MapIconLabelOverrideSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_MapIconLabelOverrideSettings_PropertyBag.TransitionTime_Property>.NativeClassPtr, 100671334);
      }

      public TransitionTime_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
