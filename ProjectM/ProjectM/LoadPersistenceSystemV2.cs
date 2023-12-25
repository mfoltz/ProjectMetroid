// Decompiled with JetBrains decompiler
// Type: ProjectM.LoadPersistenceSystemV2
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using ProjectM.Terrain;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class LoadPersistenceSystemV2 : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadedFromSaveDataQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitSomeFramesBeforeInitOnStartup;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadedBehaviourTreesQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_30;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_31;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBlobRemapping_Private_Void_HeaderData_NativeHashMap_2_Entity_Entity_byref_Dictionary_2_IntPtr_IntPtr_byref_NativeHashSet_1_SupportedBlobField_byref_NativeHashSet_1_SupportedBlobField_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlobsInNewPrefabs_Private_NativeList_1_PersistentBlobMetadata_NativeBitArray_NativeHashSet_1_SupportedBlobField_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BackupSaveBeforeLoad_Private_Void_String_String_String_GameVersion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertReferredPrefabsOnDemand_Private_Void_HeaderData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetLoadedPersistenceForTest_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLoadState_Private_Void_State_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryReadHeaderMetadata_Public_Static_Boolean_RawPersistentSaveData_Allocator_byref_PersistenceHeaderMetadata_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeHeader_Private_Static_HeaderData_PersistenceHeaderMetadata_NetBufferIn_byref_Dictionary_2_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildComponentNameLookup_Private_Static_Dictionary_2_FixedString512_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeLoadFile_Private_Void_Il2CppStructArray_1_Byte_DeserializationJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapEntities_Private_Void_DeserializationJobData_NativeHashMap_2_Entity_Entity_NativeHashMap_2_Entity_Entity_HeaderData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintRemappingFailures_Private_Void_NativeList_1_FailedRemapping_NativeHashMap_2_Entity_Entity_HeaderData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupOldToNewEntityRemappingHashMap_Private_Void_DeserializationJobData_Allocator_byref_NativeHashMap_2_Entity_Entity_byref_NativeHashMap_2_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapBlobAssets_Private_Void_DeserializationJobData_HeaderData_Dictionary_2_IntPtr_IntPtr_NativeHashSet_1_SupportedBlobField_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyDataFromPrefabs_Private_Void_DeserializationJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Debug_ValidateAllEntityDataCopied_Private_Void_DeserializationJobData_NativeHashSet_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyDataFromPrefabEntityToEntity_Private_Static_Void_EntityManager_NativeBitArray_Dictionary_2_Int32_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_HeaderData_DeserializedArchetype_Entity_Entity_PrefabGUID_NativeHashMap_2_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessExcludedComponentFields_Private_Static_Void_EntityManager_Entity_Entity_PrefabGUID_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_ComponentType_byref_TypeInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDataOnLoadedEntityComponent_Private_Static_Void_EntityManager_Entity_Entity_PrefabGUID_NativeHashMap_2_Entity_Entity_ComponentType_byref_TypeInfo_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleExcludedField_Private_Static_Void_ptr_Byte_ptr_Byte_FieldWithAttribute_1_ExcludeFieldAttribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeWorldData_Private_Void_RawPersistentSaveData_byref_NativeArray_1_Int32_byref_NonPersistentEntityDebugData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSystemData_Private_Void_RawPersistentSaveData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugAndValidateData_Private_Void_DeserializationJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapAIBlackboards_Private_Void_NativeHashMap_2_Entity_Entity_NativeArray_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe bool Initialized
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055565, XrefRangeEnd = 1055601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LoadPersistenceSystemV2.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055601, XrefRangeEnd = 1055817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LoadPersistenceSystemV2.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1055984, RefRangeEnd = 1055985, XrefRangeStart = 1055817, XrefRangeEnd = 1055984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupBlobRemapping(
      DeserializationJobData.HeaderData headerData,
      NativeHashMap<Entity, Entity> fromNewToOldEntity,
      out Dictionary<System.IntPtr, System.IntPtr> oldBlobAssetsToNewBlobAssets,
      out NativeHashSet<PersistenceV2Utility.SupportedBlobField> supportedBlobSourceFields,
      out NativeHashSet<PersistenceV2Utility.SupportedBlobField> supportedRemappableBlobFields)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) headerData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromNewToOldEntity;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref supportedBlobSourceFields;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref supportedRemappableBlobFields;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_SetupBlobRemapping_Private_Void_HeaderData_NativeHashMap_2_Entity_Entity_byref_Dictionary_2_IntPtr_IntPtr_byref_NativeHashSet_1_SupportedBlobField_byref_NativeHashSet_1_SupportedBlobField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Dictionary<System.IntPtr, System.IntPtr> local = ref oldBlobAssetsToNewBlobAssets;
      System.IntPtr pointer = zero;
      Dictionary<,> dictionary = pointer == System.IntPtr.Zero ? (Dictionary<,>) null : new Dictionary<,>(pointer);
      local = (Dictionary<System.IntPtr, System.IntPtr>) dictionary;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055985, XrefRangeEnd = 1055994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<PersistentBlobMetadata> GetBlobsInNewPrefabs(
      NativeBitArray excludedComponentTypes,
      NativeHashSet<PersistenceV2Utility.SupportedBlobField> remappableBlobFields,
      Allocator allocator)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &excludedComponentTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &remappableBlobFields;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_GetBlobsInNewPrefabs_Private_NativeList_1_PersistentBlobMetadata_NativeBitArray_NativeHashSet_1_SupportedBlobField_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<PersistentBlobMetadata>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056044, RefRangeEnd = 1056045, XrefRangeStart = 1055994, XrefRangeEnd = 1056044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BackupSaveBeforeLoad(
      string saveRootPath,
      string saveInstanceName,
      string saveInstancePath,
      GameVersion oldVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveRootPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveInstanceName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveInstancePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &oldVersion;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_BackupSaveBeforeLoad_Private_Void_String_String_String_GameVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056045, XrefRangeEnd = 1056051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertReferredPrefabsOnDemand(DeserializationJobData.HeaderData header)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) header);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_ConvertReferredPrefabsOnDemand_Private_Void_HeaderData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056074, RefRangeEnd = 1056075, XrefRangeStart = 1056051, XrefRangeEnd = 1056074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetLoadedPersistenceForTest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_ResetLoadedPersistenceForTest_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1056081, RefRangeEnd = 1056087, XrefRangeStart = 1056075, XrefRangeEnd = 1056081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetLoadState(ServerStartupState.State loadState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &loadState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_SetLoadState_Private_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1056097, RefRangeEnd = 1056099, XrefRangeStart = 1056087, XrefRangeEnd = 1056097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryReadHeaderMetadata(
      RawPersistentSaveData rawSaveData,
      Allocator allocator,
      out PersistenceHeaderMetadata headerMetadata,
      out NetBufferIn headerBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rawSaveData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref headerMetadata;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref headerBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_TryReadHeaderMetadata_Public_Static_Boolean_RawPersistentSaveData_Allocator_byref_PersistenceHeaderMetadata_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056314, RefRangeEnd = 1056315, XrefRangeStart = 1056099, XrefRangeEnd = 1056314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DeserializationJobData.HeaderData DeserializeHeader(
      PersistenceHeaderMetadata headerMetadata,
      NetBufferIn headerBuffer,
      out Dictionary<int, int> oldTypeIndexToNewTypeIndex)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &headerMetadata;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &headerBuffer;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_DeserializeHeader_Private_Static_HeaderData_PersistenceHeaderMetadata_NetBufferIn_byref_Dictionary_2_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Dictionary<int, int> local = ref oldTypeIndexToNewTypeIndex;
      System.IntPtr pointer1 = zero;
      Dictionary<,> dictionary = pointer1 == System.IntPtr.Zero ? (Dictionary<,>) null : new Dictionary<,>(pointer1);
      local = (Dictionary<int, int>) dictionary;
      System.IntPtr pointer2 = num2;
      return pointer2 == System.IntPtr.Zero ? (DeserializationJobData.HeaderData) null : new DeserializationJobData.HeaderData(pointer2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056344, RefRangeEnd = 1056345, XrefRangeStart = 1056315, XrefRangeEnd = 1056344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Dictionary<FixedString512, int> BuildComponentNameLookup()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_BuildComponentNameLookup_Private_Static_Dictionary_2_FixedString512_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<FixedString512, int>) null : new Dictionary<FixedString512, int>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056498, RefRangeEnd = 1056499, XrefRangeStart = 1056345, XrefRangeEnd = 1056498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeLoadFile(
      Il2CppStructArray<byte> fileData,
      DeserializationJobData deserializationJobData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fileData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deserializationJobData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_DeserializeLoadFile_Private_Void_Il2CppStructArray_1_Byte_DeserializationJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056541, RefRangeEnd = 1056542, XrefRangeStart = 1056499, XrefRangeEnd = 1056541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemapEntities(
      DeserializationJobData deserializationJobData,
      NativeHashMap<Entity, Entity> fromOldToNew,
      NativeHashMap<Entity, Entity> fromNewToOld,
      DeserializationJobData.HeaderData persistenceHeader)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deserializationJobData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromOldToNew;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromNewToOld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) persistenceHeader);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_RemapEntities_Private_Void_DeserializationJobData_NativeHashMap_2_Entity_Entity_NativeHashMap_2_Entity_Entity_HeaderData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056685, RefRangeEnd = 1056686, XrefRangeStart = 1056542, XrefRangeEnd = 1056685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintRemappingFailures(
      NativeList<SLSEntityRemapping.FailedRemapping> failedEntityRemappings,
      NativeHashMap<Entity, Entity> fromNewToOld,
      DeserializationJobData.HeaderData persistenceHeader)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &failedEntityRemappings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromNewToOld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) persistenceHeader);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_PrintRemappingFailures_Private_Void_NativeList_1_FailedRemapping_NativeHashMap_2_Entity_Entity_HeaderData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056905, RefRangeEnd = 1056906, XrefRangeStart = 1056686, XrefRangeEnd = 1056905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupOldToNewEntityRemappingHashMap(
      DeserializationJobData deserializationJobData,
      Allocator allocator,
      out NativeHashMap<Entity, Entity> fromOldToNew,
      out NativeHashMap<Entity, Entity> fromNewToOld)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deserializationJobData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromOldToNew;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromNewToOld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_SetupOldToNewEntityRemappingHashMap_Private_Void_DeserializationJobData_Allocator_byref_NativeHashMap_2_Entity_Entity_byref_NativeHashMap_2_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1056974, RefRangeEnd = 1056975, XrefRangeStart = 1056906, XrefRangeEnd = 1056974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemapBlobAssets(
      DeserializationJobData jobData,
      DeserializationJobData.HeaderData headerData,
      Dictionary<System.IntPtr, System.IntPtr> oldBlobAssetsToNewBlobAssets,
      NativeHashSet<PersistenceV2Utility.SupportedBlobField> supportedRemappableBlobFields)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jobData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) headerData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) oldBlobAssetsToNewBlobAssets);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &supportedRemappableBlobFields;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_RemapBlobAssets_Private_Void_DeserializationJobData_HeaderData_Dictionary_2_IntPtr_IntPtr_NativeHashSet_1_SupportedBlobField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057232, RefRangeEnd = 1057233, XrefRangeStart = 1056975, XrefRangeEnd = 1057232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyDataFromPrefabs(DeserializationJobData jobData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jobData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_CopyDataFromPrefabs_Private_Void_DeserializationJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057296, RefRangeEnd = 1057297, XrefRangeStart = 1057233, XrefRangeEnd = 1057296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Debug_ValidateAllEntityDataCopied(
      DeserializationJobData jobData,
      NativeHashSet<Entity> nonRemappedEntitiesHashSet)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jobData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nonRemappedEntitiesHashSet;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_Debug_ValidateAllEntityDataCopied_Private_Void_DeserializationJobData_NativeHashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057321, RefRangeEnd = 1057322, XrefRangeStart = 1057297, XrefRangeEnd = 1057321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyDataFromPrefabEntityToEntity(
      EntityManager entityManager,
      NativeBitArray currentlyExcludedComponents,
      Dictionary<int, List<PersistenceV2Utility.FieldWithAttribute<PersistenceV2.ExcludeFieldAttribute>>> excludedFieldsByComponent,
      DeserializationJobData.HeaderData headerData,
      DeserializationJobData.DeserializedArchetype deserializedArchetype,
      Entity srcEntity,
      Entity dstEntity,
      PrefabGUID prefabGUID,
      NativeHashMap<Entity, Entity> prefabRemapping)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentlyExcludedComponents;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludedFieldsByComponent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) headerData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deserializedArchetype);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &srcEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &dstEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabRemapping;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_CopyDataFromPrefabEntityToEntity_Private_Static_Void_EntityManager_NativeBitArray_Dictionary_2_Int32_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_HeaderData_DeserializedArchetype_Entity_Entity_PrefabGUID_NativeHashMap_2_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1057353, RefRangeEnd = 1057355, XrefRangeStart = 1057322, XrefRangeEnd = 1057353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ProcessExcludedComponentFields(
      EntityManager entityManager,
      Entity srcEntity,
      Entity dstEntity,
      PrefabGUID prefabGuid,
      List<PersistenceV2Utility.FieldWithAttribute<PersistenceV2.ExcludeFieldAttribute>> excludedFields,
      ComponentType componentType,
      ref TypeManager.TypeInfo typeInfo)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dstEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) excludedFields);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &componentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref typeInfo;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_ProcessExcludedComponentFields_Private_Static_Void_EntityManager_Entity_Entity_PrefabGUID_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_ComponentType_byref_TypeInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1057380, RefRangeEnd = 1057382, XrefRangeStart = 1057355, XrefRangeEnd = 1057380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetDataOnLoadedEntityComponent(
      EntityManager entityManager,
      Entity srcEntity,
      Entity dstEntity,
      PrefabGUID prefabGUID,
      NativeHashMap<Entity, Entity> prefabRemapping,
      ComponentType componentType,
      ref TypeManager.TypeInfo typeInfo,
      bool shouldCopyDataFromPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dstEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabRemapping;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &componentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref typeInfo;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &shouldCopyDataFromPrefab;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_SetDataOnLoadedEntityComponent_Private_Static_Void_EntityManager_Entity_Entity_PrefabGUID_NativeHashMap_2_Entity_Entity_ComponentType_byref_TypeInfo_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057383, RefRangeEnd = 1057384, XrefRangeStart = 1057382, XrefRangeEnd = 1057383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void HandleExcludedField(
      byte* instanceData,
      byte* prefabData,
      PersistenceV2Utility.FieldWithAttribute<PersistenceV2.ExcludeFieldAttribute> fieldWithAttribute)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) (void*) instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) prefabData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) fieldWithAttribute));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_HandleExcludedField_Private_Static_Void_ptr_Byte_ptr_Byte_FieldWithAttribute_1_ExcludeFieldAttribute_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057428, RefRangeEnd = 1057429, XrefRangeStart = 1057384, XrefRangeEnd = 1057428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeWorldData(
      RawPersistentSaveData rawSaveData,
      out NativeArray<int> existingVersionsByEntityIndex,
      out LoadPersistenceSystemV2.NonPersistentEntityDebugData debugData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rawSaveData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref existingVersionsByEntityIndex;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_DeserializeWorldData_Private_Void_RawPersistentSaveData_byref_NativeArray_1_Int32_byref_NonPersistentEntityDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LoadPersistenceSystemV2.NonPersistentEntityDebugData local = ref debugData;
      System.IntPtr pointer = zero;
      LoadPersistenceSystemV2.NonPersistentEntityDebugData persistentEntityDebugData = pointer == System.IntPtr.Zero ? (LoadPersistenceSystemV2.NonPersistentEntityDebugData) null : new LoadPersistenceSystemV2.NonPersistentEntityDebugData(pointer);
      local = persistentEntityDebugData;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057531, RefRangeEnd = 1057532, XrefRangeStart = 1057429, XrefRangeEnd = 1057531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSystemData(RawPersistentSaveData rawSaveData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rawSaveData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_DeserializeSystemData_Private_Void_RawPersistentSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DebugAndValidateData(DeserializationJobData deserializationJobData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deserializationJobData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_DebugAndValidateData_Private_Void_DeserializationJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057676, RefRangeEnd = 1057677, XrefRangeStart = 1057532, XrefRangeEnd = 1057676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemapAIBlackboards(
      NativeHashMap<Entity, Entity> fromOldToNewEntity,
      NativeArray<int> oldExistingVersionsByEntityIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromOldToNewEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oldExistingVersionsByEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr_RemapAIBlackboards_Private_Void_NativeHashMap_2_Entity_Entity_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057677, XrefRangeEnd = 1057678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LoadPersistenceSystemV2()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057678, XrefRangeEnd = 1057692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LoadPersistenceSystemV2.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LoadPersistenceSystemV2()
    {
      Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LoadPersistenceSystemV2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr);
      LoadPersistenceSystemV2.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (_Initialized));
      LoadPersistenceSystemV2.NativeFieldInfoPtr__LoadedFromSaveDataQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (_LoadedFromSaveDataQuery));
      LoadPersistenceSystemV2.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      LoadPersistenceSystemV2.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (_TerrainManager));
      LoadPersistenceSystemV2.NativeFieldInfoPtr__WaitSomeFramesBeforeInitOnStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (_WaitSomeFramesBeforeInitOnStartup));
      LoadPersistenceSystemV2.NativeFieldInfoPtr__LoadedBehaviourTreesQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (_LoadedBehaviourTreesQuery));
      LoadPersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_30));
      LoadPersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_31));
      LoadPersistenceSystemV2.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683006);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683007);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683008);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_SetupBlobRemapping_Private_Void_HeaderData_NativeHashMap_2_Entity_Entity_byref_Dictionary_2_IntPtr_IntPtr_byref_NativeHashSet_1_SupportedBlobField_byref_NativeHashSet_1_SupportedBlobField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683009);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_GetBlobsInNewPrefabs_Private_NativeList_1_PersistentBlobMetadata_NativeBitArray_NativeHashSet_1_SupportedBlobField_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683010);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_BackupSaveBeforeLoad_Private_Void_String_String_String_GameVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683011);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_ConvertReferredPrefabsOnDemand_Private_Void_HeaderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683012);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_ResetLoadedPersistenceForTest_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683013);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_SetLoadState_Private_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683014);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_TryReadHeaderMetadata_Public_Static_Boolean_RawPersistentSaveData_Allocator_byref_PersistenceHeaderMetadata_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683015);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_DeserializeHeader_Private_Static_HeaderData_PersistenceHeaderMetadata_NetBufferIn_byref_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683016);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_BuildComponentNameLookup_Private_Static_Dictionary_2_FixedString512_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683017);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_DeserializeLoadFile_Private_Void_Il2CppStructArray_1_Byte_DeserializationJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683018);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_RemapEntities_Private_Void_DeserializationJobData_NativeHashMap_2_Entity_Entity_NativeHashMap_2_Entity_Entity_HeaderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683019);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_PrintRemappingFailures_Private_Void_NativeList_1_FailedRemapping_NativeHashMap_2_Entity_Entity_HeaderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683020);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_SetupOldToNewEntityRemappingHashMap_Private_Void_DeserializationJobData_Allocator_byref_NativeHashMap_2_Entity_Entity_byref_NativeHashMap_2_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683021);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_RemapBlobAssets_Private_Void_DeserializationJobData_HeaderData_Dictionary_2_IntPtr_IntPtr_NativeHashSet_1_SupportedBlobField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683022);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_CopyDataFromPrefabs_Private_Void_DeserializationJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683023);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_Debug_ValidateAllEntityDataCopied_Private_Void_DeserializationJobData_NativeHashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683024);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_CopyDataFromPrefabEntityToEntity_Private_Static_Void_EntityManager_NativeBitArray_Dictionary_2_Int32_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_HeaderData_DeserializedArchetype_Entity_Entity_PrefabGUID_NativeHashMap_2_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683025);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_ProcessExcludedComponentFields_Private_Static_Void_EntityManager_Entity_Entity_PrefabGUID_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_ComponentType_byref_TypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683026);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_SetDataOnLoadedEntityComponent_Private_Static_Void_EntityManager_Entity_Entity_PrefabGUID_NativeHashMap_2_Entity_Entity_ComponentType_byref_TypeInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683027);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_HandleExcludedField_Private_Static_Void_ptr_Byte_ptr_Byte_FieldWithAttribute_1_ExcludeFieldAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683028);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_DeserializeWorldData_Private_Void_RawPersistentSaveData_byref_NativeArray_1_Int32_byref_NonPersistentEntityDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683029);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_DeserializeSystemData_Private_Void_RawPersistentSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683030);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_DebugAndValidateData_Private_Void_DeserializationJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683031);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_RemapAIBlackboards_Private_Void_NativeHashMap_2_Entity_Entity_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683032);
      LoadPersistenceSystemV2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683033);
      LoadPersistenceSystemV2.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, 100683034);
    }

    public LoadPersistenceSystemV2(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe EntityQuery _LoadedFromSaveDataQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__LoadedFromSaveDataQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__LoadedFromSaveDataQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _WaitSomeFramesBeforeInitOnStartup
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__WaitSomeFramesBeforeInitOnStartup));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__WaitSomeFramesBeforeInitOnStartup)) = value;
      }
    }

    public unsafe EntityQuery _LoadedBehaviourTreesQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__LoadedBehaviourTreesQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__LoadedBehaviourTreesQuery)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_30
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_30));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_30)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_31
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_31));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_31)) = value;
      }
    }

    public class NonPersistentEntityDebugData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NonPersistentArchetypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_OldEntityIndexToNonPersistentArchetypeIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNonPersistentArchetypeForEntity_Public_Boolean_Int32_byref_NonPersistentArchetypeData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1055545, RefRangeEnd = 1055546, XrefRangeStart = 1055541, XrefRangeEnd = 1055545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetNonPersistentArchetypeForEntity(
        int index,
        out LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData nonPersistentArchetypeData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
        numPtr1[0] = (System.IntPtr) &index;
        System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero = System.IntPtr.Zero;
        System.IntPtr* numPtr2 = &zero;
        *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeMethodInfoPtr_TryGetNonPersistentArchetypeForEntity_Public_Boolean_Int32_byref_NonPersistentArchetypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData local = ref nonPersistentArchetypeData;
        System.IntPtr pointer = zero;
        LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData persistentArchetypeData = pointer == System.IntPtr.Zero ? (LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData) null : new LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData(pointer);
        local = persistentArchetypeData;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1055558, RefRangeEnd = 1055559, XrefRangeStart = 1055546, XrefRangeEnd = 1055558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NonPersistentEntityDebugData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static NonPersistentEntityDebugData()
      {
        Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, nameof (NonPersistentEntityDebugData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData>.NativeClassPtr);
        LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeFieldInfoPtr_NonPersistentArchetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData>.NativeClassPtr, nameof (NonPersistentArchetypes));
        LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeFieldInfoPtr_OldEntityIndexToNonPersistentArchetypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData>.NativeClassPtr, nameof (OldEntityIndexToNonPersistentArchetypeIndex));
        LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeMethodInfoPtr_TryGetNonPersistentArchetypeForEntity_Public_Boolean_Int32_byref_NonPersistentArchetypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData>.NativeClassPtr, 100683035);
        LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData>.NativeClassPtr, 100683036);
      }

      public NonPersistentEntityDebugData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppReferenceArray<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData> NonPersistentArchetypes
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeFieldInfoPtr_NonPersistentArchetypes));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>) null : new Il2CppReferenceArray<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeFieldInfoPtr_NonPersistentArchetypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<int, int> OldEntityIndexToNonPersistentArchetypeIndex
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeFieldInfoPtr_OldEntityIndexToNonPersistentArchetypeIndex));
          return pointer == System.IntPtr.Zero ? (Dictionary<int, int>) null : new Dictionary<int, int>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NativeFieldInfoPtr_OldEntityIndexToNonPersistentArchetypeIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public sealed class NonPersistentArchetypeData : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_ComponentStableTypeHashes;
        private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCount;
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityCount;

        static NonPersistentArchetypeData()
        {
          Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData>.NativeClassPtr, nameof (NonPersistentArchetypeData));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>.NativeClassPtr);
          LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_ComponentStableTypeHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>.NativeClassPtr, nameof (ComponentStableTypeHashes));
          LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_ChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>.NativeClassPtr, nameof (ChunkCount));
          LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_EntityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>.NativeClassPtr, nameof (EntityCount));
        }

        public NonPersistentArchetypeData(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public NonPersistentArchetypeData()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData>.NativeClassPtr, data));
        }

        public unsafe Il2CppStructArray<ulong> ComponentStableTypeHashes
        {
          get
          {
            System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_ComponentStableTypeHashes));
            return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ulong>) null : new Il2CppStructArray<ulong>(nativeObject);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_ComponentStableTypeHashes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe int ChunkCount
        {
          get
          {
            return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_ChunkCount));
          }
          [param: In] set
          {
            *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_ChunkCount)) = value;
          }
        }

        public unsafe int EntityCount
        {
          get
          {
            return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_EntityCount));
          }
          [param: In] set
          {
            *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadPersistenceSystemV2.NonPersistentEntityDebugData.NonPersistentArchetypeData.NativeFieldInfoPtr_EntityCount)) = value;
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.LoadPersistenceSystemV2/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__21_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupOldToNewEntityRemappingHashMap_b__21_0_Internal_Int32_DeserializedArchetype_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupOldToNewEntityRemappingHashMap_b__21_1_Internal_Int32_KeyValuePair_2_PrefabGUID_OldPrefabData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055559, XrefRangeEnd = 1055563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SetupOldToNewEntityRemappingHashMap_b__21_0(
        DeserializationJobData.DeserializedArchetype x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.__c.NativeMethodInfoPtr__SetupOldToNewEntityRemappingHashMap_b__21_0_Internal_Int32_DeserializedArchetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055563, XrefRangeEnd = 1055565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SetupOldToNewEntityRemappingHashMap_b__21_1(
        KeyValuePair<PrefabGUID, DeserializationJobData.OldPrefabData> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LoadPersistenceSystemV2.__c.NativeMethodInfoPtr__SetupOldToNewEntityRemappingHashMap_b__21_1_Internal_Int32_KeyValuePair_2_PrefabGUID_OldPrefabData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadPersistenceSystemV2>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr);
        LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr, "<>9");
        LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr, "<>9__21_0");
        LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9__21_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr, "<>9__21_1");
        LoadPersistenceSystemV2.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr, 100683038);
        LoadPersistenceSystemV2.__c.NativeMethodInfoPtr__SetupOldToNewEntityRemappingHashMap_b__21_0_Internal_Int32_DeserializedArchetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr, 100683039);
        LoadPersistenceSystemV2.__c.NativeMethodInfoPtr__SetupOldToNewEntityRemappingHashMap_b__21_1_Internal_Int32_KeyValuePair_2_PrefabGUID_OldPrefabData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPersistenceSystemV2.__c>.NativeClassPtr, 100683040);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe LoadPersistenceSystemV2.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (LoadPersistenceSystemV2.__c) null : new LoadPersistenceSystemV2.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<DeserializationJobData.DeserializedArchetype, int> __9__21_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9__21_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<DeserializationJobData.DeserializedArchetype, int>) null : new Il2CppSystem.Func<DeserializationJobData.DeserializedArchetype, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9__21_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair<PrefabGUID, DeserializationJobData.OldPrefabData>, int> __9__21_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9__21_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<PrefabGUID, DeserializationJobData.OldPrefabData>, int>) null : new Il2CppSystem.Func<KeyValuePair<PrefabGUID, DeserializationJobData.OldPrefabData>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LoadPersistenceSystemV2.__c.NativeFieldInfoPtr___9__21_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
