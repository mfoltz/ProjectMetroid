// Decompiled with JetBrains decompiler
// Type: RandomLocalizationKeys
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Project.Shared;
using ProjectM;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class RandomLocalizationKeys : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_Data;
  private static readonly IntPtr NativeFieldInfoPtr_LocalizedValidNameResults;
  private static readonly IntPtr NativeFieldInfoPtr_ItemCraftedKey;
  private static readonly IntPtr NativeFieldInfoPtr_AlreadyLearnedKey;
  private static readonly IntPtr NativeFieldInfoPtr_RequirementsNotMetKey;
  private static readonly IntPtr NativeFieldInfoPtr_BloodConsumableKey;
  private static readonly IntPtr NativeFieldInfoPtr_AbilityNotUnlockedKey;
  private static readonly IntPtr NativeFieldInfoPtr_PlayerPvPToggleOnKey;
  private static readonly IntPtr NativeFieldInfoPtr_PlayerPvPToggleOffKey;
  private static readonly IntPtr NativeFieldInfoPtr_CastlePvPToggleOnKey;
  private static readonly IntPtr NativeFieldInfoPtr_CastlePvPToggleOffKey;
  private static readonly IntPtr NativeMethodInfoPtr_GetLocalizationKey_Public_LocalizationKey_UnitStatType_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryGetLocalizationKey_Public_Boolean_ValidNameResult_byref_LocalizationKey_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 714235, RefRangeEnd = 714237, XrefRangeStart = 714230, XrefRangeEnd = 714235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalizationKey GetLocalizationKey(UnitStatType statType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &statType;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomLocalizationKeys.NativeMethodInfoPtr_GetLocalizationKey_Public_LocalizationKey_UnitStatType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 714242, RefRangeEnd = 714246, XrefRangeStart = 714237, XrefRangeEnd = 714242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetLocalizationKey(ValidNameResult nameResult, out LocalizationKey key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &nameResult;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref key;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomLocalizationKeys.NativeMethodInfoPtr_TryGetLocalizationKey_Public_Boolean_ValidNameResult_byref_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RandomLocalizationKeys()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RandomLocalizationKeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RandomLocalizationKeys()
  {
    Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (RandomLocalizationKeys));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr);
    RandomLocalizationKeys.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (Data));
    RandomLocalizationKeys.NativeFieldInfoPtr_LocalizedValidNameResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (LocalizedValidNameResults));
    RandomLocalizationKeys.NativeFieldInfoPtr_ItemCraftedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (ItemCraftedKey));
    RandomLocalizationKeys.NativeFieldInfoPtr_AlreadyLearnedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (AlreadyLearnedKey));
    RandomLocalizationKeys.NativeFieldInfoPtr_RequirementsNotMetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (RequirementsNotMetKey));
    RandomLocalizationKeys.NativeFieldInfoPtr_BloodConsumableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (BloodConsumableKey));
    RandomLocalizationKeys.NativeFieldInfoPtr_AbilityNotUnlockedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (AbilityNotUnlockedKey));
    RandomLocalizationKeys.NativeFieldInfoPtr_PlayerPvPToggleOnKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (PlayerPvPToggleOnKey));
    RandomLocalizationKeys.NativeFieldInfoPtr_PlayerPvPToggleOffKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (PlayerPvPToggleOffKey));
    RandomLocalizationKeys.NativeFieldInfoPtr_CastlePvPToggleOnKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (CastlePvPToggleOnKey));
    RandomLocalizationKeys.NativeFieldInfoPtr_CastlePvPToggleOffKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, nameof (CastlePvPToggleOffKey));
    RandomLocalizationKeys.NativeMethodInfoPtr_GetLocalizationKey_Public_LocalizationKey_UnitStatType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, 100663329);
    RandomLocalizationKeys.NativeMethodInfoPtr_TryGetLocalizationKey_Public_Boolean_ValidNameResult_byref_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, 100663330);
    RandomLocalizationKeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomLocalizationKeys>.NativeClassPtr, 100663331);
  }

  public RandomLocalizationKeys(IntPtr pointer)
    : base(pointer)
  {
  }

  public RandomLocalizationKeysData Data
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_Data);
      return new RandomLocalizationKeysData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomLocalizationKeysData>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_Data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RandomLocalizationKeysData>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public unsafe List<LocalizedValidNameResult> LocalizedValidNameResults
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_LocalizedValidNameResults));
      return pointer == IntPtr.Zero ? (List<LocalizedValidNameResult>) null : new List<LocalizedValidNameResult>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_LocalizedValidNameResults), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey ItemCraftedKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_ItemCraftedKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_ItemCraftedKey)) = value;
    }
  }

  public unsafe LocalizationKey AlreadyLearnedKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_AlreadyLearnedKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_AlreadyLearnedKey)) = value;
    }
  }

  public unsafe LocalizationKey RequirementsNotMetKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_RequirementsNotMetKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_RequirementsNotMetKey)) = value;
    }
  }

  public unsafe LocalizationKey BloodConsumableKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_BloodConsumableKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_BloodConsumableKey)) = value;
    }
  }

  public unsafe LocalizationKey AbilityNotUnlockedKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_AbilityNotUnlockedKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_AbilityNotUnlockedKey)) = value;
    }
  }

  public unsafe LocalizationKey PlayerPvPToggleOnKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_PlayerPvPToggleOnKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_PlayerPvPToggleOnKey)) = value;
    }
  }

  public unsafe LocalizationKey PlayerPvPToggleOffKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_PlayerPvPToggleOffKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_PlayerPvPToggleOffKey)) = value;
    }
  }

  public unsafe LocalizationKey CastlePvPToggleOnKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_CastlePvPToggleOnKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_CastlePvPToggleOnKey)) = value;
    }
  }

  public unsafe LocalizationKey CastlePvPToggleOffKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_CastlePvPToggleOffKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeys.NativeFieldInfoPtr_CastlePvPToggleOffKey)) = value;
    }
  }
}
