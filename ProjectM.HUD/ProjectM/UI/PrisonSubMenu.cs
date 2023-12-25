// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PrisonSubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class PrisonSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorsLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Recipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID_PrisonInteractBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationStatusText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatusTextErrorColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_FullCell;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label_PrisonerName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label_PrisonerBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label_PrisonerTorture;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image_Prisoner_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image_Prisoner_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image_Prisoner_RecentDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image_Prisoner_Shield;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button_Kill;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button_Charm;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_EmptyCell;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label_ImprisonInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button_Imprison;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationName;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusesSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TortureInfoHovered;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesGridSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputGridSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusRefining;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusDeactivated;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNoInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusOutputFull;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNoPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusDamaged;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_TortureInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_TortureHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Imprison_NoUnit;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Imprison_Unit;
    private static readonly System.IntPtr NativeFieldInfoPtr_TortureSprite;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_0_Private_Void_StationBonusEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_2_Private_Void_ItemGridSelectionEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242781, XrefRangeEnd = 1242782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrisonSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242782, XrefRangeEnd = 1242859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrisonSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242859, XrefRangeEnd = 1242861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_0(
      StationBonusEntry entry,
      StationBonusEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_0_Private_Void_StationBonusEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242861, XrefRangeEnd = 1242863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_2(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_2_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrisonSubMenu()
    {
      Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PrisonSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr);
      PrisonSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (CastleFloorsLocalizationKeys));
      PrisonSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      PrisonSubMenu.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (TooltipAnchor));
      PrisonSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (TooltipAnchor_Recipes));
      PrisonSubMenu.NativeFieldInfoPtr_PrefabGUID_PrisonInteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (PrefabGUID_PrisonInteractBuff));
      PrisonSubMenu.NativeFieldInfoPtr_StationStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (StationStatusText));
      PrisonSubMenu.NativeFieldInfoPtr_StatusTextErrorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (StatusTextErrorColor));
      PrisonSubMenu.NativeFieldInfoPtr_Parent_FullCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Parent_FullCell));
      PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Label_PrisonerName));
      PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Label_PrisonerBlood));
      PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerTorture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Label_PrisonerTorture));
      PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Image_Prisoner_BloodType));
      PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Image_Prisoner_Health));
      PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_RecentDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Image_Prisoner_RecentDamage));
      PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_Shield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Image_Prisoner_Shield));
      PrisonSubMenu.NativeFieldInfoPtr_Button_Kill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Button_Kill));
      PrisonSubMenu.NativeFieldInfoPtr_Button_Charm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Button_Charm));
      PrisonSubMenu.NativeFieldInfoPtr_Parent_EmptyCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Parent_EmptyCell));
      PrisonSubMenu.NativeFieldInfoPtr_Label_ImprisonInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Label_ImprisonInfo));
      PrisonSubMenu.NativeFieldInfoPtr_Button_Imprison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (Button_Imprison));
      PrisonSubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      PrisonSubMenu.NativeFieldInfoPtr_StationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (StationName));
      PrisonSubMenu.NativeFieldInfoPtr_StationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (StationDescription));
      PrisonSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (BonusesSelectionGroup));
      PrisonSubMenu.NativeFieldInfoPtr_BonusesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (BonusesParent));
      PrisonSubMenu.NativeFieldInfoPtr_BonusEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (BonusEntryPrefab));
      PrisonSubMenu.NativeFieldInfoPtr_TortureInfoHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (TortureInfoHovered));
      PrisonSubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (RecipesGridSelectionGroup));
      PrisonSubMenu.NativeFieldInfoPtr_RecipesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (RecipesParent));
      PrisonSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (RecipeEntryPrefab));
      PrisonSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (ItemOutputGridSelectionGroup));
      PrisonSubMenu.NativeFieldInfoPtr_ItemOutputsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (ItemOutputsParent));
      PrisonSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (ItemOutputEntryPrefab));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusRefining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_StatusRefining));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_StatusDeactivated));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_StatusNoInput));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_StatusOutputFull));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_StatusNoPower));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_StatusDamaged));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_TortureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_TortureInfo));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_TortureHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_TortureHeader));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_Imprison_NoUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_Imprison_NoUnit));
      PrisonSubMenu.NativeFieldInfoPtr_LKey_Imprison_Unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (LKey_Imprison_Unit));
      PrisonSubMenu.NativeFieldInfoPtr_TortureSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, nameof (TortureSprite));
      PrisonSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, 100666163);
      PrisonSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, 100666164);
      PrisonSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, 100666165);
      PrisonSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_0_Private_Void_StationBonusEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, 100666166);
      PrisonSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_2_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, 100666167);
    }

    public PrisonSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleFloorsLocalizationKeys CastleFloorsLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (CastleFloorsLocalizationKeys) null : new CastleFloorsLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor_Recipes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent PrefabGUID_PrisonInteractBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_PrefabGUID_PrisonInteractBuff));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_PrefabGUID_PrisonInteractBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationStatusText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_StationStatusText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_StationStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color StatusTextErrorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_StatusTextErrorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_StatusTextErrorColor)) = value;
      }
    }

    public unsafe GameObject Parent_FullCell
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Parent_FullCell));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Parent_FullCell), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label_PrisonerName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label_PrisonerBlood
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerBlood));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerBlood), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label_PrisonerTorture
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerTorture));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Label_PrisonerTorture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_Prisoner_BloodType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_BloodType));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_Prisoner_Health
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_Health));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_Health), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_Prisoner_RecentDamage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_RecentDamage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_RecentDamage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_Prisoner_Shield
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_Shield));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Image_Prisoner_Shield), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button_Kill
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Button_Kill));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Button_Kill), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button_Charm
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Button_Charm));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Button_Charm), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Parent_EmptyCell
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Parent_EmptyCell));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Parent_EmptyCell), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label_ImprisonInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Label_ImprisonInfo));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Label_ImprisonInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button_Imprison
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Button_Imprison));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_Button_Imprison), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_StationName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_StationName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationDescription
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_StationDescription));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_StationDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data> BonusesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>) null : new GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup BonusesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_BonusesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_BonusesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StationBonusEntry BonusEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_BonusEntryPrefab));
        return pointer == System.IntPtr.Zero ? (StationBonusEntry) null : new StationBonusEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_BonusEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry TortureInfoHovered
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_TortureInfoHovered));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_TortureInfoHovered), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data> RecipesGridSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>) null : new GridSelectionGroup<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_RecipesGridSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup RecipesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_RecipesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_RecipesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorkstationRecipeGridSelectionEntry RecipeEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab));
        return pointer == System.IntPtr.Zero ? (WorkstationRecipeGridSelectionEntry) null : new WorkstationRecipeGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> ItemOutputGridSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ItemOutputsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_ItemOutputsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_ItemOutputsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemOutputEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_StatusRefining
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusRefining));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusRefining)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusDeactivated
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNoInput
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusOutputFull
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNoPower
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusDamaged
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TortureInfo
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_TortureInfo));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_TortureInfo)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TortureHeader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_TortureHeader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_TortureHeader)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Imprison_NoUnit
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_Imprison_NoUnit));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_Imprison_NoUnit)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Imprison_Unit
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_Imprison_Unit));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_LKey_Imprison_Unit)) = value;
      }
    }

    public unsafe Sprite TortureSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_TortureSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonSubMenu.NativeFieldInfoPtr_TortureSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.PrisonSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__45_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__45_3;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_1_Internal_Void_WorkstationRecipeGridSelectionEntry_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_3_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrisonSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_1(
        WorkstationRecipeGridSelectionEntry entry,
        WorkstationRecipeGridSelectionEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrisonSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_1_Internal_Void_WorkstationRecipeGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__45_3(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrisonSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_3_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrisonSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr);
        PrisonSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr, "<>9");
        PrisonSubMenu.__c.NativeFieldInfoPtr___9__45_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr, "<>9__45_1");
        PrisonSubMenu.__c.NativeFieldInfoPtr___9__45_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr, "<>9__45_3");
        PrisonSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr, 100666169);
        PrisonSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_1_Internal_Void_WorkstationRecipeGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr, 100666170);
        PrisonSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__45_3_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonSubMenu.__c>.NativeClassPtr, 100666171);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe PrisonSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrisonSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (PrisonSubMenu.__c) null : new PrisonSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrisonSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data> __9__45_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrisonSubMenu.__c.NativeFieldInfoPtr___9__45_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>) null : new Il2CppSystem.Action<WorkstationRecipeGridSelectionEntry, WorkstationRecipeGridSelectionEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrisonSubMenu.__c.NativeFieldInfoPtr___9__45_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__45_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrisonSubMenu.__c.NativeFieldInfoPtr___9__45_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrisonSubMenu.__c.NativeFieldInfoPtr___9__45_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
