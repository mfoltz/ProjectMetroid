// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MountSubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class MountSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedableContainer;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaddleBearerContainer;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Inventory;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputBlocker;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventorySelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContainerParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedInventorySelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedContainerParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenTagEditButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagEditPopupNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseTagEditButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveTagButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagEditInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagStatus;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagRandomButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventoryContextEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomHorseNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSaddleIcon;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitStandardWorkstationSettings_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Func_1_Entity_Func_1_Entity_Func_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInventoryInput_Public_Void_Entity_GridSelectionGroup_2_ItemGridSelectionEntry_Data_InputState_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnDisabled_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyButtonHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_0_Private_Void_ItemGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_1_Private_Void_ItemGridSelectionEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241765, XrefRangeEnd = 1241819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241819, XrefRangeEnd = 1241821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MountSubMenu.MenuSettings GetDefaultSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new MountSubMenu.MenuSettings(pointer);
    }

    public unsafe MountSubMenu.MenuSettings Settings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new MountSubMenu.MenuSettings(pointer);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitStandardWorkstationSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_InitStandardWorkstationSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1241830, RefRangeEnd = 1241831, XrefRangeStart = 1241821, XrefRangeEnd = 1241830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSettings(
      Nullable_Unboxed<InputFlag> transferItemFlag = default (Nullable_Unboxed<InputFlag>),
      Nullable_Unboxed<InputFlag> splitItemFlag = default (Nullable_Unboxed<InputFlag>),
      Il2CppSystem.Func<Entity> getLocalInventory = null,
      Il2CppSystem.Func<Entity> getRemoteInventory = null,
      Il2CppSystem.Func<Entity> getFeedInventory = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &transferItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &splitItemFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getLocalInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getRemoteInventory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getFeedInventory);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Func_1_Entity_Func_1_Entity_Func_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1241884, RefRangeEnd = 1241885, XrefRangeStart = 1241831, XrefRangeEnd = 1241884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1241897, RefRangeEnd = 1241898, XrefRangeStart = 1241885, XrefRangeEnd = 1241897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleInput(EntityManager entityManager, InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1241912, RefRangeEnd = 1241914, XrefRangeStart = 1241898, XrefRangeEnd = 1241912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleInventoryInput(
      Entity inventory,
      GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> selectionGroup,
      InputState inputState,
      EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectionGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_HandleInventoryInput_Public_Void_Entity_GridSelectionGroup_2_ItemGridSelectionEntry_Data_InputState_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241914, XrefRangeEnd = 1241915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void _OnDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MountSubMenu.NativeMethodInfoPtr__OnDisabled_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241915, XrefRangeEnd = 1241922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_IsHovered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241922, XrefRangeEnd = 1241925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAnySlotHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAnyButtonHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr_IsAnyButtonHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241925, XrefRangeEnd = 1241933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MountSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241933, XrefRangeEnd = 1241935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__20_0(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_0_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__20_1(
      ItemGridSelectionEntry entry,
      ItemGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_1_Private_Void_ItemGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MountSubMenu()
    {
      Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MountSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr);
      MountSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      MountSubMenu.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (HeaderText));
      MountSubMenu.NativeFieldInfoPtr_FeedableContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (FeedableContainer));
      MountSubMenu.NativeFieldInfoPtr_SaddleBearerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (SaddleBearerContainer));
      MountSubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (TooltipAnchor_Inventory));
      MountSubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      MountSubMenu.NativeFieldInfoPtr_InputBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (InputBlocker));
      MountSubMenu.NativeFieldInfoPtr_InventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (InventorySelectionGroup));
      MountSubMenu.NativeFieldInfoPtr_ContainerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (ContainerParent));
      MountSubMenu.NativeFieldInfoPtr_FeedInventorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (FeedInventorySelectionGroup));
      MountSubMenu.NativeFieldInfoPtr_FeedContainerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (FeedContainerParent));
      MountSubMenu.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (ItemEntryPrefab));
      MountSubMenu.NativeFieldInfoPtr_OpenTagEditButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (OpenTagEditButton));
      MountSubMenu.NativeFieldInfoPtr_TagEditPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (TagEditPopupNode));
      MountSubMenu.NativeFieldInfoPtr_CloseTagEditButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (CloseTagEditButton));
      MountSubMenu.NativeFieldInfoPtr_SaveTagButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (SaveTagButton));
      MountSubMenu.NativeFieldInfoPtr_TagEditInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (TagEditInputField));
      MountSubMenu.NativeFieldInfoPtr_TagStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (TagStatus));
      MountSubMenu.NativeFieldInfoPtr_TagRandomButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (TagRandomButton));
      MountSubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (_InventoryContextEntriesCache));
      MountSubMenu.NativeFieldInfoPtr__Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (_Settings));
      MountSubMenu.NativeFieldInfoPtr_RandomHorseNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (RandomHorseNames));
      MountSubMenu.NativeFieldInfoPtr_RandomLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (RandomLocalizationKeys));
      MountSubMenu.NativeFieldInfoPtr_DefaultSaddleIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (DefaultSaddleIcon));
      MountSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666102);
      MountSubMenu.NativeMethodInfoPtr_GetDefaultSettings_Private_MenuSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666103);
      MountSubMenu.NativeMethodInfoPtr_get_Settings_Public_get_MenuSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666104);
      MountSubMenu.NativeMethodInfoPtr_InitStandardWorkstationSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666105);
      MountSubMenu.NativeMethodInfoPtr_InitSettings_Public_Void_Nullable_Unboxed_1_InputFlag_Nullable_Unboxed_1_InputFlag_Func_1_Entity_Func_1_Entity_Func_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666106);
      MountSubMenu.NativeMethodInfoPtr_OnUpdateFromParent_Public_Void_EntityManager_Entity_Entity_GameDataSystem_PrefabCollectionSystem_InventoryLocalizationKeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666107);
      MountSubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_EntityManager_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666108);
      MountSubMenu.NativeMethodInfoPtr_HandleInventoryInput_Public_Void_Entity_GridSelectionGroup_2_ItemGridSelectionEntry_Data_InputState_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666109);
      MountSubMenu.NativeMethodInfoPtr__OnDisabled_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666110);
      MountSubMenu.NativeMethodInfoPtr_IsHovered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666111);
      MountSubMenu.NativeMethodInfoPtr_IsAnySlotHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666112);
      MountSubMenu.NativeMethodInfoPtr_IsAnyButtonHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666113);
      MountSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666114);
      MountSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_0_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666115);
      MountSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_1_Private_Void_ItemGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, 100666116);
    }

    public MountSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MountFeedableContainer FeedableContainer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_FeedableContainer));
        return pointer == System.IntPtr.Zero ? (MountFeedableContainer) null : new MountFeedableContainer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_FeedableContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MountSaddleBearerContainer SaddleBearerContainer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_SaddleBearerContainer));
        return pointer == System.IntPtr.Zero ? (MountSaddleBearerContainer) null : new MountSaddleBearerContainer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_SaddleBearerContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor_Inventory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TooltipAnchor_Inventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlockerArea InputBlocker
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_InputBlocker));
        return pointer == System.IntPtr.Zero ? (BlockerArea) null : new BlockerArea(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_InputBlocker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> InventorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_InventorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_InventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup ContainerParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_ContainerParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_ContainerParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> FeedInventorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_FeedInventorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>) null : new GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_FeedInventorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup FeedContainerParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_FeedContainerParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_FeedContainerParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ItemEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_ItemEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton OpenTagEditButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_OpenTagEditButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_OpenTagEditButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TagEditPopupNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TagEditPopupNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TagEditPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CloseTagEditButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_CloseTagEditButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_CloseTagEditButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SaveTagButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_SaveTagButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_SaveTagButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField TagEditInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TagEditInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TagEditInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText TagStatus
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TagStatus));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TagStatus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton TagRandomButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TagRandomButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_TagRandomButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InputContextEntry.Data> _InventoryContextEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr__InventoryContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public MountSubMenu.MenuSettings _Settings
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr__Settings);
        return new MountSubMenu.MenuSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr__Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe TextAsset RandomHorseNames
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_RandomHorseNames));
        return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_RandomHorseNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RandomLocalizationKeys RandomLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_RandomLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (RandomLocalizationKeys) null : new RandomLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_RandomLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite DefaultSaddleIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_DefaultSaddleIcon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.NativeFieldInfoPtr_DefaultSaddleIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class MenuSettings : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TransferItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_SplitItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_DropItemFlag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalInventoryEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRemoteInventoryEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetFeedInventoryEntity;

      static MenuSettings()
      {
        Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, nameof (MenuSettings));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr);
        MountSubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, nameof (TransferItemFlag));
        MountSubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, nameof (SplitItemFlag));
        MountSubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, nameof (DropItemFlag));
        MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, nameof (GetLocalInventoryEntity));
        MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, nameof (GetRemoteInventoryEntity));
        MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetFeedInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, nameof (GetFeedInventoryEntity));
      }

      public MenuSettings(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public MenuSettings()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MountSubMenu.MenuSettings>.NativeClassPtr, data));
      }

      public unsafe InputFlag TransferItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_TransferItemFlag)) = value;
        }
      }

      public unsafe InputFlag SplitItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_SplitItemFlag)) = value;
        }
      }

      public unsafe InputFlag DropItemFlag
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_DropItemFlag)) = value;
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetLocalInventoryEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetLocalInventoryEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetRemoteInventoryEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetRemoteInventoryEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<Entity> GetFeedInventoryEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetFeedInventoryEntity));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity>) null : new Il2CppSystem.Func<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSubMenu.MenuSettings.NativeFieldInfoPtr_GetFeedInventoryEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
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

    [ObfuscatedName("ProjectM.UI.MountSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__20_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_2_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MountSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__20_2(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MountSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_2_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<MountSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MountSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountSubMenu.__c>.NativeClassPtr);
        MountSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu.__c>.NativeClassPtr, "<>9");
        MountSubMenu.__c.NativeFieldInfoPtr___9__20_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSubMenu.__c>.NativeClassPtr, "<>9__20_2");
        MountSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu.__c>.NativeClassPtr, 100666118);
        MountSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__20_2_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSubMenu.__c>.NativeClassPtr, 100666119);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe MountSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MountSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (MountSubMenu.__c) null : new MountSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MountSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__20_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MountSubMenu.__c.NativeFieldInfoPtr___9__20_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MountSubMenu.__c.NativeFieldInfoPtr___9__20_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
