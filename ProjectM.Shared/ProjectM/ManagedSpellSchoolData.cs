// Decompiled with JetBrains decompiler
// Type: ProjectM.ManagedSpellSchoolData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ManagedSpellSchoolData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ShortName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LongName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RelevantBuffs;
    private static readonly System.IntPtr NativeFieldInfoPtr_TierIcons;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffsHeaderColor;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedSpellSchoolData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedSpellSchoolData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedSpellSchoolData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedSpellSchoolData()
    {
      Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ManagedSpellSchoolData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr);
      ManagedSpellSchoolData.NativeFieldInfoPtr_ShortName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, nameof (ShortName));
      ManagedSpellSchoolData.NativeFieldInfoPtr_LongName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, nameof (LongName));
      ManagedSpellSchoolData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, nameof (Description));
      ManagedSpellSchoolData.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, nameof (BackgroundImage));
      ManagedSpellSchoolData.NativeFieldInfoPtr_RelevantBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, nameof (RelevantBuffs));
      ManagedSpellSchoolData.NativeFieldInfoPtr_TierIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, nameof (TierIcons));
      ManagedSpellSchoolData.NativeFieldInfoPtr_BuffsHeaderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, nameof (BuffsHeaderColor));
      ManagedSpellSchoolData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, 100664542);
      ManagedSpellSchoolData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedSpellSchoolData>.NativeClassPtr, 100664543);
    }

    public ManagedSpellSchoolData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey ShortName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_ShortName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_ShortName)) = value;
      }
    }

    public unsafe LocalizationKey LongName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_LongName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_LongName)) = value;
      }
    }

    public unsafe LocalizationKey Description
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_Description));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_Description)) = value;
      }
    }

    public unsafe AssetGuid BackgroundImage
    {
      get
      {
        return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_BackgroundImage));
      }
      [param: In] set
      {
        *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_BackgroundImage)) = value;
      }
    }

    public unsafe Il2CppStructArray<PrefabGUID> RelevantBuffs
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_RelevantBuffs));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<PrefabGUID>) null : new Il2CppStructArray<PrefabGUID>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_RelevantBuffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Sprite> TierIcons
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_TierIcons));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_TierIcons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color BuffsHeaderColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_BuffsHeaderColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedSpellSchoolData.NativeFieldInfoPtr_BuffsHeaderColor)) = value;
      }
    }
  }
}
