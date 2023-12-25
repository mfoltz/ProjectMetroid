// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SalvagestationSubMenu
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
  public class SalvagestationSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorsLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Recipes;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusRefining;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusDeactivated;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNoInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNoValidInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusOutputFull;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusNoPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusDamaged;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Salvage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Salvageable;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_StationBonusEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Private_Void_ItemGridSelectionEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246821, XrefRangeEnd = 1246822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246822, XrefRangeEnd = 1246888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246888, XrefRangeEnd = 1246893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SalvagestationSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246893, XrefRangeEnd = 1246895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_0(
      StationBonusEntry entry,
      StationBonusEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_StationBonusEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246895, XrefRangeEnd = 1246897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_1(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246897, XrefRangeEnd = 1246899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_2(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SalvagestationSubMenu()
    {
      Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SalvagestationSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr);
      SalvagestationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (CastleFloorsLocalizationKeys));
      SalvagestationSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      SalvagestationSubMenu.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (TooltipAnchor));
      SalvagestationSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (TooltipAnchor_Recipes));
      SalvagestationSubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      SalvagestationSubMenu.NativeFieldInfoPtr_StationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (StationName));
      SalvagestationSubMenu.NativeFieldInfoPtr_StationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (StationDescription));
      SalvagestationSubMenu.NativeFieldInfoPtr_RefinementProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (RefinementProgress));
      SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButton_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ToggleButton_Active));
      SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButton_Inactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ToggleButton_Inactive));
      SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ToggleButtonText));
      SalvagestationSubMenu.NativeFieldInfoPtr_StationStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (StationStatusText));
      SalvagestationSubMenu.NativeFieldInfoPtr_StatusTextNormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (StatusTextNormalColor));
      SalvagestationSubMenu.NativeFieldInfoPtr_StatusTextErrorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (StatusTextErrorColor));
      SalvagestationSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (BonusesSelectionGroup));
      SalvagestationSubMenu.NativeFieldInfoPtr_BonusesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (BonusesParent));
      SalvagestationSubMenu.NativeFieldInfoPtr_BonusEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (BonusEntryPrefab));
      SalvagestationSubMenu.NativeFieldInfoPtr_InputInventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (InputInventorySelectionGroup));
      SalvagestationSubMenu.NativeFieldInfoPtr_OutputInventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (OutputInventorySelectionGroup));
      SalvagestationSubMenu.NativeFieldInfoPtr_ItemInputsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ItemInputsParent));
      SalvagestationSubMenu.NativeFieldInfoPtr_ItemInputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ItemInputEntryPrefab));
      SalvagestationSubMenu.NativeFieldInfoPtr_ItemOutputsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ItemOutputsParent));
      SalvagestationSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ItemOutputEntryPrefab));
      SalvagestationSubMenu.NativeFieldInfoPtr_ActivateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (ActivateKey));
      SalvagestationSubMenu.NativeFieldInfoPtr_DeactivateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (DeactivateKey));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_MissingBlacksmith));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_MissingLumberjack));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingTailor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_MissingTailor));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusRefining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_StatusRefining));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_StatusDeactivated));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_StatusNoInput));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoValidInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_StatusNoValidInput));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_StatusOutputFull));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_StatusNoPower));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_StatusDamaged));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_Salvage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_Salvage));
      SalvagestationSubMenu.NativeFieldInfoPtr_LKey_Salvageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, nameof (LKey_Salvageable));
      SalvagestationSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, 100666360);
      SalvagestationSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, 100666361);
      SalvagestationSubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, 100666362);
      SalvagestationSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, 100666363);
      SalvagestationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_StationBonusEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, 100666364);
      SalvagestationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, 100666365);
      SalvagestationSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, 100666366);
    }

    public SalvagestationSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleFloorsLocalizationKeys CastleFloorsLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (CastleFloorsLocalizationKeys) null : new CastleFloorsLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor_Recipes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_TooltipAnchor_Recipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StationName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StationName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationDescription
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StationDescription));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StationDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CraftingProgress RefinementProgress
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_RefinementProgress));
        return pointer == System.IntPtr.Zero ? (CraftingProgress) null : new CraftingProgress(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_RefinementProgress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ToggleButton_Active
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButton_Active));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButton_Active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ToggleButton_Inactive
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButton_Inactive));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButton_Inactive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ToggleButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ToggleButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationStatusText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StationStatusText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StationStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color StatusTextNormalColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StatusTextNormalColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StatusTextNormalColor)) = value;
      }
    }

    public unsafe Color StatusTextErrorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StatusTextErrorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_StatusTextErrorColor)) = value;
      }
    }

    public unsafe GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data> BonusesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>) null : new GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup BonusesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_BonusesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_BonusesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StationBonusEntry BonusEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_BonusEntryPrefab));
        return pointer == System.IntPtr.Zero ? (StationBonusEntry) null : new StationBonusEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_BonusEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> InputInventorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_InputInventorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_InputInventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> OutputInventorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_OutputInventorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_OutputInventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ItemInputsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ItemInputsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ItemInputsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemInputEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ItemInputEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ItemInputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ItemOutputsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ItemOutputsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ItemOutputsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemOutputEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey ActivateKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ActivateKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_ActivateKey)) = value;
      }
    }

    public unsafe LocalizationKey DeactivateKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_DeactivateKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_DeactivateKey)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingBlacksmith
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingLumberjack
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingLumberjack)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingTailor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingTailor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_MissingTailor)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusRefining
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusRefining));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusRefining)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusDeactivated
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusDeactivated)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNoInput
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoInput)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNoValidInput
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoValidInput));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoValidInput)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusOutputFull
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusNoPower
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusNoPower)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusDamaged
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_StatusDamaged)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Salvage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_Salvage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_Salvage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Salvageable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_Salvageable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SalvagestationSubMenu.NativeFieldInfoPtr_LKey_Salvageable)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.SalvagestationSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__38_3;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SalvagestationSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_3(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SalvagestationSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<SalvagestationSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SalvagestationSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SalvagestationSubMenu.__c>.NativeClassPtr);
        SalvagestationSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu.__c>.NativeClassPtr, "<>9");
        SalvagestationSubMenu.__c.NativeFieldInfoPtr___9__38_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvagestationSubMenu.__c>.NativeClassPtr, "<>9__38_3");
        SalvagestationSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu.__c>.NativeClassPtr, 100666368);
        SalvagestationSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvagestationSubMenu.__c>.NativeClassPtr, 100666369);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe SalvagestationSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SalvagestationSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (SalvagestationSubMenu.__c) null : new SalvagestationSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SalvagestationSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__38_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SalvagestationSubMenu.__c.NativeFieldInfoPtr___9__38_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SalvagestationSubMenu.__c.NativeFieldInfoPtr___9__38_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
