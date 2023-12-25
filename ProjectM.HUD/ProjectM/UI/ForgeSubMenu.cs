// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ForgeSubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ForgeSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_InsertText;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Arrow;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResultsFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_MagicCircle;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorsLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevelRaritySettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoWeaponIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemOutputGridSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusesSelectionGroup;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_0_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_1_Private_Void_StationBonusEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234719, XrefRangeEnd = 1234774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234774, XrefRangeEnd = 1234775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ForgeSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234775, XrefRangeEnd = 1234777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__21_0(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_0_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234777, XrefRangeEnd = 1234779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__21_1(
      StationBonusEntry entry,
      StationBonusEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_1_Private_Void_StationBonusEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ForgeSubMenu()
    {
      Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ForgeSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr);
      ForgeSubMenu.NativeFieldInfoPtr_RepairButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (RepairButton));
      ForgeSubMenu.NativeFieldInfoPtr_WeaponEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (WeaponEntry));
      ForgeSubMenu.NativeFieldInfoPtr_WeaponInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (WeaponInfo));
      ForgeSubMenu.NativeFieldInfoPtr_InsertText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (InsertText));
      ForgeSubMenu.NativeFieldInfoPtr_RepairText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (RepairText));
      ForgeSubMenu.NativeFieldInfoPtr_Arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (Arrow));
      ForgeSubMenu.NativeFieldInfoPtr_ResultsFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (ResultsFrame));
      ForgeSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      ForgeSubMenu.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (TooltipAnchor));
      ForgeSubMenu.NativeFieldInfoPtr_MagicCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (MagicCircle));
      ForgeSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (CastleFloorsLocalizationKeys));
      ForgeSubMenu.NativeFieldInfoPtr_InventoryLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (InventoryLocalizationKeys));
      ForgeSubMenu.NativeFieldInfoPtr_ItemLevelRaritySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (ItemLevelRaritySettings));
      ForgeSubMenu.NativeFieldInfoPtr_InputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (InputContexts));
      ForgeSubMenu.NativeFieldInfoPtr_NoWeaponIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (NoWeaponIcon));
      ForgeSubMenu.NativeFieldInfoPtr_ItemOutputsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (ItemOutputsParent));
      ForgeSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (ItemOutputEntryPrefab));
      ForgeSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (ItemOutputGridSelectionGroup));
      ForgeSubMenu.NativeFieldInfoPtr_BonusesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (BonusesParent));
      ForgeSubMenu.NativeFieldInfoPtr_BonusEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (BonusEntryPrefab));
      ForgeSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, nameof (BonusesSelectionGroup));
      ForgeSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, 100665685);
      ForgeSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, 100665686);
      ForgeSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, 100665687);
      ForgeSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_0_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, 100665688);
      ForgeSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_1_Private_Void_StationBonusEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, 100665689);
    }

    public ForgeSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ForgeSubMenu_RepairButton RepairButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_RepairButton));
        return pointer == System.IntPtr.Zero ? (ForgeSubMenu_RepairButton) null : new ForgeSubMenu_RepairButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_RepairButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ForgeSubMenu_WeaponEntry WeaponEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_WeaponEntry));
        return pointer == System.IntPtr.Zero ? (ForgeSubMenu_WeaponEntry) null : new ForgeSubMenu_WeaponEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_WeaponEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ForgeSubMenu_ResultsFrame WeaponInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_WeaponInfo));
        return pointer == System.IntPtr.Zero ? (ForgeSubMenu_ResultsFrame) null : new ForgeSubMenu_ResultsFrame(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_WeaponInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText InsertText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_InsertText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_InsertText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText RepairText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_RepairText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_RepairText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Arrow
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_Arrow));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_Arrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ResultsFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ResultsFrame));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ResultsFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ForgeSubMenu_MagicCircle MagicCircle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_MagicCircle));
        return pointer == System.IntPtr.Zero ? (ForgeSubMenu_MagicCircle) null : new ForgeSubMenu_MagicCircle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_MagicCircle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleFloorsLocalizationKeys CastleFloorsLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (CastleFloorsLocalizationKeys) null : new CastleFloorsLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventoryLocalizationKeys InventoryLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_InventoryLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (InventoryLocalizationKeys) null : new InventoryLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_InventoryLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemLevelRaritySettings ItemLevelRaritySettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ItemLevelRaritySettings));
        return pointer == System.IntPtr.Zero ? (ItemLevelRaritySettings) null : new ItemLevelRaritySettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ItemLevelRaritySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection InputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_InputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_InputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite NoWeaponIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_NoWeaponIcon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_NoWeaponIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ItemOutputsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ItemOutputsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ItemOutputsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemOutputEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ItemOutputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> ItemOutputGridSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_ItemOutputGridSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup BonusesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_BonusesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_BonusesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StationBonusEntry BonusEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_BonusEntryPrefab));
        return pointer == System.IntPtr.Zero ? (StationBonusEntry) null : new StationBonusEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_BonusEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data> BonusesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>) null : new GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu.NativeFieldInfoPtr_BonusesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.ForgeSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__21_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_2_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgeSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__21_2(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_2_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<ForgeSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu.__c>.NativeClassPtr);
        ForgeSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu.__c>.NativeClassPtr, "<>9");
        ForgeSubMenu.__c.NativeFieldInfoPtr___9__21_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu.__c>.NativeClassPtr, "<>9__21_2");
        ForgeSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu.__c>.NativeClassPtr, 100665691);
        ForgeSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__21_2_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu.__c>.NativeClassPtr, 100665692);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ForgeSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ForgeSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ForgeSubMenu.__c) null : new ForgeSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ForgeSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__21_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ForgeSubMenu.__c.NativeFieldInfoPtr___9__21_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ForgeSubMenu.__c.NativeFieldInfoPtr___9__21_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
