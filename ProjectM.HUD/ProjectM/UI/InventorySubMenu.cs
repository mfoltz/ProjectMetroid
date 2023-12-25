// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InventorySubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
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
  public class InventorySubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Salvageable;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Gear;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Inventory;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputBlocker;
    private static readonly System.IntPtr NativeFieldInfoPtr_TutorialHelper_Crafting;
    private static readonly System.IntPtr NativeFieldInfoPtr_BurnContainerUI;
    private static readonly System.IntPtr NativeFieldInfoPtr_TabButtons;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventorySelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_GrimoireSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeadSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloakSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreInstantiatedEquipmentEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttributesSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreInstantiatedAttributeEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttributeEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentItemsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowActionKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloakParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeadParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_GrimoireParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttributesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttributeKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCategorySettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagInventoriesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagsSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreInstantiatedBagsEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagsContainerSlotEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagContainers;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagInventorySelectionGroups;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Head;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Chest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Legs;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Feet;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Weapon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Grimoire;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Cloak;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Gloves;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedToSalvageStation;
    private static readonly System.IntPtr NativeFieldInfoPtr__SalvageList;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingKnowledge;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesGridSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TakeAllButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SortButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmartMergeButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelfSortButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllSortButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowBagsButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideBagsButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenTagEditButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagEditPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseTagEditButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveTagButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagEditInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventoryContextEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentTab_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeBeforeInAnimation;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeLastClosed;
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentTab_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentTab_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ResetInAnimation_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnDisabled_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartRunning_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnTabChanged_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitStandardWorkstationSettings_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Func_1_Entity_Func_1_Entity_Func_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Func_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSwappableJewel_Private_Static_Boolean_EntityManager_Entity_ItemGridSelectionEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryShowSlotRestrictedTooltip_Public_Static_Boolean_EntityManager_Entity_GameDataSystem_Vector3_ItemCategorySettings_FakeTooltip_InventoryLocalizationKeys_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHoveredBagsEntry_Private_Boolean_GameDataSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_List_1_BagsContainerSlot_byref_ItemGridSelectionEntry_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddContextAndTooltipToEquippedSlot_Private_Boolean_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_Vector3_ItemGridSelectionEntry_String_List_1_CostData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_EntityQuery_CommonClientDataSystem_GameDataSystem_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckBagContainerInputs_Private_Void_EntityManager_InputState_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleBagInventorySlotSplitInput_Private_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleBagInventorySlotTransferInput_Private_Void_EntityManager_Entity_Int32_PrefabGUID_Entity_Func_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleBagInventorySlotDropInput_Private_Void_EntityManager_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckUseOrTransferItem_Private_Void_InputState_EntityManager_Int32_PrefabGUID_EntityQuery_GameDataSystem_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckSplitItem_Private_Void_InputState_EntityManager_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckRepairInput_Private_Void_InputState_EntityManager_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckDropInput_Private_Void_InputState_EntityManager_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckTrackItem_Private_Void_InputState_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckCraftingInput_Private_Void_InputState_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckEquipmentInput_Private_Void_GridSelectionGroup_2_ItemGridSelectionEntry_Data_InputState_InputFlag_EntityManager_EquipmentType_String_UISoundType_UISoundType_UISoundType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckBagSlotsUnequipInput_Private_Void_GridSelectionGroup_2_ItemGridSelectionEntry_Data_List_1_BagsContainerSlot_InputState_EntityManager_UISoundType_UISoundType_UISoundType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCraftingTabOpen_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInventoryTabOpen_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyButtonHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_0_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_1_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_2_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_3_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_4_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_5_Private_Void_CharacterAttributeEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_6_Private_Void_ItemGridSelectionEntry_Data_0;

    public unsafe int CurrentTab
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_get_CurrentTab_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_set_CurrentTab_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237398, XrefRangeEnd = 1237410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void _ResetInAnimation()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventorySubMenu.NativeMethodInfoPtr__ResetInAnimation_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237410, XrefRangeEnd = 1237413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void _OnDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventorySubMenu.NativeMethodInfoPtr__OnDisabled_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237413, XrefRangeEnd = 1237589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1237619, RefRangeEnd = 1237622, XrefRangeStart = 1237589, XrefRangeEnd = 1237619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_StartRunning_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1237626, RefRangeEnd = 1237627, XrefRangeStart = 1237622, XrefRangeEnd = 1237626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnTabChanged()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_OnTabChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237627, XrefRangeEnd = 1237630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventorySubMenu.MenuSettings GetDefaultSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new InventorySubMenu.MenuSettings(pointer);
    }

    public unsafe InventorySubMenu.MenuSettings Settings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new InventorySubMenu.MenuSettings(pointer);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitStandardWorkstationSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_InitStandardWorkstationSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 1237661, RefRangeEnd = 1237678, XrefRangeStart = 1237630, XrefRangeEnd = 1237661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSettings(
      Nullable_Unboxed<int> startTab = default (Nullable_Unboxed<int>),
      Nullable_Unboxed<InputFlag> useItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> transferItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> splitItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> repairItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> dropItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> unEquipItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> startCraftFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> cancelCraftFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<bool> initStandardDrag = default (Nullable_Unboxed<bool>),
      Nullable_Unboxed<bool> initSmartMerge = default (Nullable_Unboxed<bool>),
      Il2CppSystem.Func<Entity> getLocalUser = null,
      Il2CppSystem.Func<Entity> getLocalInventory = null,
      Il2CppSystem.Func<Entity> getRemoteInventory = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[14];
      numPtr[0] = (System.IntPtr) &startTab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &useItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &transferItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &splitItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &repairItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dropItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &unEquipItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &startCraftFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &cancelCraftFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &initStandardDrag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &initSmartMerge;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getLocalUser);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getLocalInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getRemoteInventory);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Func_1_Entity_Func_1_Entity_Func_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237678, XrefRangeEnd = 1237686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSettings(
      Nullable_Unboxed<int> startTab = default (Nullable_Unboxed<int>),
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
      System.IntPtr* numPtr = stackalloc System.IntPtr[13];
      numPtr[0] = (System.IntPtr) &startTab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enableUseItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &enableSplitItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &enableRepairItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &enableDropItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &enableUnEquipItems;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &enableStartCraft;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &enableCancelCraft;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &enableDragInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &enableDragEquipment;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &localInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &remoteInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getLocalUser);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Func_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 1237986, RefRangeEnd = 1238002, XrefRangeStart = 1237686, XrefRangeEnd = 1237986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238002, XrefRangeEnd = 1238004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsSwappableJewel(
      EntityManager entityManager,
      Entity localCharacterEntity,
      ItemGridSelectionEntry entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_IsSwappableJewel_Private_Static_Boolean_EntityManager_Entity_ItemGridSelectionEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238028, RefRangeEnd = 1238029, XrefRangeStart = 1238004, XrefRangeEnd = 1238028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryShowSlotRestrictedTooltip(
      EntityManager entityManager,
      Entity localPlayerEntity,
      GameDataSystem gameDataSystem,
      Vector3 position,
      ItemCategorySettings itemCategorySettings,
      FakeTooltip fakeTooltip,
      InventoryLocalizationKeys localizationKeys,
      int bagIndex,
      int slotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fakeTooltip);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localizationKeys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &bagIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_TryShowSlotRestrictedTooltip_Public_Static_Boolean_EntityManager_Entity_GameDataSystem_Vector3_ItemCategorySettings_FakeTooltip_InventoryLocalizationKeys_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238052, RefRangeEnd = 1238053, XrefRangeStart = 1238029, XrefRangeEnd = 1238052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetHoveredBagsEntry(
      GameDataSystem gameDataSystem,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> bagsSelectionGroup,
      List<BagsContainerSlot> bagsContainerSlotEntries,
      out ItemGridSelectionEntry itemGridSelectionEntry,
      out int hoveredIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bagsSelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bagsContainerSlotEntries);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref hoveredIndex;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_TryGetHoveredBagsEntry_Private_Boolean_GameDataSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_List_1_BagsContainerSlot_byref_ItemGridSelectionEntry_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ItemGridSelectionEntry local = ref itemGridSelectionEntry;
      System.IntPtr pointer = zero;
      ItemGridSelectionEntry gridSelectionEntry = pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      local = gridSelectionEntry;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238086, RefRangeEnd = 1238087, XrefRangeStart = 1238053, XrefRangeEnd = 1238086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AddContextAndTooltipToEquippedSlot(
      EntityManager entityManager,
      Entity localPlayerEntity,
      Entity localUserEntity,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      InventoryLocalizationKeys localizationKeys,
      Vector3 gearTooltipPos,
      ItemGridSelectionEntry hoveredItem,
      string subText = null,
      List<CostData> requirements = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localUserEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localizationKeys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &gearTooltipPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hoveredItem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requirements);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_AddContextAndTooltipToEquippedSlot_Private_Boolean_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_Vector3_ItemGridSelectionEntry_String_List_1_CostData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 1238142, RefRangeEnd = 1238157, XrefRangeStart = 1238087, XrefRangeEnd = 1238142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleInput(
      EntityManager entityManager,
      InputState inputState,
      EntityQuery getItemDataQuery,
      CommonClientDataSystem commonClientDataSystem,
      GameDataSystem gameDataSystem = null,
      bool allowTransfer = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getItemDataQuery;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commonClientDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &allowTransfer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_EntityQuery_CommonClientDataSystem_GameDataSystem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238182, RefRangeEnd = 1238183, XrefRangeStart = 1238157, XrefRangeEnd = 1238182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckBagContainerInputs(
      EntityManager entityManager,
      InputState inputState,
      Entity localCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckBagContainerInputs_Private_Void_EntityManager_InputState_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238187, RefRangeEnd = 1238188, XrefRangeStart = 1238183, XrefRangeEnd = 1238187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void HandleBagInventorySlotSplitInput(
      EntityManager entityManager,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> inventorySelectionGroup,
      int hoveredItemIndex,
      Entity bagEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hoveredItemIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bagEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_HandleBagInventorySlotSplitInput_Private_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238199, RefRangeEnd = 1238200, XrefRangeStart = 1238188, XrefRangeEnd = 1238199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleBagInventorySlotTransferInput(
      EntityManager entityManager,
      Entity bagEntity,
      int hoveredItemIndex,
      PrefabGUID hoveredItemId,
      Entity localCharacter,
      Il2CppSystem.Func<Entity> getRemoteInventory)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hoveredItemIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hoveredItemId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getRemoteInventory);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_HandleBagInventorySlotTransferInput_Private_Void_EntityManager_Entity_Int32_PrefabGUID_Entity_Func_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238200, XrefRangeEnd = 1238201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleBagInventorySlotDropInput(
      EntityManager entityManager,
      Entity bagEntity,
      int slotIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_HandleBagInventorySlotDropInput_Private_Void_EntityManager_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238253, RefRangeEnd = 1238254, XrefRangeStart = 1238201, XrefRangeEnd = 1238253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckUseOrTransferItem(
      InputState inputState,
      EntityManager entityManager,
      int itemIndex,
      PrefabGUID itemId,
      EntityQuery getItemDataQuery,
      GameDataSystem gameDataSystem,
      bool allowTransfer,
      Entity localCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getItemDataQuery;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &allowTransfer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckUseOrTransferItem_Private_Void_InputState_EntityManager_Int32_PrefabGUID_EntityQuery_GameDataSystem_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238254, XrefRangeEnd = 1238262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckSplitItem(
      InputState inputState,
      EntityManager entityManager,
      int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckSplitItem_Private_Void_InputState_EntityManager_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238281, RefRangeEnd = 1238282, XrefRangeStart = 1238262, XrefRangeEnd = 1238281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckRepairInput(
      InputState inputState,
      EntityManager entityManager,
      int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckRepairInput_Private_Void_InputState_EntityManager_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238282, XrefRangeEnd = 1238284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckDropInput(
      InputState inputState,
      EntityManager entityManager,
      int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckDropInput_Private_Void_InputState_EntityManager_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238284, XrefRangeEnd = 1238290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckTrackItem(
      InputState inputState,
      EntityManager entityManager,
      PrefabGUID itemPrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemPrefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckTrackItem_Private_Void_InputState_EntityManager_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238311, RefRangeEnd = 1238312, XrefRangeStart = 1238290, XrefRangeEnd = 1238311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckCraftingInput(InputState inputState, EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckCraftingInput_Private_Void_InputState_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1238352, RefRangeEnd = 1238356, XrefRangeStart = 1238312, XrefRangeEnd = 1238352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckEquipmentInput(
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> gridSelectionGroup,
      InputState inputState,
      InputFlag unEquipFlag,
      EntityManager entityManager,
      EquipmentType equipmentType,
      string debugType,
      UISoundType unEquipSound,
      UISoundType moveSoundType,
      UISoundType repairSoundType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gridSelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &unEquipFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &equipmentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &unEquipSound;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &moveSoundType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &repairSoundType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckEquipmentInput_Private_Void_GridSelectionGroup_2_ItemGridSelectionEntry_Data_InputState_InputFlag_EntityManager_EquipmentType_String_UISoundType_UISoundType_UISoundType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238391, RefRangeEnd = 1238392, XrefRangeStart = 1238356, XrefRangeEnd = 1238391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckBagSlotsUnequipInput(
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> gridSelectionGroup,
      List<BagsContainerSlot> bagsContainerSlotEntries,
      InputState inputState,
      EntityManager entityManager,
      UISoundType unEquipSound,
      UISoundType moveSoundType,
      UISoundType repairSoundType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gridSelectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bagsContainerSlotEntries);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &unEquipSound;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &moveSoundType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &repairSoundType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_CheckBagSlotsUnequipInput_Private_Void_GridSelectionGroup_2_ItemGridSelectionEntry_Data_List_1_BagsContainerSlot_InputState_EntityManager_UISoundType_UISoundType_UISoundType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1238394, RefRangeEnd = 1238395, XrefRangeStart = 1238392, XrefRangeEnd = 1238394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCraftingTabOpen()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_IsCraftingTabOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238395, XrefRangeEnd = 1238397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInventoryTabOpen()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_IsInventoryTabOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 1238416, RefRangeEnd = 1238430, XrefRangeStart = 1238397, XrefRangeEnd = 1238416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_IsHovered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238430, XrefRangeEnd = 1238441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAnySlotHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238441, XrefRangeEnd = 1238444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAnyButtonHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr_IsAnyButtonHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238444, XrefRangeEnd = 1238452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventorySubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238452, XrefRangeEnd = 1238454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__75_0(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_0_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238454, XrefRangeEnd = 1238456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__75_1(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_1_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238456, XrefRangeEnd = 1238458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__75_2(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_2_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238458, XrefRangeEnd = 1238460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__75_3(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_3_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__75_4(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_4_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238460, XrefRangeEnd = 1238462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__75_5(
      CharacterAttributeEntry entry,
      CharacterAttributeEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_5_Private_Void_CharacterAttributeEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238462, XrefRangeEnd = 1238464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__75_6(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_6_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventorySubMenu()
    {
      Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InventorySubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr);
      InventorySubMenu.NativeFieldInfoPtr_AbilityTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (AbilityTooltip));
      InventorySubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (FakeTooltip));
      InventorySubMenu.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (HeaderText));
      InventorySubMenu.NativeFieldInfoPtr_LKey_Salvageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (LKey_Salvageable));
      InventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Gear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (TooltipAnchor_Gear));
      InventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (TooltipAnchor_Inventory));
      InventorySubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      InventorySubMenu.NativeFieldInfoPtr_InputBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (InputBlocker));
      InventorySubMenu.NativeFieldInfoPtr_TutorialHelper_Crafting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (TutorialHelper_Crafting));
      InventorySubMenu.NativeFieldInfoPtr_BurnContainerUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (BurnContainerUI));
      InventorySubMenu.NativeFieldInfoPtr_TabButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (TabButtons));
      InventorySubMenu.NativeFieldInfoPtr_Tabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Tabs));
      InventorySubMenu.NativeFieldInfoPtr_InventoryShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (InventoryShared));
      InventorySubMenu.NativeFieldInfoPtr_InventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (InventorySelectionGroup));
      InventorySubMenu.NativeFieldInfoPtr_ArmorSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (ArmorSelectionGroup));
      InventorySubMenu.NativeFieldInfoPtr_GrimoireSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (GrimoireSelectionGroup));
      InventorySubMenu.NativeFieldInfoPtr_HeadSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (HeadSelectionGroup));
      InventorySubMenu.NativeFieldInfoPtr_CloakSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (CloakSelectionGroup));
      InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedEquipmentEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (PreInstantiatedEquipmentEntries));
      InventorySubMenu.NativeFieldInfoPtr_AttributesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (AttributesSelectionGroup));
      InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedAttributeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (PreInstantiatedAttributeEntries));
      InventorySubMenu.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (ItemEntryPrefab));
      InventorySubMenu.NativeFieldInfoPtr_AttributeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (AttributeEntryPrefab));
      InventorySubMenu.NativeFieldInfoPtr_EquipmentItemsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (EquipmentItemsParent));
      InventorySubMenu.NativeFieldInfoPtr_ShowActionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (ShowActionKeys));
      InventorySubMenu.NativeFieldInfoPtr_ArmorParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (ArmorParent));
      InventorySubMenu.NativeFieldInfoPtr_CloakParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (CloakParent));
      InventorySubMenu.NativeFieldInfoPtr_HeadParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (HeadParent));
      InventorySubMenu.NativeFieldInfoPtr_GrimoireParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (GrimoireParent));
      InventorySubMenu.NativeFieldInfoPtr_AttributesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (AttributesParent));
      InventorySubMenu.NativeFieldInfoPtr_AttributeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (AttributeKeys));
      InventorySubMenu.NativeFieldInfoPtr_ItemCategorySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (ItemCategorySettings));
      InventorySubMenu.NativeFieldInfoPtr_BagsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (BagsParent));
      InventorySubMenu.NativeFieldInfoPtr_BagInventoriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (BagInventoriesParent));
      InventorySubMenu.NativeFieldInfoPtr_BagsSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (BagsSelectionGroup));
      InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedBagsEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (PreInstantiatedBagsEntries));
      InventorySubMenu.NativeFieldInfoPtr_BagsContainerSlotEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (BagsContainerSlotEntries));
      InventorySubMenu.NativeFieldInfoPtr_BagContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (BagContainers));
      InventorySubMenu.NativeFieldInfoPtr_BagInventorySelectionGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (BagInventorySelectionGroups));
      InventorySubMenu.NativeFieldInfoPtr_Sprite_Head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Sprite_Head));
      InventorySubMenu.NativeFieldInfoPtr_Sprite_Chest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Sprite_Chest));
      InventorySubMenu.NativeFieldInfoPtr_Sprite_Legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Sprite_Legs));
      InventorySubMenu.NativeFieldInfoPtr_Sprite_Feet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Sprite_Feet));
      InventorySubMenu.NativeFieldInfoPtr_Sprite_Weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Sprite_Weapon));
      InventorySubMenu.NativeFieldInfoPtr_Sprite_Grimoire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Sprite_Grimoire));
      InventorySubMenu.NativeFieldInfoPtr_Sprite_Cloak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Sprite_Cloak));
      InventorySubMenu.NativeFieldInfoPtr_Sprite_Gloves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (Sprite_Gloves));
      InventorySubMenu.NativeFieldInfoPtr_DropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (DropSound));
      InventorySubMenu.NativeFieldInfoPtr_ConnectedToSalvageStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (ConnectedToSalvageStation));
      InventorySubMenu.NativeFieldInfoPtr__SalvageList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (_SalvageList));
      InventorySubMenu.NativeFieldInfoPtr_LKey_MissingKnowledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (LKey_MissingKnowledge));
      InventorySubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (RecipesGridSelectionGroup));
      InventorySubMenu.NativeFieldInfoPtr_RecipesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (RecipesParent));
      InventorySubMenu.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (RecipeEntryPrefab));
      InventorySubMenu.NativeFieldInfoPtr_TakeAllButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (TakeAllButton));
      InventorySubMenu.NativeFieldInfoPtr_SortButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (SortButton));
      InventorySubMenu.NativeFieldInfoPtr_SmartMergeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (SmartMergeButton));
      InventorySubMenu.NativeFieldInfoPtr_SelfSortButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (SelfSortButton));
      InventorySubMenu.NativeFieldInfoPtr_AllSortButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (AllSortButton));
      InventorySubMenu.NativeFieldInfoPtr_ShowBagsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (ShowBagsButton));
      InventorySubMenu.NativeFieldInfoPtr_HideBagsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (HideBagsButton));
      InventorySubMenu.NativeFieldInfoPtr_OpenTagEditButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (OpenTagEditButton));
      InventorySubMenu.NativeFieldInfoPtr_TagEditPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (TagEditPopupNode));
      InventorySubMenu.NativeFieldInfoPtr_CloseTagEditButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (CloseTagEditButton));
      InventorySubMenu.NativeFieldInfoPtr_SaveTagButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (SaveTagButton));
      InventorySubMenu.NativeFieldInfoPtr_TagEditInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (TagEditInputField));
      InventorySubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (_InventoryContextEntriesCache));
      InventorySubMenu.NativeFieldInfoPtr__CurrentTab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, "<CurrentTab>k__BackingField");
      InventorySubMenu.NativeFieldInfoPtr__TimeBeforeInAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (_TimeBeforeInAnimation));
      InventorySubMenu.NativeFieldInfoPtr__TimeLastClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (_TimeLastClosed));
      InventorySubMenu.NativeFieldInfoPtr__Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (_Settings));
      InventorySubMenu.NativeMethodInfoPtr_get_CurrentTab_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665869);
      InventorySubMenu.NativeMethodInfoPtr_set_CurrentTab_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665870);
      InventorySubMenu.NativeMethodInfoPtr__ResetInAnimation_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665871);
      InventorySubMenu.NativeMethodInfoPtr__OnDisabled_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665872);
      InventorySubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665873);
      InventorySubMenu.NativeMethodInfoPtr_StartRunning_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665874);
      InventorySubMenu.NativeMethodInfoPtr_OnTabChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665875);
      InventorySubMenu.NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665876);
      InventorySubMenu.NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665877);
      InventorySubMenu.NativeMethodInfoPtr_InitStandardWorkstationSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665878);
      InventorySubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Func_1_Entity_Func_1_Entity_Func_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665879);
      InventorySubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Boolean_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Entity_Func_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665880);
      InventorySubMenu.NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665881);
      InventorySubMenu.NativeMethodInfoPtr_IsSwappableJewel_Private_Static_Boolean_EntityManager_Entity_ItemGridSelectionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665882);
      InventorySubMenu.NativeMethodInfoPtr_TryShowSlotRestrictedTooltip_Public_Static_Boolean_EntityManager_Entity_GameDataSystem_Vector3_ItemCategorySettings_FakeTooltip_InventoryLocalizationKeys_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665883);
      InventorySubMenu.NativeMethodInfoPtr_TryGetHoveredBagsEntry_Private_Boolean_GameDataSystem_GridSelectionGroup_2_ItemGridSelectionEntry_Data_List_1_BagsContainerSlot_byref_ItemGridSelectionEntry_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665884);
      InventorySubMenu.NativeMethodInfoPtr_AddContextAndTooltipToEquippedSlot_Private_Boolean_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_Vector3_ItemGridSelectionEntry_String_List_1_CostData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665885);
      InventorySubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_EntityQuery_CommonClientDataSystem_GameDataSystem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665886);
      InventorySubMenu.NativeMethodInfoPtr_CheckBagContainerInputs_Private_Void_EntityManager_InputState_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665887);
      InventorySubMenu.NativeMethodInfoPtr_HandleBagInventorySlotSplitInput_Private_Static_Void_EntityManager_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665888);
      InventorySubMenu.NativeMethodInfoPtr_HandleBagInventorySlotTransferInput_Private_Void_EntityManager_Entity_Int32_PrefabGUID_Entity_Func_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665889);
      InventorySubMenu.NativeMethodInfoPtr_HandleBagInventorySlotDropInput_Private_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665890);
      InventorySubMenu.NativeMethodInfoPtr_CheckUseOrTransferItem_Private_Void_InputState_EntityManager_Int32_PrefabGUID_EntityQuery_GameDataSystem_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665891);
      InventorySubMenu.NativeMethodInfoPtr_CheckSplitItem_Private_Void_InputState_EntityManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665892);
      InventorySubMenu.NativeMethodInfoPtr_CheckRepairInput_Private_Void_InputState_EntityManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665893);
      InventorySubMenu.NativeMethodInfoPtr_CheckDropInput_Private_Void_InputState_EntityManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665894);
      InventorySubMenu.NativeMethodInfoPtr_CheckTrackItem_Private_Void_InputState_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665895);
      InventorySubMenu.NativeMethodInfoPtr_CheckCraftingInput_Private_Void_InputState_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665896);
      InventorySubMenu.NativeMethodInfoPtr_CheckEquipmentInput_Private_Void_GridSelectionGroup_2_ItemGridSelectionEntry_Data_InputState_InputFlag_EntityManager_EquipmentType_String_UISoundType_UISoundType_UISoundType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665897);
      InventorySubMenu.NativeMethodInfoPtr_CheckBagSlotsUnequipInput_Private_Void_GridSelectionGroup_2_ItemGridSelectionEntry_Data_List_1_BagsContainerSlot_InputState_EntityManager_UISoundType_UISoundType_UISoundType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665898);
      InventorySubMenu.NativeMethodInfoPtr_IsCraftingTabOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665899);
      InventorySubMenu.NativeMethodInfoPtr_IsInventoryTabOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665900);
      InventorySubMenu.NativeMethodInfoPtr_IsHovered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665901);
      InventorySubMenu.NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665902);
      InventorySubMenu.NativeMethodInfoPtr_IsAnyButtonHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665903);
      InventorySubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665904);
      InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_0_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665905);
      InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_1_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665906);
      InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_2_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665907);
      InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_3_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665908);
      InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_4_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665909);
      InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_5_Private_Void_CharacterAttributeEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665910);
      InventorySubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_6_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, 100665911);
    }

    public InventorySubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AbilityTooltip AbilityTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AbilityTooltip));
        return pointer == System.IntPtr.Zero ? (AbilityTooltip) null : new AbilityTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AbilityTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Salvageable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_LKey_Salvageable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_LKey_Salvageable)) = value;
      }
    }

    public unsafe Transform TooltipAnchor_Gear
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Gear));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Gear), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor_Inventory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlockerArea InputBlocker
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_InputBlocker));
        return pointer == System.IntPtr.Zero ? (BlockerArea) null : new BlockerArea(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_InputBlocker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject TutorialHelper_Crafting
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TutorialHelper_Crafting));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TutorialHelper_Crafting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BurnContainer BurnContainerUI
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BurnContainerUI));
        return pointer == System.IntPtr.Zero ? (BurnContainer) null : new BurnContainer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BurnContainerUI), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<SimpleStunButton> TabButtons
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TabButtons));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SimpleStunButton>) null : new Il2CppReferenceArray<SimpleStunButton>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TabButtons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<RectTransform> Tabs
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Tabs));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RectTransform>) null : new Il2CppReferenceArray<RectTransform>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Tabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform InventoryShared
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_InventoryShared));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_InventoryShared), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> InventorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_InventorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_InventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> ArmorSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ArmorSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ArmorSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> GrimoireSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_GrimoireSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_GrimoireSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> HeadSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_HeadSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_HeadSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> CloakSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_CloakSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_CloakSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry> PreInstantiatedEquipmentEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedEquipmentEntries));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry>) null : new List<ItemGridSelectionEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedEquipmentEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<CharacterAttributeEntry, CharacterAttributeEntry.Data> AttributesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AttributesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<CharacterAttributeEntry, CharacterAttributeEntry.Data>) null : new GridSelectionGroup<CharacterAttributeEntry, CharacterAttributeEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AttributesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<CharacterAttributeEntry> PreInstantiatedAttributeEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedAttributeEntries));
        return pointer == System.IntPtr.Zero ? (List<CharacterAttributeEntry>) null : new List<CharacterAttributeEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedAttributeEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ItemEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAttributeEntry AttributeEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AttributeEntryPrefab));
        return pointer == System.IntPtr.Zero ? (CharacterAttributeEntry) null : new CharacterAttributeEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AttributeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup EquipmentItemsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_EquipmentItemsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_EquipmentItemsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool ShowActionKeys
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ShowActionKeys));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ShowActionKeys)) = value;
      }
    }

    public unsafe GridLayoutGroup ArmorParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ArmorParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ArmorParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup CloakParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_CloakParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_CloakParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup HeadParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_HeadParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_HeadParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup GrimoireParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_GrimoireParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_GrimoireParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VerticalLayoutGroup AttributesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AttributesParent));
        return pointer == System.IntPtr.Zero ? (VerticalLayoutGroup) null : new VerticalLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AttributesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AttributeKeysSetting AttributeKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AttributeKeys));
        return pointer == System.IntPtr.Zero ? (AttributeKeysSetting) null : new AttributeKeysSetting(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AttributeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemCategorySettings ItemCategorySettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ItemCategorySettings));
        return pointer == System.IntPtr.Zero ? (ItemCategorySettings) null : new ItemCategorySettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ItemCategorySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LayoutGroup BagsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagsParent));
        return pointer == System.IntPtr.Zero ? (LayoutGroup) null : new LayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject BagInventoriesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagInventoriesParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagInventoriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> BagsSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagsSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagsSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry> PreInstantiatedBagsEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedBagsEntries));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry>) null : new List<ItemGridSelectionEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_PreInstantiatedBagsEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BagsContainerSlot> BagsContainerSlotEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagsContainerSlotEntries));
        return pointer == System.IntPtr.Zero ? (List<BagsContainerSlot>) null : new List<BagsContainerSlot>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagsContainerSlotEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BagContainer> BagContainers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagContainers));
        return pointer == System.IntPtr.Zero ? (List<BagContainer>) null : new List<BagContainer>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagContainers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>> BagInventorySelectionGroups
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagInventorySelectionGroups));
        return pointer == System.IntPtr.Zero ? (List<GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>>) null : new List<GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_BagInventorySelectionGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Head
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Head));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Head), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Chest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Chest));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Chest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Legs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Legs));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Legs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Feet
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Feet));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Feet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Weapon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Weapon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Weapon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Grimoire
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Grimoire));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Grimoire), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Cloak
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Cloak));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Cloak), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Gloves
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Gloves));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_Sprite_Gloves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public FmodEvent DropSound
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_DropSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_DropSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool ConnectedToSalvageStation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ConnectedToSalvageStation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ConnectedToSalvageStation)) = value;
      }
    }

    public unsafe List<CostData> _SalvageList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr__SalvageList));
        return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr__SalvageList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_MissingKnowledge
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_LKey_MissingKnowledge));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_LKey_MissingKnowledge)) = value;
      }
    }

    public unsafe GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data> RecipesGridSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>) null : new GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup RecipesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_RecipesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_RecipesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorkstationRecipeGridSelectionEntry RecipeEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_RecipeEntryPrefab));
        return pointer == System.IntPtr.Zero ? (WorkstationRecipeGridSelectionEntry) null : new WorkstationRecipeGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton TakeAllButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TakeAllButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TakeAllButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SortButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_SortButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_SortButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SmartMergeButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_SmartMergeButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_SmartMergeButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelfSortButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_SelfSortButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_SelfSortButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AllSortButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AllSortButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_AllSortButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ShowBagsButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ShowBagsButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_ShowBagsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HideBagsButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_HideBagsButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_HideBagsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton OpenTagEditButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_OpenTagEditButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_OpenTagEditButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TagEditPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TagEditPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TagEditPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CloseTagEditButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_CloseTagEditButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_CloseTagEditButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SaveTagButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_SaveTagButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_SaveTagButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField TagEditInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TagEditInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr_TagEditInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InputContextEntry.Data> _InventoryContextEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _CurrentTab_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr__CurrentTab_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr__CurrentTab_k__BackingField)) = value;
      }
    }

    public static unsafe float _TimeBeforeInAnimation
    {
      get
      {
        float beforeInAnimation;
        IL2CPP.il2cpp_field_static_get_value(InventorySubMenu.NativeFieldInfoPtr__TimeBeforeInAnimation, (void*) &beforeInAnimation);
        return beforeInAnimation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InventorySubMenu.NativeFieldInfoPtr__TimeBeforeInAnimation, (void*) &value);
      }
    }

    public static unsafe double _TimeLastClosed
    {
      get
      {
        double timeLastClosed;
        IL2CPP.il2cpp_field_static_get_value(InventorySubMenu.NativeFieldInfoPtr__TimeLastClosed, (void*) &timeLastClosed);
        return timeLastClosed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InventorySubMenu.NativeFieldInfoPtr__TimeLastClosed, (void*) &value);
      }
    }

    public InventorySubMenu.MenuSettings _Settings
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr__Settings);
        return new InventorySubMenu.MenuSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.NativeFieldInfoPtr__Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
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
      private static readonly System.IntPtr NativeFieldInfoPtr_StartCraftFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_CancelCraftFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalInventoryEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRemoteInventoryEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_InitStandardDrag;
      private static readonly System.IntPtr NativeFieldInfoPtr_InitSmartMerge;

      static MenuSettings()
      {
        Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, nameof (MenuSettings));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr);
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_Set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (Set));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (StartTab));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_UseItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (UseItemFlag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (TransferItemFlag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (SplitItemFlag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_RepairItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (RepairItemFlag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (DropItemFlag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_UnEquipItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (UnEquipItemFlag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartCraftFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (StartCraftFlag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_CancelCraftFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (CancelCraftFlag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (GetLocalUserEntity));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (GetLocalInventoryEntity));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (GetRemoteInventoryEntity));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitStandardDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (InitStandardDrag));
        InventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitSmartMerge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, nameof (InitSmartMerge));
      }

      public MenuSettings(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public MenuSettings()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventorySubMenu.MenuSettings>.NativeClassPtr, data));
      }

      public unsafe bool Set
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_Set));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_Set)) = value;
        }
      }

      public unsafe int StartTab
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartTab));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartTab)) = value;
        }
      }

      public unsafe InputFlag UseItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_UseItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_UseItemFlag)) = value;
        }
      }

      public unsafe InputFlag TransferItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag)) = value;
        }
      }

      public unsafe InputFlag SplitItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag)) = value;
        }
      }

      public unsafe InputFlag RepairItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_RepairItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_RepairItemFlag)) = value;
        }
      }

      public unsafe InputFlag DropItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag)) = value;
        }
      }

      public unsafe InputFlag UnEquipItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_UnEquipItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_UnEquipItemFlag)) = value;
        }
      }

      public unsafe InputFlag StartCraftFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartCraftFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_StartCraftFlag)) = value;
        }
      }

      public unsafe InputFlag CancelCraftFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_CancelCraftFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_CancelCraftFlag)) = value;
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetLocalUserEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalUserEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalUserEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetLocalInventoryEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetRemoteInventoryEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool InitStandardDrag
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitStandardDrag));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitStandardDrag)) = value;
        }
      }

      public unsafe bool InitSmartMerge
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitSmartMerge));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.MenuSettings.NativeFieldInfoPtr_InitSmartMerge)) = value;
        }
      }
    }

    public enum MenuTabs
    {
      Equipment,
      Crafting,
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
      EnableCrafting = 64, // 0x00000040
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenu/<>c__DisplayClass75_0")]
    public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_index;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__8_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass75_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenu.__c__DisplayClass75_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237397, XrefRangeEnd = 1237398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__8()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.__c__DisplayClass75_0.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass75_0()
      {
        Il2CppClassPointerStore<InventorySubMenu.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, "<>c__DisplayClass75_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenu.__c__DisplayClass75_0>.NativeClassPtr);
        InventorySubMenu.__c__DisplayClass75_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.__c__DisplayClass75_0>.NativeClassPtr, nameof (index));
        InventorySubMenu.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
        InventorySubMenu.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu.__c__DisplayClass75_0>.NativeClassPtr, 100665912);
        InventorySubMenu.__c__DisplayClass75_0.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu.__c__DisplayClass75_0>.NativeClassPtr, 100665913);
      }

      public __c__DisplayClass75_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int index
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.__c__DisplayClass75_0.NativeFieldInfoPtr_index));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.__c__DisplayClass75_0.NativeFieldInfoPtr_index)) = value;
        }
      }

      public unsafe InventorySubMenu __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenu.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__75_7;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_7_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__75_7(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_7_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<InventorySubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenu.__c>.NativeClassPtr);
        InventorySubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.__c>.NativeClassPtr, "<>9");
        InventorySubMenu.__c.NativeFieldInfoPtr___9__75_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenu.__c>.NativeClassPtr, "<>9__75_7");
        InventorySubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu.__c>.NativeClassPtr, 100665915);
        InventorySubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__75_7_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenu.__c>.NativeClassPtr, 100665916);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe InventorySubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InventorySubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InventorySubMenu.__c) null : new InventorySubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InventorySubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__75_7
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InventorySubMenu.__c.NativeFieldInfoPtr___9__75_7, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InventorySubMenu.__c.NativeFieldInfoPtr___9__75_7, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
