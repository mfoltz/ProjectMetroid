// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FilterCategorySettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class FilterCategorySettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_BuildingCategories;
    private static readonly IntPtr NativeFieldInfoPtr_SavedSelection;
    private static readonly IntPtr NativeFieldInfoPtr_IsDev;
    private static readonly IntPtr NativeMethodInfoPtr_GetAssetGUID_Public_AssetGuid_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetGuid GetAssetGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FilterCategorySettings.NativeMethodInfoPtr_GetAssetGUID_Public_AssetGuid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FilterCategorySettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FilterCategorySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FilterCategorySettings()
    {
      Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (FilterCategorySettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr);
      FilterCategorySettings.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr, nameof (_Guid));
      FilterCategorySettings.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr, nameof (Name));
      FilterCategorySettings.NativeFieldInfoPtr_BuildingCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr, nameof (BuildingCategories));
      FilterCategorySettings.NativeFieldInfoPtr_SavedSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr, nameof (SavedSelection));
      FilterCategorySettings.NativeFieldInfoPtr_IsDev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr, nameof (IsDev));
      FilterCategorySettings.NativeMethodInfoPtr_GetAssetGUID_Public_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr, 100670229);
      FilterCategorySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCategorySettings>.NativeClassPtr, 100670230);
    }

    public FilterCategorySettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe BuildingCategorySettingsArray BuildingCategories
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr_BuildingCategories));
        return pointer == IntPtr.Zero ? (BuildingCategorySettingsArray) null : new BuildingCategorySettingsArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr_BuildingCategories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int SavedSelection
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr_SavedSelection));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr_SavedSelection)) = value;
      }
    }

    public unsafe bool IsDev
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr_IsDev));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategorySettings.NativeFieldInfoPtr_IsDev)) = value;
      }
    }
  }
}
