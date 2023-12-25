// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_UI_AchievementSubTaskEntryData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.UI;
using Stunlock.Localization;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_UI_AchievementSubTaskEntryData_PropertyBag : 
    ContainerPropertyBag<AchievementSubTaskEntryData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172516, XrefRangeEnd = 1172550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_UI_AchievementSubTaskEntryData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_UI_AchievementSubTaskEntryData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_UI_AchievementSubTaskEntryData_PropertyBag));
      ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag>.NativeClassPtr, 100693678);
    }

    public ProjectM_UI_AchievementSubTaskEntryData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class PrefabGuid_Property : Property<AchievementSubTaskEntryData, PrefabGUID>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_AchievementSubTaskEntryData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172488, XrefRangeEnd = 1172490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172493, RefRangeEnd = 1172495, XrefRangeStart = 1172490, XrefRangeEnd = 1172493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefabGuid_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PrefabGUID GetValue(ref AchievementSubTaskEntryData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_AchievementSubTaskEntryData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref AchievementSubTaskEntryData container,
        PrefabGUID value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PrefabGuid_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag>.NativeClassPtr, nameof (PrefabGuid_Property));
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property>.NativeClassPtr, 100693679);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property>.NativeClassPtr, 100693680);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property>.NativeClassPtr, 100693681);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_AchievementSubTaskEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property>.NativeClassPtr, 100693682);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.PrefabGuid_Property>.NativeClassPtr, 100693683);
      }

      public PrefabGuid_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Text_Property : Property<AchievementSubTaskEntryData, LocalizationKey>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_AchievementSubTaskEntryData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_LocalizationKey_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172495, XrefRangeEnd = 1172497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172500, RefRangeEnd = 1172502, XrefRangeStart = 1172497, XrefRangeEnd = 1172500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Text_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe LocalizationKey GetValue(ref AchievementSubTaskEntryData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_AchievementSubTaskEntryData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref AchievementSubTaskEntryData container,
        LocalizationKey value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Text_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag>.NativeClassPtr, nameof (Text_Property));
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property>.NativeClassPtr, 100693684);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property>.NativeClassPtr, 100693685);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property>.NativeClassPtr, 100693686);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_LocalizationKey_byref_AchievementSubTaskEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property>.NativeClassPtr, 100693687);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Text_Property>.NativeClassPtr, 100693688);
      }

      public Text_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class RequiredCompletedCount_Property : Property<AchievementSubTaskEntryData, int>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_AchievementSubTaskEntryData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_Int32_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172502, XrefRangeEnd = 1172504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172507, RefRangeEnd = 1172509, XrefRangeStart = 1172504, XrefRangeEnd = 1172507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RequiredCompletedCount_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe int GetValue(ref AchievementSubTaskEntryData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_AchievementSubTaskEntryData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref AchievementSubTaskEntryData container, int value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RequiredCompletedCount_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag>.NativeClassPtr, nameof (RequiredCompletedCount_Property));
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property>.NativeClassPtr, 100693689);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property>.NativeClassPtr, 100693690);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property>.NativeClassPtr, 100693691);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_AchievementSubTaskEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property>.NativeClassPtr, 100693692);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.RequiredCompletedCount_Property>.NativeClassPtr, 100693693);
      }

      public RequiredCompletedCount_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Div100_Property : Property<AchievementSubTaskEntryData, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_AchievementSubTaskEntryData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172509, XrefRangeEnd = 1172511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172514, RefRangeEnd = 1172516, XrefRangeStart = 1172511, XrefRangeEnd = 1172514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Div100_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref AchievementSubTaskEntryData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_AchievementSubTaskEntryData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref AchievementSubTaskEntryData container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Div100_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag>.NativeClassPtr, nameof (Div100_Property));
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property>.NativeClassPtr, 100693694);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property>.NativeClassPtr, 100693695);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property>.NativeClassPtr, 100693696);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_AchievementSubTaskEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property>.NativeClassPtr, 100693697);
        ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementSubTaskEntryData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementSubTaskEntryData_PropertyBag.Div100_Property>.NativeClassPtr, 100693698);
      }

      public Div100_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
