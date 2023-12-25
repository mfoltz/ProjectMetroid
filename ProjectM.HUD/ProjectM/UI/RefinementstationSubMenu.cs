// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.RefinementstationSubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class RefinementstationSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorsLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Recipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenTagEditButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagEditPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseTagEditButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveTagButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagEditInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationName;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefinementProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToggleButton_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToggleButton_Inactive;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToggleButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationStatusText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatusTextNormalColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatusTextErrorColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusesSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputInventorySelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputInventorySelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemInputsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemInputEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivateKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeactivateKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingBlacksmith;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingLumberjack;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingTailor;
    private static readonly System.IntPtr NativeFieldInfoPtr_StoredRecipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusRefining;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusDeactivated;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNoInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusOutputFull;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNoPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusDamaged;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNoOwner;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHoveredRecipeEntryItem_Public_Boolean_byref_RefinementstationRecipeEntry_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_0_Private_Void_StationBonusEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_1_Private_Void_RefinementstationRecipeEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_2_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_3_Private_Void_ItemGridSelectionEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244148, XrefRangeEnd = 1244150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244150, XrefRangeEnd = 1244231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244231, XrefRangeEnd = 1244246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1244254, RefRangeEnd = 1244255, XrefRangeStart = 1244246, XrefRangeEnd = 1244254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetHoveredRecipeEntryItem(
      out RefinementstationRecipeEntry hoveredRecipeEntry,
      out PrefabGUID hoveredItemGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hoveredItemGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr_TryGetHoveredRecipeEntryItem_Public_Boolean_byref_RefinementstationRecipeEntry_byref_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref RefinementstationRecipeEntry local = ref hoveredRecipeEntry;
      System.IntPtr pointer = zero;
      RefinementstationRecipeEntry refinementstationRecipeEntry = pointer == System.IntPtr.Zero ? (RefinementstationRecipeEntry) null : new RefinementstationRecipeEntry(pointer);
      local = refinementstationRecipeEntry;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244255, XrefRangeEnd = 1244263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RefinementstationSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244263, XrefRangeEnd = 1244265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_0(
      StationBonusEntry entry,
      StationBonusEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_0_Private_Void_StationBonusEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244265, XrefRangeEnd = 1244270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_1(
      RefinementstationRecipeEntry entry,
      RefinementstationRecipeEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_1_Private_Void_RefinementstationRecipeEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244270, XrefRangeEnd = 1244272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_2(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_2_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244272, XrefRangeEnd = 1244274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_3(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_3_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RefinementstationSubMenu()
    {
      Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (RefinementstationSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr);
      RefinementstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (CastleFloorsLocalizationKeys));
      RefinementstationSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      RefinementstationSubMenu.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (TooltipAnchor));
      RefinementstationSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (TooltipAnchor_Recipes));
      RefinementstationSubMenu.NativeFieldInfoPtr_OpenTagEditButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (OpenTagEditButton));
      RefinementstationSubMenu.NativeFieldInfoPtr_TagEditPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (TagEditPopupNode));
      RefinementstationSubMenu.NativeFieldInfoPtr_CloseTagEditButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (CloseTagEditButton));
      RefinementstationSubMenu.NativeFieldInfoPtr_SaveTagButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (SaveTagButton));
      RefinementstationSubMenu.NativeFieldInfoPtr_TagEditInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (TagEditInputField));
      RefinementstationSubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      RefinementstationSubMenu.NativeFieldInfoPtr_StationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (StationName));
      RefinementstationSubMenu.NativeFieldInfoPtr_StationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (StationDescription));
      RefinementstationSubMenu.NativeFieldInfoPtr_RefinementProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (RefinementProgress));
      RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButton_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ToggleButton_Active));
      RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButton_Inactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ToggleButton_Inactive));
      RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ToggleButtonText));
      RefinementstationSubMenu.NativeFieldInfoPtr_StationStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (StationStatusText));
      RefinementstationSubMenu.NativeFieldInfoPtr_StatusTextNormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (StatusTextNormalColor));
      RefinementstationSubMenu.NativeFieldInfoPtr_StatusTextErrorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (StatusTextErrorColor));
      RefinementstationSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (BonusesSelectionGroup));
      RefinementstationSubMenu.NativeFieldInfoPtr_BonusesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (BonusesParent));
      RefinementstationSubMenu.NativeFieldInfoPtr_BonusEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (BonusEntryPrefab));
      RefinementstationSubMenu.NativeFieldInfoPtr_RecipesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (RecipesSelectionGroup));
      RefinementstationSubMenu.NativeFieldInfoPtr_RecipesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (RecipesParent));
      RefinementstationSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (RecipeEntryPrefab));
      RefinementstationSubMenu.NativeFieldInfoPtr_InputInventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (InputInventorySelectionGroup));
      RefinementstationSubMenu.NativeFieldInfoPtr_OutputInventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (OutputInventorySelectionGroup));
      RefinementstationSubMenu.NativeFieldInfoPtr_ItemInputsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ItemInputsParent));
      RefinementstationSubMenu.NativeFieldInfoPtr_ItemInputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ItemInputEntryPrefab));
      RefinementstationSubMenu.NativeFieldInfoPtr_ItemOutputsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ItemOutputsParent));
      RefinementstationSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ItemOutputEntryPrefab));
      RefinementstationSubMenu.NativeFieldInfoPtr_ActivateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (ActivateKey));
      RefinementstationSubMenu.NativeFieldInfoPtr_DeactivateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (DeactivateKey));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_MissingBlacksmith));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_MissingLumberjack));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingTailor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_MissingTailor));
      RefinementstationSubMenu.NativeFieldInfoPtr_StoredRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (StoredRecipes));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusRefining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_StatusRefining));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_StatusDeactivated));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_StatusNoInput));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_StatusOutputFull));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_StatusNoPower));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_StatusDamaged));
      RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, nameof (LKey_StatusNoOwner));
      RefinementstationSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666212);
      RefinementstationSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666213);
      RefinementstationSubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666214);
      RefinementstationSubMenu.NativeMethodInfoPtr_TryGetHoveredRecipeEntryItem_Public_Boolean_byref_RefinementstationRecipeEntry_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666215);
      RefinementstationSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666216);
      RefinementstationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_0_Private_Void_StationBonusEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666217);
      RefinementstationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_1_Private_Void_RefinementstationRecipeEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666218);
      RefinementstationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_2_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666219);
      RefinementstationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_3_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, 100666220);
    }

    public RefinementstationSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleFloorsLocalizationKeys CastleFloorsLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (CastleFloorsLocalizationKeys) null : new CastleFloorsLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor_Recipes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton OpenTagEditButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_OpenTagEditButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_OpenTagEditButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TagEditPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_TagEditPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_TagEditPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CloseTagEditButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_CloseTagEditButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_CloseTagEditButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SaveTagButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_SaveTagButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_SaveTagButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField TagEditInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_TagEditInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_TagEditInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StationName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StationName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationDescription
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StationDescription));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StationDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CraftingProgress RefinementProgress
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_RefinementProgress));
        return pointer == System.IntPtr.Zero ? (CraftingProgress) null : new CraftingProgress(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_RefinementProgress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ToggleButton_Active
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButton_Active));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButton_Active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ToggleButton_Inactive
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButton_Inactive));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButton_Inactive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ToggleButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ToggleButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationStatusText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StationStatusText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StationStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color StatusTextNormalColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StatusTextNormalColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StatusTextNormalColor)) = value;
      }
    }

    public unsafe Color StatusTextErrorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StatusTextErrorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StatusTextErrorColor)) = value;
      }
    }

    public unsafe GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data> BonusesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>) null : new GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup BonusesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_BonusesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_BonusesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StationBonusEntry BonusEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_BonusEntryPrefab));
        return pointer == System.IntPtr.Zero ? (StationBonusEntry) null : new StationBonusEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_BonusEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<RefinementstationRecipeEntry, RefinementstationRecipeEntry.Data> RecipesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_RecipesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<RefinementstationRecipeEntry, RefinementstationRecipeEntry.Data>) null : new GridSelectionGroup<RefinementstationRecipeEntry, RefinementstationRecipeEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_RecipesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup RecipesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_RecipesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_RecipesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RefinementstationRecipeEntry RecipeEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab));
        return pointer == System.IntPtr.Zero ? (RefinementstationRecipeEntry) null : new RefinementstationRecipeEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> InputInventorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_InputInventorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_InputInventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> OutputInventorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_OutputInventorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_OutputInventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ItemInputsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ItemInputsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ItemInputsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemInputEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ItemInputEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ItemInputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ItemOutputsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ItemOutputsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ItemOutputsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemOutputEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey ActivateKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ActivateKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_ActivateKey)) = value;
      }
    }

    public unsafe LocalizationKey DeactivateKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_DeactivateKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_DeactivateKey)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingBlacksmith
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingLumberjack
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingTailor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingTailor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_MissingTailor)) = value;
      }
    }

    public unsafe List<PrefabGUID> StoredRecipes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StoredRecipes));
        return pointer == System.IntPtr.Zero ? (List<PrefabGUID>) null : new List<PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_StoredRecipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_StatusRefining
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusRefining));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusRefining)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusDeactivated
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNoInput
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusOutputFull
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNoPower
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusDamaged
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNoOwner
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoOwner));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenu.NativeFieldInfoPtr_LKey_StatusNoOwner)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.RefinementstationSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__45_4;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_4_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_4(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_4_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<RefinementstationSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RefinementstationSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationSubMenu.__c>.NativeClassPtr);
        RefinementstationSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu.__c>.NativeClassPtr, "<>9");
        RefinementstationSubMenu.__c.NativeFieldInfoPtr___9__45_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenu.__c>.NativeClassPtr, "<>9__45_4");
        RefinementstationSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu.__c>.NativeClassPtr, 100666222);
        RefinementstationSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_4_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenu.__c>.NativeClassPtr, 100666223);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe RefinementstationSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RefinementstationSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RefinementstationSubMenu.__c) null : new RefinementstationSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RefinementstationSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__45_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RefinementstationSubMenu.__c.NativeFieldInfoPtr___9__45_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RefinementstationSubMenu.__c.NativeFieldInfoPtr___9__45_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
