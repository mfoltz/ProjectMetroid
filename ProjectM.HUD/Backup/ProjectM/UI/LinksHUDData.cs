// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LinksHUDData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

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
  public class LinksHUDData : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeFieldInfoPtr_Keybind;
    private static readonly IntPtr NativeFieldInfoPtr_HUDMenuType;
    private static readonly IntPtr NativeFieldInfoPtr_LinkExtraData;
    private static readonly IntPtr NativeFieldInfoPtr_ProgressionRequirementPrefab;
    private static readonly IntPtr NativeMethodInfoPtr_GetProgressionRequirementPrefabGUID_Public_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267510, XrefRangeEnd = 1267514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetProgressionRequirementPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LinksHUDData.NativeMethodInfoPtr_GetProgressionRequirementPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinksHUDData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinksHUDData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LinksHUDData()
    {
      Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (LinksHUDData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr);
      LinksHUDData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr, nameof (Name));
      LinksHUDData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr, nameof (Icon));
      LinksHUDData.NativeFieldInfoPtr_Keybind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr, nameof (Keybind));
      LinksHUDData.NativeFieldInfoPtr_HUDMenuType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr, nameof (HUDMenuType));
      LinksHUDData.NativeFieldInfoPtr_LinkExtraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr, nameof (LinkExtraData));
      LinksHUDData.NativeFieldInfoPtr_ProgressionRequirementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr, nameof (ProgressionRequirementPrefab));
      LinksHUDData.NativeMethodInfoPtr_GetProgressionRequirementPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr, 100667689);
      LinksHUDData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinksHUDData>.NativeClassPtr, 100667690);
    }

    public LinksHUDData(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe long Keybind
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_Keybind));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_Keybind)) = value;
      }
    }

    public unsafe HUDMenuType HUDMenuType
    {
      get
      {
        return *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_HUDMenuType));
      }
      [param: In] set
      {
        *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_HUDMenuType)) = value;
      }
    }

    public unsafe LinkExtraData LinkExtraData
    {
      get
      {
        return *(LinkExtraData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_LinkExtraData));
      }
      [param: In] set
      {
        *(LinkExtraData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_LinkExtraData)) = value;
      }
    }

    public unsafe RecipeDataAsset ProgressionRequirementPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_ProgressionRequirementPrefab));
        return pointer == IntPtr.Zero ? (RecipeDataAsset) null : new RecipeDataAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDData.NativeFieldInfoPtr_ProgressionRequirementPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
