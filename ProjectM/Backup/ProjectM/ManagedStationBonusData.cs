// Decompiled with JetBrains decompiler
// Type: ProjectM.ManagedStationBonusData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ManagedStationBonusData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextRequirements;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon_Unlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon_Locked;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon_Bonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon_Unlocked_TextImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon_Locked_TextImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirement;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedStationBonusData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedStationBonusData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedStationBonusData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedStationBonusData()
    {
      Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ManagedStationBonusData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr);
      ManagedStationBonusData.NativeFieldInfoPtr_BonusKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (BonusKey));
      ManagedStationBonusData.NativeFieldInfoPtr_TextRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (TextRequirements));
      ManagedStationBonusData.NativeFieldInfoPtr_TextBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (TextBonus));
      ManagedStationBonusData.NativeFieldInfoPtr_Icon_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (Icon_Unlocked));
      ManagedStationBonusData.NativeFieldInfoPtr_Icon_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (Icon_Locked));
      ManagedStationBonusData.NativeFieldInfoPtr_Icon_Bonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (Icon_Bonus));
      ManagedStationBonusData.NativeFieldInfoPtr_Icon_Unlocked_TextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (Icon_Unlocked_TextImage));
      ManagedStationBonusData.NativeFieldInfoPtr_Icon_Locked_TextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (Icon_Locked_TextImage));
      ManagedStationBonusData.NativeFieldInfoPtr_ModificationValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (ModificationValue));
      ManagedStationBonusData.NativeFieldInfoPtr_BonusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (BonusType));
      ManagedStationBonusData.NativeFieldInfoPtr_Requirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, nameof (Requirement));
      ManagedStationBonusData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, 100676689);
      ManagedStationBonusData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStationBonusData>.NativeClassPtr, 100676690);
    }

    public ManagedStationBonusData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey BonusKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_BonusKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_BonusKey)) = value;
      }
    }

    public unsafe LocalizationKey TextRequirements
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_TextRequirements));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_TextRequirements)) = value;
      }
    }

    public unsafe LocalizationKey TextBonus
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_TextBonus));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_TextBonus)) = value;
      }
    }

    public unsafe Sprite Icon_Unlocked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Unlocked));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Unlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Locked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Locked));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Locked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Bonus
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Bonus));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Bonus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Unlocked_TextImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Unlocked_TextImage));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Unlocked_TextImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Locked_TextImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Locked_TextImage));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Icon_Locked_TextImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ModificationValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_ModificationValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_ModificationValue)) = value;
      }
    }

    public unsafe StationBonusType BonusType
    {
      get
      {
        return *(StationBonusType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_BonusType));
      }
      [param: In] set
      {
        *(StationBonusType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_BonusType)) = value;
      }
    }

    public unsafe StationBonusRequirement Requirement
    {
      get
      {
        return *(StationBonusRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Requirement));
      }
      [param: In] set
      {
        *(StationBonusRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedStationBonusData.NativeFieldInfoPtr_Requirement)) = value;
      }
    }
  }
}
