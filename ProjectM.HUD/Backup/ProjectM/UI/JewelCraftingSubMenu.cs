// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.JewelCraftingSubMenu
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
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class JewelCraftingSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorsLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationName;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSchoolsNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResultsNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesStatusText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationStatusText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatusTextNormalColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatusTextErrorColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSchoolsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSchoolEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_SelectSpellSchool;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingRecipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingKnowledge;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingBlacksmith;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingLumberjack;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingTailor;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNotPowered;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusDamaged;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusOutputFull;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CompleteButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSchoolAssets;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusesSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSchoolsSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesGridSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputGridSelectionGroup;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_StationBonusEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Private_Void_ItemGridSelectionEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239842, XrefRangeEnd = 1239941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239941, XrefRangeEnd = 1239943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JewelCraftingSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239943, XrefRangeEnd = 1239945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_0(
      StationBonusEntry entry,
      StationBonusEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_StationBonusEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239945, XrefRangeEnd = 1239947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_3(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JewelCraftingSubMenu()
    {
      Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (JewelCraftingSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr);
      JewelCraftingSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (CastleFloorsLocalizationKeys));
      JewelCraftingSubMenu.NativeFieldInfoPtr_WorkstationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (WorkstationName));
      JewelCraftingSubMenu.NativeFieldInfoPtr_StationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (StationDescription));
      JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (SpellSchoolsNode));
      JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (RecipesNode));
      JewelCraftingSubMenu.NativeFieldInfoPtr_ResultsNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (ResultsNode));
      JewelCraftingSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      JewelCraftingSubMenu.NativeFieldInfoPtr_AbilityTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (AbilityTooltip));
      JewelCraftingSubMenu.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (TooltipAnchor));
      JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (RecipesStatusText));
      JewelCraftingSubMenu.NativeFieldInfoPtr_StationStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (StationStatusText));
      JewelCraftingSubMenu.NativeFieldInfoPtr_StatusTextNormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (StatusTextNormalColor));
      JewelCraftingSubMenu.NativeFieldInfoPtr_StatusTextErrorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (StatusTextErrorColor));
      JewelCraftingSubMenu.NativeFieldInfoPtr_BonusesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (BonusesParent));
      JewelCraftingSubMenu.NativeFieldInfoPtr_BonusEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (BonusEntryPrefab));
      JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (SpellSchoolsParent));
      JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (SpellSchoolEntryPrefab));
      JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (RecipesParent));
      JewelCraftingSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (RecipeEntryPrefab));
      JewelCraftingSubMenu.NativeFieldInfoPtr_JewelInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (JewelInfo));
      JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (ItemOutputsParent));
      JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (ItemOutputEntryPrefab));
      JewelCraftingSubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_SelectSpellSchool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_SelectSpellSchool));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_MissingRecipes));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingKnowledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_MissingKnowledge));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_MissingBlacksmith));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_MissingLumberjack));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingTailor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_MissingTailor));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusNotPowered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_StatusNotPowered));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_StatusDamaged));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_StatusOutputFull));
      JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_CompleteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (LKey_CompleteButton));
      JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (SpellSchoolAssets));
      JewelCraftingSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (BonusesSelectionGroup));
      JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (SpellSchoolsSelectionGroup));
      JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (RecipesGridSelectionGroup));
      JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, nameof (ItemOutputGridSelectionGroup));
      JewelCraftingSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, 100665982);
      JewelCraftingSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, 100665983);
      JewelCraftingSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, 100665984);
      JewelCraftingSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_StationBonusEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, 100665985);
      JewelCraftingSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, 100665986);
    }

    public JewelCraftingSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleFloorsLocalizationKeys CastleFloorsLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (CastleFloorsLocalizationKeys) null : new CastleFloorsLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText WorkstationName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_WorkstationName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_WorkstationName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationDescription
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_StationDescription));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_StationDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SpellSchoolsNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RecipesNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ResultsNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ResultsNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ResultsNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityTooltip AbilityTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_AbilityTooltip));
        return pointer == System.IntPtr.Zero ? (AbilityTooltip) null : new AbilityTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_AbilityTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText RecipesStatusText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesStatusText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationStatusText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_StationStatusText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_StationStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color StatusTextNormalColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_StatusTextNormalColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_StatusTextNormalColor)) = value;
      }
    }

    public unsafe Color StatusTextErrorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_StatusTextErrorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_StatusTextErrorColor)) = value;
      }
    }

    public unsafe GridLayoutGroup BonusesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_BonusesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_BonusesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StationBonusEntry BonusEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_BonusEntryPrefab));
        return pointer == System.IntPtr.Zero ? (StationBonusEntry) null : new StationBonusEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_BonusEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup SpellSchoolsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellSchoolGridSelectionEntry SpellSchoolEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolEntryPrefab));
        return pointer == System.IntPtr.Zero ? (SpellSchoolGridSelectionEntry) null : new SpellSchoolGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup RecipesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorkstationRecipeGridSelectionEntry RecipeEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab));
        return pointer == System.IntPtr.Zero ? (WorkstationRecipeGridSelectionEntry) null : new WorkstationRecipeGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenu_JewelInfo JewelInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_JewelInfo));
        return pointer == System.IntPtr.Zero ? (SpellbookMenu_JewelInfo) null : new SpellbookMenu_JewelInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_JewelInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ItemOutputsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemOutputEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_SelectSpellSchool
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_SelectSpellSchool));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_SelectSpellSchool)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingRecipes
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingRecipes));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingRecipes)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingKnowledge
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingKnowledge));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingKnowledge)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingBlacksmith
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingLumberjack
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingTailor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingTailor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_MissingTailor)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNotPowered
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusNotPowered));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusNotPowered)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusDamaged
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusOutputFull
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CompleteButton
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_CompleteButton));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_LKey_CompleteButton)) = value;
      }
    }

    public unsafe List<SpellSchoolAsset> SpellSchoolAssets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolAssets));
        return pointer == System.IntPtr.Zero ? (List<SpellSchoolAsset>) null : new List<SpellSchoolAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data> BonusesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>) null : new GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<SpellSchoolGridSelectionEntry, SpellSchoolGridSelectionEntry.Data> SpellSchoolsSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<SpellSchoolGridSelectionEntry, SpellSchoolGridSelectionEntry.Data>) null : new GridSelectionGroup<SpellSchoolGridSelectionEntry, SpellSchoolGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_SpellSchoolsSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data> RecipesGridSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>) null : new GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> ItemOutputGridSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.JewelCraftingSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__38_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__38_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__38_4;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Internal_Void_SpellSchoolGridSelectionEntry_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Internal_Void_WorkstationRecipeGridSelectionEntry_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_4_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239841, XrefRangeEnd = 1239842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_1(
        SpellSchoolGridSelectionEntry entry,
        SpellSchoolGridSelectionEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Internal_Void_SpellSchoolGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_2(
        WorkstationRecipeGridSelectionEntry entry,
        WorkstationRecipeGridSelectionEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Internal_Void_WorkstationRecipeGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_4(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelCraftingSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_4_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelCraftingSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr);
        JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr, "<>9");
        JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr, "<>9__38_1");
        JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr, "<>9__38_2");
        JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr, "<>9__38_4");
        JewelCraftingSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr, 100665988);
        JewelCraftingSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Internal_Void_SpellSchoolGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr, 100665989);
        JewelCraftingSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Internal_Void_WorkstationRecipeGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr, 100665990);
        JewelCraftingSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_4_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingSubMenu.__c>.NativeClassPtr, 100665991);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe JewelCraftingSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (JewelCraftingSubMenu.__c) null : new JewelCraftingSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<SpellSchoolGridSelectionEntry, SpellSchoolGridSelectionEntry.Data> __9__38_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SpellSchoolGridSelectionEntry, SpellSchoolGridSelectionEntry.Data>) null : new Il2CppSystem.Action<SpellSchoolGridSelectionEntry, SpellSchoolGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data> __9__38_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>) null : new Il2CppSystem.Action<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__38_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelCraftingSubMenu.__c.NativeFieldInfoPtr___9__38_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
