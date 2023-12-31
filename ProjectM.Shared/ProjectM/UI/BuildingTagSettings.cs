// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildingTagSettings
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
  public class BuildingTagSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeMethodInfoPtr_GetAssetGUID_Public_AssetGuid_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetGuid GetAssetGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildingTagSettings.NativeMethodInfoPtr_GetAssetGUID_Public_AssetGuid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildingTagSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingTagSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildingTagSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildingTagSettings()
    {
      Il2CppClassPointerStore<BuildingTagSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (BuildingTagSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingTagSettings>.NativeClassPtr);
      BuildingTagSettings.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingTagSettings>.NativeClassPtr, nameof (_Guid));
      BuildingTagSettings.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingTagSettings>.NativeClassPtr, nameof (Name));
      BuildingTagSettings.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingTagSettings>.NativeClassPtr, nameof (Icon));
      BuildingTagSettings.NativeMethodInfoPtr_GetAssetGUID_Public_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingTagSettings>.NativeClassPtr, 100670226);
      BuildingTagSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingTagSettings>.NativeClassPtr, 100670227);
    }

    public BuildingTagSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingTagSettings.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingTagSettings.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingTagSettings.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingTagSettings.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingTagSettings.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingTagSettings.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
