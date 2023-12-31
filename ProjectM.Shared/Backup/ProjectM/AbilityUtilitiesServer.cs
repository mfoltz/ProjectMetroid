// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityUtilitiesServer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class AbilityUtilitiesServer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnInitialAbilityGroupSlots_Public_Static_Void_EntityManager_Entity_NativeArray_1_AbilityGroupSlotBuffer_byref_AbilityBarInitializationState_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityGroupState_Public_Static_Boolean_BufferFromEntity_1_AbilityGroupSlotBuffer_ComponentDataFromEntity_1_AbilityGroupSlot_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityGroupState_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateAbilityExists_Public_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInstantiateAbilityGroupWithHiddenSlot_Private_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInstantiateAbilityGroup_Public_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_Boolean_byref_Entity_Int32_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 719982, RefRangeEnd = 719985, XrefRangeStart = 719962, XrefRangeEnd = 719982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnInitialAbilityGroupSlots(
      EntityManager entityManager,
      Entity abilityBarEntity,
      NativeArray<AbilityGroupSlotBuffer> abilityGroupSlots,
      ref AbilityBarInitializationState initState,
      Entity abilityGroupSlotPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityBarEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupSlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref initState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupSlotPrefab;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityUtilitiesServer.NativeMethodInfoPtr_SpawnInitialAbilityGroupSlots_Public_Static_Void_EntityManager_Entity_NativeArray_1_AbilityGroupSlotBuffer_byref_AbilityBarInitializationState_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720003, RefRangeEnd = 720004, XrefRangeStart = 719985, XrefRangeEnd = 720003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityGroupState(
      BufferFromEntity<AbilityGroupSlotBuffer> getGroupSlotBuffer,
      ComponentDataFromEntity<AbilityGroupSlot> getAbilityGroupSlot,
      Entity abilityBarEntity,
      PrefabGUID abilityGroupGuid,
      out Entity abilityGroupEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &getGroupSlotBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityBarEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityUtilitiesServer.NativeMethodInfoPtr_TryGetAbilityGroupState_Public_Static_Boolean_BufferFromEntity_1_AbilityGroupSlotBuffer_ComponentDataFromEntity_1_AbilityGroupSlot_Entity_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 720025, RefRangeEnd = 720029, XrefRangeStart = 720004, XrefRangeEnd = 720025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityGroupState(
      EntityManager entityManager,
      Entity abilityBarEntity,
      PrefabGUID abilityGroupGuid,
      out Entity abilityGroupEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityBarEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityUtilitiesServer.NativeMethodInfoPtr_TryGetAbilityGroupState_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 720051, RefRangeEnd = 720066, XrefRangeStart = 720029, XrefRangeEnd = 720051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ValidateAbilityExists(
      EntityManager entityManager,
      PrefabLookupMap prefabMap,
      Entity abilityBarEntity,
      PrefabGUID abilityGroupGuid,
      out Entity abilityGroupEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityBarEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityUtilitiesServer.NativeMethodInfoPtr_ValidateAbilityExists_Public_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720110, RefRangeEnd = 720111, XrefRangeStart = 720066, XrefRangeEnd = 720110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryInstantiateAbilityGroupWithHiddenSlot(
      EntityManager entityManager,
      PrefabLookupMap prefabMap,
      Entity abilityBarEntity,
      PrefabGUID abilityGroupGuid,
      out Entity abilityGroupEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityBarEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityUtilitiesServer.NativeMethodInfoPtr_TryInstantiateAbilityGroupWithHiddenSlot_Private_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720181, RefRangeEnd = 720182, XrefRangeStart = 720111, XrefRangeEnd = 720181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryInstantiateAbilityGroup(
      EntityManager entityManager,
      PrefabLookupMap prefabMap,
      Entity abilityBarEntity,
      PrefabGUID abilityGroupGuid,
      bool expectAbiltyGroup_LogIfMissing,
      out Entity abilityGroupEntity,
      int slotIndex = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityBarEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &expectAbiltyGroup_LogIfMissing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &slotIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityUtilitiesServer.NativeMethodInfoPtr_TryInstantiateAbilityGroup_Public_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_Boolean_byref_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityUtilitiesServer()
    {
      Il2CppClassPointerStore<AbilityUtilitiesServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityUtilitiesServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityUtilitiesServer>.NativeClassPtr);
      AbilityUtilitiesServer.NativeMethodInfoPtr_SpawnInitialAbilityGroupSlots_Public_Static_Void_EntityManager_Entity_NativeArray_1_AbilityGroupSlotBuffer_byref_AbilityBarInitializationState_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityUtilitiesServer>.NativeClassPtr, 100663643);
      AbilityUtilitiesServer.NativeMethodInfoPtr_TryGetAbilityGroupState_Public_Static_Boolean_BufferFromEntity_1_AbilityGroupSlotBuffer_ComponentDataFromEntity_1_AbilityGroupSlot_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityUtilitiesServer>.NativeClassPtr, 100663644);
      AbilityUtilitiesServer.NativeMethodInfoPtr_TryGetAbilityGroupState_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityUtilitiesServer>.NativeClassPtr, 100663645);
      AbilityUtilitiesServer.NativeMethodInfoPtr_ValidateAbilityExists_Public_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityUtilitiesServer>.NativeClassPtr, 100663646);
      AbilityUtilitiesServer.NativeMethodInfoPtr_TryInstantiateAbilityGroupWithHiddenSlot_Private_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityUtilitiesServer>.NativeClassPtr, 100663647);
      AbilityUtilitiesServer.NativeMethodInfoPtr_TryInstantiateAbilityGroup_Public_Static_Boolean_EntityManager_PrefabLookupMap_Entity_PrefabGUID_Boolean_byref_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityUtilitiesServer>.NativeClassPtr, 100663648);
    }

    public AbilityUtilitiesServer(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
