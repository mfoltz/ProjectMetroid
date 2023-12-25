// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BloodAltarSubMenu
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
  public class BloodAltarSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_HuntGridSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_HuntParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_HuntPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_MenuHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_Desc;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockPowersSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockRecipesSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockBlueprintsSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_RewardsRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockPowersParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockPowersRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockRecipesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockRecipesRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockBlueprintsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockBlueprintsRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Spite_Passive;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Header_BloodAltar;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Header_VBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Sharable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Tracked;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Claimable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Unlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_UnknownHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_UnknownDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ItemText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_HiddenHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_HiddenDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedHunt;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnknownAbilityIcon;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SelectedHunt_Internal_Void_BloodAltarHuntEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSelected_Internal_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSelectedHunt_Internal_Boolean_byref_BloodAltarHuntEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonText_Internal_LocalizationKey_HuntStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySetGameDataReference_Internal_Void_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_BloodAltarHuntEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Private_Void_ResearchEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Private_Void_ResearchEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Private_Void_ResearchEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222390, XrefRangeEnd = 1222467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1222469, RefRangeEnd = 1222470, XrefRangeStart = 1222467, XrefRangeEnd = 1222469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222470, XrefRangeEnd = 1222471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SelectedHunt(BloodAltarHuntEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr_SelectedHunt_Internal_Void_BloodAltarHuntEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1222476, RefRangeEnd = 1222478, XrefRangeStart = 1222471, XrefRangeEnd = 1222476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSelected(PrefabGUID bloodHuntTarget)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &bloodHuntTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr_IsSelected_Internal_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1222483, RefRangeEnd = 1222486, XrefRangeStart = 1222478, XrefRangeEnd = 1222483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasSelectedHunt(out BloodAltarHuntEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr_HasSelectedHunt_Internal_Boolean_byref_BloodAltarHuntEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref BloodAltarHuntEntry local = ref entry;
      System.IntPtr pointer = zero;
      BloodAltarHuntEntry bloodAltarHuntEntry = pointer == System.IntPtr.Zero ? (BloodAltarHuntEntry) null : new BloodAltarHuntEntry(pointer);
      local = bloodAltarHuntEntry;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe LocalizationKey GetButtonText(HuntStatus huntStatus)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &huntStatus;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr_GetButtonText_Internal_LocalizationKey_HuntStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222486, XrefRangeEnd = 1222487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrySetGameDataReference(GameDataSystem gameDataSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr_TrySetGameDataReference_Internal_Void_GameDataSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodAltarSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222487, XrefRangeEnd = 1222488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_0(
      BloodAltarHuntEntry entry,
      BloodAltarHuntEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_BloodAltarHuntEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222488, XrefRangeEnd = 1222490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_1(
      ResearchEntry entry,
      ResearchEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Private_Void_ResearchEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222490, XrefRangeEnd = 1222492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_2(
      ResearchEntry entry,
      ResearchEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Private_Void_ResearchEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222492, XrefRangeEnd = 1222494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_3(
      ResearchEntry entry,
      ResearchEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Private_Void_ResearchEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodAltarSubMenu()
    {
      Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BloodAltarSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr);
      BloodAltarSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      BloodAltarSubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      BloodAltarSubMenu.NativeFieldInfoPtr_HuntGridSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (HuntGridSelectionGroup));
      BloodAltarSubMenu.NativeFieldInfoPtr_HuntParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (HuntParent));
      BloodAltarSubMenu.NativeFieldInfoPtr_HuntPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (HuntPrefab));
      BloodAltarSubMenu.NativeFieldInfoPtr_MenuHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (MenuHeader));
      BloodAltarSubMenu.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (Header));
      BloodAltarSubMenu.NativeFieldInfoPtr_Desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (Desc));
      BloodAltarSubMenu.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (Icon));
      BloodAltarSubMenu.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (Button));
      BloodAltarSubMenu.NativeFieldInfoPtr_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (ButtonText));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockPowersSelectionGroup));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockRecipesSelectionGroup));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockBlueprintsSelectionGroup));
      BloodAltarSubMenu.NativeFieldInfoPtr_RewardsRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (RewardsRoot));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockPowersParent));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockPowersRoot));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockRecipesParent));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockRecipesRoot));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockBlueprintsParent));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockBlueprintsRoot));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnlockPrefab));
      BloodAltarSubMenu.NativeFieldInfoPtr_Spite_Passive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (Spite_Passive));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Header_BloodAltar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_Header_BloodAltar));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Header_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_Header_VBlood));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_Normal));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Sharable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_Sharable));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_Tracked));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Claimable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_Claimable));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_Unlocked));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_UnknownHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_UnknownHeader));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_UnknownDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_UnknownDesc));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_ItemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_ItemText));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_HiddenHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_HiddenHeader));
      BloodAltarSubMenu.NativeFieldInfoPtr_LKey_HiddenDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (LKey_HiddenDesc));
      BloodAltarSubMenu.NativeFieldInfoPtr__SelectedHunt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (_SelectedHunt));
      BloodAltarSubMenu.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (_GameDataSystem));
      BloodAltarSubMenu.NativeFieldInfoPtr_UnknownAbilityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, nameof (UnknownAbilityIcon));
      BloodAltarSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664752);
      BloodAltarSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664753);
      BloodAltarSubMenu.NativeMethodInfoPtr_SelectedHunt_Internal_Void_BloodAltarHuntEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664754);
      BloodAltarSubMenu.NativeMethodInfoPtr_IsSelected_Internal_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664755);
      BloodAltarSubMenu.NativeMethodInfoPtr_HasSelectedHunt_Internal_Boolean_byref_BloodAltarHuntEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664756);
      BloodAltarSubMenu.NativeMethodInfoPtr_GetButtonText_Internal_LocalizationKey_HuntStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664757);
      BloodAltarSubMenu.NativeMethodInfoPtr_TrySetGameDataReference_Internal_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664758);
      BloodAltarSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664759);
      BloodAltarSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_0_Private_Void_BloodAltarHuntEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664760);
      BloodAltarSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_1_Private_Void_ResearchEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664761);
      BloodAltarSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_2_Private_Void_ResearchEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664762);
      BloodAltarSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_3_Private_Void_ResearchEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, 100664763);
    }

    public BloodAltarSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<BloodAltarHuntEntry, BloodAltarHuntEntry.Data> HuntGridSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_HuntGridSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<BloodAltarHuntEntry, BloodAltarHuntEntry.Data>) null : new GridSelectionGroup<BloodAltarHuntEntry, BloodAltarHuntEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_HuntGridSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup HuntParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_HuntParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_HuntParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BloodAltarHuntEntry HuntPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_HuntPrefab));
        return pointer == System.IntPtr.Zero ? (BloodAltarHuntEntry) null : new BloodAltarHuntEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_HuntPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText MenuHeader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_MenuHeader));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_MenuHeader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Header
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Header));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Header), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Desc
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Desc));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Desc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_ButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_ButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ResearchEntry, ResearchEntry.Data> UnlockPowersSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ResearchEntry, ResearchEntry.Data>) null : new GridSelectionGroup<ResearchEntry, ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ResearchEntry, ResearchEntry.Data> UnlockRecipesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ResearchEntry, ResearchEntry.Data>) null : new GridSelectionGroup<ResearchEntry, ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ResearchEntry, ResearchEntry.Data> UnlockBlueprintsSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ResearchEntry, ResearchEntry.Data>) null : new GridSelectionGroup<ResearchEntry, ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RewardsRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_RewardsRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_RewardsRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UnlockPowersParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnlockPowersRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPowersRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UnlockRecipesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnlockRecipesRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockRecipesRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UnlockBlueprintsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnlockBlueprintsRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockBlueprintsRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ResearchEntry UnlockPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPrefab));
        return pointer == System.IntPtr.Zero ? (ResearchEntry) null : new ResearchEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnlockPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Spite_Passive
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Spite_Passive));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_Spite_Passive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Header_BloodAltar
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Header_BloodAltar));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Header_BloodAltar)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Header_VBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Header_VBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Header_VBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Normal
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Normal));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Normal)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Sharable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Sharable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Sharable)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Tracked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Tracked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Tracked)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Claimable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Claimable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Claimable)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Unlocked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Unlocked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_Unlocked)) = value;
      }
    }

    public unsafe LocalizationKey LKey_UnknownHeader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_UnknownHeader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_UnknownHeader)) = value;
      }
    }

    public unsafe LocalizationKey LKey_UnknownDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_UnknownDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_UnknownDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ItemText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_ItemText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_ItemText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_HiddenHeader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_HiddenHeader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_HiddenHeader)) = value;
      }
    }

    public unsafe LocalizationKey LKey_HiddenDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_HiddenDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_LKey_HiddenDesc)) = value;
      }
    }

    public unsafe BloodAltarHuntEntry _SelectedHunt
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr__SelectedHunt));
        return pointer == System.IntPtr.Zero ? (BloodAltarHuntEntry) null : new BloodAltarHuntEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr__SelectedHunt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite UnknownAbilityIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnknownAbilityIcon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenu.NativeFieldInfoPtr_UnknownAbilityIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.BloodAltarSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__38_4;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_4_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222389, XrefRangeEnd = 1222390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__38_4(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_4_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<BloodAltarSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSubMenu.__c>.NativeClassPtr);
        BloodAltarSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu.__c>.NativeClassPtr, "<>9");
        BloodAltarSubMenu.__c.NativeFieldInfoPtr___9__38_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenu.__c>.NativeClassPtr, "<>9__38_4");
        BloodAltarSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu.__c>.NativeClassPtr, 100664765);
        BloodAltarSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__38_4_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenu.__c>.NativeClassPtr, 100664766);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe BloodAltarSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BloodAltarSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (BloodAltarSubMenu.__c) null : new BloodAltarSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BloodAltarSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__38_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BloodAltarSubMenu.__c.NativeFieldInfoPtr___9__38_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BloodAltarSubMenu.__c.NativeFieldInfoPtr___9__38_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
