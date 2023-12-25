// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpellbookMenuMapperSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SpellbookMenuMapperSystem : FullscreenMenuViewMapperSystem<SpellbookMenu>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModTierCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModCollectionSystemUi;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIAssetSubSceneLoader;
    private static readonly System.IntPtr NativeFieldInfoPtr__HighlightHelper;
    private static readonly System.IntPtr NativeFieldInfoPtr__TabDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__MiddleSectionState;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedTabIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedJewelIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedSchoolInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr__SchoolInfos;
    private static readonly System.IntPtr NativeFieldInfoPtr__BasicAbilityCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpperBasicAbilityCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__LowerBasicAbilityCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__TravelAbilityCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__UltimateAbilityCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__FakeAbilityBarAbilityCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__JewelEntryCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__SchoolToSelectedAbilityMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventoryJewels;
    private static readonly System.IntPtr NativeFieldInfoPtr_currentSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpritesToRequest;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSchoolInfo_Private_Boolean_PrefabGUID_byref_SchoolInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedAbility_Private_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindSchoolInfoWithPrefabGuid_Private_SchoolInfo_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedSchoolPrefabGuid_Private_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityTooltipType_Private_Boolean_Entity_byref_AbilityTooltipType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshAbilityInfo_Private_Void_byref_SchoolInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshJewelInfo_Private_Void_Entity_byref_SchoolInfo_SpellbookMenu_JewelInfo_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetJewelIcon_Private_Sprite_byref_SchoolInfo_byref_JewelInstance_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSpellModEntityForAbility_Private_Boolean_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInventoryJewels_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateJewelCache_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTabs_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyNewAbilitiesInSchool_Private_Boolean_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSchoolAbilities_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUnlockedNotSeen_Private_Boolean_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OwnsJewelForAbility_Private_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshFakeAbilityBar_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAbilityUnlocked_Private_Static_Boolean_DynamicBuffer_1_UnlockedAbilityElement_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAbilityUnlocked_Private_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AbilityTypeToVbloodAbilityType_Private_Static_VBloodAbilityType_AbilityTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFakeAbilityBarAbility_Private_Void_Entity_AbilityTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindJewelSpriteForAbility_Private_Boolean_byref_SchoolInfo_PrefabGUID_byref_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAbilities_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupAbilityEntries_Private_GridSelectionGroup_2_SpellbookMenu_AbilityEntry_Data_SpellbookMenu_AbilityEntry_GridLayoutGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Fail_Private_Static_Boolean_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__28_3_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__28_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__28_1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__28_2_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__28_5_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RefreshAbilityInfo_b__38_0_Private_Boolean_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262339, XrefRangeEnd = 1262368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnMenuCreated()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellbookMenuMapperSystem.NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262444, RefRangeEnd = 1262445, XrefRangeStart = 1262368, XrefRangeEnd = 1262444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_Initialize_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262445, XrefRangeEnd = 1262469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellbookMenuMapperSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262492, RefRangeEnd = 1262493, XrefRangeStart = 1262469, XrefRangeEnd = 1262492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSchoolInfo(
      PrefabGUID schoolPrefabGuid,
      out SpellbookMenuMapperSystem.SchoolInfo result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &schoolPrefabGuid;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_TryGetSchoolInfo_Private_Boolean_PrefabGUID_byref_SchoolInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SpellbookMenuMapperSystem.SchoolInfo local = ref result;
      System.IntPtr pointer = zero;
      SpellbookMenuMapperSystem.SchoolInfo schoolInfo = pointer == System.IntPtr.Zero ? (SpellbookMenuMapperSystem.SchoolInfo) null : new SpellbookMenuMapperSystem.SchoolInfo(pointer);
      local = schoolInfo;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262493, XrefRangeEnd = 1262563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellbookMenuMapperSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe PrefabGUID SelectedAbility
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 1262568, RefRangeEnd = 1262575, XrefRangeStart = 1262563, XrefRangeEnd = 1262568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_get_SelectedAbility_Private_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 1262583, RefRangeEnd = 1262584, XrefRangeStart = 1262575, XrefRangeEnd = 1262583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1262601, RefRangeEnd = 1262603, XrefRangeStart = 1262584, XrefRangeEnd = 1262601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellbookMenuMapperSystem.SchoolInfo FindSchoolInfoWithPrefabGuid(
      PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_FindSchoolInfoWithPrefabGuid_Private_SchoolInfo_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new SpellbookMenuMapperSystem.SchoolInfo(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262608, RefRangeEnd = 1262609, XrefRangeStart = 1262603, XrefRangeEnd = 1262608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetSelectedSchoolPrefabGuid()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_GetSelectedSchoolPrefabGuid_Private_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262609, XrefRangeEnd = 1262618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAbilityTooltipType(
      Entity abilityPrefabEntity,
      out AbilityTooltipType result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &abilityPrefabEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_TryGetAbilityTooltipType_Private_Boolean_Entity_byref_AbilityTooltipType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262674, RefRangeEnd = 1262675, XrefRangeStart = 1262618, XrefRangeEnd = 1262674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshAbilityInfo(
      [In] ref SpellbookMenuMapperSystem.SchoolInfo selectedSchoolInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) selectedSchoolInfo);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshAbilityInfo_Private_Void_byref_SchoolInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262675, XrefRangeEnd = 1262714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshJewelInfo(
      Entity spellModEntity,
      [In] ref SpellbookMenuMapperSystem.SchoolInfo selectedSchoolInfo,
      SpellbookMenu_JewelInfo jewelInfo,
      string name = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &spellModEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) selectedSchoolInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jewelInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshJewelInfo_Private_Void_Entity_byref_SchoolInfo_SpellbookMenu_JewelInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262714, RefRangeEnd = 1262715, XrefRangeStart = 1262714, XrefRangeEnd = 1262714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Sprite GetJewelIcon(
      [In] ref SpellbookMenuMapperSystem.SchoolInfo schoolInfo,
      [In] ref JewelInstance jewelInstance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) schoolInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelInstance;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_GetJewelIcon_Private_Sprite_byref_SchoolInfo_byref_JewelInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1262725, RefRangeEnd = 1262728, XrefRangeStart = 1262715, XrefRangeEnd = 1262725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSpellModEntityForAbility(
      PrefabGUID abilityPrefabGuid,
      out Entity result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &abilityPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_TryGetSpellModEntityForAbility_Private_Boolean_PrefabGUID_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262750, RefRangeEnd = 1262751, XrefRangeStart = 1262728, XrefRangeEnd = 1262750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateInventoryJewels()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_UpdateInventoryJewels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262797, RefRangeEnd = 1262798, XrefRangeStart = 1262751, XrefRangeEnd = 1262797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateJewelCache()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_UpdateJewelCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262818, RefRangeEnd = 1262819, XrefRangeStart = 1262798, XrefRangeEnd = 1262818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshTabs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshTabs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262838, RefRangeEnd = 1262839, XrefRangeStart = 1262819, XrefRangeEnd = 1262838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AnyNewAbilitiesInSchool(
      Entity progressionEntity,
      PrefabGUID schoolPrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &schoolPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_AnyNewAbilitiesInSchool_Private_Boolean_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262839, XrefRangeEnd = 1262937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshSchoolAbilities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshSchoolAbilities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262937, XrefRangeEnd = 1262938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsUnlockedNotSeen(bool isAbilityUnlocked, PrefabGUID abilityPrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &isAbilityUnlocked;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_IsUnlockedNotSeen_Private_Boolean_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1262954, RefRangeEnd = 1262956, XrefRangeStart = 1262938, XrefRangeEnd = 1262954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool OwnsJewelForAbility(PrefabGUID abilityPrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &abilityPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_OwnsJewelForAbility_Private_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262956, XrefRangeEnd = 1262987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshFakeAbilityBar()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshFakeAbilityBar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1262996, RefRangeEnd = 1262998, XrefRangeStart = 1262987, XrefRangeEnd = 1262996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAbilityUnlocked(
      DynamicBuffer<UnlockedAbilityElement> unlockedAbilities,
      PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &unlockedAbilities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_IsAbilityUnlocked_Private_Static_Boolean_DynamicBuffer_1_UnlockedAbilityElement_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262998, XrefRangeEnd = 1263008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAbilityUnlocked(PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_IsAbilityUnlocked_Private_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe VBloodAbilityType AbilityTypeToVbloodAbilityType(
      AbilityTypeEnum abilityType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &abilityType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_AbilityTypeToVbloodAbilityType_Private_Static_VBloodAbilityType_AbilityTypeEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(VBloodAbilityType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1263051, RefRangeEnd = 1263055, XrefRangeStart = 1263008, XrefRangeEnd = 1263051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateFakeAbilityBarAbility(
      Entity characterEntity,
      AbilityTypeEnum abilityType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &characterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_UpdateFakeAbilityBarAbility_Private_Void_Entity_AbilityTypeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1263065, RefRangeEnd = 1263067, XrefRangeStart = 1263055, XrefRangeEnd = 1263065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindJewelSpriteForAbility(
      [In] ref SpellbookMenuMapperSystem.SchoolInfo schoolInfo,
      PrefabGUID abilityPrefabGuid,
      out Sprite result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) schoolInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityPrefabGuid;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_TryFindJewelSpriteForAbility_Private_Boolean_byref_SchoolInfo_PrefabGUID_byref_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Sprite local = ref result;
      System.IntPtr pointer = zero;
      Sprite sprite = pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      local = sprite;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263094, RefRangeEnd = 1263095, XrefRangeStart = 1263067, XrefRangeEnd = 1263094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeAbilities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_InitializeAbilities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1263139, RefRangeEnd = 1263143, XrefRangeStart = 1263095, XrefRangeEnd = 1263139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data> SetupAbilityEntries(
      SpellbookMenu_AbilityEntry prefab,
      GridLayoutGroup parent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr_SetupAbilityEntries_Private_GridSelectionGroup_2_SpellbookMenu_AbilityEntry_Data_SpellbookMenu_AbilityEntry_GridLayoutGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>) null : new GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263143, RefRangeEnd = 1263144, XrefRangeStart = 1263143, XrefRangeEnd = 1263143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Fail<T>(out T result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref result;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.MethodInfoStoreGeneric_Fail_Private_Static_Boolean_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref result;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263144, XrefRangeEnd = 1263221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellbookMenuMapperSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Initialize_b__28_3(int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Initialize_b__28_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Initialize_b__28_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263221, XrefRangeEnd = 1263232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__28_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Initialize_b__28_5(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_5_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263232, XrefRangeEnd = 1263234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _RefreshAbilityInfo_b__38_0(SpellbookMenu_AbilityEntry.Data item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) item));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.NativeMethodInfoPtr__RefreshAbilityInfo_b__38_0_Private_Boolean_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263234, XrefRangeEnd = 1263237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellbookMenuMapperSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellbookMenuMapperSystem()
    {
      Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpellbookMenuMapperSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr);
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModTierCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SpellModTierCollectionSystem));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModCollectionSystemUi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SpellModCollectionSystemUi));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_CurveCollectionSystem));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__PrefabCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_PrefabCollection));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_UIAssetSubSceneLoader));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__HighlightHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_HighlightHelper));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__TabDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_TabDatas));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__MiddleSectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_MiddleSectionState));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedTabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SelectedTabIndex));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedJewelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SelectedJewelIndex));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedSchoolInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SelectedSchoolInfo));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SchoolInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SchoolInfos));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__BasicAbilityCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_BasicAbilityCache));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__UpperBasicAbilityCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_UpperBasicAbilityCache));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__LowerBasicAbilityCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_LowerBasicAbilityCache));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__TravelAbilityCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_TravelAbilityCache));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__UltimateAbilityCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_UltimateAbilityCache));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__FakeAbilityBarAbilityCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_FakeAbilityBarAbilityCache));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__JewelEntryCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_JewelEntryCache));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SpellModCache));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SchoolToSelectedAbilityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SchoolToSelectedAbilityMap));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__InventoryJewels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_InventoryJewels));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr_currentSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (currentSprite));
      SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpritesToRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (_SpritesToRequest));
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667389);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_Initialize_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667390);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667391);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_TryGetSchoolInfo_Private_Boolean_PrefabGUID_byref_SchoolInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667392);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667393);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_get_SelectedAbility_Private_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667394);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667395);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_FindSchoolInfoWithPrefabGuid_Private_SchoolInfo_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667396);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_GetSelectedSchoolPrefabGuid_Private_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667397);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_TryGetAbilityTooltipType_Private_Boolean_Entity_byref_AbilityTooltipType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667398);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshAbilityInfo_Private_Void_byref_SchoolInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667399);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshJewelInfo_Private_Void_Entity_byref_SchoolInfo_SpellbookMenu_JewelInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667400);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_GetJewelIcon_Private_Sprite_byref_SchoolInfo_byref_JewelInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667401);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_TryGetSpellModEntityForAbility_Private_Boolean_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667402);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_UpdateInventoryJewels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667403);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_UpdateJewelCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667404);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshTabs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667405);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_AnyNewAbilitiesInSchool_Private_Boolean_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667406);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshSchoolAbilities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667407);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_IsUnlockedNotSeen_Private_Boolean_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667408);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_OwnsJewelForAbility_Private_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667409);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_RefreshFakeAbilityBar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667410);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_IsAbilityUnlocked_Private_Static_Boolean_DynamicBuffer_1_UnlockedAbilityElement_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667411);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_IsAbilityUnlocked_Private_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667412);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_AbilityTypeToVbloodAbilityType_Private_Static_VBloodAbilityType_AbilityTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667413);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_UpdateFakeAbilityBarAbility_Private_Void_Entity_AbilityTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667414);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_TryFindJewelSpriteForAbility_Private_Boolean_byref_SchoolInfo_PrefabGUID_byref_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667415);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_InitializeAbilities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667416);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_SetupAbilityEntries_Private_GridSelectionGroup_2_SpellbookMenu_AbilityEntry_Data_SpellbookMenu_AbilityEntry_GridLayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667417);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_Fail_Private_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667418);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667419);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667420);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667421);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667422);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667423);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__28_5_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667424);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr__RefreshAbilityInfo_b__38_0_Private_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667425);
      SpellbookMenuMapperSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, 100667426);
    }

    public SpellbookMenuMapperSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpellModTierCollectionSystem _SpellModTierCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModTierCollectionSystem));
        return pointer == System.IntPtr.Zero ? (SpellModTierCollectionSystem) null : new SpellModTierCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModTierCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModCollectionSystem_UI _SpellModCollectionSystemUi
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModCollectionSystemUi));
        return pointer == System.IntPtr.Zero ? (SpellModCollectionSystem_UI) null : new SpellModCollectionSystem_UI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModCollectionSystemUi), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__PrefabCollection));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__PrefabCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIAssetSubSceneLoader_ClientWorld _UIAssetSubSceneLoader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader));
        return pointer == System.IntPtr.Zero ? (UIAssetSubSceneLoader_ClientWorld) null : new UIAssetSubSceneLoader_ClientWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIHighlightHelper _HighlightHelper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__HighlightHelper));
        return pointer == System.IntPtr.Zero ? (UIHighlightHelper) null : new UIHighlightHelper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__HighlightHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<FullscreenMenu_InnerTabEntry.Data> _TabDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__TabDatas));
        return pointer == System.IntPtr.Zero ? (List<FullscreenMenu_InnerTabEntry.Data>) null : new List<FullscreenMenu_InnerTabEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__TabDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenuMapperSystem.MiddleSectionState _MiddleSectionState
    {
      get
      {
        return *(SpellbookMenuMapperSystem.MiddleSectionState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__MiddleSectionState));
      }
      [param: In] set
      {
        *(SpellbookMenuMapperSystem.MiddleSectionState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__MiddleSectionState)) = value;
      }
    }

    public unsafe int _SelectedTabIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedTabIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedTabIndex)) = value;
      }
    }

    public unsafe int _SelectedJewelIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedJewelIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedJewelIndex)) = value;
      }
    }

    public SpellbookMenuMapperSystem.SchoolInfo _SelectedSchoolInfo
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedSchoolInfo);
        return new SpellbookMenuMapperSystem.SchoolInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SelectedSchoolInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<SpellbookMenuMapperSystem.SchoolInfo> _SchoolInfos
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SchoolInfos));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenuMapperSystem.SchoolInfo>) null : new List<SpellbookMenuMapperSystem.SchoolInfo>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SchoolInfos), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenu_AbilityEntry.Data> _BasicAbilityCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__BasicAbilityCache));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenu_AbilityEntry.Data>) null : new List<SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__BasicAbilityCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenu_AbilityEntry.Data> _UpperBasicAbilityCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__UpperBasicAbilityCache));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenu_AbilityEntry.Data>) null : new List<SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__UpperBasicAbilityCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenu_AbilityEntry.Data> _LowerBasicAbilityCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__LowerBasicAbilityCache));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenu_AbilityEntry.Data>) null : new List<SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__LowerBasicAbilityCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenu_AbilityEntry.Data> _TravelAbilityCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__TravelAbilityCache));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenu_AbilityEntry.Data>) null : new List<SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__TravelAbilityCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenu_AbilityEntry.Data> _UltimateAbilityCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__UltimateAbilityCache));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenu_AbilityEntry.Data>) null : new List<SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__UltimateAbilityCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenu_AbilityEntry.Data> _FakeAbilityBarAbilityCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__FakeAbilityBarAbilityCache));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenu_AbilityEntry.Data>) null : new List<SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__FakeAbilityBarAbilityCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenu_JewelEntry.Data> _JewelEntryCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__JewelEntryCache));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenu_JewelEntry.Data>) null : new List<SpellbookMenu_JewelEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__JewelEntryCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _SpellModCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModCache));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpellModCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<PrefabGUID, PrefabGUID> _SchoolToSelectedAbilityMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SchoolToSelectedAbilityMap));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, PrefabGUID>) null : new Dictionary<PrefabGUID, PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SchoolToSelectedAbilityMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenuMapperSystem.InventoryJewelInfo> _InventoryJewels
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__InventoryJewels));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenuMapperSystem.InventoryJewelInfo>) null : new List<SpellbookMenuMapperSystem.InventoryJewelInfo>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__InventoryJewels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite currentSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr_currentSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr_currentSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<AssetGuid> _SpritesToRequest
    {
      get
      {
        return *(NativeList<AssetGuid>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpritesToRequest));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.NativeFieldInfoPtr__SpritesToRequest), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<AssetGuid>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public enum MiddleSectionState
    {
      BrowseAbilities,
      BrowseJewels,
    }

    public sealed class SchoolInfo : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_ManagedData;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefixNameGen;
      private static readonly System.IntPtr NativeFieldInfoPtr_PostfixNameGen;
      private static readonly System.IntPtr NativeFieldInfoPtr_Abilities;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1262311, RefRangeEnd = 1262312, XrefRangeStart = 1262308, XrefRangeEnd = 1262311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.SchoolInfo.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SchoolInfo()
      {
        Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (SchoolInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr);
        SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, nameof (PrefabGuid));
        SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_ManagedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, nameof (ManagedData));
        SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PrefixNameGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, nameof (PrefixNameGen));
        SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PostfixNameGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, nameof (PostfixNameGen));
        SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_Abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, nameof (Abilities));
        SpellbookMenuMapperSystem.SchoolInfo.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, 100667427);
      }

      public SchoolInfo(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SchoolInfo()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellbookMenuMapperSystem.SchoolInfo>.NativeClassPtr, data));
      }

      public unsafe PrefabGUID PrefabGuid
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PrefabGuid));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PrefabGuid)) = value;
        }
      }

      public unsafe ManagedSpellSchoolData ManagedData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_ManagedData));
          return pointer == System.IntPtr.Zero ? (ManagedSpellSchoolData) null : new ManagedSpellSchoolData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_ManagedData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ManagedNameGeneratorData PrefixNameGen
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PrefixNameGen));
          return pointer == System.IntPtr.Zero ? (ManagedNameGeneratorData) null : new ManagedNameGeneratorData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PrefixNameGen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ManagedNameGeneratorData PostfixNameGen
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PostfixNameGen));
          return pointer == System.IntPtr.Zero ? (ManagedNameGeneratorData) null : new ManagedNameGeneratorData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_PostfixNameGen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<PrefabGUID> Abilities
      {
        get
        {
          return *(NativeArray<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_Abilities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.SchoolInfo.NativeFieldInfoPtr_Abilities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InventoryJewelInfo
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_JewelInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName;
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_InventoryIndex;
      [FieldOffset(0)]
      public JewelInstance JewelInstance;
      [FieldOffset(16)]
      public GeneratedName GeneratedName;
      [FieldOffset(28)]
      public Entity ItemEntity;
      [FieldOffset(36)]
      public int InventoryIndex;

      static InventoryJewelInfo()
      {
        Il2CppClassPointerStore<SpellbookMenuMapperSystem.InventoryJewelInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, nameof (InventoryJewelInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenuMapperSystem.InventoryJewelInfo>.NativeClassPtr);
        SpellbookMenuMapperSystem.InventoryJewelInfo.NativeFieldInfoPtr_JewelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.InventoryJewelInfo>.NativeClassPtr, nameof (JewelInstance));
        SpellbookMenuMapperSystem.InventoryJewelInfo.NativeFieldInfoPtr_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.InventoryJewelInfo>.NativeClassPtr, nameof (GeneratedName));
        SpellbookMenuMapperSystem.InventoryJewelInfo.NativeFieldInfoPtr_ItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.InventoryJewelInfo>.NativeClassPtr, nameof (ItemEntity));
        SpellbookMenuMapperSystem.InventoryJewelInfo.NativeFieldInfoPtr_InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.InventoryJewelInfo>.NativeClassPtr, nameof (InventoryIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellbookMenuMapperSystem.InventoryJewelInfo>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.SpellbookMenuMapperSystem/<>c__DisplayClass28_0")]
    public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_index;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__4_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass28_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass28_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262312, XrefRangeEnd = 1262317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Initialize_b__4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__Initialize_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass28_0()
      {
        Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, "<>c__DisplayClass28_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass28_0>.NativeClassPtr);
        SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass28_0>.NativeClassPtr, nameof (entry));
        SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass28_0>.NativeClassPtr, nameof (index));
        SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
        SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass28_0>.NativeClassPtr, 100667428);
        SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__Initialize_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass28_0>.NativeClassPtr, 100667429);
      }

      public __c__DisplayClass28_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SpellbookMenu_AbilityEntry entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (SpellbookMenu_AbilityEntry) null : new SpellbookMenu_AbilityEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int index
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_index));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_index)) = value;
        }
      }

      public unsafe SpellbookMenuMapperSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SpellbookMenuMapperSystem) null : new SpellbookMenuMapperSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.SpellbookMenuMapperSystem/<>c__DisplayClass48_0")]
    public sealed class __c__DisplayClass48_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_abilityPrefabGuid;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OwnsJewelForAbility_b__0_Internal_Boolean_InventoryJewelInfo_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass48_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass48_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262317, XrefRangeEnd = 1262318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _OwnsJewelForAbility_b__0(
        SpellbookMenuMapperSystem.InventoryJewelInfo entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entry;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__OwnsJewelForAbility_b__0_Internal_Boolean_InventoryJewelInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass48_0()
      {
        Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, "<>c__DisplayClass48_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass48_0>.NativeClassPtr);
        SpellbookMenuMapperSystem.__c__DisplayClass48_0.NativeFieldInfoPtr_abilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass48_0>.NativeClassPtr, nameof (abilityPrefabGuid));
        SpellbookMenuMapperSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass48_0>.NativeClassPtr, 100667430);
        SpellbookMenuMapperSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__OwnsJewelForAbility_b__0_Internal_Boolean_InventoryJewelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass48_0>.NativeClassPtr, 100667431);
      }

      public __c__DisplayClass48_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabGUID abilityPrefabGuid
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass48_0.NativeFieldInfoPtr_abilityPrefabGuid));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass48_0.NativeFieldInfoPtr_abilityPrefabGuid)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.SpellbookMenuMapperSystem/<>c__DisplayClass55_0")]
    public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__InitializeAbilities_b__0_Internal_Void_PointerEventData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass55_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass55_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262318, XrefRangeEnd = 1262325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _InitializeAbilities_b__0(PointerEventData evtData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) evtData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass55_0.NativeMethodInfoPtr__InitializeAbilities_b__0_Internal_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass55_0()
      {
        Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, "<>c__DisplayClass55_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass55_0>.NativeClassPtr);
        SpellbookMenuMapperSystem.__c__DisplayClass55_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass55_0>.NativeClassPtr, nameof (entry));
        SpellbookMenuMapperSystem.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass55_0>.NativeClassPtr, 100667432);
        SpellbookMenuMapperSystem.__c__DisplayClass55_0.NativeMethodInfoPtr__InitializeAbilities_b__0_Internal_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass55_0>.NativeClassPtr, 100667433);
      }

      public __c__DisplayClass55_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SpellbookMenu_AbilityEntry entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass55_0.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (SpellbookMenu_AbilityEntry) null : new SpellbookMenu_AbilityEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass55_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.SpellbookMenuMapperSystem/<>c__DisplayClass56_0")]
    public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_selectionGroup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupAbilityEntries_b__0_Internal_Void_SpellbookMenu_AbilityEntry_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupAbilityEntries_b__1_Internal_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupAbilityEntries_b__2_Internal_Void_Int32_PointerEventData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass56_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262325, XrefRangeEnd = 1262326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupAbilityEntries_b__0(
        SpellbookMenu_AbilityEntry entry,
        SpellbookMenu_AbilityEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__SetupAbilityEntries_b__0_Internal_Void_SpellbookMenu_AbilityEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262326, XrefRangeEnd = 1262330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupAbilityEntries_b__1(int index)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__SetupAbilityEntries_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262330, XrefRangeEnd = 1262339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupAbilityEntries_b__2(int index, PointerEventData evtData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &index;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) evtData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__SetupAbilityEntries_b__2_Internal_Void_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass56_0()
      {
        Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr, "<>c__DisplayClass56_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr);
        SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
        SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeFieldInfoPtr_selectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr, nameof (selectionGroup));
        SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr, 100667434);
        SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__SetupAbilityEntries_b__0_Internal_Void_SpellbookMenu_AbilityEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr, 100667435);
        SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__SetupAbilityEntries_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr, 100667436);
        SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__SetupAbilityEntries_b__2_Internal_Void_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenuMapperSystem.__c__DisplayClass56_0>.NativeClassPtr, 100667437);
      }

      public __c__DisplayClass56_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SpellbookMenuMapperSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SpellbookMenuMapperSystem) null : new SpellbookMenuMapperSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data> selectionGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeFieldInfoPtr_selectionGroup));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>) null : new GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenuMapperSystem.__c__DisplayClass56_0.NativeFieldInfoPtr_selectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_Fail_Private_Static_Boolean_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SpellbookMenuMapperSystem.NativeMethodInfoPtr_Fail_Private_Static_Boolean_byref_T_0, Il2CppClassPointerStore<SpellbookMenuMapperSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
