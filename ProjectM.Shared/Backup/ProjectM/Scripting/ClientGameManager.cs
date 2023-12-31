// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ClientGameManager
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
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClientGameManager
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DependenciesInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicsData;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationIDs;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationSourceMappings;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyCommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__SCTPrefab_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionChecker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SCTPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SCTPrefab_Private_set_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetEntityManager_Public_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetConditionChecker_Public_Void_ConditionChecker_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupModifications_Public_Void_ModificationIDs_NativeMultiHashMap_2_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPrefabLookupMap_Public_Void_PrefabCollectionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnEntity_Public_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequenceOneShot_Public_SequenceState_Entity_SequenceGUID_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequenceOneShot_Public_SequenceState_Entity_SequenceGUID_float3_quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_float3_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_float3_quaternion_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayImpactSequence_Public_Void_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityManager_Public_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAllies_Public_Boolean_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAllies_Public_Boolean_Team_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetList_Public_DataList_1_T_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffer_Public_DynamicBuffer_1_T_Entity_0;
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
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Entity_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSingleton_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSingleton_Public_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalCharacter_Public_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponentData_Public_Void_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveComponent_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugName_Public_String_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOwner_Public_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasOwner_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetOwner_Public_Boolean_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Public_EntityInput_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0;
    [FieldOffset(0)]
    public bool DependenciesInitialized;
    [FieldOffset(8)]
    public PhysicsData PhysicsData;
    [FieldOffset(424)]
    public ModificationIDs _ModificationIDs;
    [FieldOffset(440)]
    public NativeMultiHashMap<Entity, Entity> ModificationSourceMappings;
    [FieldOffset(456)]
    public EntityManager _EntityManager;
    [FieldOffset(464)]
    public EntityCommandBuffer DestroyCommandBuffer;
    [FieldOffset(480)]
    public EntityCommandBuffer CommandBuffer;
    [FieldOffset(496)]
    public PrefabLookupMap _PrefabLookupMap;
    [FieldOffset(544)]
    public CurveCollection CurveCollection;
    [FieldOffset(560)]
    public Entity _SCTPrefab_k__BackingField;
    [FieldOffset(568)]
    public float DeltaTime;
    [FieldOffset(576)]
    public double Time;
    [FieldOffset(584)]
    public ConditionChecker ConditionChecker;

    public unsafe ModificationIDs ModificationIDs
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationIDs*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity SCTPrefab
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_get_SCTPrefab_Public_get_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_set_SCTPrefab_Private_set_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public unsafe void SetEntityManager(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_SetEntityManager_Public_Void_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772637, XrefRangeEnd = 772638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetConditionChecker(ConditionChecker conditionChecker)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &conditionChecker;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_SetConditionChecker_Public_Void_ConditionChecker_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_SetupModifications_Public_Void_ModificationIDs_NativeMultiHashMap_2_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772638, XrefRangeEnd = 772639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPrefabLookupMap(PrefabCollectionSystem prefabCollectionSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_SetPrefabLookupMap_Public_Void_PrefabCollectionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772639, XrefRangeEnd = 772643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity SpawnEntity(PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_SpawnEntity_Public_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 772648, RefRangeEnd = 772651, XrefRangeStart = 772643, XrefRangeEnd = 772648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceState PlaySequenceOneShot(
      Entity target,
      SequenceGUID sequenceGuid,
      float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_PlaySequenceOneShot_Public_SequenceState_Entity_SequenceGUID_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772656, RefRangeEnd = 772657, XrefRangeStart = 772651, XrefRangeEnd = 772656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceState PlaySequenceOneShot(
      Entity target,
      SequenceGUID sequenceGuid,
      float3 position,
      quaternion rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_PlaySequenceOneShot_Public_SequenceState_Entity_SequenceGUID_float3_quaternion_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 772664, RefRangeEnd = 772677, XrefRangeStart = 772657, XrefRangeEnd = 772664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlaySequence(
      Entity target,
      ref SequenceState sequenceState,
      SequenceGUID sequenceGuid,
      Entity source = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 772682, RefRangeEnd = 772685, XrefRangeStart = 772677, XrefRangeEnd = 772682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlaySequence(
      Entity target,
      ref SequenceState sequenceState,
      SequenceGUID sequenceGuid,
      float3 position,
      Entity source = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_float3_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 772729, RefRangeEnd = 772733, XrefRangeStart = 772685, XrefRangeEnd = 772729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlaySequence(
      Entity target,
      ref SequenceState sequenceState,
      SequenceGUID sequenceGuid,
      float3 position,
      quaternion rotation,
      Entity source = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_float3_quaternion_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772733, XrefRangeEnd = 772734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayImpactSequence(
      PrefabGUID impactMappingGuid,
      Entity target,
      float3 position,
      quaternion rotation,
      SequenceGUID impactSequenceGuid = default (SequenceGUID),
      bool skipMaterialSequence = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &impactMappingGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &impactSequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &skipMaterialSequence;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_PlayImpactSequence_Public_Void_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe EntityManager GetEntityManager()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_GetEntityManager_Public_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityManager*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772740, RefRangeEnd = 772741, XrefRangeStart = 772734, XrefRangeEnd = 772740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAllies(Entity entity, Entity targetEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_IsAllies_Public_Boolean_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 772742, RefRangeEnd = 772744, XrefRangeStart = 772741, XrefRangeEnd = 772742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAllies(Team team, Team targetTeam)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &team;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetTeam;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_IsAllies_Public_Boolean_Team_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 772745, RefRangeEnd = 772750, XrefRangeStart = 772744, XrefRangeEnd = 772745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Exists(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_Exists_Public_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe DataList<T> GetList<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_GetList_Public_DataList_1_T_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DataList<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 772750, RefRangeEnd = 772764, XrefRangeStart = 772750, XrefRangeEnd = 772750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicBuffer<T> GetBuffer<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_GetBuffer_Public_DynamicBuffer_1_T_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(24)]
    [CachedScanResults(RefRangeStart = 772764, RefRangeEnd = 772788, XrefRangeStart = 772764, XrefRangeEnd = 772764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T GetComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_GetComponent_Public_T_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    public unsafe ValueTuple_Unboxed<T1, T2> GetComponents<T1, T2>(Entity entity)
      where T1 : unmanaged
      where T2 : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0<T1, T2>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<T1, T2>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe ValueTuple_Unboxed<T1, T2, T3> GetComponents<T1, T2, T3>(Entity entity)
      where T1 : unmanaged
      where T2 : unmanaged
      where T3 : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0<T1, T2, T3>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0<T1, T2, T3, T4>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<T1, T2, T3, T4>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(24)]
    [CachedScanResults(RefRangeStart = 772764, RefRangeEnd = 772788, XrefRangeStart = 772764, XrefRangeEnd = 772788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_HasComponent_Public_Boolean_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasComponents<T1, T2>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasComponents<T1, T2, T3>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2, T3>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasComponents<T1, T2, T3, T4>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2, T3, T4>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 772788, RefRangeEnd = 772791, XrefRangeStart = 772788, XrefRangeEnd = 772788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_SetComponentImmediate_Public_Void_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772791, RefRangeEnd = 772792, XrefRangeStart = 772791, XrefRangeEnd = 772791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_SetComponentDeferred_Public_Void_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 772811, RefRangeEnd = 772813, XrefRangeStart = 772792, XrefRangeEnd = 772811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_Entity_byref_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 772821, RefRangeEnd = 772825, XrefRangeStart = 772813, XrefRangeEnd = 772821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0<T1, T2>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 772825, RefRangeEnd = 772828, XrefRangeStart = 772825, XrefRangeEnd = 772825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0<T1, T2, T3>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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

    [CallerCount(0)]
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
      System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0<T1, T2, T3, T4>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_HasSingleton_Public_Boolean_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe T GetSingleton<T>()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_GetSingleton_Public_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_TryGetSingleton_Public_Boolean_byref_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
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

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772828, RefRangeEnd = 772829, XrefRangeStart = 772828, XrefRangeEnd = 772828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetSingletonEntity<T>()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_GetSingletonEntity_Public_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772829, XrefRangeEnd = 772832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetLocalCharacter()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_GetLocalCharacter_Public_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool TryGetSingletonEntity<T>(out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_TryGetSingletonEntity_Public_Boolean_byref_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 772834, RefRangeEnd = 772836, XrefRangeStart = 772832, XrefRangeEnd = 772834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_AddComponentData_Public_Void_Entity_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void RemoveComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_RemoveComponent_Public_Void_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 772836, RefRangeEnd = 772844, XrefRangeStart = 772836, XrefRangeEnd = 772836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBuffer<T>(Entity entity, out DynamicBuffer<T> output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref output;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasBuff<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_HasBuff_Public_Boolean_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 772845, RefRangeEnd = 772847, XrefRangeStart = 772844, XrefRangeEnd = 772845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBuff(Entity entity, PrefabGUID buffPrefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772847, XrefRangeEnd = 772848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBuff(Entity entity, PrefabGUID entityGUID, out Entity buff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_PrefabGUID_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_TryGetBuff_Public_Boolean_Entity_byref_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 772851, RefRangeEnd = 772854, XrefRangeStart = 772848, XrefRangeEnd = 772851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Destroy(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_Destroy_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772854, XrefRangeEnd = 772855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetDebugName(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_GetDebugName_Public_String_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772855, XrefRangeEnd = 772856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateEntityImmediate(Entity owner, PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772856, XrefRangeEnd = 772857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateEntityImmediate(Entity owner, Entity prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772857, XrefRangeEnd = 772858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateEntityDeferred(Entity owner, PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772858, XrefRangeEnd = 772859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity InstantiateEntityDeferred(Entity owner, Entity prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772859, XrefRangeEnd = 772860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetPrefabEntity(PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 772861, RefRangeEnd = 772874, XrefRangeStart = 772860, XrefRangeEnd = 772861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetOwner(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_GetOwner_Public_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772874, XrefRangeEnd = 772875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasOwner(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_HasOwner_Public_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772876, RefRangeEnd = 772877, XrefRangeStart = 772875, XrefRangeEnd = 772876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetOwner(Entity entity, out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_TryGetOwner_Public_Boolean_Entity_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772877, XrefRangeEnd = 772878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntityInput GetInput(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.NativeMethodInfoPtr_GetInput_Public_EntityInput_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityInput*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772880, RefRangeEnd = 772881, XrefRangeStart = 772878, XrefRangeEnd = 772880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0<ValueType, Modifiable>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<Modifiable>(objectPointer, false, true);
    }

    [CallerCount(0)]
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0<ValueType, Modifiable>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Modifiable local3 = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<Modifiable>(objectPointer, false, false);
      local3 = (Modifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 772884, RefRangeEnd = 772886, XrefRangeStart = 772881, XrefRangeEnd = 772884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientGameManager.MethodInfoStoreGeneric_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0<Modifiable>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Modifiable local = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<Modifiable>(objectPointer, false, false);
      local = (Modifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ClientGameManager()
    {
      Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ClientGameManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr);
      ClientGameManager.NativeFieldInfoPtr_DependenciesInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (DependenciesInitialized));
      ClientGameManager.NativeFieldInfoPtr_PhysicsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (PhysicsData));
      ClientGameManager.NativeFieldInfoPtr__ModificationIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (_ModificationIDs));
      ClientGameManager.NativeFieldInfoPtr_ModificationSourceMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (ModificationSourceMappings));
      ClientGameManager.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (_EntityManager));
      ClientGameManager.NativeFieldInfoPtr_DestroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (DestroyCommandBuffer));
      ClientGameManager.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (CommandBuffer));
      ClientGameManager.NativeFieldInfoPtr__PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (_PrefabLookupMap));
      ClientGameManager.NativeFieldInfoPtr_CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (CurveCollection));
      ClientGameManager.NativeFieldInfoPtr__SCTPrefab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, "<SCTPrefab>k__BackingField");
      ClientGameManager.NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (DeltaTime));
      ClientGameManager.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (Time));
      ClientGameManager.NativeFieldInfoPtr_ConditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, nameof (ConditionChecker));
      ClientGameManager.NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668424);
      ClientGameManager.NativeMethodInfoPtr_get_SCTPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668425);
      ClientGameManager.NativeMethodInfoPtr_set_SCTPrefab_Private_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668426);
      ClientGameManager.NativeMethodInfoPtr_SetEntityManager_Public_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668427);
      ClientGameManager.NativeMethodInfoPtr_SetConditionChecker_Public_Void_ConditionChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668428);
      ClientGameManager.NativeMethodInfoPtr_SetupModifications_Public_Void_ModificationIDs_NativeMultiHashMap_2_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668429);
      ClientGameManager.NativeMethodInfoPtr_SetPrefabLookupMap_Public_Void_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668430);
      ClientGameManager.NativeMethodInfoPtr_SpawnEntity_Public_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668431);
      ClientGameManager.NativeMethodInfoPtr_PlaySequenceOneShot_Public_SequenceState_Entity_SequenceGUID_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668432);
      ClientGameManager.NativeMethodInfoPtr_PlaySequenceOneShot_Public_SequenceState_Entity_SequenceGUID_float3_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668433);
      ClientGameManager.NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668434);
      ClientGameManager.NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_float3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668435);
      ClientGameManager.NativeMethodInfoPtr_PlaySequence_Public_Void_Entity_byref_SequenceState_SequenceGUID_float3_quaternion_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668436);
      ClientGameManager.NativeMethodInfoPtr_PlayImpactSequence_Public_Void_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668437);
      ClientGameManager.NativeMethodInfoPtr_GetEntityManager_Public_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668438);
      ClientGameManager.NativeMethodInfoPtr_IsAllies_Public_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668439);
      ClientGameManager.NativeMethodInfoPtr_IsAllies_Public_Boolean_Team_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668440);
      ClientGameManager.NativeMethodInfoPtr_Exists_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668441);
      ClientGameManager.NativeMethodInfoPtr_GetList_Public_DataList_1_T_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668442);
      ClientGameManager.NativeMethodInfoPtr_GetBuffer_Public_DynamicBuffer_1_T_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668443);
      ClientGameManager.NativeMethodInfoPtr_GetComponent_Public_T_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668444);
      ClientGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668445);
      ClientGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668446);
      ClientGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668447);
      ClientGameManager.NativeMethodInfoPtr_HasComponent_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668448);
      ClientGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668449);
      ClientGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668450);
      ClientGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668451);
      ClientGameManager.NativeMethodInfoPtr_SetComponentImmediate_Public_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668452);
      ClientGameManager.NativeMethodInfoPtr_SetComponentDeferred_Public_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668453);
      ClientGameManager.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Entity_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668454);
      ClientGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668455);
      ClientGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668456);
      ClientGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668457);
      ClientGameManager.NativeMethodInfoPtr_HasSingleton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668458);
      ClientGameManager.NativeMethodInfoPtr_GetSingleton_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668459);
      ClientGameManager.NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668460);
      ClientGameManager.NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668461);
      ClientGameManager.NativeMethodInfoPtr_GetLocalCharacter_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668462);
      ClientGameManager.NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668463);
      ClientGameManager.NativeMethodInfoPtr_AddComponentData_Public_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668464);
      ClientGameManager.NativeMethodInfoPtr_RemoveComponent_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668465);
      ClientGameManager.NativeMethodInfoPtr_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668466);
      ClientGameManager.NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668467);
      ClientGameManager.NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668468);
      ClientGameManager.NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668469);
      ClientGameManager.NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668470);
      ClientGameManager.NativeMethodInfoPtr_Destroy_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668471);
      ClientGameManager.NativeMethodInfoPtr_GetDebugName_Public_String_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668472);
      ClientGameManager.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668473);
      ClientGameManager.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668474);
      ClientGameManager.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668475);
      ClientGameManager.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668476);
      ClientGameManager.NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668477);
      ClientGameManager.NativeMethodInfoPtr_GetOwner_Public_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668478);
      ClientGameManager.NativeMethodInfoPtr_HasOwner_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668479);
      ClientGameManager.NativeMethodInfoPtr_TryGetOwner_Public_Boolean_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668480);
      ClientGameManager.NativeMethodInfoPtr_GetInput_Public_EntityInput_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668481);
      ClientGameManager.NativeMethodInfoPtr_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668482);
      ClientGameManager.NativeMethodInfoPtr_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668483);
      ClientGameManager.NativeMethodInfoPtr_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, 100668484);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_GetList_Public_DataList_1_T_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_GetList_Public_DataList_1_T_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetBuffer_Public_DynamicBuffer_1_T_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_GetBuffer_Public_DynamicBuffer_1_T_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_GetComponent_Public_T_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_2_T1_T2_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_3_T1_T2_T3_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_GetComponents_Public_ValueTuple_Unboxed_4_T1_T2_T3_T4_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponent_Public_Boolean_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_HasComponent_Public_Boolean_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Boolean_Entity_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_HasComponents_Public_Boolean_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetComponentImmediate_Public_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_SetComponentImmediate_Public_Void_Entity_T_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetComponentDeferred_Public_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_SetComponentDeferred_Public_Void_Entity_T_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_Entity_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Entity_byref_T_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_TryGetComponents_Public_Boolean_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasSingleton_Public_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_HasSingleton_Public_Boolean_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetSingleton_Public_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_GetSingleton_Public_T_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetSingleton_Public_Boolean_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetSingletonEntity_Public_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetSingletonEntity_Public_Boolean_byref_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddComponentData_Public_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_AddComponentData_Public_Void_Entity_T_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RemoveComponent_Public_Void_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_RemoveComponent_Public_Void_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_TryGetBuffer_Public_Boolean_Entity_byref_DynamicBuffer_1_T_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasBuff_Public_Boolean_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_HasBuff_Public_Boolean_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetBuff_Public_Boolean_Entity_byref_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_TryGetBuff_Public_Boolean_Entity_byref_Entity_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0<ValueType, Modifiable>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_ApplyModification_Public_Modifiable_Modifiable_byref_ModificationId_Entity_Entity_ModificationType_ValueType_Int32_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Modifiable>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0<ValueType, Modifiable>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_ModifyModification_Public_Boolean_byref_Modifiable_ModificationId_Entity_ValueType_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Modifiable>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0<Modifiable>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientGameManager.NativeMethodInfoPtr_RemoveModification_Public_Boolean_byref_Modifiable_Entity_ModificationId_0, Il2CppClassPointerStore<ClientGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Modifiable>.NativeClassPtr))
      }))));
    }
  }
}
