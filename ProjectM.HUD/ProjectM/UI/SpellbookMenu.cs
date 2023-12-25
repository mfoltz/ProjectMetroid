// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpellbookMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SpellbookMenu : FullscreenMenuView
  {
    private static readonly IntPtr NativeFieldInfoPtr_Schools;
    private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage;
    private static readonly IntPtr NativeFieldInfoPtr_SchoolNameText;
    private static readonly IntPtr NativeFieldInfoPtr_SchoolDescriptionText;
    private static readonly IntPtr NativeFieldInfoPtr_BuffEntries;
    private static readonly IntPtr NativeFieldInfoPtr_SchoolAbilityView;
    private static readonly IntPtr NativeFieldInfoPtr_BasicVBloodAbilityEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_TravelVBloodAbilityEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_UltimateVBloodAbilityEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_UnknownVBloodAbilityIcon;
    private static readonly IntPtr NativeFieldInfoPtr_UpperBasicVBloodAbilityParent;
    private static readonly IntPtr NativeFieldInfoPtr_UpperBasicVBloodAbilityEntryGroup;
    private static readonly IntPtr NativeFieldInfoPtr_LowerBasicVBloodAbilityParent;
    private static readonly IntPtr NativeFieldInfoPtr_LowerBasicVBloodAbilityEntryGroup;
    private static readonly IntPtr NativeFieldInfoPtr_TravelVBloodAbilityParent;
    private static readonly IntPtr NativeFieldInfoPtr_TravelVBloodAbilityEntryGroup;
    private static readonly IntPtr NativeFieldInfoPtr_UltimateVBloodAbilityParent;
    private static readonly IntPtr NativeFieldInfoPtr_UltimateVBloodAbilityEntryGroup;
    private static readonly IntPtr NativeFieldInfoPtr_JewelView;
    private static readonly IntPtr NativeFieldInfoPtr_JewelEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_JewelGroup;
    private static readonly IntPtr NativeFieldInfoPtr_EquipJewelButton;
    private static readonly IntPtr NativeFieldInfoPtr_EquipJewelButton_Text;
    private static readonly IntPtr NativeFieldInfoPtr_JewelBackButton;
    private static readonly IntPtr NativeFieldInfoPtr_JewelInfo_Middle;
    private static readonly IntPtr NativeFieldInfoPtr_SelectedAbilityInfoParent;
    private static readonly IntPtr NativeFieldInfoPtr_SelectedAbilityNameText;
    private static readonly IntPtr NativeFieldInfoPtr_SelectedAbilityTypeText;
    private static readonly IntPtr NativeFieldInfoPtr_SelectedAbilityDescriptionText;
    private static readonly IntPtr NativeFieldInfoPtr_SelectedAbilityImage;
    private static readonly IntPtr NativeFieldInfoPtr_JewelInfo_Right;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_EquipJewel;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_UnequipJewel;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_InventoryFull;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Dash;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Travel;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Projectile;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TargetAoE;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Channeling;
    private static readonly IntPtr NativeFieldInfoPtr_EmptyJewelIcon_JewelOwned;
    private static readonly IntPtr NativeFieldInfoPtr_EmptyJewelIcon_NoJewelOwned;
    private static readonly IntPtr NativeFieldInfoPtr_FakeAbilityBarEntries;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1262066, RefRangeEnd = 1262068, XrefRangeStart = 1262066, XrefRangeEnd = 1262068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellbookMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellbookMenu()
    {
      Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpellbookMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr);
      SpellbookMenu.NativeFieldInfoPtr_Schools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (Schools));
      SpellbookMenu.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (BackgroundImage));
      SpellbookMenu.NativeFieldInfoPtr_SchoolNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (SchoolNameText));
      SpellbookMenu.NativeFieldInfoPtr_SchoolDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (SchoolDescriptionText));
      SpellbookMenu.NativeFieldInfoPtr_BuffEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (BuffEntries));
      SpellbookMenu.NativeFieldInfoPtr_SchoolAbilityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (SchoolAbilityView));
      SpellbookMenu.NativeFieldInfoPtr_BasicVBloodAbilityEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (BasicVBloodAbilityEntryPrefab));
      SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (TravelVBloodAbilityEntryPrefab));
      SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (UltimateVBloodAbilityEntryPrefab));
      SpellbookMenu.NativeFieldInfoPtr_UnknownVBloodAbilityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (UnknownVBloodAbilityIcon));
      SpellbookMenu.NativeFieldInfoPtr_UpperBasicVBloodAbilityParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (UpperBasicVBloodAbilityParent));
      SpellbookMenu.NativeFieldInfoPtr_UpperBasicVBloodAbilityEntryGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (UpperBasicVBloodAbilityEntryGroup));
      SpellbookMenu.NativeFieldInfoPtr_LowerBasicVBloodAbilityParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LowerBasicVBloodAbilityParent));
      SpellbookMenu.NativeFieldInfoPtr_LowerBasicVBloodAbilityEntryGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LowerBasicVBloodAbilityEntryGroup));
      SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (TravelVBloodAbilityParent));
      SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityEntryGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (TravelVBloodAbilityEntryGroup));
      SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (UltimateVBloodAbilityParent));
      SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityEntryGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (UltimateVBloodAbilityEntryGroup));
      SpellbookMenu.NativeFieldInfoPtr_JewelView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (JewelView));
      SpellbookMenu.NativeFieldInfoPtr_JewelEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (JewelEntryPrefab));
      SpellbookMenu.NativeFieldInfoPtr_JewelGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (JewelGroup));
      SpellbookMenu.NativeFieldInfoPtr_EquipJewelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (EquipJewelButton));
      SpellbookMenu.NativeFieldInfoPtr_EquipJewelButton_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (EquipJewelButton_Text));
      SpellbookMenu.NativeFieldInfoPtr_JewelBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (JewelBackButton));
      SpellbookMenu.NativeFieldInfoPtr_JewelInfo_Middle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (JewelInfo_Middle));
      SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityInfoParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (SelectedAbilityInfoParent));
      SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (SelectedAbilityNameText));
      SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (SelectedAbilityTypeText));
      SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (SelectedAbilityDescriptionText));
      SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (SelectedAbilityImage));
      SpellbookMenu.NativeFieldInfoPtr_JewelInfo_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (JewelInfo_Right));
      SpellbookMenu.NativeFieldInfoPtr_LKey_EquipJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LKey_EquipJewel));
      SpellbookMenu.NativeFieldInfoPtr_LKey_UnequipJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LKey_UnequipJewel));
      SpellbookMenu.NativeFieldInfoPtr_LKey_InventoryFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LKey_InventoryFull));
      SpellbookMenu.NativeFieldInfoPtr_LKey_Dash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LKey_Dash));
      SpellbookMenu.NativeFieldInfoPtr_LKey_Travel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LKey_Travel));
      SpellbookMenu.NativeFieldInfoPtr_LKey_Projectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LKey_Projectile));
      SpellbookMenu.NativeFieldInfoPtr_LKey_TargetAoE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LKey_TargetAoE));
      SpellbookMenu.NativeFieldInfoPtr_LKey_Channeling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (LKey_Channeling));
      SpellbookMenu.NativeFieldInfoPtr_EmptyJewelIcon_JewelOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (EmptyJewelIcon_JewelOwned));
      SpellbookMenu.NativeFieldInfoPtr_EmptyJewelIcon_NoJewelOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (EmptyJewelIcon_NoJewelOwned));
      SpellbookMenu.NativeFieldInfoPtr_FakeAbilityBarEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, nameof (FakeAbilityBarEntries));
      SpellbookMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu>.NativeClassPtr, 100667388);
    }

    public SpellbookMenu(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<WeakAssetReference<SpellSchoolAsset>> Schools
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_Schools));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<SpellSchoolAsset>>) null : new Il2CppReferenceArray<WeakAssetReference<SpellSchoolAsset>>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_Schools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ImageFadeSwap BackgroundImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_BackgroundImage));
        return pointer == IntPtr.Zero ? (ImageFadeSwap) null : new ImageFadeSwap(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SchoolNameText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SchoolNameText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SchoolNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SchoolDescriptionText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SchoolDescriptionText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SchoolDescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellBookMenu_BuffEntry> BuffEntries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_BuffEntries));
        return pointer == IntPtr.Zero ? (List<SpellBookMenu_BuffEntry>) null : new List<SpellBookMenu_BuffEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_BuffEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SchoolAbilityView
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SchoolAbilityView));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SchoolAbilityView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenu_AbilityEntry BasicVBloodAbilityEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_BasicVBloodAbilityEntryPrefab));
        return pointer == IntPtr.Zero ? (SpellbookMenu_AbilityEntry) null : new SpellbookMenu_AbilityEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_BasicVBloodAbilityEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenu_AbilityEntry TravelVBloodAbilityEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityEntryPrefab));
        return pointer == IntPtr.Zero ? (SpellbookMenu_AbilityEntry) null : new SpellbookMenu_AbilityEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenu_AbilityEntry UltimateVBloodAbilityEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityEntryPrefab));
        return pointer == IntPtr.Zero ? (SpellbookMenu_AbilityEntry) null : new SpellbookMenu_AbilityEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite UnknownVBloodAbilityIcon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UnknownVBloodAbilityIcon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UnknownVBloodAbilityIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UpperBasicVBloodAbilityParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UpperBasicVBloodAbilityParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UpperBasicVBloodAbilityParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data> UpperBasicVBloodAbilityEntryGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UpperBasicVBloodAbilityEntryGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>) null : new GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UpperBasicVBloodAbilityEntryGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup LowerBasicVBloodAbilityParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LowerBasicVBloodAbilityParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LowerBasicVBloodAbilityParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data> LowerBasicVBloodAbilityEntryGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LowerBasicVBloodAbilityEntryGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>) null : new GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LowerBasicVBloodAbilityEntryGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup TravelVBloodAbilityParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data> TravelVBloodAbilityEntryGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityEntryGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>) null : new GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_TravelVBloodAbilityEntryGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UltimateVBloodAbilityParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data> UltimateVBloodAbilityEntryGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityEntryGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>) null : new GridSelectionGroup<SpellbookMenu_AbilityEntry, SpellbookMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_UltimateVBloodAbilityEntryGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform JewelView
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelView));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenu_JewelEntry JewelEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelEntryPrefab));
        return pointer == IntPtr.Zero ? (SpellbookMenu_JewelEntry) null : new SpellbookMenu_JewelEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GenericSelectionGroup<SpellbookMenu_JewelEntry, SpellbookMenu_JewelEntry.Data> JewelGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelGroup));
        return pointer == IntPtr.Zero ? (GenericSelectionGroup<SpellbookMenu_JewelEntry, SpellbookMenu_JewelEntry.Data>) null : new GenericSelectionGroup<SpellbookMenu_JewelEntry, SpellbookMenu_JewelEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton EquipJewelButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_EquipJewelButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_EquipJewelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText EquipJewelButton_Text
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_EquipJewelButton_Text));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_EquipJewelButton_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton JewelBackButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelBackButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelBackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenu_JewelInfo JewelInfo_Middle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelInfo_Middle));
        return pointer == IntPtr.Zero ? (SpellbookMenu_JewelInfo) null : new SpellbookMenu_JewelInfo(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelInfo_Middle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SelectedAbilityInfoParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityInfoParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityInfoParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedAbilityNameText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityNameText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedAbilityTypeText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityTypeText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityTypeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedAbilityDescriptionText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityDescriptionText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityDescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image SelectedAbilityImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_SelectedAbilityImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenu_JewelInfo JewelInfo_Right
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelInfo_Right));
        return pointer == IntPtr.Zero ? (SpellbookMenu_JewelInfo) null : new SpellbookMenu_JewelInfo(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_JewelInfo_Right), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_EquipJewel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_EquipJewel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_EquipJewel)) = value;
      }
    }

    public unsafe LocalizationKey LKey_UnequipJewel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_UnequipJewel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_UnequipJewel)) = value;
      }
    }

    public unsafe LocalizationKey LKey_InventoryFull
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_InventoryFull));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_InventoryFull)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Dash
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_Dash));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_Dash)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Travel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_Travel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_Travel)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Projectile
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_Projectile));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_Projectile)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TargetAoE
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_TargetAoE));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_TargetAoE)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Channeling
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_Channeling));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_LKey_Channeling)) = value;
      }
    }

    public unsafe Sprite EmptyJewelIcon_JewelOwned
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_EmptyJewelIcon_JewelOwned));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_EmptyJewelIcon_JewelOwned), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite EmptyJewelIcon_NoJewelOwned
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_EmptyJewelIcon_NoJewelOwned));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_EmptyJewelIcon_NoJewelOwned), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SpellbookMenu_AbilityEntry> FakeAbilityBarEntries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_FakeAbilityBarEntries));
        return pointer == IntPtr.Zero ? (List<SpellbookMenu_AbilityEntry>) null : new List<SpellbookMenu_AbilityEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu.NativeFieldInfoPtr_FakeAbilityBarEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
