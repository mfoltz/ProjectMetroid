// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantEquipment
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
  public struct ServantEquipment
  {
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
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorGlovesSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorGlovesSlotId;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanEquip_Public_Static_Boolean_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetEquipped_Public_Void_EquipmentType_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_byref_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Boolean_PrefabGUID_byref_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Boolean_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipmentEntity_Public_NetworkedEntity_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipmentItemId_Public_PrefabGUID_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllEquipmentEntities_Public_Void_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEquipmentEntityIfNotNull_Private_Void_Entity_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnequipItem_Public_Void_EquipmentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertEquipmentLevel_Public_Static_Single_Single_GearType_0;
    [FieldOffset(0)]
    public NetworkedEntity ArmorChestSlotEntity;
    [FieldOffset(12)]
    public PrefabGUID ArmorChestSlotId;
    [FieldOffset(16)]
    public NetworkedEntity WeaponSlotEntity;
    [FieldOffset(28)]
    public PrefabGUID WeaponSlotId;
    [FieldOffset(32)]
    public NetworkedEntity GrimoireSlotEntity;
    [FieldOffset(44)]
    public PrefabGUID GrimoireSlotId;
    [FieldOffset(48)]
    public NetworkedEntity ArmorFootgearSlotEntity;
    [FieldOffset(60)]
    public PrefabGUID ArmorFootgearSlotId;
    [FieldOffset(64)]
    public NetworkedEntity ArmorLegsSlotEntity;
    [FieldOffset(76)]
    public PrefabGUID ArmorLegsSlotId;
    [FieldOffset(80)]
    public NetworkedEntity ArmorGlovesSlotEntity;
    [FieldOffset(92)]
    public PrefabGUID ArmorGlovesSlotId;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 727622, RefRangeEnd = 727625, XrefRangeStart = 727622, XrefRangeEnd = 727622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanEquip(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_CanEquip_Public_Static_Boolean_EquipmentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727626, RefRangeEnd = 727627, XrefRangeStart = 727625, XrefRangeEnd = 727626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEquipped(Entity itemEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 727651, RefRangeEnd = 727655, XrefRangeStart = 727627, XrefRangeEnd = 727651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_SetEquipped_Public_Void_EquipmentType_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 727669, RefRangeEnd = 727673, XrefRangeStart = 727655, XrefRangeEnd = 727669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEquipped(Entity itemEntity, out EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_byref_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727681, RefRangeEnd = 727682, XrefRangeStart = 727673, XrefRangeEnd = 727681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEquipped(PrefabGUID itemType, out EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_PrefabGUID_byref_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727685, RefRangeEnd = 727686, XrefRangeStart = 727682, XrefRangeEnd = 727685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEquipped(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 727697, RefRangeEnd = 727704, XrefRangeStart = 727686, XrefRangeEnd = 727697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkedEntity GetEquipmentEntity(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_GetEquipmentEntity_Public_NetworkedEntity_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkedEntity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 727704, RefRangeEnd = 727710, XrefRangeStart = 727704, XrefRangeEnd = 727704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetEquipmentItemId(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_GetEquipmentItemId_Public_PrefabGUID_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 727746, RefRangeEnd = 727748, XrefRangeStart = 727710, XrefRangeEnd = 727746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetAllEquipmentEntities(NativeList<Entity> equipment)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipment;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_GetAllEquipmentEntities_Public_Void_NativeList_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727748, XrefRangeEnd = 727753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddEquipmentEntityIfNotNull(
      Entity equipmentEntity,
      NativeList<Entity> equipment)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &equipmentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &equipment;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_AddEquipmentEntityIfNotNull_Private_Void_Entity_NativeList_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 727759, RefRangeEnd = 727761, XrefRangeStart = 727753, XrefRangeEnd = 727759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnequipItem(EquipmentType equipmentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &equipmentType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_UnequipItem_Public_Void_EquipmentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727761, XrefRangeEnd = 727797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 724455, RefRangeEnd = 724468, XrefRangeStart = 724455, XrefRangeEnd = 724468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float ConvertEquipmentLevel(
      float equipment,
      ServantEquipment.GearType gearType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &equipment;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gearType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantEquipment.NativeMethodInfoPtr_ConvertEquipmentLevel_Public_Static_Single_Single_GearType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServantEquipment()
    {
      Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantEquipment));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr);
      ServantEquipment.NativeFieldInfoPtr_ArmorChestSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (ArmorChestSlotEntity));
      ServantEquipment.NativeFieldInfoPtr_ArmorChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (ArmorChestSlotId));
      ServantEquipment.NativeFieldInfoPtr_WeaponSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (WeaponSlotEntity));
      ServantEquipment.NativeFieldInfoPtr_WeaponSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (WeaponSlotId));
      ServantEquipment.NativeFieldInfoPtr_GrimoireSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (GrimoireSlotEntity));
      ServantEquipment.NativeFieldInfoPtr_GrimoireSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (GrimoireSlotId));
      ServantEquipment.NativeFieldInfoPtr_ArmorFootgearSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (ArmorFootgearSlotEntity));
      ServantEquipment.NativeFieldInfoPtr_ArmorFootgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (ArmorFootgearSlotId));
      ServantEquipment.NativeFieldInfoPtr_ArmorLegsSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (ArmorLegsSlotEntity));
      ServantEquipment.NativeFieldInfoPtr_ArmorLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (ArmorLegsSlotId));
      ServantEquipment.NativeFieldInfoPtr_ArmorGlovesSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (ArmorGlovesSlotEntity));
      ServantEquipment.NativeFieldInfoPtr_ArmorGlovesSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, nameof (ArmorGlovesSlotId));
      ServantEquipment.NativeMethodInfoPtr_CanEquip_Public_Static_Boolean_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664425);
      ServantEquipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664426);
      ServantEquipment.NativeMethodInfoPtr_SetEquipped_Public_Void_EquipmentType_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664427);
      ServantEquipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_Entity_byref_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664428);
      ServantEquipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_PrefabGUID_byref_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664429);
      ServantEquipment.NativeMethodInfoPtr_IsEquipped_Public_Boolean_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664430);
      ServantEquipment.NativeMethodInfoPtr_GetEquipmentEntity_Public_NetworkedEntity_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664431);
      ServantEquipment.NativeMethodInfoPtr_GetEquipmentItemId_Public_PrefabGUID_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664432);
      ServantEquipment.NativeMethodInfoPtr_GetAllEquipmentEntities_Public_Void_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664433);
      ServantEquipment.NativeMethodInfoPtr_AddEquipmentEntityIfNotNull_Private_Void_Entity_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664434);
      ServantEquipment.NativeMethodInfoPtr_UnequipItem_Public_Void_EquipmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664435);
      ServantEquipment.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664436);
      ServantEquipment.NativeMethodInfoPtr_ConvertEquipmentLevel_Public_Static_Single_Single_GearType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, 100664437);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantEquipment>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum GearType
    {
      Weapon,
      Armor,
      Spell,
    }
  }
}
