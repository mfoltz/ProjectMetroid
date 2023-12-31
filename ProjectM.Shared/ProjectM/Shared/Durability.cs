// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Durability
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Durability
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDurability;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairRecipe;
    private static readonly System.IntPtr NativeFieldInfoPtr_LossType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TakeDamageDurabilityLossFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealDamageTypeModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsBroken;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_OneLevelFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_TwoLevelFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThreeLevelFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_GlobalDealDamageFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_GlobalTakeDamageFactor;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDurabilityChangeByDamageDealt_Public_Void_EntityCategory_Single_Single_Int32_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDurabilityChangeByDamageTaken_Public_Void_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDurabilityChangeBySpellUsed_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRepairCostModifier_Private_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRepairCost_Public_NativeList_1_ItemRepairBuffer_PrefabLookupMap_BufferFromEntity_1_ItemRepairBuffer_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRepairCost_Public_NativeList_1_ItemRepairBuffer_PrefabLookupMap_EntityManager_0;
    [FieldOffset(0)]
    public float Value;
    [FieldOffset(4)]
    public float MaxDurability;
    [FieldOffset(8)]
    public PrefabGUID RepairRecipe;
    [FieldOffset(12)]
    public DurabilityLossType LossType;
    [FieldOffset(16)]
    public float TakeDamageDurabilityLossFactor;
    [FieldOffset(20)]
    public DurabilityDamageModifiers DealDamageTypeModifiers;
    [FieldOffset(32)]
    public bool IsBroken;
    [FieldOffset(36)]
    public SequenceGUID RepairSequence;
    [FieldOffset(40)]
    public float OneLevelFactor;
    [FieldOffset(44)]
    public float TwoLevelFactor;
    [FieldOffset(48)]
    public float ThreeLevelFactor;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 797134, RefRangeEnd = 797135, XrefRangeStart = 797128, XrefRangeEnd = 797134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyDurabilityChangeByDamageDealt(
      EntityCategory targetCategory,
      float damageDealt,
      float modifier,
      int unitLevel,
      float gearLevel,
      float reducedDurabilityOnResourceDamageFactor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &targetCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &damageDealt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &unitLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &gearLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &reducedDurabilityOnResourceDamageFactor;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Durability.NativeMethodInfoPtr_ApplyDurabilityChangeByDamageDealt_Public_Void_EntityCategory_Single_Single_Int32_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 797137, RefRangeEnd = 797138, XrefRangeStart = 797135, XrefRangeEnd = 797137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyDurabilityChangeByDamageTaken(
      float damageTaken,
      float modifier,
      float maxHealth)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &damageTaken;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxHealth;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Durability.NativeMethodInfoPtr_ApplyDurabilityChangeByDamageTaken_Public_Void_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 797140, RefRangeEnd = 797142, XrefRangeStart = 797138, XrefRangeEnd = 797140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyDurabilityChangeBySpellUsed(float spellCost)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &spellCost;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Durability.NativeMethodInfoPtr_ApplyDurabilityChangeBySpellUsed_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe float GetRepairCostModifier()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Durability.NativeMethodInfoPtr_GetRepairCostModifier_Private_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 797170, RefRangeEnd = 797171, XrefRangeStart = 797142, XrefRangeEnd = 797170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<ItemRepairBuffer> GetRepairCost(
      PrefabLookupMap prefabLookupMap,
      BufferFromEntity<ItemRepairBuffer> getRepairCost,
      float modifier = 1f,
      bool floorResult = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getRepairCost;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &floorResult;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Durability.NativeMethodInfoPtr_GetRepairCost_Public_NativeList_1_ItemRepairBuffer_PrefabLookupMap_BufferFromEntity_1_ItemRepairBuffer_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<ItemRepairBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 797194, RefRangeEnd = 797198, XrefRangeStart = 797171, XrefRangeEnd = 797194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<ItemRepairBuffer> GetRepairCost(
      PrefabLookupMap prefabLookupMap,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Durability.NativeMethodInfoPtr_GetRepairCost_Public_NativeList_1_ItemRepairBuffer_PrefabLookupMap_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<ItemRepairBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Durability()
    {
      Il2CppClassPointerStore<Durability>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (Durability));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Durability>.NativeClassPtr);
      Durability.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (Value));
      Durability.NativeFieldInfoPtr_MaxDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (MaxDurability));
      Durability.NativeFieldInfoPtr_RepairRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (RepairRecipe));
      Durability.NativeFieldInfoPtr_LossType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (LossType));
      Durability.NativeFieldInfoPtr_TakeDamageDurabilityLossFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (TakeDamageDurabilityLossFactor));
      Durability.NativeFieldInfoPtr_DealDamageTypeModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (DealDamageTypeModifiers));
      Durability.NativeFieldInfoPtr_IsBroken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (IsBroken));
      Durability.NativeFieldInfoPtr_RepairSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (RepairSequence));
      Durability.NativeFieldInfoPtr_OneLevelFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (OneLevelFactor));
      Durability.NativeFieldInfoPtr_TwoLevelFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (TwoLevelFactor));
      Durability.NativeFieldInfoPtr_ThreeLevelFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (ThreeLevelFactor));
      Durability.NativeFieldInfoPtr_GlobalDealDamageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (GlobalDealDamageFactor));
      Durability.NativeFieldInfoPtr_GlobalTakeDamageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Durability>.NativeClassPtr, nameof (GlobalTakeDamageFactor));
      Durability.NativeMethodInfoPtr_ApplyDurabilityChangeByDamageDealt_Public_Void_EntityCategory_Single_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Durability>.NativeClassPtr, 100670340);
      Durability.NativeMethodInfoPtr_ApplyDurabilityChangeByDamageTaken_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Durability>.NativeClassPtr, 100670341);
      Durability.NativeMethodInfoPtr_ApplyDurabilityChangeBySpellUsed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Durability>.NativeClassPtr, 100670342);
      Durability.NativeMethodInfoPtr_GetRepairCostModifier_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Durability>.NativeClassPtr, 100670343);
      Durability.NativeMethodInfoPtr_GetRepairCost_Public_NativeList_1_ItemRepairBuffer_PrefabLookupMap_BufferFromEntity_1_ItemRepairBuffer_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Durability>.NativeClassPtr, 100670344);
      Durability.NativeMethodInfoPtr_GetRepairCost_Public_NativeList_1_ItemRepairBuffer_PrefabLookupMap_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Durability>.NativeClassPtr, 100670345);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Durability>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float GlobalDealDamageFactor
    {
      get
      {
        float dealDamageFactor;
        IL2CPP.il2cpp_field_static_get_value(Durability.NativeFieldInfoPtr_GlobalDealDamageFactor, (void*) &dealDamageFactor);
        return dealDamageFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Durability.NativeFieldInfoPtr_GlobalDealDamageFactor, (void*) &value);
      }
    }

    public static unsafe float GlobalTakeDamageFactor
    {
      get
      {
        float takeDamageFactor;
        IL2CPP.il2cpp_field_static_get_value(Durability.NativeFieldInfoPtr_GlobalTakeDamageFactor, (void*) &takeDamageFactor);
        return takeDamageFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Durability.NativeFieldInfoPtr_GlobalTakeDamageFactor, (void*) &value);
      }
    }
  }
}
