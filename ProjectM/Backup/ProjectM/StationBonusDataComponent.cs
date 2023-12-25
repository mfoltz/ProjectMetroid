// Decompiled with JetBrains decompiler
// Type: ProjectM.StationBonusDataComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class StationBonusDataComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BonusType;
    private static readonly IntPtr NativeFieldInfoPtr_Requirement;
    private static readonly IntPtr NativeFieldInfoPtr_ModificationValue;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_Unlocked;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_Locked;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_Bonus;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_Unlocked_TextImage;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_Locked_TextImage;
    private static readonly IntPtr NativeFieldInfoPtr_BonusKey;
    private static readonly IntPtr NativeFieldInfoPtr_TextRequirements;
    private static readonly IntPtr NativeFieldInfoPtr_TextBonus;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993132, XrefRangeEnd = 993154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StationBonusDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StationBonusDataComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StationBonusDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StationBonusDataComponent()
    {
      Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StationBonusDataComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr);
      StationBonusDataComponent.NativeFieldInfoPtr_BonusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (BonusType));
      StationBonusDataComponent.NativeFieldInfoPtr_Requirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (Requirement));
      StationBonusDataComponent.NativeFieldInfoPtr_ModificationValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (ModificationValue));
      StationBonusDataComponent.NativeFieldInfoPtr_Icon_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (Icon_Unlocked));
      StationBonusDataComponent.NativeFieldInfoPtr_Icon_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (Icon_Locked));
      StationBonusDataComponent.NativeFieldInfoPtr_Icon_Bonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (Icon_Bonus));
      StationBonusDataComponent.NativeFieldInfoPtr_Icon_Unlocked_TextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (Icon_Unlocked_TextImage));
      StationBonusDataComponent.NativeFieldInfoPtr_Icon_Locked_TextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (Icon_Locked_TextImage));
      StationBonusDataComponent.NativeFieldInfoPtr_BonusKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (BonusKey));
      StationBonusDataComponent.NativeFieldInfoPtr_TextRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (TextRequirements));
      StationBonusDataComponent.NativeFieldInfoPtr_TextBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, nameof (TextBonus));
      StationBonusDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, 100676691);
      StationBonusDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationBonusDataComponent>.NativeClassPtr, 100676692);
    }

    public StationBonusDataComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe StationBonusType BonusType
    {
      get
      {
        return *(StationBonusType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_BonusType));
      }
      [param: In] set
      {
        *(StationBonusType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_BonusType)) = value;
      }
    }

    public unsafe StationBonusRequirement Requirement
    {
      get
      {
        return *(StationBonusRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Requirement));
      }
      [param: In] set
      {
        *(StationBonusRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Requirement)) = value;
      }
    }

    public unsafe float ModificationValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_ModificationValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_ModificationValue)) = value;
      }
    }

    public unsafe Sprite Icon_Unlocked
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Unlocked));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Unlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Locked
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Locked));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Locked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Bonus
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Bonus));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Bonus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Unlocked_TextImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Unlocked_TextImage));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Unlocked_TextImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Locked_TextImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Locked_TextImage));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_Icon_Locked_TextImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey BonusKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_BonusKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_BonusKey)) = value;
      }
    }

    public unsafe LocalizationKey TextRequirements
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_TextRequirements));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_TextRequirements)) = value;
      }
    }

    public unsafe LocalizationKey TextBonus
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_TextBonus));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusDataComponent.NativeFieldInfoPtr_TextBonus)) = value;
      }
    }
  }
}
