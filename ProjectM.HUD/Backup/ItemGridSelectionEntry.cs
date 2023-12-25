// Decompiled with JetBrains decompiler
// Type: ItemGridSelectionEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using ProjectM.Shared;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ItemGridSelectionEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_ActionKeyParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_ActionKeyText;
  private static readonly System.IntPtr NativeFieldInfoPtr_AmountText;
  private static readonly System.IntPtr NativeFieldInfoPtr_BrokenParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShatteredParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_IconBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_SelectedIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_HoverColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
  private static readonly System.IntPtr NativeFieldInfoPtr_SyncedEntity;
  private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxStacks;
  private static readonly System.IntPtr NativeFieldInfoPtr_BloodPotionParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_BloodPotionImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_BloodPotionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_IconBackgroundSprite_Default;
  private static readonly System.IntPtr NativeFieldInfoPtr_IconBackgroundSprite_Equipped;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ItemGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInventorySlotDatas_Internal_Static_Void_ComponentSystemBase_Entity_List_1_Data_ItemCategorySettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateBagsSlotDatas_Internal_Static_Void_EntityManager_BagHolder_GameDataSystem_ItemCategorySettings_Sprite_List_1_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSpawnedUnitsSlotDatas_Internal_Static_Void_EntityManager_Entity_GameDataSystem_List_1_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInventorySlotData_Internal_Static_Data_InventoryBuffer_ItemCategorySettings_PrefabGUID_ItemCategory_GameDataSystem_PrefabCollectionSystem_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSpawnedUnitSlotData_Internal_Static_Data_RecipeOutputBuffer_Entity_GameDataSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateBagInventorySlotDatas_Public_Static_Void_ComponentSystemBase_ItemCategorySettings_BagHolder_Int32_List_1_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 1208563, RefRangeEnd = 1208592, XrefRangeStart = 1208413, XrefRangeEnd = 1208563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    ItemGridSelectionEntry entry,
    ItemGridSelectionEntry.Data data,
    ControllerType controllerType,
    GridSelectionGroup<ItemGridSelectionEntry, ItemGridSelectionEntry.Data> parent,
    bool showActionBarKey)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &showActionBarKey;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ItemGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(16)]
  [CachedScanResults(RefRangeStart = 1208625, RefRangeEnd = 1208641, XrefRangeStart = 1208592, XrefRangeEnd = 1208625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateInventorySlotDatas(
    ComponentSystemBase systemBase,
    Entity inventoryOwner,
    List<ItemGridSelectionEntry.Data> output,
    ItemCategorySettings itemCategorySettings = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) output);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemGridSelectionEntry.NativeMethodInfoPtr_CreateInventorySlotDatas_Internal_Static_Void_ComponentSystemBase_Entity_List_1_Data_ItemCategorySettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208661, RefRangeEnd = 1208662, XrefRangeStart = 1208641, XrefRangeEnd = 1208661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateBagsSlotDatas(
    EntityManager entityManager,
    BagHolder bagHolder,
    GameDataSystem gameDataSystem,
    ItemCategorySettings itemCategorySettings,
    Sprite defaultIcon,
    List<ItemGridSelectionEntry.Data> output)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagHolder;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defaultIcon);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) output);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemGridSelectionEntry.NativeMethodInfoPtr_CreateBagsSlotDatas_Internal_Static_Void_EntityManager_BagHolder_GameDataSystem_ItemCategorySettings_Sprite_List_1_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208716, RefRangeEnd = 1208717, XrefRangeStart = 1208662, XrefRangeEnd = 1208716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateSpawnedUnitsSlotDatas(
    EntityManager entityManager,
    Entity station,
    GameDataSystem gameDataSystem,
    List<ItemGridSelectionEntry.Data> output)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &station;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) output);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemGridSelectionEntry.NativeMethodInfoPtr_CreateSpawnedUnitsSlotDatas_Internal_Static_Void_EntityManager_Entity_GameDataSystem_List_1_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208777, RefRangeEnd = 1208778, XrefRangeStart = 1208717, XrefRangeEnd = 1208777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ItemGridSelectionEntry.Data CreateInventorySlotData(
    InventoryBuffer inventoryEntry,
    ItemCategorySettings itemCategorySettings,
    PrefabGUID restrictedType,
    ItemCategory restrictedCategory,
    GameDataSystem gameDataSystem,
    PrefabCollectionSystem prefabCollectionSystem,
    Entity inventoryOwner)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &inventoryEntry;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictedType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictedCategory;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryOwner;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ItemGridSelectionEntry.NativeMethodInfoPtr_CreateInventorySlotData_Internal_Static_Data_InventoryBuffer_ItemCategorySettings_PrefabGUID_ItemCategory_GameDataSystem_PrefabCollectionSystem_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new ItemGridSelectionEntry.Data(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208786, RefRangeEnd = 1208787, XrefRangeStart = 1208778, XrefRangeEnd = 1208786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ItemGridSelectionEntry.Data CreateSpawnedUnitSlotData(
    RecipeOutputBuffer outputItem,
    Entity syncedEntity,
    GameDataSystem gameDataSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &outputItem;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &syncedEntity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ItemGridSelectionEntry.NativeMethodInfoPtr_CreateSpawnedUnitSlotData_Internal_Static_Data_RecipeOutputBuffer_Entity_GameDataSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new ItemGridSelectionEntry.Data(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208790, RefRangeEnd = 1208791, XrefRangeStart = 1208787, XrefRangeEnd = 1208790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateBagInventorySlotDatas(
    ComponentSystemBase systemBase,
    ItemCategorySettings itemCategorySettings,
    BagHolder bagHolder,
    int bagIndex,
    List<ItemGridSelectionEntry.Data> bagInventorySlotDatas)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bagHolder;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bagIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bagInventorySlotDatas);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemGridSelectionEntry.NativeMethodInfoPtr_CreateBagInventorySlotDatas_Public_Static_Void_ComponentSystemBase_ItemCategorySettings_BagHolder_Int32_List_1_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ItemGridSelectionEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ItemGridSelectionEntry()
  {
    Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ItemGridSelectionEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr);
    ItemGridSelectionEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (Name));
    ItemGridSelectionEntry.NativeFieldInfoPtr_ActionKeyParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (ActionKeyParent));
    ItemGridSelectionEntry.NativeFieldInfoPtr_ActionKeyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (ActionKeyText));
    ItemGridSelectionEntry.NativeFieldInfoPtr_AmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (AmountText));
    ItemGridSelectionEntry.NativeFieldInfoPtr_BrokenParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (BrokenParent));
    ItemGridSelectionEntry.NativeFieldInfoPtr_ShatteredParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (ShatteredParent));
    ItemGridSelectionEntry.NativeFieldInfoPtr_ItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (ItemIcon));
    ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (IconBackground));
    ItemGridSelectionEntry.NativeFieldInfoPtr_BackgroundSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (BackgroundSprite));
    ItemGridSelectionEntry.NativeFieldInfoPtr_SelectedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (SelectedIcon));
    ItemGridSelectionEntry.NativeFieldInfoPtr_UpgradeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (UpgradeIcon));
    ItemGridSelectionEntry.NativeFieldInfoPtr_HoverColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (HoverColor));
    ItemGridSelectionEntry.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (DefaultColor));
    ItemGridSelectionEntry.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (EntryId));
    ItemGridSelectionEntry.NativeFieldInfoPtr_SyncedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (SyncedEntity));
    ItemGridSelectionEntry.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (Amount));
    ItemGridSelectionEntry.NativeFieldInfoPtr_MaxStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (MaxStacks));
    ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (BloodPotionParent));
    ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (BloodPotionImage));
    ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (BloodPotionText));
    ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackgroundSprite_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (IconBackgroundSprite_Default));
    ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackgroundSprite_Equipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (IconBackgroundSprite_Equipped));
    ItemGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ItemGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ItemGridSelectionEntry_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, 100663536);
    ItemGridSelectionEntry.NativeMethodInfoPtr_CreateInventorySlotDatas_Internal_Static_Void_ComponentSystemBase_Entity_List_1_Data_ItemCategorySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, 100663537);
    ItemGridSelectionEntry.NativeMethodInfoPtr_CreateBagsSlotDatas_Internal_Static_Void_EntityManager_BagHolder_GameDataSystem_ItemCategorySettings_Sprite_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, 100663538);
    ItemGridSelectionEntry.NativeMethodInfoPtr_CreateSpawnedUnitsSlotDatas_Internal_Static_Void_EntityManager_Entity_GameDataSystem_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, 100663539);
    ItemGridSelectionEntry.NativeMethodInfoPtr_CreateInventorySlotData_Internal_Static_Data_InventoryBuffer_ItemCategorySettings_PrefabGUID_ItemCategory_GameDataSystem_PrefabCollectionSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, 100663540);
    ItemGridSelectionEntry.NativeMethodInfoPtr_CreateSpawnedUnitSlotData_Internal_Static_Data_RecipeOutputBuffer_Entity_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, 100663541);
    ItemGridSelectionEntry.NativeMethodInfoPtr_CreateBagInventorySlotDatas_Public_Static_Void_ComponentSystemBase_ItemCategorySettings_BagHolder_Int32_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, 100663542);
    ItemGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, 100663543);
  }

  public ItemGridSelectionEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText Name
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_Name));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject ActionKeyParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_ActionKeyParent));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_ActionKeyParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextMeshProUGUI ActionKeyText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_ActionKeyText));
      return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_ActionKeyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextMeshProUGUI AmountText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_AmountText));
      return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_AmountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject BrokenParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BrokenParent));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BrokenParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject ShatteredParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_ShatteredParent));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_ShatteredParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ItemIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_ItemIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_ItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image IconBackground
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackground));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image BackgroundSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BackgroundSprite));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BackgroundSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image SelectedIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_SelectedIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_SelectedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image UpgradeIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_UpgradeIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_UpgradeIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color32 HoverColor
  {
    get
    {
      return *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_HoverColor));
    }
    [param: In] set
    {
      *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_HoverColor)) = value;
    }
  }

  public unsafe Color32 DefaultColor
  {
    get
    {
      return *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_DefaultColor));
    }
    [param: In] set
    {
      *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_DefaultColor)) = value;
    }
  }

  public unsafe PrefabGUID EntryId
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_EntryId));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_EntryId)) = value;
    }
  }

  public unsafe Entity SyncedEntity
  {
    get
    {
      return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_SyncedEntity));
    }
    [param: In] set
    {
      *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_SyncedEntity)) = value;
    }
  }

  public unsafe int Amount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_Amount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_Amount)) = value;
    }
  }

  public unsafe int MaxStacks
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_MaxStacks));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_MaxStacks)) = value;
    }
  }

  public unsafe GameObject BloodPotionParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionParent));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image BloodPotionImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText BloodPotionText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_BloodPotionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite IconBackgroundSprite_Default
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackgroundSprite_Default));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackgroundSprite_Default), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite IconBackgroundSprite_Equipped
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackgroundSprite_Equipped));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.NativeFieldInfoPtr_IconBackgroundSprite_Equipped), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeStatus;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sorting;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsEmpty;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsBroken;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsShattered;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsEquipped;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowNumberIfOne;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysShowName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraItemInfo;

    static Data()
    {
      Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemGridSelectionEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr);
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (Name));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (EntryId));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_SyncedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (SyncedEntity));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ItemSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (ItemSprite));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_BackgroundSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (BackgroundSprite));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_UpgradeStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (UpgradeStatus));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (Stacks));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_MaxStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (MaxStacks));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Sorting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (Sorting));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (IsEmpty));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (IsDisabled));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsBroken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (IsBroken));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsShattered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (IsShattered));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (IsEquipped));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ShowNumberIfOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (ShowNumberIfOne));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_AlwaysShowName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (AlwaysShowName));
      ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ExtraItemInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, nameof (ExtraItemInfo));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemGridSelectionEntry.Data>.NativeClassPtr, data));
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe PrefabGUID EntryId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId)) = value;
      }
    }

    public unsafe Entity SyncedEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_SyncedEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_SyncedEntity)) = value;
      }
    }

    public unsafe Sprite ItemSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ItemSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ItemSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite BackgroundSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_BackgroundSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_BackgroundSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UpgradeStatus UpgradeStatus
    {
      get
      {
        return *(UpgradeStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_UpgradeStatus));
      }
      [param: In] set
      {
        *(UpgradeStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_UpgradeStatus)) = value;
      }
    }

    public unsafe int Stacks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Stacks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Stacks)) = value;
      }
    }

    public unsafe int MaxStacks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_MaxStacks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_MaxStacks)) = value;
      }
    }

    public unsafe int Sorting
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Sorting));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_Sorting)) = value;
      }
    }

    public unsafe bool IsEmpty
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsEmpty));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsEmpty)) = value;
      }
    }

    public unsafe bool IsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsDisabled)) = value;
      }
    }

    public unsafe bool IsBroken
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsBroken));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsBroken)) = value;
      }
    }

    public unsafe bool IsShattered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsShattered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsShattered)) = value;
      }
    }

    public unsafe bool IsEquipped
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsEquipped));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_IsEquipped)) = value;
      }
    }

    public unsafe bool ShowNumberIfOne
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ShowNumberIfOne));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ShowNumberIfOne)) = value;
      }
    }

    public unsafe bool AlwaysShowName
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_AlwaysShowName));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_AlwaysShowName)) = value;
      }
    }

    public Il2CppSystem.Nullable<ExtraItemInfo> ExtraItemInfo
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ExtraItemInfo);
        return new Il2CppSystem.Nullable<ExtraItemInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ExtraItemInfo>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemGridSelectionEntry.Data.NativeFieldInfoPtr_ExtraItemInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ExtraItemInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
