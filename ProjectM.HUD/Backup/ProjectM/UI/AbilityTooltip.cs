// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AbilityTooltip
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class AbilityTooltip : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_Desc;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsedValueEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAbilityDataEntryList;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Dash;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Travel;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Projectile;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_TargetAoE;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Channeling;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Damage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_SpecialDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CooldownValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ChargesValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CastTimeValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTooltip_Public_Boolean_Vector3_PrefabGUID_TooltipPivot_Nullable_Unboxed_1_Vector2_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityData_Private_Void_LocalizationKey_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_Nullable_Unboxed_1_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableTooltip_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 1221943, RefRangeEnd = 1221962, XrefRangeStart = 1221942, XrefRangeEnd = 1221943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeTooltip(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTooltip.NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1222097, RefRangeEnd = 1222100, XrefRangeStart = 1221962, XrefRangeEnd = 1222097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetTooltip(
      Vector3 position,
      PrefabGUID abilityGuid,
      AbilityTooltip.TooltipPivot tooltipPivot = AbilityTooltip.TooltipPivot.TopLeft,
      Nullable_Unboxed<Vector2> offset = default (Nullable_Unboxed<Vector2>),
      bool isAi = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipPivot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isAi;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityTooltip.NativeMethodInfoPtr_SetTooltip_Public_Boolean_Vector3_PrefabGUID_TooltipPivot_Nullable_Unboxed_1_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1222115, RefRangeEnd = 1222118, XrefRangeStart = 1222100, XrefRangeEnd = 1222115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityData(LocalizationKey key, float value, int decimals = 2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &key;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTooltip.NativeMethodInfoPtr_SetAbilityData_Private_Void_LocalizationKey_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222118, XrefRangeEnd = 1222136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTooltipPosition(Vector3 position, Nullable_Unboxed<Vector2> offset = default (Nullable_Unboxed<Vector2>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTooltip.NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_Nullable_Unboxed_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 1222138, RefRangeEnd = 1222167, XrefRangeStart = 1222136, XrefRangeEnd = 1222138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableTooltip()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTooltip.NativeMethodInfoPtr_DisableTooltip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityTooltip()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityTooltip()
    {
      Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AbilityTooltip));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr);
      AbilityTooltip.NativeFieldInfoPtr_TooltipHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (TooltipHeader));
      AbilityTooltip.NativeFieldInfoPtr_Desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (Desc));
      AbilityTooltip.NativeFieldInfoPtr__UsedValueEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (_UsedValueEntries));
      AbilityTooltip.NativeFieldInfoPtr_TooltipAbilityDataEntryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (TooltipAbilityDataEntryList));
      AbilityTooltip.NativeFieldInfoPtr_LKey_Dash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_Dash));
      AbilityTooltip.NativeFieldInfoPtr_LKey_Travel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_Travel));
      AbilityTooltip.NativeFieldInfoPtr_LKey_Projectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_Projectile));
      AbilityTooltip.NativeFieldInfoPtr_LKey_TargetAoE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_TargetAoE));
      AbilityTooltip.NativeFieldInfoPtr_LKey_Channeling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_Channeling));
      AbilityTooltip.NativeFieldInfoPtr_LKey_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_Damage));
      AbilityTooltip.NativeFieldInfoPtr_LKey_SpecialDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_SpecialDamage));
      AbilityTooltip.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      AbilityTooltip.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (_EntityManager));
      AbilityTooltip.NativeFieldInfoPtr_LKey_CooldownValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_CooldownValue));
      AbilityTooltip.NativeFieldInfoPtr_LKey_ChargesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_ChargesValue));
      AbilityTooltip.NativeFieldInfoPtr_LKey_CastTimeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, nameof (LKey_CastTimeValue));
      AbilityTooltip.NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, 100664725);
      AbilityTooltip.NativeMethodInfoPtr_SetTooltip_Public_Boolean_Vector3_PrefabGUID_TooltipPivot_Nullable_Unboxed_1_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, 100664726);
      AbilityTooltip.NativeMethodInfoPtr_SetAbilityData_Private_Void_LocalizationKey_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, 100664727);
      AbilityTooltip.NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_Nullable_Unboxed_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, 100664728);
      AbilityTooltip.NativeMethodInfoPtr_DisableTooltip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, 100664729);
      AbilityTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTooltip>.NativeClassPtr, 100664730);
    }

    public AbilityTooltip(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TooltipHeader TooltipHeader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_TooltipHeader));
        return pointer == System.IntPtr.Zero ? (TooltipHeader) null : new TooltipHeader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_TooltipHeader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Desc
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_Desc));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_Desc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _UsedValueEntries
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr__UsedValueEntries));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr__UsedValueEntries)) = value;
      }
    }

    public unsafe List<TooltipAbilityDataEntry> TooltipAbilityDataEntryList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_TooltipAbilityDataEntryList));
        return pointer == System.IntPtr.Zero ? (List<TooltipAbilityDataEntry>) null : new List<TooltipAbilityDataEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_TooltipAbilityDataEntryList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Dash
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Dash));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Dash)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Travel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Travel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Travel)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Projectile
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Projectile));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Projectile)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TargetAoE
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_TargetAoE));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_TargetAoE)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Channeling
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Channeling));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Channeling)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Damage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Damage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_Damage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_SpecialDamage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_SpecialDamage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_SpecialDamage)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityManager _EntityManager
    {
      get
      {
        return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr__EntityManager));
      }
      [param: In] set
      {
        *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr__EntityManager)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CooldownValue
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_CooldownValue));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_CooldownValue)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ChargesValue
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_ChargesValue));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_ChargesValue)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CastTimeValue
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_CastTimeValue));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltip.NativeFieldInfoPtr_LKey_CastTimeValue)) = value;
      }
    }

    public enum TooltipPivot
    {
      TopLeft,
      TopRight,
      BottomRight,
      BottomLeft,
    }
  }
}
