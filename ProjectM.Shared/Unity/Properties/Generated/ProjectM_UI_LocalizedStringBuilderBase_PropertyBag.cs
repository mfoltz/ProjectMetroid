// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_UI_LocalizedStringBuilderBase_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_UI_LocalizedStringBuilderBase_PropertyBag : 
    ContainerPropertyBag<LocalizedStringBuilderBase>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804840, XrefRangeEnd = 804866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_UI_LocalizedStringBuilderBase_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_UI_LocalizedStringBuilderBase_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_UI_LocalizedStringBuilderBase_PropertyBag));
      ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag>.NativeClassPtr, 100671051);
    }

    public ProjectM_UI_LocalizedStringBuilderBase_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Key_Property : Property<LocalizedStringBuilderBase, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_LocalizedStringBuilderBase_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804819, XrefRangeEnd = 804821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804824, RefRangeEnd = 804826, XrefRangeStart = 804821, XrefRangeEnd = 804824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Key_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref LocalizedStringBuilderBase container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_LocalizedStringBuilderBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref LocalizedStringBuilderBase container,
        LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Key_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag>.NativeClassPtr, nameof (Key_Property));
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property>.NativeClassPtr, 100671052);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property>.NativeClassPtr, 100671053);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property>.NativeClassPtr, 100671054);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_LocalizedStringBuilderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property>.NativeClassPtr, 100671055);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.Key_Property>.NativeClassPtr, 100671056);
      }

      public Key_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ParameterIndex_Property : Property<LocalizedStringBuilderBase, int>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_LocalizedStringBuilderBase_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_Int32_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804826, XrefRangeEnd = 804828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804831, RefRangeEnd = 804833, XrefRangeStart = 804828, XrefRangeEnd = 804831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ParameterIndex_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe int GetValue(ref LocalizedStringBuilderBase container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_LocalizedStringBuilderBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref LocalizedStringBuilderBase container, int value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ParameterIndex_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag>.NativeClassPtr, nameof (ParameterIndex_Property));
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property>.NativeClassPtr, 100671057);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property>.NativeClassPtr, 100671058);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property>.NativeClassPtr, 100671059);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_LocalizedStringBuilderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property>.NativeClassPtr, 100671060);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterIndex_Property>.NativeClassPtr, 100671061);
      }

      public ParameterIndex_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ParameterCount_Property : Property<LocalizedStringBuilderBase, int>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_LocalizedStringBuilderBase_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_Int32_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804833, XrefRangeEnd = 804835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 804838, RefRangeEnd = 804840, XrefRangeStart = 804835, XrefRangeEnd = 804838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ParameterCount_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe int GetValue(ref LocalizedStringBuilderBase container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_LocalizedStringBuilderBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref LocalizedStringBuilderBase container, int value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ParameterCount_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag>.NativeClassPtr, nameof (ParameterCount_Property));
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property>.NativeClassPtr, 100671062);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property>.NativeClassPtr, 100671063);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property>.NativeClassPtr, 100671064);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_LocalizedStringBuilderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property>.NativeClassPtr, 100671065);
        ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizedStringBuilderBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_LocalizedStringBuilderBase_PropertyBag.ParameterCount_Property>.NativeClassPtr, 100671066);
      }

      public ParameterCount_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
