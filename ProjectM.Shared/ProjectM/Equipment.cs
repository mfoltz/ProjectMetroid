// Decompiled with JetBrains decompiler
// Type: ProjectM.Equipment
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Equipment
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponRunCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorHeadgearSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorHeadgearSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorChestSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorChestSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_GrimoireSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_GrimoireSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorFootgearSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorFootgearSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorLegsSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorLegsSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClothChestSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClothChestSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClothLegsSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClothLegsSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloakSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloakSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorGlovesSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorGlovesSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelDamageSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLevelDamageSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquippedItemDestroyedSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquippedItemBrokenSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnarmedBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnarmedBuffInstance;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetEquipped_Public_Void_EquipmentType_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_byref_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Boolean_PrefabGUID_byref_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Boolean_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipmentEntity_Public_NetworkedEntity_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidEquipmentType_Public_Static_Boolean_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipmentItemId_Public_PrefabGUID_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllEquipmentEntities_Public_Void_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEquipmentEntityIfNotNull_Private_Void_Entity_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAnyEquippedItem_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnequipItem_Public_Void_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFullLevel_Public_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertEquipmentLevel_Public_Static_Single_Single_GearType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasEquippedItemOfCategory_Public_Boolean_EntityManager_ItemCategory_0;
    [FieldOffset(0)]
    public ModifiableFloat WeaponLevel;
    [FieldOffset(8)]
    public ModifiableFloat ArmorLevel;
    [FieldOffset(16)]
    public ModifiableFloat SpellLevel;
    [FieldOffset(24)]
    public ModifiableInt WeaponRunCycle;
    [FieldOffset(32)]
    public NetworkedEntity ArmorHeadgearSlotEntity;
    [FieldOffset(44)]
    public PrefabGUID ArmorHeadgearSlotId;
    [FieldOffset(48)]
    public NetworkedEntity ArmorChestSlotEntity;
    [FieldOffset(60)]
    public PrefabGUID ArmorChestSlotId;
    [FieldOffset(64)]
    public NetworkedEntity WeaponSlotEntity;
    [FieldOffset(76)]
    public PrefabGUID WeaponSlotId;
    [FieldOffset(80)]
    public NetworkedEntity GrimoireSlotEntity;
    [FieldOffset(92)]
    public PrefabGUID GrimoireSlotId;
    [FieldOffset(96)]
    public NetworkedEntity ArmorFootgearSlotEntity;
    [FieldOffset(108)]
    public PrefabGUID ArmorFootgearSlotId;
    [FieldOffset(112)]
    public NetworkedEntity ArmorLegsSlotEntity;
    [FieldOffset(124)]
    public PrefabGUID ArmorLegsSlotId;
    [FieldOffset(128)]
    public NetworkedEntity ClothChestSlotEntity;
    [FieldOffset(140)]
    public PrefabGUID ClothChestSlotId;
    [FieldOffset(144)]
    public NetworkedEntity ClothLegsSlotEntity;
    [FieldOffset(156)]
    public PrefabGUID ClothLegsSlotId;
    [FieldOffset(160)]
    public NetworkedEntity CloakSlotEntity;
    [FieldOffset(172)]
    public PrefabGUID CloakSlotId;
    [FieldOffset(176)]
    public NetworkedEntity ArmorGlovesSlotEntity;
    [FieldOffset(188)]
    public PrefabGUID ArmorGlovesSlotId;
    [FieldOffset(192)]
    public Entity LevelDamageSettings;
    [FieldOffset(200)]
    public Entity PlayerLevelDamageSettings;
    [FieldOffset(208)]
    public SequenceGUID EquippedItemDestroyedSequenceGuid;
    [FieldOffset(212)]
    public SequenceGUID EquippedItemBrokenSequenceGuid;
    [FieldOffset(216)]
    public PrefabGUID UnarmedBuffPrefab;
    [FieldOffset(220)]
    public Entity UnarmedBuffInstance;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 724114, RefRangeEnd = 724119, XrefRangeStart = 724113, XrefRangeEnd = 724114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEquipped(Entity itemEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 724159, RefRangeEnd = 724162, XrefRangeStart = 724119, XrefRangeEnd = 724159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetEquipped(
      EquipmentType equipmentType,
      Entity itemEntity,
      PrefabGUID itemId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &equipmentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_SetEquipped_Public_Void_EquipmentType_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 724184, RefRangeEnd = 724188, XrefRangeStart = 724162, XrefRangeEnd = 724184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEquipped(Entity itemEntity, out EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_byref_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 724200, RefRangeEnd = 724204, XrefRangeStart = 724188, XrefRangeEnd = 724200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEquipped(PrefabGUID itemType, out EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_PrefabGUID_byref_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 724207, RefRangeEnd = 724212, XrefRangeStart = 724204, XrefRangeEnd = 724207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEquipped(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 724227, RefRangeEnd = 724249, XrefRangeStart = 724212, XrefRangeEnd = 724227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkedEntity GetEquipmentEntity(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_GetEquipmentEntity_Public_NetworkedEntity_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkedEntity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 724249, RefRangeEnd = 724253, XrefRangeStart = 724249, XrefRangeEnd = 724249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValidEquipmentType(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_IsValidEquipmentType_Public_Static_Boolean_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 724253, RefRangeEnd = 724261, XrefRangeStart = 724253, XrefRangeEnd = 724253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetEquipmentItemId(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_GetEquipmentItemId_Public_PrefabGUID_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 724321, RefRangeEnd = 724331, XrefRangeStart = 724261, XrefRangeEnd = 724321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetAllEquipmentEntities(NativeList<Entity> equipment)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipment;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_GetAllEquipmentEntities_Public_Void_NativeList_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724331, XrefRangeEnd = 724336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddEquipmentEntityIfNotNull(
      Entity equipmentEntity,
      NativeList<Entity> equipment)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &equipmentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &equipment;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_AddEquipmentEntityIfNotNull_Private_Void_Entity_NativeList_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 724366, RefRangeEnd = 724367, XrefRangeStart = 724336, XrefRangeEnd = 724366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasAnyEquippedItem()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_HasAnyEquippedItem_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 724373, RefRangeEnd = 724376, XrefRangeStart = 724367, XrefRangeEnd = 724373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnequipItem(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_UnequipItem_Public_Void_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724376, XrefRangeEnd = 724436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 724439, RefRangeEnd = 724455, XrefRangeStart = 724436, XrefRangeEnd = 724439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetFullLevel()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_GetFullLevel_Public_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 724455, RefRangeEnd = 724468, XrefRangeStart = 724455, XrefRangeEnd = 724455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float ConvertEquipmentLevel(float equipment, Equipment.GearType gearType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &equipment;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gearType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_ConvertEquipmentLevel_Public_Static_Single_Single_GearType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 724483, RefRangeEnd = 724484, XrefRangeStart = 724468, XrefRangeEnd = 724483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasEquippedItemOfCategory(
      EntityManager entityManager,
      ItemCategory itemCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Equipment.NativeMethodInfoPtr_HasEquippedItemOfCategory_Public_Boolean_EntityManager_ItemCategory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Equipment()
    {
      Il2CppClassPointerStore<Equipment>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Equipment));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equipment>.NativeClassPtr);
      Equipment.NativeFieldInfoPtr_WeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (WeaponLevel));
      Equipment.NativeFieldInfoPtr_ArmorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorLevel));
      Equipment.NativeFieldInfoPtr_SpellLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (SpellLevel));
      Equipment.NativeFieldInfoPtr_WeaponRunCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (WeaponRunCycle));
      Equipment.NativeFieldInfoPtr_ArmorHeadgearSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorHeadgearSlotEntity));
      Equipment.NativeFieldInfoPtr_ArmorHeadgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorHeadgearSlotId));
      Equipment.NativeFieldInfoPtr_ArmorChestSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorChestSlotEntity));
      Equipment.NativeFieldInfoPtr_ArmorChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorChestSlotId));
      Equipment.NativeFieldInfoPtr_WeaponSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (WeaponSlotEntity));
      Equipment.NativeFieldInfoPtr_WeaponSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (WeaponSlotId));
      Equipment.NativeFieldInfoPtr_GrimoireSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (GrimoireSlotEntity));
      Equipment.NativeFieldInfoPtr_GrimoireSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (GrimoireSlotId));
      Equipment.NativeFieldInfoPtr_ArmorFootgearSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorFootgearSlotEntity));
      Equipment.NativeFieldInfoPtr_ArmorFootgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorFootgearSlotId));
      Equipment.NativeFieldInfoPtr_ArmorLegsSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorLegsSlotEntity));
      Equipment.NativeFieldInfoPtr_ArmorLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorLegsSlotId));
      Equipment.NativeFieldInfoPtr_ClothChestSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ClothChestSlotEntity));
      Equipment.NativeFieldInfoPtr_ClothChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ClothChestSlotId));
      Equipment.NativeFieldInfoPtr_ClothLegsSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ClothLegsSlotEntity));
      Equipment.NativeFieldInfoPtr_ClothLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ClothLegsSlotId));
      Equipment.NativeFieldInfoPtr_CloakSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (CloakSlotEntity));
      Equipment.NativeFieldInfoPtr_CloakSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (CloakSlotId));
      Equipment.NativeFieldInfoPtr_ArmorGlovesSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorGlovesSlotEntity));
      Equipment.NativeFieldInfoPtr_ArmorGlovesSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (ArmorGlovesSlotId));
      Equipment.NativeFieldInfoPtr_LevelDamageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (LevelDamageSettings));
      Equipment.NativeFieldInfoPtr_PlayerLevelDamageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (PlayerLevelDamageSettings));
      Equipment.NativeFieldInfoPtr_EquippedItemDestroyedSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (EquippedItemDestroyedSequenceGuid));
      Equipment.NativeFieldInfoPtr_EquippedItemBrokenSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (EquippedItemBrokenSequenceGuid));
      Equipment.NativeFieldInfoPtr_UnarmedBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (UnarmedBuffPrefab));
      Equipment.NativeFieldInfoPtr_UnarmedBuffInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equipment>.NativeClassPtr, nameof (UnarmedBuffInstance));
      Equipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664055);
      Equipment.NativeMethodInfoPtr_SetEquipped_Public_Void_EquipmentType_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664056);
      Equipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_byref_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664057);
      Equipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_PrefabGUID_byref_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664058);
      Equipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664059);
      Equipment.NativeMethodInfoPtr_GetEquipmentEntity_Public_NetworkedEntity_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664060);
      Equipment.NativeMethodInfoPtr_IsValidEquipmentType_Public_Static_Boolean_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664061);
      Equipment.NativeMethodInfoPtr_GetEquipmentItemId_Public_PrefabGUID_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664062);
      Equipment.NativeMethodInfoPtr_GetAllEquipmentEntities_Public_Void_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664063);
      Equipment.NativeMethodInfoPtr_AddEquipmentEntityIfNotNull_Private_Void_Entity_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664064);
      Equipment.NativeMethodInfoPtr_HasAnyEquippedItem_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664065);
      Equipment.NativeMethodInfoPtr_UnequipItem_Public_Void_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664066);
      Equipment.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664067);
      Equipment.NativeMethodInfoPtr_GetFullLevel_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664068);
      Equipment.NativeMethodInfoPtr_ConvertEquipmentLevel_Public_Static_Single_Single_GearType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664069);
      Equipment.NativeMethodInfoPtr_HasEquippedItemOfCategory_Public_Boolean_EntityManager_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equipment>.NativeClassPtr, 100664070);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Equipment>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum GearType
    {
      Weapon,
      Armor,
      Spell,
    }
  }
}
