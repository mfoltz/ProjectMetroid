// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InventorySubMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class InventorySubMenuMapper : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SoundMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ShowBags;
    private static readonly System.IntPtr NativeFieldInfoPtr__ItemSlotDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__BagSlotDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__BagInventorySlotDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__ArmorSlotDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__GrimoireSlotDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__CloakSlotDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__HeadSlotDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__AttributeDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedRecipes;
    private static readonly System.IntPtr NativeFieldInfoPtr__RecipesDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedRecipeRequirements;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__HighlightHelper;
    private static readonly System.IntPtr NativeFieldInfoPtr__StandardDragDelegates;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEntryRightClick_Private_Static_Void_EntityManager_InventorySubMenu_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsJewel_Public_Static_Boolean_EntityManager_Entity_ItemGridSelectionEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowBagsInventories_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HideBagsInventories_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleBagsInventories_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBagsContainerButtonHovered_Public_Static_Boolean_List_1_BagsContainerSlot_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCount_Private_Int32_List_1_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPlayerInventory_Private_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPlayerMainInventory_Private_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPlayerBagInventory_Private_NetworkId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239097, XrefRangeEnd = 1239112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventorySubMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239112, XrefRangeEnd = 1239120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnEntryRightClick(
      EntityManager entityManager,
      InventorySubMenu inventorySubMenu,
      Entity localCharacterEntity,
      int itemIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventorySubMenu);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_OnEntryRightClick_Private_Static_Void_EntityManager_InventorySubMenu_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1239124, RefRangeEnd = 1239125, XrefRangeStart = 1239120, XrefRangeEnd = 1239124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsJewel(
      EntityManager entityManager,
      Entity localCharacterEntity,
      ItemGridSelectionEntry entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacterEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_IsJewel_Public_Static_Boolean_EntityManager_Entity_ItemGridSelectionEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void ShowBagsInventories()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_ShowBagsInventories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void HideBagsInventories()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_HideBagsInventories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void ToggleBagsInventories()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_ToggleBagsInventories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239125, XrefRangeEnd = 1239133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventorySubMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239133, XrefRangeEnd = 1239173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventorySubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239173, XrefRangeEnd = 1239176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventorySubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239176, XrefRangeEnd = 1239207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventorySubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1239223, RefRangeEnd = 1239224, XrefRangeStart = 1239207, XrefRangeEnd = 1239223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsBagsContainerButtonHovered(
      List<BagsContainerSlot> bagsContainerSlotEntries,
      int bagIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bagsContainerSlotEntries);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_IsBagsContainerButtonHovered_Public_Static_Boolean_List_1_BagsContainerSlot_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1239239, RefRangeEnd = 1239240, XrefRangeStart = 1239224, XrefRangeEnd = 1239239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetItemCount(List<ItemGridSelectionEntry.Data> itemSlotDatas)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemSlotDatas);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_GetItemCount_Private_Int32_List_1_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239240, XrefRangeEnd = 1239246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkId GetLocalPlayerInventory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_GetLocalPlayerInventory_Private_NetworkId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239246, XrefRangeEnd = 1239254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkId GetLocalPlayerMainInventory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_GetLocalPlayerMainInventory_Private_NetworkId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239254, XrefRangeEnd = 1239266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkId GetLocalPlayerBagInventory(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr_GetLocalPlayerBagInventory_Private_NetworkId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239266, XrefRangeEnd = 1239332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventorySubMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventorySubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventorySubMenuMapper()
    {
      Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InventorySubMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr);
      InventorySubMenuMapper.NativeFieldInfoPtr__SoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_SoundMapping));
      InventorySubMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_Query));
      InventorySubMenuMapper.NativeFieldInfoPtr__LocalPlayerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_LocalPlayerQuery));
      InventorySubMenuMapper.NativeFieldInfoPtr__ShowBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_ShowBags));
      InventorySubMenuMapper.NativeFieldInfoPtr__ItemSlotDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_ItemSlotDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__BagSlotDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_BagSlotDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__BagInventorySlotDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_BagInventorySlotDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__ArmorSlotDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_ArmorSlotDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__GrimoireSlotDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_GrimoireSlotDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__CloakSlotDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_CloakSlotDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__HeadSlotDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_HeadSlotDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__AttributeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_AttributeDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_UnlockedRecipes));
      InventorySubMenuMapper.NativeFieldInfoPtr__RecipesDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_RecipesDatas));
      InventorySubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_CachedRecipeRequirements));
      InventorySubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      InventorySubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      InventorySubMenuMapper.NativeFieldInfoPtr__HighlightHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_HighlightHelper));
      InventorySubMenuMapper.NativeFieldInfoPtr__StandardDragDelegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (_StandardDragDelegates));
      InventorySubMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665917);
      InventorySubMenuMapper.NativeMethodInfoPtr_OnEntryRightClick_Private_Static_Void_EntityManager_InventorySubMenu_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665918);
      InventorySubMenuMapper.NativeMethodInfoPtr_IsJewel_Public_Static_Boolean_EntityManager_Entity_ItemGridSelectionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665919);
      InventorySubMenuMapper.NativeMethodInfoPtr_ShowBagsInventories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665920);
      InventorySubMenuMapper.NativeMethodInfoPtr_HideBagsInventories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665921);
      InventorySubMenuMapper.NativeMethodInfoPtr_ToggleBagsInventories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665922);
      InventorySubMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665923);
      InventorySubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665924);
      InventorySubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665925);
      InventorySubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665926);
      InventorySubMenuMapper.NativeMethodInfoPtr_IsBagsContainerButtonHovered_Public_Static_Boolean_List_1_BagsContainerSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665927);
      InventorySubMenuMapper.NativeMethodInfoPtr_GetItemCount_Private_Int32_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665928);
      InventorySubMenuMapper.NativeMethodInfoPtr_GetLocalPlayerInventory_Private_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665929);
      InventorySubMenuMapper.NativeMethodInfoPtr_GetLocalPlayerMainInventory_Private_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665930);
      InventorySubMenuMapper.NativeMethodInfoPtr_GetLocalPlayerBagInventory_Private_NetworkId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665931);
      InventorySubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665932);
      InventorySubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, 100665933);
    }

    public InventorySubMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UISoundMapping _SoundMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__SoundMapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__SoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _LocalPlayerQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__LocalPlayerQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__LocalPlayerQuery)) = value;
      }
    }

    public unsafe bool _ShowBags
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__ShowBags));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__ShowBags)) = value;
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _ItemSlotDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__ItemSlotDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__ItemSlotDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _BagSlotDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__BagSlotDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__BagSlotDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _BagInventorySlotDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__BagInventorySlotDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__BagInventorySlotDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _ArmorSlotDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__ArmorSlotDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__ArmorSlotDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _GrimoireSlotDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__GrimoireSlotDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__GrimoireSlotDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _CloakSlotDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__CloakSlotDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__CloakSlotDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _HeadSlotDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__HeadSlotDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__HeadSlotDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<CharacterAttributeEntry.Data> _AttributeDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__AttributeDatas));
        return pointer == System.IntPtr.Zero ? (List<CharacterAttributeEntry.Data>) null : new List<CharacterAttributeEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__AttributeDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashSet<PrefabGUID> _UnlockedRecipes
    {
      get
      {
        return *(NativeHashSet<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<WorkstationRecipeGridSelectionEntry.Data> _RecipesDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__RecipesDatas));
        return pointer == System.IntPtr.Zero ? (List<WorkstationRecipeGridSelectionEntry.Data>) null : new List<WorkstationRecipeGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__RecipesDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, List<CostData>> _CachedRecipeRequirements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, List<CostData>>) null : new Dictionary<int, List<CostData>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIHighlightHelper _HighlightHelper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__HighlightHelper));
        return pointer == System.IntPtr.Zero ? (UIHighlightHelper) null : new UIHighlightHelper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__HighlightHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InventorySubMenuMapper.StandardDragDelegate> _StandardDragDelegates
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__StandardDragDelegates));
        return pointer == System.IntPtr.Zero ? (List<InventorySubMenuMapper.StandardDragDelegate>) null : new List<InventorySubMenuMapper.StandardDragDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.NativeFieldInfoPtr__StandardDragDelegates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InventoryTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      [FieldOffset(0)]
      public Entity Target;

      static InventoryTarget()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.InventoryTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (InventoryTarget));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.InventoryTarget>.NativeClassPtr);
        InventorySubMenuMapper.InventoryTarget.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.InventoryTarget>.NativeClassPtr, nameof (Target));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventorySubMenuMapper.InventoryTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class StandardDragDelegate : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InventorySubMenu;
      private static readonly System.IntPtr NativeFieldInfoPtr_Delegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Unregister_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1238470, RefRangeEnd = 1238471, XrefRangeStart = 1238464, XrefRangeEnd = 1238470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Register()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.StandardDragDelegate.NativeMethodInfoPtr_Register_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1238477, RefRangeEnd = 1238478, XrefRangeStart = 1238471, XrefRangeEnd = 1238477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Unregister()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.StandardDragDelegate.NativeMethodInfoPtr_Unregister_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StandardDragDelegate()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.StandardDragDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, nameof (StandardDragDelegate));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.StandardDragDelegate>.NativeClassPtr);
        InventorySubMenuMapper.StandardDragDelegate.NativeFieldInfoPtr_InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.StandardDragDelegate>.NativeClassPtr, nameof (InventorySubMenu));
        InventorySubMenuMapper.StandardDragDelegate.NativeFieldInfoPtr_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.StandardDragDelegate>.NativeClassPtr, nameof (Delegate));
        InventorySubMenuMapper.StandardDragDelegate.NativeMethodInfoPtr_Register_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.StandardDragDelegate>.NativeClassPtr, 100665934);
        InventorySubMenuMapper.StandardDragDelegate.NativeMethodInfoPtr_Unregister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.StandardDragDelegate>.NativeClassPtr, 100665935);
      }

      public StandardDragDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public StandardDragDelegate()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InventorySubMenuMapper.StandardDragDelegate>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventorySubMenuMapper.StandardDragDelegate>.NativeClassPtr, data));
      }

      public unsafe InventorySubMenu InventorySubMenu
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.StandardDragDelegate.NativeFieldInfoPtr_InventorySubMenu));
          return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.StandardDragDelegate.NativeFieldInfoPtr_InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action<int> Delegate
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.StandardDragDelegate.NativeFieldInfoPtr_Delegate));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.StandardDragDelegate.NativeFieldInfoPtr_Delegate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenuMapper/<>c__DisplayClass21_0")]
    public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__0_Internal_Void_Entity_InventorySubMenu_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__1_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__2_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass21_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238478, XrefRangeEnd = 1238634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnStartRunning_b__0(Entity menuEntity, InventorySubMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &menuEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_0.NativeMethodInfoPtr__OnStartRunning_b__0_Internal_Void_Entity_InventorySubMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238634, XrefRangeEnd = 1238638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnStartRunning_b__1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_0.NativeMethodInfoPtr__OnStartRunning_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238638, XrefRangeEnd = 1238642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnStartRunning_b__2()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_0.NativeMethodInfoPtr__OnStartRunning_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass21_0()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, "<>c__DisplayClass21_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr);
        InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
        InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr, "<>9__1");
        InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr, "<>9__2");
        InventorySubMenuMapper.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr, 100665936);
        InventorySubMenuMapper.__c__DisplayClass21_0.NativeMethodInfoPtr__OnStartRunning_b__0_Internal_Void_Entity_InventorySubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr, 100665937);
        InventorySubMenuMapper.__c__DisplayClass21_0.NativeMethodInfoPtr__OnStartRunning_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr, 100665938);
        InventorySubMenuMapper.__c__DisplayClass21_0.NativeMethodInfoPtr__OnStartRunning_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_0>.NativeClassPtr, 100665939);
      }

      public __c__DisplayClass21_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe InventorySubMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InventorySubMenuMapper) null : new InventorySubMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityAction __9__1
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1));
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityAction __9__2
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___9__2));
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenuMapper/<>c__DisplayClass21_1")]
    public sealed class __c__DisplayClass21_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_menu;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass21_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass21_1()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, "<>c__DisplayClass21_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_1>.NativeClassPtr);
        InventorySubMenuMapper.__c__DisplayClass21_1.NativeFieldInfoPtr_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_1>.NativeClassPtr, nameof (menu));
        InventorySubMenuMapper.__c__DisplayClass21_1.NativeFieldInfoPtr_field_Public___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_1>.NativeClassPtr, "CS$<>8__locals1");
        InventorySubMenuMapper.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_1>.NativeClassPtr, 100665940);
      }

      public __c__DisplayClass21_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe InventorySubMenu menu
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_1.NativeFieldInfoPtr_menu));
          return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_1.NativeFieldInfoPtr_menu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe InventorySubMenuMapper.__c__DisplayClass21_0 field_Public___c__DisplayClass21_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_1.NativeFieldInfoPtr_field_Public___c__DisplayClass21_0_0));
          return pointer == System.IntPtr.Zero ? (InventorySubMenuMapper.__c__DisplayClass21_0) null : new InventorySubMenuMapper.__c__DisplayClass21_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_1.NativeFieldInfoPtr_field_Public___c__DisplayClass21_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenuMapper/<>c__DisplayClass21_2")]
    public sealed class __c__DisplayClass21_2 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localCharacterEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__3_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass21_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238642, XrefRangeEnd = 1238649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnStartRunning_b__3(int itemIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &itemIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_2.NativeMethodInfoPtr__OnStartRunning_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass21_2()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, "<>c__DisplayClass21_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_2>.NativeClassPtr);
        InventorySubMenuMapper.__c__DisplayClass21_2.NativeFieldInfoPtr_localCharacterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_2>.NativeClassPtr, nameof (localCharacterEntity));
        InventorySubMenuMapper.__c__DisplayClass21_2.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_2>.NativeClassPtr, "CS$<>8__locals2");
        InventorySubMenuMapper.__c__DisplayClass21_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_2>.NativeClassPtr, 100665941);
        InventorySubMenuMapper.__c__DisplayClass21_2.NativeMethodInfoPtr__OnStartRunning_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_2>.NativeClassPtr, 100665942);
      }

      public __c__DisplayClass21_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Entity localCharacterEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_2.NativeFieldInfoPtr_localCharacterEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_2.NativeFieldInfoPtr_localCharacterEntity)) = value;
        }
      }

      public unsafe InventorySubMenuMapper.__c__DisplayClass21_1 field_Public___c__DisplayClass21_1_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_2.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0));
          return pointer == System.IntPtr.Zero ? (InventorySubMenuMapper.__c__DisplayClass21_1) null : new InventorySubMenuMapper.__c__DisplayClass21_1(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_2.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenuMapper/<>c__DisplayClass21_3")]
    public sealed class __c__DisplayClass21_3 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_local;
      private static readonly System.IntPtr NativeFieldInfoPtr_target;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__4_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass21_3()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238649, XrefRangeEnd = 1238652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnStartRunning_b__4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_3.NativeMethodInfoPtr__OnStartRunning_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass21_3()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, "<>c__DisplayClass21_3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_3>.NativeClassPtr);
        InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_3>.NativeClassPtr, nameof (local));
        InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_3>.NativeClassPtr, nameof (target));
        InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_3>.NativeClassPtr, "CS$<>8__locals3");
        InventorySubMenuMapper.__c__DisplayClass21_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_3>.NativeClassPtr, 100665943);
        InventorySubMenuMapper.__c__DisplayClass21_3.NativeMethodInfoPtr__OnStartRunning_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_3>.NativeClassPtr, 100665944);
      }

      public __c__DisplayClass21_3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Entity local
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_local));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_local)) = value;
        }
      }

      public unsafe Entity target
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_target));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_target)) = value;
        }
      }

      public unsafe InventorySubMenuMapper.__c__DisplayClass21_1 field_Public___c__DisplayClass21_1_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0));
          return pointer == System.IntPtr.Zero ? (InventorySubMenuMapper.__c__DisplayClass21_1) null : new InventorySubMenuMapper.__c__DisplayClass21_1(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_3.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenuMapper/<>c__DisplayClass21_4")]
    public sealed class __c__DisplayClass21_4 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__5_Internal_Void_SimpleStunButton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__6_Internal_Void_SimpleStunButton_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass21_4()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_4>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238652, XrefRangeEnd = 1238677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnStartRunning_b__5(SimpleStunButton bagSlotButton)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bagSlotButton);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_4.NativeMethodInfoPtr__OnStartRunning_b__5_Internal_Void_SimpleStunButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238677, XrefRangeEnd = 1238689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnStartRunning_b__6(SimpleStunButton bagSlotButton)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bagSlotButton);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass21_4.NativeMethodInfoPtr__OnStartRunning_b__6_Internal_Void_SimpleStunButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass21_4()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, "<>c__DisplayClass21_4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_4>.NativeClassPtr);
        InventorySubMenuMapper.__c__DisplayClass21_4.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_4>.NativeClassPtr, nameof (entry));
        InventorySubMenuMapper.__c__DisplayClass21_4.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_4>.NativeClassPtr, "CS$<>8__locals4");
        InventorySubMenuMapper.__c__DisplayClass21_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_4>.NativeClassPtr, 100665945);
        InventorySubMenuMapper.__c__DisplayClass21_4.NativeMethodInfoPtr__OnStartRunning_b__5_Internal_Void_SimpleStunButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_4>.NativeClassPtr, 100665946);
        InventorySubMenuMapper.__c__DisplayClass21_4.NativeMethodInfoPtr__OnStartRunning_b__6_Internal_Void_SimpleStunButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass21_4>.NativeClassPtr, 100665947);
      }

      public __c__DisplayClass21_4(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BagsContainerSlot entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_4.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (BagsContainerSlot) null : new BagsContainerSlot(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_4.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe InventorySubMenuMapper.__c__DisplayClass21_1 field_Public___c__DisplayClass21_1_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_4.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0));
          return pointer == System.IntPtr.Zero ? (InventorySubMenuMapper.__c__DisplayClass21_1) null : new InventorySubMenuMapper.__c__DisplayClass21_1(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass21_4.NativeFieldInfoPtr_field_Public___c__DisplayClass21_1_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenuMapper/<>c__DisplayClass30_0")]
    public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_getOutputItems;
      private static readonly System.IntPtr NativeFieldInfoPtr_localControlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_InventorySubMenu_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass30_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238689, XrefRangeEnd = 1238925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity menuEntity, InventorySubMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &menuEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass30_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_InventorySubMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass30_0()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, "<>c__DisplayClass30_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr);
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, nameof (gameDataSystem));
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, nameof (localUserEntity));
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_getOutputItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, nameof (getOutputItems));
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_localControlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, nameof (localControlledEntity));
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, nameof (prefabLookupMap));
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, 100665948);
        InventorySubMenuMapper.__c__DisplayClass30_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_InventorySubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_0>.NativeClassPtr, 100665949);
      }

      public __c__DisplayClass30_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe InventorySubMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InventorySubMenuMapper) null : new InventorySubMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe BufferFromEntity<RecipeOutputBuffer> getOutputItems
      {
        get
        {
          return *(BufferFromEntity<RecipeOutputBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_getOutputItems));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_getOutputItems), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<RecipeOutputBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Entity localControlledEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_localControlledEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_localControlledEntity)) = value;
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InventorySubMenuMapper/<>c__DisplayClass30_1")]
    public sealed class __c__DisplayClass30_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_menu;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Controller_byref_LocalUser_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Controller_byref_LocalUser_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Controller_byref_LocalUser_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Controller_byref_LocalUser_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Health_byref_UnitStats_byref_Equipment_byref_Movement_byref_ResistanceData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass30_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238925, XrefRangeEnd = 1238939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref Controller controller,
        ref LocalUser localUser)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Controller_byref_LocalUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238939, XrefRangeEnd = 1238948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        ref Controller controller,
        ref LocalUser localUser)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Controller_byref_LocalUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238948, XrefRangeEnd = 1238957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        ref Controller controller,
        ref LocalUser localUser)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Controller_byref_LocalUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238957, XrefRangeEnd = 1238966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        Entity entity,
        ref Controller controller,
        ref LocalUser localUser)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUser;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Controller_byref_LocalUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238966, XrefRangeEnd = 1239097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__5(
        Entity entity,
        ref Health health,
        ref UnitStats unitStats,
        ref Equipment equipment,
        ref Movement movement,
        ref ResistanceData resistanceData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref health;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitStats;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipment;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref resistanceData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Health_byref_UnitStats_byref_Equipment_byref_Movement_byref_ResistanceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass30_1()
      {
        Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventorySubMenuMapper>.NativeClassPtr, "<>c__DisplayClass30_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr);
        InventorySubMenuMapper.__c__DisplayClass30_1.NativeFieldInfoPtr_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr, nameof (menu));
        InventorySubMenuMapper.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr, "CS$<>8__locals1");
        InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr, 100665950);
        InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Controller_byref_LocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr, 100665951);
        InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Controller_byref_LocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr, 100665952);
        InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Controller_byref_LocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr, 100665953);
        InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Controller_byref_LocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr, 100665954);
        InventorySubMenuMapper.__c__DisplayClass30_1.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Health_byref_UnitStats_byref_Equipment_byref_Movement_byref_ResistanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySubMenuMapper.__c__DisplayClass30_1>.NativeClassPtr, 100665955);
      }

      public __c__DisplayClass30_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe InventorySubMenu menu
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_1.NativeFieldInfoPtr_menu));
          return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_1.NativeFieldInfoPtr_menu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe InventorySubMenuMapper.__c__DisplayClass30_0 field_Public___c__DisplayClass30_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0));
          return pointer == System.IntPtr.Zero ? (InventorySubMenuMapper.__c__DisplayClass30_0) null : new InventorySubMenuMapper.__c__DisplayClass30_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySubMenuMapper.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
