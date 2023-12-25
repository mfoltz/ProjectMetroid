// Decompiled with JetBrains decompiler
// Type: ProjectM.SerializePersistenceSystemV2
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using ProjectM.Network;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class SerializePersistenceSystemV2 : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveFileFormatVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PersistenceDebuggingSingleton;
    private static readonly System.IntPtr NativeFieldInfoPtr__ECBSyncPointManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewPrefabsRegisteredQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PersistenceQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ExcludePersistenceQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ExcludeComponentTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr__ComponentsThatExcludeArchetypes;
    private static readonly System.IntPtr NativeFieldInfoPtr__ArchetypesWithChunkCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__ArchetypeChunks;
    private static readonly System.IntPtr NativeFieldInfoPtr__NonPersistentArchetypeChunks;
    private static readonly System.IntPtr NativeFieldInfoPtr__NonPersistentArchetypesWithChunkCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__TypesToLogErrorFor;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemoveFromArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugSerializedComponentSizes;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugSerializedBitsPerArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetBuffers;
    private static readonly System.IntPtr NativeFieldInfoPtr__SharedComponentsToSerialize;
    private static readonly System.IntPtr NativeFieldInfoPtr__HeaderWriteResult;
    private static readonly System.IntPtr NativeFieldInfoPtr__HeaderNetBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldNetBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__SystemDataNetBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__TypesWithErrors;
    private static readonly System.IntPtr NativeFieldInfoPtr__JobDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__TotalChunksToSerialize;
    private static readonly System.IntPtr NativeFieldInfoPtr__SuccessfulWritersArray;
    private static readonly System.IntPtr NativeFieldInfoPtr__FinalSaveResult;
    private static readonly System.IntPtr NativeFieldInfoPtr__TempSaveRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr__WriteToDiskDependency;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__HeaderIsDirty;
    private static readonly System.IntPtr NativeFieldInfoPtr_CHUNKSERIALIZE_JOB_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_SERIALIZE_JOB_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_WRITER_JOB_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_JOB_INDEX_HEADER_DATA;
    private static readonly System.IntPtr NativeFieldInfoPtr_JOB_INDEX_WORLD_DATA;
    private static readonly System.IntPtr NativeFieldInfoPtr_JOB_INDEX_SYSTEM_DATA;
    private static readonly System.IntPtr NativeFieldInfoPtr___BroadcastSerializeFailedErrorMessage_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BroadcastSerializeFailedErrorMessage_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SerializeHeader_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrepareArchetypeJobData_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrepareNonPersistentArchetypeJobData_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_32;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_SavePersistentDataEvent_33;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_34;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_SerializePersistenceResult_ServerRuntimeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupQueries_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BroadcastSerializeFailedErrorMessage_Private_Void_EventType_SerializePersistenceResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetInitializeState_Private_Void_State_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateSavePaths_Private_Static_Void_ServerRuntimeSettings_byref_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TriggerSave_Private_Void_SavePersistentDataEvent_ServerRuntimeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeHeader_Private_SerializePersistenceResult_ServerRuntimeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteTempFiles_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrepareArchetypeJobData_Private_Void_EntityQuery_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrepareNonPersistentArchetypeJobData_Private_Void_EntityQuery_PersistenceDebuggingSingleton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSystemData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleSerializationJobs_Private_JobHandle_String_Boolean_String_NativeBitArray_PersistenceDebuggingSingleton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeTempFilePath_Private_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupWriteToDiskJob_Private_Void_byref_WriteAndZipToDiskJob_String_DynamicNetBufferData_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeAnyActiveSaveJobsSynchronously_Internal_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompleteAndFinalizeExistingSaveOperation_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveResultBasedOnException_Private_Static_SerializePersistenceResult_Exception_SerializePersistenceResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDiskFull_Private_Static_Boolean_Exception_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintSerializationDebugData_Private_Void_String_NativeBitArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_StringBuilder_String_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForBroadcastSerializeFailedErrorMessage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059428, XrefRangeEnd = 1059449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializePersistenceSystemV2.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1059527, RefRangeEnd = 1059528, XrefRangeStart = 1059449, XrefRangeEnd = 1059527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SerializePersistenceResult Initialize(ServerRuntimeSettings saveConfig)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &saveConfig;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_Initialize_Private_SerializePersistenceResult_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SerializePersistenceResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1059608, RefRangeEnd = 1059609, XrefRangeStart = 1059528, XrefRangeEnd = 1059608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupQueries()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_SetupQueries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059609, XrefRangeEnd = 1059657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializePersistenceSystemV2.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059657, XrefRangeEnd = 1059689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializePersistenceSystemV2.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1059699, RefRangeEnd = 1059701, XrefRangeStart = 1059689, XrefRangeEnd = 1059699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BroadcastSerializeFailedErrorMessage(
      SerializePersistenceFailedFeedbackEvent.EventType eventType,
      SerializePersistenceResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &eventType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_BroadcastSerializeFailedErrorMessage_Private_Void_EventType_SerializePersistenceResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1059707, RefRangeEnd = 1059708, XrefRangeStart = 1059701, XrefRangeEnd = 1059707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetInitializeState(ServerStartupState.State initializeState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &initializeState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_SetInitializeState_Private_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059708, XrefRangeEnd = 1059721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetOrCreateSavePaths(
      ServerRuntimeSettings saveConfig,
      out string saveRoot,
      out string tempSaveRoot)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &saveConfig;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_GetOrCreateSavePaths_Private_Static_Void_ServerRuntimeSettings_byref_String_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      saveRoot = IL2CPP.Il2CppStringToManaged(zero1);
      tempSaveRoot = IL2CPP.Il2CppStringToManaged(zero2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1059834, RefRangeEnd = 1059835, XrefRangeStart = 1059721, XrefRangeEnd = 1059834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TriggerSave(
      SavePersistentDataEvent saveEvent,
      ServerRuntimeSettings saveConfig)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &saveEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &saveConfig;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_TriggerSave_Private_Void_SavePersistentDataEvent_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1059929, RefRangeEnd = 1059931, XrefRangeStart = 1059835, XrefRangeEnd = 1059929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SerializePersistenceResult SerializeHeader(ServerRuntimeSettings saveConfig)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &saveConfig;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_SerializeHeader_Private_SerializePersistenceResult_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SerializePersistenceResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1059946, RefRangeEnd = 1059948, XrefRangeStart = 1059931, XrefRangeEnd = 1059946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeleteTempFiles(string tempDir)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tempDir);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_DeleteTempFiles_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1059980, RefRangeEnd = 1059981, XrefRangeStart = 1059948, XrefRangeEnd = 1059980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrepareArchetypeJobData(EntityQuery query)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &query;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_PrepareArchetypeJobData_Private_Void_EntityQuery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1060008, RefRangeEnd = 1060009, XrefRangeStart = 1059981, XrefRangeEnd = 1060008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrepareNonPersistentArchetypeJobData(
      EntityQuery query,
      PersistenceDebuggingSingleton debuggingSingleton)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &query;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &debuggingSingleton;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_PrepareNonPersistentArchetypeJobData_Private_Void_EntityQuery_PersistenceDebuggingSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1060079, RefRangeEnd = 1060080, XrefRangeStart = 1060009, XrefRangeEnd = 1060079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSystemData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_SerializeSystemData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1060193, RefRangeEnd = 1060194, XrefRangeStart = 1060080, XrefRangeEnd = 1060193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JobHandle ScheduleSerializationJobs(
      string saveInstancePath,
      bool compressResult,
      string tempSaveInstancePath,
      NativeBitArray excludeComponentTypes,
      PersistenceDebuggingSingleton debuggingSingleton)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveInstancePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &compressResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(tempSaveInstancePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeComponentTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &debuggingSingleton;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_ScheduleSerializationJobs_Private_JobHandle_String_Boolean_String_NativeBitArray_PersistenceDebuggingSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060194, XrefRangeEnd = 1060210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetFreeTempFilePath(string tempSaveRoot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tempSaveRoot);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_GetFreeTempFilePath_Private_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1060216, RefRangeEnd = 1060217, XrefRangeStart = 1060210, XrefRangeEnd = 1060216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupWriteToDiskJob(
      ref SerializePersistenceSystemV2.WriteAndZipToDiskJob job,
      string name,
      DynamicNetBufferData netBufferData,
      bool expectMoreThanZeroBytes,
      int writerJobIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref job;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &netBufferData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &expectMoreThanZeroBytes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &writerJobIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_SetupWriteToDiskJob_Private_Void_byref_WriteAndZipToDiskJob_String_DynamicNetBufferData_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060217, XrefRangeEnd = 1060220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinalizeAnyActiveSaveJobsSynchronously(bool broadcastResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &broadcastResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_FinalizeAnyActiveSaveJobsSynchronously_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1060232, RefRangeEnd = 1060238, XrefRangeStart = 1060220, XrefRangeEnd = 1060232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CompleteAndFinalizeExistingSaveOperation(bool broadcastResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &broadcastResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_CompleteAndFinalizeExistingSaveOperation_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1060238, RefRangeEnd = 1060240, XrefRangeStart = 1060238, XrefRangeEnd = 1060238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SerializePersistenceResult GetSaveResultBasedOnException(
      Il2CppSystem.Exception e,
      SerializePersistenceResult defaultSaveResult = SerializePersistenceResult.Failed_UnknownError)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultSaveResult;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_GetSaveResultBasedOnException_Private_Static_SerializePersistenceResult_Exception_SerializePersistenceResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SerializePersistenceResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsDiskFull(Il2CppSystem.Exception ex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ex);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_IsDiskFull_Private_Static_Boolean_Exception_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1061122, RefRangeEnd = 1061123, XrefRangeStart = 1060240, XrefRangeEnd = 1061122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintSerializationDebugData(
      string saveInstancePath,
      NativeBitArray excludeComponentTypes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveInstancePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeComponentTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_PrintSerializationDebugData_Private_Void_String_NativeBitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061123, XrefRangeEnd = 1061124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SerializePersistenceSystemV2()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061124, XrefRangeEnd = 1061132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Internal_Static_Void_StringBuilder_String_PDM_0(
      StringBuilder dumpFileBuilder,
      string logText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dumpFileBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(logText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_Method_Internal_Static_Void_StringBuilder_String_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061132, XrefRangeEnd = 1061216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializePersistenceSystemV2.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061216, XrefRangeEnd = 1061235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForBroadcastSerializeFailedErrorMessage_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr___GetEntityQuery_ForBroadcastSerializeFailedErrorMessage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1061239, RefRangeEnd = 1061240, XrefRangeStart = 1061235, XrefRangeEnd = 1061239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1061244, RefRangeEnd = 1061245, XrefRangeStart = 1061240, XrefRangeEnd = 1061244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SerializePersistenceSystemV2()
    {
      Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SerializePersistenceSystemV2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr);
      SerializePersistenceSystemV2.NativeFieldInfoPtr_SaveFileFormatVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (SaveFileFormatVersion));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__PersistenceDebuggingSingleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_PersistenceDebuggingSingleton));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__ECBSyncPointManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_ECBSyncPointManager));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__NewPrefabsRegisteredQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_NewPrefabsRegisteredQuery));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__PersistenceQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_PersistenceQuery));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__ExcludePersistenceQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_ExcludePersistenceQuery));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__ExcludeComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_ExcludeComponentTypes));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__ComponentsThatExcludeArchetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_ComponentsThatExcludeArchetypes));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__ArchetypesWithChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_ArchetypesWithChunkCount));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__ArchetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_ArchetypeChunks));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__NonPersistentArchetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_NonPersistentArchetypeChunks));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__NonPersistentArchetypesWithChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_NonPersistentArchetypesWithChunkCount));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__TypesToLogErrorFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_TypesToLogErrorFor));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__RemoveFromArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_RemoveFromArchetype));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__DebugSerializedComponentSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_DebugSerializedComponentSizes));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__DebugSerializedBitsPerArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_DebugSerializedBitsPerArchetype));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__NetBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_NetBuffers));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__SharedComponentsToSerialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_SharedComponentsToSerialize));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderWriteResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_HeaderWriteResult));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderNetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_HeaderNetBuffer));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__WorldNetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_WorldNetBuffer));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__SystemDataNetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_SystemDataNetBuffer));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__TypesWithErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_TypesWithErrors));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__JobDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_JobDatas));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__TotalChunksToSerialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_TotalChunksToSerialize));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__SuccessfulWritersArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_SuccessfulWritersArray));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__FinalSaveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_FinalSaveResult));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__TempSaveRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_TempSaveRoot));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__WriteToDiskDependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_WriteToDiskDependency));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_Initialized));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderIsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_HeaderIsDirty));
      SerializePersistenceSystemV2.NativeFieldInfoPtr_CHUNKSERIALIZE_JOB_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (CHUNKSERIALIZE_JOB_COUNT));
      SerializePersistenceSystemV2.NativeFieldInfoPtr_SERIALIZE_JOB_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (SERIALIZE_JOB_COUNT));
      SerializePersistenceSystemV2.NativeFieldInfoPtr_WRITER_JOB_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (WRITER_JOB_COUNT));
      SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_HEADER_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (JOB_INDEX_HEADER_DATA));
      SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_WORLD_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (JOB_INDEX_WORLD_DATA));
      SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_SYSTEM_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (JOB_INDEX_SYSTEM_DATA));
      SerializePersistenceSystemV2.NativeFieldInfoPtr___BroadcastSerializeFailedErrorMessage_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>BroadcastSerializeFailedErrorMessage_LambdaJob0_entityQuery");
      SerializePersistenceSystemV2.NativeFieldInfoPtr___BroadcastSerializeFailedErrorMessage_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>BroadcastSerializeFailedErrorMessage_LambdaJob0_profilerMarker");
      SerializePersistenceSystemV2.NativeFieldInfoPtr___SerializeHeader_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>SerializeHeader_profilerMarker");
      SerializePersistenceSystemV2.NativeFieldInfoPtr___PrepareArchetypeJobData_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>PrepareArchetypeJobData_profilerMarker");
      SerializePersistenceSystemV2.NativeFieldInfoPtr___PrepareNonPersistentArchetypeJobData_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>PrepareNonPersistentArchetypeJobData_profilerMarker");
      SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_32));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_SavePersistentDataEvent_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_SingletonEntityQuery_SavePersistentDataEvent_33));
      SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_34));
      SerializePersistenceSystemV2.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683107);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_Initialize_Private_SerializePersistenceResult_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683108);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_SetupQueries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683109);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683110);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683111);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_BroadcastSerializeFailedErrorMessage_Private_Void_EventType_SerializePersistenceResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683112);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_SetInitializeState_Private_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683113);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_GetOrCreateSavePaths_Private_Static_Void_ServerRuntimeSettings_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683114);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_TriggerSave_Private_Void_SavePersistentDataEvent_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683115);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_SerializeHeader_Private_SerializePersistenceResult_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683116);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_DeleteTempFiles_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683117);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_PrepareArchetypeJobData_Private_Void_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683118);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_PrepareNonPersistentArchetypeJobData_Private_Void_EntityQuery_PersistenceDebuggingSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683119);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_SerializeSystemData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683120);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_ScheduleSerializationJobs_Private_JobHandle_String_Boolean_String_NativeBitArray_PersistenceDebuggingSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683121);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_GetFreeTempFilePath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683122);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_SetupWriteToDiskJob_Private_Void_byref_WriteAndZipToDiskJob_String_DynamicNetBufferData_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683123);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_FinalizeAnyActiveSaveJobsSynchronously_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683124);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_CompleteAndFinalizeExistingSaveOperation_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683125);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_GetSaveResultBasedOnException_Private_Static_SerializePersistenceResult_Exception_SerializePersistenceResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683126);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_IsDiskFull_Private_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683127);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_PrintSerializationDebugData_Private_Void_String_NativeBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683128);
      SerializePersistenceSystemV2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683129);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_Method_Internal_Static_Void_StringBuilder_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683130);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683131);
      SerializePersistenceSystemV2.NativeMethodInfoPtr___GetEntityQuery_ForBroadcastSerializeFailedErrorMessage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683132);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683133);
      SerializePersistenceSystemV2.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, 100683134);
    }

    public SerializePersistenceSystemV2(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int SaveFileFormatVersion
    {
      get
      {
        int fileFormatVersion;
        IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_SaveFileFormatVersion, (void*) &fileFormatVersion);
        return fileFormatVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_SaveFileFormatVersion, (void*) &value);
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<PersistenceDebuggingSingleton> _PersistenceDebuggingSingleton
    {
      get
      {
        return *(SingletonAccessor<PersistenceDebuggingSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__PersistenceDebuggingSingleton));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__PersistenceDebuggingSingleton), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<PersistenceDebuggingSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ECBSyncPointManager _ECBSyncPointManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ECBSyncPointManager));
        return pointer == System.IntPtr.Zero ? (ECBSyncPointManager) null : new ECBSyncPointManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ECBSyncPointManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _NewPrefabsRegisteredQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__NewPrefabsRegisteredQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__NewPrefabsRegisteredQuery)) = value;
      }
    }

    public unsafe EntityQuery _PersistenceQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__PersistenceQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__PersistenceQuery)) = value;
      }
    }

    public unsafe EntityQuery _ExcludePersistenceQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ExcludePersistenceQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ExcludePersistenceQuery)) = value;
      }
    }

    public unsafe NativeBitArray _ExcludeComponentTypes
    {
      get
      {
        return *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ExcludeComponentTypes));
      }
      [param: In] set
      {
        *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ExcludeComponentTypes)) = value;
      }
    }

    public unsafe NativeBitArray _ComponentsThatExcludeArchetypes
    {
      get
      {
        return *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ComponentsThatExcludeArchetypes));
      }
      [param: In] set
      {
        *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ComponentsThatExcludeArchetypes)) = value;
      }
    }

    public unsafe NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount> _ArchetypesWithChunkCount
    {
      get
      {
        return *(NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ArchetypesWithChunkCount));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ArchetypesWithChunkCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ArchetypeChunk> _ArchetypeChunks
    {
      get
      {
        return *(NativeList<ArchetypeChunk>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ArchetypeChunks));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__ArchetypeChunks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ArchetypeChunk>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ArchetypeChunk> _NonPersistentArchetypeChunks
    {
      get
      {
        return *(NativeList<ArchetypeChunk>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__NonPersistentArchetypeChunks));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__NonPersistentArchetypeChunks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ArchetypeChunk>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount> _NonPersistentArchetypesWithChunkCount
    {
      get
      {
        return *(NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__NonPersistentArchetypesWithChunkCount));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__NonPersistentArchetypesWithChunkCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeBitArray _TypesToLogErrorFor
    {
      get
      {
        return *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__TypesToLogErrorFor));
      }
      [param: In] set
      {
        *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__TypesToLogErrorFor)) = value;
      }
    }

    public unsafe NativeBitArray _RemoveFromArchetype
    {
      get
      {
        return *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__RemoveFromArchetype));
      }
      [param: In] set
      {
        *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__RemoveFromArchetype)) = value;
      }
    }

    public unsafe Il2CppStructArray<NativeArray<long>> _DebugSerializedComponentSizes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__DebugSerializedComponentSizes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<NativeArray<long>>) null : new Il2CppStructArray<NativeArray<long>>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__DebugSerializedComponentSizes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<NativeList<long>> _DebugSerializedBitsPerArchetype
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__DebugSerializedBitsPerArchetype));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<NativeList<long>>) null : new Il2CppStructArray<NativeList<long>>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__DebugSerializedBitsPerArchetype), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<DynamicNetBufferData> _NetBuffers
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__NetBuffers));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<DynamicNetBufferData>) null : new Il2CppStructArray<DynamicNetBufferData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__NetBuffers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize>> _SharedComponentsToSerialize
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SharedComponentsToSerialize));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize>>) null : new Il2CppStructArray<NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize>>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SharedComponentsToSerialize), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SerializePersistenceResult _HeaderWriteResult
    {
      get
      {
        return *(SerializePersistenceResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderWriteResult));
      }
      [param: In] set
      {
        *(SerializePersistenceResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderWriteResult)) = value;
      }
    }

    public unsafe DynamicNetBufferData _HeaderNetBuffer
    {
      get
      {
        return *(DynamicNetBufferData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderNetBuffer));
      }
      [param: In] set
      {
        *(DynamicNetBufferData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderNetBuffer)) = value;
      }
    }

    public unsafe DynamicNetBufferData _WorldNetBuffer
    {
      get
      {
        return *(DynamicNetBufferData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__WorldNetBuffer));
      }
      [param: In] set
      {
        *(DynamicNetBufferData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__WorldNetBuffer)) = value;
      }
    }

    public unsafe DynamicNetBufferData _SystemDataNetBuffer
    {
      get
      {
        return *(DynamicNetBufferData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SystemDataNetBuffer));
      }
      [param: In] set
      {
        *(DynamicNetBufferData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SystemDataNetBuffer)) = value;
      }
    }

    public unsafe Il2CppStructArray<NativeList<int>> _TypesWithErrors
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__TypesWithErrors));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<NativeList<int>>) null : new Il2CppStructArray<NativeList<int>>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__TypesWithErrors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeArray<SerializePersistenceSystemV2.SerializeJobData> _JobDatas
    {
      get
      {
        return *(NativeArray<SerializePersistenceSystemV2.SerializeJobData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__JobDatas));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__JobDatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SerializePersistenceSystemV2.SerializeJobData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeReference<int> _TotalChunksToSerialize
    {
      get
      {
        return *(NativeReference<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__TotalChunksToSerialize));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__TotalChunksToSerialize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<SerializePersistenceResult> _SuccessfulWritersArray
    {
      get
      {
        return *(NativeArray<SerializePersistenceResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SuccessfulWritersArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SuccessfulWritersArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SerializePersistenceResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeReference<SerializePersistenceResult> _FinalSaveResult
    {
      get
      {
        return *(NativeReference<SerializePersistenceResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__FinalSaveResult));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__FinalSaveResult), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<SerializePersistenceResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string _TempSaveRoot
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__TempSaveRoot)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__TempSaveRoot), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Nullable_Unboxed<JobHandle> _WriteToDiskDependency
    {
      get
      {
        return *(Nullable_Unboxed<JobHandle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__WriteToDiskDependency));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__WriteToDiskDependency), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<JobHandle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe bool _HeaderIsDirty
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderIsDirty));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__HeaderIsDirty)) = value;
      }
    }

    public static unsafe int CHUNKSERIALIZE_JOB_COUNT
    {
      get
      {
        int chunkserializeJobCount;
        IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_CHUNKSERIALIZE_JOB_COUNT, (void*) &chunkserializeJobCount);
        return chunkserializeJobCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_CHUNKSERIALIZE_JOB_COUNT, (void*) &value);
      }
    }

    public static unsafe int SERIALIZE_JOB_COUNT
    {
      get
      {
        int serializeJobCount;
        IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_SERIALIZE_JOB_COUNT, (void*) &serializeJobCount);
        return serializeJobCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_SERIALIZE_JOB_COUNT, (void*) &value);
      }
    }

    public static unsafe int WRITER_JOB_COUNT
    {
      get
      {
        int writerJobCount;
        IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_WRITER_JOB_COUNT, (void*) &writerJobCount);
        return writerJobCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_WRITER_JOB_COUNT, (void*) &value);
      }
    }

    public static unsafe int JOB_INDEX_HEADER_DATA
    {
      get
      {
        int jobIndexHeaderData;
        IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_HEADER_DATA, (void*) &jobIndexHeaderData);
        return jobIndexHeaderData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_HEADER_DATA, (void*) &value);
      }
    }

    public static unsafe int JOB_INDEX_WORLD_DATA
    {
      get
      {
        int jobIndexWorldData;
        IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_WORLD_DATA, (void*) &jobIndexWorldData);
        return jobIndexWorldData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_WORLD_DATA, (void*) &value);
      }
    }

    public static unsafe int JOB_INDEX_SYSTEM_DATA
    {
      get
      {
        int jobIndexSystemData;
        IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_SYSTEM_DATA, (void*) &jobIndexSystemData);
        return jobIndexSystemData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.NativeFieldInfoPtr_JOB_INDEX_SYSTEM_DATA, (void*) &value);
      }
    }

    public unsafe EntityQuery __BroadcastSerializeFailedErrorMessage_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___BroadcastSerializeFailedErrorMessage_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___BroadcastSerializeFailedErrorMessage_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __BroadcastSerializeFailedErrorMessage_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___BroadcastSerializeFailedErrorMessage_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___BroadcastSerializeFailedErrorMessage_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __SerializeHeader_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___SerializeHeader_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___SerializeHeader_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __PrepareArchetypeJobData_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___PrepareArchetypeJobData_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___PrepareArchetypeJobData_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __PrepareNonPersistentArchetypeJobData_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___PrepareNonPersistentArchetypeJobData_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr___PrepareNonPersistentArchetypeJobData_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_32
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_32));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_32)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_SavePersistentDataEvent_33
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_SavePersistentDataEvent_33));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_SavePersistentDataEvent_33)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_34
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_34));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_34)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ArchetypeWithChunkCount
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkStartIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCount;
      [FieldOffset(0)]
      public EntityArchetype EntityArchetype;
      [FieldOffset(8)]
      public int ChunkStartIndex;
      [FieldOffset(12)]
      public int ChunkCount;

      static ArchetypeWithChunkCount()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeWithChunkCount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (ArchetypeWithChunkCount));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeWithChunkCount>.NativeClassPtr);
        SerializePersistenceSystemV2.ArchetypeWithChunkCount.NativeFieldInfoPtr_EntityArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeWithChunkCount>.NativeClassPtr, nameof (EntityArchetype));
        SerializePersistenceSystemV2.ArchetypeWithChunkCount.NativeFieldInfoPtr_ChunkStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeWithChunkCount>.NativeClassPtr, nameof (ChunkStartIndex));
        SerializePersistenceSystemV2.ArchetypeWithChunkCount.NativeFieldInfoPtr_ChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeWithChunkCount>.NativeClassPtr, nameof (ChunkCount));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeWithChunkCount>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SerializeJobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FirstArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalChunkCount;
      [FieldOffset(0)]
      public int FirstArchetype;
      [FieldOffset(4)]
      public int ArchetypeCount;
      [FieldOffset(8)]
      public int TotalChunkCount;

      static SerializeJobData()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (SerializeJobData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeJobData>.NativeClassPtr);
        SerializePersistenceSystemV2.SerializeJobData.NativeFieldInfoPtr_FirstArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeJobData>.NativeClassPtr, nameof (FirstArchetype));
        SerializePersistenceSystemV2.SerializeJobData.NativeFieldInfoPtr_ArchetypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeJobData>.NativeClassPtr, nameof (ArchetypeCount));
        SerializePersistenceSystemV2.SerializeJobData.NativeFieldInfoPtr_TotalChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeJobData>.NativeClassPtr, nameof (TotalChunkCount));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeJobData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum SerializedComponentType
    {
      Buffer,
      BlittableComponent,
      ISharedComponentData,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SharedComponentToSerialize
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SharedComponentIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentType;
      [FieldOffset(0)]
      public int SharedComponentIndex;
      [FieldOffset(4)]
      public ComponentType ComponentType;

      static SharedComponentToSerialize()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.SharedComponentToSerialize>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (SharedComponentToSerialize));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.SharedComponentToSerialize>.NativeClassPtr);
        SerializePersistenceSystemV2.SharedComponentToSerialize.NativeFieldInfoPtr_SharedComponentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SharedComponentToSerialize>.NativeClassPtr, nameof (SharedComponentIndex));
        SerializePersistenceSystemV2.SharedComponentToSerialize.NativeFieldInfoPtr_ComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SharedComponentToSerialize>.NativeClassPtr, nameof (ComponentType));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.SharedComponentToSerialize>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SerializePersistentChunksJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_JobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypesWithChunkCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityTypeHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExcludeComponentTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_TypesToLogErrorFor;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemoveFromArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_TypesWithErrors;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetBufferData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SharedComponentsToSerialize;
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentsInArchetypeReused;
      private static readonly System.IntPtr NativeFieldInfoPtr_PersistentComponentsInArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_DebugSerializedBitsForArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_DebugSerializedComponentSizes;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OptimizeArchetypeComponents_Private_Void_byref_NetBufferOut_0;
      [FieldOffset(0)]
      public SerializePersistenceSystemV2.SerializeJobData JobData;
      [FieldOffset(16)]
      public NativeList<ArchetypeChunk> ArchetypeChunks;
      [FieldOffset(32)]
      public NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount> ArchetypesWithChunkCount;
      [FieldOffset(48)]
      public EntityTypeHandle EntityTypeHandle;
      [FieldOffset(56)]
      public NativeBitArray ExcludeComponentTypes;
      [FieldOffset(72)]
      public NativeBitArray TypesToLogErrorFor;
      [FieldOffset(88)]
      public NativeBitArray RemoveFromArchetype;
      [FieldOffset(104)]
      public NativeList<int> TypesWithErrors;
      [FieldOffset(120)]
      public DynamicNetBufferData NetBufferData;
      [FieldOffset(152)]
      public NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize> SharedComponentsToSerialize;
      [FieldOffset(176)]
      public NativeList<ComponentType> ComponentsInArchetypeReused;
      [FieldOffset(192)]
      public NativeList<SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo> PersistentComponentsInArchetype;
      [FieldOffset(208)]
      public NativeArray<long> DebugSerializedBitsForArchetype;
      [FieldOffset(224)]
      public NativeArray<long> DebugSerializedComponentSizes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058486, XrefRangeEnd = 1058603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1058647, RefRangeEnd = 1058648, XrefRangeStart = 1058603, XrefRangeEnd = 1058647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OptimizeArchetypeComponents(ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeMethodInfoPtr_OptimizeArchetypeComponents_Private_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SerializePersistentChunksJob()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (SerializePersistentChunksJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr);
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_JobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (JobData));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_ArchetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (ArchetypeChunks));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_ArchetypesWithChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (ArchetypesWithChunkCount));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_EntityTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (EntityTypeHandle));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_ExcludeComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (ExcludeComponentTypes));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_TypesToLogErrorFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (TypesToLogErrorFor));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_RemoveFromArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (RemoveFromArchetype));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_TypesWithErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (TypesWithErrors));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_NetBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (NetBufferData));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_SharedComponentsToSerialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (SharedComponentsToSerialize));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_ComponentsInArchetypeReused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (ComponentsInArchetypeReused));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_PersistentComponentsInArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (PersistentComponentsInArchetype));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_DebugSerializedBitsForArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (DebugSerializedBitsForArchetype));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeFieldInfoPtr_DebugSerializedComponentSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (DebugSerializedComponentSizes));
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, 100683135);
        SerializePersistenceSystemV2.SerializePersistentChunksJob.NativeMethodInfoPtr_OptimizeArchetypeComponents_Private_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, 100683136);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct ComponentInfo
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Type;
        private static readonly System.IntPtr NativeFieldInfoPtr_TypeIndexInArchetype;
        private static readonly System.IntPtr NativeFieldInfoPtr_ComponentType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ComponentSize;
        [FieldOffset(0)]
        public ComponentType Type;
        [FieldOffset(8)]
        public int TypeIndexInArchetype;
        [FieldOffset(12)]
        public SerializePersistenceSystemV2.SerializedComponentType ComponentType;
        [FieldOffset(16)]
        public int ComponentSize;

        static ComponentInfo()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob>.NativeClassPtr, nameof (ComponentInfo));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo>.NativeClassPtr);
          SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo>.NativeClassPtr, nameof (Type));
          SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo.NativeFieldInfoPtr_TypeIndexInArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo>.NativeClassPtr, nameof (TypeIndexInArchetype));
          SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo.NativeFieldInfoPtr_ComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo>.NativeClassPtr, nameof (ComponentType));
          SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo.NativeFieldInfoPtr_ComponentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo>.NativeClassPtr, nameof (ComponentSize));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializePersistentChunksJob.ComponentInfo>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SerializeWorldDataJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetBufferData;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityTypeHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_SerializeAdditionalDebugData;
      private static readonly System.IntPtr NativeFieldInfoPtr_NonPersistentArchetypesWithChunkCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_NonPersistentArchetypeChunks;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public EntityManager EntityManager;
      [FieldOffset(8)]
      public DynamicNetBufferData NetBufferData;
      [FieldOffset(40)]
      public EntityTypeHandle EntityTypeHandle;
      [FieldOffset(44)]
      public bool SerializeAdditionalDebugData;
      [FieldOffset(48)]
      public NativeArray<SerializePersistenceSystemV2.ArchetypeWithChunkCount> NonPersistentArchetypesWithChunkCount;
      [FieldOffset(64)]
      public NativeArray<ArchetypeChunk> NonPersistentArchetypeChunks;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058648, XrefRangeEnd = 1058675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.SerializeWorldDataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SerializeWorldDataJob()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (SerializeWorldDataJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr);
        SerializePersistenceSystemV2.SerializeWorldDataJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr, nameof (EntityManager));
        SerializePersistenceSystemV2.SerializeWorldDataJob.NativeFieldInfoPtr_NetBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr, nameof (NetBufferData));
        SerializePersistenceSystemV2.SerializeWorldDataJob.NativeFieldInfoPtr_EntityTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr, nameof (EntityTypeHandle));
        SerializePersistenceSystemV2.SerializeWorldDataJob.NativeFieldInfoPtr_SerializeAdditionalDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr, nameof (SerializeAdditionalDebugData));
        SerializePersistenceSystemV2.SerializeWorldDataJob.NativeFieldInfoPtr_NonPersistentArchetypesWithChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr, nameof (NonPersistentArchetypesWithChunkCount));
        SerializePersistenceSystemV2.SerializeWorldDataJob.NativeFieldInfoPtr_NonPersistentArchetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr, nameof (NonPersistentArchetypeChunks));
        SerializePersistenceSystemV2.SerializeWorldDataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr, 100683137);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeWorldDataJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SerializeSharedComponentsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SharedComponentToSerialize1;
      private static readonly System.IntPtr NativeFieldInfoPtr_SharedComponentToSerialize2;
      private static readonly System.IntPtr NativeFieldInfoPtr_SharedComponentToSerialize3;
      private static readonly System.IntPtr NativeFieldInfoPtr_SharedComponentToSerialize4;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetBufferData;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CombineSharedComponents_Private_Static_Void_NativeHashMap_2_Int32_Int32_NativeQueue_1_SharedComponentToSerialize_0;
      [FieldOffset(0)]
      public NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize> SharedComponentToSerialize1;
      [FieldOffset(24)]
      public NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize> SharedComponentToSerialize2;
      [FieldOffset(48)]
      public NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize> SharedComponentToSerialize3;
      [FieldOffset(72)]
      public NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize> SharedComponentToSerialize4;
      [FieldOffset(96)]
      public EntityManager EntityManager;
      [FieldOffset(104)]
      public DynamicNetBufferData NetBufferData;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058675, XrefRangeEnd = 1058717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1058725, RefRangeEnd = 1058729, XrefRangeStart = 1058717, XrefRangeEnd = 1058725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void CombineSharedComponents(
        NativeHashMap<int, int> combinedSharedComponentsToSerialize,
        NativeQueue<SerializePersistenceSystemV2.SharedComponentToSerialize> sharedComponentsToSerialize)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &combinedSharedComponentsToSerialize;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sharedComponentsToSerialize;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeMethodInfoPtr_CombineSharedComponents_Private_Static_Void_NativeHashMap_2_Int32_Int32_NativeQueue_1_SharedComponentToSerialize_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SerializeSharedComponentsJob()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (SerializeSharedComponentsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr);
        SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeFieldInfoPtr_SharedComponentToSerialize1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, nameof (SharedComponentToSerialize1));
        SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeFieldInfoPtr_SharedComponentToSerialize2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, nameof (SharedComponentToSerialize2));
        SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeFieldInfoPtr_SharedComponentToSerialize3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, nameof (SharedComponentToSerialize3));
        SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeFieldInfoPtr_SharedComponentToSerialize4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, nameof (SharedComponentToSerialize4));
        SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, nameof (EntityManager));
        SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeFieldInfoPtr_NetBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, nameof (NetBufferData));
        SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, 100683138);
        SerializePersistenceSystemV2.SerializeSharedComponentsJob.NativeMethodInfoPtr_CombineSharedComponents_Private_Static_Void_NativeHashMap_2_Int32_Int32_NativeQueue_1_SharedComponentToSerialize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, 100683139);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.SerializeSharedComponentsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WriteAndZipToDiskJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SuccessfulWriterJobArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_FileEntries;
      private static readonly System.IntPtr NativeFieldInfoPtr_SaveFilePath;
      private static readonly System.IntPtr NativeFieldInfoPtr_CompressResult;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetAllWriterResults_Private_Void_SerializePersistenceResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteFileEntry_Private_SerializePersistenceResult_FileEntry_Stream_Int32_0;
      [FieldOffset(0)]
      public NativeArray<SerializePersistenceResult> SuccessfulWriterJobArray;
      [FieldOffset(16)]
      public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas FileEntries;
      [FieldOffset(848)]
      public FixedString512 SaveFilePath;
      [FieldOffset(1360)]
      public bool CompressResult;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058750, XrefRangeEnd = 1058840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1058842, RefRangeEnd = 1058845, XrefRangeStart = 1058840, XrefRangeEnd = 1058842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetAllWriterResults(SerializePersistenceResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeMethodInfoPtr_SetAllWriterResults_Private_Void_SerializePersistenceResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1058885, RefRangeEnd = 1058886, XrefRangeStart = 1058845, XrefRangeEnd = 1058885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SerializePersistenceResult WriteFileEntry(
        SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry fileEntry,
        Stream targetStream,
        int entryIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &fileEntry;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetStream);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entryIndex;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeMethodInfoPtr_WriteFileEntry_Private_SerializePersistenceResult_FileEntry_Stream_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SerializePersistenceResult*) IL2CPP.il2cpp_object_unbox(num);
      }

      static WriteAndZipToDiskJob()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (WriteAndZipToDiskJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr);
        SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeFieldInfoPtr_SuccessfulWriterJobArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, nameof (SuccessfulWriterJobArray));
        SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeFieldInfoPtr_FileEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, nameof (FileEntries));
        SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeFieldInfoPtr_SaveFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, nameof (SaveFilePath));
        SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeFieldInfoPtr_CompressResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, nameof (CompressResult));
        SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, 100683140);
        SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeMethodInfoPtr_SetAllWriterResults_Private_Void_SerializePersistenceResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, 100683141);
        SerializePersistenceSystemV2.WriteAndZipToDiskJob.NativeMethodInfoPtr_WriteFileEntry_Private_SerializePersistenceResult_FileEntry_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, 100683142);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct FileEntry
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntryName;
        private static readonly System.IntPtr NativeFieldInfoPtr_NetBufferData;
        private static readonly System.IntPtr NativeFieldInfoPtr_ExpectMoreThanZeroBytes;
        private static readonly System.IntPtr NativeMethodInfoPtr_get_EntryExists_Public_get_Boolean_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FixedString64_DynamicNetBufferData_Boolean_0;
        [FieldOffset(0)]
        public FixedString64 EntryName;
        [FieldOffset(64)]
        public DynamicNetBufferData NetBufferData;
        [FieldOffset(96)]
        public bool ExpectMoreThanZeroBytes;

        public unsafe bool EntryExists
        {
          [CallerCount(3), CachedScanResults(RefRangeStart = 1058736, RefRangeEnd = 1058739, XrefRangeStart = 1058729, XrefRangeEnd = 1058736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry.NativeMethodInfoPtr_get_EntryExists_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*) IL2CPP.il2cpp_object_unbox(num);
          }
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 1058739, RefRangeEnd = 1058743, XrefRangeStart = 1058739, XrefRangeEnd = 1058739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe FileEntry(
          FixedString64 entryName,
          DynamicNetBufferData netBufferData,
          bool expectMoreThanZeroBytes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &entryName;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &netBufferData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &expectMoreThanZeroBytes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry.NativeMethodInfoPtr__ctor_Public_Void_FixedString64_DynamicNetBufferData_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static FileEntry()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, nameof (FileEntry));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry>.NativeClassPtr);
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry.NativeFieldInfoPtr_EntryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry>.NativeClassPtr, nameof (EntryName));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry.NativeFieldInfoPtr_NetBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry>.NativeClassPtr, nameof (NetBufferData));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry.NativeFieldInfoPtr_ExpectMoreThanZeroBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry>.NativeClassPtr, nameof (ExpectMoreThanZeroBytes));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry.NativeMethodInfoPtr_get_EntryExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry>.NativeClassPtr, 100683143);
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry.NativeMethodInfoPtr__ctor_Public_Void_FixedString64_DynamicNetBufferData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry>.NativeClassPtr, 100683144);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct FileEntryDatas
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Entry0;
        private static readonly System.IntPtr NativeFieldInfoPtr_Entry1;
        private static readonly System.IntPtr NativeFieldInfoPtr_Entry2;
        private static readonly System.IntPtr NativeFieldInfoPtr_Entry3;
        private static readonly System.IntPtr NativeFieldInfoPtr_Entry4;
        private static readonly System.IntPtr NativeFieldInfoPtr_Entry5;
        private static readonly System.IntPtr NativeFieldInfoPtr_Entry6;
        private static readonly System.IntPtr NativeFieldInfoPtr_Entry7;
        private static readonly System.IntPtr NativeFieldInfoPtr_MaxEntryCount;
        private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_FileEntry_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_FileEntry_0;
        [FieldOffset(0)]
        public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry Entry0;
        [FieldOffset(104)]
        public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry Entry1;
        [FieldOffset(208)]
        public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry Entry2;
        [FieldOffset(312)]
        public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry Entry3;
        [FieldOffset(416)]
        public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry Entry4;
        [FieldOffset(520)]
        public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry Entry5;
        [FieldOffset(624)]
        public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry Entry6;
        [FieldOffset(728)]
        public SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry Entry7;

        public unsafe SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry this[int index]
        {
          [CallerCount(3), CachedScanResults(RefRangeStart = 1058743, RefRangeEnd = 1058746, XrefRangeStart = 1058743, XrefRangeEnd = 1058743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) &index;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeMethodInfoPtr_get_Item_Public_get_FileEntry_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntry*) IL2CPP.il2cpp_object_unbox(num);
          }
          [CallerCount(4), CachedScanResults(RefRangeStart = 1058746, RefRangeEnd = 1058750, XrefRangeStart = 1058746, XrefRangeEnd = 1058746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) &index;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_FileEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }
        }

        static FileEntryDatas()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, nameof (FileEntryDatas));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr);
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_Entry0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (Entry0));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_Entry1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (Entry1));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_Entry2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (Entry2));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_Entry3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (Entry3));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_Entry4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (Entry4));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_Entry5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (Entry5));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_Entry6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (Entry6));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_Entry7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (Entry7));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_MaxEntryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, nameof (MaxEntryCount));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeMethodInfoPtr_get_Item_Public_get_FileEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, 100683145);
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_FileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, 100683146);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public static unsafe int MaxEntryCount
        {
          get
          {
            int maxEntryCount;
            IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_MaxEntryCount, (void*) &maxEntryCount);
            return maxEntryCount;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.WriteAndZipToDiskJob.FileEntryDatas.NativeFieldInfoPtr_MaxEntryCount, (void*) &value);
          }
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct ProfilerScope
      {
        private static readonly System.IntPtr NativeFieldInfoPtr__IsValid;
        private static readonly System.IntPtr NativeMethodInfoPtr_Sample_Public_Static_ProfilerScope_String_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
        [FieldOffset(0)]
        public bool _IsValid;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope Sample(
          string sampleName)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sampleName);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope.NativeMethodInfoPtr_Sample_Public_Static_ProfilerScope_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Dispose()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ProfilerScope()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob>.NativeClassPtr, nameof (ProfilerScope));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope>.NativeClassPtr);
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope.NativeFieldInfoPtr__IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope>.NativeClassPtr, nameof (_IsValid));
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope.NativeMethodInfoPtr_Sample_Public_Static_ProfilerScope_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope>.NativeClassPtr, 100683147);
          SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope>.NativeClassPtr, 100683148);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.WriteAndZipToDiskJob.ProfilerScope>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FinalizeWritersJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TempPath;
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetPath;
      private static readonly System.IntPtr NativeFieldInfoPtr_WriterJobsSuccessful;
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeFieldInfoPtr_JobDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalChunksToSerialize;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveCopyAndFinalizeSave_Private_SerializePersistenceResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_Boolean_Boolean_0;
      [FieldOffset(0)]
      public FixedString512 TempPath;
      [FieldOffset(512)]
      public FixedString512 TargetPath;
      [FieldOffset(1024)]
      public NativeArray<SerializePersistenceResult> WriterJobsSuccessful;
      [FieldOffset(1040)]
      public NativeReference<SerializePersistenceResult> Result;
      [FieldOffset(1056)]
      public NativeArray<SerializePersistenceSystemV2.SerializeJobData> JobDatas;
      [FieldOffset(1072)]
      public NativeReference<int> TotalChunksToSerialize;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058886, XrefRangeEnd = 1058890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.FinalizeWritersJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1058908, RefRangeEnd = 1058909, XrefRangeStart = 1058890, XrefRangeEnd = 1058908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SerializePersistenceResult MoveCopyAndFinalizeSave()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.FinalizeWritersJob.NativeMethodInfoPtr_MoveCopyAndFinalizeSave_Private_SerializePersistenceResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SerializePersistenceResult*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1058931, RefRangeEnd = 1058932, XrefRangeStart = 1058909, XrefRangeEnd = 1058931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Cleanup(bool deleteTempPath, bool deleteTargetPath)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &deleteTempPath;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deleteTargetPath;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.FinalizeWritersJob.NativeMethodInfoPtr_Cleanup_Private_Void_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FinalizeWritersJob()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (FinalizeWritersJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr);
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeFieldInfoPtr_TempPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, nameof (TempPath));
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeFieldInfoPtr_TargetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, nameof (TargetPath));
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeFieldInfoPtr_WriterJobsSuccessful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, nameof (WriterJobsSuccessful));
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, nameof (Result));
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeFieldInfoPtr_JobDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, nameof (JobDatas));
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeFieldInfoPtr_TotalChunksToSerialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, nameof (TotalChunksToSerialize));
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, 100683149);
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeMethodInfoPtr_MoveCopyAndFinalizeSave_Private_SerializePersistenceResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, 100683150);
        SerializePersistenceSystemV2.FinalizeWritersJob.NativeMethodInfoPtr_Cleanup_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, 100683151);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.FinalizeWritersJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LogErrorsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TypesWithErrors;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public NativeList<int> TypesWithErrors;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058932, XrefRangeEnd = 1058961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.LogErrorsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static LogErrorsJob()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.LogErrorsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (LogErrorsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.LogErrorsJob>.NativeClassPtr);
        SerializePersistenceSystemV2.LogErrorsJob.NativeFieldInfoPtr_TypesWithErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.LogErrorsJob>.NativeClassPtr, nameof (TypesWithErrors));
        SerializePersistenceSystemV2.LogErrorsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.LogErrorsJob>.NativeClassPtr, 100683152);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.LogErrorsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class ArchetypeDebugData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Archetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasLoadedFromPersistenceTag;
      private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeString;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_SerializedSize;

      static ArchetypeDebugData()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (ArchetypeDebugData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr);
        SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_Archetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr, nameof (Archetype));
        SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_HasLoadedFromPersistenceTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr, nameof (HasLoadedFromPersistenceTag));
        SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_ArchetypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr, nameof (ArchetypeString));
        SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_ChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr, nameof (ChunkCount));
        SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_EntityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr, nameof (EntityCount));
        SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_SerializedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr, nameof (SerializedSize));
      }

      public ArchetypeDebugData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ArchetypeDebugData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.ArchetypeDebugData>.NativeClassPtr, data));
      }

      public unsafe EntityArchetype Archetype
      {
        get
        {
          return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_Archetype));
        }
        [param: In] set
        {
          *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_Archetype)) = value;
        }
      }

      public unsafe bool HasLoadedFromPersistenceTag
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_HasLoadedFromPersistenceTag));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_HasLoadedFromPersistenceTag)) = value;
        }
      }

      public unsafe string ArchetypeString
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_ArchetypeString)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_ArchetypeString), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int ChunkCount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_ChunkCount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_ChunkCount)) = value;
        }
      }

      public unsafe int EntityCount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_EntityCount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_EntityCount)) = value;
        }
      }

      public unsafe long SerializedSize
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_SerializedSize));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.ArchetypeDebugData.NativeFieldInfoPtr_SerializedSize)) = value;
        }
      }
    }

    public sealed class DebugSerializedComponentSize : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SerializedSize;

      static DebugSerializedComponentSize()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.DebugSerializedComponentSize>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, nameof (DebugSerializedComponentSize));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.DebugSerializedComponentSize>.NativeClassPtr);
        SerializePersistenceSystemV2.DebugSerializedComponentSize.NativeFieldInfoPtr_ComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.DebugSerializedComponentSize>.NativeClassPtr, nameof (ComponentType));
        SerializePersistenceSystemV2.DebugSerializedComponentSize.NativeFieldInfoPtr_SerializedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.DebugSerializedComponentSize>.NativeClassPtr, nameof (SerializedSize));
      }

      public DebugSerializedComponentSize(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public DebugSerializedComponentSize()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializePersistenceSystemV2.DebugSerializedComponentSize>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.DebugSerializedComponentSize>.NativeClassPtr, data));
      }

      public unsafe Il2CppSystem.Type ComponentType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.DebugSerializedComponentSize.NativeFieldInfoPtr_ComponentType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.DebugSerializedComponentSize.NativeFieldInfoPtr_ComponentType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe long SerializedSize
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.DebugSerializedComponentSize.NativeFieldInfoPtr_SerializedSize));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.DebugSerializedComponentSize.NativeFieldInfoPtr_SerializedSize)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__40_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_6;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_8;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_10;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_11;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_12;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_13;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_14;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_15;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_16;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_17;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_19;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_21;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_23;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_24;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_25;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_26;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_27;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__71_28;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupQueries_b__40_0_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_1_Internal_Int64_DynamicNetBufferData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_6_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_8_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_9_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_10_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_2_Internal_Int32_ArchetypeDebugData_ArchetypeDebugData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_3_Internal_Int32_ArchetypeDebugData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_4_Internal_Int32_ArchetypeDebugData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_11_Internal_String_ArchetypeDebugData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_12_Internal_Boolean_ArchetypeDebugData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_13_Internal_String_ArchetypeDebugData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_14_Internal_Int64_ArchetypeDebugData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_15_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_16_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_17_Internal_ValueTuple_Unboxed_2_Int32_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_19_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_21_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_23_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_24_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_25_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_26_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_27_Internal_Boolean_Int64_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__71_28_Internal_Int64_DebugSerializedComponentSize_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058961, XrefRangeEnd = 1058962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _SetupQueries_b__40_0(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__SetupQueries_b__40_0_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058962, XrefRangeEnd = 1058965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe long _PrintSerializationDebugData_b__71_1(DynamicNetBufferData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_1_Internal_Int64_DynamicNetBufferData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058965, XrefRangeEnd = 1058966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_6(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_6_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_8(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_8_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_9(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_9_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_10(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_10_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058966, XrefRangeEnd = 1058967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _PrintSerializationDebugData_b__71_2(
        SerializePersistenceSystemV2.ArchetypeDebugData a,
        SerializePersistenceSystemV2.ArchetypeDebugData b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_2_Internal_Int32_ArchetypeDebugData_ArchetypeDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _PrintSerializationDebugData_b__71_3(
        SerializePersistenceSystemV2.ArchetypeDebugData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_3_Internal_Int32_ArchetypeDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _PrintSerializationDebugData_b__71_4(
        SerializePersistenceSystemV2.ArchetypeDebugData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_4_Internal_Int32_ArchetypeDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe string _PrintSerializationDebugData_b__71_11(
        SerializePersistenceSystemV2.ArchetypeDebugData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_11_Internal_String_ArchetypeDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      public unsafe bool _PrintSerializationDebugData_b__71_12(
        SerializePersistenceSystemV2.ArchetypeDebugData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_12_Internal_Boolean_ArchetypeDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe string _PrintSerializationDebugData_b__71_13(
        SerializePersistenceSystemV2.ArchetypeDebugData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_13_Internal_String_ArchetypeDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      public unsafe long _PrintSerializationDebugData_b__71_14(
        SerializePersistenceSystemV2.ArchetypeDebugData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_14_Internal_Int64_ArchetypeDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058967, XrefRangeEnd = 1058968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _PrintSerializationDebugData_b__71_15(
        KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_15_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058968, XrefRangeEnd = 1058969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _PrintSerializationDebugData_b__71_16(
        KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_16_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058969, XrefRangeEnd = 1058970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ValueTuple_Unboxed<int, int> _PrintSerializationDebugData_b__71_17(
        KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_17_Internal_ValueTuple_Unboxed_2_Int32_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ValueTuple_Unboxed<int, int>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_19(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_19_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_21(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_21_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_23(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_23_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_24(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_24_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_25(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_25_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintSerializationDebugData_b__71_26(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_26_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      public unsafe bool _PrintSerializationDebugData_b__71_27(long x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_27_Internal_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe long _PrintSerializationDebugData_b__71_28(
        SerializePersistenceSystemV2.DebugSerializedComponentSize x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_28_Internal_Int64_DebugSerializedComponentSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr);
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__40_0");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_1");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_6");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_8");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_9");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_10");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_2");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_3");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_4");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_11");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_12");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_13");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_14");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_15");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_16");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_17");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_19");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_21");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_23");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_24");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_25");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_26");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_27");
        SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, "<>9__71_28");
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683154);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__SetupQueries_b__40_0_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683155);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_1_Internal_Int64_DynamicNetBufferData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683156);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_6_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683157);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_8_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683158);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_9_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683159);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_10_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683160);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_2_Internal_Int32_ArchetypeDebugData_ArchetypeDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683161);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_3_Internal_Int32_ArchetypeDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683162);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_4_Internal_Int32_ArchetypeDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683163);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_11_Internal_String_ArchetypeDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683164);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_12_Internal_Boolean_ArchetypeDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683165);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_13_Internal_String_ArchetypeDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683166);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_14_Internal_Int64_ArchetypeDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683167);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_15_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683168);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_16_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683169);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_17_Internal_ValueTuple_Unboxed_2_Int32_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ValueTuple_Unboxed_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683170);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_19_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683171);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_21_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683172);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_23_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683173);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_24_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683174);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_25_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683175);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_26_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683176);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_27_Internal_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683177);
        SerializePersistenceSystemV2.__c.NativeMethodInfoPtr__PrintSerializationDebugData_b__71_28_Internal_Int64_DebugSerializedComponentSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c>.NativeClassPtr, 100683178);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe SerializePersistenceSystemV2.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (SerializePersistenceSystemV2.__c) null : new SerializePersistenceSystemV2.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__40_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__40_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__40_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<DynamicNetBufferData, long> __9__71_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<DynamicNetBufferData, long>) null : new Il2CppSystem.Func<DynamicNetBufferData, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_6
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_6, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_6, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_8
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_8, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_8, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_10
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_10, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_10, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<SerializePersistenceSystemV2.ArchetypeDebugData> __9__71_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<SerializePersistenceSystemV2.ArchetypeDebugData>) null : new Il2CppSystem.Comparison<SerializePersistenceSystemV2.ArchetypeDebugData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, int> __9__71_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, int>) null : new Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, int> __9__71_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, int>) null : new Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, string> __9__71_11
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_11, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, string>) null : new Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_11, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, bool> __9__71_12
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_12, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, bool>) null : new Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_12, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, string> __9__71_13
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_13, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, string>) null : new Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_13, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, long> __9__71_14
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_14, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, long>) null : new Il2CppSystem.Func<SerializePersistenceSystemV2.ArchetypeDebugData, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_14, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, int> __9__71_15
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_15, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, int>) null : new Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_15, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, int> __9__71_16
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_16, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, int>) null : new Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_16, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, ValueTuple_Unboxed<int, int>> __9__71_17
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_17, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, ValueTuple_Unboxed<int, int>>) null : new Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, ValueTuple_Unboxed<int, int>>, ValueTuple_Unboxed<int, int>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_17, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_19
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_19, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_19, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_21
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_21, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_21, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_23
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_23, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_23, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_24
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_24, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_24, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_25
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_25, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_25, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__71_26
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_26, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_26, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<long, bool> __9__71_27
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_27, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<long, bool>) null : new Il2CppSystem.Func<long, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_27, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SerializePersistenceSystemV2.DebugSerializedComponentSize, long> __9__71_28
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_28, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SerializePersistenceSystemV2.DebugSerializedComponentSize, long>) null : new Il2CppSystem.Func<SerializePersistenceSystemV2.DebugSerializedComponentSize, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c.NativeFieldInfoPtr___9__71_28, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/<>c__DisplayClass45_0")]
    public sealed class __c__DisplayClass45_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_failEvent;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BroadcastSerializeFailedErrorMessage_b__0_Internal_Void_byref_User_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass45_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _BroadcastSerializeFailedErrorMessage_b__0([In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeMethodInfoPtr__BroadcastSerializeFailedErrorMessage_b__0_Internal_Void_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass45_0()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass45_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr, "<>4__this");
        SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeFieldInfoPtr_failEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr, nameof (failEvent));
        SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr, 100683179);
        SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeMethodInfoPtr__BroadcastSerializeFailedErrorMessage_b__0_Internal_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr, 100683180);
      }

      public __c__DisplayClass45_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass45_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass45_0>.NativeClassPtr, data));
      }

      public unsafe SerializePersistenceSystemV2 __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SerializePersistenceSystemV2) null : new SerializePersistenceSystemV2(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SerializePersistenceFailedFeedbackEvent failEvent
      {
        get
        {
          return *(SerializePersistenceFailedFeedbackEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeFieldInfoPtr_failEvent));
        }
        [param: In] set
        {
          *(SerializePersistenceFailedFeedbackEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass45_0.NativeFieldInfoPtr_failEvent)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/<>c__DisplayClass49_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass49_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_netBufferData;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentPersistenceVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_applicationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_conversionMethod;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLinkedEntityGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_excludeComponentTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_removeComponentFromArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabBlobAssets;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SerializeHeader_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public DynamicNetBufferData netBufferData;
      [FieldOffset(32)]
      public GameVersion gameVersion;
      [FieldOffset(48)]
      public PersistenceVersion currentPersistenceVersion;
      [FieldOffset(52)]
      public ApplicationType applicationType;
      [FieldOffset(56)]
      public PrefabConversionMethod conversionMethod;
      [FieldOffset(64)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(112)]
      public BufferFromEntity<LinkedEntityGroup> getLinkedEntityGroup;
      [FieldOffset(152)]
      public NativeBitArray excludeComponentTypes;
      [FieldOffset(168)]
      public NativeBitArray removeComponentFromArchetype;
      [FieldOffset(184)]
      public NativeList<PersistentBlobMetadata> prefabBlobAssets;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass49_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SerializeHeader_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeMethodInfoPtr__SerializeHeader_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass49_0()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass49_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_netBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (netBufferData));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_gameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (gameVersion));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_currentPersistenceVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (currentPersistenceVersion));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_applicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (applicationType));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_conversionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (conversionMethod));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (prefabLookupMap));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_getLinkedEntityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (getLinkedEntityGroup));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_excludeComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (excludeComponentTypes));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_removeComponentFromArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (removeComponentFromArchetype));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeFieldInfoPtr_prefabBlobAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, nameof (prefabBlobAssets));
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, 100683181);
        SerializePersistenceSystemV2.__c__DisplayClass49_0.NativeMethodInfoPtr__SerializeHeader_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, 100683182);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass49_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/<>c__DisplayClass51_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass51_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypeChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_totalChunksToSerialize;
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypesWithChunkCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobDatas;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrepareArchetypeJobData_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public NativeArray<EntityArchetype> archetypes;
      [FieldOffset(16)]
      public NativeList<ArchetypeChunk> archetypeChunks;
      [FieldOffset(32)]
      public EntityManager entityManager;
      [FieldOffset(40)]
      public NativeReference<int> totalChunksToSerialize;
      [FieldOffset(56)]
      public NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount> archetypesWithChunkCount;
      [FieldOffset(72)]
      public NativeArray<SerializePersistenceSystemV2.SerializeJobData> jobDatas;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass51_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PrepareArchetypeJobData_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeMethodInfoPtr__PrepareArchetypeJobData_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass51_0()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass51_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeFieldInfoPtr_archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, nameof (archetypes));
        SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeFieldInfoPtr_archetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, nameof (archetypeChunks));
        SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, nameof (entityManager));
        SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeFieldInfoPtr_totalChunksToSerialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, nameof (totalChunksToSerialize));
        SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeFieldInfoPtr_archetypesWithChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, nameof (archetypesWithChunkCount));
        SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeFieldInfoPtr_jobDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, nameof (jobDatas));
        SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, 100683183);
        SerializePersistenceSystemV2.__c__DisplayClass51_0.NativeMethodInfoPtr__PrepareArchetypeJobData_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, 100683184);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass51_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/<>c__DisplayClass52_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass52_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypeChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypesWithChunkCount;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrepareNonPersistentArchetypeJobData_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public NativeArray<EntityArchetype> archetypes;
      [FieldOffset(16)]
      public NativeList<ArchetypeChunk> archetypeChunks;
      [FieldOffset(32)]
      public EntityManager entityManager;
      [FieldOffset(40)]
      public NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount> archetypesWithChunkCount;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass52_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PrepareNonPersistentArchetypeJobData_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass52_0.NativeMethodInfoPtr__PrepareNonPersistentArchetypeJobData_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass52_0()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass52_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass52_0.NativeFieldInfoPtr_archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr, nameof (archetypes));
        SerializePersistenceSystemV2.__c__DisplayClass52_0.NativeFieldInfoPtr_archetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr, nameof (archetypeChunks));
        SerializePersistenceSystemV2.__c__DisplayClass52_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr, nameof (entityManager));
        SerializePersistenceSystemV2.__c__DisplayClass52_0.NativeFieldInfoPtr_archetypesWithChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr, nameof (archetypesWithChunkCount));
        SerializePersistenceSystemV2.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr, 100683185);
        SerializePersistenceSystemV2.__c__DisplayClass52_0.NativeMethodInfoPtr__PrepareNonPersistentArchetypeJobData_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr, 100683186);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass52_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/<>c__DisplayClass71_0")]
    public sealed class __c__DisplayClass71_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_excludeComponentTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__7;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__18;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__20;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__22;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__5_Internal_Boolean_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__7_Internal_Boolean_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__18_Internal_Boolean_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__20_Internal_Boolean_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSerializationDebugData_b__22_Internal_Boolean_ComponentType_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass71_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058970, XrefRangeEnd = 1058971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _PrintSerializationDebugData_b__5(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__5_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058971, XrefRangeEnd = 1058972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _PrintSerializationDebugData_b__7(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__7_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058972, XrefRangeEnd = 1058974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _PrintSerializationDebugData_b__18(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__18_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058974, XrefRangeEnd = 1058975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _PrintSerializationDebugData_b__20(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__20_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058975, XrefRangeEnd = 1058976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _PrintSerializationDebugData_b__22(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__22_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass71_0()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass71_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr_excludeComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, nameof (excludeComponentTypes));
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, "<>4__this");
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, "<>9__5");
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, "<>9__7");
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, "<>9__18");
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, "<>9__20");
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, "<>9__22");
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, 100683187);
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__5_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, 100683188);
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__7_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, 100683189);
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__18_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, 100683190);
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__20_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, 100683191);
        SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeMethodInfoPtr__PrintSerializationDebugData_b__22_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass71_0>.NativeClassPtr, 100683192);
      }

      public __c__DisplayClass71_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe NativeBitArray excludeComponentTypes
      {
        get
        {
          return *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr_excludeComponentTypes));
        }
        [param: In] set
        {
          *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr_excludeComponentTypes)) = value;
        }
      }

      public unsafe SerializePersistenceSystemV2 __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SerializePersistenceSystemV2) null : new SerializePersistenceSystemV2(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<ComponentType, bool> __9__5
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__5));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<ComponentType, bool> __9__7
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__7));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<ComponentType, bool> __9__18
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__18));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__18), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<ComponentType, bool> __9__20
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__20));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__20), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Func<ComponentType, bool> __9__22
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__22));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass71_0.NativeFieldInfoPtr___9__22), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/ProjectM.<>c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0")]
    public sealed class __c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_failEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass45_0_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058984, XrefRangeEnd = 1058989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058989, XrefRangeEnd = 1058990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SerializePersistenceSystemV2.__c__DisplayClass45_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1058991, RefRangeEnd = 1058992, XrefRangeStart = 1058990, XrefRangeEnd = 1058991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SerializePersistenceSystemV2.__c__DisplayClass45_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058992, XrefRangeEnd = 1059005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059011, RefRangeEnd = 1059012, XrefRangeStart = 1059005, XrefRangeEnd = 1059011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059013, RefRangeEnd = 1059014, XrefRangeStart = 1059012, XrefRangeEnd = 1059013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SerializePersistenceSystemV2 componentSystem,
        ref SerializePersistenceSystemV2.__c__DisplayClass45_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass45_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, "<>4__this");
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr_failEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, nameof (failEvent));
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, 100683193);
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, 100683194);
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, 100683195);
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, 100683197);
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, 100683198);
        SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, 100683199);
      }

      public __c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe SerializePersistenceSystemV2 __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SerializePersistenceSystemV2) null : new SerializePersistenceSystemV2(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SerializePersistenceFailedFeedbackEvent failEvent
      {
        get
        {
          return *(SerializePersistenceFailedFeedbackEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr_failEvent));
        }
        [param: In] set
        {
          *(SerializePersistenceFailedFeedbackEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr_failEvent)) = value;
        }
      }

      public unsafe SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058976, XrefRangeEnd = 1058979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SerializePersistenceSystemV2 componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1058983, RefRangeEnd = 1058984, XrefRangeStart = 1058979, XrefRangeEnd = 1058983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100683200);
          SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100683201);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;

          static Runtimes()
          {
            Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_BroadcastSerializeFailedErrorMessage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/ProjectM.<>c__DisplayClass_SerializeHeader")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SerializeHeader
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_netBufferData;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentPersistenceVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_applicationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_conversionMethod;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLinkedEntityGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_excludeComponentTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_removeComponentFromArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabBlobAssets;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass49_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass49_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass49_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public DynamicNetBufferData netBufferData;
      [FieldOffset(32)]
      public GameVersion gameVersion;
      [FieldOffset(48)]
      public PersistenceVersion currentPersistenceVersion;
      [FieldOffset(52)]
      public ApplicationType applicationType;
      [FieldOffset(56)]
      public PrefabConversionMethod conversionMethod;
      [FieldOffset(64)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(112)]
      public BufferFromEntity<LinkedEntityGroup> getLinkedEntityGroup;
      [FieldOffset(152)]
      public NativeBitArray excludeComponentTypes;
      [FieldOffset(168)]
      public NativeBitArray removeComponentFromArchetype;
      [FieldOffset(184)]
      public NativeList<PersistentBlobMetadata> prefabBlobAssets;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059116, RefRangeEnd = 1059117, XrefRangeStart = 1059014, XrefRangeEnd = 1059116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059117, RefRangeEnd = 1059118, XrefRangeStart = 1059117, XrefRangeEnd = 1059117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SerializePersistenceSystemV2.__c__DisplayClass49_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass49_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059118, RefRangeEnd = 1059119, XrefRangeStart = 1059118, XrefRangeEnd = 1059118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SerializePersistenceSystemV2.__c__DisplayClass49_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass49_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059120, RefRangeEnd = 1059121, XrefRangeStart = 1059119, XrefRangeEnd = 1059120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059122, RefRangeEnd = 1059123, XrefRangeStart = 1059121, XrefRangeEnd = 1059122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SerializePersistenceSystemV2 componentSystem,
        ref SerializePersistenceSystemV2.__c__DisplayClass49_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass49_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059123, XrefRangeEnd = 1059124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SerializeHeader()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass_SerializeHeader");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_netBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (netBufferData));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_gameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (gameVersion));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_currentPersistenceVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (currentPersistenceVersion));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_applicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (applicationType));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_conversionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (conversionMethod));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (prefabLookupMap));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_getLinkedEntityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (getLinkedEntityGroup));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_excludeComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (excludeComponentTypes));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_removeComponentFromArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (removeComponentFromArchetype));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_prefabBlobAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (prefabBlobAssets));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, 100683202);
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass49_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, 100683203);
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass49_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, 100683204);
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, 100683205);
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass49_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, 100683206);
        SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, 100683207);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_SerializeHeader.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/ProjectM.<>c__DisplayClass_PrepareArchetypeJobData")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_PrepareArchetypeJobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypeChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_totalChunksToSerialize;
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypesWithChunkCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass51_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass51_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass51_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeArray<EntityArchetype> archetypes;
      [FieldOffset(16)]
      public NativeList<ArchetypeChunk> archetypeChunks;
      [FieldOffset(32)]
      public EntityManager entityManager;
      [FieldOffset(40)]
      public NativeReference<int> totalChunksToSerialize;
      [FieldOffset(56)]
      public NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount> archetypesWithChunkCount;
      [FieldOffset(72)]
      public NativeArray<SerializePersistenceSystemV2.SerializeJobData> jobDatas;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059199, XrefRangeEnd = 1059223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059223, RefRangeEnd = 1059224, XrefRangeStart = 1059223, XrefRangeEnd = 1059223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SerializePersistenceSystemV2.__c__DisplayClass51_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass51_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059224, RefRangeEnd = 1059225, XrefRangeStart = 1059224, XrefRangeEnd = 1059224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SerializePersistenceSystemV2.__c__DisplayClass51_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass51_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059226, RefRangeEnd = 1059227, XrefRangeStart = 1059225, XrefRangeEnd = 1059226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059228, RefRangeEnd = 1059229, XrefRangeStart = 1059227, XrefRangeEnd = 1059228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SerializePersistenceSystemV2 componentSystem,
        ref SerializePersistenceSystemV2.__c__DisplayClass51_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass51_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059229, XrefRangeEnd = 1059233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059234, RefRangeEnd = 1059235, XrefRangeStart = 1059233, XrefRangeEnd = 1059234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PrepareArchetypeJobData()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass_PrepareArchetypeJobData");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, nameof (archetypes));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_archetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, nameof (archetypeChunks));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, nameof (entityManager));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_totalChunksToSerialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, nameof (totalChunksToSerialize));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_archetypesWithChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, nameof (archetypesWithChunkCount));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_jobDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, nameof (jobDatas));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, 100683208);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass51_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, 100683209);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass51_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, 100683210);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, 100683211);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass51_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, 100683212);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, 100683213);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, 100683214);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/ProjectM.<>c__DisplayClass_PrepareArchetypeJobData/ProjectM.RunWithoutJobSystem_00004717$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, "RunWithoutJobSystem_00004717$PostfixBurstDelegate");
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100683215);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100683216);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100683217);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100683218);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/ProjectM.<>c__DisplayClass_PrepareArchetypeJobData/ProjectM.RunWithoutJobSystem_00004717$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059124, XrefRangeEnd = 1059138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059138, XrefRangeEnd = 1059156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059156, XrefRangeEnd = 1059171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1059198, RefRangeEnd = 1059199, XrefRangeStart = 1059171, XrefRangeEnd = 1059198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData>.NativeClassPtr, "RunWithoutJobSystem_00004717$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683219);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683220);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683221);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683222);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683224);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/ProjectM.<>c__DisplayClass_PrepareNonPersistentArchetypeJobData")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_PrepareNonPersistentArchetypeJobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypeChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_archetypesWithChunkCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass52_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass52_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass52_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeArray<EntityArchetype> archetypes;
      [FieldOffset(16)]
      public NativeList<ArchetypeChunk> archetypeChunks;
      [FieldOffset(32)]
      public EntityManager entityManager;
      [FieldOffset(40)]
      public NativeList<SerializePersistenceSystemV2.ArchetypeWithChunkCount> archetypesWithChunkCount;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059310, XrefRangeEnd = 1059318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1059318, RefRangeEnd = 1059320, XrefRangeStart = 1059318, XrefRangeEnd = 1059318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SerializePersistenceSystemV2.__c__DisplayClass52_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass52_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1059320, RefRangeEnd = 1059322, XrefRangeStart = 1059320, XrefRangeEnd = 1059320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SerializePersistenceSystemV2.__c__DisplayClass52_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass52_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059323, RefRangeEnd = 1059324, XrefRangeStart = 1059322, XrefRangeEnd = 1059323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059325, RefRangeEnd = 1059326, XrefRangeStart = 1059324, XrefRangeEnd = 1059325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SerializePersistenceSystemV2 componentSystem,
        ref SerializePersistenceSystemV2.__c__DisplayClass52_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass52_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059326, XrefRangeEnd = 1059330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1059427, RefRangeEnd = 1059428, XrefRangeStart = 1059330, XrefRangeEnd = 1059427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PrepareNonPersistentArchetypeJobData()
      {
        Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2>.NativeClassPtr, "<>c__DisplayClass_PrepareNonPersistentArchetypeJobData");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, nameof (archetypes));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_archetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, nameof (archetypeChunks));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, nameof (entityManager));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_archetypesWithChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, nameof (archetypesWithChunkCount));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, 100683225);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass52_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, 100683226);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass52_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, 100683227);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, 100683228);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializePersistenceSystemV2_byref___c__DisplayClass52_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, 100683229);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, 100683230);
        SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, 100683231);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/ProjectM.<>c__DisplayClass_PrepareNonPersistentArchetypeJobData/ProjectM.RunWithoutJobSystem_0000471D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, "RunWithoutJobSystem_0000471D$PostfixBurstDelegate");
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100683232);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100683233);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100683234);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100683235);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SerializePersistenceSystemV2/ProjectM.<>c__DisplayClass_PrepareNonPersistentArchetypeJobData/ProjectM.RunWithoutJobSystem_0000471D$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059235, XrefRangeEnd = 1059249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059249, XrefRangeEnd = 1059267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059267, XrefRangeEnd = 1059282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1059309, RefRangeEnd = 1059310, XrefRangeStart = 1059282, XrefRangeEnd = 1059309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData>.NativeClassPtr, "RunWithoutJobSystem_0000471D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683236);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683237);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683238);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683239);
          SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100683241);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SerializePersistenceSystemV2.__c__DisplayClass_PrepareNonPersistentArchetypeJobData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
