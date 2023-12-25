// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityHelpers
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Physics;

#nullable disable
namespace ProjectM
{
  public static class AbilityHelpers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentAbilityEntity_Public_Static_Entity_EntityManager_DynamicBuffer_1_AbilityStateBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNextAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviousAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Mod_Private_Static_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityEntity_Public_Static_Boolean_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityState_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Public_Static_Boolean_Entity_byref_AbilityGetters_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityGroupStateEntityWithEntityManager_Public_Static_Boolean_Entity_EntityManager_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Public_Static_Boolean_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_AbilityGetters_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityCastResult_Public_Static_TryCastResultData_EntityManager_PrefabGUID_byref_AbilityBar_Shared_byref_BuffableFlagState_byref_Entity_byref_AbilityGetters_DynamicBuffer_1_AbilityGroupSlotBuffer_Double_PrefabLookupMap_byref_CollisionWorld_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityCastResult_Public_Static_TryCastResultData_EntityManager_PrefabGUID_byref_AbilityBar_Shared_byref_AbilityBar_Client_byref_BuffableFlagState_byref_Entity_byref_AbilityGetters_DynamicBuffer_1_AbilityGroupSlotBuffer_Double_PrefabLookupMap_byref_CollisionWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGroupSlotIndexFromInputFlag_Public_Static_Boolean_InputFlag_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInputFlagFromGroupSlotIndex_Public_Static_Boolean_Int32_byref_InputFlag_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 995411, RefRangeEnd = 995414, XrefRangeStart = 995401, XrefRangeEnd = 995411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetCurrentAbilityEntity(
      EntityManager entityManager,
      DynamicBuffer<AbilityStateBuffer> abilities,
      Entity abilityGroupEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_GetCurrentAbilityEntity_Public_Static_Entity_EntityManager_DynamicBuffer_1_AbilityStateBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995424, RefRangeEnd = 995425, XrefRangeStart = 995414, XrefRangeEnd = 995424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetCurrentAbilityEntity(
      DynamicBuffer<AbilityStateBuffer> abilities,
      ComponentDataFromEntity<AbilityGroupComboState> getComboState,
      Entity abilityGroupEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &abilities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getComboState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_GetCurrentAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995425, XrefRangeEnd = 995435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetNextAbilityEntity(
      DynamicBuffer<AbilityStateBuffer> abilities,
      ComponentDataFromEntity<AbilityGroupComboState> getComboState,
      Entity abilityGroupEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &abilities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getComboState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_GetNextAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 995445, RefRangeEnd = 995447, XrefRangeStart = 995435, XrefRangeEnd = 995445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetPreviousAbilityEntity(
      DynamicBuffer<AbilityStateBuffer> abilities,
      ComponentDataFromEntity<AbilityGroupComboState> getComboState,
      Entity abilityGroupEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &abilities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getComboState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_GetPreviousAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int Mod(int x, int m)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &m;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_Mod_Private_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995447, XrefRangeEnd = 995460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityEntity(
      DynamicBuffer<AbilityStateBuffer> abilities,
      ComponentDataFromEntity<AbilityState> getAbilityState,
      PrefabGUID abilityGuid,
      out Entity abilityEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &abilities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_TryGetAbilityEntity_Public_Static_Boolean_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityState_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 995481, RefRangeEnd = 995483, XrefRangeStart = 995460, XrefRangeEnd = 995481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityGroupStateEntity(
      Entity character,
      ref AbilityGetters abilityGetters,
      PrefabGUID abilityGroupId,
      out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGetters;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Public_Static_Boolean_Entity_byref_AbilityGetters_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 995484, RefRangeEnd = 995490, XrefRangeStart = 995483, XrefRangeEnd = 995484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityGroupStateEntityWithEntityManager(
      Entity character,
      EntityManager entityManager,
      PrefabGUID abilityGroupId,
      out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntityWithEntityManager_Public_Static_Boolean_Entity_EntityManager_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995490, XrefRangeEnd = 995508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityGroupStateEntity(
      DynamicBuffer<AbilityGroupSlotBuffer> groupSlots,
      ref AbilityGetters abilityGetters,
      PrefabGUID abilityGroupId,
      out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &groupSlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGetters;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Public_Static_Boolean_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_AbilityGetters_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995724, RefRangeEnd = 995725, XrefRangeStart = 995508, XrefRangeEnd = 995724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TryCastResultData GetAbilityCastResult(
      EntityManager entityManager,
      PrefabGUID tryCastGroupGuid,
      [In] ref AbilityBar_Shared abilityBarShared,
      [In] ref BuffableFlagState buffableFlagState,
      [In] ref Entity character,
      ref AbilityGetters abilityGetters,
      DynamicBuffer<AbilityGroupSlotBuffer> abilityGroups,
      double serverTime,
      PrefabLookupMap prefabLookup,
      ref CollisionWorld collisionWorld,
      bool serverInitiatedCast)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tryCastGroupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGetters;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroups;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &serverInitiatedCast;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_GetAbilityCastResult_Public_Static_TryCastResultData_EntityManager_PrefabGUID_byref_AbilityBar_Shared_byref_BuffableFlagState_byref_Entity_byref_AbilityGetters_DynamicBuffer_1_AbilityGroupSlotBuffer_Double_PrefabLookupMap_byref_CollisionWorld_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TryCastResultData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995788, RefRangeEnd = 995789, XrefRangeStart = 995725, XrefRangeEnd = 995788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TryCastResultData GetAbilityCastResult(
      EntityManager entityManager,
      PrefabGUID tryCastGroupGuid,
      [In] ref AbilityBar_Shared abilityBarShared,
      [In] ref AbilityBar_Client abilityBarClient,
      [In] ref BuffableFlagState buffableFlagState,
      [In] ref Entity character,
      ref AbilityGetters abilityGetters,
      DynamicBuffer<AbilityGroupSlotBuffer> abilityGroups,
      double serverTime,
      PrefabLookupMap prefabLookup,
      ref CollisionWorld collisionWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tryCastGroupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarClient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGetters;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroups;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_GetAbilityCastResult_Public_Static_TryCastResultData_EntityManager_PrefabGUID_byref_AbilityBar_Shared_byref_AbilityBar_Client_byref_BuffableFlagState_byref_Entity_byref_AbilityGetters_DynamicBuffer_1_AbilityGroupSlotBuffer_Double_PrefabLookupMap_byref_CollisionWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TryCastResultData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 995789, RefRangeEnd = 995791, XrefRangeStart = 995789, XrefRangeEnd = 995789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetGroupSlotIndexFromInputFlag(
      InputFlag inputFlag,
      out int groupSlotIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inputFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref groupSlotIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_TryGetGroupSlotIndexFromInputFlag_Public_Static_Boolean_InputFlag_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 995791, RefRangeEnd = 995794, XrefRangeStart = 995791, XrefRangeEnd = 995791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInputFlagFromGroupSlotIndex(
      int groupSlotIndex,
      out InputFlag inputFlag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &groupSlotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputFlag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityHelpers.NativeMethodInfoPtr_TryGetInputFlagFromGroupSlotIndex_Public_Static_Boolean_Int32_byref_InputFlag_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityHelpers()
    {
      Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityHelpers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr);
      AbilityHelpers.NativeMethodInfoPtr_GetCurrentAbilityEntity_Public_Static_Entity_EntityManager_DynamicBuffer_1_AbilityStateBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676885);
      AbilityHelpers.NativeMethodInfoPtr_GetCurrentAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676886);
      AbilityHelpers.NativeMethodInfoPtr_GetNextAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676887);
      AbilityHelpers.NativeMethodInfoPtr_GetPreviousAbilityEntity_Public_Static_Entity_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityGroupComboState_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676888);
      AbilityHelpers.NativeMethodInfoPtr_Mod_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676889);
      AbilityHelpers.NativeMethodInfoPtr_TryGetAbilityEntity_Public_Static_Boolean_DynamicBuffer_1_AbilityStateBuffer_ComponentDataFromEntity_1_AbilityState_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676890);
      AbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Public_Static_Boolean_Entity_byref_AbilityGetters_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676891);
      AbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntityWithEntityManager_Public_Static_Boolean_Entity_EntityManager_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676892);
      AbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Public_Static_Boolean_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_AbilityGetters_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676893);
      AbilityHelpers.NativeMethodInfoPtr_GetAbilityCastResult_Public_Static_TryCastResultData_EntityManager_PrefabGUID_byref_AbilityBar_Shared_byref_BuffableFlagState_byref_Entity_byref_AbilityGetters_DynamicBuffer_1_AbilityGroupSlotBuffer_Double_PrefabLookupMap_byref_CollisionWorld_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676894);
      AbilityHelpers.NativeMethodInfoPtr_GetAbilityCastResult_Public_Static_TryCastResultData_EntityManager_PrefabGUID_byref_AbilityBar_Shared_byref_AbilityBar_Client_byref_BuffableFlagState_byref_Entity_byref_AbilityGetters_DynamicBuffer_1_AbilityGroupSlotBuffer_Double_PrefabLookupMap_byref_CollisionWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676895);
      AbilityHelpers.NativeMethodInfoPtr_TryGetGroupSlotIndexFromInputFlag_Public_Static_Boolean_InputFlag_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676896);
      AbilityHelpers.NativeMethodInfoPtr_TryGetInputFlagFromGroupSlotIndex_Public_Static_Boolean_Int32_byref_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityHelpers>.NativeClassPtr, 100676897);
    }

    public AbilityHelpers(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
