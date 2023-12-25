// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServantInventorySubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Stunlock.Fmod;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ServantInventorySubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_InjuryDescriptionColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Portrait;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_UnitName;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_ServantName;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_EditNameButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_Expertise;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_HuntProficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_PowerLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsInfo_Expertise;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsInfo_GearLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsInfo_HuntProficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsInfo_Power;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsInfo_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_Faction;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkHover_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkHover_Faction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hover_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameServant_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameServant_InputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameServant_InputFieldError;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChangeNamePopupPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Gear;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Inventory;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputBlocker;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Proficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ProficiencyDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_GearLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_GearLevelDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_HuntProficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_HuntProficiencyDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Power;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PowerDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MaxHealthDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_DontStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_NormalStatus;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_InjuredHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventorySelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_GrimoireSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreInstantiatedEquipmentEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentItemsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_GrimoireParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Chest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Legs;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Feet;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Weapon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Grimoire;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Gloves;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_TakeAllButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenTagEditButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagEditPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseTagEditButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveTagButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagEditInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventoryContextEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__ManagedMissionInjureDataAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartRunning_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_Boolean_Func_1_Entity_Func_1_Entity_Func_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Func_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInjury_Internal_ManagedMissionInjureDataAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddContexAndTooltipToEquippedSlot_Private_Boolean_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_Vector3_ItemGridSelectionEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_EntityQuery_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStoredInjury_Internal_Void_ManagedMissionInjureDataAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_0_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_1_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_2_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_3_Private_Void_ItemGridSelectionEntry_Data_0;

    [CallerCount(0)]
    public unsafe bool AnyInputFieldFocused()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248397, XrefRangeEnd = 1248484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1248500, RefRangeEnd = 1248501, XrefRangeStart = 1248484, XrefRangeEnd = 1248500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_StartRunning_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248501, XrefRangeEnd = 1248504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantInventorySubMenu.MenuSettings GetDefaultSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new ServantInventorySubMenu.MenuSettings(pointer);
    }

    public unsafe ServantInventorySubMenu.MenuSettings Settings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new ServantInventorySubMenu.MenuSettings(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1248525, RefRangeEnd = 1248526, XrefRangeStart = 1248504, XrefRangeEnd = 1248525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSettings(
      Nullable_Unboxed<InputFlag> useItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> transferItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> splitItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> repairItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> dropItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> unEquipItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<bool> initStandardDrag = default (Nullable_Unboxed<bool>),
      Il2CppSystem.Func<Entity> getLocalUser = null,
      Il2CppSystem.Func<Entity> getLocalInventory = null,
      Il2CppSystem.Func<Entity> getRemoteInventory = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &useItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &transferItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &splitItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &repairItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dropItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &unEquipItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &initStandardDrag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getLocalUser);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getLocalInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getRemoteInventory);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_Boolean_Func_1_Entity_Func_1_Entity_Func_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248526, XrefRangeEnd = 1248530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSettings(
      Nullable_Unboxed<bool> enableUseItems = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> enableSplitItems = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> enableRepairItems = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> enableDropItems = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> enableUnEquipItems = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> enableStartCraft = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> enableCancelCraft = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> enableDragInventory = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> enableDragEquipment = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<Entity> localInventoryEntity = default (Nullable_Unboxed<Entity>),
      Nullable_Unboxed<Entity> remoteInventoryEntity = default (Nullable_Unboxed<Entity>),
      Il2CppSystem.Func<Entity> getLocalUser = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) &enableUseItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enableSplitItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &enableRepairItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &enableDropItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &enableUnEquipItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &enableStartCraft;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &enableCancelCraft;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &enableDragInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &enableDragEquipment;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &localInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &remoteInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getLocalUser);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Func_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1248631, RefRangeEnd = 1248632, XrefRangeStart = 1248530, XrefRangeEnd = 1248631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnUpdateFromParent(
      EntityManager entityManager,
      Entity localPlayerEntity,
      Entity localUserEntity,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      InventoryLocalizationKeys localizationKeys)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localUserEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localizationKeys);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe ManagedMissionInjureDataAsset GetInjury()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_GetInjury_Internal_ManagedMissionInjureDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ManagedMissionInjureDataAsset) null : new ManagedMissionInjureDataAsset(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248632, XrefRangeEnd = 1248641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AddContexAndTooltipToEquippedSlot(
      EntityManager entityManager,
      Entity localPlayerEntity,
      Entity localUserEntity,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      InventoryLocalizationKeys localizationKeys,
      Vector3 gearTooltipPos,
      ItemGridSelectionEntry hoveredItem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localUserEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localizationKeys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &gearTooltipPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hoveredItem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_AddContexAndTooltipToEquippedSlot_Private_Boolean_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_Vector3_ItemGridSelectionEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1248737, RefRangeEnd = 1248738, XrefRangeStart = 1248641, XrefRangeEnd = 1248737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleInput(
      EntityManager entityManager,
      InputState inputState,
      EntityQuery getItemDataQuery,
      GameDataSystem gameDataSystem = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getItemDataQuery;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_EntityQuery_GameDataSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1248742, RefRangeEnd = 1248743, XrefRangeStart = 1248738, XrefRangeEnd = 1248742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_IsHovered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248743, XrefRangeEnd = 1248752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAnySlotHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248752, XrefRangeEnd = 1248753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetStoredInjury(ManagedMissionInjureDataAsset injury)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) injury);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr_SetStoredInjury_Internal_Void_ManagedMissionInjureDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248753, XrefRangeEnd = 1248761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantInventorySubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248761, XrefRangeEnd = 1248763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__78_0(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_0_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248763, XrefRangeEnd = 1248765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__78_1(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_1_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248765, XrefRangeEnd = 1248767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__78_2(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_2_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248767, XrefRangeEnd = 1248769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__78_3(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_3_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantInventorySubMenu()
    {
      Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServantInventorySubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr);
      ServantInventorySubMenu.NativeFieldInfoPtr_AbilityTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (AbilityTooltip));
      ServantInventorySubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (FakeTooltip));
      ServantInventorySubMenu.NativeFieldInfoPtr_LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LocalizedTime));
      ServantInventorySubMenu.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (TimeKeys));
      ServantInventorySubMenu.NativeFieldInfoPtr_InjuryDescriptionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (InjuryDescriptionColor));
      ServantInventorySubMenu.NativeFieldInfoPtr_Portrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Portrait));
      ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (UnitInfo_Parent));
      ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_UnitName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (UnitInfo_UnitName));
      ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_ServantName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (UnitInfo_ServantName));
      ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_EditNameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (UnitInfo_EditNameButton));
      ServantInventorySubMenu.NativeFieldInfoPtr_Expertise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Expertise));
      ServantInventorySubMenu.NativeFieldInfoPtr_GearLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (GearLevel));
      ServantInventorySubMenu.NativeFieldInfoPtr_HuntProficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (HuntProficiency));
      ServantInventorySubMenu.NativeFieldInfoPtr_PowerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (PowerLevel));
      ServantInventorySubMenu.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (MaxHealth));
      ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_Expertise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (StatsInfo_Expertise));
      ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_GearLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (StatsInfo_GearLevel));
      ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_HuntProficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (StatsInfo_HuntProficiency));
      ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (StatsInfo_Power));
      ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (StatsInfo_MaxHealth));
      ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (PerkInfo_Parent));
      ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (PerkInfo_BloodType));
      ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (PerkInfo_Faction));
      ServantInventorySubMenu.NativeFieldInfoPtr_PerkHover_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (PerkHover_BloodType));
      ServantInventorySubMenu.NativeFieldInfoPtr_PerkHover_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (PerkHover_Faction));
      ServantInventorySubMenu.NativeFieldInfoPtr_Label_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Label_Status));
      ServantInventorySubMenu.NativeFieldInfoPtr_Hover_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Hover_Status));
      ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (NameServant_Parent));
      ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (NameServant_InputField));
      ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_InputFieldError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (NameServant_InputFieldError));
      ServantInventorySubMenu.NativeFieldInfoPtr_ChangeNamePopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (ChangeNamePopupPrefab));
      ServantInventorySubMenu.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (HeaderText));
      ServantInventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Gear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (TooltipAnchor_Gear));
      ServantInventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (TooltipAnchor_Inventory));
      ServantInventorySubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      ServantInventorySubMenu.NativeFieldInfoPtr_InputBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (InputBlocker));
      ServantInventorySubMenu.NativeFieldInfoPtr_InventoryShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (InventoryShared));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_InvalidInput_AllSpaces));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_Proficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_Proficiency));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_ProficiencyDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_ProficiencyDesc));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_GearLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_GearLevel));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_GearLevelDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_GearLevelDesc));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_HuntProficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_HuntProficiency));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_HuntProficiencyDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_HuntProficiencyDesc));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_Power));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_PowerDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_PowerDesc));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_MaxHealth));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_MaxHealthDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_MaxHealthDesc));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_DontStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_DontStack));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_NormalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_NormalStatus));
      ServantInventorySubMenu.NativeFieldInfoPtr_LKey_InjuredHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (LKey_InjuredHeader));
      ServantInventorySubMenu.NativeFieldInfoPtr_InventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (InventorySelectionGroup));
      ServantInventorySubMenu.NativeFieldInfoPtr_ArmorSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (ArmorSelectionGroup));
      ServantInventorySubMenu.NativeFieldInfoPtr_GrimoireSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (GrimoireSelectionGroup));
      ServantInventorySubMenu.NativeFieldInfoPtr_WeaponSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (WeaponSelectionGroup));
      ServantInventorySubMenu.NativeFieldInfoPtr_PreInstantiatedEquipmentEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (PreInstantiatedEquipmentEntries));
      ServantInventorySubMenu.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (ItemEntryPrefab));
      ServantInventorySubMenu.NativeFieldInfoPtr_EquipmentItemsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (EquipmentItemsParent));
      ServantInventorySubMenu.NativeFieldInfoPtr_ArmorParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (ArmorParent));
      ServantInventorySubMenu.NativeFieldInfoPtr_GrimoireParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (GrimoireParent));
      ServantInventorySubMenu.NativeFieldInfoPtr_WeaponParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (WeaponParent));
      ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Chest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Sprite_Chest));
      ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Sprite_Legs));
      ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Feet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Sprite_Feet));
      ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Sprite_Weapon));
      ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Grimoire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Sprite_Grimoire));
      ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Gloves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (Sprite_Gloves));
      ServantInventorySubMenu.NativeFieldInfoPtr_DropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (DropSound));
      ServantInventorySubMenu.NativeFieldInfoPtr_TakeAllButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (TakeAllButton));
      ServantInventorySubMenu.NativeFieldInfoPtr_OpenTagEditButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (OpenTagEditButton));
      ServantInventorySubMenu.NativeFieldInfoPtr_TagEditPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (TagEditPopupNode));
      ServantInventorySubMenu.NativeFieldInfoPtr_CloseTagEditButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (CloseTagEditButton));
      ServantInventorySubMenu.NativeFieldInfoPtr_SaveTagButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (SaveTagButton));
      ServantInventorySubMenu.NativeFieldInfoPtr_TagEditInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (TagEditInputField));
      ServantInventorySubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (_InventoryContextEntriesCache));
      ServantInventorySubMenu.NativeFieldInfoPtr__ManagedMissionInjureDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (_ManagedMissionInjureDataAsset));
      ServantInventorySubMenu.NativeFieldInfoPtr__Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (_Settings));
      ServantInventorySubMenu.NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666450);
      ServantInventorySubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666451);
      ServantInventorySubMenu.NativeMethodInfoPtr_StartRunning_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666452);
      ServantInventorySubMenu.NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666453);
      ServantInventorySubMenu.NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666454);
      ServantInventorySubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_Boolean_Func_1_Entity_Func_1_Entity_Func_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666455);
      ServantInventorySubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Func_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666456);
      ServantInventorySubMenu.NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666457);
      ServantInventorySubMenu.NativeMethodInfoPtr_GetInjury_Internal_ManagedMissionInjureDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666458);
      ServantInventorySubMenu.NativeMethodInfoPtr_AddContexAndTooltipToEquippedSlot_Private_Boolean_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_Vector3_ItemGridSelectionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666459);
      ServantInventorySubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_EntityQuery_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666460);
      ServantInventorySubMenu.NativeMethodInfoPtr_IsHovered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666461);
      ServantInventorySubMenu.NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666462);
      ServantInventorySubMenu.NativeMethodInfoPtr_SetStoredInjury_Internal_Void_ManagedMissionInjureDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666463);
      ServantInventorySubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666464);
      ServantInventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_0_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666465);
      ServantInventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_1_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666466);
      ServantInventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_2_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666467);
      ServantInventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_3_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, 100666468);
    }

    public ServantInventorySubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AbilityTooltip AbilityTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_AbilityTooltip));
        return pointer == System.IntPtr.Zero ? (AbilityTooltip) null : new AbilityTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_AbilityTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedTimeBuilder LocalizedTime
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LocalizedTime);
        return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LocalizationTimeKeys TimeKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TimeKeys));
        return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color InjuryDescriptionColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_InjuryDescriptionColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_InjuryDescriptionColor)) = value;
      }
    }

    public unsafe Image Portrait
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Portrait));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Portrait), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnitInfo_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText UnitInfo_UnitName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_UnitName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_UnitName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText UnitInfo_ServantName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_ServantName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_ServantName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton UnitInfo_EditNameButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_EditNameButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_UnitInfo_EditNameButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Expertise
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Expertise));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Expertise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText GearLevel
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_GearLevel));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_GearLevel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HuntProficiency
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_HuntProficiency));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_HuntProficiency), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PowerLevel
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PowerLevel));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PowerLevel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText MaxHealth
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_MaxHealth));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_MaxHealth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry StatsInfo_Expertise
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_Expertise));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_Expertise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry StatsInfo_GearLevel
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_GearLevel));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_GearLevel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry StatsInfo_HuntProficiency
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_HuntProficiency));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_HuntProficiency), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry StatsInfo_Power
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_Power));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_Power), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry StatsInfo_MaxHealth
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_MaxHealth));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_StatsInfo_MaxHealth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PerkInfo_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantInventorySubMenu.BasicPerkInfo PerkInfo_BloodType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_BloodType));
        return pointer == System.IntPtr.Zero ? (ServantInventorySubMenu.BasicPerkInfo) null : new ServantInventorySubMenu.BasicPerkInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantInventorySubMenu.BasicPerkInfo PerkInfo_Faction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_Faction));
        return pointer == System.IntPtr.Zero ? (ServantInventorySubMenu.BasicPerkInfo) null : new ServantInventorySubMenu.BasicPerkInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkInfo_Faction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry PerkHover_BloodType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkHover_BloodType));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkHover_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry PerkHover_Faction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkHover_Faction));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PerkHover_Faction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label_Status
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Label_Status));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Label_Status), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry Hover_Status
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Hover_Status));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Hover_Status), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform NameServant_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField NameServant_InputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_InputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_InputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NameServant_InputFieldError
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_InputFieldError));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_NameServant_InputFieldError), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu_ChangeNamePopup ChangeNamePopupPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ChangeNamePopupPrefab));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu_ChangeNamePopup) null : new ServantCoffinstationSubMenu_ChangeNamePopup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ChangeNamePopupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor_Gear
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Gear));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Gear), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor_Inventory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlockerArea InputBlocker
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_InputBlocker));
        return pointer == System.IntPtr.Zero ? (BlockerArea) null : new BlockerArea(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_InputBlocker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform InventoryShared
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_InventoryShared));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_InventoryShared), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_InvalidInput_AllSpaces
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Proficiency
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_Proficiency));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_Proficiency)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ProficiencyDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_ProficiencyDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_ProficiencyDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_GearLevel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_GearLevel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_GearLevel)) = value;
      }
    }

    public unsafe LocalizationKey LKey_GearLevelDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_GearLevelDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_GearLevelDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_HuntProficiency
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_HuntProficiency));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_HuntProficiency)) = value;
      }
    }

    public unsafe LocalizationKey LKey_HuntProficiencyDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_HuntProficiencyDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_HuntProficiencyDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Power
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_Power));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_Power)) = value;
      }
    }

    public unsafe LocalizationKey LKey_PowerDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_PowerDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_PowerDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MaxHealth
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_MaxHealth));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_MaxHealth)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MaxHealthDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_MaxHealthDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_MaxHealthDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_DontStack
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_DontStack));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_DontStack)) = value;
      }
    }

    public unsafe LocalizationKey LKey_NormalStatus
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_NormalStatus));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_NormalStatus)) = value;
      }
    }

    public unsafe LocalizationKey LKey_InjuredHeader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_InjuredHeader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_LKey_InjuredHeader)) = value;
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> InventorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_InventorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_InventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> ArmorSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ArmorSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ArmorSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> GrimoireSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_GrimoireSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_GrimoireSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> WeaponSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_WeaponSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_WeaponSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry> PreInstantiatedEquipmentEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PreInstantiatedEquipmentEntries));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry>) null : new List<ItemGridSelectionEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_PreInstantiatedEquipmentEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ItemEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup EquipmentItemsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_EquipmentItemsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_EquipmentItemsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ArmorParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ArmorParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_ArmorParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup GrimoireParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_GrimoireParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_GrimoireParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup WeaponParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_WeaponParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_WeaponParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Chest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Chest));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Chest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Legs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Legs));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Legs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Feet
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Feet));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Feet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Weapon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Weapon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Weapon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Grimoire
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Grimoire));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Grimoire), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Gloves
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Gloves));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_Sprite_Gloves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public FmodEvent DropSound
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_DropSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_DropSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SimpleStunButton TakeAllButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TakeAllButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TakeAllButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton OpenTagEditButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_OpenTagEditButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_OpenTagEditButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TagEditPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TagEditPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TagEditPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CloseTagEditButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_CloseTagEditButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_CloseTagEditButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SaveTagButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_SaveTagButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_SaveTagButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField TagEditInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TagEditInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr_TagEditInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InputContextEntry.Data> _InventoryContextEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ManagedMissionInjureDataAsset _ManagedMissionInjureDataAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr__ManagedMissionInjureDataAsset));
        return pointer == System.IntPtr.Zero ? (ManagedMissionInjureDataAsset) null : new ManagedMissionInjureDataAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr__ManagedMissionInjureDataAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ServantInventorySubMenu.MenuSettings _Settings
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr__Settings);
        return new ServantInventorySubMenu.MenuSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.NativeFieldInfoPtr__Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public class BasicPerkInfo : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_ID;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BasicPerkInfo()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantInventorySubMenu.BasicPerkInfo>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.BasicPerkInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BasicPerkInfo()
      {
        Il2CppClassPointerStore<ServantInventorySubMenu.BasicPerkInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (BasicPerkInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantInventorySubMenu.BasicPerkInfo>.NativeClassPtr);
        ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.BasicPerkInfo>.NativeClassPtr, nameof (Text));
        ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.BasicPerkInfo>.NativeClassPtr, nameof (Icon));
        ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.BasicPerkInfo>.NativeClassPtr, nameof (ID));
        ServantInventorySubMenu.BasicPerkInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu.BasicPerkInfo>.NativeClassPtr, 100666469);
      }

      public BasicPerkInfo(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe LocalizedText Text
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_Text));
          return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Image Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabGUID ID
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_ID));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.BasicPerkInfo.NativeFieldInfoPtr_ID)) = value;
        }
      }
    }

    public sealed class MenuSettings : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Set;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTab;
      private static readonly System.IntPtr NativeFieldInfoPtr_UseItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_TransferItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_SplitItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_RepairItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_DropItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnEquipItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalInventoryEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRemoteInventoryEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_InitStandardDrag;

      static MenuSettings()
      {
        Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, nameof (MenuSettings));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr);
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_Set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (Set));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (StartTab));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_UseItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (UseItemFlag));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (TransferItemFlag));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (SplitItemFlag));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_RepairItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (RepairItemFlag));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (DropItemFlag));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_UnEquipItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (UnEquipItemFlag));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (GetLocalUserEntity));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (GetLocalInventoryEntity));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (GetRemoteInventoryEntity));
        ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitStandardDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, nameof (InitStandardDrag));
      }

      public MenuSettings(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public MenuSettings()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantInventorySubMenu.MenuSettings>.NativeClassPtr, data));
      }

      public unsafe bool Set
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_Set));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_Set)) = value;
        }
      }

      public unsafe int StartTab
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartTab));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartTab)) = value;
        }
      }

      public unsafe InputFlag UseItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_UseItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_UseItemFlag)) = value;
        }
      }

      public unsafe InputFlag TransferItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag)) = value;
        }
      }

      public unsafe InputFlag SplitItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag)) = value;
        }
      }

      public unsafe InputFlag RepairItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_RepairItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_RepairItemFlag)) = value;
        }
      }

      public unsafe InputFlag DropItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag)) = value;
        }
      }

      public unsafe InputFlag UnEquipItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_UnEquipItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_UnEquipItemFlag)) = value;
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetLocalUserEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalUserEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalUserEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetLocalInventoryEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetRemoteInventoryEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool InitStandardDrag
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitStandardDrag));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitStandardDrag)) = value;
        }
      }
    }

    public enum Conf
    {
      None = 0,
      EnableUseItems = 1,
      StandardInventory = 1,
      EnableTransferItems = 2,
      All = 3,
      StandardWorkstation = 3,
      EnableSplitStacks = 4,
      EnableRepairItems = 8,
      EnableDropStacks = 16, // 0x00000010
      EnableUnEquip = 32, // 0x00000020
    }

    [ObfuscatedName("ProjectM.UI.ServantInventorySubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__78_4;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_4_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantInventorySubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__78_4(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantInventorySubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_4_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<ServantInventorySubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantInventorySubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantInventorySubMenu.__c>.NativeClassPtr);
        ServantInventorySubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.__c>.NativeClassPtr, "<>9");
        ServantInventorySubMenu.__c.NativeFieldInfoPtr___9__78_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInventorySubMenu.__c>.NativeClassPtr, "<>9__78_4");
        ServantInventorySubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu.__c>.NativeClassPtr, 100666471);
        ServantInventorySubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__78_4_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantInventorySubMenu.__c>.NativeClassPtr, 100666472);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ServantInventorySubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantInventorySubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ServantInventorySubMenu.__c) null : new ServantInventorySubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantInventorySubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__78_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantInventorySubMenu.__c.NativeFieldInfoPtr___9__78_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantInventorySubMenu.__c.NativeFieldInfoPtr___9__78_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
