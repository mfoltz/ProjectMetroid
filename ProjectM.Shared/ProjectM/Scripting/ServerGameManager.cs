// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ServerGameManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using ProjectM.Shared;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerGameManager
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DependenciesInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicsData;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileMapData;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyCommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_SCTTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemGroupHashLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationIDs;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__ItemLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr__SCTPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__TriggerData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionChecker;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationSourceMappings;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeSinceStartup;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_Random;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasDayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SCTPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TriggerData_Public_get_NativeList_1_TriggerData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetEntityManager_Public_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetConditionChecker_Public_Void_ConditionChecker_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityManager_Public_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPrefabLookupMap_Public_Void_PrefabCollectionSystem_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupModifications_Public_Void_ModificationIDs_NativeMultiHashMap_2_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTriggerData_Public_Void_NativeList_1_TriggerData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetItemLookupMap_Public_Void_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequenceOnTarget_Public_Void_Entity_SequenceGUID_Single_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequenceOnPosition_Public_Void_float3_quaternion_SequenceGUID_Single_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayImpactSequence_Public_Void_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddStatChangeListener_Public_ListenerId_Entity_Entity_StatChangeCallbackDelegate_Boolean_StatChangeListenerLocation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddGlobalDeathListener_Public_ListenerId_Entity_GlobalDeathDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOnKillListener_Public_ListenerId_Entity_Entity_OnKillDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOnDeathListener_Public_ListenerId_Entity_Entity_OnDeathDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEventListener_Public_ListenerId_Entity_GenericEventDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_ListenerId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleFunction_Public_Void_Entity_Single_ScheduledFunctionDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Public_Entity_Entity_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_StatChangeCallbackDelegate_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealEnergy_Public_Void_Entity_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_DealDamageParameters_Single_StatChangeCallbackDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Single_Boolean_Boolean_Boolean_StatChangeCallbackDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_EntityTypeModifiers_Single_Single_Single_Boolean_Boolean_Boolean_StatChangeCallbackDelegate_MainDamageType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyComponent_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddGameplayEvent_Public_Void_GameplayEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_EntityOwner_Entity_Entity_float3_float3_quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInventoryItemCount_Public_Int32_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInventoryItem_Public_Boolean_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasFullInventory_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddInventoryItem_Public_AddItemResponse_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddInventoryItem_Public_AddItemResponse_Entity_PrefabGUID_Int32_Nullable_Unboxed_1_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDropInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDropRandomInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDropRandomInventoryItem_Public_Boolean_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Void_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Void_Entity_Byte_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Void_float3_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateBuffEntityImmediate_Public_Entity_Entity_Entity_PrefabGUID_OnSpawnedDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInstantiateBuffEntityImmediate_Public_Boolean_Entity_Entity_PrefabGUID_OnSpawnedDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInstantiateBuffEntityImmediate_Public_Boolean_Entity_Entity_PrefabGUID_byref_Entity_OnSpawnedDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateKnockback_Public_Void_Entity_Entity_float3_Single_Single_byref_KnockbackPower_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponentData_Public_Void_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveComponent_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetList_Public_DataList_1_T_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffer_Public_DynamicBuffer_1_T_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddToBuffer_Public_Boolean_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddToBufferUnique_Public_Boolean_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_T_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponent_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetComponentImmediate_Public_Void_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetComponentDeferred_Public_Void_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponentDeferred_Public_Void_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Entity_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRequiredComponent_Public_Boolean_Entity_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSingleton_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSingleton_Public_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugName_Public_String_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOwnerOrSelf_Private_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOwner_Public_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasOwner_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetOwner_Public_Boolean_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Public_EntityInput_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBloodMoonBuffBonus_Public_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InterruptCast_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityCooldown_Public_Single_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityGroupCooldown_Public_Single_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityGroupCooldown_Public_Single_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityGroupCooldown_Internal_Private_Single_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityCooldown_Public_Void_Entity_PrefabGUID_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityGroupCooldown_Public_Void_Entity_PrefabGUID_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityGroupCooldown_Public_Void_Entity_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityGroupCooldown_Internal_Private_Void_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityCharges_Public_Int32_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityGroupCharges_Public_Int32_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityGroupCharges_Public_Int32_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityGroupCharges_Internal_Private_Int32_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityCharges_Public_Void_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityGroupCharges_Public_Void_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityGroupCharges_Public_Void_Entity_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityGroupCharges_Internal_Private_Void_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForceCastAbilityGroup_Public_Void_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForceCastAbilityGroup_Public_Void_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyAbilityGroupOnSlot_Public_ModificationId_Entity_Entity_Int32_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAbilityGroupModificationOnSlot_Public_Void_Entity_Int32_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAllies_Public_Boolean_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAllies_Public_Boolean_Team_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_AssetGuid_PrefabGUID_float3_Entity_float3_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_AssetGuid_float3_Entity_float3_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckCondition_Public_Boolean_SelfServer_Entity_Entity_BlobAssetReference_1_ConditionBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendToBufferDeferred_Public_Void_Entity_T_0;
    [FieldOffset(0)]
    public bool DependenciesInitialized;
    [FieldOffset(8)]
    public PhysicsData PhysicsData;
    [FieldOffset(424)]
    public TileMapCollisionMath.MapData TileMapData;
    [FieldOffset(528)]
    public TileWorld TileWorld;
    [FieldOffset(552)]
    public EntityCommandBuffer CommandBuffer;
    [FieldOffset(568)]
    public EntityCommandBuffer DestroyCommandBuffer;
    [FieldOffset(584)]
    public SCTTypeCollection SCTTypes;
    [FieldOffset(736)]
    public PrefabLookupMap PrefabLookupMap;
    [FieldOffset(784)]
    public NativeHashMap<PrefabGUID, ItemDataDropGroup> ItemGroupHashLookupMap;
    [FieldOffset(800)]
    public CollisionDetection SpatialLookup;
    [FieldOffset(816)]
    public ModificationIDs _ModificationIDs;
    [FieldOffset(832)]
    public EntityManager _EntityManager;
    [FieldOffset(840)]
    public NativeHashMap<PrefabGUID, ItemData> _ItemLookupMap_k__BackingField;
    [FieldOffset(856)]
    public Entity _NetworkedSequence;
    [FieldOffset(864)]
    public Entity _SCTPrefab;
    [FieldOffset(872)]
    public NativeList<ProjectM.Scripting.TriggerData> _TriggerData;
    [FieldOffset(888)]
    public ConditionChecker ConditionChecker;
    [FieldOffset(3088)]
    public NativeList<GameplayEvent> GameplayEvents;
    [FieldOffset(3104)]
    public ProjectM.Shared.SpellModCollection<BlobAssetReference<SpellModBlob>> SpellModCollection;
    [FieldOffset(3120)]
    public NativeMultiHashMap<Entity, Entity> ModificationSourceMappings;
    [FieldOffset(3136)]
    public float DeltaTime;
    [FieldOffset(3144)]
    public double TimeSinceStartup;
    [FieldOffset(3152)]
    public double ServerTime;
    [FieldOffset(3160)]
    public int ServerFrame;
    [FieldOffset(3168)]
    public CurveCollection CurveCollection;
    [FieldOffset(3184)]
    public Unity.Mathematics.Random Random;
    [FieldOffset(3188)]
    public bool HasDayNightCycle;
    [FieldOffset(3192)]
    public DayNightCycle DayNightCycle;

    public unsafe ModificationIDs ModificationIDs
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationIDs*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, ItemData> ItemLookupMap
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_get_ItemLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, ItemData>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_set_ItemLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Entity SCTPrefab
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_get_SCTPrefab_Public_get_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeList<ProjectM.Scripting.TriggerData> TriggerData
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_get_TriggerData_Public_get_NativeList_1_TriggerData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<ProjectM.Scripting.TriggerData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public unsafe void SetEntityManager(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetEntityManager_Public_Void_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774772, XrefRangeEnd = 774773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetConditionChecker(ConditionChecker conditionChecker)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &conditionChecker;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetConditionChecker_Public_Void_ConditionChecker_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe EntityManager GetEntityManager()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetEntityManager_Public_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityManager*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 774778, RefRangeEnd = 774779, XrefRangeStart = 774773, XrefRangeEnd = 774778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPrefabLookupMap(
      PrefabCollectionSystem prefabCollectionSystem,
      Entity networkedEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &networkedEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetPrefabLookupMap_Public_Void_PrefabCollectionSystem_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetupModifications(
      ModificationIDs modificationIds,
      NativeMultiHashMap<Entity, Entity> modificationSourceMappings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &modificationIds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationSourceMappings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetupModifications_Public_Void_ModificationIDs_NativeMultiHashMap_2_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetTriggerData(NativeList<ProjectM.Scripting.TriggerData> triggerData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &triggerData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetTriggerData_Public_Void_NativeList_1_TriggerData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetItemLookupMap(GameDataSystem gameDataSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetItemLookupMap_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 774801, RefRangeEnd = 774807, XrefRangeStart = 774779, XrefRangeEnd = 774801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlaySequenceOnTarget(
      Entity target,
      SequenceGUID sequenceGuid,
      float scale = 1f,
      Entity secondaryTarget = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTarget;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_PlaySequenceOnTarget_Public_Void_Entity_SequenceGUID_Single_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 774822, RefRangeEnd = 774833, XrefRangeStart = 774807, XrefRangeEnd = 774822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlaySequenceOnPosition(
      float3 position,
      quaternion rotation,
      SequenceGUID sequenceGuid,
      float scale = 1f,
      Entity secondaryTarget = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTarget;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_PlaySequenceOnPosition_Public_Void_float3_quaternion_SequenceGUID_Single_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774833, XrefRangeEnd = 774890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayImpactSequence(
      PrefabGUID impactMappingGuid,
      Entity target,
      float3 position,
      quaternion rotation,
      SequenceGUID impactSequenceGuid = default (SequenceGUID),
      float scale = 1f,
      bool skipMaterialSequence = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &impactMappingGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &impactSequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &skipMaterialSequence;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_PlayImpactSequence_Public_Void_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(32)]
    [CachedScanResults(RefRangeStart = 774921, RefRangeEnd = 774953, XrefRangeStart = 774890, XrefRangeEnd = 774921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ListenerId AddStatChangeListener(
      Entity self,
      Entity entity,
      ServerScriptMapper.StatChangeCallbackDelegate callback,
      bool outgoing = false,
      StatChangeListenerLocation location = StatChangeListenerLocation.AfterApplication)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &outgoing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &location;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_AddStatChangeListener_Public_ListenerId_Entity_Entity_StatChangeCallbackDelegate_Boolean_StatChangeListenerLocation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ListenerId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774953, XrefRangeEnd = 774984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ListenerId AddGlobalDeathListener(
      Entity self,
      ServerScriptMapper.GlobalDeathDelegate callback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_AddGlobalDeathListener_Public_ListenerId_Entity_GlobalDeathDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ListenerId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 775015, RefRangeEnd = 775019, XrefRangeStart = 774984, XrefRangeEnd = 775015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ListenerId AddOnKillListener(
      Entity self,
      Entity target,
      ServerScriptMapper.OnKillDelegate callback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_AddOnKillListener_Public_ListenerId_Entity_Entity_OnKillDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ListenerId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 775050, RefRangeEnd = 775055, XrefRangeStart = 775019, XrefRangeEnd = 775050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ListenerId AddOnDeathListener(
      Entity self,
      Entity target,
      ServerScriptMapper.OnDeathDelegate callback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_AddOnDeathListener_Public_ListenerId_Entity_Entity_OnDeathDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ListenerId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 775089, RefRangeEnd = 775092, XrefRangeStart = 775055, XrefRangeEnd = 775089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ListenerId AddEventListener<T>(
      Entity self,
      ServerScriptMapper.GenericEventDelegate callback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_AddEventListener_Public_ListenerId_Entity_GenericEventDelegate_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ListenerId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 775128, RefRangeEnd = 775133, XrefRangeStart = 775092, XrefRangeEnd = 775128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveListener(ListenerId listener)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &listener;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ListenerId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775154, RefRangeEnd = 775155, XrefRangeStart = 775133, XrefRangeEnd = 775154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity CreateEvent<T>(T value)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_CreateEvent_Public_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 775182, RefRangeEnd = 775194, XrefRangeStart = 775155, XrefRangeEnd = 775182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleFunction(
      Entity self,
      float time,
      ServerScriptMapper.ScheduledFunctionDelegate callback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_ScheduleFunction_Public_Void_Entity_Single_ScheduledFunctionDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775194, XrefRangeEnd = 775198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity SendMessage(Entity target, string functionName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SendMessage_Public_Entity_Entity_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 775203, RefRangeEnd = 775208, XrefRangeStart = 775198, XrefRangeEnd = 775203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealHealing(
      Entity self,
      Entity target,
      float healing,
      bool trueHealing = false,
      bool isLeech = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &healing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &trueHealing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isLeech;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 775212, RefRangeEnd = 775214, XrefRangeStart = 775208, XrefRangeEnd = 775212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealHealing(
      Entity self,
      Entity target,
      float healing,
      bool sct,
      bool trueHealing = false,
      bool isLeech = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &healing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sct;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &trueHealing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &isLeech;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775218, RefRangeEnd = 775219, XrefRangeStart = 775214, XrefRangeEnd = 775218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealHealing(
      Entity self,
      Entity target,
      float healing,
      bool sct,
      bool trueHealing = false,
      bool ignoreAmplify = false,
      bool isLeech = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &healing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sct;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &trueHealing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreAmplify;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &isLeech;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775219, XrefRangeEnd = 775237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealHealing(
      Entity self,
      Entity target,
      float healing,
      ServerScriptMapper.StatChangeCallbackDelegate callback,
      bool trueHealing = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &healing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &trueHealing;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_StatChangeCallbackDelegate_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775237, XrefRangeEnd = 775242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealEnergy(Entity self, Entity target, float energy)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &energy;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DealEnergy_Public_Void_Entity_Entity_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 775259, RefRangeEnd = 775269, XrefRangeStart = 775242, XrefRangeEnd = 775259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealDamage(
      Entity self,
      Entity target,
      DealDamageParameters parameters,
      float modifier = 1f,
      ServerScriptMapper.StatChangeCallbackDelegate callback = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_DealDamageParameters_Single_StatChangeCallbackDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775269, XrefRangeEnd = 775286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealDamage(
      Entity self,
      Entity target,
      MainDamageType damageType,
      float mainFactor,
      float resourceModifier,
      EntityTypeModifiers typeModifiers,
      float modifier = 1f,
      bool showSct = true,
      bool causeDurabilityLoss = true,
      bool isDoT = false,
      ServerScriptMapper.StatChangeCallbackDelegate callback = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &damageType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mainFactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &typeModifiers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &showSct;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &causeDurabilityLoss;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &isDoT;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Single_Boolean_Boolean_Boolean_StatChangeCallbackDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 775303, RefRangeEnd = 775309, XrefRangeStart = 775286, XrefRangeEnd = 775303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealDamage(
      Entity self,
      Entity target,
      EntityTypeModifiers typeModifier,
      float rawDamage,
      float rawDamagePercent = 0.0f,
      float modifier = 1f,
      bool showSct = true,
      bool causeDurabilityLoss = true,
      bool isDoT = false,
      ServerScriptMapper.StatChangeCallbackDelegate callback = null,
      MainDamageType mainDamageType = MainDamageType.Physical)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &typeModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rawDamage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rawDamagePercent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &showSct;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &causeDurabilityLoss;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &isDoT;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &mainDamageType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_EntityTypeModifiers_Single_Single_Single_Boolean_Boolean_Boolean_StatChangeCallbackDelegate_MainDamageType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775317, RefRangeEnd = 775318, XrefRangeStart = 775309, XrefRangeEnd = 775317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool VerifyComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_VerifyComponent_Private_Boolean_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775321, RefRangeEnd = 775322, XrefRangeStart = 775318, XrefRangeEnd = 775321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddGameplayEvent(GameplayEvent gameplayEvent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &gameplayEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_AddGameplayEvent_Public_Void_GameplayEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 775326, RefRangeEnd = 775340, XrefRangeStart = 775322, XrefRangeEnd = 775326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateGameplayEvent(
      GameplayEventId id,
      Entity spellSource,
      EntityOwner entityOwner,
      Entity spellTarget,
      Entity target,
      float3 originPos,
      float3 pos,
      quaternion rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spellSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spellTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &originPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_EntityOwner_Entity_Entity_float3_float3_quaternion_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 775341, RefRangeEnd = 775346, XrefRangeStart = 775340, XrefRangeEnd = 775341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateGameplayEvent(GameplayEventId id, Entity self)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 775377, RefRangeEnd = 775385, XrefRangeStart = 775346, XrefRangeEnd = 775377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateGameplayEvent(GameplayEventId id, Entity self, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775385, XrefRangeEnd = 775386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetInventoryItemCount(Entity target, PrefabGUID itemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetInventoryItemCount_Public_Int32_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775390, RefRangeEnd = 775391, XrefRangeStart = 775386, XrefRangeEnd = 775390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetInventoryItem(Entity target, PrefabGUID itemType, out Entity item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref item;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryGetInventoryItem_Public_Boolean_Entity_PrefabGUID_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775391, XrefRangeEnd = 775392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasFullInventory(Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_HasFullInventory_Public_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 775394, RefRangeEnd = 775396, XrefRangeStart = 775392, XrefRangeEnd = 775394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AddItemResponse TryAddInventoryItem(
      Entity target,
      PrefabGUID itemType,
      int stacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryAddInventoryItem_Public_AddItemResponse_Entity_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AddItemResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775396, XrefRangeEnd = 775398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AddItemResponse TryAddInventoryItem(
      Entity target,
      PrefabGUID itemType,
      int stacks,
      Nullable_Unboxed<int> startIndex,
      bool onlyFillEmptySlots)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyFillEmptySlots;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryAddInventoryItem_Public_AddItemResponse_Entity_PrefabGUID_Int32_Nullable_Unboxed_1_Int32_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AddItemResponse*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 775399, RefRangeEnd = 775401, XrefRangeStart = 775398, XrefRangeEnd = 775399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryRemoveInventoryItem(Entity target, PrefabGUID itemType, int stacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryRemoveInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775401, XrefRangeEnd = 775402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryDropInventoryItem(Entity target, PrefabGUID itemType, int stacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryDropInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775407, RefRangeEnd = 775408, XrefRangeStart = 775402, XrefRangeEnd = 775407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryDropRandomInventoryItem(Entity target, PrefabGUID itemType, int stacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryDropRandomInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775408, XrefRangeEnd = 775409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryDropRandomInventoryItem(Entity target, PrefabGUID itemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryDropRandomInventoryItem_Public_Boolean_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775409, XrefRangeEnd = 775410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDroppedItemEntity(Entity target, PrefabGUID itemType, int stacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Void_Entity_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 775411, RefRangeEnd = 775413, XrefRangeStart = 775410, XrefRangeEnd = 775411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateStacksIncreaseEvent(Entity buff, byte oldStacks, byte newStacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oldStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newStacks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Void_Entity_Byte_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775413, XrefRangeEnd = 775414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDroppedItemEntity(float3 position, PrefabGUID itemType, int stacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Void_float3_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 775415, RefRangeEnd = 775419, XrefRangeStart = 775414, XrefRangeEnd = 775415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateBuffEntityImmediate(
      Entity creator,
      Entity target,
      PrefabGUID prefabGuid,
      ServerScriptMapper.OnSpawnedDelegate callback = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &creator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_InstantiateBuffEntityImmediate_Public_Entity_Entity_Entity_PrefabGUID_OnSpawnedDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 775420, RefRangeEnd = 775449, XrefRangeStart = 775419, XrefRangeEnd = 775420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInstantiateBuffEntityImmediate(
      Entity creator,
      Entity target,
      PrefabGUID prefabGuid,
      ServerScriptMapper.OnSpawnedDelegate callback = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &creator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryInstantiateBuffEntityImmediate_Public_Boolean_Entity_Entity_PrefabGUID_OnSpawnedDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 775486, RefRangeEnd = 775503, XrefRangeStart = 775449, XrefRangeEnd = 775486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInstantiateBuffEntityImmediate(
      Entity creator,
      Entity target,
      PrefabGUID prefabGuid,
      out Entity buffEntity,
      ServerScriptMapper.OnSpawnedDelegate callback = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &creator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryInstantiateBuffEntityImmediate_Public_Boolean_Entity_Entity_PrefabGUID_byref_Entity_OnSpawnedDelegate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 775514, RefRangeEnd = 775517, XrefRangeStart = 775503, XrefRangeEnd = 775514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateKnockback(
      Entity creator,
      Entity target,
      float3 direction,
      float duration,
      float range,
      [In] ref KnockbackPower knockbackPower)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &creator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &range;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref knockbackPower;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateKnockback_Public_Void_Entity_Entity_float3_Single_Single_byref_KnockbackPower_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775518, RefRangeEnd = 775519, XrefRangeStart = 775517, XrefRangeEnd = 775518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddComponentData<T>(Entity entity, T componentData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) componentData;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref componentData;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_AddComponentData_Public_Void_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 775520, RefRangeEnd = 775523, XrefRangeStart = 775519, XrefRangeEnd = 775520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_RemoveComponent_Public_Void_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe DataList<T> GetList<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_GetList_Public_DataList_1_T_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DataList<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(149)]
    [CachedScanResults(RefRangeStart = 775523, RefRangeEnd = 775672, XrefRangeStart = 775523, XrefRangeEnd = 775523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBuffer<T>(Entity entity, out DynamicBuffer<T> output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref output;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(219)]
    [CachedScanResults(RefRangeStart = 775672, RefRangeEnd = 775891, XrefRangeStart = 775672, XrefRangeEnd = 775672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicBuffer<T> GetBuffer<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_GetBuffer_Public_DynamicBuffer_1_T_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775893, RefRangeEnd = 775894, XrefRangeStart = 775891, XrefRangeEnd = 775893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryAddToBuffer<T>(Entity entity, T element)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) element;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref element;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryAddToBuffer_Public_Boolean_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 775897, RefRangeEnd = 775898, XrefRangeStart = 775894, XrefRangeEnd = 775897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryAddToBufferUnique<T>(Entity entity, T element)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) element;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref element;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryAddToBufferUnique_Public_Boolean_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 775898, RefRangeEnd = 775914, XrefRangeStart = 775898, XrefRangeEnd = 775898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T GetComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_GetComponent_Public_T_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 775914, RefRangeEnd = 775916, XrefRangeStart = 775914, XrefRangeEnd = 775914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ValueTuple_Unboxed<T1, T2> GetComponents<T1, T2>(Entity entity)
      where T1 : unmanaged
      where T2 : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0<T1, T2>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<T1, T2>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 775898, RefRangeEnd = 775914, XrefRangeStart = 775898, XrefRangeEnd = 775914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ValueTuple_Unboxed<T1, T2, T3> GetComponents<T1, T2, T3>(Entity entity)
      where T1 : unmanaged
      where T2 : unmanaged
      where T3 : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0<T1, T2, T3>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<T1, T2, T3>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe ValueTuple_Unboxed<T1, T2, T3, T4> GetComponents<T1, T2, T3, T4>(Entity entity)
      where T1 : unmanaged
      where T2 : unmanaged
      where T3 : unmanaged
      where T4 : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0<T1, T2, T3, T4>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<T1, T2, T3, T4>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(262)]
    [CachedScanResults(RefRangeStart = 775916, RefRangeEnd = 776178, XrefRangeStart = 775916, XrefRangeEnd = 775916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_HasComponent_Public_Boolean_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasComponents<T1, T2>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasComponents<T1, T2, T3>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2, T3>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasComponents<T1, T2, T3, T4>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2, T3, T4>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 776178, RefRangeEnd = 776199, XrefRangeStart = 776178, XrefRangeEnd = 776178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetComponentImmediate<T>(Entity entity, T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) component;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_SetComponentImmediate_Public_Void_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 776199, RefRangeEnd = 776200, XrefRangeStart = 776199, XrefRangeEnd = 776199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetComponentDeferred<T>(Entity entity, T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) component;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_SetComponentDeferred_Public_Void_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 776200, RefRangeEnd = 776204, XrefRangeStart = 776200, XrefRangeEnd = 776200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddComponentDeferred<T>(Entity entity, T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) component;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_AddComponentDeferred_Public_Void_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 776319, RefRangeEnd = 776321, XrefRangeStart = 776204, XrefRangeEnd = 776319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetComponent<T>(Entity entity, out T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_Entity_byref_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref component;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 776365, RefRangeEnd = 776366, XrefRangeStart = 776321, XrefRangeEnd = 776365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetRequiredComponent<T>(Entity entity, out T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetRequiredComponent_Public_Boolean_Entity_byref_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref component;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 776366, RefRangeEnd = 776382, XrefRangeStart = 776366, XrefRangeEnd = 776366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetComponents<T1, T2>(
      Entity entity,
      out T1 component1,
      out T2 component2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T1& local1;
      if (!typeof (T1).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T1*) &zero1);
      }
      else
        local1 = ref component1;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      T2& local2;
      if (!typeof (T2).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(T2*) &zero2);
      }
      else
        local2 = ref component2;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr exc;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0<T1, T2>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T1).IsValueType)
      {
        ref T1 local3 = ref component1;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T1>(objectPointer, false, false);
        local3 = (T1) valueGeneric;
      }
      if (!typeof (T2).IsValueType)
      {
        ref T2 local4 = ref component2;
        System.IntPtr objectPointer = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T2>(objectPointer, false, false);
        local4 = (T2) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 776382, RefRangeEnd = 776388, XrefRangeStart = 776382, XrefRangeEnd = 776382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetComponents<T1, T2, T3>(
      Entity entity,
      out T1 component1,
      out T2 component2,
      out T3 component3)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T1& local1;
      if (!typeof (T1).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T1*) &zero1);
      }
      else
        local1 = ref component1;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      T2& local2;
      if (!typeof (T2).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(T2*) &zero2);
      }
      else
        local2 = ref component2;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr num3 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero3;
      // ISSUE: variable of a reference type
      T3& local3;
      if (!typeof (T3).IsValueType)
      {
        zero3 = System.IntPtr.Zero;
        local3 = ref (*(T3*) &zero3);
      }
      else
        local3 = ref component3;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0<T1, T2, T3>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T1).IsValueType)
      {
        ref T1 local4 = ref component1;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T1>(objectPointer, false, false);
        local4 = (T1) valueGeneric;
      }
      if (!typeof (T2).IsValueType)
      {
        ref T2 local5 = ref component2;
        System.IntPtr objectPointer = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T2>(objectPointer, false, false);
        local5 = (T2) valueGeneric;
      }
      if (!typeof (T3).IsValueType)
      {
        ref T3 local6 = ref component3;
        System.IntPtr objectPointer = zero3;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T3>(objectPointer, false, false);
        local6 = (T3) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 776388, RefRangeEnd = 776389, XrefRangeStart = 776388, XrefRangeEnd = 776388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetComponents<T1, T2, T3, T4>(
      Entity entity,
      out T1 component1,
      out T2 component2,
      out T3 component3,
      out T4 component4)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T1& local1;
      if (!typeof (T1).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T1*) &zero1);
      }
      else
        local1 = ref component1;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      T2& local2;
      if (!typeof (T2).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(T2*) &zero2);
      }
      else
        local2 = ref component2;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr num3 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero3;
      // ISSUE: variable of a reference type
      T3& local3;
      if (!typeof (T3).IsValueType)
      {
        zero3 = System.IntPtr.Zero;
        local3 = ref (*(T3*) &zero3);
      }
      else
        local3 = ref component3;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
      System.IntPtr num4 = (System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr zero4;
      // ISSUE: variable of a reference type
      T4& local4;
      if (!typeof (T4).IsValueType)
      {
        zero4 = System.IntPtr.Zero;
        local4 = ref (*(T4*) &zero4);
      }
      else
        local4 = ref component4;
      *(System.IntPtr*) num4 = (System.IntPtr) ref local4;
      System.IntPtr exc;
      System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0<T1, T2, T3, T4>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T1).IsValueType)
      {
        ref T1 local5 = ref component1;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T1>(objectPointer, false, false);
        local5 = (T1) valueGeneric;
      }
      if (!typeof (T2).IsValueType)
      {
        ref T2 local6 = ref component2;
        System.IntPtr objectPointer = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T2>(objectPointer, false, false);
        local6 = (T2) valueGeneric;
      }
      if (!typeof (T3).IsValueType)
      {
        ref T3 local7 = ref component3;
        System.IntPtr objectPointer = zero3;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T3>(objectPointer, false, false);
        local7 = (T3) valueGeneric;
      }
      if (!typeof (T4).IsValueType)
      {
        ref T4 local8 = ref component4;
        System.IntPtr objectPointer = zero4;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T4>(objectPointer, false, false);
        local8 = (T4) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
    }

    [CallerCount(0)]
    public unsafe bool HasSingleton<T>()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_HasSingleton_Public_Boolean_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe T GetSingleton<T>()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_GetSingleton_Public_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    public unsafe bool TryGetSingleton<T>(out T component)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref component;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetSingleton_Public_Boolean_byref_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref component;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Entity GetSingletonEntity<T>()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_GetSingletonEntity_Public_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool TryGetSingletonEntity<T>(out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetSingletonEntity_Public_Boolean_byref_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(262)]
    [CachedScanResults(RefRangeStart = 775916, RefRangeEnd = 776178, XrefRangeStart = 775916, XrefRangeEnd = 776178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBuff<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_HasBuff_Public_Boolean_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 776390, RefRangeEnd = 776400, XrefRangeStart = 776389, XrefRangeEnd = 776390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBuff(Entity entity, PrefabGUID buffPrefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 776401, RefRangeEnd = 776406, XrefRangeStart = 776400, XrefRangeEnd = 776401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBuff(Entity entity, PrefabGUID entityGUID, out Entity buff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_PrefabGUID_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool TryGetBuff<T>(Entity entity, out Entity buff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_TryGetBuff_Public_Boolean_Entity_byref_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 776409, RefRangeEnd = 776438, XrefRangeStart = 776406, XrefRangeEnd = 776409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Destroy(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_Destroy_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 776441, RefRangeEnd = 776452, XrefRangeStart = 776438, XrefRangeEnd = 776441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyImmediate(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_DestroyImmediate_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 776453, RefRangeEnd = 776455, XrefRangeStart = 776452, XrefRangeEnd = 776453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetDebugName(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetDebugName_Public_String_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 776456, RefRangeEnd = 776484, XrefRangeStart = 776455, XrefRangeEnd = 776456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateEntityImmediate(Entity owner, PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 776485, RefRangeEnd = 776486, XrefRangeStart = 776484, XrefRangeEnd = 776485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateEntityImmediate(Entity owner, Entity prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 776487, RefRangeEnd = 776489, XrefRangeStart = 776486, XrefRangeEnd = 776487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateEntityDeferred(Entity owner, PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776489, XrefRangeEnd = 776490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateEntityDeferred(Entity owner, Entity prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 776491, RefRangeEnd = 776497, XrefRangeStart = 776490, XrefRangeEnd = 776491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetPrefabEntity(PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776497, XrefRangeEnd = 776498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetOwnerOrSelf(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetOwnerOrSelf_Private_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(226)]
    [CachedScanResults(RefRangeStart = 776499, RefRangeEnd = 776725, XrefRangeStart = 776498, XrefRangeEnd = 776499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetOwner(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetOwner_Public_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 776726, RefRangeEnd = 776727, XrefRangeStart = 776725, XrefRangeEnd = 776726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasOwner(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_HasOwner_Public_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 776728, RefRangeEnd = 776733, XrefRangeStart = 776727, XrefRangeEnd = 776728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetOwner(Entity entity, out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_TryGetOwner_Public_Boolean_Entity_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 776734, RefRangeEnd = 776738, XrefRangeStart = 776733, XrefRangeEnd = 776734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntityInput GetInput(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetInput_Public_EntityInput_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityInput*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(48)]
    [CachedScanResults(RefRangeStart = 776740, RefRangeEnd = 776788, XrefRangeStart = 776738, XrefRangeEnd = 776740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetBloodMoonBuffBonus()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetBloodMoonBuffBonus_Public_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 776794, RefRangeEnd = 776795, XrefRangeStart = 776788, XrefRangeEnd = 776794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InterruptCast(Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &character;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_InterruptCast_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776795, XrefRangeEnd = 776825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetAbilityCooldown(Entity character, PrefabGUID abilityType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetAbilityCooldown_Public_Single_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776825, XrefRangeEnd = 776841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetAbilityGroupCooldown(Entity character, PrefabGUID abilityGroupType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCooldown_Public_Single_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776841, XrefRangeEnd = 776845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetAbilityGroupCooldown(Entity character, int abilityGroupSlot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupSlot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCooldown_Public_Single_Entity_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 776868, RefRangeEnd = 776869, XrefRangeStart = 776845, XrefRangeEnd = 776868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetAbilityGroupCooldown_Internal(
      DynamicBuffer<AbilityGroupSlotBuffer> abilitySlots,
      int abilityGroupIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &abilitySlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCooldown_Internal_Private_Single_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 776908, RefRangeEnd = 776912, XrefRangeStart = 776869, XrefRangeEnd = 776908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityCooldown(Entity character, PrefabGUID abilityType, float cooldown)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cooldown;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetAbilityCooldown_Public_Void_Entity_PrefabGUID_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 776930, RefRangeEnd = 776933, XrefRangeStart = 776912, XrefRangeEnd = 776930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityGroupCooldown(
      Entity character,
      PrefabGUID abilityGroupType,
      float cooldown)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cooldown;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCooldown_Public_Void_Entity_PrefabGUID_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776933, XrefRangeEnd = 776937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityGroupCooldown(
      Entity character,
      int abilityGroupSlot,
      float cooldown)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cooldown;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCooldown_Public_Void_Entity_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 776964, RefRangeEnd = 776967, XrefRangeStart = 776937, XrefRangeEnd = 776964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityGroupCooldown_Internal(
      DynamicBuffer<AbilityGroupSlotBuffer> abilitySlots,
      int abilityGroupIndex,
      float cooldown)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &abilitySlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cooldown;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCooldown_Internal_Private_Void_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776967, XrefRangeEnd = 776996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetAbilityCharges(Entity character, PrefabGUID abilityType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetAbilityCharges_Public_Int32_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776996, XrefRangeEnd = 777012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetAbilityGroupCharges(Entity character, PrefabGUID abilityGroupType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCharges_Public_Int32_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777012, XrefRangeEnd = 777016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetAbilityGroupCharges(Entity character, int abilityGroupSlot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupSlot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCharges_Public_Int32_Entity_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 777029, RefRangeEnd = 777030, XrefRangeStart = 777016, XrefRangeEnd = 777029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetAbilityGroupCharges_Internal(
      DynamicBuffer<AbilityGroupSlotBuffer> abilitySlots,
      int abilityGroupIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &abilitySlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCharges_Internal_Private_Int32_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 777061, RefRangeEnd = 777064, XrefRangeStart = 777030, XrefRangeEnd = 777061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityCharges(Entity character, PrefabGUID abilityType, int charges)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &charges;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetAbilityCharges_Public_Void_Entity_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777064, XrefRangeEnd = 777082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityGroupCharges(
      Entity character,
      PrefabGUID abilityGroupType,
      int charges)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &charges;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCharges_Public_Void_Entity_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777082, XrefRangeEnd = 777086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityGroupCharges(Entity character, int abilityGroupSlot, int charges)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &charges;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCharges_Public_Void_Entity_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 777101, RefRangeEnd = 777104, XrefRangeStart = 777086, XrefRangeEnd = 777101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityGroupCharges_Internal(
      DynamicBuffer<AbilityGroupSlotBuffer> abilitySlots,
      int abilityGroupIndex,
      int charges)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &abilitySlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &charges;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCharges_Internal_Private_Void_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 777118, RefRangeEnd = 777119, XrefRangeStart = 777104, XrefRangeEnd = 777118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ForceCastAbilityGroup(Entity character, int abilityGroupSlot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupSlot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_ForceCastAbilityGroup_Public_Void_Entity_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 777127, RefRangeEnd = 777132, XrefRangeStart = 777119, XrefRangeEnd = 777127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ForceCastAbilityGroup(Entity character, PrefabGUID forceCastAbility)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &forceCastAbility;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_ForceCastAbilityGroup_Public_Void_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 777155, RefRangeEnd = 777156, XrefRangeStart = 777132, XrefRangeEnd = 777155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModificationId ModifyAbilityGroupOnSlot(
      Entity self,
      Entity character,
      int abilitySlot,
      PrefabGUID newAbilityGroup,
      int priority = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilitySlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newAbilityGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_ModifyAbilityGroupOnSlot_Public_ModificationId_Entity_Entity_Int32_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 777177, RefRangeEnd = 777179, XrefRangeStart = 777156, XrefRangeEnd = 777177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveAbilityGroupModificationOnSlot(
      Entity character,
      int abilitySlot,
      ModificationId modificationId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilitySlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_RemoveAbilityGroupModificationOnSlot_Public_Void_Entity_Int32_ModificationId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 777185, RefRangeEnd = 777186, XrefRangeStart = 777179, XrefRangeEnd = 777185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAllies(Entity entity, Entity targetEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_IsAllies_Public_Boolean_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 772742, RefRangeEnd = 772744, XrefRangeStart = 772742, XrefRangeEnd = 772744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAllies(Team team, Team targetTeam)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &team;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetTeam;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_IsAllies_Public_Boolean_Team_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 777188, RefRangeEnd = 777198, XrefRangeStart = 777186, XrefRangeEnd = 777188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Modifiable ApplyModification<ValueType, Modifiable>(
      Modifiable modifiable,
      out ModificationId modificationId,
      Entity applier,
      Entity target,
      ModificationType modType,
      ValueType modValue,
      int priority = 0)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      Modifiable& local1;
      if (!typeof (Modifiable).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<Modifiable> local2 = (object) modifiable;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (Modifiable&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (Modifiable&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modifiable;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationId;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &applier;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      ValueType& local3;
      if (!typeof (ValueType).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<ValueType> local4 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (ValueType&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (ValueType&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref modValue;
      *(System.IntPtr*) num = (System.IntPtr) ref local3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0<ValueType, Modifiable>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<Modifiable>(objectPointer, false, true);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 777200, RefRangeEnd = 777201, XrefRangeStart = 777198, XrefRangeEnd = 777200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ModifyModification<ValueType, Modifiable>(
      ref Modifiable modifiable,
      ModificationId modificationId,
      Entity target,
      ValueType modValue)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationId;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      ValueType& local1;
      if (!typeof (ValueType).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<ValueType> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (ValueType&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (ValueType&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0<ValueType, Modifiable>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Modifiable local3 = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<Modifiable>(objectPointer, false, false);
      local3 = (Modifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 777204, RefRangeEnd = 777214, XrefRangeStart = 777201, XrefRangeEnd = 777204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RemoveModification<Modifiable>(
      ref Modifiable modifiable,
      Entity target,
      ModificationId modificationId)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0<Modifiable>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Modifiable local = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<Modifiable>(objectPointer, false, false);
      local = (Modifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 777215, RefRangeEnd = 777221, XrefRangeStart = 777214, XrefRangeEnd = 777215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateScrollingCombatText(
      float value,
      PrefabGUID sctType,
      float3 position,
      Entity target,
      Entity source,
      PrefabGUID sourceItemType = default (PrefabGUID))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sctType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceItemType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 777222, RefRangeEnd = 777223, XrefRangeStart = 777221, XrefRangeEnd = 777222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateScrollingCombatText(
      AssetGuid text,
      PrefabGUID sctType,
      float3 position,
      Entity target,
      float3 color = default (float3),
      float value = 0.0f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &text;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sctType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_AssetGuid_PrefabGUID_float3_Entity_float3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 777224, RefRangeEnd = 777229, XrefRangeStart = 777223, XrefRangeEnd = 777224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateScrollingCombatText(
      AssetGuid text,
      float3 position,
      Entity target,
      float3 color = default (float3),
      float value = 0.0f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &text;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_AssetGuid_float3_Entity_float3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 777231, RefRangeEnd = 777245, XrefRangeStart = 777229, XrefRangeEnd = 777231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckCondition(
      SelfServer self,
      Entity owner,
      Entity entity,
      BlobAssetReference<ConditionBlob> condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameManager.NativeMethodInfoPtr_CheckCondition_Public_Boolean_SelfServer_Entity_Entity_BlobAssetReference_1_ConditionBlob_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 777246, RefRangeEnd = 777250, XrefRangeStart = 777245, XrefRangeEnd = 777246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AppendToBufferDeferred<T>(Entity entity, T element)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) element;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref element;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameManager.MethodInfoStoreGeneric_AppendToBufferDeferred_Public_Void_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerGameManager()
    {
      Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ServerGameManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr);
      ServerGameManager.NativeFieldInfoPtr_DependenciesInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (DependenciesInitialized));
      ServerGameManager.NativeFieldInfoPtr_PhysicsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (PhysicsData));
      ServerGameManager.NativeFieldInfoPtr_TileMapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (TileMapData));
      ServerGameManager.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (TileWorld));
      ServerGameManager.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (CommandBuffer));
      ServerGameManager.NativeFieldInfoPtr_DestroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (DestroyCommandBuffer));
      ServerGameManager.NativeFieldInfoPtr_SCTTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (SCTTypes));
      ServerGameManager.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (PrefabLookupMap));
      ServerGameManager.NativeFieldInfoPtr_ItemGroupHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (ItemGroupHashLookupMap));
      ServerGameManager.NativeFieldInfoPtr_SpatialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (SpatialLookup));
      ServerGameManager.NativeFieldInfoPtr__ModificationIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (_ModificationIDs));
      ServerGameManager.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (_EntityManager));
      ServerGameManager.NativeFieldInfoPtr__ItemLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, "<ItemLookupMap>k__BackingField");
      ServerGameManager.NativeFieldInfoPtr__NetworkedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (_NetworkedSequence));
      ServerGameManager.NativeFieldInfoPtr__SCTPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (_SCTPrefab));
      ServerGameManager.NativeFieldInfoPtr__TriggerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (_TriggerData));
      ServerGameManager.NativeFieldInfoPtr_ConditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (ConditionChecker));
      ServerGameManager.NativeFieldInfoPtr_GameplayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (GameplayEvents));
      ServerGameManager.NativeFieldInfoPtr_SpellModCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (SpellModCollection));
      ServerGameManager.NativeFieldInfoPtr_ModificationSourceMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (ModificationSourceMappings));
      ServerGameManager.NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (DeltaTime));
      ServerGameManager.NativeFieldInfoPtr_TimeSinceStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (TimeSinceStartup));
      ServerGameManager.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (ServerTime));
      ServerGameManager.NativeFieldInfoPtr_ServerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (ServerFrame));
      ServerGameManager.NativeFieldInfoPtr_CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (CurveCollection));
      ServerGameManager.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (Random));
      ServerGameManager.NativeFieldInfoPtr_HasDayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (HasDayNightCycle));
      ServerGameManager.NativeFieldInfoPtr_DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, nameof (DayNightCycle));
      ServerGameManager.NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668692);
      ServerGameManager.NativeMethodInfoPtr_get_ItemLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668693);
      ServerGameManager.NativeMethodInfoPtr_set_ItemLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668694);
      ServerGameManager.NativeMethodInfoPtr_get_SCTPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668695);
      ServerGameManager.NativeMethodInfoPtr_get_TriggerData_Public_get_NativeList_1_TriggerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668696);
      ServerGameManager.NativeMethodInfoPtr_SetEntityManager_Public_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668697);
      ServerGameManager.NativeMethodInfoPtr_SetConditionChecker_Public_Void_ConditionChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668698);
      ServerGameManager.NativeMethodInfoPtr_GetEntityManager_Public_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668699);
      ServerGameManager.NativeMethodInfoPtr_SetPrefabLookupMap_Public_Void_PrefabCollectionSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668700);
      ServerGameManager.NativeMethodInfoPtr_SetupModifications_Public_Void_ModificationIDs_NativeMultiHashMap_2_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668701);
      ServerGameManager.NativeMethodInfoPtr_SetTriggerData_Public_Void_NativeList_1_TriggerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668702);
      ServerGameManager.NativeMethodInfoPtr_SetItemLookupMap_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668703);
      ServerGameManager.NativeMethodInfoPtr_PlaySequenceOnTarget_Public_Void_Entity_SequenceGUID_Single_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668704);
      ServerGameManager.NativeMethodInfoPtr_PlaySequenceOnPosition_Public_Void_float3_quaternion_SequenceGUID_Single_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668705);
      ServerGameManager.NativeMethodInfoPtr_PlayImpactSequence_Public_Void_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668706);
      ServerGameManager.NativeMethodInfoPtr_AddStatChangeListener_Public_ListenerId_Entity_Entity_StatChangeCallbackDelegate_Boolean_StatChangeListenerLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668707);
      ServerGameManager.NativeMethodInfoPtr_AddGlobalDeathListener_Public_ListenerId_Entity_GlobalDeathDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668708);
      ServerGameManager.NativeMethodInfoPtr_AddOnKillListener_Public_ListenerId_Entity_Entity_OnKillDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668709);
      ServerGameManager.NativeMethodInfoPtr_AddOnDeathListener_Public_ListenerId_Entity_Entity_OnDeathDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668710);
      ServerGameManager.NativeMethodInfoPtr_AddEventListener_Public_ListenerId_Entity_GenericEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668711);
      ServerGameManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ListenerId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668712);
      ServerGameManager.NativeMethodInfoPtr_CreateEvent_Public_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668713);
      ServerGameManager.NativeMethodInfoPtr_ScheduleFunction_Public_Void_Entity_Single_ScheduledFunctionDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668714);
      ServerGameManager.NativeMethodInfoPtr_SendMessage_Public_Entity_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668715);
      ServerGameManager.NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668716);
      ServerGameManager.NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668717);
      ServerGameManager.NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668718);
      ServerGameManager.NativeMethodInfoPtr_DealHealing_Public_Void_Entity_Entity_Single_StatChangeCallbackDelegate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668719);
      ServerGameManager.NativeMethodInfoPtr_DealEnergy_Public_Void_Entity_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668720);
      ServerGameManager.NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_DealDamageParameters_Single_StatChangeCallbackDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668721);
      ServerGameManager.NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Single_Boolean_Boolean_Boolean_StatChangeCallbackDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668722);
      ServerGameManager.NativeMethodInfoPtr_DealDamage_Public_Void_Entity_Entity_EntityTypeModifiers_Single_Single_Single_Boolean_Boolean_Boolean_StatChangeCallbackDelegate_MainDamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668723);
      ServerGameManager.NativeMethodInfoPtr_VerifyComponent_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668724);
      ServerGameManager.NativeMethodInfoPtr_AddGameplayEvent_Public_Void_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668725);
      ServerGameManager.NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_EntityOwner_Entity_Entity_float3_float3_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668726);
      ServerGameManager.NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668727);
      ServerGameManager.NativeMethodInfoPtr_CreateGameplayEvent_Public_Void_GameplayEventId_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668728);
      ServerGameManager.NativeMethodInfoPtr_GetInventoryItemCount_Public_Int32_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668729);
      ServerGameManager.NativeMethodInfoPtr_TryGetInventoryItem_Public_Boolean_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668730);
      ServerGameManager.NativeMethodInfoPtr_HasFullInventory_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668731);
      ServerGameManager.NativeMethodInfoPtr_TryAddInventoryItem_Public_AddItemResponse_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668732);
      ServerGameManager.NativeMethodInfoPtr_TryAddInventoryItem_Public_AddItemResponse_Entity_PrefabGUID_Int32_Nullable_Unboxed_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668733);
      ServerGameManager.NativeMethodInfoPtr_TryRemoveInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668734);
      ServerGameManager.NativeMethodInfoPtr_TryDropInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668735);
      ServerGameManager.NativeMethodInfoPtr_TryDropRandomInventoryItem_Public_Boolean_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668736);
      ServerGameManager.NativeMethodInfoPtr_TryDropRandomInventoryItem_Public_Boolean_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668737);
      ServerGameManager.NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Void_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668738);
      ServerGameManager.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Void_Entity_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668739);
      ServerGameManager.NativeMethodInfoPtr_CreateDroppedItemEntity_Public_Void_float3_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668740);
      ServerGameManager.NativeMethodInfoPtr_InstantiateBuffEntityImmediate_Public_Entity_Entity_Entity_PrefabGUID_OnSpawnedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668741);
      ServerGameManager.NativeMethodInfoPtr_TryInstantiateBuffEntityImmediate_Public_Boolean_Entity_Entity_PrefabGUID_OnSpawnedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668742);
      ServerGameManager.NativeMethodInfoPtr_TryInstantiateBuffEntityImmediate_Public_Boolean_Entity_Entity_PrefabGUID_byref_Entity_OnSpawnedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668743);
      ServerGameManager.NativeMethodInfoPtr_CreateKnockback_Public_Void_Entity_Entity_float3_Single_Single_byref_KnockbackPower_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668744);
      ServerGameManager.NativeMethodInfoPtr_AddComponentData_Public_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668745);
      ServerGameManager.NativeMethodInfoPtr_RemoveComponent_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668746);
      ServerGameManager.NativeMethodInfoPtr_GetList_Public_DataList_1_T_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668747);
      ServerGameManager.NativeMethodInfoPtr_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668748);
      ServerGameManager.NativeMethodInfoPtr_GetBuffer_Public_DynamicBuffer_1_T_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668749);
      ServerGameManager.NativeMethodInfoPtr_TryAddToBuffer_Public_Boolean_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668750);
      ServerGameManager.NativeMethodInfoPtr_TryAddToBufferUnique_Public_Boolean_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668751);
      ServerGameManager.NativeMethodInfoPtr_GetComponent_Public_T_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668752);
      ServerGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668753);
      ServerGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668754);
      ServerGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668755);
      ServerGameManager.NativeMethodInfoPtr_HasComponent_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668756);
      ServerGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668757);
      ServerGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668758);
      ServerGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668759);
      ServerGameManager.NativeMethodInfoPtr_SetComponentImmediate_Public_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668760);
      ServerGameManager.NativeMethodInfoPtr_SetComponentDeferred_Public_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668761);
      ServerGameManager.NativeMethodInfoPtr_AddComponentDeferred_Public_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668762);
      ServerGameManager.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Entity_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668763);
      ServerGameManager.NativeMethodInfoPtr_TryGetRequiredComponent_Public_Boolean_Entity_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668764);
      ServerGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668765);
      ServerGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668766);
      ServerGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668767);
      ServerGameManager.NativeMethodInfoPtr_HasSingleton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668768);
      ServerGameManager.NativeMethodInfoPtr_GetSingleton_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668769);
      ServerGameManager.NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668770);
      ServerGameManager.NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668771);
      ServerGameManager.NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668772);
      ServerGameManager.NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668773);
      ServerGameManager.NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668774);
      ServerGameManager.NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668775);
      ServerGameManager.NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668776);
      ServerGameManager.NativeMethodInfoPtr_Destroy_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668777);
      ServerGameManager.NativeMethodInfoPtr_DestroyImmediate_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668778);
      ServerGameManager.NativeMethodInfoPtr_GetDebugName_Public_String_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668779);
      ServerGameManager.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668780);
      ServerGameManager.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668781);
      ServerGameManager.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668782);
      ServerGameManager.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668783);
      ServerGameManager.NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668784);
      ServerGameManager.NativeMethodInfoPtr_GetOwnerOrSelf_Private_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668785);
      ServerGameManager.NativeMethodInfoPtr_GetOwner_Public_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668786);
      ServerGameManager.NativeMethodInfoPtr_HasOwner_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668787);
      ServerGameManager.NativeMethodInfoPtr_TryGetOwner_Public_Boolean_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668788);
      ServerGameManager.NativeMethodInfoPtr_GetInput_Public_EntityInput_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668789);
      ServerGameManager.NativeMethodInfoPtr_GetBloodMoonBuffBonus_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668790);
      ServerGameManager.NativeMethodInfoPtr_InterruptCast_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668791);
      ServerGameManager.NativeMethodInfoPtr_GetAbilityCooldown_Public_Single_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668792);
      ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCooldown_Public_Single_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668793);
      ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCooldown_Public_Single_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668794);
      ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCooldown_Internal_Private_Single_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668795);
      ServerGameManager.NativeMethodInfoPtr_SetAbilityCooldown_Public_Void_Entity_PrefabGUID_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668796);
      ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCooldown_Public_Void_Entity_PrefabGUID_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668797);
      ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCooldown_Public_Void_Entity_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668798);
      ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCooldown_Internal_Private_Void_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668799);
      ServerGameManager.NativeMethodInfoPtr_GetAbilityCharges_Public_Int32_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668800);
      ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCharges_Public_Int32_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668801);
      ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCharges_Public_Int32_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668802);
      ServerGameManager.NativeMethodInfoPtr_GetAbilityGroupCharges_Internal_Private_Int32_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668803);
      ServerGameManager.NativeMethodInfoPtr_SetAbilityCharges_Public_Void_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668804);
      ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCharges_Public_Void_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668805);
      ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCharges_Public_Void_Entity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668806);
      ServerGameManager.NativeMethodInfoPtr_SetAbilityGroupCharges_Internal_Private_Void_DynamicBuffer_1_AbilityGroupSlotBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668807);
      ServerGameManager.NativeMethodInfoPtr_ForceCastAbilityGroup_Public_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668808);
      ServerGameManager.NativeMethodInfoPtr_ForceCastAbilityGroup_Public_Void_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668809);
      ServerGameManager.NativeMethodInfoPtr_ModifyAbilityGroupOnSlot_Public_ModificationId_Entity_Entity_Int32_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668810);
      ServerGameManager.NativeMethodInfoPtr_RemoveAbilityGroupModificationOnSlot_Public_Void_Entity_Int32_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668811);
      ServerGameManager.NativeMethodInfoPtr_IsAllies_Public_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668812);
      ServerGameManager.NativeMethodInfoPtr_IsAllies_Public_Boolean_Team_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668813);
      ServerGameManager.NativeMethodInfoPtr_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668814);
      ServerGameManager.NativeMethodInfoPtr_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668815);
      ServerGameManager.NativeMethodInfoPtr_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668816);
      ServerGameManager.NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668817);
      ServerGameManager.NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_AssetGuid_PrefabGUID_float3_Entity_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668818);
      ServerGameManager.NativeMethodInfoPtr_CreateScrollingCombatText_Public_Void_AssetGuid_float3_Entity_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668819);
      ServerGameManager.NativeMethodInfoPtr_CheckCondition_Public_Boolean_SelfServer_Entity_Entity_BlobAssetReference_1_ConditionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668820);
      ServerGameManager.NativeMethodInfoPtr_AppendToBufferDeferred_Public_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, 100668821);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_AddEventListener_Public_ListenerId_Entity_GenericEventDelegate_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_AddEventListener_Public_ListenerId_Entity_GenericEventDelegate_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CreateEvent_Public_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_CreateEvent_Public_Entity_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_VerifyComponent_Private_Boolean_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_VerifyComponent_Private_Boolean_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddComponentData_Public_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_AddComponentData_Public_Void_Entity_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RemoveComponent_Public_Void_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_RemoveComponent_Public_Void_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetList_Public_DataList_1_T_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_GetList_Public_DataList_1_T_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetBuffer_Public_DynamicBuffer_1_T_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_GetBuffer_Public_DynamicBuffer_1_T_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryAddToBuffer_Public_Boolean_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryAddToBuffer_Public_Boolean_Entity_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryAddToBufferUnique_Public_Boolean_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryAddToBufferUnique_Public_Boolean_Entity_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_GetComponent_Public_T_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponent_Public_Boolean_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_HasComponent_Public_Boolean_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetComponentImmediate_Public_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_SetComponentImmediate_Public_Void_Entity_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetComponentDeferred_Public_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_SetComponentDeferred_Public_Void_Entity_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddComponentDeferred_Public_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_AddComponentDeferred_Public_Void_Entity_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_Entity_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Entity_byref_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetRequiredComponent_Public_Boolean_Entity_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetRequiredComponent_Public_Boolean_Entity_byref_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasSingleton_Public_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_HasSingleton_Public_Boolean_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetSingleton_Public_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_GetSingleton_Public_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetSingleton_Public_Boolean_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetSingletonEntity_Public_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetSingletonEntity_Public_Boolean_byref_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasBuff_Public_Boolean_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetBuff_Public_Boolean_Entity_byref_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_byref_Entity_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0<ValueType, Modifiable>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Modifiable>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0<ValueType, Modifiable>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Modifiable>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0<Modifiable>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Modifiable>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AppendToBufferDeferred_Public_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerGameManager.NativeMethodInfoPtr_AppendToBufferDeferred_Public_Void_Entity_T_0, Il2CppClassPointerStore<ServerGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
